#define DEBUG
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace HydroTrain;

[DesignerGenerated]
public class USBOPTORLY816 : Form
{
	private class PDUCommon
	{
		internal bool _valid;

		internal bool _complete;

		internal byte[] _data;

		public PDUCommon()
		{
			_valid = false;
			_complete = false;
		}

		public bool isComplete()
		{
			return _complete;
		}

		public bool isValid()
		{
			return _valid;
		}

		public int FindByte(byte needle, ref List<byte> someData, ref object someDataLock)
		{
			Monitor.Enter(RuntimeHelpers.GetObjectValue(someDataLock));
			int result = someData.IndexOf(needle);
			Monitor.Exit(RuntimeHelpers.GetObjectValue(someDataLock));
			return result;
		}

		public byte[] GetBytes(byte needle, ref List<byte> someData, ref object someDataLock)
		{
			byte[] result = null;
			Monitor.Enter(RuntimeHelpers.GetObjectValue(someDataLock));
			int num = someData.IndexOf(needle);
			if (num >= 0)
			{
				num = checked(num + 1);
				result = someData.GetRange(0, num).ToArray();
				someData.RemoveRange(0, num);
			}
			Monitor.Exit(RuntimeHelpers.GetObjectValue(someDataLock));
			return result;
		}

		public byte[] GetBytes(ref List<byte> someData, ref object someDataLock, int count)
		{
			byte[] result = null;
			if (someData.Count >= count && count > 0)
			{
				Monitor.Enter(RuntimeHelpers.GetObjectValue(someDataLock));
				result = someData.GetRange(0, count).ToArray();
				someData.RemoveRange(0, count);
				Monitor.Exit(RuntimeHelpers.GetObjectValue(someDataLock));
			}
			return result;
		}

		public byte[] GetAllBytes(ref List<byte> someData, ref object someDataLock)
		{
			byte[] result = null;
			if (someData.Count > 0)
			{
				Monitor.Enter(RuntimeHelpers.GetObjectValue(someDataLock));
				result = someData.GetRange(0, someData.Count).ToArray();
				someData.RemoveRange(0, someData.Count);
				Monitor.Exit(RuntimeHelpers.GetObjectValue(someDataLock));
			}
			return result;
		}

		public int FlushBuffer(ref List<byte> someData, ref object someDataLock, bool getBytes = false)
		{
			int result = 0;
			if (someData.Count > 0)
			{
				Monitor.Enter(RuntimeHelpers.GetObjectValue(someDataLock));
				result = someData.Count;
				if (getBytes)
				{
					_data = someData.GetRange(0, someData.Count).ToArray();
				}
				someData.Clear();
				Monitor.Exit(RuntimeHelpers.GetObjectValue(someDataLock));
			}
			return result;
		}
	}

	private class LinePDU : PDUCommon
	{
		public string Data;

		private const byte lineTerm = 10;

		public LinePDU(ref List<byte> someData, ref object someDataLock)
		{
			Data = "";
			byte[] bytes = GetBytes(10, ref someData, ref someDataLock);
			if (bytes != null)
			{
				Data = new string(Encoding.GetEncoding(28591).GetChars(bytes, 0, bytes.Length));
				_complete = true;
				_valid = true;
			}
		}

		public int DataLength()
		{
			return Data.Length;
		}
	}

	private class ComplexDeviceProto : PDUCommon
	{
		public string Data;

		public int ID;

		private const byte stx = 2;

		public ComplexDeviceProto(ref List<byte> someData, ref object someDataLock)
		{
			Data = "";
			ID = int.MinValue;
			bool flag = true;
			Monitor.Enter(RuntimeHelpers.GetObjectValue(someDataLock));
			while (someData.Count > 0 && someData[0] != 2)
			{
				someData.RemoveAt(0);
				if (flag)
				{
					Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.f") + " Write Data Error");
					flag = false;
				}
			}
			checked
			{
				if (someData.Count >= 6 && someData.Count >= 7 + someData[5])
				{
					byte[] array = someData.GetRange(0, 7 + someData[5]).ToArray();
					someData.RemoveRange(0, 7 + someData[5]);
					Monitor.Exit(RuntimeHelpers.GetObjectValue(someDataLock));
					int num = 6 + (array[5] - 1);
					int num2 = default(int);
					for (int i = 6; i <= num; i++)
					{
						num2 ^= array[i];
					}
					if (num2 == array[6 + array[5]])
					{
						ID = BitConverter.ToInt32(array, 1);
						Data = new string(Encoding.GetEncoding(28591).GetChars(array, 6, array[5]));
						_complete = true;
						_valid = true;
					}
					else
					{
						Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.f") + " CRC Error");
					}
				}
				if (Monitor.IsEntered(RuntimeHelpers.GetObjectValue(someDataLock)))
				{
					Monitor.Exit(RuntimeHelpers.GetObjectValue(someDataLock));
				}
			}
		}

		public int DataLength()
		{
			return Data.Length;
		}
	}

	public delegate void SetTextCallback(string text);

	public delegate void SetTimerEnable(bool enable);

	private delegate void AppendTextBoxDelegate(TextBox TB, string txt);

	private delegate void AppendLabelDelegate(Label LB, string txt);

	public delegate void MyInt88ChangedEventHandler(string newTOT88_CLIP);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MotorSwitchTM")]
	private System.Windows.Forms.Timer _MotorSwitchTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CoolingFanTM")]
	private System.Windows.Forms.Timer _CoolingFanTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VoltsStableTM")]
	private System.Windows.Forms.Timer _VoltsStableTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Invisible")]
	private Button _Invisible;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay7")]
	private Button _Relay7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay6")]
	private Button _Relay6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay5")]
	private Button _Relay5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay4")]
	private Button _Relay4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay3")]
	private Button _Relay3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay2")]
	private Button _Relay2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RelayOverideSw")]
	private Button _RelayOverideSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay1")]
	private Button _Relay1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay8")]
	private Button _Relay8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsNoBoardLb")]
	private Label _CommsNoBoardLb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsNoBoard")]
	private TextBox _CommsNoBoard;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WriteDataTM")]
	private System.Windows.Forms.Timer _WriteDataTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InputsOverideSw")]
	private Button _InputsOverideSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IN8")]
	private Button _IN8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IN7")]
	private Button _IN7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IN6")]
	private Button _IN6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IN5")]
	private Button _IN5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IN4")]
	private Button _IN4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IN3")]
	private Button _IN3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IN2")]
	private Button _IN2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IN1")]
	private Button _IN1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_comport")]
	private ComboBox _ComboBox_comport;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsResetTM")]
	private System.Windows.Forms.Timer _CommsResetTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mySerialPort")]
	private SerialPort _mySerialPort;

	private List<byte> RcvBuffer;

	private object rcvBufLock;

	private ManualResetEvent runThreads;

	private Thread rcvThrd;

	private AutoResetEvent rcvARE;

	private Thread protoThrd;

	private AutoResetEvent protoARE;

	private Thread pinserrorsThrd;

	private AutoResetEvent pinsErrorsARE;

	private ConcurrentQueue<object> PinsErrorsQ;

	private const int TimerMin = 60000;

	private const int TimerSec = 1000;

	private int RcvReadCT;

	private bool RcvError;

	private bool RcvInstr;

	private long RcvDRECT;

	private long RcvDREEofs;

	private long RcvByteTot;

	private long RcvMultiRead;

	private long RcvNoData;

	private Stopwatch RcvThrdTime;

	private Stopwatch RcvBuffAddTime;

	public static bool CommsActive;

	public static bool SandBoxOnOff;

	public static bool SandBoxPushSw;

	public static bool BackwashShort;

	public static bool BackwashLong;

	public static bool Backwash;

	public static int CirculationTMI;

	public static int CirculationDelayTMI;

	public static bool FillPump;

	public static bool EmptyPump;

	public static bool FillEmptyCirc;

	private double OperatingTemp;

	private bool EmptyPumpTell;

	private bool FillPumpTell;

	private bool RemoteWaterDN;

	private bool RemoteWaterUP;

	private bool RemoteSpeedDN;

	private bool RemoteSpeedUP;

	private bool RemoteGradientDN;

	private bool RemoteGradientUP;

	private bool BackwashCont;

	private int Software;

	public static bool CleanWaterEmpty;

	public static bool CirculationPumpError;

	public static bool UVCLamp;

	public static bool CleanCirculation;

	public static bool Heater;

	public static byte CirculationErrorCount;

	public static bool Circulation;

	public static bool LiftCCW;

	public static bool LiftError;

	public static bool Movement;

	public static float MoveCount;

	public static bool LiftMaxHeight;

	public static bool LiftZeroHeight;

	public static bool LiftLGHeight;

	public static bool LiftLowHeight;

	private bool LiftSpeed1;

	private bool LiftSpeed2;

	private bool WaitFlag;

	private int ReadReg;

	public bool BoardError;

	private bool BoardCheck;

	private string ReturnType;

	private static byte[] serBuf = new byte[21];

	private byte Num;

	private static bool NewData;

	private byte PortIndex;

	private byte RegPort;

	private bool SendOutputSpeed;

	private bool SendOutputIncline;

	private string Port;

	private bool PortOk;

	private string ReceivedText;

	private string textIn;

	public byte TypeCheck;

	private string DataReceivedBoard;

	private byte InputOveride;

	private bool InputOverideSw;

	private bool DataReceived;

	private bool CommsOK;

	public static bool VoltageOK;

	private string Indicator;

	private string ItemName;

	private int ControlLevel;

	private int CommCheck;

	public bool EmergencyStopActive;

	public static bool RelayOveride;

	public static bool Relay8On;

	public static bool Relay7On;

	public static bool Relay6On;

	public static bool Relay5On;

	public static bool Relay4On;

	public static bool Relay3On;

	public static bool Relay2On;

	public static bool Relay1On;

	public static int MotorIndex = 1;

	public static bool MotorSent = false;

	public static bool[] MotorSwitch = new bool[9];

	private static bool SandBoxInd;

	private static bool SandBoxFlash;

	private static bool MotorOnOff;

	private static bool MotorsOff;

	public bool JetONOff;

	public bool AirReleaseEmpty;

	public bool AirReleaseEmptyDelay;

	public bool AirReleaseFill;

	public bool AirReleaseFillDelay;

	private static bool CoolingFan;

	public bool EmergencyStopSet;

	public bool HeaterInput;

	public byte InclinePositionAdd;

	public bool CirculationInput;

	public byte InclineFaultAdd;

	public bool ReadWriteFlag;

	private bool EmergencyPush;

	public System.Threading.Timer InfoEnterTM;

	private static Random prng = new Random();

	private int minMessSz;

	private bool slow;

	public System.Threading.Timer SandBoxPushSwTM;

	public static System.Threading.Timer CirculationTM;

	public System.Threading.Timer CirculationDelayTM;

	public System.Threading.Timer CirculationCheckPumpTM;

	[SpecialName]
	private Task _0024STATIC_0024Form1_FormClosing_002420211C12825_0024t;

	internal virtual System.Windows.Forms.Timer MotorSwitchTM
	{
		[CompilerGenerated]
		get
		{
			return _MotorSwitchTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MotorSwitchTM_Tick;
			System.Windows.Forms.Timer timer = _MotorSwitchTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_MotorSwitchTM = value;
			timer = _MotorSwitchTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer CoolingFanTM
	{
		[CompilerGenerated]
		get
		{
			return _CoolingFanTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CoolingFanTM_Tick;
			System.Windows.Forms.Timer timer = _CoolingFanTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_CoolingFanTM = value;
			timer = _CoolingFanTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer VoltsStableTM
	{
		[CompilerGenerated]
		get
		{
			return _VoltsStableTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = VoltsStableTM_Tick;
			System.Windows.Forms.Timer timer = _VoltsStableTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_VoltsStableTM = value;
			timer = _VoltsStableTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SerialAddress")]
	internal virtual ListBox SerialAddress
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OKVolts")]
	internal virtual TextBox OKVolts
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsResetInd")]
	internal virtual TextBox CommsResetInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TitleName")]
	internal virtual Label TitleName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Invisible
	{
		[CompilerGenerated]
		get
		{
			return _Invisible;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Invisible_Click;
			Button button = _Invisible;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Invisible = value;
			button = _Invisible;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TypeNo")]
	internal virtual TextBox TypeNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("VoltsLB")]
	internal virtual Label VoltsLB
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Volts")]
	internal virtual TextBox Volts
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Relay7
	{
		[CompilerGenerated]
		get
		{
			return _Relay7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Relay7_Click;
			Button button = _Relay7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Relay7 = value;
			button = _Relay7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Relay6
	{
		[CompilerGenerated]
		get
		{
			return _Relay6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Relay6_Click;
			Button button = _Relay6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Relay6 = value;
			button = _Relay6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Relay5
	{
		[CompilerGenerated]
		get
		{
			return _Relay5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Relay5_Click;
			Button button = _Relay5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Relay5 = value;
			button = _Relay5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Relay4
	{
		[CompilerGenerated]
		get
		{
			return _Relay4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Relay4_Click;
			Button button = _Relay4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Relay4 = value;
			button = _Relay4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Relay3
	{
		[CompilerGenerated]
		get
		{
			return _Relay3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Relay3_Click;
			Button button = _Relay3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Relay3 = value;
			button = _Relay3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Relay2
	{
		[CompilerGenerated]
		get
		{
			return _Relay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Relay2_Click;
			Button button = _Relay2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Relay2 = value;
			button = _Relay2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button RelayOverideSw
	{
		[CompilerGenerated]
		get
		{
			return _RelayOverideSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RelayOverideSw_Click;
			Button button = _RelayOverideSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_RelayOverideSw = value;
			button = _RelayOverideSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Relay1
	{
		[CompilerGenerated]
		get
		{
			return _Relay1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Relay1_Click;
			Button button = _Relay1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Relay1 = value;
			button = _Relay1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Relay8
	{
		[CompilerGenerated]
		get
		{
			return _Relay8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Relay8_Click;
			Button button = _Relay8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Relay8 = value;
			button = _Relay8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OutputData")]
	internal virtual TextBox OutputData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InputData")]
	internal virtual TextBox InputData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label CommsNoBoardLb
	{
		[CompilerGenerated]
		get
		{
			return _CommsNoBoardLb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsNoBoardLb_Click;
			Label label = _CommsNoBoardLb;
			if (label != null)
			{
				label.Click -= value2;
			}
			_CommsNoBoardLb = value;
			label = _CommsNoBoardLb;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox CommsNoBoard
	{
		[CompilerGenerated]
		get
		{
			return _CommsNoBoard;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsNoBoard_Click;
			TextBox textBox = _CommsNoBoard;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_CommsNoBoard = value;
			textBox = _CommsNoBoard;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("IdentNo")]
	internal virtual TextBox IdentNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Send")]
	internal virtual TextBox Send
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ReceivedData")]
	public virtual TextBox ReceivedData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ErrorReporting")]
	internal virtual TextBox ErrorReporting
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer WriteDataTM
	{
		[CompilerGenerated]
		get
		{
			return _WriteDataTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WriteDataTM_Tick;
			System.Windows.Forms.Timer timer = _WriteDataTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_WriteDataTM = value;
			timer = _WriteDataTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("MessageBox")]
	public virtual TextBox MessageBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button InputsOverideSw
	{
		[CompilerGenerated]
		get
		{
			return _InputsOverideSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OverrideInputs_Click;
			Button button = _InputsOverideSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_InputsOverideSw = value;
			button = _InputsOverideSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button IN8
	{
		[CompilerGenerated]
		get
		{
			return _IN8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IN1_Click;
			Button button = _IN8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_IN8 = value;
			button = _IN8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button IN7
	{
		[CompilerGenerated]
		get
		{
			return _IN7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IN1_Click;
			Button button = _IN7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_IN7 = value;
			button = _IN7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button IN6
	{
		[CompilerGenerated]
		get
		{
			return _IN6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IN1_Click;
			Button button = _IN6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_IN6 = value;
			button = _IN6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button IN5
	{
		[CompilerGenerated]
		get
		{
			return _IN5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IN1_Click;
			Button button = _IN5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_IN5 = value;
			button = _IN5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button IN4
	{
		[CompilerGenerated]
		get
		{
			return _IN4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IN1_Click;
			Button button = _IN4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_IN4 = value;
			button = _IN4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button IN3
	{
		[CompilerGenerated]
		get
		{
			return _IN3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IN1_Click;
			Button button = _IN3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_IN3 = value;
			button = _IN3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button IN2
	{
		[CompilerGenerated]
		get
		{
			return _IN2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IN1_Click;
			Button button = _IN2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_IN2 = value;
			button = _IN2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button IN1
	{
		[CompilerGenerated]
		get
		{
			return _IN1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IN1_Click;
			Button button = _IN1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_IN1 = value;
			button = _IN1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SoftwareVer")]
	internal virtual TextBox SoftwareVer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox_comport
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox_comport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox_comport_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox_comport;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox_comport = value;
			comboBox = _ComboBox_comport;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer CommsResetTM
	{
		[CompilerGenerated]
		get
		{
			return _CommsResetTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsResetTM_Tick;
			System.Windows.Forms.Timer timer = _CommsResetTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_CommsResetTM = value;
			timer = _CommsResetTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	private virtual SerialPort mySerialPort
	{
		[CompilerGenerated]
		get
		{
			return _mySerialPort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			SerialDataReceivedEventHandler value2 = mySerialPort_DataReceived;
			SerialErrorReceivedEventHandler value3 = mySerialPort_ErrorReceived;
			SerialPinChangedEventHandler value4 = mySerialPort_PinChanged;
			SerialPort serialPort = _mySerialPort;
			if (serialPort != null)
			{
				serialPort.DataReceived -= value2;
				serialPort.ErrorReceived -= value3;
				serialPort.PinChanged -= value4;
			}
			_mySerialPort = value;
			serialPort = _mySerialPort;
			if (serialPort != null)
			{
				serialPort.DataReceived += value2;
				serialPort.ErrorReceived += value3;
				serialPort.PinChanged += value4;
			}
		}
	}

	public string TOT88_CLIP
	{
		get
		{
			string result = default(string);
			return result;
		}
		set
		{
			if (Strings.Len(value) > 0)
			{
				ReadDataReceived(value);
			}
			MyInt88Changed?.Invoke(value);
		}
	}

	public event MyInt88ChangedEventHandler MyInt88Changed;

	public USBOPTORLY816()
	{
		base.FormClosing += Form1_FormClosing;
		base.Load += Form_Load;
		base.Activated += Board_Activated;
		base.Shown += Form1_Shown;
		mySerialPort = new SerialPort();
		RcvBuffer = new List<byte>();
		rcvBufLock = RuntimeHelpers.GetObjectValue(new object());
		runThreads = new ManualResetEvent(initialState: false);
		rcvARE = new AutoResetEvent(initialState: false);
		protoARE = new AutoResetEvent(initialState: false);
		pinsErrorsARE = new AutoResetEvent(initialState: false);
		PinsErrorsQ = new ConcurrentQueue<object>();
		RcvReadCT = 0;
		RcvError = false;
		RcvInstr = true;
		RcvDRECT = 0L;
		RcvDREEofs = 0L;
		RcvByteTot = 0L;
		RcvMultiRead = 0L;
		RcvNoData = 0L;
		RcvThrdTime = new Stopwatch();
		RcvBuffAddTime = new Stopwatch();
		ReadReg = 0;
		Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, 0.ToString());
		slow = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		this.MotorSwitchTM = new System.Windows.Forms.Timer(this.components);
		this.CoolingFanTM = new System.Windows.Forms.Timer(this.components);
		this.VoltsStableTM = new System.Windows.Forms.Timer(this.components);
		this.SerialAddress = new System.Windows.Forms.ListBox();
		this.OKVolts = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.CommsResetInd = new System.Windows.Forms.TextBox();
		this.TitleName = new System.Windows.Forms.Label();
		this.Invisible = new System.Windows.Forms.Button();
		this.Label17 = new System.Windows.Forms.Label();
		this.TypeNo = new System.Windows.Forms.TextBox();
		this.VoltsLB = new System.Windows.Forms.Label();
		this.Volts = new System.Windows.Forms.TextBox();
		this.Relay7 = new System.Windows.Forms.Button();
		this.Relay6 = new System.Windows.Forms.Button();
		this.Relay5 = new System.Windows.Forms.Button();
		this.Relay4 = new System.Windows.Forms.Button();
		this.Relay3 = new System.Windows.Forms.Button();
		this.Relay2 = new System.Windows.Forms.Button();
		this.RelayOverideSw = new System.Windows.Forms.Button();
		this.Relay1 = new System.Windows.Forms.Button();
		this.Relay8 = new System.Windows.Forms.Button();
		this.Label16 = new System.Windows.Forms.Label();
		this.OutputData = new System.Windows.Forms.TextBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.InputData = new System.Windows.Forms.TextBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.CommsNoBoardLb = new System.Windows.Forms.Label();
		this.CommsNoBoard = new System.Windows.Forms.TextBox();
		this.IdentNo = new System.Windows.Forms.TextBox();
		this.Send = new System.Windows.Forms.TextBox();
		this.ReceivedData = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.ErrorReporting = new System.Windows.Forms.TextBox();
		this.WriteDataTM = new System.Windows.Forms.Timer(this.components);
		this.MessageBox = new System.Windows.Forms.TextBox();
		this.InputsOverideSw = new System.Windows.Forms.Button();
		this.IN8 = new System.Windows.Forms.Button();
		this.IN7 = new System.Windows.Forms.Button();
		this.IN6 = new System.Windows.Forms.Button();
		this.IN5 = new System.Windows.Forms.Button();
		this.IN4 = new System.Windows.Forms.Button();
		this.IN3 = new System.Windows.Forms.Button();
		this.IN2 = new System.Windows.Forms.Button();
		this.IN1 = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.SoftwareVer = new System.Windows.Forms.TextBox();
		this.ComboBox_comport = new System.Windows.Forms.ComboBox();
		this.CommsResetTM = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.CoolingFanTM.Interval = 600000;
		this.VoltsStableTM.Interval = 2000;
		this.SerialAddress.FormattingEnabled = true;
		this.SerialAddress.Location = new System.Drawing.Point(25, 110);
		this.SerialAddress.Name = "SerialAddress";
		this.SerialAddress.Size = new System.Drawing.Size(76, 108);
		this.SerialAddress.TabIndex = 234;
		this.OKVolts.Location = new System.Drawing.Point(32, 334);
		this.OKVolts.Name = "OKVolts";
		this.OKVolts.Size = new System.Drawing.Size(52, 20);
		this.OKVolts.TabIndex = 233;
		this.OKVolts.Text = "Volts Off";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(26, 232);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(78, 13);
		this.Label2.TabIndex = 232;
		this.Label2.Text = "Comms  Check";
		this.CommsResetInd.Location = new System.Drawing.Point(38, 248);
		this.CommsResetInd.Name = "CommsResetInd";
		this.CommsResetInd.Size = new System.Drawing.Size(44, 20);
		this.CommsResetInd.TabIndex = 231;
		this.TitleName.AutoSize = true;
		this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TitleName.Location = new System.Drawing.Point(12, 7);
		this.TitleName.Name = "TitleName";
		this.TitleName.Size = new System.Drawing.Size(38, 20);
		this.TitleName.TabIndex = 230;
		this.TitleName.Text = "Title";
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(460, 12);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(62, 58);
		this.Invisible.TabIndex = 229;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = true;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(189, 123);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(31, 13);
		this.Label17.TabIndex = 228;
		this.Label17.Text = "Type";
		this.TypeNo.Location = new System.Drawing.Point(192, 136);
		this.TypeNo.Name = "TypeNo";
		this.TypeNo.Size = new System.Drawing.Size(126, 20);
		this.TypeNo.TabIndex = 227;
		this.VoltsLB.AutoSize = true;
		this.VoltsLB.Location = new System.Drawing.Point(29, 306);
		this.VoltsLB.Name = "VoltsLB";
		this.VoltsLB.Size = new System.Drawing.Size(30, 13);
		this.VoltsLB.TabIndex = 226;
		this.VoltsLB.Text = "Volts";
		this.VoltsLB.UseWaitCursor = true;
		this.Volts.Location = new System.Drawing.Point(63, 303);
		this.Volts.Name = "Volts";
		this.Volts.Size = new System.Drawing.Size(44, 20);
		this.Volts.TabIndex = 225;
		this.Relay7.Location = new System.Drawing.Point(428, 326);
		this.Relay7.Name = "Relay7";
		this.Relay7.Size = new System.Drawing.Size(44, 26);
		this.Relay7.TabIndex = 224;
		this.Relay7.Text = "RL7";
		this.Relay7.UseVisualStyleBackColor = true;
		this.Relay6.Location = new System.Drawing.Point(478, 286);
		this.Relay6.Name = "Relay6";
		this.Relay6.Size = new System.Drawing.Size(44, 26);
		this.Relay6.TabIndex = 223;
		this.Relay6.Text = "RL6";
		this.Relay6.UseVisualStyleBackColor = true;
		this.Relay5.Location = new System.Drawing.Point(428, 285);
		this.Relay5.Name = "Relay5";
		this.Relay5.Size = new System.Drawing.Size(44, 26);
		this.Relay5.TabIndex = 222;
		this.Relay5.Text = "RL5";
		this.Relay5.UseVisualStyleBackColor = true;
		this.Relay4.Location = new System.Drawing.Point(478, 243);
		this.Relay4.Name = "Relay4";
		this.Relay4.Size = new System.Drawing.Size(44, 26);
		this.Relay4.TabIndex = 221;
		this.Relay4.Text = "RL4";
		this.Relay4.UseVisualStyleBackColor = true;
		this.Relay3.Location = new System.Drawing.Point(428, 243);
		this.Relay3.Name = "Relay3";
		this.Relay3.Size = new System.Drawing.Size(44, 26);
		this.Relay3.TabIndex = 220;
		this.Relay3.Text = "RL3";
		this.Relay3.UseVisualStyleBackColor = true;
		this.Relay2.Location = new System.Drawing.Point(478, 203);
		this.Relay2.Name = "Relay2";
		this.Relay2.Size = new System.Drawing.Size(44, 26);
		this.Relay2.TabIndex = 219;
		this.Relay2.Text = "RL2";
		this.Relay2.UseVisualStyleBackColor = true;
		this.RelayOverideSw.Location = new System.Drawing.Point(428, 163);
		this.RelayOverideSw.Name = "RelayOverideSw";
		this.RelayOverideSw.Size = new System.Drawing.Size(94, 26);
		this.RelayOverideSw.TabIndex = 218;
		this.RelayOverideSw.Text = "Relays";
		this.RelayOverideSw.UseVisualStyleBackColor = true;
		this.Relay1.Location = new System.Drawing.Point(428, 203);
		this.Relay1.Name = "Relay1";
		this.Relay1.Size = new System.Drawing.Size(44, 26);
		this.Relay1.TabIndex = 217;
		this.Relay1.Text = "RL1";
		this.Relay1.UseVisualStyleBackColor = true;
		this.Relay8.Location = new System.Drawing.Point(478, 326);
		this.Relay8.Name = "Relay8";
		this.Relay8.Size = new System.Drawing.Size(44, 26);
		this.Relay8.TabIndex = 216;
		this.Relay8.Text = "RL8";
		this.Relay8.UseVisualStyleBackColor = true;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(122, 205);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(44, 13);
		this.Label16.TabIndex = 215;
		this.Label16.Text = "Outputs";
		this.Label16.UseWaitCursor = true;
		this.OutputData.Location = new System.Drawing.Point(125, 220);
		this.OutputData.Multiline = true;
		this.OutputData.Name = "OutputData";
		this.OutputData.Size = new System.Drawing.Size(225, 22);
		this.OutputData.TabIndex = 214;
		this.OutputData.Text = "Data";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(122, 320);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(53, 13);
		this.Label15.TabIndex = 213;
		this.Label15.Text = "Recieved";
		this.Label15.UseWaitCursor = true;
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(191, 159);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(36, 13);
		this.Label14.TabIndex = 212;
		this.Label14.Text = "Inputs";
		this.Label14.UseWaitCursor = true;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(126, 247);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(29, 13);
		this.Label13.TabIndex = 211;
		this.Label13.Text = "Sent";
		this.InputData.Location = new System.Drawing.Point(123, 179);
		this.InputData.Multiline = true;
		this.InputData.Name = "InputData";
		this.InputData.Size = new System.Drawing.Size(225, 22);
		this.InputData.TabIndex = 210;
		this.InputData.Text = "Data";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(189, 79);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(31, 13);
		this.Label11.TabIndex = 209;
		this.Label11.Text = "Ident";
		this.CommsNoBoardLb.AutoSize = true;
		this.CommsNoBoardLb.Location = new System.Drawing.Point(23, 83);
		this.CommsNoBoardLb.Name = "CommsNoBoardLb";
		this.CommsNoBoardLb.Size = new System.Drawing.Size(28, 13);
		this.CommsNoBoardLb.TabIndex = 208;
		this.CommsNoBoardLb.Text = "Com";
		this.CommsNoBoard.Location = new System.Drawing.Point(57, 80);
		this.CommsNoBoard.Name = "CommsNoBoard";
		this.CommsNoBoard.Size = new System.Drawing.Size(44, 20);
		this.CommsNoBoard.TabIndex = 207;
		this.IdentNo.Location = new System.Drawing.Point(192, 95);
		this.IdentNo.Name = "IdentNo";
		this.IdentNo.Size = new System.Drawing.Size(126, 20);
		this.IdentNo.TabIndex = 206;
		this.Send.Location = new System.Drawing.Point(123, 260);
		this.Send.Multiline = true;
		this.Send.Name = "Send";
		this.Send.Size = new System.Drawing.Size(225, 60);
		this.Send.TabIndex = 205;
		this.ReceivedData.Location = new System.Drawing.Point(121, 334);
		this.ReceivedData.Multiline = true;
		this.ReceivedData.Name = "ReceivedData";
		this.ReceivedData.Size = new System.Drawing.Size(225, 60);
		this.ReceivedData.TabIndex = 204;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(272, 12);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(65, 13);
		this.Label1.TabIndex = 203;
		this.Label1.Text = "Relay Board";
		this.ErrorReporting.Location = new System.Drawing.Point(275, 28);
		this.ErrorReporting.Multiline = true;
		this.ErrorReporting.Name = "ErrorReporting";
		this.ErrorReporting.Size = new System.Drawing.Size(143, 61);
		this.ErrorReporting.TabIndex = 202;
		this.ErrorReporting.Text = "No Error";
		this.WriteDataTM.Enabled = true;
		this.WriteDataTM.Interval = 75;
		this.MessageBox.Location = new System.Drawing.Point(121, 400);
		this.MessageBox.Multiline = true;
		this.MessageBox.Name = "MessageBox";
		this.MessageBox.Size = new System.Drawing.Size(225, 33);
		this.MessageBox.TabIndex = 235;
		this.InputsOverideSw.Location = new System.Drawing.Point(354, 105);
		this.InputsOverideSw.Name = "InputsOverideSw";
		this.InputsOverideSw.Size = new System.Drawing.Size(68, 26);
		this.InputsOverideSw.TabIndex = 244;
		this.InputsOverideSw.Text = "Inputs";
		this.InputsOverideSw.UseVisualStyleBackColor = true;
		this.IN8.Location = new System.Drawing.Point(365, 385);
		this.IN8.Name = "IN8";
		this.IN8.Size = new System.Drawing.Size(44, 26);
		this.IN8.TabIndex = 243;
		this.IN8.Text = "IN8";
		this.IN8.UseVisualStyleBackColor = true;
		this.IN7.Location = new System.Drawing.Point(365, 350);
		this.IN7.Name = "IN7";
		this.IN7.Size = new System.Drawing.Size(44, 26);
		this.IN7.TabIndex = 242;
		this.IN7.Text = "IN7";
		this.IN7.UseVisualStyleBackColor = true;
		this.IN6.Location = new System.Drawing.Point(365, 315);
		this.IN6.Name = "IN6";
		this.IN6.Size = new System.Drawing.Size(44, 26);
		this.IN6.TabIndex = 241;
		this.IN6.Text = "IN6";
		this.IN6.UseVisualStyleBackColor = true;
		this.IN5.Location = new System.Drawing.Point(365, 280);
		this.IN5.Name = "IN5";
		this.IN5.Size = new System.Drawing.Size(44, 26);
		this.IN5.TabIndex = 240;
		this.IN5.Text = "IN5";
		this.IN5.UseVisualStyleBackColor = true;
		this.IN4.Location = new System.Drawing.Point(365, 245);
		this.IN4.Name = "IN4";
		this.IN4.Size = new System.Drawing.Size(44, 26);
		this.IN4.TabIndex = 239;
		this.IN4.Text = "IN4";
		this.IN4.UseVisualStyleBackColor = true;
		this.IN3.Location = new System.Drawing.Point(365, 210);
		this.IN3.Name = "IN3";
		this.IN3.Size = new System.Drawing.Size(44, 26);
		this.IN3.TabIndex = 238;
		this.IN3.Text = "IN3";
		this.IN3.UseVisualStyleBackColor = true;
		this.IN2.Location = new System.Drawing.Point(365, 175);
		this.IN2.Name = "IN2";
		this.IN2.Size = new System.Drawing.Size(44, 26);
		this.IN2.TabIndex = 237;
		this.IN2.Text = "IN2";
		this.IN2.UseVisualStyleBackColor = true;
		this.IN1.Location = new System.Drawing.Point(365, 140);
		this.IN1.Name = "IN1";
		this.IN1.Size = new System.Drawing.Size(44, 26);
		this.IN1.TabIndex = 236;
		this.IN1.Text = "IN1";
		this.IN1.UseVisualStyleBackColor = true;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(189, 37);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(49, 13);
		this.Label3.TabIndex = 246;
		this.Label3.Text = "Software";
		this.SoftwareVer.Location = new System.Drawing.Point(192, 53);
		this.SoftwareVer.Name = "SoftwareVer";
		this.SoftwareVer.Size = new System.Drawing.Size(50, 20);
		this.SoftwareVer.TabIndex = 245;
		this.ComboBox_comport.CausesValidation = false;
		this.ComboBox_comport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ComboBox_comport.FormattingEnabled = true;
		this.ComboBox_comport.Location = new System.Drawing.Point(12, 38);
		this.ComboBox_comport.Name = "ComboBox_comport";
		this.ComboBox_comport.Size = new System.Drawing.Size(171, 32);
		this.ComboBox_comport.TabIndex = 247;
		this.ComboBox_comport.Text = "Select COM port";
		this.CommsResetTM.Interval = 400;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(554, 481);
		base.ControlBox = false;
		base.Controls.Add(this.ComboBox_comport);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.SoftwareVer);
		base.Controls.Add(this.InputsOverideSw);
		base.Controls.Add(this.IN8);
		base.Controls.Add(this.IN7);
		base.Controls.Add(this.IN6);
		base.Controls.Add(this.IN5);
		base.Controls.Add(this.IN4);
		base.Controls.Add(this.IN3);
		base.Controls.Add(this.IN2);
		base.Controls.Add(this.IN1);
		base.Controls.Add(this.MessageBox);
		base.Controls.Add(this.SerialAddress);
		base.Controls.Add(this.OKVolts);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.CommsResetInd);
		base.Controls.Add(this.TitleName);
		base.Controls.Add(this.Invisible);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.TypeNo);
		base.Controls.Add(this.VoltsLB);
		base.Controls.Add(this.Volts);
		base.Controls.Add(this.Relay7);
		base.Controls.Add(this.Relay6);
		base.Controls.Add(this.Relay5);
		base.Controls.Add(this.Relay4);
		base.Controls.Add(this.Relay3);
		base.Controls.Add(this.Relay2);
		base.Controls.Add(this.RelayOverideSw);
		base.Controls.Add(this.Relay1);
		base.Controls.Add(this.Relay8);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.OutputData);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.InputData);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.CommsNoBoardLb);
		base.Controls.Add(this.CommsNoBoard);
		base.Controls.Add(this.IdentNo);
		base.Controls.Add(this.Send);
		base.Controls.Add(this.ReceivedData);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ErrorReporting);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "USBOPTORLY816";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "USBOPTORLY816";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
	{
		checked
		{
			if (e.EventType == SerialData.Eof)
			{
				if (RcvInstr)
				{
					RcvDREEofs++;
				}
				return;
			}
			rcvARE.Set();
			if (RcvInstr)
			{
				RcvDRECT++;
			}
		}
	}

	private void mySerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
	{
		PinsErrorsQ.Enqueue(e);
		pinsErrorsARE.Set();
	}

	private void mySerialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
	{
		PinsErrorsQ.Enqueue(e);
		pinsErrorsARE.Set();
	}

	private void Receive()
	{
		checked
		{
			while (true)
			{
				if (mySerialPort.IsOpen && mySerialPort.BytesToRead > 0)
				{
					if (RcvInstr)
					{
						RcvThrdTime.Start();
					}
					RcvError = false;
					try
					{
						switch (ReturnType)
						{
						case "Ident":
							ReceivedText = mySerialPort.ReadExisting();
							break;
						case "Type":
						{
							if (mySerialPort.BytesToRead > 0)
							{
								ReceivedText = mySerialPort.ReadByte().ToString();
								Software = mySerialPort.ReadByte();
							}
							string text = mySerialPort.ReadExisting();
							break;
						}
						case "Volts":
						{
							if (mySerialPort.BytesToRead > 0)
							{
								ReceivedText = mySerialPort.ReadByte().ToString();
							}
							string text = mySerialPort.ReadExisting();
							break;
						}
						case "Setup":
						{
							if (mySerialPort.BytesToRead > 0)
							{
								ReceivedText = mySerialPort.ReadByte().ToString();
							}
							string text = mySerialPort.ReadExisting();
							break;
						}
						case "Outputs":
						{
							int num3 = 0;
							int num4 = mySerialPort.BytesToRead - 1;
							for (num3 = 0; num3 <= num4; num3++)
							{
								try
								{
									mySerialPort.Read(serBuf, num3, 1);
									if (num3 < 1)
									{
										ReceivedText += Conversion.Val(serBuf[num3]);
									}
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									ProjectData.ClearProjectError();
								}
							}
							string text = mySerialPort.ReadExisting();
							break;
						}
						case "Inputs":
						{
							int num = 0;
							int num2 = mySerialPort.BytesToRead - 1;
							for (num = 0; num <= num2; num++)
							{
								try
								{
									mySerialPort.Read(serBuf, num, 1);
									if (num < 1)
									{
										ReceivedText += Conversion.Val(serBuf[num]);
									}
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ProjectData.ClearProjectError();
								}
							}
							string text = mySerialPort.ReadExisting();
							break;
						}
						}
						TOT88_CLIP = ReceivedText;
						ReceivedText = "";
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception item = ex5;
						RcvError = true;
						PinsErrorsQ.Enqueue(item);
						pinsErrorsARE.Set();
						ProjectData.ClearProjectError();
					}
					if (RcvInstr)
					{
						RcvThrdTime.Stop();
					}
				}
				else
				{
					rcvARE.WaitOne();
					if (!runThreads.WaitOne(0))
					{
						break;
					}
				}
			}
		}
	}

	private void PinsAndErrors()
	{
		while (true)
		{
			if (PinsErrorsQ.Count > 0)
			{
				if (PinsErrorsQ.TryDequeue(out var result))
				{
					if (result is SerialErrorReceivedEventArgs)
					{
						SerialErrorReceivedEventArgs e = (SerialErrorReceivedEventArgs)result;
						SerialErrorReceivedEventArgs e2 = e;
						Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.f") + " " + e.EventType);
						switch (e.EventType)
						{
						case SerialError.Overrun:
							mySerialPort.DiscardInBuffer();
							break;
						}
					}
					else if (result is SerialPinChangedEventArgs)
					{
						SerialPinChangedEventArgs e3 = (SerialPinChangedEventArgs)result;
						SerialPinChangedEventArgs e4 = e3;
						Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.f") + " " + e3.EventType);
					}
					else if (result is Exception)
					{
						Exception ex = (Exception)result;
						Exception ex2 = ex;
						Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.f") + " " + ex.InnerException.Message);
					}
				}
				else
				{
					Thread.Sleep(10);
				}
			}
			else
			{
				pinsErrorsARE.WaitOne();
				if (!runThreads.WaitOne(0))
				{
					break;
				}
			}
		}
	}

	private void SerialPortOpen()
	{
		if (!mySerialPort.IsOpen)
		{
			StartSerialPortThreads();
			Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, 0.ToString());
			if (Conversion.Val(Port) > 0.0)
			{
				AppendTextBox(CommsNoBoard, Interaction.GetSetting("Health", "Setup", "Port" + base.Name, 0.ToString()));
				GetSerialPortNames();
				Display.RLY816Startup = false;
				CommsNoBoard.BackColor = Color.Green;
				CommsActive = true;
				mySerialPort.PortName = "Com" + Port;
				mySerialPort.BaudRate = 115200;
				mySerialPort.DataBits = 8;
				mySerialPort.Parity = Parity.None;
				mySerialPort.StopBits = StopBits.One;
				mySerialPort.ReceivedBytesThreshold = 1;
				mySerialPort.ReadTimeout = 1000;
				mySerialPort.WriteTimeout = 1000;
				mySerialPort.ReadBufferSize = 4096;
				mySerialPort.WriteBufferSize = 2048;
				mySerialPort.Encoding = Encoding.GetEncoding(28591);
			}
			try
			{
				mySerialPort.Open();
				BoardError = false;
				ControlColorGreenChange("CommsNoBoard");
				AppendTextBox(ErrorReporting, "Port Open");
				mySerialPort.DtrEnable = true;
				CommsResetTM.Enabled = true;
				CirculationOn();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				BoardError = true;
				SerialPortClose(isAppEnd: false);
				ControlColorRedChange("CommsNoBoard");
				AppendTextBox(ErrorReporting, "Port Close");
				CommsOff();
				ProjectData.ClearProjectError();
			}
			Interaction.SaveSetting("Health", "Setup", "Open" + base.Name.ToString(), Conversions.ToString(mySerialPort.IsOpen));
		}
	}

	private void StartSerialPortThreads()
	{
		if (!runThreads.WaitOne(0))
		{
			rcvARE.Reset();
			pinsErrorsARE.Reset();
			rcvThrd = new Thread(Receive);
			rcvThrd.IsBackground = true;
			rcvThrd.Priority = ThreadPriority.AboveNormal;
			pinserrorsThrd = new Thread(PinsAndErrors);
			pinserrorsThrd.IsBackground = true;
			runThreads.Set();
			pinserrorsThrd.Start();
			rcvThrd.Start();
			while ((pinserrorsThrd.ThreadState & System.Threading.ThreadState.Unstarted) == System.Threading.ThreadState.Unstarted || (rcvThrd.ThreadState & System.Threading.ThreadState.Unstarted) == System.Threading.ThreadState.Unstarted)
			{
				Thread.Sleep(10);
			}
		}
	}

	private void SerialPortClose(bool isAppEnd)
	{
		runThreads.Reset();
		rcvARE.Set();
		pinsErrorsARE.Set();
		rcvThrd.Join();
		pinserrorsThrd.Join();
		try
		{
			if (mySerialPort.IsOpen)
			{
				mySerialPort.Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if (isAppEnd)
		{
			Thread.Sleep(100);
			rcvARE.Dispose();
			pinsErrorsARE.Dispose();
			runThreads.Dispose();
		}
	}

	private void FormIsClosingHelper()
	{
		SerialPortClose(isAppEnd: true);
		BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			Close();
		}));
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (_0024STATIC_0024Form1_FormClosing_002420211C12825_0024t == null)
		{
			_0024STATIC_0024Form1_FormClosing_002420211C12825_0024t = Task.Run([SpecialName] () =>
			{
				FormIsClosingHelper();
			});
			e.Cancel = true;
		}
		else
		{
			_0024STATIC_0024Form1_FormClosing_002420211C12825_0024t.Wait();
		}
	}

	private void Form_Load(object sender, EventArgs e)
	{
		SetupThreadTimerOperations();
		MotorSwitchTM.Enabled = true;
		if (Conversion.Val(Interaction.GetSetting("Health", "Setup", "Port" + base.Name, 0.ToString())) > 0.0)
		{
			Hide();
			SerialPortOpen();
		}
	}

	private void SetupThreadTimerOperations()
	{
		CirculationTMSet();
		CirculationDelayTMSet();
		CirculationPumpCheckTMSet();
		SandBoxPushSwTMSet();
		InfoEnterTMSet();
	}

	public bool CheckComPort()
	{
		ReadOnlyCollection<string> serialPortNames = MyProject.Computer.Ports.SerialPortNames;
		if (serialPortNames.Contains("COM" + Interaction.GetSetting("Health", "Setup", "Port" + base.Name, 0.ToString())))
		{
			return true;
		}
		return false;
	}

	private void ComboBox_comport_SelectedIndexChanged(object sender, EventArgs e)
	{
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, Strings.Mid(ComboBox_comport.Text, 4, Strings.Len(ComboBox_comport.Text)));
		if (Conversion.Val(Interaction.GetSetting("Health", "Setup", "Port" + base.Name)) > 0.0)
		{
			SerialPortOpen();
			return;
		}
		AppendTextBox(CommsNoBoard, "0");
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, 0.ToString());
		Port = "0";
		CommsOff();
	}

	private void Board_Activated(object sender, EventArgs e)
	{
		AppendLabel(TitleName, base.Name);
		AppendTextBox(CommsNoBoard, Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0"));
		Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0");
		GetSerialPortNames();
		foreach (string serialPortName in MyProject.Computer.Ports.SerialPortNames)
		{
			if (Conversion.Val(Interaction.GetSetting("Health", "Setup", "COM" + serialPortName, 0.ToString())) == 0.0)
			{
				ComboBox_comport.Items.Add(serialPortName);
			}
		}
		ComboBox_comport.Items.Add("COM0");
	}

	public void GetSerialPortNames()
	{
		try
		{
			SerialAddress.Items.Clear();
			PortOk = false;
			Array array = Strings.Split(Display.AvailablePorts, ",");
			foreach (object item in array)
			{
				string text = Conversions.ToString(item);
				if (Operators.CompareString("COM" + Port, text, TextCompare: false) == 0)
				{
					PortOk = true;
				}
				SerialAddress.Items.Add(text);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void CommsOff()
	{
		mySerialPort.Close();
		if (Operators.CompareString(Port, "0", TextCompare: false) == 0)
		{
			CommsResetTM.Dispose();
		}
	}

	private void ControlColorRedChange(string text)
	{
		if (base.Controls[text].InvokeRequired)
		{
			SetTextCallback method = ControlColorRedChange;
			Invoke(method, text);
		}
		else
		{
			base.Controls[text].BackColor = Color.Red;
		}
	}

	private void ControlColorGreenChange(string text)
	{
		if (base.Controls[text].InvokeRequired)
		{
			SetTextCallback method = ControlColorGreenChange;
			Invoke(method, text);
		}
		else
		{
			base.Controls[text].BackColor = Color.Green;
		}
	}

	private void CommsNoBoard_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "CommsNoBoard";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsNoBoardLb_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "CommsNoBoard";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsSetting()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTMon();
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsNoBoard", TextCompare: false) == 0)
		{
			if (Operators.CompareString(CommsNoBoard.Text, "", TextCompare: false) == 0)
			{
				AppendTextBox(CommsNoBoard, "0");
			}
			MyProject.Forms.InfoEnter.Preload = CommsNoBoard.Text;
			InfoEnter.PasswordSet = CommsNoBoard.Text;
		}
	}

	public void InfoEnterTMSet()
	{
		InfoEnterTM = new System.Threading.Timer(InfoEnterTM_Tick, null, -1, -1);
	}

	public void InfoEnterTMOff()
	{
		InfoEnterTM.Change(-1, -1);
	}

	public void InfoEnterTMon()
	{
		InfoEnterTM.Change(400, 400);
	}

	private void InfoEnterTM_Tick(object sender)
	{
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsNoBoard", TextCompare: false) == 0)
		{
			AppendTextBox(CommsNoBoard, InfoEnter.PasswordSet);
			CommsNoBoard.TextAlign = HorizontalAlignment.Left;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		string itemName2 = ItemName;
		if (Operators.CompareString(itemName2, "CommsNoBoard", TextCompare: false) == 0)
		{
			if ((Operators.CompareString(CommsNoBoard.Text, "", TextCompare: false) == 0) | (Conversion.Val(CommsNoBoard.Text) == 0.0))
			{
				if (Operators.CompareString(CommsNoBoard.Text, "ZERO", TextCompare: false) == 0)
				{
					AppendTextBox(CommsNoBoard, "0");
					Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, "0");
					Port = "0";
					CommsOff();
				}
			}
			else
			{
				AppendTextBox(CommsNoBoard, Conversions.ToString(Conversion.Val(CommsNoBoard.Text)));
				Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, CommsNoBoard.Text);
				SerialPortOpen();
			}
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTMOff();
		ControlLevel = 0;
	}

	private void CommsResetTM_Tick(object sender, EventArgs e)
	{
		if ((Conversion.Val(CommsResetInd.Text) == 10.0) | Display.RLY816Startup)
		{
			AppendTextBox(CommsResetInd, "");
			CommsResetTM.Enabled = false;
			mySerialPort.Close();
			SerialPortOpen();
			if (mySerialPort.IsOpen)
			{
				ReadWrite();
			}
			WaitFlag = false;
		}
		else if (BoardError | !mySerialPort.IsOpen | BoardCheck | !ReadWriteFlag)
		{
			AppendTextBox(CommsResetInd, Conversions.ToString(Conversion.Val(CommsResetInd.Text) + 1.0));
			if (Conversion.Val(CommsResetInd.Text) > 1.0)
			{
				WaitFlag = false;
			}
		}
		else
		{
			AppendTextBox(CommsResetInd, "");
		}
		if (CommsResetInd.BackColor == Color.DarkGreen)
		{
			ControlColorGreenYellowChange("CommsResetInd");
		}
		else
		{
			ControlColorDarkGreenChange("CommsResetInd");
		}
	}

	private void ControlColorDarkGreenChange(string text)
	{
		if (base.Controls[text].InvokeRequired)
		{
			SetTextCallback method = ControlColorDarkGreenChange;
			Invoke(method, text);
		}
		else
		{
			base.Controls[text].BackColor = Color.DarkGreen;
		}
	}

	private void ControlColorGreenYellowChange(string text)
	{
		if (base.Controls[text].InvokeRequired)
		{
			SetTextCallback method = ControlColorGreenYellowChange;
			Invoke(method, text);
		}
		else
		{
			base.Controls[text].BackColor = Color.GreenYellow;
		}
	}

	private void VoltsChange(string text)
	{
		if (Volts.InvokeRequired)
		{
			SetTextCallback method = VoltsChange;
			Invoke(method, text);
		}
		else
		{
			Volts.Text = text;
		}
	}

	private void OKVoltsChange(string text)
	{
		if (OKVolts.InvokeRequired)
		{
			SetTextCallback method = OKVoltsChange;
			Invoke(method, text);
		}
		else
		{
			OKVolts.Text = text;
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
	}

	private void SetDoubleBuffering(Control aControl)
	{
		Type type = aControl.GetType();
		try
		{
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(aControl, true, null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ReadWrite()
	{
		ReadWriteFlag = true;
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		checked
		{
			if (Conversion.Val(IdentNo.Text) == 0.0)
			{
				GlobalIdent();
			}
			else if (Operators.CompareString(TypeNo.Text, "", TextCompare: false) == 0)
			{
				DetectType();
			}
			else if ((Operators.CompareString(Volts.Text, "", TextCompare: false) == 0) & (Operators.CompareString(TypeNo.Text, "USB-OPTO-RL816", TextCompare: false) == 0))
			{
				CheckVolts();
			}
			else
			{
				ReadReg++;
				if ((ReadReg == 1) & (Operators.CompareString(TypeNo.Text, "USB-OPTO-RL816", TextCompare: false) == 0))
				{
					CheckVolts();
				}
				else if (((ReadReg == 1) & (Operators.CompareString(TypeNo.Text, "USB-RL08B", TextCompare: false) != 0)) | ((ReadReg == 2) & (Operators.CompareString(TypeNo.Text, "USB-RL08B", TextCompare: false) != 0)))
				{
					ReadInputs();
					if (ReadReg == 1)
					{
						ReadReg++;
					}
				}
				else if (((ReadReg <= 3) & MotorSent) | ((ReadReg <= 3) & MotorsOff))
				{
					if (!MotorsOff)
					{
						MotorOp();
					}
					else
					{
						AllOff();
						MotorsOff = false;
					}
				}
				else
				{
					ReadOutputs();
					ReadReg = 0;
				}
			}
			try
			{
				BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					if (base.Visible)
					{
						Show();
					}
					else
					{
						Hide();
					}
				}));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void GlobalIdent()
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		WaitFlag = true;
		if (!BoardError)
		{
			ReturnType = "Ident";
			Array.Clear(serBuf, 0, serBuf.Length);
			serBuf[0] = 56;
			Num = 1;
			NewData = true;
			WriteData();
		}
	}

	private void DetectType()
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		WaitFlag = true;
		ReturnType = "Type";
		Array.Clear(serBuf, 0, serBuf.Length);
		serBuf[0] = 90;
		Num = 1;
		NewData = true;
		WriteData();
	}

	private void CheckVolts()
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		WaitFlag = true;
		ReturnType = "Volts";
		Array.Clear(serBuf, 0, serBuf.Length);
		serBuf[0] = 93;
		Num = 1;
		NewData = true;
		WriteData();
	}

	public void AllOutputsOff()
	{
		MotorsOff = true;
	}

	private void AllOff()
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		WaitFlag = true;
		ReturnType = "NoReturn";
		Array.Clear(serBuf, 0, serBuf.Length);
		serBuf[0] = 110;
		Num = 1;
		NewData = true;
		Relay1On = false;
		Relay2On = false;
		Relay3On = false;
		Relay4On = false;
		Relay5On = false;
		Relay6On = false;
		Relay7On = false;
		Relay8On = false;
		WriteData();
		MotorSent = false;
	}

	private void MotorOp()
	{
		checked
		{
			if (Display.TestEStop)
			{
				while (WaitFlag)
				{
					Application.DoEvents();
				}
				WaitFlag = true;
				ReturnType = "NoReturn";
				Array.Clear(serBuf, 0, serBuf.Length);
				serBuf[0] = 110;
				Num = 1;
				NewData = true;
				Relay1On = false;
				Relay2On = false;
				Relay3On = false;
				Relay4On = false;
				Relay5On = false;
				Relay6On = false;
				Relay7On = false;
				Relay8On = false;
				WriteData();
			}
			else
			{
				while (WaitFlag)
				{
					Application.DoEvents();
				}
				WaitFlag = true;
				ReturnType = "NoReturn";
				Array.Clear(serBuf, 0, serBuf.Length);
				byte b = (byte)(100 + MotorIndex);
				if (!MotorOnOff)
				{
					b += 10;
				}
				serBuf[0] = b;
				Num = 1;
				NewData = true;
				WriteData();
			}
			MotorSent = false;
		}
	}

	private void ReadInputs()
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		WaitFlag = true;
		ReturnType = "Inputs";
		Array.Clear(serBuf, 0, serBuf.Length);
		serBuf[0] = 25;
		Num = 1;
		NewData = true;
		WriteData();
	}

	private void ReadOutputs()
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		WaitFlag = true;
		ReturnType = "Outputs";
		Array.Clear(serBuf, 0, serBuf.Length);
		serBuf[0] = 91;
		Num = 1;
		NewData = true;
		WriteData();
	}

	private void WriteData()
	{
		EnableSpeakerTextTM(enable: true);
	}

	private void TimerEnable(bool enable)
	{
		WriteDataTM.Enabled = enable;
	}

	public void EnableSpeakerTextTM(bool enable)
	{
		try
		{
			Invoke(new SetTimerEnable(TimerEnable), enable);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			TimerEnable(enable);
			ProjectData.ClearProjectError();
		}
	}

	private void WriteDataTM_Tick(object sender, EventArgs e)
	{
		WriteDataTM.Dispose();
		checked
		{
			try
			{
				if (mySerialPort.IsOpen & NewData)
				{
					TimerEnable(enable: false);
					mySerialPort.Write(serBuf, 0, Num);
					NewData = false;
					BoardCheck = true;
					string text = "";
					if ((Operators.CompareString(Indicator, ">", TextCompare: false) == 0) | (Operators.CompareString(Indicator, null, TextCompare: false) == 0))
					{
						Indicator = "<";
					}
					else
					{
						Indicator = ">";
					}
					byte b = (byte)(Num - 1);
					byte b2 = 0;
					while (unchecked((uint)b2 <= (uint)b))
					{
						text = text + "," + Conversion.Val(serBuf[b2]);
						b2 = (byte)unchecked((uint)(b2 + 1));
					}
					string text2 = Strings.Mid(Send.Text, 1, 200);
					AppendTextBox(Send, text + Indicator + text2);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				AppendTextBox(ErrorReporting, "Device Failed");
				BoardError = true;
				SerialPortClose(isAppEnd: false);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(ReturnType, "NoReturn", TextCompare: false) == 0)
			{
				TOT88_CLIP = "0";
			}
		}
	}

	private void SimulateDevice()
	{
		checked
		{
			try
			{
				if (NewData)
				{
					mySerialPort.Write(serBuf, 0, Num);
				}
				NewData = false;
				string text = "";
				if ((Operators.CompareString(Indicator, ">", TextCompare: false) == 0) | (Operators.CompareString(Indicator, null, TextCompare: false) == 0))
				{
					Indicator = "<";
				}
				else
				{
					Indicator = ">";
				}
				byte b = (byte)(Num - 1);
				byte b2 = 0;
				while (unchecked((uint)b2 <= (uint)b))
				{
					text = text + "," + Conversion.Val(serBuf[b2]);
					b2 = (byte)unchecked((uint)(b2 + 1));
				}
				string text2 = Strings.Mid(Send.Text, 1, 200);
				AppendTextBox(Send, text + Indicator + text2);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				AppendTextBox(ErrorReporting, "Device Failed");
				BoardError = true;
				SerialPortClose(isAppEnd: false);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void AppendTextBox(TextBox TB, string txt)
	{
		if (TB.InvokeRequired)
		{
			TB.Invoke(new AppendTextBoxDelegate(AppendTextBox), TB, txt);
		}
		else
		{
			TB.Clear();
			TB.AppendText(txt);
		}
	}

	public void AppendLabel(Label LB, string txt)
	{
		if (LB.InvokeRequired)
		{
			LB.Invoke(new AppendLabelDelegate(AppendLabel), LB, txt);
		}
		else
		{
			LB.Text = txt;
		}
	}

	public void ReadDataReceived(string ReceivedText)
	{
		textIn += ReceivedText;
		if ((Operators.CompareString(Indicator, "<", TextCompare: false) == 0) | (Operators.CompareString(Indicator, null, TextCompare: false) == 0))
		{
			Indicator = ">";
		}
		else
		{
			Indicator = "<";
		}
		string text = Strings.Mid(ReceivedData.Text, 1, 200);
		AppendTextBox(ReceivedData, ReceivedText + " " + Indicator + " " + text);
		DataReceived = true;
		GetAck();
		IOPOT.IOPotCommsOK = CommsOK;
	}

	public void GetAck()
	{
		bool flag = false;
		ReadWriteFlag = false;
		checked
		{
			if (Operators.CompareString(ReturnType, "NoReturn", TextCompare: false) != 0)
			{
				while (Operators.CompareString(textIn, "", TextCompare: false) == 0)
				{
					Application.DoEvents();
				}
				flag = true;
				switch (ReturnType)
				{
				case "Ident":
					AppendTextBox(IdentNo, textIn);
					break;
				case "Type":
					if (Operators.CompareString(Strings.Mid(textIn, 1, 2), "13", TextCompare: false) == 0)
					{
						AppendTextBox(TypeNo, "USB-OPTO-RL816");
						TypeCheck = 2;
					}
					else if (Operators.CompareString(Strings.Mid(textIn, 1, 2), "12", TextCompare: false) == 0)
					{
						AppendTextBox(TypeNo, "USB-OPTO-RL88");
						TypeCheck = 1;
					}
					else if (Operators.CompareString(Strings.Mid(textIn, 1, 2), "8", TextCompare: false) == 0)
					{
						AppendTextBox(TypeNo, "USB-RL08B");
						TypeCheck = 1;
					}
					else if (Operators.CompareString(Strings.Mid(textIn, 1, 2), "1", TextCompare: false) == 0)
					{
						AppendTextBox(TypeNo, "USB-ISS");
					}
					AppendTextBox(SoftwareVer, Software.ToString());
					break;
				case "Volts":
					AppendTextBox(Volts, (Conversion.Val(textIn) / 10.0).ToString());
					if (Conversion.Val(Volts.Text) > 11.0)
					{
						VoltsStableTM.Enabled = true;
						OKVoltsChange("OK");
						VoltageOK = true;
					}
					else if (VoltageOK & (TypeCheck == 2))
					{
						VoltageOK = false;
						VoltsStableTM.Dispose();
						if (TypeCheck == 2)
						{
							AllOutputsOff();
						}
						OKVoltsChange("No Volts");
					}
					else if (TypeCheck == 1)
					{
						VoltageOK = true;
						OKVoltsChange("Not Used");
					}
					break;
				case "Outputs":
				{
					byte b = ((!(Conversion.Val(textIn) > 255.0)) ? ((byte)Math.Round(Conversion.Val(textIn))) : byte.MaxValue);
					DataReceivedBoard = "";
					byte b2 = 0;
					do
					{
						if ((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
						{
							DataReceivedBoard = "1" + DataReceivedBoard;
							MotorSwitch[b2 + 1] = true;
							string text = "Relay" + Conversions.ToString(b2 + 1);
							ControlColorGreenChange(text);
						}
						else
						{
							DataReceivedBoard = "0" + DataReceivedBoard;
							MotorSwitch[b2 + 1] = false;
							string text = "Relay" + Conversions.ToString(b2 + 1);
							ControlColorRedChange(text);
						}
						b2 = (byte)unchecked((uint)(b2 + 1));
					}
					while (unchecked((uint)b2) <= 7u);
					AppendTextBox(OutputData, DataReceivedBoard);
					if ((MachineSetup.HeatCircFitted & Display.EmergencyStop & (Operators.CompareString(Interaction.GetSetting("DTread", "RLY88", "HeaterInput", "False"), "True", TextCompare: false) == 0) & (Operators.CompareString(Interaction.GetSetting("DTread", "RLY88", "CirculationInput", "False"), "True", TextCompare: false) == 0) & (Operators.CompareString(Interaction.GetSetting("DTread", "RLY816", "Circulation", "False"), "True", TextCompare: false) == 0) & (Operators.CompareString(Interaction.GetSetting("DTread", "Aqua", "TankTempGauge", "False"), "False", TextCompare: false) == 0) & VoltageOK & MotorSwitch[5] & !SandBoxOnOff) | ((Operators.CompareString(Interaction.GetSetting("Dtread", "Aqua", "TankTempGauge", "False"), "True", TextCompare: false) == 0) & (Operators.CompareString(Interaction.GetSetting("Dtread", "WaterTemp", "TankTempHeater", "False"), "True", TextCompare: false) == 0) & (Operators.CompareString(Interaction.GetSetting("DTread", "RLY88", "HeaterInput", "False"), "True", TextCompare: false) == 0) & (Operators.CompareString(Interaction.GetSetting("DTread", "RLY88", "CirculationInput", "False"), "True", TextCompare: false) == 0) & (Operators.CompareString(Interaction.GetSetting("DTread", "RLY816", "Circulation", "False"), "True", TextCompare: false) == 0) & VoltageOK & MotorSwitch[5] & !SandBoxOnOff))
					{
						Heater = true;
						Interaction.SaveSetting("DTread", "RLY816", "Heater", "True");
						break;
					}
					Heater = false;
					if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) != 0)
					{
						Interaction.SaveSetting("DTread", "RLY816", "Heater", "False");
					}
					break;
				}
				case "Inputs":
				{
					byte b = (InputOverideSw ? InputOveride : ((!(Conversion.Val(textIn) > 255.0)) ? ((byte)Math.Round(Conversion.Val(textIn))) : byte.MaxValue));
					DataReceivedBoard = "";
					byte b2 = 0;
					do
					{
						if ((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
						{
							DataReceivedBoard = "1" + DataReceivedBoard;
							ControlColorGreenChange("IN" + Conversions.ToString(b2 + 1));
						}
						else
						{
							DataReceivedBoard = "0" + DataReceivedBoard;
							ControlColorRedChange("IN" + Conversions.ToString(b2 + 1));
						}
						switch (b2)
						{
						case 0:
							if (Display.Lift)
							{
								if ((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
								{
									LiftLowHeight = true;
								}
							}
							else
							{
								LiftLowHeight = false;
							}
							break;
						case 1:
							if (((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0) & Display.Lift)
							{
								LiftLGHeight = true;
								LiftLowHeight = false;
							}
							else
							{
								LiftLGHeight = false;
							}
							break;
						case 2:
							if (((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0) & Display.Lift)
							{
								LiftMaxHeight = false;
								if (EmptyPump & !LiftZeroHeight)
								{
									LiftZeroHeight = true;
									MoveCount = 400f;
									Interaction.SaveSetting("Dtread", "RLY82", "Pulse", Conversions.ToString(MoveCount));
								}
							}
							else
							{
								LiftZeroHeight = false;
							}
							break;
						case 3:
							if (Display.Lift)
							{
								if ((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
								{
									LiftMaxHeight = true;
								}
							}
							else
							{
								LiftMaxHeight = false;
							}
							break;
						case 4:
							if ((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
							{
								if (InclinePositionAdd < 3)
								{
									InclinePositionAdd++;
								}
								else
								{
									Interaction.SaveSetting("Dtread", "RLY816", "Actuator", "True");
								}
							}
							else
							{
								Interaction.SaveSetting("Dtread", "RLY816", "Actuator", "False");
								InclinePositionAdd = 0;
							}
							break;
						case 5:
							if ((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
							{
								if (InclineFaultAdd < 14)
								{
									InclineFaultAdd++;
								}
								else if (Operators.CompareString(Interaction.GetSetting("Dtread", "RLY816", "ActuatorFault", "False"), "False", TextCompare: false) == 0)
								{
									Interaction.SaveSetting("Dtread", "RLY816", "ActuatorFault", "True");
									USBOPTORLY88.InclinePowerTMHold = true;
									MyProject.Forms.Display.DoBoxChange("WriteMachineHistory");
								}
							}
							else
							{
								Interaction.SaveSetting("Dtread", "RLY816", "ActuatorFault", "False");
								USBOPTORLY88.InclinePowerTMHold = false;
								InclineFaultAdd = 0;
							}
							break;
						case 6:
							if (((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0) & !Display.ProgramRun & !Display.CleanOn & (Display.ActualWaterDepth <= -5f))
							{
								if ((!SandBoxOnOff & Display.EmergencyStop) | (SandBoxOnOff & !Display.EmergencyStop))
								{
									if (Display.EmergencyStop)
									{
										Display.StartProgramPic = "SandBox";
										MyProject.Forms.Display.ControlChange("ProgramStart", "Enabled", "False");
										SandBoxOnOff = true;
									}
									else
									{
										MyProject.Forms.Display.ControlChange("ProgramStart", "Enabled", "True");
										SandBoxOnOff = false;
									}
									CirculationDelayTMOff();
									CirculationOff();
									CleanCirculation = false;
								}
							}
							else if (SandBoxOnOff | (Operators.CompareString(Display.StartProgramPic, "SandBox", TextCompare: false) == 0))
							{
								SandBoxOnOff = false;
								CirculationDelayTMOff();
								CirculationOff();
								if (!Display.EmergencyStop)
								{
									Display.StartProgramPic = "Estop1";
								}
								else
								{
									Display.StartProgramPic = "StartSW";
								}
								MyProject.Forms.Display.ControlChange("ProgramStart", "Enabled", "True");
								SandBoxPushSwTMOff();
								CleanWaterEmpty = false;
								BackwashCont = false;
								if (Backwash)
								{
									Backwash = false;
									BackwashLong = false;
									BackwashShort = false;
									CleanCirculationOn();
								}
								CleanCirculationOn();
							}
							break;
						case 7:
							if (((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0) & SandBoxOnOff)
							{
								if (!CleanWaterEmpty & !BackwashCont)
								{
									if (!SandBoxPushSw & !BackwashLong & !BackwashShort & !Circulation)
									{
										SandBoxPushSw = true;
										SandBoxPushSwTMOn();
										BackwashLong = true;
										CirculationOn();
										Backwash = true;
										Interaction.SaveSetting("DTread", "RLY816", "Circulation", "True");
									}
									else if (!SandBoxPushSw & BackwashLong & !BackwashShort & !Circulation)
									{
										SandBoxPushSw = true;
										BackwashLong = false;
										BackwashShort = true;
										CirculationOn();
										SandBoxPushSwTMOff();
									}
								}
								else if (BackwashCont)
								{
									CleanWaterEmpty = false;
									BackwashCont = false;
									CirculationOff();
								}
								break;
							}
							SandBoxPushSwTMOff();
							BackwashShort = false;
							if (SandBoxOnOff)
							{
								if (CleanWaterEmpty & !BackwashCont)
								{
									BackwashCont = true;
								}
								if (!CleanWaterEmpty & !BackwashCont)
								{
									SandBoxPushSw = false;
								}
							}
							else
							{
								BackwashLong = false;
								SandBoxPushSw = false;
							}
							break;
						}
						b2 = (byte)unchecked((uint)(b2 + 1));
					}
					while (unchecked((uint)b2) <= 7u);
					AppendTextBox(InputData, DataReceivedBoard);
					break;
				}
				}
				WaitFlag = false;
			}
			else
			{
				WaitFlag = false;
			}
			textIn = "";
			BoardCheck = false;
			ReadWrite();
		}
	}

	private void Invisible_Click(object sender, EventArgs e)
	{
		base.Visible = false;
		Hide();
		ClearInputOveride();
		AllOutputsOff();
	}

	private void VoltsStableTM_Tick(object sender, EventArgs e)
	{
		VoltsStableTM.Dispose();
		VoltageOK = true;
	}

	private void MotorSwitchTM_Tick(object sender, EventArgs e)
	{
		if (!MotorSent)
		{
			MotorControlOp();
		}
	}

	private void MotorControlOp()
	{
		if ((MotorIndex == 9) | (MotorIndex == 0))
		{
			MotorIndex = 1;
		}
		if ((!Display.EmergencyStop & !Display.TestEStop) | ((TypeCheck == 2) & !VoltageOK & !Display.TestEStop & CommsActive))
		{
			CirculationOff();
			FillPump = false;
			if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("DTread", "RLY816", "FillPump", "False");
			}
			USBOPTORLY88.AirReleaseFill = false;
			if (EmptyPump & !Display.TreadmillFloatSw)
			{
				Display.WaterDepthMeasure = MyProject.Forms.Display.FloatSwDepth;
			}
			EmptyPump = false;
			Interaction.SaveSetting("DTread", "RLY816", "EmptyPump", "False");
			USBOPTORLY88.AirReleaseEmpty = false;
			FillPumpTell = false;
			EmptyPumpTell = false;
			Display.JetOn = false;
			CoolingFan = false;
		}
		checked
		{
			if (MotorIndex == 1)
			{
				if (RelayOveride)
				{
					if ((!Relay1On & MotorSwitch[MotorIndex]) | (Relay1On & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = Relay1On;
						MotorSent = true;
					}
				}
				else if (MachineSetup.HeatCircFitted && ((!Heater & MotorSwitch[MotorIndex]) | (Heater & !MotorSwitch[MotorIndex])))
				{
					MotorOnOff = Heater;
					MotorSent = true;
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex == 2)
			{
				if (RelayOveride)
				{
					if ((!Relay2On & MotorSwitch[MotorIndex]) | (Relay2On & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = Relay2On;
						MotorSent = true;
					}
				}
				else
				{
					if ((MachineSetup.HeatCircFitted & (Conversion.Val(MyProject.Forms.Display.WaterDepthActual.Text) < 5.0)) | !MachineSetup.JetDisplayOnOff | !Display.JetOn | (Display.JetOn & Display.ProgramHold) | (!VoltageOK & !Display.TestEStop))
					{
						JetONOff = false;
					}
					else
					{
						JetONOff = true;
					}
					if ((!JetONOff & MotorSwitch[MotorIndex]) | (JetONOff & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = JetONOff;
						MotorSent = true;
					}
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex == 3)
			{
				if (RelayOveride)
				{
					if ((!Relay3On & MotorSwitch[MotorIndex]) | (Relay3On & !Heater & !Circulation & !MotorSwitch[MotorIndex]))
					{
						if (USBOPTORLY88.MotorSwitch[6])
						{
							MotorOnOff = Relay3On;
							MotorSent = true;
							MessageBox.Text = "";
						}
						else
						{
							MotorOnOff = false;
							MotorSent = true;
							MessageBox.Text = "Switch on Relay 6 Air Release Valve RLY88";
							Relay3On = false;
						}
					}
				}
				else
				{
					MotorSent = FillPumpAndFillValveNormalyOpen((byte)MotorIndex);
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex == 4)
			{
				if (RelayOveride)
				{
					if ((!Relay4On & MotorSwitch[MotorIndex]) | (Relay4On & !Heater & !Circulation & !MotorSwitch[MotorIndex]))
					{
						if (USBOPTORLY88.MotorSwitch[7])
						{
							MotorOnOff = Relay4On;
							MotorSent = true;
							MessageBox.Text = "";
						}
						else
						{
							MotorOnOff = false;
							MotorSent = true;
							MessageBox.Text = "Switch on Relay 7 Air Release Valve RLY88";
							Relay4On = false;
						}
					}
				}
				else
				{
					MotorSent = EmptyPumpAndEmptyValveNormalyOpen((byte)MotorIndex);
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex == 5)
			{
				if (RelayOveride)
				{
					if ((!Relay5On & MotorSwitch[MotorIndex]) | (Relay5On & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = Relay5On;
						MotorSent = true;
					}
				}
				else if (!Display.Lift)
				{
					if (MachineSetup.HeatCircFitted && ((!Circulation & MotorSwitch[MotorIndex]) | (Circulation & !MotorSwitch[MotorIndex])))
					{
						MotorOnOff = Circulation;
						MotorSent = true;
					}
				}
				else
				{
					LiftSpeed1 = MotorSwitch[3] | MotorSwitch[4];
					if ((!LiftSpeed1 & MotorSwitch[MotorIndex]) | (LiftSpeed1 & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = LiftSpeed1;
						MotorSent = true;
					}
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex == 6)
			{
				if (RelayOveride)
				{
					if ((!Relay6On & MotorSwitch[MotorIndex]) | (Relay6On & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = Relay6On;
						MotorSent = true;
					}
				}
				else
				{
					if (!Display.Lift)
					{
						if ((MachineSetup.UVCLampFitted & MotorSwitch[MotorIndex - 1]) && ((!UVCLamp & MotorSwitch[MotorIndex]) | (UVCLamp & !MotorSwitch[MotorIndex])))
						{
							MotorOnOff = UVCLamp;
							MotorSent = true;
						}
					}
					else
					{
						if (Operators.CompareString(Interaction.GetSetting("DTread", "RLY816", "LiftSpeed2", "False"), "True", TextCompare: false) == 0)
						{
							LiftSpeed2 = true;
						}
						else
						{
							LiftSpeed2 = false;
						}
						if ((!LiftSpeed2 & MotorSwitch[MotorIndex]) | (LiftSpeed2 & !MotorSwitch[MotorIndex]))
						{
							MotorOnOff = LiftSpeed2;
							MotorSent = true;
						}
					}
					if (!MotorSent)
					{
						MotorIndex++;
					}
				}
			}
			if (MotorIndex == 7)
			{
				if (RelayOveride)
				{
					if ((!Relay7On & MotorSwitch[MotorIndex]) | (Relay7On & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = Relay7On;
						MotorSent = true;
					}
				}
				else
				{
					Process[] processesByName = Process.GetProcessesByName("CoolingFanTM");
					if (Display.ProgramRun & VoltageOK)
					{
						CoolingFan = true;
					}
					else if (CoolingFan & VoltageOK & (processesByName.Length == 0))
					{
						CoolingFanTM.Enabled = true;
					}
					if ((!CoolingFan & MotorSwitch[MotorIndex]) | (CoolingFan & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = CoolingFan;
						MotorSent = true;
					}
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex != 8)
			{
				return;
			}
			if (RelayOveride)
			{
				if ((!Relay8On & MotorSwitch[MotorIndex]) | (Relay8On & !MotorSwitch[MotorIndex]))
				{
					MotorOnOff = Relay8On;
					MotorSent = true;
				}
			}
			else if (VoltageOK)
			{
				if ((!EmergencyStopActive & MotorSwitch[MotorIndex]) | (EmergencyStopActive & !MotorSwitch[MotorIndex]))
				{
					MotorOnOff = EmergencyStopActive;
					MotorSent = true;
				}
			}
			else
			{
				MotorOnOff = false;
				MotorSent = true;
			}
			if (!MotorSent)
			{
				MotorIndex = 0;
			}
		}
	}

	private void Relay8_Click(object sender, EventArgs e)
	{
		if (!Relay8On)
		{
			Relay8On = true;
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			Relay8On = false;
		}
	}

	private void Relay7_Click(object sender, EventArgs e)
	{
		if (!Relay7On)
		{
			Relay7On = true;
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			Relay7On = false;
		}
	}

	private void Relay6_Click(object sender, EventArgs e)
	{
		if (!Relay6On)
		{
			Relay6On = true;
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			Relay6On = false;
		}
	}

	private void Relay5_Click(object sender, EventArgs e)
	{
		if (!Relay5On)
		{
			Relay5On = true;
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			Relay5On = false;
		}
	}

	private void Relay4_Click(object sender, EventArgs e)
	{
		if (!Relay4On)
		{
			Relay4On = true;
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			Relay4On = false;
		}
	}

	private void Relay3_Click(object sender, EventArgs e)
	{
		if (!Relay3On)
		{
			Relay3On = true;
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			Relay3On = false;
		}
	}

	private void Relay2_Click(object sender, EventArgs e)
	{
		if (!Relay2On)
		{
			Relay2On = true;
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			Relay2On = false;
		}
	}

	private void Relay1_Click(object sender, EventArgs e)
	{
		if (!Relay1On)
		{
			Relay1On = true;
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			Relay1On = false;
		}
	}

	private void RelayOverideSw_Click(object sender, EventArgs e)
	{
		if (!RelayOveride)
		{
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			RelayOverideSwChange("Relays Off");
			RelayOveride = false;
			AllOutputsOff();
		}
	}

	private void RelayOverideSwChange(string text)
	{
		if (RelayOverideSw.InvokeRequired)
		{
			SetTextCallback method = RelayOverideSwChange;
			Invoke(method, text);
		}
		else
		{
			RelayOverideSw.Text = text;
		}
	}

	private void InputsOverideSwChange(string text)
	{
		if (InputsOverideSw.InvokeRequired)
		{
			SetTextCallback method = InputsOverideSwChange;
			Invoke(method, text);
		}
		else
		{
			InputsOverideSw.Text = text;
		}
	}

	public bool FillPumpAndFillValveNormalyOpen(byte Index)
	{
		bool result = false;
		if (Display.Lift | (USBOPTORLY88.MotorSwitch[6] & FillPump) | !FillPump)
		{
			if (Display.WDOnOff & !EmptyPump & USBOPTORLY88.AirReleaseFill & USBOPTORLY88.MotorSwitch[6] & !Display.EmergencyEmpty & VoltageOK & !LiftLowHeight)
			{
				if ((!FillPump & MotorSwitch[Index]) | (FillPump & !MotorSwitch[Index]))
				{
					if (!Display.Lift)
					{
						if (!FillPump)
						{
							FillEmptyCirc = true;
							CirculationOn();
						}
						else
						{
							CirculationOff();
						}
					}
					MotorOnOff = FillPump;
					result = true;
				}
			}
			else if (MotorSwitch[Index] | FillPump)
			{
				if (!Display.Lift)
				{
					FillEmptyCirc = true;
					CirculationOn();
					FillPump = false;
					Interaction.SaveSetting("DTread", "RLY816", "FillPump", "False");
				}
				USBOPTORLY88.AirReleaseFill = false;
				MotorOnOff = false;
				result = true;
			}
		}
		return result;
	}

	public bool EmptyPumpAndEmptyValveNormalyOpen(byte Index)
	{
		bool result = false;
		if (Display.Lift | (USBOPTORLY88.MotorSwitch[7] & EmptyPump) | !EmptyPump)
		{
			if (Display.WDOnOff & !FillPump & USBOPTORLY88.MotorSwitch[7] & USBOPTORLY88.AirReleaseEmpty & !LiftMaxHeight & VoltageOK)
			{
				if ((!EmptyPump & MotorSwitch[Index]) | (EmptyPump & !MotorSwitch[Index]))
				{
					if (!Display.Lift)
					{
						if (!EmptyPump)
						{
							FillEmptyCirc = true;
							CirculationOn();
						}
						else
						{
							CirculationOff();
						}
					}
					MotorOnOff = EmptyPump;
					result = true;
				}
			}
			else if (MotorSwitch[Index] | EmptyPump)
			{
				if (!Display.Lift)
				{
					FillEmptyCirc = true;
					CirculationOn();
					if (EmptyPump & !Display.TreadmillFloatSw)
					{
						Display.WaterDepthMeasure = MyProject.Forms.Display.FloatSwDepth;
					}
				}
				EmptyPump = false;
				Interaction.SaveSetting("DTread", "RLY816", "EmptyPump", "False");
				USBOPTORLY88.AirReleaseEmpty = false;
				MotorOnOff = false;
				result = true;
			}
		}
		return result;
	}

	private void CoolingFanTM_Tick(object sender, EventArgs e)
	{
		CoolingFanTM.Dispose();
		CoolingFan = false;
	}

	private void IN1_Click(object sender, EventArgs e)
	{
		checked
		{
			byte b = (byte)Math.Round(Math.Pow(2.0, Conversion.Val(Strings.Mid(((Button)sender).Name, 3, Strings.Len(((Button)sender).Name))) - 1.0));
			if ((InputOveride & b) != 0)
			{
				InputOveride = (byte)unchecked((uint)(InputOveride - b));
			}
			else
			{
				InputOveride = (byte)unchecked((uint)(InputOveride + b));
			}
			InputOverideSw = true;
			SetInputs();
		}
	}

	private void SetInputs()
	{
		if (InputOverideSw)
		{
			InputsOverideSwChange("Inputs On");
		}
		else
		{
			InputsOverideSwChange("Inputs Off");
		}
	}

	private void OverrideInputs_Click(object sender, EventArgs e)
	{
		ClearInputOveride();
	}

	private void ClearInputOveride()
	{
		InputOveride = 0;
		InputOverideSw = false;
		SetInputs();
	}

	public void CirculationOff()
	{
		CirculationTMOff();
		CirculationCheckPumpTMOff();
		CirculationPumpError = false;
		Circulation = false;
		Interaction.SaveSetting("DTread", "RLY816", "Circulation", "False");
		Heater = false;
		if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) != 0)
		{
			Interaction.SaveSetting("DTread", "RLY816", "Heater", "False");
		}
	}

	public void CirculationOnTimeSet()
	{
		if (BackwashLong)
		{
			CirculationTMI = 50000;
			CirculationDelayTMI = 5000;
		}
		else if (BackwashShort)
		{
			CirculationTMI = 20000;
			CirculationDelayTMI = 5000;
		}
		else if (CirculationPumpError)
		{
			CirculationTMI = 3000;
			CirculationDelayTMI = 60000;
		}
		else if (FillEmptyCirc)
		{
			FillEmptyCirc = false;
			CirculationTMI = 600000;
			CirculationDelayTMI = 1200000;
		}
		else if (CleanCirculation)
		{
			CleanCirculation = false;
			CirculationTMI = 1200000;
			CirculationDelayTMI = 600000;
		}
		else if (CleanWaterEmpty)
		{
			CleanWaterEmpty = false;
			CirculationTMI = 1500000;
			CirculationDelayTMI = 5000;
		}
		else
		{
			CirculationTMI = 300000;
			CirculationDelayTMI = 1500000;
		}
		AppendTextBox(MessageBox, Conversions.ToString(CirculationTMI) + ", " + Conversions.ToString(CirculationDelayTMI));
	}

	public void CirculationOn()
	{
		if (!MachineSetup.HeatCircFitted)
		{
			return;
		}
		if (!Circulation & !FillPump & !EmptyPump & (Display.ActualWaterDepth <= -5f) & Display.EmergencyStop & !Display.ProgramRun & !Display.ProgramReset & !Display.CleanOn & VoltageOK)
		{
			CirculationTMOff();
			CirculationDelayTMOff();
			CirculationOnTimeSet();
			if (CirculationTMI > 1000)
			{
				CirculationTMon();
			}
			else
			{
				CirculationDelayTMon();
			}
			Interaction.SaveSetting("DTread", "RLY816", "Circulation", "True");
			if (!SandBoxOnOff)
			{
				CirculationCheckPumpTMon();
			}
		}
		else if (!Circulation)
		{
			CirculationDelayTMI = 60000;
			CirculationDelayTMon();
		}
	}

	public void CleanCirculationOn()
	{
		CleanCirculation = true;
		CirculationOn();
	}

	public void SandBoxPushSwTMSet()
	{
		SandBoxPushSwTM = new System.Threading.Timer(SandBoxPushSwTM_Tick, null, -1, -1);
	}

	public void SandBoxPushSwTM_Tick(object sender)
	{
		SandBoxPushSwTMOff();
		CirculationTMOff();
		CleanWaterEmpty = true;
		CirculationOn();
		SetRegistryKeys();
	}

	public void SandBoxPushSwTMOff()
	{
		SandBoxPushSwTM.Change(-1, -1);
	}

	public void SandBoxPushSwTMOn()
	{
		SandBoxPushSwTM.Change(5000, 5000);
	}

	public void SetRegistryKeys()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control\\\\Windows\\\\Panel\\\\", writable: true);
		registryKey.SetValue("DCW", (Conversion.Val(RuntimeHelpers.GetObjectValue(registryKey.GetValue("DCW", "0"))) + 1.0).ToString());
		registryKey.SetValue("WCW", (Conversion.Val(RuntimeHelpers.GetObjectValue(registryKey.GetValue("WCW", "0"))) + 1.0).ToString());
	}

	public void CirculationTMSet()
	{
		CirculationTM = new System.Threading.Timer(CirculationTM_Tick, null, -1, -1);
	}

	public void CirculationTMOff()
	{
		CirculationTM.Change(-1, -1);
	}

	public void CirculationTMon()
	{
		CirculationTM.Change(CirculationTMI, CirculationTMI);
		Circulation = true;
	}

	public void CirculationTM_Tick(object source)
	{
		CirculationTMOff();
		if (!SandBoxOnOff)
		{
			CirculationDelayRunCheck();
		}
		else
		{
			CirculationOff();
		}
	}

	public void CirculationDelayRunCheck()
	{
		if (Operators.CompareString(Interaction.GetSetting("DTread", "RLY88", "HeaterInput", "False"), "False", TextCompare: false) == 0)
		{
			CirculationOff();
			CirculationDelayTMon();
		}
		else
		{
			CirculationTMI = 5000;
			CirculationTMon();
		}
	}

	public void CirculationDelayTMSet()
	{
		CirculationDelayTM = new System.Threading.Timer(CirculationDelayTM_Tick, null, -1, -1);
	}

	public void CirculationDelayTM_Tick(object sender)
	{
		CirculationDelayTMOff();
		CirculationOn();
	}

	public void CirculationDelayTMOff()
	{
		CirculationDelayTM.Change(-1, -1);
	}

	public void CirculationDelayTMon()
	{
		CirculationDelayTM.Change(CirculationDelayTMI, CirculationDelayTMI);
	}

	public void CirculationPumpCheckTMSet()
	{
		CirculationErrorCount = 0;
		CirculationCheckPumpTM = new System.Threading.Timer(CirculationCheckPumpTM_Tick, null, -1, -1);
	}

	public void CirculationCheckPumpTMOff()
	{
		CirculationCheckPumpTM.Change(-1, -1);
	}

	public void CirculationCheckPumpTMon()
	{
		CirculationCheckPumpTM.Change(5000, 5000);
	}

	public void CirculationCheckPumpTM_Tick(object sender)
	{
		CirculationCheckPumpTMOff();
		checked
		{
			if (Circulation & (Operators.CompareString(Interaction.GetSetting("DTread", "RLY88", "CirculationInput", "False"), "False", TextCompare: false) == 0) & !FillPump & !EmptyPump & !Display.ProgramRun & !Display.CleanOn & (CirculationErrorCount >= 3))
			{
				CirculationOff();
				if (Operators.CompareString(Interaction.GetSetting("DTread", "RLY816", "CirculationPumpError", "False"), "False", TextCompare: false) == 0)
				{
					Interaction.SaveSetting("DTread", "RLY816", "CirculationPumpError", "True");
					MyProject.Forms.Display.DoBoxChange("WriteMachineHistory");
				}
				UVCLamp = false;
				CirculationPumpError = true;
				CirculationOn();
			}
			else if (Operators.CompareString(Interaction.GetSetting("DTread", "RLY88", "CirculationInput", "False"), "False", TextCompare: false) == 0)
			{
				if (CirculationErrorCount < 3)
				{
					CirculationErrorCount++;
				}
				UVCLamp = false;
			}
			else
			{
				CirculationErrorCount = 0;
				CirculationPumpError = false;
				Interaction.SaveSetting("DTread", "RLY816", "CirculationPumpError", "False");
				if (MachineSetup.UVCLampFitted)
				{
					UVCLamp = true;
				}
			}
			CirculationCheckPumpTMon();
		}
	}
}
