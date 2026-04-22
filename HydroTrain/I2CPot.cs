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
public class I2CPot : Form
{
	public delegate void SetTextCallback(string text);

	private delegate void DelegateInvokeRead();

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SendData")]
	private Button _SendData;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PortISS")]
	private Button _PortISS;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Invisible")]
	private Button _Invisible;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsNoISSBoardLb")]
	private Label _CommsNoISSBoardLb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsNoISSBoard")]
	private TextBox _CommsNoISSBoard;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsResetISS")]
	private Timer _CommsResetISS;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaitTimeISS")]
	private Timer _WaitTimeISS;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsTM")]
	private Timer _CommsTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SerialPortI2CBoard")]
	private SerialPort _SerialPortI2CBoard;

	public string Port;

	public string Ports;

	public bool PortOk;

	public bool Lift;

	public bool InclineReset;

	public bool InclineLearn;

	public bool LearnOnOff;

	public bool CommsActive;

	public bool Comms;

	public bool EmergencyStopActive;

	public bool EmergencyStopSet;

	public bool[] MotorSwitch;

	public bool I2CPotError;

	public bool DataISSReceived;

	public string textInISS;

	public int ISST1;

	public bool AirReleaseEmpty;

	public bool AirReleaseEmptyDelay;

	public bool AirReleaseFill;

	public bool AirReleaseFillDelay;

	public bool ISSCommsOK;

	public bool FloatSwFault;

	public bool HeaterInput;

	public bool CirculationInput;

	public static bool VoltageOK;

	public byte TypeCheck;

	private string DataReceivedBoard;

	private bool WaitISSFlag;

	private bool EmergencyPushRelease;

	private string ReturnType;

	private string ItemName;

	private int ControlLevel;

	private double OperatingTemp;

	private bool CoolingFan;

	private bool SandBoxInd;

	private bool SandBoxFlash;

	private int MotorSwitchEnabled;

	internal virtual Button SendData
	{
		[CompilerGenerated]
		get
		{
			return _SendData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SendData_Click;
			Button button = _SendData;
			if (button != null)
			{
				button.Click -= value2;
			}
			_SendData = value;
			button = _SendData;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button PortISS
	{
		[CompilerGenerated]
		get
		{
			return _PortISS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PortISS_Click;
			Button button = _PortISS;
			if (button != null)
			{
				button.Click -= value2;
			}
			_PortISS = value;
			button = _PortISS;
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

	[field: AccessedThroughProperty("CommsResetISSInd")]
	internal virtual TextBox CommsResetISSInd
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

	internal virtual Label CommsNoISSBoardLb
	{
		[CompilerGenerated]
		get
		{
			return _CommsNoISSBoardLb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsNoISSBoardLb_Click;
			Label label = _CommsNoISSBoardLb;
			if (label != null)
			{
				label.Click -= value2;
			}
			_CommsNoISSBoardLb = value;
			label = _CommsNoISSBoardLb;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox CommsNoISSBoard
	{
		[CompilerGenerated]
		get
		{
			return _CommsNoISSBoard;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsNoISSBoard_Click;
			TextBox textBox = _CommsNoISSBoard;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_CommsNoISSBoard = value;
			textBox = _CommsNoISSBoard;
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

	[field: AccessedThroughProperty("ReceivedDataISS")]
	public virtual TextBox ReceivedDataISS
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

	[field: AccessedThroughProperty("ErrorReportISS")]
	internal virtual TextBox ErrorReportISS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer CommsResetISS
	{
		[CompilerGenerated]
		get
		{
			return _CommsResetISS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsResetISS_Tick;
			Timer timer = _CommsResetISS;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_CommsResetISS = value;
			timer = _CommsResetISS;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer WaitTimeISS
	{
		[CompilerGenerated]
		get
		{
			return _WaitTimeISS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaitTimeISS_Tick;
			Timer timer = _WaitTimeISS;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_WaitTimeISS = value;
			timer = _WaitTimeISS;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("IndicatorFlashTM")]
	internal virtual Timer IndicatorFlashTM
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer CommsTM
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
			Timer timer = _CommsTM;
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

	internal virtual SerialPort SerialPortI2CBoard
	{
		[CompilerGenerated]
		get
		{
			return _SerialPortI2CBoard;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			SerialDataReceivedEventHandler value2 = SerialPortISSBoard_DataReceived;
			SerialPort serialPort = _SerialPortI2CBoard;
			if (serialPort != null)
			{
				serialPort.DataReceived -= value2;
			}
			_SerialPortI2CBoard = value;
			serialPort = _SerialPortI2CBoard;
			if (serialPort != null)
			{
				serialPort.DataReceived += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ResetEmergencyStop")]
	internal virtual Timer ResetEmergencyStop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CoolingFanTM")]
	internal virtual Timer CoolingFanTM
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("VoltsStableTM")]
	internal virtual Timer VoltsStableTM
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public I2CPot()
	{
		base.Activated += USB_ISS_Activated;
		base.Load += USB_ISS_Load;
		base.Closing += USB_ISS_Closing;
		MotorSwitch = new bool[9];
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
		this.SendData = new System.Windows.Forms.Button();
		this.PortISS = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.SetupNo = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.VersionNo = new System.Windows.Forms.TextBox();
		this.SerialAddress = new System.Windows.Forms.ListBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.CommsResetISSInd = new System.Windows.Forms.TextBox();
		this.TitleName = new System.Windows.Forms.Label();
		this.Invisible = new System.Windows.Forms.Button();
		this.Label17 = new System.Windows.Forms.Label();
		this.TypeNo = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.OutputISSData = new System.Windows.Forms.TextBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.CommsNoISSBoardLb = new System.Windows.Forms.Label();
		this.CommsNoISSBoard = new System.Windows.Forms.TextBox();
		this.IdentNo = new System.Windows.Forms.TextBox();
		this.SendISS = new System.Windows.Forms.TextBox();
		this.ReceivedDataISS = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.ErrorReportISS = new System.Windows.Forms.TextBox();
		this.CommsResetISS = new System.Windows.Forms.Timer(this.components);
		this.WaitTimeISS = new System.Windows.Forms.Timer(this.components);
		this.IndicatorFlashTM = new System.Windows.Forms.Timer(this.components);
		this.CommsTM = new System.Windows.Forms.Timer(this.components);
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.SerialPortI2CBoard = new System.IO.Ports.SerialPort(this.components);
		this.ResetEmergencyStop = new System.Windows.Forms.Timer(this.components);
		this.CoolingFanTM = new System.Windows.Forms.Timer(this.components);
		this.VoltsStableTM = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.SendData.Location = new System.Drawing.Point(198, 244);
		this.SendData.Name = "SendData";
		this.SendData.Size = new System.Drawing.Size(57, 22);
		this.SendData.TabIndex = 300;
		this.SendData.Text = "Send";
		this.SendData.UseVisualStyleBackColor = true;
		this.PortISS.Location = new System.Drawing.Point(278, 244);
		this.PortISS.Name = "PortISS";
		this.PortISS.Size = new System.Drawing.Size(57, 22);
		this.PortISS.TabIndex = 299;
		this.PortISS.Text = "Port 1";
		this.PortISS.UseVisualStyleBackColor = true;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(175, 104);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(35, 13);
		this.Label4.TabIndex = 298;
		this.Label4.Text = "Setup";
		this.SetupNo.Location = new System.Drawing.Point(178, 117);
		this.SetupNo.Name = "SetupNo";
		this.SetupNo.Size = new System.Drawing.Size(126, 20);
		this.SetupNo.TabIndex = 297;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(15, 187);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(42, 13);
		this.Label3.TabIndex = 296;
		this.Label3.Text = "Version";
		this.VersionNo.Location = new System.Drawing.Point(16, 203);
		this.VersionNo.Name = "VersionNo";
		this.VersionNo.Size = new System.Drawing.Size(126, 20);
		this.VersionNo.TabIndex = 295;
		this.SerialAddress.FormattingEnabled = true;
		this.SerialAddress.Location = new System.Drawing.Point(354, 132);
		this.SerialAddress.Name = "SerialAddress";
		this.SerialAddress.Size = new System.Drawing.Size(71, 134);
		this.SerialAddress.TabIndex = 294;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(358, 321);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(78, 13);
		this.Label2.TabIndex = 293;
		this.Label2.Text = "Comms  Check";
		this.CommsResetISSInd.Location = new System.Drawing.Point(379, 350);
		this.CommsResetISSInd.Name = "CommsResetISSInd";
		this.CommsResetISSInd.Size = new System.Drawing.Size(44, 20);
		this.CommsResetISSInd.TabIndex = 292;
		this.TitleName.AutoSize = true;
		this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TitleName.Location = new System.Drawing.Point(12, 21);
		this.TitleName.Name = "TitleName";
		this.TitleName.Size = new System.Drawing.Size(38, 20);
		this.TitleName.TabIndex = 291;
		this.TitleName.Text = "Title";
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(363, 26);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(62, 58);
		this.Invisible.TabIndex = 290;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = true;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(13, 148);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(31, 13);
		this.Label17.TabIndex = 289;
		this.Label17.Text = "Type";
		this.TypeNo.Location = new System.Drawing.Point(16, 161);
		this.TypeNo.Name = "TypeNo";
		this.TypeNo.Size = new System.Drawing.Size(126, 20);
		this.TypeNo.TabIndex = 288;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(15, 226);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(44, 13);
		this.Label16.TabIndex = 287;
		this.Label16.Text = "Outputs";
		this.Label16.UseWaitCursor = true;
		this.OutputISSData.Location = new System.Drawing.Point(16, 244);
		this.OutputISSData.Multiline = true;
		this.OutputISSData.Name = "OutputISSData";
		this.OutputISSData.Size = new System.Drawing.Size(151, 22);
		this.OutputISSData.TabIndex = 286;
		this.OutputISSData.Text = "Data";
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(114, 321);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(53, 13);
		this.Label15.TabIndex = 285;
		this.Label15.Text = "Recieved";
		this.Label15.UseWaitCursor = true;
		this.Label13.AutoSize = true;
		this.Label13.Location = new System.Drawing.Point(15, 275);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(29, 13);
		this.Label13.TabIndex = 284;
		this.Label13.Text = "Sent";
		this.Label11.AutoSize = true;
		this.Label11.Location = new System.Drawing.Point(13, 104);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(31, 13);
		this.Label11.TabIndex = 283;
		this.Label11.Text = "Ident";
		this.CommsNoISSBoardLb.AutoSize = true;
		this.CommsNoISSBoardLb.Location = new System.Drawing.Point(20, 71);
		this.CommsNoISSBoardLb.Name = "CommsNoISSBoardLb";
		this.CommsNoISSBoardLb.Size = new System.Drawing.Size(28, 13);
		this.CommsNoISSBoardLb.TabIndex = 282;
		this.CommsNoISSBoardLb.Text = "Com";
		this.CommsNoISSBoard.Location = new System.Drawing.Point(54, 68);
		this.CommsNoISSBoard.Name = "CommsNoISSBoard";
		this.CommsNoISSBoard.Size = new System.Drawing.Size(44, 20);
		this.CommsNoISSBoard.TabIndex = 281;
		this.IdentNo.Location = new System.Drawing.Point(16, 120);
		this.IdentNo.Name = "IdentNo";
		this.IdentNo.Size = new System.Drawing.Size(126, 20);
		this.IdentNo.TabIndex = 280;
		this.SendISS.Location = new System.Drawing.Point(16, 291);
		this.SendISS.Name = "SendISS";
		this.SendISS.Size = new System.Drawing.Size(429, 20);
		this.SendISS.TabIndex = 279;
		this.ReceivedDataISS.Location = new System.Drawing.Point(117, 337);
		this.ReceivedDataISS.Multiline = true;
		this.ReceivedDataISS.Name = "ReceivedDataISS";
		this.ReceivedDataISS.Size = new System.Drawing.Size(225, 46);
		this.ReceivedDataISS.TabIndex = 278;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(171, 21);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(35, 13);
		this.Label1.TabIndex = 277;
		this.Label1.Text = "Board";
		this.ErrorReportISS.Location = new System.Drawing.Point(174, 37);
		this.ErrorReportISS.Multiline = true;
		this.ErrorReportISS.Name = "ErrorReportISS";
		this.ErrorReportISS.Size = new System.Drawing.Size(161, 61);
		this.ErrorReportISS.TabIndex = 276;
		this.ErrorReportISS.Text = "No Error";
		this.WaitTimeISS.Enabled = true;
		this.WaitTimeISS.Interval = 10;
		this.CommsTM.Enabled = true;
		this.CommsTM.Interval = 1500;
		this.InfoEnterTM.Enabled = true;
		this.SerialPortI2CBoard.Parity = System.IO.Ports.Parity.Even;
		this.ResetEmergencyStop.Interval = 800;
		this.CoolingFanTM.Interval = 600000;
		this.VoltsStableTM.Interval = 2000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(464, 421);
		base.ControlBox = false;
		base.Controls.Add(this.SendData);
		base.Controls.Add(this.PortISS);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.SetupNo);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.VersionNo);
		base.Controls.Add(this.SerialAddress);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.CommsResetISSInd);
		base.Controls.Add(this.TitleName);
		base.Controls.Add(this.Invisible);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.TypeNo);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.OutputISSData);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.CommsNoISSBoardLb);
		base.Controls.Add(this.CommsNoISSBoard);
		base.Controls.Add(this.IdentNo);
		base.Controls.Add(this.SendISS);
		base.Controls.Add(this.ReceivedDataISS);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ErrorReportISS);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "I2CPot";
		this.Text = "I2CPot";
		base.TopMost = true;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public void ISSControl()
	{
		Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0");
		if (Conversion.Val(Port) > 0.0)
		{
			GetSerialPortNames();
			Display.RLY08Startup = false;
		}
		if ((Conversion.Val(Port) > 0.0) & PortOk)
		{
			CommsNoISSBoard.BackColor = Color.Green;
			CommsActive = true;
			if (!SerialPortI2CBoard.IsOpen)
			{
				SerialPortI2CBoard.PortName = "Com" + Port;
				SerialPortI2CBoard.BaudRate = 115200;
				SerialPortI2CBoard.Parity = Parity.None;
				SerialPortI2CBoard.DataBits = 8;
				SerialPortI2CBoard.StopBits = StopBits.One;
				SerialPortI2CBoard.Handshake = Handshake.None;
				SerialPortI2CBoard.ReadTimeout = 500;
				SerialPortI2CBoard.WriteTimeout = 500;
				Comms = false;
				try
				{
					SerialPortI2CBoard.Open();
					I2CPotError = false;
					ErrorReporting("Port Open");
					Comms = true;
				}
				catch (TimeoutException ex)
				{
					ProjectData.SetProjectError(ex);
					TimeoutException ex2 = ex;
					I2CPotError = true;
					ErrorReporting("Port Timeout Error");
					ProjectData.ClearProjectError();
				}
				catch (IOException ex3)
				{
					ProjectData.SetProjectError(ex3);
					IOException ex4 = ex3;
					I2CPotError = true;
					ErrorReporting("Port IO Error");
					ProjectData.ClearProjectError();
				}
				catch (SystemException ex5)
				{
					ProjectData.SetProjectError(ex5);
					SystemException ex6 = ex5;
					I2CPotError = true;
					ErrorReporting("Port System Error");
					ProjectData.ClearProjectError();
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					I2CPotError = true;
					ErrorReporting("Port Error");
					ProjectData.ClearProjectError();
				}
			}
			if (I2CPotError)
			{
				CloseSerialPortISSBoard();
				ErrorReporting("Port Closed");
			}
		}
		else if (Conversion.Val(Port) > 0.0)
		{
			CommsNoISSBoard.BackColor = Color.Red;
			ErrorReporting("Com No Error");
			I2CPotError = true;
		}
		else
		{
			CommsNoISSBoard.BackColor = Color.Gray;
			CommsResetISS.Dispose();
			CommsActive = false;
			Comms = false;
		}
		Interaction.SaveSetting("Health", "Setup", "Open" + base.Name.ToString(), Conversions.ToString(SerialPortI2CBoard.IsOpen));
	}

	public void CommsOff()
	{
		CommsNoISSBoardChange("0");
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, "0");
	}

	private void WritePortISSBoard(byte Header, byte ByteCount, byte Command, byte Data1, byte Data2, byte StartAddress, byte Checksum, string Ack)
	{
		byte[] array = new byte[11];
		string text = " ";
		string text2;
		if (Strings.InStr(SendISS.Text, ">") == 0)
		{
			text2 = ">";
		}
		else if (Strings.InStr(SendISS.Text, "<") == 0)
		{
			text2 = "<";
		}
		else if (Strings.InStr(SendISS.Text, "^") == 0)
		{
			text2 = "^";
		}
		else if (Strings.InStr(SendISS.Text, "*") == 0)
		{
			text2 = "*";
		}
		else
		{
			SendISSChange(">");
			text2 = ">";
		}
		if (!SerialPortI2CBoard.IsOpen || !(!I2CPotError & (SerialPortI2CBoard.BytesToWrite <= 0)))
		{
			return;
		}
		checked
		{
			try
			{
				short num = (short)(ByteCount + 1);
				for (short num2 = 0; num2 <= num; num2 = (short)unchecked(num2 + 1))
				{
					switch (num2)
					{
					case 0:
						array[num2] = Header;
						text = Header.ToString();
						text += ",";
						break;
					case 1:
						array[num2] = ByteCount;
						text += ByteCount;
						text += ",";
						break;
					case 2:
						array[num2] = Command;
						text += Command;
						text += ",";
						break;
					case 3:
						array[num2] = StartAddress;
						text += StartAddress;
						text += ",";
						break;
					case 4:
						array[num2] = Data1;
						text += Data1;
						text += ",";
						break;
					case 5:
						array[num2] = Data2;
						text += Data2;
						text += ",";
						break;
					}
				}
				array[ByteCount + 2] = Checksum;
				text += Checksum;
				SendISSChange(text + text2 + "  " + SendISS.Text);
				SerialPortI2CBoard.Write(array, 0, ByteCount + 2);
				ISSCommsOK = Conversions.ToBoolean(GetAckISS(Conversions.ToString(Command), Ack));
				Command = Conversions.ToByte("");
			}
			catch (IOException ex)
			{
				ProjectData.SetProjectError(ex);
				IOException ex2 = ex;
				ErrorReporting("Port Write IO Error");
				CloseSerialPortISSBoard();
				ProjectData.ClearProjectError();
			}
			catch (TimeoutException ex3)
			{
				ProjectData.SetProjectError(ex3);
				TimeoutException ex4 = ex3;
				ErrorReporting("Port Write Timeout Error");
				CloseSerialPortISSBoard();
				ProjectData.ClearProjectError();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ErrorReporting("Port Write Ex Error");
				CloseSerialPortISSBoard();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ErrorReporting(object ErrorText)
	{
		if (Strings.Len(ErrorReportISS.Text) > 250)
		{
			ErrorReportISSChange(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("", ErrorText), '\r'), '\n'), Strings.Mid(ErrorReportISS.Text, 1, 150))));
		}
		else
		{
			ErrorReportISSChange(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("", ErrorText), '\r'), '\n'), ErrorReportISS.Text)));
		}
	}

	private void GlobalIdent3()
	{
		byte b = 170;
		byte b2 = 2;
		byte b3 = 193;
		byte b4 = 0;
		byte b5 = 0;
		byte b6 = 0;
		int num = 0;
		int[] array = new int[6] { b, b2, b3, b5, b6, b4 };
		checked
		{
			int num2 = b2 + 1;
			for (int i = 0; i <= num2; i++)
			{
				num += array[i];
			}
			byte checksum = (byte)(num & 0xFF);
			while (WaitISSFlag)
			{
				Application.DoEvents();
			}
			if (!WaitISSFlag && !I2CPotError)
			{
				ReturnType = "Type";
				WritePortISSBoard(b, b2, b3, b5, b6, b4, checksum, ReturnType);
			}
		}
	}

	private void GlobalIdent()
	{
		byte b = 170;
		byte b2 = 2;
		byte b3 = 254;
		byte b4 = 33;
		byte b5 = 0;
		byte b6 = 0;
		int num = 0;
		int[] array = new int[6] { b, b2, b3, b4, b5, b6 };
		checked
		{
			int num2 = b2 + 1;
			for (int i = 0; i <= num2; i++)
			{
				num += array[i];
			}
			byte checksum = (byte)(num & 0xFF);
			while (WaitISSFlag)
			{
				Application.DoEvents();
			}
			if (!WaitISSFlag && !I2CPotError)
			{
				ReturnType = "Type";
				WritePortISSBoard(b, b2, b3, b5, b6, b4, checksum, ReturnType);
			}
		}
	}

	private void GlobalIdent2()
	{
		byte b = 170;
		byte b2 = 4;
		byte b3 = 190;
		byte b4 = 44;
		byte b5 = 3;
		byte b6 = 0;
		int num = 0;
		int[] array = new int[6] { b, b2, b3, b5, b6, b4 };
		checked
		{
			int num2 = b2 + 1;
			for (int i = 0; i <= num2; i++)
			{
				num += array[i];
			}
			byte checksum = (byte)(num & 0xFF);
			while (WaitISSFlag)
			{
				Application.DoEvents();
			}
			if (!WaitISSFlag && !I2CPotError)
			{
				ReturnType = "Type";
				WritePortISSBoard(b, b2, b3, b5, b6, b4, checksum, ReturnType);
			}
		}
	}

	private void GlobalIdent1()
	{
		byte b = 170;
		byte b2 = 2;
		byte command = 254;
		byte b3 = 0;
		byte b4 = 33;
		byte b5 = 3;
		byte b6 = 88;
		byte b7 = 0;
		byte b8 = 0;
		byte b9 = 0;
		int num = 0;
		int[] array = new int[9] { b, b2, b3, b4, b5, b6, b7, b8, b9 };
		checked
		{
			int num2 = b2 + 1;
			for (int i = 0; i <= num2; i++)
			{
				num += array[i];
			}
			byte checksum = (byte)(num & 0xFF);
			while (WaitISSFlag)
			{
				Application.DoEvents();
			}
			if (!WaitISSFlag && !I2CPotError)
			{
				ReturnType = "Type";
				WritePortISSBoard(b, b2, command, b3, b4, b6, checksum, ReturnType);
			}
		}
	}

	private void GlobalType()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		if (!WaitISSFlag && !I2CPotError)
		{
			byte b = 90;
			byte b2 = 0;
			byte b3 = 2;
			ReturnType = "Type";
		}
	}

	private void GlobalVersion()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		if (!WaitISSFlag && !I2CPotError)
		{
			byte b = 90;
			byte b2 = 1;
			byte b3 = 2;
			ReturnType = "Version";
		}
	}

	private void SetMode()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		if (!WaitISSFlag && !I2CPotError)
		{
			byte b = 90;
			byte b2 = 2;
			byte b3 = 80;
			byte b4 = 0;
			byte b5 = 3;
			ReturnType = "Setup";
		}
	}

	public void AllOutputsOff()
	{
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		if (!WaitISSFlag && I2CPotError)
		{
			ReturnType = "NoReturn";
			byte b = 110;
			byte b2 = 2;
		}
	}

	private void CloseSerialPortISSBoard()
	{
		if (PortOk)
		{
			try
			{
				SerialPortI2CBoard.DiscardInBuffer();
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
				SerialPortI2CBoard.Dispose();
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
				SerialPortI2CBoard.Close();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ErrorReporting("Port IO Error Close");
				ProjectData.ClearProjectError();
			}
		}
		I2CPotError = true;
	}

	private void SerialPortISSBoard_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
		switch (ReturnType)
		{
		case "Ident":
			text = Conversions.ToString(ReadExistingFromPort());
			break;
		case "NoReturn":
			text = Conversions.ToString(ReadExistingFromPort());
			break;
		case "Type":
			text = Conversions.ToString(ReadByteFromPort());
			text2 = Conversions.ToString(ReadExistingFromPort());
			break;
		case "Setup":
			text = Conversions.ToString(ReadByteFromPort());
			text2 = Conversions.ToString(ReadExistingFromPort());
			break;
		case "Version":
			text = Conversions.ToString(ReadByteFromPort());
			text2 = Conversions.ToString(ReadExistingFromPort());
			break;
		case "Outputs":
			text = Conversions.ToString(ReadByteFromPort());
			text2 = Conversions.ToString(ReadExistingFromPort());
			break;
		}
		textInISS += text;
		if (Strings.Len(ReceivedDataISS.Text) > 100)
		{
			ReceivedDataISSChange(text + " " + Strings.Mid(ReceivedDataISS.Text, 1, 40));
		}
		else
		{
			ReceivedDataISSChange(text + " " + ReceivedDataISS.Text);
		}
		DataISSReceived = true;
	}

	public object ReadAll()
	{
		int bytesToRead = SerialPortI2CBoard.BytesToRead;
		byte[] array = new byte[checked(bytesToRead - 1 + 1)];
		SerialPortI2CBoard.Read(array, 0, bytesToRead);
		return array[0];
	}

	public object ReadExistingFromPort()
	{
		string result = "";
		try
		{
			result = SerialPortI2CBoard.ReadExisting();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public object ReadByteFromPort()
	{
		string result = "";
		try
		{
			if (SerialPortI2CBoard.BytesToRead > 0)
			{
				result = Conversions.ToString(SerialPortI2CBoard.ReadByte());
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

	public object WaitISS(object tenms, object ack)
	{
		WaitTimeISS.Enabled = true;
		ISST1 = 0;
		while (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(ISST1, tenms, TextCompare: false), !DataISSReceived)))
		{
			WaitISSFlag = true;
			Application.DoEvents();
		}
		DataISSReceived = false;
		WaitTimeISS.Enabled = false;
		WaitISSFlag = false;
		return RuntimeHelpers.GetObjectValue(ack);
	}

	private void WaitTimeISS_Tick(object sender, EventArgs e)
	{
		checked
		{
			ISST1++;
		}
	}

	public object GetAckISS(string v, string ack)
	{
		bool flag = false;
		checked
		{
			if (Operators.CompareString(ack, "NoReturn", TextCompare: false) != 0)
			{
				while (Operators.CompareString(textInISS, "", TextCompare: false) == 0)
				{
					Application.DoEvents();
				}
				flag = true;
				switch (ack)
				{
				case "Ident":
					IdentNoChange(textInISS);
					break;
				case "Type":
					if (Operators.CompareString(Strings.Mid(textInISS, 1, 2), "13", TextCompare: false) == 0)
					{
						TypeNoChange("USB-OPTO-RL816");
						TypeCheck = 2;
					}
					else if (Operators.CompareString(Strings.Mid(textInISS, 1, 2), "12", TextCompare: false) == 0)
					{
						TypeNoChange("USB-OPTO-RL88");
						TypeCheck = 1;
					}
					else if (Operators.CompareString(Strings.Mid(textInISS, 1, 2), "8", TextCompare: false) == 0)
					{
						TypeNoChange("USB-RL08B");
						TypeCheck = 1;
					}
					else if (Operators.CompareString(Strings.Mid(textInISS, 1, 2), "90", TextCompare: false) == 0)
					{
						TypeNoChange("USB-ISS");
						TypeCheck = 1;
					}
					else
					{
						TypeNoChange("USB-RL??");
						TypeCheck = 0;
					}
					break;
				case "Version":
					VersionChange(textInISS);
					break;
				case "Setup":
					if (Conversion.Val(textInISS) == 255.0)
					{
						SetupChange("I2C_8_400KHZ");
					}
					else
					{
						SetupChange(textInISS);
					}
					break;
				case "Outputs":
				{
					if (!(Conversion.Val(textInISS) < 256.0))
					{
						break;
					}
					byte b = (byte)Math.Round(Conversion.Val(textInISS));
					DataReceivedBoard = "";
					byte b2 = 0;
					string text = default(string);
					do
					{
						if ((b & (long)Math.Round(Math.Pow(2.0, unchecked((int)b2)))) != 0)
						{
							DataReceivedBoard = "1" + DataReceivedBoard;
							ControlColorGreenChange(text);
						}
						else
						{
							DataReceivedBoard = "0" + DataReceivedBoard;
							ControlColorRedChange(text);
						}
						b2 = (byte)unchecked((uint)(b2 + 1));
					}
					while (unchecked((uint)b2) <= 7u);
					OutputISSDataChange(DataReceivedBoard);
					break;
				}
				}
			}
			else
			{
				flag = true;
			}
			ack = "";
			textInISS = "";
			return flag;
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

	private void ISSDataSend(object Port, object Data)
	{
		if (!I2CPotError)
		{
			while (WaitISSFlag)
			{
				Application.DoEvents();
			}
			if (!WaitISSFlag)
			{
				ReturnType = "Outputs";
				byte b = 44;
				byte b2 = 3;
			}
		}
	}

	private void CommsNoISSBoard_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "CommsISSBoard";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsNoISSBoardLb_Click(object sender, EventArgs e)
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
		InfoEnterTM.Enabled = true;
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsISSBoard", TextCompare: false) == 0)
		{
			if (Operators.CompareString(CommsNoISSBoard.Text, "", TextCompare: false) == 0)
			{
				CommsNoISSBoardChange("0");
			}
			MyProject.Forms.InfoEnter.Preload = CommsNoISSBoard.Text;
			InfoEnter.PasswordSet = CommsNoISSBoard.Text;
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsISSBoard", TextCompare: false) == 0)
		{
			CommsNoISSBoardChange(InfoEnter.PasswordSet);
			CommsNoISSBoard.TextAlign = HorizontalAlignment.Left;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		string itemName2 = ItemName;
		if (Operators.CompareString(itemName2, "CommsISSBoard", TextCompare: false) == 0)
		{
			if ((Operators.CompareString(CommsNoISSBoard.Text, "", TextCompare: false) == 0) | (Conversion.Val(CommsNoISSBoard.Text) == 0.0))
			{
				if (Operators.CompareString(CommsNoISSBoard.Text, "ZERO", TextCompare: false) == 0)
				{
					CommsOff();
				}
			}
			else
			{
				CommsNoISSBoardChange(Conversions.ToString(Conversion.Val(CommsNoISSBoard.Text)));
				Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, CommsNoISSBoard.Text);
				CommsResetISS.Enabled = true;
				CloseSerialPortISSBoard();
			}
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Enabled = false;
		ControlLevel = 0;
	}

	private void CommsResetISS_Tick(object sender, EventArgs e)
	{
		if ((Conversion.Val(CommsResetISSInd.Text) == 50.0) | Display.I2CPOTStartup)
		{
			CommsResetISSIndChange("");
			CloseSerialPortISSBoard();
			if (!SerialPortI2CBoard.IsOpen)
			{
				ISSControl();
			}
			return;
		}
		checked
		{
			if (!CommsTM.Enabled)
			{
				MotorSwitchEnabled++;
				if (MotorSwitchEnabled == 20)
				{
					MotorSwitchEnabled = 0;
					CommsTM.Enabled = true;
				}
			}
			if (I2CPotError | !SerialPortI2CBoard.IsOpen)
			{
				CommsResetISSIndChange(Conversions.ToString(Conversion.Val(CommsResetISSInd.Text) + 1.0));
			}
			else if (CommsResetISSInd.BackColor == Color.DarkGreen)
			{
				CommsResetISSIndChange("");
				ControlColorGreenYellowChange("CommsResetISSInd");
			}
			else
			{
				CommsResetISSIndChange("");
				ControlColorDarkGreenChange("CommsResetISSInd");
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

	private void USB_ISS_Activated(object sender, EventArgs e)
	{
		TitleNameChange(base.Name);
		CommsNoISSBoardChange(Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0"));
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, CommsNoISSBoard.Text);
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

	private void Invisible_Click(object sender, EventArgs e)
	{
		Hide();
		AllOutputsOff();
	}

	private void CommsNoISSBoardChange(string text)
	{
		if (CommsNoISSBoard.InvokeRequired)
		{
			SetTextCallback method = CommsNoISSBoardChange;
			Invoke(method, text);
		}
		else
		{
			CommsNoISSBoard.Text = text;
		}
	}

	private void ErrorReportISSChange(string text)
	{
		if (ErrorReportISS.InvokeRequired)
		{
			SetTextCallback method = ErrorReportISSChange;
			Invoke(method, text);
		}
		else
		{
			ErrorReportISS.Text = text;
		}
	}

	private void SendISSChange(string text)
	{
		if (SendISS.InvokeRequired)
		{
			SetTextCallback method = SendISSChange;
			Invoke(method, text);
		}
		else
		{
			SendISS.Text = text;
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

	private void VersionChange(string text)
	{
		if (VersionNo.InvokeRequired)
		{
			SetTextCallback method = VersionChange;
			Invoke(method, text);
		}
		else
		{
			VersionNo.Text = text;
		}
	}

	private void SetupChange(string text)
	{
		if (SetupNo.InvokeRequired)
		{
			SetTextCallback method = SetupChange;
			Invoke(method, text);
		}
		else
		{
			SetupNo.Text = text;
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

	private void OutputISSDataChange(string text)
	{
		if (OutputISSData.InvokeRequired)
		{
			SetTextCallback method = OutputISSDataChange;
			Invoke(method, text);
		}
		else
		{
			OutputISSData.Text = text;
		}
	}

	private void CommsResetISSIndChange(string text)
	{
		if (CommsResetISSInd.InvokeRequired)
		{
			SetTextCallback method = CommsResetISSIndChange;
			Invoke(method, text);
		}
		else
		{
			CommsResetISSInd.Text = text;
		}
	}

	private void ReceivedDataISSChange(string text)
	{
		if (ReceivedDataISS.InvokeRequired)
		{
			SetTextCallback method = ReceivedDataISSChange;
			Invoke(method, text);
		}
		else
		{
			ReceivedDataISS.Text = text;
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

	private void SerialAddress_Click(object sender, EventArgs e)
	{
		GetSerialPortNames();
	}

	private void USB_ISS_Load(object sender, EventArgs e)
	{
		if (Conversion.Val(Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0")) > 0.0 && Operators.ConditionalCompareObjectEqual(CheckComPort(), true, TextCompare: false))
		{
			Hide();
			CommsResetISS.Enabled = true;
		}
	}

	public object CheckComPort()
	{
		ReadOnlyCollection<string> serialPortNames = MyProject.Computer.Ports.SerialPortNames;
		if (serialPortNames.Contains("COM" + Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0")))
		{
			return true;
		}
		return false;
	}

	private void USB_ISS_Closing(object sender, CancelEventArgs e)
	{
		SerialPortI2CBoard.Close();
	}

	private void CommsTM_Tick(object sender, EventArgs e)
	{
		short num = 0;
		while (WaitISSFlag)
		{
			Application.DoEvents();
		}
		if (Conversion.Val(IdentNo.Text) == 0.0)
		{
			GlobalIdent();
		}
		else if (Operators.CompareString(Strings.Mid(SetupNo.Text, 1, 3), "I2C", TextCompare: false) == 0 && Operators.CompareString(VersionNo.Text, "", TextCompare: false) != 0 && TypeCheck != 0)
		{
		}
		if (!WaitISSFlag)
		{
		}
		CommsTM.Enabled = true;
	}

	private void PortISS_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(PortISS.Text, "Port 1", TextCompare: false) == 0)
		{
			PortISS.Text = "Port 2";
		}
		else
		{
			PortISS.Text = "Port 1";
		}
	}

	private void SendData_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(PortISS.Text, "Port 1", TextCompare: false) == 0)
		{
			Ports = Conversions.ToString(1);
		}
		else
		{
			Ports = Conversions.ToString(2);
		}
		byte b = default(byte);
		if (Conversion.Val(OutputISSData.Text) < 256.0)
		{
			b = Conversions.ToByte(Conversion.Val(OutputISSData.Text).ToString());
		}
		byte b2 = 88;
		byte b3 = 0;
		checked
		{
			byte b4 = (byte)unchecked((int)b);
			byte b5 = 3;
			ReturnType = "Outputs";
		}
	}
}
