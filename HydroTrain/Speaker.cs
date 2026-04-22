using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Speech.Synthesis;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class Speaker : Form
{
	public delegate void SetTimerEnable(bool enable);

	public delegate void SetControl1Callback(string ControlName, bool Data);

	public delegate void SetDataCallback(string text);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VoiceOnTM")]
	private System.Windows.Forms.Timer _VoiceOnTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VoiceNameSet")]
	private TextBox _VoiceNameSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private System.Windows.Forms.Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ExitPage")]
	private Button _ExitPage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OptionMF2")]
	private RadioButton _OptionMF2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OptionMF1")]
	private RadioButton _OptionMF1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SpeachCompleteTM")]
	private System.Windows.Forms.Timer _SpeachCompleteTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SpeakerTextTM")]
	private System.Windows.Forms.Timer _SpeakerTextTM;

	public static bool VoiceHold;

	public static bool VoiceOnOff;

	private const long infinite = -1L;

	private byte SVSFlagsAsync;

	private string ItemName;

	private int ControlLevel;

	private bool RestartHydro;

	private string Talk;

	private string VoiceCommand;

	private Thread SpeakThread;

	private SpeechSynthesizer speaker;

	private object SAPI;

	private string VoiceName;

	private string[] ArrayOfNames;

	private string[] ArrayOfGender;

	private ReadOnlyCollection<InstalledVoice> voices;

	internal virtual System.Windows.Forms.Timer VoiceOnTM
	{
		[CompilerGenerated]
		get
		{
			return _VoiceOnTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = VoiceOnTM_Tick;
			System.Windows.Forms.Timer timer = _VoiceOnTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_VoiceOnTM = value;
			timer = _VoiceOnTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual ListBox ListBox1
	{
		[CompilerGenerated]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ListBox1_SelectedIndexChanged;
			ListBox listBox = _ListBox1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
			}
			_ListBox1 = value;
			listBox = _ListBox1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual TextBox VoiceNameSet
	{
		[CompilerGenerated]
		get
		{
			return _VoiceNameSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = VoiceNameSet_Click;
			TextBox textBox = _VoiceNameSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_VoiceNameSet = value;
			textBox = _VoiceNameSet;
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
			EventHandler value2 = InfoEnter_Tick;
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

	[field: AccessedThroughProperty("PersonSex")]
	internal virtual TextBox PersonSex
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual RadioButton OptionMF2
	{
		[CompilerGenerated]
		get
		{
			return _OptionMF2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OptionMF_Click;
			RadioButton radioButton = _OptionMF2;
			if (radioButton != null)
			{
				radioButton.Click -= value2;
			}
			_OptionMF2 = value;
			radioButton = _OptionMF2;
			if (radioButton != null)
			{
				radioButton.Click += value2;
			}
		}
	}

	internal virtual RadioButton OptionMF1
	{
		[CompilerGenerated]
		get
		{
			return _OptionMF1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OptionMF_Click;
			RadioButton radioButton = _OptionMF1;
			if (radioButton != null)
			{
				radioButton.Click -= value2;
			}
			_OptionMF1 = value;
			radioButton = _OptionMF1;
			if (radioButton != null)
			{
				radioButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("VoiceSet")]
	internal virtual TextBox VoiceSet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual System.Windows.Forms.Timer SpeachCompleteTM
	{
		[CompilerGenerated]
		get
		{
			return _SpeachCompleteTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SpeachCompleteTM_Tick;
			System.Windows.Forms.Timer timer = _SpeachCompleteTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_SpeachCompleteTM = value;
			timer = _SpeachCompleteTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SpeakTextTM")]
	public virtual System.Windows.Forms.Timer SpeakTextTM
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual System.Windows.Forms.Timer SpeakerTextTM
	{
		[CompilerGenerated]
		get
		{
			return _SpeakerTextTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SpeakerTextTM_Tick;
			System.Windows.Forms.Timer timer = _SpeakerTextTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_SpeakerTextTM = value;
			timer = _SpeakerTextTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SpeakTM")]
	private virtual System.Timers.Timer SpeakTM
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public event EventHandler<SpeakCompletedEventArgs> SpeakCompleted;

	public Speaker()
	{
		base.Load += Speaker_Load;
		base.FormClosing += ExitPage_Click;
		SVSFlagsAsync = 1;
		SpeakTM = new System.Timers.Timer();
		speaker = new SpeechSynthesizer();
		SAPI = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.spvoice"));
		VoiceName = Interaction.GetSetting("Dtread", "Aqua", "VoiceName", "hydra");
		ArrayOfNames = new string[101];
		ArrayOfGender = new string[101];
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
		this.VoiceOnTM = new System.Windows.Forms.Timer(this.components);
		this.ListBox1 = new System.Windows.Forms.ListBox();
		this.VoiceNameSet = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.ExitPage = new System.Windows.Forms.Button();
		this.PersonSex = new System.Windows.Forms.TextBox();
		this.OptionMF2 = new System.Windows.Forms.RadioButton();
		this.OptionMF1 = new System.Windows.Forms.RadioButton();
		this.VoiceSet = new System.Windows.Forms.TextBox();
		this.SpeachCompleteTM = new System.Windows.Forms.Timer(this.components);
		this.SpeakerTextTM = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.VoiceOnTM.Interval = 10000;
		this.ListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ListBox1.FormattingEnabled = true;
		this.ListBox1.ItemHeight = 16;
		this.ListBox1.Location = new System.Drawing.Point(30, 107);
		this.ListBox1.Margin = new System.Windows.Forms.Padding(6);
		this.ListBox1.Name = "ListBox1";
		this.ListBox1.Size = new System.Drawing.Size(775, 116);
		this.ListBox1.TabIndex = 2;
		this.VoiceNameSet.Location = new System.Drawing.Point(463, 378);
		this.VoiceNameSet.Name = "VoiceNameSet";
		this.VoiceNameSet.Size = new System.Drawing.Size(222, 31);
		this.VoiceNameSet.TabIndex = 3;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(379, 381);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(68, 25);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Name";
		this.ExitPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ExitPage.Location = new System.Drawing.Point(750, 32);
		this.ExitPage.Name = "ExitPage";
		this.ExitPage.Size = new System.Drawing.Size(55, 44);
		this.ExitPage.TabIndex = 161;
		this.ExitPage.Text = "X";
		this.ExitPage.UseVisualStyleBackColor = true;
		this.PersonSex.Location = new System.Drawing.Point(696, 441);
		this.PersonSex.Name = "PersonSex";
		this.PersonSex.Size = new System.Drawing.Size(19, 31);
		this.PersonSex.TabIndex = 168;
		this.PersonSex.Visible = false;
		this.OptionMF2.AutoSize = true;
		this.OptionMF2.Location = new System.Drawing.Point(574, 445);
		this.OptionMF2.Name = "OptionMF2";
		this.OptionMF2.Size = new System.Drawing.Size(101, 29);
		this.OptionMF2.TabIndex = 167;
		this.OptionMF2.TabStop = true;
		this.OptionMF2.Text = "Female";
		this.OptionMF2.UseVisualStyleBackColor = true;
		this.OptionMF1.AutoSize = true;
		this.OptionMF1.Location = new System.Drawing.Point(483, 445);
		this.OptionMF1.Name = "OptionMF1";
		this.OptionMF1.Size = new System.Drawing.Size(77, 29);
		this.OptionMF1.TabIndex = 166;
		this.OptionMF1.TabStop = true;
		this.OptionMF1.Text = "Male";
		this.OptionMF1.UseVisualStyleBackColor = true;
		this.VoiceSet.Location = new System.Drawing.Point(30, 309);
		this.VoiceSet.Name = "VoiceSet";
		this.VoiceSet.Size = new System.Drawing.Size(359, 31);
		this.VoiceSet.TabIndex = 169;
		this.SpeachCompleteTM.Interval = 1000;
		this.SpeakerTextTM.Interval = 1000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(12f, 25f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.SlateGray;
		base.ClientSize = new System.Drawing.Size(847, 486);
		base.ControlBox = false;
		base.Controls.Add(this.VoiceSet);
		base.Controls.Add(this.PersonSex);
		base.Controls.Add(this.OptionMF2);
		base.Controls.Add(this.OptionMF1);
		base.Controls.Add(this.ExitPage);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.VoiceNameSet);
		base.Controls.Add(this.ListBox1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new System.Windows.Forms.Padding(6);
		base.Name = "Speaker";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "VoiceControl";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void SpeakerTextTM_Tick(object sender, EventArgs e)
	{
		EnableSpeakerTextTM(false);
		Talk = Interaction.GetSetting("Dtread", "Aqua", "Sound");
		VoiceSetChange("Text", Talk);
		SpeakThread = new Thread(SpeachRun);
		SpeakThread.Start();
		SpeakThread.Priority = ThreadPriority.Highest;
		SpeachCompleteTM.Interval = 1000;
		SpeachCompleteTM.Enabled = true;
	}

	private void TimerEnable(bool enable)
	{
		if (!base.Enabled)
		{
			SpeakerTextTM.Dispose();
		}
		else
		{
			SpeakerTextTM.Enabled = true;
		}
	}

	public void EnableSpeakerTextTM(object enable)
	{
		Invoke(new SetTimerEnable(TimerEnable), enable);
	}

	private void SpeachRun()
	{
		if (Operators.CompareString(Talk, "", TextCompare: false) > 0)
		{
			object sAPI = SAPI;
			object[] array = new object[2];
			ref string talk = ref Talk;
			array[0] = talk;
			ref byte sVSFlagsAsync = ref SVSFlagsAsync;
			array[1] = sVSFlagsAsync;
			object[] array2 = array;
			bool[] obj = new bool[2] { true, true };
			bool[] array3 = obj;
			NewLateBinding.LateCall(sAPI, null, "Speak", array, null, null, obj, IgnoreReturn: true);
			if (array3[0])
			{
				talk = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
			}
			if (array3[1])
			{
				sVSFlagsAsync = (byte)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(byte));
			}
			NewLateBinding.LateCall(SAPI, null, "WAITUNTILDONE", new object[1] { -1L }, null, null, null, IgnoreReturn: true);
		}
	}

	public void SpeachCompleteTM_Tick(object sender, EventArgs e)
	{
		if (!SpeakThread.IsAlive)
		{
			SpeachCompleteTM.Dispose();
			MyProject.Forms.VoiceRecognizer.SetVoiceSync();
			Display.NewSpeech = true;
			MyProject.Forms.Display.UpdateVoiceImage();
		}
	}

	private void Speaker_Load(object sender, EventArgs e)
	{
		Hide();
		Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
		NewLateBinding.LateSet(SAPI, null, "Voice", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(SAPI, null, "getvoices", new object[0], null, null, null), null, "item", new object[1] { Interaction.GetSetting("Dtread", "Aqua", "UsedVoice", Conversions.ToString(0)) }, null, null, null) }, null, null);
		if (Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "Voice", Conversions.ToString(Value: false))))
		{
			speaker.SetOutputToDefaultAudioDevice();
			VoiceNameChange("Text", VoiceName);
			ListVoices();
		}
	}

	private void VoiceOnTM_Tick(object sender, EventArgs e)
	{
		if (!Display.ProgramRun)
		{
			VoiceOnTM.Dispose();
			VoiceOnOff = false;
			MyProject.Forms.VoiceRecognizer.SystemVoice("Voice Off");
		}
	}

	private void SpeachComplete(object sender, SpeakCompletedEventArgs e)
	{
		MyProject.Forms.VoiceRecognizer.SetVoiceSync();
		Display.NewSpeech = false;
		MyProject.Forms.Display.UpdateVoiceImage();
	}

	private void ListVoices()
	{
		voices = speaker.GetInstalledVoices();
		ListBox1.Items.Clear();
		int num = default(int);
		foreach (InstalledVoice voice in voices)
		{
			ListBox1.Items.Add($"Name: {voice.VoiceInfo.Name}, Gender: {voice.VoiceInfo.Gender}, Age: {voice.VoiceInfo.Age}, Description: {voice.VoiceInfo.Description}");
			ArrayOfGender[num] = Conversions.ToString(num);
			num = checked(num + 1);
		}
	}

	private void ListVoicesGender(string Sex)
	{
		double num = 1.0;
		if (Operators.CompareString(Sex, "Female", TextCompare: false) == 0)
		{
			num += 1.0;
		}
		voices = speaker.GetInstalledVoices();
		ListBox1.Items.Clear();
		checked
		{
			int num2 = default(int);
			int num3 = default(int);
			foreach (InstalledVoice voice in voices)
			{
				if (num == (double)voice.VoiceInfo.Gender)
				{
					ListBox1.Items.Add($"Name: {voice.VoiceInfo.Name}, Gender: {voice.VoiceInfo.Gender}, Age: {voice.VoiceInfo.Age}, Description: {voice.VoiceInfo.Description}");
					ArrayOfGender[num2] = Conversions.ToString(num3);
					num2++;
				}
				num3++;
			}
		}
	}

	private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string expression = ListBox1.SelectedItem.ToString();
		Array instance = Strings.Split(expression, ",");
		string text = Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet(instance, new object[1] { 3 }, null)), checked(Strings.Len("Discription: Microsoft") + 2), Strings.Len(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance, new object[1] { 3 }, null))));
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(instance, new object[1] { 1 }, null), " Gender: Male", TextCompare: false))
		{
			VoiceNameSet.Text = "hydra";
		}
		else
		{
			VoiceNameSet.Text = "hydra";
		}
		object sAPI = SAPI;
		object[] array = new object[1];
		object instance2 = NewLateBinding.LateGet(SAPI, null, "getvoices", new object[0], null, null, null);
		object[] array2 = new object[1];
		ref string reference = ref ArrayOfGender[ListBox1.SelectedIndex];
		array2[0] = reference;
		object[] array3 = array2;
		bool[] array4;
		object obj = NewLateBinding.LateGet(instance2, null, "item", array2, null, null, array4 = new bool[1] { true });
		if (array4[0])
		{
			reference = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
		}
		array[0] = obj;
		NewLateBinding.LateSet(sAPI, null, "Voice", array, null, null);
		Interaction.SaveSetting("Dtread", "Aqua", "UsedVoice", ArrayOfGender[ListBox1.SelectedIndex]);
		MyProject.Forms.VoiceRecognizer.Recognizercancell("This is " + text + " Hello");
		VoiceNameSet.Text = Strings.LCase(VoiceNameSet.Text);
		Interaction.SaveSetting("Dtread", "Aqua", "VoiceName", VoiceNameSet.Text);
		RestartHydro = true;
	}

	private void VoiceNameSet_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "VoiceName";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void RunNewEntre()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "VoiceName", TextCompare: false) == 0)
		{
			if (Conversion.Val(VoiceNameSet.Text) == 0.0)
			{
				VoiceNameChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = VoiceNameSet.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
		}
	}

	private void InfoEnter_Tick(object sender, EventArgs e)
	{
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "VoiceName", TextCompare: false) == 0)
		{
			VoiceNameChange("TextAlign", "Left");
			VoiceNameChange("Text", InfoEnter.PasswordSet);
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		string itemName2 = ItemName;
		if (Operators.CompareString(itemName2, "VoiceName", TextCompare: false) == 0)
		{
			if (Operators.CompareString(VoiceNameSet.Text, "", TextCompare: false) != 0)
			{
				VoiceNameSet.Text = Strings.LCase(VoiceNameSet.Text);
				Interaction.SaveSetting("Dtread", "Aqua", "VoiceName", VoiceNameSet.Text);
				RestartHydro = true;
			}
			VoiceNameChange("TextAlign", "Left");
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		ControlLevel = 0;
	}

	private void ExitPage_Click(object sender, EventArgs e)
	{
		CheckRestartHydro();
	}

	private void CheckRestartHydro()
	{
		if (RestartHydro)
		{
			RestartHydro = false;
			Display.RestartRequired = true;
		}
		try
		{
			Hide();
			MyProject.Forms.Display.VisibleCheck();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void VoiceNameChange(string Setting, string Data)
	{
		if (VoiceNameSet.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				VoiceNameChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			VoiceNameSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				VoiceNameSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				VoiceNameSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void VoiceSetChange(string Setting, string Data)
	{
		if (VoiceSet.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				VoiceSetChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			VoiceSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				VoiceSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				VoiceSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	public void PersonSexChange(string Text)
	{
		try
		{
			if (PersonSex.InvokeRequired)
			{
				SetDataCallback method = PersonSexChange;
				Invoke(method, Text);
				return;
			}
			PersonSex.Text = Text;
			if (Operators.CompareString(Text, "M", TextCompare: false) == 0)
			{
				if (!OptionMF1.Checked)
				{
					OptionMF1.Checked = true;
				}
				if (OptionMF2.Checked)
				{
					OptionMF2.Checked = false;
				}
			}
			else if (Operators.CompareString(Text, "F", TextCompare: false) == 0)
			{
				if (OptionMF1.Checked)
				{
					OptionMF1.Checked = false;
				}
				if (!OptionMF2.Checked)
				{
					OptionMF2.Checked = true;
				}
			}
			else
			{
				if (OptionMF1.Checked)
				{
					OptionMF1.Checked = false;
				}
				if (OptionMF2.Checked)
				{
					OptionMF2.Checked = false;
				}
			}
			Interaction.SaveSetting("Dtread", "Aqua", "VoiceSex", Text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void OptionMF_Click(object sender, EventArgs e)
	{
		if (OptionMF1.Checked)
		{
			PersonSexChange("M");
			ListVoicesGender("Male");
		}
		else if (OptionMF2.Checked)
		{
			PersonSexChange("F");
			ListVoicesGender("Female");
		}
	}
}
