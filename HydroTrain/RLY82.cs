using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class RLY82 : Form
{
	private delegate void load_classes(ComboBox _adc1, ComboBox _adc2, ComboBox _adc3, ComboBox _adc4, ComboBox _adc5, ComboBox _adc6, ComboBox _adc7, ComboBox _adc8, object Data);

	public delegate void SetControlCallback(string ControlName, string Setting, string Data);

	public delegate void SetTimerEnable(bool enable);

	private delegate void AppendTextBoxDelegate(TextBox TB, string txt);

	private delegate void AppendLabelDelegate(Label LB, string txt);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_comport")]
	private ComboBox _ComboBox_comport;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay1")]
	private Button _Relay1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Relay2")]
	private Button _Relay2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MainTimerTM")]
	private Timer _MainTimerTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_adc1")]
	private ComboBox _ComboBox_adc1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_adc2")]
	private ComboBox _ComboBox_adc2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_adc3")]
	private ComboBox _ComboBox_adc3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_adc4")]
	private ComboBox _ComboBox_adc4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_adc5")]
	private ComboBox _ComboBox_adc5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_adc7")]
	private ComboBox _ComboBox_adc7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_adc6")]
	private ComboBox _ComboBox_adc6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ComboBox_adc8")]
	private ComboBox _ComboBox_adc8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SerialAddress")]
	private ListBox _SerialAddress;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RelayOverideSw")]
	private Button _RelayOverideSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Invisible")]
	private Button _Invisible;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InputsOverideSw")]
	private Button _InputsOverideSw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Input8")]
	private Button _Input8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Input7")]
	private Button _Input7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Input6")]
	private Button _Input6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Input5")]
	private Button _Input5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Input4")]
	private Button _Input4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Input3")]
	private Button _Input3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Input2")]
	private Button _Input2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Input1")]
	private Button _Input1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsTM")]
	private Timer _CommsTM;

	public static bool BoardError;

	private SerialPort serialport;

	private byte[] serBuf;

	private int inputs;

	private byte ManualInput;

	private int InputsOveride;

	private int MotorIndex;

	private int Index;

	private bool connected;

	private bool TranRec;

	private bool TranClr;

	private int adc1;

	private int adc2;

	private int adc3;

	private int adc4;

	private int adc5;

	private int adc6;

	private int adc7;

	private int adc8;

	private string Port;

	private bool PortOk;

	private byte CommsIndex;

	private int MotorSwitch;

	private bool MotorOnOff;

	private int MotorMax;

	private bool State1;

	private bool State2;

	private bool Combo;

	private bool EmergencyPush;

	public static bool PulseInput;

	private bool PulseUsed;

	private bool DirectionInput;

	private bool MotorsOn;

	public static bool ErrorInput;

	public static bool DirectionError;

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
			EventHandler value2 = Button_pressed;
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
			EventHandler value2 = Button_pressed;
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

	internal virtual Timer MainTimerTM
	{
		[CompilerGenerated]
		get
		{
			return _MainTimerTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MainTimerTM_Tick;
			Timer timer = _MainTimerTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_MainTimerTM = value;
			timer = _MainTimerTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label_id")]
	internal virtual Label Label_id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label_v")]
	internal virtual Label Label_v
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

	internal virtual ComboBox ComboBox_adc1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox_adc1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Adc_ref_selected;
			ComboBox comboBox = _ComboBox_adc1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox_adc1 = value;
			comboBox = _ComboBox_adc1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox_adc2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox_adc2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Adc_ref_selected;
			ComboBox comboBox = _ComboBox_adc2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox_adc2 = value;
			comboBox = _ComboBox_adc2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox_adc3
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox_adc3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Adc_ref_selected;
			ComboBox comboBox = _ComboBox_adc3;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox_adc3 = value;
			comboBox = _ComboBox_adc3;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox_adc4
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox_adc4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Adc_ref_selected;
			ComboBox comboBox = _ComboBox_adc4;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox_adc4 = value;
			comboBox = _ComboBox_adc4;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox_adc5
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox_adc5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Adc_ref_selected;
			ComboBox comboBox = _ComboBox_adc5;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox_adc5 = value;
			comboBox = _ComboBox_adc5;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox_adc7
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox_adc7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Adc_ref_selected;
			ComboBox comboBox = _ComboBox_adc7;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox_adc7 = value;
			comboBox = _ComboBox_adc7;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox_adc6
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox_adc6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Adc_ref_selected;
			ComboBox comboBox = _ComboBox_adc6;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox_adc6 = value;
			comboBox = _ComboBox_adc6;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox_adc8
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox_adc8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Adc_ref_selected;
			ComboBox comboBox = _ComboBox_adc8;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox_adc8 = value;
			comboBox = _ComboBox_adc8;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
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
			EventHandler value2 = ComboBox_comport_GotFocus;
			ListBox listBox = _SerialAddress;
			if (listBox != null)
			{
				listBox.GotFocus -= value2;
			}
			_SerialAddress = value;
			listBox = _SerialAddress;
			if (listBox != null)
			{
				listBox.GotFocus += value2;
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

	[field: AccessedThroughProperty("CommsNoBoard")]
	internal virtual TextBox CommsNoBoard
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button InputsOverideSw
	{
		[CompilerGenerated]
		get
		{
			return _InputsOverideSw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InputsOverideSw_Click;
			Button button = _InputsOverideSw;
			if (button != null)
			{
				button.Click -= value2;
			}
			_InputsOverideSw = value;
			button = _InputsOverideSw;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Input8
	{
		[CompilerGenerated]
		get
		{
			return _Input8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Input_Click;
			Button button = _Input8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Input8 = value;
			button = _Input8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Input7
	{
		[CompilerGenerated]
		get
		{
			return _Input7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Input_Click;
			Button button = _Input7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Input7 = value;
			button = _Input7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Input6
	{
		[CompilerGenerated]
		get
		{
			return _Input6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Input_Click;
			Button button = _Input6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Input6 = value;
			button = _Input6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Input5
	{
		[CompilerGenerated]
		get
		{
			return _Input5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Input_Click;
			Button button = _Input5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Input5 = value;
			button = _Input5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Input4
	{
		[CompilerGenerated]
		get
		{
			return _Input4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Input_Click;
			Button button = _Input4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Input4 = value;
			button = _Input4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Input3
	{
		[CompilerGenerated]
		get
		{
			return _Input3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Input_Click;
			Button button = _Input3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Input3 = value;
			button = _Input3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Input2
	{
		[CompilerGenerated]
		get
		{
			return _Input2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Input_Click;
			Button button = _Input2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Input2 = value;
			button = _Input2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Input1
	{
		[CompilerGenerated]
		get
		{
			return _Input1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Input_Click;
			Button button = _Input1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Input1 = value;
			button = _Input1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("InputsLB")]
	internal virtual Label InputsLB
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual Timer CommsTM
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("CommsInd")]
	internal virtual TextBox CommsInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public RLY82()
	{
		base.Load += RLY82_Load;
		base.Activated += RLY82_Activated;
		serialport = new SerialPort();
		serBuf = new byte[21];
		inputs = 0;
		InputsOveride = 0;
		connected = false;
		TranRec = false;
		TranClr = false;
		MotorSwitch = 0;
		MotorMax = 2;
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
		this.ComboBox_comport = new System.Windows.Forms.ComboBox();
		this.Relay1 = new System.Windows.Forms.Button();
		this.Relay2 = new System.Windows.Forms.Button();
		this.MainTimerTM = new System.Windows.Forms.Timer(this.components);
		this.Label_id = new System.Windows.Forms.Label();
		this.Label_v = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.ComboBox_adc1 = new System.Windows.Forms.ComboBox();
		this.ComboBox_adc2 = new System.Windows.Forms.ComboBox();
		this.ComboBox_adc3 = new System.Windows.Forms.ComboBox();
		this.ComboBox_adc4 = new System.Windows.Forms.ComboBox();
		this.ComboBox_adc5 = new System.Windows.Forms.ComboBox();
		this.ComboBox_adc7 = new System.Windows.Forms.ComboBox();
		this.ComboBox_adc6 = new System.Windows.Forms.ComboBox();
		this.ComboBox_adc8 = new System.Windows.Forms.ComboBox();
		this.SerialAddress = new System.Windows.Forms.ListBox();
		this.RelayOverideSw = new System.Windows.Forms.Button();
		this.Invisible = new System.Windows.Forms.Button();
		this.CommsNoBoard = new System.Windows.Forms.TextBox();
		this.InputsOverideSw = new System.Windows.Forms.Button();
		this.Input8 = new System.Windows.Forms.Button();
		this.Input7 = new System.Windows.Forms.Button();
		this.Input6 = new System.Windows.Forms.Button();
		this.Input5 = new System.Windows.Forms.Button();
		this.Input4 = new System.Windows.Forms.Button();
		this.Input3 = new System.Windows.Forms.Button();
		this.Input2 = new System.Windows.Forms.Button();
		this.Input1 = new System.Windows.Forms.Button();
		this.InputsLB = new System.Windows.Forms.Label();
		this.CommsTM = new System.Windows.Forms.Timer(this.components);
		this.Label9 = new System.Windows.Forms.Label();
		this.TitleName = new System.Windows.Forms.Label();
		this.CommsInd = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.ComboBox_comport.CausesValidation = false;
		this.ComboBox_comport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ComboBox_comport.FormattingEnabled = true;
		this.ComboBox_comport.Location = new System.Drawing.Point(14, 38);
		this.ComboBox_comport.Name = "ComboBox_comport";
		this.ComboBox_comport.Size = new System.Drawing.Size(176, 32);
		this.ComboBox_comport.TabIndex = 0;
		this.ComboBox_comport.Text = "Select COM port";
		this.Relay1.Location = new System.Drawing.Point(13, 157);
		this.Relay1.Name = "Relay1";
		this.Relay1.Size = new System.Drawing.Size(121, 23);
		this.Relay1.TabIndex = 1;
		this.Relay1.Tag = "False";
		this.Relay1.Text = "Relay 1";
		this.Relay1.UseVisualStyleBackColor = true;
		this.Relay2.Location = new System.Drawing.Point(13, 187);
		this.Relay2.Name = "Relay2";
		this.Relay2.Size = new System.Drawing.Size(121, 23);
		this.Relay2.TabIndex = 2;
		this.Relay2.Tag = "False";
		this.Relay2.Text = "Relay 2";
		this.Relay2.UseVisualStyleBackColor = true;
		this.Label_id.AutoSize = true;
		this.Label_id.Location = new System.Drawing.Point(12, 221);
		this.Label_id.Name = "Label_id";
		this.Label_id.Size = new System.Drawing.Size(59, 13);
		this.Label_id.TabIndex = 3;
		this.Label_id.Text = "Module ID:";
		this.Label_v.AutoSize = true;
		this.Label_v.Location = new System.Drawing.Point(12, 234);
		this.Label_v.Name = "Label_v";
		this.Label_v.Size = new System.Drawing.Size(61, 13);
		this.Label_v.TabIndex = 4;
		this.Label_v.Text = "Firmware v:";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(363, 146);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(41, 13);
		this.Label1.TabIndex = 5;
		this.Label1.Text = "ADC 1:";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(363, 176);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(41, 13);
		this.Label2.TabIndex = 6;
		this.Label2.Text = "ADC 2:";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(363, 205);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(41, 13);
		this.Label3.TabIndex = 7;
		this.Label3.Text = "ADC 3:";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(363, 234);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(41, 13);
		this.Label4.TabIndex = 8;
		this.Label4.Text = "ADC 4:";
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(363, 263);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(41, 13);
		this.Label5.TabIndex = 9;
		this.Label5.Text = "ADC 5:";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(363, 292);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(41, 13);
		this.Label6.TabIndex = 10;
		this.Label6.Text = "ADC 6:";
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(363, 321);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(41, 13);
		this.Label7.TabIndex = 11;
		this.Label7.Text = "ADC 7:";
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(363, 350);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(41, 13);
		this.Label8.TabIndex = 12;
		this.Label8.Text = "ADC 8:";
		this.ComboBox_adc1.FormattingEnabled = true;
		this.ComboBox_adc1.Items.AddRange(new object[3] { "USB Supply", "4.096v", "2.048v" });
		this.ComboBox_adc1.Location = new System.Drawing.Point(258, 143);
		this.ComboBox_adc1.Name = "ComboBox_adc1";
		this.ComboBox_adc1.Size = new System.Drawing.Size(99, 21);
		this.ComboBox_adc1.TabIndex = 13;
		this.ComboBox_adc1.Tag = "1";
		this.ComboBox_adc2.FormattingEnabled = true;
		this.ComboBox_adc2.Items.AddRange(new object[3] { "USB Supply", "4.096v", "2.048v" });
		this.ComboBox_adc2.Location = new System.Drawing.Point(258, 173);
		this.ComboBox_adc2.Name = "ComboBox_adc2";
		this.ComboBox_adc2.Size = new System.Drawing.Size(99, 21);
		this.ComboBox_adc2.TabIndex = 14;
		this.ComboBox_adc2.Tag = "2";
		this.ComboBox_adc3.FormattingEnabled = true;
		this.ComboBox_adc3.Items.AddRange(new object[3] { "USB Supply", "4.096v", "2.048v" });
		this.ComboBox_adc3.Location = new System.Drawing.Point(258, 202);
		this.ComboBox_adc3.Name = "ComboBox_adc3";
		this.ComboBox_adc3.Size = new System.Drawing.Size(99, 21);
		this.ComboBox_adc3.TabIndex = 15;
		this.ComboBox_adc3.Tag = "3";
		this.ComboBox_adc4.FormattingEnabled = true;
		this.ComboBox_adc4.Items.AddRange(new object[3] { "USB Supply", "4.096v", "2.048v" });
		this.ComboBox_adc4.Location = new System.Drawing.Point(258, 231);
		this.ComboBox_adc4.Name = "ComboBox_adc4";
		this.ComboBox_adc4.Size = new System.Drawing.Size(99, 21);
		this.ComboBox_adc4.TabIndex = 16;
		this.ComboBox_adc4.Tag = "4";
		this.ComboBox_adc5.FormattingEnabled = true;
		this.ComboBox_adc5.Items.AddRange(new object[3] { "USB Supply", "4.096v", "2.048v" });
		this.ComboBox_adc5.Location = new System.Drawing.Point(258, 260);
		this.ComboBox_adc5.Name = "ComboBox_adc5";
		this.ComboBox_adc5.Size = new System.Drawing.Size(99, 21);
		this.ComboBox_adc5.TabIndex = 17;
		this.ComboBox_adc5.Tag = "5";
		this.ComboBox_adc7.FormattingEnabled = true;
		this.ComboBox_adc7.Items.AddRange(new object[3] { "USB Supply", "4.096v", "2.048v" });
		this.ComboBox_adc7.Location = new System.Drawing.Point(258, 318);
		this.ComboBox_adc7.Name = "ComboBox_adc7";
		this.ComboBox_adc7.Size = new System.Drawing.Size(99, 21);
		this.ComboBox_adc7.TabIndex = 18;
		this.ComboBox_adc7.Tag = "7";
		this.ComboBox_adc6.FormattingEnabled = true;
		this.ComboBox_adc6.Items.AddRange(new object[3] { "USB Supply", "4.096v", "2.048v" });
		this.ComboBox_adc6.Location = new System.Drawing.Point(258, 289);
		this.ComboBox_adc6.Name = "ComboBox_adc6";
		this.ComboBox_adc6.Size = new System.Drawing.Size(99, 21);
		this.ComboBox_adc6.TabIndex = 18;
		this.ComboBox_adc6.Tag = "6";
		this.ComboBox_adc8.FormattingEnabled = true;
		this.ComboBox_adc8.Items.AddRange(new object[3] { "USB Supply", "4.096v", "2.048v" });
		this.ComboBox_adc8.Location = new System.Drawing.Point(258, 347);
		this.ComboBox_adc8.Name = "ComboBox_adc8";
		this.ComboBox_adc8.Size = new System.Drawing.Size(99, 21);
		this.ComboBox_adc8.TabIndex = 19;
		this.ComboBox_adc8.Tag = "8";
		this.SerialAddress.FormattingEnabled = true;
		this.SerialAddress.Location = new System.Drawing.Point(38, 260);
		this.SerialAddress.Name = "SerialAddress";
		this.SerialAddress.Size = new System.Drawing.Size(76, 121);
		this.SerialAddress.TabIndex = 337;
		this.RelayOverideSw.Location = new System.Drawing.Point(13, 121);
		this.RelayOverideSw.Name = "RelayOverideSw";
		this.RelayOverideSw.Size = new System.Drawing.Size(121, 23);
		this.RelayOverideSw.TabIndex = 338;
		this.RelayOverideSw.Tag = "False";
		this.RelayOverideSw.Text = "Relay Overide";
		this.RelayOverideSw.UseVisualStyleBackColor = true;
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(342, 12);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(62, 58);
		this.Invisible.TabIndex = 339;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = true;
		this.CommsNoBoard.Location = new System.Drawing.Point(70, 95);
		this.CommsNoBoard.Name = "CommsNoBoard";
		this.CommsNoBoard.Size = new System.Drawing.Size(44, 20);
		this.CommsNoBoard.TabIndex = 340;
		this.InputsOverideSw.Location = new System.Drawing.Point(172, 97);
		this.InputsOverideSw.Name = "InputsOverideSw";
		this.InputsOverideSw.Size = new System.Drawing.Size(62, 23);
		this.InputsOverideSw.TabIndex = 406;
		this.InputsOverideSw.Text = "Inputs Off";
		this.InputsOverideSw.UseVisualStyleBackColor = true;
		this.Input8.Location = new System.Drawing.Point(188, 345);
		this.Input8.Name = "Input8";
		this.Input8.Size = new System.Drawing.Size(33, 23);
		this.Input8.TabIndex = 405;
		this.Input8.Tag = "False";
		this.Input8.UseVisualStyleBackColor = true;
		this.Input7.Location = new System.Drawing.Point(188, 316);
		this.Input7.Name = "Input7";
		this.Input7.Size = new System.Drawing.Size(33, 23);
		this.Input7.TabIndex = 404;
		this.Input7.Tag = "False";
		this.Input7.UseVisualStyleBackColor = true;
		this.Input6.Location = new System.Drawing.Point(188, 287);
		this.Input6.Name = "Input6";
		this.Input6.Size = new System.Drawing.Size(33, 23);
		this.Input6.TabIndex = 403;
		this.Input6.Tag = "False";
		this.Input6.UseVisualStyleBackColor = true;
		this.Input5.Location = new System.Drawing.Point(188, 258);
		this.Input5.Name = "Input5";
		this.Input5.Size = new System.Drawing.Size(33, 23);
		this.Input5.TabIndex = 402;
		this.Input5.Tag = "False";
		this.Input5.UseVisualStyleBackColor = true;
		this.Input4.Location = new System.Drawing.Point(188, 229);
		this.Input4.Name = "Input4";
		this.Input4.Size = new System.Drawing.Size(33, 23);
		this.Input4.TabIndex = 401;
		this.Input4.Tag = "False";
		this.Input4.UseVisualStyleBackColor = true;
		this.Input3.Location = new System.Drawing.Point(188, 200);
		this.Input3.Name = "Input3";
		this.Input3.Size = new System.Drawing.Size(33, 23);
		this.Input3.TabIndex = 400;
		this.Input3.Tag = "False";
		this.Input3.UseVisualStyleBackColor = true;
		this.Input2.Location = new System.Drawing.Point(188, 171);
		this.Input2.Name = "Input2";
		this.Input2.Size = new System.Drawing.Size(33, 23);
		this.Input2.TabIndex = 399;
		this.Input2.Tag = "False";
		this.Input2.UseVisualStyleBackColor = true;
		this.Input1.Location = new System.Drawing.Point(188, 142);
		this.Input1.Name = "Input1";
		this.Input1.Size = new System.Drawing.Size(33, 23);
		this.Input1.TabIndex = 398;
		this.Input1.Tag = "False";
		this.Input1.UseVisualStyleBackColor = true;
		this.InputsLB.AutoSize = true;
		this.InputsLB.Location = new System.Drawing.Point(255, 121);
		this.InputsLB.Name = "InputsLB";
		this.InputsLB.Size = new System.Drawing.Size(39, 13);
		this.InputsLB.TabIndex = 407;
		this.InputsLB.Text = "Inputs:";
		this.CommsTM.Interval = 50;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(33, 98);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(31, 13);
		this.Label9.TabIndex = 408;
		this.Label9.Text = "Com:";
		this.TitleName.AutoSize = true;
		this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TitleName.Location = new System.Drawing.Point(12, 12);
		this.TitleName.Name = "TitleName";
		this.TitleName.Size = new System.Drawing.Size(38, 20);
		this.TitleName.TabIndex = 409;
		this.TitleName.Text = "Title";
		this.CommsInd.Location = new System.Drawing.Point(313, 99);
		this.CommsInd.Name = "CommsInd";
		this.CommsInd.Size = new System.Drawing.Size(44, 20);
		this.CommsInd.TabIndex = 410;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(465, 439);
		base.ControlBox = false;
		base.Controls.Add(this.CommsInd);
		base.Controls.Add(this.TitleName);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.InputsLB);
		base.Controls.Add(this.InputsOverideSw);
		base.Controls.Add(this.Input8);
		base.Controls.Add(this.Input7);
		base.Controls.Add(this.Input6);
		base.Controls.Add(this.Input5);
		base.Controls.Add(this.Input4);
		base.Controls.Add(this.Input3);
		base.Controls.Add(this.Input2);
		base.Controls.Add(this.Input1);
		base.Controls.Add(this.CommsNoBoard);
		base.Controls.Add(this.Invisible);
		base.Controls.Add(this.RelayOverideSw);
		base.Controls.Add(this.SerialAddress);
		base.Controls.Add(this.ComboBox_adc8);
		base.Controls.Add(this.ComboBox_adc6);
		base.Controls.Add(this.ComboBox_adc7);
		base.Controls.Add(this.ComboBox_adc5);
		base.Controls.Add(this.ComboBox_adc4);
		base.Controls.Add(this.ComboBox_adc3);
		base.Controls.Add(this.ComboBox_adc2);
		base.Controls.Add(this.ComboBox_adc1);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Label_v);
		base.Controls.Add(this.Label_id);
		base.Controls.Add(this.Relay2);
		base.Controls.Add(this.Relay1);
		base.Controls.Add(this.ComboBox_comport);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "RLY82";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = " RLY82";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void RLY82_Load(object sender, EventArgs e)
	{
		if (Conversion.Val(Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0")) > 0.0)
		{
			Hide();
			SerialPortOpen();
		}
	}

	public void CommsOff()
	{
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, "0");
		CommsTM.Dispose();
		serialport.Close();
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

	private void ComboBox_comport_GotFocus(object sender, EventArgs e)
	{
		ControlChange("RelayOverideSw", "Focus", "Set");
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

	private void ComboBox_comport_SelectedIndexChanged(object sender, EventArgs e)
	{
		connected = false;
		Interaction.SaveSetting("Health", "Setup", "Port" + base.Name, Strings.Mid(ComboBox_comport.Text, 4, Strings.Len(ComboBox_comport.Text)));
		if (Conversions.ToInteger(Interaction.GetSetting("Health", "Setup", "Port" + base.Name)) > 0)
		{
			SerialPortOpen();
			CommsTM.Enabled = true;
		}
		else
		{
			CommsOff();
		}
	}

	private void SerialPortOpen()
	{
		if (serialport.IsOpen)
		{
			serialport.Close();
		}
		try
		{
			serialport = MyProject.Computer.Ports.OpenSerialPort("COM" + Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0"), 19200, Parity.None, 8, StopBits.Two);
			Interaction.SaveSetting("Dtread", "Display", "RLY82Startup", Conversions.ToString(Value: false));
			Interaction.SaveSetting("Dtread", "RLY82", "State1", Conversions.ToString(Value: false));
			Interaction.SaveSetting("Dtread", "RLY82", "State2", Conversions.ToString(Value: false));
			BoardError = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			BoardError = true;
			ControlChange("ComboBox_comport", "BackColor", "Red");
			Interaction.SaveSetting("Dtread", "RLY82", "BoardError", Conversions.ToString(BoardError));
			ProjectData.ClearProjectError();
			return;
		}
		Interaction.SaveSetting("Health", "Setup", "Open" + base.Name.ToString(), Conversions.ToString(serialport.IsOpen));
		Interaction.SaveSetting("Dtread", "RLY82", "BoardError", Conversions.ToString(BoardError));
		ControlChange("ComboBox_comport", "ForeColor", "White");
		Startup();
	}

	private void Startup()
	{
		serialport.ReadTimeout = 1000;
		serBuf[0] = 90;
		Transmit(1);
		Receive(2);
		string data = $"Module ID:{serBuf[0]}";
		string data2 = $"Firmware v:{serBuf[1]}";
		ControlChange("Label_id", "Text", data);
		ControlChange("Label_v", "Text", data2);
		if (serBuf[0] == 33)
		{
			RLY82SetRefVolts();
			serBuf[0] = 130;
			Transmit(1);
			Receive(8);
			string data3 = string.Join(",", serBuf);
			ComboBoxSelectIndex(data3);
			ControlChange("Relay1", "Enabled", "True");
			ControlChange("Relay2", "Enabled", "True");
			MainTimerTMEnable(enable: true);
			connected = true;
			ControlChange("RelayOverideSw", "Focus", "Set");
		}
	}

	private void Transmit(int num)
	{
		if (serialport.IsOpen)
		{
			try
			{
				serialport.Write(serBuf, 0, num);
				BoardError = false;
				ControlChange("ComboBox_comport", "BackColor", "Green");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MainTimerTM.Dispose();
				BoardError = true;
				ControlChange("ComboBox_comport", "BackColor", "Red");
				ProjectData.ClearProjectError();
				return;
			}
			Interaction.SaveSetting("Dtread", "RLY82", "BoardError", Conversions.ToString(BoardError));
		}
	}

	private void Receive(int num)
	{
		if (!serialport.IsOpen)
		{
			return;
		}
		checked
		{
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				try
				{
					serialport.Read(serBuf, i, 1);
					BoardError = false;
					ControlChange("ComboBox_comport", "BackColor", "Green");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					BoardError = true;
					ControlChange("ComboBox_comport", "BackColor", "Red");
					ProjectData.ClearProjectError();
				}
			}
			serialport.ReadExisting();
			Interaction.SaveSetting("Dtread", "RLY82", "BoardError", Conversions.ToString(BoardError));
		}
	}

	private void MainTimerTM_Tick(object sender, EventArgs e)
	{
		MotorControlOp();
		checked
		{
			if (connected)
			{
				if (TranRec)
				{
					TranRec = false;
					Transmit(1);
				}
				if (TranClr)
				{
					TranClr = false;
					Transmit(2);
				}
				serBuf[0] = 94;
				Transmit(1);
				Receive(1);
				inputs = serBuf[0];
				serBuf[0] = 91;
				Transmit(1);
				Receive(1);
				MotorSwitch = serBuf[0];
				serBuf[0] = 128;
				Transmit(1);
				Receive(16);
				adc1 = serBuf[0];
				adc1 <<= 8;
				adc1 += serBuf[1];
				adc2 = serBuf[2];
				adc2 <<= 8;
				adc2 += serBuf[3];
				adc3 = serBuf[4];
				adc3 <<= 8;
				adc3 += serBuf[5];
				adc4 = serBuf[6];
				adc4 <<= 8;
				adc4 += serBuf[7];
				adc5 = serBuf[8];
				adc5 <<= 8;
				adc5 += serBuf[9];
				adc6 = serBuf[10];
				adc6 <<= 8;
				adc6 += serBuf[11];
				adc7 = serBuf[12];
				adc7 <<= 8;
				adc7 += serBuf[13];
				adc8 = serBuf[14];
				adc8 <<= 8;
				adc8 += serBuf[15];
				ControlChange("Label1", "Text", $"ADC1: {adc1}");
				ControlChange("Label2", "Text", $"ADC2: {adc2}");
				ControlChange("Label3", "Text", $"ADC3: {adc3}");
				ControlChange("Label4", "Text", $"ADC4: {adc4}");
				ControlChange("Label5", "Text", $"ADC5: {adc5}");
				ControlChange("Label6", "Text", $"ADC6: {adc6}");
				ControlChange("Label7", "Text", $"ADC7: {adc7}");
				ControlChange("Label8", "Text", $"ADC8: {adc8}");
				Interaction.SaveSetting("Dtread", "RLY82", "ADC1", Conversions.ToString(adc1));
				Interaction.SaveSetting("Dtread", "RLY82", "ADC2", Conversions.ToString(adc2));
				Interaction.SaveSetting("Dtread", "RLY82", "ADC3", Conversions.ToString(adc3));
				Interaction.SaveSetting("Dtread", "RLY82", "ADC4", Conversions.ToString(adc4));
				Interaction.SaveSetting("Dtread", "RLY82", "ADC5", Conversions.ToString(adc5));
				Interaction.SaveSetting("Dtread", "RLY82", "ADC6", Conversions.ToString(adc6));
				Interaction.SaveSetting("Dtread", "RLY82", "ADC7", Conversions.ToString(adc7));
				Interaction.SaveSetting("Dtread", "RLY82", "ADC8", Conversions.ToString(adc8));
				InputsState();
				int motorMax = MotorMax;
				for (Index = 1; Index <= motorMax; Index++)
				{
					short num = (short)Math.Round(Math.Pow(2.0, Index - 1));
					if ((MotorSwitch & num) != 0)
					{
						ControlChange("Relay" + Conversions.ToString(Index), "BackColor", "Green");
					}
					else
					{
						ControlChange("Relay" + Conversions.ToString(Index), "BackColor", "Red");
					}
				}
				CommsIndex++;
				if (CommsIndex >= 4)
				{
					if (CommsInd.BackColor == Color.Green)
					{
						ControlChange("CommsInd", "BackColor", "LightGreen");
					}
					else
					{
						ControlChange("CommsInd", "BackColor", "Green");
					}
					CommsIndex = 0;
				}
			}
			else
			{
				BoardError = true;
				ControlChange("ComboBox_comport", "BackColor", "Red");
			}
			Interaction.SaveSetting("Dtread", "RLY82", "BoardError", Conversions.ToString(BoardError));
		}
	}

	private void MotorControlOp()
	{
		bool flag = false;
		State1 = Conversions.ToBoolean(Interaction.GetSetting("Dtread", "RLY82", "State1", "False"));
		State2 = Conversions.ToBoolean(Interaction.GetSetting("Dtread", "RLY82", "State2", "False"));
		if (!((connected & (Operators.CompareString(RelayOverideSw.Text, "Relay Overide Off", TextCompare: false) == 0)) | (Operators.CompareString(RelayOverideSw.Text, "Relay Overide", TextCompare: false) == 0)))
		{
			return;
		}
		checked
		{
			do
			{
				MotorIndex++;
				int num = (int)Math.Round(Math.Pow(2.0, MotorIndex - 1));
				bool flag2 = (MotorSwitch & num) != 0;
				switch (MotorIndex)
				{
				case 1:
					if (State1 != flag2)
					{
						flag = true;
					}
					break;
				case 2:
					if (State2 != flag2)
					{
						flag = true;
					}
					break;
				}
				if (flag)
				{
					if ((MotorSwitch & num) != 0)
					{
						serBuf[0] = (byte)(110 + MotorIndex);
					}
					else
					{
						serBuf[0] = (byte)(100 + MotorIndex);
					}
					TranRec = true;
				}
			}
			while (!(flag | (MotorIndex == MotorMax)));
			if (MotorIndex == MotorMax)
			{
				MotorIndex = 0;
			}
		}
	}

	private void RelayOverideSw_Click(object sender, EventArgs e)
	{
		if (!Conversions.ToBoolean(RelayOverideSw.Tag))
		{
			ClearRelays();
			return;
		}
		RelayOverideSw.Tag = true;
		ControlChange("RelayOverideSw", "Text", "Relay Overide On");
	}

	private void ClearRelays()
	{
		ControlChange("RelayOverideSw", "Text", "Relay Overide Off");
		RelayOverideSw.Tag = false;
		serBuf[0] = 92;
		serBuf[1] = 0;
		TranClr = true;
	}

	private void InputsState()
	{
		string text = "";
		Index = 1;
		checked
		{
			do
			{
				text = (((inputs & (int)Math.Round(Math.Pow(2.0, Index - 1))) == 0) ? ("0" + text) : ("1" + text));
				if (Conversions.ToBoolean(InputsOverideSw.Tag))
				{
					inputs = ManualInput;
				}
				if (!Display.RLY88Startup)
				{
					if (adc6 > 4)
					{
						PulseInput = true;
					}
					else if (adc6 == 0)
					{
						PulseInput = false;
						PulseUsed = false;
					}
					switch (Index)
					{
					case 2:
						if ((inputs & (byte)Math.Round(Math.Pow(2.0, Index))) != 0)
						{
							DirectionInput = true;
							if (USBOPTORLY816.MotorSwitch[3])
							{
								DirectionError = true;
								Display.PumpCheck = true;
							}
							else if (USBOPTORLY816.MotorSwitch[4])
							{
								DirectionError = false;
							}
						}
						else
						{
							DirectionInput = false;
							if (USBOPTORLY816.MotorSwitch[4])
							{
								DirectionError = true;
								Display.PumpCheck = true;
							}
							else if (USBOPTORLY816.MotorSwitch[3])
							{
								DirectionError = false;
							}
						}
						break;
					case 3:
						if ((inputs & (byte)Math.Round(Math.Pow(2.0, Index))) != 0)
						{
							ErrorInput = true;
						}
						else
						{
							ErrorInput = false;
						}
						break;
					}
				}
				Index++;
			}
			while (Index <= 8);
			if (PulseInput & !PulseUsed)
			{
				PulseUsed = true;
				if (!USBOPTORLY816.MotorSwitch[3] & !USBOPTORLY816.MotorSwitch[4])
				{
					MotorsOn = false;
				}
				else
				{
					MotorsOn = true;
				}
				if (USBOPTORLY816.MotorSwitch[3] | (!MotorsOn & !DirectionInput))
				{
					Interaction.SaveSetting("Dtread", "RLY82", "Pulse", Conversions.ToString(Conversions.ToInteger(Interaction.GetSetting("Dtread", "RLY82", "Pulse", "0")) + 2));
				}
				else if (USBOPTORLY816.MotorSwitch[4] | (!MotorsOn & DirectionInput))
				{
					Interaction.SaveSetting("Dtread", "RLY82", "Pulse", Conversions.ToString(Conversions.ToInteger(Interaction.GetSetting("Dtread", "RLY82", "Pulse", "0")) - 2));
				}
			}
			if (!Conversions.ToBoolean(InputsOverideSw.Tag))
			{
				InputsLB.Visible = false;
				SetInputs(inputs);
			}
			else
			{
				InputsLB.Visible = true;
				InputsLB.Text = $"Inputs: {text}";
			}
		}
	}

	private void InputsOverideSw_Click(object sender, EventArgs e)
	{
		if (!Conversions.ToBoolean(InputsOverideSw.Tag))
		{
			InputsOverideSw.Tag = true;
			InputsOveride = inputs;
			SetInputs(InputsOveride);
		}
		else
		{
			InputsOverideSw.Tag = false;
			ClearInputOveride();
		}
	}

	private void ClearInputOveride()
	{
		InputsOveride = 0;
		InputsOverideSw.Tag = false;
	}

	private void Input_Click(object sender, EventArgs e)
	{
		string text = "";
		string name = ((Button)sender).Name;
		checked
		{
			byte b = (byte)Math.Round(Conversion.Val(Strings.Mid(((Button)sender).Name, 6, Strings.Len(((Button)sender).Name))) - 1.0);
			byte b2 = (byte)Math.Round(Math.Pow(2.0, unchecked((int)b)));
			if ((InputsOveride & b2) != 0)
			{
				InputsOveride -= b2;
			}
			else
			{
				InputsOveride += b2;
			}
			ManualInput = (byte)InputsOveride;
			InputsOverideSw.Tag = true;
			SetInputs(InputsOveride);
		}
	}

	private void SetInputs(int Inputs)
	{
		if (Conversions.ToBoolean(InputsOverideSw.Tag))
		{
			ControlChange("InputsOverideSw", "Text", "Inputs On");
		}
		else
		{
			ControlChange("InputsOverideSw", "Text", "Inputs Off");
		}
		Index = 1;
		checked
		{
			do
			{
				if ((Inputs & (int)Math.Round(Math.Pow(2.0, Index - 1))) != 0)
				{
					ControlChange("Input" + Conversions.ToString(Index), "BackColor", "Green");
					Interaction.SaveSetting("Dtread", "RLY82", "IN" + Conversions.ToString(Index), "True");
				}
				else
				{
					ControlChange("Input" + Conversions.ToString(Index), "BackColor", "Red");
					Interaction.SaveSetting("Dtread", "RLY82", "IN" + Conversions.ToString(Index), "False");
				}
				Index++;
			}
			while (Index <= 8);
		}
	}

	private void Button_pressed(object sender, EventArgs e)
	{
		if (!connected)
		{
			return;
		}
		RelayOverideSw.Tag = true;
		ControlChange("RelayOverideSw", "Text", "Relay Overide On");
		checked
		{
			if (sender is Button)
			{
				Button button = (Button)sender;
				byte b = (byte)Math.Round(Conversion.Val(Strings.Mid(button.Text, Strings.Len(button.Text) - 1, 2)));
				byte b2 = (byte)Math.Round(Math.Pow(2.0, b - 1));
				if ((MotorSwitch & b2) != 0)
				{
					serBuf[0] = (byte)(110 + b);
				}
				else
				{
					serBuf[0] = (byte)(100 + b);
				}
				TranRec = true;
			}
		}
	}

	private void Adc_ref_selected(object sender, EventArgs e)
	{
		Combo = true;
		if (!(sender is ComboBox))
		{
			return;
		}
		ComboBox comboBox = (ComboBox)sender;
		checked
		{
			if (connected)
			{
				serBuf[0] = 129;
				byte b = default(byte);
				switch (Conversions.ToInteger(comboBox.Tag))
				{
				case 1:
					b = (byte)ComboBox_adc1.SelectedIndex;
					serBuf[1] = 1;
					break;
				case 2:
					b = (byte)ComboBox_adc2.SelectedIndex;
					serBuf[1] = 2;
					break;
				case 3:
					b = (byte)ComboBox_adc3.SelectedIndex;
					serBuf[1] = 3;
					break;
				case 4:
					b = (byte)ComboBox_adc4.SelectedIndex;
					serBuf[1] = 4;
					break;
				case 5:
					b = (byte)ComboBox_adc5.SelectedIndex;
					serBuf[1] = 5;
					break;
				case 6:
					b = (byte)ComboBox_adc6.SelectedIndex;
					serBuf[1] = 6;
					break;
				case 7:
					b = (byte)ComboBox_adc7.SelectedIndex;
					serBuf[1] = 7;
					break;
				case 8:
					b = (byte)ComboBox_adc8.SelectedIndex;
					serBuf[1] = 8;
					break;
				}
				serBuf[2] = b;
				Transmit(3);
				Array.Clear(serBuf, 0, 20);
				serBuf[0] = 130;
				Transmit(1);
				Receive(8);
				string text = string.Join(",", serBuf);
				Interaction.SaveSetting("Dtread", "RLY82", "Combo", text);
				ComboBoxSelectIndex(text);
			}
		}
	}

	private void Get_fillComboboxes(ComboBox _adc1, ComboBox _adc2, ComboBox _adc3, ComboBox _adc4, ComboBox _adc5, ComboBox _adc6, ComboBox _adc7, ComboBox _adc8, object Data)
	{
		Array array = Strings.Split(Conversions.ToString(Data), ",");
		try
		{
			_adc1.SelectedIndex = Conversions.ToInteger(array.GetValue(0));
			_adc2.SelectedIndex = Conversions.ToInteger(array.GetValue(1));
			_adc3.SelectedIndex = Conversions.ToInteger(array.GetValue(2));
			_adc4.SelectedIndex = Conversions.ToInteger(array.GetValue(3));
			_adc5.SelectedIndex = Conversions.ToInteger(array.GetValue(4));
			_adc6.SelectedIndex = Conversions.ToInteger(array.GetValue(5));
			_adc7.SelectedIndex = Conversions.ToInteger(array.GetValue(6));
			_adc8.SelectedIndex = Conversions.ToInteger(array.GetValue(7));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void ComboBoxSelectIndex(object Data)
	{
		try
		{
			BeginInvoke(new load_classes(Get_fillComboboxes), ComboBox_adc1, ComboBox_adc2, ComboBox_adc3, ComboBox_adc4, ComboBox_adc5, ComboBox_adc6, ComboBox_adc7, ComboBox_adc8, Data);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void RLY82SetRefVolts()
	{
		Array array = Strings.Split(Interaction.GetSetting("Dtread", "RLY82", "Combo", "0,0,0,0,0,0,2,2"), ",");
		Index = 1;
		checked
		{
			do
			{
				serBuf[0] = 129;
				serBuf[1] = (byte)Index;
				byte b = Conversions.ToByte(array.GetValue(Index - 1));
				serBuf[2] = b;
				Transmit(3);
				Index++;
			}
			while (Index <= 8);
		}
	}

	public void ControlChange(string ControlName, string Setting, string Data)
	{
		checked
		{
			try
			{
				if (base.Controls[ControlName].InvokeRequired)
				{
					SetControlCallback method = ControlChange;
					Invoke(method, ControlName, Setting, Data);
					return;
				}
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
				case "BackgroundImageLayout":
					if (Operators.CompareString(Data, "Zoom", TextCompare: false) == 0)
					{
						base.Controls[ControlName].BackgroundImageLayout = ImageLayout.Zoom;
					}
					else
					{
						base.Controls[ControlName].BackgroundImageLayout = ImageLayout.Stretch;
					}
					break;
				case "ForeColor":
					if (Operators.CompareString(Data, "White", TextCompare: false) == 0)
					{
						base.Controls[ControlName].ForeColor = Color.White;
					}
					else
					{
						base.Controls[ControlName].ForeColor = Color.FromArgb(128, 255, 255);
					}
					break;
				case "BackColor":
					switch (Data)
					{
					case "Red":
						base.Controls[ControlName].BackColor = Color.Red;
						break;
					case "Green":
						base.Controls[ControlName].BackColor = Color.Green;
						break;
					case "LightGreen":
						base.Controls[ControlName].BackColor = Color.LightGreen;
						break;
					}
					break;
				case "Tag":
					base.Controls[ControlName].Tag = Data;
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
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, Conversions.ToInteger(Data));
					break;
				case "Focus":
					base.Controls[ControlName].Select();
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
	}

	private void MainTimerEnable(bool enable)
	{
		if (enable)
		{
			MainTimerTM.Enabled = true;
		}
		else
		{
			MainTimerTM.Dispose();
		}
	}

	public void MainTimerTMEnable(bool enable)
	{
		try
		{
			Invoke(new SetTimerEnable(MainTimerEnable), enable);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MainTimerEnable(enable);
			ProjectData.ClearProjectError();
		}
	}

	private void Invisible_Click(object sender, EventArgs e)
	{
		base.Visible = false;
		Hide();
		ClearRelays();
		ClearInputOveride();
	}

	private void CommsTM_Tick(object sender, EventArgs e)
	{
		if (serialport.IsOpen)
		{
			BoardError = false;
			return;
		}
		SerialPortOpen();
		BoardError = true;
	}

	private void RLY82_Activated(object sender, EventArgs e)
	{
		AppendLabel(TitleName, base.Name);
		AppendTextBox(CommsNoBoard, Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0"));
		Port = Interaction.GetSetting("Health", "Setup", "Port" + base.Name, "0");
		GetSerialPortNames();
		ComboBox_comport.Items.Clear();
		foreach (string serialPortName in MyProject.Computer.Ports.SerialPortNames)
		{
			if (Conversions.ToInteger(Interaction.GetSetting("Health", "Setup", "COM" + serialPortName, Conversions.ToString(0))) == 0)
			{
				ComboBox_comport.Items.Add(serialPortName);
			}
		}
		ComboBox_comport.Items.Add("COM0");
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
}
