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
public class UPOT8PROXR : Form
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
	[AccessedThroughProperty("CommsResetTM")]
	private System.Windows.Forms.Timer _CommsResetTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MotorSwitchTM")]
	private System.Windows.Forms.Timer _MotorSwitchTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private System.Windows.Forms.Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VoltsStableTM")]
	private System.Windows.Forms.Timer _VoltsStableTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsTM")]
	private System.Windows.Forms.Timer _CommsTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WriteDataTM")]
	private System.Windows.Forms.Timer _WriteDataTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Port_Speed")]
	private TextBox _Port_Speed;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Port_Incline")]
	private TextBox _Port_Incline;

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

	public bool InclineReset;

	public bool InclineLearn;

	public bool LearnOnOff;

	public object CloseVersion;

	public bool CommsActive;

	private double OperatingTemp;

	private bool EmptyPumpTell;

	private bool FillPumpTell;

	private bool RemoteWaterDN;

	private bool RemoteWaterUP;

	private bool RemoteSpeedDN;

	private bool RemoteSpeedUP;

	private bool RemoteGradientDN;

	private bool RemoteGradientUP;

	private bool CWE;

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

	private bool DataReceived;

	private bool CommsOK;

	public static bool VoltageOK;

	private string Indicator;

	private string IndicatorS;

	private string IndicatorR;

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

	public static byte MotorIndex = 1;

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

	public bool FloatSwFault;

	private bool EmergencyPush;

	private static Random prng = new Random();

	private int minMessSz;

	private bool slow;

	[SpecialName]
	private Task _0024STATIC_0024Form1_FormClosing_002420211C12825_0024t;

	[field: AccessedThroughProperty("MessageBox")]
	public virtual TextBox MessageBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual System.Windows.Forms.Timer InfoEnterTM
	{
		[CompilerGenerated]
		get
		{
			return _InfoEnterTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InfoEnterTM_Tick;
			System.Windows.Forms.Timer timer = _InfoEnterTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_InfoEnterTM = value;
			timer = _InfoEnterTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SerialPortBoard")]
	internal virtual SerialPort SerialPortBoard
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	public virtual System.Windows.Forms.Timer CommsTM
	{
		[CompilerGenerated]
		get
		{
			return _CommsTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsTM_Tick;
			System.Windows.Forms.Timer timer = _CommsTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_CommsTM = value;
			timer = _CommsTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
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

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox Port_Speed
	{
		[CompilerGenerated]
		get
		{
			return _Port_Speed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Port_Speed_Click;
			TextBox textBox = _Port_Speed;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_Port_Speed = value;
			textBox = _Port_Speed;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox Port_Incline
	{
		[CompilerGenerated]
		get
		{
			return _Port_Incline;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Port_Incline_Click;
			TextBox textBox = _Port_Incline;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_Port_Incline = value;
			textBox = _Port_Incline;
			if (textBox != null)
			{
				textBox.Click += value2;
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

	public UPOT8PROXR()
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
		CloseVersion = Registry.CurrentUser.OpenSubKey("Control\\\\Windows\\\\Panel\\\\", writable: true);
		ReadReg = 0;
		Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, Conversions.ToString(0));
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
		this.MessageBox = new System.Windows.Forms.TextBox();
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
		this.CommsResetTM = new System.Windows.Forms.Timer(this.components);
		this.MotorSwitchTM = new System.Windows.Forms.Timer(this.components);
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.SerialPortBoard = new System.IO.Ports.SerialPort(this.components);
		this.VoltsStableTM = new System.Windows.Forms.Timer(this.components);
		this.CommsTM = new System.Windows.Forms.Timer(this.components);
		this.WriteDataTM = new System.Windows.Forms.Timer(this.components);
		this.Label22 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Port_Speed = new System.Windows.Forms.TextBox();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Port_Incline = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.MessageBox.Location = new System.Drawing.Point(119, 407);
		this.MessageBox.Multiline = true;
		this.MessageBox.Name = "MessageBox";
		this.MessageBox.Size = new System.Drawing.Size(225, 33);
		this.MessageBox.TabIndex = 303;
		this.SerialAddress.FormattingEnabled = true;
		this.SerialAddress.Location = new System.Drawing.Point(357, 135);
		this.SerialAddress.Name = "SerialAddress";
		this.SerialAddress.Size = new System.Drawing.Size(76, 108);
		this.SerialAddress.TabIndex = 302;
		this.OKVolts.Location = new System.Drawing.Point(30, 341);
		this.OKVolts.Name = "OKVolts";
		this.OKVolts.Size = new System.Drawing.Size(52, 20);
		this.OKVolts.TabIndex = 301;
		this.OKVolts.Text = "Volts Off";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(358, 257);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(78, 13);
		this.Label2.TabIndex = 300;
		this.Label2.Text = "Comms  Check";
		this.CommsResetInd.Location = new System.Drawing.Point(370, 273);
		this.CommsResetInd.Name = "CommsResetInd";
		this.CommsResetInd.Size = new System.Drawing.Size(44, 20);
		this.CommsResetInd.TabIndex = 299;
		this.TitleName.AutoSize = true;
		this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TitleName.Location = new System.Drawing.Point(19, 25);
		this.TitleName.Name = "TitleName";
		this.TitleName.Size = new System.Drawing.Size(38, 20);
		this.TitleName.TabIndex = 298;
		this.TitleName.Text = "Title";
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(361, 25);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(62, 58);
		this.Invisible.TabIndex = 297;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = true;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(118, 134);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(31, 13);
		this.Label17.TabIndex = 296;
		this.Label17.Text = "Type";
		this.TypeNo.Location = new System.Drawing.Point(121, 147);
		this.TypeNo.Name = "TypeNo";
		this.TypeNo.Size = new System.Drawing.Size(126, 20);
		this.TypeNo.TabIndex = 295;
		this.VoltsLB.AutoSize = true;
		this.VoltsLB.Location = new System.Drawing.Point(27, 313);
		this.VoltsLB.Name = "VoltsLB";
		this.VoltsLB.Size = new System.Drawing.Size(30, 13);
		this.VoltsLB.TabIndex = 294;
		this.VoltsLB.Text = "Volts";
		this.VoltsLB.UseWaitCursor = true;
		this.Volts.Location = new System.Drawing.Point(61, 310);
		this.Volts.Name = "Volts";
		this.Volts.Size = new System.Drawing.Size(44, 20);
		this.Volts.TabIndex = 293;
		this.Relay7.Location = new System.Drawing.Point(11, 265);
		this.Relay7.Name = "Relay7";
		this.Relay7.Size = new System.Drawing.Size(44, 26);
		this.Relay7.TabIndex = 292;
		this.Relay7.Text = "RL7";
		this.Relay7.UseVisualStyleBackColor = true;
		this.Relay6.Location = new System.Drawing.Point(61, 225);
		this.Relay6.Name = "Relay6";
		this.Relay6.Size = new System.Drawing.Size(44, 26);
		this.Relay6.TabIndex = 291;
		this.Relay6.Text = "RL6";
		this.Relay6.UseVisualStyleBackColor = true;
		this.Relay5.Location = new System.Drawing.Point(11, 224);
		this.Relay5.Name = "Relay5";
		this.Relay5.Size = new System.Drawing.Size(44, 26);
		this.Relay5.TabIndex = 290;
		this.Relay5.Text = "RL5";
		this.Relay5.UseVisualStyleBackColor = true;
		this.Relay4.Location = new System.Drawing.Point(61, 182);
		this.Relay4.Name = "Relay4";
		this.Relay4.Size = new System.Drawing.Size(44, 26);
		this.Relay4.TabIndex = 289;
		this.Relay4.Text = "RL4";
		this.Relay4.UseVisualStyleBackColor = true;
		this.Relay3.Location = new System.Drawing.Point(11, 182);
		this.Relay3.Name = "Relay3";
		this.Relay3.Size = new System.Drawing.Size(44, 26);
		this.Relay3.TabIndex = 288;
		this.Relay3.Text = "RL3";
		this.Relay3.UseVisualStyleBackColor = true;
		this.Relay2.Location = new System.Drawing.Point(61, 142);
		this.Relay2.Name = "Relay2";
		this.Relay2.Size = new System.Drawing.Size(44, 26);
		this.Relay2.TabIndex = 287;
		this.Relay2.Text = "RL2";
		this.Relay2.UseVisualStyleBackColor = true;
		this.RelayOverideSw.Location = new System.Drawing.Point(11, 102);
		this.RelayOverideSw.Name = "RelayOverideSw";
		this.RelayOverideSw.Size = new System.Drawing.Size(94, 26);
		this.RelayOverideSw.TabIndex = 286;
		this.RelayOverideSw.Text = "Relays";
		this.RelayOverideSw.UseVisualStyleBackColor = true;
		this.Relay1.Location = new System.Drawing.Point(11, 142);
		this.Relay1.Name = "Relay1";
		this.Relay1.Size = new System.Drawing.Size(44, 26);
		this.Relay1.TabIndex = 285;
		this.Relay1.Text = "RL1";
		this.Relay1.UseVisualStyleBackColor = true;
		this.Relay8.Location = new System.Drawing.Point(61, 265);
		this.Relay8.Name = "Relay8";
		this.Relay8.Size = new System.Drawing.Size(44, 26);
		this.Relay8.TabIndex = 284;
		this.Relay8.Text = "RL8";
		this.Relay8.UseVisualStyleBackColor = true;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(120, 212);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(44, 13);
		this.Label16.TabIndex = 283;
		this.Label16.Text = "Outputs";
		this.Label16.UseWaitCursor = true;
		this.OutputData.Location = new System.Drawing.Point(123, 227);
		this.OutputData.Multiline = true;
		this.OutputData.Name = "OutputData";
		this.OutputData.Size = new System.Drawing.Size(225, 22);
		this.OutputData.TabIndex = 282;
		this.OutputData.Text = "Data";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(120, 327);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(53, 13);
		this.Label15.TabIndex = 281;
		this.Label15.Text = "Recieved";
		this.Label15.UseWaitCursor = true;
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(120, 170);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(36, 13);
		this.Label14.TabIndex = 280;
		this.Label14.Text = "Inputs";
		this.Label14.UseWaitCursor = true;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(124, 254);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(29, 13);
		this.Label13.TabIndex = 279;
		this.Label13.Text = "Sent";
		this.InputData.Location = new System.Drawing.Point(121, 186);
		this.InputData.Multiline = true;
		this.InputData.Name = "InputData";
		this.InputData.Size = new System.Drawing.Size(225, 22);
		this.InputData.TabIndex = 278;
		this.InputData.Text = "Data";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(118, 90);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(31, 13);
		this.Label11.TabIndex = 277;
		this.Label11.Text = "Ident";
		this.CommsNoBoardLb.AutoSize = true;
		this.CommsNoBoardLb.Location = new System.Drawing.Point(27, 75);
		this.CommsNoBoardLb.Name = "CommsNoBoardLb";
		this.CommsNoBoardLb.Size = new System.Drawing.Size(28, 13);
		this.CommsNoBoardLb.TabIndex = 276;
		this.CommsNoBoardLb.Text = "Com";
		this.CommsNoBoard.Location = new System.Drawing.Point(61, 72);
		this.CommsNoBoard.Name = "CommsNoBoard";
		this.CommsNoBoard.Size = new System.Drawing.Size(44, 20);
		this.CommsNoBoard.TabIndex = 275;
		this.IdentNo.Location = new System.Drawing.Point(121, 106);
		this.IdentNo.Name = "IdentNo";
		this.IdentNo.Size = new System.Drawing.Size(126, 20);
		this.IdentNo.TabIndex = 274;
		this.Send.Location = new System.Drawing.Point(121, 267);
		this.Send.Multiline = true;
		this.Send.Name = "Send";
		this.Send.Size = new System.Drawing.Size(225, 60);
		this.Send.TabIndex = 273;
		this.ReceivedData.Location = new System.Drawing.Point(119, 341);
		this.ReceivedData.Multiline = true;
		this.ReceivedData.Name = "ReceivedData";
		this.ReceivedData.Size = new System.Drawing.Size(225, 60);
		this.ReceivedData.TabIndex = 272;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(170, 11);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(35, 13);
		this.Label1.TabIndex = 271;
		this.Label1.Text = "Board";
		this.ErrorReporting.Location = new System.Drawing.Point(173, 27);
		this.ErrorReporting.Multiline = true;
		this.ErrorReporting.Name = "ErrorReporting";
		this.ErrorReporting.Size = new System.Drawing.Size(161, 61);
		this.ErrorReporting.TabIndex = 270;
		this.ErrorReporting.Text = "No Error";
		this.CommsResetTM.Interval = 150;
		this.MotorSwitchTM.Enabled = true;
		this.SerialPortBoard.Parity = System.IO.Ports.Parity.Even;
		this.VoltsStableTM.Interval = 2000;
		this.CommsTM.Enabled = true;
		this.CommsTM.Interval = 500;
		this.WriteDataTM.Enabled = true;
		this.WriteDataTM.Interval = 75;
		this.Label22.AutoSize = true;
		this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label22.Location = new System.Drawing.Point(483, 27);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(83, 20);
		this.Label22.TabIndex = 306;
		this.Label22.Text = "Conveyor";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(490, 68);
		this.Label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(26, 13);
		this.Label3.TabIndex = 305;
		this.Label3.Text = "Port";
		this.Port_Speed.Location = new System.Drawing.Point(520, 65);
		this.Port_Speed.Name = "Port_Speed";
		this.Port_Speed.Size = new System.Drawing.Size(37, 20);
		this.Port_Speed.TabIndex = 304;
		this.Label21.AutoSize = true;
		this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label21.Location = new System.Drawing.Point(489, 205);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(78, 20);
		this.Label21.TabIndex = 309;
		this.Label21.Text = "Actuator";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(490, 246);
		this.Label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(26, 13);
		this.Label4.TabIndex = 308;
		this.Label4.Text = "Port";
		this.Port_Incline.Location = new System.Drawing.Point(520, 243);
		this.Port_Incline.Name = "Port_Incline";
		this.Port_Incline.Size = new System.Drawing.Size(37, 20);
		this.Port_Incline.TabIndex = 307;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(607, 450);
		base.ControlBox = false;
		base.Controls.Add(this.Label21);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Port_Incline);
		base.Controls.Add(this.Label22);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Port_Speed);
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
		base.Name = "UPOT8PROXR";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "POT 8";
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
						case "U":
							ReceivedText = mySerialPort.ReadExisting();
							break;
						case "Ident":
							ReceivedText = mySerialPort.ReadExisting();
							break;
						case "Type":
						{
							if (mySerialPort.BytesToRead > 0)
							{
								ReceivedText = Conversions.ToString(mySerialPort.ReadByte());
							}
							string text = mySerialPort.ReadExisting();
							break;
						}
						case "Volts":
						{
							if (mySerialPort.BytesToRead > 0)
							{
								ReceivedText = Conversions.ToString(mySerialPort.ReadByte());
							}
							string text = mySerialPort.ReadExisting();
							break;
						}
						case "Setup":
						{
							if (mySerialPort.BytesToRead > 0)
							{
								ReceivedText = Conversions.ToString(mySerialPort.ReadByte());
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
			Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, Conversions.ToString(0));
			if (Conversions.ToDouble(Port) == 0.0)
			{
				Interaction.GetSetting("Health", "Setup", "IOPOT", Conversions.ToString(0));
			}
			if (Conversion.Val(Port) > 0.0)
			{
				GetSerialPortNames();
				Display.UPOT8Startup = false;
				CommsNoBoard.BackColor = Color.Green;
				CommsActive = true;
			}
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
			try
			{
				mySerialPort.Open();
				Display.IOPOTCommsActive = true;
				BoardError = false;
				ControlColorGreenChange("CommsNoBoard");
				AppendTextBox(ErrorReporting, "Port Open");
				mySerialPort.DtrEnable = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				BoardError = true;
				Display.IOPOTCommsActive = false;
				SerialPortClose(isAppEnd: false);
				ControlColorRedChange("CommsNoBoard");
				AppendTextBox(ErrorReporting, "Port Close");
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
		if (Conversion.Val(Interaction.GetSetting("Health", "Setup", "Port" + base.Name, Conversions.ToString(0))) > 0.0)
		{
			base.Visible = false;
			SerialPortOpen();
			AppendTextBox(Port_Speed, Interaction.GetSetting("Health", "Setup", "Port_Speed", "4"));
			AppendTextBox(Port_Incline, Interaction.GetSetting("Health", "Setup", "Port_Incline", "3"));
		}
	}

	public object CheckComPort()
	{
		ReadOnlyCollection<string> serialPortNames = MyProject.Computer.Ports.SerialPortNames;
		if (serialPortNames.Contains("COM" + Interaction.GetSetting("Health", "Setup", "Port" + base.Name, Conversions.ToString(0))))
		{
			return true;
		}
		return false;
	}

	private void Board_Activated(object sender, EventArgs e)
	{
		AppendLabel(TitleName, base.Name);
		AppendTextBox(CommsNoBoard, Interaction.GetSetting("Health", "Setup", "Port" + base.Name, Conversions.ToString(0)));
		GetSerialPortNames();
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

	private void Port_Speed_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "Port_Speed";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void Port_Incline_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "Port_Incline";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsSetting()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		switch (ItemName)
		{
		case "CommsNoBoard":
			if (Operators.CompareString(CommsNoBoard.Text, "", TextCompare: false) == 0)
			{
				AppendTextBox(CommsNoBoard, "0");
			}
			MyProject.Forms.InfoEnter.Preload = CommsNoBoard.Text;
			InfoEnter.PasswordSet = CommsNoBoard.Text;
			break;
		case "Port_Speed":
			if (Operators.CompareString(Port_Speed.Text, "", TextCompare: false) == 0)
			{
				AppendTextBox(Port_Speed, "4");
			}
			MyProject.Forms.InfoEnter.Preload = Port_Speed.Text;
			InfoEnter.PasswordSet = Port_Speed.Text;
			break;
		case "Port_Incline":
			if (Operators.CompareString(Port_Incline.Text, "", TextCompare: false) == 0)
			{
				AppendTextBox(Port_Incline, "3");
			}
			MyProject.Forms.InfoEnter.Preload = Port_Incline.Text;
			InfoEnter.PasswordSet = Port_Incline.Text;
			break;
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		switch (ItemName)
		{
		case "CommsNoBoard":
			AppendTextBox(CommsNoBoard, InfoEnter.PasswordSet);
			CommsNoBoard.TextAlign = HorizontalAlignment.Left;
			break;
		case "Port_Speed":
			Port_Speed.TextAlign = HorizontalAlignment.Left;
			AppendTextBox(Port_Speed, InfoEnter.PasswordSet);
			break;
		case "Port_Incline":
			Port_Incline.TextAlign = HorizontalAlignment.Left;
			AppendTextBox(Port_Incline, InfoEnter.PasswordSet);
			break;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		switch (ItemName)
		{
		case "CommsNoBoard":
			if ((Operators.CompareString(CommsNoBoard.Text, "", TextCompare: false) == 0) | (Conversion.Val(CommsNoBoard.Text) == 0.0))
			{
				if (Operators.CompareString(CommsNoBoard.Text, "ZERO", TextCompare: false) == 0)
				{
					CommsOff();
				}
			}
			else
			{
				AppendTextBox(CommsNoBoard, Conversions.ToString(Conversion.Val(CommsNoBoard.Text)));
				Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, CommsNoBoard.Text);
				CommsResetTM.Enabled = true;
			}
			break;
		case "Port_Speed":
			if (Operators.CompareString(Port_Speed.Text, "", TextCompare: false) != 0 && ((Conversion.Val(Port_Speed.Text) >= 0.0) & (Conversion.Val(Port_Speed.Text) <= 7.0)))
			{
				AppendTextBox(Port_Speed, Conversions.ToString(Conversion.Val(Port_Speed.Text)));
				Interaction.SaveSetting("Health", "Setup", "Port_Speed", Port_Speed.Text);
			}
			break;
		case "Port_Incline":
			if (Operators.CompareString(Port_Incline.Text, "", TextCompare: false) != 0 && ((Conversion.Val(Port_Speed.Text) >= 0.0) & (Conversion.Val(Port_Speed.Text) <= 7.0)))
			{
				AppendTextBox(Port_Incline, Conversions.ToString(Conversion.Val(Port_Incline.Text)));
				Interaction.SaveSetting("Health", "Setup", "Port_Incline", Port_Incline.Text);
			}
			break;
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		ControlLevel = 0;
	}

	public void CommsOff()
	{
		AppendTextBox(CommsNoBoard, "0");
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, Conversions.ToString(0));
	}

	private void CommsResetTM_Tick(object sender, EventArgs e)
	{
		if ((Conversion.Val(CommsResetInd.Text) == 10.0) | Display.UPOT8Startup)
		{
			AppendTextBox(CommsResetInd, "");
			CommsResetTM.Dispose();
			SerialPortOpen();
			if (mySerialPort.IsOpen)
			{
				ReadWrite();
			}
			WaitFlag = false;
		}
		else if (BoardError | !mySerialPort.IsOpen | BoardCheck)
		{
			AppendTextBox(CommsResetInd, Conversions.ToString(Conversion.Val(CommsResetInd.Text) + 1.0));
			if (Conversion.Val(CommsResetInd.Text) > 1.0)
			{
				WaitFlag = false;
			}
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

	private void AReadWrite()
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		AppendTextBox(CommsResetInd, "");
		ControlColorDarkGreenChange("CommsResetInd");
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

	private void ReadWrite()
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		AppendTextBox(CommsResetInd, "");
		ControlColorDarkGreenChange("CommsResetInd");
		if (ReadReg == 0)
		{
			if ((Operators.CompareString(Port_Speed.Text, "", TextCompare: false) > 0) & Display.EmergencyStop)
			{
				SetIOPot(Conversion.Val(Port_Speed.Text), IOPOT.SpeedIntXHold);
			}
			else
			{
				MyProject.Forms.IOPOT.ZeroSpeed();
				IOPOT.SpeedIntXHold = 0;
				SetIOPot(Conversion.Val(Port_Speed.Text), IOPOT.SpeedIntXHold);
			}
			ReadReg = 1;
		}
		else if (ReadReg == 1)
		{
			SetIOPot(Conversion.Val(Port_Incline.Text), IOPOT.GradientIntXHold);
			ReadReg = 0;
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

	private void InitializeIOPot()
	{
		SetAllPots(0);
	}

	private void SetAllPots(object Setting)
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		WaitFlag = true;
		ReturnType = "U";
		Array.Clear(serBuf, 0, serBuf.Length);
		serBuf[0] = 254;
		serBuf[1] = 171;
		serBuf[2] = Conversions.ToByte(Setting);
		Num = 3;
		NewData = true;
		WriteData();
	}

	public void SetIOPot(object Address, object Setting)
	{
		while (WaitFlag)
		{
			Application.DoEvents();
		}
		WaitFlag = true;
		ReturnType = "U";
		Array.Clear(serBuf, 0, serBuf.Length);
		serBuf[0] = 254;
		serBuf[1] = 170;
		serBuf[2] = Conversions.ToByte(Address);
		serBuf[3] = Conversions.ToByte(Setting);
		Num = 4;
		NewData = true;
		WriteData();
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
		ReturnType = "Outputs";
		Array.Clear(serBuf, 0, serBuf.Length);
		serBuf[0] = 110;
		serBuf[1] = 91;
		Num = 2;
		NewData = true;
		Relay1On = false;
		Relay2On = false;
		Relay3On = false;
		Relay4On = false;
		Relay5On = false;
		Relay6On = false;
		Relay7On = false;
		Relay8On = false;
		MotorSent = false;
		WriteData();
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
				ReturnType = "Outputs";
				Array.Clear(serBuf, 0, serBuf.Length);
				serBuf[0] = 110;
				serBuf[1] = 91;
				Num = 2;
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
				ReturnType = "Outputs";
				Array.Clear(serBuf, 0, serBuf.Length);
				byte b = (byte)(100 + MotorIndex);
				if (!MotorOnOff)
				{
					b += 10;
				}
				serBuf[0] = b;
				serBuf[1] = 91;
				Num = 2;
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
		EnableSpeakerTextTM(true);
	}

	private void TimerEnable(bool enable)
	{
		WriteDataTM.Enabled = enable;
	}

	public void EnableSpeakerTextTM(object enable)
	{
		try
		{
			Invoke(new SetTimerEnable(TimerEnable), enable);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			TimerEnable(Conversions.ToBoolean(enable));
			ProjectData.ClearProjectError();
		}
	}

	private void WriteDataTM_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (mySerialPort.IsOpen & NewData)
				{
					WriteDataTM.Dispose();
					TimerEnable(enable: false);
					mySerialPort.Write(serBuf, 0, Num);
					NewData = false;
					BoardCheck = true;
					CommsResetTM.Enabled = true;
					AppendTextBox(CommsResetInd, "");
					ControlColorGreenYellowChange("CommsResetInd");
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
					Display.IOPOTCommsActive = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				AppendTextBox(ErrorReporting, "Device Failed");
				BoardError = true;
				Display.IOPOTCommsActive = false;
				SerialPortClose(isAppEnd: false);
				WriteDataTM.Dispose();
				ProjectData.ClearProjectError();
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
				if ((Operators.CompareString(IndicatorS, ">", TextCompare: false) == 0) | (Operators.CompareString(IndicatorS, null, TextCompare: false) == 0))
				{
					IndicatorS = "<";
				}
				else
				{
					IndicatorS = ">";
				}
				byte b = (byte)(Num - 1);
				byte b2 = 0;
				while (unchecked((uint)b2 <= (uint)b))
				{
					text = text + "," + Conversion.Val(serBuf[b2]);
					b2 = (byte)unchecked((uint)(b2 + 1));
				}
				string text2 = Strings.Mid(Send.Text, 1, 200);
				AppendTextBox(Send, text + IndicatorS + text2);
				Display.IOPOTCommsActive = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				AppendTextBox(ErrorReporting, "Device Failed");
				BoardError = true;
				Display.IOPOTCommsActive = false;
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

	public void ReadDataReceived(object ReceivedText)
	{
		textIn = Conversions.ToString(Operators.ConcatenateObject(textIn, ReceivedText));
		if ((Operators.CompareString(IndicatorR, "<", TextCompare: false) == 0) | (Operators.CompareString(IndicatorR, null, TextCompare: false) == 0))
		{
			IndicatorR = ">";
		}
		else
		{
			IndicatorR = "<";
		}
		string right = Strings.Mid(ReceivedData.Text, 1, 200);
		AppendTextBox(ReceivedData, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ReceivedText, " "), IndicatorR), " "), right)));
		DataReceived = true;
		GetAck();
		IOPOT.IOPotCommsOK = CommsOK;
	}

	public void GetAck()
	{
		bool flag = false;
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
				case "U":
					IOPOT.SpeedSet = IOPOT.SpeedIntXHold;
					IOPOT.InclineByteSet = IOPOT.GradientIntXHold;
					break;
				case "Ident":
					AppendTextBox(IdentNo, textIn);
					IdentNo.Text = textIn;
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
					break;
				case "Volts":
					AppendTextBox(Volts, Conversion.Val(12).ToString());
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
						if ((b & (long)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
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
					break;
				}
				case "Inputs":
				{
					byte b = ((!(Conversion.Val(textIn) > 255.0)) ? ((byte)Math.Round(Conversion.Val(textIn))) : byte.MaxValue);
					DataReceivedBoard = "";
					byte b2 = 0;
					do
					{
						if ((b & (long)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
						{
							DataReceivedBoard = "1" + DataReceivedBoard;
						}
						else
						{
							DataReceivedBoard = "0" + DataReceivedBoard;
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
				while (NewData)
				{
					Application.DoEvents();
				}
				flag = true;
				WaitFlag = false;
			}
			textIn = "";
			BoardCheck = false;
			CommsResetTM.Dispose();
			ReadWrite();
		}
	}

	private void Invisible_Click(object sender, EventArgs e)
	{
		base.Visible = false;
		Hide();
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
				else
				{
					if (!Display.EmergencyStop)
					{
						Display.MotorForward = false;
					}
					if ((!Display.MotorForward & MotorSwitch[MotorIndex]) | (Display.MotorForward & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = Display.MotorForward;
						MotorSent = true;
					}
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
					if (!Display.EmergencyStop)
					{
						Display.MotorReverse = false;
					}
					if ((!Display.MotorReverse & MotorSwitch[MotorIndex]) | (Display.MotorReverse & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = Display.MotorReverse;
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
					if ((!Relay3On & MotorSwitch[MotorIndex]) | (Relay3On & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = Relay3On;
						MotorSent = true;
					}
				}
				else if ((!InclineReset & MotorSwitch[MotorIndex]) | (InclineReset & !MotorSwitch[MotorIndex]))
				{
					MotorOnOff = InclineReset;
					MotorSent = true;
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
					if ((!Relay4On & MotorSwitch[MotorIndex]) | (Relay4On & !MotorSwitch[MotorIndex]))
					{
						MotorOnOff = Relay4On;
						MotorSent = true;
					}
				}
				else if ((!InclineLearn & MotorSwitch[MotorIndex]) | (InclineLearn & !MotorSwitch[MotorIndex]))
				{
					MotorOnOff = InclineLearn;
					LearnOnOff = InclineLearn;
					MotorSent = true;
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex == 5)
			{
				if (RelayOveride && ((!Relay5On & MotorSwitch[MotorIndex]) | (Relay5On & !MotorSwitch[MotorIndex])))
				{
					MotorOnOff = Relay5On;
					MotorSent = true;
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex == 6)
			{
				if (RelayOveride && ((!Relay6On & MotorSwitch[MotorIndex]) | (Relay6On & !MotorSwitch[MotorIndex])))
				{
					MotorOnOff = Relay6On;
					MotorSent = true;
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex == 7)
			{
				if (RelayOveride && ((!Relay7On & MotorSwitch[MotorIndex]) | (Relay7On & !MotorSwitch[MotorIndex])))
				{
					MotorOnOff = Relay7On;
					MotorSent = true;
				}
				if (!MotorSent)
				{
					MotorIndex++;
				}
			}
			if (MotorIndex == 8)
			{
				if (RelayOveride && ((!Relay8On & MotorSwitch[MotorIndex]) | (Relay8On & !MotorSwitch[MotorIndex])))
				{
					MotorOnOff = Relay8On;
					MotorSent = true;
				}
				if (!MotorSent)
				{
					MotorIndex = 0;
				}
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

	private void CommsTM_Tick(object sender, EventArgs e)
	{
		if (mySerialPort.IsOpen)
		{
			CommsTM.Dispose();
			InitializeIOPot();
		}
		else
		{
			BoardError = true;
		}
		CommCheck = 0;
	}
}
