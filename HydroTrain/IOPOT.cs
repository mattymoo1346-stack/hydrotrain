using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace HydroTrain;

[DesignerGenerated]
public class IOPOT : Form
{
	public delegate void SetTextCallback(string text);

	public delegate void SetControlCallback(bool Data);

	public delegate void SetControl1Callback(string ControlName, bool Data);

	public delegate void SetControl2Callback(string ControlName, string Setting, string Data);

	public delegate void SetControl3Callback(string ControlContainerA, string ControlName, string Setting, string Data);

	public delegate void SetControl4Callback(string ControlContainerB, string ControlContainerA, string ControlName, string Setting, string Data);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LearnSW")]
	private Button _LearnSW;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ResetStopSW")]
	private Button _ResetStopSW;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Invisible")]
	private Button _Invisible;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InclineByteDisplay")]
	private TextBox _InclineByteDisplay;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownGrad")]
	private Button _DownGrad;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UPGrad")]
	private Button _UPGrad;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RelayOverideSw")]
	private Button _RelayOverideSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RPMLb")]
	private Label _RPMLb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RPMInd")]
	private TextBox _RPMInd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RLYBSpeed")]
	private Button _RLYBSpeed;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SpeedIntDisplay")]
	private TextBox _SpeedIntDisplay;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownSpeed")]
	private Button _DownSpeed;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UpSpeed")]
	private Button _UpSpeed;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RLYASpeed")]
	private Button _RLYASpeed;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SpeedChangeTM")]
	private Timer _SpeedChangeTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OutputsTM")]
	private Timer _OutputsTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("GradientChangeTM")]
	private Timer _GradientChangeTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InclineFaultTM")]
	private Timer _InclineFaultTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LearnOpTM")]
	private Timer _LearnOpTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StopResetTM")]
	private Timer _StopResetTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ConveyorOffTM")]
	private Timer _ConveyorOffTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("GradientPowerOffTM")]
	private Timer _GradientPowerOffTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeadbandSet")]
	private TextBox _DeadbandSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UpLevelSpeed")]
	private Button _UpLevelSpeed;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownLevelSpeed")]
	private Button _DownLevelSpeed;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownLevelDeg")]
	private Button _DownLevelDeg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UpLevelDeg")]
	private Button _UpLevelDeg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeadBandGradSet")]
	private TextBox _DeadBandGradSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InitialRegDeg")]
	private Button _InitialRegDeg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ConveyorContOnOff")]
	private Button _ConveyorContOnOff;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ActuatorContOnOff")]
	private Button _ActuatorContOnOff;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ActuatorPowerOffDelay")]
	private Timer _ActuatorPowerOffDelay;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RunningTM")]
	private Timer _RunningTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MotorForwardTM")]
	private Timer _MotorForwardTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MotorReverseTM")]
	private Timer _MotorReverseTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SetDegRange")]
	private Button _SetDegRange;

	public object CloseVersion;

	public float Diameter;

	public float PI;

	public int BitResS;

	public int BitResA;

	public byte DeadBand;

	public byte DeadBandGrad;

	public static int DrumCircumference = checked((int)Math.Round(Conversion.Val(Interaction.GetSetting("Dtread", "Aqua", "DrumCircumferenceSet", Conversions.ToString(534.07075118)))));

	public static int Mile_in_mm = 1609344;

	public static float IndexConstSpeed;

	public int SetSpeed;

	public float SpeedLevel;

	public int SetSpeedActual;

	public bool EmergencyStopActive;

	public bool IOPotError;

	public static string SpeedDisplay;

	public double SpeedIndkmpm;

	public double SpeedIndkmph;

	public double SpeedIndkmh;

	public double SpeedIndmpm;

	public double SpeedIndmiph;

	public double SpeedIndmph;

	public double Distancekm;

	public double Distancemi;

	public int Speed;

	public int Levels;

	public static int SpeedSet;

	public static bool ActuatorDelayOff;

	public static int InclineByteSet;

	public bool TreadmillMotorForward;

	public bool TreadmillMotorReverse;

	private byte SetByte;

	public static byte SpeedByte = 0;

	public static byte InclineByte = 0;

	public float IndexConstIncline;

	public static int SetIncline;

	public float InclineIndex;

	public float IndexIncline;

	public int SetInclineActual;

	public bool InclinePositionOK;

	public bool StartActuator;

	public double MaxGradient;

	public bool LearnAcc;

	public double Grade;

	public static bool IOPotCommsOK;

	public bool RelayOveride;

	public static byte SpeedIntXHold;

	public static byte SpeedIntYHold;

	public static byte GradientIntXHold;

	public static byte GradientIntYHold;

	private bool ResetProgram;

	public static bool HoldProgramOp;

	private bool GradWrite;

	private int GradT1;

	private string textInGradient;

	private string AckErrorGradient;

	private bool LearnOp;

	private int LearnMaxTime;

	private bool InclinePositionMoved;

	private bool ErrorCorrectionMotor;

	private int NextSpeed;

	private int SpeedT1;

	private string textInIOPot;

	private string IndicatorGrad;

	private string IndicatorSpeed;

	private bool LearnRLY;

	private bool RelayA;

	private bool RelayB;

	private bool RelayC;

	private bool RelayD;

	private bool RelayE;

	private bool StopResetRLY;

	private bool RLA;

	private bool RLB;

	private bool RLE;

	private string AckErrorIOPot;

	private string ReturnType;

	private bool IOPotWrite;

	private double VO2PerMin;

	private string ItemName;

	private int ControlLevel;

	private double OperatingTemp;

	private bool CopiedRawString;

	private byte ReadIndex;

	private string SerialNo;

	private bool ConveyorOffTMFlag;

	private int NumberOfHandles;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InclinePositionInd")]
	internal virtual Button InclinePositionInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button LearnSW
	{
		[CompilerGenerated]
		get
		{
			return _LearnSW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = LearnSW_Click;
			Button button = _LearnSW;
			if (button != null)
			{
				button.Click -= value2;
			}
			_LearnSW = value;
			button = _LearnSW;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button ResetStopSW
	{
		[CompilerGenerated]
		get
		{
			return _ResetStopSW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ResetStopSW_Click;
			Button button = _ResetStopSW;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ResetStopSW = value;
			button = _ResetStopSW;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label4
	{
		[CompilerGenerated]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InclineByteDisplay_Click;
			Label label = _Label4;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label4 = value;
			label = _Label4;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GradientPlusInd")]
	internal virtual TextBox GradientPlusInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox InclineByteDisplay
	{
		[CompilerGenerated]
		get
		{
			return _InclineByteDisplay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InclineByteDisplay_Click;
			TextBox textBox = _InclineByteDisplay;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_InclineByteDisplay = value;
			textBox = _InclineByteDisplay;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual Button DownGrad
	{
		[CompilerGenerated]
		get
		{
			return _DownGrad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DownGrad_Click;
			Button button = _DownGrad;
			if (button != null)
			{
				button.Click -= value2;
			}
			_DownGrad = value;
			button = _DownGrad;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button UPGrad
	{
		[CompilerGenerated]
		get
		{
			return _UPGrad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UPGrad_Click;
			Button button = _UPGrad;
			if (button != null)
			{
				button.Click -= value2;
			}
			_UPGrad = value;
			button = _UPGrad;
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

	internal virtual Label RPMLb
	{
		[CompilerGenerated]
		get
		{
			return _RPMLb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RPMLb_Click;
			Label label = _RPMLb;
			if (label != null)
			{
				label.Click -= value2;
			}
			_RPMLb = value;
			label = _RPMLb;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox RPMInd
	{
		[CompilerGenerated]
		get
		{
			return _RPMInd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RPMInd_Click;
			TextBox textBox = _RPMInd;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_RPMInd = value;
			textBox = _RPMInd;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual Button RLYBSpeed
	{
		[CompilerGenerated]
		get
		{
			return _RLYBSpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RLYBSpeed_Click;
			Button button = _RLYBSpeed;
			if (button != null)
			{
				button.Click -= value2;
			}
			_RLYBSpeed = value;
			button = _RLYBSpeed;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label9
	{
		[CompilerGenerated]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SpeedIntDisplay_Click;
			Label label = _Label9;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label9 = value;
			label = _Label9;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SpeedActual")]
	internal virtual TextBox SpeedActual
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox SpeedIntDisplay
	{
		[CompilerGenerated]
		get
		{
			return _SpeedIntDisplay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SpeedIntDisplay_Click;
			TextBox textBox = _SpeedIntDisplay;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_SpeedIntDisplay = value;
			textBox = _SpeedIntDisplay;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual Button DownSpeed
	{
		[CompilerGenerated]
		get
		{
			return _DownSpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DownSpeed_Click;
			Button button = _DownSpeed;
			if (button != null)
			{
				button.Click -= value2;
			}
			_DownSpeed = value;
			button = _DownSpeed;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button UpSpeed
	{
		[CompilerGenerated]
		get
		{
			return _UpSpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UpSpeed_Click;
			Button button = _UpSpeed;
			if (button != null)
			{
				button.Click -= value2;
			}
			_UpSpeed = value;
			button = _UpSpeed;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button RLYASpeed
	{
		[CompilerGenerated]
		get
		{
			return _RLYASpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RLYASpeed_Click;
			Button button = _RLYASpeed;
			if (button != null)
			{
				button.Click -= value2;
			}
			_RLYASpeed = value;
			button = _RLYASpeed;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("BoardComms")]
	internal virtual GroupBox BoardComms
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SerialPortIOPotInd")]
	internal virtual SerialPort SerialPortIOPotInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer SpeedChangeTM
	{
		[CompilerGenerated]
		get
		{
			return _SpeedChangeTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SpeedChangeTM_Tick;
			Timer timer = _SpeedChangeTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_SpeedChangeTM = value;
			timer = _SpeedChangeTM;
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

	internal virtual Timer OutputsTM
	{
		[CompilerGenerated]
		get
		{
			return _OutputsTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OutputsTM_Tick;
			Timer timer = _OutputsTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_OutputsTM = value;
			timer = _OutputsTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer GradientChangeTM
	{
		[CompilerGenerated]
		get
		{
			return _GradientChangeTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = GradientChangeTM_Tick;
			Timer timer = _GradientChangeTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_GradientChangeTM = value;
			timer = _GradientChangeTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer InclineFaultTM
	{
		[CompilerGenerated]
		get
		{
			return _InclineFaultTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InclineFaultTM_Tick;
			Timer timer = _InclineFaultTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_InclineFaultTM = value;
			timer = _InclineFaultTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer LearnOpTM
	{
		[CompilerGenerated]
		get
		{
			return _LearnOpTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = LearnOpTM_Tick;
			Timer timer = _LearnOpTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_LearnOpTM = value;
			timer = _LearnOpTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer StopResetTM
	{
		[CompilerGenerated]
		get
		{
			return _StopResetTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = StopResetTM_Tick;
			Timer timer = _StopResetTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_StopResetTM = value;
			timer = _StopResetTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer ConveyorOffTM
	{
		[CompilerGenerated]
		get
		{
			return _ConveyorOffTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ConveyorOffTM_Tick;
			Timer timer = _ConveyorOffTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ConveyorOffTM = value;
			timer = _ConveyorOffTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InclineActualByte")]
	internal virtual TextBox InclineActualByte
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer GradientPowerOffTM
	{
		[CompilerGenerated]
		get
		{
			return _GradientPowerOffTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = GradientPowerOffTM_Tick;
			Timer timer = _GradientPowerOffTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_GradientPowerOffTM = value;
			timer = _GradientPowerOffTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox DeadbandSet
	{
		[CompilerGenerated]
		get
		{
			return _DeadbandSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DeadbandSet_Click;
			TextBox textBox = _DeadbandSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_DeadbandSet = value;
			textBox = _DeadbandSet;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual Button UpLevelSpeed
	{
		[CompilerGenerated]
		get
		{
			return _UpLevelSpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UpLevelSpeed_Click;
			Button button = _UpLevelSpeed;
			if (button != null)
			{
				button.Click -= value2;
			}
			_UpLevelSpeed = value;
			button = _UpLevelSpeed;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button DownLevelSpeed
	{
		[CompilerGenerated]
		get
		{
			return _DownLevelSpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DownLevelSpeed_Click;
			Button button = _DownLevelSpeed;
			if (button != null)
			{
				button.Click -= value2;
			}
			_DownLevelSpeed = value;
			button = _DownLevelSpeed;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LevelInd")]
	internal virtual TextBox LevelInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ActualLevelIndSpeed")]
	internal virtual TextBox ActualLevelIndSpeed
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

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InitialReg")]
	internal virtual Button InitialReg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ActualLevelIndGradient")]
	internal virtual TextBox ActualLevelIndGradient
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button DownLevelDeg
	{
		[CompilerGenerated]
		get
		{
			return _DownLevelDeg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DownLevelDeg_Click;
			Button button = _DownLevelDeg;
			if (button != null)
			{
				button.Click -= value2;
			}
			_DownLevelDeg = value;
			button = _DownLevelDeg;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button UpLevelDeg
	{
		[CompilerGenerated]
		get
		{
			return _UpLevelDeg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UpLevelDeg_Click;
			Button button = _UpLevelDeg;
			if (button != null)
			{
				button.Click -= value2;
			}
			_UpLevelDeg = value;
			button = _UpLevelDeg;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DegInd")]
	internal virtual TextBox DegInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox DeadBandGradSet
	{
		[CompilerGenerated]
		get
		{
			return _DeadBandGradSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DeadbandGradSet_Click;
			TextBox textBox = _DeadBandGradSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_DeadBandGradSet = value;
			textBox = _DeadBandGradSet;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button InitialRegDeg
	{
		[CompilerGenerated]
		get
		{
			return _InitialRegDeg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InitialRegDeg_Click;
			Button button = _InitialRegDeg;
			if (button != null)
			{
				button.Click -= value2;
			}
			_InitialRegDeg = value;
			button = _InitialRegDeg;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	internal virtual Button ConveyorContOnOff
	{
		[CompilerGenerated]
		get
		{
			return _ConveyorContOnOff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ConveyorContOnOff_Click;
			Button button = _ConveyorContOnOff;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ConveyorContOnOff = value;
			button = _ConveyorContOnOff;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button ActuatorContOnOff
	{
		[CompilerGenerated]
		get
		{
			return _ActuatorContOnOff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ActuatorContOnOff_Click;
			Button button = _ActuatorContOnOff;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ActuatorContOnOff = value;
			button = _ActuatorContOnOff;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Timer ActuatorPowerOffDelay
	{
		[CompilerGenerated]
		get
		{
			return _ActuatorPowerOffDelay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ActuatorPowerOffDelay_Tick;
			Timer timer = _ActuatorPowerOffDelay;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ActuatorPowerOffDelay = value;
			timer = _ActuatorPowerOffDelay;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer RunningTM
	{
		[CompilerGenerated]
		get
		{
			return _RunningTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RunningTM_Tick;
			Timer timer = _RunningTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_RunningTM = value;
			timer = _RunningTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("MpmInd")]
	internal virtual TextBox MpmInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MpmLb")]
	internal virtual Label MpmLb
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Meter")]
	internal virtual Label Meter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MpmMeter")]
	internal virtual TextBox MpmMeter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer MotorForwardTM
	{
		[CompilerGenerated]
		get
		{
			return _MotorForwardTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MotorForwardTM_Tick;
			Timer timer = _MotorForwardTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_MotorForwardTM = value;
			timer = _MotorForwardTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer MotorReverseTM
	{
		[CompilerGenerated]
		get
		{
			return _MotorReverseTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MotorReverseTM_Tick;
			Timer timer = _MotorReverseTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_MotorReverseTM = value;
			timer = _MotorReverseTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CommsActiveInd")]
	internal virtual TextBox CommsActiveInd
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

	internal virtual Button SetDegRange
	{
		[CompilerGenerated]
		get
		{
			return _SetDegRange;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SetDegRange_Click;
			Button button = _SetDegRange;
			if (button != null)
			{
				button.Click -= value2;
			}
			_SetDegRange = value;
			button = _SetDegRange;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public IOPOT()
	{
		base.Activated += IOPOT_Activated;
		base.Load += IOPOT_Load;
		base.Closing += IOPOT_Closing;
		CloseVersion = Registry.CurrentUser.OpenSubKey("Control\\\\Windows\\\\Panel\\\\", writable: true);
		Diameter = 170f;
		PI = (float)Math.PI;
		BitResS = 255;
		BitResA = 255;
		checked
		{
			DeadBand = (byte)Math.Round(Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandSet", "0")));
			DeadBandGrad = (byte)Math.Round(Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandGradSet", "0")));
			SpeedIndkmh = 0.0;
			SpeedIndmph = 0.0;
			SetByte = 0;
			IndexIncline = 0f;
			SerialNo = Interaction.GetSetting("Dtread", "Aqua", "SerialNo", Conversions.ToString(9999));
			NumberOfHandles = Process.GetCurrentProcess().HandleCount;
			InitializeComponent();
		}
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
		this.Label1 = new System.Windows.Forms.Label();
		this.InclinePositionInd = new System.Windows.Forms.Button();
		this.LearnSW = new System.Windows.Forms.Button();
		this.ResetStopSW = new System.Windows.Forms.Button();
		this.Invisible = new System.Windows.Forms.Button();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.GradientPlusInd = new System.Windows.Forms.TextBox();
		this.InclineByteDisplay = new System.Windows.Forms.TextBox();
		this.DownGrad = new System.Windows.Forms.Button();
		this.UPGrad = new System.Windows.Forms.Button();
		this.RelayOverideSw = new System.Windows.Forms.Button();
		this.RPMLb = new System.Windows.Forms.Label();
		this.RPMInd = new System.Windows.Forms.TextBox();
		this.RLYBSpeed = new System.Windows.Forms.Button();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.SpeedActual = new System.Windows.Forms.TextBox();
		this.SpeedIntDisplay = new System.Windows.Forms.TextBox();
		this.DownSpeed = new System.Windows.Forms.Button();
		this.UpSpeed = new System.Windows.Forms.Button();
		this.RLYASpeed = new System.Windows.Forms.Button();
		this.BoardComms = new System.Windows.Forms.GroupBox();
		this.CommsActiveInd = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.SerialPortIOPotInd = new System.IO.Ports.SerialPort(this.components);
		this.SpeedChangeTM = new System.Windows.Forms.Timer(this.components);
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.OutputsTM = new System.Windows.Forms.Timer(this.components);
		this.GradientChangeTM = new System.Windows.Forms.Timer(this.components);
		this.InclineFaultTM = new System.Windows.Forms.Timer(this.components);
		this.LearnOpTM = new System.Windows.Forms.Timer(this.components);
		this.StopResetTM = new System.Windows.Forms.Timer(this.components);
		this.ConveyorOffTM = new System.Windows.Forms.Timer(this.components);
		this.Label7 = new System.Windows.Forms.Label();
		this.InclineActualByte = new System.Windows.Forms.TextBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.GradientPowerOffTM = new System.Windows.Forms.Timer(this.components);
		this.Label15 = new System.Windows.Forms.Label();
		this.DeadbandSet = new System.Windows.Forms.TextBox();
		this.UpLevelSpeed = new System.Windows.Forms.Button();
		this.DownLevelSpeed = new System.Windows.Forms.Button();
		this.LevelInd = new System.Windows.Forms.TextBox();
		this.ActualLevelIndSpeed = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.InitialReg = new System.Windows.Forms.Button();
		this.Label18 = new System.Windows.Forms.Label();
		this.ActualLevelIndGradient = new System.Windows.Forms.TextBox();
		this.DownLevelDeg = new System.Windows.Forms.Button();
		this.UpLevelDeg = new System.Windows.Forms.Button();
		this.Label19 = new System.Windows.Forms.Label();
		this.DegInd = new System.Windows.Forms.TextBox();
		this.DeadBandGradSet = new System.Windows.Forms.TextBox();
		this.Label20 = new System.Windows.Forms.Label();
		this.InitialRegDeg = new System.Windows.Forms.Button();
		this.Label21 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.ConveyorContOnOff = new System.Windows.Forms.Button();
		this.ActuatorContOnOff = new System.Windows.Forms.Button();
		this.ActuatorPowerOffDelay = new System.Windows.Forms.Timer(this.components);
		this.RunningTM = new System.Windows.Forms.Timer(this.components);
		this.MpmInd = new System.Windows.Forms.TextBox();
		this.MpmLb = new System.Windows.Forms.Label();
		this.Meter = new System.Windows.Forms.Label();
		this.MpmMeter = new System.Windows.Forms.TextBox();
		this.MotorForwardTM = new System.Windows.Forms.Timer(this.components);
		this.MotorReverseTM = new System.Windows.Forms.Timer(this.components);
		this.SetDegRange = new System.Windows.Forms.Button();
		this.BoardComms.SuspendLayout();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(671, 112);
		this.Label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(78, 13);
		this.Label1.TabIndex = 197;
		this.Label1.Text = "Incline Position";
		this.InclinePositionInd.BackColor = System.Drawing.SystemColors.Control;
		this.InclinePositionInd.Location = new System.Drawing.Point(694, 129);
		this.InclinePositionInd.Margin = new System.Windows.Forms.Padding(1);
		this.InclinePositionInd.Name = "InclinePositionInd";
		this.InclinePositionInd.Size = new System.Drawing.Size(42, 30);
		this.InclinePositionInd.TabIndex = 196;
		this.InclinePositionInd.UseVisualStyleBackColor = false;
		this.LearnSW.Location = new System.Drawing.Point(672, 71);
		this.LearnSW.Margin = new System.Windows.Forms.Padding(1);
		this.LearnSW.Name = "LearnSW";
		this.LearnSW.Size = new System.Drawing.Size(75, 24);
		this.LearnSW.TabIndex = 194;
		this.LearnSW.Text = "Learn";
		this.LearnSW.UseVisualStyleBackColor = true;
		this.ResetStopSW.Location = new System.Drawing.Point(672, 35);
		this.ResetStopSW.Margin = new System.Windows.Forms.Padding(1);
		this.ResetStopSW.Name = "ResetStopSW";
		this.ResetStopSW.Size = new System.Drawing.Size(75, 24);
		this.ResetStopSW.TabIndex = 193;
		this.ResetStopSW.Text = "Reset/Stop";
		this.ResetStopSW.UseVisualStyleBackColor = true;
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(27, 17);
		this.Invisible.Margin = new System.Windows.Forms.Padding(1);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(60, 44);
		this.Invisible.TabIndex = 190;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(628, 212);
		this.Label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(23, 20);
		this.Label5.TabIndex = 185;
		this.Label5.Text = "%";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(470, 91);
		this.Label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(40, 13);
		this.Label4.TabIndex = 184;
		this.Label4.Text = "0 - 255";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(510, 36);
		this.Label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(47, 13);
		this.Label3.TabIndex = 183;
		this.Label3.Text = "Actuator";
		this.GradientPlusInd.Location = new System.Drawing.Point(653, 212);
		this.GradientPlusInd.Margin = new System.Windows.Forms.Padding(1);
		this.GradientPlusInd.Multiline = true;
		this.GradientPlusInd.Name = "GradientPlusInd";
		this.GradientPlusInd.Size = new System.Drawing.Size(60, 27);
		this.GradientPlusInd.TabIndex = 180;
		this.GradientPlusInd.Text = "0.0";
		this.InclineByteDisplay.Location = new System.Drawing.Point(522, 86);
		this.InclineByteDisplay.Margin = new System.Windows.Forms.Padding(1);
		this.InclineByteDisplay.Name = "InclineByteDisplay";
		this.InclineByteDisplay.Size = new System.Drawing.Size(42, 20);
		this.InclineByteDisplay.TabIndex = 179;
		this.DownGrad.Location = new System.Drawing.Point(513, 111);
		this.DownGrad.Margin = new System.Windows.Forms.Padding(1);
		this.DownGrad.Name = "DownGrad";
		this.DownGrad.Size = new System.Drawing.Size(51, 25);
		this.DownGrad.TabIndex = 178;
		this.DownGrad.Text = "Down";
		this.DownGrad.UseVisualStyleBackColor = true;
		this.UPGrad.Location = new System.Drawing.Point(513, 52);
		this.UPGrad.Margin = new System.Windows.Forms.Padding(1);
		this.UPGrad.Name = "UPGrad";
		this.UPGrad.Size = new System.Drawing.Size(51, 26);
		this.UPGrad.TabIndex = 177;
		this.UPGrad.Text = "UP";
		this.UPGrad.UseVisualStyleBackColor = true;
		this.RelayOverideSw.Location = new System.Drawing.Point(14, 266);
		this.RelayOverideSw.Margin = new System.Windows.Forms.Padding(1);
		this.RelayOverideSw.Name = "RelayOverideSw";
		this.RelayOverideSw.Size = new System.Drawing.Size(92, 24);
		this.RelayOverideSw.TabIndex = 221;
		this.RelayOverideSw.Text = "Relays Off";
		this.RelayOverideSw.UseVisualStyleBackColor = true;
		this.RPMLb.AutoSize = true;
		this.RPMLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.RPMLb.Location = new System.Drawing.Point(9, 217);
		this.RPMLb.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.RPMLb.Name = "RPMLb";
		this.RPMLb.Size = new System.Drawing.Size(44, 20);
		this.RPMLb.TabIndex = 219;
		this.RPMLb.Text = "RPM";
		this.RPMInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.RPMInd.Location = new System.Drawing.Point(55, 215);
		this.RPMInd.Margin = new System.Windows.Forms.Padding(1);
		this.RPMInd.Name = "RPMInd";
		this.RPMInd.Size = new System.Drawing.Size(61, 26);
		this.RPMInd.TabIndex = 218;
		this.RPMInd.Text = "0.0";
		this.RLYBSpeed.Location = new System.Drawing.Point(220, 72);
		this.RLYBSpeed.Margin = new System.Windows.Forms.Padding(1);
		this.RLYBSpeed.Name = "RLYBSpeed";
		this.RLYBSpeed.Size = new System.Drawing.Size(75, 24);
		this.RLYBSpeed.TabIndex = 215;
		this.RLYBSpeed.Text = "Reverse";
		this.RLYBSpeed.UseVisualStyleBackColor = true;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(35, 150);
		this.Label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(37, 13);
		this.Label8.TabIndex = 211;
		this.Label8.Text = "Actual";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(28, 92);
		this.Label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(40, 13);
		this.Label9.TabIndex = 210;
		this.Label9.Text = "0 - 255";
		this.SpeedActual.Location = new System.Drawing.Point(74, 145);
		this.SpeedActual.Margin = new System.Windows.Forms.Padding(1);
		this.SpeedActual.Name = "SpeedActual";
		this.SpeedActual.Size = new System.Drawing.Size(42, 20);
		this.SpeedActual.TabIndex = 206;
		this.SpeedIntDisplay.Location = new System.Drawing.Point(74, 86);
		this.SpeedIntDisplay.Margin = new System.Windows.Forms.Padding(1);
		this.SpeedIntDisplay.Name = "SpeedIntDisplay";
		this.SpeedIntDisplay.Size = new System.Drawing.Size(42, 20);
		this.SpeedIntDisplay.TabIndex = 205;
		this.DownSpeed.Location = new System.Drawing.Point(66, 112);
		this.DownSpeed.Margin = new System.Windows.Forms.Padding(1);
		this.DownSpeed.Name = "DownSpeed";
		this.DownSpeed.Size = new System.Drawing.Size(51, 24);
		this.DownSpeed.TabIndex = 204;
		this.DownSpeed.Text = "Down";
		this.DownSpeed.UseVisualStyleBackColor = true;
		this.UpSpeed.Location = new System.Drawing.Point(66, 53);
		this.UpSpeed.Margin = new System.Windows.Forms.Padding(1);
		this.UpSpeed.Name = "UpSpeed";
		this.UpSpeed.Size = new System.Drawing.Size(51, 26);
		this.UpSpeed.TabIndex = 203;
		this.UpSpeed.Text = "UP";
		this.UpSpeed.UseVisualStyleBackColor = true;
		this.RLYASpeed.Location = new System.Drawing.Point(220, 35);
		this.RLYASpeed.Margin = new System.Windows.Forms.Padding(1);
		this.RLYASpeed.Name = "RLYASpeed";
		this.RLYASpeed.Size = new System.Drawing.Size(75, 24);
		this.RLYASpeed.TabIndex = 207;
		this.RLYASpeed.Text = "Forward";
		this.RLYASpeed.UseVisualStyleBackColor = true;
		this.BoardComms.Controls.Add(this.CommsActiveInd);
		this.BoardComms.Controls.Add(this.Label2);
		this.BoardComms.Controls.Add(this.Invisible);
		this.BoardComms.Controls.Add(this.RelayOverideSw);
		this.BoardComms.Location = new System.Drawing.Point(324, 6);
		this.BoardComms.Name = "BoardComms";
		this.BoardComms.Size = new System.Drawing.Size(122, 308);
		this.BoardComms.TabIndex = 223;
		this.BoardComms.TabStop = false;
		this.CommsActiveInd.Location = new System.Drawing.Point(36, 175);
		this.CommsActiveInd.Margin = new System.Windows.Forms.Padding(1);
		this.CommsActiveInd.Name = "CommsActiveInd";
		this.CommsActiveInd.Size = new System.Drawing.Size(42, 20);
		this.CommsActiveInd.TabIndex = 223;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(24, 161);
		this.Label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(74, 13);
		this.Label2.TabIndex = 222;
		this.Label2.Text = "Comms Active";
		this.SerialPortIOPotInd.BaudRate = 125000;
		this.SerialPortIOPotInd.Parity = System.IO.Ports.Parity.Even;
		this.SerialPortIOPotInd.PortName = "COM12";
		this.SpeedChangeTM.Enabled = true;
		this.InfoEnterTM.Enabled = true;
		this.GradientChangeTM.Interval = 1000;
		this.InclineFaultTM.Interval = 60000;
		this.LearnOpTM.Interval = 1000;
		this.StopResetTM.Interval = 10000;
		this.ConveyorOffTM.Interval = 3000;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(63, 35);
		this.Label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(38, 13);
		this.Label7.TabIndex = 233;
		this.Label7.Text = "Speed";
		this.InclineActualByte.Location = new System.Drawing.Point(522, 143);
		this.InclineActualByte.Margin = new System.Windows.Forms.Padding(1);
		this.InclineActualByte.Name = "InclineActualByte";
		this.InclineActualByte.Size = new System.Drawing.Size(42, 20);
		this.InclineActualByte.TabIndex = 234;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(483, 148);
		this.Label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(37, 13);
		this.Label12.TabIndex = 235;
		this.Label12.Text = "Actual";
		this.GradientPowerOffTM.Interval = 50000;
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(222, 117);
		this.Label15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(73, 26);
		this.Label15.TabIndex = 241;
		this.Label15.Text = "Min Operating\r\nLevel";
		this.DeadbandSet.Location = new System.Drawing.Point(230, 145);
		this.DeadbandSet.Margin = new System.Windows.Forms.Padding(1);
		this.DeadbandSet.Name = "DeadbandSet";
		this.DeadbandSet.Size = new System.Drawing.Size(54, 20);
		this.DeadbandSet.TabIndex = 242;
		this.UpLevelSpeed.Location = new System.Drawing.Point(65, 182);
		this.UpLevelSpeed.Margin = new System.Windows.Forms.Padding(1);
		this.UpLevelSpeed.Name = "UpLevelSpeed";
		this.UpLevelSpeed.Size = new System.Drawing.Size(51, 26);
		this.UpLevelSpeed.TabIndex = 243;
		this.UpLevelSpeed.Text = "UP";
		this.UpLevelSpeed.UseVisualStyleBackColor = true;
		this.DownLevelSpeed.Location = new System.Drawing.Point(65, 248);
		this.DownLevelSpeed.Margin = new System.Windows.Forms.Padding(1);
		this.DownLevelSpeed.Name = "DownLevelSpeed";
		this.DownLevelSpeed.Size = new System.Drawing.Size(51, 24);
		this.DownLevelSpeed.TabIndex = 244;
		this.DownLevelSpeed.Text = "Down";
		this.DownLevelSpeed.UseVisualStyleBackColor = true;
		this.LevelInd.Location = new System.Drawing.Point(74, 281);
		this.LevelInd.Margin = new System.Windows.Forms.Padding(1);
		this.LevelInd.Name = "LevelInd";
		this.LevelInd.Size = new System.Drawing.Size(42, 20);
		this.LevelInd.TabIndex = 245;
		this.ActualLevelIndSpeed.Location = new System.Drawing.Point(133, 218);
		this.ActualLevelIndSpeed.Margin = new System.Windows.Forms.Padding(1);
		this.ActualLevelIndSpeed.Name = "ActualLevelIndSpeed";
		this.ActualLevelIndSpeed.Size = new System.Drawing.Size(42, 20);
		this.ActualLevelIndSpeed.TabIndex = 246;
		this.ActualLevelIndSpeed.Text = "0";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(15, 284);
		this.Label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(57, 13);
		this.Label16.TabIndex = 247;
		this.Label16.Text = "Levels Set";
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(130, 204);
		this.Label17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(33, 13);
		this.Label17.TabIndex = 248;
		this.Label17.Text = "Level";
		this.InitialReg.Location = new System.Drawing.Point(220, 188);
		this.InitialReg.Margin = new System.Windows.Forms.Padding(1);
		this.InitialReg.Name = "InitialReg";
		this.InitialReg.Size = new System.Drawing.Size(90, 42);
		this.InitialReg.TabIndex = 249;
		this.InitialReg.Text = "Initial Speed Reg";
		this.InitialReg.UseVisualStyleBackColor = true;
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(574, 202);
		this.Label18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(33, 13);
		this.Label18.TabIndex = 251;
		this.Label18.Text = "Level";
		this.ActualLevelIndGradient.Location = new System.Drawing.Point(577, 216);
		this.ActualLevelIndGradient.Margin = new System.Windows.Forms.Padding(1);
		this.ActualLevelIndGradient.Name = "ActualLevelIndGradient";
		this.ActualLevelIndGradient.Size = new System.Drawing.Size(42, 20);
		this.ActualLevelIndGradient.TabIndex = 250;
		this.ActualLevelIndGradient.Text = "0";
		this.DownLevelDeg.Location = new System.Drawing.Point(513, 247);
		this.DownLevelDeg.Margin = new System.Windows.Forms.Padding(1);
		this.DownLevelDeg.Name = "DownLevelDeg";
		this.DownLevelDeg.Size = new System.Drawing.Size(51, 24);
		this.DownLevelDeg.TabIndex = 255;
		this.DownLevelDeg.Text = "Down";
		this.DownLevelDeg.UseVisualStyleBackColor = true;
		this.UpLevelDeg.Location = new System.Drawing.Point(513, 181);
		this.UpLevelDeg.Margin = new System.Windows.Forms.Padding(1);
		this.UpLevelDeg.Name = "UpLevelDeg";
		this.UpLevelDeg.Size = new System.Drawing.Size(51, 26);
		this.UpLevelDeg.TabIndex = 254;
		this.UpLevelDeg.Text = "UP";
		this.UpLevelDeg.UseVisualStyleBackColor = true;
		this.Label19.AutoSize = true;
		this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label19.Location = new System.Drawing.Point(460, 217);
		this.Label19.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(39, 20);
		this.Label19.TabIndex = 253;
		this.Label19.Text = "Deg";
		this.DegInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DegInd.Location = new System.Drawing.Point(503, 214);
		this.DegInd.Margin = new System.Windows.Forms.Padding(1);
		this.DegInd.Name = "DegInd";
		this.DegInd.Size = new System.Drawing.Size(61, 26);
		this.DegInd.TabIndex = 252;
		this.DegInd.Text = "0.0";
		this.DeadBandGradSet.Location = new System.Drawing.Point(597, 145);
		this.DeadBandGradSet.Margin = new System.Windows.Forms.Padding(1);
		this.DeadBandGradSet.Name = "DeadBandGradSet";
		this.DeadBandGradSet.Size = new System.Drawing.Size(54, 20);
		this.DeadBandGradSet.TabIndex = 257;
		this.Label20.AutoSize = true;
		this.Label20.Location = new System.Drawing.Point(594, 129);
		this.Label20.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(58, 13);
		this.Label20.TabIndex = 256;
		this.Label20.Text = "Zero Level";
		this.InitialRegDeg.Location = new System.Drawing.Point(597, 273);
		this.InitialRegDeg.Margin = new System.Windows.Forms.Padding(1);
		this.InitialRegDeg.Name = "InitialRegDeg";
		this.InitialRegDeg.Size = new System.Drawing.Size(65, 42);
		this.InitialRegDeg.TabIndex = 258;
		this.InitialRegDeg.Text = "Set Zero Level";
		this.InitialRegDeg.UseVisualStyleBackColor = true;
		this.Label21.AutoSize = true;
		this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label21.Location = new System.Drawing.Point(635, 5);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(78, 20);
		this.Label21.TabIndex = 259;
		this.Label21.Text = "Actuator";
		this.Label22.AutoSize = true;
		this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label22.Location = new System.Drawing.Point(128, 6);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(83, 20);
		this.Label22.TabIndex = 260;
		this.Label22.Text = "Conveyor";
		this.ConveyorContOnOff.Location = new System.Drawing.Point(146, 36);
		this.ConveyorContOnOff.Margin = new System.Windows.Forms.Padding(1);
		this.ConveyorContOnOff.Name = "ConveyorContOnOff";
		this.ConveyorContOnOff.Size = new System.Drawing.Size(65, 60);
		this.ConveyorContOnOff.TabIndex = 261;
		this.ConveyorContOnOff.Text = "Conveyor Controller Off";
		this.ConveyorContOnOff.UseVisualStyleBackColor = true;
		this.ActuatorContOnOff.Location = new System.Drawing.Point(597, 35);
		this.ActuatorContOnOff.Margin = new System.Windows.Forms.Padding(1);
		this.ActuatorContOnOff.Name = "ActuatorContOnOff";
		this.ActuatorContOnOff.Size = new System.Drawing.Size(65, 60);
		this.ActuatorContOnOff.TabIndex = 262;
		this.ActuatorContOnOff.Text = "Actuator Controller Off";
		this.ActuatorContOnOff.UseVisualStyleBackColor = true;
		this.ActuatorPowerOffDelay.Interval = 5000;
		this.RunningTM.Enabled = true;
		this.RunningTM.Interval = 1000;
		this.MpmInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.MpmInd.Location = new System.Drawing.Point(249, 245);
		this.MpmInd.Margin = new System.Windows.Forms.Padding(1);
		this.MpmInd.Name = "MpmInd";
		this.MpmInd.Size = new System.Drawing.Size(61, 26);
		this.MpmInd.TabIndex = 263;
		this.MpmInd.Text = "0.0";
		this.MpmLb.AutoSize = true;
		this.MpmLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.MpmLb.Location = new System.Drawing.Point(200, 249);
		this.MpmLb.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.MpmLb.Name = "MpmLb";
		this.MpmLb.Size = new System.Drawing.Size(48, 20);
		this.MpmLb.TabIndex = 264;
		this.MpmLb.Text = "m/pm";
		this.Meter.AutoSize = true;
		this.Meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Meter.Location = new System.Drawing.Point(156, 283);
		this.Meter.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
		this.Meter.Name = "Meter";
		this.Meter.Size = new System.Drawing.Size(91, 20);
		this.Meter.TabIndex = 266;
		this.Meter.Text = "Meter * 100";
		this.MpmMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.MpmMeter.Location = new System.Drawing.Point(249, 280);
		this.MpmMeter.Margin = new System.Windows.Forms.Padding(1);
		this.MpmMeter.Name = "MpmMeter";
		this.MpmMeter.Size = new System.Drawing.Size(61, 26);
		this.MpmMeter.TabIndex = 265;
		this.MpmMeter.Text = "0.0";
		this.MotorForwardTM.Interval = 1000;
		this.MotorReverseTM.Interval = 1000;
		this.SetDegRange.Location = new System.Drawing.Point(694, 272);
		this.SetDegRange.Margin = new System.Windows.Forms.Padding(1);
		this.SetDegRange.Name = "SetDegRange";
		this.SetDegRange.Size = new System.Drawing.Size(61, 42);
		this.SetDegRange.TabIndex = 267;
		this.SetDegRange.Text = "Set Deg Range";
		this.SetDegRange.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(794, 361);
		base.ControlBox = false;
		base.Controls.Add(this.SetDegRange);
		base.Controls.Add(this.Meter);
		base.Controls.Add(this.MpmMeter);
		base.Controls.Add(this.MpmLb);
		base.Controls.Add(this.MpmInd);
		base.Controls.Add(this.ActuatorContOnOff);
		base.Controls.Add(this.ConveyorContOnOff);
		base.Controls.Add(this.Label22);
		base.Controls.Add(this.Label21);
		base.Controls.Add(this.InitialRegDeg);
		base.Controls.Add(this.DeadBandGradSet);
		base.Controls.Add(this.Label20);
		base.Controls.Add(this.DownLevelDeg);
		base.Controls.Add(this.UpLevelDeg);
		base.Controls.Add(this.Label19);
		base.Controls.Add(this.DegInd);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.ActualLevelIndGradient);
		base.Controls.Add(this.InitialReg);
		base.Controls.Add(this.Label17);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.ActualLevelIndSpeed);
		base.Controls.Add(this.LevelInd);
		base.Controls.Add(this.DownLevelSpeed);
		base.Controls.Add(this.UpLevelSpeed);
		base.Controls.Add(this.DeadbandSet);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.InclineActualByte);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.BoardComms);
		base.Controls.Add(this.RPMLb);
		base.Controls.Add(this.RPMInd);
		base.Controls.Add(this.RLYBSpeed);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.RLYASpeed);
		base.Controls.Add(this.SpeedActual);
		base.Controls.Add(this.SpeedIntDisplay);
		base.Controls.Add(this.DownSpeed);
		base.Controls.Add(this.UpSpeed);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.InclinePositionInd);
		base.Controls.Add(this.LearnSW);
		base.Controls.Add(this.ResetStopSW);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.GradientPlusInd);
		base.Controls.Add(this.InclineByteDisplay);
		base.Controls.Add(this.DownGrad);
		base.Controls.Add(this.UPGrad);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new System.Windows.Forms.Padding(1);
		base.Name = "IOPOT";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "IOPOT";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		this.BoardComms.ResumeLayout(false);
		this.BoardComms.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void MotorForward()
	{
		if ((TreadmillMotorForward & !RelayOveride & !Display.TestEStop) | (RelayA & RelayOveride))
		{
			Display.MotorForward = true;
		}
		else
		{
			Display.MotorForward = false;
		}
	}

	private void MotorReverse()
	{
		if ((TreadmillMotorReverse & !RelayOveride & !Display.TestEStop) | (RelayB & RelayOveride))
		{
			Display.MotorReverse = true;
		}
		else
		{
			Display.MotorReverse = false;
		}
	}

	private void RLEKey_Click(object sender, EventArgs e)
	{
		RLYEKeyOperate();
	}

	private void RLYEKeyOperate()
	{
		RelayE = RLE;
		if (!RelayE)
		{
			RelayE = true;
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
		}
		else
		{
			RelayE = false;
		}
	}

	private void RLYASpeed_Click(object sender, EventArgs e)
	{
		RLYASpeedOperate();
	}

	private void RLYASpeedOperate()
	{
		RelayA = RLA;
		if (!RelayB)
		{
			if (!RelayA)
			{
				RelayA = true;
				RelayOveride = true;
				RelayOverideSwChange("Relays On");
			}
			else
			{
				RelayA = false;
			}
		}
	}

	private void RLYBSpeed_Click(object sender, EventArgs e)
	{
		RLYBSpeedOperate();
	}

	private void RLYBSpeedOperate()
	{
		RelayB = RLB;
		if (!RelayA)
		{
			if (!RelayB)
			{
				RelayB = true;
				RelayOveride = true;
				RelayOverideSwChange("Relays On");
			}
			else
			{
				RelayB = false;
			}
		}
	}

	private void ControlColorDarkGreenChange(string text)
	{
		if (base.Controls["BoardComms"].Controls[text].InvokeRequired)
		{
			SetTextCallback method = ControlColorDarkGreenChange;
			Invoke(method, text);
		}
		else
		{
			base.Controls["BoardComms"].Controls[text].BackColor = Color.DarkGreen;
		}
	}

	private void ControlColorGreenYellowChange(string text)
	{
		if (base.Controls["BoardComms"].Controls[text].InvokeRequired)
		{
			SetTextCallback method = ControlColorGreenYellowChange;
			Invoke(method, text);
		}
		else
		{
			base.Controls["BoardComms"].Controls[text].BackColor = Color.GreenYellow;
		}
	}

	private void SpeedChangeTM_Tick(object sender, EventArgs e)
	{
		SpeedChange();
	}

	private void SpeedChange()
	{
		byte b = 1;
		if (Display.IOPOTCommsActive)
		{
			ControlColorGreenYellowChange("CommsActiveInd");
		}
		else
		{
			ControlColorDarkGreenChange("CommsActiveInd");
		}
		if (!IOPotError | Display.TestEStop)
		{
			ErrorCorrectionMotor = false;
			short speedByte = SpeedByte;
			b = 1;
			checked
			{
				if (((SpeedIntXHold > speedByte) & (SpeedIntXHold > 0)) | (HoldProgramOp & (SpeedIntXHold > 0)))
				{
					SpeedIntXHold = (byte)unchecked((uint)(SpeedIntXHold - b));
					if (unchecked((uint)SpeedIntXHold < (uint)DeadBand))
					{
						SpeedIntXHold = 0;
					}
				}
				else if (Display.ProgramNumSpeed > 0)
				{
					if (((SpeedIntXHold < speedByte) & (Conversion.Val(MyProject.Forms.Display.Speed_kmh.Text) <= Conversion.Val(MyProject.Forms.Display.MaxSpeedIndkm.Text)) & MyProject.Forms.Display.ConveyorActive) | ((SpeedIntXHold < speedByte) & (Conversion.Val(MyProject.Forms.Display.Speed_kmh.Text) <= Conversion.Val(MyProject.Forms.Display.MaxSpeedIndkm.Text)) & Display.TestEStop))
					{
						if (unchecked((uint)SpeedIntXHold < (uint)DeadBand) & (DeadBand > 0))
						{
							SpeedIntXHold = (byte)(DeadBand - 1);
						}
						if (TreadmillMotorForward | TreadmillMotorReverse | unchecked((uint)SpeedIntXHold <= (uint)DeadBand))
						{
							SpeedIntXHold = (byte)unchecked((uint)(SpeedIntXHold + b));
						}
					}
				}
				else if (((SpeedIntXHold < speedByte) & MyProject.Forms.Display.ConveyorActive) | ((SpeedIntXHold < speedByte) & Display.TestEStop))
				{
					if (unchecked((uint)SpeedIntXHold < (uint)DeadBand) & (DeadBand > 0))
					{
						SpeedIntXHold = (byte)(DeadBand - 1);
					}
					SpeedIntXHold = (byte)unchecked((uint)(SpeedIntXHold + b));
				}
				IndexConstSpeed = (float)(Conversions.ToDouble(Interaction.GetSetting("Treadmill", "ByteSet", "Byte" + SpeedLevel, "0")) / (double)SpeedLevel);
			}
			if ((((float)SetSpeed > SpeedLevel) & ((float)(int)SpeedIntXHold > SpeedLevel * IndexConstSpeed)) | (((float)SetSpeed < SpeedLevel) & ((float)(int)SpeedIntXHold < SpeedLevel * IndexConstSpeed)) | (((float)SetSpeed > SpeedLevel) & (SpeedLevel == 0f)))
			{
				if ((float)SetSpeed > SpeedLevel)
				{
					SpeedLevel += 1f;
				}
				else if ((float)SetSpeed < SpeedLevel)
				{
					SpeedLevel -= 1f;
				}
				SpeedIndkmh = Math.Round((double)SpeedLevel * 0.1, 1);
				SpeedIndmph = Math.Round(SpeedLevel * 100000f / (float)Mile_in_mm, 1);
			}
			if (Operators.CompareString(IndicatorSpeed, ">", TextCompare: false) == 0)
			{
				IndicatorSpeed = "<";
			}
			else
			{
				IndicatorSpeed = ">";
			}
			if (ControlLevel == 0)
			{
				ControlChange("SpeedIntDisplay", "Text", " " + SpeedByte);
			}
			ControlChange("SpeedActual", "Text", IndicatorSpeed.ToString() + " " + SpeedSet);
			if ((SpeedByte > 0) & !Display.Conveyor & Display.ProgramRun)
			{
				Display.Conveyor = true;
				ConveyorControllerOnOff();
				ConveyorOffDispose();
			}
			if ((SpeedByte > 0) & (SpeedIntXHold > 0) & MyProject.Forms.Display.ConveyorActive & (SpeedSet > 0))
			{
				if (!RelayOveride)
				{
					if (!Display.SpeedProgramReverse)
					{
						TreadmillMotorForward = true;
						TreadmillMotorReverse = false;
					}
					else
					{
						TreadmillMotorForward = false;
						TreadmillMotorReverse = true;
					}
				}
			}
			else if ((SpeedByte == 0) & (SpeedIntXHold == 0) & (SpeedSet <= DeadBand) & !RelayOveride & !ConveyorOffTMFlag)
			{
				if (Display.Conveyor)
				{
					ConveyorOffTMFlag = true;
					ConveyorOffTM.Enabled = true;
				}
				TreadmillMotorForward = false;
				TreadmillMotorReverse = false;
			}
		}
		else if (((uint)SpeedIntXHold >= (uint)SpeedByte) & (SpeedIntXHold > 0) & !RelayOveride)
		{
			checked
			{
				SpeedIntXHold--;
				ControlChange("SpeedIntDisplay", "Text", " " + SpeedByte);
				short speedByte = default(short);
				ControlChange("SpeedActual", "Text", " " + speedByte);
				ErrorCorrectionMotor = true;
			}
		}
		SpeedIndication(SpeedLevel);
	}

	private void SpeedIndication(object OpSpeed)
	{
		double num = Conversion.Val(MyProject.Forms.Information.BMR.Text);
		double num2 = 60.0 / ((double)SpeedChangeTM.Interval / 1000.0);
		double num4 = default(double);
		if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreater(OpSpeed, 0, TextCompare: false), Operators.CompareString(Interaction.GetSetting("Dtread", "Setup", "RPMInd" + OpSpeed.ToString(), "E"), "E", TextCompare: false) == 0), Operators.CompareString(Interaction.GetSetting("Health", "Setup", "RPMIndSet"), "True", TextCompare: false) != 0)))
		{
			double num3 = Conversions.ToDouble(Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Conversion.Val(MyProject.Forms.Display.MaxSpeedMilesSet) * Conversion.Val(MyProject.Forms.Display.MilesToKilometersMulti) / 64.0, OpSpeed), 1000000), 60));
			num4 = Math.Round(num3 / (double)DrumCircumference * Conversion.Val(MachineSetup.Gearbox), 0);
		}
		string text = Conversions.ToString(Conversion.Val(Interaction.GetSetting("Dtread", "Setup", "RPMInd" + OpSpeed.ToString(), num4.ToString())));
		double num5 = default(double);
		double num6 = default(double);
		double num7 = default(double);
		if (Conversions.ToDouble(text) > 0.0)
		{
			num5 = Conversion.Val(text) / Conversion.Val(MachineSetup.Gearbox) * (double)DrumCircumference;
			num6 = num5 / 1000.0;
			SpeedIndkmpm = num5 / 1000000.0;
			SpeedIndmpm = num5 / (double)Mile_in_mm;
			SpeedIndkmph = SpeedIndkmpm * 60.0;
			SpeedIndmiph = SpeedIndmpm * 60.0;
			num7 = SpeedIndkmpm / num2;
			double num8 = SpeedIndmpm / num2;
			Distancekm += num7;
			Distancemi += num8;
		}
		else
		{
			SpeedIndkmph = 0.0;
			SpeedIndmiph = 0.0;
		}
		float num9 = 1.44f;
		float num10 = 0.1f;
		if (num7 > 0.0)
		{
			if (Grade < 0.01)
			{
				Grade = 0.01;
			}
			double num11 = ((!(num5 <= 99.16)) ? (0.2 * num6 + 0.9 * num6 * Grade + 3.5) : (0.1 * num6 + 1.8 * num6 * Grade + 3.5));
			double num12 = num11 / 3.5;
			double num13 = 1.0 / 60.0 / num2;
			num9 = 1.44f;
			float num14 = ((!Display.JetOn) ? num9 : (num9 + num10));
			if (num > 0.0)
			{
				double num15 = num / 24.0 * num12 * num13;
				MyProject.Forms.Display.CalorieDry = MyProject.Forms.Display.CalorieDry + num15;
				MyProject.Forms.Display.CalorieWet = MyProject.Forms.Display.CalorieDry * (double)num14;
			}
		}
	}

	public void UpdateBits()
	{
		string expression = ((Conversions.ToDouble(SerialNo) != 1444.0) ? "0,9,12,16,19,22,26,30,33,36,40,43,46,50,53,57,62,65,68,71,76,79,82,86,90,93,97,100,103,107,111,114,118,122,125,128,131,135,139,143,145,147,149,151,153,155,157,159,161,163,165,167,169,171,173,175,177,179,180,182,184,186,188,190,192,193,194,196,197,198,200,202,204,205,207,209,210,211,213,214,215,217,218,219,220,222,224,225,226,228,229,230,231,233,234,235,236,237,239,240,241" : "0,27,30,33,36,39,42,44,47,50,52,55,57,60,63,66,68,71,74,77,79,82,84,87,90,92,95,98,98,103,105,108,111,114,117,120,122,124,126,129,131,134,137,139,141,144,146,149,151,153,155,158,160,163,165,167,169,171,173,174,176,177,179,179,181,182,183,184,186,187,188,190,191,193,194,196,197,198,199,200,202,203,204,205,207,208,209,210,212,213,214,216,217,218,219,220,221,222,223,225,229");
		Interaction.SaveSetting("Treadmill", "ByteSet", "Byte" + Conversions.ToString(0), Conversions.ToString(0));
		Array array = Strings.Split(expression, ",");
		checked
		{
			int num = ((!((DeadBand == 0) | ((double)unchecked((int)DeadBand) == Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { 1 }, null)))))) ? ((int)Math.Round((double)unchecked((int)DeadBand) - Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { 1 }, null))))) : 0);
			Interaction.SaveSetting("Treadmill", "ByteSet", "Byte" + Conversions.ToString(0), "0");
			int num2 = Microsoft.VisualBasic.Information.UBound(array);
			for (int i = 1; i <= num2; i++)
			{
				Interaction.SaveSetting("Treadmill", "ByteSet", "Byte" + i, Conversions.ToString(Operators.AddObject(NewLateBinding.LateIndexGet(array, new object[1] { i }, null), num)));
			}
		}
	}

	public void SetupRPMIndReg()
	{
		float num = Conversions.ToSingle(Interaction.GetSetting("Dtread", "Aqua", "MaxRPM", "2490"));
		float num2 = Conversions.ToSingle(Interaction.GetSetting("DTread", "Aqua", "Gearbox", "8.5"));
		int num3 = checked((int)Math.Round(Conversion.Val(MyProject.Forms.MachineSetup.Maxkph.Text) * 10.0));
		Interaction.SaveSetting("Dtread", "Setup", "RPMInd" + Conversions.ToString(0), "0");
		float num4 = num3;
		for (float num5 = 1f; num5 <= num4; num5 += 1f)
		{
			float num6 = (float)((double)(num5 / 10f) * 16666.666666666668);
			float num7 = num6 / (float)DrumCircumference;
			float num8 = num7 * num2;
			Interaction.SaveSetting("Dtread", "Setup", "RPMInd" + Conversions.ToString(num5), Conversions.ToString(Math.Round(num8, 0)));
		}
	}

	private void SetDegRange_Click(object sender, EventArgs e)
	{
		SetupDegreeReg();
	}

	public void SetupDegreeReg()
	{
		int inclineLevels = MyProject.Forms.Display.InclineLevels;
		Interaction.SaveSetting("Dtread", "Setup", "DegInd" + Conversions.ToString(0), "0");
		float num = inclineLevels;
		for (float num2 = 1f; num2 <= num; num2 += 1f)
		{
			Interaction.SaveSetting("Dtread", "Setup", "DegInd" + Conversions.ToString(num2), Conversions.ToString(num2));
		}
		UpdateBitDeg();
	}

	private void UpdateBitDeg()
	{
		int inclineLevels = MyProject.Forms.Display.InclineLevels;
		checked
		{
			int num = BitResA - DeadBandGrad - 1;
			float num2 = (float)((double)num / (double)inclineLevels);
			Interaction.SaveSetting("Treadmill", "ByteSetDeg", "Byte" + Conversions.ToString(0), Conversions.ToString(DeadBandGrad));
			int num3 = inclineLevels;
			for (int i = 1; i <= num3; i++)
			{
				byte b = (byte)Math.Round(Math.Round((float)unchecked((int)DeadBandGrad) + num2 * (float)i, 0));
				Interaction.SaveSetting("Treadmill", "ByteSetDeg", "Byte" + i, Conversions.ToString(b));
			}
		}
	}

	private void LoadSpeedIntoReg()
	{
		string text = "";
		if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) == 0)
		{
			if (Operators.CompareString(MachineSetup.Gearbox, "5.92", TextCompare: false) == 0)
			{
				text = "0,32,75,114,152,192,230,270,306,344,376,414,448,480,514,448,580,612,640,672,700";
				text += ",732,782,834,885,937,987,1036,1084,1130,1176,1221,1261,1304,1344,1382,1422,1460,1496,1530,1566";
				text += ",1600,1634,1666,1696,1730,1756,1786,1808,1838,1862,1884,1910,1932,1952,1972,1992,2014,2030,2044,2064,2080,2090,2093,2093";
			}
			else if (Operators.CompareString(MachineSetup.Gearbox, "8.5", TextCompare: false) == 0)
			{
				text = "0,18,44,72,96,120,143,172,192,222,242,268,289,315,338,362,380,407,427,447,472";
				text += ",493,518,540,564,588,610,630,656,678,698,728,746,766,790,825,864,902,935,971,1015";
				text += ",1054,1095,1144,1181,1233,1270,1321,1372,1414,1450,1518,1562,1617,1660,1744,1781,1873,1944,1960,2060,2075,2090,2120,2120";
			}
		}
		else if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0)
		{
			if (Operators.CompareString(MachineSetup.Gearbox, "5.92", TextCompare: false) == 0)
			{
				text = "0,32,75,114,152,192,230,270,306,344,376,414,448,480,514,448,580,612,640,672,700";
				text += ",732,782,834,885,937,987,1036,1084,1130,1176,1221,1261,1304,1344,1382,1422,1460,1496,1530,1566";
				text += ",1600,1634,1666,1696,1730,1756,1786,1808,1838,1862,1884,1910,1932,1952,1972,1992,2014,2030,2044,2064,2080,2090,2093,2093";
			}
			else if (Operators.CompareString(MachineSetup.Gearbox, "8.5", TextCompare: false) == 0)
			{
				text = "0,0,0,0,0,0,12,31,53,75,95,116,141,160,188,206,227,248,271,292,315,336,360,379,400,424,446,468,490,512,538,560,580";
				text += ",605,630,653,678,701,727,747,777,800,828,870,900,955,1035,1072,1122,1170,1220,1266,1315,1368,1420,1476,1530";
				text += ",1600,1666,1725,1800,1870,1935,2007";
			}
		}
		if (Operators.CompareString(text, "", TextCompare: false) != 0)
		{
			string[] array = Strings.Split(text, ",");
			int num = Microsoft.VisualBasic.Information.UBound(array);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				Interaction.SaveSetting("Dtread", "Setup", "RPMInd" + Conversions.ToString(i), array[i]);
			}
		}
	}

	private void MpmIndLevel(object Level)
	{
		float num = Conversions.ToSingle(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[2]
		{
			Operators.DivideObject(Operators.MultiplyObject(Level, 100), 60),
			1
		}, null, null, null).ToString());
		MpmIndChange(num.ToString());
		if (num >= 100f)
		{
			MeterChange("Meter * 100");
		}
		else
		{
			MeterChange("Meter * 10");
		}
		MpmMeterChange(num.ToString());
	}

	private void UpLevelSpeed_Click(object sender, EventArgs e)
	{
		ControlChange("InitialReg", "Visible", "False");
		checked
		{
			if (Levels < MyProject.Forms.Display.DisplayLevels)
			{
				Levels++;
			}
			ActualLevelIndSpeedChange(Conversions.ToString(Levels));
			MpmIndLevel(Levels);
			ControlChange("SpeedIntDisplay", "Text", Conversions.ToString(Levels));
			SpeedByte = Conversions.ToByte(Interaction.GetSetting("Treadmill", "ByteSet", "Byte" + Levels, "0"));
			RPMIndChange(Interaction.GetSetting("Dtread", "Setup", "RPMInd" + Levels, "E"));
			SpeedIntXHold = SpeedByte;
			if ((Levels >= 1) & Display.ProgramRun)
			{
				ConveyorOffDispose();
				Display.Conveyor = true;
				ConveyorControllerOnOff();
			}
		}
	}

	private void DownLevelSpeed_Click(object sender, EventArgs e)
	{
		ControlChange("InitialReg", "Visible", "False");
		if (Conversion.Val(Levels) > 0.0)
		{
			Levels = checked((int)Math.Round(Conversion.Val(Levels) - 1.0));
		}
		ActualLevelIndSpeedChange(Conversions.ToString(Levels));
		MpmIndLevel(Levels);
		ControlChange("SpeedIntDisplay", "Text", Conversions.ToString(Levels));
		SpeedByte = Conversions.ToByte(Interaction.GetSetting("Treadmill", "ByteSet", "Byte" + Levels, "0"));
		RPMIndChange(Interaction.GetSetting("Dtread", "Setup", "RPMInd" + Levels, "E"));
		SpeedIntXHold = SpeedByte;
		if ((Conversion.Val(Levels) <= 0.0) & !RelayOveride & !Display.ProgramRun)
		{
			if (Display.Conveyor & !ConveyorOffTMFlag)
			{
				ConveyorOffTM.Enabled = true;
			}
			TreadmillMotorForward = false;
			TreadmillMotorReverse = false;
		}
	}

	public void ZeroSpeed()
	{
		ControlChange("InitialReg", "Visible", "False");
		if (Conversion.Val(Levels) > 0.0)
		{
			Levels = 0;
		}
		ActualLevelIndSpeedChange(Conversions.ToString(Levels));
		ControlChange("SpeedIntDisplay", "Text", Conversions.ToString(Levels));
		SpeedByte = Conversions.ToByte(Interaction.GetSetting("Treadmill", "ByteSet", "Byte" + Levels, "0"));
		RPMIndChange(Interaction.GetSetting("Dtread", "Setup", "RPMInd" + Levels, "E"));
		SpeedLevel = 0f;
		SpeedIntXHold = SpeedByte;
		if (!Display.ProgramRun & Display.Conveyor & !ConveyorOffTMFlag)
		{
			ConveyorOffTM.Enabled = true;
		}
		if (RelayA)
		{
			RLYASpeedOperate();
		}
		if (RelayB)
		{
			RLYBSpeedOperate();
		}
		if (RelayE)
		{
			RLYEKeyOperate();
		}
	}

	private void UpSpeed_Click(object sender, EventArgs e)
	{
		ControlChange("InitialReg", "Visible", "False");
		if (Levels == 0)
		{
			SpeedByte = 0;
			ControlChange("SpeedIntDisplay", "Text", SpeedByte.ToString());
			Interaction.SaveSetting("Treadmill", "ByteSet", "Byte" + Levels, SpeedByte.ToString());
			SpeedIntXHold = SpeedByte;
			return;
		}
		checked
		{
			if (SpeedByte < BitResS)
			{
				SpeedByte++;
			}
			SpeedIntXHold = SpeedByte;
			ControlChange("SpeedIntDisplay", "Text", SpeedByte.ToString());
			Interaction.SaveSetting("Treadmill", "ByteSet", "Byte" + Levels, SpeedByte.ToString());
			if ((SpeedByte >= 1) & Display.ProgramRun)
			{
				ConveyorOffDispose();
				Display.Conveyor = true;
				ConveyorControllerOnOff();
			}
		}
	}

	private void DownSpeed_Click(object sender, EventArgs e)
	{
		ControlChange("InitialReg", "Visible", "False");
		checked
		{
			if (SpeedByte > 0)
			{
				SpeedByte--;
			}
			SpeedIntXHold = SpeedByte;
			ControlChange("SpeedIntDisplay", "Text", SpeedByte.ToString());
			Interaction.SaveSetting("Treadmill", "ByteSet", "Byte" + Levels, SpeedByte.ToString());
			if (SpeedByte <= 0)
			{
				if (!ConveyorOffTMFlag & Display.Conveyor)
				{
					ConveyorOffTM.Enabled = true;
				}
				TreadmillMotorForward = false;
				TreadmillMotorReverse = false;
			}
		}
	}

	private void ZeroAll()
	{
		ZeroDeg();
		ZeroSpeed();
	}

	private void BoardCommsNo_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "CommsIOPot";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void DeadbandSet_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "DeadbandSet";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void DeadbandGradSet_Click(object sender, EventArgs e)
	{
	}

	private void CommsSetting()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, checked(base.Top + base.Height));
		Invisible.Visible = false;
		switch (ItemName)
		{
		case "DeadbandSet":
			if (Operators.CompareString(DeadbandSet.Text, "", TextCompare: false) == 0)
			{
				DeadbandSetChange("0");
			}
			MyProject.Forms.InfoEnter.Preload = DeadbandSet.Text;
			InfoEnter.PasswordSet = DeadbandSet.Text;
			break;
		case "DeadbandGradSet":
			if (Operators.CompareString(DeadBandGradSet.Text, "", TextCompare: false) == 0)
			{
				DeadbandGradSetChange("0");
			}
			MyProject.Forms.InfoEnter.Preload = DeadBandGradSet.Text;
			InfoEnter.PasswordSet = DeadBandGradSet.Text;
			break;
		case "RPMInd":
			if (Operators.CompareString(RPMInd.Text, "", TextCompare: false) == 0)
			{
				RPMIndChange("0");
			}
			MyProject.Forms.InfoEnter.Preload = RPMInd.Text;
			InfoEnter.PasswordSet = RPMInd.Text;
			break;
		case "InclineByteDisplay":
			if (Operators.CompareString(InclineByteDisplay.Text, "", TextCompare: false) == 0)
			{
				ControlChange("InclineByteDisplay", "Text", " 0");
			}
			MyProject.Forms.InfoEnter.Preload = InclineByteDisplay.Text;
			InfoEnter.PasswordSet = InclineByteDisplay.Text;
			break;
		case "SpeedIntDisplay":
			if (Operators.CompareString(SpeedIntDisplay.Text, "", TextCompare: false) == 0)
			{
				ControlChange("SpeedIntDisplay", "Text", " 0");
			}
			MyProject.Forms.InfoEnter.Preload = SpeedIntDisplay.Text;
			InfoEnter.PasswordSet = SpeedIntDisplay.Text;
			break;
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		switch (ItemName)
		{
		case "DeadbandSet":
			DeadbandSet.TextAlign = HorizontalAlignment.Left;
			DeadbandSetChange(InfoEnter.PasswordSet);
			break;
		case "DeadbandGradSet":
			DeadBandGradSet.TextAlign = HorizontalAlignment.Left;
			DeadbandGradSetChange(InfoEnter.PasswordSet);
			break;
		case "RPMInd":
			RPMIndChange(InfoEnter.PasswordSet);
			RPMInd.TextAlign = HorizontalAlignment.Left;
			break;
		case "InclineByteDisplay":
			ControlChange("InclineByteDisplay", "Text", " " + InfoEnter.PasswordSet);
			InclineByteDisplay.TextAlign = HorizontalAlignment.Left;
			break;
		case "SpeedIntDisplay":
			ControlChange("SpeedIntDisplay", "Text", " " + InfoEnter.PasswordSet);
			SpeedIntDisplay.TextAlign = HorizontalAlignment.Left;
			break;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		checked
		{
			switch (ItemName)
			{
			case "InclineByteDisplay":
				if (Operators.CompareString(InclineByteDisplay.Text, "", TextCompare: false) == 0)
				{
					ControlChange("InclineByteDisplay", "Text", "0");
					break;
				}
				if (Conversion.Val(InclineByteDisplay.Text) > (double)BitResA)
				{
					ControlChange("InclineByteDisplay", "Text", "255");
				}
				ControlChange("InclineByteDisplay", "Text", Conversions.ToString(Conversion.Val(InclineByteDisplay.Text)));
				InclineByte = (byte)Math.Round(Conversion.Val(InclineByteDisplay.Text));
				Interaction.SaveSetting("Treadmill", "ByteSetDeg", "Byte" + SetIncline, InclineByte.ToString());
				break;
			case "SpeedIntDisplay":
				if (Operators.CompareString(SpeedIntDisplay.Text, "", TextCompare: false) == 0)
				{
					ControlChange("SpeedIntDisplay", "Text", "0");
					break;
				}
				if (Conversion.Val(SpeedIntDisplay.Text) > 255.0)
				{
					ControlChange("SpeedIntDisplay", "Text", "255");
				}
				ControlChange("SpeedIntDisplay", "Text", Conversions.ToString(Conversion.Val(SpeedIntDisplay.Text)));
				SpeedByte = (byte)Math.Round(Conversion.Val(SpeedIntDisplay.Text));
				Interaction.SaveSetting("Treadmill", "ByteSet", "Byte" + Levels, SpeedByte.ToString());
				break;
			case "DeadbandSet":
				if (Operators.CompareString(DeadbandSet.Text, "", TextCompare: false) == 0)
				{
					DeadbandSetChange("1");
					Interaction.SaveSetting("Health", "Setup", "DeadbandSet", "1");
				}
				else
				{
					if (Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandSet", "1")) > 100.0)
					{
						Interaction.SaveSetting("Health", "Setup", "DeadbandSet", "100");
						DeadbandSetChange(Interaction.GetSetting("Health", "Setup", "DeadbandSet", "1"));
					}
					DeadbandSetChange(Conversions.ToString(Conversion.Val(DeadbandSet.Text)));
					Interaction.SaveSetting("Health", "Setup", "DeadbandSet", DeadbandSet.Text);
				}
				DeadBand = (byte)Math.Round(Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandSet", "0")));
				break;
			case "DeadbandGradSet":
				if (Operators.CompareString(DeadBandGradSet.Text, "", TextCompare: false) == 0)
				{
					DeadbandGradSetChange("0");
					Interaction.SaveSetting("Health", "Setup", "DeadbandGradSet", "0");
				}
				else
				{
					if (Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandGradSet", "0")) != Conversion.Val(DeadBandGradSet.Text))
					{
						ControlChange("InitialRegDeg", "Visible", "True");
					}
					DeadbandGradSetChange(Conversions.ToString(Conversion.Val(DeadBandGradSet.Text)));
					Interaction.SaveSetting("Health", "Setup", "DeadbandGradSet", DeadBandGradSet.Text);
				}
				DeadBandGrad = (byte)Math.Round(Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandGradSet", "0")));
				break;
			}
			MyProject.Forms.InfoEnter.Preload = "";
			InfoEnter.PasswordSet = "";
			InfoEnterTM.Dispose();
			ControlLevel = 0;
			Invisible.Visible = true;
		}
	}

	private void BoardCommsNo_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("BoardComms", "CommsNoRelayPotLb", "Focus", "Set");
	}

	private void IOPOT_Activated(object sender, EventArgs e)
	{
		checked
		{
			DeadBand = (byte)Math.Round(Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandSet", "0")));
			if (DeadBand > 100)
			{
				DeadBand = 100;
				Interaction.SaveSetting("Health", "Setup", "DeadbandSet", "100");
			}
			DeadbandSetChange(DeadBand.ToString());
			DeadBandGrad = (byte)Math.Round(Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandGradSet", "1")));
			DeadbandGradSetChange(DeadBandGrad.ToString());
		}
	}

	public void ProgramReset()
	{
		UpdateSpeed(0, Hold: false, ResetProg: true);
		UpdateGradient(0, Hold: false, ResetProg: true);
	}

	private void InclineByteDisplay_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "InclineByteDisplay";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void SpeedIntDisplay_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "SpeedIntDisplay";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void RPMLb_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "RPMInd";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void RPMInd_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "RPMInd";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	public void UpdateSpeed(int Index, bool Hold, bool ResetProg)
	{
		checked
		{
			if (Hold)
			{
				HoldProgramOp = true;
				SetSpeed = (int)Math.Round(Math.Round(Conversion.Val(Interaction.GetSetting("Treadmill", "Speed", "0", "0")), 0));
			}
			else
			{
				HoldProgramOp = false;
				SetSpeed = (int)Math.Round(Math.Round(Conversion.Val(Interaction.GetSetting("Treadmill", "Speed", Index.ToString(), "0")), 0));
			}
			if (ResetProg)
			{
				ResetProgram = true;
			}
			else
			{
				ResetProgram = false;
			}
			if (SetSpeed > 0)
			{
				SpeedDisplay = ((double)SetSpeed / 10.0).ToString("n1");
				MyProject.Forms.Display.SSLLabelChange(SpeedDisplay + " " + MyProject.Forms.Display.kmhLabelSP.Text);
			}
			else
			{
				SpeedDisplay = "0.0";
				MyProject.Forms.Display.SSLLabelChange(SpeedDisplay + " " + MyProject.Forms.Display.kmhLabelSP.Text);
			}
			ActualLevelIndSpeedChange(Conversions.ToString(SetSpeed));
			SetByte = Conversions.ToByte(Interaction.GetSetting("Treadmill", "ByteSet", "Byte" + SetSpeed, Conversions.ToString(0)));
			RPMIndChange(Interaction.GetSetting("Dtread", "Setup", "RPMInd" + SetSpeed, "E"));
			SpeedByte = Convert.ToByte(Math.Round(new decimal(SetByte), 0));
		}
	}

	private void Invisible_Click(object sender, EventArgs e)
	{
		Hide();
		ControlChange("InitialReg", "Visible", "False");
		ControlChange("InitialRegDeg", "Visible", "False");
		ControlChange("SetDegRange", "Visible", "False");
		ZeroAll();
		RelayOveride = false;
		RelayOverideSwChange("Relays Off");
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
			ZeroAll();
			RelayOveride = false;
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

	private void OutputsTM_Tick(object sender, EventArgs e)
	{
		if (!RelayOveride & !Display.TestEStop)
		{
			if ((!TreadmillMotorForward & RLA) | (TreadmillMotorForward & !RLA))
			{
				if (TreadmillMotorForward)
				{
					MotorForwardTM.Enabled = true;
					RLA = true;
				}
				else
				{
					MotorForward();
					RLA = false;
				}
			}
			if ((!TreadmillMotorReverse & RLB) | (TreadmillMotorReverse & !RLB))
			{
				if (TreadmillMotorReverse)
				{
					MotorReverseTM.Enabled = true;
					RLB = true;
				}
				else
				{
					MotorReverse();
					RLB = false;
				}
			}
		}
		else
		{
			if ((!RelayA & RLA) | (RelayA & !RLA))
			{
				MotorForward();
				RLA = RelayA;
			}
			if ((!RelayB & RLB) | (RelayB & !RLB))
			{
				MotorReverse();
				RLB = RelayB;
			}
		}
		if (!RLA)
		{
			RLYASpeedColorChange("DarkGray");
		}
		else
		{
			RLYASpeedColorChange("Green");
		}
		if (!RLB)
		{
			RLYBSpeedColorChange("DarkGray");
		}
		else
		{
			RLYBSpeedColorChange("Green");
		}
	}

	private void RLYASpeedColorChange(string text)
	{
		if (RLYASpeed.InvokeRequired)
		{
			SetTextCallback method = RLYASpeedColorChange;
			Invoke(method, text);
		}
		else if (Operators.CompareString(text, "Green", TextCompare: false) != 0)
		{
			if (Operators.CompareString(text, "DarkGray", TextCompare: false) == 0)
			{
				RLYASpeed.BackColor = Color.DarkGray;
			}
		}
		else
		{
			RLYASpeed.BackColor = Color.Green;
		}
	}

	private void RLYBSpeedColorChange(string text)
	{
		if (RLYBSpeed.InvokeRequired)
		{
			SetTextCallback method = RLYBSpeedColorChange;
			Invoke(method, text);
		}
		else if (Operators.CompareString(text, "Green", TextCompare: false) != 0)
		{
			if (Operators.CompareString(text, "DarkGray", TextCompare: false) == 0)
			{
				RLYBSpeed.BackColor = Color.DarkGray;
			}
		}
		else
		{
			RLYBSpeed.BackColor = Color.Green;
		}
	}

	private void CommsNoRelayPotLb_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "CommsIOPot";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void UPGrad_Click(object sender, EventArgs e)
	{
		UpGradBit();
	}

	public void UpBit()
	{
		DeadbandGradSetChange(InclineByte.ToString());
		UpGradBit();
		DeadbandGradSetChange(InclineByte.ToString());
	}

	private void UpGradBit()
	{
		if (InclineByte >= BitResA)
		{
			return;
		}
		checked
		{
			InclineByte++;
			Interaction.SaveSetting("Treadmill", "ByteSetDeg", "Byte" + Conversions.ToString(SetIncline), Conversions.ToString(InclineByte));
		}
		if ((Operators.CompareString(ActualLevelIndGradient.Text, "0", TextCompare: false) == 0) & (InclineByte >= 0))
		{
			if ((uint)InclineByte > (uint)Conversions.ToByte(Interaction.GetSetting("Health", "Setup", "DeadbandGradSet", "0")))
			{
				SetDeadBand();
			}
			ControlChange("InitialRegDeg", "Visible", "True");
		}
	}

	private void DownGrad_Click(object sender, EventArgs e)
	{
		DownGradBit();
	}

	public void DownBit()
	{
		DeadbandGradSetChange(InclineByte.ToString());
		DownGradBit();
		DeadbandGradSetChange(InclineByte.ToString());
	}

	private void DownGradBit()
	{
		if (InclineByte <= 0)
		{
			return;
		}
		checked
		{
			InclineByte--;
			Interaction.SaveSetting("Treadmill", "ByteSetDeg", "Byte" + Conversions.ToString(SetIncline), Conversions.ToString(InclineByte));
		}
		if ((Operators.CompareString(ActualLevelIndGradient.Text, "0", TextCompare: false) == 0) & (InclineByte >= 0))
		{
			if ((uint)InclineByte > (uint)Conversions.ToByte(Interaction.GetSetting("Health", "Setup", "DeadbandGradSet", "0")))
			{
				SetDeadBand();
			}
			ControlChange("InitialRegDeg", "Visible", "True");
		}
	}

	private void GradientChangeTM_Tick(object sender, EventArgs e)
	{
		GradientChange();
	}

	public void GradientChange()
	{
		if ((!IOPotError & !HoldProgramOp) | (!IOPotError & ResetProgram) | (Display.TestEStop & !HoldProgramOp) | (Display.TestEStop & ResetProgram))
		{
			short inclineByte = InclineByte;
			checked
			{
				if ((GradientIntXHold > inclineByte) & (GradientIntXHold > 0))
				{
					GradientIntXHold--;
				}
				else if ((GradientIntXHold < inclineByte) & (GradientIntXHold < BitResA))
				{
					GradientIntXHold++;
				}
			}
			if ((MaxGradient > 0.0) & (GradientIntXHold > 0))
			{
				Grade = MaxGradient / (double)(int)GradientIntXHold / 100.0;
			}
			else
			{
				Grade = 0.01;
			}
			if (Operators.CompareString(IndicatorGrad, ">", TextCompare: false) == 0)
			{
				IndicatorGrad = "<";
			}
			else
			{
				IndicatorGrad = ">";
			}
			if ((IndexIncline >= IndexConstIncline) | (((float)SetIncline > InclineIndex) & ((float)(int)GradientIntXHold > InclineIndex * IndexConstIncline)) | (((float)SetIncline < InclineIndex) & ((float)(int)GradientIntXHold < InclineIndex * IndexConstIncline)))
			{
				if (IndexIncline >= IndexConstIncline)
				{
					IndexIncline = (float)Math.Round(IndexIncline - IndexConstIncline, 2);
				}
				if ((float)SetIncline > InclineIndex)
				{
					InclineIndex += 1f;
				}
				else if ((float)SetIncline < InclineIndex)
				{
					InclineIndex -= 1f;
				}
			}
			else
			{
				IndexIncline += 1f;
			}
			if (ControlLevel == 0)
			{
				ControlChange("InclineByteDisplay", "Text", " " + InclineByte);
			}
			ControlChange("InclineActualByte", "Text", IndicatorGrad + " " + InclineByteSet);
			ActualLevelIndGradientChange(Conversions.ToString(SetIncline));
			if (!MyProject.Forms.Display.LevelZero)
			{
				MyProject.Forms.Display.InclineActualChange(Functions.NumberToString((float)Conversion.Val(Math.Round(Conversion.Val(InclineIndex / 10f), 1)), 1));
			}
			short num = checked((short)Math.Round(Math.Round(MyProject.Forms.Display.MaxInclineDeg, 1) * 10.0));
			float num2 = (float)Conversion.Val(MyProject.Forms.Display.InclinePercentage.Text);
			GradientPlusIndChange(Conversions.ToString(Math.Round(num2 / (float)num * InclineIndex, 2)));
			if (((uint)GradientIntXHold > (uint)DeadBandGrad) | MyProject.Forms.Display.LevelZero)
			{
				Display.Actuator = true;
				ActuatorControllerOnOffInd();
				MyProject.Forms.Display.InclineFault = false;
			}
			else
			{
				GetInclinePositionOK();
				if ((((uint)GradientIntXHold <= (uint)DeadBandGrad) & InclinePositionOK & !RelayOveride) | (((uint)GradientIntXHold <= (uint)DeadBandGrad) & Display.TestEStop))
				{
					GradientPowerOffTM.Dispose();
					InclineFaultTM.Dispose();
					MyProject.Forms.Display.InclineFault = false;
					if (Display.Actuator)
					{
						Display.Actuator = false;
						ActuatorControllerOnOffInd();
						if (!ActuatorDelayOff)
						{
							ActuatorPowerOffDelay.Enabled = true;
							ActuatorDelayOff = true;
						}
					}
				}
				else
				{
					GradientPowerOffTM.Dispose();
					if (((uint)GradientIntXHold <= (uint)DeadBandGrad) & Display.Actuator & !RelayOveride)
					{
						if (!InclineFaultTM.Enabled)
						{
							InclineFaultTM.Enabled = true;
						}
					}
					else
					{
						InclineFaultTM.Dispose();
					}
				}
			}
		}
		else
		{
			GradientPowerOffTM.Enabled = true;
		}
		InclineOk();
	}

	public void GetInclinePositionOK()
	{
		if (Conversions.ToBoolean(Interaction.GetSetting("Dtread", "RLY88", "Actuator", Conversions.ToString(Value: false))) | Conversions.ToBoolean(Interaction.GetSetting("Dtread", "RLY816", "Actuator", Conversions.ToString(Value: false))))
		{
			InclinePositionOK = true;
		}
		else
		{
			InclinePositionOK = false;
		}
	}

	public void UpdateGradient(int Index, bool Hold, bool ResetProg)
	{
		checked
		{
			if (MachineSetup.InclineDisplayOnOff)
			{
				SetIncline = (int)Math.Round(Conversion.Val(Interaction.GetSetting("Treadmill", "GradientPlus", Index.ToString(), Conversions.ToString(0))));
				InclineByte = (byte)Math.Round(Conversion.Val(Interaction.GetSetting("Treadmill", "ByteSetDeg", "Byte" + SetIncline, "0")));
				if (ResetProg)
				{
					ResetProgram = true;
				}
				else
				{
					ResetProgram = false;
				}
				DegIndChange(Conversions.ToString(Math.Round(Conversion.Val(Interaction.GetSetting("Dtread", "Setup", "DegInd" + Conversions.ToString(SetIncline), "E")) / 10.0, 1)));
				if (SetIncline > 0)
				{
					MyProject.Forms.Display.GSLLabelChange(((double)SetIncline / 10.0).ToString("n1") + " " + MyProject.Forms.Display.DegLabel.Text);
				}
				else
				{
					MyProject.Forms.Display.GSLLabelChange("0.0 " + MyProject.Forms.Display.DegLabel.Text);
				}
				if (!GradientChangeTM.Enabled)
				{
					UpdateInclineTM();
				}
			}
		}
	}

	private void UpdateInclineTM()
	{
		GradientChangeTM.Interval = 100;
		GradientChangeTM.Enabled = true;
	}

	private void InclineFaultTM_Tick(object sender, EventArgs e)
	{
		InclineFaultTM.Dispose();
		Display.Actuator = false;
		MyProject.Forms.Display.InclineFault = true;
		ActuatorControllerOnOffInd();
	}

	private void LearnSW_Click(object sender, EventArgs e)
	{
		if (!Display.ProgramRun & !LearnAcc & !Display.CleanOn & !Display.Actuator)
		{
			RelayOveride = true;
			RelayOverideSwChange("Relays On");
			LearnOn();
		}
	}

	public void LearnOn()
	{
		if (!Display.ProgramRun & !LearnOp & !Display.CleanOn & !Display.Actuator)
		{
			InclineLearnSw(true);
			Learn();
		}
	}

	private void Learn()
	{
		LearnOpTM.Interval = 1000;
		LearnOpTM.Enabled = true;
		Display.Actuator = true;
		ActuatorControllerOnOffInd();
	}

	private void LearnOpTM_Tick(object sender, EventArgs e)
	{
		InclineOk();
		if (!LearnOp)
		{
			if (MyProject.Forms.Display.RLY08.CommsActive)
			{
				MyProject.Forms.Display.RLY08.InclineLearn = true;
				if (MyProject.Forms.Display.RLY08.LearnOnOff)
				{
					LearnOp = true;
				}
			}
			else
			{
				MyProject.Forms.Display.RLY04.InclineLearn = true;
				if (MyProject.Forms.Display.RLY04.LearnOnOff)
				{
					LearnOp = true;
				}
			}
		}
		else
		{
			GetInclinePositionOK();
			if (InclinePositionOK & InclinePositionMoved)
			{
				LearnOff();
			}
			else if (LearnAcc)
			{
				if (MyProject.Forms.Display.RLY08.CommsActive)
				{
					if (MyProject.Forms.Display.RLY08.InclineLearn & InclinePositionMoved)
					{
						MyProject.Forms.Display.RLY08.InclineLearn = false;
					}
				}
				else if (MyProject.Forms.Display.RLY04.InclineLearn & InclinePositionMoved)
				{
					MyProject.Forms.Display.RLY04.InclineLearn = false;
				}
			}
			else
			{
				LearnAcc = true;
			}
			if (!InclinePositionOK)
			{
				InclinePositionMoved = true;
			}
		}
		if (LearnMaxTime >= 270)
		{
			LearnOff();
			LearnMaxTime = 0;
		}
		checked
		{
			LearnMaxTime++;
		}
	}

	private void LearnOff()
	{
		InclinePositionMoved = false;
		LearnOpTM.Dispose();
		LearnOp = false;
		LearnAcc = false;
		if (MyProject.Forms.Display.RLY08.CommsActive)
		{
			MyProject.Forms.Display.RLY08.InclineLearn = false;
		}
		else
		{
			MyProject.Forms.Display.RLY04.InclineLearn = false;
		}
		InclineLearnSw(false);
		RelayOveride = false;
		LearnMaxTime = 0;
		GradientPowerOffTM.Dispose();
		if (Display.Actuator)
		{
			Display.Actuator = false;
			if (!ActuatorDelayOff)
			{
				ActuatorPowerOffDelay.Enabled = true;
				ActuatorDelayOff = true;
			}
		}
		ActuatorControllerOnOffInd();
	}

	private void InclineLearnSw(object Data)
	{
		if (Operators.ConditionalCompareObjectEqual(Data, false, TextCompare: false))
		{
			InclineLearnSwColorChange("DarkGray");
		}
		else
		{
			InclineLearnSwColorChange("Green");
		}
	}

	private void InclineLearnSwColorChange(string text)
	{
		if (LearnSW.InvokeRequired)
		{
			SetTextCallback method = InclineLearnSwColorChange;
			Invoke(method, text);
		}
		else if (Operators.CompareString(text, "Green", TextCompare: false) != 0)
		{
			if (Operators.CompareString(text, "DarkGray", TextCompare: false) == 0)
			{
				LearnSW.BackColor = Color.DarkGray;
			}
		}
		else
		{
			LearnSW.BackColor = Color.Green;
		}
	}

	private void InclineOk()
	{
		GetInclinePositionOK();
		if (InclinePositionOK)
		{
			InclinePositionIndColorChange("Green");
			MyProject.Forms.Display.InclinePositionIndColorChange("DarkGreen");
		}
		else
		{
			InclinePositionIndColorChange("DarkGray");
			MyProject.Forms.Display.InclinePositionIndColorChange("Normal");
		}
	}

	private void InclinePositionIndColorChange(string text)
	{
		if (InclinePositionInd.InvokeRequired)
		{
			SetTextCallback method = InclinePositionIndColorChange;
			Invoke(method, text);
		}
		else if (Operators.CompareString(text, "Green", TextCompare: false) != 0)
		{
			if (Operators.CompareString(text, "DarkGray", TextCompare: false) == 0)
			{
				InclinePositionInd.BackColor = Color.DarkGray;
			}
		}
		else
		{
			InclinePositionInd.BackColor = Color.Green;
		}
	}

	private void ResetStopSW_Click(object sender, EventArgs e)
	{
		if (!Display.ProgramRun & !StopResetRLY & !Display.CleanOn)
		{
			if (LearnMaxTime == 0)
			{
				RelayOveride = true;
				RelayOverideSwChange("Relays On");
				StopReset();
			}
			else
			{
				LearnOff();
			}
		}
	}

	public void StopReset()
	{
		LearnOff();
		Display.Actuator = true;
		ActuatorControllerOnOffInd();
		if (!StopResetRLY)
		{
			StopResetOp();
		}
		StopResetTM.Enabled = true;
	}

	private void StopResetTM_Tick(object sender, EventArgs e)
	{
		if (StopResetRLY)
		{
			StopResetOp();
		}
		if (LearnOp)
		{
			LearnAcc = true;
			StopResetTM.Dispose();
			return;
		}
		GetInclinePositionOK();
		if (InclinePositionOK | !Display.EmergencyStop)
		{
			StopResetTM.Dispose();
			if (Display.Actuator)
			{
				Display.Actuator = false;
				if (!ActuatorDelayOff)
				{
					ActuatorPowerOffDelay.Enabled = true;
					ActuatorDelayOff = true;
				}
			}
			GradientPowerOffTM.Dispose();
			ActuatorControllerOnOffInd();
		}
		else if (!GradientPowerOffTM.Enabled)
		{
			GradientPowerOffTM.Interval = 30000;
			GradientPowerOffTM.Enabled = true;
		}
	}

	private void StopResetOp()
	{
		if (!StopResetRLY)
		{
			StopResetRLY = true;
			ResetStopSWColorChange("Green");
		}
		else
		{
			StopResetRLY = false;
			ResetStopSWColorChange("DarkGray");
		}
		if (MyProject.Forms.Display.RLY08.CommsActive)
		{
			MyProject.Forms.Display.RLY08.InclineReset = StopResetRLY;
		}
		else
		{
			MyProject.Forms.Display.RLY04.InclineReset = StopResetRLY;
		}
	}

	private void ResetStopSWColorChange(string text)
	{
		if (ResetStopSW.InvokeRequired)
		{
			SetTextCallback method = ResetStopSWColorChange;
			Invoke(method, text);
		}
		else if (Operators.CompareString(text, "Green", TextCompare: false) != 0)
		{
			if (Operators.CompareString(text, "DarkGray", TextCompare: false) == 0)
			{
				ResetStopSW.BackColor = Color.DarkGray;
			}
		}
		else
		{
			ResetStopSW.BackColor = Color.Green;
		}
	}

	private void ConveyorOffTM_Tick(object sender, EventArgs e)
	{
		ConveyorOffDispose();
		Display.Conveyor = false;
		ConveyorControllerOnOff();
	}

	private void ConveyorOffDispose()
	{
		ConveyorOffTMFlag = false;
		ConveyorOffTM.Dispose();
	}

	private void GradientPowerOffTM_Tick(object sender, EventArgs e)
	{
		GradientPowerOffTM.Dispose();
		if (RelayOveride)
		{
			return;
		}
		if (Display.Actuator)
		{
			Display.Actuator = false;
			if (!ActuatorDelayOff)
			{
				ActuatorPowerOffDelay.Enabled = true;
				ActuatorDelayOff = true;
			}
			ActuatorControllerOnOffInd();
		}
		StopResetTM.Dispose();
	}

	private void SpeedIntDisplayChangeA(string text)
	{
		if (SpeedIntDisplay.InvokeRequired)
		{
			SetTextCallback method = SpeedIntDisplayChangeA;
			Invoke(method, text);
		}
		else
		{
			SpeedIntDisplay.Text = text;
		}
	}

	private void SpeedActualChangeA(string text)
	{
		if (SpeedActual.InvokeRequired)
		{
			SetTextCallback method = SpeedActualChangeA;
			Invoke(method, text);
		}
		else
		{
			SpeedActual.Text = text;
		}
	}

	private void DeadbandSetChange(string text)
	{
		if (DeadbandSet.InvokeRequired)
		{
			SetTextCallback method = DeadbandSetChange;
			Invoke(method, text);
		}
		else
		{
			DeadbandSet.Text = text;
		}
	}

	private void DeadbandGradSetChange(string text)
	{
		if (DeadBandGradSet.InvokeRequired)
		{
			SetTextCallback method = DeadbandGradSetChange;
			Invoke(method, text);
		}
		else
		{
			DeadBandGradSet.Text = text;
		}
	}

	private void RPMIndChange(string text)
	{
		if (RPMInd.InvokeRequired)
		{
			SetTextCallback method = RPMIndChange;
			Invoke(method, text);
		}
		else
		{
			RPMInd.Text = text;
		}
	}

	private void InclineByteDisplayChange(string text)
	{
		if (InclineByteDisplay.InvokeRequired)
		{
			SetTextCallback method = InclineByteDisplayChange;
			Invoke(method, text);
		}
		else
		{
			InclineByteDisplay.Text = text;
		}
	}

	private void DegIndChange(string text)
	{
		if (DegInd.InvokeRequired)
		{
			SetTextCallback method = DegIndChange;
			Invoke(method, text);
		}
		else
		{
			DegInd.Text = text;
		}
	}

	private void GradientPlusIndChange(string text)
	{
		if (GradientPlusInd.InvokeRequired)
		{
			SetTextCallback method = GradientPlusIndChange;
			Invoke(method, text);
		}
		else
		{
			GradientPlusInd.Text = text;
		}
	}

	public void ControlChange(string ControlName, string Setting, string Data)
	{
		if (base.Controls[ControlName].InvokeRequired)
		{
			SetControl2Callback method = ControlChange;
			Invoke(method, ControlName, Setting, Data);
			return;
		}
		checked
		{
			switch (Setting)
			{
			case "Text":
				base.Controls[ControlName].Text = Data;
				break;
			case "Visible":
				if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
				{
					base.Controls[ControlName].Visible = false;
				}
				else
				{
					base.Controls[ControlName].Visible = true;
				}
				break;
			case "Enabled":
				if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
				{
					base.Controls[ControlName].Enabled = false;
				}
				else
				{
					base.Controls[ControlName].Enabled = true;
				}
				break;
			case "Height":
				base.Controls[ControlName].Height = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Width":
				base.Controls[ControlName].Width = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Top":
				base.Controls[ControlName].Top = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Left":
				base.Controls[ControlName].Left = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Font":
				base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, (float)Conversion.Val(Data));
				break;
			case "Focus":
				base.Controls[ControlName].Select();
				break;
			}
		}
	}

	public void ControlAChange(string ControlAName, string ControlName, string Setting, string Data)
	{
		if (base.Controls[ControlAName].Controls[ControlName].InvokeRequired)
		{
			SetControl3Callback method = ControlAChange;
			Invoke(method, ControlAName, ControlName, Setting, Data);
			return;
		}
		checked
		{
			switch (Setting)
			{
			case "Text":
				base.Controls[ControlAName].Controls[ControlName].Text = Data;
				break;
			case "Visible":
				if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
				{
					base.Controls[ControlAName].Controls[ControlName].Visible = false;
				}
				else
				{
					base.Controls[ControlAName].Controls[ControlName].Visible = true;
				}
				break;
			case "Enabled":
				if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
				{
					base.Controls[ControlAName].Controls[ControlName].Enabled = false;
				}
				else
				{
					base.Controls[ControlAName].Controls[ControlName].Enabled = true;
				}
				break;
			case "Height":
				base.Controls[ControlAName].Controls[ControlName].Height = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Width":
				base.Controls[ControlAName].Controls[ControlName].Width = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Top":
				base.Controls[ControlAName].Controls[ControlName].Top = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Left":
				base.Controls[ControlAName].Controls[ControlName].Left = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Font":
				base.Controls[ControlAName].Controls[ControlName].Font = new Font(base.Controls[ControlAName].Controls[ControlName].Font.FontFamily, (float)Conversion.Val(Data));
				break;
			case "Focus":
				base.Controls[ControlAName].Controls[ControlName].Select();
				break;
			}
		}
	}

	public void ControlBChange(string ControlBName, string ControlAName, string ControlName, string Setting, string Data)
	{
		if (base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].InvokeRequired)
		{
			SetControl4Callback method = ControlBChange;
			Invoke(method, ControlAName, ControlName, Setting, Data);
			return;
		}
		checked
		{
			switch (Setting)
			{
			case "Text":
				base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Text = Data;
				break;
			case "Visible":
				if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
				{
					base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Visible = false;
				}
				else
				{
					base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Visible = true;
				}
				break;
			case "Enabled":
				if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
				{
					base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Enabled = false;
				}
				else
				{
					base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Enabled = true;
				}
				break;
			case "Height":
				base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Height = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Width":
				base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Width = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Top":
				base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Top = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Left":
				base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Left = (int)Math.Round(Conversion.Val(Data));
				break;
			case "Font":
				base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Font = new Font(base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Font.FontFamily, (float)Conversion.Val(Data));
				break;
			case "Focus":
				base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].Select();
				break;
			}
		}
	}

	private void IOPOT_Load(object sender, EventArgs e)
	{
		Hide();
		OutputsTM.Interval = 500;
		OutputsTM.Enabled = true;
		ControlChange("InitialReg", "Visible", "False");
		ControlChange("InitialRegDeg", "Visible", "False");
		ControlChange("SetDegRange", "Visible", "False");
		if ((Operators.CompareString(SerialNo, "0000", TextCompare: false) == 0) & (Operators.CompareString(Interaction.GetSetting("Health", "Setup", "SetDeadband", "E"), "E", TextCompare: false) == 0))
		{
			Interaction.SaveSetting("Health", "Setup", "DeadbandSet", "5");
			DeadBand = checked((byte)Math.Round(Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandSet", "0"))));
			UpdateBits();
			MyProject.Forms.MachineSetup.Kphtorpm();
			SetupDegreeReg();
			Interaction.SaveSetting("Health", "Setup", "SetDeadband", "OK");
		}
		if (Conversion.Val(Interaction.GetSetting("Treadmill", "ByteSet", "Byte10", Conversions.ToString(0))) == 0.0)
		{
			UpdateBits();
			MyProject.Forms.MachineSetup.Kphtorpm();
			SetupDegreeReg();
		}
		if (Conversion.Val(Interaction.GetSetting("Treadmill", "ByteSetDeg", "Byte10", Conversions.ToString(0))) == 0.0)
		{
			SetupDegreeReg();
		}
		SetupRPMIndReg();
		LevelIndChange(Conversions.ToString(MyProject.Forms.Display.DisplayLevels));
		RPMIndChange(Interaction.GetSetting("Dtread", "Setup", "RPMInd" + Conversions.ToString(0), "0"));
		IndexConstIncline = (float)Math.Round((double)BitResA / (MyProject.Forms.Display.MaxInclineDeg * 10.0), 2);
		UpdateGradient(0, Hold: false, ResetProg: false);
	}

	private void IOPOT_Closing(object sender, CancelEventArgs e)
	{
		SerialPortIOPotInd.Close();
	}

	private void LevelIndChange(string text)
	{
		if (LevelInd.InvokeRequired)
		{
			SetTextCallback method = LevelIndChange;
			Invoke(method, text);
		}
		else
		{
			LevelInd.Text = text;
		}
	}

	private void MpmIndChange(string text)
	{
		if (MpmInd.InvokeRequired)
		{
			SetTextCallback method = MpmIndChange;
			Invoke(method, text);
		}
		else
		{
			MpmInd.Text = text;
		}
	}

	private void MpmMeterChange(string text)
	{
		if (MpmMeter.InvokeRequired)
		{
			SetTextCallback method = MpmMeterChange;
			Invoke(method, text);
		}
		else
		{
			MpmMeter.Text = text;
		}
	}

	private void MeterChange(string text)
	{
		if (Meter.InvokeRequired)
		{
			SetTextCallback method = MeterChange;
			Invoke(method, text);
		}
		else
		{
			Meter.Text = text;
		}
	}

	private void ActualLevelIndSpeedChange(string text)
	{
		if (ActualLevelIndSpeed.InvokeRequired)
		{
			SetTextCallback method = ActualLevelIndSpeedChange;
			Invoke(method, text);
		}
		else
		{
			ActualLevelIndSpeed.Text = text;
		}
	}

	private void ActualLevelIndGradientChange(string text)
	{
		if (ActualLevelIndGradient.InvokeRequired)
		{
			SetTextCallback method = ActualLevelIndGradientChange;
			Invoke(method, text);
		}
		else
		{
			ActualLevelIndGradient.Text = text;
		}
	}

	public void SetupLevel()
	{
		DeadBandGrad = checked((byte)Math.Round(Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandGradSet", "0"))));
		InclineByte = Conversions.ToByte(Interaction.GetSetting("Treadmill", "ByteSetDeg", "Byte" + Conversions.ToString(0), Conversions.ToString(0)));
		MyProject.Forms.Display.InclineActualChange(Conversions.ToString(InclineByte));
		DeadbandGradSetChange(Conversions.ToString(InclineByte));
		GradientIntXHold = InclineByte;
	}

	private void UpLevelDeg_Click(object sender, EventArgs e)
	{
		ControlChange("InitialRegDeg", "Visible", "False");
		ControlChange("SetDegRange", "Visible", "False");
		checked
		{
			if (SetIncline < MyProject.Forms.Display.InclineLevels)
			{
				SetIncline += MyProject.Forms.Display.Jump;
			}
			InclineByte = Conversions.ToByte(Interaction.GetSetting("Treadmill", "ByteSetDeg", "Byte" + Conversions.ToString(SetIncline), Conversions.ToString(0)));
			if (Conversion.Val(Interaction.GetSetting("Dtread", "Setup", "DegInd" + Conversions.ToString(SetIncline), "0")) > 0.0)
			{
				DegIndChange(Conversions.ToString(Math.Round(Conversion.Val(Interaction.GetSetting("Dtread", "Setup", "DegInd" + Conversions.ToString(SetIncline), "E")) / 10.0, 1)));
			}
			GradientIntXHold = InclineByte;
		}
	}

	private void DownLevelDeg_Click(object sender, EventArgs e)
	{
		ControlChange("InitialRegDeg", "Visible", "False");
		ControlChange("SetDegRange", "Visible", "False");
		checked
		{
			if (SetIncline > 0)
			{
				SetIncline -= MyProject.Forms.Display.Jump;
			}
			InclineByte = Conversions.ToByte(Interaction.GetSetting("Treadmill", "ByteSetDeg", "Byte" + Conversions.ToString(SetIncline), Conversions.ToString(0)));
			if (Conversion.Val(Interaction.GetSetting("Dtread", "Setup", "DegInd" + Conversions.ToString(SetIncline), "E")) > 0.0)
			{
				DegIndChange(Conversions.ToString(Math.Round(Conversion.Val(Interaction.GetSetting("Dtread", "Setup", "DegInd" + Conversions.ToString(SetIncline), "E")) / 10.0, 1)));
			}
			else
			{
				DegIndChange("0.0");
			}
			GradientIntXHold = InclineByte;
		}
	}

	private void ZeroDeg()
	{
		if (SetIncline > 0)
		{
			SetIncline = 0;
		}
		InclineByte = Conversions.ToByte(Interaction.GetSetting("Treadmill", "ByteSetDeg", "Byte" + Conversions.ToString(SetIncline), Conversions.ToString(0)));
		if (Conversion.Val(Interaction.GetSetting("Dtread", "Setup", "DegInd" + Conversions.ToString(SetIncline), "E")) > 0.0)
		{
			DegIndChange(Conversions.ToString(Math.Round(Conversion.Val(Interaction.GetSetting("Dtread", "Setup", "DegInd" + Conversions.ToString(SetIncline), "E")) / 10.0, 1)));
		}
		else
		{
			DegIndChange("0.0");
		}
		GradientIntXHold = InclineByte;
	}

	private void InitialRegDeg_Click(object sender, EventArgs e)
	{
		SetZeroRegDeg();
		ControlChange("SetDegRange", "Visible", "True");
	}

	private void SetDeadBand()
	{
		if ((Operators.CompareString(ActualLevelIndGradient.Text, "0", TextCompare: false) == 0) & (InclineByte >= 0))
		{
			DeadbandGradSetChange(InclineByte.ToString());
			Interaction.SaveSetting("Health", "Setup", "DeadbandGradSet", DeadBandGradSet.Text);
			DeadBandGrad = checked((byte)Math.Round(Conversion.Val(Interaction.GetSetting("Health", "Setup", "DeadbandGradSet", "0"))));
		}
	}

	public void SetZeroRegDeg()
	{
		SetDeadBand();
	}

	private void ConveyorContOnOff_Click(object sender, EventArgs e)
	{
		RelayOveride = true;
		HoldProgramOp = false;
		RelayOverideSwChange("Relays On");
		if (!Display.Conveyor)
		{
			Display.Conveyor = true;
		}
		else
		{
			Display.Conveyor = false;
		}
		ConveyorControllerOnOff();
	}

	public void ConveyorControllerOnOff()
	{
		if (!Display.Conveyor)
		{
			ConveyorContOnOffChange("Conveyor Controller Off");
		}
		else
		{
			ConveyorContOnOffChange("Conveyor Controller On");
		}
	}

	private void ActuatorContOnOff_Click(object sender, EventArgs e)
	{
		ActuatorMainOnOff();
	}

	private void ActuatorMainOnOff()
	{
		RelayOveride = true;
		RelayOverideSwChange("Relays On");
		if (!Display.Actuator)
		{
			Display.Actuator = true;
		}
		else
		{
			Display.Actuator = false;
			if (!ActuatorDelayOff)
			{
				ActuatorPowerOffDelay.Enabled = true;
				ActuatorDelayOff = true;
			}
		}
		ActuatorControllerOnOffInd();
	}

	public void ActuatorControllerOnOffInd()
	{
		if (!Display.Actuator)
		{
			ActuatorContOnOffChange("Actuator Controller Off");
		}
		else
		{
			ActuatorContOnOffChange("Actuator Controller On");
		}
	}

	private void ConveyorContOnOffChange(string text)
	{
		if (ConveyorContOnOff.InvokeRequired)
		{
			SetTextCallback method = ConveyorContOnOffChange;
			Invoke(method, text);
		}
		else
		{
			ConveyorContOnOff.Text = text;
		}
	}

	private void ActuatorContOnOffChange(string text)
	{
		if (ActuatorContOnOff.InvokeRequired)
		{
			SetTextCallback method = ActuatorContOnOffChange;
			Invoke(method, text);
		}
		else
		{
			ActuatorContOnOff.Text = text;
		}
	}

	private void ActuatorPowerOffDelay_Tick(object sender, EventArgs e)
	{
		ActuatorPowerOffDelay.Enabled = false;
		ActuatorDelayOff = false;
	}

	private void RunningTM_Tick(object sender, EventArgs e)
	{
		if (Display.Conveyor & TreadmillMotorForward)
		{
			NewLateBinding.LateCall(CloseVersion, null, "SetValue", new object[2]
			{
				"MotorF",
				Operators.AddObject(NewLateBinding.LateGet(CloseVersion, null, "GetValue", new object[2] { "MotorF", "0" }, null, null, null), 1)
			}, null, null, null, IgnoreReturn: true);
		}
		else if (Display.Conveyor & TreadmillMotorReverse)
		{
			NewLateBinding.LateCall(CloseVersion, null, "SetValue", new object[2]
			{
				"MotorR",
				Operators.AddObject(NewLateBinding.LateGet(CloseVersion, null, "GetValue", new object[2] { "MotorR", "0" }, null, null, null), 1)
			}, null, null, null, IgnoreReturn: true);
		}
		if (Display.Actuator & !InclinePositionOK & !MyProject.Forms.Display.InclineFault)
		{
			NewLateBinding.LateCall(CloseVersion, null, "SetValue", new object[2]
			{
				"Actuator",
				Operators.AddObject(NewLateBinding.LateGet(CloseVersion, null, "GetValue", new object[2] { "Actuator", "0" }, null, null, null), 1)
			}, null, null, null, IgnoreReturn: true);
		}
		else if (Display.Actuator & MyProject.Forms.Display.InclineFault)
		{
			NewLateBinding.LateCall(CloseVersion, null, "SetValue", new object[2]
			{
				"ActuatorFault",
				Operators.AddObject(NewLateBinding.LateGet(CloseVersion, null, "GetValue", new object[2] { "ActuatorFault", "0" }, null, null, null), 1)
			}, null, null, null, IgnoreReturn: true);
		}
	}

	private void MotorReverseTM_Tick(object sender, EventArgs e)
	{
		MotorReverseTM.Dispose();
		MotorReverse();
	}

	private void MotorForwardTM_Tick(object sender, EventArgs e)
	{
		MotorForwardTM.Dispose();
		MotorForward();
	}
}
