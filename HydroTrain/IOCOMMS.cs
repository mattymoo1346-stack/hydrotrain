using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class IOCOMMS : Form
{
	public delegate void SetControlCallback(string ControlName, string Setting, bool Data);

	public delegate void MyIntDPChangedEventHandler(string newTOTDP_CLIP);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UpdatePort")]
	private Timer _UpdatePort;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Invisible")]
	private Button _Invisible;

	private string ItemName;

	private int ItemNumber;

	private int ControlLevel;

	private bool PortOK;

	private string[] PortName;

	private bool UpdateComms;

	[field: AccessedThroughProperty("Comlb1")]
	internal virtual Label Comlb1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsNo1")]
	internal virtual TextBox CommsNo1
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

	[field: AccessedThroughProperty("Comlb2")]
	internal virtual Label Comlb2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsNo2")]
	internal virtual TextBox CommsNo2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Comlb3")]
	internal virtual Label Comlb3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsNo3")]
	internal virtual TextBox CommsNo3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Comlb4")]
	internal virtual Label Comlb4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsNo4")]
	internal virtual TextBox CommsNo4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Comlb5")]
	internal virtual Label Comlb5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsNo5")]
	internal virtual TextBox CommsNo5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Timer UpdatePort
	{
		[CompilerGenerated]
		get
		{
			return _UpdatePort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UpdatePort_Tick;
			Timer timer = _UpdatePort;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_UpdatePort = value;
			timer = _UpdatePort;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Comlb6")]
	internal virtual Label Comlb6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsNo6")]
	internal virtual TextBox CommsNo6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Comlb7")]
	internal virtual Label Comlb7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsNo7")]
	internal virtual TextBox CommsNo7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Comlb8")]
	internal virtual Label Comlb8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsNo8")]
	internal virtual TextBox CommsNo8
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public string TOTDP_CLIP
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
				OpenForms(value);
			}
			MyIntDPChanged?.Invoke(value);
		}
	}

	public event MyIntDPChangedEventHandler MyIntDPChanged;

	public IOCOMMS()
	{
		base.Load += IOCOMMS_Load;
		base.Activated += IOCOMMS_Activated;
		PortName = new string[11];
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
		this.Comlb1 = new System.Windows.Forms.Label();
		this.CommsNo1 = new System.Windows.Forms.TextBox();
		this.SerialAddress = new System.Windows.Forms.ListBox();
		this.Comlb2 = new System.Windows.Forms.Label();
		this.CommsNo2 = new System.Windows.Forms.TextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Comlb3 = new System.Windows.Forms.Label();
		this.CommsNo3 = new System.Windows.Forms.TextBox();
		this.Button4 = new System.Windows.Forms.Button();
		this.Comlb4 = new System.Windows.Forms.Label();
		this.CommsNo4 = new System.Windows.Forms.TextBox();
		this.Button5 = new System.Windows.Forms.Button();
		this.Comlb5 = new System.Windows.Forms.Label();
		this.CommsNo5 = new System.Windows.Forms.TextBox();
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.UpdatePort = new System.Windows.Forms.Timer(this.components);
		this.Button6 = new System.Windows.Forms.Button();
		this.Comlb6 = new System.Windows.Forms.Label();
		this.CommsNo6 = new System.Windows.Forms.TextBox();
		this.Button7 = new System.Windows.Forms.Button();
		this.Comlb7 = new System.Windows.Forms.Label();
		this.CommsNo7 = new System.Windows.Forms.TextBox();
		this.Button8 = new System.Windows.Forms.Button();
		this.Comlb8 = new System.Windows.Forms.Label();
		this.CommsNo8 = new System.Windows.Forms.TextBox();
		this.Invisible = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.Comlb1.AutoSize = true;
		this.Comlb1.Location = new System.Drawing.Point(143, 30);
		this.Comlb1.Name = "Comlb1";
		this.Comlb1.Size = new System.Drawing.Size(28, 13);
		this.Comlb1.TabIndex = 289;
		this.Comlb1.Text = "Com";
		this.CommsNo1.ForeColor = System.Drawing.Color.White;
		this.CommsNo1.Location = new System.Drawing.Point(177, 27);
		this.CommsNo1.Name = "CommsNo1";
		this.CommsNo1.Size = new System.Drawing.Size(44, 20);
		this.CommsNo1.TabIndex = 288;
		this.SerialAddress.FormattingEnabled = true;
		this.SerialAddress.Location = new System.Drawing.Point(258, 105);
		this.SerialAddress.Name = "SerialAddress";
		this.SerialAddress.Size = new System.Drawing.Size(71, 121);
		this.SerialAddress.TabIndex = 300;
		this.Comlb2.AutoSize = true;
		this.Comlb2.Location = new System.Drawing.Point(143, 70);
		this.Comlb2.Name = "Comlb2";
		this.Comlb2.Size = new System.Drawing.Size(28, 13);
		this.Comlb2.TabIndex = 302;
		this.Comlb2.Text = "Com";
		this.CommsNo2.ForeColor = System.Drawing.Color.White;
		this.CommsNo2.Location = new System.Drawing.Point(177, 67);
		this.CommsNo2.Name = "CommsNo2";
		this.CommsNo2.Size = new System.Drawing.Size(44, 20);
		this.CommsNo2.TabIndex = 301;
		this.Button1.Location = new System.Drawing.Point(22, 25);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 303;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(22, 65);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 304;
		this.Button2.Text = "Button2";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(22, 105);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 307;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = true;
		this.Comlb3.AutoSize = true;
		this.Comlb3.Location = new System.Drawing.Point(143, 110);
		this.Comlb3.Name = "Comlb3";
		this.Comlb3.Size = new System.Drawing.Size(28, 13);
		this.Comlb3.TabIndex = 306;
		this.Comlb3.Text = "Com";
		this.CommsNo3.ForeColor = System.Drawing.Color.White;
		this.CommsNo3.Location = new System.Drawing.Point(177, 107);
		this.CommsNo3.Name = "CommsNo3";
		this.CommsNo3.Size = new System.Drawing.Size(44, 20);
		this.CommsNo3.TabIndex = 305;
		this.Button4.Location = new System.Drawing.Point(22, 145);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(75, 23);
		this.Button4.TabIndex = 310;
		this.Button4.Text = "Button4";
		this.Button4.UseVisualStyleBackColor = true;
		this.Comlb4.AutoSize = true;
		this.Comlb4.Location = new System.Drawing.Point(143, 150);
		this.Comlb4.Name = "Comlb4";
		this.Comlb4.Size = new System.Drawing.Size(28, 13);
		this.Comlb4.TabIndex = 309;
		this.Comlb4.Text = "Com";
		this.CommsNo4.ForeColor = System.Drawing.Color.White;
		this.CommsNo4.Location = new System.Drawing.Point(177, 147);
		this.CommsNo4.Name = "CommsNo4";
		this.CommsNo4.Size = new System.Drawing.Size(44, 20);
		this.CommsNo4.TabIndex = 308;
		this.Button5.Location = new System.Drawing.Point(22, 185);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(75, 23);
		this.Button5.TabIndex = 313;
		this.Button5.Text = "Button5";
		this.Button5.UseVisualStyleBackColor = true;
		this.Comlb5.AutoSize = true;
		this.Comlb5.Location = new System.Drawing.Point(143, 190);
		this.Comlb5.Name = "Comlb5";
		this.Comlb5.Size = new System.Drawing.Size(28, 13);
		this.Comlb5.TabIndex = 312;
		this.Comlb5.Text = "Com";
		this.CommsNo5.ForeColor = System.Drawing.Color.White;
		this.CommsNo5.Location = new System.Drawing.Point(177, 187);
		this.CommsNo5.Name = "CommsNo5";
		this.CommsNo5.Size = new System.Drawing.Size(44, 20);
		this.CommsNo5.TabIndex = 311;
		this.InfoEnterTM.Enabled = true;
		this.UpdatePort.Enabled = true;
		this.UpdatePort.Interval = 3000;
		this.Button6.Location = new System.Drawing.Point(22, 224);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(75, 23);
		this.Button6.TabIndex = 316;
		this.Button6.Text = "Button6";
		this.Button6.UseVisualStyleBackColor = true;
		this.Comlb6.AutoSize = true;
		this.Comlb6.Location = new System.Drawing.Point(143, 229);
		this.Comlb6.Name = "Comlb6";
		this.Comlb6.Size = new System.Drawing.Size(28, 13);
		this.Comlb6.TabIndex = 315;
		this.Comlb6.Text = "Com";
		this.CommsNo6.ForeColor = System.Drawing.Color.White;
		this.CommsNo6.Location = new System.Drawing.Point(177, 226);
		this.CommsNo6.Name = "CommsNo6";
		this.CommsNo6.Size = new System.Drawing.Size(44, 20);
		this.CommsNo6.TabIndex = 314;
		this.Button7.Location = new System.Drawing.Point(22, 262);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(75, 23);
		this.Button7.TabIndex = 319;
		this.Button7.Text = "Button7";
		this.Button7.UseVisualStyleBackColor = true;
		this.Comlb7.AutoSize = true;
		this.Comlb7.Location = new System.Drawing.Point(143, 267);
		this.Comlb7.Name = "Comlb7";
		this.Comlb7.Size = new System.Drawing.Size(28, 13);
		this.Comlb7.TabIndex = 318;
		this.Comlb7.Text = "Com";
		this.CommsNo7.ForeColor = System.Drawing.Color.White;
		this.CommsNo7.Location = new System.Drawing.Point(177, 264);
		this.CommsNo7.Name = "CommsNo7";
		this.CommsNo7.Size = new System.Drawing.Size(44, 20);
		this.CommsNo7.TabIndex = 317;
		this.Button8.Location = new System.Drawing.Point(22, 302);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(75, 23);
		this.Button8.TabIndex = 322;
		this.Button8.Text = "Button8";
		this.Button8.UseVisualStyleBackColor = true;
		this.Comlb8.AutoSize = true;
		this.Comlb8.Location = new System.Drawing.Point(143, 307);
		this.Comlb8.Name = "Comlb8";
		this.Comlb8.Size = new System.Drawing.Size(28, 13);
		this.Comlb8.TabIndex = 321;
		this.Comlb8.Text = "Com";
		this.CommsNo8.ForeColor = System.Drawing.Color.White;
		this.CommsNo8.Location = new System.Drawing.Point(177, 304);
		this.CommsNo8.Name = "CommsNo8";
		this.CommsNo8.Size = new System.Drawing.Size(44, 20);
		this.CommsNo8.TabIndex = 320;
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(286, 12);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(43, 44);
		this.Invisible.TabIndex = 323;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(255, 89);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(64, 13);
		this.Label1.TabIndex = 324;
		this.Label1.Text = "List Of Ports";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(364, 421);
		base.ControlBox = false;
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Invisible);
		base.Controls.Add(this.Button8);
		base.Controls.Add(this.Comlb8);
		base.Controls.Add(this.CommsNo8);
		base.Controls.Add(this.Button7);
		base.Controls.Add(this.Comlb7);
		base.Controls.Add(this.CommsNo7);
		base.Controls.Add(this.Button6);
		base.Controls.Add(this.Comlb6);
		base.Controls.Add(this.CommsNo6);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Comlb5);
		base.Controls.Add(this.CommsNo5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Comlb4);
		base.Controls.Add(this.CommsNo4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Comlb3);
		base.Controls.Add(this.CommsNo3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Comlb2);
		base.Controls.Add(this.CommsNo2);
		base.Controls.Add(this.SerialAddress);
		base.Controls.Add(this.Comlb1);
		base.Controls.Add(this.CommsNo1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "IOCOMMS";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "IOCOMMS";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemNumber = checked((int)Math.Round(Conversion.Val(Strings.Mid(Conversions.ToString(NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null)), 7, Strings.Len(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)))))));
			ItemName = "CommsNo" + Conversions.ToString(ItemNumber);
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void TextBoxChange(string ControlName, string Setting, string Data)
	{
		try
		{
			if (base.Controls[ControlName].InvokeRequired)
			{
				SetControlCallback method = [SpecialName] [DebuggerHidden] (string a0, string a1, bool a2) =>
				{
					TextBoxChange(a0, a1, Conversions.ToString(a2));
				};
				Invoke(method, ControlName, Setting, Data);
				return;
			}
			if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
			{
				base.Controls[ControlName].Text = Data;
			}
			else if (Operators.CompareString(Setting, "Align", TextCompare: false) != 0)
			{
			}
			switch (ControlName)
			{
			case "CommsNo1":
				if (Operators.CompareString(Data, "Centre", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
					{
						CommsNo1.TextAlign = HorizontalAlignment.Left;
					}
				}
				else
				{
					CommsNo1.TextAlign = HorizontalAlignment.Center;
				}
				break;
			case "CommsNo2":
				if (Operators.CompareString(Data, "Centre", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
					{
						CommsNo2.TextAlign = HorizontalAlignment.Left;
					}
				}
				else
				{
					CommsNo2.TextAlign = HorizontalAlignment.Center;
				}
				break;
			case "CommsNo3":
				if (Operators.CompareString(Data, "Centre", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
					{
						CommsNo3.TextAlign = HorizontalAlignment.Left;
					}
				}
				else
				{
					CommsNo3.TextAlign = HorizontalAlignment.Center;
				}
				break;
			case "CommsNo4":
				if (Operators.CompareString(Data, "Centre", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
					{
						CommsNo4.TextAlign = HorizontalAlignment.Left;
					}
				}
				else
				{
					CommsNo4.TextAlign = HorizontalAlignment.Center;
				}
				break;
			case "CommsNo5":
				if (Operators.CompareString(Data, "Centre", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
					{
						CommsNo5.TextAlign = HorizontalAlignment.Left;
					}
				}
				else
				{
					CommsNo5.TextAlign = HorizontalAlignment.Center;
				}
				break;
			case "CommsNo6":
				if (Operators.CompareString(Data, "Centre", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
					{
						CommsNo6.TextAlign = HorizontalAlignment.Left;
					}
				}
				else
				{
					CommsNo6.TextAlign = HorizontalAlignment.Center;
				}
				break;
			case "CommsNo7":
				if (Operators.CompareString(Data, "Centre", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
					{
						CommsNo7.TextAlign = HorizontalAlignment.Left;
					}
				}
				else
				{
					CommsNo7.TextAlign = HorizontalAlignment.Center;
				}
				break;
			case "CommsNo8":
				if (Operators.CompareString(Data, "Centre", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
					{
						CommsNo8.TextAlign = HorizontalAlignment.Left;
					}
				}
				else
				{
					CommsNo8.TextAlign = HorizontalAlignment.Center;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void CommsSetting()
	{
		RunKeyPad();
		if (Operators.CompareString(base.Controls[ItemName].Text, "", TextCompare: false) == 0)
		{
			TextBoxChange(ItemName, "Text", "0");
		}
		MyProject.Forms.KeyPadEnter.Preload = base.Controls[ItemName].Text;
		KeyPadEnter.PasswordSet = base.Controls[ItemName].Text;
	}

	private void RunKeyPad()
	{
		MyProject.Forms.KeyPadEnter.Show();
		if (!InfoEnterTM.Enabled)
		{
			InfoEnterTM.Enabled = true;
		}
		MyProject.Forms.KeyPadEnter.SetLocation(checked(base.Left + base.Width + 15), base.Top);
		MyProject.Forms.KeyPadEnter.Button30.Visible = false;
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(ItemName, null, TextCompare: false) == 0)
		{
			return;
		}
		TextBoxChange(ItemName, "Text", KeyPadEnter.PasswordSet);
		TextBoxChange(ItemName, "Align", "Left");
		if (KeyPadEnter.ControlKey)
		{
			return;
		}
		if (((Operators.CompareString(base.Controls[ItemName].Text, "", TextCompare: false) == 0) & Display.EngPass) | ((Conversion.Val(base.Controls[ItemName].Text) == 0.0) & Display.EngPass))
		{
			if (Operators.CompareString(base.Controls[ItemName].Text, "ZERO", TextCompare: false) == 0)
			{
				TextBoxChange(ItemName, "Text", "0");
				if (Operators.CompareString(base.Controls[ItemName].Text, "", TextCompare: false) != 0)
				{
					Interaction.SaveSetting("Health", "Setup", "Port" + PortName[ItemNumber], base.Controls[ItemName].Text);
				}
			}
		}
		else if ((Operators.CompareString(base.Controls[ItemName].Text, "", TextCompare: false) == 0) | (Conversion.Val(base.Controls[ItemName].Text) == 0.0))
		{
			TextBoxChange(ItemName, "Text", MyProject.Forms.KeyPadEnter.Preload);
		}
		else
		{
			TextBoxChange(ItemName, "Text", KeyPadEnter.PasswordSet);
			if (Operators.CompareString(base.Controls[ItemName].Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Health", "Setup", "Port" + PortName[ItemNumber], base.Controls[ItemName].Text);
				if (Operators.CompareString(PortName[ItemNumber], "USBISS", TextCompare: false) == 0)
				{
					USBISS.NewSerialNumberSet = true;
				}
			}
			OpenSerialPort(PortName[ItemNumber]);
			UpdateComms = true;
		}
		MyProject.Forms.KeyPadEnter.Preload = "";
		KeyPadEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		ControlLevel = 0;
	}

	private void OpenSerialPort(string ItemName)
	{
		switch (ItemName)
		{
		case "USBRLY04":
			TOTDP_CLIP = "RLY04";
			break;
		case "USBRLY08":
			TOTDP_CLIP = "RLY08";
			break;
		case "USBRLY82":
			TOTDP_CLIP = "RLY82";
			break;
		case "USBRLY88":
			TOTDP_CLIP = "RLY88";
			break;
		case "USBRLY816":
			TOTDP_CLIP = "RLY816";
			break;
		case "USBISS":
			TOTDP_CLIP = "USBISS";
			break;
		case "USBI2C":
			TOTDP_CLIP = "USBI2C";
			break;
		case "POT8":
			TOTDP_CLIP = "POT8";
			break;
		}
	}

	public void OpenForms(object FormName)
	{
		if (Operators.ConditionalCompareObjectEqual(FormName, "RLY08", TextCompare: false))
		{
			MyProject.Forms.USBRLY08.Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(FormName, "RLY88", TextCompare: false))
		{
			MyProject.Forms.USBOPTORLY88.Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(FormName, "RLY82", TextCompare: false))
		{
			MyProject.Forms.RLY82.Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(FormName, "RLY816", TextCompare: false))
		{
			MyProject.Forms.USBOPTORLY816.Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(FormName, "RLY04", TextCompare: false))
		{
			MyProject.Forms.USBRLY04.Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(FormName, "USBISS", TextCompare: false))
		{
			MyProject.Forms.USBISS.Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(FormName, "I2CPOT", TextCompare: false))
		{
			MyProject.Forms.I2CPot.Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(FormName, "POT8", TextCompare: false))
		{
			MyProject.Forms.UPOT8PROXR.Show();
		}
	}

	private void UpdatePort_Tick(object sender, EventArgs e)
	{
		SerialAddress.Items.Clear();
		PortOK = false;
		foreach (string serialPortName in MyProject.Computer.Ports.SerialPortNames)
		{
			if (Operators.CompareString("COM" + Conversions.ToString(WifiSocket.Port), serialPortName, TextCompare: false) == 0)
			{
				PortOK = true;
			}
			SerialAddress.Items.Add(serialPortName);
		}
		int num = 1;
		do
		{
			string text = PortName[num];
			string text2 = text + "Error";
			if (!Conversions.ToBoolean(Interaction.GetSetting("Health", "Setup", "Open" + PortName[num], Conversions.ToString(Value: false))))
			{
				base.Controls["CommsNo" + Conversions.ToString(num)].BackColor = Color.Gray;
			}
			else
			{
				base.Controls["CommsNo" + Conversions.ToString(num)].BackColor = Color.Green;
			}
			num = checked(num + 1);
		}
		while (num <= 8);
	}

	private void IOCOMMS_Load(object sender, EventArgs e)
	{
		UpdateComms = false;
	}

	public void SetLocation(object LocX, object LocY)
	{
		base.Location = new Point(Conversions.ToInteger(LocX), Conversions.ToInteger(LocY));
	}

	private void Invisible_Click(object sender, EventArgs e)
	{
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		UpdatePort.Dispose();
		ControlLevel = 0;
		MyProject.Forms.InfoEnter.Visible = false;
		InfoEnter.ControlKey = false;
		base.Visible = false;
		Hide();
		if (UpdateComms)
		{
			UpdateComms = false;
			Display.RestartRequired = true;
		}
	}

	private void IOCOMMS_Activated(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				int num = 1;
				if ((Conversion.Val(Interaction.GetSetting("Health", "Setup", "PortUSBISS", Conversions.ToString(0))) > 0.0) | Display.EngPass)
				{
					PortName[num] = "USBISS";
					base.Controls["Button" + Conversions.ToString(num)].Text = "USBISS";
					base.Controls["CommsNo" + Conversions.ToString(num)].Text = Interaction.GetSetting("Health", "Setup", "Port" + PortName[num], Conversions.ToString(0));
					num++;
				}
				if ((Conversion.Val(Interaction.GetSetting("Health", "Setup", "PortUSBI2C", Conversions.ToString(0))) > 0.0) | Display.EngPass)
				{
					PortName[num] = "USBI2C";
					base.Controls["Button" + Conversions.ToString(num)].Text = "USBI2C";
					base.Controls["CommsNo" + Conversions.ToString(num)].Text = Interaction.GetSetting("Health", "Setup", "Port" + PortName[num], Conversions.ToString(0));
					num++;
				}
				if ((Conversion.Val(Interaction.GetSetting("Health", "Setup", "PortUPOT8PROXR", Conversions.ToString(0))) > 0.0) | Display.EngPass)
				{
					PortName[num] = "UPOT8PROXR";
					base.Controls["Button" + Conversions.ToString(num)].Text = "POT8";
					base.Controls["CommsNo" + Conversions.ToString(num)].Text = Interaction.GetSetting("Health", "Setup", "Port" + PortName[num], Conversions.ToString(0));
					num++;
				}
				if ((Conversion.Val(Interaction.GetSetting("Health", "Setup", "PortUSBOPTORLY88", Conversions.ToString(0))) > 0.0) | Display.EngPass)
				{
					PortName[num] = "USBOPTORLY88";
					base.Controls["Button" + Conversions.ToString(num)].Text = "RLY88";
					base.Controls["CommsNo" + Conversions.ToString(num)].Text = Interaction.GetSetting("Health", "Setup", "Port" + PortName[num], Conversions.ToString(0));
					num++;
				}
				if ((Conversion.Val(Interaction.GetSetting("Health", "Setup", "PortUSBOPTORLY816", Conversions.ToString(0))) > 0.0) | Display.EngPass)
				{
					PortName[num] = "USBOPTORLY816";
					base.Controls["Button" + Conversions.ToString(num)].Text = "RLY816";
					base.Controls["CommsNo" + Conversions.ToString(num)].Text = Interaction.GetSetting("Health", "Setup", "Port" + PortName[num], Conversions.ToString(0));
					num++;
				}
				if ((Conversion.Val(Interaction.GetSetting("Health", "Setup", "PortUSBRLY08", Conversions.ToString(0))) > 0.0) | Display.EngPass)
				{
					PortName[num] = "USBRLY08";
					base.Controls["Button" + Conversions.ToString(num)].Text = "RLY08";
					base.Controls["CommsNo" + Conversions.ToString(num)].Text = Interaction.GetSetting("Health", "Setup", "Port" + PortName[num], Conversions.ToString(0));
					num++;
				}
				if ((Conversions.ToDouble(Interaction.GetSetting("Health", "Setup", "PortRLY82", Conversions.ToString(0))) > 0.0) | Display.EngPass)
				{
					PortName[num] = "RLY82";
					base.Controls["Button" + Conversions.ToString(num)].Text = "RLY82";
					base.Controls["CommsNo" + Conversions.ToString(num)].Text = Interaction.GetSetting("Health", "Setup", "Port" + PortName[num], Conversions.ToString(0));
					num++;
				}
				if ((Conversions.ToDouble(Interaction.GetSetting("Health", "Setup", "PortUSBRLY04", Conversions.ToString(0))) > 0.0) | Display.EngPass)
				{
					PortName[num] = "USBRLY04";
					base.Controls["Button" + Conversions.ToString(num)].Text = "RLY04";
					base.Controls["CommsNo" + Conversions.ToString(num)].Text = Interaction.GetSetting("Health", "Setup", "Port" + PortName[num], Conversions.ToString(0));
				}
				if (!Display.EngPass)
				{
					base.Height = base.Controls["Button" + Conversions.ToString(num)].Top + base.Controls["Button" + Conversions.ToString(num)].Height + 15;
					SerialAddress.Height = base.Controls["CommsNo" + Conversions.ToString(num)].Top - base.Controls["CommsNo" + Conversions.ToString(num)].Height - SerialAddress.Top;
					do
					{
						base.Controls["Button" + Conversions.ToString(num)].Visible = false;
						base.Controls["CommsNo" + Conversions.ToString(num)].Visible = false;
						base.Controls["Comlb" + Conversions.ToString(num)].Visible = false;
						num++;
					}
					while (num <= 8);
					return;
				}
				base.Height = base.Controls["Button" + Conversions.ToString(num)].Top + base.Controls["Button" + Conversions.ToString(num)].Height + 60;
				SerialAddress.Height = base.Controls["CommsNo" + Conversions.ToString(num)].Top - base.Controls["CommsNo" + Conversions.ToString(num)].Height - SerialAddress.Top;
				num = 1;
				do
				{
					base.Controls["Button" + Conversions.ToString(num)].Visible = true;
					base.Controls["CommsNo" + Conversions.ToString(num)].Visible = true;
					base.Controls["Comlb" + Conversions.ToString(num)].Visible = true;
					num++;
				}
				while (num <= 8);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}
}
