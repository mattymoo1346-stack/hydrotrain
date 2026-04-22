#define DEBUG
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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

namespace HydroTrain;

[DesignerGenerated]
public class USBISS : Form
{
	public delegate void SetControlCallback(string Data);

	public delegate void SetControl1Callback(string ControlName, bool Data);

	public delegate void SetControl2Callback(string ControlName, string Setting, string Data);

	public delegate void SetControl3Callback(string ControlContainerA, string ControlName, string Setting, string Data);

	public delegate void SetControl4Callback(string ControlContainerB, string ControlContainerA, string ControlName, string Setting, string Data);

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
					Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.f") + " Protocol Error");
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

	public delegate void MyIntChangedEventHandler(string newTOT_CLIP);

	private delegate void AppendTextBoxDelegate(TextBox TB, string txt);

	private delegate void AppendLabelDelegate(Label LB, string txt);

	[CompilerGenerated]
	internal sealed class _Closure_0024__269_002D0
	{
		public char[] _0024VB_0024Local_loremch;

		public USBISS _0024VB_0024Me;

		public _Closure_0024__269_002D0(_Closure_0024__269_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_loremch = arg0._0024VB_0024Local_loremch;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			int num = 1;
			bool flag = false;
			List<byte> list = new List<byte>();
			Stopwatch stopwatch = Stopwatch.StartNew();
			checked
			{
				do
				{
					list.Clear();
					list.Add(2);
					list.AddRange(BitConverter.GetBytes(num));
					int num2 = prng.Next(1, 256);
					list.Add((byte)num2);
					list.AddRange(Encoding.GetEncoding(28591).GetBytes(_0024VB_0024Local_loremch, 0, num2));
					int num3 = 0;
					int num4 = list.Count - 1;
					for (int i = 6; i <= num4; i++)
					{
						num3 ^= list[i];
					}
					list.Add((byte)(num3 & 0xFF));
					byte[] array = list.ToArray();
					try
					{
						_0024VB_0024Me.mySerialPort.Write(array, 0, array.Length);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					num++;
					if (stopwatch.ElapsedMilliseconds >= 250)
					{
						stopwatch.Restart();
						_0024VB_0024Me.BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
						}));
					}
					if (flag || _0024VB_0024Me.slow)
					{
						Thread.Sleep(25);
					}
				}
				while (_0024VB_0024Me.runThreads.WaitOne(0));
			}
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("I2CType")]
	private Button _I2CType;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Invisible")]
	private Button _Invisible;

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
	[AccessedThroughProperty("ComboBox_comport")]
	private ComboBox _ComboBox_comport;

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

	public float ResMultiW;

	public float ResMultiH;

	public int CentreLocX;

	public int CentreLocY;

	public int LowLocY;

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

	private bool WaitISSFlag;

	private bool ReadReg;

	public bool USBISSError;

	private bool USBISSCheck;

	private string ReturnType;

	private byte[] serBuf;

	private byte[] IdentBuf;

	private byte Num;

	private bool NewData;

	private byte NumRec;

	private byte PortIndex;

	private byte RegPort;

	private bool SendOutputSpeed;

	private bool SendOutputIncline;

	private string Port;

	private byte PortA;

	private byte PortB;

	private bool PortOk;

	private string ReceivedText;

	private byte[] VersionByte;

	private string textInISS;

	private byte TypeCheck;

	private string DataReceivedBoard;

	private bool DataISSReceived;

	private bool ISSCommsOK;

	private string Indicator;

	private string ItemName;

	private int ControlLevel;

	private int CommCheck;

	public bool EmergencyStopActive;

	public bool I2CPotError;

	public bool ReadWriteFlag;

	public string I2CTypeSet;

	public bool NewDataRef;

	public static bool NewSerialNumberSet;

	public int NewSerialSet;

	private Stopwatch stpw;

	private Stopwatch UIstpw;

	public System.Threading.Timer InfoEnterTM;

	public System.Threading.Timer CommsResetTM;

	private static Random prng = new Random();

	private int minMessSz;

	private bool slow;

	[SpecialName]
	private Task _0024STATIC_0024Form1_FormClosing_002420211C12825_0024t;

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RegisterTwo")]
	internal virtual TextBox RegisterTwo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RegisterOne")]
	internal virtual TextBox RegisterOne
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ZeroAll")]
	internal virtual Button ZeroAll
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button I2CType
	{
		[CompilerGenerated]
		get
		{
			return _I2CType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = I2CType_Click;
			Button button = _I2CType;
			if (button != null)
			{
				button.Click -= value2;
			}
			_I2CType = value;
			button = _I2CType;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SetupNo")]
	internal virtual TextBox SetupNo
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

	[field: AccessedThroughProperty("VersionNo")]
	internal virtual TextBox VersionNo
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

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OutputISSData")]
	internal virtual TextBox OutputISSData
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

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	[field: AccessedThroughProperty("SendISS")]
	internal virtual TextBox SendISS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ReceivedData")]
	internal virtual TextBox ReceivedData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	public string TOT_CLIP
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
			MyIntChanged?.Invoke(value);
		}
	}

	public event MyIntChangedEventHandler MyIntChanged;

	public USBISS()
	{
		base.FormClosing += Form1_FormClosing;
		base.Load += Form1_Load;
		base.Activated += USBISS_Activated;
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
		serBuf = new byte[21];
		IdentBuf = new byte[21];
		PortA = 1;
		PortB = 3;
		VersionByte = new byte[21];
		stpw = Stopwatch.StartNew();
		UIstpw = Stopwatch.StartNew();
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
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.RegisterTwo = new System.Windows.Forms.TextBox();
		this.RegisterOne = new System.Windows.Forms.TextBox();
		this.ZeroAll = new System.Windows.Forms.Button();
		this.I2CType = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.SetupNo = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.VersionNo = new System.Windows.Forms.TextBox();
		this.SerialAddress = new System.Windows.Forms.ListBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.CommsResetInd = new System.Windows.Forms.TextBox();
		this.TitleName = new System.Windows.Forms.Label();
		this.Invisible = new System.Windows.Forms.Button();
		this.Label17 = new System.Windows.Forms.Label();
		this.TypeNo = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.OutputISSData = new System.Windows.Forms.TextBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.CommsNoBoardLb = new System.Windows.Forms.Label();
		this.CommsNoBoard = new System.Windows.Forms.TextBox();
		this.IdentNo = new System.Windows.Forms.TextBox();
		this.SendISS = new System.Windows.Forms.TextBox();
		this.ReceivedData = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.ErrorReporting = new System.Windows.Forms.TextBox();
		this.ComboBox_comport = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(277, 269);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(55, 13);
		this.Label6.TabIndex = 310;
		this.Label6.Text = "Register 2";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(197, 269);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(55, 13);
		this.Label5.TabIndex = 309;
		this.Label5.Text = "Register 1";
		this.RegisterTwo.Location = new System.Drawing.Point(275, 285);
		this.RegisterTwo.Name = "RegisterTwo";
		this.RegisterTwo.Size = new System.Drawing.Size(57, 20);
		this.RegisterTwo.TabIndex = 308;
		this.RegisterOne.Location = new System.Drawing.Point(195, 285);
		this.RegisterOne.Name = "RegisterOne";
		this.RegisterOne.Size = new System.Drawing.Size(57, 20);
		this.RegisterOne.TabIndex = 307;
		this.ZeroAll.Location = new System.Drawing.Point(236, 241);
		this.ZeroAll.Name = "ZeroAll";
		this.ZeroAll.Size = new System.Drawing.Size(57, 22);
		this.ZeroAll.TabIndex = 306;
		this.ZeroAll.Text = "All Off";
		this.ZeroAll.UseVisualStyleBackColor = true;
		this.I2CType.Location = new System.Drawing.Point(195, 181);
		this.I2CType.Name = "I2CType";
		this.I2CType.Size = new System.Drawing.Size(82, 22);
		this.I2CType.TabIndex = 305;
		this.I2CType.Text = "I2CType";
		this.I2CType.UseVisualStyleBackColor = true;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(194, 123);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(35, 13);
		this.Label4.TabIndex = 303;
		this.Label4.Text = "Setup";
		this.SetupNo.Location = new System.Drawing.Point(194, 139);
		this.SetupNo.Name = "SetupNo";
		this.SetupNo.Size = new System.Drawing.Size(126, 20);
		this.SetupNo.TabIndex = 302;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(15, 205);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(42, 13);
		this.Label3.TabIndex = 301;
		this.Label3.Text = "Version";
		this.VersionNo.Location = new System.Drawing.Point(12, 221);
		this.VersionNo.Name = "VersionNo";
		this.VersionNo.Size = new System.Drawing.Size(126, 20);
		this.VersionNo.TabIndex = 300;
		this.SerialAddress.FormattingEnabled = true;
		this.SerialAddress.Location = new System.Drawing.Point(356, 126);
		this.SerialAddress.Name = "SerialAddress";
		this.SerialAddress.Size = new System.Drawing.Size(71, 134);
		this.SerialAddress.TabIndex = 299;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(353, 344);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(78, 13);
		this.Label2.TabIndex = 298;
		this.Label2.Text = "Comms  Check";
		this.CommsResetInd.Location = new System.Drawing.Point(373, 363);
		this.CommsResetInd.Name = "CommsResetInd";
		this.CommsResetInd.Size = new System.Drawing.Size(44, 20);
		this.CommsResetInd.TabIndex = 297;
		this.TitleName.AutoSize = true;
		this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TitleName.Location = new System.Drawing.Point(14, 15);
		this.TitleName.Name = "TitleName";
		this.TitleName.Size = new System.Drawing.Size(38, 20);
		this.TitleName.TabIndex = 296;
		this.TitleName.Text = "Title";
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(373, 12);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(62, 58);
		this.Invisible.TabIndex = 295;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = true;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(13, 165);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(31, 13);
		this.Label17.TabIndex = 294;
		this.Label17.Text = "Type";
		this.TypeNo.Location = new System.Drawing.Point(12, 181);
		this.TypeNo.Name = "TypeNo";
		this.TypeNo.Size = new System.Drawing.Size(126, 20);
		this.TypeNo.TabIndex = 293;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(13, 250);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(44, 13);
		this.Label16.TabIndex = 292;
		this.Label16.Text = "Outputs";
		this.Label16.UseWaitCursor = true;
		this.OutputISSData.Location = new System.Drawing.Point(12, 266);
		this.OutputISSData.Multiline = true;
		this.OutputISSData.Name = "OutputISSData";
		this.OutputISSData.Size = new System.Drawing.Size(151, 22);
		this.OutputISSData.TabIndex = 291;
		this.OutputISSData.Text = "Data";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(13, 370);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(53, 13);
		this.Label15.TabIndex = 290;
		this.Label15.Text = "Recieved";
		this.Label15.UseWaitCursor = true;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(13, 295);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(29, 13);
		this.Label13.TabIndex = 289;
		this.Label13.Text = "Sent";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(13, 124);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(31, 13);
		this.Label11.TabIndex = 288;
		this.Label11.Text = "Ident";
		this.CommsNoBoardLb.AutoSize = true;
		this.CommsNoBoardLb.Location = new System.Drawing.Point(15, 96);
		this.CommsNoBoardLb.Name = "CommsNoBoardLb";
		this.CommsNoBoardLb.Size = new System.Drawing.Size(28, 13);
		this.CommsNoBoardLb.TabIndex = 287;
		this.CommsNoBoardLb.Text = "Com";
		this.CommsNoBoard.ForeColor = System.Drawing.Color.White;
		this.CommsNoBoard.Location = new System.Drawing.Point(49, 93);
		this.CommsNoBoard.Name = "CommsNoBoard";
		this.CommsNoBoard.Size = new System.Drawing.Size(44, 20);
		this.CommsNoBoard.TabIndex = 286;
		this.IdentNo.Location = new System.Drawing.Point(12, 140);
		this.IdentNo.Name = "IdentNo";
		this.IdentNo.Size = new System.Drawing.Size(126, 20);
		this.IdentNo.TabIndex = 285;
		this.SendISS.Location = new System.Drawing.Point(12, 311);
		this.SendISS.Multiline = true;
		this.SendISS.Name = "SendISS";
		this.SendISS.Size = new System.Drawing.Size(320, 46);
		this.SendISS.TabIndex = 284;
		this.ReceivedData.Location = new System.Drawing.Point(12, 386);
		this.ReceivedData.Multiline = true;
		this.ReceivedData.Name = "ReceivedData";
		this.ReceivedData.Size = new System.Drawing.Size(320, 46);
		this.ReceivedData.TabIndex = 283;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(194, 9);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(35, 13);
		this.Label7.TabIndex = 282;
		this.Label7.Text = "Board";
		this.ErrorReporting.Location = new System.Drawing.Point(194, 28);
		this.ErrorReporting.Multiline = true;
		this.ErrorReporting.Name = "ErrorReporting";
		this.ErrorReporting.Size = new System.Drawing.Size(161, 61);
		this.ErrorReporting.TabIndex = 281;
		this.ErrorReporting.Text = "No Error";
		this.ComboBox_comport.CausesValidation = false;
		this.ComboBox_comport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ComboBox_comport.FormattingEnabled = true;
		this.ComboBox_comport.Location = new System.Drawing.Point(12, 42);
		this.ComboBox_comport.Name = "ComboBox_comport";
		this.ComboBox_comport.Size = new System.Drawing.Size(176, 32);
		this.ComboBox_comport.TabIndex = 312;
		this.ComboBox_comport.Text = "Select COM port";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(463, 453);
		base.ControlBox = false;
		base.Controls.Add(this.ComboBox_comport);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.RegisterTwo);
		base.Controls.Add(this.RegisterOne);
		base.Controls.Add(this.ZeroAll);
		base.Controls.Add(this.I2CType);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.SetupNo);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.VersionNo);
		base.Controls.Add(this.SerialAddress);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.CommsResetInd);
		base.Controls.Add(this.TitleName);
		base.Controls.Add(this.Invisible);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.TypeNo);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.OutputISSData);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.CommsNoBoardLb);
		base.Controls.Add(this.CommsNoBoard);
		base.Controls.Add(this.IdentNo);
		base.Controls.Add(this.SendISS);
		base.Controls.Add(this.ReceivedData);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.ErrorReporting);
		this.ForeColor = System.Drawing.SystemColors.ControlText;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.IsMdiContainer = true;
		base.Name = "USBISS";
		this.RightToLeftLayout = true;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "USBISS";
		base.TopMost = true;
		base.TransparencyKey = System.Drawing.Color.White;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
	{
		Thread.Sleep(20);
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
			do
			{
				string text = "";
				while (mySerialPort.IsOpen && mySerialPort.BytesToRead > 0)
				{
					if (RcvInstr)
					{
						RcvThrdTime.Start();
					}
					RcvError = false;
					int bytesToRead = mySerialPort.BytesToRead;
					if (Operators.CompareString(ReturnType, "", TextCompare: false) == 0)
					{
						int num = 0;
						ReceivedText = "";
						int num2 = mySerialPort.BytesToRead - 1;
						for (num = 0; num <= num2; num++)
						{
							VersionByte[num] = (byte)mySerialPort.ReadByte();
							ReceivedText = ReceivedText + Conversion.Val(VersionByte[num]) + "  ";
						}
					}
					try
					{
						switch (ReturnType)
						{
						case "Ident":
							if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
							{
								int num10 = 0;
								int num11 = mySerialPort.BytesToRead - 1;
								for (num10 = 0; num10 <= num11; num10++)
								{
									IdentBuf[num10] = (byte)mySerialPort.ReadByte();
								}
								ReceivedText = Conversions.ToString(IdentBuf[2]);
							}
							else
							{
								ReceivedText = mySerialPort.ReadExisting();
							}
							break;
						case "NoReturn":
						{
							string text5 = mySerialPort.ReadExisting();
							break;
						}
						case "Type":
						{
							if (mySerialPort.BytesToRead > 0)
							{
								ReceivedText = Conversions.ToString(mySerialPort.ReadByte());
							}
							string text5 = mySerialPort.ReadExisting();
							break;
						}
						case "Setup":
						{
							if (mySerialPort.BytesToRead > 0)
							{
								ReceivedText = Conversions.ToString(mySerialPort.ReadByte());
							}
							string text5 = mySerialPort.ReadExisting();
							break;
						}
						case "Version":
						{
							int num8 = 0;
							if (mySerialPort.BytesToRead > 0)
							{
								int num9 = mySerialPort.BytesToRead - 1;
								for (num8 = 0; num8 <= num9; num8++)
								{
									VersionByte[num8] = (byte)mySerialPort.ReadByte();
									ReceivedText = ReceivedText + Conversion.Val(VersionByte[num8]) + "  ";
								}
							}
							string text5 = mySerialPort.ReadExisting();
							break;
						}
						case "Control":
						{
							int num12 = 0;
							if (mySerialPort.BytesToRead > 0)
							{
								int num13 = mySerialPort.BytesToRead - 1;
								for (num12 = 0; num12 <= num13; num12++)
								{
									VersionByte[num12] = (byte)mySerialPort.ReadByte();
									ReceivedText = ReceivedText + Conversion.Val(VersionByte[num12]) + "  ";
								}
							}
							string text5 = mySerialPort.ReadExisting();
							break;
						}
						case "Register":
						{
							int num6 = 0;
							int num7 = mySerialPort.BytesToRead - 1;
							for (num6 = 0; num6 <= num7; num6++)
							{
								try
								{
									ReceivedText = ReceivedText + " " + Conversions.ToString((byte)mySerialPort.ReadByte());
								}
								catch (Exception ex3)
								{
									ProjectData.SetProjectError(ex3);
									Exception ex4 = ex3;
									ProjectData.ClearProjectError();
								}
							}
							string text5 = mySerialPort.ReadExisting();
							break;
						}
						case "Outputs":
						{
							int num3 = 0;
							string text2 = "";
							string receivedText = "";
							string left = "";
							string text3 = "";
							int num4 = mySerialPort.BytesToRead - 1;
							int num5 = num4;
							for (num3 = 0; num3 <= num5; num3++)
							{
								try
								{
									string text4 = mySerialPort.ReadByte().ToString();
									if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
									{
										if (num4 == 10)
										{
											if (num3 == 7)
											{
												receivedText = text4;
											}
											if (num3 == 8)
											{
												left = text4;
											}
											if (num3 == 9)
											{
												text3 = text4;
												if (RegPort == 3)
												{
													if (Operators.CompareString(left, "0", TextCompare: false) == 0)
													{
														ReceivedText = receivedText;
													}
													else if (Operators.CompareString(left, "255", TextCompare: false) == 0)
													{
														ReceivedText = text3;
													}
												}
												if (RegPort == 1)
												{
													if (Operators.CompareString(left, "0", TextCompare: false) == 0)
													{
														ReceivedText = text3;
													}
													else if (Operators.CompareString(left, "255", TextCompare: false) == 0)
													{
														ReceivedText = receivedText;
													}
												}
											}
										}
									}
									else if (num3 < 1)
									{
										ReceivedText = ReceivedText + " " + text4;
									}
									text2 = text2 + " " + text4;
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ProjectData.ClearProjectError();
								}
							}
							if (Operators.CompareString(ReceivedText, "", TextCompare: false) == 0)
							{
							}
							string text5 = mySerialPort.ReadExisting();
							break;
						}
						}
						TOT_CLIP = ReceivedText;
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
				rcvARE.WaitOne();
			}
			while (runThreads.WaitOne(0));
		}
	}

	private void ReceiveOld()
	{
		checked
		{
			do
			{
				RcvReadCT = 0;
				while (mySerialPort.IsOpen && mySerialPort.BytesToRead > 0)
				{
					if (RcvInstr)
					{
						RcvThrdTime.Start();
					}
					RcvError = false;
					try
					{
						int bytesToRead = mySerialPort.BytesToRead;
						byte[] array = new byte[bytesToRead - 1 + 1];
						bytesToRead = mySerialPort.Read(array, 0, bytesToRead);
						if (bytesToRead != array.Length)
						{
							Array.Resize(ref array, bytesToRead);
						}
						if (RcvInstr)
						{
							RcvByteTot += bytesToRead;
						}
						if (RcvInstr)
						{
							RcvBuffAddTime.Start();
						}
						Monitor.Enter(RuntimeHelpers.GetObjectValue(rcvBufLock));
						RcvBuffer.AddRange(array);
						Monitor.Exit(RuntimeHelpers.GetObjectValue(rcvBufLock));
						if (RcvInstr)
						{
							RcvBuffAddTime.Stop();
						}
						RcvReadCT++;
						if (RcvReadCT == 1)
						{
							protoARE.Set();
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception item = ex;
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
				if (RcvReadCT > 1)
				{
					if (RcvInstr)
					{
						RcvMultiRead++;
					}
					protoARE.Set();
				}
				else if (RcvInstr && RcvReadCT == 0)
				{
					RcvNoData++;
				}
				rcvARE.WaitOne();
			}
			while (runThreads.WaitOne(0));
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
			Display.USBISSStartup = false;
			Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0");
			if ((Conversions.ToInteger(Port) > 0) & Functions.SerialPortCheck(Conversions.ToInteger(Port)))
			{
				AppendTextBox(CommsNoBoard, Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0"));
				GetSerialPortNames();
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
				Display.IOPOTCommsActive = true;
				USBISSError = false;
				ControlColorGreenChange("CommsNoBoard");
				AppendTextBox(ErrorReporting, "Port Open");
				mySerialPort.DtrEnable = true;
				CommsResetTMon();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				USBISSError = true;
				Display.IOPOTCommsActive = false;
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
			protoARE.Reset();
			rcvThrd = new Thread(Receive);
			rcvThrd.IsBackground = true;
			rcvThrd.Priority = ThreadPriority.AboveNormal;
			protoThrd = new Thread(Protocol);
			protoThrd.IsBackground = true;
			pinserrorsThrd = new Thread(PinsAndErrors);
			pinserrorsThrd.IsBackground = true;
			runThreads.Set();
			pinserrorsThrd.Start();
			protoThrd.Start();
			rcvThrd.Start();
			while ((pinserrorsThrd.ThreadState & System.Threading.ThreadState.Unstarted) == System.Threading.ThreadState.Unstarted || (protoThrd.ThreadState & System.Threading.ThreadState.Unstarted) == System.Threading.ThreadState.Unstarted || (rcvThrd.ThreadState & System.Threading.ThreadState.Unstarted) == System.Threading.ThreadState.Unstarted)
			{
				Thread.Sleep(10);
			}
		}
	}

	private void SerialPortClose(bool isAppEnd)
	{
		runThreads.Reset();
		protoARE.Set();
		rcvARE.Set();
		pinsErrorsARE.Set();
		protoThrd.Join();
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
			protoARE.Dispose();
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

	private void Protocolx()
	{
		SimulateDevice();
	}

	private void ProtocolA()
	{
		List<ComplexDeviceProto> list = new List<ComplexDeviceProto>();
		long num = 0L;
		long num2 = 0L;
		int num3 = 0;
		checked
		{
			while (true)
			{
				ComplexDeviceProto complexDeviceProto = new ComplexDeviceProto(ref RcvBuffer, ref rcvBufLock);
				if (complexDeviceProto.isValid())
				{
					list.Add(complexDeviceProto);
					num2 += complexDeviceProto.DataLength();
				}
				if (complexDeviceProto.isComplete() && RcvBuffer.Count >= minMessSz)
				{
					continue;
				}
				if (list.Count > 0)
				{
					if (list.Count > num3)
					{
						num3 = list.Count;
					}
					num += list.Count;
					list.Clear();
					try
					{
						if (UIstpw.ElapsedMilliseconds >= 250)
						{
							UIstpw.Restart();
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				protoARE.WaitOne();
				if (!runThreads.WaitOne(0))
				{
					break;
				}
			}
		}
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

	private void Form1_Load(object sender, EventArgs e)
	{
		SetupThreadTimerOperations();
		if (Conversion.Val(Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0")) > 0.0)
		{
			Hide();
			SerialPortOpen();
		}
		SetResScreen();
	}

	public void SetupThreadTimerOperations()
	{
		CommsResetTMSet();
		InfoEnterTMSet();
	}

	private void SetResScreen()
	{
		int num = 492;
		int num2 = 479;
		base.Height = num;
		base.Width = num2;
		checked
		{
			CentreLocX = (int)Math.Round((double)Screen.PrimaryScreen.Bounds.Width - (double)Screen.PrimaryScreen.Bounds.Width / 2.0 - (double)num2 / 2.0);
			CentreLocY = (int)Math.Round((double)Screen.PrimaryScreen.Bounds.Height - (double)Screen.PrimaryScreen.Bounds.Height / 2.0 - (double)num / 2.0 - (double)num / 4.0);
			LowLocY = CentreLocY * 2;
			SetLocation(CentreLocX, CentreLocY);
		}
	}

	public void SetLocation(int LocX, int LocY)
	{
		base.Location = new Point(LocX, LocY);
	}

	private void USBISS_Activated(object sender, EventArgs e)
	{
		AppendLabel(TitleName, base.Name);
		AppendTextBox(CommsNoBoard, Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0"));
		I2CTypeSet = Interaction.GetSetting("Health", "Setup", "I2CType", "Davantect");
		ControlChange("I2CType", "Text", I2CTypeSet);
		Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0");
		GetSerialPortNames();
		foreach (string serialPortName in MyProject.Computer.Ports.SerialPortNames)
		{
			if (Conversions.ToInteger(Interaction.GetSetting("Health", "Setup", "COM" + serialPortName, "0")) == 0)
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
			ItemName = "CommsISSBoard";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsNoBoardLb_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "CommsISSBoard";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsSetting()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTMon();
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsISSBoard", TextCompare: false) == 0)
		{
			if (Operators.CompareString(CommsNoBoard.Text, "", TextCompare: false) == 0)
			{
				AppendTextBox(CommsNoBoard, "0");
			}
			MyProject.Forms.InfoEnter.Preload = CommsNoBoard.Text;
			InfoEnter.PasswordSet = CommsNoBoard.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
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
		if (Operators.CompareString(itemName, "CommsISSBoard", TextCompare: false) == 0)
		{
			AppendTextBox(CommsNoBoard, InfoEnter.PasswordSet);
			CommsNoBoard.TextAlign = HorizontalAlignment.Left;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		string itemName2 = ItemName;
		if (Operators.CompareString(itemName2, "CommsISSBoard", TextCompare: false) == 0)
		{
			if ((Operators.CompareString(CommsNoBoard.Text, "", TextCompare: false) == 0) | (Conversion.Val(CommsNoBoard.Text) == 0.0))
			{
				if (Operators.CompareString(CommsNoBoard.Text, "ZERO", TextCompare: false) == 0)
				{
					AppendTextBox(CommsNoBoard, "0");
					Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, Conversions.ToString(0));
					Port = "0";
					CommsOff();
				}
			}
			else
			{
				AppendTextBox(CommsNoBoard, CommsNoBoard.Text);
				Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, CommsNoBoard.Text);
				CommsResetTMon();
			}
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTMOff();
		ControlLevel = 0;
	}

	public void CommsResetTMSet()
	{
		CommsResetTM = new System.Threading.Timer(CommsResetTM_Tick, null, -1, -1);
	}

	public void CommsResetTMOff()
	{
		CommsResetTM.Change(-1, -1);
	}

	public void CommsResetTMon()
	{
		CommsResetTM.Change(400, 400);
	}

	public void CommsOff()
	{
		mySerialPort.Close();
		if (Operators.CompareString(Port, "0", TextCompare: false) == 0)
		{
			CommsResetTMOff();
		}
	}

	private void CommsResetTM_Tick(object sender)
	{
		if ((Conversion.Val(CommsResetInd.Text) == 5.0) | Display.USBISSStartup)
		{
			AppendTextBox(CommsResetInd, "");
			SerialPortOpen();
			if (mySerialPort.IsOpen)
			{
				ReadWrite();
			}
			WaitISSFlag = false;
		}
		else if (USBISSError | !mySerialPort.IsOpen | USBISSCheck | !ReadWriteFlag)
		{
			AppendTextBox(CommsResetInd, Conversions.ToString(Conversion.Val(CommsResetInd.Text) + 1.0));
			if (Conversion.Val(CommsResetInd.Text) > 1.0)
			{
				WaitISSFlag = false;
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
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		if (Conversion.Val(IdentNo.Text) == 0.0)
		{
			GlobalIdent();
		}
		else if ((Operators.CompareString(Strings.Mid(SetupNo.Text, 1, 3), "I2C", TextCompare: false) != 0) & (Operators.CompareString(Strings.Mid(SetupNo.Text, 1, 3), "NCD", TextCompare: false) != 0))
		{
			SetMode();
		}
		else if (Operators.CompareString(VersionNo.Text, "", TextCompare: false) == 0)
		{
			GlobalVersion();
		}
		else if (Operators.CompareString(TypeNo.Text, "", TextCompare: false) == 0)
		{
			DetectIC2Pot();
			if (Operators.CompareString(TypeNo.Text, "", TextCompare: false) == 0)
			{
				I2CPotError = true;
			}
		}
		else
		{
			I2CPotError = false;
			if (!ReadReg)
			{
				ReadPortReg();
				ReadReg = true;
			}
			else
			{
				ReadReg = false;
				SendDataISS();
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

	private void GlobalIdent()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		WaitISSFlag = true;
		checked
		{
			if (NewSerialNumberSet)
			{
				NewSerialSet++;
				if (NewSerialSet < 5)
				{
					NewSerialSet++;
				}
				else if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
				{
					I2CTypeSet = "Davantect";
				}
				else
				{
					I2CTypeSet = "NCD";
				}
			}
			ReturnType = "Ident";
			Array.Clear(serBuf, 0, serBuf.Length);
			if (!USBISSError)
			{
				if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
				{
					serBuf[0] = 170;
					serBuf[1] = 2;
					serBuf[2] = 254;
					serBuf[3] = 33;
					serBuf[4] = (byte)Checksum(serBuf[0], serBuf[1], serBuf[2], serBuf[3], 0, 0, 0, 0);
					Num = 5;
					NewData = true;
				}
				else
				{
					serBuf[0] = 90;
					serBuf[1] = 3;
					Num = 2;
					NewData = true;
				}
			}
		}
	}

	public int Checksum(byte Byte1, byte Byte2, byte Byte3, byte Byte4, byte Byte5, byte Byte6, byte Byte7, byte Byte8)
	{
		int num = 0;
		byte[] array = new byte[8] { Byte1, Byte2, Byte3, Byte4, Byte5, Byte6, Byte7, Byte8 };
		checked
		{
			int num2 = array.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				num += array[i];
			}
			return num & 0xFF;
		}
	}

	private void GlobalType()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		WaitISSFlag = true;
		ReturnType = "Type";
		Array.Clear(serBuf, 0, serBuf.Length);
		if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
		{
			serBuf[0] = 170;
			serBuf[1] = 4;
			serBuf[2] = 190;
			serBuf[3] = 44;
			serBuf[4] = 3;
			serBuf[5] = 0;
			serBuf[6] = checked((byte)Checksum(serBuf[0], serBuf[1], serBuf[2], serBuf[3], serBuf[4], serBuf[5], serBuf[6], serBuf[7]));
			Num = 7;
			NewData = true;
		}
		else if (!USBISSError)
		{
			serBuf[0] = 90;
			serBuf[1] = 3;
			Num = 2;
			NewData = true;
		}
	}

	private void GlobalVersion()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		WaitISSFlag = true;
		ReturnType = "Version";
		Array.Clear(serBuf, 0, serBuf.Length);
		if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
		{
			if (!USBISSError)
			{
				serBuf[0] = 170;
				serBuf[1] = 3;
				serBuf[2] = 193;
				serBuf[3] = 0;
				serBuf[4] = 109;
				serBuf[5] = checked((byte)Checksum(serBuf[0], serBuf[1], serBuf[2], serBuf[3], serBuf[4], serBuf[5], serBuf[6], serBuf[7]));
				Num = 6;
				NewData = true;
			}
		}
		else if (!USBISSError)
		{
			serBuf[0] = 90;
			serBuf[1] = 1;
			Num = 2;
			NewData = true;
		}
	}

	private void SetMode()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		WaitISSFlag = true;
		ReturnType = "Setup";
		if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
		{
			Array.Clear(serBuf, 0, serBuf.Length);
			serBuf[0] = 170;
			serBuf[1] = 4;
			serBuf[2] = 190;
			serBuf[3] = 44;
			serBuf[4] = 3;
			serBuf[5] = 0;
			serBuf[6] = checked((byte)Checksum(serBuf[0], serBuf[1], serBuf[2], serBuf[3], serBuf[4], serBuf[5], serBuf[6], serBuf[7]));
			Num = 7;
			NewData = true;
		}
		else if (!USBISSError)
		{
			Array.Clear(serBuf, 0, serBuf.Length);
			serBuf[0] = 90;
			serBuf[1] = 2;
			serBuf[2] = 64;
			serBuf[3] = 0;
			Num = 4;
			NewData = true;
		}
	}

	private void DetectIC2Pot()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		WaitISSFlag = true;
		ReturnType = "Type";
		if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
		{
			Array.Clear(serBuf, 0, serBuf.Length);
			serBuf[0] = 170;
			serBuf[1] = 4;
			serBuf[2] = 190;
			serBuf[3] = 44;
			serBuf[4] = 0;
			serBuf[5] = 0;
			serBuf[6] = checked((byte)Checksum(serBuf[0], serBuf[1], serBuf[2], serBuf[3], serBuf[4], serBuf[5], serBuf[6], serBuf[7]));
			Num = 7;
			NewData = true;
		}
		else
		{
			Array.Clear(serBuf, 0, serBuf.Length);
			serBuf[0] = 88;
			serBuf[1] = 88;
			Num = 2;
			NewData = true;
			NumRec = 1;
		}
	}

	public void SendDataISS()
	{
		if (SendOutputSpeed)
		{
			SendOutputSpeed = false;
			ISSDataSend(PortA, IOPOT.SpeedIntXHold);
		}
		else if (SendOutputIncline)
		{
			SendOutputIncline = false;
			ISSDataSend(PortB, IOPOT.GradientIntXHold);
		}
		else
		{
			ReadWrite();
		}
	}

	private void ISSDataSend(byte PortReg, byte Data)
	{
		if (!USBISSError)
		{
			while (WaitISSFlag)
			{
				Application.DoEvents();
			}
			WaitISSFlag = true;
			ReturnType = "Register";
			if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
			{
				Array.Clear(serBuf, 0, serBuf.Length);
				serBuf[0] = 170;
				serBuf[1] = 4;
				serBuf[2] = 190;
				serBuf[3] = 44;
				serBuf[4] = PortReg;
				serBuf[5] = Data;
				serBuf[6] = checked((byte)Checksum(serBuf[0], serBuf[1], serBuf[2], serBuf[3], serBuf[4], serBuf[5], serBuf[6], serBuf[7]));
				Num = 7;
				NewData = true;
				NumRec = 1;
			}
			else
			{
				Array.Clear(serBuf, 0, serBuf.Length);
				serBuf[0] = 85;
				serBuf[1] = 88;
				serBuf[2] = PortReg;
				serBuf[3] = 1;
				serBuf[4] = Data;
				Num = 5;
				NewData = true;
				NumRec = 1;
			}
		}
	}

	private void ReadPortReg()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		WaitISSFlag = true;
		ReturnType = "Outputs";
		if (RegPort == PortA)
		{
			RegPort = PortB;
		}
		else
		{
			RegPort = PortA;
		}
		if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
		{
			Array.Clear(serBuf, 0, serBuf.Length);
			serBuf[0] = 170;
			serBuf[1] = 5;
			serBuf[2] = 191;
			serBuf[3] = 44;
			serBuf[4] = 8;
			serBuf[5] = 0;
			serBuf[6] = 0;
			serBuf[7] = checked((byte)Checksum(serBuf[0], serBuf[1], serBuf[2], serBuf[3], serBuf[4], serBuf[5], serBuf[6], serBuf[7]));
			Num = 8;
			NewData = true;
			NumRec = 1;
		}
		else
		{
			Array.Clear(serBuf, 0, serBuf.Length);
			serBuf[0] = 85;
			serBuf[1] = 89;
			serBuf[2] = RegPort;
			serBuf[3] = 2;
			Num = 4;
			NewData = true;
			NumRec = 2;
		}
	}

	private void Protocol()
	{
		checked
		{
			do
			{
				try
				{
					if (mySerialPort.IsOpen & NewData)
					{
						mySerialPort.Write(serBuf, 0, Num);
						NewData = false;
						USBISSCheck = true;
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
						string text2 = Strings.Mid(SendISS.Text, 1, 200);
						AppendTextBox(SendISS, text + Indicator + text2);
						Display.IOPOTCommsActive = true;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					AppendTextBox(ErrorReporting, "Device Failed");
					USBISSError = true;
					Display.IOPOTCommsActive = false;
					SerialPortClose(isAppEnd: false);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(100);
			}
			while (runThreads.WaitOne(0));
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
				string text2 = Strings.Mid(SendISS.Text, 1, 200);
				AppendTextBox(SendISS, text + Indicator + text2);
				Display.IOPOTCommsActive = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				AppendTextBox(ErrorReporting, "Device Failed");
				USBISSError = true;
				Display.IOPOTCommsActive = false;
				SerialPortClose(isAppEnd: false);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void AppendTextBox(TextBox TB, string txt)
	{
		try
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
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
		if (Operators.CompareString(ReceivedText, "-", TextCompare: false) == 0)
		{
			ReturnType = "Register";
		}
		textInISS += ReceivedText;
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
		DataISSReceived = true;
		ISSCommsOK = GetAckISS();
		IOPOT.IOPotCommsOK = ISSCommsOK;
	}

	public bool GetAckISS()
	{
		bool flag = false;
		ReadWriteFlag = false;
		if (Operators.CompareString(ReturnType, "NoReturn", TextCompare: false) != 0)
		{
			while (Operators.CompareString(textInISS, "", TextCompare: false) == 0)
			{
				Application.DoEvents();
			}
			flag = true;
			switch (ReturnType)
			{
			case "Ident":
				if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
				{
					if (Conversion.Val(textInISS) == 85.0)
					{
						AppendTextBox(IdentNo, "5252");
					}
				}
				else
				{
					AppendTextBox(IdentNo, textInISS);
					IdentNo.Text = textInISS;
				}
				if (NewSerialNumberSet)
				{
					if (Operators.CompareString(IdentNo.Text, "5252", TextCompare: false) == 0)
					{
						Interaction.SaveSetting("Health", "Setup", "I2CType", "NCD");
					}
					else
					{
						Interaction.SaveSetting("Health", "Setup", "I2CType", "Davantect");
					}
					NewSerialNumberSet = false;
				}
				break;
			case "Type":
				if (Operators.CompareString(Strings.Mid(textInISS, 1, 2), "13", TextCompare: false) == 0)
				{
					AppendTextBox(TypeNo, "USB-OPTO-RL816");
					TypeCheck = 2;
				}
				else if (Operators.CompareString(Strings.Mid(textInISS, 1, 2), "12", TextCompare: false) == 0)
				{
					AppendTextBox(TypeNo, "USB-OPTO-RL88");
					TypeCheck = 1;
				}
				else if (Operators.CompareString(Strings.Mid(textInISS, 1, 2), "8", TextCompare: false) == 0)
				{
					AppendTextBox(TypeNo, "USB-RL08B");
					TypeCheck = 1;
				}
				else if (Operators.CompareString(Strings.Mid(textInISS, 1, 2), "1", TextCompare: false) == 0)
				{
					AppendTextBox(TypeNo, "USB-ISS");
					TypeCheck = 1;
				}
				else if (Operators.CompareString(Strings.Mid(textInISS, 1, 3), "170", TextCompare: false) == 0)
				{
					AppendTextBox(TypeNo, "USB-NCD");
					TypeCheck = 1;
				}
				break;
			case "Version":
				AppendTextBox(VersionNo, textInISS);
				if (VersionByte[2] == 64)
				{
					AppendTextBox(VersionNo, "I2C_S_100KHZ");
				}
				else if (VersionByte[2] == 44)
				{
					AppendTextBox(VersionNo, "NCD_S_100KHZ");
				}
				break;
			case "Setup":
				if (Conversion.Val(textInISS) == 255.0)
				{
					AppendTextBox(SetupNo, "I2C");
				}
				else if (Conversion.Val(textInISS) == 170.0)
				{
					AppendTextBox(SetupNo, "NCD");
				}
				break;
			case "Outputs":
			{
				byte b;
				byte b2;
				if (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0)
				{
					b = ((!(Conversion.Val(textInISS) > 255.0)) ? Conversions.ToByte(textInISS) : byte.MaxValue);
					if (RegPort == 1)
					{
						AppendTextBox(RegisterOne, Conversions.ToString(b));
						IOPOT.SpeedSet = b;
						if ((IOPOT.SpeedIntXHold != b) | (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0))
						{
							SendOutputSpeed = true;
						}
					}
					else
					{
						AppendTextBox(RegisterTwo, Conversions.ToString(b));
						IOPOT.InclineByteSet = b;
						if ((IOPOT.GradientIntXHold != b) | (Operators.CompareString(I2CTypeSet, "NCD", TextCompare: false) == 0))
						{
							SendOutputIncline = true;
						}
					}
					DataReceivedBoard = "";
					b2 = 0;
					do
					{
						checked
						{
							if ((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
							{
								DataReceivedBoard = "1" + DataReceivedBoard;
							}
							else
							{
								DataReceivedBoard = "0" + DataReceivedBoard;
							}
							b2 = (byte)unchecked((uint)(b2 + 1));
						}
					}
					while ((uint)b2 <= 7u);
					AppendTextBox(OutputISSData, DataReceivedBoard);
					break;
				}
				b = ((!(Conversion.Val(textInISS) > 255.0)) ? Conversions.ToByte(textInISS) : byte.MaxValue);
				if (RegPort == 1)
				{
					AppendTextBox(RegisterOne, Conversions.ToString(b));
					IOPOT.SpeedSet = b;
					if (IOPOT.SpeedIntXHold != b)
					{
						SendOutputSpeed = true;
					}
				}
				else
				{
					AppendTextBox(RegisterTwo, Conversions.ToString(b));
					IOPOT.InclineByteSet = b;
					if (IOPOT.GradientIntXHold != b)
					{
						SendOutputIncline = true;
					}
				}
				DataReceivedBoard = "";
				b2 = 0;
				do
				{
					checked
					{
						if ((b & (byte)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
						{
							DataReceivedBoard = "1" + DataReceivedBoard;
						}
						else
						{
							DataReceivedBoard = "0" + DataReceivedBoard;
						}
						b2 = (byte)unchecked((uint)(b2 + 1));
					}
				}
				while ((uint)b2 <= 7u);
				AppendTextBox(OutputISSData, DataReceivedBoard);
				break;
			}
			}
			WaitISSFlag = false;
		}
		else
		{
			WaitISSFlag = false;
			flag = true;
		}
		bool result = flag;
		USBISSCheck = false;
		textInISS = "";
		ReadWrite();
		return result;
	}

	private void SimulateDeviceA()
	{
		_Closure_0024__269_002D0 arg = default(_Closure_0024__269_002D0);
		_Closure_0024__269_002D0 CS_0024_003C_003E8__locals7 = new _Closure_0024__269_002D0(arg);
		CS_0024_003C_003E8__locals7._0024VB_0024Me = this;
		string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean non vehicula sem, lacinia consequat sapien. Four score and seven years ago...";
		text += text;
		CS_0024_003C_003E8__locals7._0024VB_0024Local_loremch = text.ToCharArray();
		minMessSz = 8;
		Task task = Task.Run(checked([SpecialName] () =>
		{
			int num = 1;
			bool flag = false;
			List<byte> list = new List<byte>();
			Stopwatch stopwatch = Stopwatch.StartNew();
			do
			{
				list.Clear();
				list.Add(2);
				list.AddRange(BitConverter.GetBytes(num));
				int num2 = prng.Next(1, 256);
				list.Add((byte)num2);
				list.AddRange(Encoding.GetEncoding(28591).GetBytes(CS_0024_003C_003E8__locals7._0024VB_0024Local_loremch, 0, num2));
				int num3 = 0;
				int num4 = list.Count - 1;
				for (int i = 6; i <= num4; i++)
				{
					num3 ^= list[i];
				}
				list.Add((byte)(num3 & 0xFF));
				byte[] array = list.ToArray();
				try
				{
					CS_0024_003C_003E8__locals7._0024VB_0024Me.mySerialPort.Write(array, 0, array.Length);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				num++;
				if (stopwatch.ElapsedMilliseconds >= 250)
				{
					stopwatch.Restart();
					CS_0024_003C_003E8__locals7._0024VB_0024Me.BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
					}));
				}
				if (flag || CS_0024_003C_003E8__locals7._0024VB_0024Me.slow)
				{
					Thread.Sleep(25);
				}
			}
			while (CS_0024_003C_003E8__locals7._0024VB_0024Me.runThreads.WaitOne(0));
		}));
	}

	private void Invisible_Click(object sender, EventArgs e)
	{
		base.Visible = false;
		Hide();
	}

	private void ComboBox_comport_SelectedIndexChanged(object sender, EventArgs e)
	{
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, Strings.Mid(ComboBox_comport.Text, 4, Strings.Len(ComboBox_comport.Text)));
		if (Conversions.ToInteger(Interaction.GetSetting("Health", "Setup", "Port" + base.Name)) > 0)
		{
			NewSerialNumberSet = true;
			SerialPortOpen();
			return;
		}
		AppendTextBox(CommsNoBoard, "0");
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, "0");
		Port = "0";
		CommsOff();
	}

	private void I2CType_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			if (Operators.CompareString(I2CTypeSet, "Davantect", TextCompare: false) == 0)
			{
				I2CTypeSet = "NCD";
			}
			else
			{
				I2CTypeSet = "Davantect";
			}
			Interaction.SaveSetting("Health", "Setup", "I2CType", I2CTypeSet);
			ControlChange("I2CType", "Text", I2CTypeSet);
		}
	}

	public void ControlChange(string ControlName, string Setting, string Data)
	{
		if (base.Controls[ControlName].InvokeRequired)
		{
			SetControl2Callback method = ControlChange;
			Invoke(method, ControlName, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			base.Controls[ControlName].Text = Data;
		}
	}
}
