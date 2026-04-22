using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class KeyPadEnter : Form
{
	public delegate void SetControl2Callback(string ControlName, string Data);

	public delegate void SetControl4Callback(string text, string textA, string text, string textA);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EnterKey")]
	private Button _EnterKey;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CLR")]
	private Button _CLR;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DEL")]
	private Button _DEL;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button39")]
	private Button _Button39;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button38")]
	private Button _Button38;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button37")]
	private Button _Button37;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button36")]
	private Button _Button36;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button35")]
	private Button _Button35;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button34")]
	private Button _Button34;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button33")]
	private Button _Button33;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button32")]
	private Button _Button32;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button31")]
	private Button _Button31;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button30")]
	private Button _Button30;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button29")]
	private Button _Button29;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CursorFlash")]
	private Timer _CursorFlash;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DoubleTouchSlow")]
	private Timer _DoubleTouchSlow;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClickClrTM")]
	private Timer _ClickClrTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClickClrDoubleStop")]
	private Timer _ClickClrDoubleStop;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClickDelDoubleStop")]
	private Timer _ClickDelDoubleStop;

	public static string PasswordSet = "";

	public static bool ControlKey;

	public bool CaseSet;

	public string Preload;

	public short CentreLocX;

	public short CentreLocY;

	public short LowLocY;

	private string InputText;

	private string ControlTarget;

	private int ControlLevel;

	private int OriginH;

	private int OriginW;

	private int OriginT;

	private int OriginL;

	private int OriginFont;

	private int ButtonNumberHold;

	private bool ClickClr;

	private bool ClickClrStop;

	private bool ClickDelStop;

	private bool FlashCursor;

	[field: AccessedThroughProperty("KeyPad")]
	internal virtual Panel KeyPad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button EnterKey
	{
		[CompilerGenerated]
		get
		{
			return _EnterKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = EnterKey_Click;
			Button button = _EnterKey;
			if (button != null)
			{
				button.Click -= value2;
			}
			_EnterKey = value;
			button = _EnterKey;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button CLR
	{
		[CompilerGenerated]
		get
		{
			return _CLR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CLR_Click;
			Button button = _CLR;
			if (button != null)
			{
				button.Click -= value2;
			}
			_CLR = value;
			button = _CLR;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button DEL
	{
		[CompilerGenerated]
		get
		{
			return _DEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DEL_Click;
			Button button = _DEL;
			if (button != null)
			{
				button.Click -= value2;
			}
			_DEL = value;
			button = _DEL;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button39
	{
		[CompilerGenerated]
		get
		{
			return _Button39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button39;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button39 = value;
			button = _Button39;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button38
	{
		[CompilerGenerated]
		get
		{
			return _Button38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button38;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button38 = value;
			button = _Button38;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button37
	{
		[CompilerGenerated]
		get
		{
			return _Button37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button37;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button37 = value;
			button = _Button37;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button36
	{
		[CompilerGenerated]
		get
		{
			return _Button36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button36;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button36 = value;
			button = _Button36;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button35
	{
		[CompilerGenerated]
		get
		{
			return _Button35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button35;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button35 = value;
			button = _Button35;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button34
	{
		[CompilerGenerated]
		get
		{
			return _Button34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button34;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button34 = value;
			button = _Button34;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button33
	{
		[CompilerGenerated]
		get
		{
			return _Button33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button33;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button33 = value;
			button = _Button33;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button32
	{
		[CompilerGenerated]
		get
		{
			return _Button32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button32;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button32 = value;
			button = _Button32;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button31
	{
		[CompilerGenerated]
		get
		{
			return _Button31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button31;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button31 = value;
			button = _Button31;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button30
	{
		[CompilerGenerated]
		get
		{
			return _Button30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button30;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button30 = value;
			button = _Button30;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button29
	{
		[CompilerGenerated]
		get
		{
			return _Button29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button29;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button29 = value;
			button = _Button29;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Timer CursorFlash
	{
		[CompilerGenerated]
		get
		{
			return _CursorFlash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CursorFlash_Tick;
			Timer timer = _CursorFlash;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_CursorFlash = value;
			timer = _CursorFlash;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer DoubleTouchSlow
	{
		[CompilerGenerated]
		get
		{
			return _DoubleTouchSlow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DoubleTouchSlow_Tick;
			Timer timer = _DoubleTouchSlow;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_DoubleTouchSlow = value;
			timer = _DoubleTouchSlow;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer ClickClrTM
	{
		[CompilerGenerated]
		get
		{
			return _ClickClrTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClickClrTM_Tick;
			Timer timer = _ClickClrTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ClickClrTM = value;
			timer = _ClickClrTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer ClickClrDoubleStop
	{
		[CompilerGenerated]
		get
		{
			return _ClickClrDoubleStop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClickClrDoubleStop_Tick;
			Timer timer = _ClickClrDoubleStop;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ClickClrDoubleStop = value;
			timer = _ClickClrDoubleStop;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer ClickDelDoubleStop
	{
		[CompilerGenerated]
		get
		{
			return _ClickDelDoubleStop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClickDelDoubleStop_Tick;
			Timer timer = _ClickDelDoubleStop;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ClickDelDoubleStop = value;
			timer = _ClickDelDoubleStop;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	public KeyPadEnter()
	{
		base.Activated += KeyPadEnter_Activated;
		base.Load += KeyPadEnter_Load;
		base.Deactivate += InfoEnter_Deactivate;
		Preload = "";
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
		this.KeyPad = new System.Windows.Forms.Panel();
		this.EnterKey = new System.Windows.Forms.Button();
		this.CLR = new System.Windows.Forms.Button();
		this.DEL = new System.Windows.Forms.Button();
		this.Button39 = new System.Windows.Forms.Button();
		this.Button38 = new System.Windows.Forms.Button();
		this.Button37 = new System.Windows.Forms.Button();
		this.Button36 = new System.Windows.Forms.Button();
		this.Button35 = new System.Windows.Forms.Button();
		this.Button34 = new System.Windows.Forms.Button();
		this.Button33 = new System.Windows.Forms.Button();
		this.Button32 = new System.Windows.Forms.Button();
		this.Button31 = new System.Windows.Forms.Button();
		this.Button30 = new System.Windows.Forms.Button();
		this.Button29 = new System.Windows.Forms.Button();
		this.CursorFlash = new System.Windows.Forms.Timer(this.components);
		this.DoubleTouchSlow = new System.Windows.Forms.Timer(this.components);
		this.ClickClrTM = new System.Windows.Forms.Timer(this.components);
		this.ClickClrDoubleStop = new System.Windows.Forms.Timer(this.components);
		this.ClickDelDoubleStop = new System.Windows.Forms.Timer(this.components);
		this.KeyPad.SuspendLayout();
		base.SuspendLayout();
		this.KeyPad.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.KeyPad.Controls.Add(this.EnterKey);
		this.KeyPad.Controls.Add(this.CLR);
		this.KeyPad.Controls.Add(this.DEL);
		this.KeyPad.Controls.Add(this.Button39);
		this.KeyPad.Controls.Add(this.Button38);
		this.KeyPad.Controls.Add(this.Button37);
		this.KeyPad.Controls.Add(this.Button36);
		this.KeyPad.Controls.Add(this.Button35);
		this.KeyPad.Controls.Add(this.Button34);
		this.KeyPad.Controls.Add(this.Button33);
		this.KeyPad.Controls.Add(this.Button32);
		this.KeyPad.Controls.Add(this.Button31);
		this.KeyPad.Controls.Add(this.Button30);
		this.KeyPad.Controls.Add(this.Button29);
		this.KeyPad.Location = new System.Drawing.Point(3, 3);
		this.KeyPad.Name = "KeyPad";
		this.KeyPad.Size = new System.Drawing.Size(240, 233);
		this.KeyPad.TabIndex = 5;
		this.EnterKey.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.EnterKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.EnterKey.Cursor = System.Windows.Forms.Cursors.Cross;
		this.EnterKey.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.EnterKey.Location = new System.Drawing.Point(8, 132);
		this.EnterKey.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.EnterKey.Name = "EnterKey";
		this.EnterKey.Size = new System.Drawing.Size(59, 83);
		this.EnterKey.TabIndex = 55;
		this.EnterKey.Text = "ENT";
		this.EnterKey.UseVisualStyleBackColor = false;
		this.CLR.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.CLR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.CLR.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CLR.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.CLR.Location = new System.Drawing.Point(6, 76);
		this.CLR.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.CLR.Name = "CLR";
		this.CLR.Size = new System.Drawing.Size(61, 50);
		this.CLR.TabIndex = 54;
		this.CLR.Text = "CLR";
		this.CLR.UseVisualStyleBackColor = false;
		this.DEL.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.DEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.DEL.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DEL.Location = new System.Drawing.Point(6, 17);
		this.DEL.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.DEL.Name = "DEL";
		this.DEL.Size = new System.Drawing.Size(61, 50);
		this.DEL.TabIndex = 53;
		this.DEL.Text = "DEL";
		this.DEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.DEL.UseVisualStyleBackColor = false;
		this.Button39.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button39.Location = new System.Drawing.Point(181, 17);
		this.Button39.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button39.Name = "Button39";
		this.Button39.Size = new System.Drawing.Size(50, 50);
		this.Button39.TabIndex = 52;
		this.Button39.Text = "9";
		this.Button39.UseVisualStyleBackColor = true;
		this.Button38.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button38.Location = new System.Drawing.Point(131, 17);
		this.Button38.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button38.Name = "Button38";
		this.Button38.Size = new System.Drawing.Size(50, 50);
		this.Button38.TabIndex = 51;
		this.Button38.Text = "8";
		this.Button38.UseVisualStyleBackColor = true;
		this.Button37.Font = new System.Drawing.Font("Verdana", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Button37.Location = new System.Drawing.Point(81, 17);
		this.Button37.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button37.Name = "Button37";
		this.Button37.Size = new System.Drawing.Size(50, 50);
		this.Button37.TabIndex = 50;
		this.Button37.Text = "7";
		this.Button37.UseVisualStyleBackColor = true;
		this.Button36.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button36.Location = new System.Drawing.Point(181, 67);
		this.Button36.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button36.Name = "Button36";
		this.Button36.Size = new System.Drawing.Size(50, 50);
		this.Button36.TabIndex = 49;
		this.Button36.Text = "6";
		this.Button36.UseVisualStyleBackColor = true;
		this.Button35.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button35.Location = new System.Drawing.Point(131, 67);
		this.Button35.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button35.Name = "Button35";
		this.Button35.Size = new System.Drawing.Size(50, 50);
		this.Button35.TabIndex = 48;
		this.Button35.Text = "5";
		this.Button35.UseVisualStyleBackColor = true;
		this.Button34.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button34.Location = new System.Drawing.Point(81, 67);
		this.Button34.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button34.Name = "Button34";
		this.Button34.Size = new System.Drawing.Size(50, 50);
		this.Button34.TabIndex = 47;
		this.Button34.Text = "4";
		this.Button34.UseVisualStyleBackColor = true;
		this.Button33.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button33.Location = new System.Drawing.Point(181, 116);
		this.Button33.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button33.Name = "Button33";
		this.Button33.Size = new System.Drawing.Size(50, 50);
		this.Button33.TabIndex = 46;
		this.Button33.Text = "3";
		this.Button33.UseVisualStyleBackColor = true;
		this.Button32.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button32.Location = new System.Drawing.Point(131, 116);
		this.Button32.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button32.Name = "Button32";
		this.Button32.Size = new System.Drawing.Size(50, 50);
		this.Button32.TabIndex = 45;
		this.Button32.Text = "2";
		this.Button32.UseVisualStyleBackColor = true;
		this.Button31.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button31.Location = new System.Drawing.Point(81, 116);
		this.Button31.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button31.Name = "Button31";
		this.Button31.Size = new System.Drawing.Size(50, 50);
		this.Button31.TabIndex = 44;
		this.Button31.Text = "1";
		this.Button31.UseVisualStyleBackColor = true;
		this.Button30.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button30.Location = new System.Drawing.Point(181, 167);
		this.Button30.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button30.Name = "Button30";
		this.Button30.Size = new System.Drawing.Size(50, 50);
		this.Button30.TabIndex = 43;
		this.Button30.Text = ".";
		this.Button30.UseVisualStyleBackColor = true;
		this.Button29.Font = new System.Drawing.Font("Verdana", 15.75f);
		this.Button29.Location = new System.Drawing.Point(81, 167);
		this.Button29.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button29.Name = "Button29";
		this.Button29.Size = new System.Drawing.Size(100, 50);
		this.Button29.TabIndex = 42;
		this.Button29.Text = "0";
		this.Button29.UseVisualStyleBackColor = true;
		this.CursorFlash.Interval = 300;
		this.DoubleTouchSlow.Interval = 300;
		this.ClickClrTM.Interval = 1000;
		this.ClickClrDoubleStop.Interval = 200;
		this.ClickDelDoubleStop.Interval = 300;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		base.ClientSize = new System.Drawing.Size(246, 238);
		base.Controls.Add(this.KeyPad);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "KeyPadEnter";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "KeyPad";
		base.TopMost = true;
		this.KeyPad.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void KeyPadEnter_Activated(object sender, EventArgs e)
	{
		if (!CursorFlash.Enabled)
		{
			InputText = Preload;
		}
		CursorFlash.Enabled = true;
		FlashCursor = true;
		ControlKey = true;
	}

	private void KeyPadEnter_Load(object sender, EventArgs e)
	{
	}

	private void InfoEnter_Deactivate(object sender, EventArgs e)
	{
		Button30.Visible = true;
		ControlLevel = 0;
	}

	public void SetLocation(object LocX, object LocY)
	{
		base.Location = new Point(Conversions.ToInteger(LocX), Conversions.ToInteger(LocY));
	}

	public void KeyboardAdjust()
	{
		int num = base.Height;
		int num2 = base.Width;
		checked
		{
			base.Size = new Size((int)Math.Round((float)num2 * Display.ResMultiW), (int)Math.Round((float)num * Display.ResMultiW));
			Resolution("KeyPad", "");
			int num3 = 29;
			do
			{
				Resolution("Button" + num3, "KeyPad");
				num3++;
			}
			while (num3 <= 39);
			Resolution("CLR", "KeyPad");
			Resolution("DEL", "KeyPad");
			Resolution("EnterKey", "KeyPad");
			ControlKey = true;
			if (!CursorFlash.Enabled)
			{
				CursorFlash.Enabled = true;
			}
			FlashCursor = true;
		}
	}

	public void DELETE()
	{
		CursorDel();
		if (Operators.CompareString(InputText, "", TextCompare: false) != 0)
		{
			InputText = Strings.Mid(InputText, 1, checked(Strings.Len(InputText) - 1));
			PasswordSet = InputText;
		}
	}

	public void CursorDel()
	{
		if (Operators.CompareString(InputText, "", TextCompare: false) != 0 && Operators.CompareString(Strings.Mid(InputText, Strings.Len(InputText), 1), "_", TextCompare: false) == 0)
		{
			InputText = Strings.Mid(InputText, 1, checked(Strings.Len(InputText) - 1));
			PasswordSet = InputText;
		}
	}

	private void Resolution(string ControlName, string ControlContainer)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(ControlContainer, "", TextCompare: false) > 0)
				{
					if (base.Controls[ControlContainer].Controls[ControlName].InvokeRequired)
					{
						SetControl2Callback method = Resolution;
						Invoke(method, ControlName, ControlContainer);
					}
					else if (!Display.ScreenType)
					{
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainer].Controls[ControlName].Font.Size * Display.ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Height * Display.ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Width * Display.ResMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Top * Display.ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Left * Display.ResMultiW);
					}
					else if (Display.ResMultiW < Display.ResMultiH)
					{
						float resMultiW = Display.ResMultiW;
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainer].Controls[ControlName].Font.Size * resMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Height * resMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Width * resMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Top * resMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Left * resMultiW);
					}
					else
					{
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainer].Controls[ControlName].Font.Size / Display.ResMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Height * Display.ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Width / Display.ResMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Top * Display.ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Left / Display.ResMultiW);
					}
				}
				else if (base.Controls[ControlName].InvokeRequired)
				{
					SetControl2Callback method2 = Resolution;
					Invoke(method2, ControlName, ControlContainer);
				}
				else if (!Display.ScreenType)
				{
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, base.Controls[ControlName].Font.Size * Display.ResMultiH);
					base.Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlName].Height * Display.ResMultiH);
					base.Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlName].Width * Display.ResMultiW);
					base.Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlName].Top * Display.ResMultiH);
					base.Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlName].Left * Display.ResMultiW);
				}
				else if (Display.ResMultiW < Display.ResMultiH)
				{
					float resMultiW2 = Display.ResMultiW;
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, base.Controls[ControlName].Font.Size * resMultiW2);
					base.Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlName].Height * resMultiW2);
					base.Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlName].Width * resMultiW2);
					base.Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlName].Top * resMultiW2);
					base.Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlName].Left * resMultiW2);
				}
				else
				{
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, base.Controls[ControlName].Font.Size / Display.ResMultiH);
					base.Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlName].Height * Display.ResMultiH);
					base.Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlName].Width / Display.ResMultiW);
					base.Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlName].Top * Display.ResMultiH);
					base.Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlName].Left / Display.ResMultiW);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ResolutionA(string ControlName, string ControlContainer)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(ControlContainer, "", TextCompare: false) > 0)
				{
					if (base.Controls[ControlContainer].Controls[ControlName].InvokeRequired)
					{
						SetControl2Callback method = Resolution;
						Invoke(method, ControlName, ControlContainer);
					}
					else
					{
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainer].Controls[ControlName].Font.Size * Display.ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Height * Display.ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Width * Display.ResMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Top * Display.ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Left * Display.ResMultiW);
					}
				}
				else if (base.Controls[ControlName].InvokeRequired)
				{
					SetControl2Callback method2 = Resolution;
					Invoke(method2, ControlName, ControlContainer);
				}
				else
				{
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, base.Controls[ControlName].Font.Size * Display.ResMultiH);
					base.Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlName].Height * Display.ResMultiH);
					base.Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlName].Width * Display.ResMultiW);
					base.Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlName].Top * Display.ResMultiH);
					base.Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlName].Left * Display.ResMultiW);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void EnterKey_Click(object sender, EventArgs e)
	{
		EnterKeyPress();
	}

	private void EnterKeyPress()
	{
		FlashCursor = false;
		ControlLevel = 2;
		CursorDel();
		if (Operators.CompareString(InputText, "", TextCompare: false) == 0)
		{
			PasswordSet = Preload;
		}
		else
		{
			PasswordSet = InputText;
			InputText = "                      ";
		}
		ControlKey = false;
		base.Visible = false;
	}

	private void CLR_Click(object sender, EventArgs e)
	{
		if (!ClickClrStop)
		{
			if (ClickClr)
			{
				ClickClr = false;
				InputText = "";
				EnterKeyPress();
			}
			else
			{
				ClickClrStop = true;
				ClickClrDoubleStop.Enabled = true;
				ClickClr = true;
				ClickClrTM.Enabled = true;
			}
		}
	}

	private void DEL_Click(object sender, EventArgs e)
	{
		CursorDel();
		DELETE();
		DEL.Enabled = false;
		ClickDelDoubleStop.Enabled = true;
	}

	private void CursorFlash_Tick(object sender, EventArgs e)
	{
		if (FlashCursor)
		{
			if (Operators.CompareString(InputText, "", TextCompare: false) != 0)
			{
				if (Operators.CompareString(Strings.Mid(InputText, Strings.Len(InputText), 1), "_", TextCompare: false) == 0)
				{
					InputText = Strings.Mid(InputText, 1, checked(Strings.Len(InputText) - 1));
				}
				else
				{
					InputText += "_";
				}
			}
			else
			{
				InputText += "_";
			}
			PasswordSet = InputText;
		}
		else
		{
			CursorFlash.Dispose();
			CursorDel();
		}
	}

	private void Button_Click(object sender, EventArgs e)
	{
		Button button = sender as Button;
		if (DoubleTouchSlow.Enabled)
		{
			DoubleTouchSlow.Dispose();
			ButtonNumberReset();
		}
		CursorDel();
		if (Strings.Len(InputText) < 30)
		{
			string name = button.Name;
			int num = checked((int)Math.Round(Conversion.Val(Strings.Mid(name, 7, Strings.Len(name) - 6))));
			InputText += base.Controls["KeyPad"].Controls["Button" + num].Text;
			base.Controls["KeyPad"].Controls["Button" + Conversions.ToString(num)].Enabled = false;
			PasswordSet = InputText;
			ButtonNumberHold = num;
			DoubleTouchSlow.Enabled = true;
		}
	}

	private void ButtonNumberReset()
	{
		if (ButtonNumberHold > 0)
		{
			if (ButtonNumberHold > 28)
			{
				base.Controls["KeyPad"].Controls["Button" + Conversions.ToString(ButtonNumberHold)].Enabled = true;
			}
			else
			{
				base.Controls["KeyBoard"].Controls["Button" + Conversions.ToString(ButtonNumberHold)].Enabled = true;
			}
		}
	}

	private void DoubleTouchSlow_Tick(object sender, EventArgs e)
	{
		DoubleTouchSlow.Dispose();
		ButtonNumberReset();
	}

	private void ClickClrTM_Tick(object sender, EventArgs e)
	{
		ClickClrTM.Dispose();
		ClickClr = false;
	}

	private void ClickClrDoubleStop_Tick(object sender, EventArgs e)
	{
		ClickClrDoubleStop.Dispose();
		ClickClrStop = false;
	}

	private void ClickDelDoubleStop_Tick(object sender, EventArgs e)
	{
		ClickDelDoubleStop.Dispose();
		DEL.Enabled = true;
	}
}
