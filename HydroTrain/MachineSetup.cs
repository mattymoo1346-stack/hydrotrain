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
public class MachineSetup : Form
{
	public delegate void SetTextCallback(string text);

	public delegate void SetControl1Callback(string ControlName, bool Data);

	public delegate void SetControl2Callback(string ControlName, string Setting, string Data);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InclineSw")]
	private Button _InclineSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("JetSw")]
	private Button _JetSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ChamberTempSw")]
	private Button _ChamberTempSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HeaterAndCirculationFittedSw")]
	private Button _HeaterAndCirculationFittedSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UVCLampSw")]
	private Button _UVCLampSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ReverseSW")]
	private Button _ReverseSW;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ExitPage")]
	private Button _ExitPage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SerialNoLabel")]
	private Label _SerialNoLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SerialNo")]
	private TextBox _SerialNo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KeyLockOnOffSw")]
	private Button _KeyLockOnOffSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NetOnOffSw")]
	private Button _NetOnOffSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("GearboxSW")]
	private Button _GearboxSW;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthSet")]
	private TextBox _WaterDepthSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WaterDepthlb")]
	private Label _WaterDepthlb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ControlRemote")]
	private Button _ControlRemote;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LanDriveMapLetter")]
	private Button _LanDriveMapLetter;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DepthAdjustSw")]
	private Button _DepthAdjustSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CleaningOnOffSw")]
	private Button _CleaningOnOffSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CalorieIndWetOnOffSw")]
	private Button _CalorieIndWetOnOffSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TypeSw")]
	private Button _TypeSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BedLengthSw")]
	private Button _BedLengthSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CustomerName")]
	private TextBox _CustomerName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MaxRPM")]
	private TextBox _MaxRPM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MaxRPMLb")]
	private Label _MaxRPMLb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Maxkph")]
	private TextBox _Maxkph;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MaxkphLb")]
	private Label _MaxkphLb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PDF_Print")]
	private Button _PDF_Print;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MemDriveMapLetter")]
	private Button _MemDriveMapLetter;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrumCircumferenceSet")]
	private TextBox _DrumCircumferenceSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FloatSw")]
	private Button _FloatSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CleanTimer")]
	private Button _CleanTimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DoorSensorsSw")]
	private Button _DoorSensorsSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VoiceSW")]
	private Button _VoiceSW;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FloatSwDepthlb")]
	private Label _FloatSwDepthlb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FloatSwDepthSet")]
	private TextBox _FloatSwDepthSet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TimerBoxOnOffSw")]
	private Button _TimerBoxOnOffSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BedMaxHeightSw")]
	private TextBox _BedMaxHeightSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BedMaxAngle")]
	private TextBox _BedMaxAngle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CineOnOff")]
	private Button _CineOnOff;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TankTempSw")]
	private Button _TankTempSw;

	public static string Type;

	public static int MaxkpmSet = 16;

	public static bool InclineDisplayOnOff;

	public static bool FloatSwOnOff;

	public static bool CalorieIndWetOnOff;

	public static bool DepthAdjustOnOff;

	public static bool CleanOnOff;

	public static bool CleanTimerOnOff;

	public static bool DoorSensorsOnOff;

	public static bool JetDisplayOnOff;

	public static bool ChamberTempOnOff;

	public static bool TankTempOnOff;

	public static bool HeatCircFitted;

	public static bool ReverseOnOff;

	public static bool UVCLampFitted;

	public static bool USBSave = false;

	public static string ComputerName;

	public static string PDFOrPrint;

	public static bool VoiceControlOnOff;

	public static bool TimerBoxOnOff;

	public static string Gearbox;

	public string BedLength;

	public string MaxBedHeight;

	private bool KeyLock;

	private bool PassKey;

	private bool RestartHydro;

	private string ItemName;

	private int ControlLevel;

	internal virtual Button InclineSw
	{
		[CompilerGenerated]
		get
		{
			return _InclineSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InclineSw_Click;
			Button button = _InclineSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_InclineSw = value;
			button = _InclineSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button JetSw
	{
		[CompilerGenerated]
		get
		{
			return _JetSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = JetSw_Click;
			Button button = _JetSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_JetSw = value;
			button = _JetSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button ChamberTempSw
	{
		[CompilerGenerated]
		get
		{
			return _ChamberTempSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ChamberTempSw_Click;
			Button button = _ChamberTempSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ChamberTempSw = value;
			button = _ChamberTempSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button HeaterAndCirculationFittedSw
	{
		[CompilerGenerated]
		get
		{
			return _HeaterAndCirculationFittedSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = HeaterAndCirculationFittedSw_Click;
			Button button = _HeaterAndCirculationFittedSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_HeaterAndCirculationFittedSw = value;
			button = _HeaterAndCirculationFittedSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button UVCLampSw
	{
		[CompilerGenerated]
		get
		{
			return _UVCLampSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UVCLampSw_Click;
			Button button = _UVCLampSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_UVCLampSw = value;
			button = _UVCLampSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button ReverseSW
	{
		[CompilerGenerated]
		get
		{
			return _ReverseSW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ReverseSW_Click;
			Button button = _ReverseSW;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ReverseSW = value;
			button = _ReverseSW;
			if (button != null)
			{
				button.Click += value2;
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

	[field: AccessedThroughProperty("MessageBox")]
	internal virtual TextBox MessageBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label SerialNoLabel
	{
		[CompilerGenerated]
		get
		{
			return _SerialNoLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SerialNoLabel_Click;
			Label label = _SerialNoLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_SerialNoLabel = value;
			label = _SerialNoLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox SerialNo
	{
		[CompilerGenerated]
		get
		{
			return _SerialNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SerialNo_Click;
			TextBox textBox = _SerialNo;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_SerialNo = value;
			textBox = _SerialNo;
			if (textBox != null)
			{
				textBox.Click += value2;
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

	internal virtual Button KeyLockOnOffSw
	{
		[CompilerGenerated]
		get
		{
			return _KeyLockOnOffSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = KeyLockOnOffSw_Click;
			Button button = _KeyLockOnOffSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_KeyLockOnOffSw = value;
			button = _KeyLockOnOffSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button NetOnOffSw
	{
		[CompilerGenerated]
		get
		{
			return _NetOnOffSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NetOnOffSw_Click;
			Button button = _NetOnOffSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_NetOnOffSw = value;
			button = _NetOnOffSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button GearboxSW
	{
		[CompilerGenerated]
		get
		{
			return _GearboxSW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = GearboxSW_Click;
			Button button = _GearboxSW;
			if (button != null)
			{
				button.Click -= value2;
			}
			_GearboxSW = value;
			button = _GearboxSW;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual TextBox WaterDepthSet
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthSet_Click;
			TextBox textBox = _WaterDepthSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_WaterDepthSet = value;
			textBox = _WaterDepthSet;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual Label WaterDepthlb
	{
		[CompilerGenerated]
		get
		{
			return _WaterDepthlb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WaterDepthlb_Click;
			Label label = _WaterDepthlb;
			if (label != null)
			{
				label.Click -= value2;
			}
			_WaterDepthlb = value;
			label = _WaterDepthlb;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Button ControlRemote
	{
		[CompilerGenerated]
		get
		{
			return _ControlRemote;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ControlRemote_Click;
			Button button = _ControlRemote;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ControlRemote = value;
			button = _ControlRemote;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button LanDriveMapLetter
	{
		[CompilerGenerated]
		get
		{
			return _LanDriveMapLetter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = LanDriveMapLetter_Click;
			Button button = _LanDriveMapLetter;
			if (button != null)
			{
				button.Click -= value2;
			}
			_LanDriveMapLetter = value;
			button = _LanDriveMapLetter;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button DepthAdjustSw
	{
		[CompilerGenerated]
		get
		{
			return _DepthAdjustSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DepthAdjustSw_Click;
			Button button = _DepthAdjustSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_DepthAdjustSw = value;
			button = _DepthAdjustSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button CleaningOnOffSw
	{
		[CompilerGenerated]
		get
		{
			return _CleaningOnOffSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CleaningOnOffSw_Click;
			Button button = _CleaningOnOffSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_CleaningOnOffSw = value;
			button = _CleaningOnOffSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button CalorieIndWetOnOffSw
	{
		[CompilerGenerated]
		get
		{
			return _CalorieIndWetOnOffSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CalorieIndWetOnOffSw_Click;
			Button button = _CalorieIndWetOnOffSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_CalorieIndWetOnOffSw = value;
			button = _CalorieIndWetOnOffSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button TypeSw
	{
		[CompilerGenerated]
		get
		{
			return _TypeSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TypeSw_Click;
			Button button = _TypeSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_TypeSw = value;
			button = _TypeSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Versiontxt")]
	internal virtual TextBox Versiontxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SoftwareLb")]
	internal virtual Label SoftwareLb
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BedLengthSw
	{
		[CompilerGenerated]
		get
		{
			return _BedLengthSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BedLengthSw_Click;
			Button button = _BedLengthSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_BedLengthSw = value;
			button = _BedLengthSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual TextBox CustomerName
	{
		[CompilerGenerated]
		get
		{
			return _CustomerName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CustomerName_Click;
			TextBox textBox = _CustomerName;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_CustomerName = value;
			textBox = _CustomerName;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual TextBox MaxRPM
	{
		[CompilerGenerated]
		get
		{
			return _MaxRPM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MaxRPM_Click;
			TextBox textBox = _MaxRPM;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_MaxRPM = value;
			textBox = _MaxRPM;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual Label MaxRPMLb
	{
		[CompilerGenerated]
		get
		{
			return _MaxRPMLb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MaxRPMLb_Click;
			Label label = _MaxRPMLb;
			if (label != null)
			{
				label.Click -= value2;
			}
			_MaxRPMLb = value;
			label = _MaxRPMLb;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox Maxkph
	{
		[CompilerGenerated]
		get
		{
			return _Maxkph;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Maxkph_Click;
			TextBox textBox = _Maxkph;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_Maxkph = value;
			textBox = _Maxkph;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual Label MaxkphLb
	{
		[CompilerGenerated]
		get
		{
			return _MaxkphLb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Maxkph_Click;
			Label label = _MaxkphLb;
			if (label != null)
			{
				label.Click -= value2;
			}
			_MaxkphLb = value;
			label = _MaxkphLb;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ComputerNameSet")]
	internal virtual TextBox ComputerNameSet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button PDF_Print
	{
		[CompilerGenerated]
		get
		{
			return _PDF_Print;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PDF_Print_Click;
			Button button = _PDF_Print;
			if (button != null)
			{
				button.Click -= value2;
			}
			_PDF_Print = value;
			button = _PDF_Print;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button MemDriveMapLetter
	{
		[CompilerGenerated]
		get
		{
			return _MemDriveMapLetter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MemDriveMapLetter_Click;
			Button button = _MemDriveMapLetter;
			if (button != null)
			{
				button.Click -= value2;
			}
			_MemDriveMapLetter = value;
			button = _MemDriveMapLetter;
			if (button != null)
			{
				button.Click += value2;
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

	internal virtual TextBox DrumCircumferenceSet
	{
		[CompilerGenerated]
		get
		{
			return _DrumCircumferenceSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrumCircumference_Click;
			TextBox textBox = _DrumCircumferenceSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_DrumCircumferenceSet = value;
			textBox = _DrumCircumferenceSet;
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

	internal virtual Button FloatSw
	{
		[CompilerGenerated]
		get
		{
			return _FloatSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = FloatSw_Click;
			Button button = _FloatSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_FloatSw = value;
			button = _FloatSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button CleanTimer
	{
		[CompilerGenerated]
		get
		{
			return _CleanTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CleanTimer_Click;
			Button button = _CleanTimer;
			if (button != null)
			{
				button.Click -= value2;
			}
			_CleanTimer = value;
			button = _CleanTimer;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button DoorSensorsSw
	{
		[CompilerGenerated]
		get
		{
			return _DoorSensorsSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DoorSensorsSw_Click;
			Button button = _DoorSensorsSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_DoorSensorsSw = value;
			button = _DoorSensorsSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button VoiceSW
	{
		[CompilerGenerated]
		get
		{
			return _VoiceSW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = VoiceSW_Click;
			Button button = _VoiceSW;
			if (button != null)
			{
				button.Click -= value2;
			}
			_VoiceSW = value;
			button = _VoiceSW;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Label FloatSwDepthlb
	{
		[CompilerGenerated]
		get
		{
			return _FloatSwDepthlb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = FloatSwDepthlb_Click;
			Label label = _FloatSwDepthlb;
			if (label != null)
			{
				label.Click -= value2;
			}
			_FloatSwDepthlb = value;
			label = _FloatSwDepthlb;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox FloatSwDepthSet
	{
		[CompilerGenerated]
		get
		{
			return _FloatSwDepthSet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = FloatSwDepthSet_Click;
			TextBox textBox = _FloatSwDepthSet;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_FloatSwDepthSet = value;
			textBox = _FloatSwDepthSet;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual Button TimerBoxOnOffSw
	{
		[CompilerGenerated]
		get
		{
			return _TimerBoxOnOffSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TimerBoxOnOffSw_Click;
			Button button = _TimerBoxOnOffSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_TimerBoxOnOffSw = value;
			button = _TimerBoxOnOffSw;
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

	[field: AccessedThroughProperty("MainDirSet")]
	internal virtual TextBox MainDirSet
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox BedMaxHeightSw
	{
		[CompilerGenerated]
		get
		{
			return _BedMaxHeightSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BedMaxHeightSw_Click;
			TextBox textBox = _BedMaxHeightSw;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_BedMaxHeightSw = value;
			textBox = _BedMaxHeightSw;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("MaxHeightLb")]
	internal virtual Label MaxHeightLb
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaxAngleLB")]
	internal virtual Label MaxAngleLB
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox BedMaxAngle
	{
		[CompilerGenerated]
		get
		{
			return _BedMaxAngle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BedMaxAngle_Click;
			TextBox textBox = _BedMaxAngle;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_BedMaxAngle = value;
			textBox = _BedMaxAngle;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	internal virtual Button CineOnOff
	{
		[CompilerGenerated]
		get
		{
			return _CineOnOff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CineOnOff_Click;
			Button button = _CineOnOff;
			if (button != null)
			{
				button.Click -= value2;
			}
			_CineOnOff = value;
			button = _CineOnOff;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button TankTempSw
	{
		[CompilerGenerated]
		get
		{
			return _TankTempSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TankTempSw_Click;
			Button button = _TankTempSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_TankTempSw = value;
			button = _TankTempSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public MachineSetup()
	{
		base.Load += MachineSetup_Load;
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
		this.InclineSw = new System.Windows.Forms.Button();
		this.JetSw = new System.Windows.Forms.Button();
		this.ChamberTempSw = new System.Windows.Forms.Button();
		this.HeaterAndCirculationFittedSw = new System.Windows.Forms.Button();
		this.UVCLampSw = new System.Windows.Forms.Button();
		this.ReverseSW = new System.Windows.Forms.Button();
		this.ExitPage = new System.Windows.Forms.Button();
		this.MessageBox = new System.Windows.Forms.TextBox();
		this.SerialNoLabel = new System.Windows.Forms.Label();
		this.SerialNo = new System.Windows.Forms.TextBox();
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.KeyLockOnOffSw = new System.Windows.Forms.Button();
		this.NetOnOffSw = new System.Windows.Forms.Button();
		this.GearboxSW = new System.Windows.Forms.Button();
		this.WaterDepthSet = new System.Windows.Forms.TextBox();
		this.WaterDepthlb = new System.Windows.Forms.Label();
		this.ControlRemote = new System.Windows.Forms.Button();
		this.LanDriveMapLetter = new System.Windows.Forms.Button();
		this.DepthAdjustSw = new System.Windows.Forms.Button();
		this.CleaningOnOffSw = new System.Windows.Forms.Button();
		this.CalorieIndWetOnOffSw = new System.Windows.Forms.Button();
		this.TypeSw = new System.Windows.Forms.Button();
		this.Versiontxt = new System.Windows.Forms.TextBox();
		this.SoftwareLb = new System.Windows.Forms.Label();
		this.BedLengthSw = new System.Windows.Forms.Button();
		this.CustomerName = new System.Windows.Forms.TextBox();
		this.MaxRPM = new System.Windows.Forms.TextBox();
		this.MaxRPMLb = new System.Windows.Forms.Label();
		this.Maxkph = new System.Windows.Forms.TextBox();
		this.MaxkphLb = new System.Windows.Forms.Label();
		this.ComputerNameSet = new System.Windows.Forms.TextBox();
		this.PDF_Print = new System.Windows.Forms.Button();
		this.MemDriveMapLetter = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.DrumCircumferenceSet = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.FloatSw = new System.Windows.Forms.Button();
		this.CleanTimer = new System.Windows.Forms.Button();
		this.DoorSensorsSw = new System.Windows.Forms.Button();
		this.VoiceSW = new System.Windows.Forms.Button();
		this.FloatSwDepthlb = new System.Windows.Forms.Label();
		this.FloatSwDepthSet = new System.Windows.Forms.TextBox();
		this.TimerBoxOnOffSw = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.MainDirSet = new System.Windows.Forms.TextBox();
		this.BedMaxHeightSw = new System.Windows.Forms.TextBox();
		this.MaxHeightLb = new System.Windows.Forms.Label();
		this.MaxAngleLB = new System.Windows.Forms.Label();
		this.BedMaxAngle = new System.Windows.Forms.TextBox();
		this.CineOnOff = new System.Windows.Forms.Button();
		this.Label6 = new System.Windows.Forms.Label();
		this.TankTempSw = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.InclineSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.InclineSw.Location = new System.Drawing.Point(40, 60);
		this.InclineSw.Name = "InclineSw";
		this.InclineSw.Size = new System.Drawing.Size(160, 40);
		this.InclineSw.TabIndex = 1;
		this.InclineSw.Text = "Incline";
		this.InclineSw.UseVisualStyleBackColor = true;
		this.JetSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.JetSw.Location = new System.Drawing.Point(40, 105);
		this.JetSw.Name = "JetSw";
		this.JetSw.Size = new System.Drawing.Size(160, 40);
		this.JetSw.TabIndex = 2;
		this.JetSw.Text = "Jet";
		this.JetSw.UseVisualStyleBackColor = true;
		this.ChamberTempSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.ChamberTempSw.Location = new System.Drawing.Point(869, 111);
		this.ChamberTempSw.Name = "ChamberTempSw";
		this.ChamberTempSw.Size = new System.Drawing.Size(96, 53);
		this.ChamberTempSw.TabIndex = 3;
		this.ChamberTempSw.Text = "Chamber Off";
		this.ChamberTempSw.UseVisualStyleBackColor = true;
		this.HeaterAndCirculationFittedSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.HeaterAndCirculationFittedSw.Location = new System.Drawing.Point(230, 150);
		this.HeaterAndCirculationFittedSw.Name = "HeaterAndCirculationFittedSw";
		this.HeaterAndCirculationFittedSw.Size = new System.Drawing.Size(160, 80);
		this.HeaterAndCirculationFittedSw.TabIndex = 8;
		this.HeaterAndCirculationFittedSw.Text = "Heater and Circulation Pump Not Fitted";
		this.HeaterAndCirculationFittedSw.UseVisualStyleBackColor = true;
		this.UVCLampSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.UVCLampSw.Location = new System.Drawing.Point(230, 241);
		this.UVCLampSw.Name = "UVCLampSw";
		this.UVCLampSw.Size = new System.Drawing.Size(160, 40);
		this.UVCLampSw.TabIndex = 158;
		this.UVCLampSw.Text = "UV-C Not Fitted";
		this.UVCLampSw.UseVisualStyleBackColor = true;
		this.ReverseSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ReverseSW.Location = new System.Drawing.Point(420, 195);
		this.ReverseSW.Name = "ReverseSW";
		this.ReverseSW.Size = new System.Drawing.Size(180, 40);
		this.ReverseSW.TabIndex = 159;
		this.ReverseSW.Text = "Forward Belt Only";
		this.ReverseSW.UseVisualStyleBackColor = true;
		this.ExitPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ExitPage.Location = new System.Drawing.Point(924, 17);
		this.ExitPage.Name = "ExitPage";
		this.ExitPage.Size = new System.Drawing.Size(55, 44);
		this.ExitPage.TabIndex = 160;
		this.ExitPage.Text = "X";
		this.ExitPage.UseVisualStyleBackColor = true;
		this.MessageBox.Location = new System.Drawing.Point(453, 455);
		this.MessageBox.Name = "MessageBox";
		this.MessageBox.Size = new System.Drawing.Size(526, 20);
		this.MessageBox.TabIndex = 161;
		this.MessageBox.Text = "No Message";
		this.SerialNoLabel.AutoSize = true;
		this.SerialNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.SerialNoLabel.Location = new System.Drawing.Point(845, 564);
		this.SerialNoLabel.Name = "SerialNoLabel";
		this.SerialNoLabel.Size = new System.Drawing.Size(41, 25);
		this.SerialNoLabel.TabIndex = 163;
		this.SerialNoLabel.Text = "SN";
		this.SerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.SerialNo.Location = new System.Drawing.Point(892, 564);
		this.SerialNo.Name = "SerialNo";
		this.SerialNo.Size = new System.Drawing.Size(73, 35);
		this.SerialNo.TabIndex = 162;
		this.SerialNo.Text = "1426";
		this.KeyLockOnOffSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.KeyLockOnOffSw.Location = new System.Drawing.Point(673, 47);
		this.KeyLockOnOffSw.Name = "KeyLockOnOffSw";
		this.KeyLockOnOffSw.Size = new System.Drawing.Size(160, 40);
		this.KeyLockOnOffSw.TabIndex = 164;
		this.KeyLockOnOffSw.Text = "Key Lock On/Off";
		this.KeyLockOnOffSw.UseVisualStyleBackColor = true;
		this.NetOnOffSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.NetOnOffSw.Location = new System.Drawing.Point(673, 92);
		this.NetOnOffSw.Name = "NetOnOffSw";
		this.NetOnOffSw.Size = new System.Drawing.Size(160, 40);
		this.NetOnOffSw.TabIndex = 165;
		this.NetOnOffSw.Text = "USB Save";
		this.NetOnOffSw.UseVisualStyleBackColor = true;
		this.GearboxSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.GearboxSW.Location = new System.Drawing.Point(40, 240);
		this.GearboxSW.Name = "GearboxSW";
		this.GearboxSW.Size = new System.Drawing.Size(160, 40);
		this.GearboxSW.TabIndex = 166;
		this.GearboxSW.Text = "Gearbox 5.92";
		this.GearboxSW.UseVisualStyleBackColor = true;
		this.WaterDepthSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthSet.Location = new System.Drawing.Point(40, 418);
		this.WaterDepthSet.Name = "WaterDepthSet";
		this.WaterDepthSet.Size = new System.Drawing.Size(73, 29);
		this.WaterDepthSet.TabIndex = 167;
		this.WaterDepthSet.Text = "60";
		this.WaterDepthSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.WaterDepthlb.AutoSize = true;
		this.WaterDepthlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.WaterDepthlb.Location = new System.Drawing.Point(119, 425);
		this.WaterDepthlb.Name = "WaterDepthlb";
		this.WaterDepthlb.Size = new System.Drawing.Size(178, 18);
		this.WaterDepthlb.TabIndex = 168;
		this.WaterDepthlb.Text = "Water Depth Max (cm)";
		this.ControlRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ControlRemote.Location = new System.Drawing.Point(673, 182);
		this.ControlRemote.Name = "ControlRemote";
		this.ControlRemote.Size = new System.Drawing.Size(160, 40);
		this.ControlRemote.TabIndex = 169;
		this.ControlRemote.Text = "Remote Off";
		this.ControlRemote.UseVisualStyleBackColor = true;
		this.LanDriveMapLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LanDriveMapLetter.Location = new System.Drawing.Point(420, 60);
		this.LanDriveMapLetter.Name = "LanDriveMapLetter";
		this.LanDriveMapLetter.Size = new System.Drawing.Size(180, 40);
		this.LanDriveMapLetter.TabIndex = 170;
		this.LanDriveMapLetter.Text = "Remote Drive \"R\"";
		this.LanDriveMapLetter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.LanDriveMapLetter.UseVisualStyleBackColor = true;
		this.DepthAdjustSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DepthAdjustSw.Location = new System.Drawing.Point(420, 150);
		this.DepthAdjustSw.Name = "DepthAdjustSw";
		this.DepthAdjustSw.Size = new System.Drawing.Size(180, 40);
		this.DepthAdjustSw.TabIndex = 171;
		this.DepthAdjustSw.Text = "Depth Adjustment Off";
		this.DepthAdjustSw.UseVisualStyleBackColor = true;
		this.CleaningOnOffSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CleaningOnOffSw.Location = new System.Drawing.Point(230, 15);
		this.CleaningOnOffSw.Name = "CleaningOnOffSw";
		this.CleaningOnOffSw.Size = new System.Drawing.Size(160, 40);
		this.CleaningOnOffSw.TabIndex = 172;
		this.CleaningOnOffSw.Text = "Cleaning Off";
		this.CleaningOnOffSw.UseVisualStyleBackColor = true;
		this.CalorieIndWetOnOffSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CalorieIndWetOnOffSw.Location = new System.Drawing.Point(420, 104);
		this.CalorieIndWetOnOffSw.Name = "CalorieIndWetOnOffSw";
		this.CalorieIndWetOnOffSw.Size = new System.Drawing.Size(180, 40);
		this.CalorieIndWetOnOffSw.TabIndex = 173;
		this.CalorieIndWetOnOffSw.Text = "Calorie Ind Wet Off";
		this.CalorieIndWetOnOffSw.UseVisualStyleBackColor = true;
		this.TypeSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TypeSw.Location = new System.Drawing.Point(40, 15);
		this.TypeSw.Name = "TypeSw";
		this.TypeSw.Size = new System.Drawing.Size(160, 40);
		this.TypeSw.TabIndex = 174;
		this.TypeSw.Text = "TYPE";
		this.TypeSw.UseVisualStyleBackColor = true;
		this.Versiontxt.Location = new System.Drawing.Point(453, 486);
		this.Versiontxt.Name = "Versiontxt";
		this.Versiontxt.Size = new System.Drawing.Size(221, 20);
		this.Versiontxt.TabIndex = 175;
		this.Versiontxt.Text = "CCC";
		this.SoftwareLb.AutoSize = true;
		this.SoftwareLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.SoftwareLb.Location = new System.Drawing.Point(387, 486);
		this.SoftwareLb.Name = "SoftwareLb";
		this.SoftwareLb.Size = new System.Drawing.Size(59, 16);
		this.SoftwareLb.TabIndex = 176;
		this.SoftwareLb.Text = "Software";
		this.BedLengthSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BedLengthSw.Location = new System.Drawing.Point(420, 245);
		this.BedLengthSw.Name = "BedLengthSw";
		this.BedLengthSw.Size = new System.Drawing.Size(180, 60);
		this.BedLengthSw.TabIndex = 177;
		this.BedLengthSw.Text = "Bed Length 1915mm";
		this.BedLengthSw.UseVisualStyleBackColor = true;
		this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CustomerName.Location = new System.Drawing.Point(453, 516);
		this.CustomerName.Name = "CustomerName";
		this.CustomerName.Size = new System.Drawing.Size(526, 29);
		this.CustomerName.TabIndex = 179;
		this.CustomerName.WordWrap = false;
		this.MaxRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.MaxRPM.Location = new System.Drawing.Point(40, 577);
		this.MaxRPM.Name = "MaxRPM";
		this.MaxRPM.Size = new System.Drawing.Size(73, 35);
		this.MaxRPM.TabIndex = 180;
		this.MaxRPM.Text = "2550";
		this.MaxRPMLb.AutoSize = true;
		this.MaxRPMLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.MaxRPMLb.Location = new System.Drawing.Point(184, 583);
		this.MaxRPMLb.Name = "MaxRPMLb";
		this.MaxRPMLb.Size = new System.Drawing.Size(59, 25);
		this.MaxRPMLb.TabIndex = 181;
		this.MaxRPMLb.Text = "RPM";
		this.Maxkph.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Maxkph.Location = new System.Drawing.Point(40, 536);
		this.Maxkph.Name = "Maxkph";
		this.Maxkph.Size = new System.Drawing.Size(73, 35);
		this.Maxkph.TabIndex = 182;
		this.Maxkph.Text = "10.0";
		this.MaxkphLb.AutoSize = true;
		this.MaxkphLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.MaxkphLb.Location = new System.Drawing.Point(149, 542);
		this.MaxkphLb.Name = "MaxkphLb";
		this.MaxkphLb.Size = new System.Drawing.Size(94, 25);
		this.MaxkphLb.TabIndex = 183;
		this.MaxkphLb.Text = "Max kph";
		this.ComputerNameSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ComputerNameSet.Location = new System.Drawing.Point(453, 564);
		this.ComputerNameSet.Name = "ComputerNameSet";
		this.ComputerNameSet.Size = new System.Drawing.Size(222, 26);
		this.ComputerNameSet.TabIndex = 184;
		this.PDF_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.PDF_Print.Location = new System.Drawing.Point(673, 137);
		this.PDF_Print.Name = "PDF_Print";
		this.PDF_Print.Size = new System.Drawing.Size(160, 40);
		this.PDF_Print.TabIndex = 185;
		this.PDF_Print.Text = "PDF/Print";
		this.PDF_Print.UseVisualStyleBackColor = true;
		this.MemDriveMapLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.MemDriveMapLetter.Location = new System.Drawing.Point(420, 15);
		this.MemDriveMapLetter.Name = "MemDriveMapLetter";
		this.MemDriveMapLetter.Size = new System.Drawing.Size(180, 40);
		this.MemDriveMapLetter.TabIndex = 186;
		this.MemDriveMapLetter.Text = "Memory Drive \"M\"";
		this.MemDriveMapLetter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.MemDriveMapLetter.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(379, 564);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(68, 32);
		this.Label2.TabIndex = 188;
		this.Label2.Text = "Computer \r\nName";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(403, 456);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(43, 16);
		this.Label3.TabIndex = 189;
		this.Label3.Text = "Notes";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.Location = new System.Drawing.Point(646, 9);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(184, 25);
		this.Label4.TabIndex = 190;
		this.Label4.Text = "MACHINE SETUP";
		this.DrumCircumferenceSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DrumCircumferenceSet.Location = new System.Drawing.Point(40, 342);
		this.DrumCircumferenceSet.Name = "DrumCircumferenceSet";
		this.DrumCircumferenceSet.Size = new System.Drawing.Size(73, 35);
		this.DrumCircumferenceSet.TabIndex = 191;
		this.DrumCircumferenceSet.Text = "569";
		this.DrumCircumferenceSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(119, 352);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(171, 20);
		this.Label5.TabIndex = 192;
		this.Label5.Text = "Drive Circumference";
		this.FloatSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FloatSw.Location = new System.Drawing.Point(40, 195);
		this.FloatSw.Name = "FloatSw";
		this.FloatSw.Size = new System.Drawing.Size(160, 40);
		this.FloatSw.TabIndex = 193;
		this.FloatSw.Text = "No Float Sw";
		this.FloatSw.UseVisualStyleBackColor = true;
		this.CleanTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CleanTimer.Location = new System.Drawing.Point(230, 60);
		this.CleanTimer.Name = "CleanTimer";
		this.CleanTimer.Size = new System.Drawing.Size(160, 40);
		this.CleanTimer.TabIndex = 194;
		this.CleanTimer.Text = "Clean Timer Off";
		this.CleanTimer.UseVisualStyleBackColor = true;
		this.DoorSensorsSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DoorSensorsSw.Location = new System.Drawing.Point(40, 150);
		this.DoorSensorsSw.Name = "DoorSensorsSw";
		this.DoorSensorsSw.Size = new System.Drawing.Size(160, 40);
		this.DoorSensorsSw.TabIndex = 195;
		this.DoorSensorsSw.Text = "Door Sensors";
		this.DoorSensorsSw.UseVisualStyleBackColor = true;
		this.VoiceSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.VoiceSW.Location = new System.Drawing.Point(673, 227);
		this.VoiceSW.Name = "VoiceSW";
		this.VoiceSW.Size = new System.Drawing.Size(160, 40);
		this.VoiceSW.TabIndex = 196;
		this.VoiceSW.Text = "Voice";
		this.VoiceSW.UseVisualStyleBackColor = true;
		this.FloatSwDepthlb.AutoSize = true;
		this.FloatSwDepthlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FloatSwDepthlb.Location = new System.Drawing.Point(119, 390);
		this.FloatSwDepthlb.Name = "FloatSwDepthlb";
		this.FloatSwDepthlb.Size = new System.Drawing.Size(190, 18);
		this.FloatSwDepthlb.TabIndex = 198;
		this.FloatSwDepthlb.Text = "Float Switch Depth (cm)";
		this.FloatSwDepthSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FloatSwDepthSet.Location = new System.Drawing.Point(40, 383);
		this.FloatSwDepthSet.Name = "FloatSwDepthSet";
		this.FloatSwDepthSet.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.FloatSwDepthSet.Size = new System.Drawing.Size(73, 29);
		this.FloatSwDepthSet.TabIndex = 197;
		this.FloatSwDepthSet.Text = "-21";
		this.FloatSwDepthSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.FloatSwDepthSet.WordWrap = false;
		this.TimerBoxOnOffSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TimerBoxOnOffSw.Location = new System.Drawing.Point(230, 104);
		this.TimerBoxOnOffSw.Name = "TimerBoxOnOffSw";
		this.TimerBoxOnOffSw.Size = new System.Drawing.Size(160, 40);
		this.TimerBoxOnOffSw.TabIndex = 199;
		this.TimerBoxOnOffSw.Text = "Timer Box";
		this.TimerBoxOnOffSw.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(384, 517);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(65, 32);
		this.Label1.TabIndex = 200;
		this.Label1.Text = "Company\r\nName";
		this.MainDirSet.Location = new System.Drawing.Point(838, 485);
		this.MainDirSet.Name = "MainDirSet";
		this.MainDirSet.Size = new System.Drawing.Size(141, 20);
		this.MainDirSet.TabIndex = 201;
		this.MainDirSet.Text = "CCC";
		this.BedMaxHeightSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BedMaxHeightSw.Location = new System.Drawing.Point(40, 455);
		this.BedMaxHeightSw.Name = "BedMaxHeightSw";
		this.BedMaxHeightSw.Size = new System.Drawing.Size(73, 35);
		this.BedMaxHeightSw.TabIndex = 202;
		this.BedMaxHeightSw.Text = "175";
		this.MaxHeightLb.AutoSize = true;
		this.MaxHeightLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.MaxHeightLb.Location = new System.Drawing.Point(122, 461);
		this.MaxHeightLb.Name = "MaxHeightLb";
		this.MaxHeightLb.Size = new System.Drawing.Size(121, 25);
		this.MaxHeightLb.TabIndex = 203;
		this.MaxHeightLb.Text = "Max Height";
		this.MaxAngleLB.AutoSize = true;
		this.MaxAngleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.MaxAngleLB.Location = new System.Drawing.Point(129, 501);
		this.MaxAngleLB.Name = "MaxAngleLB";
		this.MaxAngleLB.Size = new System.Drawing.Size(114, 25);
		this.MaxAngleLB.TabIndex = 205;
		this.MaxAngleLB.Text = "Max Angle";
		this.BedMaxAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BedMaxAngle.Location = new System.Drawing.Point(40, 495);
		this.BedMaxAngle.Name = "BedMaxAngle";
		this.BedMaxAngle.Size = new System.Drawing.Size(73, 35);
		this.BedMaxAngle.TabIndex = 204;
		this.BedMaxAngle.Text = "5.6";
		this.CineOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CineOnOff.Location = new System.Drawing.Point(673, 273);
		this.CineOnOff.Name = "CineOnOff";
		this.CineOnOff.Size = new System.Drawing.Size(160, 40);
		this.CineOnOff.TabIndex = 206;
		this.CineOnOff.Text = "Cine On/Off";
		this.CineOnOff.UseVisualStyleBackColor = true;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(869, 92);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(94, 16);
		this.Label6.TabIndex = 207;
		this.Label6.Text = "Temp Gauges";
		this.TankTempSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.TankTempSw.Location = new System.Drawing.Point(869, 184);
		this.TankTempSw.Name = "TankTempSw";
		this.TankTempSw.Size = new System.Drawing.Size(96, 46);
		this.TankTempSw.TabIndex = 208;
		this.TankTempSw.Text = "Tank Off";
		this.TankTempSw.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(993, 620);
		base.ControlBox = false;
		base.Controls.Add(this.TankTempSw);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.CineOnOff);
		base.Controls.Add(this.MaxAngleLB);
		base.Controls.Add(this.BedMaxAngle);
		base.Controls.Add(this.MaxHeightLb);
		base.Controls.Add(this.BedMaxHeightSw);
		base.Controls.Add(this.MainDirSet);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.TimerBoxOnOffSw);
		base.Controls.Add(this.FloatSwDepthlb);
		base.Controls.Add(this.FloatSwDepthSet);
		base.Controls.Add(this.VoiceSW);
		base.Controls.Add(this.DoorSensorsSw);
		base.Controls.Add(this.CleanTimer);
		base.Controls.Add(this.FloatSw);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.DrumCircumferenceSet);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.MemDriveMapLetter);
		base.Controls.Add(this.PDF_Print);
		base.Controls.Add(this.ComputerNameSet);
		base.Controls.Add(this.MaxkphLb);
		base.Controls.Add(this.Maxkph);
		base.Controls.Add(this.MaxRPMLb);
		base.Controls.Add(this.MaxRPM);
		base.Controls.Add(this.CustomerName);
		base.Controls.Add(this.BedLengthSw);
		base.Controls.Add(this.SoftwareLb);
		base.Controls.Add(this.Versiontxt);
		base.Controls.Add(this.TypeSw);
		base.Controls.Add(this.CalorieIndWetOnOffSw);
		base.Controls.Add(this.CleaningOnOffSw);
		base.Controls.Add(this.DepthAdjustSw);
		base.Controls.Add(this.LanDriveMapLetter);
		base.Controls.Add(this.ControlRemote);
		base.Controls.Add(this.WaterDepthlb);
		base.Controls.Add(this.WaterDepthSet);
		base.Controls.Add(this.GearboxSW);
		base.Controls.Add(this.NetOnOffSw);
		base.Controls.Add(this.KeyLockOnOffSw);
		base.Controls.Add(this.SerialNoLabel);
		base.Controls.Add(this.SerialNo);
		base.Controls.Add(this.MessageBox);
		base.Controls.Add(this.ExitPage);
		base.Controls.Add(this.ReverseSW);
		base.Controls.Add(this.UVCLampSw);
		base.Controls.Add(this.HeaterAndCirculationFittedSw);
		base.Controls.Add(this.ChamberTempSw);
		base.Controls.Add(this.JetSw);
		base.Controls.Add(this.InclineSw);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "MachineSetup";
		this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MachineSetup";
		base.TopMost = true;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void MachineSetup_Load(object sender, EventArgs e)
	{
		UpdateSettings();
		base.Top = 100;
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
		Hide();
		MyProject.Forms.Display.VisibleCheck();
	}

	private void InclineSw_Click(object sender, EventArgs e)
	{
		if (InclineDisplayOnOff)
		{
			InclineDisplayOnOff = false;
		}
		else
		{
			InclineDisplayOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "Incline", Conversions.ToString(InclineDisplayOnOff));
		UpdateSettings();
		RestartHydro = true;
	}

	private void FloatSw_Click(object sender, EventArgs e)
	{
		if (FloatSwOnOff)
		{
			FloatSwOnOff = false;
		}
		else
		{
			FloatSwOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "FloatSw", Conversions.ToString(FloatSwOnOff));
		UpdateSettings();
		RestartHydro = true;
	}

	private void JetSw_Click(object sender, EventArgs e)
	{
		if (JetDisplayOnOff)
		{
			JetDisplayOnOff = false;
		}
		else
		{
			JetDisplayOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "JetOnOff", Conversions.ToString(JetDisplayOnOff));
		UpdateSettings();
		RestartHydro = true;
	}

	private void DoorSensorsSw_Click(object sender, EventArgs e)
	{
		DoorSensorOrLift();
	}

	private void DoorSensorOrLift()
	{
		if (DoorSensorsOnOff & !Display.Lift)
		{
			DoorSensorsOnOff = false;
		}
		else if (!DoorSensorsOnOff & !Display.Lift)
		{
			Display.Lift = true;
		}
		else if (!DoorSensorsOnOff & Display.Lift)
		{
			DoorSensorsOnOff = true;
			Display.Lift = false;
		}
		Interaction.SaveSetting("DTread", "Aqua", "DoorSensors", Conversions.ToString(DoorSensorsOnOff));
		Interaction.SaveSetting("DTread", "Aqua", "Lift", Conversions.ToString(Display.Lift));
		UpdateSettings();
	}

	private void ChamberTempSw_Click(object sender, EventArgs e)
	{
		if (ChamberTempOnOff)
		{
			ChamberTempOnOff = false;
		}
		else
		{
			ChamberTempOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "ChamberTempGauge", Conversions.ToString(ChamberTempOnOff));
		UpdateSettings();
		RestartHydro = true;
	}

	private void HeaterAndCirculationFittedSw_Click(object sender, EventArgs e)
	{
		if (!HeatCircFitted)
		{
			HeatCircFitted = true;
		}
		else
		{
			HeatCircFitted = false;
		}
		Interaction.SaveSetting("DTread", "Aqua", "HeatCircFitted", Conversions.ToString(HeatCircFitted));
		UpdateSettings();
		RestartHydro = true;
	}

	private void UVCLampSw_Click(object sender, EventArgs e)
	{
		if (UVCLampFitted)
		{
			UVCLampFitted = false;
		}
		else
		{
			UVCLampFitted = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "UVCLampFitted", Conversions.ToString(UVCLampFitted));
		UpdateSettings();
	}

	private void ReverseSW_Click(object sender, EventArgs e)
	{
		if (ReverseOnOff)
		{
			ReverseOnOff = false;
		}
		else
		{
			ReverseOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "Reverse", Conversions.ToString(ReverseOnOff));
		UpdateSettings();
	}

	private void KeyLockOnOffSw_Click(object sender, EventArgs e)
	{
		if (KeyLock)
		{
			KeyLock = false;
			PassKey = false;
		}
		else if (PassKey)
		{
			PassKey = false;
			KeyLock = true;
		}
		else if (!KeyLock & !PassKey)
		{
			KeyLock = false;
			PassKey = true;
		}
		Interaction.SaveSetting("Treadmill", "Health", "Lock", Conversions.ToString(KeyLock));
		Interaction.SaveSetting("Treadmill", "Health", "PassKey", Conversions.ToString(PassKey));
		Display.KeyLock = KeyLock;
		Display.PassKey = PassKey;
		UpdateSettings();
	}

	private void NetOnOffSw_Click(object sender, EventArgs e)
	{
		if (USBSave)
		{
			USBSave = false;
		}
		else
		{
			USBSave = true;
		}
		Interaction.SaveSetting("Treadmill", "Health", "Net", Conversions.ToString(USBSave));
		UpdateSettings();
	}

	public void RPMtoDisplayLevel()
	{
		int num = Conversions.ToInteger(Interaction.GetSetting("Dtread", "Aqua", "MaxRPM", "2508"));
		float num2 = Conversions.ToSingle(Interaction.GetSetting("DTread", "Aqua", "Gearbox", "8.5"));
		float num3 = (float)Conversion.Val(DrumCircumferenceSet.Text);
		float num7 = default(float);
		if (Conversion.Val(num) > 0.0)
		{
			float num4 = (float)(Conversion.Val(num) / (double)num2 * (double)num3);
			float num5 = num4 / 1000f;
			float num6 = num4 / 1000000f;
			num7 = num6 * 60f;
		}
		Interaction.SaveSetting("DTread", "Aqua", "DisplayLevels", Conversions.ToString(Math.Round(num7 * 10f, 0)));
	}

	public void Kphtorpm()
	{
		float num = (float)Conversion.Val(Interaction.GetSetting("Dtread", "Aqua", "Maxkph", "10.0"));
		float num2 = (float)Conversion.Val(Interaction.GetSetting("DTread", "Aqua", "Gearbox", "8.5"));
		float num3 = num * 1000000f / 60f;
		float num4 = (float)((double)num3 / Conversions.ToDouble(Interaction.GetSetting("Dtread", "Aqua", "DrumCircumferenceSet", "569")));
		Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", ((float)Math.Round(num4 * num2, 0)).ToString());
		RPMtoDisplayLevel();
	}

	public void UpdateSettings()
	{
		try
		{
			Versiontxt.Text = MyProject.Forms.Display.VersionName + " V" + MyProject.Forms.Display.VersionNumber;
			MainDirChange(Functions.GetMainDirName());
			string text = MainDirSet.Text;
			VoiceControlOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "Voice", Conversions.ToString(Value: false)));
			if (!VoiceControlOnOff)
			{
				ControlChange("VoiceSw", "Text", "Voice Off");
			}
			else
			{
				ControlChange("VoiceSw", "Text", "Voice On");
			}
			InclineDisplayOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "Incline", Conversions.ToString(Value: false)));
			if (!InclineDisplayOnOff)
			{
				ControlChange("InclineSw", "Text", "No Incline");
			}
			else
			{
				ControlChange("InclineSw", "Text", "Incline Fitted");
			}
			FloatSwOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "FloatSw", Conversions.ToString(Value: false)));
			if (!FloatSwOnOff)
			{
				ControlChange("FloatSw", "Text", "No Float Sw");
			}
			else
			{
				ControlChange("FloatSw", "Text", "Float Sw Fitted");
			}
			JetDisplayOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "JetOnOff", Conversions.ToString(Value: false)));
			if (!JetDisplayOnOff)
			{
				ControlChange("JetSw", "Text", "No Jet");
			}
			else
			{
				ControlChange("JetSw", "Text", "Jet Fitted");
			}
			DoorSensorsOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "DoorSensors", Conversions.ToString(Value: true)));
			Display.Lift = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "Lift", Conversions.ToString(Value: false)));
			if (!DoorSensorsOnOff & !Display.Lift)
			{
				ControlChange("DoorSensorsSw", "Text", "No Sensors/Lift");
			}
			else if (DoorSensorsOnOff & !Display.Lift)
			{
				ControlChange("DoorSensorsSw", "Text", "Door Sensors");
			}
			else if (!DoorSensorsOnOff & Display.Lift)
			{
				ControlChange("DoorSensorsSw", "Text", "Lift");
			}
			if (!DoorSensorsOnOff)
			{
				Interaction.SaveSetting("DTread", "Aqua", "CleanTimer", Conversions.ToString(Value: false));
			}
			MyProject.Forms.Display.Cine = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "SwitchBox", Conversions.ToString(Value: false)));
			if (!MyProject.Forms.Display.Cine)
			{
				ControlChange("CineOnOff", "Text", "Cine Off");
			}
			else
			{
				ControlChange("CineOnOff", "Text", "Cine On");
			}
			ChamberTempOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "ChamberTempGauge", Conversions.ToString(Value: false)));
			if (!ChamberTempOnOff)
			{
				ControlChange("ChamberTempSw", "Text", "Chamber Off");
			}
			else
			{
				ControlChange("ChamberTempSw", "Text", "Chamber On");
			}
			TankTempOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "TankTempGauge", Conversions.ToString(Value: false)));
			if (!TankTempOnOff)
			{
				ControlChange("TankTempSw", "Text", "Tank Off");
			}
			else
			{
				ControlChange("TankTempSw", "Text", "Tank On");
			}
			ReverseOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "Reverse", Conversions.ToString(Value: false)));
			if (!ReverseOnOff)
			{
				ControlChange("ReverseSW", "Text", "Belt Forward Only");
			}
			else
			{
				ControlChange("ReverseSW", "Text", "Reversable Belt");
			}
			HeatCircFitted = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "HeatCircFitted", Conversions.ToString(Value: false)));
			if (!HeatCircFitted)
			{
				ControlChange("HeaterAndCirculationFittedSw", "Text", "Heater and Circulation Pump Not Fitted");
			}
			else
			{
				ControlChange("HeaterAndCirculationFittedSw", "Text", "Heater and Circulation Pump Fitted");
			}
			UVCLampFitted = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "UVCLampFitted", Conversions.ToString(Value: false)));
			if (!UVCLampFitted)
			{
				ControlChange("UVCLampSw", "Text", "UV-C Not Fitted");
			}
			else
			{
				ControlChange("UVCLampSw", "Text", "UV-C Fitted");
			}
			KeyLock = Conversions.ToBoolean(Interaction.GetSetting("Treadmill", "Health", "Lock", Conversions.ToString(Value: true)));
			if (!KeyLock & !PassKey)
			{
				ControlChange("KeyLockOnOffSw", "Text", "Key Lock Off");
			}
			else if (KeyLock)
			{
				ControlChange("KeyLockOnOffSw", "Text", "Key Lock Active");
			}
			else if (PassKey)
			{
				ControlChange("KeyLockOnOffSw", "Text", "Pass Key Active");
			}
			USBSave = Conversions.ToBoolean(Interaction.GetSetting("Treadmill", "Health", "Net", Conversions.ToString(Value: false)));
			if (!USBSave)
			{
				ControlChange("NetOnOffSw", "Text", "USB Save Off");
			}
			else
			{
				ControlChange("NetOnOffSw", "Text", "USB Save On");
			}
			PDFOrPrint = Interaction.GetSetting("Dtread", "Aqua", "PDFOrPrint", "PDF");
			ControlChange("PDF_Print", "Text", PDFOrPrint);
			CalorieIndWetOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "CalorieIndWet", Conversions.ToString(Value: false)));
			if (!CalorieIndWetOnOff)
			{
				ControlChange("CalorieIndWetOnOffSw", "Text", "Calorie Ind Wet Off");
			}
			else
			{
				ControlChange("CalorieIndWetOnOffSw", "Text", "Calorie Ind Wet On");
			}
			DepthAdjustOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "DepthAdjustOnOff", Conversions.ToString(DepthAdjustOnOff)));
			if (!DepthAdjustOnOff)
			{
				ControlChange("DepthAdjustSw", "Text", "Depth Adjust Off");
			}
			else
			{
				ControlChange("DepthAdjustSw", "Text", "Depth Adjust On");
			}
			CleanOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "CleanOnOff", Conversions.ToString(CleanOnOff)));
			if (!CleanOnOff)
			{
				ControlChange("CleaningOnOffSw", "Text", "Clean Sw Off");
			}
			else
			{
				ControlChange("CleaningOnOffSw", "Text", "Clean Sw On");
			}
			CleanTimerOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "CleanTimer", Conversions.ToString(CleanTimerOnOff)));
			if (!CleanTimerOnOff)
			{
				ControlChange("CleanTimer", "Text", "Clean Timer Off");
			}
			else
			{
				ControlChange("CleanTimer", "Text", "Clean Timer On");
			}
			TimerBoxOnOff = Conversions.ToBoolean(Interaction.GetSetting("DTread", "Aqua", "TimerBox", Conversions.ToString(Value: true)));
			if (!TimerBoxOnOff)
			{
				ControlChange("TimerBoxOnOffSw", "Text", "Timer Box Off");
			}
			else
			{
				ControlChange("TimerBoxOnOffSw", "Text", "Timer Box On");
			}
			Type = Interaction.GetSetting("DTread", "File", "SerialFile");
			Gearbox = Interaction.GetSetting("DTread", "Aqua", "Gearbox", "8.5");
			ControlChange("GearboxSW", "Text", "Gearbox: " + Gearbox);
			if (Operators.CompareString(Type, "Animal", TextCompare: false) == 0)
			{
				ControlChange("TypeSw", "Text", "Animal");
			}
			else if (Operators.CompareString(Type, "Person", TextCompare: false) == 0)
			{
				ControlChange("TypeSw", "Text", "Person");
				Interaction.SaveSetting("DTread", "Aqua", "BedLength", "1330");
			}
			else if (Operators.CompareString(Type, "Canine", TextCompare: false) == 0)
			{
				ControlChange("TypeSw", "Text", "Canine");
			}
			else if (Operators.CompareString(Type, "", TextCompare: false) == 0)
			{
				ControlChange("TypeSw", "Text", "Type");
			}
			BedLength = Interaction.GetSetting("DTread", "Aqua", "Bedlength", "1915");
			ControlChange("BedLengthSw", "Text", "Bed Length: " + BedLength + "mm");
			BedMaxHeightSw.Text = Interaction.GetSetting("DTread", "Aqua", "BedMaxHeight", "0");
			ControlChange("BedMaxHeightSw", "Text", BedMaxHeightSw.Text);
			BedMaxAngle.Text = Interaction.GetSetting("Treadmill", "GradientPlus", "MaxInclineDeg", "5.1");
			ControlChange("BedMaxAngle", "Text", BedMaxAngle.Text);
			CustomerNameChange("Text", Interaction.GetSetting("Dtread", "Aqua", "CustomerName"));
			SerialNoChange("Text", Interaction.GetSetting("Dtread", "Aqua", "SerialNo", "0"));
			MaxRPMChange("Text", Interaction.GetSetting("Dtread", "Aqua", "MaxRPM", "2490"));
			MaxkphChange("Text", Interaction.GetSetting("Dtread", "Aqua", "Maxkph", "10.0"));
			MyProject.Forms.Display.MaxSpeedMilesSet = (float)(Conversion.Val(Maxkph.Text) * 0.621371);
			WaterDepthSetChange("Text", Interaction.GetSetting("Dtread", "Aqua", "WaterDepthSet", "50"));
			FloatSwDepthSetChange("Text", Interaction.GetSetting("Dtread", "Aqua", "FloatSwDepth", "-20"));
			DrumCircumferenceSetChange("Text", Interaction.GetSetting("Dtread", "Aqua", "DrumCircumferenceSet", "569"));
			LanDriveMapLetterChange("Text", "Remote Drive " + Interaction.GetSetting("Dtread", "Aqua", "LanDriveMapLetter", "R"));
			MyProject.Forms.Display.LanMapDrive = Interaction.GetSetting("Dtread", "Aqua", "LanDriveMapLetter", "R");
			MemDriveMapLetterChange("Text", "Memory Drive " + Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M"));
			MyProject.Forms.Display.MemMapDrive = Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M");
			if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile1", "0"), "93C72B10FF93A", TextCompare: false) == 0)
			{
				MyProject.Forms.Display.ControlAChange("DateTimeInd", "RemoteInd", "Text", "REMOTE");
				ControlChange("ControlRemote", "Text", "Remote On");
			}
			else if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile1", "0"), "C74A63F92AA83", TextCompare: false) == 0)
			{
				MyProject.Forms.Display.ControlAChange("DateTimeInd", "RemoteInd", "Text", "MAIN");
				ControlChange("ControlRemote", "Text", "Remote Main");
			}
			else if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile1", "0"), "83C72B10FF92A", TextCompare: false) == 0)
			{
				MyProject.Forms.Display.ControlAChange("DateTimeInd", "RemoteInd", "Text", "OFF");
				ControlChange("ControlRemote", "Text", "Remote Off");
			}
			else
			{
				Interaction.SaveSetting("DTread", "File", "SerialFile1", "83C72B10FF92A");
				MyProject.Forms.Display.ControlAChange("DateTimeInd", "RemoteInd", "Text", "OFF");
				ControlChange("ControlRemote", "Text", "Remote Off");
			}
			RPMtoDisplayLevel();
			SetRemoteName();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		switch (ItemName)
		{
		case "SerialNo":
			SerialNoChange("TextAlign", "Left");
			SerialNoChange("Text", InfoEnter.PasswordSet);
			break;
		case "MaxRPM":
			MaxRPMChange("TextAlign", "Left");
			MaxRPMChange("Text", InfoEnter.PasswordSet);
			break;
		case "Maxkph":
			MaxkphChange("TextAlign", "Left");
			if (Conversion.Val(InfoEnter.PasswordSet) > (double)MaxkpmSet)
			{
				MyProject.Forms.InfoEnter.InputText = MaxkpmSet.ToString();
			}
			if ((Conversion.Val(InfoEnter.PasswordSet) > Conversion.Int(Conversion.Val(InfoEnter.PasswordSet))) & (Conversion.Int(Conversion.Val(InfoEnter.PasswordSet)) > 9.0))
			{
				MyProject.Forms.InfoEnter.InputText = Conversion.Int(Conversion.Val(InfoEnter.PasswordSet)).ToString();
			}
			MaxkphChange("Text", InfoEnter.PasswordSet);
			break;
		case "BedMaxHeightSw":
			BedMaxHeightSwChange("TextAlign", "Left");
			BedMaxHeightSwChange("Text", InfoEnter.PasswordSet);
			break;
		case "BedMaxAngle":
			BedMaxAngleChange("TextAlign", "Left");
			BedMaxAngleChange("Text", InfoEnter.PasswordSet);
			break;
		case "CustomerName":
			CustomerNameChange("TextAlign", "Left");
			CustomerNameChange("Text", InfoEnter.PasswordSet);
			break;
		case "WaterDepth":
			WaterDepthSetChange("TextAlign", "Left");
			WaterDepthSetChange("Text", InfoEnter.PasswordSet);
			break;
		case "FloatSwDepth":
			FloatSwDepthSetChange("TextAlign", "Left");
			FloatSwDepthSetChange("Text", InfoEnter.PasswordSet);
			break;
		case "DrumCircumference":
			DrumCircumferenceSetChange("TextAlign", "Left");
			DrumCircumferenceSetChange("Text", InfoEnter.PasswordSet);
			break;
		case "LanDriveMapLetter":
			LanDriveMapLetterChange("TextAlign", "Left");
			LanDriveMapLetterChange("Text", InfoEnter.PasswordSet);
			break;
		case "MemDriveMapLetter":
			MemDriveMapLetterChange("TextAlign", "Left");
			MemDriveMapLetterChange("Text", InfoEnter.PasswordSet);
			break;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		switch (ItemName)
		{
		case "SerialNo":
			if (Operators.CompareString(SerialNo.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "SerialNo", SerialNo.Text);
				SetRemoteName();
				RestartHydro = true;
			}
			SerialNoChange("TextAlign", "Left");
			break;
		case "MaxRPM":
			if (Operators.CompareString(MaxRPM.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", MaxRPM.Text);
				RPMtoDisplayLevel();
				RestartHydro = true;
			}
			MaxRPMChange("TextAlign", "Left");
			break;
		case "Maxkph":
			if (Operators.CompareString(Maxkph.Text, "", TextCompare: false) != 0)
			{
				if (Conversion.Val(Maxkph.Text) > (double)MaxkpmSet)
				{
					Maxkph.Text = MaxkpmSet.ToString();
				}
				Interaction.SaveSetting("Dtread", "Aqua", "Maxkph", Math.Round(Conversion.Val(Maxkph.Text), 1).ToString());
				Kphtorpm();
				RestartHydro = true;
			}
			MaxkphChange("TextAlign", "Left");
			break;
		case "BedMaxHeightSw":
			if (Operators.CompareString(BedMaxHeightSw.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "BedMaxHeight", BedMaxHeightSw.Text);
			}
			BedMaxHeightSwChange("TextAlign", "Left");
			MyProject.Forms.Display.InclineAngle("H");
			break;
		case "BedMaxAngle":
			if (Operators.CompareString(BedMaxAngle.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Treadmill", "GradientPlus", "MaxInclineDeg", BedMaxAngle.Text);
				MyProject.Forms.Display.InclineLevels = Conversions.ToInteger((Conversion.Val(BedMaxAngle.Text) * 10.0).ToString());
				MyProject.Forms.IOPOT.SetupDegreeReg();
			}
			BedMaxAngleChange("TextAlign", "Left");
			MyProject.Forms.Display.InclineAngle("A");
			break;
		case "CustomerName":
			if (Operators.CompareString(CustomerName.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "CustomerName", CustomerName.Text);
			}
			CustomerNameChange("TextAlign", "Left");
			break;
		case "WaterDepth":
			if (Operators.CompareString(WaterDepthSet.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "WaterDepthSet", WaterDepthSet.Text);
			}
			WaterDepthSetChange("TextAlign", "Left");
			break;
		case "FloatSwDepth":
			if (Operators.CompareString(FloatSwDepthSet.Text, "", TextCompare: false) != 0)
			{
				if (Conversion.Val(FloatSwDepthSet.Text) > 0.0)
				{
					FloatSwDepthSet.Text = "-" + FloatSwDepthSet.Text;
				}
				RestartHydro = true;
			}
			FloatSwDepthSetChange("Text", Conversions.ToString(Conversion.Val(FloatSwDepthSet.Text)));
			FloatSwDepthSetChange("TextAlign", "Center");
			Interaction.SaveSetting("Dtread", "Aqua", "FloatSwDepth", FloatSwDepthSet.Text);
			Interaction.SaveSetting("Health", "Person", "WaterDepthMeasure", FloatSwDepthSet.Text);
			break;
		case "DrumCircumference":
			if (Operators.CompareString(DrumCircumferenceSet.Text, "", TextCompare: false) != 0)
			{
				Interaction.SaveSetting("Dtread", "Aqua", "DrumCircumferenceSet", DrumCircumferenceSet.Text);
				Kphtorpm();
				RestartHydro = true;
			}
			DrumCircumferenceSetChange("TextAlign", "Left");
			break;
		case "LanDriveMapLetter":
			if (Operators.CompareString(LanDriveMapLetter.Text, "", TextCompare: false) != 0 && ((Strings.Len(LanDriveMapLetter.Text) == 1) & (Strings.Asc(LanDriveMapLetter.Text) >= 65) & (Strings.Asc(LanDriveMapLetter.Text) <= 90)))
			{
				Functions.UnMapDrive(Interaction.GetSetting("Dtread", "Aqua", "LanDriveMapLetter", "R"));
				Interaction.SaveSetting("Dtread", "Aqua", "LanDriveMapLetter", LanDriveMapLetter.Text);
				RestartHydro = true;
			}
			LanDriveMapLetterChange("TextAlign", "Center");
			break;
		case "MemDriveMapLetter":
			if (Operators.CompareString(MemDriveMapLetter.Text, "", TextCompare: false) != 0 && ((Operators.CompareString(MemDriveMapLetter.Text, "OFF", TextCompare: false) == 0) | ((Strings.Len(MemDriveMapLetter.Text) == 1) & (Strings.Asc(MemDriveMapLetter.Text) >= 65) & (Strings.Asc(MemDriveMapLetter.Text) <= 90))))
			{
				Functions.UnMapDrive(Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M"));
				Interaction.SaveSetting("Dtread", "Aqua", "MemDriveMapLetter", MemDriveMapLetter.Text);
				RestartHydro = true;
			}
			MemDriveMapLetterChange("TextAlign", "Center");
			break;
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Enabled = false;
		ControlLevel = 0;
		UpdateSettings();
	}

	public void SetRemoteName()
	{
		if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile1", "0"), "93C72B10FF93A", TextCompare: false) == 0)
		{
			Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", "DWS-" + SerialNo.Text, "Save");
			CheckComputerName("DWS-" + SerialNo.Text + "R");
		}
		else if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile1", "0"), "C74A63F92AA83", TextCompare: false) == 0)
		{
			Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", "DWS-" + SerialNo.Text + "R", "Save");
			CheckComputerName("DWS-" + SerialNo.Text);
		}
		else
		{
			Display.ComputerNameError = false;
		}
	}

	public void CheckComputerName(string Data)
	{
		ComputerNameSetChange("Text", Functions.GetComputerName());
		if (Operators.CompareString(ComputerNameSet.Text, Data, TextCompare: false) != 0)
		{
			if ((Operators.CompareString(ComputerNameSet.Text, "JMFMicro", TextCompare: false) != 0) & (Operators.CompareString(SerialNo.Text, "1444", TextCompare: false) != 0) & (Operators.CompareString(SerialNo.Text, "1449", TextCompare: false) != 0) & (Operators.CompareString(SerialNo.Text, "1452", TextCompare: false) != 0))
			{
				Display.ComputerNameError = true;
			}
		}
		else
		{
			Display.ComputerNameError = false;
		}
	}

	private void RunNewEntre()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		switch (ItemName)
		{
		case "SerialNo":
			if (Conversion.Val(SerialNo.Text) == 0.0)
			{
				SerialNoChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = SerialNo.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "MaxRPM":
			if (Conversion.Val(MaxRPM.Text) == 0.0)
			{
				MaxRPMChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = MaxRPM.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "Maxkph":
			if (Conversion.Val(Maxkph.Text) == 0.0)
			{
				MaxkphChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = Maxkph.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "BedMaxHeightSw":
			if (Conversion.Val(BedMaxHeightSw.Text) == 0.0)
			{
				BedMaxHeightSwChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = BedMaxHeightSw.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "BedMaxAngle":
			if (Conversion.Val(BedMaxAngle.Text) == 0.0)
			{
				BedMaxAngleChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = BedMaxAngle.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "CustomerName":
			if (Conversion.Val(CustomerName.Text) == 0.0)
			{
				CustomerNameChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = CustomerName.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "WaterDepth":
			if (Conversion.Val(WaterDepthSet.Text) == 0.0)
			{
				WaterDepthSetChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = WaterDepthSet.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "FloatSwDepth":
			if (Conversion.Val(FloatSwDepthSet.Text) == 0.0)
			{
				FloatSwDepthSetChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = FloatSwDepthSet.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "DrumCircumference":
			if (Conversion.Val(DrumCircumferenceSet.Text) == 0.0)
			{
				DrumCircumferenceSetChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = DrumCircumferenceSet.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "LanDriveMapLetter":
			if (Conversion.Val(LanDriveMapLetter.Text) == 0.0)
			{
				LanDriveMapLetterChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = LanDriveMapLetter.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		case "MemDriveMapLetter":
			if (Conversion.Val(MemDriveMapLetter.Text) == 0.0)
			{
				MemDriveMapLetterChange("Text", "");
			}
			MyProject.Forms.InfoEnter.Preload = MemDriveMapLetter.Text;
			MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, (double)MyProject.Forms.InfoEnter.CentreLocY + (double)base.Height / 2.0);
			break;
		}
	}

	private void SerialNo_Cl(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "SerialNo";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void SerialNo_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "SerialNo";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void SerialNoLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "SerialNo";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void MaxRPM_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "MaxRPM";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void MaxRPMLb_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "MaxRPM";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void Maxkph_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Maxkph";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void CustomerName_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "CustomerName";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthSet_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepth";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void WaterDepthlb_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "WaterDepth";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void FloatSwDepthSet_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "FloatSwDepth";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void FloatSwDepthlb_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "FloatSwDepth";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void DrumCircumference_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "DrumCircumference";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void LanDriveMapLetter_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "LanDriveMapLetter";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void MemDriveMapLetter_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "MemDriveMapLetter";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void SetResScreen()
	{
		Resolution("SerialNo", "", "");
		Resolution("SerialNoLabel", "", "");
		Resolution("MaxRPM", "", "");
		Resolution("MaxRPMLb", "", "");
		Resolution("Maxkph", "", "");
		Resolution("MaxkphLb", "", "");
		Resolution("CustomerName", "", "");
		Resolution("WaterDepthSet", "", "");
		Resolution("WaterDepthlb", "", "");
		Resolution("FloatSwDepthSet", "", "");
		Resolution("FloatSwDepthlb", "", "");
		Resolution("DrumCircumferenceSet", "", "");
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

	private void GearboxSW_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Gearbox, "5.92", TextCompare: false) == 0)
		{
			Gearbox = "8.5";
		}
		else
		{
			Gearbox = "5.92";
		}
		Interaction.SaveSetting("DTread", "Aqua", "Gearbox", Gearbox);
		UpdateSettings();
		Kphtorpm();
		MyProject.Forms.IOPOT.SetupRPMIndReg();
		RestartHydro = true;
	}

	private void ControlRemote_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile1", "0"), "93C72B10FF93A", TextCompare: false) == 0)
		{
			Interaction.SaveSetting("DTread", "File", "SerialFile1", "C74A63F92AA83");
			SetRemoteName();
		}
		else if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile1", "0"), "C74A63F92AA83", TextCompare: false) == 0)
		{
			Interaction.SaveSetting("DTread", "File", "SerialFile1", "83C72B10FF92A");
		}
		else if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile1", "0"), "83C72B10FF92A", TextCompare: false) == 0)
		{
			Interaction.SaveSetting("DTread", "File", "SerialFile1", "93C72B10FF93A");
			SetRemoteName();
		}
		else if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile1", "0"), "0", TextCompare: false) == 0)
		{
			Interaction.SaveSetting("DTread", "File", "SerialFile1", "83C72B10FF92A");
		}
		UpdateSettings();
		RestartHydro = true;
	}

	private void DepthAdjustSw_Click(object sender, EventArgs e)
	{
		if (DepthAdjustOnOff)
		{
			DepthAdjustOnOff = false;
		}
		else
		{
			DepthAdjustOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "DepthAdjustOnOff", Conversions.ToString(DepthAdjustOnOff));
		UpdateSettings();
		RestartHydro = true;
	}

	private void CleaningOnOffSw_Click(object sender, EventArgs e)
	{
		if (CleanOnOff)
		{
			CleanOnOff = false;
		}
		else
		{
			CleanOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "CleanOnOff", Conversions.ToString(CleanOnOff));
		UpdateSettings();
		RestartHydro = true;
	}

	private void CalorieIndWetOnOffSw_Click(object sender, EventArgs e)
	{
		if (CalorieIndWetOnOff)
		{
			CalorieIndWetOnOff = false;
		}
		else
		{
			CalorieIndWetOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "CalorieIndWet", Conversions.ToString(CalorieIndWetOnOff));
		UpdateSettings();
		RestartHydro = true;
	}

	private void TypeSw_Click(object sender, EventArgs e)
	{
		TypeSet();
	}

	private void TypeSet()
	{
		if (Conversions.ToDouble(Gearbox) == 5.92)
		{
			if (Operators.CompareString(Type, "Person", TextCompare: false) == 0)
			{
				Type = "Animal";
				Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", "954");
				Interaction.SaveSetting("Dtread", "Aqua", "Maxkph", "5.5");
			}
			else if (Operators.CompareString(Type, "Animal", TextCompare: false) == 0)
			{
				Type = "Canine";
				Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", "1318");
				Interaction.SaveSetting("Dtread", "Aqua", "Maxkph", "7.6");
			}
			else if (Operators.CompareString(Type, "Canine", TextCompare: false) == 0)
			{
				Type = "Person";
				Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", "1734");
				Interaction.SaveSetting("Dtread", "Aqua", "Maxkph", "10.0");
			}
			else
			{
				Type = "Person";
				Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", "1734");
				Interaction.SaveSetting("Dtread", "Aqua", "Maxkph", "10.0");
			}
		}
		else if (Operators.CompareString(Type, "Person", TextCompare: false) == 0)
		{
			Type = "Animal";
			Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", "1369");
			Interaction.SaveSetting("Dtread", "Aqua", "Maxkph", "5.5");
		}
		else if (Operators.CompareString(Type, "Animal", TextCompare: false) == 0)
		{
			Type = "Canine";
			Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", "2508");
			Interaction.SaveSetting("Dtread", "Aqua", "Maxkph", "7.6");
		}
		else if (Operators.CompareString(Type, "Canine", TextCompare: false) == 0)
		{
			Type = "Person";
			Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", "2508");
			Interaction.SaveSetting("Dtread", "Aqua", "Maxkph", "10.0");
		}
		else
		{
			Type = "Person";
			Interaction.SaveSetting("Dtread", "Aqua", "MaxRPM", "2508");
			Interaction.SaveSetting("Dtread", "Aqua", "Maxkph", "10.0");
		}
		Interaction.SaveSetting("DTread", "File", "SerialFile", Type);
		UpdateSettings();
		RestartHydro = true;
	}

	private void ComputerNameSetChange(string Setting, string Data)
	{
		if (ComputerNameSet.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				ComputerNameSetChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			ComputerNameSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				ComputerNameSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				ComputerNameSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void DrumCircumferenceSetChange(string Setting, string Data)
	{
		if (DrumCircumferenceSet.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				DrumCircumferenceSetChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			DrumCircumferenceSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				DrumCircumferenceSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				DrumCircumferenceSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void WaterDepthSetChange(string Setting, string Data)
	{
		if (WaterDepthSet.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				WaterDepthSetChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			WaterDepthSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				WaterDepthSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				WaterDepthSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void FloatSwDepthSetChange(string Setting, string Data)
	{
		if (FloatSwDepthSet.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				FloatSwDepthSetChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			FloatSwDepthSet.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				FloatSwDepthSet.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				FloatSwDepthSet.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	public void SerialNoChange(string Setting, string Data)
	{
		if (SerialNo.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				SerialNoChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			SerialNo.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				SerialNo.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				SerialNo.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void MaxRPMChange(string Setting, string Data)
	{
		if (MaxRPM.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				MaxRPMChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			MaxRPM.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				MaxRPM.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				MaxRPM.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void MaxkphChange(string Setting, string Data)
	{
		if (Maxkph.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				MaxkphChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			Maxkph.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				Maxkph.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				Maxkph.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void CustomerNameChange(string Setting, string Data)
	{
		if (CustomerName.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				CustomerNameChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			CustomerName.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				CustomerName.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				CustomerName.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void LanDriveMapLetterChange(string Setting, string Data)
	{
		if (LanDriveMapLetter.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				LanDriveMapLetterChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			LanDriveMapLetter.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				LanDriveMapLetter.TextAlign = ContentAlignment.MiddleLeft;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				LanDriveMapLetter.TextAlign = ContentAlignment.MiddleCenter;
			}
		}
	}

	private void MemDriveMapLetterChange(string Setting, string Data)
	{
		if (MemDriveMapLetter.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				MemDriveMapLetterChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			MemDriveMapLetter.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				MemDriveMapLetter.TextAlign = ContentAlignment.MiddleLeft;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				MemDriveMapLetter.TextAlign = ContentAlignment.MiddleCenter;
			}
		}
	}

	public void MessageBoxChange(string text)
	{
		if (MessageBox.InvokeRequired)
		{
			SetTextCallback method = MessageBoxChange;
			Invoke(method, text);
		}
		else
		{
			MessageBox.Text = text;
		}
	}

	public void MainDirChange(string text)
	{
		if (MainDirSet.InvokeRequired)
		{
			SetTextCallback method = MainDirChange;
			Invoke(method, text);
		}
		else
		{
			MainDirSet.Text = text;
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

	private void BedLengthSw_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Type, "Person", TextCompare: false) == 0)
		{
			Interaction.SaveSetting("DTread", "Aqua", "BedLength", "1330");
		}
		else if ((Operators.CompareString(BedLength, "1865", TextCompare: false) == 0) | (Operators.CompareString(BedLength, "", TextCompare: false) == 0))
		{
			BedLength = "1565";
		}
		else if (Operators.CompareString(BedLength, "1565", TextCompare: false) == 0)
		{
			BedLength = "1395";
		}
		else if (Operators.CompareString(BedLength, "1395", TextCompare: false) == 0)
		{
			BedLength = "1350";
		}
		else if (Operators.CompareString(BedLength, "1350", TextCompare: false) == 0)
		{
			BedLength = "1865";
		}
		else
		{
			BedLength = "1865";
		}
		RestartHydro = true;
		Interaction.SaveSetting("DTread", "Aqua", "BedLength", BedLength);
		MyProject.Forms.Display.InclineAngle("L");
		UpdateSettings();
	}

	private void BedMaxAngle_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "BedMaxAngle";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void BedMaxHeightSw_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "BedMaxHeightSw";
			RunNewEntre();
			ControlLevel = 1;
		}
	}

	private void Old_BedMaxHeightSw_Click(object sender, EventArgs e)
	{
		if ((Operators.CompareString(MaxBedHeight, "210", TextCompare: false) != 0) | (Operators.CompareString(MaxBedHeight, "0", TextCompare: false) == 0) | (Operators.CompareString(MaxBedHeight, "", TextCompare: false) == 0))
		{
			MaxBedHeight = "210";
		}
		Interaction.SaveSetting("DTread", "Aqua", "BedMaxHeight", MaxBedHeight);
		UpdateSettings();
		MyProject.Forms.Display.InclineAngle("H");
	}

	private void BedMaxHeightSwChange(string Setting, string Data)
	{
		if (BedMaxHeightSw.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				BedMaxHeightSwChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			BedMaxHeightSw.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				BedMaxHeightSw.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				BedMaxHeightSw.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void BedMaxAngleChange(string Setting, string Data)
	{
		if (BedMaxAngle.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				BedMaxAngleChange(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
		}
		else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
		{
			BedMaxAngle.Text = Data;
		}
		else if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Data, "Left", TextCompare: false) == 0)
			{
				BedMaxAngle.TextAlign = HorizontalAlignment.Left;
			}
			else if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
			{
				BedMaxAngle.TextAlign = HorizontalAlignment.Center;
			}
		}
	}

	private void PDF_Print_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(PDFOrPrint, "", TextCompare: false) == 0)
		{
			PDFOrPrint = "PDF";
		}
		else if (Operators.CompareString(PDFOrPrint, "PDF", TextCompare: false) == 0)
		{
			PDFOrPrint = "Print";
		}
		else if (Operators.CompareString(PDFOrPrint, "Print", TextCompare: false) == 0)
		{
			PDFOrPrint = "PDF/Print";
		}
		else if (Operators.CompareString(PDFOrPrint, "PDF/Print", TextCompare: false) == 0)
		{
			PDFOrPrint = "PDF";
		}
		Interaction.SaveSetting("Dtread", "Aqua", "PDFOrPrint", PDFOrPrint);
		UpdateSettings();
	}

	private void CleanTimer_Click(object sender, EventArgs e)
	{
		if (CleanTimerOnOff)
		{
			CleanTimerOnOff = false;
		}
		else
		{
			CleanTimerOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "CleanTimer", Conversions.ToString(CleanTimerOnOff));
		UpdateSettings();
	}

	private void VoiceSW_Click(object sender, EventArgs e)
	{
		if (VoiceControlOnOff)
		{
			VoiceControlOnOff = false;
		}
		else
		{
			VoiceControlOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "Voice", Conversions.ToString(VoiceControlOnOff));
		UpdateSettings();
		RestartHydro = true;
	}

	private void TimerBoxOnOffSw_Click(object sender, EventArgs e)
	{
		if (TimerBoxOnOff)
		{
			TimerBoxOnOff = false;
		}
		else
		{
			TimerBoxOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "TimerBox", Conversions.ToString(TimerBoxOnOff));
		UpdateSettings();
		RestartHydro = true;
	}

	private void CineOnOff_Click(object sender, EventArgs e)
	{
		if (MyProject.Forms.Display.Cine)
		{
			MyProject.Forms.Display.Cine = false;
		}
		else
		{
			MyProject.Forms.Display.Cine = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "SwitchBox", Conversions.ToString(MyProject.Forms.Display.Cine));
		UpdateSettings();
		RestartHydro = true;
	}

	private void TankTempSw_Click(object sender, EventArgs e)
	{
		if (TankTempOnOff)
		{
			TankTempOnOff = false;
		}
		else
		{
			TankTempOnOff = true;
		}
		Interaction.SaveSetting("DTread", "Aqua", "TankTempGauge", Conversions.ToString(TankTempOnOff));
		UpdateSettings();
		RestartHydro = true;
	}
}
