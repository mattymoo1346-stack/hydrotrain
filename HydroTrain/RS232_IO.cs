using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class RS232_IO : Form
{
	public delegate void SetTextCallback(string text);

	public delegate void SetIntCallback(int Index, string text);

	public delegate void SetSTRCallback(string text, string textA);

	public delegate void SetBoolCallback(string text, string textA, bool textB);

	private delegate void DelegateInvokeRead();

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SerialPortRS232")]
	private SerialPort _SerialPortRS232;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsNo")]
	private TextBox _CommsNo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ErrorReport")]
	private RichTextBox _ErrorReport;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private System.Windows.Forms.Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsLb")]
	private Label _CommsLb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Dtr")]
	private Button _Dtr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Rts")]
	private Button _Rts;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InclinePositionTrueCheck")]
	private System.Windows.Forms.Timer _InclinePositionTrueCheck;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InclinePositionFalseCheck")]
	private System.Windows.Forms.Timer _InclinePositionFalseCheck;

	private Thread demoThread;

	private string Port;

	private bool SerialPortRS232Error;

	private string ItemName;

	private int ControlLevel;

	internal virtual SerialPort SerialPortRS232
	{
		[CompilerGenerated]
		get
		{
			return _SerialPortRS232;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			SerialPinChangedEventHandler value2 = SerialPortRS232_PinChanged;
			SerialDataReceivedEventHandler value3 = SerialPortIORS232_DataReceived;
			SerialPort serialPort = _SerialPortRS232;
			if (serialPort != null)
			{
				serialPort.PinChanged -= value2;
				serialPort.DataReceived -= value3;
			}
			_SerialPortRS232 = value;
			serialPort = _SerialPortRS232;
			if (serialPort != null)
			{
				serialPort.PinChanged += value2;
				serialPort.DataReceived += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DSR")]
	internal virtual TextBox DSR
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CTS")]
	internal virtual TextBox CTS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CD")]
	internal virtual TextBox CD
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RING")]
	internal virtual TextBox RING
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox CommsNo
	{
		[CompilerGenerated]
		get
		{
			return _CommsNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsNo_Click;
			EventHandler value3 = CommsNo_GotFocus;
			TextBox textBox = _CommsNo;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_CommsNo = value;
			textBox = _CommsNo;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual RichTextBox ErrorReport
	{
		[CompilerGenerated]
		get
		{
			return _ErrorReport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ErrorReport_GotFocus;
			RichTextBox richTextBox = _ErrorReport;
			if (richTextBox != null)
			{
				richTextBox.GotFocus -= value2;
			}
			_ErrorReport = value;
			richTextBox = _ErrorReport;
			if (richTextBox != null)
			{
				richTextBox.GotFocus += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Label CommsLb
	{
		[CompilerGenerated]
		get
		{
			return _CommsLb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsLb_Click;
			Label label = _CommsLb;
			if (label != null)
			{
				label.Click -= value2;
			}
			_CommsLb = value;
			label = _CommsLb;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Button Dtr
	{
		[CompilerGenerated]
		get
		{
			return _Dtr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Dtr_Click;
			Button button = _Dtr;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Dtr = value;
			button = _Dtr;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Rts
	{
		[CompilerGenerated]
		get
		{
			return _Rts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Rts_Click;
			Button button = _Rts;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Rts = value;
			button = _Rts;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer InclinePositionTrueCheck
	{
		[CompilerGenerated]
		get
		{
			return _InclinePositionTrueCheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InclinePositionTrueCheck_Tick;
			System.Windows.Forms.Timer timer = _InclinePositionTrueCheck;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_InclinePositionTrueCheck = value;
			timer = _InclinePositionTrueCheck;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer InclinePositionFalseCheck
	{
		[CompilerGenerated]
		get
		{
			return _InclinePositionFalseCheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InclinePositionFalseCheck_Tick;
			System.Windows.Forms.Timer timer = _InclinePositionFalseCheck;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_InclinePositionFalseCheck = value;
			timer = _InclinePositionFalseCheck;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CommsResetSpeed")]
	internal virtual System.Windows.Forms.Timer CommsResetSpeed
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public RS232_IO()
	{
		base.Load += RS232_IO_Load;
		base.Closing += RS232_IO_Closing;
		demoThread = null;
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
		this.SerialPortRS232 = new System.IO.Ports.SerialPort(this.components);
		this.DSR = new System.Windows.Forms.TextBox();
		this.CTS = new System.Windows.Forms.TextBox();
		this.CD = new System.Windows.Forms.TextBox();
		this.RING = new System.Windows.Forms.TextBox();
		this.CommsNo = new System.Windows.Forms.TextBox();
		this.ErrorReport = new System.Windows.Forms.RichTextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.CommsLb = new System.Windows.Forms.Label();
		this.Dtr = new System.Windows.Forms.Button();
		this.Rts = new System.Windows.Forms.Button();
		this.InclinePositionTrueCheck = new System.Windows.Forms.Timer(this.components);
		this.InclinePositionFalseCheck = new System.Windows.Forms.Timer(this.components);
		this.CommsResetSpeed = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.DSR.Location = new System.Drawing.Point(179, 145);
		this.DSR.Name = "DSR";
		this.DSR.Size = new System.Drawing.Size(40, 20);
		this.DSR.TabIndex = 1;
		this.CTS.Location = new System.Drawing.Point(179, 171);
		this.CTS.Name = "CTS";
		this.CTS.Size = new System.Drawing.Size(40, 20);
		this.CTS.TabIndex = 2;
		this.CD.Location = new System.Drawing.Point(179, 119);
		this.CD.Name = "CD";
		this.CD.Size = new System.Drawing.Size(40, 20);
		this.CD.TabIndex = 3;
		this.RING.Location = new System.Drawing.Point(179, 195);
		this.RING.Name = "RING";
		this.RING.Size = new System.Drawing.Size(40, 20);
		this.RING.TabIndex = 4;
		this.CommsNo.Location = new System.Drawing.Point(58, 22);
		this.CommsNo.Name = "CommsNo";
		this.CommsNo.Size = new System.Drawing.Size(40, 20);
		this.CommsNo.TabIndex = 5;
		this.ErrorReport.Location = new System.Drawing.Point(133, 12);
		this.ErrorReport.Name = "ErrorReport";
		this.ErrorReport.Size = new System.Drawing.Size(139, 54);
		this.ErrorReport.TabIndex = 6;
		this.ErrorReport.Text = "";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(143, 148);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(30, 13);
		this.Label1.TabIndex = 7;
		this.Label1.Text = "DSR";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(143, 174);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(28, 13);
		this.Label2.TabIndex = 8;
		this.Label2.Text = "CTS";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(151, 122);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(22, 13);
		this.Label3.TabIndex = 9;
		this.Label3.Text = "CD";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(139, 198);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(34, 13);
		this.Label4.TabIndex = 10;
		this.Label4.Text = "RING";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(225, 122);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(34, 13);
		this.Label5.TabIndex = 11;
		this.Label5.Text = "PIN 1";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(225, 198);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(34, 13);
		this.Label6.TabIndex = 12;
		this.Label6.Text = "PIN 9";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(225, 174);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(34, 13);
		this.Label7.TabIndex = 13;
		this.Label7.Text = "PIN 8";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(225, 148);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(34, 13);
		this.Label8.TabIndex = 14;
		this.Label8.Text = "PIN 6";
		this.InfoEnterTM.Enabled = true;
		this.InfoEnterTM.Interval = 200;
		this.CommsLb.AutoSize = true;
		this.CommsLb.Location = new System.Drawing.Point(30, 25);
		this.CommsLb.Name = "CommsLb";
		this.CommsLb.Size = new System.Drawing.Size(28, 13);
		this.CommsLb.TabIndex = 15;
		this.CommsLb.Text = "Com";
		this.Dtr.Location = new System.Drawing.Point(22, 150);
		this.Dtr.Name = "Dtr";
		this.Dtr.Size = new System.Drawing.Size(50, 37);
		this.Dtr.TabIndex = 16;
		this.Dtr.Text = "Dtr";
		this.Dtr.UseVisualStyleBackColor = true;
		this.Rts.Location = new System.Drawing.Point(22, 213);
		this.Rts.Name = "Rts";
		this.Rts.Size = new System.Drawing.Size(50, 37);
		this.Rts.TabIndex = 17;
		this.Rts.Text = "Rts";
		this.Rts.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(284, 262);
		base.ControlBox = false;
		base.Controls.Add(this.Rts);
		base.Controls.Add(this.Dtr);
		base.Controls.Add(this.CommsLb);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ErrorReport);
		base.Controls.Add(this.CommsNo);
		base.Controls.Add(this.RING);
		base.Controls.Add(this.CD);
		base.Controls.Add(this.CTS);
		base.Controls.Add(this.DSR);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "RS232_IO";
		this.Text = "RS232_IO";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void CommsNo_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "Comms";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsSetting()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsSpeed", TextCompare: false) == 0)
		{
			if (Operators.CompareString(CommsNo.Text, "", TextCompare: false) == 0)
			{
				CommsNoRelayBoardChange("0");
			}
			MyProject.Forms.InfoEnter.Preload = CommsNo.Text;
			InfoEnter.PasswordSet = CommsNo.Text;
		}
	}

	private void DSRChange(string text, string texta, bool textb)
	{
		if (DSR.InvokeRequired)
		{
			SetBoolCallback method = DSRChange;
			Invoke(method, text, texta, textb);
			return;
		}
		if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
		{
			DSR.Text = texta;
		}
		if (Operators.CompareString(text, "Back", TextCompare: false) == 0)
		{
			if (!textb)
			{
				DSR.BackColor = Color.Gray;
			}
			else
			{
				DSR.BackColor = Color.Green;
			}
		}
		if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
		{
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				DSR.Visible = false;
			}
			else
			{
				DSR.Visible = true;
			}
		}
	}

	private void CDChange(string text, string texta, bool textb)
	{
		if (CD.InvokeRequired)
		{
			SetBoolCallback method = CDChange;
			Invoke(method, text, texta, textb);
			return;
		}
		if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
		{
			CD.Text = texta;
		}
		if (Operators.CompareString(text, "Back", TextCompare: false) == 0)
		{
			if (!textb)
			{
				CD.BackColor = Color.Gray;
				Display.EmergencyStop = false;
			}
			else
			{
				CD.BackColor = Color.Green;
				Display.EmergencyStop = true;
			}
			MyProject.Forms.Display.SetProgramStartImage();
		}
		if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
		{
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				CD.Visible = false;
			}
			else
			{
				CD.Visible = true;
			}
		}
	}

	private void CtsChange(string text, string texta, bool textb)
	{
		if (CTS.InvokeRequired)
		{
			SetBoolCallback method = CtsChange;
			Invoke(method, text, texta, textb);
			return;
		}
		if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
		{
			CTS.Text = texta;
		}
		if (Operators.CompareString(text, "Back", TextCompare: false) == 0)
		{
			if (!textb)
			{
				CTS.BackColor = Color.Gray;
			}
			else
			{
				CTS.BackColor = Color.Green;
			}
		}
		if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
		{
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				CTS.Visible = false;
				InclinePositionFalseCheck.Enabled = true;
				InclinePositionTrueCheck.Dispose();
			}
			else
			{
				CTS.Visible = true;
				InclinePositionTrueCheck.Enabled = true;
				InclinePositionFalseCheck.Dispose();
			}
		}
	}

	private void RingChange(string text, string texta, bool textb)
	{
		if (RING.InvokeRequired)
		{
			SetBoolCallback method = RingChange;
			Invoke(method, text, texta, textb);
			return;
		}
		if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
		{
			RING.Text = texta;
		}
		if (Operators.CompareString(text, "Back", TextCompare: false) == 0)
		{
			if (!textb)
			{
				RING.BackColor = Color.Gray;
			}
			else
			{
				RING.BackColor = Color.Green;
			}
		}
		if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
		{
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				RING.Visible = false;
			}
			else
			{
				RING.Visible = true;
			}
		}
	}

	private void HoldDsr()
	{
		DSRChange("Back", "", SerialPortRS232.DsrHolding);
	}

	private void HoldCD()
	{
		CDChange("Back", "", SerialPortRS232.CDHolding);
	}

	private void HoldCts()
	{
		CtsChange("Back", "", SerialPortRS232.CtsHolding);
	}

	private void HoldRing()
	{
		if (RING.BackColor == Color.Gray)
		{
			RingChange("Back", "", textb: true);
		}
		else
		{
			RingChange("Back", "", textb: false);
		}
		HoldDsr();
		HoldCD();
		HoldCts();
	}

	private void SerialPortRS232_PinChanged(object sender, SerialPinChangedEventArgs e)
	{
		if (e.EventType == SerialPinChange.DsrChanged)
		{
			HoldDsr();
		}
		if (e.EventType == SerialPinChange.CtsChanged)
		{
			HoldCts();
		}
		if (e.EventType == SerialPinChange.CDChanged)
		{
			HoldCD();
		}
		if (e.EventType == SerialPinChange.Ring)
		{
			HoldRing();
		}
	}

	private void SerialPortIORS232_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
	}

	private void RS232_IO_Load(object sender, EventArgs e)
	{
		if (Conversions.ToDouble(Interaction.GetSetting("Health", "Setup", "PortRS232_IO", Conversions.ToString(0))) > 0.0)
		{
			Hide();
		}
		if (!SerialPortRS232.IsOpen)
		{
			Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, Conversions.ToString(1));
			CommsNoRelayBoardChange(Port);
			SerialPortRS232.PortName = "Com" + Port;
			SerialPortRS232.BaudRate = 38400;
			SerialPortRS232.Parity = Parity.None;
			SerialPortRS232.DataBits = 8;
			SerialPortRS232.StopBits = StopBits.One;
			SerialPortRS232.Handshake = Handshake.None;
			SerialPortRS232.ReadTimeout = 500;
			SerialPortRS232.WriteTimeout = 500;
			try
			{
				SerialPortRS232.Open();
				HoldDsr();
				HoldCD();
				HoldCts();
			}
			catch (TimeoutException ex)
			{
				ProjectData.SetProjectError(ex);
				TimeoutException ex2 = ex;
				ErrorReportChange("Port Timeout Error");
				SerialPortRS232Error = true;
				ProjectData.ClearProjectError();
			}
			catch (IOException ex3)
			{
				ProjectData.SetProjectError(ex3);
				IOException ex4 = ex3;
				ErrorReportChange("Port IO Error");
				SerialPortRS232Error = true;
				ProjectData.ClearProjectError();
			}
			catch (SystemException ex5)
			{
				ProjectData.SetProjectError(ex5);
				SystemException ex6 = ex5;
				ErrorReportChange("Port System Error");
				SerialPortRS232Error = true;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ErrorReportChange("Port Error");
				SerialPortRS232Error = true;
				ProjectData.ClearProjectError();
			}
			if (SerialPortRS232Error & !CommsResetSpeed.Enabled)
			{
				CommsResetSpeed.Enabled = true;
			}
		}
	}

	private void ErrorReportChange(string text)
	{
		if (ErrorReport.InvokeRequired)
		{
			SetTextCallback method = ErrorReportChange;
			Invoke(method, text);
		}
		else
		{
			ErrorReport.Text = text;
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "Comms", TextCompare: false) == 0)
		{
			CommsNoRelayBoardChange(InfoEnter.PasswordSet);
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		string itemName2 = ItemName;
		if (Operators.CompareString(itemName2, "Comms", TextCompare: false) == 0)
		{
			if ((Operators.CompareString(CommsNo.Text, "", TextCompare: false) == 0) | (Conversion.Val(CommsNo.Text) == 0.0))
			{
				if (Operators.CompareString(CommsNo.Text, "ZERO", TextCompare: false) == 0)
				{
					CommsOff();
				}
			}
			else
			{
				CommsNoRelayBoardChange(Conversions.ToString(Conversion.Val(CommsNo.Text)));
				Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, CommsNo.Text);
			}
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		ControlLevel = 0;
	}

	private void CommsOff()
	{
		CommsNoRelayBoardChange("0");
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, "0");
	}

	private void CommsNoRelayBoardChange(string text)
	{
		if (CommsNo.InvokeRequired)
		{
			SetTextCallback method = CommsNoRelayBoardChange;
			Invoke(method, text);
		}
		else
		{
			CommsNo.Text = text;
		}
	}

	private void CommsLb_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "Comms";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void CommsNo_GotFocus(object sender, EventArgs e)
	{
		CommsLb.Select();
	}

	private void ErrorReport_GotFocus(object sender, EventArgs e)
	{
		CommsLb.Select();
	}

	private void RichTextBox1_GotFocus(object sender, EventArgs e)
	{
		CommsLb.Select();
	}

	private void Dtr_Click(object sender, EventArgs e)
	{
		if (!SerialPortRS232.DtrEnable)
		{
			SerialPortRS232.DtrEnable = true;
			ControlColorGreenChange("Dtr");
		}
		else
		{
			SerialPortRS232.DtrEnable = false;
			ControlColorRedChange("Dtr");
			Dtr.BackColor = Color.Gray;
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

	private void Rts_Click(object sender, EventArgs e)
	{
		if (!SerialPortRS232.RtsEnable)
		{
			SerialPortRS232.RtsEnable = true;
			ControlColorGreenChange("Rts");
			Rts.BackColor = Color.Green;
		}
		else
		{
			ControlColorRedChange("Rts");
			SerialPortRS232.RtsEnable = false;
			Rts.BackColor = Color.Gray;
		}
	}

	private void InclinePositionTrueCheck_Tick(object sender, EventArgs e)
	{
		InclinePositionTrueCheck.Dispose();
		MyProject.Forms.Display.InclinePositionOK = true;
	}

	private void InclinePositionFalseCheck_Tick(object sender, EventArgs e)
	{
		InclinePositionFalseCheck.Dispose();
		MyProject.Forms.Display.InclinePositionOK = false;
	}

	private void RS232_IO_Closing(object sender, CancelEventArgs e)
	{
		SerialPortRS232.Close();
	}
}
