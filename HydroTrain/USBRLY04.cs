using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class USBRLY04 : Form
{
	public delegate void SetTextCallback(string text);

	private delegate void DelegateInvokeRead();

	private delegate void AppendTextBoxDelegate(TextBox TB, string txt);

	private delegate void AppendLabelDelegate(Label LB, string txt);

	private IContainer components;

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
	[AccessedThroughProperty("CommsNoBoardLb")]
	private Label _CommsNoBoardLb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsNoBoard")]
	private TextBox _CommsNoBoard;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Invisible")]
	private Button _Invisible;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsResetRelayTM")]
	private Timer _CommsResetRelayTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaitTimeRelay")]
	private Timer _WaitTimeRelay;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MotorSwitchTM")]
	private Timer _MotorSwitchTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SerialPortRelayBoard")]
	private SerialPort _SerialPortRelayBoard;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SerialAddress")]
	private ListBox _SerialAddress;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_comport")]
	private ComboBox _ComboBox_comport;

	public bool InclineReset;

	public bool InclineLearn;

	public bool LearnOnOff;

	public bool CommsActive;

	public bool Comms;

	public string Port;

	public bool PortOK;

	public bool EmergencyStopActive;

	public bool EmergencyStopSet;

	public bool[] MotorSwitch;

	public bool BoardError;

	public bool DataRelayReceived;

	public static bool RelayOveride;

	public static bool Relay4On;

	public static bool Relay3On;

	public static bool Relay2On;

	public static bool Relay1On;

	public int RelayT1;

	public string textInRelay;

	public bool CommsOK;

	public byte TypeCheck;

	private bool WaitRelayFlag;

	private bool EmergencyPushRelease;

	private string ReturnType;

	private string ItemName;

	private int ControlLevel;

	private int MotorIndex;

	private int MotorSwitchEnabled;

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

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OutputRelayData")]
	internal virtual TextBox OutputRelayData
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

	[field: AccessedThroughProperty("InputRelayData")]
	internal virtual TextBox InputRelayData
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

	[field: AccessedThroughProperty("SendRelay")]
	internal virtual TextBox SendRelay
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ReceivedDataRelay")]
	public virtual TextBox ReceivedDataRelay
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

	[field: AccessedThroughProperty("ErrorReportRelay")]
	internal virtual TextBox ErrorReportRelay
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

	[field: AccessedThroughProperty("TitleName")]
	internal virtual Label TitleName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer CommsResetRelayTM
	{
		[CompilerGenerated]
		get
		{
			return _CommsResetRelayTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsResetRelayTM_Tick;
			Timer timer = _CommsResetRelayTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_CommsResetRelayTM = value;
			timer = _CommsResetRelayTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer WaitTimeRelay
	{
		[CompilerGenerated]
		get
		{
			return _WaitTimeRelay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaitTimeRelay_Tick;
			Timer timer = _WaitTimeRelay;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_WaitTimeRelay = value;
			timer = _WaitTimeRelay;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer MotorSwitchTM
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
			Timer timer = _MotorSwitchTM;
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

	internal virtual Timer InfoEnterTM
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
			Timer timer = _InfoEnterTM;
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

	internal virtual SerialPort SerialPortRelayBoard
	{
		[CompilerGenerated]
		get
		{
			return _SerialPortRelayBoard;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			SerialDataReceivedEventHandler value2 = SerialPortRelayBoard_DataReceived;
			SerialPort serialPort = _SerialPortRelayBoard;
			if (serialPort != null)
			{
				serialPort.DataReceived -= value2;
			}
			_SerialPortRelayBoard = value;
			serialPort = _SerialPortRelayBoard;
			if (serialPort != null)
			{
				serialPort.DataReceived += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CommsResetRelayInd")]
	internal virtual TextBox CommsResetRelayInd
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

	internal virtual ListBox SerialAddress
	{
		[CompilerGenerated]
		get
		{
			return _SerialAddress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SerialAddress_Click;
			ListBox listBox = _SerialAddress;
			if (listBox != null)
			{
				listBox.Click -= value2;
			}
			_SerialAddress = value;
			listBox = _SerialAddress;
			if (listBox != null)
			{
				listBox.Click += value2;
			}
		}
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

	public USBRLY04()
	{
		base.Activated += RLY04_Activated;
		base.Load += USBRLY04_Load;
		base.Closing += USBRLY04_Closing;
		MotorSwitch = new bool[5];
		MotorIndex = 1;
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
		this.Label17 = new System.Windows.Forms.Label();
		this.TypeNo = new System.Windows.Forms.TextBox();
		this.VoltsLB = new System.Windows.Forms.Label();
		this.Volts = new System.Windows.Forms.TextBox();
		this.Relay4 = new System.Windows.Forms.Button();
		this.Relay3 = new System.Windows.Forms.Button();
		this.Relay2 = new System.Windows.Forms.Button();
		this.RelayOverideSw = new System.Windows.Forms.Button();
		this.Relay1 = new System.Windows.Forms.Button();
		this.Label16 = new System.Windows.Forms.Label();
		this.OutputRelayData = new System.Windows.Forms.TextBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.InputRelayData = new System.Windows.Forms.TextBox();
		this.Label11 = new System.Windows.Forms.Label();
		this.CommsNoBoardLb = new System.Windows.Forms.Label();
		this.CommsNoBoard = new System.Windows.Forms.TextBox();
		this.IdentNo = new System.Windows.Forms.TextBox();
		this.SendRelay = new System.Windows.Forms.TextBox();
		this.ReceivedDataRelay = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.ErrorReportRelay = new System.Windows.Forms.TextBox();
		this.Invisible = new System.Windows.Forms.Button();
		this.TitleName = new System.Windows.Forms.Label();
		this.CommsResetRelayTM = new System.Windows.Forms.Timer(this.components);
		this.WaitTimeRelay = new System.Windows.Forms.Timer(this.components);
		this.MotorSwitchTM = new System.Windows.Forms.Timer(this.components);
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.SerialPortRelayBoard = new System.IO.Ports.SerialPort(this.components);
		this.CommsResetRelayInd = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.SerialAddress = new System.Windows.Forms.ListBox();
		this.ComboBox_comport = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(109, 161);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(31, 13);
		this.Label17.TabIndex = 132;
		this.Label17.Text = "Type";
		this.TypeNo.Location = new System.Drawing.Point(112, 174);
		this.TypeNo.Name = "TypeNo";
		this.TypeNo.Size = new System.Drawing.Size(126, 20);
		this.TypeNo.TabIndex = 131;
		this.VoltsLB.AutoSize = true;
		this.VoltsLB.Location = new System.Drawing.Point(22, 295);
		this.VoltsLB.Name = "VoltsLB";
		this.VoltsLB.Size = new System.Drawing.Size(30, 13);
		this.VoltsLB.TabIndex = 130;
		this.VoltsLB.Text = "Volts";
		this.VoltsLB.UseWaitCursor = true;
		this.Volts.Location = new System.Drawing.Point(56, 292);
		this.Volts.Name = "Volts";
		this.Volts.Size = new System.Drawing.Size(44, 20);
		this.Volts.TabIndex = 129;
		this.Relay4.Location = new System.Drawing.Point(56, 209);
		this.Relay4.Name = "Relay4";
		this.Relay4.Size = new System.Drawing.Size(44, 26);
		this.Relay4.TabIndex = 125;
		this.Relay4.Text = "RL4";
		this.Relay4.UseVisualStyleBackColor = true;
		this.Relay3.Location = new System.Drawing.Point(6, 209);
		this.Relay3.Name = "Relay3";
		this.Relay3.Size = new System.Drawing.Size(44, 26);
		this.Relay3.TabIndex = 124;
		this.Relay3.Text = "RL3";
		this.Relay3.UseVisualStyleBackColor = true;
		this.Relay2.Location = new System.Drawing.Point(56, 169);
		this.Relay2.Name = "Relay2";
		this.Relay2.Size = new System.Drawing.Size(44, 26);
		this.Relay2.TabIndex = 123;
		this.Relay2.Text = "RL2";
		this.Relay2.UseVisualStyleBackColor = true;
		this.RelayOverideSw.Location = new System.Drawing.Point(6, 129);
		this.RelayOverideSw.Name = "RelayOverideSw";
		this.RelayOverideSw.Size = new System.Drawing.Size(94, 26);
		this.RelayOverideSw.TabIndex = 122;
		this.RelayOverideSw.Text = "Relays";
		this.RelayOverideSw.UseVisualStyleBackColor = true;
		this.Relay1.Location = new System.Drawing.Point(6, 169);
		this.Relay1.Name = "Relay1";
		this.Relay1.Size = new System.Drawing.Size(44, 26);
		this.Relay1.TabIndex = 121;
		this.Relay1.Text = "RL1";
		this.Relay1.UseVisualStyleBackColor = true;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(111, 239);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(44, 13);
		this.Label16.TabIndex = 119;
		this.Label16.Text = "Outputs";
		this.Label16.UseWaitCursor = true;
		this.OutputRelayData.Location = new System.Drawing.Point(114, 254);
		this.OutputRelayData.Multiline = true;
		this.OutputRelayData.Name = "OutputRelayData";
		this.OutputRelayData.Size = new System.Drawing.Size(225, 22);
		this.OutputRelayData.TabIndex = 118;
		this.OutputRelayData.Text = "Data";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(111, 281);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(53, 13);
		this.Label15.TabIndex = 117;
		this.Label15.Text = "Recieved";
		this.Label15.UseWaitCursor = true;
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(111, 197);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(36, 13);
		this.Label14.TabIndex = 116;
		this.Label14.Text = "Inputs";
		this.Label14.UseWaitCursor = true;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(111, 81);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(29, 13);
		this.Label13.TabIndex = 115;
		this.Label13.Text = "Sent";
		this.InputRelayData.Location = new System.Drawing.Point(112, 213);
		this.InputRelayData.Multiline = true;
		this.InputRelayData.Name = "InputRelayData";
		this.InputRelayData.Size = new System.Drawing.Size(225, 22);
		this.InputRelayData.TabIndex = 114;
		this.InputRelayData.Text = "Data";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(109, 117);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(31, 13);
		this.Label11.TabIndex = 113;
		this.Label11.Text = "Ident";
		this.CommsNoBoardLb.AutoSize = true;
		this.CommsNoBoardLb.Location = new System.Drawing.Point(10, 100);
		this.CommsNoBoardLb.Name = "CommsNoBoardLb";
		this.CommsNoBoardLb.Size = new System.Drawing.Size(28, 13);
		this.CommsNoBoardLb.TabIndex = 112;
		this.CommsNoBoardLb.Text = "Com";
		this.CommsNoBoard.Location = new System.Drawing.Point(44, 97);
		this.CommsNoBoard.Name = "CommsNoBoard";
		this.CommsNoBoard.Size = new System.Drawing.Size(44, 20);
		this.CommsNoBoard.TabIndex = 111;
		this.IdentNo.Location = new System.Drawing.Point(112, 133);
		this.IdentNo.Name = "IdentNo";
		this.IdentNo.Size = new System.Drawing.Size(126, 20);
		this.IdentNo.TabIndex = 110;
		this.SendRelay.Location = new System.Drawing.Point(112, 97);
		this.SendRelay.Name = "SendRelay";
		this.SendRelay.Size = new System.Drawing.Size(225, 20);
		this.SendRelay.TabIndex = 109;
		this.ReceivedDataRelay.Location = new System.Drawing.Point(112, 297);
		this.ReceivedDataRelay.Multiline = true;
		this.ReceivedDataRelay.Name = "ReceivedDataRelay";
		this.ReceivedDataRelay.Size = new System.Drawing.Size(225, 33);
		this.ReceivedDataRelay.TabIndex = 108;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(185, 7);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(65, 13);
		this.Label1.TabIndex = 107;
		this.Label1.Text = "Relay Board";
		this.ErrorReportRelay.Location = new System.Drawing.Point(188, 23);
		this.ErrorReportRelay.Multiline = true;
		this.ErrorReportRelay.Name = "ErrorReportRelay";
		this.ErrorReportRelay.Size = new System.Drawing.Size(161, 61);
		this.ErrorReportRelay.TabIndex = 106;
		this.ErrorReportRelay.Text = "No Error";
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(370, 12);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(62, 58);
		this.Invisible.TabIndex = 133;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = true;
		this.TitleName.AutoSize = true;
		this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TitleName.Location = new System.Drawing.Point(9, 9);
		this.TitleName.Name = "TitleName";
		this.TitleName.Size = new System.Drawing.Size(38, 20);
		this.TitleName.TabIndex = 134;
		this.TitleName.Text = "Title";
		this.WaitTimeRelay.Enabled = true;
		this.WaitTimeRelay.Interval = 10;
		this.MotorSwitchTM.Enabled = true;
		this.InfoEnterTM.Enabled = true;
		this.SerialPortRelayBoard.Parity = System.IO.Ports.Parity.Even;
		this.CommsResetRelayInd.Location = new System.Drawing.Point(357, 297);
		this.CommsResetRelayInd.Name = "CommsResetRelayInd";
		this.CommsResetRelayInd.Size = new System.Drawing.Size(44, 20);
		this.CommsResetRelayInd.TabIndex = 135;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(345, 281);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(78, 13);
		this.Label2.TabIndex = 136;
		this.Label2.Text = "Comms  Check";
		this.SerialAddress.FormattingEnabled = true;
		this.SerialAddress.Location = new System.Drawing.Point(344, 101);
		this.SerialAddress.Name = "SerialAddress";
		this.SerialAddress.Size = new System.Drawing.Size(79, 134);
		this.SerialAddress.TabIndex = 242;
		this.ComboBox_comport.CausesValidation = false;
		this.ComboBox_comport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ComboBox_comport.FormattingEnabled = true;
		this.ComboBox_comport.Location = new System.Drawing.Point(6, 44);
		this.ComboBox_comport.Name = "ComboBox_comport";
		this.ComboBox_comport.Size = new System.Drawing.Size(176, 32);
		this.ComboBox_comport.TabIndex = 243;
		this.ComboBox_comport.Text = "Select COM port";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(444, 371);
		base.ControlBox = false;
		base.Controls.Add(this.ComboBox_comport);
		base.Controls.Add(this.SerialAddress);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.CommsResetRelayInd);
		base.Controls.Add(this.TitleName);
		base.Controls.Add(this.Invisible);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.TypeNo);
		base.Controls.Add(this.VoltsLB);
		base.Controls.Add(this.Volts);
		base.Controls.Add(this.Relay4);
		base.Controls.Add(this.Relay3);
		base.Controls.Add(this.Relay2);
		base.Controls.Add(this.RelayOverideSw);
		base.Controls.Add(this.Relay1);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.OutputRelayData);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.InputRelayData);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.CommsNoBoardLb);
		base.Controls.Add(this.CommsNoBoard);
		base.Controls.Add(this.IdentNo);
		base.Controls.Add(this.SendRelay);
		base.Controls.Add(this.ReceivedDataRelay);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ErrorReportRelay);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "USBRLY04";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "USBRLY04";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public void SerialPortOpen()
	{
		Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0");
		if (Conversion.Val(Port) > 0.0)
		{
			AppendTextBox(CommsNoBoard, Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0"));
			GetSerialPortNames();
			Display.RLY04Startup = false;
		}
		if ((Conversion.Val(Port) > 0.0) & PortOK)
		{
			CommsNoBoard.BackColor = Color.Green;
			CommsActive = true;
			if (!SerialPortRelayBoard.IsOpen)
			{
				SerialPortRelayBoard.PortName = "Com" + Port;
				SerialPortRelayBoard.BaudRate = 9600;
				SerialPortRelayBoard.Parity = Parity.None;
				SerialPortRelayBoard.DataBits = 8;
				SerialPortRelayBoard.StopBits = StopBits.One;
				SerialPortRelayBoard.Handshake = Handshake.None;
				SerialPortRelayBoard.ReadTimeout = 500;
				SerialPortRelayBoard.WriteTimeout = 500;
				Comms = false;
				try
				{
					SerialPortRelayBoard.Open();
					BoardError = false;
					ErrorReporting("Port Open");
					AllOutputsOff();
					Comms = true;
				}
				catch (TimeoutException ex)
				{
					ProjectData.SetProjectError(ex);
					TimeoutException ex2 = ex;
					BoardError = true;
					ErrorReporting("Port Timeout Error");
					ProjectData.ClearProjectError();
				}
				catch (IOException ex3)
				{
					ProjectData.SetProjectError(ex3);
					IOException ex4 = ex3;
					BoardError = true;
					ErrorReporting("Port IO Error");
					ProjectData.ClearProjectError();
				}
				catch (SystemException ex5)
				{
					ProjectData.SetProjectError(ex5);
					SystemException ex6 = ex5;
					BoardError = true;
					ErrorReporting("Port System Error");
					ProjectData.ClearProjectError();
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					BoardError = true;
					ErrorReporting("Port Error");
					ProjectData.ClearProjectError();
				}
			}
			if (BoardError)
			{
				CommsResetRelayTM.Dispose();
				CloseSerialPortRelayBoard();
				ErrorReporting("Port Closed");
			}
		}
		else if (Conversion.Val(Port) > 0.0)
		{
			CommsNoBoard.BackColor = Color.Red;
			ErrorReporting("Com No Error");
			BoardError = true;
		}
		else
		{
			CommsNoBoard.BackColor = Color.Gray;
			CommsResetRelayTM.Dispose();
			CommsActive = false;
			Comms = false;
		}
		Interaction.SaveSetting("Health", "Setup", "Open" + base.Name.ToString(), Conversions.ToString(SerialPortRelayBoard.IsOpen));
	}

	public void GetSerialPortNames()
	{
		try
		{
			SerialAddress.Items.Clear();
			PortOK = false;
			Array array = Strings.Split(Display.AvailablePorts, ",");
			foreach (object item in array)
			{
				string text = Conversions.ToString(item);
				if (Operators.CompareString("COM" + Port, text, TextCompare: false) == 0)
				{
					PortOK = true;
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
		SerialPortRelayBoard.Close();
		CommsNoRelayBoardChange("0");
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, "0");
	}

	private void WritePortRelayBoard(byte command, byte addr, byte data, string Ack)
	{
		byte[] array = new byte[4];
		string text;
		if (Strings.InStr(SendRelay.Text, ">") == 0)
		{
			text = ">";
		}
		else if (Strings.InStr(SendRelay.Text, "<") == 0)
		{
			text = "<";
		}
		else if (Strings.InStr(SendRelay.Text, "^") == 0)
		{
			text = "^";
		}
		else if (Strings.InStr(SendRelay.Text, "*") == 0)
		{
			text = "*";
		}
		else
		{
			SendRelayChange(Conversions.ToString(addr));
			text = ">";
		}
		if (SerialPortRelayBoard.IsOpen && (!BoardError & (SerialPortRelayBoard.BytesToWrite <= 0)))
		{
			try
			{
				SendRelayChange(Conversions.ToString(addr) + " " + Conversions.ToString(data) + " " + text + "  " + SendRelay.Text);
				array[0] = command;
				array[1] = addr;
				array[2] = data;
				SerialPortRelayBoard.Write(array, 0, 3);
				CommsOK = GetAckRelay(data, addr, Ack);
			}
			catch (IOException ex)
			{
				ProjectData.SetProjectError(ex);
				IOException ex2 = ex;
				ErrorReporting("Port Write IO Error");
				CommsResetRelayTM.Dispose();
				CloseSerialPortRelayBoard();
				ProjectData.ClearProjectError();
			}
			catch (TimeoutException ex3)
			{
				ProjectData.SetProjectError(ex3);
				TimeoutException ex4 = ex3;
				ErrorReporting("Port Write Timeout Error");
				CommsResetRelayTM.Dispose();
				CloseSerialPortRelayBoard();
				ProjectData.ClearProjectError();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ErrorReporting("Port Write Ex Error");
				CommsResetRelayTM.Dispose();
				CloseSerialPortRelayBoard();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ErrorReporting(string ErrorText)
	{
		if (Strings.Len(ErrorReportRelay.Text) > 250)
		{
			ErrorReportRelayChange(ErrorText + "\r\n" + Strings.Mid(ErrorReportRelay.Text, 1, 150));
		}
		else
		{
			ErrorReportRelayChange(ErrorText + "\r\n" + ErrorReportRelay.Text);
		}
	}

	private void Output(byte Address, bool OnOff)
	{
		while (WaitRelayFlag)
		{
			Application.DoEvents();
		}
		if (!WaitRelayFlag && !BoardError)
		{
			byte command = byte.MaxValue;
			byte addr = Address;
			byte data = (byte)(OnOff ? 1 : 0);
			ReturnType = "NoReturn";
			WritePortRelayBoard(command, addr, data, ReturnType);
		}
	}

	public void AllOutputsOff()
	{
		byte b = 0;
		while (true)
		{
			if (WaitRelayFlag)
			{
				Application.DoEvents();
				continue;
			}
			if (!WaitRelayFlag & !BoardError)
			{
				Output(b, OnOff: false);
			}
			checked
			{
				b = (byte)unchecked((uint)(b + 1));
			}
			if ((uint)b > 3u)
			{
				break;
			}
		}
		Relay1On = false;
		Relay2On = false;
		Relay3On = false;
		Relay4On = false;
	}

	private void CloseSerialPortRelayBoard()
	{
		if (PortOK)
		{
			try
			{
				SerialPortRelayBoard.DiscardInBuffer();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ErrorReporting("Port IO Error Buffer");
				ProjectData.ClearProjectError();
			}
			try
			{
				SerialPortRelayBoard.Dispose();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ErrorReporting("Port IO Error Dispose");
				ProjectData.ClearProjectError();
			}
			try
			{
				SerialPortRelayBoard.Close();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ErrorReporting("Port IO Error Close");
				ProjectData.ClearProjectError();
			}
		}
		CommsResetRelayTM.Enabled = true;
		BoardError = true;
	}

	private void SerialPortRelayBoard_DataReceived(object sender, SerialDataReceivedEventArgs e)
	{
		try
		{
			Invoke(new DelegateInvokeRead(ReadDataReceived));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ReadDataReceived()
	{
		string text = "";
		string text2 = "";
		if (Operators.CompareString(ReturnType, "Ident", TextCompare: false) == 0)
		{
			text = ReadExistingFromPort();
		}
		else if (Operators.CompareString(ReturnType, "NoReturn", TextCompare: false) == 0)
		{
			text = ReadExistingFromPort();
		}
		else if (Operators.CompareString(ReturnType, "Type", TextCompare: false) == 0)
		{
			text = ReadByteFromPort();
			text2 = ReadExistingFromPort();
		}
		else if (Operators.CompareString(ReturnType, "Volts", TextCompare: false) == 0)
		{
			text = ReadByteFromPort();
			text2 = ReadExistingFromPort();
		}
		else if (Operators.CompareString(ReturnType, "Inputs", TextCompare: false) == 0)
		{
			text = ReadByteFromPort();
			text2 = ReadExistingFromPort();
			if (Operators.CompareString(text2, "", TextCompare: false) != 0)
			{
				ReturnType = "NoReturn";
			}
		}
		else if (Operators.CompareString(ReturnType, "Outputs", TextCompare: false) == 0)
		{
			text = ReadByteFromPort();
			text2 = ReadExistingFromPort();
		}
		textInRelay += text;
		if (Strings.Len(ReceivedDataRelay.Text) > 50)
		{
			ReceivedDataRelayChange(text + " " + Strings.Mid(ReceivedDataRelay.Text, 1, 30));
		}
		else
		{
			ReceivedDataRelayChange(text);
		}
		DataRelayReceived = true;
	}

	public string ReadExistingFromPort()
	{
		string result = "";
		try
		{
			result = SerialPortRelayBoard.ReadExisting();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string ReadByteFromPort()
	{
		string result = "";
		try
		{
			if (SerialPortRelayBoard.BytesToRead > 0)
			{
				result = Conversions.ToString(SerialPortRelayBoard.ReadByte());
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool WaitRelay(int tenms, bool ack)
	{
		WaitTimeRelay.Enabled = true;
		RelayT1 = 0;
		while ((RelayT1 < tenms) & !DataRelayReceived)
		{
			WaitRelayFlag = true;
			Application.DoEvents();
		}
		DataRelayReceived = false;
		WaitTimeRelay.Dispose();
		WaitRelayFlag = false;
		return ack;
	}

	private void WaitTimeRelay_Tick(object sender, EventArgs e)
	{
		checked
		{
			RelayT1++;
		}
	}

	public bool GetAckRelay(byte data, byte addr, string ack)
	{
		bool flag = false;
		if (Operators.CompareString(ack, "NoReturn", TextCompare: false) != 0)
		{
			while (Operators.CompareString(textInRelay, "", TextCompare: false) == 0)
			{
				Application.DoEvents();
			}
			flag = true;
		}
		else
		{
			flag = true;
		}
		ack = "";
		textInRelay = "";
		return flag;
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

	private void MotorSwitchTM_Tick(object sender, EventArgs e)
	{
		short num = 0;
		MotorSwitchTM.Dispose();
		MotorSwitchEnabled = 0;
		while (WaitRelayFlag)
		{
			Application.DoEvents();
		}
		checked
		{
			if (!WaitRelayFlag)
			{
				num = 1;
				if (RelayOveride)
				{
					if ((!Relay1On & MotorSwitch[num]) | (Relay1On & !MotorSwitch[num]))
					{
						Output((byte)num, Relay1On);
						MotorSwitch[num] = Relay1On;
					}
				}
				else if ((!Display.MotorForward & MotorSwitch[num]) | (Display.MotorForward & !MotorSwitch[num]))
				{
					MotorSwitch[num] = Display.MotorForward;
				}
				else if (MotorIndex == num)
				{
					Output((byte)num, Display.MotorForward);
				}
				if (MotorSwitch[1])
				{
					Display.MotorRun = true;
				}
				num++;
				if (RelayOveride)
				{
					if ((!Relay2On & MotorSwitch[num]) | (Relay2On & !MotorSwitch[num]))
					{
						Output((byte)num, Relay2On);
						MotorSwitch[num] = Relay2On;
					}
				}
				else if ((!Display.MotorReverse & MotorSwitch[num]) | (Display.MotorReverse & !MotorSwitch[num]))
				{
					MotorSwitch[num] = Display.MotorReverse;
				}
				else if (MotorIndex == num)
				{
					Output((byte)num, Display.MotorReverse);
				}
				if (MotorSwitch[2])
				{
					Display.MotorRun = true;
				}
				num++;
				if (RelayOveride)
				{
					if ((!Relay3On & MotorSwitch[num]) | (Relay3On & !MotorSwitch[num]))
					{
						Output((byte)num, Relay3On);
						MotorSwitch[num] = Relay3On;
					}
				}
				else if ((!InclineReset & MotorSwitch[num]) | (InclineReset & !MotorSwitch[num]))
				{
					MotorSwitch[num] = InclineReset;
				}
				else if (MotorIndex == num)
				{
					Output((byte)num, InclineReset);
				}
				num++;
				if (RelayOveride)
				{
					if ((!Relay4On & MotorSwitch[num]) | (Relay4On & !MotorSwitch[num]))
					{
						Output((byte)num, Relay4On);
						MotorSwitch[num] = Relay4On;
					}
				}
				else if ((!InclineLearn & MotorSwitch[num]) | (InclineLearn & !MotorSwitch[num]))
				{
					MotorSwitch[num] = InclineLearn;
				}
				else if (MotorIndex == num)
				{
					Output((byte)num, InclineLearn);
					LearnOnOff = InclineLearn;
				}
			}
			num = 1;
			do
			{
				unchecked
				{
					if (MotorSwitch[num])
					{
						string text = "Relay" + Conversions.ToString((int)num);
						ControlColorGreenChange(text);
					}
					else
					{
						string text = "Relay" + Conversions.ToString((int)num);
						ControlColorRedChange(text);
					}
				}
				num = (short)unchecked(num + 1);
			}
			while (num <= 4);
			MotorSwitchTM.Enabled = true;
			MotorIndex++;
			if (MotorIndex > 4)
			{
				MotorIndex = 1;
			}
		}
	}

	private void CommsNoBoard_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "CommsRelayBoard";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsNoBoardLb_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "CommsRelayBoard";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsSetting()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsRelay", TextCompare: false) == 0)
		{
			if (Operators.CompareString(CommsNoBoard.Text, "", TextCompare: false) == 0)
			{
				CommsNoRelayBoardChange("0");
			}
			MyProject.Forms.InfoEnter.Preload = CommsNoBoard.Text;
			InfoEnter.PasswordSet = CommsNoBoard.Text;
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsRelayBoard", TextCompare: false) == 0)
		{
			CommsNoRelayBoardChange(InfoEnter.PasswordSet);
			CommsNoBoard.TextAlign = HorizontalAlignment.Left;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		string itemName2 = ItemName;
		if (Operators.CompareString(itemName2, "CommsRelayBoard", TextCompare: false) == 0)
		{
			if ((Operators.CompareString(CommsNoBoard.Text, "", TextCompare: false) == 0) | (Conversion.Val(CommsNoBoard.Text) == 0.0))
			{
				if (Operators.CompareString(CommsNoBoard.Text, "ZERO", TextCompare: false) == 0)
				{
					CommsOff();
				}
			}
			else
			{
				CommsNoRelayBoardChange(Conversions.ToString(Conversion.Val(CommsNoBoard.Text)));
				Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, CommsNoBoard.Text);
				CommsResetRelayTM.Dispose();
				CloseSerialPortRelayBoard();
			}
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		ControlLevel = 0;
	}

	private void CommsResetRelayTM_Tick(object sender, EventArgs e)
	{
		if ((Conversion.Val(CommsResetRelayInd.Text) == 50.0) | Display.RLY04Startup)
		{
			CommsResetRelayIndChange("");
			CommsResetRelayTM.Dispose();
			CloseSerialPortRelayBoard();
			if (!SerialPortRelayBoard.IsOpen)
			{
				SerialPortOpen();
			}
			return;
		}
		checked
		{
			if (!MotorSwitchTM.Enabled)
			{
				MotorSwitchEnabled++;
				if (MotorSwitchEnabled == 20)
				{
					MotorSwitchEnabled = 0;
					MotorSwitchTM.Enabled = true;
				}
			}
			if (BoardError | !SerialPortRelayBoard.IsOpen)
			{
				CommsResetRelayIndChange(Conversions.ToString(Conversion.Val(CommsResetRelayInd.Text) + 1.0));
			}
			else if (CommsResetRelayInd.BackColor == Color.DarkGreen)
			{
				CommsResetRelayIndChange("");
				ControlColorGreenYellowChange("CommsResetRelayInd");
			}
			else
			{
				CommsResetRelayIndChange("");
				ControlColorDarkGreenChange("CommsResetRelayInd");
			}
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
			AllOutputsOff();
			RelayOveride = false;
		}
	}

	private void RLY04_Activated(object sender, EventArgs e)
	{
		AppendLabel(TitleName, base.Name);
		AppendTextBox(CommsNoBoard, Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0"));
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

	private void Invisible_Click(object sender, EventArgs e)
	{
		Hide();
		RelayOverideSwChange("Relays Off");
		AllOutputsOff();
		RelayOveride = false;
	}

	private void CommsNoRelayBoardChange(string text)
	{
		if (CommsNoBoard.InvokeRequired)
		{
			SetTextCallback method = CommsNoRelayBoardChange;
			Invoke(method, text);
		}
		else
		{
			CommsNoBoard.Text = text;
		}
	}

	private void ErrorReportRelayChange(string text)
	{
		if (ErrorReportRelay.InvokeRequired)
		{
			SetTextCallback method = ErrorReportRelayChange;
			Invoke(method, text);
		}
		else
		{
			ErrorReportRelay.Text = text;
		}
	}

	private void SendRelayChange(string text)
	{
		if (SendRelay.InvokeRequired)
		{
			SetTextCallback method = SendRelayChange;
			Invoke(method, text);
		}
		else
		{
			SendRelay.Text = text;
		}
	}

	private void IdentNoChange(string text)
	{
		if (IdentNo.InvokeRequired)
		{
			SetTextCallback method = IdentNoChange;
			Invoke(method, text);
		}
		else
		{
			IdentNo.Text = text;
		}
	}

	private void TypeNoChange(string text)
	{
		if (TypeNo.InvokeRequired)
		{
			SetTextCallback method = TypeNoChange;
			Invoke(method, text);
		}
		else
		{
			TypeNo.Text = text;
		}
	}

	private void InputRelayDataChange(string text)
	{
		if (InputRelayData.InvokeRequired)
		{
			SetTextCallback method = InputRelayDataChange;
			Invoke(method, text);
		}
		else
		{
			InputRelayData.Text = text;
		}
	}

	private void OutputRelayDataChange(string text)
	{
		if (OutputRelayData.InvokeRequired)
		{
			SetTextCallback method = OutputRelayDataChange;
			Invoke(method, text);
		}
		else
		{
			OutputRelayData.Text = text;
		}
	}

	private void CommsResetRelayIndChange(string text)
	{
		if (CommsResetRelayInd.InvokeRequired)
		{
			SetTextCallback method = CommsResetRelayIndChange;
			Invoke(method, text);
		}
		else
		{
			CommsResetRelayInd.Text = text;
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

	private void ReceivedDataRelayChange(string text)
	{
		if (ReceivedDataRelay.InvokeRequired)
		{
			SetTextCallback method = ReceivedDataRelayChange;
			Invoke(method, text);
		}
		else
		{
			ReceivedDataRelay.Text = text;
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

	private void TitleNameChange(string text)
	{
		if (TitleName.InvokeRequired)
		{
			SetTextCallback method = TitleNameChange;
			Invoke(method, text);
		}
		else
		{
			TitleName.Text = text;
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

	private void USBRLY04_Load(object sender, EventArgs e)
	{
		if (Conversions.ToInteger(Interaction.GetSetting("Health", "Setup", "PortUSBRLY04", "0")) > 0)
		{
			Hide();
			CommsResetRelayTM.Enabled = true;
		}
	}

	public bool CheckComPort()
	{
		ReadOnlyCollection<string> serialPortNames = MyProject.Computer.Ports.SerialPortNames;
		if (serialPortNames.Contains("COM" + Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0")))
		{
			return true;
		}
		return false;
	}

	private void ComboBox_comport_SelectedIndexChanged(object sender, EventArgs e)
	{
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, Strings.Mid(ComboBox_comport.Text, 4, Strings.Len(ComboBox_comport.Text)));
		if (Conversions.ToInteger(Interaction.GetSetting("Health", "Setup", "Port" + base.Name)) > 0)
		{
			SerialPortOpen();
			return;
		}
		AppendTextBox(CommsNoBoard, "0");
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, "0");
		Port = "0";
		CommsOff();
	}

	private void USBRLY04_Closing(object sender, CancelEventArgs e)
	{
		SerialPortRelayBoard.Close();
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

	private void SerialAddress_Click(object sender, EventArgs e)
	{
		GetSerialPortNames();
	}
}
