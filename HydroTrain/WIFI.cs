using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class WIFI : Form
{
	private delegate void UpdateDelegate(string s);

	public delegate void SetControl1Callback(string Data);

	public delegate void SetControl2Callback(string ControlName, string Data);

	public delegate void SetControl3Callback(string ControlName, string Setting, string Data);

	public delegate void SetTextCallback(string text);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LanSelected")]
	private Button _LanSelected;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Selectbt")]
	private Button _Selectbt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearData")]
	private Button _ClearData;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSend")]
	private Button _btnSend;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckLan")]
	private System.Windows.Forms.Timer _CheckLan;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListenTM")]
	private System.Windows.Forms.Timer _ListenTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NetworkcomputerTM")]
	private System.Windows.Forms.Timer _NetworkcomputerTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SendCtl")]
	private Button _SendCtl;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DemandTM")]
	private System.Windows.Forms.Timer _DemandTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WiFiSpeedTM")]
	private System.Windows.Forms.Timer _WiFiSpeedTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Invisible")]
	private Button _Invisible;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private System.Windows.Forms.Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommsDelay")]
	private TextBox _CommsDelay;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RecievedTM")]
	private System.Windows.Forms.Timer _RecievedTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WifiCommsTM")]
	private System.Windows.Forms.Timer _WifiCommsTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MemorySelected")]
	private Button _MemorySelected;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NetworkMemoryTM")]
	private System.Windows.Forms.Timer _NetworkMemoryTM;

	private Thread SendThread;

	private Thread GHAThread;

	public string HostNameAddress;

	public string HostIP4Address;

	public string HostIP6Address;

	public static int HostPort = 3000;

	public static int Port = 2000;

	public IPAddress AddressIP;

	public bool Comms;

	public string ReceivedDataHold;

	public long WiFiSpeed;

	public static bool WiFiOk;

	public static bool WifiComms;

	public static bool WifiComms1;

	public string DataMessage;

	public long PSCount;

	public string ClientNameAddress;

	public string ClientIP4Address;

	public string ClientIP6Address;

	public static int ClientPort = 3001;

	public TcpClient tcpClient;

	public string ClientMemoryNameAddress;

	public string ClientMemoryIP4Address;

	public string ClientMemoryIP6Address;

	public static int ClientMemoryPort = 4001;

	private bool SendFull;

	private bool LanOrMemCheck;

	private bool LanFound;

	private bool MemoryFound;

	private bool NetworkComputerDone;

	private bool ListAddressFound;

	private bool MemoryAddressFound;

	private string RemoteControl;

	private TcpListener Listener;

	private Thread thdListener;

	private bool NetworkThread;

	private string ItemName;

	private int ControlLevel;

	private string RuningData;

	[field: AccessedThroughProperty("Communication")]
	internal virtual TextBox Communication
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	internal virtual Button LanSelected
	{
		[CompilerGenerated]
		get
		{
			return _LanSelected;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = LanSelected_Click;
			Button button = _LanSelected;
			if (button != null)
			{
				button.Click -= value2;
			}
			_LanSelected = value;
			button = _LanSelected;
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ClientInfo")]
	internal virtual TextBox ClientInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SentData")]
	internal virtual TextBox SentData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Selection")]
	internal virtual ListBox Selection
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ErrorData")]
	internal virtual TextBox ErrorData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ReceivedData")]
	internal virtual TextBox ReceivedData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HostInfo")]
	internal virtual TextBox HostInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Selectbt
	{
		[CompilerGenerated]
		get
		{
			return _Selectbt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selectbt_Click;
			Button button = _Selectbt;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Selectbt = value;
			button = _Selectbt;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button ClearData
	{
		[CompilerGenerated]
		get
		{
			return _ClearData;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClearData_Click;
			Button button = _ClearData;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ClearData = value;
			button = _ClearData;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSend
	{
		[CompilerGenerated]
		get
		{
			return _btnSend;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Send_Click;
			Button button = _btnSend;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSend = value;
			button = _btnSend;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer CheckLan
	{
		[CompilerGenerated]
		get
		{
			return _CheckLan;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckLan_Tick;
			System.Windows.Forms.Timer timer = _CheckLan;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_CheckLan = value;
			timer = _CheckLan;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer ListenTM
	{
		[CompilerGenerated]
		get
		{
			return _ListenTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ListenTM_Tick;
			System.Windows.Forms.Timer timer = _ListenTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ListenTM = value;
			timer = _ListenTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer NetworkcomputerTM
	{
		[CompilerGenerated]
		get
		{
			return _NetworkcomputerTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NetworkcomputerTM_Tick;
			System.Windows.Forms.Timer timer = _NetworkcomputerTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_NetworkcomputerTM = value;
			timer = _NetworkcomputerTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Button SendCtl
	{
		[CompilerGenerated]
		get
		{
			return _SendCtl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SendCtl_Click;
			Button button = _SendCtl;
			if (button != null)
			{
				button.Click -= value2;
			}
			_SendCtl = value;
			button = _SendCtl;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer DemandTM
	{
		[CompilerGenerated]
		get
		{
			return _DemandTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DemandTM_Tick;
			System.Windows.Forms.Timer timer = _DemandTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_DemandTM = value;
			timer = _DemandTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("WiFiSpeedDisplay")]
	internal virtual TextBox WiFiSpeedDisplay
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer WiFiSpeedTM
	{
		[CompilerGenerated]
		get
		{
			return _WiFiSpeedTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WiFiSpeedTM_Tick;
			System.Windows.Forms.Timer timer = _WiFiSpeedTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_WiFiSpeedTM = value;
			timer = _WiFiSpeedTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("PSReceived")]
	internal virtual TextBox PSReceived
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

	[field: AccessedThroughProperty("ErrorCount")]
	internal virtual TextBox ErrorCount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckList")]
	internal virtual ListBox CheckList
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

	internal virtual TextBox CommsDelay
	{
		[CompilerGenerated]
		get
		{
			return _CommsDelay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CommsDelay_Click;
			TextBox textBox = _CommsDelay;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_CommsDelay = value;
			textBox = _CommsDelay;
			if (textBox != null)
			{
				textBox.Click += value2;
			}
		}
	}

	public virtual System.Windows.Forms.Timer RecievedTM
	{
		[CompilerGenerated]
		get
		{
			return _RecievedTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RecievedTM_Tick;
			System.Windows.Forms.Timer timer = _RecievedTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_RecievedTM = value;
			timer = _RecievedTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer WifiCommsTM
	{
		[CompilerGenerated]
		get
		{
			return _WifiCommsTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WifiCommsTM_Tick;
			System.Windows.Forms.Timer timer = _WifiCommsTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_WifiCommsTM = value;
			timer = _WifiCommsTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("WIFITitle")]
	internal virtual Label WIFITitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button MemorySelected
	{
		[CompilerGenerated]
		get
		{
			return _MemorySelected;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MemorySelected_Click;
			Button button = _MemorySelected;
			if (button != null)
			{
				button.Click -= value2;
			}
			_MemorySelected = value;
			button = _MemorySelected;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer NetworkMemoryTM
	{
		[CompilerGenerated]
		get
		{
			return _NetworkMemoryTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NetworkMemoryTM_Tick;
			System.Windows.Forms.Timer timer = _NetworkMemoryTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_NetworkMemoryTM = value;
			timer = _NetworkMemoryTM;
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CommsDelayTM")]
	private static System.Windows.Forms.Timer CommsDelayTM
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	} = new System.Windows.Forms.Timer();

	public WIFI()
	{
		base.Load += WIFI_Load;
		base.Activated += Network_Activated;
		HostNameAddress = "";
		HostIP4Address = "";
		HostIP6Address = "";
		ClientNameAddress = "";
		ClientIP4Address = "";
		ClientIP6Address = "";
		ClientMemoryNameAddress = "";
		ClientMemoryIP4Address = "";
		ClientMemoryIP6Address = "";
		Listener = null;
		thdListener = new Thread(CreateListener);
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
		this.Communication = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.LanSelected = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.ClientInfo = new System.Windows.Forms.TextBox();
		this.SentData = new System.Windows.Forms.TextBox();
		this.Selection = new System.Windows.Forms.ListBox();
		this.ErrorData = new System.Windows.Forms.TextBox();
		this.ReceivedData = new System.Windows.Forms.TextBox();
		this.HostInfo = new System.Windows.Forms.TextBox();
		this.Selectbt = new System.Windows.Forms.Button();
		this.ClearData = new System.Windows.Forms.Button();
		this.btnSend = new System.Windows.Forms.Button();
		this.CheckLan = new System.Windows.Forms.Timer(this.components);
		this.ListenTM = new System.Windows.Forms.Timer(this.components);
		this.NetworkcomputerTM = new System.Windows.Forms.Timer(this.components);
		this.SendCtl = new System.Windows.Forms.Button();
		this.DemandTM = new System.Windows.Forms.Timer(this.components);
		this.WiFiSpeedDisplay = new System.Windows.Forms.TextBox();
		this.WiFiSpeedTM = new System.Windows.Forms.Timer(this.components);
		this.Label6 = new System.Windows.Forms.Label();
		this.Invisible = new System.Windows.Forms.Button();
		this.PSReceived = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.ErrorCount = new System.Windows.Forms.TextBox();
		this.CheckList = new System.Windows.Forms.ListBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.CommsDelay = new System.Windows.Forms.TextBox();
		this.RecievedTM = new System.Windows.Forms.Timer(this.components);
		this.WifiCommsTM = new System.Windows.Forms.Timer(this.components);
		this.WIFITitle = new System.Windows.Forms.Label();
		this.MemorySelected = new System.Windows.Forms.Button();
		this.NetworkMemoryTM = new System.Windows.Forms.Timer(this.components);
		this.Label9 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.Communication.Location = new System.Drawing.Point(780, 285);
		this.Communication.Multiline = true;
		this.Communication.Name = "Communication";
		this.Communication.Size = new System.Drawing.Size(215, 61);
		this.Communication.TabIndex = 34;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(561, 255);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(29, 13);
		this.Label5.TabIndex = 33;
		this.Label5.Text = "Error";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(561, 56);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(53, 13);
		this.Label4.TabIndex = 32;
		this.Label4.Text = "Received";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(792, 56);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(29, 13);
		this.Label3.TabIndex = 31;
		this.Label3.Text = "Sent";
		this.LanSelected.Location = new System.Drawing.Point(21, 111);
		this.LanSelected.Name = "LanSelected";
		this.LanSelected.Size = new System.Drawing.Size(138, 31);
		this.LanSelected.TabIndex = 30;
		this.LanSelected.Text = "REMOTE";
		this.LanSelected.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(247, 175);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(33, 13);
		this.Label2.TabIndex = 29;
		this.Label2.Text = "Client";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(247, 59);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(29, 13);
		this.Label1.TabIndex = 28;
		this.Label1.Text = "Host";
		this.ClientInfo.Location = new System.Drawing.Point(250, 191);
		this.ClientInfo.Multiline = true;
		this.ClientInfo.Name = "ClientInfo";
		this.ClientInfo.Size = new System.Drawing.Size(305, 89);
		this.ClientInfo.TabIndex = 27;
		this.SentData.Location = new System.Drawing.Point(795, 75);
		this.SentData.Multiline = true;
		this.SentData.Name = "SentData";
		this.SentData.Size = new System.Drawing.Size(200, 182);
		this.SentData.TabIndex = 26;
		this.Selection.FormattingEnabled = true;
		this.Selection.Location = new System.Drawing.Point(21, 157);
		this.Selection.Name = "Selection";
		this.Selection.Size = new System.Drawing.Size(138, 160);
		this.Selection.TabIndex = 25;
		this.ErrorData.Location = new System.Drawing.Point(564, 314);
		this.ErrorData.Multiline = true;
		this.ErrorData.Name = "ErrorData";
		this.ErrorData.Size = new System.Drawing.Size(179, 69);
		this.ErrorData.TabIndex = 24;
		this.ReceivedData.Location = new System.Drawing.Point(564, 75);
		this.ReceivedData.Multiline = true;
		this.ReceivedData.Name = "ReceivedData";
		this.ReceivedData.Size = new System.Drawing.Size(200, 182);
		this.ReceivedData.TabIndex = 23;
		this.HostInfo.Location = new System.Drawing.Point(250, 75);
		this.HostInfo.Multiline = true;
		this.HostInfo.Name = "HostInfo";
		this.HostInfo.Size = new System.Drawing.Size(305, 89);
		this.HostInfo.TabIndex = 22;
		this.Selectbt.Location = new System.Drawing.Point(41, 327);
		this.Selectbt.Name = "Selectbt";
		this.Selectbt.Size = new System.Drawing.Size(101, 36);
		this.Selectbt.TabIndex = 21;
		this.Selectbt.Text = "Select";
		this.Selectbt.UseVisualStyleBackColor = true;
		this.ClearData.Location = new System.Drawing.Point(41, 373);
		this.ClearData.Name = "ClearData";
		this.ClearData.Size = new System.Drawing.Size(101, 36);
		this.ClearData.TabIndex = 20;
		this.ClearData.Text = "Clear Data";
		this.ClearData.UseVisualStyleBackColor = true;
		this.btnSend.Location = new System.Drawing.Point(758, 352);
		this.btnSend.Name = "btnSend";
		this.btnSend.Size = new System.Drawing.Size(101, 36);
		this.btnSend.TabIndex = 19;
		this.btnSend.Text = "Send";
		this.btnSend.UseVisualStyleBackColor = true;
		this.CheckLan.Interval = 2000;
		this.ListenTM.Interval = 1000;
		this.NetworkcomputerTM.Interval = 1000;
		this.SendCtl.Location = new System.Drawing.Point(906, 352);
		this.SendCtl.Name = "SendCtl";
		this.SendCtl.Size = new System.Drawing.Size(101, 36);
		this.SendCtl.TabIndex = 35;
		this.SendCtl.Text = "Control";
		this.SendCtl.UseVisualStyleBackColor = true;
		this.DemandTM.Interval = 2000;
		this.WiFiSpeedDisplay.Location = new System.Drawing.Point(183, 352);
		this.WiFiSpeedDisplay.Multiline = true;
		this.WiFiSpeedDisplay.Name = "WiFiSpeedDisplay";
		this.WiFiSpeedDisplay.Size = new System.Drawing.Size(35, 41);
		this.WiFiSpeedDisplay.TabIndex = 36;
		this.WiFiSpeedTM.Interval = 1000;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(180, 336);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(38, 13);
		this.Label6.TabIndex = 38;
		this.Label6.Text = "Speed";
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(933, 12);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(62, 46);
		this.Invisible.TabIndex = 164;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = true;
		this.PSReceived.Location = new System.Drawing.Point(300, 350);
		this.PSReceived.Multiline = true;
		this.PSReceived.Name = "PSReceived";
		this.PSReceived.Size = new System.Drawing.Size(84, 59);
		this.PSReceived.TabIndex = 165;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(297, 334);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(21, 13);
		this.Label7.TabIndex = 166;
		this.Label7.Text = "PS";
		this.ErrorCount.Location = new System.Drawing.Point(428, 350);
		this.ErrorCount.Multiline = true;
		this.ErrorCount.Name = "ErrorCount";
		this.ErrorCount.Size = new System.Drawing.Size(84, 59);
		this.ErrorCount.TabIndex = 167;
		this.CheckList.FormattingEnabled = true;
		this.CheckList.Location = new System.Drawing.Point(408, 16);
		this.CheckList.Name = "CheckList";
		this.CheckList.Size = new System.Drawing.Size(138, 43);
		this.CheckList.TabIndex = 168;
		this.Label8.AutoSize = true;
		this.Label8.Location = new System.Drawing.Point(684, 9);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(71, 13);
		this.Label8.TabIndex = 170;
		this.Label8.Text = "Comms Delay";
		this.CommsDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CommsDelay.Location = new System.Drawing.Point(761, 9);
		this.CommsDelay.Name = "CommsDelay";
		this.CommsDelay.Size = new System.Drawing.Size(100, 31);
		this.CommsDelay.TabIndex = 171;
		this.WifiCommsTM.Interval = 200;
		this.WIFITitle.AutoSize = true;
		this.WIFITitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.WIFITitle.Location = new System.Drawing.Point(31, 16);
		this.WIFITitle.Name = "WIFITitle";
		this.WIFITitle.Size = new System.Drawing.Size(128, 20);
		this.WIFITitle.TabIndex = 172;
		this.WIFITitle.Text = "WIFI Selection";
		this.MemorySelected.Location = new System.Drawing.Point(21, 56);
		this.MemorySelected.Name = "MemorySelected";
		this.MemorySelected.Size = new System.Drawing.Size(138, 31);
		this.MemorySelected.TabIndex = 173;
		this.MemorySelected.Text = "MEMORY";
		this.MemorySelected.UseVisualStyleBackColor = true;
		this.NetworkMemoryTM.Interval = 1000;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(24, 40);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(44, 13);
		this.Label9.TabIndex = 174;
		this.Label9.Text = "Memory";
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(18, 95);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(44, 13);
		this.Label10.TabIndex = 175;
		this.Label10.Text = "Remote";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1016, 430);
		base.ControlBox = false;
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.MemorySelected);
		base.Controls.Add(this.WIFITitle);
		base.Controls.Add(this.CommsDelay);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.CheckList);
		base.Controls.Add(this.ErrorCount);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.PSReceived);
		base.Controls.Add(this.Invisible);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.WiFiSpeedDisplay);
		base.Controls.Add(this.SendCtl);
		base.Controls.Add(this.Communication);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.LanSelected);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.ClientInfo);
		base.Controls.Add(this.SentData);
		base.Controls.Add(this.Selection);
		base.Controls.Add(this.ErrorData);
		base.Controls.Add(this.ReceivedData);
		base.Controls.Add(this.HostInfo);
		base.Controls.Add(this.Selectbt);
		base.Controls.Add(this.ClearData);
		base.Controls.Add(this.btnSend);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "WIFI";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "WIFI";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void HostInfoChange(string text)
	{
		if (HostInfo.InvokeRequired)
		{
			SetTextCallback method = HostInfoChange;
			Invoke(method, text);
		}
		else
		{
			HostInfo.Text = text;
		}
	}

	private void ClientInfoChange(string text)
	{
		if (ClientInfo.InvokeRequired)
		{
			SetTextCallback method = ClientInfoChange;
			Invoke(method, text);
		}
		else
		{
			ClientInfo.Text = text;
		}
	}

	private void SentDataChange(string text)
	{
		if (SentData.InvokeRequired)
		{
			SetTextCallback method = SentDataChange;
			Invoke(method, text);
		}
		else
		{
			SentData.Text = text;
		}
	}

	public void ReceivedDataChange(string text)
	{
		if (ReceivedData.InvokeRequired)
		{
			SetTextCallback method = ReceivedDataChange;
			Invoke(method, text);
		}
		else
		{
			ReceivedData.Text = text;
		}
	}

	private void TextBox1Change(string text)
	{
		if (Communication.InvokeRequired)
		{
			SetTextCallback method = TextBox1Change;
			Invoke(method, text);
		}
		else
		{
			Communication.Text = text;
		}
	}

	private void ErrorDataChange(string text)
	{
		if (ErrorData.InvokeRequired)
		{
			SetTextCallback method = ErrorDataChange;
			Invoke(method, text);
		}
		else
		{
			ErrorData.Text = text;
		}
	}

	private void ClearTextBox(string text)
	{
		if (ErrorData.InvokeRequired)
		{
			SetTextCallback method = ClearTextBox;
			Invoke(method, text);
		}
		else
		{
			Selection.Items.Clear();
		}
	}

	public void CommsDataChange(string text)
	{
		if (Communication.InvokeRequired)
		{
			SetTextCallback method = CommsDataChange;
			Invoke(method, text);
		}
		else
		{
			Communication.Text = text;
		}
	}

	public void PSReceivedChange(string text)
	{
		if (PSReceived.InvokeRequired)
		{
			SetTextCallback method = PSReceivedChange;
			Invoke(method, text);
		}
		else
		{
			PSReceived.Text = text;
		}
	}

	public void ErrorCountChange(string text)
	{
		if (ErrorCount.InvokeRequired)
		{
			SetTextCallback method = ErrorCountChange;
			Invoke(method, text);
		}
		else
		{
			ErrorCount.Text = text;
		}
	}

	private void GetHostAddressThreadStart()
	{
		GHAThread = new Thread(GetHostAddress)
		{
			IsBackground = true
		};
		GHAThread.Start();
	}

	private void GetHostAddress()
	{
		string hostName = Dns.GetHostName();
		HostIP4Address = "";
		HostIP6Address = "";
		string text = "WIFI Selection\r\n" + hostName;
		checked
		{
			try
			{
				HostNameAddress = hostName.ToUpper();
				HostInfoChange(HostInfo.Text + "Host Name: " + hostName + "\r\n");
				IPAddress[] addressList = Dns.GetHostEntry(hostName).AddressList;
				for (int i = 0; i < addressList.Length; i++)
				{
					AddressIP = addressList[i];
					if ((Operators.CompareString(AddressIP.AddressFamily.ToString(), "InterNetwork", TextCompare: false) == 0) & (Operators.CompareString(HostIP4Address, "", TextCompare: false) == 0))
					{
						HostIP4Address = AddressIP.ToString();
						string[] array = Strings.Split(HostIP4Address, ".");
						HostPort = (int)Math.Round(Conversion.Val(array[Microsoft.VisualBasic.Information.UBound(array)]));
					}
					if ((Operators.CompareString(AddressIP.AddressFamily.ToString(), "InterNetworkV6", TextCompare: false) == 0) & (Operators.CompareString(HostIP6Address, "", TextCompare: false) == 0))
					{
						HostIP6Address = AddressIP.ToString();
					}
				}
				HostInfoChange(HostInfo.Text + "Host IP Version 4 Address: " + HostIP4Address.ToString() + "\r\n");
				HostInfoChange(HostInfo.Text + "Host IP Version 6 Address: " + HostIP6Address.ToString() + "\r\n");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			Functions.RegUpdate("Dtread", "Treadmill", "HostLanName", HostNameAddress, "Save");
			Functions.RegUpdate("Dtread", "Treadmill", "HostLanIP4", HostIP4Address, "Save");
			Functions.RegUpdate("Dtread", "Treadmill", "HostLanIP6", HostIP6Address, "Save");
		}
	}

	private void SelectMem(object ItemSelected)
	{
		try
		{
			if (!Operators.ConditionalCompareObjectNotEqual(ItemSelected, string.Empty, TextCompare: false))
			{
				return;
			}
			int num = Selection.FindString(Conversions.ToString(ItemSelected));
			if (num == -1)
			{
				return;
			}
			Selection.SetSelected(num, value: true);
			ClientMemoryNameAddress = Selection.SelectedItem.ToString();
			IPAddress[] addressList = Dns.GetHostEntry(Selection.SelectedItem.ToString()).AddressList;
			for (int i = 0; i < addressList.Length; i = checked(i + 1))
			{
				AddressIP = addressList[i];
				switch (Convert.ToInt32((int)AddressIP.AddressFamily))
				{
				case 2:
				{
					ClientMemoryIP4Address = AddressIP.ToString();
					string[] array = Strings.Split(ClientMemoryIP4Address, ".");
					ClientMemoryPort = checked((int)Math.Round(Conversion.Val(array[Microsoft.VisualBasic.Information.UBound(array)])));
					break;
				}
				case 23:
					ClientMemoryIP6Address = AddressIP.ToString();
					break;
				}
			}
			Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryName", ClientMemoryNameAddress, "Save");
			Functions.RegUpdate("Dtread", "Treadmill", "ClienMemoryIP4", ClientMemoryIP4Address, "Save");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelectItem(object ItemSelected)
	{
		try
		{
			if (!Operators.ConditionalCompareObjectNotEqual(ItemSelected, string.Empty, TextCompare: false))
			{
				return;
			}
			int num = Selection.FindString(Conversions.ToString(ItemSelected));
			if (num != -1)
			{
				Selection.SetSelected(num, value: true);
				ClientInfoChange(Conversions.ToString(Operators.CompareString(ClientInfo.Text, "", TextCompare: false) == 0));
				ClientNameAddress = Selection.SelectedItem.ToString();
				ClientInfoChange("Client Name: " + Selection.SelectedItem.ToString() + "\r\n");
				IPAddress[] addressList = Dns.GetHostEntry(Selection.SelectedItem.ToString()).AddressList;
				for (int i = 0; i < addressList.Length; i = checked(i + 1))
				{
					AddressIP = addressList[i];
					switch (Convert.ToInt32((int)AddressIP.AddressFamily))
					{
					case 2:
					{
						ClientInfoChange(ClientInfo.Text + "Client IP Version 4 Address:  " + AddressIP.ToString() + "\r\n");
						ClientIP4Address = AddressIP.ToString();
						string[] array = Strings.Split(ClientIP4Address, ".");
						ClientPort = checked((int)Math.Round(Conversion.Val(array[Microsoft.VisualBasic.Information.UBound(array)])));
						break;
					}
					case 23:
						ClientInfoChange(ClientInfo.Text + "Client IP Version 6 Address:  " + AddressIP.ToString() + "\r\n");
						ClientIP6Address = AddressIP.ToString();
						break;
					}
				}
				Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", ClientNameAddress, "Save");
				Functions.RegUpdate("Dtread", "Treadmill", "ClientLanIP4", ClientIP4Address, "Save");
			}
			else
			{
				MessageBox.Show("The search string did not match any items in the ListBox");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Selectbt_Click(object sender, EventArgs e)
	{
		if (!LanOrMemCheck)
		{
			SelectedLan();
		}
		else
		{
			SelectedMem();
		}
	}

	private void SelectedLan()
	{
		try
		{
			if (Operators.CompareString(Selection.SelectedItem.ToString(), "", TextCompare: false) != 0)
			{
				ClientInfoChange(Conversions.ToString(Operators.CompareString(ClientInfo.Text, "", TextCompare: false) == 0));
				ClientNameAddress = Selection.SelectedItem.ToString();
				ClientInfoChange("Client Name: " + Selection.SelectedItem.ToString() + "\r\n");
				IPAddress[] addressList = Dns.GetHostEntry(Selection.SelectedItem.ToString()).AddressList;
				for (int i = 0; i < addressList.Length; i = checked(i + 1))
				{
					AddressIP = addressList[i];
					switch (Convert.ToInt32((int)AddressIP.AddressFamily))
					{
					case 2:
						ClientInfoChange(ClientInfo.Text + "Client IP Version 4 Address:  " + AddressIP.ToString() + "\r\n");
						ClientIP4Address = AddressIP.ToString();
						break;
					case 23:
						ClientInfoChange(ClientInfo.Text + "Client IP Version 6 Address:  " + AddressIP.ToString() + "\r\n");
						ClientIP6Address = AddressIP.ToString();
						break;
					}
				}
			}
			Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", ClientNameAddress, "Save");
			Functions.RegUpdate("Dtread", "Treadmill", "ClientLanIP4", ClientIP4Address, "Save");
			Functions.RegUpdate("Dtread", "Treadmill", "ClientLanIP6", ClientIP6Address, "Save");
			ListAddressFound = false;
			LanFound = false;
			ClientInfoChange("");
			IsNetworkComputersTicking();
			NetworkComputerDone = false;
			NetworkComputers();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SelectedMem()
	{
		try
		{
			if (Operators.CompareString(Selection.SelectedItem.ToString(), "", TextCompare: false) != 0)
			{
				ClientMemoryNameAddress = Selection.SelectedItem.ToString();
				IPAddress[] addressList = Dns.GetHostEntry(Selection.SelectedItem.ToString()).AddressList;
				for (int i = 0; i < addressList.Length; i = checked(i + 1))
				{
					AddressIP = addressList[i];
					switch (Convert.ToInt32((int)AddressIP.AddressFamily))
					{
					case 2:
						ClientMemoryIP4Address = AddressIP.ToString();
						break;
					case 23:
						ClientMemoryIP6Address = AddressIP.ToString();
						break;
					}
				}
			}
			Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryName", ClientMemoryNameAddress, "Save");
			Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryIP4", ClientMemoryIP4Address, "Save");
			Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryIP6", ClientMemoryIP6Address, "Save");
			MemoryFound = false;
			IsNetworkComputersTicking();
			NetworkMemoryTM.Enabled = true;
			NetworkComputerDone = false;
			NetworkComputers();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void ScreenCentre()
	{
		CenterToScreen();
	}

	public void UpdateSettings()
	{
		Display.WIFIStartup = false;
		CenterToScreen();
		GetHostAddressThreadStart();
		LanSelectedChange("Text", "Please Wait");
		LanSelectedChange("BackColor", "Red");
		NetworkComputers();
		IsNetworkComputersTicking();
		NetworkMemoryTM.Enabled = true;
		if (Operators.CompareString(Functions.RegUpdate("DTread", "File", "SerialFile1", "0", "Get"), "93C72B10FF93A", TextCompare: false) == 0)
		{
			RemoteControl = "REMOTE";
		}
		else if (Operators.CompareString(Functions.RegUpdate("DTread", "File", "SerialFile1", "0", "Get"), "C74A63F92AA83", TextCompare: false) == 0)
		{
			RemoteControl = "MAIN";
		}
		else
		{
			RemoteControl = "OFF";
		}
	}

	private void NetworkComputers()
	{
		if (!NetworkThread)
		{
			NetworkThread = true;
			Thread thread = new Thread(GetNetworkComputers)
			{
				IsBackground = true
			};
			thread.Start();
		}
	}

	private void AddListBoxItem(string s)
	{
		bool flag = false;
		if (Operators.CompareString(s, HostNameAddress, TextCompare: false) == 0)
		{
			return;
		}
		foreach (object item in Selection.Items)
		{
			string left = Conversions.ToString(item);
			if (Operators.CompareString(left, s, TextCompare: false) == 0)
			{
				flag = true;
			}
		}
		if (!flag)
		{
			Selection.Items.Add(s);
		}
		if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", "", "Get"), s, TextCompare: false) == 0)
		{
			LanFound = true;
			SelectItem(s);
			ListAddressFound = true;
		}
		if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryName", "", "Get"), s, TextCompare: false) == 0)
		{
			MemoryFound = true;
			SelectMem(s);
			MemoryAddressFound = true;
			MyProject.Forms.Display.MemError = false;
		}
		else if ((Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryName", "", "Get"), "", TextCompare: false) != 0) & !MemoryFound)
		{
			MyProject.Forms.Display.MemError = true;
		}
		else
		{
			MyProject.Forms.Display.MemError = false;
		}
	}

	private void GetNetworkComputers()
	{
		ArrayList arrayList = new ArrayList();
		DirectoryEntry directoryEntry = new DirectoryEntry
		{
			Path = "WinNT:"
		};
		foreach (DirectoryEntry child in directoryEntry.Children)
		{
			if (Operators.CompareString(child.SchemaClassName, "Domain", TextCompare: false) == 0)
			{
				arrayList.Add(child.Name);
			}
			child.Dispose();
		}
		foreach (object item in arrayList)
		{
			string text = Conversions.ToString(item);
			directoryEntry.Path = "WinNT://" + text;
			foreach (DirectoryEntry child2 in directoryEntry.Children)
			{
				if (Operators.CompareString(child2.SchemaClassName, "Computer", TextCompare: false) == 0)
				{
					UpdateDelegate method = AddListBoxItem;
					Invoke(method, child2.Name);
				}
				child2.Dispose();
			}
		}
		NetworkComputerDone = true;
		NetworkThread = false;
	}

	private void FoundLan()
	{
		if (LanFound)
		{
			LanSelectedChange("BackColor", "Green");
			LanSelectedChange("Text", Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", "", "Get"));
			ClientNameAddress = Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", "", "Get");
			ClientInfoChange("Client Name: " + ClientNameAddress + "\r\n");
			ClientIP4Address = Functions.RegUpdate("Dtread", "Treadmill", "ClientLanIP4", "", "Get");
			ClientInfoChange(ClientInfo.Text + "Client IP Version 4 Address:  " + ClientIP4Address + "\r\n");
			ClientIP6Address = Functions.RegUpdate("Dtread", "Treadmill", "ClientLanIP6", "", "Get");
			ClientInfoChange(ClientInfo.Text + "Client IP Version 6 Address:  " + ClientIP6Address + "\r\n");
			CheckLan.Dispose();
			ListenTM.Enabled = true;
			if (Operators.CompareString(RemoteControl, "REMOTE", TextCompare: false) == 0)
			{
				Functions.MainMapDriveLan(Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", "", "Get"));
			}
			return;
		}
		NetworkComputerDone = false;
		if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", "", "Get"), "", TextCompare: false) != 0)
		{
			LanSelectedChange("BackColor", "Red");
			LanSelectedChange("Text", Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", "", "Get"));
			if (ListAddressFound)
			{
				ListAddressFound = false;
				CheckLan.Enabled = true;
			}
		}
		else if (ListAddressFound)
		{
			LanSelectedChange("BackColor", "Orange");
			LanSelectedChange("Text", "Select");
		}
		else
		{
			CheckLan.Enabled = true;
		}
	}

	private void FoundMemory()
	{
		if (MemoryFound)
		{
			MemorySelectedChange("BackColor", "Green");
			MemorySelectedChange("Text", Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryName", "", "Get"));
			ClientMemoryNameAddress = Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryName", "", "Get");
			ClientMemoryIP4Address = Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryIP4", "", "Get");
			ClientMemoryIP6Address = Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryIP6", "", "Get");
			Functions.MainMapDriveMemory(Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryName", "", "Get"));
			return;
		}
		NetworkComputerDone = false;
		if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryName", "", "Get"), "", TextCompare: false) != 0)
		{
			MemorySelectedChange("BackColor", "Red");
			MemorySelectedChange("Text", Functions.RegUpdate("Dtread", "Treadmill", "ClientMemoryName", "", "Get"));
			if (MemoryAddressFound)
			{
				MemoryAddressFound = false;
				CheckLan.Enabled = true;
			}
		}
		else if (MemoryAddressFound)
		{
			MemorySelectedChange("BackColor", "Orange");
			MemorySelectedChange("Text", "Select");
		}
	}

	public void LanSelectedChange(string Setting, string Data)
	{
		try
		{
			if (LanSelected.InvokeRequired)
			{
				SetControl2Callback method = LanSelectedChange;
				Invoke(method, Setting, Data);
				return;
			}
			if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
			{
				LanSelected.Text = Data;
			}
			if (Operators.CompareString(Setting, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
				{
					LanSelected.Visible = false;
				}
				else
				{
					LanSelected.Visible = true;
				}
			}
			if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
			{
				if (Operators.CompareString(Data, "Left", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
					{
						LanSelected.TextAlign = ContentAlignment.TopCenter;
					}
				}
				else
				{
					LanSelected.TextAlign = (ContentAlignment)0;
				}
			}
			if (Operators.CompareString(Setting, "BackColor", TextCompare: false) == 0)
			{
				switch (Data)
				{
				case "Red":
					LanSelected.BackColor = Color.Red;
					break;
				case "Green":
					LanSelected.BackColor = Color.Green;
					break;
				case "Orange":
					LanSelected.BackColor = Color.Orange;
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

	public void MemorySelectedChange(string Setting, string Data)
	{
		try
		{
			if (MemorySelected.InvokeRequired)
			{
				SetControl2Callback method = MemorySelectedChange;
				Invoke(method, Setting, Data);
				return;
			}
			if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
			{
				MemorySelected.Text = Data;
			}
			if (Operators.CompareString(Setting, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
				{
					MemorySelected.Visible = false;
				}
				else
				{
					MemorySelected.Visible = true;
				}
			}
			if (Operators.CompareString(Setting, "TextAlign", TextCompare: false) == 0)
			{
				if (Operators.CompareString(Data, "Left", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Data, "Center", TextCompare: false) == 0)
					{
						MemorySelected.TextAlign = ContentAlignment.TopCenter;
					}
				}
				else
				{
					MemorySelected.TextAlign = (ContentAlignment)0;
				}
			}
			if (Operators.CompareString(Setting, "BackColor", TextCompare: false) == 0)
			{
				switch (Data)
				{
				case "Red":
					MemorySelected.BackColor = Color.Red;
					break;
				case "Green":
					MemorySelected.BackColor = Color.Green;
					break;
				case "Orange":
					MemorySelected.BackColor = Color.Orange;
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

	private void ListenTM_Tick(object sender, EventArgs e)
	{
		ListenTM.Dispose();
		DemandTM.Enabled = true;
	}

	private void NetworkMemoryTM_Tick(object sender, EventArgs e)
	{
		NetworkMemoryTM.Dispose();
		string text = "";
		try
		{
			if (Operators.ConditionalCompareObjectNotEqual(Selection.SelectedItem, null, TextCompare: false))
			{
				text = Selection.SelectedItem.ToString();
				if (NetworkComputerDone & (Operators.CompareString(text, "", TextCompare: false) != 0))
				{
					NetworkMemoryTM.Dispose();
					CheckLan.Enabled = true;
					FoundMemory();
				}
				else if ((Operators.CompareString(text, "", TextCompare: false) == 0) & NetworkComputerDone)
				{
					MemoryAddressFound = false;
					MemoryFound = false;
					NetworkMemoryTM.Enabled = true;
					NetworkComputerDone = false;
					NetworkComputers();
				}
			}
			else
			{
				NetworkComputers();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void IsNetworkComputersTicking()
	{
		if (!NetworkcomputerTM.Enabled)
		{
			NetworkcomputerTM.Enabled = true;
		}
	}

	private void NetworkcomputerTM_Tick(object sender, EventArgs e)
	{
		string text = "";
		try
		{
			if (Operators.ConditionalCompareObjectNotEqual(Selection.SelectedItem, null, TextCompare: false))
			{
				text = Selection.SelectedItem.ToString();
				if (NetworkComputerDone & (Operators.CompareString(text, "", TextCompare: false) != 0))
				{
					NetworkcomputerTM.Dispose();
					CheckLan.Enabled = true;
					FoundLan();
				}
				else if ((Operators.CompareString(text, "", TextCompare: false) == 0) & NetworkComputerDone)
				{
					ListAddressFound = false;
					LanFound = false;
					ClientInfoChange("");
					IsNetworkComputersTicking();
					NetworkComputerDone = false;
					NetworkComputers();
				}
			}
			else
			{
				NetworkComputers();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void CheckLan_Tick(object sender, EventArgs e)
	{
		CheckLan.Dispose();
		if (!NetworkComputerDone)
		{
			IsNetworkComputersTicking();
			NetworkComputerDone = false;
			NetworkComputers();
		}
	}

	private void LanSelected_Click(object sender, EventArgs e)
	{
		LanOrMemCheck = false;
		ListAddressFound = false;
		NetworkComputerDone = false;
		LanSelectedChange("BackColor", "Orange");
		IsNetworkComputersTicking();
		NetworkComputers();
	}

	private void MemorySelected_Click(object sender, EventArgs e)
	{
		LanOrMemCheck = true;
		MemoryAddressFound = false;
		NetworkComputerDone = false;
		MemorySelectedChange("BackColor", "Orange");
		NetworkMemoryTM.Enabled = true;
		NetworkComputers();
	}

	private void SendCtl_Click(object sender, EventArgs e)
	{
		SendControl();
	}

	private void SendControl()
	{
		string text = "";
		text = ((Operators.CompareString(RemoteControl, "MAIN", TextCompare: false) != 0) ? "DTA" : "CNT");
		SendDataThreadStart(text);
	}

	private void Send_Click(object sender, EventArgs e)
	{
		SendDataThreadStart("Hello");
	}

	private void SendDataThreadStart(object Message)
	{
		DataMessage = Conversions.ToString(Message);
		SendThread = new Thread(SendData)
		{
			IsBackground = true
		};
		try
		{
			SendThread.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SendData()
	{
		if (!SendFull && (((object)ClientIP4Address != "") & ((object)HostIP4Address != "")))
		{
			Connect(ClientIP4Address, DataMessage);
			Listen("Open");
		}
	}

	private void Connect(string serverIP, string message)
	{
		string text = "";
		SendFull = true;
		try
		{
			TcpClient tcpClient = new TcpClient(serverIP, Port)
			{
				ReceiveTimeout = 5
			};
			byte[] array = new byte[1025];
			array = Encoding.ASCII.GetBytes(message);
			NetworkStream stream = tcpClient.GetStream();
			stream.Write(array, 0, array.Length);
			stream.Flush();
			stream.Close();
			tcpClient.Close();
		}
		catch (ArgumentNullException ex)
		{
			ProjectData.SetProjectError(ex);
			ArgumentNullException ex2 = ex;
			text = "ArgumentNullException: " + ex2.ToString();
			ProjectData.ClearProjectError();
		}
		catch (SocketException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SocketException ex4 = ex3;
			text = "SocketException: " + ex4.ToString();
			if (this.tcpClient != null && this.tcpClient.Connected)
			{
				this.tcpClient.Close();
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			text = "Exception: " + ex6.ToString();
			ProjectData.ClearProjectError();
		}
		text = "Sent: " + message;
		SentDataChange(text);
		SendFull = false;
	}

	private void Listen(object Data)
	{
		if (Operators.ConditionalCompareObjectEqual(Data, "Open", TextCompare: false))
		{
			if (thdListener.ThreadState == System.Threading.ThreadState.Unstarted)
			{
				thdListener.Start();
				WiFiSpeedTM.Enabled = true;
			}
		}
		else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(Data, "Open", TextCompare: false), thdListener.IsAlive)))
		{
			Listener.Stop();
			thdListener.Abort();
			WiFiSpeedTM.Dispose();
		}
	}

	private void RecievedTM_Tick(object sender, EventArgs e)
	{
		RecievedTM.Dispose();
		if ((object)WifiSocket.ReceivedDataListener != "")
		{
			ReceiveData();
		}
		if ((object)WifiSocket.CommsData != "")
		{
			ReceivedCommsData();
		}
		if ((object)WifiSocket.SentData != "")
		{
			ReceivedSendData();
		}
	}

	private void ReceivedCommsData()
	{
		CommsDataChange(Communication.Text + WifiSocket.CommsData);
		WifiSocket.CommsData = "";
	}

	private void ReceivedSendData()
	{
		SentDataChange(Communication.Text + WifiSocket.SentData);
		WifiSocket.CommsData = "";
	}

	private void ReceivedTimerSet()
	{
		ReceiveData();
	}

	private void ReceiveData()
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		checked
		{
			try
			{
				NetworkStream stream = tcpClient.GetStream();
				byte[] array = new byte[129];
				StringBuilder stringBuilder = new StringBuilder();
				int num = 0;
				do
				{
					num = stream.Read(array, 0, array.Length);
					stringBuilder.AppendFormat("{0}", Encoding.ASCII.GetString(array, 0, num));
				}
				while (stream.DataAvailable);
				stream.Flush();
				stream.Close();
				ReceivedDataHold = stringBuilder.ToString();
				text = "Received: " + stringBuilder.ToString();
				text2 = "";
				string remoteControl = RemoteControl;
				if (Operators.CompareString(ReceivedDataHold, "", TextCompare: false) == 0)
				{
					return;
				}
				if (Strings.Mid(ReceivedDataHold, 1, 5).Equals("Hello"))
				{
					text2 = "Goodbye";
				}
				else if (Operators.CompareString(RemoteControl, "MAIN", TextCompare: false) == 0)
				{
					if (Strings.Mid(ReceivedDataHold, 1, 7).Equals("Control"))
					{
						Functions.RegUpdate("Dtread", "Treadmill", "DemandC", Functions.RegUpdate("Dtread", "Treadmill", "DemandC", "", "Get") + Strings.Mid(ReceivedDataHold, 9, Strings.Len(ReceivedDataHold)), "Save");
						text2 = "";
						text3 = "BTN";
						RuningData = "BTNC";
					}
					else if (Strings.Mid(ReceivedDataHold, 1, 3).Equals("CNT"))
					{
						text2 = "";
						text3 = "BTN";
						RuningData = "BTNC";
					}
					else if (Strings.Mid(ReceivedDataHold, 1, 3).Equals("BTN"))
					{
						text2 = "";
						text3 = "DTA";
						RuningData = "DTAC";
					}
					else
					{
						text2 = "CNT";
						RuningData = "CNT";
					}
				}
				else if (Operators.CompareString(RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					if (Strings.Mid(ReceivedDataHold, 1, 7).Equals("Buttons"))
					{
						Functions.RegUpdate("Dtread", "Treadmill", "DemandB", Strings.Mid(ReceivedDataHold, 9, Strings.Len(ReceivedDataHold)), "Save");
						text2 = "BTN";
						RuningData = "BTN";
					}
					else if (Strings.Mid(ReceivedDataHold, 1, 4).Equals("Data"))
					{
						Functions.RegUpdate("Dtread", "Treadmill", "DemandD", Strings.Mid(ReceivedDataHold, 6, Strings.Len(ReceivedDataHold)), "Save");
						text2 = "DTA";
						RuningData = "DTA";
					}
					else
					{
						text3 = "CNT";
						RuningData = "CNTC";
					}
				}
				else if (Strings.Mid(ReceivedDataHold, 1, 7).Equals("Control"))
				{
					text2 = "OK";
				}
				if (!Comms)
				{
					CommsDataChange(Communication.Text + "Connected");
					Comms = true;
					Functions.RegUpdate("Dtread", "Treadmill", "WifiComms", Conversions.ToString(Comms), "Save");
				}
				Functions.RegUpdate("Dtread", "Treadmill", "Demand", text2, "Save");
				if (Operators.CompareString(text2, "", TextCompare: false) != 0)
				{
					text = "Returned: " + text2;
					SendDataThreadStart(text2);
					text2 = "";
				}
				else if (Operators.CompareString(text3, "", TextCompare: false) != 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "Demand", text3, "Save");
					SendDataDemand(text3);
					text3 = "";
				}
				string text4 = "";
				short num2 = (short)Strings.Len(ReceivedDataHold);
				short num3 = 1;
				while (num3 <= num2 && Operators.CompareString(Strings.Mid(ReceivedDataHold, num3, 1), "\0", TextCompare: false) != 0)
				{
					text4 += Strings.Mid(ReceivedDataHold, num3, 1);
					num3 = (short)unchecked(num3 + 1);
				}
				ReceivedDataHold = text4;
				ReceivedDataChange("Received: " + ReceivedDataHold);
				ReceivedDataHold = "";
				string text5 = "";
				WiFiSpeed++;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (Operators.CompareString(ex2.Message, "A blocking operation was interrupted by a call to WSACancelBlockingCall", TextCompare: false) == 0)
				{
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	public void CreateListener()
	{
		string text = "";
		IPAddress localaddr = IPAddress.Parse(HostIP4Address);
		checked
		{
			try
			{
				if (Operators.CompareString(RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Port = 2000 + HostPort;
				}
				else
				{
					Port = 2000 + ClientPort;
				}
				Listener = new TcpListener(localaddr, Port);
				Listener.Start();
				CommsDataChange(Communication.Text + "Waiting for a connection...");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				CommsDataChange(Communication.Text + "Error: " + ex2.ToString());
				MessageBox.Show(text);
				ProjectData.ClearProjectError();
			}
			while (true)
			{
				try
				{
					WifiComms = false;
					tcpClient = Listener.AcceptTcpClient();
					WifiComms = true;
					if (Operators.CompareString(RemoteControl, "REMOTE", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "Demand", "BTN", "Get"), "BTN", TextCompare: false) == 0)
						{
							Thread.Sleep((int)Math.Round(140.0 + Conversion.Val(CommsDelay.Text)));
						}
						else if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "Demand", "BTN", "Get"), "DTA", TextCompare: false) == 0)
						{
							Thread.Sleep((int)Math.Round(90.0 + Conversion.Val(CommsDelay.Text)));
						}
						else if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "Demand", "BTN", "Get"), "CNT", TextCompare: false) == 0)
						{
							Thread.Sleep((int)Math.Round(90.0 + Conversion.Val(CommsDelay.Text)));
						}
						else
						{
							Thread.Sleep((int)Math.Round(100.0 + Conversion.Val(CommsDelay.Text)));
						}
					}
					else
					{
						Thread.Sleep((int)Math.Round(10.0 + Conversion.Val(CommsDelay.Text)));
					}
					ReceivedTimerSet();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
					break;
				}
			}
		}
	}

	private void SendDataDemand(object Command)
	{
		DemandTM.Dispose();
		if (Operators.ConditionalCompareObjectEqual(Command, "BTN", TextCompare: false))
		{
			string message = "Buttons:" + Functions.RegUpdate("Dtread", "Treadmill", "SendB", "", "Get");
			SendDataThreadStart(message);
		}
		else if (Operators.ConditionalCompareObjectEqual(Command, "DTA", TextCompare: false))
		{
			string message2 = "Data:" + Functions.RegUpdate("Dtread", "Treadmill", "SendD", "", "Get");
			SendDataThreadStart(message2);
		}
		else if (Operators.ConditionalCompareObjectEqual(Command, "CNT", TextCompare: false))
		{
			string message3 = "Control:" + Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get");
			Functions.RegUpdate("Dtread", "Treadmill", "SendC", ",Nil", "Save");
			SendDataThreadStart(message3);
		}
		else
		{
			SendDataThreadStart("Control:,Nil");
		}
		if (Operators.CompareString(RemoteControl, "REMOTE", TextCompare: false) == 0)
		{
			DemandTM.Enabled = true;
		}
	}

	private void ClearData_Click(object sender, EventArgs e)
	{
		Functions.RegUpdate("Dtread", "Treadmill", "ClientLanName", "", "Save");
		Functions.RegUpdate("Dtread", "Treadmill", "ClientLanIP4", "", "Save");
		Functions.RegUpdate("Dtread", "Treadmill", "ClientLanIP6", "", "Save");
		ListAddressFound = false;
		LanFound = false;
		MemoryFound = false;
		ClientInfoChange("");
		IsNetworkComputersTicking();
		NetworkMemoryTM.Enabled = true;
		NetworkComputerDone = false;
		NetworkComputers();
	}

	private void DemandTM_Tick(object sender, EventArgs e)
	{
		DemandTM.Dispose();
		if (Operators.CompareString(RemoteControl, "REMOTE", TextCompare: false) == 0)
		{
			SendDataDemand("CNT");
		}
	}

	private void WiFiSpeedTM_Tick(object sender, EventArgs e)
	{
		WiFiSpeedTM.Dispose();
		if (!WiFiOk & (WiFiSpeed == 0) & (Operators.CompareString(RemoteControl, "REMOTE", TextCompare: false) == 0))
		{
			SendControl();
		}
		else if (WiFiSpeed == 0)
		{
			WiFiOk = false;
			SendControl();
		}
		else
		{
			WiFiOk = true;
			if (Operators.CompareString(RemoteControl, "REMOTE", TextCompare: false) == 0)
			{
				WifiCommsTM.Enabled = true;
			}
		}
		WiFiSpeedDisplay.Text = WiFiSpeed.ToString();
		WiFiSpeed = 0L;
	}

	private void Invisible_Click(object sender, EventArgs e)
	{
		Hide();
	}

	private void WIFI_Load(object sender, EventArgs e)
	{
		if (Display.WIFIStartup)
		{
			Hide();
		}
		UpdateSettings();
	}

	private void Network_Activated(object sender, EventArgs e)
	{
		if (Display.EngPass)
		{
			base.Width = 1020;
			Invisible.Left = 934;
		}
		else
		{
			base.Width = 250;
			Invisible.Left = 172;
		}
		CommsDelayChange(Interaction.GetSetting("Health", "Setup", "Delay" + base.Name, "150"));
	}

	private void CommsSetting()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsDelay", TextCompare: false) == 0)
		{
			if (Operators.CompareString(CommsDelay.Text, "", TextCompare: false) == 0)
			{
				CommsDelayChange("10");
			}
			MyProject.Forms.InfoEnter.Preload = CommsDelay.Text;
			InfoEnter.PasswordSet = CommsDelay.Text;
		}
	}

	private void CommsDelayChange(string text)
	{
		if (CommsDelay.InvokeRequired)
		{
			SetTextCallback method = CommsDelayChange;
			Invoke(method, text);
		}
		else
		{
			CommsDelay.Text = text;
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "CommsDelay", TextCompare: false) == 0)
		{
			CommsDelay.TextAlign = HorizontalAlignment.Left;
			CommsDelayChange(InfoEnter.PasswordSet);
		}
		if (!InfoEnter.ControlKey)
		{
			string itemName2 = ItemName;
			if (Operators.CompareString(itemName2, "CommsDelay", TextCompare: false) == 0 && Operators.CompareString(CommsDelay.Text, "", TextCompare: false) != 0)
			{
				CommsDelayChange(Conversions.ToString(Conversion.Val(CommsDelay.Text)));
				Interaction.SaveSetting("Health", "Setup", "Delay" + base.Name, CommsDelay.Text);
			}
			MyProject.Forms.InfoEnter.Preload = "";
			InfoEnter.PasswordSet = "";
			InfoEnterTM.Dispose();
			ControlLevel = 0;
		}
	}

	private void CommsDelay_Click(object sender, EventArgs e)
	{
		if ((ControlLevel == 0) & !Display.ProgramRun)
		{
			ItemName = "CommsDelay";
			CommsSetting();
			ControlLevel = 1;
		}
	}

	private void WifiCommsTM_Tick(object sender, EventArgs e)
	{
		WifiCommsTM.Dispose();
		string text = "";
		if (!WifiComms & !WifiComms1)
		{
			WifiComms1 = true;
		}
		else if (!WifiComms & WifiComms1)
		{
			WifiComms1 = false;
			if (Strings.Len(RuningData) > 3)
			{
				text = Strings.Mid(RuningData, 1, 3);
				SendDataDemand(text);
			}
			else
			{
				SendDataThreadStart(RuningData);
			}
		}
		else if (WifiComms)
		{
			WifiComms1 = false;
		}
	}
}
