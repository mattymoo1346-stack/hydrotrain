using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using HydroTrain.My;
using HydroTrain.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class Information : Form
{
	public delegate void SetDataCallback(string text);

	public delegate void SetIntCallback(int Index, string text);

	public delegate void SetSTRCallback(string text, string textA);

	public delegate void SetControlCallback(string Data);

	public delegate void SetControl1Callback(string ControlName, bool Data);

	public delegate void SetControl2Callback(string ControlName, string Setting, string Data);

	public delegate void SetControl3Callback(string ControlContainerA, string ControlName, string Setting, string Data);

	public delegate void SetControl4Callback(string ControlContainerB, string ControlContainerA, string ControlName, string Setting, string Data);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Person")]
	private GroupBox _Person;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BMR")]
	private Button _BMR;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BMIDescription")]
	private Button _BMIDescription;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RMR")]
	private Button _RMR;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RMRLabel")]
	private Label _RMRLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BMRLabel")]
	private Label _BMRLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BMILabel")]
	private Label _BMILabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClosePerson")]
	private PictureBox _ClosePerson;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TrainerLabel")]
	private Label _TrainerLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Trainer")]
	private TextBox _Trainer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListViewSW")]
	private PictureBox _ListViewSW;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Age")]
	private TextBox _Age;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DOBYear")]
	private ComboBox _DOBYear;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DOBMonth")]
	private ComboBox _DOBMonth;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DOBDay")]
	private ComboBox _DOBDay;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ID")]
	private TextBox _ID;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IDLabel")]
	private Label _IDLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ImportantLabel")]
	private Label _ImportantLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Important")]
	private TextBox _Important;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Breed")]
	private TextBox _Breed;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BreedLabel")]
	private Label _BreedLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AnimalNameLabel")]
	private Label _AnimalNameLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AnimalName")]
	private TextBox _AnimalName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearAll")]
	private PictureBox _ClearAll;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lbLabel")]
	private Label _lbLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PersonWeightlb")]
	private TextBox _PersonWeightlb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("inLabel")]
	private Label _inLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ftLabel")]
	private Label _ftLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PersonHeightin")]
	private TextBox _PersonHeightin;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PersonHeightft")]
	private TextBox _PersonHeightft;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("stLabel")]
	private Label _stLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PersonWeightst")]
	private TextBox _PersonWeightst;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DOBLabel")]
	private Label _DOBLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DOB")]
	private TextBox _DOB;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PersonWeightLabel")]
	private Label _PersonWeightLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PersonHeightLabel")]
	private Label _PersonHeightLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PersonWeightkg")]
	private TextBox _PersonWeightkg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PersonHeightcm")]
	private TextBox _PersonHeightcm;

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
	[AccessedThroughProperty("PersonNameLabel")]
	private Label _PersonNameLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InfoEnterTM")]
	private System.Windows.Forms.Timer _InfoEnterTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InformationTM")]
	private System.Windows.Forms.Timer _InformationTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BMIVisableTM")]
	private System.Windows.Forms.Timer _BMIVisableTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UpdateInformationTM")]
	private System.Windows.Forms.Timer _UpdateInformationTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RefYear")]
	private ComboBox _RefYear;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ReferralEnd")]
	private TextBox _ReferralEnd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RefMonth")]
	private ComboBox _RefMonth;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RefDay")]
	private ComboBox _RefDay;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RefLabel")]
	private Label _RefLabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PersonName")]
	private TextBox _PersonName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HouseNo")]
	private TextBox _HouseNo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PostCode")]
	private TextBox _PostCode;

	public float ResMultiW;

	public float ResMultiH;

	private static string ItemName;

	private static int ControlLevel;

	private static string HoldInfo;

	private static string HoldItem;

	internal virtual GroupBox Person
	{
		[CompilerGenerated]
		get
		{
			return _Person;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Person_Focus;
			EventHandler value3 = Person_Enter;
			EventHandler value4 = Person_MouseHover;
			GroupBox groupBox = _Person;
			if (groupBox != null)
			{
				groupBox.GotFocus -= value2;
				groupBox.Click -= value3;
				groupBox.MouseHover -= value4;
			}
			_Person = value;
			groupBox = _Person;
			if (groupBox != null)
			{
				groupBox.GotFocus += value2;
				groupBox.Click += value3;
				groupBox.MouseHover += value4;
			}
		}
	}

	[field: AccessedThroughProperty("HealthInd")]
	internal virtual GroupBox HealthInd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BMI")]
	internal virtual Button BMI
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HealthLegand")]
	internal virtual PictureBox HealthLegand
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BMR
	{
		[CompilerGenerated]
		get
		{
			return _BMR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BMR_Click;
			Button button = _BMR;
			if (button != null)
			{
				button.Click -= value2;
			}
			_BMR = value;
			button = _BMR;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button BMIDescription
	{
		[CompilerGenerated]
		get
		{
			return _BMIDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BMIDescription_GotFocus;
			Button button = _BMIDescription;
			if (button != null)
			{
				button.GotFocus -= value2;
			}
			_BMIDescription = value;
			button = _BMIDescription;
			if (button != null)
			{
				button.GotFocus += value2;
			}
		}
	}

	internal virtual Button RMR
	{
		[CompilerGenerated]
		get
		{
			return _RMR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RMR_Click;
			EventHandler value3 = RMR_GotFocus;
			Button button = _RMR;
			if (button != null)
			{
				button.Click -= value2;
				button.GotFocus -= value3;
			}
			_RMR = value;
			button = _RMR;
			if (button != null)
			{
				button.Click += value2;
				button.GotFocus += value3;
			}
		}
	}

	internal virtual Label RMRLabel
	{
		[CompilerGenerated]
		get
		{
			return _RMRLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RMRLabel_Click;
			Label label = _RMRLabel;
			if (label != null)
			{
				label.GotFocus -= value2;
			}
			_RMRLabel = value;
			label = _RMRLabel;
			if (label != null)
			{
				label.GotFocus += value2;
			}
		}
	}

	internal virtual Label BMRLabel
	{
		[CompilerGenerated]
		get
		{
			return _BMRLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BMRLabel_Click;
			Label label = _BMRLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_BMRLabel = value;
			label = _BMRLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label BMILabel
	{
		[CompilerGenerated]
		get
		{
			return _BMILabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BMILabel_Click;
			Label label = _BMILabel;
			if (label != null)
			{
				label.GotFocus -= value2;
			}
			_BMILabel = value;
			label = _BMILabel;
			if (label != null)
			{
				label.GotFocus += value2;
			}
		}
	}

	internal virtual PictureBox ClosePerson
	{
		[CompilerGenerated]
		get
		{
			return _ClosePerson;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClosePerson_Click;
			PictureBox pictureBox = _ClosePerson;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_ClosePerson = value;
			pictureBox = _ClosePerson;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	internal virtual Label TrainerLabel
	{
		[CompilerGenerated]
		get
		{
			return _TrainerLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TrainerLabel_Click;
			Label label = _TrainerLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_TrainerLabel = value;
			label = _TrainerLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox Trainer
	{
		[CompilerGenerated]
		get
		{
			return _Trainer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Trainer_Click;
			EventHandler value3 = Trainer_GotFocus;
			TextBox textBox = _Trainer;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_Trainer = value;
			textBox = _Trainer;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual PictureBox ListViewSW
	{
		[CompilerGenerated]
		get
		{
			return _ListViewSW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ListViewSW_Click;
			PictureBox pictureBox = _ListViewSW;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_ListViewSW = value;
			pictureBox = _ListViewSW;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PersonSex")]
	internal virtual TextBox PersonSex
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AgeLabel")]
	internal virtual Label AgeLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox Age
	{
		[CompilerGenerated]
		get
		{
			return _Age;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Age_GotFocus;
			TextBox textBox = _Age;
			if (textBox != null)
			{
				textBox.GotFocus -= value2;
			}
			_Age = value;
			textBox = _Age;
			if (textBox != null)
			{
				textBox.GotFocus += value2;
			}
		}
	}

	internal virtual ComboBox DOBYear
	{
		[CompilerGenerated]
		get
		{
			return _DOBYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DOBYear_SelectedIndexChanged;
			ComboBox comboBox = _DOBYear;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_DOBYear = value;
			comboBox = _DOBYear;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox DOBMonth
	{
		[CompilerGenerated]
		get
		{
			return _DOBMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DOBMonth_SelectedIndexChanged;
			ComboBox comboBox = _DOBMonth;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_DOBMonth = value;
			comboBox = _DOBMonth;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox DOBDay
	{
		[CompilerGenerated]
		get
		{
			return _DOBDay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DOBDay_SelectedIndexChanged;
			ComboBox comboBox = _DOBDay;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_DOBDay = value;
			comboBox = _DOBDay;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual TextBox ID
	{
		[CompilerGenerated]
		get
		{
			return _ID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ID_Click;
			EventHandler value3 = ID_GotFocus;
			TextBox textBox = _ID;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_ID = value;
			textBox = _ID;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual Label IDLabel
	{
		[CompilerGenerated]
		get
		{
			return _IDLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = IDLabel_Click;
			Label label = _IDLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_IDLabel = value;
			label = _IDLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label ImportantLabel
	{
		[CompilerGenerated]
		get
		{
			return _ImportantLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ImportantLabel_Click;
			Label label = _ImportantLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_ImportantLabel = value;
			label = _ImportantLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox Important
	{
		[CompilerGenerated]
		get
		{
			return _Important;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Important_Click;
			EventHandler value3 = Important_GotFocus;
			TextBox textBox = _Important;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_Important = value;
			textBox = _Important;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual TextBox Breed
	{
		[CompilerGenerated]
		get
		{
			return _Breed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Breed_Click;
			EventHandler value3 = Breed_GotFocus;
			TextBox textBox = _Breed;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_Breed = value;
			textBox = _Breed;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual Label BreedLabel
	{
		[CompilerGenerated]
		get
		{
			return _BreedLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BreedLabel_Click;
			Label label = _BreedLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_BreedLabel = value;
			label = _BreedLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label AnimalNameLabel
	{
		[CompilerGenerated]
		get
		{
			return _AnimalNameLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AnimalNameLabel_Click;
			Label label = _AnimalNameLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_AnimalNameLabel = value;
			label = _AnimalNameLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox AnimalName
	{
		[CompilerGenerated]
		get
		{
			return _AnimalName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AnimalName_Click;
			EventHandler value3 = AnimalName_GotFocus;
			TextBox textBox = _AnimalName;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_AnimalName = value;
			textBox = _AnimalName;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual PictureBox ClearAll
	{
		[CompilerGenerated]
		get
		{
			return _ClearAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClearAll_Click;
			PictureBox pictureBox = _ClearAll;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_ClearAll = value;
			pictureBox = _ClearAll;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	internal virtual Label lbLabel
	{
		[CompilerGenerated]
		get
		{
			return _lbLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = LBLabel_Click1;
			Label label = _lbLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lbLabel = value;
			label = _lbLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox PersonWeightlb
	{
		[CompilerGenerated]
		get
		{
			return _PersonWeightlb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonWeightlb_Click;
			EventHandler value3 = PersonWeightlb_GotFocus;
			TextBox textBox = _PersonWeightlb;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_PersonWeightlb = value;
			textBox = _PersonWeightlb;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual Label inLabel
	{
		[CompilerGenerated]
		get
		{
			return _inLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InLabel_Click;
			Label label = _inLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_inLabel = value;
			label = _inLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label ftLabel
	{
		[CompilerGenerated]
		get
		{
			return _ftLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = FTLabel_Click;
			Label label = _ftLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_ftLabel = value;
			label = _ftLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox PersonHeightin
	{
		[CompilerGenerated]
		get
		{
			return _PersonHeightin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonHeightin_Click1;
			EventHandler value3 = PersonHeightin_GotFocus;
			TextBox textBox = _PersonHeightin;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_PersonHeightin = value;
			textBox = _PersonHeightin;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual TextBox PersonHeightft
	{
		[CompilerGenerated]
		get
		{
			return _PersonHeightft;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonHeightft_Click1;
			EventHandler value3 = PersonHeightft_GotFocus;
			TextBox textBox = _PersonHeightft;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_PersonHeightft = value;
			textBox = _PersonHeightft;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual Label stLabel
	{
		[CompilerGenerated]
		get
		{
			return _stLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = STLabel_Click1;
			Label label = _stLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_stLabel = value;
			label = _stLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox PersonWeightst
	{
		[CompilerGenerated]
		get
		{
			return _PersonWeightst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonWeightst_Click;
			EventHandler value3 = PersonWeightst_GotFocus;
			TextBox textBox = _PersonWeightst;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_PersonWeightst = value;
			textBox = _PersonWeightst;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	[field: AccessedThroughProperty("kgLabel")]
	internal virtual Label kgLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmLabel")]
	internal virtual Label cmLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label DOBLabel
	{
		[CompilerGenerated]
		get
		{
			return _DOBLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DOBLabel_Click;
			Label label = _DOBLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_DOBLabel = value;
			label = _DOBLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox DOB
	{
		[CompilerGenerated]
		get
		{
			return _DOB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DOB_Click;
			EventHandler value3 = DOB_GotFocus;
			TextBox textBox = _DOB;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_DOB = value;
			textBox = _DOB;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual Label PersonWeightLabel
	{
		[CompilerGenerated]
		get
		{
			return _PersonWeightLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonWeightLabel_Click;
			Label label = _PersonWeightLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_PersonWeightLabel = value;
			label = _PersonWeightLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label PersonHeightLabel
	{
		[CompilerGenerated]
		get
		{
			return _PersonHeightLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonHeightLabel_Click;
			Label label = _PersonHeightLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_PersonHeightLabel = value;
			label = _PersonHeightLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox PersonWeightkg
	{
		[CompilerGenerated]
		get
		{
			return _PersonWeightkg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonWeight_Click;
			EventHandler value3 = PersonWeightkg_GotFocus;
			TextBox textBox = _PersonWeightkg;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_PersonWeightkg = value;
			textBox = _PersonWeightkg;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual TextBox PersonHeightcm
	{
		[CompilerGenerated]
		get
		{
			return _PersonHeightcm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonHeight_Click1;
			EventHandler value3 = PersonHeightcm_GotFocus;
			TextBox textBox = _PersonHeightcm;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_PersonHeightcm = value;
			textBox = _PersonHeightcm;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
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
			EventHandler value3 = OptionMF2_GotFocus;
			RadioButton radioButton = _OptionMF2;
			if (radioButton != null)
			{
				radioButton.Click -= value2;
				radioButton.GotFocus -= value3;
			}
			_OptionMF2 = value;
			radioButton = _OptionMF2;
			if (radioButton != null)
			{
				radioButton.Click += value2;
				radioButton.GotFocus += value3;
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
			EventHandler value3 = OptionMF1_GotFocus;
			RadioButton radioButton = _OptionMF1;
			if (radioButton != null)
			{
				radioButton.Click -= value2;
				radioButton.GotFocus -= value3;
			}
			_OptionMF1 = value;
			radioButton = _OptionMF1;
			if (radioButton != null)
			{
				radioButton.Click += value2;
				radioButton.GotFocus += value3;
			}
		}
	}

	internal virtual Label PersonNameLabel
	{
		[CompilerGenerated]
		get
		{
			return _PersonNameLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonNameLabel_Click;
			Label label = _PersonNameLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_PersonNameLabel = value;
			label = _PersonNameLabel;
			if (label != null)
			{
				label.Click += value2;
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

	internal virtual System.Windows.Forms.Timer InformationTM
	{
		[CompilerGenerated]
		get
		{
			return _InformationTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InformationTM_Tick;
			System.Windows.Forms.Timer timer = _InformationTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_InformationTM = value;
			timer = _InformationTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer BMIVisableTM
	{
		[CompilerGenerated]
		get
		{
			return _BMIVisableTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BMIVisableTM_Tick;
			System.Windows.Forms.Timer timer = _BMIVisableTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_BMIVisableTM = value;
			timer = _BMIVisableTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PostCodeLabel")]
	internal virtual Label PostCodeLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MemoryStick")]
	public virtual Label MemoryStick
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer UpdateInformationTM
	{
		[CompilerGenerated]
		get
		{
			return _UpdateInformationTM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UpdateInformationTM_Tick;
			System.Windows.Forms.Timer timer = _UpdateInformationTM;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_UpdateInformationTM = value;
			timer = _UpdateInformationTM;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual ComboBox RefYear
	{
		[CompilerGenerated]
		get
		{
			return _RefYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RefYear_SelectedIndexChanged;
			ComboBox comboBox = _RefYear;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_RefYear = value;
			comboBox = _RefYear;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual TextBox ReferralEnd
	{
		[CompilerGenerated]
		get
		{
			return _ReferralEnd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ReferralEnd_Click;
			EventHandler value3 = ReferralEnd_GotFocus;
			TextBox textBox = _ReferralEnd;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_ReferralEnd = value;
			textBox = _ReferralEnd;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual ComboBox RefMonth
	{
		[CompilerGenerated]
		get
		{
			return _RefMonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RefMonth_SelectedIndexChanged;
			ComboBox comboBox = _RefMonth;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_RefMonth = value;
			comboBox = _RefMonth;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ComboBox RefDay
	{
		[CompilerGenerated]
		get
		{
			return _RefDay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RefDay_SelectedIndexChanged;
			ComboBox comboBox = _RefDay;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_RefDay = value;
			comboBox = _RefDay;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual Label RefLabel
	{
		[CompilerGenerated]
		get
		{
			return _RefLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = REFLabel_Click;
			Label label = _RefLabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_RefLabel = value;
			label = _RefLabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual TextBox PersonName
	{
		[CompilerGenerated]
		get
		{
			return _PersonName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PersonName_Click;
			EventHandler value3 = PersonName_GotFocus;
			TextBox textBox = _PersonName;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_PersonName = value;
			textBox = _PersonName;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual TextBox HouseNo
	{
		[CompilerGenerated]
		get
		{
			return _HouseNo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = HouseNo_Click;
			EventHandler value3 = HouseNo_GotFocus;
			TextBox textBox = _HouseNo;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_HouseNo = value;
			textBox = _HouseNo;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	internal virtual TextBox PostCode
	{
		[CompilerGenerated]
		get
		{
			return _PostCode;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PostCode_Click;
			EventHandler value3 = PostCode_GotFocus;
			TextBox textBox = _PostCode;
			if (textBox != null)
			{
				textBox.Click -= value2;
				textBox.GotFocus -= value3;
			}
			_PostCode = value;
			textBox = _PostCode;
			if (textBox != null)
			{
				textBox.Click += value2;
				textBox.GotFocus += value3;
			}
		}
	}

	public Information()
	{
		base.Load += Information_Load;
		base.Activated += Information_Activated;
		base.Deactivate += Information_Deactivate;
		base.GotFocus += Information_Focus;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HydroTrain.Information));
		this.Person = new System.Windows.Forms.GroupBox();
		this.RefYear = new System.Windows.Forms.ComboBox();
		this.RefLabel = new System.Windows.Forms.Label();
		this.ReferralEnd = new System.Windows.Forms.TextBox();
		this.RefMonth = new System.Windows.Forms.ComboBox();
		this.RefDay = new System.Windows.Forms.ComboBox();
		this.HouseNo = new System.Windows.Forms.TextBox();
		this.PostCodeLabel = new System.Windows.Forms.Label();
		this.PostCode = new System.Windows.Forms.TextBox();
		this.HealthInd = new System.Windows.Forms.GroupBox();
		this.BMI = new System.Windows.Forms.Button();
		this.HealthLegand = new System.Windows.Forms.PictureBox();
		this.BMR = new System.Windows.Forms.Button();
		this.BMIDescription = new System.Windows.Forms.Button();
		this.RMR = new System.Windows.Forms.Button();
		this.RMRLabel = new System.Windows.Forms.Label();
		this.BMRLabel = new System.Windows.Forms.Label();
		this.BMILabel = new System.Windows.Forms.Label();
		this.ClosePerson = new System.Windows.Forms.PictureBox();
		this.TrainerLabel = new System.Windows.Forms.Label();
		this.Trainer = new System.Windows.Forms.TextBox();
		this.ListViewSW = new System.Windows.Forms.PictureBox();
		this.PersonSex = new System.Windows.Forms.TextBox();
		this.AgeLabel = new System.Windows.Forms.Label();
		this.Age = new System.Windows.Forms.TextBox();
		this.DOBYear = new System.Windows.Forms.ComboBox();
		this.DOBMonth = new System.Windows.Forms.ComboBox();
		this.DOBDay = new System.Windows.Forms.ComboBox();
		this.ID = new System.Windows.Forms.TextBox();
		this.IDLabel = new System.Windows.Forms.Label();
		this.ImportantLabel = new System.Windows.Forms.Label();
		this.Important = new System.Windows.Forms.TextBox();
		this.Breed = new System.Windows.Forms.TextBox();
		this.BreedLabel = new System.Windows.Forms.Label();
		this.AnimalNameLabel = new System.Windows.Forms.Label();
		this.AnimalName = new System.Windows.Forms.TextBox();
		this.MemoryStick = new System.Windows.Forms.Label();
		this.ClearAll = new System.Windows.Forms.PictureBox();
		this.lbLabel = new System.Windows.Forms.Label();
		this.PersonWeightlb = new System.Windows.Forms.TextBox();
		this.inLabel = new System.Windows.Forms.Label();
		this.ftLabel = new System.Windows.Forms.Label();
		this.PersonHeightin = new System.Windows.Forms.TextBox();
		this.PersonHeightft = new System.Windows.Forms.TextBox();
		this.stLabel = new System.Windows.Forms.Label();
		this.PersonWeightst = new System.Windows.Forms.TextBox();
		this.kgLabel = new System.Windows.Forms.Label();
		this.cmLabel = new System.Windows.Forms.Label();
		this.PersonName = new System.Windows.Forms.TextBox();
		this.DOBLabel = new System.Windows.Forms.Label();
		this.DOB = new System.Windows.Forms.TextBox();
		this.PersonWeightLabel = new System.Windows.Forms.Label();
		this.PersonHeightLabel = new System.Windows.Forms.Label();
		this.PersonWeightkg = new System.Windows.Forms.TextBox();
		this.PersonHeightcm = new System.Windows.Forms.TextBox();
		this.OptionMF2 = new System.Windows.Forms.RadioButton();
		this.OptionMF1 = new System.Windows.Forms.RadioButton();
		this.PersonNameLabel = new System.Windows.Forms.Label();
		this.InfoEnterTM = new System.Windows.Forms.Timer(this.components);
		this.InformationTM = new System.Windows.Forms.Timer(this.components);
		this.BMIVisableTM = new System.Windows.Forms.Timer(this.components);
		this.UpdateInformationTM = new System.Windows.Forms.Timer(this.components);
		this.Person.SuspendLayout();
		this.HealthInd.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.HealthLegand).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ClosePerson).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ListViewSW).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ClearAll).BeginInit();
		base.SuspendLayout();
		this.Person.BackColor = System.Drawing.Color.Transparent;
		this.Person.Controls.Add(this.RefYear);
		this.Person.Controls.Add(this.RefLabel);
		this.Person.Controls.Add(this.ReferralEnd);
		this.Person.Controls.Add(this.RefMonth);
		this.Person.Controls.Add(this.RefDay);
		this.Person.Controls.Add(this.HouseNo);
		this.Person.Controls.Add(this.PostCodeLabel);
		this.Person.Controls.Add(this.PostCode);
		this.Person.Controls.Add(this.HealthInd);
		this.Person.Controls.Add(this.ClosePerson);
		this.Person.Controls.Add(this.TrainerLabel);
		this.Person.Controls.Add(this.Trainer);
		this.Person.Controls.Add(this.ListViewSW);
		this.Person.Controls.Add(this.PersonSex);
		this.Person.Controls.Add(this.AgeLabel);
		this.Person.Controls.Add(this.Age);
		this.Person.Controls.Add(this.DOBYear);
		this.Person.Controls.Add(this.DOBMonth);
		this.Person.Controls.Add(this.DOBDay);
		this.Person.Controls.Add(this.ID);
		this.Person.Controls.Add(this.IDLabel);
		this.Person.Controls.Add(this.ImportantLabel);
		this.Person.Controls.Add(this.Important);
		this.Person.Controls.Add(this.Breed);
		this.Person.Controls.Add(this.BreedLabel);
		this.Person.Controls.Add(this.AnimalNameLabel);
		this.Person.Controls.Add(this.AnimalName);
		this.Person.Controls.Add(this.MemoryStick);
		this.Person.Controls.Add(this.ClearAll);
		this.Person.Controls.Add(this.lbLabel);
		this.Person.Controls.Add(this.PersonWeightlb);
		this.Person.Controls.Add(this.inLabel);
		this.Person.Controls.Add(this.ftLabel);
		this.Person.Controls.Add(this.PersonHeightin);
		this.Person.Controls.Add(this.PersonHeightft);
		this.Person.Controls.Add(this.stLabel);
		this.Person.Controls.Add(this.PersonWeightst);
		this.Person.Controls.Add(this.kgLabel);
		this.Person.Controls.Add(this.cmLabel);
		this.Person.Controls.Add(this.PersonName);
		this.Person.Controls.Add(this.DOBLabel);
		this.Person.Controls.Add(this.DOB);
		this.Person.Controls.Add(this.PersonWeightLabel);
		this.Person.Controls.Add(this.PersonHeightLabel);
		this.Person.Controls.Add(this.PersonWeightkg);
		this.Person.Controls.Add(this.PersonHeightcm);
		this.Person.Controls.Add(this.OptionMF2);
		this.Person.Controls.Add(this.OptionMF1);
		this.Person.Controls.Add(this.PersonNameLabel);
		this.Person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Person.Font = new System.Drawing.Font("Verdana", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Person.ForeColor = System.Drawing.Color.White;
		this.Person.Location = new System.Drawing.Point(10, 10);
		this.Person.Name = "Person";
		this.Person.Size = new System.Drawing.Size(886, 414);
		this.Person.TabIndex = 8;
		this.Person.TabStop = false;
		this.Person.Text = "Information";
		this.RefYear.AllowDrop = true;
		this.RefYear.Font = new System.Drawing.Font("Verdana", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.RefYear.FormattingEnabled = true;
		this.RefYear.Location = new System.Drawing.Point(546, 377);
		this.RefYear.Name = "RefYear";
		this.RefYear.Size = new System.Drawing.Size(88, 31);
		this.RefYear.TabIndex = 167;
		this.RefYear.Text = "Year";
		this.RefYear.Visible = false;
		this.RefLabel.AutoSize = true;
		this.RefLabel.Font = new System.Drawing.Font("Verdana", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.RefLabel.Location = new System.Drawing.Point(395, 351);
		this.RefLabel.Name = "RefLabel";
		this.RefLabel.Size = new System.Drawing.Size(138, 23);
		this.RefLabel.TabIndex = 168;
		this.RefLabel.Text = "Referral Ends";
		this.RefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.ReferralEnd.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.ReferralEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ReferralEnd.Location = new System.Drawing.Point(387, 378);
		this.ReferralEnd.Name = "ReferralEnd";
		this.ReferralEnd.Size = new System.Drawing.Size(174, 30);
		this.ReferralEnd.TabIndex = 166;
		this.ReferralEnd.Text = "0";
		this.ReferralEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.RefMonth.Font = new System.Drawing.Font("Verdana", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.RefMonth.FormattingEnabled = true;
		this.RefMonth.Items.AddRange(new object[13]
		{
			"01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
			"11", "12", "Month"
		});
		this.RefMonth.Location = new System.Drawing.Point(452, 377);
		this.RefMonth.Name = "RefMonth";
		this.RefMonth.Size = new System.Drawing.Size(88, 31);
		this.RefMonth.TabIndex = 165;
		this.RefMonth.Text = "Month";
		this.RefMonth.Visible = false;
		this.RefDay.AllowDrop = true;
		this.RefDay.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.RefDay.Font = new System.Drawing.Font("Verdana", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.RefDay.ForeColor = System.Drawing.Color.White;
		this.RefDay.FormattingEnabled = true;
		this.RefDay.Items.AddRange(new object[32]
		{
			"01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
			"21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
			"31", "Day"
		});
		this.RefDay.Location = new System.Drawing.Point(372, 377);
		this.RefDay.Name = "RefDay";
		this.RefDay.Size = new System.Drawing.Size(74, 31);
		this.RefDay.TabIndex = 164;
		this.RefDay.Text = "Day";
		this.RefDay.Visible = false;
		this.HouseNo.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.HouseNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.HouseNo.Location = new System.Drawing.Point(180, 80);
		this.HouseNo.Name = "HouseNo";
		this.HouseNo.Size = new System.Drawing.Size(75, 30);
		this.HouseNo.TabIndex = 163;
		this.HouseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.PostCodeLabel.AutoSize = true;
		this.PostCodeLabel.Font = new System.Drawing.Font("Verdana", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.PostCodeLabel.Location = new System.Drawing.Point(260, 80);
		this.PostCodeLabel.Name = "PostCodeLabel";
		this.PostCodeLabel.Size = new System.Drawing.Size(196, 29);
		this.PostCodeLabel.TabIndex = 162;
		this.PostCodeLabel.Text = ":Post Code/No.";
		this.PostCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.PostCode.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.PostCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.PostCode.Location = new System.Drawing.Point(15, 80);
		this.PostCode.Name = "PostCode";
		this.PostCode.Size = new System.Drawing.Size(155, 30);
		this.PostCode.TabIndex = 161;
		this.PostCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.HealthInd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.HealthInd.BackColor = System.Drawing.Color.Transparent;
		this.HealthInd.Controls.Add(this.BMI);
		this.HealthInd.Controls.Add(this.HealthLegand);
		this.HealthInd.Controls.Add(this.BMR);
		this.HealthInd.Controls.Add(this.BMIDescription);
		this.HealthInd.Controls.Add(this.RMR);
		this.HealthInd.Controls.Add(this.RMRLabel);
		this.HealthInd.Controls.Add(this.BMRLabel);
		this.HealthInd.Controls.Add(this.BMILabel);
		this.HealthInd.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.HealthInd.ForeColor = System.Drawing.Color.White;
		this.HealthInd.Location = new System.Drawing.Point(581, 273);
		this.HealthInd.Name = "HealthInd";
		this.HealthInd.Size = new System.Drawing.Size(299, 134);
		this.HealthInd.TabIndex = 160;
		this.HealthInd.TabStop = false;
		this.HealthInd.Visible = false;
		this.BMI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.BMI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.BMI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.BMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BMI.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BMI.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.BMI.Location = new System.Drawing.Point(212, 93);
		this.BMI.Name = "BMI";
		this.BMI.Size = new System.Drawing.Size(75, 30);
		this.BMI.TabIndex = 39;
		this.BMI.Text = "15.0";
		this.BMI.UseVisualStyleBackColor = true;
		this.HealthLegand.Image = (System.Drawing.Image)resources.GetObject("HealthLegand.Image");
		this.HealthLegand.Location = new System.Drawing.Point(16, 2);
		this.HealthLegand.Name = "HealthLegand";
		this.HealthLegand.Size = new System.Drawing.Size(45, 45);
		this.HealthLegand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.HealthLegand.TabIndex = 140;
		this.HealthLegand.TabStop = false;
		this.BMR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.BMR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.BMR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.BMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BMR.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BMR.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.BMR.Location = new System.Drawing.Point(212, 17);
		this.BMR.Name = "BMR";
		this.BMR.Size = new System.Drawing.Size(75, 30);
		this.BMR.TabIndex = 43;
		this.BMR.Text = "0.0";
		this.BMR.UseVisualStyleBackColor = true;
		this.BMIDescription.BackColor = System.Drawing.Color.Transparent;
		this.BMIDescription.FlatAppearance.BorderSize = 0;
		this.BMIDescription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.BMIDescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.BMIDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BMIDescription.Font = new System.Drawing.Font("Verdana", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BMIDescription.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.BMIDescription.Location = new System.Drawing.Point(6, 64);
		this.BMIDescription.Name = "BMIDescription";
		this.BMIDescription.Size = new System.Drawing.Size(155, 63);
		this.BMIDescription.TabIndex = 132;
		this.BMIDescription.Text = "Very Severely Underweight";
		this.BMIDescription.UseVisualStyleBackColor = false;
		this.RMR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.RMR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
		this.RMR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.RMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.RMR.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.RMR.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.RMR.Location = new System.Drawing.Point(212, 55);
		this.RMR.Name = "RMR";
		this.RMR.Size = new System.Drawing.Size(75, 30);
		this.RMR.TabIndex = 45;
		this.RMR.Text = "0.0";
		this.RMR.UseVisualStyleBackColor = true;
		this.RMRLabel.AutoSize = true;
		this.RMRLabel.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.RMRLabel.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.RMRLabel.Location = new System.Drawing.Point(157, 61);
		this.RMRLabel.Name = "RMRLabel";
		this.RMRLabel.Size = new System.Drawing.Size(43, 18);
		this.RMRLabel.TabIndex = 44;
		this.RMRLabel.Text = "RMR";
		this.BMRLabel.AutoSize = true;
		this.BMRLabel.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BMRLabel.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.BMRLabel.Location = new System.Drawing.Point(157, 23);
		this.BMRLabel.Name = "BMRLabel";
		this.BMRLabel.Size = new System.Drawing.Size(43, 18);
		this.BMRLabel.TabIndex = 42;
		this.BMRLabel.Text = "BMR";
		this.BMILabel.AutoSize = true;
		this.BMILabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.BMILabel.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BMILabel.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.BMILabel.Location = new System.Drawing.Point(157, 97);
		this.BMILabel.Name = "BMILabel";
		this.BMILabel.Size = new System.Drawing.Size(39, 18);
		this.BMILabel.TabIndex = 36;
		this.BMILabel.Text = "BMI";
		this.ClosePerson.Image = HydroTrain.My.Resources.Resources.Close;
		this.ClosePerson.Location = new System.Drawing.Point(809, 27);
		this.ClosePerson.Name = "ClosePerson";
		this.ClosePerson.Size = new System.Drawing.Size(60, 60);
		this.ClosePerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClosePerson.TabIndex = 151;
		this.ClosePerson.TabStop = false;
		this.TrainerLabel.AutoSize = true;
		this.TrainerLabel.Font = new System.Drawing.Font("Verdana", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TrainerLabel.Location = new System.Drawing.Point(367, 282);
		this.TrainerLabel.Name = "TrainerLabel";
		this.TrainerLabel.Size = new System.Drawing.Size(121, 25);
		this.TrainerLabel.TabIndex = 149;
		this.TrainerLabel.Text = ":Therapist";
		this.TrainerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Trainer.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.Trainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Trainer.Location = new System.Drawing.Point(103, 282);
		this.Trainer.Name = "Trainer";
		this.Trainer.Size = new System.Drawing.Size(258, 30);
		this.Trainer.TabIndex = 148;
		this.Trainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.ListViewSW.BackColor = System.Drawing.Color.Transparent;
		this.ListViewSW.Image = (System.Drawing.Image)resources.GetObject("ListViewSW.Image");
		this.ListViewSW.Location = new System.Drawing.Point(10, 324);
		this.ListViewSW.Name = "ListViewSW";
		this.ListViewSW.Size = new System.Drawing.Size(80, 80);
		this.ListViewSW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ListViewSW.TabIndex = 147;
		this.ListViewSW.TabStop = false;
		this.PersonSex.Location = new System.Drawing.Point(458, 219);
		this.PersonSex.Name = "PersonSex";
		this.PersonSex.Size = new System.Drawing.Size(19, 37);
		this.PersonSex.TabIndex = 146;
		this.PersonSex.Visible = false;
		this.AgeLabel.AutoSize = true;
		this.AgeLabel.Location = new System.Drawing.Point(130, 203);
		this.AgeLabel.Name = "AgeLabel";
		this.AgeLabel.Size = new System.Drawing.Size(69, 29);
		this.AgeLabel.TabIndex = 145;
		this.AgeLabel.Text = ":Age";
		this.AgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Age.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.Age.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Age.Location = new System.Drawing.Point(17, 202);
		this.Age.Name = "Age";
		this.Age.Size = new System.Drawing.Size(107, 30);
		this.Age.TabIndex = 144;
		this.Age.Text = "0";
		this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.DOBYear.AllowDrop = true;
		this.DOBYear.Font = new System.Drawing.Font("Verdana", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DOBYear.FormattingEnabled = true;
		this.DOBYear.Location = new System.Drawing.Point(195, 160);
		this.DOBYear.Name = "DOBYear";
		this.DOBYear.Size = new System.Drawing.Size(88, 31);
		this.DOBYear.TabIndex = 143;
		this.DOBYear.Text = "Year";
		this.DOBYear.Visible = false;
		this.DOBMonth.Font = new System.Drawing.Font("Verdana", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DOBMonth.FormattingEnabled = true;
		this.DOBMonth.Items.AddRange(new object[13]
		{
			"01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
			"11", "12", "Month"
		});
		this.DOBMonth.Location = new System.Drawing.Point(100, 160);
		this.DOBMonth.Name = "DOBMonth";
		this.DOBMonth.Size = new System.Drawing.Size(88, 31);
		this.DOBMonth.TabIndex = 142;
		this.DOBMonth.Text = "Month";
		this.DOBMonth.Visible = false;
		this.DOBDay.AllowDrop = true;
		this.DOBDay.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.DOBDay.Font = new System.Drawing.Font("Verdana", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DOBDay.ForeColor = System.Drawing.Color.White;
		this.DOBDay.FormattingEnabled = true;
		this.DOBDay.Items.AddRange(new object[32]
		{
			"01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
			"21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
			"31", "Day"
		});
		this.DOBDay.Location = new System.Drawing.Point(15, 160);
		this.DOBDay.Name = "DOBDay";
		this.DOBDay.Size = new System.Drawing.Size(74, 31);
		this.DOBDay.TabIndex = 141;
		this.DOBDay.Text = "Day";
		this.DOBDay.Visible = false;
		this.ID.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ID.Location = new System.Drawing.Point(15, 120);
		this.ID.Name = "ID";
		this.ID.Size = new System.Drawing.Size(209, 30);
		this.ID.TabIndex = 140;
		this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.IDLabel.AutoSize = true;
		this.IDLabel.Font = new System.Drawing.Font("Verdana", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.IDLabel.Location = new System.Drawing.Point(230, 120);
		this.IDLabel.Name = "IDLabel";
		this.IDLabel.Size = new System.Drawing.Size(53, 29);
		this.IDLabel.TabIndex = 139;
		this.IDLabel.Text = ":ID";
		this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.ImportantLabel.AutoSize = true;
		this.ImportantLabel.Font = new System.Drawing.Font("Verdana", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ImportantLabel.Location = new System.Drawing.Point(367, 322);
		this.ImportantLabel.Name = "ImportantLabel";
		this.ImportantLabel.Size = new System.Drawing.Size(127, 25);
		this.ImportantLabel.TabIndex = 138;
		this.ImportantLabel.Text = ":Important";
		this.ImportantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Important.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.Important.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Important.Location = new System.Drawing.Point(103, 322);
		this.Important.Multiline = true;
		this.Important.Name = "Important";
		this.Important.Size = new System.Drawing.Size(258, 82);
		this.Important.TabIndex = 137;
		this.Breed.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.Breed.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Breed.Location = new System.Drawing.Point(480, 80);
		this.Breed.Name = "Breed";
		this.Breed.Size = new System.Drawing.Size(205, 30);
		this.Breed.TabIndex = 136;
		this.Breed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.BreedLabel.AutoSize = true;
		this.BreedLabel.Font = new System.Drawing.Font("Verdana", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BreedLabel.Location = new System.Drawing.Point(690, 80);
		this.BreedLabel.Name = "BreedLabel";
		this.BreedLabel.Size = new System.Drawing.Size(93, 29);
		this.BreedLabel.TabIndex = 135;
		this.BreedLabel.Text = ":Breed";
		this.BreedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.AnimalNameLabel.AutoSize = true;
		this.AnimalNameLabel.Font = new System.Drawing.Font("Verdana", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.AnimalNameLabel.Location = new System.Drawing.Point(605, 120);
		this.AnimalNameLabel.Name = "AnimalNameLabel";
		this.AnimalNameLabel.Size = new System.Drawing.Size(181, 29);
		this.AnimalNameLabel.TabIndex = 134;
		this.AnimalNameLabel.Text = ":Animal Name";
		this.AnimalNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.AnimalName.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.AnimalName.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.AnimalName.Location = new System.Drawing.Point(340, 120);
		this.AnimalName.Name = "AnimalName";
		this.AnimalName.Size = new System.Drawing.Size(260, 30);
		this.AnimalName.TabIndex = 133;
		this.AnimalName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.MemoryStick.AutoSize = true;
		this.MemoryStick.Location = new System.Drawing.Point(12, 242);
		this.MemoryStick.Name = "MemoryStick";
		this.MemoryStick.Size = new System.Drawing.Size(75, 29);
		this.MemoryStick.TabIndex = 132;
		this.MemoryStick.Text = "None";
		this.ClearAll.BackColor = System.Drawing.Color.Transparent;
		this.ClearAll.Image = (System.Drawing.Image)resources.GetObject("ClearAll.Image");
		this.ClearAll.Location = new System.Drawing.Point(809, 124);
		this.ClearAll.Name = "ClearAll";
		this.ClearAll.Size = new System.Drawing.Size(60, 60);
		this.ClearAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClearAll.TabIndex = 131;
		this.ClearAll.TabStop = false;
		this.lbLabel.AutoSize = true;
		this.lbLabel.Location = new System.Drawing.Point(637, 237);
		this.lbLabel.Name = "lbLabel";
		this.lbLabel.Size = new System.Drawing.Size(34, 29);
		this.lbLabel.TabIndex = 22;
		this.lbLabel.Text = "lb";
		this.PersonWeightlb.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.PersonWeightlb.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.PersonWeightlb.Location = new System.Drawing.Point(595, 237);
		this.PersonWeightlb.Name = "PersonWeightlb";
		this.PersonWeightlb.Size = new System.Drawing.Size(40, 30);
		this.PersonWeightlb.TabIndex = 21;
		this.PersonWeightlb.Text = "0";
		this.PersonWeightlb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.inLabel.AutoSize = true;
		this.inLabel.Location = new System.Drawing.Point(823, 236);
		this.inLabel.Name = "inLabel";
		this.inLabel.Size = new System.Drawing.Size(34, 29);
		this.inLabel.TabIndex = 20;
		this.inLabel.Text = "in";
		this.ftLabel.AutoSize = true;
		this.ftLabel.Location = new System.Drawing.Point(742, 236);
		this.ftLabel.Name = "ftLabel";
		this.ftLabel.Size = new System.Drawing.Size(30, 29);
		this.ftLabel.TabIndex = 19;
		this.ftLabel.Text = "ft";
		this.PersonHeightin.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.PersonHeightin.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.PersonHeightin.Location = new System.Drawing.Point(783, 235);
		this.PersonHeightin.Name = "PersonHeightin";
		this.PersonHeightin.Size = new System.Drawing.Size(40, 30);
		this.PersonHeightin.TabIndex = 18;
		this.PersonHeightin.Text = "0";
		this.PersonHeightin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.PersonHeightft.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.PersonHeightft.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.PersonHeightft.Location = new System.Drawing.Point(703, 235);
		this.PersonHeightft.Name = "PersonHeightft";
		this.PersonHeightft.Size = new System.Drawing.Size(40, 30);
		this.PersonHeightft.TabIndex = 17;
		this.PersonHeightft.Text = "0";
		this.PersonHeightft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.stLabel.AutoSize = true;
		this.stLabel.Location = new System.Drawing.Point(554, 237);
		this.stLabel.Name = "stLabel";
		this.stLabel.Size = new System.Drawing.Size(44, 29);
		this.stLabel.TabIndex = 16;
		this.stLabel.Text = "st.";
		this.PersonWeightst.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.PersonWeightst.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.PersonWeightst.Location = new System.Drawing.Point(515, 237);
		this.PersonWeightst.Name = "PersonWeightst";
		this.PersonWeightst.Size = new System.Drawing.Size(40, 30);
		this.PersonWeightst.TabIndex = 15;
		this.PersonWeightst.Text = "0";
		this.PersonWeightst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.kgLabel.AutoSize = true;
		this.kgLabel.Location = new System.Drawing.Point(624, 190);
		this.kgLabel.Name = "kgLabel";
		this.kgLabel.Size = new System.Drawing.Size(42, 29);
		this.kgLabel.TabIndex = 14;
		this.kgLabel.Text = "kg";
		this.cmLabel.AutoSize = true;
		this.cmLabel.Location = new System.Drawing.Point(811, 193);
		this.cmLabel.Name = "cmLabel";
		this.cmLabel.Size = new System.Drawing.Size(49, 29);
		this.cmLabel.TabIndex = 13;
		this.cmLabel.Text = "cm";
		this.PersonName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		this.PersonName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
		this.PersonName.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.PersonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.PersonName.Location = new System.Drawing.Point(15, 35);
		this.PersonName.Name = "PersonName";
		this.PersonName.Size = new System.Drawing.Size(546, 37);
		this.PersonName.TabIndex = 10;
		this.DOBLabel.AutoSize = true;
		this.DOBLabel.Location = new System.Drawing.Point(285, 160);
		this.DOBLabel.Name = "DOBLabel";
		this.DOBLabel.Size = new System.Drawing.Size(175, 29);
		this.DOBLabel.TabIndex = 9;
		this.DOBLabel.Text = ":Date of Birth";
		this.DOBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.DOB.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.DOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DOB.Location = new System.Drawing.Point(105, 160);
		this.DOB.Name = "DOB";
		this.DOB.Size = new System.Drawing.Size(174, 30);
		this.DOB.TabIndex = 8;
		this.DOB.Text = "0";
		this.DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.PersonWeightLabel.AutoSize = true;
		this.PersonWeightLabel.Location = new System.Drawing.Point(513, 160);
		this.PersonWeightLabel.Name = "PersonWeightLabel";
		this.PersonWeightLabel.Size = new System.Drawing.Size(95, 29);
		this.PersonWeightLabel.TabIndex = 7;
		this.PersonWeightLabel.Text = "Weight";
		this.PersonHeightLabel.AutoSize = true;
		this.PersonHeightLabel.Location = new System.Drawing.Point(701, 160);
		this.PersonHeightLabel.Name = "PersonHeightLabel";
		this.PersonHeightLabel.Size = new System.Drawing.Size(90, 29);
		this.PersonHeightLabel.TabIndex = 6;
		this.PersonHeightLabel.Text = "Height";
		this.PersonWeightkg.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.PersonWeightkg.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.PersonWeightkg.Location = new System.Drawing.Point(515, 193);
		this.PersonWeightkg.Name = "PersonWeightkg";
		this.PersonWeightkg.Size = new System.Drawing.Size(100, 30);
		this.PersonWeightkg.TabIndex = 5;
		this.PersonWeightkg.Text = "0";
		this.PersonWeightkg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.PersonHeightcm.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.PersonHeightcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.PersonHeightcm.Location = new System.Drawing.Point(703, 193);
		this.PersonHeightcm.Name = "PersonHeightcm";
		this.PersonHeightcm.Size = new System.Drawing.Size(100, 30);
		this.PersonHeightcm.TabIndex = 4;
		this.PersonHeightcm.Text = "0";
		this.PersonHeightcm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.OptionMF2.AutoSize = true;
		this.OptionMF2.Location = new System.Drawing.Point(340, 223);
		this.OptionMF2.Name = "OptionMF2";
		this.OptionMF2.Size = new System.Drawing.Size(115, 33);
		this.OptionMF2.TabIndex = 3;
		this.OptionMF2.TabStop = true;
		this.OptionMF2.Text = "Female";
		this.OptionMF2.UseVisualStyleBackColor = true;
		this.OptionMF1.AutoSize = true;
		this.OptionMF1.Location = new System.Drawing.Point(230, 223);
		this.OptionMF1.Name = "OptionMF1";
		this.OptionMF1.Size = new System.Drawing.Size(85, 33);
		this.OptionMF1.TabIndex = 2;
		this.OptionMF1.TabStop = true;
		this.OptionMF1.Text = "Male";
		this.OptionMF1.UseVisualStyleBackColor = true;
		this.PersonNameLabel.AutoSize = true;
		this.PersonNameLabel.Font = new System.Drawing.Font("Verdana", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.PersonNameLabel.Location = new System.Drawing.Point(567, 37);
		this.PersonNameLabel.Name = "PersonNameLabel";
		this.PersonNameLabel.Size = new System.Drawing.Size(179, 29);
		this.PersonNameLabel.TabIndex = 0;
		this.PersonNameLabel.Text = ":Owner Name";
		this.PersonNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.InfoEnterTM.Interval = 300;
		this.InformationTM.Interval = 4000;
		this.BMIVisableTM.Interval = 3000;
		this.UpdateInformationTM.Interval = 1000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(906, 434);
		base.Controls.Add(this.Person);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Information";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "Information";
		base.TopMost = true;
		this.Person.ResumeLayout(false);
		this.Person.PerformLayout();
		this.HealthInd.ResumeLayout(false);
		this.HealthInd.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.HealthLegand).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ClosePerson).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ListViewSW).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ClearAll).EndInit();
		base.ResumeLayout(false);
	}

	private void RefYear_SelectedIndexChanged(object sender, EventArgs e)
	{
		RefSet();
	}

	private void RefMonth_SelectedIndexChanged(object sender, EventArgs e)
	{
		RefSet();
	}

	private void RefDay_SelectedIndexChanged(object sender, EventArgs e)
	{
		RefSet();
	}

	private void RefSet()
	{
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		if ((Conversion.Val(RuntimeHelpers.GetObjectValue(RefYear.SelectedItem)) > 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(RefMonth.SelectedItem)) > 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(RefDay.SelectedItem)) > 0.0))
		{
			string format = "dd/MM/yyyy";
			DateTime dateTime = DateTime.ParseExact(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(RefDay.SelectedItem, "/"), RefMonth.SelectedItem), "/"), RefYear.SelectedItem)), format, invariantCulture);
			ControlAChange("Person", "ReferralEnd", "Text", Conversions.ToString(dateTime));
			ControlAChange("Person", "ReferralEnd", "Visible", Conversions.ToString(Value: true));
			ControlAChange("Person", "REFLabel", "Visible", Conversions.ToString(Value: true));
			ControlAChange("Person", "RefDay", "Visible", Conversions.ToString(Value: false));
			ControlAChange("Person", "RefMonth", "Visible", Conversions.ToString(Value: false));
			ControlAChange("Person", "RefYear", "Visible", Conversions.ToString(Value: false));
			if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
			{
				Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",Referral" + ReferralEnd.Text, "Save");
			}
			RefYearCollection();
			MyProject.Forms.Display.CustomerListUpdateRequired = true;
		}
	}

	public object ChangeRegionLanguage()
	{
		Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
		return 1;
	}

	private void Information_Load(object sender, EventArgs e)
	{
		LanguageSet();
		SetResScreen();
		RAMInformation();
	}

	public void LanguageSet()
	{
		if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile"), "Animal", TextCompare: false) == 0)
		{
			ControlAChange("Person", "AnimalNameLabel", "Text", Display.Animaltxt + " " + MyProject.Forms.Display.Nametxt);
			ControlAChange("Person", "PersonNameLabel", "Text", MyProject.Forms.Display.Owners + " " + MyProject.Forms.Display.Nametxt);
		}
		else if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile"), "Person", TextCompare: false) == 0)
		{
			ControlAChange("Person", "PersonNameLabel", "Text", MyProject.Forms.Display.Nametxt);
			ControlAChange("Person", "AnimalNameLabel", "Text", "");
		}
		else if (Operators.CompareString(Interaction.GetSetting("DTread", "File", "SerialFile"), "Canine", TextCompare: false) == 0)
		{
			ControlAChange("Person", "PersonNameLabel", "Text", MyProject.Forms.Display.Owners + " " + MyProject.Forms.Display.Nametxt);
			ControlAChange("Person", "AnimalNameLabel", "Text", Display.Dogstxt + " " + MyProject.Forms.Display.Nametxt);
		}
	}

	private void SetResScreen()
	{
		checked
		{
			base.Height -= 20;
			ResMultiW = (float)((double)base.Width / 906.0);
			ResMultiH = (float)((double)base.Height / 434.0);
			Resolution("Person", "", "");
			Resolution("MemoryStick", "Person", "");
			Resolution("ListViewSw", "Person", "");
			Resolution("ClosePerson", "Person", "");
			Resolution("ClearAll", "Person", "");
			Resolution("HealthInd", "Person", "");
			int num = (int)Math.Round((float)(PersonNameLabel.Left - PersonName.Left - PersonName.Width) * ResMultiW);
			int num2 = (int)Math.Round((float)num + (float)(PersonName.Left - PersonNameLabel.Left - PersonNameLabel.Width) * ResMultiW);
			Resolution("PersonName", "Person", "");
			Resolution("PersonNameLabel", "Person", "");
			ControlAChange("Person", "PersonNameLabel", "Left", Conversions.ToString(PersonName.Left + PersonName.Width + num));
			num = (int)Math.Round((float)(HouseNo.Left - PostCode.Left - PostCode.Width) * ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(PostCode.Left - HouseNo.Left - HouseNo.Width) * ResMultiW);
			Resolution("PostCode", "Person", "");
			Resolution("HouseNo", "Person", "");
			ControlAChange("Person", "HouseNo", "Left", Conversions.ToString(PostCode.Left + PostCode.Width + num));
			Resolution("PostCodeLabel", "Person", "");
			ControlAChange("Person", "PostCodeLabel", "Left", Conversions.ToString(HouseNo.Left + HouseNo.Width + num));
			num = (int)Math.Round((float)(AnimalNameLabel.Left - AnimalName.Left - AnimalName.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(AnimalName.Left - AnimalNameLabel.Left - AnimalNameLabel.Width) * Display.ResMultiW);
			Resolution("AnimalName", "Person", "");
			Resolution("AnimalNameLabel", "Person", "");
			ControlAChange("Person", "AnimalNameLabel", "Left", Conversions.ToString(AnimalName.Left + AnimalName.Width + num));
			num = (int)Math.Round((float)(BreedLabel.Left - Breed.Left - Breed.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(Breed.Left - BreedLabel.Left - BreedLabel.Width) * Display.ResMultiW);
			Resolution("Breed", "Person", "");
			Resolution("BreedLabel", "Person", "");
			ControlAChange("Person", "BreedLabel", "Left", Conversions.ToString(Breed.Left + Breed.Width + num));
			num = (int)Math.Round((float)(DOBLabel.Left - DOB.Left - DOB.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(DOB.Left - DOBLabel.Left - DOBLabel.Width) * Display.ResMultiW);
			Resolution("DOB", "Person", "");
			Resolution("DOBLabel", "Person", "");
			ControlAChange("Person", "DOBLabel", "Left", Conversions.ToString(DOB.Left + DOB.Width + num));
			num = (int)Math.Round((float)(IDLabel.Left - ID.Left - ID.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(ID.Left - IDLabel.Left - IDLabel.Width) * Display.ResMultiW);
			Resolution("ID", "Person", "");
			Resolution("IDLabel", "Person", "");
			ControlAChange("Person", "IDLabel", "Left", Conversions.ToString(ID.Left + ID.Width + num));
			num = (int)Math.Round((float)(AgeLabel.Left - Age.Left - Age.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(Age.Left - AgeLabel.Left - AgeLabel.Width) * Display.ResMultiW);
			Resolution("Age", "Person", "");
			Resolution("AgeLabel", "Person", "");
			ControlAChange("Person", "AgeLabel", "Left", Conversions.ToString(Age.Left + Age.Width + num));
			num = (int)Math.Round((float)(TrainerLabel.Left - Trainer.Left - Trainer.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(Trainer.Left - TrainerLabel.Left - TrainerLabel.Width) * Display.ResMultiW);
			Resolution("Trainer", "Person", "");
			Resolution("TrainerLabel", "Person", "");
			ControlAChange("Person", "TrainerLabel", "Left", Conversions.ToString(Trainer.Left + Trainer.Width + num));
			num = (int)Math.Round((float)(ImportantLabel.Left - Important.Left - Important.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(Important.Left - ImportantLabel.Left - ImportantLabel.Width) * Display.ResMultiW);
			Resolution("Important", "Person", "");
			Resolution("ImportantLabel", "Person", "");
			ControlAChange("Person", "ImportantLabel", "Left", Conversions.ToString(Important.Left + Important.Width + num));
			num = (int)Math.Round((float)RefLabel.Left * Display.ResMultiW);
			Resolution("ReferralEnd", "Person", "");
			Resolution("RefLabel", "Person", "");
			ControlAChange("Person", "RefLabel", "Left", Conversions.ToString(ReferralEnd.Left + ReferralEnd.Width - RefLabel.Width));
			num = (int)Math.Round((float)(RefYear.Left - RefMonth.Left - RefMonth.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(RefMonth.Left - RefYear.Left - RefYear.Width) * Display.ResMultiW);
			Resolution("RefDay", "Person", "");
			Resolution("RefMonth", "Person", "");
			Resolution("RefYear", "Person", "");
			ControlAChange("Person", "RefYear", "Left", Conversions.ToString(RefMonth.Left + RefMonth.Width + num));
			num = (int)Math.Round((float)(cmLabel.Left - PersonHeightcm.Left - PersonHeightcm.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(cmLabel.Left - PersonHeightcm.Left - PersonHeightcm.Width) * Display.ResMultiW);
			Resolution("PersonHeightLabel", "Person", "");
			Resolution("PersonHeightcm", "Person", "");
			Resolution("cmLabel", "Person", "");
			ControlAChange("Person", "cmLabel", "Left", Conversions.ToString(PersonHeightcm.Left + PersonHeightcm.Width + num));
			num = (int)Math.Round((float)(ftLabel.Left - PersonHeightft.Left - PersonHeightft.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(PersonHeightin.Left - ftLabel.Left - ftLabel.Width) * Display.ResMultiW);
			int num3 = (int)Math.Round((float)num + (float)(inLabel.Left - PersonHeightin.Left - PersonHeightin.Width) * Display.ResMultiW);
			Resolution("PersonHeightft", "Person", "");
			Resolution("ftLabel", "Person", "");
			ControlAChange("Person", "ftLabel", "Left", Conversions.ToString(PersonHeightft.Left + PersonHeightft.Width + num));
			Resolution("PersonHeightin", "Person", "");
			ControlAChange("Person", "PersonHeightin", "Left", Conversions.ToString(ftLabel.Left + ftLabel.Width + num2));
			Resolution("inLabel", "Person", "");
			ControlAChange("Person", "inLabel", "Left", Conversions.ToString(PersonHeightin.Left + PersonHeightin.Width + num3));
			num = (int)Math.Round((float)(kgLabel.Left - PersonWeightkg.Left - PersonWeightkg.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(PersonWeightkg.Left - kgLabel.Left - kgLabel.Width) * Display.ResMultiW);
			Resolution("PersonWeightLabel", "Person", "");
			Resolution("PersonWeightkg", "Person", "");
			Resolution("kgLabel", "Person", "");
			ControlAChange("Person", "kgLabel", "Left", Conversions.ToString(PersonWeightkg.Left + PersonWeightkg.Width + num));
			num = (int)Math.Round((float)(stLabel.Left - PersonWeightst.Left - PersonWeightst.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(PersonWeightlb.Left - stLabel.Left - stLabel.Width) * Display.ResMultiW);
			num3 = (int)Math.Round((float)num + (float)(lbLabel.Left - PersonWeightlb.Left - PersonWeightlb.Width) * Display.ResMultiW);
			Resolution("PersonWeightst", "Person", "");
			Resolution("stLabel", "Person", "");
			ControlAChange("Person", "stLabel", "Left", Conversions.ToString(PersonWeightst.Left + PersonWeightst.Width + num));
			Resolution("PersonWeightlb", "Person", "");
			ControlAChange("Person", "PersonWeightlb", "Left", Conversions.ToString(stLabel.Left + stLabel.Width + num2));
			Resolution("lbLabel", "Person", "");
			ControlAChange("Person", "lbLabel", "Left", Conversions.ToString(PersonWeightlb.Left + PersonWeightlb.Width + num3));
			num = (int)Math.Round((float)(BMRLabel.Left - BMR.Left - BMR.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(BMRLabel.Left - BMR.Left - BMR.Width) * Display.ResMultiW);
			Resolution("BMRLabel", "HealthInd", "Person");
			Resolution("BMR", "HealthInd", "Person");
			num = (int)Math.Round((float)(RMRLabel.Left - RMR.Left - RMR.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(RMRLabel.Left - RMR.Left - RMR.Width) * Display.ResMultiW);
			Resolution("RMRLabel", "HealthInd", "Person");
			Resolution("RMR", "HealthInd", "Person");
			num = (int)Math.Round((float)(BMILabel.Left - BMI.Left - BMI.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(BMILabel.Left - BMI.Left - BMI.Width) * Display.ResMultiW);
			Resolution("BMILabel", "HealthInd", "Person");
			Resolution("BMI", "HealthInd", "Person");
			num = (int)Math.Round((float)(BMIDescription.Left - BMIDescription.Width) * Display.ResMultiW);
			num2 = (int)Math.Round((float)num + (float)(BMIDescription.Left - BMIDescription.Width) * Display.ResMultiW);
			Resolution("BMIDescription", "HealthInd", "Person");
			int num4 = 1;
			do
			{
				Resolution("OptionMF" + num4, "Person", "");
				num4++;
			}
			while (num4 <= 2);
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
						return;
					}
					if ((double)ResMultiH > 1.1)
					{
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font.FontFamily, (float)((double)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font.Size * ((double)ResMultiH * 0.85)));
					}
					else
					{
						base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Font.Size * ResMultiH);
					}
					base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Height * ResMultiH);
					base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Width * ResMultiW);
					base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Top * ResMultiH);
					base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainerA].Controls[ControlContainer].Controls[ControlName].Left * ResMultiW);
				}
				else if (Operators.CompareString(ControlContainer, "", TextCompare: false) > 0)
				{
					if (base.Controls[ControlContainer].Controls[ControlName].InvokeRequired)
					{
						SetControl2Callback method2 = Resolution;
						Invoke(method2, ControlName, ControlContainer, ControlContainerA);
						return;
					}
					if ((double)ResMultiH > 1.1)
					{
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, (float)((double)base.Controls[ControlContainer].Controls[ControlName].Font.Size * ((double)ResMultiH * 0.85)));
					}
					else
					{
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainer].Controls[ControlName].Font.Size * ResMultiH);
					}
					base.Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Height * ResMultiH);
					base.Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Width * ResMultiW);
					base.Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Top * ResMultiH);
					base.Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Left * ResMultiW);
				}
				else if (base.Controls[ControlName].InvokeRequired)
				{
					SetControl2Callback method3 = Resolution;
					Invoke(method3, ControlName, ControlContainer, ControlContainerA);
				}
				else
				{
					if ((double)ResMultiH > 1.1)
					{
						base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, (float)((double)base.Controls[ControlName].Font.Size * ((double)ResMultiH * 0.85)));
					}
					else
					{
						base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, base.Controls[ControlName].Font.Size * ResMultiH);
					}
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

	public void ControlChange(string ControlName, string Setting, string Data)
	{
		checked
		{
			try
			{
				if (base.Controls[ControlName].InvokeRequired)
				{
					SetControl2Callback method = ControlChange;
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
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, (float)Conversion.Val(Data));
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

	public void ControlAChange(string ControlAName, string ControlName, string Setting, string Data)
	{
		checked
		{
			try
			{
				if (base.Controls[ControlAName].Controls[ControlName].InvokeRequired)
				{
					SetControl3Callback method = ControlAChange;
					Invoke(method, ControlAName, ControlName, Setting, Data);
					return;
				}
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
				case "SelectedItem":
					unchecked
					{
						switch (ControlName)
						{
						case "DOBDay":
							if (Conversion.Val(Data) <= 9.0 && (object)Data != "Day")
							{
								DOBDay.SelectedItem = "0" + Data.ToString();
							}
							else
							{
								DOBDay.SelectedItem = Data;
							}
							break;
						case "RefDay":
							if (Conversion.Val(Data) <= 9.0 && (object)Data != "Day")
							{
								RefDay.SelectedItem = "0" + Data.ToString();
							}
							else
							{
								RefDay.SelectedItem = Data;
							}
							break;
						case "DOBMonth":
							if (Conversion.Val(Data) <= 9.0 && (object)Data != "Month")
							{
								DOBMonth.SelectedItem = "0" + Data.ToString();
							}
							else
							{
								DOBMonth.SelectedItem = Data;
							}
							break;
						case "RefMonth":
							if (Conversion.Val(Data) <= 9.0 && (object)Data != "Month")
							{
								RefMonth.SelectedItem = "0" + Data.ToString();
							}
							else
							{
								RefMonth.SelectedItem = Data;
							}
							break;
						case "DOBYear":
							DOBYear.SelectedItem = Data;
							break;
						case "RefYear":
							RefYear.SelectedItem = Data;
							break;
						}
						break;
					}
				case "BringToFront":
					base.Controls[ControlAName].Controls[ControlName].BringToFront();
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

	public void ControlBChange(string ControlBName, string ControlAName, string ControlName, string Setting, string Data)
	{
		checked
		{
			try
			{
				if (base.Controls[ControlBName].Controls[ControlAName].Controls[ControlName].InvokeRequired)
				{
					SetControl4Callback method = ControlBChange;
					Invoke(method, ControlAName, ControlName, Setting, Data);
					return;
				}
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
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ClosePerson_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Display.RecordChanges();
		MyProject.Forms.Display.DoBox2Change("RemoteProgramEdit0");
		MyProject.Forms.Display.PersonFileRead = false;
	}

	private void ListViewSW_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
		{
			Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",LIST", "Save");
			return;
		}
		MyProject.Forms.Display.RecordChanges();
		MyProject.Forms.Display.DoBoxChange("List");
	}

	private void RunNewPerson()
	{
		MyProject.Forms.InfoEnter.Show();
		InfoEnterTM.Enabled = true;
		checked
		{
			switch (ItemName)
			{
			case "PersonName":
				if (Operators.CompareString(PersonName.Text, "Name", TextCompare: false) == 0)
				{
					PersonNameChange("Text", "");
				}
				MyProject.Forms.InfoEnter.Preload = PersonName.Text;
				InfoEnter.PasswordSet = PersonName.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "AnimalName":
				MyProject.Forms.InfoEnter.Preload = AnimalName.Text;
				InfoEnter.PasswordSet = AnimalName.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "Trainer":
				MyProject.Forms.InfoEnter.Preload = Trainer.Text;
				InfoEnter.PasswordSet = Trainer.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "ID":
				MyProject.Forms.InfoEnter.Preload = ID.Text;
				InfoEnter.PasswordSet = ID.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "PostCode":
				MyProject.Forms.InfoEnter.Preload = PostCode.Text;
				InfoEnter.PasswordSet = PostCode.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "HouseNo":
				MyProject.Forms.InfoEnter.Preload = HouseNo.Text;
				InfoEnter.PasswordSet = HouseNo.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "Breed":
				MyProject.Forms.InfoEnter.Preload = Breed.Text;
				InfoEnter.PasswordSet = Breed.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "Important":
				MyProject.Forms.InfoEnter.Preload = Important.Text;
				InfoEnter.PasswordSet = Important.Text;
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "DOB":
				ClearDayMonthYearDOBCollection();
				if (Conversion.Val(DOB.Text) == 0.0)
				{
					DOBChange("Text", "");
				}
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "REF":
				ClearDayMonthYearRefCollection();
				if (Conversion.Val(ReferralEnd.Text) == 0.0)
				{
					ReferralEndChange("Text", "");
				}
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "Height":
				if (Conversion.Val(PersonHeightcm.Text) == 0.0)
				{
					PersonHeightcmChange("Text", "");
					MyProject.Forms.InfoEnter.Preload = PersonHeightcm.Text;
				}
				else
				{
					MyProject.Forms.InfoEnter.Preload = PersonHeightcm.Text;
				}
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			case "Weight":
				if (Conversion.Val(PersonWeightkg.Text) == 0.0)
				{
					PersonWeightkgChange("Text", "");
					MyProject.Forms.InfoEnter.Preload = PersonWeightkg.Text;
				}
				else
				{
					MyProject.Forms.InfoEnter.Preload = PersonWeightkg.Text;
				}
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			default:
				MyProject.Forms.InfoEnter.SetLocation(MyProject.Forms.InfoEnter.CentreLocX, base.Top + base.Height);
				break;
			}
		}
	}

	private void DOB_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			DOBShow();
		}
	}

	private void DOBLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			if (!DOB.Visible)
			{
				ClearDayMonthYearDOBCollection();
			}
			else
			{
				DOBShow();
			}
		}
	}

	private void ReferralEnd_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			RefShow();
		}
	}

	private void REFLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			if (!ReferralEnd.Visible)
			{
				ClearDayMonthYearRefCollection();
			}
			else
			{
				RefShow();
			}
		}
	}

	public void ClearDayMonthYearDOBCollection()
	{
		ControlAChange("Person", "DOBDay", "SelectedItem", "Day");
		ControlAChange("Person", "DOBMonth", "SelectedItem", "Month");
		ControlAChange("Person", "DOBYear", "SelectedItem", "Year");
		ControlAChange("Person", "DOB", "Visible", Conversions.ToString(Value: true));
		ControlAChange("Person", "DOBLabel", "Visible", Conversions.ToString(Value: true));
		ControlAChange("Person", "DOBDay", "Visible", Conversions.ToString(Value: false));
		ControlAChange("Person", "DOBMonth", "Visible", Conversions.ToString(Value: false));
		ControlAChange("Person", "DOBYear", "Visible", Conversions.ToString(Value: false));
		ControlAChange("Person", "AgeLabel", "Visible", Conversions.ToString(Value: true));
		ControlAChange("Person", "Age", "Visible", Conversions.ToString(Value: true));
	}

	public void ClearDayMonthYearRefCollection()
	{
		ControlAChange("Person", "RefDay", "SelectedItem", "Day");
		ControlAChange("Person", "RefMonth", "SelectedItem", "Month");
		ControlAChange("Person", "RefYear", "SelectedItem", "Year");
		ControlAChange("Person", "ReferralEnd", "Visible", Conversions.ToString(Value: true));
		ControlAChange("Person", "RefDay", "Visible", Conversions.ToString(Value: false));
		ControlAChange("Person", "RefMonth", "Visible", Conversions.ToString(Value: false));
		ControlAChange("Person", "RefYear", "Visible", Conversions.ToString(Value: false));
		ControlAChange("Person", "RefLabel", "Visible", Conversions.ToString(Value: true));
	}

	private void DOBShow()
	{
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		string format = "dd/MM/yyyy";
		try
		{
			if ((Operators.CompareString(DOB.Text, null, TextCompare: false) != 0) & (Operators.CompareString(DOB.Text, "0", TextCompare: false) != 0))
			{
				DateTime dateTime = DateTime.ParseExact(DOB.Text, format, invariantCulture);
				ControlAChange("Person", "DOBDay", "SelectedItem", Conversions.ToString(dateTime.Day));
				ControlAChange("Person", "DOBMonth", "SelectedItem", Conversions.ToString(dateTime.Month));
				ControlAChange("Person", "DOBYear", "SelectedItem", Conversions.ToString(dateTime.Year));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		ControlAChange("Person", "Age", "Visible", "False");
		ControlAChange("Person", "AgeLabel", "Visible", "False");
		ControlAChange("Person", "DOB", "Visible", "False");
		ControlAChange("Person", "DOBLabel", "Visible", Conversions.ToString(Value: false));
		ControlAChange("Person", "DOBDay", "Visible", "True");
		ControlAChange("Person", "DOBMonth", "Visible", "True");
		ControlAChange("Person", "DOBYear", "Visible", "True");
	}

	private void RefShow()
	{
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		string format = "dd/MM/yyyy";
		try
		{
			if ((Operators.CompareString(ReferralEnd.Text, null, TextCompare: false) != 0) & (Operators.CompareString(ReferralEnd.Text, "0", TextCompare: false) != 0))
			{
				DateTime dateTime = DateTime.ParseExact(ReferralEnd.Text, format, invariantCulture);
				ControlAChange("Person", "RefDay", "SelectedItem", Conversions.ToString(dateTime.Day));
				ControlAChange("Person", "RefMonth", "SelectedItem", Conversions.ToString(dateTime.Month));
				ControlAChange("Person", "RefYear", "SelectedItem", Conversions.ToString(dateTime.Year));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		ControlAChange("Person", "ReferralEnd", "Visible", "False");
		ControlAChange("Person", "RefLabel", "Visible", "False");
		ControlAChange("Person", "RefDay", "Visible", "True");
		ControlAChange("Person", "RefMonth", "Visible", "True");
		ControlAChange("Person", "RefYear", "Visible", "True");
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
			Interaction.SaveSetting("Health", "Person", "Sex", Text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void InLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Heightin";
			HoldItem = PersonHeightin.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonHeightin_Click1(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Heightin";
			HoldItem = PersonHeightin.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void FTLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Heightft";
			HoldItem = PersonHeightft.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonHeightft_Click1(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Heightft";
			HoldItem = PersonHeightft.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonHeightLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Heightcm";
			HoldItem = PersonHeightcm.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonHeight_Click1(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Heightcm";
			HoldItem = PersonHeightcm.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonWeightlb_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Weightlb";
			HoldItem = PersonWeightlb.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void LBLabel_Click1(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Weightlb";
			HoldItem = PersonWeightlb.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonWeightst_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Weightst";
			HoldItem = PersonWeightst.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void STLabel_Click1(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Weightst";
			HoldItem = PersonWeightst.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonWeightLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Weightkg";
			HoldItem = PersonWeightkg.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonWeight_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Weightkg";
			HoldItem = PersonWeightkg.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void Trainer_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			PersonNameChange("Visible", "True");
			ItemName = "Trainer";
			HoldItem = Trainer.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void TrainerLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			PersonNameChange("Visible", "True");
			ItemName = "Trainer";
			HoldItem = Trainer.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonName_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			PersonNameChange("Visible", "True");
			ItemName = "PersonName";
			HoldItem = PersonName.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PersonNameLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			PersonNameChange("Visible", "True");
			ItemName = "PersonName";
			HoldItem = PersonName.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void AnimalName_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "AnimalName";
			HoldItem = AnimalName.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void AnimalNameLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "AnimalName";
			HoldItem = AnimalName.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void PostCode_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "PostCode";
			HoldItem = PostCode.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void HouseNo_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "HouseNo";
			HoldItem = HouseNo.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void Breed_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Breed";
			HoldItem = Breed.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void BreedLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Breed";
			HoldItem = Breed.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void ID_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "ID";
			HoldItem = ID.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void IDLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "ID";
			HoldItem = ID.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void Important_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Important";
			HoldItem = Important.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void ImportantLabel_Click(object sender, EventArgs e)
	{
		if (ControlLevel == 0)
		{
			ItemName = "Important";
			HoldItem = Important.Text;
			RunNewPerson();
			ControlLevel = 1;
		}
	}

	private void InfoEnterTM_Tick(object sender, EventArgs e)
	{
		switch (ItemName)
		{
		case "PersonName":
			PersonNameChange("TextAlign", "Left");
			PersonNameChange("Text", InfoEnter.PasswordSet);
			break;
		case "AnimalName":
			AnimalNameChange("TextAlign", "Left");
			AnimalNameChange("Text", InfoEnter.PasswordSet);
			break;
		case "Trainer":
			TrainerChange("TextAlign", "Left");
			TrainerChange("Text", InfoEnter.PasswordSet);
			break;
		case "Breed":
			BreedChange("TextAlign", "Left");
			BreedChange("Text", InfoEnter.PasswordSet);
			break;
		case "ID":
			IDChange("TextAlign", "Left");
			IDChange("Text", InfoEnter.PasswordSet);
			break;
		case "PostCode":
			PostCodeChange("TextAlign", "Left");
			PostCodeChange("Text", InfoEnter.PasswordSet);
			break;
		case "HouseNo":
			HouseNoChange("TextAlign", "Left");
			HouseNoChange("Text", InfoEnter.PasswordSet);
			break;
		case "Important":
			ImportantChange("TextAlign", "Left");
			ImportantChange("Text", InfoEnter.PasswordSet);
			break;
		case "Heightin":
			PersonHeightinChange("Text", InfoEnter.PasswordSet);
			PersonHeightinChange("TextAlign", "Left");
			break;
		case "Heightft":
			PersonHeightftChange("Text", InfoEnter.PasswordSet);
			PersonHeightftChange("TextAlign", "Left");
			break;
		case "Heightcm":
			PersonHeightcmChange("Text", InfoEnter.PasswordSet);
			PersonHeightcmChange("TextAlign", "Left");
			break;
		case "Weightkg":
			PersonWeightkgChange("Text", InfoEnter.PasswordSet);
			PersonWeightkgChange("TextAlign", "Left");
			break;
		case "Weightst":
			PersonWeightstChange("Text", InfoEnter.PasswordSet);
			PersonWeightstChange("TextAlign", "Left");
			break;
		case "Weightlb":
			PersonWeightlbChange("Text", InfoEnter.PasswordSet);
			PersonWeightlbChange("TextAlign", "Left");
			break;
		}
		if (InfoEnter.ControlKey)
		{
			return;
		}
		switch (ItemName)
		{
		case "PersonName":
			if (Operators.CompareString(PersonName.Text, "", TextCompare: false) == 0)
			{
				PersonNameChange("text", HoldItem);
			}
			else
			{
				ControlChange("Person", "Text", MyProject.Forms.Display.TimeOfDayInd);
				Interaction.SaveSetting("Health", "Person", "Name", PersonName.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",PNAME" + PersonName.Text, "Save");
				}
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			PersonNameChange("TextAlign", "Left");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "AnimalName":
			if (Operators.CompareString(AnimalName.Text, "", TextCompare: false) == 0)
			{
				AnimalNameChange("text", HoldItem);
			}
			else
			{
				Interaction.SaveSetting("Health", "Person", "AnimalName", AnimalName.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",DNAME" + AnimalName.Text, "Save");
				}
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			AnimalNameChange("TextAlign", "Centre");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "Trainer":
			if (Operators.CompareString(Trainer.Text, "", TextCompare: false) == 0)
			{
				TrainerChange("text", HoldItem);
			}
			else
			{
				Interaction.SaveSetting("Health", "Person", "Trainer", Trainer.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",TRAINER" + Trainer.Text, "Save");
				}
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			TrainerChange("TextAlign", "Center");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "ID":
			if (Operators.CompareString(ID.Text, "", TextCompare: false) == 0)
			{
				IDChange("text", HoldItem);
			}
			else
			{
				Interaction.SaveSetting("Health", "Person", "ID", ID.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",ID" + ID.Text, "Save");
				}
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			IDChange("TextAlign", "Center");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "PostCode":
			if (Operators.CompareString(PostCode.Text, "", TextCompare: false) == 0)
			{
				PostCodeChange("text", HoldItem);
			}
			else
			{
				Interaction.SaveSetting("Health", "Person", "PostCode", PostCode.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",POSTCODE" + PostCode.Text, "Save");
				}
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			PostCodeChange("TextAlign", "Center");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "HouseNo":
			if (Operators.CompareString(PostCode.Text, "", TextCompare: false) == 0)
			{
				HouseNoChange("text", HoldItem);
			}
			else
			{
				Interaction.SaveSetting("Health", "Person", "HouseNo", HouseNo.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",HOUSENO" + HouseNo.Text, "Save");
				}
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			HouseNoChange("TextAlign", "Center");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "Breed":
			if (Operators.CompareString(Breed.Text, "", TextCompare: false) == 0)
			{
				BreedChange("text", HoldItem);
			}
			else
			{
				Interaction.SaveSetting("Health", "Person", "Breed", Breed.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",BREED" + Breed.Text, "Save");
				}
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			BreedChange("TextAlign", "Center");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "Important":
			if (Operators.CompareString(Important.Text, "", TextCompare: false) == 0)
			{
				ImportantChange("text", HoldItem);
			}
			else
			{
				Interaction.SaveSetting("Health", "Person", "Important", Important.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",IMPORTANT" + Important.Text, "Save");
				}
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			ImportantChange("TextAlign", "Left");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "Heightin":
			if ((Operators.CompareString(PersonHeightin.Text, "", TextCompare: false) == 0) | (Conversion.Val(PersonHeightin.Text) > 11.0))
			{
				PersonHeightinChange("text", HoldItem);
			}
			else
			{
				HeightToCm();
				Interaction.SaveSetting("Health", "Person", "Height", PersonHeightcm.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",HEIGHT" + PersonHeightcm.Text, "Save");
				}
				PersonHealthCheck();
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			PersonHeightinChange("TextAlign", "Center");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "Heightft":
			if ((Operators.CompareString(PersonHeightft.Text, "", TextCompare: false) == 0) | (Conversion.Val(PersonHeightft.Text) > 14.0))
			{
				PersonHeightftChange("text", HoldItem);
			}
			else
			{
				HeightToCm();
				Interaction.SaveSetting("Health", "Person", "Height", PersonHeightcm.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",HEIGHT" + PersonHeightcm.Text, "Save");
				}
				PersonHealthCheck();
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			PersonHeightftChange("TextAlign", "Center");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "Heightcm":
			if ((Operators.CompareString(PersonHeightcm.Text, "", TextCompare: false) == 0) | (Conversion.Val(PersonHeightcm.Text) > 300.0))
			{
				PersonHeightcmChange("text", HoldItem);
			}
			else
			{
				SetFeetInches();
				Interaction.SaveSetting("Health", "Person", "Height", PersonHeightcm.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",HEIGHT" + PersonHeightcm.Text, "Save");
				}
				PersonHealthCheck();
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			PersonHeightcmChange("TextAlign", "Center");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		case "Weightst":
			if ((Operators.CompareString(PersonWeightst.Text, "", TextCompare: false) == 0) | (Conversion.Val(PersonWeightst.Text) > 35.0))
			{
				PersonWeightstChange("text", HoldItem);
			}
			else
			{
				WeightToKg();
				Interaction.SaveSetting("Health", "Person", "Weight", PersonWeightkg.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",WEIGHT" + PersonWeightkg.Text, "Save");
				}
				PersonHealthCheck();
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			MyProject.Forms.Display.PersonFileRead = false;
			PersonWeightstChange("TextAlign", "Center");
			break;
		case "Weightlb":
			if ((Operators.CompareString(PersonWeightlb.Text, "", TextCompare: false) == 0) | (Conversion.Val(PersonWeightlb.Text) > 13.0))
			{
				PersonWeightlbChange("text", HoldItem);
			}
			else
			{
				WeightToKg();
				Interaction.SaveSetting("Health", "Person", "Weight", PersonWeightkg.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",WEIGHT" + PersonWeightkg.Text, "Save");
				}
				PersonHealthCheck();
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			MyProject.Forms.Display.PersonFileRead = false;
			PersonWeightlbChange("TextAlign", "Center");
			break;
		case "Weightkg":
			if ((Operators.CompareString(PersonWeightkg.Text, "", TextCompare: false) == 0) | (Conversion.Val(PersonWeightkg.Text) > 300.0))
			{
				PersonWeightkgChange("text", HoldItem);
			}
			else
			{
				SetStonePounds();
				Interaction.SaveSetting("Health", "Person", "Weight", PersonWeightkg.Text);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",WEIGHT" + PersonWeightkg.Text, "Save");
				}
				PersonHealthCheck();
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
			PersonWeightkgChange("TextAlign", "Center");
			MyProject.Forms.Display.PersonFileRead = false;
			break;
		}
		MyProject.Forms.InfoEnter.Preload = "";
		InfoEnter.PasswordSet = "";
		InfoEnterTM.Dispose();
		ControlLevel = 0;
	}

	private void OptionMF_Click(object sender, EventArgs e)
	{
		if (OptionMF1.Checked)
		{
			PersonSexChange("M");
			if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
			{
				Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",SEXM", "Save");
			}
		}
		else if (OptionMF2.Checked)
		{
			PersonSexChange("F");
			if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
			{
				Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",SEXF", "Save");
			}
		}
		PersonHealthCheck();
	}

	public void PersonHealthCheck()
	{
		if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) == 0) & (Conversion.Val(DOB.Text) > 0.0) & (Conversion.Val(PersonHeightcm.Text) > 0.0) & (Conversion.Val(PersonWeightkg.Text) > 0.0))
		{
			ControlAChange("Person", "HealthInd", "Visible", "True");
			ControlBChange("Person", "HealthInd", "BMR", "Text", Conversions.ToString(BasalMetabolicRate()));
			ControlBChange("Person", "HealthInd", "RMR", "Text", Conversions.ToString(RestingMetabolicRate()));
			ControlBChange("Person", "HealthInd", "BMI", "Text", Conversions.ToString(BodyMassIndex()));
			if (Conversion.Val(BMI.Text) <= 15.0)
			{
				ControlBChange("Person", "HealthInd", "BMIDescription", "Text", MyProject.Forms.Display.Very + " " + MyProject.Forms.Display.Severely + "\r" + MyProject.Forms.Display.Underweight);
			}
			if ((Conversion.Val(BMI.Text) > 15.0) & (Conversion.Val(BMI.Text) <= 16.0))
			{
				ControlBChange("Person", "HealthInd", "BMIDescription", "Text", MyProject.Forms.Display.Severely + "\r" + MyProject.Forms.Display.Underweight);
			}
			if ((Conversion.Val(BMI.Text) > 16.0) & (Conversion.Val(BMI.Text) <= 18.5))
			{
				ControlBChange("Person", "HealthInd", "BMIDescription", "Text", MyProject.Forms.Display.Underweight);
			}
			if ((Conversion.Val(BMI.Text) > 18.5) & (Conversion.Val(BMI.Text) <= 25.0))
			{
				ControlBChange("Person", "HealthInd", "BMIDescription", "Text", MyProject.Forms.Display.Healthy + "\r" + MyProject.Forms.Display.Weight);
			}
			if ((Conversion.Val(BMI.Text) > 25.0) & (Conversion.Val(BMI.Text) <= 30.0))
			{
				ControlBChange("Person", "HealthInd", "BMIDescription", "Text", MyProject.Forms.Display.Overweight);
			}
			if ((Conversion.Val(BMI.Text) > 30.0) & (Conversion.Val(BMI.Text) <= 35.0))
			{
				ControlBChange("Person", "HealthInd", "BMIDescription", "Text", MyProject.Forms.Display.Moderately + "\r" + MyProject.Forms.Display.Obese);
			}
			if ((Conversion.Val(BMI.Text) > 35.0) & (Conversion.Val(BMI.Text) <= 40.0))
			{
				ControlBChange("Person", "HealthInd", "BMIDescription", "Text", MyProject.Forms.Display.Severely + "\r" + MyProject.Forms.Display.Obese);
			}
			if (Conversion.Val(BMI.Text) > 40.0)
			{
				ControlBChange("Person", "HealthInd", "BMIDescription", "Text", MyProject.Forms.Display.Very + " " + MyProject.Forms.Display.Severely + "\r" + MyProject.Forms.Display.Obese);
			}
		}
		else
		{
			ControlAChange("Person", "HealthInd", "Visible", "False");
			ControlBChange("Person", "HealthInd", "BMI", "Text", "15");
			ControlBChange("Person", "HealthInd", "BMIDescription", "Text", MyProject.Forms.Display.Very + " " + MyProject.Forms.Display.Severely + " " + MyProject.Forms.Display.Underweight);
		}
	}

	public void DOBYearCollection()
	{
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		checked
		{
			short num = (short)DateAndTime.Year(DateAndTime.Now);
			short num2 = ((!((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))) ? ((short)(num - 120)) : ((short)(num - 30)));
			DOBYear.Items.Clear();
			do
			{
				DOBYear.Items.Add(num.ToString());
				num--;
			}
			while (num > num2);
			DOBYear.Items.Add("Year");
			string format = "dd/MM/yyyy";
			try
			{
				if ((Operators.CompareString(DOB.Text, null, TextCompare: false) != 0) & (Operators.CompareString(DOB.Text, "0", TextCompare: false) != 0))
				{
					DateTime dateTime = DateTime.ParseExact(DOB.Text, format, invariantCulture);
					string texta = Conversions.ToString(GetAgeFromDOB(dateTime));
					AgeChange("Text", texta);
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

	public void RefYearCollection()
	{
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		checked
		{
			short num = (short)DateAndTime.Year(DateAndTime.Now);
			short num2 = ((!((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0))) ? ((short)(num + 5)) : ((short)(num + 5)));
			RefYear.Items.Clear();
			do
			{
				RefYear.Items.Add(num.ToString());
				num++;
			}
			while (num < num2);
			RefYear.Items.Add("Year");
			string format = "dd/MM/yyyy";
			try
			{
				if ((Operators.CompareString(ReferralEnd.Text, null, TextCompare: false) != 0) & (Operators.CompareString(ReferralEnd.Text, "0", TextCompare: false) != 0))
				{
					DateTime dateTime = DateTime.ParseExact(ReferralEnd.Text, format, invariantCulture);
					float num3 = (float)Conversion.Val(RuntimeHelpers.GetObjectValue(GetAgeFromRef(dateTime)));
					if (num3 > 0f)
					{
						ReferralEndChange("Color", "Red");
						MyProject.Forms.Display.RefError = true;
					}
					else
					{
						ReferralEndChange("Color", "Normal");
						MyProject.Forms.Display.RefError = false;
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
	}

	public object GetAgeFromDOB(object DOBDate)
	{
		string text = "";
		checked
		{
			try
			{
				long num = DateAndTime.DateDiff(DateInterval.Year, Conversions.ToDate(DOBDate), DateAndTime.Now);
				long num2 = DateAndTime.DateDiff(DateInterval.Month, Conversions.ToDate(DOBDate), DateAndTime.Now);
				if (DateAndTime.DateDiff(DateInterval.Month, Conversions.ToDate(DOBDate), DateAndTime.Now) <= 12)
				{
					num = DateAndTime.DateDiff(DateInterval.Month, Conversions.ToDate(DOBDate), DateAndTime.Now);
					if (Operators.ConditionalCompareObjectGreater(DateAndTime.Now.Day, NewLateBinding.LateGet(DOBDate, null, "Day", new object[0], null, null, null), TextCompare: false))
					{
						num--;
					}
					if (num == 12)
					{
						text = Conversions.ToString(1);
						Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString(1));
					}
					else
					{
						text = num + "m";
						Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString(12.0 / (double)num));
					}
				}
				else
				{
					num = DateAndTime.DateDiff(DateInterval.Year, Conversions.ToDate(DOBDate), DateAndTime.Now);
					if (Operators.ConditionalCompareObjectGreaterEqual(DateAndTime.Now.Month, NewLateBinding.LateGet(DOBDate, null, "Month", new object[0], null, null, null), TextCompare: false))
					{
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(DateAndTime.Now.Day, NewLateBinding.LateGet(DOBDate, null, "Day", new object[0], null, null, null), TextCompare: false), num > 1)))
						{
							num--;
							num2 -= num * 12;
							if (Operators.ConditionalCompareObjectLess(DateAndTime.Now.Day, NewLateBinding.LateGet(DOBDate, null, "Day", new object[0], null, null, null), TextCompare: false))
							{
								num2--;
							}
							if (num2 > 0)
							{
								if (num2 == 12)
								{
									num2 = 11L;
								}
								if (num2 > 12)
								{
									num2 -= 12;
								}
								text = num + "." + num2 + "m";
								Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString((double)num + Math.Round((double)num2 / 12.0, 1)));
							}
							else
							{
								text = num.ToString();
								Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString(num));
							}
							Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString((double)num + Math.Round((double)num2 / 12.0, 1)));
						}
						else
						{
							num2 -= num * 12;
							if (Operators.ConditionalCompareObjectLess(DateAndTime.Now.Day, NewLateBinding.LateGet(DOBDate, null, "Day", new object[0], null, null, null), TextCompare: false))
							{
								num2--;
							}
							if (num2 > 0)
							{
								if (num2 == 12)
								{
									num2 = 11L;
								}
								if (num2 > 12)
								{
									num2 -= 12;
								}
								text = num + "." + num2 + "m";
								Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString((double)num + Math.Round((double)num2 / 12.0, 1)));
							}
							else
							{
								text = num.ToString();
								Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString(num));
							}
						}
					}
					else
					{
						num--;
						num2 -= num * 12;
						if (Operators.ConditionalCompareObjectLess(DateAndTime.Now.Day, NewLateBinding.LateGet(DOBDate, null, "Day", new object[0], null, null, null), TextCompare: false))
						{
							num2--;
						}
						if (num2 > 0)
						{
							if (num2 == 12)
							{
								num2 = 11L;
							}
							if (num2 > 12)
							{
								num2 -= 12;
							}
							text = num + "." + num2 + "m";
							Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString((double)num + Math.Round((double)num2 / 12.0, 1)));
						}
						else
						{
							text = num.ToString();
							Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString(num));
						}
					}
				}
			}
			catch (FormatException ex)
			{
				ProjectData.SetProjectError(ex);
				FormatException ex2 = ex;
				text = "";
				Interaction.SaveSetting("Health", "Person", "Age", Conversions.ToString(0));
				ProjectData.ClearProjectError();
			}
			return text;
		}
	}

	public object GetAgeFromRef(object RefDate)
	{
		string text = "";
		checked
		{
			try
			{
				long num = DateAndTime.DateDiff(DateInterval.Year, Conversions.ToDate(RefDate), DateAndTime.Now);
				long num2 = DateAndTime.DateDiff(DateInterval.Month, Conversions.ToDate(RefDate), DateAndTime.Now);
				if (DateAndTime.DateDiff(DateInterval.Month, Conversions.ToDate(RefDate), DateAndTime.Now) <= 12)
				{
					num = DateAndTime.DateDiff(DateInterval.Month, Conversions.ToDate(RefDate), DateAndTime.Now);
					if (Operators.ConditionalCompareObjectGreater(DateAndTime.Now.Day, NewLateBinding.LateGet(RefDate, null, "Day", new object[0], null, null, null), TextCompare: false))
					{
						num--;
					}
					if (num == 12)
					{
						text = Conversions.ToString(1);
						Interaction.SaveSetting("Health", "Person", "Referral", Conversions.ToString(1));
					}
					else
					{
						text = num.ToString();
						Interaction.SaveSetting("Health", "Person", "Referral", Conversions.ToString(12.0 / (double)num));
					}
				}
				else
				{
					num = DateAndTime.DateDiff(DateInterval.Year, Conversions.ToDate(RefDate), DateAndTime.Now);
					if (Operators.ConditionalCompareObjectGreaterEqual(DateAndTime.Now.Month, NewLateBinding.LateGet(RefDate, null, "Month", new object[0], null, null, null), TextCompare: false))
					{
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(DateAndTime.Now.Day, NewLateBinding.LateGet(RefDate, null, "Day", new object[0], null, null, null), TextCompare: false), num > 1)))
						{
							num--;
							num2 -= num * 12;
							if (Operators.ConditionalCompareObjectLess(DateAndTime.Now.Day, NewLateBinding.LateGet(RefDate, null, "Day", new object[0], null, null, null), TextCompare: false))
							{
								num2--;
							}
							if (num2 > 0)
							{
								if (num2 == 12)
								{
									num2 = 11L;
								}
								if (num2 > 12)
								{
									num2 -= 12;
								}
								text = num + "." + num2;
								Interaction.SaveSetting("Health", "Person", "Ref", Conversions.ToString((double)num + Math.Round((double)num2 / 12.0, 1)));
							}
							else
							{
								text = num.ToString();
								Interaction.SaveSetting("Health", "Person", "Ref", Conversions.ToString(num));
							}
							Interaction.SaveSetting("Health", "Person", "Ref", Conversions.ToString((double)num + Math.Round((double)num2 / 12.0, 1)));
						}
						else
						{
							num2 -= num * 12;
							if (Operators.ConditionalCompareObjectLess(DateAndTime.Now.Day, NewLateBinding.LateGet(RefDate, null, "Day", new object[0], null, null, null), TextCompare: false))
							{
								num2--;
							}
							if (num2 > 0)
							{
								if (num2 == 12)
								{
									num2 = 11L;
								}
								if (num2 > 12)
								{
									num2 -= 12;
								}
								text = num + "." + num2;
								Interaction.SaveSetting("Health", "Person", "Ref", Conversions.ToString((double)num + Math.Round((double)num2 / 12.0, 1)));
							}
							else
							{
								text = num.ToString();
								Interaction.SaveSetting("Health", "Person", "Ref", Conversions.ToString(num));
							}
						}
					}
					else
					{
						num--;
						num2 -= num * 12;
						if (Operators.ConditionalCompareObjectLess(DateAndTime.Now.Day, NewLateBinding.LateGet(RefDate, null, "Day", new object[0], null, null, null), TextCompare: false))
						{
							num2--;
						}
						if (num2 > 0)
						{
							if (num2 == 12)
							{
								num2 = 11L;
							}
							if (num2 > 12)
							{
								num2 -= 12;
							}
							text = num + "." + num2 + "m";
							Interaction.SaveSetting("Health", "Person", "Ref", Conversions.ToString((double)num + Math.Round((double)num2 / 12.0, 1)));
						}
						else
						{
							text = num.ToString();
							Interaction.SaveSetting("Health", "Person", "Ref", Conversions.ToString(num));
						}
					}
				}
			}
			catch (FormatException ex)
			{
				ProjectData.SetProjectError(ex);
				FormatException ex2 = ex;
				text = "";
				Interaction.SaveSetting("Health", "Person", "Ref", Conversions.ToString(0));
				ProjectData.ClearProjectError();
			}
			return text;
		}
	}

	public float BasalMetabolicRate()
	{
		string setting = Interaction.GetSetting("Health", "Person", "Age", Conversions.ToString(0));
		string setting2 = Interaction.GetSetting("Health", "Person", "Sex", "M");
		string setting3 = Interaction.GetSetting("Health", "Person", "Height", Conversions.ToString(0));
		string setting4 = Interaction.GetSetting("Health", "Person", "Weight", Conversions.ToString(0));
		float num = ((Operators.CompareString(setting2, "M", TextCompare: false) != 0) ? ((float)(655.0955 + 1.8496 * Conversion.Val(setting3) + 9.5634 * Conversion.Val(setting4) - 4.6756 * Conversion.Val(setting))) : ((float)(66.473 + 5.0033 * Conversion.Val(setting3) + 13.7516 * Conversion.Val(setting4) - 6.755 * Conversion.Val(setting))));
		return (float)Math.Round(num, 0);
	}

	public object RestingMetabolicRate()
	{
		string setting = Interaction.GetSetting("Health", "Person", "Age", Conversions.ToString(0));
		string setting2 = Interaction.GetSetting("Health", "Person", "Sex", "M");
		string setting3 = Interaction.GetSetting("Health", "Person", "Height", Conversions.ToString(0));
		string setting4 = Interaction.GetSetting("Health", "Person", "Weight", Conversions.ToString(0));
		float num = ((Operators.CompareString(setting2, "Male", TextCompare: false) != 0) ? ((float)(10.0 * Conversion.Val(setting4) + 6.25 * Conversion.Val(setting3) - 5.0 * Conversion.Val(setting) - 161.0)) : ((float)(10.0 * Conversion.Val(setting4) + 6.25 * Conversion.Val(setting3) - 5.0 * Conversion.Val(setting) + 5.0)));
		num = (float)Math.Round(num, 0);
		return num;
	}

	public object BodyMassIndex()
	{
		float num = (float)(Conversion.Val(PersonHeightcm.Text) / 100.0);
		return Functions.NumberToString((float)Math.Round(Conversion.Val(PersonWeightkg.Text) / (double)(num * num), 2), 2);
	}

	private void ClearAll_Click(object sender, EventArgs e)
	{
		ClearAllInfo();
	}

	public void ClearAllInfo()
	{
		PersonNameChange("Text", "");
		BreedChange("Text", "");
		ImportantChange("Text", "");
		AnimalNameChange("Text", "");
		IDChange("Text", "");
		PostCodeChange("Text", "");
		HouseNoChange("Text", "");
		if (!MyProject.Forms.Display.TestInd)
		{
			ControlChange("WelcomeBox", "Text", MyProject.Forms.Display.TimeOfDayInd);
		}
		ControlChange("Person", "Text", MyProject.Forms.Display.TimeOfDayInd);
		DOBChange("Text", "");
		AgeChange("Text", "");
		ReferralEndChange("Text", "");
		PersonHeightcmChange("Text", "0");
		PersonSexChange("");
		PersonWeightkgChange("Text", "0");
		OptionMF1.Checked = false;
		OptionMF2.Checked = false;
	}

	public void AgeChange(string text, string texta)
	{
		try
		{
			if (Age.InvokeRequired)
			{
				SetSTRCallback method = AgeChange;
				Invoke(method, text, texta);
			}
			else if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				Age.Text = texta;
			}
			else if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					Age.Visible = false;
				}
				else
				{
					Age.Visible = true;
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

	private void DOBYear_SelectedIndexChanged(object sender, EventArgs e)
	{
		DOBSet();
	}

	private void DOBMonth_SelectedIndexChanged(object sender, EventArgs e)
	{
		DOBSet();
	}

	private void DOBDay_SelectedIndexChanged(object sender, EventArgs e)
	{
		DOBSet();
	}

	private void DOBSet()
	{
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		try
		{
			if ((Conversion.Val(RuntimeHelpers.GetObjectValue(DOBYear.SelectedItem)) > 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(DOBMonth.SelectedItem)) > 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(DOBDay.SelectedItem)) > 0.0))
			{
				string format = "dd/MM/yyyy";
				DateTime dateTime = DateTime.ParseExact(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DOBDay.SelectedItem, "/"), DOBMonth.SelectedItem), "/"), DOBYear.SelectedItem)), format, invariantCulture);
				long num = DateAndTime.DateDiff(DateInterval.Year, dateTime, DateAndTime.Now);
				string texta = Conversions.ToString(GetAgeFromDOB(dateTime));
				AgeChange("Text", texta);
				ControlAChange("Person", "DOB", "Text", Conversions.ToString(dateTime));
				ControlAChange("Person", "DOB", "Visible", Conversions.ToString(Value: true));
				ControlAChange("Person", "DOBLabel", "Visible", Conversions.ToString(Value: true));
				ControlAChange("Person", "AgeLabel", "Visible", Conversions.ToString(Value: true));
				ControlAChange("Person", "Age", "Visible", Conversions.ToString(Value: true));
				ControlAChange("Person", "DOBDay", "Visible", Conversions.ToString(Value: false));
				ControlAChange("Person", "DOBMonth", "Visible", Conversions.ToString(Value: false));
				ControlAChange("Person", "DOBYear", "Visible", Conversions.ToString(Value: false));
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Functions.RegUpdate("Dtread", "Treadmill", "SendC", Functions.RegUpdate("Dtread", "Treadmill", "SendC", "", "Get") + ",DOB" + DOB.Text, "Save");
				}
				PersonHealthCheck();
				MyProject.Forms.Display.CustomerListUpdateRequired = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PersonNameChange(string text, string texta)
	{
		try
		{
			if (PersonName.InvokeRequired)
			{
				SetSTRCallback method = PersonNameChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				PersonName.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					PersonName.Visible = false;
				}
				else
				{
					PersonName.Visible = true;
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
					PersonName.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				PersonName.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void TrainerChange(string text, string texta)
	{
		try
		{
			if (Trainer.InvokeRequired)
			{
				SetSTRCallback method = TrainerChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				Trainer.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					Trainer.Visible = false;
				}
				else
				{
					Trainer.Visible = true;
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
					Trainer.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				Trainer.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void DOBChange(string text, string texta)
	{
		try
		{
			if (DOB.InvokeRequired)
			{
				SetSTRCallback method = DOBChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				DOB.Text = texta;
				DOBYearCollection();
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					DOB.Visible = false;
				}
				else
				{
					DOB.Visible = true;
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
					DOB.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				DOB.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void ReferralEndChange(string text, string texta)
	{
		try
		{
			if (ReferralEnd.InvokeRequired)
			{
				SetSTRCallback method = ReferralEndChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				ReferralEnd.Text = texta;
				RefYearCollection();
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					ReferralEnd.Visible = false;
				}
				else
				{
					ReferralEnd.Visible = true;
				}
			}
			if (Operators.CompareString(text, "TextAlign", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "Left", TextCompare: false) != 0)
				{
					if (Operators.CompareString(texta, "Center", TextCompare: false) == 0)
					{
						ReferralEnd.TextAlign = HorizontalAlignment.Center;
					}
				}
				else
				{
					ReferralEnd.TextAlign = HorizontalAlignment.Left;
				}
			}
			if (Operators.CompareString(text, "Color", TextCompare: false) != 0)
			{
				return;
			}
			if (Operators.CompareString(texta, "Red", TextCompare: false) != 0)
			{
				if (Operators.CompareString(texta, "Normal", TextCompare: false) == 0)
				{
					ReferralEnd.ForeColor = Color.Black;
				}
			}
			else
			{
				ReferralEnd.ForeColor = Color.Red;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void AnimalNameChange(string text, string texta)
	{
		try
		{
			if (AnimalName.InvokeRequired)
			{
				SetSTRCallback method = AnimalNameChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				AnimalName.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					AnimalName.Visible = false;
				}
				else
				{
					AnimalName.Visible = true;
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
					AnimalName.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				AnimalName.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void ImportantChange(string text, string texta)
	{
		try
		{
			if (Important.InvokeRequired)
			{
				SetSTRCallback method = ImportantChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				Important.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					Important.Visible = false;
				}
				else
				{
					Important.Visible = true;
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
					Important.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				Important.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PostCodeChange(string text, string texta)
	{
		try
		{
			if (PostCode.InvokeRequired)
			{
				SetSTRCallback method = PostCodeChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				PostCode.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					PostCode.Visible = false;
				}
				else
				{
					PostCode.Visible = true;
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
					PostCode.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				PostCode.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void HouseNoChange(string text, string texta)
	{
		try
		{
			if (HouseNo.InvokeRequired)
			{
				SetSTRCallback method = HouseNoChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				HouseNo.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					HouseNo.Visible = false;
				}
				else
				{
					HouseNo.Visible = true;
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
					HouseNo.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				HouseNo.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PersonHeightcmChange(string text, string texta)
	{
		try
		{
			if (PersonHeightcm.InvokeRequired)
			{
				SetSTRCallback method = PersonHeightcmChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				PersonHeightcm.Text = texta;
				if (ControlLevel == 0)
				{
					SetFeetInches();
				}
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					PersonHeightcm.Visible = false;
				}
				else
				{
					PersonHeightcm.Visible = true;
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
					PersonHeightcm.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				PersonHeightcm.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PersonHeightinChange(string text, string texta)
	{
		try
		{
			if (PersonHeightin.InvokeRequired)
			{
				SetSTRCallback method = PersonHeightinChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				PersonHeightin.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					PersonHeightin.Visible = false;
				}
				else
				{
					PersonHeightin.Visible = true;
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
					PersonHeightin.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				PersonHeightin.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PersonHeightftChange(string text, string texta)
	{
		try
		{
			if (PersonHeightft.InvokeRequired)
			{
				SetSTRCallback method = PersonHeightftChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				PersonHeightft.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					PersonHeightft.Visible = false;
				}
				else
				{
					PersonHeightft.Visible = true;
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
					PersonHeightft.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				PersonHeightft.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PersonWeightkgChange(string text, string texta)
	{
		try
		{
			if (PersonWeightkg.InvokeRequired)
			{
				SetSTRCallback method = PersonWeightkgChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				PersonWeightkg.Text = texta;
				if (ControlLevel == 0)
				{
					SetStonePounds();
				}
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					PersonWeightkg.Visible = false;
				}
				else
				{
					PersonWeightkg.Visible = true;
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
					PersonWeightkg.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				PersonWeightkg.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PersonWeightstChange(string text, string texta)
	{
		try
		{
			if (PersonWeightst.InvokeRequired)
			{
				SetSTRCallback method = PersonWeightstChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				PersonWeightst.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					PersonWeightst.Visible = false;
				}
				else
				{
					PersonWeightst.Visible = true;
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
					PersonWeightst.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				PersonWeightst.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void PersonWeightlbChange(string text, string texta)
	{
		try
		{
			if (PersonWeightlb.InvokeRequired)
			{
				SetSTRCallback method = PersonWeightlbChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				PersonWeightlb.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					PersonWeightlb.Visible = false;
				}
				else
				{
					PersonWeightlb.Visible = true;
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
					PersonWeightlb.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				PersonWeightlb.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void BreedChange(string text, string texta)
	{
		try
		{
			if (Breed.InvokeRequired)
			{
				SetSTRCallback method = BreedChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				Breed.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					Breed.Visible = false;
				}
				else
				{
					Breed.Visible = true;
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
					Breed.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				Breed.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void IDChange(string text, string texta)
	{
		try
		{
			if (ID.InvokeRequired)
			{
				SetSTRCallback method = IDChange;
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				ID.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					ID.Visible = false;
				}
				else
				{
					ID.Visible = true;
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
					ID.TextAlign = HorizontalAlignment.Center;
				}
			}
			else
			{
				ID.TextAlign = HorizontalAlignment.Left;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void HeightToCm()
	{
		float num = default(float);
		if (Conversion.Val(PersonHeightft.Text) > 0.0)
		{
			num = (float)(Conversion.Val(PersonHeightft.Text) * 30.48);
		}
		if (Conversion.Val(PersonHeightin.Text) > 0.0)
		{
			num = (float)((double)num + Conversion.Val(PersonHeightin.Text) * 2.54);
		}
		PersonHeightcmChange("Text", ((float)Math.Round(num, 1)).ToString());
	}

	private void WeightToKg()
	{
		float num = default(float);
		if (Conversion.Val(PersonWeightst.Text) > 0.0)
		{
			num = (float)(Conversion.Val(PersonWeightst.Text) * 6.35029);
		}
		if (Conversion.Val(PersonWeightlb.Text) > 0.0)
		{
			num = (float)((double)num + Conversion.Val(PersonWeightlb.Text) / 2.204622);
		}
		PersonWeightkgChange("Text", ((float)Math.Round(num, 1)).ToString());
	}

	private void SetFeetInches()
	{
		double num = default(double);
		if (Conversion.Val(PersonHeightcm.Text) > 0.0)
		{
			num = Conversion.Val(PersonHeightcm.Text) / 30.48;
		}
		checked
		{
			short num2 = (short)Math.Round(Math.Round(num, 0));
			if ((double)num2 > num)
			{
				num2--;
			}
			short num3 = (short)Math.Round(12.0 * (num - (double)num2));
			if (num3 == 12)
			{
				num3 = 0;
				num2++;
			}
			PersonHeightftChange("Text", num2.ToString());
			PersonHeightinChange("Text", num3.ToString());
		}
	}

	private void SetStonePounds()
	{
		double num = default(double);
		if (Conversion.Val(PersonWeightkg.Text) > 0.0)
		{
			num = Conversion.Val(PersonWeightkg.Text) * 0.157473;
		}
		checked
		{
			short num2 = (short)Math.Round(Math.Round(num, 0));
			if ((double)num2 > num)
			{
				num2--;
			}
			short num3 = (short)Math.Round(14.0 * (num - (double)num2));
			if (num3 == 14)
			{
				num3 = 0;
				num2++;
			}
			PersonWeightstChange("Text", num2.ToString());
			PersonWeightlbChange("Text", num3.ToString());
		}
	}

	public void RAMChange(string text, string texta)
	{
		try
		{
			if (MemoryStick.InvokeRequired)
			{
				SetIntCallback method = [SpecialName] [DebuggerHidden] (int a0, string a1) =>
				{
					RAMChange(Conversions.ToString(a0), a1);
				};
				Invoke(method, text, texta);
				return;
			}
			if (Operators.CompareString(text, "Text", TextCompare: false) == 0)
			{
				MemoryStick.Text = texta;
			}
			if (Operators.CompareString(text, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(texta, "False", TextCompare: false) == 0)
				{
					MemoryStick.Visible = false;
				}
				else
				{
					MemoryStick.Visible = true;
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
					MemoryStick.TextAlign = ContentAlignment.TopCenter;
				}
			}
			else
			{
				MemoryStick.TextAlign = (ContentAlignment)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void BMI_Click(object sender, EventArgs e)
	{
		ControlChange("Info", "Text", Conversions.ToString(Functions.InformationPrint("30")));
		InformationTM.Enabled = true;
		MyProject.Forms.Display.ControlChange("PersonEdit", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void BMIVisableTM_Tick(object sender, EventArgs e)
	{
		MyProject.Forms.Display.ControlChange("Info", "Text", Conversions.ToString(Functions.InformationPrint("30")));
		InformationTM.Enabled = true;
		ControlBChange("Person", "HealthInd", "BMI", "Visible", "False");
		ControlBChange("Person", "HealthInd", "BMIDescription", "Visible", "False");
		BMIVisableTM.Dispose();
	}

	private void BMIInd_Click(object sender, EventArgs e)
	{
		ControlBChange("Person", "HealthInd", "BMI", "Visible ", "True");
		ControlBChange("Person", "HealthInd", "BMIDescription", "Visible ", "True");
		BMIVisableTM.Enabled = true;
	}

	public void BMRChange(string text, string texta)
	{
		try
		{
			if (BMR.InvokeRequired)
			{
				SetSTRCallback method = BMRChange;
				Invoke(method, text, texta);
			}
			else
			{
				if (Operators.CompareString(text, "TextAlign", TextCompare: false) != 0)
				{
					return;
				}
				if (Operators.CompareString(texta, "Left", TextCompare: false) != 0)
				{
					if (Operators.CompareString(texta, "Center", TextCompare: false) == 0)
					{
						BMR.TextAlign = ContentAlignment.TopCenter;
					}
				}
				else
				{
					BMR.TextAlign = (ContentAlignment)0;
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

	public void RMRChange(string text, string texta)
	{
		try
		{
			if (RMR.InvokeRequired)
			{
				SetSTRCallback method = RMRChange;
				Invoke(method, text, texta);
			}
			else
			{
				if (Operators.CompareString(text, "TextAlign", TextCompare: false) != 0)
				{
					return;
				}
				if (Operators.CompareString(texta, "Left", TextCompare: false) != 0)
				{
					if (Operators.CompareString(texta, "Center", TextCompare: false) == 0)
					{
						RMR.TextAlign = ContentAlignment.TopCenter;
					}
				}
				else
				{
					RMR.TextAlign = (ContentAlignment)0;
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

	public void BMIChange(string text, string texta)
	{
		try
		{
			if (BMI.InvokeRequired)
			{
				SetSTRCallback method = BMIChange;
				Invoke(method, text, texta);
			}
			else
			{
				if (Operators.CompareString(text, "TextAlign", TextCompare: false) != 0)
				{
					return;
				}
				if (Operators.CompareString(texta, "Left", TextCompare: false) != 0)
				{
					if (Operators.CompareString(texta, "Center", TextCompare: false) == 0)
					{
						BMI.TextAlign = ContentAlignment.TopCenter;
					}
				}
				else
				{
					BMI.TextAlign = (ContentAlignment)0;
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

	public void BMIDescriptionChange(string text, string texta)
	{
		try
		{
			if (BMIDescription.InvokeRequired)
			{
				SetSTRCallback method = BMIDescriptionChange;
				Invoke(method, text, texta);
			}
			else
			{
				if (Operators.CompareString(text, "TextAlign", TextCompare: false) != 0)
				{
					return;
				}
				if (Operators.CompareString(texta, "Left", TextCompare: false) != 0)
				{
					if (Operators.CompareString(texta, "Center", TextCompare: false) == 0)
					{
						BMIDescription.TextAlign = ContentAlignment.TopCenter;
					}
				}
				else
				{
					BMIDescription.TextAlign = (ContentAlignment)0;
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

	private void InformationTM_Tick(object sender, EventArgs e)
	{
		InformationTM.Dispose();
		MyProject.Forms.Display.ControlChange("Info", "Text", HoldInfo);
	}

	private void BMILabel_Click(object sender, EventArgs e)
	{
		ControlChange("Info", "Text", Conversions.ToString(Functions.InformationPrint("30")));
		InformationTM.Enabled = true;
		ControlBChange("Person", "HealthInd", "BMI", "Visible", "True");
		ControlBChange("Person", "HealthInd", "BMIDescription", "Visible", "True");
	}

	private void BMIDescription_GotFocus(object sender, EventArgs e)
	{
		ControlChange("PersonEdit", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void BMRLabel_Click(object sender, EventArgs e)
	{
		HoldInfo = MyProject.Forms.Display.Info.Text;
		MyProject.Forms.Display.ControlChange("Info", "Text", Conversions.ToString(Functions.InformationPrint("6")));
		InformationTM.Enabled = true;
	}

	private void BMR_Click(object sender, EventArgs e)
	{
		HoldInfo = MyProject.Forms.Display.Info.Text;
		MyProject.Forms.Display.ControlChange("Info", "Text", Conversions.ToString(Functions.InformationPrint("6")));
		InformationTM.Enabled = true;
	}

	private void Age_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "AgeLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void DOB_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "DOBLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void ReferralEnd_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "RefLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void AnimalName_GotFocus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "AnimalNameLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void ID_GotFocus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "IDLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void PostCode_GotFocus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "PostCodeLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void HouseNo_GotFocus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "PostCodeLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void Breed_GotFocus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "BreedLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void PersonHeightft_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "ftLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void PersonHeightin_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "inLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void PersonHeightcm_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "PersonHeightLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void Trainer_GotFocus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "TrainerLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void PersonName_GotFocus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "PersonNameLabel", "Focus", "Set");
		}
	}

	private void Important_GotFocus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "ImportantLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void PersonWeightkg_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "PersonWeightLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void PersonWeightst_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "stLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void PersonWeightlb_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "lbLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void OptionMF1_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "PersonNameLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void OptionMF2_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "PersonNameLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void RMR_Click(object sender, EventArgs e)
	{
		HoldInfo = MyProject.Forms.Display.Info.Text;
		MyProject.Forms.Display.ControlChange("Info", "Text", Conversions.ToString(Functions.InformationPrint("6")));
		InformationTM.Enabled = true;
	}

	private void RMR_GotFocus(object sender, EventArgs e)
	{
		ControlAChange("Person", "RMRLabel", "Focus", "Set");
		Display.DisplayOn = true;
	}

	private void RMRLabel_Click(object sender, EventArgs e)
	{
		HoldInfo = MyProject.Forms.Display.Info.Text;
		MyProject.Forms.Display.ControlChange("Info", "Text", Conversions.ToString(Functions.InformationPrint("6")));
		InformationTM.Enabled = true;
	}

	private void UpdateInformationTM_Tick(object sender, EventArgs e)
	{
		RAMInformation();
	}

	private void RAMInformation()
	{
		if (Conversions.ToBoolean(Interaction.GetSetting("Treadmill", "Health", "Net", Conversions.ToString(Value: false))))
		{
			RAMChange("Text", Interaction.GetSetting("Recording", "Running", "RAM"));
		}
		else
		{
			RAMChange("Text", "");
		}
	}

	private void Information_Activated(object sender, EventArgs e)
	{
		UpdateInformationTM.Enabled = true;
		if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
		{
			ControlAChange("Person", "ReferralEnd", "Visible", "False");
			ControlAChange("Person", "RefLabel", "Visible", "False");
		}
	}

	private void Information_Deactivate(object sender, EventArgs e)
	{
		UpdateInformationTM.Dispose();
	}

	private void Information_Focus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void Person_Focus(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "PersonNameLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void Person_Enter(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "PersonNameLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}

	private void Person_MouseHover(object sender, EventArgs e)
	{
		if (MyProject.Forms.InfoEnter.Visible)
		{
			MyProject.Forms.InfoEnter.ControlAChange("KeyPad", "Focus", "Set");
		}
		else
		{
			ControlAChange("Person", "PersonNameLabel", "Focus", "Set");
		}
		Display.DisplayOn = true;
	}
}
