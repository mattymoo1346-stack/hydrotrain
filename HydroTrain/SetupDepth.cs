using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HydroTrain.My;
using HydroTrain.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class SetupDepth : Form
{
	public delegate void SetTextCallback(string text);

	public delegate void SetControl1Callback(string ControlName, bool Data);

	public delegate void SetControl2Callback(string ControlName, string Setting, string Data);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRangeTime")]
	private TextBox _WaterDepthRangeTime;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ExitPage")]
	private Button _ExitPage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange10Plus")]
	private TextBox _WaterDepthRange10Plus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange20Plus")]
	private TextBox _WaterDepthRange20Plus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange30Plus")]
	private TextBox _WaterDepthRange30Plus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange40Plus")]
	private TextBox _WaterDepthRange40Plus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange50Plus")]
	private TextBox _WaterDepthRange50Plus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange60Plus")]
	private TextBox _WaterDepthRange60Plus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange0Plus")]
	private TextBox _WaterDepthRange0Plus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange0Minus")]
	private TextBox _WaterDepthRange0Minus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange60Minus")]
	private TextBox _WaterDepthRange60Minus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange50Minus")]
	private TextBox _WaterDepthRange50Minus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange40Minus")]
	private TextBox _WaterDepthRange40Minus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange30Minus")]
	private TextBox _WaterDepthRange30Minus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange20Minus")]
	private TextBox _WaterDepthRange20Minus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthRange10Minus")]
	private TextBox _WaterDepthRange10Minus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthUP")]
	private PictureBox _WaterDepthUP;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthDN")]
	private PictureBox _WaterDepthDN;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ResetButtonsTM")]
	private Timer _ResetButtonsTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ZeroLevelSw")]
	private Button _ZeroLevelSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterRangeSw")]
	private Button _WaterRangeSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EmptyAdj")]
	private TextBox _EmptyAdj;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FillAdj")]
	private TextBox _FillAdj;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DisplayTM")]
	private Timer _DisplayTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ExitPage1")]
	private Button _ExitPage1;

	private string ItemName;

	private int ControlLevel;

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

	internal virtual TextBox WaterDepthRangeTime
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRangeTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRangeTime_GotFocus;
			TextBox textBox = _WaterDepthRangeTime;
			if (textBox != null)
			{
				textBox.GotFocus -= value2;
			}
			_WaterDepthRangeTime = value;
			textBox = _WaterDepthRangeTime;
			if (textBox != null)
			{
				textBox.GotFocus += value2;
			}
		}
	}

	[field: AccessedThroughProperty("WaterDepthRangeLabel")]
	internal virtual Label WaterDepthRangeLabel
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

	internal virtual TextBox WaterDepthRange10Plus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange10Plus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange10Plus_Click;
			TextBox textBox = _WaterDepthRange10Plus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange10Plus = value;
			textBox = _WaterDepthRange10Plus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual TextBox WaterDepthRange20Plus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange20Plus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange20Plus_Click;
			TextBox textBox = _WaterDepthRange20Plus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange20Plus = value;
			textBox = _WaterDepthRange20Plus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual TextBox WaterDepthRange30Plus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange30Plus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange30Plus_Click;
			TextBox textBox = _WaterDepthRange30Plus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange30Plus = value;
			textBox = _WaterDepthRange30Plus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual TextBox WaterDepthRange40Plus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange40Plus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange40Plus_Click;
			TextBox textBox = _WaterDepthRange40Plus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange40Plus = value;
			textBox = _WaterDepthRange40Plus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	internal virtual TextBox WaterDepthRange50Plus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange50Plus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange50Plus_Click;
			TextBox textBox = _WaterDepthRange50Plus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange50Plus = value;
			textBox = _WaterDepthRange50Plus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox WaterDepthRange60Plus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange60Plus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange60Plus_Click;
			TextBox textBox = _WaterDepthRange60Plus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange60Plus = value;
			textBox = _WaterDepthRange60Plus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	internal virtual TextBox WaterDepthRange0Plus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange0Plus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange0Plus_Click;
			TextBox textBox = _WaterDepthRange0Plus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange0Plus = value;
			textBox = _WaterDepthRange0Plus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual TextBox WaterDepthRange0Minus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange0Minus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange0Minus_Click;
			TextBox textBox = _WaterDepthRange0Minus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange0Minus = value;
			textBox = _WaterDepthRange0Minus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
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

	internal virtual TextBox WaterDepthRange60Minus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange60Minus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange60Minus_Click;
			TextBox textBox = _WaterDepthRange60Minus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange60Minus = value;
			textBox = _WaterDepthRange60Minus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox WaterDepthRange50Minus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange50Minus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange50Minus_Click;
			TextBox textBox = _WaterDepthRange50Minus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange50Minus = value;
			textBox = _WaterDepthRange50Minus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label26")]
	internal virtual Label Label26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label27")]
	internal virtual Label Label27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox WaterDepthRange40Minus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange40Minus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange40Minus_Click;
			TextBox textBox = _WaterDepthRange40Minus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange40Minus = value;
			textBox = _WaterDepthRange40Minus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual TextBox WaterDepthRange30Minus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange30Minus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange30Minus_Click;
			TextBox textBox = _WaterDepthRange30Minus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange30Minus = value;
			textBox = _WaterDepthRange30Minus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual TextBox WaterDepthRange20Minus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange20Minus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange20Minus_Click;
			TextBox textBox = _WaterDepthRange20Minus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange20Minus = value;
			textBox = _WaterDepthRange20Minus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual TextBox WaterDepthRange10Minus
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthRange10Minus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthRange10Minus_Click;
			TextBox textBox = _WaterDepthRange10Minus;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthRange10Minus = value;
			textBox = _WaterDepthRange10Minus;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label28")]
	internal virtual Label Label28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CleanTimeLB")]
	internal virtual Label CleanTimeLB
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CleaningTimeInd")]
	internal virtual Label CleaningTimeInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox WaterDepthUP
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthUP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthUP_Click;
			PictureBox pictureBox = _WaterDepthUP;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_WaterDepthUP = value;
			pictureBox = _WaterDepthUP;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	internal virtual PictureBox WaterDepthDN
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthDN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthDN_Click;
			PictureBox pictureBox = _WaterDepthDN;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_WaterDepthDN = value;
			pictureBox = _WaterDepthDN;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("WaterLevelLB")]
	internal virtual Label WaterLevelLB
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer ResetButtonsTM
	{
		[CompilerGenerated]
		get
		{
			return _ResetButtonsTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ResetButtonsTM_Tick;
			Timer timer = _ResetButtonsTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ResetButtonsTM = value;
			timer = _ResetButtonsTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button ZeroLevelSw
	{
		[CompilerGenerated]
		get
		{
			return _ZeroLevelSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ZeroLevelSw_Click;
			Button button = _ZeroLevelSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ZeroLevelSw = value;
			button = _ZeroLevelSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button WaterRangeSw
	{
		[CompilerGenerated]
		get
		{
			return _WaterRangeSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterRangeSw_Click;
			Button button = _WaterRangeSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_WaterRangeSw = value;
			button = _WaterRangeSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label32")]
	internal virtual Label Label32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label31")]
	internal virtual Label Label31
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox EmptyAdj
	{
		[CompilerGenerated]
		get
		{
			return _EmptyAdj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = EmptyAdj_Click;
			TextBox textBox = _EmptyAdj;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_EmptyAdj = value;
			textBox = _EmptyAdj;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual TextBox FillAdj
	{
		[CompilerGenerated]
		get
		{
			return _FillAdj;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = FillAdj_Click;
			TextBox textBox = _FillAdj;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_FillAdj = value;
			textBox = _FillAdj;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label30")]
	internal virtual Label Label30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label34")]
	internal virtual Label Label34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label33")]
	internal virtual Label Label33
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer DisplayTM
	{
		[CompilerGenerated]
		get
		{
			return _DisplayTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DisplayTM_Tick;
			Timer timer = _DisplayTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_DisplayTM = value;
			timer = _DisplayTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Button ExitPage1
	{
		[CompilerGenerated]
		get
		{
			return _ExitPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ExitPage_Click;
			Button button = _ExitPage1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ExitPage1 = value;
			button = _ExitPage1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public SetupDepth()
	{
		base.Load += Setup_Load;
		base.Activated += SetupDepth_Activated;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HydroTrain.SetupDepth));
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.WaterDepthRangeTime = new System.Windows.Forms.TextBox();
		this.WaterDepthRangeLabel = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.ExitPage = new System.Windows.Forms.Button();
		this.WaterDepthRange10Plus = new System.Windows.Forms.TextBox();
		this.WaterDepthRange20Plus = new System.Windows.Forms.TextBox();
		this.WaterDepthRange30Plus = new System.Windows.Forms.TextBox();
		this.WaterDepthRange40Plus = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.WaterDepthRange50Plus = new System.Windows.Forms.TextBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.WaterDepthRange60Plus = new System.Windows.Forms.TextBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.WaterDepthRange0Plus = new System.Windows.Forms.TextBox();
		this.WaterDepthRange0Minus = new System.Windows.Forms.TextBox();
		this.Label15 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.WaterDepthRange60Minus = new System.Windows.Forms.TextBox();
		this.Label17 = new System.Windows.Forms.Label();
		this.WaterDepthRange50Minus = new System.Windows.Forms.TextBox();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.Label23 = new System.Windows.Forms.Label();
		this.Label24 = new System.Windows.Forms.Label();
		this.Label25 = new System.Windows.Forms.Label();
		this.Label26 = new System.Windows.Forms.Label();
		this.Label27 = new System.Windows.Forms.Label();
		this.WaterDepthRange40Minus = new System.Windows.Forms.TextBox();
		this.WaterDepthRange30Minus = new System.Windows.Forms.TextBox();
		this.WaterDepthRange20Minus = new System.Windows.Forms.TextBox();
		this.WaterDepthRange10Minus = new System.Windows.Forms.TextBox();
		this.Label28 = new System.Windows.Forms.Label();
		this.CleanTimeLB = new System.Windows.Forms.Label();
		this.CleaningTimeInd = new System.Windows.Forms.Label();
		this.WaterDepthUP = new System.Windows.Forms.PictureBox();
		this.WaterDepthDN = new System.Windows.Forms.PictureBox();
		this.WaterLevelLB = new System.Windows.Forms.Label();
		this.ResetButtonsTM = new System.Windows.Forms.Timer(this.components);
		this.Label29 = new System.Windows.Forms.Label();
		this.ZeroLevelSw = new System.Windows.Forms.Button();
		this.WaterRangeSw = new System.Windows.Forms.Button();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label34 = new System.Windows.Forms.Label();
		this.Label33 = new System.Windows.Forms.Label();
		this.Label32 = new System.Windows.Forms.Label();
		this.Label31 = new System.Windows.Forms.Label();
		this.EmptyAdj = new System.Windows.Forms.TextBox();
		this.FillAdj = new System.Windows.Forms.TextBox();
		this.Label30 = new System.Windows.Forms.Label();
		this.DisplayTM = new System.Windows.Forms.Timer(this.components);
		this.ExitPage1 = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.WaterDepthUP).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.WaterDepthDN).BeginInit();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.WaterDepthRangeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRangeTime.Location = new System.Drawing.Point(762, 14);
		this.WaterDepthRangeTime.Name = "WaterDepthRangeTime";
		this.WaterDepthRangeTime.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRangeTime.TabIndex = 4;
		this.WaterDepthRangeTime.Text = "300";
		this.WaterDepthRangeLabel.AutoSize = true;
		this.WaterDepthRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRangeLabel.Location = new System.Drawing.Point(628, 10);
		this.WaterDepthRangeLabel.Name = "WaterDepthRangeLabel";
		this.WaterDepthRangeLabel.Size = new System.Drawing.Size(119, 48);
		this.WaterDepthRangeLabel.TabIndex = 5;
		this.WaterDepthRangeLabel.Text = "Water Depth \r\nRange Time";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(585, 71);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(40, 25);
		this.Label1.TabIndex = 6;
		this.Label1.Text = "ms";
		this.ExitPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ExitPage.Location = new System.Drawing.Point(236, 12);
		this.ExitPage.Name = "ExitPage";
		this.ExitPage.Size = new System.Drawing.Size(55, 44);
		this.ExitPage.TabIndex = 8;
		this.ExitPage.Text = "X";
		this.ExitPage.UseVisualStyleBackColor = true;
		this.WaterDepthRange10Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange10Plus.Location = new System.Drawing.Point(516, 106);
		this.WaterDepthRange10Plus.Name = "WaterDepthRange10Plus";
		this.WaterDepthRange10Plus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange10Plus.TabIndex = 9;
		this.WaterDepthRange10Plus.Text = "300";
		this.WaterDepthRange20Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange20Plus.Location = new System.Drawing.Point(516, 147);
		this.WaterDepthRange20Plus.Name = "WaterDepthRange20Plus";
		this.WaterDepthRange20Plus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange20Plus.TabIndex = 10;
		this.WaterDepthRange20Plus.Text = "300";
		this.WaterDepthRange30Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange30Plus.Location = new System.Drawing.Point(516, 188);
		this.WaterDepthRange30Plus.Name = "WaterDepthRange30Plus";
		this.WaterDepthRange30Plus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange30Plus.TabIndex = 11;
		this.WaterDepthRange30Plus.Text = "300";
		this.WaterDepthRange40Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange40Plus.Location = new System.Drawing.Point(516, 229);
		this.WaterDepthRange40Plus.Name = "WaterDepthRange40Plus";
		this.WaterDepthRange40Plus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange40Plus.TabIndex = 12;
		this.WaterDepthRange40Plus.Text = "300";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(585, 110);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(40, 25);
		this.Label2.TabIndex = 13;
		this.Label2.Text = "ms";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(585, 153);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(40, 25);
		this.Label3.TabIndex = 14;
		this.Label3.Text = "ms";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(585, 194);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(40, 25);
		this.Label4.TabIndex = 15;
		this.Label4.Text = "ms";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(585, 235);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(40, 25);
		this.Label5.TabIndex = 16;
		this.Label5.Text = "ms";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(373, 71);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(137, 25);
		this.Label6.TabIndex = 17;
		this.Label6.Text = "Float Sw to 0";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(404, 110);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(106, 25);
		this.Label7.TabIndex = 18;
		this.Label7.Text = "0 to 10cm";
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(392, 153);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(118, 25);
		this.Label8.TabIndex = 19;
		this.Label8.Text = "10 to 20cm";
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(392, 194);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(118, 25);
		this.Label9.TabIndex = 20;
		this.Label9.Text = "20 to 30cm";
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.Location = new System.Drawing.Point(392, 235);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(118, 25);
		this.Label10.TabIndex = 21;
		this.Label10.Text = "30 to 40cm";
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.Location = new System.Drawing.Point(392, 276);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(118, 25);
		this.Label11.TabIndex = 22;
		this.Label11.Text = "40 to 50cm";
		this.WaterDepthRange50Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange50Plus.Location = new System.Drawing.Point(516, 270);
		this.WaterDepthRange50Plus.Name = "WaterDepthRange50Plus";
		this.WaterDepthRange50Plus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange50Plus.TabIndex = 23;
		this.WaterDepthRange50Plus.Text = "300";
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.Location = new System.Drawing.Point(379, 317);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(131, 25);
		this.Label12.TabIndex = 24;
		this.Label12.Text = "Above 50cm";
		this.WaterDepthRange60Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange60Plus.Location = new System.Drawing.Point(516, 311);
		this.WaterDepthRange60Plus.Name = "WaterDepthRange60Plus";
		this.WaterDepthRange60Plus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange60Plus.TabIndex = 25;
		this.WaterDepthRange60Plus.Text = "300";
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.Location = new System.Drawing.Point(585, 276);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(40, 25);
		this.Label13.TabIndex = 26;
		this.Label13.Text = "ms";
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.Location = new System.Drawing.Point(585, 317);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(40, 25);
		this.Label14.TabIndex = 27;
		this.Label14.Text = "ms";
		this.WaterDepthRange0Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange0Plus.Location = new System.Drawing.Point(516, 65);
		this.WaterDepthRange0Plus.Name = "WaterDepthRange0Plus";
		this.WaterDepthRange0Plus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange0Plus.TabIndex = 28;
		this.WaterDepthRange0Plus.Text = "300";
		this.WaterDepthRange0Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange0Minus.Location = new System.Drawing.Point(830, 65);
		this.WaterDepthRange0Minus.Name = "WaterDepthRange0Minus";
		this.WaterDepthRange0Minus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange0Minus.TabIndex = 49;
		this.WaterDepthRange0Minus.Text = "300";
		this.Label15.AutoSize = true;
		this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label15.Location = new System.Drawing.Point(899, 317);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(40, 25);
		this.Label15.TabIndex = 48;
		this.Label15.Text = "ms";
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.Location = new System.Drawing.Point(899, 276);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(40, 25);
		this.Label16.TabIndex = 47;
		this.Label16.Text = "ms";
		this.WaterDepthRange60Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange60Minus.Location = new System.Drawing.Point(830, 311);
		this.WaterDepthRange60Minus.Name = "WaterDepthRange60Minus";
		this.WaterDepthRange60Minus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange60Minus.TabIndex = 46;
		this.WaterDepthRange60Minus.Text = "300";
		this.Label17.AutoSize = true;
		this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.Location = new System.Drawing.Point(687, 317);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(127, 25);
		this.Label17.TabIndex = 45;
		this.Label17.Text = "Above to 50";
		this.WaterDepthRange50Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange50Minus.Location = new System.Drawing.Point(830, 270);
		this.WaterDepthRange50Minus.Name = "WaterDepthRange50Minus";
		this.WaterDepthRange50Minus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange50Minus.TabIndex = 44;
		this.WaterDepthRange50Minus.Text = "300";
		this.Label18.AutoSize = true;
		this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label18.Location = new System.Drawing.Point(696, 276);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(118, 25);
		this.Label18.TabIndex = 43;
		this.Label18.Text = "50 to 40cm";
		this.Label19.AutoSize = true;
		this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label19.Location = new System.Drawing.Point(696, 235);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(118, 25);
		this.Label19.TabIndex = 42;
		this.Label19.Text = "40 to 30cm";
		this.Label20.AutoSize = true;
		this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label20.Location = new System.Drawing.Point(696, 194);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(118, 25);
		this.Label20.TabIndex = 41;
		this.Label20.Text = "30 to 20cm";
		this.Label21.AutoSize = true;
		this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label21.Location = new System.Drawing.Point(696, 153);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(118, 25);
		this.Label21.TabIndex = 40;
		this.Label21.Text = "20 to 10cm";
		this.Label22.AutoSize = true;
		this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label22.Location = new System.Drawing.Point(708, 110);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(106, 25);
		this.Label22.TabIndex = 39;
		this.Label22.Text = "10 to 0cm";
		this.Label23.AutoSize = true;
		this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label23.Location = new System.Drawing.Point(677, 71);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(137, 25);
		this.Label23.TabIndex = 38;
		this.Label23.Text = "0 to Float Sw";
		this.Label24.AutoSize = true;
		this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label24.Location = new System.Drawing.Point(899, 235);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(40, 25);
		this.Label24.TabIndex = 37;
		this.Label24.Text = "ms";
		this.Label25.AutoSize = true;
		this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label25.Location = new System.Drawing.Point(899, 194);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(40, 25);
		this.Label25.TabIndex = 36;
		this.Label25.Text = "ms";
		this.Label26.AutoSize = true;
		this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label26.Location = new System.Drawing.Point(899, 153);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(40, 25);
		this.Label26.TabIndex = 35;
		this.Label26.Text = "ms";
		this.Label27.AutoSize = true;
		this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label27.Location = new System.Drawing.Point(899, 110);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(40, 25);
		this.Label27.TabIndex = 34;
		this.Label27.Text = "ms";
		this.WaterDepthRange40Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange40Minus.Location = new System.Drawing.Point(830, 229);
		this.WaterDepthRange40Minus.Name = "WaterDepthRange40Minus";
		this.WaterDepthRange40Minus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange40Minus.TabIndex = 33;
		this.WaterDepthRange40Minus.Text = "300";
		this.WaterDepthRange30Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange30Minus.Location = new System.Drawing.Point(830, 188);
		this.WaterDepthRange30Minus.Name = "WaterDepthRange30Minus";
		this.WaterDepthRange30Minus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange30Minus.TabIndex = 32;
		this.WaterDepthRange30Minus.Text = "300";
		this.WaterDepthRange20Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange20Minus.Location = new System.Drawing.Point(830, 147);
		this.WaterDepthRange20Minus.Name = "WaterDepthRange20Minus";
		this.WaterDepthRange20Minus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange20Minus.TabIndex = 31;
		this.WaterDepthRange20Minus.Text = "300";
		this.WaterDepthRange10Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthRange10Minus.Location = new System.Drawing.Point(830, 106);
		this.WaterDepthRange10Minus.Name = "WaterDepthRange10Minus";
		this.WaterDepthRange10Minus.Size = new System.Drawing.Size(63, 35);
		this.WaterDepthRange10Minus.TabIndex = 30;
		this.WaterDepthRange10Minus.Text = "300";
		this.Label28.AutoSize = true;
		this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label28.Location = new System.Drawing.Point(899, 71);
		this.Label28.Name = "Label28";
		this.Label28.Size = new System.Drawing.Size(40, 25);
		this.Label28.TabIndex = 29;
		this.Label28.Text = "ms";
		this.CleanTimeLB.AutoSize = true;
		this.CleanTimeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CleanTimeLB.Location = new System.Drawing.Point(323, 364);
		this.CleanTimeLB.Name = "CleanTimeLB";
		this.CleanTimeLB.Size = new System.Drawing.Size(150, 25);
		this.CleanTimeLB.TabIndex = 53;
		this.CleanTimeLB.Text = "Cleaning Time";
		this.CleaningTimeInd.AutoSize = true;
		this.CleaningTimeInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CleaningTimeInd.Location = new System.Drawing.Point(508, 364);
		this.CleaningTimeInd.Name = "CleaningTimeInd";
		this.CleaningTimeInd.Size = new System.Drawing.Size(152, 25);
		this.CleaningTimeInd.TabIndex = 54;
		this.CleaningTimeInd.Text = "Date and Time";
		this.WaterDepthUP.BackColor = System.Drawing.Color.Transparent;
		this.WaterDepthUP.Image = (System.Drawing.Image)resources.GetObject("WaterDepthUP.Image");
		this.WaterDepthUP.Location = new System.Drawing.Point(236, 128);
		this.WaterDepthUP.Name = "WaterDepthUP";
		this.WaterDepthUP.Size = new System.Drawing.Size(50, 51);
		this.WaterDepthUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.WaterDepthUP.TabIndex = 149;
		this.WaterDepthUP.TabStop = false;
		this.WaterDepthDN.BackColor = System.Drawing.Color.Transparent;
		this.WaterDepthDN.Image = (System.Drawing.Image)resources.GetObject("WaterDepthDN.Image");
		this.WaterDepthDN.Location = new System.Drawing.Point(242, 279);
		this.WaterDepthDN.Name = "WaterDepthDN";
		this.WaterDepthDN.Size = new System.Drawing.Size(49, 48);
		this.WaterDepthDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.WaterDepthDN.TabIndex = 150;
		this.WaterDepthDN.TabStop = false;
		this.WaterLevelLB.AutoSize = true;
		this.WaterLevelLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterLevelLB.Location = new System.Drawing.Point(231, 210);
		this.WaterLevelLB.Name = "WaterLevelLB";
		this.WaterLevelLB.Size = new System.Drawing.Size(69, 50);
		this.WaterLevelLB.TabIndex = 151;
		this.WaterLevelLB.Text = "Water\r\nLevel";
		this.Label29.AutoSize = true;
		this.Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label29.Location = new System.Drawing.Point(323, 9);
		this.Label29.Name = "Label29";
		this.Label29.Size = new System.Drawing.Size(99, 25);
		this.Label29.TabIndex = 152;
		this.Label29.Text = "Chamber";
		this.ZeroLevelSw.Location = new System.Drawing.Point(20, 208);
		this.ZeroLevelSw.Name = "ZeroLevelSw";
		this.ZeroLevelSw.Size = new System.Drawing.Size(124, 50);
		this.ZeroLevelSw.TabIndex = 153;
		this.ZeroLevelSw.Text = "Conveyor Level Set";
		this.ZeroLevelSw.UseVisualStyleBackColor = true;
		this.WaterRangeSw.Location = new System.Drawing.Point(20, 143);
		this.WaterRangeSw.Name = "WaterRangeSw";
		this.WaterRangeSw.Size = new System.Drawing.Size(124, 50);
		this.WaterRangeSw.TabIndex = 154;
		this.WaterRangeSw.Text = "40cm Level Set";
		this.WaterRangeSw.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.Label34);
		this.GroupBox1.Controls.Add(this.Label33);
		this.GroupBox1.Controls.Add(this.Label32);
		this.GroupBox1.Controls.Add(this.Label31);
		this.GroupBox1.Controls.Add(this.EmptyAdj);
		this.GroupBox1.Controls.Add(this.FillAdj);
		this.GroupBox1.Controls.Add(this.Label30);
		this.GroupBox1.Controls.Add(this.ZeroLevelSw);
		this.GroupBox1.Controls.Add(this.WaterRangeSw);
		this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.GroupBox1.Location = new System.Drawing.Point(42, 86);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(167, 275);
		this.GroupBox1.TabIndex = 155;
		this.GroupBox1.TabStop = false;
		this.Label34.AutoSize = true;
		this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label34.Location = new System.Drawing.Point(120, 98);
		this.Label34.Name = "Label34";
		this.Label34.Size = new System.Drawing.Size(40, 25);
		this.Label34.TabIndex = 161;
		this.Label34.Text = "cm";
		this.Label33.AutoSize = true;
		this.Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label33.Location = new System.Drawing.Point(120, 49);
		this.Label33.Name = "Label33";
		this.Label33.Size = new System.Drawing.Size(40, 25);
		this.Label33.TabIndex = 160;
		this.Label33.Text = "cm";
		this.Label32.AutoSize = true;
		this.Label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label32.Location = new System.Drawing.Point(8, 15);
		this.Label32.Name = "Label32";
		this.Label32.Size = new System.Drawing.Size(150, 20);
		this.Label32.TabIndex = 159;
		this.Label32.Text = "Auto Level Adjust";
		this.Label31.AutoSize = true;
		this.Label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label31.Location = new System.Drawing.Point(6, 99);
		this.Label31.Name = "Label31";
		this.Label31.Size = new System.Drawing.Size(63, 24);
		this.Label31.TabIndex = 158;
		this.Label31.Text = "Empty";
		this.EmptyAdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EmptyAdj.Location = new System.Drawing.Point(69, 92);
		this.EmptyAdj.Name = "EmptyAdj";
		this.EmptyAdj.Size = new System.Drawing.Size(45, 35);
		this.EmptyAdj.TabIndex = 156;
		this.EmptyAdj.Text = "0";
		this.FillAdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FillAdj.Location = new System.Drawing.Point(69, 43);
		this.FillAdj.Name = "FillAdj";
		this.FillAdj.Size = new System.Drawing.Size(45, 35);
		this.FillAdj.TabIndex = 157;
		this.FillAdj.Text = "0";
		this.Label30.AutoSize = true;
		this.Label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label30.Location = new System.Drawing.Point(6, 49);
		this.Label30.Name = "Label30";
		this.Label30.Size = new System.Drawing.Size(34, 24);
		this.Label30.TabIndex = 155;
		this.Label30.Text = "Fill";
		this.DisplayTM.Interval = 500;
		this.ExitPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ExitPage1.Location = new System.Drawing.Point(894, 10);
		this.ExitPage1.Name = "ExitPage1";
		this.ExitPage1.Size = new System.Drawing.Size(55, 44);
		this.ExitPage1.TabIndex = 156;
		this.ExitPage1.Text = "X";
		this.ExitPage1.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(965, 396);
		base.Controls.Add(this.ExitPage1);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.WaterLevelLB);
		base.Controls.Add(this.WaterDepthDN);
		base.Controls.Add(this.WaterDepthUP);
		base.Controls.Add(this.CleaningTimeInd);
		base.Controls.Add(this.Label29);
		base.Controls.Add(this.CleanTimeLB);
		base.Controls.Add(this.WaterDepthRange0Minus);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.WaterDepthRange60Minus);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.WaterDepthRange50Minus);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.Label19);
		base.Controls.Add(this.Label20);
		base.Controls.Add(this.Label21);
		base.Controls.Add(this.Label22);
		base.Controls.Add(this.Label23);
		base.Controls.Add(this.Label24);
		base.Controls.Add(this.Label25);
		base.Controls.Add(this.Label26);
		base.Controls.Add(this.Label27);
		base.Controls.Add(this.WaterDepthRange40Minus);
		base.Controls.Add(this.WaterDepthRange30Minus);
		base.Controls.Add(this.WaterDepthRange20Minus);
		base.Controls.Add(this.WaterDepthRange10Minus);
		base.Controls.Add(this.Label28);
		base.Controls.Add(this.WaterDepthRange0Plus);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.WaterDepthRange60Plus);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.WaterDepthRange50Plus);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.WaterDepthRange40Plus);
		base.Controls.Add(this.WaterDepthRange30Plus);
		base.Controls.Add(this.WaterDepthRange20Plus);
		base.Controls.Add(this.WaterDepthRange10Plus);
		base.Controls.Add(this.ExitPage);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.WaterDepthRangeLabel);
		base.Controls.Add(this.WaterDepthRangeTime);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "SetupDepth";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setup";
		base.TopMost = true;
		((System.ComponentModel.ISupportInitialize)this.WaterDepthUP).EndInit();
		((System.ComponentModel.ISupportInitialize)this.WaterDepthDN).EndInit();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void Sleep(long dwMilliseconds);

	public void Setup_Load(object sender, EventArgs e)
	{
		UpdateSettings();
	}

	private void SetResScreen()
	{
		Resolution("InclineSw", "", "");
		Resolution("JetSw", "", "");
		Resolution("TempGaugeSw", "", "");
		Resolution("HeaterAndCirculationFittedSw", "", "");
		Resolution("ExitPage", "", "");
		Resolution("WaterDepthRangeLabel", "", "");
		Resolution("WaterDepthRangeTM", "", "");
		Resolution("WaterDepthRange0Plus", "", "");
		Resolution("WaterDepthRange10Plus", "", "");
		Resolution("WaterDepthRange20Plus", "", "");
		Resolution("WaterDepthRange30Plus", "", "");
		Resolution("WaterDepthRange40Plus", "", "");
		Resolution("WaterDepthRange50Plus", "", "");
		Resolution("WaterDepthRange60Plus", "", "");
		Resolution("WaterDepthRange0Minus", "", "");
		Resolution("WaterDepthRange10Minus", "", "");
		Resolution("WaterDepthRange20Minus", "", "");
		Resolution("WaterDepthRange30Minus", "", "");
		Resolution("WaterDepthRange40Minus", "", "");
		Resolution("WaterDepthRange50Minus", "", "");
		Resolution("WaterDepthRange60Minus", "", "");
		Resolution("FillAdj", "", "");
		Resolution("EmptyAdj", "", "");
		Resolution("Label1", "", "");
		Resolution("Label2", "", "");
		Resolution("Label3", "", "");
		Resolution("Label4", "", "");
		Resolution("Label5", "", "");
		Resolution("Label6", "", "");
		Resolution("Label7", "", "");
		Resolution("Label8", "", "");
		Resolution("Label9", "", "");
		Resolution("Label10", "", "");
		Resolution("Label11", "", "");
		Resolution("Label12", "", "");
		Resolution("Label13", "", "");
		Resolution("Label14", "", "");
		Resolution("Label15", "", "");
		Resolution("Label16", "", "");
		Resolution("Label17", "", "");
		Resolution("Label18", "", "");
		Resolution("Label18", "", "");
		Resolution("Label20", "", "");
		Resolution("Label21", "", "");
		Resolution("Label22", "", "");
		Resolution("Label23", "", "");
	}

	private void Resolution(string ControlName, string ControlContainer, string ControlContainerA)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(ControlContainerA, "", TextCompare: false) > 0)
				{
					if (base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].InvokeRequired)
					{
						SetControl2Callback method = Resolution;
						Invoke(method, ControlName, ControlContainer, ControlContainerA);
					}
					else
					{
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font.Size * Display.ResMultiH);
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Height * Display.ResMultiH);
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Width * Display.ResMultiW);
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Top * Display.ResMultiH);
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Left * Display.ResMultiW);
					}
				}
				else if (Operators.CompareString(ControlContainer, "", TextCompare: false) > 0)
				{
					if (base.Controls[ControlContainer].Controls[ControlName].InvokeRequired)
					{
						SetControl2Callback method2 = Resolution;
						Invoke(method2, ControlName, ControlContainer, ControlContainerA);
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
					SetControl2Callback method3 = Resolution;
					Invoke(method3, ControlName, ControlContainer, ControlContainerA);
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

	public void UpdateSettings()
	{
		WaterDepthRange0PlusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange0Plus", Conversions.ToString(300)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange0Plus", WaterDepthRange0Plus.Text);
		WaterDepthRange10PlusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange10Plus", Conversions.ToString(335)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange10Plus", WaterDepthRange10Plus.Text);
		WaterDepthRange20PlusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange20Plus", Conversions.ToString(330)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange20Plus", WaterDepthRange20Plus.Text);
		WaterDepthRange30PlusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange30Plus", Conversions.ToString(330)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange30Plus", WaterDepthRange30Plus.Text);
		WaterDepthRange40PlusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange40Plus", Conversions.ToString(335)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange40Plus", WaterDepthRange40Plus.Text);
		WaterDepthRange50PlusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange50Plus", Conversions.ToString(345)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange50Plus", WaterDepthRange50Plus.Text);
		WaterDepthRange60PlusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange60Plus", Conversions.ToString(350)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange60Plus", WaterDepthRange60Plus.Text);
		WaterDepthRange0MinusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange0Minus", Conversions.ToString(425)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange0Minus", WaterDepthRange0Minus.Text);
		WaterDepthRange10MinusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange10Minus", Conversions.ToString(330)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange10Minus", WaterDepthRange10Minus.Text);
		WaterDepthRange20MinusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange20Minus", Conversions.ToString(335)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange20Minus", WaterDepthRange20Minus.Text);
		WaterDepthRange30MinusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange30Minus", Conversions.ToString(335)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange30Minus", WaterDepthRange30Minus.Text);
		WaterDepthRange40MinusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange40Minus", Conversions.ToString(340)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange40Minus", WaterDepthRange40Minus.Text);
		WaterDepthRange50MinusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange50Minus", Conversions.ToString(340)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange50Minus", WaterDepthRange50Minus.Text);
		WaterDepthRange60MinusChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRange60Minus", Conversions.ToString(330)));
		Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange60Minus", WaterDepthRange60Minus.Text);
		FillAdjChange("Text", Interaction.GetSetting("Dtread", "Aqua", "FillAdj", Conversions.ToString(1.5)));
		Interaction.SaveSetting("Dtread", "Aqua", "FillAdj", FillAdj.Text);
		EmptyAdjChange("Text", Interaction.GetSetting("Dtread", "Aqua", "EmptyAdj", Conversions.ToString(1)));
		Interaction.SaveSetting("Dtread", "Aqua", "EmptyAdj", EmptyAdj.Text);
		base.Top = 100;
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		switch (ItemName)
		{
		case "WaterDepthRange0Plus":
			WaterDepthRange0PlusChange("TextAlign", "Left");
			WaterDepthRange0PlusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange10Plus":
			WaterDepthRange10PlusChange("TextAlign", "Left");
			WaterDepthRange10PlusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange20Plus":
			WaterDepthRange20PlusChange("TextAlign", "Left");
			WaterDepthRange20PlusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange30Plus":
			WaterDepthRange30PlusChange("TextAlign", "Left");
			WaterDepthRange30PlusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange40Plus":
			WaterDepthRange40PlusChange("TextAlign", "Left");
			WaterDepthRange40PlusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange50Plus":
			WaterDepthRange50PlusChange("TextAlign", "Left");
			WaterDepthRange50PlusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange60Plus":
			WaterDepthRange60PlusChange("TextAlign", "Left");
			WaterDepthRange60PlusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange0Minus":
			WaterDepthRange0MinusChange("TextAlign", "Left");
			WaterDepthRange0MinusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange10Minus":
			WaterDepthRange10MinusChange("TextAlign", "Left");
			WaterDepthRange10MinusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange20Minus":
			WaterDepthRange20MinusChange("TextAlign", "Left");
			WaterDepthRange20MinusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange30Minus":
			WaterDepthRange30MinusChange("TextAlign", "Left");
			WaterDepthRange30MinusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange40Minus":
			WaterDepthRange40MinusChange("TextAlign", "Left");
			WaterDepthRange40MinusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange50Minus":
			WaterDepthRange50MinusChange("TextAlign", "Left");
			WaterDepthRange50MinusChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepthRange60Minus":
			WaterDepthRange60MinusChange("TextAlign", "Left");
			WaterDepthRange60MinusChange("Text", InfoEnter.PasswordSet);
			break;
		case "FillAdj":
			FillAdjChange("TextAlign", "Left");
			FillAdjChange("Text", InfoEnter.PasswordSet);
			break;
		case "EmptyAdj":
			EmptyAdjChange("TextAlign", "Left");
			EmptyAdjChange("Text", InfoEnter.PasswordSet);
			break;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		switch (ItemName)
		{
		case "WaterDepthRange0Plus":
			if (Operators.CompareString(WaterDepthRange0Plus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange0Plus", WaterDepthRange0Plus.Text);
			}
			WaterDepthRange0PlusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange10Plus":
			if (Operators.CompareString(WaterDepthRange10Plus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange10Plus", WaterDepthRange10Plus.Text);
			}
			WaterDepthRange10PlusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange20Plus":
			if (Operators.CompareString(WaterDepthRange20Plus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange20Plus", WaterDepthRange20Plus.Text);
			}
			WaterDepthRange20PlusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange30Plus":
			if (Operators.CompareString(WaterDepthRange30Plus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange30Plus", WaterDepthRange30Plus.Text);
			}
			WaterDepthRange30PlusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange40Plus":
			if (Operators.CompareString(WaterDepthRange40Plus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange40Plus", WaterDepthRange40Plus.Text);
			}
			WaterDepthRange40PlusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange50Plus":
			if (Operators.CompareString(WaterDepthRange50Plus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange50Plus", WaterDepthRange50Plus.Text);
			}
			WaterDepthRange50PlusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange60Plus":
			if (Operators.CompareString(WaterDepthRange60Plus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange60Plus", WaterDepthRange60Plus.Text);
			}
			WaterDepthRange60PlusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange0Minus":
			if (Operators.CompareString(WaterDepthRange0Minus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange0Minus", WaterDepthRange0Minus.Text);
			}
			WaterDepthRange0MinusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange10Minus":
			if (Operators.CompareString(WaterDepthRange10Minus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange10Minus", WaterDepthRange10Minus.Text);
			}
			WaterDepthRange10MinusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange20Minus":
			if (Operators.CompareString(WaterDepthRange20Minus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange20Minus", WaterDepthRange20Minus.Text);
			}
			WaterDepthRange20MinusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange30Minus":
			if (Operators.CompareString(WaterDepthRange30Minus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange30Minus", WaterDepthRange30Minus.Text);
			}
			WaterDepthRange30MinusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange40Minus":
			if (Operators.CompareString(WaterDepthRange40Minus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange40Minus", WaterDepthRange40Minus.Text);
			}
			WaterDepthRange40MinusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange50Minus":
			if (Operators.CompareString(WaterDepthRange50Minus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange50Minus", WaterDepthRange50Minus.Text);
			}
			WaterDepthRange50MinusChange("TextAlign", "Left");
			break;
		case "WaterDepthRange60Minus":
			if (Operators.CompareString(WaterDepthRange60Minus.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthRange60Minus", WaterDepthRange60Minus.Text);
			}
			WaterDepthRange60MinusChange("TextAlign", "Left");
			break;
		case "FillAdj":
			if (Operators.CompareString(FillAdj.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "FillAdj", FillAdj.Text);
			}
			FillAdjChange("TextAlign", "Left");
			break;
		case "EmptyAdj":
			if (Operators.CompareString(EmptyAdj.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "EmptyAdj", EmptyAdj.Text);
			}
			EmptyAdjChange("TextAlign", "Left");
			break;
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		ControlLevel = 0;
		UpdateSettings();
	}

	private void RunNewEntre()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		checked
		{
			switch (ItemName)
			{
			case "WaterDepthRange0Plus":
				if (Conversion.Val(WaterDepthRange0Plus.Text) == 0.0)
				{
					WaterDepthRange0PlusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange0Plus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange10Plus":
				if (Conversion.Val(WaterDepthRange10Plus.Text) == 0.0)
				{
					WaterDepthRange10PlusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange10Plus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange20Plus":
				if (Conversion.Val(WaterDepthRange20Plus.Text) == 0.0)
				{
					WaterDepthRange20PlusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange10Plus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange30Plus":
				if (Conversion.Val(WaterDepthRange30Plus.Text) == 0.0)
				{
					WaterDepthRange30PlusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange30Plus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange40Plus":
				if (Conversion.Val(WaterDepthRange40Plus.Text) == 0.0)
				{
					WaterDepthRange40PlusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange40Plus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange50Plus":
				if (Conversion.Val(WaterDepthRange50Plus.Text) == 0.0)
				{
					WaterDepthRange50PlusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange50Plus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange60Plus":
				if (Conversion.Val(WaterDepthRange60Plus.Text) == 0.0)
				{
					WaterDepthRange60PlusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange60Plus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange0Minus":
				if (Conversion.Val(WaterDepthRange0Minus.Text) == 0.0)
				{
					WaterDepthRange0MinusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange0Minus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange10Minus":
				if (Conversion.Val(WaterDepthRange10Minus.Text) == 0.0)
				{
					WaterDepthRange10MinusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange10Minus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange20Minus":
				if (Conversion.Val(WaterDepthRange20Minus.Text) == 0.0)
				{
					WaterDepthRange20MinusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange10Minus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange30Minus":
				if (Conversion.Val(WaterDepthRange30Minus.Text) == 0.0)
				{
					WaterDepthRange30MinusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange30Minus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange40Minus":
				if (Conversion.Val(WaterDepthRange40Minus.Text) == 0.0)
				{
					WaterDepthRange40MinusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange40Minus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange50Minus":
				if (Conversion.Val(WaterDepthRange50Minus.Text) == 0.0)
				{
					WaterDepthRange50MinusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange50Minus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "WaterDepthRange60Minus":
				if (Conversion.Val(WaterDepthRange60Minus.Text) == 0.0)
				{
					WaterDepthRange60MinusChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = WaterDepthRange60Minus.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "FillAdj":
				if (Conversion.Val(FillAdj.Text) == 0.0)
				{
					FillAdjChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = FillAdj.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			case "EmptyAdj":
				if (Conversion.Val(EmptyAdj.Text) == 0.0)
				{
					EmptyAdjChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = EmptyAdj.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, MyProject.Forms.InfoEnter.CentreLocY + (base.Height - 100));
				break;
			}
		}
	}

	private void ExitPage_Click(object sender, EventArgs e)
	{
		Hide();
		DisplayTM.Enabled = false;
	}

	private void WaterDepthRange0Plus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange0Plus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange10Plus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange10Plus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange20Plus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange20Plus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange30Plus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange30Plus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange40Plus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange40Plus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange50Plus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange50Plus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange60Plus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange60Plus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRangeTime_GotFocus(object sender, EventArgs e)
	{
		WaterDepthRangeLabel.Focus();
	}

	private void WaterDepthRange0Minus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange0Minus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange10Minus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange10Minus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange20Minus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange20Minus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange30Minus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange30Minus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange40Minus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange40Minus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange50Minus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange50Minus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthRange60Minus_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepthRange60Minus";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void FillAdj_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "FillAdj";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void EmptyAdj_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "EmptyAdj";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthUP_MouseHover(object sender, EventArgs e)
	{
		MyProject.Forms.Display.WaterDepthCheckTMOff();
		ImageChange("WaterDepthUP", "WaterDepth", "ArrowUpDe");
		if (Display.WDOnOff)
		{
			USBOPTORLY816.FillPump = true;
			USBOPTORLY88.AirReleaseFill = true;
		}
	}

	private void WaterDepthUP_MouseLeave(object sender, EventArgs e)
	{
		if (Display.WDOnOff)
		{
			MyProject.Forms.Display.WaterDepthCheckTMon();
		}
		ImageChange("WaterDepthUP", "WaterDepth", "ArrowUpOp");
		USBOPTORLY816.FillPump = false;
		Interaction.SaveSetting("DTread", "RLY816", "FillPump", Conversions.ToString(Value: false));
		USBOPTORLY88.AirReleaseFill = false;
	}

	private void WaterDepthDN_MouseHover(object sender, EventArgs e)
	{
		MyProject.Forms.Display.WaterDepthCheckTMOff();
		ImageChange("WaterDepthDN", "WaterDepth", "ArrowDnDe");
		if (Display.WDOnOff)
		{
			USBOPTORLY816.EmptyPump = true;
			Interaction.SaveSetting("DTread", "RLY816", "EmptyPump", Conversions.ToString(Value: true));
			USBOPTORLY88.AirReleaseEmpty = true;
		}
	}

	private void WaterDepthDN_MouseLeave(object sender, EventArgs e)
	{
		if (Display.WDOnOff)
		{
			MyProject.Forms.Display.WaterDepthCheckTMon();
		}
		ImageChange("WaterDepthDN", "WaterDepth", "ArrowDnOp");
		USBOPTORLY816.EmptyPump = false;
		USBOPTORLY88.AirReleaseEmpty = false;
		Interaction.SaveSetting("DTread", "RLY816", "EmptyPump", Conversions.ToString(Value: false));
	}

	public void ImageChange(string Control, string Setting, string Image)
	{
		if (base.Controls[Control].InvokeRequired)
		{
			SetControl2Callback method = ImageChange;
			Invoke(method, Control, Setting, Image);
			return;
		}
		try
		{
			if (Operators.CompareString(Setting, "WaterDepth", TextCompare: false) == 0)
			{
				switch (Image)
				{
				case "ArrowDnOp":
					WaterDepthDN.Image = Resources.ArrowDnOp;
					break;
				case "ArrowUpOp":
					WaterDepthUP.Image = Resources.ArrowUpOP;
					break;
				case "ArrowDnDe":
					WaterDepthDN.Image = Resources.ArrowDnDe;
					break;
				case "ArrowUpDe":
					WaterDepthUP.Image = Resources.ArrowUpDe;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public object WaterDepthRangeTimeChange(string Setting, string Data)
	{
		if (WaterDepthRangeTime.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRangeTimeChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRangeTime.Text = " " + Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRangeTime.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRangeTime.TextAlign = HorizontalAlignment.Center;
			}
		}
		object result = default(object);
		return result;
	}

	private void DisplayTM_Tick(object sender, EventArgs e)
	{
		WaterDepthRangeTimeChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthRangeInterval", "300"));
	}

	private void WaterDepthRange0PlusChange(string Setting, string Data)
	{
		if (WaterDepthRange0Plus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange0PlusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange0Plus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange0Plus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange0Plus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange10PlusChange(string Setting, string Data)
	{
		if (WaterDepthRange10Plus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange10PlusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange10Plus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange10Plus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange10Plus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange20PlusChange(string Setting, string Data)
	{
		if (WaterDepthRange20Plus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange20PlusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange20Plus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange20Plus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange20Plus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange30PlusChange(string Setting, string Data)
	{
		if (WaterDepthRange30Plus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange30PlusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange30Plus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange30Plus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange30Plus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange40PlusChange(string Setting, string Data)
	{
		if (WaterDepthRange40Plus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange40PlusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange40Plus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange40Plus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange40Plus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange50PlusChange(string Setting, string Data)
	{
		if (WaterDepthRange50Plus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange50PlusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange50Plus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange50Plus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange50Plus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange60PlusChange(string Setting, string Data)
	{
		if (WaterDepthRange60Plus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange60PlusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange60Plus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange60Plus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange60Plus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange0MinusChange(string Setting, string Data)
	{
		if (WaterDepthRange0Minus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange0MinusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange0Minus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange0Minus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange0Minus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange10MinusChange(string Setting, string Data)
	{
		if (WaterDepthRange10Minus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange10MinusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange10Minus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange10Minus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange10Minus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange20MinusChange(string Setting, string Data)
	{
		if (WaterDepthRange20Minus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange20MinusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange20Minus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange20Minus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange20Minus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange30MinusChange(string Setting, string Data)
	{
		if (WaterDepthRange30Minus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange30MinusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange30Minus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange30Minus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange30Minus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange40MinusChange(string Setting, string Data)
	{
		if (WaterDepthRange40Minus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange40MinusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange40Minus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange40Minus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange40Minus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange50MinusChange(string Setting, string Data)
	{
		if (WaterDepthRange50Minus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange50MinusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange50Minus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange50Minus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange50Minus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthRange60MinusChange(string Setting, string Data)
	{
		if (WaterDepthRange60Minus.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthRange60MinusChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthRange60Minus.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthRange60Minus.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthRange60Minus.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void FillAdjChange(string Setting, string Data)
	{
		if (FillAdj.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				FillAdjChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			FillAdj.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				FillAdj.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				FillAdj.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void EmptyAdjChange(string Setting, string Data)
	{
		if (EmptyAdj.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				EmptyAdjChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			EmptyAdj.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				EmptyAdj.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				EmptyAdj.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthUP_Click(object sender, EventArgs e)
	{
		WaterOnOffCheck();
		ImageChange("WaterDepthUP", "WaterDepth", "ArrowUpDe");
		IncreaseWaterDepth();
	}

	private void WaterOnOffCheck()
	{
		if (USBOPTORLY816.EmptyPump | USBOPTORLY88.AirReleaseEmpty | USBOPTORLY816.FillPump | USBOPTORLY88.AirReleaseFill)
		{
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthSw();
			}
		}
		else if (!Display.WDOnOff)
		{
			MyProject.Forms.Display.WaterDepthSw();
		}
	}

	public void IncreaseWaterDepth()
	{
		if (USBOPTORLY816.EmptyPump | USBOPTORLY88.AirReleaseEmpty)
		{
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthCheckTMon();
			}
			USBOPTORLY816.EmptyPump = false;
			USBOPTORLY88.AirReleaseEmpty = false;
			Interaction.SaveSetting("DTread", "RLY816", "EmptyPump", Conversions.ToString(Value: false));
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthSw();
			}
		}
		else if (!USBOPTORLY816.FillPump)
		{
			MyProject.Forms.Display.WaterDepthCheckTMOff();
			if (Display.WDOnOff)
			{
				USBOPTORLY88.AirReleaseFill = true;
				USBOPTORLY816.FillPump = true;
				Interaction.SaveSetting("DTread", "RLY816", "FillPump", Conversions.ToString(Value: true));
			}
		}
		else
		{
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthCheckTMon();
			}
			USBOPTORLY816.FillPump = false;
			USBOPTORLY88.AirReleaseFill = false;
			Interaction.SaveSetting("DTread", "RLY816", "FillPump", Conversions.ToString(Value: false));
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthSw();
			}
		}
		ResetButtonsTM.Interval = 800;
		ResetButtonsTM.Enabled = true;
	}

	private void WaterDepthDN_Click(object sender, EventArgs e)
	{
		WaterOnOffCheck();
		ImageChange("WaterDepthDN", "WaterDepth", "ArrowDnDe");
		DecreaseWaterDepth();
	}

	public void DecreaseWaterDepth()
	{
		if (USBOPTORLY816.FillPump | USBOPTORLY88.AirReleaseFill)
		{
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthCheckTMon();
			}
			USBOPTORLY816.FillPump = false;
			USBOPTORLY88.AirReleaseFill = false;
			Interaction.SaveSetting("DTread", "RLY816", "FillPump", Conversions.ToString(Value: false));
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthSw();
			}
		}
		else if (!USBOPTORLY816.EmptyPump)
		{
			MyProject.Forms.Display.WaterDepthCheckTMOff();
			if (Display.WDOnOff)
			{
				USBOPTORLY88.AirReleaseEmpty = true;
				USBOPTORLY816.EmptyPump = true;
				Interaction.SaveSetting("DTread", "RLY816", "EmptyPump", Conversions.ToString(Value: true));
			}
		}
		else
		{
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthCheckTMon();
			}
			USBOPTORLY816.EmptyPump = false;
			USBOPTORLY88.AirReleaseEmpty = false;
			Interaction.SaveSetting("DTread", "RLY816", "EmptyPump", Conversions.ToString(Value: false));
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthSw();
			}
		}
		ResetButtonsTM.Interval = 800;
		ResetButtonsTM.Enabled = true;
	}

	public void WaterDepthOff()
	{
		if (USBOPTORLY816.FillPump | USBOPTORLY88.AirReleaseFill)
		{
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthCheckTMon();
			}
			USBOPTORLY816.FillPump = false;
			USBOPTORLY88.AirReleaseFill = false;
			Interaction.SaveSetting("DTread", "RLY816", "FillPump", Conversions.ToString(Value: false));
		}
		if (USBOPTORLY816.EmptyPump | USBOPTORLY88.AirReleaseEmpty)
		{
			if (Display.WDOnOff)
			{
				MyProject.Forms.Display.WaterDepthCheckTMon();
			}
			USBOPTORLY816.EmptyPump = false;
			USBOPTORLY88.AirReleaseEmpty = false;
			Interaction.SaveSetting("DTread", "RLY816", "EmptyPump", Conversions.ToString(Value: false));
		}
	}

	private void ResetButtonsTM_Tick(object sender, EventArgs e)
	{
		ResetButtonsTM.Dispose();
		ImageChange("WaterDepthUP", "WaterDepth", "ArrowUpOp");
		ImageChange("WaterDepthDN", "WaterDepth", "ArrowDnOp");
	}

	private void WaterRangeSw_Click(object sender, EventArgs e)
	{
		Interaction.SaveSetting("DTread", "RLY82", "WaterRange", Conversions.ToString(Conversion.Val(Conversions.ToDouble(Interaction.GetSetting("Dtread", "RLY82", "ADC1", "571")) - Conversion.Val(Interaction.GetSetting("Dtread", "RLY82", "WaterZero", "253").ToString()))));
	}

	private void ZeroLevelSw_Click(object sender, EventArgs e)
	{
		Interaction.SaveSetting("DTread", "RLY82", "WaterZero", Conversion.Val(Interaction.GetSetting("Dtread", "RLY82", "ADC1", "253")).ToString());
	}

	private void SetupDepth_Activated(object sender, EventArgs e)
	{
		DisplayTM.Enabled = true;
	}

	public void SetLocation(object LocX, object LocY)
	{
		base.Location = new Point(Conversions.ToInteger(LocX), Conversions.ToInteger(LocY));
	}
}
