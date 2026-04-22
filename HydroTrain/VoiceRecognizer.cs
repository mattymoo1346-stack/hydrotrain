using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Speech.Recognition;
using System.Threading;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class VoiceRecognizer : Form
{
	public delegate void SetControl1Callback(string ControlName, string Data);

	public delegate void SetTimerEnable(bool enable);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ZeroTrackLevel")]
	private Button _ZeroTrackLevel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InitialSilenceTimeoutSet")]
	private TextBox _InitialSilenceTimeoutSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BabbleTimeoutSet")]
	private TextBox _BabbleTimeoutSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EndSilenceTimeoutSet")]
	private TextBox _EndSilenceTimeoutSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EndSilenceTimeoutAmbiguousSet")]
	private TextBox _EndSilenceTimeoutAmbiguousSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MaxAltSet")]
	private TextBox _MaxAltSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private System.Windows.Forms.Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VoiceControlDeviceTM")]
	private System.Windows.Forms.Timer _VoiceControlDeviceTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ExitPage")]
	private Button _ExitPage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WelcomeTM")]
	private System.Windows.Forms.Timer _WelcomeTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MicOnTM")]
	private System.Windows.Forms.Timer _MicOnTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TrackBar1")]
	private TrackBar _TrackBar1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ControlVoiceOffTM")]
	private System.Windows.Forms.Timer _ControlVoiceOffTM;

	private CultureInfo CI;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("recognizer")]
	private SpeechRecognitionEngine _recognizer;

	private Thread RecogThread;

	private Thread CommandThread;

	private bool Welcome;

	private string VoiceCommand;

	private string VoiceConfired;

	public bool VoiceOnOff;

	private string VoiceName;

	private string Addwordlist;

	private string AddList;

	private string[] WordList;

	private string[] WordListA;

	private bool VoiceControlDevice;

	private bool RestartHydro;

	private int ControlLevel;

	private int MicLevel;

	private int MicLevelCount;

	private int LevelSet;

	private string ItemName;

	private byte State;

	[SpecialName]
	private string[] _0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine_0024Init;

	[SpecialName]
	private string[] _0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen_0024Init;

	[SpecialName]
	private string[] _0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten_0024Init;

	[field: AccessedThroughProperty("MainDisplay")]
	internal virtual TextBox MainDisplay
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button ZeroTrackLevel
	{
		[CompilerGenerated]
		get
		{
			return _ZeroTrackLevel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ZeroTrackLevel_Click;
			Button button = _ZeroTrackLevel;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ZeroTrackLevel = value;
			button = _ZeroTrackLevel;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual TextBox InitialSilenceTimeoutSet
	{
		[CompilerGenerated]
		get
		{
			return _InitialSilenceTimeoutSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selection_Click;
			TextBox textBox = _InitialSilenceTimeoutSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_InitialSilenceTimeoutSet = value;
			textBox = _InitialSilenceTimeoutSet;
			if (textBox != null)
			{
				textBox.Click += value2;
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

	internal virtual TextBox BabbleTimeoutSet
	{
		[CompilerGenerated]
		get
		{
			return _BabbleTimeoutSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selection_Click;
			TextBox textBox = _BabbleTimeoutSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_BabbleTimeoutSet = value;
			textBox = _BabbleTimeoutSet;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox EndSilenceTimeoutSet
	{
		[CompilerGenerated]
		get
		{
			return _EndSilenceTimeoutSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selection_Click;
			TextBox textBox = _EndSilenceTimeoutSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_EndSilenceTimeoutSet = value;
			textBox = _EndSilenceTimeoutSet;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox EndSilenceTimeoutAmbiguousSet
	{
		[CompilerGenerated]
		get
		{
			return _EndSilenceTimeoutAmbiguousSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selection_Click;
			TextBox textBox = _EndSilenceTimeoutAmbiguousSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_EndSilenceTimeoutAmbiguousSet = value;
			textBox = _EndSilenceTimeoutAmbiguousSet;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox MaxAltSet
	{
		[CompilerGenerated]
		get
		{
			return _MaxAltSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selection_Click;
			TextBox textBox = _MaxAltSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_MaxAltSet = value;
			textBox = _MaxAltSet;
			if (textBox != null)
			{
				textBox.Click += value2;
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

	[field: AccessedThroughProperty("LevelBar")]
	internal virtual ProgressBar LevelBar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaxLevel")]
	internal virtual Button MaxLevel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer VoiceControlDeviceTM
	{
		[CompilerGenerated]
		get
		{
			return _VoiceControlDeviceTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = VoiceControlDeviceTM_Tick;
			System.Windows.Forms.Timer timer = _VoiceControlDeviceTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_VoiceControlDeviceTM = value;
			timer = _VoiceControlDeviceTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Button ExitPage
	{
		[CompilerGenerated]
		get
		{
			return _ExitPage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ExitPage_Click;
			Button button = _ExitPage;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ExitPage = value;
			button = _ExitPage;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer WelcomeTM
	{
		[CompilerGenerated]
		get
		{
			return _WelcomeTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WelcomeTM_Tick;
			System.Windows.Forms.Timer timer = _WelcomeTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_WelcomeTM = value;
			timer = _WelcomeTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer MicOnTM
	{
		[CompilerGenerated]
		get
		{
			return _MicOnTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MicOnTM_Tick;
			System.Windows.Forms.Timer timer = _MicOnTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_MicOnTM = value;
			timer = _MicOnTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual TrackBar TrackBar1
	{
		[CompilerGenerated]
		get
		{
			return _TrackBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TrackBar1_Scroll;
			TrackBar trackBar = _TrackBar1;
			if (trackBar != null)
			{
				trackBar.Scroll -= value2;
			}
			_TrackBar1 = value;
			trackBar = _TrackBar1;
			if (trackBar != null)
			{
				trackBar.Scroll += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer ControlVoiceOffTM
	{
		[CompilerGenerated]
		get
		{
			return _ControlVoiceOffTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ControlVoiceOffTM_Tick;
			System.Windows.Forms.Timer timer = _ControlVoiceOffTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ControlVoiceOffTM = value;
			timer = _ControlVoiceOffTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	private virtual SpeechRecognitionEngine recognizer
	{
		[CompilerGenerated]
		get
		{
			return _recognizer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler<RecognizeCompletedEventArgs> value2 = recognizer_RecognizeCompleted;
			SpeechRecognitionEngine speechRecognitionEngine = _recognizer;
			if (speechRecognitionEngine != null)
			{
				speechRecognitionEngine.RecognizeCompleted -= value2;
			}
			_recognizer = value;
			speechRecognitionEngine = _recognizer;
			if (speechRecognitionEngine != null)
			{
				speechRecognitionEngine.RecognizeCompleted += value2;
			}
		}
	}

	public VoiceRecognizer()
	{
		base.Load += VoiceControl_Load;
		base.Closing += VoiceRecognizer_Closing;
		CI = new CultureInfo("en-GB", useUserOverride: false);
		recognizer = new SpeechRecognitionEngine();
		VoiceName = Interaction.GetSetting("Dtread", "Aqua", "VoiceName", "vicky");
		VoiceControlDevice = true;
		LevelSet = checked((int)Math.Round(Conversion.Val(Interaction.GetSetting("Dtread", "Aqua", "VoiceLevel", "8"))));
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
		this.MainDisplay = new System.Windows.Forms.TextBox();
		this.ZeroTrackLevel = new System.Windows.Forms.Button();
		this.InitialSilenceTimeoutSet = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.BabbleTimeoutSet = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.EndSilenceTimeoutSet = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.EndSilenceTimeoutAmbiguousSet = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.MaxAltSet = new System.Windows.Forms.TextBox();
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.LevelBar = new System.Windows.Forms.ProgressBar();
		this.MaxLevel = new System.Windows.Forms.Button();
		this.VoiceControlDeviceTM = new System.Windows.Forms.Timer(this.components);
		this.ExitPage = new System.Windows.Forms.Button();
		this.WelcomeTM = new System.Windows.Forms.Timer(this.components);
		this.MicOnTM = new System.Windows.Forms.Timer(this.components);
		this.TrackBar1 = new System.Windows.Forms.TrackBar();
		this.Label6 = new System.Windows.Forms.Label();
		this.ControlVoiceOffTM = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.TrackBar1).BeginInit();
		base.SuspendLayout();
		this.MainDisplay.Location = new System.Drawing.Point(248, 187);
		this.MainDisplay.Multiline = true;
		this.MainDisplay.Name = "MainDisplay";
		this.MainDisplay.ReadOnly = true;
		this.MainDisplay.Size = new System.Drawing.Size(164, 229);
		this.MainDisplay.TabIndex = 0;
		this.ZeroTrackLevel.Location = new System.Drawing.Point(89, 351);
		this.ZeroTrackLevel.Name = "ZeroTrackLevel";
		this.ZeroTrackLevel.Size = new System.Drawing.Size(75, 23);
		this.ZeroTrackLevel.TabIndex = 1;
		this.ZeroTrackLevel.Text = "ZERO";
		this.ZeroTrackLevel.UseVisualStyleBackColor = true;
		this.InitialSilenceTimeoutSet.Location = new System.Drawing.Point(195, 23);
		this.InitialSilenceTimeoutSet.Name = "InitialSilenceTimeoutSet";
		this.InitialSilenceTimeoutSet.Size = new System.Drawing.Size(100, 20);
		this.InitialSilenceTimeoutSet.TabIndex = 2;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(31, 26);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(110, 13);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "Initial Silence Timeout";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(31, 56);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(81, 13);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Babble Timeout";
		this.BabbleTimeoutSet.Location = new System.Drawing.Point(195, 53);
		this.BabbleTimeoutSet.Name = "BabbleTimeoutSet";
		this.BabbleTimeoutSet.Size = new System.Drawing.Size(100, 20);
		this.BabbleTimeoutSet.TabIndex = 4;
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(31, 86);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(108, 13);
		this.Label3.TabIndex = 7;
		this.Label3.Text = "End Silence Timeout ";
		this.EndSilenceTimeoutSet.Location = new System.Drawing.Point(195, 83);
		this.EndSilenceTimeoutSet.Name = "EndSilenceTimeoutSet";
		this.EndSilenceTimeoutSet.Size = new System.Drawing.Size(100, 20);
		this.EndSilenceTimeoutSet.TabIndex = 6;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(31, 116);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(160, 13);
		this.Label4.TabIndex = 9;
		this.Label4.Text = "End Silence Timeout Ambiguous";
		this.EndSilenceTimeoutAmbiguousSet.Location = new System.Drawing.Point(195, 113);
		this.EndSilenceTimeoutAmbiguousSet.Name = "EndSilenceTimeoutAmbiguousSet";
		this.EndSilenceTimeoutAmbiguousSet.Size = new System.Drawing.Size(100, 20);
		this.EndSilenceTimeoutAmbiguousSet.TabIndex = 8;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(31, 159);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(77, 13);
		this.Label5.TabIndex = 11;
		this.Label5.Text = "Max Alternates";
		this.MaxAltSet.Location = new System.Drawing.Point(195, 156);
		this.MaxAltSet.Name = "MaxAltSet";
		this.MaxAltSet.Size = new System.Drawing.Size(100, 20);
		this.MaxAltSet.TabIndex = 10;
		this.LevelBar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
		this.LevelBar.Location = new System.Drawing.Point(24, 393);
		this.LevelBar.Maximum = 101;
		this.LevelBar.Minimum = 1;
		this.LevelBar.Name = "LevelBar";
		this.LevelBar.Size = new System.Drawing.Size(199, 23);
		this.LevelBar.Step = 1;
		this.LevelBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.LevelBar.TabIndex = 13;
		this.LevelBar.Value = 1;
		this.MaxLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.MaxLevel.Location = new System.Drawing.Point(89, 422);
		this.MaxLevel.Name = "MaxLevel";
		this.MaxLevel.Size = new System.Drawing.Size(75, 23);
		this.MaxLevel.TabIndex = 15;
		this.MaxLevel.Text = "0";
		this.MaxLevel.UseVisualStyleBackColor = true;
		this.VoiceControlDeviceTM.Interval = 5000;
		this.ExitPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ExitPage.Location = new System.Drawing.Point(357, 12);
		this.ExitPage.Name = "ExitPage";
		this.ExitPage.Size = new System.Drawing.Size(55, 44);
		this.ExitPage.TabIndex = 162;
		this.ExitPage.Text = "X";
		this.ExitPage.UseVisualStyleBackColor = true;
		this.WelcomeTM.Interval = 5000;
		this.MicOnTM.Interval = 1000;
		this.TrackBar1.LargeChange = 1;
		this.TrackBar1.Location = new System.Drawing.Point(12, 230);
		this.TrackBar1.Maximum = 50;
		this.TrackBar1.Minimum = 1;
		this.TrackBar1.Name = "TrackBar1";
		this.TrackBar1.Size = new System.Drawing.Size(230, 64);
		this.TrackBar1.TabIndex = 163;
		this.TrackBar1.Value = 1;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(89, 270);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(72, 13);
		this.Label6.TabIndex = 164;
		this.Label6.Text = "Set Mic Level";
		this.ControlVoiceOffTM.Interval = 55000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(454, 521);
		base.ControlBox = false;
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.TrackBar1);
		base.Controls.Add(this.ExitPage);
		base.Controls.Add(this.MaxLevel);
		base.Controls.Add(this.LevelBar);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.MaxAltSet);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.EndSilenceTimeoutAmbiguousSet);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.EndSilenceTimeoutSet);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.BabbleTimeoutSet);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.InitialSilenceTimeoutSet);
		base.Controls.Add(this.ZeroTrackLevel);
		base.Controls.Add(this.MainDisplay);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "VoiceRecognizer";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Voice Control";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		((System.ComponentModel.ISupportInitialize)this.TrackBar1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Setbar()
	{
		LevelBar.Maximum = 100;
		LevelBar.Minimum = 0;
	}

	public void SetMic()
	{
		try
		{
			recognizer.RecognizeAsyncStop();
			recognizer.RequestRecognizerUpdate();
			recognizer.SetInputToDefaultAudioDevice();
			SetVoiceSync();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void recfailevent(object sender, RecognitionEventArgs e)
	{
		SetVoiceSync();
	}

	private void VoiceControl_Load(object sender, EventArgs e)
	{
		Hide();
		Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
		if (Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "Voice", Conversions.ToString(Value: false))))
		{
			Setbar();
			Setup();
			SetAudioDeviceOn();
		}
	}

	private void MicOnTM_Tick(object sender, EventArgs e)
	{
		SetAudioDeviceOn();
	}

	private void SetAudioDeviceOn()
	{
		try
		{
			recognizer.SetInputToDefaultAudioDevice();
			VoiceControlDevice = true;
			WelcomeTM.Enabled = true;
			MicOnTM.Dispose();
			TrackBar1.Value = LevelSet;
			Label6.Text = "Set Mic Level " + LevelSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			VoiceControlDevice = false;
			MicOnTM.Enabled = true;
			ProjectData.ClearProjectError();
		}
		if (VoiceControlDevice)
		{
			WordListBuild();
			Choices alternateChoices = new Choices(WordList);
			object obj = new Grammar(new GrammarBuilder(alternateChoices));
			recognizer.LoadGrammar((Grammar)obj);
			recognizer.SpeechRecognized += recevent;
			recognizer.SpeechRecognitionRejected += recfailevent;
			recognizer.AudioLevelUpdated += level;
			recognizer.AudioStateChanged += AudioState;
		}
		else
		{
			VoiceControlDeviceTM.Enabled = true;
		}
	}

	public void AudioState(object sender, AudioStateChangedEventArgs e)
	{
		State = checked((byte)e.AudioState);
		if (State == 2)
		{
			MicLevelCount = 0;
		}
		MaxLevel.BackColor = Color.Transparent;
	}

	public void level(object sender, AudioLevelUpdatedEventArgs e)
	{
		checked
		{
			MicLevel = (int)Math.Round(Conversion.Val(e.AudioLevel));
			if (MicLevel < TrackBar1.Value)
			{
				MicLevelCount++;
				if (MicLevelCount > 20)
				{
					MicLevelCount = 0;
					MaxLevel.Text = "0";
					MyProject.Forms.Display.MaxLevel.Text = "0";
				}
			}
			else
			{
				MicLevelCount = 0;
			}
			if (Conversion.Val(e.AudioLevel) > 0.0)
			{
				LevelBar.Value = (int)Math.Round(Conversion.Val(e.AudioLevel));
			}
			else
			{
				LevelBar.Value = 0;
			}
			if ((MaxLevel.BackColor == Color.Transparent) & VoiceOnOff)
			{
				MaxLevel.BackColor = Color.Cyan;
				MyProject.Forms.Display.LevelBarSet.BackColor = Color.DodgerBlue;
			}
			else
			{
				MaxLevel.BackColor = Color.Transparent;
				MyProject.Forms.Display.LevelBarSet.BackColor = Color.DarkBlue;
			}
			MyProject.Forms.Display.LevelBar.Value = LevelBar.Value;
			MyProject.Forms.Display.LevelBarSet.Value = LevelSet;
			if (((double)LevelBar.Value > Conversion.Val(MaxLevel.Text)) & (LevelBar.Value > 0))
			{
				MaxLevel.Text = LevelBar.Value.ToString();
				MyProject.Forms.Display.MaxLevel.Text = MaxLevel.Text;
			}
		}
	}

	public void recevent(object sender, RecognitionEventArgs e)
	{
		Display.NewSpeech = false;
		MyProject.Forms.Display.UpdateVoiceImage();
		try
		{
			if (((double)e.Result.Confidence > 0.4) & ((double)e.Result.Confidence < 0.97))
			{
				MainDisplayChange("Text", e.Result.Text + ", " + MainDisplay.Text);
				if (Strings.Len(MainDisplay.Text) > 250)
				{
					MainDisplay.Text = Strings.Mid(MainDisplay.Text, 1, checked(Strings.Len(MainDisplay.Text) - 50));
				}
				VoiceCommand = e.Result.Text;
			}
			else
			{
				SetVoiceSync();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
	{
		if (Operators.CompareString(VoiceCommand, "", TextCompare: false) > 0)
		{
			NativeMethods.TurnOnScreen();
			Command(VoiceCommand);
			VoiceCommand = "";
		}
		else
		{
			SetVoiceSync();
		}
	}

	public void SetVoiceSync()
	{
		if (recognizer.AudioState == System.Speech.Recognition.AudioState.Stopped)
		{
			MaxLevel.Text = "0";
			MyProject.Forms.Display.MaxLevel.Text = "0";
			SetupCheck();
			RecogThread = new Thread(SetRecog);
			RecogThread.Priority = ThreadPriority.Highest;
			RecogThread.Start();
		}
		Display.NewSpeech = true;
		MyProject.Forms.Display.UpdateVoiceImage();
	}

	private void SetRecog()
	{
		try
		{
			recognizer.RecognizeAsync();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void Recognizercancell(object Talk)
	{
		recognizer.RecognizeAsyncCancel();
		recognizer.RecognizeAsyncStop();
		VoiceCommand = Conversions.ToString(Talk);
	}

	private string GroupToWords(float num)
	{
		if (_0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine_0024Init, ref lockTaken);
			if (_0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine_0024Init.State == 0)
			{
				_0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine_0024Init.State = 2;
				_0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine = new string[10] { "point zero", "point one", "point two", "point three", "point four", "point five", "point six", "point seven", "point eight", "point nine" };
			}
			else if (_0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine_0024Init);
			}
		}
		if (_0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken2 = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen_0024Init, ref lockTaken2);
			if (_0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen_0024Init.State == 0)
			{
				_0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen_0024Init.State = 2;
				_0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen = new string[20]
				{
					"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
					"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eightteen", "nineteen"
				};
			}
			else if (_0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen_0024Init.State = 1;
			if (lockTaken2)
			{
				Monitor.Exit(_0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen_0024Init);
			}
		}
		if (_0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken3 = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten_0024Init, ref lockTaken3);
			if (_0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten_0024Init.State == 0)
			{
				_0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten_0024Init.State = 2;
				_0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten = new string[8] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
			}
			else if (_0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten_0024Init.State = 1;
			if (lockTaken3)
			{
				Monitor.Exit(_0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten_0024Init);
			}
		}
		num = (float)Math.Round(num, 1);
		string text = "";
		string text2 = "";
		checked
		{
			if (num < 20f)
			{
				int num2 = (int)Math.Floor(num);
				int num3 = (int)Math.Round((num - (float)num2) * 10f);
				if (num3 > 0)
				{
					text2 = _0024STATIC_0024GroupToWords_0024201EC_0024pointone_to_pointnine[num3];
				}
				text = text + " " + _0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen[num2] + " " + text2;
			}
			else if (num < 100f)
			{
				int num2 = (int)unchecked(checked((long)Math.Round(num)) / 10);
				num %= 10f;
				text = text + " " + _0024STATIC_0024GroupToWords_0024201EC_0024multiples_of_ten[num2 - 2];
				if (num > 0f)
				{
					text = text + " " + _0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen[(int)Math.Round(num)];
				}
			}
			else if (num > 99f)
			{
				int num2 = (int)unchecked(checked((long)Math.Round(num)) / 100);
				num %= 100f;
				text = _0024STATIC_0024GroupToWords_0024201EC_0024one_to_nineteen[num2] + " hundred";
			}
			return text.Trim();
		}
	}

	private void WordListBuild_Revoved_16_11_21()
	{
		Addwordlist += "voice operate, voiceoff, voice off, voice stop, voice on, voiceon, cancell, ";
		Addwordlist += "start program, hold program, pause program, continue program, end program, reset emergency Stop, close program, ";
		Addwordlist += "chamber depth up, chamber depth down, chamber depth zero, chamber level up, chamber level down, chamber level zero, ";
		Addwordlist += "Jet operate, jetoperate, jet stop, jetstop,  stop jet, stopjet, clean control On, clean control off, ";
		Addwordlist += "set Estop, set eng, show relay 88, show relay 816, show voice, show level, exit level, level control up, level control down, show io pot, show usb iss, ";
		Addwordlist += "pump operate, pumpoperate, pumpon, pumpoff, pump on, pump off, fill chamber, chamber off, empty chamber, chamber pump on, chamber pump off, ";
		Addwordlist += "select speed down, select speed up, select speed manual, speed up, speed down, conveyor reverse, reverse conveyor, conveyor forward, ";
		Addwordlist += "set max speed, set speed zero, set 0 speed, ";
		Addwordlist += "select incline down, select incline up, select incline manual, incline control up, incline control down, ";
		Addwordlist += "set max incline, set zero incline, set 0 incline, ";
		Addwordlist += "delay timer cycle, delay timer On, delay timer off, ";
		Addwordlist += "duration 020, duration 025, duration 030, duration 035, duration 040, duration 045, duration 050, duration 055, ";
		Addwordlist += "duration 1, duration 105, duration 110, duration 115, duration 120, duration 125, duration 130, duration 135, duration 140, duration 145, duration 150, duration 155, ";
		Addwordlist += "duration 2, duration 205, duration 210, duration 215, duration 220, duration 225, duration 230, duration 235, duration 240, duration 245, duration 250, duration 255, ";
		Addwordlist += "duration 3, duration 305, duration 310, duration 315, duration 320, duration 325, duration 330, duration 335, duration 340, duration 345, duration 350, duration 355, ";
		Addwordlist += "duration 4, duration 405, duration 410, duration 415, duration 420, duration 425, duration 430, duration 435, duration 440, duration 445, duration 450, duration 455, ";
		Addwordlist += "duration 5, duration five, duration 505, duration 510, duration 515, duration 520, duration 525, duration 530, duration 535, duration 540, duration 545, duration 550, duration 555, ";
		Addwordlist += "duration 6, duration 605, duration 610, duration 615, duration 620, duration 625, duration 630, duration 635, duration 640, duration 645, duration 650, duration 655, ";
		Addwordlist += "duration 7, duration 705, duration 710, duration 715, duration 720, duration 725, duration 730, duration 735, duration 740, duration 745, duration 750, duration 755, ";
		Addwordlist += "duration 8, duration 805, duration 810, duration 815, duration 820, duration 825, duration 830, duration 835, duration 840, duration 845, duration 850, duration 855, ";
		Addwordlist += "duration 9, duration 905, duration 910, duration 915, duration 920, duration 925, duration 930, duration 935, duration 940, duration 945, duration 950, duration 955, ";
		Addwordlist += "duration 10, duration 1015, duration 1030, duration 1045, ";
		Addwordlist += "duration 11, duration 1115, duration 1130, duration 1145, ";
		Addwordlist += "duration 12, duration 1215, duration 1230, duration 1245, ";
		Addwordlist += "duration 13, duration 1315, duration 1330, duration 1345, ";
		Addwordlist += "duration 14, duration 1415, duration 1430, duration 1445, ";
		Addwordlist += "duration 15, duration 1515, duration 1530, duration 1545, ";
		Addwordlist += "duration 16, duration 1615, duration 1630, duration 1645, ";
		Addwordlist += "duration 17, duration 1715, duration 1730, duration 1745, ";
		Addwordlist += "duration 18, duration 1815, duration 1830, duration 1845, ";
		Addwordlist += "duration 19, duration 1915, duration 1930, duration 1945, ";
		Addwordlist += "duration 20, duration 2015, duration 2030, duration 2045, ";
		Addwordlist += "duration 21, duration 2115, duration 2130, duration 2145, ";
		Addwordlist += "duration 22, duration 2215, duration 2230, duration 2245, ";
		Addwordlist += "duration 23, duration 2315, duration 2330, duration 2345, ";
		Addwordlist += "duration 24, duration 2415, duration 2430, duration 2445, ";
		Addwordlist += "duration 25, duration 2515, duration 2530, duration 2545, ";
		Addwordlist += "duration 26, duration 2615, duration 2630, duration 2645, ";
		Addwordlist += "duration 27, duration 2715, duration 2730, duration 2745, ";
		Addwordlist += "duration 28, duration 2815, duration 2830, duration 2845, ";
		Addwordlist += "duration 29, duration 2915, duration 2930, duration 2945, ";
		Addwordlist += "duration 30, duration 3015, duration 3030, duration 3045, ";
		Addwordlist += "duration 31, duration 3115, duration 3130, duration 3145, ";
		Addwordlist += "duration 32, duration 3215, duration 3230, duration 3245, ";
		Addwordlist += "duration 33, duration 3315, duration 3330, duration 3345, ";
		Addwordlist += "duration 34, duration 3415, duration 3430, duration 3445, ";
		Addwordlist += "duration 35, duration 3515, duration 3530, duration 3545, ";
		Addwordlist += "duration 36, duration 3615, duration 3630, duration 3645, ";
		Addwordlist += "duration 37, duration 3715, duration 3730, duration 3745, ";
		Addwordlist += "duration 38, duration 3815, duration 3830, duration 3845, ";
		Addwordlist += "duration 39, duration 3915, duration 3930, duration 3945, ";
		Addwordlist += "duration 40, duration 4015, duration 4030, duration 4045, ";
		Addwordlist += "duration 41, duration 4115, duration 4130, duration 4145, ";
		Addwordlist += "duration 42, duration 4215, duration 4230, duration 4245, ";
		Addwordlist += "duration 43, duration 2415, duration 4230, duration 4345, ";
		Addwordlist += "duration 44, duration 4415, duration 4430, duration 4445, ";
		Addwordlist += "duration 45, duration 4515, duration 4530, duration 4545, ";
		Addwordlist += "duration 46, duration 4615, duration 4630, duration 4645, ";
		Addwordlist += "duration 47, duration 4715, duration 4730, duration 4745, ";
		Addwordlist += "duration 48, duration 4815, duration 4830, duration 4845, ";
		Addwordlist += "duration 49, duration 4915, duration 4930, duration 4945, ";
		Addwordlist += "duration 50, duration 5015, duration 5030, duration 5045, ";
		Addwordlist += "duration 51, duration 5115, duration 5130, duration 5145, ";
		Addwordlist += "duration 52, duration 5215, duration 5230, duration 5245, ";
		Addwordlist += "duration 53, duration 5315, duration 5330, duration 5345, ";
		Addwordlist += "duration 54, duration 5415, duration 5430, duration 5445, ";
		Addwordlist += "duration 55, duration 5515, duration 5530, duration 5545, ";
		Addwordlist += "duration 56, duration 5615, duration 5630, duration 5645, ";
		Addwordlist += "duration 57, duration 5715, duration 5730, duration 5745, ";
		Addwordlist += "duration 58, duration 5815, duration 5830, duration 5845, ";
		Addwordlist += "duration 59, duration 5915, duration 5930, duration 5945, ";
		SetLanguage();
		WordListA = Strings.Split(Addwordlist, ", ");
		AddList = VoiceName + " " + WordListA[0] + ", " + WordListA[0];
		checked
		{
			int num = Microsoft.VisualBasic.Information.UBound(WordListA) - 1;
			for (int i = 1; i <= num; i++)
			{
				AddList = AddList + ", " + VoiceName + " " + WordListA[i] + ", " + WordListA[i];
			}
			AddList = AddList + ", " + VoiceName + ",  yes,  no,  confirmed,  emergency empty";
			WordList = Strings.Split(AddList, ", ");
		}
	}

	private void Selection_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = Conversions.ToString(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null));
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void RunNewEntre()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		switch (ItemName)
		{
		case "MaxAltSet":
			if (Conversion.Val(MaxAltSet.Text) == 0.0)
			{
				MaxAltSetChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = MaxAltSet.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "EndSilenceTimeoutAmbiguousSet":
			if (Conversion.Val(EndSilenceTimeoutAmbiguousSet.Text) == 0.0)
			{
				EndSilenceTimeoutAmbiguousSetChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = EndSilenceTimeoutAmbiguousSet.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "EndSilenceTimeoutSet":
			if (Conversion.Val(EndSilenceTimeoutSet.Text) == 0.0)
			{
				EndSilenceTimeoutSetChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = EndSilenceTimeoutSet.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "BabbleTimeoutSet":
			if (Conversion.Val(BabbleTimeoutSet.Text) == 0.0)
			{
				BabbleTimeoutSetChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = BabbleTimeoutSet.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "InitialSilenceTimeoutSet":
			if (Conversion.Val(InitialSilenceTimeoutSet.Text) == 0.0)
			{
				InitialSilenceTimeoutSetChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = InitialSilenceTimeoutSet.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		switch (ItemName)
		{
		case "MaxAltSet":
			MaxAltSetChange("TextAlign", "Left");
			MaxAltSetChange("Text", InfoEnter.PasswordSet);
			break;
		case "EndSilenceTimeoutAmbiguousSet":
			EndSilenceTimeoutAmbiguousSetChange("TextAlign", "Left");
			EndSilenceTimeoutAmbiguousSetChange("Text", InfoEnter.PasswordSet);
			break;
		case "EndSilenceTimeoutSet":
			EndSilenceTimeoutSetChange("TextAlign", "Left");
			EndSilenceTimeoutSetChange("Text", InfoEnter.PasswordSet);
			break;
		case "BabbleTimeoutSet":
			BabbleTimeoutSetChange("TextAlign", "Left");
			BabbleTimeoutSetChange("Text", InfoEnter.PasswordSet);
			break;
		case "InitialSilenceTimeoutSet":
			InitialSilenceTimeoutSetChange("TextAlign", "Left");
			InitialSilenceTimeoutSetChange("Text", InfoEnter.PasswordSet);
			break;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		switch (ItemName)
		{
		case "MaxAltSet":
			if (Operators.CompareString(MaxAltSet.Text, "", TextCompare: false) != 0)
			{
				MaxAltSet.Text = Strings.LCase(MaxAltSet.Text);
				Interaction.SaveSetting("Dtread", "Recog", "MaxAltSet", MaxAltSet.Text);
			}
			MaxAltSetChange("TextAlign", "Left");
			break;
		case "EndSilenceTimeoutAmbiguousSet":
			if (Operators.CompareString(EndSilenceTimeoutAmbiguousSet.Text, "", TextCompare: false) != 0)
			{
				EndSilenceTimeoutAmbiguousSet.Text = Strings.LCase(EndSilenceTimeoutAmbiguousSet.Text);
				Interaction.SaveSetting("Dtread", "Recog", "EndSilenceTimeoutAmbiguousSet", EndSilenceTimeoutAmbiguousSet.Text);
			}
			EndSilenceTimeoutAmbiguousSetChange("TextAlign", "Left");
			break;
		case "EndSilenceTimeoutSet":
			if (Operators.CompareString(EndSilenceTimeoutSet.Text, "", TextCompare: false) != 0)
			{
				EndSilenceTimeoutSet.Text = Strings.LCase(EndSilenceTimeoutSet.Text);
				Interaction.SaveSetting("Dtread", "Recog", "EndSilenceTimeoutSet", EndSilenceTimeoutSet.Text);
			}
			EndSilenceTimeoutSetChange("TextAlign", "Left");
			break;
		case "BabbleTimeoutSet":
			if (Operators.CompareString(BabbleTimeoutSet.Text, "", TextCompare: false) != 0)
			{
				BabbleTimeoutSet.Text = Strings.LCase(BabbleTimeoutSet.Text);
				Interaction.SaveSetting("Dtread", "Recog", "BabbleTimeoutSet", BabbleTimeoutSet.Text);
			}
			BabbleTimeoutSetChange("TextAlign", "Left");
			break;
		case "InitialSilenceTimeoutSet":
			if (Operators.CompareString(InitialSilenceTimeoutSet.Text, "", TextCompare: false) != 0)
			{
				InitialSilenceTimeoutSet.Text = Strings.LCase(InitialSilenceTimeoutSet.Text);
				Interaction.SaveSetting("Dtread", "Recog", "InitialSilenceTimeoutSet", InitialSilenceTimeoutSet.Text);
			}
			InitialSilenceTimeoutSetChange("TextAlign", "Left");
			break;
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		ControlLevel = 0;
		Setup();
	}

	private void MainDisplayChange(string Setting, string Data)
	{
		if (MainDisplay.InvokeRequired)
		{
			SetControl1Callback method = MainDisplayChange;
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			MainDisplay.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				MainDisplay.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				MainDisplay.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void MaxAltSetChange(string Setting, string Data)
	{
		if (MaxAltSet.InvokeRequired)
		{
			SetControl1Callback method = MaxAltSetChange;
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			MaxAltSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				MaxAltSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				MaxAltSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void EndSilenceTimeoutAmbiguousSetChange(string Setting, string Data)
	{
		if (EndSilenceTimeoutAmbiguousSet.InvokeRequired)
		{
			SetControl1Callback method = EndSilenceTimeoutAmbiguousSetChange;
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			EndSilenceTimeoutAmbiguousSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				EndSilenceTimeoutAmbiguousSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				EndSilenceTimeoutAmbiguousSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void EndSilenceTimeoutSetChange(string Setting, string Data)
	{
		if (EndSilenceTimeoutSet.InvokeRequired)
		{
			SetControl1Callback method = EndSilenceTimeoutSetChange;
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			EndSilenceTimeoutSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				EndSilenceTimeoutSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				EndSilenceTimeoutSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void BabbleTimeoutSetChange(string Setting, string Data)
	{
		if (BabbleTimeoutSet.InvokeRequired)
		{
			SetControl1Callback method = BabbleTimeoutSetChange;
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			BabbleTimeoutSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				BabbleTimeoutSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				BabbleTimeoutSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void InitialSilenceTimeoutSetChange(string Setting, string Data)
	{
		if (InitialSilenceTimeoutSet.InvokeRequired)
		{
			SetControl1Callback method = InitialSilenceTimeoutSetChange;
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			InitialSilenceTimeoutSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				InitialSilenceTimeoutSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				InitialSilenceTimeoutSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void Setup()
	{
		MaxAltSetChange("Text", Conversions.ToString(Conversion.Val(Interaction.GetSetting("Dtread", "Recog", "MaxAltSet", "0"))));
		EndSilenceTimeoutAmbiguousSetChange("Text", Conversions.ToString(Conversion.Val(Interaction.GetSetting("Dtread", "Recog", "EndSilenceTimeoutAmbiguousSet", "0"))));
		EndSilenceTimeoutSetChange("Text", Conversions.ToString(Conversion.Val(Interaction.GetSetting("Dtread", "Recog", "EndSilenceTimeoutSet", "0"))));
		BabbleTimeoutSetChange("Text", Conversions.ToString(Conversion.Val(Interaction.GetSetting("Dtread", "Recog", "BabbleTimeoutSet", "0"))));
		InitialSilenceTimeoutSetChange("Text", Conversions.ToString(Conversion.Val(Interaction.GetSetting("Dtread", "Recog", "InitialSilenceTimeoutSet", "0"))));
	}

	private void SetupCheck()
	{
		try
		{
			recognizer.MaxAlternates = checked((int)Math.Round(Conversion.Val(MaxAltSet.Text)));
			recognizer.EndSilenceTimeoutAmbiguous = TimeSpan.FromSeconds(Conversion.Val(EndSilenceTimeoutAmbiguousSet.Text));
			recognizer.EndSilenceTimeout = TimeSpan.FromSeconds(Conversion.Val(EndSilenceTimeoutSet.Text));
			recognizer.BabbleTimeout = TimeSpan.FromSeconds(Conversion.Val(BabbleTimeoutSet.Text));
			recognizer.InitialSilenceTimeout = TimeSpan.FromSeconds(Conversion.Val(InitialSilenceTimeoutSet.Text));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ZeroTrackLevel_Click(object sender, EventArgs e)
	{
		SetAudioDeviceOn();
		Display.NewSpeech = false;
		MyProject.Forms.Display.UpdateVoiceImage();
		MaxLevel.Text = "0";
		MyProject.Forms.Display.MaxLevel.Text = "0";
	}

	private void WordListBuild()
	{
		Addwordlist += "deactivate voice, cancell, ";
		Addwordlist += "start program, hold program, pause program, continue program, end program, reset emergency Stop, close program, ";
		Addwordlist += "chamber depth up, chamber depth down, ";
		Addwordlist += "jet operate, jetoperate, jet stop, jetstop,  stop jet, stopjet, clean control On, clean control off, ";
		Addwordlist += "set Estop, set eng, show relay 88, show relay 816, show voice, show level, exit level, level control up, level control down, show io pot, show usb iss, ";
		Addwordlist += "pump operate, pumpoperate, pumpon, pumpoff, pump on, pump off, fill chamber, chamber off, empty chamber, chamber pump on, chamber pump off, ";
		Addwordlist += "select speed down, select speed up, select speed manual, speed control up, speed control down, set max speed, ";
		Addwordlist += "conveyor reverse, reverse conveyor, conveyor forward, ";
		Addwordlist += "select incline down, select incline up, select incline manual, incline control up, incline control down, incline control max, set incline zero, ";
		SetLanguage();
		WordListA = Strings.Split(Addwordlist, ", ");
		AddList = VoiceName + " " + WordListA[0] + ", " + WordListA[0];
		checked
		{
			int num = Microsoft.VisualBasic.Information.UBound(WordListA) - 1;
			for (int i = 1; i <= num; i++)
			{
				AddList = AddList + ", " + VoiceName + " " + WordListA[i] + ", " + WordListA[i];
			}
			AddList = AddList + ", " + VoiceName + ",  emergency empty";
			WordList = Strings.Split(AddList, ", ");
		}
	}

	private void SetLanguage()
	{
		Addwordlist += "set speed zero , speed zero , ";
		Addwordlist += "set incline zero, incline zero, ";
		float num = 0f;
		do
		{
			ref string addwordlist = ref Addwordlist;
			ref string reference = ref addwordlist;
			addwordlist = reference + "set speed " + num + ", set speed " + num + ".5, ";
			ref string addwordlist2 = ref Addwordlist;
			reference = ref addwordlist2;
			addwordlist2 = reference + "set incline " + num + ", set incline " + num + ".5, ";
			num += 1f;
		}
		while (num <= 20f);
		Addwordlist += "chamber depth zero, ";
		Addwordlist += "chamber level zero , ";
		num = 0f;
		do
		{
			ref string addwordlist3 = ref Addwordlist;
			addwordlist3 = addwordlist3 + "chamber depth " + num + ", ";
			ref string addwordlist4 = ref Addwordlist;
			addwordlist4 = addwordlist4 + "chamber level " + num + ", ";
			num += 1f;
		}
		while (num <= 100f);
	}

	private void Command(object Voice)
	{
		VoiceCommand = "";
		checked
		{
			if (Operators.ConditionalCompareObjectEqual(Voice, Strings.Mid(Conversions.ToString(Voice), 1, Strings.Len(VoiceName)) + " emergency empty", TextCompare: false))
			{
				SystemVoice("emergency empty");
				Display.EmergencyEmpty = true;
			}
			else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Voice, Strings.Mid(Conversions.ToString(Voice), 1, Strings.Len(VoiceName)) + " set Estop", TextCompare: false), Display.EngPass)))
			{
				MyProject.Forms.Display.TestEStopOnOff();
				SystemVoice("Done");
			}
			else if (Operators.ConditionalCompareObjectEqual(Voice, Strings.Mid(Conversions.ToString(Voice), 1, Strings.Len(VoiceName)) + " set eng", TextCompare: false))
			{
				MyProject.Forms.Display.EngineerPass(Pass: false);
				SystemVoice("Done");
			}
			else if ((Operators.CompareString(Strings.Mid(Conversions.ToString(Voice), 1, Strings.Len(VoiceName)), VoiceName, TextCompare: false) == 0) & (Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) > Strings.Len(VoiceName)))
			{
				Voice = Strings.Mid(Conversions.ToString(Voice), Strings.Len(VoiceName) + 2, Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) - Strings.Len(VoiceName));
				VoiceOnOff = true;
			}
			if (Operators.ConditionalCompareObjectEqual(Voice, VoiceName, TextCompare: false))
			{
				if (Display.ProgramRun)
				{
					SystemVoice("yes");
				}
				else
				{
					SystemVoice("Hello");
				}
				VoiceOnOff = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(Voice, "emergency empty", TextCompare: false))
			{
				if (Display.ProgramRun)
				{
					SystemVoice("emergency empty");
					MyProject.Forms.Display.RLY88.RemoteEmergencyEmpty();
				}
				else
				{
					SystemVoice("program not running");
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(Voice, "cancell", TextCompare: false))
			{
				MyProject.Forms.Display.DoBox2Change(MyProject.Forms.Display.Cancell);
				SystemVoice("cancelled");
			}
			else if (Operators.ConditionalCompareObjectEqual(Voice, "deactivate voice", TextCompare: false))
			{
				SystemVoice("voice control off");
				VoiceOnOff = false;
			}
			else if ((Operators.CompareString(Strings.Mid(Conversions.ToString(Voice), 1, 7), "This Is", TextCompare: false) == 0) & (Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) > 8))
			{
				SystemVoice(RuntimeHelpers.GetObjectValue(Voice));
			}
			else if (VoiceOnOff)
			{
				if (Operators.ConditionalCompareObjectEqual(Voice, "reset emergency stop", TextCompare: false))
				{
					if (!Display.EmergencyStop)
					{
						SystemVoice("Resetting Emergency Stop");
						MyProject.Forms.Display.DoBoxChange("RemoteProgramStart");
					}
					else
					{
						SystemVoice("Emergency Stop Active");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "speed control up", TextCompare: false))
				{
					if (Display.ProgramRun & !Display.ProgramHold)
					{
						if (MyProject.Forms.Display.SpeedProgramSet == 0)
						{
							MyProject.Forms.Display.DoBoxChange("SpeedProgramUp_Control");
							SystemVoice("Speed " + IOPOT.SpeedDisplay + " kilometers per hour");
						}
						else
						{
							MyProject.Forms.Display.DoBoxChange("RemoteSpeedUp");
							SystemVoice("Speed Max " + MyProject.Forms.Display.MaxSpeedIndkm.Text.ToString() + " kilometers per hour");
						}
					}
					else if (Display.ProgramHold)
					{
						SystemVoice("Program paused");
					}
					else
					{
						SystemVoice("Program not running");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "speed control down", TextCompare: false))
				{
					if (Display.ProgramRun & !Display.ProgramHold)
					{
						if (MyProject.Forms.Display.SpeedProgramSet == 0)
						{
							MyProject.Forms.Display.DoBoxChange("SpeedProgramDN_Control");
							SystemVoice("Speed " + IOPOT.SpeedDisplay + " kilometers per hour");
						}
						else
						{
							MyProject.Forms.Display.DoBoxChange("RemoteSpeedDown");
							SystemVoice("Speed Max " + MyProject.Forms.Display.MaxSpeedIndkm.Text.ToString() + " kilometers per hour");
						}
					}
					else if (Display.ProgramHold)
					{
						SystemVoice("Program paused");
					}
					else
					{
						SystemVoice("Program not running");
					}
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Voice, "set speed zero", TextCompare: false), Operators.CompareObjectEqual(Voice, "speed zero", TextCompare: false))))
				{
					MyProject.Forms.Display.DoBox2Change("RSSG0");
					SystemVoice("Speed zero kilometers per hour");
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Voice, "set max speed", TextCompare: false), Operators.CompareObjectEqual(Voice, "speed max", TextCompare: false))))
				{
					double num = Conversion.Val(Interaction.GetSetting("Dtread", "Aqua", "Maxkph", "10.0"));
					MyProject.Forms.Display.DoBox2Change("RSSG" + Conversion.Val(num) * 10.0);
					SystemVoice("Speed Max " + num + " kilometers per hour");
				}
				else if ((Operators.CompareString(Strings.Mid(Conversions.ToString(Voice), 1, 9), "set speed", TextCompare: false) == 0) & (Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) > 10))
				{
					double num2 = Conversion.Val(Interaction.GetSetting("Dtread", "Aqua", "Maxkph", "10.0"));
					double num3 = Conversion.Val(Strings.Mid(Conversions.ToString(Voice), 10, Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) - 9));
					string text = Strings.Mid(Conversions.ToString(Voice), 11, Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) - 9);
					if (num3 == 0.0)
					{
						if (Operators.CompareString(text, "zero", TextCompare: false) == 0)
						{
							num3 = 0.0;
						}
						if (Operators.CompareString(text, "one", TextCompare: false) == 0)
						{
							num3 = 1.0;
						}
						if (Operators.CompareString(text, "two", TextCompare: false) == 0)
						{
							num3 = 2.0;
						}
						if (Operators.CompareString(text, "three", TextCompare: false) == 0)
						{
							num3 = 3.0;
						}
						if (Operators.CompareString(text, "four", TextCompare: false) == 0)
						{
							num3 = 4.0;
						}
						if (Operators.CompareString(text, "five", TextCompare: false) == 0)
						{
							num3 = 5.0;
						}
						if (Operators.CompareString(text, "six", TextCompare: false) == 0)
						{
							num3 = 6.0;
						}
						if (Operators.CompareString(text, "seven", TextCompare: false) == 0)
						{
							num3 = 7.0;
						}
						if (Operators.CompareString(text, "eight", TextCompare: false) == 0)
						{
							num3 = 8.0;
						}
						if (Operators.CompareString(text, "nine", TextCompare: false) == 0)
						{
							num3 = 9.0;
						}
					}
					if (num2 >= Conversion.Val(num3))
					{
						MyProject.Forms.Display.DoBox2Change("RSSG" + Conversion.Val(num3) * 10.0);
						SystemVoice("Speed " + text + " kilometer per hour");
					}
					else
					{
						MyProject.Forms.Display.DoBox2Change("RSSG" + 0);
						SystemVoice("Speed " + 0 + " kilometers per hour");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "incline control up", TextCompare: false))
				{
					if (Display.ProgramRun & !Display.ProgramHold)
					{
						if (MyProject.Forms.Display.GradientProgramSet == 0)
						{
							MyProject.Forms.Display.DoBoxChange("GradientProgramUp_Control");
							if (Conversion.Val(MyProject.Forms.Display.InclineDeg.Text) == Conversion.Val(MyProject.Forms.Display.GSLLabel.Text))
							{
								SystemVoice("max " + MyProject.Forms.Display.InclineActual.Text + " Degrees");
							}
							else
							{
								SystemVoice(Conversion.Val(Display.Display_Incline) / 10.0 + " Degrees");
							}
						}
						else
						{
							MyProject.Forms.Display.DoBoxChange("RemoteGradientUp");
							SystemVoice("Max " + MyProject.Forms.Display.InclineDeg.Text + " Degrees");
						}
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "incline control down", TextCompare: false))
				{
					if (Display.ProgramRun & !Display.ProgramHold)
					{
						if (MyProject.Forms.Display.GradientProgramSet == 0)
						{
							MyProject.Forms.Display.DoBoxChange("GradientProgramDN_Control");
							SystemVoice(Conversion.Val(Display.Display_Incline) / 10.0 + " Degrees");
						}
						else
						{
							MyProject.Forms.Display.DoBoxChange("RemoteGradientDown");
							SystemVoice("Max " + MyProject.Forms.Display.InclineDeg.Text + " Degrees");
						}
					}
					else
					{
						SystemVoice("program Not running");
					}
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Voice, "incline 0", TextCompare: false), Operators.CompareObjectEqual(Voice, "incline zero", TextCompare: false)), Operators.CompareObjectEqual(Voice, "set incline 0", TextCompare: false)), Operators.CompareObjectEqual(Voice, "set incline zero", TextCompare: false))))
				{
					if (MyProject.Forms.Display.GradientProgramSet == 0)
					{
						double num4 = Conversion.Val(MyProject.Forms.Display.InclineDeg.Text);
						if ((Display.ProgramRun & !Display.ProgramHold) | !Display.ProgramRun)
						{
							MyProject.Forms.Display.DoBox2Change("RGSG0");
							SystemVoice("0 Degrees");
						}
					}
					else
					{
						if ((Display.ProgramRun & !Display.ProgramHold) | !Display.ProgramRun)
						{
							MyProject.Forms.Display.MaxGradientSet = 2f;
						}
						MyProject.Forms.Display.DoBoxChange("RemoteGradientDown");
						SystemVoice("Max " + MyProject.Forms.Display.InclineDeg.Text + " Degrees");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "incline control max", TextCompare: false))
				{
					if (MyProject.Forms.Display.GradientProgramSet == 0)
					{
						double num5 = Conversion.Val(MyProject.Forms.Display.InclineDeg.Text);
						if (!Display.ProgramHold)
						{
							MyProject.Forms.Display.DoBox2Change("RGSG" + Conversion.Val(num5) * 10.0);
							SystemVoice(Conversion.Val(num5) + " Degrees");
						}
						else
						{
							SystemVoice("program paused");
						}
					}
					else if (!Display.ProgramHold)
					{
						MyProject.Forms.Display.MaxGradientSet = 15f;
						MyProject.Forms.Display.DoBoxChange("RemoteGradientUp");
						SystemVoice("Max " + MyProject.Forms.Display.InclineDeg.Text + " Degrees");
					}
					else
					{
						SystemVoice("program paused");
					}
				}
				else if (Operators.CompareString(Strings.Mid(Conversions.ToString(Voice), 1, 11), "set incline", TextCompare: false) == 0)
				{
					if ((Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) > 12) & (MyProject.Forms.Display.GradientProgramSet == 0))
					{
						double num6 = Conversion.Val(MyProject.Forms.Display.InclineDeg.Text);
						double num7 = Conversion.Val(Strings.Mid(Conversions.ToString(Voice), 13, Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) - 12));
						string left = Strings.Mid(Conversions.ToString(Voice), 13, Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) - 12);
						if (num7 == 0.0)
						{
							if (Operators.CompareString(left, "zero", TextCompare: false) == 0)
							{
								num7 = 0.0;
							}
							if (Operators.CompareString(left, "one", TextCompare: false) == 0)
							{
								num7 = 1.0;
							}
							if (Operators.CompareString(left, "two", TextCompare: false) == 0)
							{
								num7 = 2.0;
							}
							if (Operators.CompareString(left, "three", TextCompare: false) == 0)
							{
								num7 = 3.0;
							}
							if (Operators.CompareString(left, "four", TextCompare: false) == 0)
							{
								num7 = 4.0;
							}
							if (Operators.CompareString(left, "five", TextCompare: false) == 0)
							{
								num7 = 5.0;
							}
							if (Operators.CompareString(left, "six", TextCompare: false) == 0)
							{
								num7 = 6.0;
							}
							if (Operators.CompareString(left, "seven", TextCompare: false) == 0)
							{
								num7 = 7.0;
							}
							if (Operators.CompareString(left, "eight", TextCompare: false) == 0)
							{
								num7 = 8.0;
							}
							if (Operators.CompareString(left, "nine", TextCompare: false) == 0)
							{
								num7 = 9.0;
							}
						}
						if (num6 >= num7)
						{
							MyProject.Forms.Display.DoBox2Change("RGSG" + num7 * 10.0);
							SystemVoice("Incline " + num7 + " degrees");
						}
						else
						{
							MyProject.Forms.Display.RemoteGradientSelectG8(0);
							SystemVoice("incline " + 0 + " degrees");
						}
					}
					else if (MyProject.Forms.Display.GradientProgramSet != 0)
					{
						SystemVoice("Not available");
					}
					else
					{
						SystemVoice("no degrees given");
					}
				}
				else if ((Operators.CompareString(Strings.Mid(Conversions.ToString(Voice), 1, 13), "chamber depth", TextCompare: false) == 0) | (Operators.CompareString(Strings.Mid(Conversions.ToString(Voice), 1, 13), "chamber level", TextCompare: false) == 0))
				{
					if (Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) > 14)
					{
						string text2 = Strings.Mid(Conversions.ToString(Voice), 15, Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) - 5);
						if (Operators.CompareString(text2, "up", TextCompare: false) == 0)
						{
							text2 = Conversions.ToString(Conversion.Val(MyProject.Forms.Display.WaterDepthInd.Text) + 1.0);
						}
						if (Operators.CompareString(text2, "down", TextCompare: false) == 0)
						{
							text2 = Conversions.ToString(Conversion.Val(MyProject.Forms.Display.WaterDepthInd.Text) - 1.0);
						}
						if (Operators.CompareString(text2, "zero", TextCompare: false) == 0)
						{
							text2 = "0";
						}
						if (Operators.CompareString(text2, "one", TextCompare: false) == 0)
						{
							text2 = "1";
						}
						if (Operators.CompareString(text2, "five", TextCompare: false) == 0)
						{
							text2 = "5";
						}
						if (Operators.CompareString(text2, "six", TextCompare: false) == 0)
						{
							text2 = "6";
						}
						Interaction.SaveSetting("Health", "Person", "WaterDepthInd", text2);
						MyProject.Forms.Display.ControlAChange("WaterDepth", "WaterDepthInd", "Text", text2);
						MyProject.Forms.Display.DoBoxChange("RemoteWaterDepthSetting");
						SystemVoice("depth " + MyProject.Forms.Display.WaterDepthInd.Text.ToString());
					}
					else
					{
						SystemVoice("no depth given");
					}
				}
				else if (Operators.CompareString(Strings.Mid(Conversions.ToString(Voice), 1, 8), "duration", TextCompare: false) == 0)
				{
					if (Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) > 9)
					{
						string text3 = Strings.Mid(Conversions.ToString(Voice), 10, Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) - 9);
						if (Operators.CompareString(text3, "five", TextCompare: false) == 0)
						{
							text3 = "5";
						}
						MyProject.Forms.Display.DurationTimeSet(text3);
						if (Conversions.ToDouble(Display.HoldDurationTimeSec) == 0.0)
						{
							SystemVoice("Duration " + Display.HoldDurationTimeMin.ToString() + " Minutes");
						}
						else
						{
							SystemVoice("Duration " + Display.HoldDurationTimeMin.ToString() + " Minutes And " + Display.HoldDurationTimeSec.ToString() + " seconds");
						}
					}
					else
					{
						SystemVoice("no time given");
					}
				}
				else if (Operators.CompareString(Strings.Mid(Conversions.ToString(Voice), 1, 12), "set delay on", TextCompare: false) == 0)
				{
					if (Operators.ConditionalCompareObjectEqual(Voice, "Set delay On zero", TextCompare: false))
					{
						MyProject.Forms.Display.StartTimerSet("0");
						SystemVoice(RuntimeHelpers.GetObjectValue(Voice));
					}
					else
					{
						string text4 = Strings.Mid(Conversions.ToString(Voice), 14, Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) - 5);
						if (Operators.CompareString(text4, "five", TextCompare: false) == 0)
						{
							text4 = "5";
						}
						MyProject.Forms.Display.StartTimerSet(text4);
						SystemVoice(RuntimeHelpers.GetObjectValue(Voice));
					}
				}
				else if (Operators.CompareString(Strings.Mid(Conversions.ToString(Voice), 1, 13), "set delay off", TextCompare: false) == 0)
				{
					if (Operators.ConditionalCompareObjectEqual(Voice, "set delay off zero", TextCompare: false))
					{
						MyProject.Forms.Display.StopTimerSet(Conversions.ToInteger("0"));
						SystemVoice(RuntimeHelpers.GetObjectValue(Voice));
					}
					else if (Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) > 14)
					{
						string text5 = Strings.Mid(Conversions.ToString(Voice), 15, Strings.Len(RuntimeHelpers.GetObjectValue(Voice)) - 5);
						if (Operators.CompareString(text5, "five", TextCompare: false) == 0)
						{
							text5 = "5";
						}
						MyProject.Forms.Display.StopTimerSet(Conversions.ToInteger(text5));
						SystemVoice(RuntimeHelpers.GetObjectValue(Voice));
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "delay timer On", TextCompare: false))
				{
					if ((!Display.TimerStartStopDelay & Display.EmergencyStop & (Conversion.Val(MyProject.Forms.Display.ShortTimerStart.Text) > 0.0)) | (!Display.TimerStartStopDelay & Display.EmergencyStop & (Conversion.Val(MyProject.Forms.Display.ShortTimerStop.Text) > 0.0)))
					{
						MyProject.Forms.Display.DelayTimerControl();
						SystemVoice("timer start");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency Stop active");
					}
					else if ((Conversion.Val(MyProject.Forms.Display.ShortTimerStart.Text) == 0.0) & (Conversion.Val(MyProject.Forms.Display.ShortTimerStop.Text) == 0.0))
					{
						SystemVoice("delay timer's at zero");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "delay timer off", TextCompare: false))
				{
					MyProject.Forms.Display.DelayTimerControl();
					SystemVoice("timer stop");
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "delay timer cycle", TextCompare: false))
				{
					MyProject.Forms.Display.CycleShortTimer();
					SystemVoice("timer cycle");
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "show level", TextCompare: false))
				{
					if (Display.EngPass)
					{
						MyProject.Forms.Display.ShowBoards("LEVEL");
						SystemVoice("Active");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "exit level", TextCompare: false))
				{
					if (Display.EngPass)
					{
						MyProject.Forms.Display.ShowBoards("LEVELX");
						SystemVoice("Done");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "level up", TextCompare: false))
				{
					if (Display.EngPass)
					{
						MyProject.Forms.Display.ShowBoards("LEVELUP");
						SystemVoice("level up");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "level down", TextCompare: false))
				{
					if (Display.EngPass)
					{
						MyProject.Forms.Display.ShowBoards("LEVELDOWN");
						SystemVoice("level down");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "show relay 88", TextCompare: false))
				{
					if (Display.EngPass)
					{
						MyProject.Forms.Display.ShowBoards("RLY88");
						SystemVoice("Done");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "show relay 816", TextCompare: false))
				{
					if (Display.EngPass)
					{
						MyProject.Forms.Display.ShowBoards("RLY816");
						SystemVoice("Done");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "show io pot", TextCompare: false))
				{
					if (Display.EngPass)
					{
						MyProject.Forms.Display.ShowBoards("IOPOT");
						SystemVoice("Done");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "show usb iss", TextCompare: false))
				{
					if (Display.EngPass)
					{
						MyProject.Forms.Display.ShowBoards("USBISS");
						SystemVoice("Done");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "show voice", TextCompare: false))
				{
					MyProject.Forms.Display.ShowBoards("VOICE");
					SystemVoice("Done");
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "start program", TextCompare: false))
				{
					if (!Display.ProgramRun & Display.EmergencyStop)
					{
						SystemVoice("starting program");
						MyProject.Forms.Display.DoBoxChange("RemoteProgramStart");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency stop active");
					}
					else
					{
						SystemVoice("program running");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "continue program", TextCompare: false))
				{
					if (Display.ProgramRun & Display.ProgramHold & Display.EmergencyStop)
					{
						SystemVoice("continuing program");
						MyProject.Forms.Display.DoBoxChange("RemoteProgramStart");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency stop active");
					}
					else if (Display.ProgramRun & Display.ProgramHold)
					{
						SystemVoice("program running");
					}
					else
					{
						SystemVoice("program not nunning");
					}
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Voice, "hold program", TextCompare: false), Operators.CompareObjectEqual(Voice, "pause program", TextCompare: false))))
				{
					if (Display.ProgramRun & !Display.ProgramHold)
					{
						MyProject.Forms.Display.DoBoxChange("RemoteProgramStart");
						SystemVoice("Program Paused");
					}
					else
					{
						SystemVoice("program not running");
					}
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Voice, "close program", TextCompare: false), Operators.CompareObjectEqual(Voice, "end program", TextCompare: false))))
				{
					if (Display.ProgramRun & Display.ProgramHold)
					{
						MyProject.Forms.Display.DoBox2Change("RemoteProgramEdit0");
						SystemVoice("Closing Program");
					}
					else if (!Display.ProgramRun)
					{
						SystemVoice("program not running");
					}
					else
					{
						SystemVoice("program pause required");
					}
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Voice, "conveyor reverse", TextCompare: false), Operators.CompareObjectEqual(Voice, "reverse conveyor", TextCompare: false))))
				{
					if (!Display.ProgramRun & (MyProject.Forms.Display.SpeedProgramSet == 0))
					{
						if (!Display.SpeedProgramReverse)
						{
							MyProject.Forms.Display.ConveyorDirection();
						}
						SystemVoice("Conveyor Reverse");
					}
					else
					{
						SystemVoice("not available");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "conveyor forward", TextCompare: false))
				{
					if (!Display.ProgramRun & (MyProject.Forms.Display.SpeedProgramSet == 0))
					{
						if (Display.SpeedProgramReverse)
						{
							MyProject.Forms.Display.ConveyorDirection();
						}
						SystemVoice("Conveyor Forward");
					}
					else
					{
						SystemVoice("Conveyor Forward");
					}
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Voice, "pump on", TextCompare: false), Operators.CompareObjectEqual(Voice, "pumpon", TextCompare: false)), Operators.CompareObjectEqual(Voice, "pump operate", TextCompare: false)), Operators.CompareObjectEqual(Voice, "pumpoperate", TextCompare: false)), Operators.CompareObjectEqual(Voice, "fill chamber", TextCompare: false)), Operators.CompareObjectEqual(Voice, "chamber pump on", TextCompare: false))))
				{
					if (!Display.WDOnOff & Display.EmergencyStop)
					{
						MyProject.Forms.Display.DoBoxChange("WaterDepthSw");
						SystemVoice("pump on");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency stop reset required");
					}
					else
					{
						SystemVoice("pump is on");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "empty chamber", TextCompare: false))
				{
					if (!Display.WDOnOff & Display.EmergencyStop & (Conversions.ToDouble(Interaction.GetSetting("Health", "Person", "WaterDepthMeasure", Conversions.ToString(0))) > 0.0))
					{
						string text6 = "0";
						Interaction.SaveSetting("Health", "Person", "WaterDepthInd", text6);
						MyProject.Forms.Display.ControlAChange("WaterDepth", "WaterDepthInd", "Text", text6);
						MyProject.Forms.Display.DoBoxChange("RemoteWaterDepthSetting");
						MyProject.Forms.Display.DoBoxChange("WaterDepthSw");
						SystemVoice("emptying");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency stop reset required");
					}
					else if (USBOPTORLY816.FillPump & (Conversions.ToDouble(Interaction.GetSetting("Health", "Person", "WaterDepthMeasure", Conversions.ToString(0))) > 0.0))
					{
						string text7 = "0";
						Interaction.SaveSetting("Health", "Person", "WaterDepthInd", text7);
						MyProject.Forms.Display.ControlAChange("WaterDepth", "WaterDepthInd", "Text", text7);
						MyProject.Forms.Display.DoBoxChange("RemoteWaterDepthSetting");
						SystemVoice("emptying");
					}
					else if (Conversions.ToDouble(Interaction.GetSetting("Health", "Person", "WaterDepthMeasure", Conversions.ToString(0))) <= 0.0)
					{
						SystemVoice("Depth zero");
					}
					else
					{
						SystemVoice("pump is on");
					}
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Voice, "chamber off", TextCompare: false), Operators.CompareObjectEqual(Voice, "chamber pump off", TextCompare: false))))
				{
					if (Display.WDOnOff)
					{
						MyProject.Forms.Display.DoBoxChange("WaterDepthSw");
						SystemVoice("pump off");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency stop reset required");
					}
					else
					{
						SystemVoice("pump is off");
					}
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Voice, "jet operate", TextCompare: false), Operators.CompareObjectEqual(Voice, "jetoperate", TextCompare: false))))
				{
					if (!Display.JetOn)
					{
						MyProject.Forms.Display.DoBoxChange("RemoteJetOnOff");
						SystemVoice("jet on");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency stop reset required");
					}
					else
					{
						SystemVoice("jet is off");
					}
				}
				else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Voice, "stop jet", TextCompare: false), Operators.CompareObjectEqual(Voice, "stopjet", TextCompare: false))))
				{
					if (Display.JetOn)
					{
						MyProject.Forms.Display.DoBoxChange("RemoteJetOnOff");
						SystemVoice("jet off");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency stop reset required");
					}
					else
					{
						SystemVoice("jet is off");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "clean control on", TextCompare: false))
				{
					if (!Display.CleanOn)
					{
						MyProject.Forms.Display.DoBoxChange("CleanOnOffRemote");
						SystemVoice("cleaning on");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency stop reset required");
					}
					else
					{
						SystemVoice("running");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "clean control off", TextCompare: false))
				{
					if (Display.CleanOn)
					{
						MyProject.Forms.Display.DoBoxChange("CleanOnOffRemote");
						SystemVoice("clean off");
					}
					else if (!Display.EmergencyStop)
					{
						SystemVoice("emergency stop active");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "select speed down", TextCompare: false))
				{
					if (!Display.ProgramRun)
					{
						MyProject.Forms.Display.DoBoxChange("SpeedProgramDN_Control");
						if (MyProject.Forms.Display.SpeedProgramSet == 0)
						{
							SystemVoice("Manual Speed Selected");
						}
						else
						{
							SystemVoice("Speed Program " + Conversions.ToString(MyProject.Forms.Display.SpeedProgramSet));
						}
					}
					else
					{
						SystemVoice("program running");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "select speed up", TextCompare: false))
				{
					if (!Display.ProgramRun)
					{
						MyProject.Forms.Display.DoBoxChange("SpeedProgramUp_Control");
						if (MyProject.Forms.Display.SpeedProgramSet == 0)
						{
							SystemVoice("Manual Speed Selected");
						}
						else
						{
							SystemVoice("Speed Program " + Conversions.ToString(MyProject.Forms.Display.SpeedProgramSet));
						}
					}
					else
					{
						SystemVoice("program running");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "select speed manual", TextCompare: false))
				{
					if (!Display.ProgramRun)
					{
						MyProject.Forms.Display.DoBoxChange("SpeedProgramManual");
						SystemVoice("Manual Speed Selected");
					}
					else
					{
						SystemVoice("program running");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "select incline down", TextCompare: false))
				{
					if (!Display.ProgramRun)
					{
						MyProject.Forms.Display.DoBoxChange("GradientProgramDN_Control");
						if (MyProject.Forms.Display.SpeedProgramSet == 0)
						{
							SystemVoice("Manual Incline Selected");
						}
						else
						{
							SystemVoice("Incline Program " + Conversions.ToString(MyProject.Forms.Display.GradientProgramSet));
						}
					}
					else
					{
						SystemVoice("program running");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "select incline up", TextCompare: false))
				{
					if (!Display.ProgramRun)
					{
						MyProject.Forms.Display.DoBoxChange("GradientProgramUp_Control");
						if (MyProject.Forms.Display.SpeedProgramSet == 0)
						{
							SystemVoice("Manual Incline Selected");
						}
						else
						{
							SystemVoice("Incline Program " + Conversions.ToString(MyProject.Forms.Display.GradientProgramSet));
						}
					}
					else
					{
						SystemVoice("program running");
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(Voice, "select incline manual", TextCompare: false))
				{
					if (!Display.ProgramRun)
					{
						MyProject.Forms.Display.DoBoxChange("GradientProgramManual");
						SystemVoice("Manual Incline Selected");
					}
					else
					{
						SystemVoice("program running");
					}
				}
				else if (!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Voice, VoiceName + " voice on", TextCompare: false), Operators.CompareObjectEqual(Voice, VoiceName + " voiceon", TextCompare: false)), Operators.CompareObjectEqual(Voice, VoiceName + " voice operate", TextCompare: false)), Operators.CompareObjectEqual(Voice, VoiceName + " voice activate", TextCompare: false)), Operators.CompareObjectEqual(Voice, VoiceName + " set eng", TextCompare: false)), Operators.CompareObjectEqual(Voice, VoiceName + " set Estop", TextCompare: false))))
				{
					if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Voice, "Failed", TextCompare: false), Operators.CompareObjectEqual(Voice, "Event", TextCompare: false)), Operators.CompareObjectEqual(Voice, "Unknown", TextCompare: false))))
					{
						SystemVoice(RuntimeHelpers.GetObjectValue(Voice));
					}
					else
					{
						SystemVoice("sorry??;;");
					}
				}
			}
			else if (!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Voice, VoiceName + " voice on", TextCompare: false), Operators.CompareObjectEqual(Voice, VoiceName + " voiceon", TextCompare: false)), Operators.CompareObjectEqual(Voice, VoiceName + " voice operate", TextCompare: false)), Operators.CompareObjectEqual(Voice, VoiceName + " voice activate", TextCompare: false)), Operators.CompareObjectEqual(Voice, VoiceName + " set eng", TextCompare: false)), Operators.CompareObjectEqual(Voice, VoiceName + " set Estop", TextCompare: false))))
			{
				SystemVoice("control is off");
			}
			Voice = "";
		}
	}

	public void SystemVoice(object SpeechText)
	{
		ControlVoiceOffTM.Dispose();
		checked
		{
			if (Operators.ConditionalCompareObjectGreater(SpeechText, "", TextCompare: false))
			{
				if (Operators.CompareString(Strings.Mid(Conversions.ToString(SpeechText), 1, Strings.Len(VoiceName) + 1), VoiceName + " ", TextCompare: false) == 0)
				{
					SpeechText = Strings.Mid(Conversions.ToString(SpeechText), Strings.Len(VoiceName) + 1, Strings.Len(RuntimeHelpers.GetObjectValue(SpeechText)));
				}
				Interaction.SaveSetting("Dtread", "Aqua", "Sound", Conversions.ToString(SpeechText));
				MainDisplayChange("Text", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(SpeechText, ", "), MainDisplay.Text)));
				if (Strings.Len(MainDisplay.Text) > 250)
				{
					MainDisplay.Text = Strings.Mid(MainDisplay.Text, 1, Strings.Len(MainDisplay.Text) - 50);
				}
				EnableSpeakerTextTM(true);
			}
			ControlVoiceOffTM.Enabled = true;
		}
	}

	private void TimerEnable(bool enable)
	{
		MyProject.Forms.Speaker.SpeakerTextTM.Enabled = enable;
	}

	public void EnableSpeakerTextTM(object enable)
	{
		Invoke(new SetTimerEnable(TimerEnable), enable);
	}

	private void VoiceControlDeviceTM_Tick(object sender, EventArgs e)
	{
		if (VoiceControlDevice)
		{
			VoiceControlDeviceTM.Dispose();
			VoiceControlDevice = false;
		}
	}

	private void ExitPage_Click(object sender, EventArgs e)
	{
		CheckRestartHydro();
	}

	public void CheckRestartHydro()
	{
		if (RestartHydro)
		{
			RestartHydro = false;
			Display.RestartRequired = true;
		}
		Hide();
		MyProject.Forms.Display.VisibleCheck();
	}

	private void VoiceRecognizer_Closing(object sender, CancelEventArgs e)
	{
		CheckRestartHydro();
	}

	private void WelcomeTM_Tick(object sender, EventArgs e)
	{
		WelcomeTM.Dispose();
		if (!Welcome)
		{
			if (Operators.CompareString(MyProject.Forms.Display.TimeOfDayInd, "", TextCompare: false) == 0)
			{
				SystemVoice("Hello \", this is, " + VoiceName);
				return;
			}
			SystemVoice(MyProject.Forms.Display.TimeOfDayInd + ", this is, " + VoiceName);
			Welcome = true;
		}
	}

	private void TrackBar1_Scroll(object sender, EventArgs e)
	{
		LevelSet = TrackBar1.Value;
		Label6.Text = "Set Mic Level " + LevelSet;
		Interaction.SaveSetting("Dtread", "Aqua", "VoiceLevel", LevelSet.ToString());
	}

	private void ControlVoiceOffTM_Tick(object sender, EventArgs e)
	{
		ControlVoiceOffTM.Dispose();
		VoiceOnOff = false;
	}
}
