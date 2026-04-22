using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HydroTrain.My;
using HydroTrain.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace HydroTrain;

[DesignerGenerated]
public class NameListSort : Form
{
	public delegate void SetTextCallback(string text);

	public delegate void SetIntCallback(int Index, string text);

	public delegate void SetSTRCallback(string text, string textA);

	public delegate void SetControlCallback(bool Data);

	public delegate void SetControl1Callback(string ControlName, bool Data);

	public delegate void SetControl2Callback(string ControlName, string Setting, string Data);

	public delegate void SetControl3Callback(string ControlContainerA, string ControlName, string Setting, string Data);

	public delegate void SetControl4Callback(string ControlContainerB, string ControlContainerA, string ControlName, string Setting, string Data);

	private enum PrinterStatus
	{
		PrinterIdle = 3,
		PrinterPrinting,
		PrinterWarmingUp
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NameListView")]
	private ListView _NameListView;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CloseFrm")]
	private Button _CloseFrm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Accept")]
	private Button _Accept;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DelName")]
	private Button _DelName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveList")]
	private Button _SaveList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("History")]
	private Button _History;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OlderRecord")]
	private Button _OlderRecord;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NewerRecord")]
	private Button _NewerRecord;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintIt")]
	private Button _PrintIt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckPrinterStatus")]
	private System.Windows.Forms.Timer _CheckPrinterStatus;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Transfer")]
	private Button _Transfer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Searchbox")]
	private TextBox _Searchbox;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private System.Windows.Forms.Timer _InfoEnterTM;

	private Thread demoThread;

	private static string ItemName;

	private static int ControlLevel;

	private static int SearchboxHeight;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PrintDocumentForm")]
	private PrintDocument _PrintDocumentForm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MPrintDocument")]
	private PrintDocument _MPrintDocument;

	private Bitmap mPrintBitMap;

	private string InfoYesNo;

	private string DirPath;

	private Array HistoryPDF;

	private string OneDrivePath;

	private string GooglePath;

	public bool ScreenResSet;

	public float ResMultiW;

	public float ResMultiH;

	private int OriginScreenResW;

	private int OriginScreenResH;

	private int ScreenResW;

	private int ScreenResH;

	private string NamePerson;

	private string AnimalNamePerson;

	private string IDPerson;

	private string PersonSex;

	private DateTime DOBPerson;

	private DateTime REFPerson;

	private string BreedPerson;

	private string HeightPerson;

	private string WeightPerson;

	private string TrainerPerson;

	private string ImportantPerson;

	private string PostCodePerson;

	private string HouseNoPerson;

	private string Duration;

	private int SpeedProgram;

	private int SetMaxSpeed;

	private float SetMaxSpeedkmh;

	private int GradientProgram;

	private int SetMaxGradient;

	private string CalorieDry;

	private string CalorieWet;

	private object RecordsDisplayedMax;

	public static string[] DateTimeFileNameHistory = new string[1001];

	private int HistoryIndex;

	public static string[] DateTimeHistory = new string[1001];

	public static string[] ReportNumberHistory = new string[1001];

	private string[] KeyNoHistory;

	public static string[] TrainerHistory = new string[1001];

	public static string[] NamePersonHistory = new string[1001];

	public static string[] RefPersonHistory = new string[1001];

	public static string[] DirectionHistory = new string[1001];

	public static string[] BMIHistory = new string[1001];

	public static string[] AnimalNameHistory = new string[1001];

	public static string[] IDHistory = new string[1001];

	public static string[] PostCodeHistory = new string[1001];

	public static string[] HouseNoHistory = new string[1001];

	public static string[] DOBHistory = new string[1001];

	public static string[] SexHistory = new string[1001];

	public static string[] WeightHistory = new string[1001];

	public static string[] HeightHistory = new string[1001];

	public static string[] BreedHistory = new string[1001];

	public static string[] ProgramSHistory = new string[1001];

	public static string[] ProgramGHistory = new string[1001];

	public static string[] TimeHistory = new string[1001];

	public static string[] DurationHistory = new string[1001];

	public static string[] RestTimeHistory = new string[1001];

	public static string[] RestTotalHistory = new string[1001];

	public static string[] SpeedHistory = new string[1001];

	public static string[] GradientHistory = new string[1001];

	public static string[] DistanceHistory = new string[1001];

	public static string[] MaxkmhHistory = new string[1001];

	public static string[] MaxDegHistory = new string[1001];

	public static string[] MaxPercentHistory = new string[1001];

	public static string[] WaterDepthHistory = new string[1001];

	public static string[] CalorieDryHistory = new string[1001];

	public static string[] CalorieWetHistory = new string[1001];

	public static string[] RestHistory = new string[1001];

	public static string[] TemperatureHistory = new string[1001];

	public static string[] JetHistory = new string[1001];

	private int HistoryIndexMax;

	private string HistoryDir;

	public static int HistoryUpperIndex;

	public int HistoryUpperIndexArchive;

	private int RecordNumber;

	private string ReportOldDay;

	private int ReportAddNum;

	private int ScreenSizeH;

	private int ScreenSizeW;

	private string SpeedHistoryStr;

	private string GradientHistoryStr;

	private string TimeHistoryStr;

	private string RestTimeHistoryStr;

	private string DistanceHistoryStr;

	private string WaterHistoryStr;

	private string CalorieHistoryDryStr;

	private string CalorieHistoryWetStr;

	private string RestHistoryStr;

	private string TemperatureHistoryStr;

	private string JetHistoryStr;

	private float TimeLapse;

	private float TimeHold;

	private string TimePassStr;

	private bool ChartSet;

	public ListView.SelectedListViewItemCollection Selected;

	internal virtual ListView NameListView
	{
		[CompilerGenerated]
		get
		{
			return _NameListView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ColumnClickEventHandler value2 = NameListView_ColumnClick;
			EventHandler value3 = NameListView_SelectedIndexChanged;
			ListView listView = _NameListView;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
				listView.SelectedIndexChanged -= value3;
			}
			_NameListView = value;
			listView = _NameListView;
			if (listView != null)
			{
				listView.ColumnClick += value2;
				listView.SelectedIndexChanged += value3;
			}
		}
	}

	internal virtual Button CloseFrm
	{
		[CompilerGenerated]
		get
		{
			return _CloseFrm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CloseFrm_Click;
			Button button = _CloseFrm;
			if (button != null)
			{
				button.Click -= value2;
			}
			_CloseFrm = value;
			button = _CloseFrm;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PersonName")]
	internal virtual TextBox PersonName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Animal")]
	internal virtual TextBox Animal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ID")]
	internal virtual TextBox ID
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Accept
	{
		[CompilerGenerated]
		get
		{
			return _Accept;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Accept_Click;
			Button button = _Accept;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Accept = value;
			button = _Accept;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button DelName
	{
		[CompilerGenerated]
		get
		{
			return _DelName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DelName_Click;
			Button button = _DelName;
			if (button != null)
			{
				button.Click -= value2;
			}
			_DelName = value;
			button = _DelName;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button SaveList
	{
		[CompilerGenerated]
		get
		{
			return _SaveList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SaveList_Click;
			Button button = _SaveList;
			if (button != null)
			{
				button.Click -= value2;
			}
			_SaveList = value;
			button = _SaveList;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button History
	{
		[CompilerGenerated]
		get
		{
			return _History;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = History_Click;
			Button button = _History;
			if (button != null)
			{
				button.Click -= value2;
			}
			_History = value;
			button = _History;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ChartHistory")]
	internal virtual Chart ChartHistory
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OlderRecord
	{
		[CompilerGenerated]
		get
		{
			return _OlderRecord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OlderRecord_Click;
			Button button = _OlderRecord;
			if (button != null)
			{
				button.Click -= value2;
			}
			_OlderRecord = value;
			button = _OlderRecord;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button NewerRecord
	{
		[CompilerGenerated]
		get
		{
			return _NewerRecord;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NewerRecord_Click;
			Button button = _NewerRecord;
			if (button != null)
			{
				button.Click -= value2;
			}
			_NewerRecord = value;
			button = _NewerRecord;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoBox")]
	internal virtual RichTextBox DoBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button PrintIt
	{
		[CompilerGenerated]
		get
		{
			return _PrintIt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PrintIt_Click;
			Button button = _PrintIt;
			if (button != null)
			{
				button.Click -= value2;
			}
			_PrintIt = value;
			button = _PrintIt;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer CheckPrinterStatus
	{
		[CompilerGenerated]
		get
		{
			return _CheckPrinterStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckPrinterStatus_Tick;
			System.Windows.Forms.Timer timer = _CheckPrinterStatus;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_CheckPrinterStatus = value;
			timer = _CheckPrinterStatus;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Button Transfer
	{
		[CompilerGenerated]
		get
		{
			return _Transfer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Transfer_Click;
			Button button = _Transfer;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Transfer = value;
			button = _Transfer;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("HistoryTextImage")]
	internal virtual PictureBox HistoryTextImage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox Searchbox
	{
		[CompilerGenerated]
		get
		{
			return _Searchbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Searchbox_Click;
			TextBox textBox = _Searchbox;
			if (textBox != null)
			{
				textBox.Click -= value2;
			}
			_Searchbox = value;
			textBox = _Searchbox;
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

	[field: AccessedThroughProperty("SearchPic")]
	internal virtual PictureBox SearchPic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	private virtual PrintDocument PrintDocumentForm
	{
		[CompilerGenerated]
		get
		{
			return _PrintDocumentForm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = PrintDocumentForm_PrintPage;
			PrintDocument printDocument = _PrintDocumentForm;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_PrintDocumentForm = value;
			printDocument = _PrintDocumentForm;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	private virtual PrintDocument MPrintDocument
	{
		[CompilerGenerated]
		get
		{
			return _MPrintDocument;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = M_PrintDocument_PrintPage;
			PrintDocument printDocument = _MPrintDocument;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_MPrintDocument = value;
			printDocument = _MPrintDocument;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	public NameListSort()
	{
		base.Activated += NameListSort_Activated;
		base.Load += NameList_Load;
		demoThread = null;
		PrintDocumentForm = new PrintDocument();
		MPrintDocument = new PrintDocument();
		RecordsDisplayedMax = 50;
		HistoryIndex = 1000;
		KeyNoHistory = new string[1001];
		ReportOldDay = "00";
		ReportAddNum = 1;
		SpeedHistoryStr = "";
		GradientHistoryStr = "";
		TimeHistoryStr = "";
		RestTimeHistoryStr = "";
		DistanceHistoryStr = "";
		WaterHistoryStr = "";
		CalorieHistoryDryStr = "";
		CalorieHistoryWetStr = "";
		RestHistoryStr = "";
		TemperatureHistoryStr = "";
		JetHistoryStr = "";
		TimeLapse = 0f;
		TimeHold = 0f;
		TimePassStr = "";
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
		System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
		System.Windows.Forms.DataVisualization.Charting.Legend legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
		this.NameListView = new System.Windows.Forms.ListView();
		this.CloseFrm = new System.Windows.Forms.Button();
		this.PersonName = new System.Windows.Forms.TextBox();
		this.Animal = new System.Windows.Forms.TextBox();
		this.ID = new System.Windows.Forms.TextBox();
		this.Accept = new System.Windows.Forms.Button();
		this.DelName = new System.Windows.Forms.Button();
		this.SaveList = new System.Windows.Forms.Button();
		this.History = new System.Windows.Forms.Button();
		this.ChartHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
		this.OlderRecord = new System.Windows.Forms.Button();
		this.NewerRecord = new System.Windows.Forms.Button();
		this.DoBox = new System.Windows.Forms.RichTextBox();
		this.PrintIt = new System.Windows.Forms.Button();
		this.CheckPrinterStatus = new System.Windows.Forms.Timer(this.components);
		this.Transfer = new System.Windows.Forms.Button();
		this.Searchbox = new System.Windows.Forms.TextBox();
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.SearchPic = new System.Windows.Forms.PictureBox();
		this.HistoryTextImage = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.ChartHistory).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.SearchPic).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.HistoryTextImage).BeginInit();
		base.SuspendLayout();
		this.NameListView.BackColor = System.Drawing.Color.Navy;
		this.NameListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.NameListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.NameListView.ForeColor = System.Drawing.Color.White;
		this.NameListView.HideSelection = false;
		this.NameListView.Location = new System.Drawing.Point(10, 10);
		this.NameListView.MultiSelect = false;
		this.NameListView.Name = "NameListView";
		this.NameListView.ShowGroups = false;
		this.NameListView.Size = new System.Drawing.Size(886, 330);
		this.NameListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
		this.NameListView.TabIndex = 0;
		this.NameListView.UseCompatibleStateImageBehavior = false;
		this.CloseFrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.CloseFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CloseFrm.ForeColor = System.Drawing.Color.White;
		this.CloseFrm.Location = new System.Drawing.Point(828, 376);
		this.CloseFrm.Name = "CloseFrm";
		this.CloseFrm.Size = new System.Drawing.Size(66, 50);
		this.CloseFrm.TabIndex = 1;
		this.CloseFrm.Text = "X";
		this.CloseFrm.UseVisualStyleBackColor = true;
		this.PersonName.BackColor = System.Drawing.Color.Teal;
		this.PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.PersonName.ForeColor = System.Drawing.Color.White;
		this.PersonName.Location = new System.Drawing.Point(140, 375);
		this.PersonName.Name = "PersonName";
		this.PersonName.Size = new System.Drawing.Size(194, 26);
		this.PersonName.TabIndex = 2;
		this.Animal.BackColor = System.Drawing.Color.Teal;
		this.Animal.ForeColor = System.Drawing.Color.White;
		this.Animal.Location = new System.Drawing.Point(245, 407);
		this.Animal.Name = "Animal";
		this.Animal.Size = new System.Drawing.Size(90, 20);
		this.Animal.TabIndex = 3;
		this.ID.BackColor = System.Drawing.Color.Teal;
		this.ID.ForeColor = System.Drawing.Color.White;
		this.ID.Location = new System.Drawing.Point(140, 407);
		this.ID.Name = "ID";
		this.ID.Size = new System.Drawing.Size(90, 20);
		this.ID.TabIndex = 4;
		this.Accept.BackColor = System.Drawing.Color.Teal;
		this.Accept.FlatAppearance.BorderSize = 5;
		this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Accept.ForeColor = System.Drawing.Color.White;
		this.Accept.Location = new System.Drawing.Point(12, 376);
		this.Accept.Name = "Accept";
		this.Accept.Size = new System.Drawing.Size(100, 50);
		this.Accept.TabIndex = 6;
		this.Accept.Text = "Accept Selection";
		this.Accept.UseVisualStyleBackColor = false;
		this.DelName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.DelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DelName.ForeColor = System.Drawing.Color.White;
		this.DelName.Location = new System.Drawing.Point(456, 376);
		this.DelName.Name = "DelName";
		this.DelName.Size = new System.Drawing.Size(84, 50);
		this.DelName.TabIndex = 7;
		this.DelName.Text = "Delete Selection";
		this.DelName.UseVisualStyleBackColor = true;
		this.SaveList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.SaveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.SaveList.ForeColor = System.Drawing.Color.White;
		this.SaveList.Location = new System.Drawing.Point(736, 376);
		this.SaveList.Name = "SaveList";
		this.SaveList.Size = new System.Drawing.Size(81, 50);
		this.SaveList.TabIndex = 8;
		this.SaveList.Text = "Save Changes";
		this.SaveList.UseVisualStyleBackColor = true;
		this.History.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.History.ForeColor = System.Drawing.Color.White;
		this.History.Location = new System.Drawing.Point(556, 376);
		this.History.Name = "History";
		this.History.Size = new System.Drawing.Size(74, 50);
		this.History.TabIndex = 9;
		this.History.Text = "History";
		this.History.UseVisualStyleBackColor = true;
		this.History.Visible = false;
		this.ChartHistory.BorderlineWidth = 0;
		chartArea.Name = "ChartArea1";
		this.ChartHistory.ChartAreas.Add(chartArea);
		legend.Name = "HistoryLG";
		legend.Title = "History";
		legend.TitleAlignment = System.Drawing.StringAlignment.Near;
		this.ChartHistory.Legends.Add(legend);
		this.ChartHistory.Location = new System.Drawing.Point(10, 115);
		this.ChartHistory.Name = "ChartHistory";
		this.ChartHistory.Size = new System.Drawing.Size(886, 55);
		this.ChartHistory.TabIndex = 11;
		this.ChartHistory.Text = "HistoryChart";
		this.ChartHistory.Visible = false;
		this.OlderRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.OlderRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.OlderRecord.ForeColor = System.Drawing.Color.White;
		this.OlderRecord.Location = new System.Drawing.Point(139, 376);
		this.OlderRecord.Name = "OlderRecord";
		this.OlderRecord.Size = new System.Drawing.Size(84, 50);
		this.OlderRecord.TabIndex = 12;
		this.OlderRecord.Text = "Older";
		this.OlderRecord.UseVisualStyleBackColor = true;
		this.OlderRecord.Visible = false;
		this.NewerRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.NewerRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.NewerRecord.ForeColor = System.Drawing.Color.White;
		this.NewerRecord.Location = new System.Drawing.Point(248, 376);
		this.NewerRecord.Name = "NewerRecord";
		this.NewerRecord.Size = new System.Drawing.Size(84, 50);
		this.NewerRecord.TabIndex = 13;
		this.NewerRecord.Text = "Newer";
		this.NewerRecord.UseVisualStyleBackColor = true;
		this.NewerRecord.Visible = false;
		this.DoBox.Location = new System.Drawing.Point(118, 374);
		this.DoBox.Name = "DoBox";
		this.DoBox.Size = new System.Drawing.Size(24, 23);
		this.DoBox.TabIndex = 159;
		this.DoBox.Text = "";
		this.DoBox.Visible = false;
		this.PrintIt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.PrintIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.PrintIt.ForeColor = System.Drawing.Color.White;
		this.PrintIt.Location = new System.Drawing.Point(646, 376);
		this.PrintIt.Name = "PrintIt";
		this.PrintIt.Size = new System.Drawing.Size(74, 50);
		this.PrintIt.TabIndex = 160;
		this.PrintIt.Text = "Print";
		this.PrintIt.UseVisualStyleBackColor = true;
		this.PrintIt.Visible = false;
		this.CheckPrinterStatus.Interval = 1000;
		this.Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Transfer.ForeColor = System.Drawing.Color.White;
		this.Transfer.Location = new System.Drawing.Point(357, 376);
		this.Transfer.Name = "Transfer";
		this.Transfer.Size = new System.Drawing.Size(84, 50);
		this.Transfer.TabIndex = 161;
		this.Transfer.Text = "Transfer";
		this.Transfer.UseVisualStyleBackColor = true;
		this.Searchbox.BackColor = System.Drawing.Color.Teal;
		this.Searchbox.ForeColor = System.Drawing.Color.White;
		this.Searchbox.Location = new System.Drawing.Point(10, 346);
		this.Searchbox.Name = "Searchbox";
		this.Searchbox.Size = new System.Drawing.Size(220, 20);
		this.Searchbox.TabIndex = 164;
		this.InfoEnterTM.Interval = 300;
		this.SearchPic.BackgroundImage = HydroTrain.My.Resources.Resources.SearchSymbol;
		this.SearchPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.SearchPic.Location = new System.Drawing.Point(236, 346);
		this.SearchPic.Name = "SearchPic";
		this.SearchPic.Size = new System.Drawing.Size(21, 20);
		this.SearchPic.TabIndex = 165;
		this.SearchPic.TabStop = false;
		this.HistoryTextImage.Location = new System.Drawing.Point(10, 10);
		this.HistoryTextImage.Name = "HistoryTextImage";
		this.HistoryTextImage.Size = new System.Drawing.Size(886, 104);
		this.HistoryTextImage.TabIndex = 163;
		this.HistoryTextImage.TabStop = false;
		this.HistoryTextImage.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Teal;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.CausesValidation = false;
		base.ClientSize = new System.Drawing.Size(906, 434);
		base.Controls.Add(this.SearchPic);
		base.Controls.Add(this.Searchbox);
		base.Controls.Add(this.HistoryTextImage);
		base.Controls.Add(this.Transfer);
		base.Controls.Add(this.PrintIt);
		base.Controls.Add(this.DoBox);
		base.Controls.Add(this.NewerRecord);
		base.Controls.Add(this.OlderRecord);
		base.Controls.Add(this.ChartHistory);
		base.Controls.Add(this.History);
		base.Controls.Add(this.SaveList);
		base.Controls.Add(this.DelName);
		base.Controls.Add(this.Accept);
		base.Controls.Add(this.ID);
		base.Controls.Add(this.Animal);
		base.Controls.Add(this.PersonName);
		base.Controls.Add(this.CloseFrm);
		base.Controls.Add(this.NameListView);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "NameListSort";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Name List";
		base.TopMost = true;
		base.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		((System.ComponentModel.ISupportInitialize)this.ChartHistory).EndInit();
		((System.ComponentModel.ISupportInitialize)this.SearchPic).EndInit();
		((System.ComponentModel.ISupportInitialize)this.HistoryTextImage).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void NameListView_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		ListViewSorter listViewItemSorter = new ListViewSorter(e.Column, ListViewSorter.EnumSortOrder.Ascending);
		NameListView.ListViewItemSorter = listViewItemSorter;
	}

	private void SetResScreen()
	{
		checked
		{
			if (!ScreenResSet)
			{
				ScreenResSet = true;
				base.Top = MyProject.Forms.Information.Top;
				base.Left = MyProject.Forms.Information.Left;
				base.Width = MyProject.Forms.Information.Width;
				base.Height = MyProject.Forms.Information.Height;
				ResMultiW = (float)((double)base.Width / 906.0);
				ResMultiH = (float)((double)base.Height / 434.0);
				float num = ((!(ResMultiW < ResMultiH)) ? ((float)(1.0 + (double)(ResMultiH - 1f) * 0.8)) : ((float)(1.0 + (double)(ResMultiW - 1f) * 0.8)));
				NameListView.Height = (int)Math.Round((float)NameListView.Height * ResMultiH);
				NameListView.Width = (int)Math.Round((float)NameListView.Width * ResMultiW);
				Searchbox.Top = NameListView.Top + NameListView.Height + 6;
				Searchbox.Left = NameListView.Left;
				SearchPic.Top = Searchbox.Top;
				SearchPic.Left = Searchbox.Left + Searchbox.Width + 4;
				SearchboxHeight = Searchbox.Top + Searchbox.Height;
				HistoryTextImage.Top = NameListView.Top;
				HistoryTextImage.Left = NameListView.Left;
				HistoryTextImage.Width = NameListView.Width;
				HistoryTextImage.Top = NameListView.Top;
				HistoryTextImage.Left = NameListView.Left;
				HistoryTextImage.Width = NameListView.Width;
				ChartHistory.Top = HistoryTextImage.Top + HistoryTextImage.Height;
				ChartHistory.Left = HistoryTextImage.Left;
				ChartHistory.Height = SearchboxHeight - ChartHistory.Top;
				ChartHistory.Width = HistoryTextImage.Width;
				Accept.Top = (int)Math.Round((float)Accept.Top * ResMultiH);
				Accept.Left = NameListView.Left;
				Accept.Height = (int)Math.Round((float)Accept.Height * ResMultiH);
				Accept.Width = (int)Math.Round((float)Accept.Width * ResMultiW);
				Accept.Font = new Font(Accept.Font.FontFamily, Accept.Font.Size * num);
				SaveList.Top = (int)Math.Round((float)SaveList.Top * ResMultiH);
				SaveList.Left = (int)Math.Round((float)SaveList.Left * ResMultiW);
				SaveList.Height = (int)Math.Round((float)SaveList.Height * ResMultiH);
				SaveList.Width = (int)Math.Round((float)SaveList.Width * ResMultiW);
				SaveList.Font = new Font(SaveList.Font.FontFamily, SaveList.Font.Size * num);
				DelName.Top = (int)Math.Round((float)DelName.Top * ResMultiH);
				DelName.Left = (int)Math.Round((float)DelName.Left * ResMultiW);
				DelName.Height = (int)Math.Round((float)DelName.Height * ResMultiH);
				DelName.Width = (int)Math.Round((float)DelName.Width * ResMultiW);
				DelName.Font = new Font(DelName.Font.FontFamily, DelName.Font.Size * num);
				CloseFrm.Top = (int)Math.Round((float)CloseFrm.Top * ResMultiH);
				CloseFrm.Left = (int)Math.Round((float)CloseFrm.Left * ResMultiW);
				CloseFrm.Height = (int)Math.Round((float)CloseFrm.Height * ResMultiH);
				CloseFrm.Width = (int)Math.Round((float)CloseFrm.Width * ResMultiW);
				Transfer.Top = (int)Math.Round((float)Transfer.Top * ResMultiH);
				Transfer.Left = (int)Math.Round((float)Transfer.Left * ResMultiW);
				Transfer.Height = (int)Math.Round((float)Transfer.Height * ResMultiH);
				Transfer.Width = (int)Math.Round((float)Transfer.Width * ResMultiW);
				Transfer.Font = new Font(Transfer.Font.FontFamily, Transfer.Font.Size * num);
				History.Top = (int)Math.Round((float)History.Top * ResMultiH);
				History.Left = (int)Math.Round((float)History.Left * ResMultiW);
				History.Height = (int)Math.Round((float)History.Height * ResMultiH);
				History.Width = (int)Math.Round((float)History.Width * ResMultiW);
				History.Font = new Font(History.Font.FontFamily, History.Font.Size * num);
				PrintIt.Top = (int)Math.Round((float)PrintIt.Top * ResMultiH);
				PrintIt.Left = (int)Math.Round((float)PrintIt.Left * ResMultiW);
				PrintIt.Height = (int)Math.Round((float)PrintIt.Height * ResMultiH);
				PrintIt.Width = (int)Math.Round((float)PrintIt.Width * ResMultiW);
				PrintIt.Font = new Font(PrintIt.Font.FontFamily, PrintIt.Font.Size * num);
				PrintIt.Visible = false;
				NewerRecord.Top = (int)Math.Round((float)NewerRecord.Top * ResMultiH);
				NewerRecord.Left = (int)Math.Round((float)NewerRecord.Left * ResMultiW);
				NewerRecord.Height = (int)Math.Round((float)NewerRecord.Height * ResMultiH);
				NewerRecord.Width = (int)Math.Round((float)NewerRecord.Width * ResMultiW);
				NewerRecord.Font = new Font(NewerRecord.Font.FontFamily, NewerRecord.Font.Size * num);
				OlderRecord.Top = (int)Math.Round((float)OlderRecord.Top * ResMultiH);
				OlderRecord.Left = (int)Math.Round((float)OlderRecord.Left * ResMultiW);
				OlderRecord.Height = (int)Math.Round((float)OlderRecord.Height * ResMultiH);
				OlderRecord.Width = (int)Math.Round((float)OlderRecord.Width * ResMultiW);
				OlderRecord.Font = new Font(OlderRecord.Font.FontFamily, OlderRecord.Font.Size * num);
				PersonName.Top = (int)Math.Round((float)PersonName.Top * ResMultiH);
				PersonName.Left = (int)Math.Round((float)PersonName.Left * ResMultiW);
				PersonName.Height = (int)Math.Round((float)PersonName.Height * ResMultiH);
				PersonName.Width = (int)Math.Round((float)PersonName.Width * ResMultiW);
				PersonName.Font = new Font(PersonName.Font.FontFamily, PersonName.Font.Size * ResMultiH);
				Animal.Top = (int)Math.Round((float)Animal.Top * ResMultiH);
				Animal.Left = (int)Math.Round((float)Animal.Left * ResMultiW);
				Animal.Height = (int)Math.Round((float)Animal.Height * ResMultiH);
				Animal.Width = (int)Math.Round((float)Animal.Width * ResMultiW);
				Animal.Font = new Font(Animal.Font.FontFamily, Animal.Font.Size * ResMultiH);
				ID.Top = (int)Math.Round((float)ID.Top * ResMultiH);
				ID.Left = (int)Math.Round((float)ID.Left * ResMultiW);
				ID.Height = (int)Math.Round((float)ID.Height * ResMultiH);
				ID.Width = (int)Math.Round((float)ID.Width * ResMultiW);
				ID.Font = new Font(ID.Font.FontFamily, ID.Font.Size * ResMultiH);
			}
		}
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
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font.Size * ResMultiH);
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Height * ResMultiH);
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Width * ResMultiW);
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Top * ResMultiH);
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Left * ResMultiW);
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
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainer].Controls[ControlName].Font.Size * ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Height * ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Width * ResMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Top * ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Left * ResMultiW);
					}
				}
				else if (base.Controls[ControlName].InvokeRequired)
				{
					SetControl2Callback method3 = Resolution;
					Invoke(method3, ControlName, ControlContainer, ControlContainerA);
				}
				else
				{
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, base.Controls[ControlName].Font.Size * ResMultiH);
					base.Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlName].Height * ResMultiH);
					base.Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlName].Width * ResMultiW);
					base.Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlName].Top * ResMultiH);
					base.Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlName].Left * ResMultiW);
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

	private void RegistryScrollBar()
	{
		object obj = Registry.CurrentUser.OpenSubKey("Control Panel\\\\Desktop\\\\WindowMetrics\\\\", writable: true);
		object obj2 = Registry.CurrentUser.OpenSubKey("Control Panel\\\\Desktop\\\\WindowMetrics\\\\", writable: true);
		if (obj == null)
		{
			obj = Registry.CurrentUser.CreateSubKey("Control Panel\\\\Desktop\\\\WindowMetrics\\\\");
		}
		if (obj2 == null)
		{
			obj2 = Registry.CurrentUser.CreateSubKey("Control Panel\\\\Desktop\\\\WindowMetrics\\\\");
		}
		int num = 0;
		int num2 = 0;
		if (obj == null)
		{
			return;
		}
		num = Conversions.ToInteger(NewLateBinding.LateGet(obj, null, "GetValue", new object[2] { "ScrollWidth", 0 }, null, null, null));
		num2 = Conversions.ToInteger(NewLateBinding.LateGet(obj2, null, "GetValue", new object[2] { "ScrollHeight", 0 }, null, null, null));
		if ((Conversions.ToDouble(Interaction.GetSetting("DTread", "Aqua", "SerialNo", "1350")) >= 1425.0) & (Operators.CompareString(Interaction.GetSetting("DTread", "Aqua", "Main", "Nil"), "1350", TextCompare: false) == 0))
		{
			if (num != -360 || num2 != -360)
			{
				num = -360;
				num2 = -360;
				object instance = obj;
				object[] obj3 = new object[3]
				{
					"ScrollWidth",
					num,
					RegistryValueKind.String
				};
				object[] array = obj3;
				bool[] obj4 = new bool[3] { false, true, false };
				bool[] array2 = obj4;
				NewLateBinding.LateCall(instance, null, "SetValue", obj3, null, null, obj4, IgnoreReturn: true);
				if (array2[1])
				{
					num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				NewLateBinding.LateCall(obj2, null, "SetValue", array = new object[3]
				{
					"ScrollHeight",
					num2,
					RegistryValueKind.String
				}, null, null, array2 = new bool[3] { false, true, false }, IgnoreReturn: true);
				if (array2[1])
				{
					num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
			}
		}
		else if (num != -550 || num2 != -550)
		{
			num = -550;
			num2 = -550;
			object instance2 = obj;
			object[] obj5 = new object[3]
			{
				"ScrollWidth",
				num,
				RegistryValueKind.String
			};
			object[] array = obj5;
			bool[] obj6 = new bool[3] { false, true, false };
			bool[] array2 = obj6;
			NewLateBinding.LateCall(instance2, null, "SetValue", obj5, null, null, obj6, IgnoreReturn: true);
			if (array2[1])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			NewLateBinding.LateCall(obj2, null, "SetValue", array = new object[3]
			{
				"ScrollHeight",
				num2,
				RegistryValueKind.String
			}, null, null, array2 = new bool[3] { false, true, false }, IgnoreReturn: true);
			if (array2[1])
			{
				num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
		}
		NewLateBinding.LateCall(obj, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(obj2, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void NameListSort_Activated(object sender, EventArgs e)
	{
		if (base.WindowState == FormWindowState.Normal)
		{
			TransferCheck();
			SearchChange("Text", MyProject.Forms.Information.ID.Text);
			ListviewSearch();
			SearchChange("Text", "");
		}
	}

	private void TransferCheck()
	{
		string drive = "C:";
		string text = "\\Users\\Public";
		string text2 = "\\Open";
		if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
		{
			text2 = "\\OpenP";
		}
		if (Operators.CompareString(Functions.DirExist(drive, text + text2 + "\\DWS"), "Failed", TextCompare: false) != 0)
		{
			if (((Operators.CompareString(Functions.DirExist(Functions.GetDrive(), ""), "Failed", TextCompare: false) != 0) & (Operators.CompareString(Functions.DirExist(Functions.GetDrive(), "\\NewFiles"), "Failed", TextCompare: false) == 0)) | Functions.MemoryDrive)
			{
				Transfer.Text = "Transfer";
				ControlChange("Transfer", "Visible", "True");
				ControlChange("Transfer", "Enabled", "True");
			}
			else
			{
				ControlChange("Transfer", "Visible", "False");
			}
		}
		else
		{
			ControlChange("Transfer", "Visible", "False");
		}
	}

	private void NameList_Load(object sender, EventArgs e)
	{
		LoadNameList();
		RegistryScrollBar();
		SetChart();
		ChangeMe("WindowsState", "Normal");
		ChangeMe("Visible", "False");
		SetResScreen();
		ChangeMe("WindowsState", "Minimized");
		CloseForm();
		ChangeMe("TopMost", "True");
	}

	private void SetChart()
	{
		if (!ChartSet)
		{
			ChartSet = true;
			ChartHistory.Series.Add("Speed - kmh");
			ChartHistory.Series["Speed - kmh"].ChartType = SeriesChartType.Line;
			ChartHistory.Series["Speed - kmh"].BorderWidth = 2;
			ChartHistory.Series["Speed - kmh"].Color = Color.Red;
			if (MachineSetup.InclineDisplayOnOff)
			{
				ChartHistory.Series.Add("Incline - Deg");
				ChartHistory.Series["Incline - Deg"].ChartType = SeriesChartType.Line;
				ChartHistory.Series["Incline - Deg"].BorderWidth = 2;
				ChartHistory.Series["Incline - Deg"].Color = Color.Green;
			}
			if (MachineSetup.DepthAdjustOnOff)
			{
				ChartHistory.Series.Add("Water Depth x 10 cm");
				ChartHistory.Series["Water Depth x 10 cm"].ChartType = SeriesChartType.Line;
				ChartHistory.Series["Water Depth x 10 cm"].BorderWidth = 2;
				ChartHistory.Series["Water Depth x 10 cm"].Color = Color.Blue;
			}
			if (MachineSetup.JetDisplayOnOff)
			{
				ChartHistory.Series.Add("Jet");
				ChartHistory.Series["Jet"].ChartType = SeriesChartType.Line;
				ChartHistory.Series["Jet"].BorderWidth = 2;
				ChartHistory.Series["Jet"].Color = Color.Orange;
			}
			ChartHistory.Series.Add("Rest Time - Min");
			ChartHistory.Series["Rest Time - Min"].ChartType = SeriesChartType.Line;
			ChartHistory.Series["Rest Time - Min"].BorderWidth = 2;
			ChartHistory.Series["Rest Time - Min"].Color = Color.Brown;
			ChartHistory.ChartAreas[0].AxisX.Title = "TIME";
			ChartHistory.ChartAreas[0].AxisY.Title = "LEVEL";
		}
	}

	public void LoadNameList()
	{
		NameListView.View = View.Details;
		NameListView.MultiSelect = false;
		NameLoad(Display.NameArrayMax);
		if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
		{
			ControlChange("DelName", "Visible", "False");
			ControlChange("SaveList", "Visible", "False");
		}
	}

	public void NameLoad(object ArrayMax)
	{
		NameListView.Clear();
		NameListView.View = View.Details;
		int num = Conversions.ToInteger(ArrayMax);
		checked
		{
			for (int i = 0; i <= num; i++)
			{
				if (!((i == 0) & (Operators.CompareString(MyProject.Forms.Display.IDPerson[i], "", TextCompare: false) == 0)))
				{
					ListViewItem listViewItem = new ListViewItem(MyProject.Forms.Display.NamePerson[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.IDPerson[i]);
					if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))
					{
						listViewItem.SubItems.Add(MyProject.Forms.Display.AnimalNamePerson[i]);
						string text = MyProject.Forms.Display.AnimalNamePerson[i];
					}
					listViewItem.SubItems.Add(MyProject.Forms.Display.DOBPerson[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.SexPerson[i]);
					if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))
					{
						listViewItem.SubItems.Add(MyProject.Forms.Display.BreedPerson[i]);
					}
					listViewItem.SubItems.Add(MyProject.Forms.Display.HeightPerson[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.WeightPerson[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.TrainerPerson[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.SetSpeedProgram[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.SetMaxSpeed[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.SetMaxSpeedKmh[i]);
					if (MachineSetup.InclineDisplayOnOff)
					{
						listViewItem.SubItems.Add(MyProject.Forms.Display.SetGradientProgram[i]);
						listViewItem.SubItems.Add(MyProject.Forms.Display.SetMaxGradient[i]);
					}
					listViewItem.SubItems.Add(MyProject.Forms.Display.Duration[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.ImportantPerson[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.PostCodePerson[i]);
					listViewItem.SubItems.Add(MyProject.Forms.Display.HouseNoPerson[i]);
					if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))
					{
						listViewItem.SubItems.Add(MyProject.Forms.Display.REFPerson[i]);
					}
					NameListView.Items.Add(listViewItem);
				}
			}
			ColumnHeader value = new ColumnHeader
			{
				Text = "NAME"
			};
			NameListView.Columns.Add(value);
			int num2 = 1;
			value = new ColumnHeader
			{
				Text = "ID",
				TextAlign = HorizontalAlignment.Center
			};
			NameListView.Columns.Add(value);
			num2++;
			if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0)
			{
				value = new ColumnHeader
				{
					Text = "ANIMAL NAME",
					TextAlign = HorizontalAlignment.Center
				};
				NameListView.Columns.Add(value);
				num2++;
			}
			if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0)
			{
				value = new ColumnHeader
				{
					Text = "DOG NAME",
					TextAlign = HorizontalAlignment.Center
				};
				NameListView.Columns.Add(value);
				num2++;
			}
			value = new ColumnHeader
			{
				Text = "DOB",
				TextAlign = HorizontalAlignment.Center
			};
			NameListView.Columns.Add(value);
			num2++;
			value = new ColumnHeader
			{
				Text = "SEX",
				TextAlign = HorizontalAlignment.Center
			};
			NameListView.Columns.Add(value);
			num2++;
			if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))
			{
				value = new ColumnHeader
				{
					Text = "BREED",
					TextAlign = HorizontalAlignment.Center
				};
				NameListView.Columns.Add(value);
				num2++;
			}
			value = new ColumnHeader
			{
				Text = "HEIGHT",
				TextAlign = HorizontalAlignment.Center
			};
			NameListView.Columns.Add(value);
			num2++;
			int num3 = num2;
			value = new ColumnHeader
			{
				Text = "WEIGHT",
				TextAlign = HorizontalAlignment.Center
			};
			NameListView.Columns.Add(value);
			num2++;
			int num4 = num2;
			value = new ColumnHeader
			{
				Text = "TRAINER",
				TextAlign = HorizontalAlignment.Center
			};
			NameListView.Columns.Add(value);
			num2++;
			int num5 = num2;
			value = new ColumnHeader
			{
				Text = "SPEED PROG",
				TextAlign = HorizontalAlignment.Center
			};
			NameListView.Columns.Add(value);
			num2++;
			int num6 = num2;
			value = new ColumnHeader
			{
				Text = "MAX S",
				TextAlign = HorizontalAlignment.Center
			};
			NameListView.Columns.Add(value);
			num2++;
			int num7 = num2;
			value = new ColumnHeader
			{
				Text = "MAX kmh",
				TextAlign = HorizontalAlignment.Center
			};
			NameListView.Columns.Add(value);
			num2++;
			int num8 = num2;
			if (MachineSetup.InclineDisplayOnOff)
			{
				value = new ColumnHeader
				{
					Text = "GRADIENT PROG",
					TextAlign = HorizontalAlignment.Center
				};
				NameListView.Columns.Add(value);
				num2++;
				int num9 = num2;
				value = new ColumnHeader
				{
					Text = "MAX G",
					TextAlign = HorizontalAlignment.Center
				};
				NameListView.Columns.Add(value);
				num2++;
				int num10 = num2;
			}
			value = new ColumnHeader
			{
				TextAlign = HorizontalAlignment.Center,
				Text = "DURATION"
			};
			NameListView.Columns.Add(value);
			num2++;
			int num11 = num2;
			value = new ColumnHeader
			{
				Text = "IMPORTANT",
				TextAlign = HorizontalAlignment.Left
			};
			NameListView.Columns.Add(value);
			num2++;
			value = new ColumnHeader
			{
				Text = "POSTCODE",
				TextAlign = HorizontalAlignment.Left
			};
			NameListView.Columns.Add(value);
			num2++;
			value = new ColumnHeader
			{
				Text = "HOUSENO",
				TextAlign = HorizontalAlignment.Left
			};
			NameListView.Columns.Add(value);
			num2++;
			if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))
			{
				value = new ColumnHeader
				{
					Text = "REFERRAL",
					TextAlign = HorizontalAlignment.Center
				};
				NameListView.Columns.Add(value);
				num2++;
			}
			foreach (ColumnHeader column in NameListView.Columns)
			{
				column.Width = -2;
			}
		}
	}

	private void NameListViewSortDel()
	{
		foreach (ListViewItem item in Selected)
		{
			NameListView.Items.Remove(item);
		}
	}

	public void NameListClear()
	{
		NameListView.Clear();
	}

	private void NameListViewSortSave()
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			try
			{
				foreach (ListViewItem item in NameListView.Items)
				{
					num2 = 0;
					MyProject.Forms.Display.NamePerson[num] = item.SubItems[num2].Text;
					num2++;
					MyProject.Forms.Display.IDPerson[num] = item.SubItems[num2].Text;
					num2++;
					if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))
					{
						MyProject.Forms.Display.AnimalNamePerson[num] = item.SubItems[num2].Text;
						num2++;
					}
					MyProject.Forms.Display.DOBPerson[num] = item.SubItems[num2].Text;
					num2++;
					MyProject.Forms.Display.SexPerson[num] = item.SubItems[num2].Text;
					num2++;
					if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))
					{
						MyProject.Forms.Display.BreedPerson[num] = item.SubItems[num2].Text;
						num2++;
					}
					MyProject.Forms.Display.HeightPerson[num] = item.SubItems[num2].Text;
					num2++;
					MyProject.Forms.Display.WeightPerson[num] = item.SubItems[num2].Text;
					num2++;
					MyProject.Forms.Display.TrainerPerson[num] = item.SubItems[num2].Text;
					num2++;
					MyProject.Forms.Display.SetSpeedProgram[num] = Conversions.ToString(Conversion.Val(item.SubItems[num2].Text));
					num2++;
					MyProject.Forms.Display.SetMaxSpeed[num] = Conversions.ToString(Conversion.Val(item.SubItems[num2].Text));
					num2++;
					MyProject.Forms.Display.SetMaxSpeedKmh[num] = Conversions.ToString(Conversion.Val(item.SubItems[num2].Text));
					num2++;
					if (MachineSetup.InclineDisplayOnOff)
					{
						MyProject.Forms.Display.SetGradientProgram[num] = Conversions.ToString(Conversion.Val(item.SubItems[num2].Text));
						num2++;
						MyProject.Forms.Display.SetMaxGradient[num] = Conversions.ToString(Conversion.Val(item.SubItems[num2].Text));
						num2++;
					}
					MyProject.Forms.Display.Duration[num] = item.SubItems[num2].Text;
					num2++;
					MyProject.Forms.Display.ImportantPerson[num] = item.SubItems[num2].Text;
					num2++;
					MyProject.Forms.Display.PostCodePerson[num] = item.SubItems[num2].Text;
					num2++;
					MyProject.Forms.Display.HouseNoPerson[num] = item.SubItems[num2].Text;
					num2++;
					if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))
					{
						MyProject.Forms.Display.REFPerson[num] = item.SubItems[num2].Text;
						num2++;
					}
					num++;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			Display.NameArrayMax = NameListView.Items.Count - 1;
			MyProject.Forms.Display.CustomerListUpdateRequired = true;
			MyProject.Forms.Display.PersonFileRead = false;
			MyProject.Forms.Display.RecordChanges();
		}
	}

	private void NameListView_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			string text = "\\Open";
			if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
			{
				text = "\\OpenP";
			}
			Selected = NameListView.SelectedItems;
			ControlChange("History", "Visible", "False");
			foreach (ListViewItem item in Selected)
			{
				PersonNameChange("Text", item.SubItems[0].Text);
				IDChange("Text", item.SubItems[1].Text);
				AnimalChange("Text", item.SubItems[2].Text);
			}
			HistoryDir = ID.Text;
			if (!((Operators.CompareString(PersonName.Text, "", TextCompare: false) != 0) & (Operators.CompareString(ID.Text, "", TextCompare: false) != 0)))
			{
				return;
			}
			if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
			{
				if (Operators.ConditionalCompareObjectEqual(GetFiles(Interaction.GetSetting("Dtread", "Aqua", "LanDriveMapLetter", "R") + ":" + text + "\\DWS-History\\" + HistoryDir), true, TextCompare: false))
				{
					ControlChange("History", "Visible", "True");
				}
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(GetFiles("C:\\Users\\Public" + text + "\\DWS-History\\" + HistoryDir), true, TextCompare: false))
			{
				ControlChange("History", "Visible", "True");
			}
			ButtonSelection(2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void RemoteSelection(object ItemID)
	{
		int num = 0;
		NamePerson = "";
		checked
		{
			if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) == 0)
			{
				foreach (ListViewItem item in NameListView.Items)
				{
					if (Operators.ConditionalCompareObjectEqual(ItemID, item.SubItems[1].Text, TextCompare: false))
					{
						NamePerson = item.SubItems[0].Text;
						IDPerson = item.SubItems[1].Text;
						DOBPerson = Conversions.ToDate(item.SubItems[2].Text);
						PersonSex = item.SubItems[3].Text;
						HeightPerson = item.SubItems[4].Text;
						WeightPerson = item.SubItems[5].Text;
						TrainerPerson = item.SubItems[6].Text;
						SpeedProgram = (int)Math.Round(Conversion.Val(item.SubItems[7].Text));
						SetMaxSpeed = (int)Math.Round(Conversion.Val(item.SubItems[8].Text));
						SetMaxSpeedkmh = (float)Conversion.Val(item.SubItems[11].Text);
						if (MachineSetup.InclineDisplayOnOff)
						{
							GradientProgram = (int)Math.Round(Conversion.Val(item.SubItems[9].Text));
							SetMaxGradient = (int)Math.Round(Conversion.Val(item.SubItems[10].Text));
							Duration = item.SubItems[11].Text;
							ImportantPerson = item.SubItems[12].Text;
							PostCodePerson = item.SubItems[13].Text;
							HouseNoPerson = item.SubItems[14].Text;
						}
						else
						{
							Duration = item.SubItems[9].Text;
							ImportantPerson = item.SubItems[10].Text;
							PostCodePerson = item.SubItems[11].Text;
							HouseNoPerson = item.SubItems[12].Text;
						}
					}
				}
				if (Operators.CompareString(NamePerson, "", TextCompare: false) != 0)
				{
					MyProject.Forms.Information.PersonNameChange("Text", NamePerson);
					MyProject.Forms.Information.IDChange("Text", IDPerson);
					MyProject.Forms.Information.DOBChange("Text", Conversions.ToString(DOBPerson));
					MyProject.Forms.Information.PersonSexChange(PersonSex);
					MyProject.Forms.Information.PersonHeightcmChange("Text", HeightPerson);
					MyProject.Forms.Information.PersonWeightkgChange("Text", WeightPerson);
					MyProject.Forms.Information.TrainerChange("Text", TrainerPerson);
					MyProject.Forms.Display.SpeedProgramSet = SpeedProgram;
					MyProject.Forms.Display.MaxSpeedSet = SetMaxSpeed;
					if (MachineSetup.InclineDisplayOnOff)
					{
						MyProject.Forms.Display.GradientProgramSet = GradientProgram;
						MyProject.Forms.Display.MaxGradientSet = SetMaxGradient;
					}
					MyProject.Forms.Display.DurationTimeSet(Duration);
					MyProject.Forms.Information.ImportantChange("Text", ImportantPerson);
					MyProject.Forms.Information.PostCodeChange("Text", PostCodePerson);
					MyProject.Forms.Information.HouseNoChange("Text", HouseNoPerson);
					MyProject.Forms.Information.AgeChange("Text", Conversions.ToString(DateAndTime.DateDiff(DateInterval.Year, DOBPerson, DateAndTime.Now)));
					DoBoxChange("CloseList");
				}
				return;
			}
			foreach (ListViewItem item2 in NameListView.Items)
			{
				if (Operators.ConditionalCompareObjectEqual(ItemID, item2.SubItems[1].Text, TextCompare: false))
				{
					NamePerson = item2.SubItems[0].Text;
					IDPerson = item2.SubItems[1].Text;
					AnimalNamePerson = item2.SubItems[2].Text;
					DOBPerson = Conversions.ToDate(item2.SubItems[3].Text);
					PersonSex = item2.SubItems[4].Text;
					BreedPerson = item2.SubItems[5].Text;
					HeightPerson = item2.SubItems[6].Text;
					WeightPerson = item2.SubItems[7].Text;
					TrainerPerson = item2.SubItems[8].Text;
					SpeedProgram = (int)Math.Round(Conversion.Val(item2.SubItems[9].Text));
					SetMaxSpeed = (int)Math.Round(Conversion.Val(item2.SubItems[10].Text));
					SetMaxSpeedkmh = (float)Conversion.Val(item2.SubItems[11].Text);
					GradientProgram = (int)Math.Round(Conversion.Val(item2.SubItems[12].Text));
					SetMaxGradient = (int)Math.Round(Conversion.Val(item2.SubItems[13].Text));
					Duration = item2.SubItems[16].Text;
					ImportantPerson = item2.SubItems[17].Text;
					PostCodePerson = item2.SubItems[18].Text;
					HouseNoPerson = item2.SubItems[19].Text;
					REFPerson = Conversions.ToDate(item2.SubItems[20].Text);
				}
			}
			if (Operators.CompareString(NamePerson, "", TextCompare: false) != 0)
			{
				MyProject.Forms.Information.PersonNameChange("Text", NamePerson);
				MyProject.Forms.Information.IDChange("Text", IDPerson);
				MyProject.Forms.Information.AnimalNameChange("Text", AnimalNamePerson);
				MyProject.Forms.Information.DOBChange("Text", Conversions.ToString(DOBPerson));
				MyProject.Forms.Information.PersonSexChange(PersonSex);
				MyProject.Forms.Information.BreedChange("Text", BreedPerson);
				MyProject.Forms.Information.PersonHeightcmChange("Text", HeightPerson);
				MyProject.Forms.Information.PersonWeightkgChange("Text", WeightPerson);
				MyProject.Forms.Information.TrainerChange("Text", TrainerPerson);
				MyProject.Forms.Display.SpeedProgramSet = SpeedProgram;
				MyProject.Forms.Display.MaxSpeedSet = SetMaxSpeed;
				MyProject.Forms.Display.GradientProgramSet = GradientProgram;
				MyProject.Forms.Display.MaxGradientSet = SetMaxGradient;
				MyProject.Forms.Display.DurationTimeSet(Duration);
				MyProject.Forms.Information.ImportantChange("Text", ImportantPerson);
				MyProject.Forms.Information.PostCodeChange("Text", PostCodePerson);
				MyProject.Forms.Information.HouseNoChange("Text", HouseNoPerson);
				MyProject.Forms.Information.AgeChange("Text", Conversions.ToString(DateAndTime.DateDiff(DateInterval.Year, DOBPerson, DateAndTime.Now)));
				MyProject.Forms.Information.ReferralEndChange("Text", Conversions.ToString(REFPerson));
				DoBoxChange("CloseList");
			}
		}
	}

	public void PersonNameChange(string text, string texta)
	{
		if (PersonName.InvokeRequired)
		{
			SetSTRCallback method = PersonNameChange;
			Invoke(method, text, texta);
			return;
		}
		switch (text)
		{
		case "Text":
			PersonName.Text = texta;
			break;
		case "Visible":
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				PersonName.Visible = false;
			}
			else
			{
				PersonName.Visible = true;
			}
			break;
		case "Enabled":
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				PersonName.Enabled = false;
			}
			else
			{
				PersonName.Enabled = true;
			}
			break;
		}
	}

	public void IDChange(string text, string texta)
	{
		if (ID.InvokeRequired)
		{
			SetSTRCallback method = IDChange;
			Invoke(method, text, texta);
			return;
		}
		switch (text)
		{
		case "Text":
			ID.Text = texta;
			break;
		case "Visible":
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				ID.Visible = false;
			}
			else
			{
				ID.Visible = true;
			}
			break;
		case "Enabled":
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				ID.Enabled = false;
			}
			else
			{
				ID.Enabled = true;
			}
			break;
		}
	}

	public void AnimalChange(string text, string texta)
	{
		if (Animal.InvokeRequired)
		{
			SetSTRCallback method = AnimalChange;
			Invoke(method, text, texta);
			return;
		}
		switch (text)
		{
		case "Text":
			Animal.Text = texta;
			break;
		case "Visible":
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				Animal.Visible = false;
			}
			else
			{
				Animal.Visible = true;
			}
			break;
		case "Enabled":
			if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
			{
				Animal.Enabled = false;
			}
			else
			{
				Animal.Enabled = true;
			}
			break;
		}
	}

	private void ToDo()
	{
		if (Operators.CompareString(DoBox.Text, "CloseList", TextCompare: false) == 0)
		{
			MyProject.Forms.Display.ToDo("CloseList");
		}
		if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
		{
			Interaction.SaveSetting("Dtread", "Treadmill", "SendC", Interaction.GetSetting("Dtread", "Treadmill", "SendC") + ",CLOSELIST");
		}
	}

	private void DoBoxChange(string text)
	{
		if (DoBox.InvokeRequired)
		{
			SetTextCallback method = DoBoxChange;
			Invoke(method, text);
		}
		else
		{
			DoBox.Text = text;
			ToDo();
		}
	}

	private void CloseFrm_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(DelName.Text, "All", TextCompare: false) == 0)
		{
			InfoYesNo = "X";
		}
		else
		{
			CloseForm();
		}
		ControlChange("Transfer", "Enabled", "True");
	}

	private void CloseForm()
	{
		if (!ChartHistory.Visible & !HistoryTextImage.Visible)
		{
			if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
			{
				Interaction.SaveSetting("Dtread", "Treadmill", "SendC", Interaction.GetSetting("Dtread", "Treadmill", "SendC") + ",CLOSELIST");
			}
			else
			{
				DoBoxChange("CloseList");
			}
		}
		else
		{
			ChartHistoryOff();
			ControlChange("Searchbox", "Visible", "True");
			ControlChange("SearchPic", "Visible", "True");
			ControlChange("PrintIt", "Visible", "False");
		}
	}

	private void ChartHistoryOff()
	{
		ControlChange("HistoryTextImage", "Visible", "False");
		ControlChange("ChartHistory", "Visible", "False");
		ControlChange("OlderRecord", "Visible", "False");
		ControlChange("NewerRecord", "Visible", "False");
		ControlChange("Transfer", "Visible", "False");
		ButtonSelection(2);
	}

	private void AcceptData()
	{
		checked
		{
			try
			{
				foreach (ListViewItem item in Selected)
				{
					int num = 0;
					NamePerson = item.SubItems[num].Text;
					num++;
					IDPerson = item.SubItems[num].Text;
					num++;
					if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) != 0)
					{
						AnimalNamePerson = item.SubItems[num].Text;
						num++;
					}
					DOBPerson = Conversions.ToDate(item.SubItems[num].Text);
					num++;
					PersonSex = item.SubItems[num].Text;
					num++;
					if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) != 0)
					{
						BreedPerson = item.SubItems[num].Text;
						num++;
					}
					HeightPerson = item.SubItems[num].Text;
					num++;
					WeightPerson = item.SubItems[num].Text;
					num++;
					TrainerPerson = item.SubItems[num].Text;
					num++;
					SpeedProgram = (int)Math.Round(Conversion.Val(item.SubItems[num].Text));
					num++;
					SetMaxSpeed = (int)Math.Round(Conversion.Val(item.SubItems[num].Text));
					num++;
					SetMaxSpeedkmh = (float)Conversion.Val(item.SubItems[num].Text);
					num++;
					if (MachineSetup.InclineDisplayOnOff)
					{
						GradientProgram = (int)Math.Round(Conversion.Val(item.SubItems[num].Text));
						num++;
						SetMaxGradient = (int)Math.Round(Conversion.Val(item.SubItems[num].Text));
						num++;
					}
					Duration = item.SubItems[num].Text;
					num++;
					ImportantPerson = item.SubItems[num].Text;
					num++;
					PostCodePerson = item.SubItems[num].Text;
					num++;
					HouseNoPerson = item.SubItems[num].Text;
					num++;
					if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) != 0)
					{
						REFPerson = Conversions.ToDate(item.SubItems[num].Text);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Interaction.SaveSetting("Dtread", "Treadmill", "SendC", Interaction.GetSetting("Dtread", "Treadmill", "SendC") + ",SID,CLOSELIST");
				}
				else if (Operators.CompareString(PersonName.Text, "", TextCompare: false) != 0)
				{
					MyProject.Forms.Information.PersonNameChange("Text", NamePerson);
					MyProject.Forms.Information.IDChange("Text", IDPerson);
					MyProject.Forms.Information.AnimalNameChange("Text", AnimalNamePerson);
					MyProject.Forms.Information.DOBChange("Text", Conversions.ToString(DOBPerson));
					MyProject.Forms.Information.PersonSexChange(PersonSex);
					MyProject.Forms.Information.BreedChange("Text", BreedPerson);
					MyProject.Forms.Information.PersonHeightcmChange("Text", HeightPerson);
					MyProject.Forms.Information.PersonWeightkgChange("Text", WeightPerson);
					MyProject.Forms.Information.TrainerChange("Text", TrainerPerson);
					MyProject.Forms.Display.SpeedProgramSet = SpeedProgram;
					MyProject.Forms.Display.MaxSpeedSet = SetMaxSpeed;
					MyProject.Forms.Display.GradientProgramSet = GradientProgram;
					MyProject.Forms.Display.MaxGradientSet = SetMaxGradient;
					MyProject.Forms.Display.DurationTimeSet(Duration);
					MyProject.Forms.Information.ImportantChange("Text", ImportantPerson);
					MyProject.Forms.Information.PostCodeChange("Text", PostCodePerson);
					MyProject.Forms.Information.HouseNoChange("Text", HouseNoPerson);
					MyProject.Forms.Information.AgeChange("Text", Conversions.ToString(DateAndTime.DateDiff(DateInterval.Year, DOBPerson, DateAndTime.Now)));
					MyProject.Forms.Information.ReferralEndChange("Text", Conversions.ToString(REFPerson));
					DoBoxChange("CloseList");
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			MyProject.Forms.Display.CustomerListUpdateRequired = true;
			MyProject.Forms.Display.PersonFileRead = false;
			MyProject.Forms.Display.RecordChanges();
			ChartHistoryOff();
		}
	}

	private void HoldSoftware()
	{
		checked
		{
			foreach (ListViewItem item in Selected)
			{
				NamePerson = item.SubItems[0].Text;
				IDPerson = item.SubItems[1].Text;
				AnimalNamePerson = item.SubItems[2].Text;
				DOBPerson = Conversions.ToDate(item.SubItems[3].Text);
				PersonSex = item.SubItems[4].Text;
				BreedPerson = item.SubItems[5].Text;
				HeightPerson = item.SubItems[6].Text;
				WeightPerson = item.SubItems[7].Text;
				TrainerPerson = item.SubItems[8].Text;
				SpeedProgram = (int)Math.Round(Conversion.Val(item.SubItems[9].Text));
				SetMaxSpeed = (int)Math.Round(Conversion.Val(item.SubItems[10].Text));
				SetMaxSpeedkmh = (float)Conversion.Val(item.SubItems[11].Text);
				if (MachineSetup.InclineDisplayOnOff)
				{
					GradientProgram = (int)Math.Round(Conversion.Val(item.SubItems[12].Text));
					SetMaxGradient = (int)Math.Round(Conversion.Val(item.SubItems[13].Text));
					Duration = item.SubItems[14].Text;
					ImportantPerson = item.SubItems[15].Text;
					PostCodePerson = item.SubItems[16].Text;
					HouseNoPerson = item.SubItems[17].Text;
					REFPerson = Conversions.ToDate(item.SubItems[18].Text);
				}
				else
				{
					Duration = item.SubItems[12].Text;
					ImportantPerson = item.SubItems[13].Text;
					PostCodePerson = item.SubItems[14].Text;
					HouseNoPerson = item.SubItems[15].Text;
					REFPerson = Conversions.ToDate(item.SubItems[16].Text);
				}
			}
		}
	}

	private void Accept_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Accept.Text, "Accept Selection", TextCompare: false) == 0)
		{
			AcceptData();
		}
		if (Operators.CompareString(Accept.Text, "Selected", TextCompare: false) == 0)
		{
			InfoYesNo = "Selected";
		}
	}

	private void SaveList_Click(object sender, EventArgs e)
	{
		NameListViewSortSave();
		NameLoad(Display.NameArrayMax);
	}

	private void DelName_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(DelName.Text, "Delete Selection", TextCompare: false) == 0)
		{
			NameListViewSortDel();
			ControlChange("Transfer", "Visible", "False");
			ControlChange("DelName", "Visible", "False");
			ControlChange("History", "Visible", "False");
			ControlChange("Accept", "Visible", "False");
			ControlChange("SaveList", "Visible", "True");
		}
		if (Operators.CompareString(DelName.Text, "All", TextCompare: false) == 0)
		{
			InfoYesNo = "All";
		}
	}

	private void History_Click(object sender, EventArgs e)
	{
		ControlChange("Transfer", "Visible", "False");
		ControlChange("DelName", "Visible", "False");
		ControlChange("SaveList", "Visible", "False");
		ControlChange("Searchbox", "Visible", "False");
		ControlChange("SearchPic", "Visible", "False");
		HistorySelected();
	}

	public void HistorySelected()
	{
		int num = 0;
		short num2 = 0;
		checked
		{
			if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) == 0)
			{
				try
				{
					Selected = NameListView.SelectedItems;
					foreach (ListViewItem item in Selected)
					{
						num = 0;
						num2 = (short)(item.SubItems.Count - 1);
						NamePerson = item.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						IDPerson = item.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						DOBPerson = Conversions.ToDate(item.SubItems[num].Text);
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						PersonSex = item.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						HeightPerson = item.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						WeightPerson = item.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						TrainerPerson = item.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						SpeedProgram = (int)Math.Round(Conversion.Val(item.SubItems[num].Text));
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						SetMaxSpeed = (int)Math.Round(Conversion.Val(item.SubItems[num].Text));
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						SetMaxSpeedkmh = (float)Conversion.Val(item.SubItems[num].Text);
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						if (MachineSetup.InclineDisplayOnOff)
						{
							GradientProgram = (int)Math.Round(Conversion.Val(item.SubItems[num].Text));
							if (num + 1 > num2)
							{
								continue;
							}
							num++;
							SetMaxGradient = (int)Math.Round(Conversion.Val(item.SubItems[num].Text));
							if (num + 1 > num2)
							{
								continue;
							}
							num++;
						}
						Duration = item.SubItems[num].Text;
						num++;
						ImportantPerson = item.SubItems[num].Text;
						num++;
						PostCodePerson = item.SubItems[num].Text;
						num++;
						HouseNoPerson = item.SubItems[num].Text;
						num++;
						Application.DoEvents();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return;
				}
			}
			else
			{
				try
				{
					Selected = NameListView.SelectedItems;
					short num3 = (short)Selected.Count;
					foreach (ListViewItem item2 in Selected)
					{
						num2 = (short)(item2.SubItems.Count - 1);
						num = 0;
						NamePerson = item2.SubItems[num].Text;
						if (num + 1 <= num2)
						{
							if (num + 1 > num2)
							{
								continue;
							}
							num++;
						}
						IDPerson = item2.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						AnimalNamePerson = item2.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						DOBPerson = Conversions.ToDate(item2.SubItems[num].Text);
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						PersonSex = item2.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						BreedPerson = item2.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						HeightPerson = item2.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						WeightPerson = item2.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						TrainerPerson = item2.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						SpeedProgram = (int)Math.Round(Conversion.Val(item2.SubItems[num].Text));
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						SetMaxSpeed = (int)Math.Round(Conversion.Val(item2.SubItems[num].Text));
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						SetMaxSpeedkmh = (float)Conversion.Val(item2.SubItems[num].Text);
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						if (MachineSetup.InclineDisplayOnOff)
						{
							GradientProgram = (int)Math.Round(Conversion.Val(item2.SubItems[num].Text));
							if (num + 1 > num2)
							{
								continue;
							}
							num++;
							SetMaxGradient = (int)Math.Round(Conversion.Val(item2.SubItems[num].Text));
							if (num + 1 > num2)
							{
								continue;
							}
							num++;
						}
						Duration = item2.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						ImportantPerson = item2.SubItems[num].Text;
						if (num + 1 > num2)
						{
							continue;
						}
						num++;
						PostCodePerson = item2.SubItems[num].Text;
						if (num + 1 <= num2)
						{
							num++;
							HouseNoPerson = item2.SubItems[num].Text;
							if (num + 1 <= num2)
							{
								num++;
								REFPerson = Conversions.ToDate(item2.SubItems[num].Text);
							}
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
					return;
				}
			}
			string text = "\\Open";
			if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
			{
				text = "\\OpenP";
			}
			try
			{
				HistoryDir = IDPerson;
				if ((Operators.CompareString(NamePerson, "", TextCompare: false) != 0) & (Operators.CompareString(IDPerson, "", TextCompare: false) != 0))
				{
					if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
					{
						bool flag = Conversions.ToBoolean(GetFiles(Interaction.GetSetting("Dtread", "Aqua", "LanDriveMapLetter", "R") + ":" + text + "\\DWS-History\\" + HistoryDir));
					}
					else
					{
						bool flag = Conversions.ToBoolean(GetFiles("C:\\Users\\Public" + text + "\\DWS-History\\" + HistoryDir));
					}
				}
				if (Strings.Len(ReportNumberHistory[0]) > 0)
				{
					NewerRecord.Enabled = false;
					ControlChange("NewerRecord", "Visible", "False");
					if (HistoryUpperIndex > 0)
					{
						OlderRecord.Enabled = true;
						ControlChange("OlderRecord", "Text", "Older");
						ControlChange("OlderRecord", "Visible", "True");
						ControlChange("PersonName", "Visible", "False");
						ControlChange("ID", "Visible", "False");
						ControlChange("Animal", "Visible", "False");
					}
					else
					{
						ControlChange("OlderRecord", "Visible", "False");
					}
					ControlChange("Accept", "Visible", "False");
					ControlChange("History", "Visible", "False");
					if (Operators.ConditionalCompareObjectLess(HistoryUpperIndex, Operators.SubtractObject(RecordsDisplayedMax, 1), TextCompare: false))
					{
						RecordNumber = HistoryUpperIndex;
					}
					else
					{
						RecordNumber = Conversions.ToInteger(Operators.SubtractObject(RecordsDisplayedMax, 1));
					}
					HistoryIndexMax = RecordNumber;
					DisplayHistoryGraphic(RecordNumber);
					HistoryChart(RecordNumber);
					PDFCheck();
					PDFFileCheck();
					PersonNameChange("Visible", Conversions.ToString(Value: false));
					IDChange("Visible", Conversions.ToString(Value: false));
					AnimalChange("Visible", Conversions.ToString(Value: false));
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void PDFFileCheck()
	{
		string drive = "C:";
		string text = "\\Users\\Public";
		string text2 = "\\Open";
		if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
		{
			text2 = "\\OpenP";
		}
		string text3 = "\\DWS-History";
		string drive2 = Functions.GetDrive();
		string text4 = DateTimeFileNameHistory[RecordNumber];
		bool flag = false;
		bool flag2 = false;
		string data = "White";
		bool flag3 = false;
		if ((Operators.CompareString(MachineSetup.PDFOrPrint, "PDF/Print", TextCompare: false) == 0) | (Operators.CompareString(MachineSetup.PDFOrPrint, "Print", TextCompare: false) == 0))
		{
			flag3 = CheckPrinter(DefaultPrinterName());
		}
		if (Functions.FileExist(drive, "\\" + text + "\\" + text2 + "\\" + text3 + "\\" + IDPerson + "\\" + IDPerson + "_" + text4 + "_Chart.pdf"))
		{
			flag = true;
			data = "Gray";
		}
		if (Operators.CompareString(MachineSetup.PDFOrPrint, "Print", TextCompare: false) == 0 && flag3)
		{
			ControlChange("PrintIt", "Text", MachineSetup.PDFOrPrint);
			ControlChange("PrintIt", "Color", data);
			ControlChange("PrintIt", "Visible", "True");
		}
		else if ((Operators.CompareString(MachineSetup.PDFOrPrint, "PDF", TextCompare: false) == 0) | (Operators.CompareString(MachineSetup.PDFOrPrint, "PDF/Print", TextCompare: false) == 0))
		{
			FindOneDrive();
			if (Operators.CompareString(OneDrivePath, "Failed", TextCompare: false) != 0)
			{
				if (Functions.FileExist(OneDrivePath, "\\" + text3 + "\\" + IDPerson + "\\" + IDPerson + "_" + text4 + "_Chart.pdf"))
				{
					flag2 = true;
				}
				else
				{
					data = "Yellow";
				}
			}
			if (((Operators.CompareString(drive2, "", TextCompare: false) != 0) & MachineSetup.USBSave) && !Functions.FileExist(drive2, "\\" + text3 + "\\" + IDPerson + "\\" + IDPerson + "_" + text4 + "_Chart.pdf"))
			{
				data = (flag ? "Red" : "Orange");
			}
			ControlChange("PrintIt", "Visible", "True");
			ControlChange("PrintIt", "Text", MachineSetup.PDFOrPrint);
			ControlChange("PrintIt", "Color", data);
		}
		else
		{
			ControlChange("PrintIt", "Visible", "False");
		}
	}

	public void HistoryChartOne(object Drive, object Path, object FileName)
	{
		int num = 1;
		string text = SpeedHistory[num];
		short num2 = 1;
		SetChart();
		checked
		{
			try
			{
				ChartHistory.Series["Speed - kmh"].Points.Clear();
				if (MachineSetup.InclineDisplayOnOff)
				{
					ChartHistory.Series["Incline - Deg"].Points.Clear();
				}
				if (MachineSetup.DepthAdjustOnOff)
				{
					ChartHistory.Series["Water Depth x 10 cm"].Points.Clear();
				}
				if (MachineSetup.JetDisplayOnOff)
				{
					ChartHistory.Series["Jet"].Points.Clear();
				}
				ChartHistory.Series["Rest Time - Min"].Points.Clear();
				GetChartHistoryOne();
				TimeHistory[num] = "00.00;" + TimeHistoryStr;
				SpeedHistory[num] = SpeedHistoryStr + ";0.0";
				RestTimeHistory[num] = RestTimeHistoryStr + ";0.0";
				if (MachineSetup.InclineDisplayOnOff)
				{
					GradientHistory[num] = GradientHistoryStr + ";0.0";
				}
				if (MachineSetup.DepthAdjustOnOff)
				{
					WaterDepthHistory[num] = WaterHistoryStr + ";0.0";
				}
				if (MachineSetup.JetDisplayOnOff)
				{
					JetHistory[num] = JetHistoryStr + ";0.0";
				}
				if (MachineSetup.ChamberTempOnOff)
				{
					TemperatureHistory[num] = TemperatureHistoryStr + ";0.0";
				}
				RestHistory[num] = RestHistoryStr + ";0.0";
				Array array = Strings.Split(TimeHistory[num], ";");
				string text2 = TimeHistory[num];
				Array array2 = Strings.Split(SpeedHistory[num], ";");
				string text3 = SpeedHistory[num];
				int num3 = Microsoft.VisualBasic.Information.UBound(array2);
				float num4 = default(float);
				for (int i = 0; i <= num3; i++)
				{
					if (Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array2, new object[1] { i }, null))) > (double)num4)
					{
						num4 = (float)Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array2, new object[1] { i }, null)));
					}
				}
				Array array3 = Strings.Split(GradientHistory[num], ";");
				string text4 = GradientHistory[num];
				Array array4 = Strings.Split(WaterDepthHistory[num], ";");
				string text5 = WaterDepthHistory[num];
				Array array5 = Strings.Split(RestHistory[num], ";");
				string text6 = RestHistory[num];
				Array array6 = Strings.Split(RestTimeHistory[num], ";");
				string text7 = RestTimeHistory[num];
				Array array7 = Strings.Split(TemperatureHistory[num], ";");
				string text8 = TemperatureHistory[num];
				Array array8 = Strings.Split(JetHistory[num], ";");
				string text9 = JetHistory[num];
				int num5 = Microsoft.VisualBasic.Information.UBound(array) - 1;
				float num8 = default(float);
				for (int i = 0; i <= num5; i++)
				{
					if (Microsoft.VisualBasic.Information.UBound(array2) >= i)
					{
						ChartHistory.Series["Speed - kmh"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array2, new object[1] { i }, null))));
					}
					if (MachineSetup.InclineDisplayOnOff && Microsoft.VisualBasic.Information.UBound(array3) >= i)
					{
						ChartHistory.Series["Incline - Deg"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array3, new object[1] { i }, null))));
					}
					if (MachineSetup.DepthAdjustOnOff && Microsoft.VisualBasic.Information.UBound(array4) >= i)
					{
						double num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array4, new object[1] { i }, null)));
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array4, new object[1] { i }, null))) > 0.0)
						{
							ChartHistory.Series["Water Depth x 10 cm"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), Conversion.Val(Operators.DivideObject(NewLateBinding.LateIndexGet(array4, new object[1] { i }, null), 10)));
						}
						else
						{
							ChartHistory.Series["Water Depth x 10 cm"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), 0);
						}
					}
					if (Microsoft.VisualBasic.Information.UBound(array6) >= i)
					{
						Array array9 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet(array6, new object[1] { i }, null)), ":");
						int num7 = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array9, new object[1] { 0 }, null))));
						if (Microsoft.VisualBasic.Information.UBound(array9) > 0)
						{
							num8 = (float)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array9, new object[1] { 1 }, null))) * 1.6666666666666667 / 100.0, 2);
						}
						ChartHistory.Series["Rest Time - Min"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), (float)num7 + num8);
					}
					if (MachineSetup.JetDisplayOnOff && Microsoft.VisualBasic.Information.UBound(array8) >= i)
					{
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array8, new object[1] { i }, null))) == 0.0)
						{
							ChartHistory.Series["Jet"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), 0);
						}
						else
						{
							ChartHistory.Series["Jet"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), num4);
						}
					}
				}
				ProduceChartImage();
				PDFSave.PDFChartOne(RuntimeHelpers.GetObjectValue(Drive), RuntimeHelpers.GetObjectValue(Path), RuntimeHelpers.GetObjectValue(FileName));
				if (MachineSetup.USBSave)
				{
					string drive = Functions.GetDrive();
					if (Operators.CompareString(Functions.DirCreate(drive, "\\DWS-History"), "Failed", TextCompare: false) != 0 && Operators.CompareString(Functions.DirCreate(drive + "\\DWS-History\\", MyProject.Forms.Information.ID.Text), "Failed", TextCompare: false) != 0)
					{
						PDFSave.PDFChartOne(drive, "\\DWS-History\\" + MyProject.Forms.Information.ID.Text + "\\", RuntimeHelpers.GetObjectValue(FileName));
					}
				}
				if (Functions.MemoryDrive)
				{
					string drive = Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M") + ":\\";
					if (Operators.CompareString(Functions.DirCreate(drive, "\\DWS-History"), "Failed", TextCompare: false) != 0 && Operators.CompareString(Functions.DirCreate(drive + "\\DWS-History\\", MyProject.Forms.Information.ID.Text), "Failed", TextCompare: false) != 0)
					{
						PDFSave.PDFChartOne(drive, "\\DWS-History\\" + MyProject.Forms.Information.ID.Text + "\\", RuntimeHelpers.GetObjectValue(FileName));
					}
				}
				FindOneDrive();
				if (Operators.CompareString(OneDrivePath, "Failed", TextCompare: false) != 0 && Operators.CompareString(Functions.DirCreate(OneDrivePath, "\\DWS-History"), "Failed", TextCompare: false) != 0 && Operators.CompareString(Functions.DirCreate(OneDrivePath + "\\DWS-History\\", MyProject.Forms.Information.ID.Text), "Failed", TextCompare: false) != 0)
				{
					PDFSave.PDFChartOne(OneDrivePath, "\\DWS-History\\" + MyProject.Forms.Information.ID.Text + "\\", RuntimeHelpers.GetObjectValue(FileName));
				}
				GooglePath = Functions.GoogleDriveCheck();
				if (Operators.CompareString(GooglePath, "Failed", TextCompare: false) != 0 && Operators.CompareString(Functions.DirCreate(GooglePath, "\\DWS-History"), "Failed", TextCompare: false) != 0 && Operators.CompareString(Functions.DirCreate(GooglePath + "\\DWS-History\\", MyProject.Forms.Information.ID.Text), "Failed", TextCompare: false) != 0)
				{
					PDFSave.PDFChartOne(GooglePath, "\\DWS-History\\" + MyProject.Forms.Information.ID.Text + "\\", RuntimeHelpers.GetObjectValue(FileName));
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

	private void GetChartHistoryOne()
	{
		TimeLapse = 0f;
		TimeHold = 0f;
		TimePassStr = "";
		SpeedHistoryStr = "";
		GradientHistoryStr = "";
		TimeHistoryStr = "";
		RestTimeHistoryStr = "";
		WaterHistoryStr = "";
		DistanceHistoryStr = "";
		CalorieHistoryDryStr = "";
		CalorieHistoryWetStr = "";
		RestHistoryStr = "";
		TemperatureHistoryStr = "";
		JetHistoryStr = "";
		int historyProgramIndex = Display.HistoryProgramIndex;
		for (int i = 0; i <= historyProgramIndex; i = checked(i + 1))
		{
			string text = ((i >= Display.HistoryProgramIndex) ? "" : ";");
			SpeedHistoryStr = SpeedHistoryStr + Display.HistoryProgramSpeed[i] + text;
			GradientHistoryStr = GradientHistoryStr + Display.HistoryProgramGradient[i] + text;
			TimeLapse = (float)(Conversion.Val(Display.HistoryProgramTime[i]) - (double)TimeHold);
			TimeHold += TimeLapse;
			TimePassStr = TimePassStr + TimeLapse + text;
			TimeHistoryStr = TimeHistoryStr + Display.HistoryProgramTime[i] + text;
			RestTimeHistoryStr = RestTimeHistoryStr + Display.HistoryProgramRestTime[i] + text;
			WaterHistoryStr = WaterHistoryStr + Display.HistoryProgramWater[i] + text;
			DistanceHistoryStr = DistanceHistoryStr + Display.HistoryProgramDistance[i] + text;
			CalorieHistoryDryStr = CalorieHistoryDryStr + Display.HistoryProgramCalorieDry[i] + text;
			CalorieHistoryWetStr = CalorieHistoryWetStr + Display.HistoryProgramCalorieWet[i] + text;
			RestHistoryStr = RestHistoryStr + Display.HistoryProgramRest[i] + text;
			TemperatureHistoryStr = TemperatureHistoryStr + Display.HistoryProgramTemperature[i] + text;
			JetHistoryStr = JetHistoryStr + Display.HistoryProgramJet[i] + text;
		}
	}

	public void HistoryChart(object FileNo)
	{
		string text = SpeedHistory[Conversions.ToInteger(FileNo)];
		checked
		{
			try
			{
				ChartHistory.Series["Speed - kmh"].Points.Clear();
				if (MachineSetup.InclineDisplayOnOff)
				{
					ChartHistory.Series["Incline - Deg"].Points.Clear();
				}
				if (MachineSetup.DepthAdjustOnOff)
				{
					ChartHistory.Series["Water Depth x 10 cm"].Points.Clear();
				}
				if (MachineSetup.JetDisplayOnOff)
				{
					ChartHistory.Series["Jet"].Points.Clear();
				}
				ChartHistory.Series["Rest Time - Min"].Points.Clear();
				TimeHistory[Conversions.ToInteger(FileNo)] = "00.00" + TimeHistory[Conversions.ToInteger(FileNo)];
				SpeedHistory[Conversions.ToInteger(FileNo)] = SpeedHistory[Conversions.ToInteger(FileNo)] + ";0.0";
				RestTimeHistory[Conversions.ToInteger(FileNo)] = RestTimeHistory[Conversions.ToInteger(FileNo)] + ";0.0";
				if (MachineSetup.InclineDisplayOnOff)
				{
					GradientHistory[Conversions.ToInteger(FileNo)] = GradientHistory[Conversions.ToInteger(FileNo)] + ";0.0";
				}
				if (MachineSetup.DepthAdjustOnOff)
				{
					WaterDepthHistory[Conversions.ToInteger(FileNo)] = WaterDepthHistory[Conversions.ToInteger(FileNo)] + ";0.0";
				}
				if (MachineSetup.ChamberTempOnOff)
				{
					TemperatureHistory[Conversions.ToInteger(FileNo)] = TemperatureHistory[Conversions.ToInteger(FileNo)] + ";0.0";
				}
				if (MachineSetup.JetDisplayOnOff)
				{
					JetHistory[Conversions.ToInteger(FileNo)] = JetHistory[Conversions.ToInteger(FileNo)] + ";0.0";
				}
				RestHistory[Conversions.ToInteger(FileNo)] = RestHistory[Conversions.ToInteger(FileNo)] + ";0.0";
				Array array = Strings.Split(TimeHistory[Conversions.ToInteger(FileNo)], ";");
				string text2 = TimeHistory[Conversions.ToInteger(FileNo)];
				Array array2 = Strings.Split(SpeedHistory[Conversions.ToInteger(FileNo)], ";");
				string text3 = SpeedHistory[Conversions.ToInteger(FileNo)];
				int num = Microsoft.VisualBasic.Information.UBound(array2);
				float num2 = default(float);
				for (int i = 0; i <= num; i++)
				{
					if (Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array2, new object[1] { i }, null))) > (double)num2)
					{
						num2 = (float)Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array2, new object[1] { i }, null)));
					}
				}
				Array array3 = Strings.Split(GradientHistory[Conversions.ToInteger(FileNo)], ";");
				string text4 = GradientHistory[Conversions.ToInteger(FileNo)];
				Array array4 = Strings.Split(WaterDepthHistory[Conversions.ToInteger(FileNo)], ";");
				string text5 = WaterDepthHistory[Conversions.ToInteger(FileNo)];
				Array array5 = Strings.Split(RestHistory[Conversions.ToInteger(FileNo)], ";");
				string text6 = RestHistory[Conversions.ToInteger(FileNo)];
				Array array6 = Strings.Split(RestTimeHistory[Conversions.ToInteger(FileNo)], ";");
				string text7 = RestTimeHistory[Conversions.ToInteger(FileNo)];
				Array array7 = Strings.Split(TemperatureHistory[Conversions.ToInteger(FileNo)], ";");
				string text8 = TemperatureHistory[Conversions.ToInteger(FileNo)];
				Array array8 = Strings.Split(JetHistory[Conversions.ToInteger(FileNo)], ";");
				string text9 = JetHistory[Conversions.ToInteger(FileNo)];
				int num3 = Microsoft.VisualBasic.Information.UBound(array) - 1;
				float num6 = default(float);
				for (int i = 0; i <= num3; i++)
				{
					if (Microsoft.VisualBasic.Information.UBound(array2) >= i)
					{
						ChartHistory.Series["Speed - kmh"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array2, new object[1] { i }, null))));
					}
					if (MachineSetup.InclineDisplayOnOff && Microsoft.VisualBasic.Information.UBound(array3) >= i)
					{
						ChartHistory.Series["Incline - Deg"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array3, new object[1] { i }, null))));
					}
					if (MachineSetup.DepthAdjustOnOff && Microsoft.VisualBasic.Information.UBound(array4) >= i)
					{
						double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array4, new object[1] { i }, null)));
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array4, new object[1] { i }, null))) > 0.0)
						{
							ChartHistory.Series["Water Depth x 10 cm"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), Conversion.Val(Operators.DivideObject(NewLateBinding.LateIndexGet(array4, new object[1] { i }, null), 10)));
						}
						else
						{
							ChartHistory.Series["Water Depth x 10 cm"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), 0);
						}
					}
					if (Microsoft.VisualBasic.Information.UBound(array6) >= i)
					{
						Array array9 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet(array6, new object[1] { i }, null)), ":");
						int num5 = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array9, new object[1] { 0 }, null))));
						if (Microsoft.VisualBasic.Information.UBound(array9) > 0)
						{
							num6 = (float)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array9, new object[1] { 1 }, null))) * 1.6666666666666667 / 100.0, 2);
						}
						ChartHistory.Series["Rest Time - Min"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), (float)num5 + num6);
					}
					if (MachineSetup.JetDisplayOnOff && Microsoft.VisualBasic.Information.UBound(array8) >= i)
					{
						if (Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array8, new object[1] { i }, null))) == 0.0)
						{
							ChartHistory.Series["Jet"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), 0);
						}
						else
						{
							ChartHistory.Series["Jet"].Points.AddXY(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { i }, null)), num2);
						}
					}
				}
				ChartHistory.Visible = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DisplayHistoryGraphic(object FileNo)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		checked
		{
			try
			{
				Array array = Strings.Split(DistanceHistory[Conversions.ToInteger(FileNo)], ";");
				string text6 = Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { Microsoft.VisualBasic.Information.UBound(array) }, null));
				Array array2 = Strings.Split(CalorieDryHistory[Conversions.ToInteger(FileNo)], ";");
				string text7 = Conversions.ToString(NewLateBinding.LateIndexGet(array2, new object[1] { Microsoft.VisualBasic.Information.UBound(array2) }, null));
				Array array3 = Strings.Split(CalorieWetHistory[Conversions.ToInteger(FileNo)], ";");
				string text8 = Conversions.ToString(NewLateBinding.LateIndexGet(array3, new object[1] { Microsoft.VisualBasic.Information.UBound(array3) }, null));
				Bitmap image = new Bitmap(HistoryTextImage.Width, HistoryTextImage.Height, PixelFormat.Format32bppArgb);
				Graphics graphics = Graphics.FromImage(image);
				text = "ID : " + IDHistory[Conversions.ToInteger(FileNo)] + "  --  Name: " + NamePersonHistory[Conversions.ToInteger(FileNo)] + "  --  House No: " + HouseNoHistory[Conversions.ToInteger(FileNo)] + "  --  Post Code: " + PostCodeHistory[Conversions.ToInteger(FileNo)] + "  --  Referral End Date: " + RefPersonHistory[Conversions.ToInteger(FileNo)];
				text2 = "";
				if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0)
				{
					text2 = text2 + "Animal Name: " + AnimalNameHistory[Conversions.ToInteger(FileNo)] + "  --  ";
				}
				if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0)
				{
					text2 = text2 + "Dog Name: " + AnimalNameHistory[Conversions.ToInteger(FileNo)] + "  --  ";
				}
				if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0))
				{
					text2 = text2 + "Breed: " + BreedHistory[Conversions.ToInteger(FileNo)] + "  --  ";
				}
				else if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) == 0)
				{
					text2 += "Health:   --  ";
				}
				text2 = text2 + "Weight kg : " + WeightHistory[Conversions.ToInteger(FileNo)] + "  --  Height cm: " + HeightHistory[Conversions.ToInteger(FileNo)] + "  --  Sex: " + SexHistory[Conversions.ToInteger(FileNo)] + "  --  DOB: " + DOBHistory[Conversions.ToInteger(FileNo)];
				if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
				{
					text2 = text2 + "  --  BMI: " + BMIHistory[Conversions.ToInteger(FileNo)];
				}
				text3 = "";
				if (Operators.CompareString(TrainerHistory[Conversions.ToInteger(FileNo)], "", TextCompare: false) != 0)
				{
					text3 = text3 + "Therapist: " + TrainerHistory[Conversions.ToInteger(FileNo)] + "   --   ";
				}
				text3 = text3 + "Duration " + DurationHistory[Conversions.ToInteger(FileNo)] + "  --  Rest " + RestTotalHistory[Conversions.ToInteger(FileNo)];
				if (MachineSetup.ChamberTempOnOff)
				{
					text3 = text3 + "  --  Ave Temp " + Conversions.ToString(Display.TemperatureAve);
				}
				if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
				{
					text3 = text3 + "  --  Used Cal Dry: " + text7 + " kcal";
					if (MachineSetup.CalorieIndWetOnOff)
					{
						text3 = text3 + "  --  Used Cal Wet: " + text8 + " kcal";
					}
				}
				text4 = "";
				string text9;
				string text10;
				if (!Display.CleanOp)
				{
					text9 = ((MyProject.Forms.Display.SpeedProgramSet != 0) ? (Conversions.ToString(MyProject.Forms.Display.SpeedProgramSet) ?? "") : ((!Display.SpeedProgramReverse) ? "Manual/F" : "Manual/R"));
					text10 = ((MyProject.Forms.Display.GradientProgramSet != 0) ? (Conversions.ToString(MyProject.Forms.Display.GradientProgramSet) ?? "") : "Manual");
				}
				else
				{
					text9 = "Cleaning";
					text10 = "Cleaning";
				}
				text4 = text4 + "Speed P " + text9 + "  --  Max kmh: " + MaxkmhHistory[Conversions.ToInteger(FileNo)] + "  --  Max M/m: " + Conversions.ToString(Math.Round(Conversion.Val(MaxkmhHistory[Conversions.ToInteger(FileNo)]) * 1000.0 / 60.0, 3)) + "  --  Distance: " + text6 + " km";
				text5 = "";
				if (MachineSetup.InclineDisplayOnOff)
				{
					text5 = text5 + "Gradient P " + text10 + "  --  Max %: " + MaxPercentHistory[Conversions.ToInteger(FileNo)] + "  --  Max Deg: " + MaxDegHistory[Conversions.ToInteger(FileNo)];
				}
				object obj = new StringFormat
				{
					LineAlignment = StringAlignment.Center,
					Alignment = StringAlignment.Center
				};
				object obj2 = new StringFormat
				{
					LineAlignment = StringAlignment.Near,
					Alignment = StringAlignment.Near
				};
				object left = NameListView.Width;
				object right = 140f * ResMultiW;
				Font font = new Font("Verdana", 12f, FontStyle.Bold);
				graphics.DrawString(MyProject.Forms.MachineSetup.CustomerName.Text, font, Brushes.White, Conversions.ToSingle(Operators.DivideObject(left, 2)), 10f, (StringFormat)obj);
				font = new Font("Verdana", 9f, FontStyle.Regular);
				graphics.DrawString("Date & Time: " + DateTimeHistory[Conversions.ToInteger(FileNo)], font, Brushes.White, 10f, 5f, (StringFormat)obj2);
				graphics.DrawString("Report: " + ReportNumberHistory[Conversions.ToInteger(FileNo)], font, Brushes.White, Conversions.ToSingle(Operators.SubtractObject(left, right)), 5f, (StringFormat)obj2);
				graphics.DrawString(text, font, Brushes.White, 10f, 25f, (StringFormat)obj2);
				graphics.DrawString(text2, font, Brushes.White, 10f, 40f, (StringFormat)obj2);
				graphics.DrawString(text3, font, Brushes.White, 10f, 55f, (StringFormat)obj2);
				graphics.DrawString(text4, font, Brushes.White, 10f, 70f, (StringFormat)obj2);
				graphics.DrawString(text5, font, Brushes.White, 10f, 85f, (StringFormat)obj2);
				HistoryTextImage.Image = image;
				ControlChange("HistoryTextImage", "Visible", Conversions.ToString(Value: true));
				graphics.Dispose();
				int num = HistoryTextImage.Width;
				int num2 = HistoryTextImage.Height;
				Bitmap bitmap = new Bitmap(num, num2, PixelFormat.Format32bppArgb);
				Graphics graphics2 = Graphics.FromImage(bitmap);
				int num3 = num - 1;
				for (int i = 0; i <= num3; i++)
				{
					int num4 = num2 - 1;
					for (int j = 0; j <= num4; j++)
					{
						Color pixel = bitmap.GetPixel(i, j);
						pixel = Color.FromArgb(255, 255, 255);
						bitmap.SetPixel(i, j, pixel);
					}
				}
				font = new Font("Verdana", 12f, FontStyle.Bold);
				graphics2.DrawString(MyProject.Forms.MachineSetup.CustomerName.Text, font, Brushes.Black, Conversions.ToSingle(Operators.DivideObject(left, 2)), 10f, (StringFormat)obj);
				font = new Font("Verdana", 9f, FontStyle.Regular);
				graphics2.DrawString("Date & Time: " + DateTimeHistory[Conversions.ToInteger(FileNo)], font, Brushes.Black, 10f, 5f, (StringFormat)obj2);
				graphics2.DrawString("Report: " + ReportNumberHistory[Conversions.ToInteger(FileNo)], font, Brushes.Black, Conversions.ToSingle(Operators.SubtractObject(left, right)), 5f, (StringFormat)obj2);
				graphics2.DrawString(text, font, Brushes.Black, 10f, 25f, (StringFormat)obj2);
				graphics2.DrawString(text2, font, Brushes.Black, 10f, 40f, (StringFormat)obj2);
				graphics2.DrawString(text3, font, Brushes.Black, 10f, 55f, (StringFormat)obj2);
				graphics2.DrawString(text4, font, Brushes.Black, 10f, 70f, (StringFormat)obj2);
				graphics2.DrawString(text5, font, Brushes.Black, 10f, 85f, (StringFormat)obj2);
				Image image2 = bitmap;
				image2.Save(MyProject.Application.Info.DirectoryPath + "\\MainHistory.bmp", ImageFormat.Bmp);
				graphics2.Dispose();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ImageProduce(object FileNo, object Line_1, object Line_2, object Line_3, object Line_4, object Line_5)
	{
		object left = NameListView.Width;
		object right = 140f * ResMultiW;
		object obj = new StringFormat
		{
			LineAlignment = StringAlignment.Center,
			Alignment = StringAlignment.Center
		};
		object obj2 = new StringFormat
		{
			LineAlignment = StringAlignment.Near,
			Alignment = StringAlignment.Near
		};
		int num = HistoryTextImage.Width;
		int num2 = HistoryTextImage.Height;
		Bitmap bitmap = new Bitmap(num, num2, PixelFormat.Format32bppArgb);
		Graphics graphics = Graphics.FromImage(bitmap);
		checked
		{
			int num3 = num - 1;
			for (int i = 0; i <= num3; i++)
			{
				int num4 = num2 - 1;
				for (int j = 0; j <= num4; j++)
				{
					Color pixel = bitmap.GetPixel(i, j);
					pixel = Color.FromArgb(255, 255, 255);
					bitmap.SetPixel(i, j, pixel);
				}
			}
			graphics.DrawString(MyProject.Forms.MachineSetup.CustomerName.Text, Font, Brushes.Black, Conversions.ToSingle(Operators.DivideObject(left, 2)), 10f, (StringFormat)obj);
			Font = new Font("Verdana", 9f, FontStyle.Regular);
			graphics.DrawString("Date & Time: " + DateTimeHistory[Conversions.ToInteger(FileNo)], Font, Brushes.Black, 10f, 5f, (StringFormat)obj2);
			graphics.DrawString("Report: " + ReportNumberHistory[Conversions.ToInteger(FileNo)], Font, Brushes.Black, Conversions.ToSingle(Operators.SubtractObject(left, right)), 5f, (StringFormat)obj2);
			graphics.DrawString(Conversions.ToString(Line_1), Font, Brushes.Black, 10f, 25f, (StringFormat)obj2);
			graphics.DrawString(Conversions.ToString(Line_2), Font, Brushes.Black, 10f, 40f, (StringFormat)obj2);
			graphics.DrawString(Conversions.ToString(Line_3), Font, Brushes.Black, 10f, 55f, (StringFormat)obj2);
			graphics.DrawString(Conversions.ToString(Line_4), Font, Brushes.Black, 10f, 70f, (StringFormat)obj2);
			graphics.DrawString(Conversions.ToString(Line_5), Font, Brushes.Black, 10f, 85f, (StringFormat)obj2);
			Image image = bitmap;
			image.Save(MyProject.Application.Info.DirectoryPath + "\\MainHistory.bmp", ImageFormat.Bmp);
			graphics.Dispose();
		}
	}

	private void ReadInformationHistory(object File, object Index, object MaxNoFiles)
	{
		string text = Conversions.ToString(File);
		string text2 = "";
		int num = 0;
		checked
		{
			object obj = Strings.Mid(Conversions.ToString(File), Strings.Len(RuntimeHelpers.GetObjectValue(File)) - 26, 15);
			try
			{
				StreamReader streamReader = new StreamReader(text);
				string text3;
				do
				{
					text3 = streamReader.ReadLine();
					if (Operators.ConditionalCompareObjectLessEqual(Index, MaxNoFiles, TextCompare: false))
					{
						DateTimeFileNameHistory[Conversions.ToInteger(Index)] = Strings.Mid(text, Strings.Len(text) - 26, 15);
						if (Operators.CompareString(Strings.Mid(text3, 1, 8), "Report: ", TextCompare: false) == 0)
						{
							ReportNumberHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 9, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 13), "Date & Time: ", TextCompare: false) == 0)
						{
							DateTimeHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 14, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 8), "Key No: ", TextCompare: false) == 0)
						{
							KeyNoHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 9, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 9), "Trainer: ", TextCompare: false) == 0)
						{
							TrainerHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 10, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 6), "Name: ", TextCompare: false) == 0)
						{
							NamePersonHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 7, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 12), "AnimalName: ", TextCompare: false) == 0)
						{
							AnimalNameHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 13, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 13), "Animal Name: ", TextCompare: false) == 0)
						{
							AnimalNameHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 14, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 10), "Dog Name: ", TextCompare: false) == 0)
						{
							AnimalNameHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 9), "DogName: ", TextCompare: false) == 0)
						{
							AnimalNameHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 10, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 4), "ID: ", TextCompare: false) == 0)
						{
							IDHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 5, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 10), "PostCode: ", TextCompare: false) == 0)
						{
							PostCodeHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 9), "HouseNo: ", TextCompare: false) == 0)
						{
							HouseNoHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 10, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 5), "DOB: ", TextCompare: false) == 0)
						{
							DOBHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 6, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 5), "Sex: ", TextCompare: false) == 0)
						{
							SexHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 6, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 8), "Height: ", TextCompare: false) == 0)
						{
							HeightHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 9, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 8), "Weight: ", TextCompare: false) == 0)
						{
							WeightHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 9, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 7), "Breed: ", TextCompare: false) == 0)
						{
							BreedHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 8, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 10), "ProgramS: ", TextCompare: false) == 0)
						{
							ProgramSHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 10), "ProgramG: ", TextCompare: false) == 0)
						{
							ProgramGHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 6), "Time: ", TextCompare: false) == 0)
						{
							TimeHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 7, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 9), "Time Min:", TextCompare: false) == 0)
						{
							TimeHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 10, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 10), "Duration: ", TextCompare: false) == 0)
						{
							DurationHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 12), "Rest Total: ", TextCompare: false) == 0)
						{
							RestTotalHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 13, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 11), "Rest Time: ", TextCompare: false) == 0)
						{
							RestTimeHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 12, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 7), "Speed: ", TextCompare: false) == 0)
						{
							SpeedHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 8, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 10), "Gradient: ", TextCompare: false) == 0)
						{
							GradientHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 10), "Distance: ", TextCompare: false) == 0)
						{
							DistanceHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 9), "Max kmh: ", TextCompare: false) == 0)
						{
							MaxkmhHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 10, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 10), "Max km/h: ", TextCompare: false) == 0)
						{
							MaxkmhHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 9), "Max Deg: ", TextCompare: false) == 0)
						{
							MaxDegHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 10, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 8), "Max % : ", TextCompare: false) == 0)
						{
							MaxPercentHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 9, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 13), "Water Depth: ", TextCompare: false) == 0)
						{
							WaterDepthHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 14, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 14), "Calories Dry: ", TextCompare: false) == 0)
						{
							CalorieDryHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 14), "Calories Wet: ", TextCompare: false) == 0)
						{
							CalorieWetHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 5), "Jet: ", TextCompare: false) == 0)
						{
							JetHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 6, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 5), "BMI: ", TextCompare: false) == 0)
						{
							BMIHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 6, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 10), "Referral: ", TextCompare: false) == 0)
						{
							RefPersonHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 11, Strings.Len(text3));
						}
						if (Operators.CompareString(Strings.Mid(text3, 1, 11), "Direction: ", TextCompare: false) == 0)
						{
							DirectionHistory[Conversions.ToInteger(Index)] = Strings.Mid(text3, 12, Strings.Len(text3));
						}
					}
				}
				while (text3 != null);
				if (Operators.CompareString(ReportNumberHistory[Conversions.ToInteger(Index)], "", TextCompare: false) == 0)
				{
					ReportNumberHistory[Conversions.ToInteger(Index)] = "Report: Nil";
				}
				streamReader.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string text4 = "NoFile";
				ProjectData.ClearProjectError();
			}
		}
	}

	public object GetFiles(string xPath)
	{
		int num = 0;
		HistoryUpperIndex = 0;
		HistoryUpperIndexArchive = 0;
		checked
		{
			object result;
			try
			{
				if (Directory.GetDirectories(xPath).Length > 0)
				{
					string[] directories = Directory.GetDirectories(xPath);
					foreach (string text in directories)
					{
						if (Directory.Exists(text))
						{
							GetFiles(text);
						}
					}
				}
				if (Directory.GetFiles(xPath).Length > 0)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(xPath);
					FileInfo[] files = directoryInfo.GetFiles();
					Array.Sort(files, new CLSCompareFileInfo());
					int num2 = Microsoft.VisualBasic.Information.UBound(files);
					FileInfo[] array = files;
					int num3 = default(int);
					foreach (FileInfo fileInfo in array)
					{
						if (Operators.CompareString(Strings.Mid(fileInfo.FullName.ToString(), Strings.Len(fileInfo.FullName.ToString()) - 2, 3), "txt", TextCompare: false) == 0)
						{
							num3++;
						}
					}
					int num4 = ((!Operators.ConditionalCompareObjectGreater(num3, RecordsDisplayedMax, TextCompare: false)) ? num3 : Conversions.ToInteger(RecordsDisplayedMax));
					string text2 = "";
					FileInfo[] array2 = files;
					foreach (FileInfo fileInfo2 in array2)
					{
						string text3 = "";
						text3 = Strings.Mid(fileInfo2.FullName.ToString(), Strings.Len(fileInfo2.FullName.ToString()) - 2, 3);
						if (Operators.CompareString(Strings.Mid(fileInfo2.FullName.ToString(), Strings.Len(fileInfo2.FullName.ToString()) - 2, 3), "txt", TextCompare: false) == 0)
						{
							if (Operators.ConditionalCompareObjectGreaterEqual(num, Operators.SubtractObject(num3 + 1, RecordsDisplayedMax), TextCompare: false))
							{
								ReadInformationHistory(xPath + "\\" + Path.GetFileName(fileInfo2.FullName.ToString()), HistoryUpperIndex, num4);
								HistoryUpperIndex++;
								text2 = ((!Functions.FileExist(Strings.Mid(fileInfo2.FullName.ToString(), 1, Strings.Len(fileInfo2.FullName.ToString()) - 11) + "Chart.pdf", "")) ? (text2 + Strings.Mid(fileInfo2.FullName.ToString(), 1, Strings.Len(fileInfo2.FullName.ToString()) - 11) + "Chart.pdf;") : (text2 + "1;"));
							}
							num++;
						}
					}
					if (HistoryUpperIndex > 0)
					{
						HistoryUpperIndex--;
						HistoryPDF = Strings.Split(text2, ";");
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private void ListviewSearch()
	{
		string pattern = "*" + Searchbox.Text + "*";
		NameListView.SelectedIndices.Clear();
		foreach (ListViewItem item in NameListView.Items)
		{
			foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
			{
				if (LikeOperator.LikeString(subItem.Text, pattern, Microsoft.VisualBasic.CompareMethod.Binary))
				{
					NameListView.SelectedIndices.Add(item.Index);
					ControlChange("Accept", "Focus", "Set");
					return;
				}
			}
		}
		ControlChange("Accept", "Focus", "Set");
	}

	private void ButtonSelection(object Buttons)
	{
		if (Operators.ConditionalCompareObjectEqual(Buttons, 0, TextCompare: false))
		{
			ControlChange("Accept", "Text", "Select Name");
			ControlChange("Accept", "Visible", "True");
			ControlChange("Accept", "Enabled", "True");
			ControlChange("Searchbox", "Visible", "True");
			ControlChange("SearchPic", "Visible", "True");
			ControlChange("OlderRecord", "Visable", "True");
			ControlChange("History", "Visible", "False");
			ControlChange("SaveList", "Visible", "False");
			ControlChange("DelName", "Visible", "False");
			ControlChange("CloseFrm", "Visible", "True");
			ControlChange("PersonName", "Visible", "False");
			ControlChange("PersonName", "Text", "");
			ControlChange("ID", "Visible", "False");
			ControlChange("ID", "Text", "");
			ControlChange("Animal", "Visible", "False");
			ControlChange("Animal", "Text", "");
		}
		else if (Operators.ConditionalCompareObjectEqual(Buttons, 1, TextCompare: false))
		{
			ControlChange("Accept", "Text", "Accept Selection");
			ControlChange("Accept", "Visible", "True");
			ControlChange("Searchbox", "Visible", "True");
			ControlChange("SearchPic", "Visible", "True");
			ControlChange("OlderRecord", "Visible", "False");
			ControlChange("CloseFrm", "Visible", "True");
			ControlChange("PersonName", "Visible", "True");
			ControlChange("ID", "Visible", "True");
			ControlChange("Animal", "Visible", "True");
			TransferCheck();
		}
		else if (Operators.ConditionalCompareObjectEqual(Buttons, 2, TextCompare: false))
		{
			ControlChange("Accept", "Text", "Accept Selection");
			ControlChange("Accept", "Visible", "True");
			ControlChange("Searchbox", "Visible", "True");
			ControlChange("SearchPic", "Visible", "True");
			ControlChange("OlderRecord", "Visible", "False");
			ControlChange("CloseFrm", "Visible", "True");
			ControlChange("PersonName", "Visible", "True");
			ControlChange("ID", "Visible", "True");
			ControlChange("Animal", "Visible", "True");
			if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
			{
				ControlChange("DelName", "Visible", "False");
				ControlChange("SaveList", "Visible", "False");
			}
			else
			{
				ControlChange("DelName", "Visible", "True");
			}
			TransferCheck();
		}
	}

	private void PDFCheck()
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(HistoryPDF, new object[1] { RecordNumber }, null), "1", TextCompare: false))
		{
			return;
		}
		try
		{
			ProduceChartImage();
			PDFSave.PDFChart(RecordNumber, "", "", RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(HistoryPDF, new object[1] { RecordNumber }, null)));
			NewLateBinding.LateIndexSet(HistoryPDF, new object[2] { RecordNumber, "1" }, null);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void OlderRecord_Click(object sender, EventArgs e)
	{
		checked
		{
			if (RecordNumber > 0)
			{
				NewerRecord.Enabled = true;
				ControlChange("NewerRecord", "Visible", "True");
				RecordNumber--;
				DisplayHistoryGraphic(RecordNumber);
				HistoryChart(RecordNumber);
				PDFCheck();
				PDFFileCheck();
				if (RecordNumber == 0)
				{
					OlderRecord.Enabled = false;
					ControlChange("OlderRecord", "Visible", "False");
				}
			}
		}
	}

	private void NewerRecord_Click(object sender, EventArgs e)
	{
		checked
		{
			if (RecordNumber < HistoryIndexMax)
			{
				ControlChange("OlderRecord", "Visible", "True");
				OlderRecord.Enabled = true;
				RecordNumber++;
				DisplayHistoryGraphic(RecordNumber);
				HistoryChart(RecordNumber);
				PDFCheck();
				PDFFileCheck();
				if (RecordNumber == HistoryIndexMax)
				{
					NewerRecord.Enabled = false;
					ControlChange("NewerRecord", "Visible", "False");
				}
			}
		}
	}

	private void HistoryText_GotFocus(object sender, EventArgs e)
	{
		ControlChange("CloseFrm", "Focus", "Set");
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
			case "Hide":
				if (Operators.CompareString(Data, "True", TextCompare: false) == 0)
				{
					base.Controls[ControlName].Hide();
				}
				break;
			case "Show":
				if (Operators.CompareString(Data, "True", TextCompare: false) == 0)
				{
					base.Controls[ControlName].Show();
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
			case "Color":
				switch (Data)
				{
				case "White":
					base.Controls[ControlName].ForeColor = Color.White;
					break;
				case "Red":
					base.Controls[ControlName].ForeColor = Color.Red;
					break;
				case "Yellow":
					base.Controls[ControlName].ForeColor = Color.Yellow;
					break;
				case "Orange":
					base.Controls[ControlName].ForeColor = Color.Orange;
					break;
				case "Gray":
					base.Controls[ControlName].ForeColor = Color.Gray;
					break;
				}
				break;
			}
		}
	}

	public void ChangeMe(string Setting, string Data)
	{
		if (base.InvokeRequired)
		{
			SetControl1Callback method = [SpecialName] [DebuggerHidden] (string a0, bool a1) =>
			{
				ChangeMe(a0, Conversions.ToString(a1));
			};
			Invoke(method, Setting, Data);
			return;
		}
		switch (Setting)
		{
		case "Text":
			Text = Data;
			break;
		case "Visible":
			if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
			{
				base.Visible = false;
				Hide();
				ChartHistoryOff();
			}
			else
			{
				base.Visible = true;
			}
			break;
		case "TopMost":
			if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
			{
				base.TopMost = false;
			}
			else
			{
				base.TopMost = true;
			}
			break;
		case "WindowsState":
			if (Operators.CompareString(Data, "Normal", TextCompare: false) == 0)
			{
				base.WindowState = FormWindowState.Normal;
			}
			else if (Operators.CompareString(Data, "Maximized", TextCompare: false) == 0)
			{
				base.WindowState = FormWindowState.Maximized;
			}
			else
			{
				base.WindowState = FormWindowState.Minimized;
			}
			break;
		}
	}

	private void PrintForm()
	{
		mPrintBitMap = new Bitmap(base.Width, base.Height);
		Rectangle targetBounds = default(Rectangle);
		targetBounds.Width = base.Width;
		targetBounds.Height = base.Height;
		DrawToBitmap(mPrintBitMap, targetBounds);
		PrintDocumentForm = new PrintDocument();
		PrintDocumentForm.Print();
		mPrintBitMap.Dispose();
	}

	private void PrintDocumentForm_PrintPage(object sender, PrintPageEventArgs e)
	{
		e.PageSettings.Landscape = true;
		checked
		{
			int num = e.MarginBounds.X + unchecked(checked(e.MarginBounds.Width - mPrintBitMap.Width) / 2);
			int num2 = e.MarginBounds.Y + unchecked(checked(e.MarginBounds.Height - mPrintBitMap.Height) / 2);
			e.Graphics.DrawImage(mPrintBitMap, num, num2);
			e.PageSettings.Landscape = true;
			e.HasMorePages = false;
		}
	}

	public static string DefaultPrinterName()
	{
		PrinterSettings printerSettings = new PrinterSettings();
		string result;
		try
		{
			result = printerSettings.PrinterName;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		finally
		{
			printerSettings = null;
		}
		return result;
	}

	private bool CheckPrinter(string NameOfPrinter)
	{
		bool result = false;
		if (Operators.ConditionalCompareObjectEqual(StatusOfPrinter(), true, TextCompare: false))
		{
			try
			{
				PrintDocument printDocument = new PrintDocument();
				printDocument.PrinterSettings.PrinterName = NameOfPrinter;
				printDocument.PrinterSettings.Copies = 1;
				result = printDocument.PrinterSettings.IsValid;
				CheckPrinterStatus.Enabled = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
		}
		return result;
	}

	private void PrintIt_Click(object sender, EventArgs e)
	{
		string text = "C:";
		string text2 = "\\Users\\Public";
		string text3 = "\\Open";
		if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
		{
			text3 = "\\OpenP";
		}
		string text4 = "\\DWS-History";
		if ((Operators.CompareString(MachineSetup.PDFOrPrint, "PDF/Print", TextCompare: false) == 0) | (Operators.CompareString(MachineSetup.PDFOrPrint, "PDF", TextCompare: false) == 0))
		{
			string text5 = DateTimeFileNameHistory[RecordNumber];
			ProduceChartImage();
			PDFSave.PDFChart(RecordNumber, text, text2 + text3 + text4 + "\\", IDHistory[RecordNumber] + "\\" + IDHistory[RecordNumber] + "_" + text5 + "_Chart.pdf");
			if (MachineSetup.USBSave)
			{
				string drive = Functions.GetDrive();
				if (Operators.CompareString(drive, "", TextCompare: false) != 0 && Operators.CompareString(Functions.DirCreate(drive, text4), "Failed", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Functions.DirCreate(drive, text4 + "\\" + IDHistory[RecordNumber]), "Failed", TextCompare: false) != 0)
					{
						Functions.CopyFiles(text + text2 + text3 + text4 + "\\" + IDHistory[RecordNumber] + "\\", IDHistory[RecordNumber] + "_" + text5 + "_History.txt", drive + text4 + "\\" + IDHistory[RecordNumber] + "\\");
						PDFSave.PDFChart(RecordNumber, drive, "\\" + text4 + "\\", IDHistory[RecordNumber] + "\\" + IDHistory[RecordNumber] + "_" + text5 + "_Chart.pdf");
					}
					PDFFileCheck();
				}
			}
			FindOneDrive();
			if (Operators.CompareString(OneDrivePath, "Failed", TextCompare: false) != 0 && Operators.CompareString(Functions.DirCreate(OneDrivePath, text4), "Failed", TextCompare: false) != 0)
			{
				if (Operators.CompareString(Functions.DirCreate(OneDrivePath, text4 + "\\" + IDHistory[RecordNumber]), "Failed", TextCompare: false) != 0)
				{
					Functions.CopyFiles(text + text2 + text3 + text4 + "\\" + IDHistory[RecordNumber] + "\\", IDHistory[RecordNumber] + "_" + text5 + "_History.txt", OneDrivePath + text4 + "\\" + IDHistory[RecordNumber] + "\\");
					PDFSave.PDFChart(RecordNumber, OneDrivePath, "\\" + text4 + "\\", IDHistory[RecordNumber] + "\\" + IDHistory[RecordNumber] + "_" + text5 + "_Chart.pdf");
				}
				PDFFileCheck();
			}
		}
		if ((Operators.CompareString(MachineSetup.PDFOrPrint, "PDF/Print", TextCompare: false) == 0) | (Operators.CompareString(MachineSetup.PDFOrPrint, "Print", TextCompare: false) == 0))
		{
			PrintThis();
		}
	}

	private void FindOneDrive()
	{
		string mainDirName = Functions.GetMainDirName();
		string text = "\\OneDrive";
		string text2 = "C:\\Users\\" + mainDirName;
		if (Operators.CompareString(Functions.DirExist(text2, text), "Failed", TextCompare: false) != 0)
		{
			OneDrivePath = text2 + text;
		}
		else
		{
			OneDrivePath = "Failed";
		}
	}

	public object FormatDateTime(object Data)
	{
		string text = "";
		string expression = Strings.Mid(Conversions.ToString(Data), 1, 10);
		Array array = Strings.Split(expression, "/");
		checked
		{
			string expression2 = Strings.Mid(Conversions.ToString(Data), Strings.Len(RuntimeHelpers.GetObjectValue(Data)) - 7, Strings.Len(RuntimeHelpers.GetObjectValue(Data)));
			Array array2 = Strings.Split(expression2, ":");
			int num = Microsoft.VisualBasic.Information.UBound(array);
			for (int i = 0; i <= num; i++)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(array, new object[1] { i }, null), text));
			}
			text += "_";
			int num2 = Microsoft.VisualBasic.Information.UBound(array2);
			for (int i = 0; i <= num2; i++)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, NewLateBinding.LateIndexGet(array2, new object[1] { i }, null)));
			}
			return text;
		}
	}

	private void ProduceChartImage()
	{
		try
		{
			ChartHistory.SaveImage(MyProject.Application.Info.DirectoryPath + "\\MainChart.tif", ImageFormat.Tiff);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ProduceHistoryImage()
	{
		try
		{
			HistoryTextImage.Image.Save(MyProject.Application.Info.DirectoryPath + "\\MainHistory.tif", ImageFormat.Tiff);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PrintThis()
	{
		if (!CheckPrinter(DefaultPrinterName()))
		{
			return;
		}
		try
		{
			MPrintDocument = new PrintDocument();
			MPrintDocument.DefaultPageSettings.Landscape = true;
			MPrintDocument.Print();
			if (!CheckPrinter(DefaultPrinterName()))
			{
				MPrintDocument.Dispose();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void M_PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
	{
		string setting = Interaction.GetSetting("Dtread", "Aqua", "CustomerName");
		short num = 10;
		short num2 = 100;
		short num3 = num;
		checked
		{
			short num4 = (short)(num2 + 190);
			Rectangle position = new Rectangle(num3, num4, e.PageBounds.Width - num3, ChartHistory.Height);
			Rectangle rect = new Rectangle(num, num2, e.PageBounds.Width - num, (short)unchecked(num4 - num2));
			Image image = Image.FromFile(MyProject.Application.Info.DirectoryPath + "\\MainHistory.bmp");
			e.Graphics.DrawImage(image, rect);
			ChartHistory.Printing.PrintPaint(e.Graphics, position);
		}
	}

	private string PrinterStatusToString(PrinterStatus ps)
	{
		return ps switch
		{
			PrinterStatus.PrinterIdle => "idle", 
			PrinterStatus.PrinterPrinting => "printing", 
			PrinterStatus.PrinterWarmingUp => "warmup", 
			_ => "unknown", 
		};
	}

	public object StatusOfPrinter()
	{
		string text = "localhost";
		bool flag = false;
		try
		{
			string pathName = "winmgmts://" + text;
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Interaction.GetObject(pathName), null, "InstancesOf", new object[1] { "win32_Printer" }, null, null, null));
			foreach (object item in (IEnumerable)objectValue)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(item);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue2, null, "Name", new object[0], null, null, null), DefaultPrinterName(), TextCompare: false))
				{
					if (Operators.CompareString(PrinterStatusToString((PrinterStatus)Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "PrinterStatus", new object[0], null, null, null))), "idle", TextCompare: false) == 0)
					{
						ControlChange("", "Text", MachineSetup.PDFOrPrint);
						flag = true;
					}
					else if (Operators.CompareString(PrinterStatusToString((PrinterStatus)Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "PrinterStatus", new object[0], null, null, null))), "printing", TextCompare: false) == 0)
					{
						ControlChange("PrintIt", "Text", "Busy");
					}
					else if (Operators.CompareString(PrinterStatusToString((PrinterStatus)Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "PrinterStatus", new object[0], null, null, null))), "warmup", TextCompare: false) == 0)
					{
						ControlChange("PrintIt", "Text", "Try Later");
					}
					else if (Operators.CompareString(PrinterStatusToString((PrinterStatus)Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "PrinterStatus", new object[0], null, null, null))), "unknown", TextCompare: false) == 0)
					{
						ControlChange("PrintIt", "Text", "Print Failed");
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	private void CheckPrinterStatus_Tick(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(StatusOfPrinter(), true, TextCompare: false))
		{
			CheckPrinterStatus.Dispose();
		}
	}

	public void LoadName()
	{
		NameLoad(Display.NameArrayMax);
	}

	private void Transfer_Click(object sender, EventArgs e)
	{
		checked
		{
			short num = (short)Transfer.Width;
			short num2 = (short)Transfer.Height;
			short num3 = (short)Transfer.Left;
			short num4 = (short)Transfer.Top;
			string text = "";
			string text2 = "DWS-History";
			string text3 = "";
			string text4 = "\\Open";
			if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
			{
				text4 = "\\OpenP";
			}
			string text5 = "C:\\Users\\Public" + text4 + "\\DWS\\";
			float size = default(float);
			try
			{
				History.Hide();
				SaveList.Hide();
				ControlChange("Searchbox", "Visible", "False");
				ControlChange("SearchPic", "Visible", "False");
				ControlChange("Transfer", "Height", Conversions.ToString(base.Height - 120));
				ControlChange("Transfer", "Width", Conversions.ToString(base.Width - 20));
				ControlChange("Transfer", "Left", Conversions.ToString(10));
				ControlChange("Transfer", "Top", Conversions.ToString(10));
				Thread.Sleep(10);
				size = Transfer.Font.Size;
				float emSize = size + 40f;
				Transfer.Font = new Font(Transfer.Font.Name, emSize, Transfer.Font.Style, Transfer.Font.Unit);
				MyProject.Forms.Display.ProgramStart.Visible = false;
				MyProject.Forms.Display.Enabled = false;
				MyProject.Forms.Display.TimeInd.Visible = false;
				ControlChange("DelName", "Text", "All");
				ControlChange("DelName", "Visible", "True");
				ControlChange("DelName", "Enabled", "True");
				ControlChange("Accept", "Text", "Selected");
				if (Operators.CompareString(ID.Text, "", TextCompare: false) != 0)
				{
					ControlChange("Transfer", "Text", "Transfer\n\rPlease Select\n\r'Selected',  'All'  or  'X'");
				}
				else
				{
					ControlChange("Accept", "Visible", "False");
					ControlChange("Transfer", "Text", "Transfer\n\rPlease Select\n\r'All'  or  'X'");
				}
				TransferSelect();
				ControlChange("Accept", "Text", "Accept Selection");
				ControlChange("DelName", "Text", "Delete Selection");
				ControlChange("DelName", "Hide", "True");
				ControlChange("Transfer", "Height", Conversions.ToString(base.Height - 20));
				ControlChange("Transfer", "Text", "Working\n\rPlease Wait");
				DisplayPush();
				text3 = "";
				if (Operators.CompareString(InfoYesNo, "All", TextCompare: false) == 0)
				{
					text3 = "C:\\Users\\Public" + text4 + "\\DWS-History";
					text = "DWS-History";
				}
				else if (Operators.CompareString(InfoYesNo, "Selected", TextCompare: false) == 0 && Operators.CompareString(ID.Text, "", TextCompare: false) != 0)
				{
					text3 = "C:\\Users\\Public" + text4 + "\\DWS-History\\" + ID.Text;
					text = "DWS-History\\" + ID.Text;
				}
				InfoYesNo = "";
				if (Operators.CompareString(text3, "", TextCompare: false) != 0)
				{
					if (!Conversions.ToBoolean(Functions.DirectoryCopy(text3, Functions.GetDrive() + "\\" + text + "\\", ok: true)))
					{
						MyProject.Forms.Display.Enabled = true;
						NameListView.Enabled = true;
						MyProject.Forms.Display.ProgramStart.Enabled = true;
						MyProject.Forms.Display.TimeInd.Visible = true;
						TransferText("Failed 'C'", num, num2, num3, num4, false, true, size);
					}
					else
					{
						text5 = "C:\\Users\\Public" + text4 + "\\DWS\\";
						text2 = "DWS-History";
						Functions.CopyFiles(text5, "CustomerData.txt", Functions.GetDrive() + "\\" + text2 + "\\");
						if (Functions.MemoryDrive)
						{
							string text6 = Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M") + ":\\";
							if (!Conversions.ToBoolean(Functions.DirectoryCopy(text3, text6 + "\\" + text + "\\", ok: true)))
							{
								MyProject.Forms.Display.Enabled = true;
								NameListView.Enabled = true;
								MyProject.Forms.Display.ProgramStart.Enabled = true;
								MyProject.Forms.Display.TimeInd.Visible = true;
								TransferText("Failed 'M'", num, num2, num3, num4, false, true, size);
							}
							else
							{
								Functions.CopyFiles(text5, "CustomerData.txt", text6 + "\\" + text2 + "\\");
								MyProject.Forms.Display.Enabled = true;
								MyProject.Forms.Display.ProgramStart.Enabled = true;
								NameListView.Enabled = true;
								MyProject.Forms.Display.TimeInd.Visible = true;
								TransferText("Transfer", num, num2, num3, num4, true, false, size);
							}
						}
						else
						{
							MyProject.Forms.Display.Enabled = true;
							MyProject.Forms.Display.ProgramStart.Enabled = true;
							NameListView.Enabled = true;
							MyProject.Forms.Display.TimeInd.Visible = true;
							TransferText("Transfer", num, num2, num3, num4, true, false, size);
						}
					}
				}
				else
				{
					MyProject.Forms.Display.Enabled = true;
					NameListView.Enabled = true;
					MyProject.Forms.Display.ProgramStart.Enabled = true;
					MyProject.Forms.Display.TimeInd.Visible = true;
					TransferText("Aborted", num, num2, num3, num4, false, true, size);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.Display.Enabled = true;
				MyProject.Forms.Display.ProgramStart.Visible = true;
				NameListView.Enabled = true;
				MyProject.Forms.Display.TimeInd.Visible = true;
				TransferText("Failed", num, num2, num3, num4, false, true, size);
				ProjectData.ClearProjectError();
			}
			MyProject.Forms.Display.ProgramStart.Visible = true;
		}
	}

	private void ExtendedMemoryHistory()
	{
		if (Functions.MemoryDrive)
		{
			object obj = Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M") + ":\\";
			if (Operators.CompareString(Functions.DirCreate(Conversions.ToString(obj), "\\DWS-History"), "Failed", TextCompare: false) != 0 && Operators.CompareString(Functions.DirCreate(Conversions.ToString(Operators.ConcatenateObject(obj, "\\DWS-History\\")), MyProject.Forms.Information.ID.Text), "Failed", TextCompare: false) == 0)
			{
			}
		}
	}

	private void TransferText(object TransferText, object WidthT, object HeightT, object LeftT, object TopT, object TransferEnabled, object TransferVisable, object currentsize)
	{
		Transfer.Width = Conversions.ToInteger(WidthT);
		Transfer.Height = Conversions.ToInteger(HeightT);
		Transfer.Left = Conversions.ToInteger(LeftT);
		Transfer.Top = Conversions.ToInteger(TopT);
		Transfer.Text = Conversions.ToString(TransferText);
		Transfer.Enabled = Conversions.ToBoolean(TransferEnabled);
		Transfer.Visible = Conversions.ToBoolean(TransferVisable);
		Transfer.Font = new Font(Transfer.Font.Name, Conversions.ToSingle(currentsize), Transfer.Font.Style, Transfer.Font.Unit);
	}

	private void TransferSelect()
	{
		CloseFrm.Select();
		while (!((Operators.CompareString(InfoYesNo, "All", TextCompare: false) == 0) | (Operators.CompareString(InfoYesNo, "Selected", TextCompare: false) == 0) | (Operators.CompareString(InfoYesNo, "X", TextCompare: false) == 0)))
		{
			Application.DoEvents();
		}
	}

	private void DisplayPush()
	{
		Application.DoEvents();
	}

	private void Searchbox_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Search";
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "Search", TextCompare: false) == 0)
		{
			SearchChange("TextAlign", "Left");
			SearchChange("Text", InfoEnter.PasswordSet);
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		string itemName2 = ItemName;
		if (Operators.CompareString(itemName2, "Search", TextCompare: false) == 0)
		{
			if (Operators.CompareString(Searchbox.Text, "", TextCompare: false) != 0)
			{
				ListviewSearch();
			}
			SearchChange("TextAlign", "Left");
			MyProject.Forms.Display.PersonFileRead = false;
		}
		ControlChange("CloseFrm", "Visible", "True");
		ControlChange("Accept", "Visible", "True");
		ControlChange("DelName", "Visible", "True");
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		ControlLevel = 0;
	}

	public void SearchChange(string text, string texta)
	{
		try
		{
			if (Searchbox.InvokeRequired)
			{
				SetSTRCallback method = SearchChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				Searchbox.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					Searchbox.Visible = false;
				}
				else
				{
					Searchbox.Visible = true;
				}
			}
			if (Operators.CompareString(text, "TextAlign", TextCompare: false) != 0)
			{
				return;
			}
			if (Operators.CompareString(texta, "Left", TextCompare: false) != 0)
			{
				if (Operators.CompareString(texta, "Center", TextCompare: false) == 0)
				{
					Searchbox.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				Searchbox.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void RunNewPerson()
	{
		ControlChange("CloseFrm", "Visible", "False");
		ControlChange("Accept", "Visible", "False");
		ControlChange("DelName", "Visible", "False");
		ControlChange("Transfer", "Visible", "False");
		ControlChange("History", "Visible", "False");
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, checked(base.Top + base.Height));
		string itemName = ItemName;
		if (Operators.CompareString(itemName, "Search", TextCompare: false) == 0 && Operators.CompareString(PersonName.Text, "Name", TextCompare: false) == 0)
		{
			PersonNameChange("Text", "");
		}
	}
}
