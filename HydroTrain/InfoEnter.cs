using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HydroTrain.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class InfoEnter : Form
{
	public delegate void SetControl2Callback(string ControlName, string Data);

	public delegate void SetControl3Callback(string textA, string text, string textA);

	public delegate void SetControl4Callback(string text, string textA, string text, string textA);

	public delegate void MyIntNPChangedEventHandler(string newTOTNP_CLIP);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SpaceBar")]
	private Button _SpaceBar;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button27")]
	private Button _Button27;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button26")]
	private Button _Button26;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button25")]
	private Button _Button25;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button24")]
	private Button _Button24;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button23")]
	private Button _Button23;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button22")]
	private Button _Button22;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button21")]
	private Button _Button21;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button20")]
	private Button _Button20;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button19")]
	private Button _Button19;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button18")]
	private Button _Button18;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button17")]
	private Button _Button17;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button16")]
	private Button _Button16;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button15")]
	private Button _Button15;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button14")]
	private Button _Button14;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button13")]
	private Button _Button13;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button12")]
	private Button _Button12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

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
	[AccessedThroughProperty("Button28")]
	private Button _Button28;

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

	public static string PasswordSet;

	public static bool ControlKey;

	public bool CaseSet;

	public string Preload;

	public short CentreLocX;

	public short CentreLocY;

	public short LowLocY;

	public string InputText;

	public int HeightNorm;

	public int Extension;

	public int HeightExtended;

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

	private float ResMultiH;

	private float ResMultiW;

	[field: AccessedThroughProperty("KeyBoard")]
	internal virtual Panel KeyBoard
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button SpaceBar
	{
		[CompilerGenerated]
		get
		{
			return _SpaceBar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SpaceBar_Click;
			Button button = _SpaceBar;
			if (button != null)
			{
				button.Click -= value2;
			}
			_SpaceBar = value;
			button = _SpaceBar;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button27
	{
		[CompilerGenerated]
		get
		{
			return _Button27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button27;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button27 = value;
			button = _Button27;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button26
	{
		[CompilerGenerated]
		get
		{
			return _Button26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button26;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button26 = value;
			button = _Button26;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button25
	{
		[CompilerGenerated]
		get
		{
			return _Button25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button25;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button25 = value;
			button = _Button25;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button24
	{
		[CompilerGenerated]
		get
		{
			return _Button24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button24;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button24 = value;
			button = _Button24;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button23
	{
		[CompilerGenerated]
		get
		{
			return _Button23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button23;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button23 = value;
			button = _Button23;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button22
	{
		[CompilerGenerated]
		get
		{
			return _Button22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button22;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button22 = value;
			button = _Button22;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button21
	{
		[CompilerGenerated]
		get
		{
			return _Button21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button21;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button21 = value;
			button = _Button21;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button20
	{
		[CompilerGenerated]
		get
		{
			return _Button20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button20;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button20 = value;
			button = _Button20;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button19
	{
		[CompilerGenerated]
		get
		{
			return _Button19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button19;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button19 = value;
			button = _Button19;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button18
	{
		[CompilerGenerated]
		get
		{
			return _Button18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button18;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button18 = value;
			button = _Button18;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button17
	{
		[CompilerGenerated]
		get
		{
			return _Button17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button17;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button17 = value;
			button = _Button17;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button16
	{
		[CompilerGenerated]
		get
		{
			return _Button16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button16;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button16 = value;
			button = _Button16;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button15
	{
		[CompilerGenerated]
		get
		{
			return _Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button15;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button15 = value;
			button = _Button15;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button14
	{
		[CompilerGenerated]
		get
		{
			return _Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button14;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button14 = value;
			button = _Button14;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button13
	{
		[CompilerGenerated]
		get
		{
			return _Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button13;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button13 = value;
			button = _Button13;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button12
	{
		[CompilerGenerated]
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button12;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button12 = value;
			button = _Button12;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button11
	{
		[CompilerGenerated]
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button11;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button11 = value;
			button = _Button11;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button10
	{
		[CompilerGenerated]
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button10;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button10 = value;
			button = _Button10;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button9
	{
		[CompilerGenerated]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button9;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button9 = value;
			button = _Button9;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

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

	internal virtual Button Button28
	{
		[CompilerGenerated]
		get
		{
			return _Button28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button_Click;
			Button button = _Button28;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button28 = value;
			button = _Button28;
			if (button != null)
			{
				button.Click += value2;
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

	[field: AccessedThroughProperty("ShiftKey")]
	internal virtual Button ShiftKey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("KeyBoardText")]
	internal virtual Button KeyBoardText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public string TOTNP_CLIP
	{
		get
		{
			string result = default(string);
			return result;
		}
		set
		{
			if ((Strings.Len(value) > 0) & base.Visible)
			{
				ControlBChange("KeyBoard", "KeyBoardText", "Text", value);
				ControlBChange("KeyBoard", "KeyBoardText", "Visible", "True");
				base.Size = new Size(base.Width, HeightExtended);
			}
			MyIntNPChanged?.Invoke(value);
		}
	}

	public event MyIntNPChangedEventHandler MyIntNPChanged;

	public InfoEnter()
	{
		base.Activated += InfoEnter_Activated;
		base.Deactivate += InfoEnter_Deactivate;
		base.Load += InfoEnter_Load;
		base.KeyPress += Form1_KeyPress;
		base.KeyDown += Program_KeyDown;
		base.KeyUp += Program_KeyUp;
		Extension = 10;
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
		this.KeyBoard = new System.Windows.Forms.Panel();
		this.KeyBoardText = new System.Windows.Forms.Button();
		this.ShiftKey = new System.Windows.Forms.Button();
		this.Button28 = new System.Windows.Forms.Button();
		this.SpaceBar = new System.Windows.Forms.Button();
		this.Button27 = new System.Windows.Forms.Button();
		this.Button26 = new System.Windows.Forms.Button();
		this.Button25 = new System.Windows.Forms.Button();
		this.Button24 = new System.Windows.Forms.Button();
		this.Button23 = new System.Windows.Forms.Button();
		this.Button22 = new System.Windows.Forms.Button();
		this.Button21 = new System.Windows.Forms.Button();
		this.Button20 = new System.Windows.Forms.Button();
		this.Button19 = new System.Windows.Forms.Button();
		this.Button18 = new System.Windows.Forms.Button();
		this.Button17 = new System.Windows.Forms.Button();
		this.Button16 = new System.Windows.Forms.Button();
		this.Button15 = new System.Windows.Forms.Button();
		this.Button14 = new System.Windows.Forms.Button();
		this.Button13 = new System.Windows.Forms.Button();
		this.Button12 = new System.Windows.Forms.Button();
		this.Button11 = new System.Windows.Forms.Button();
		this.Button10 = new System.Windows.Forms.Button();
		this.Button9 = new System.Windows.Forms.Button();
		this.Button8 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
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
		this.KeyBoard.SuspendLayout();
		this.KeyPad.SuspendLayout();
		base.SuspendLayout();
		this.KeyBoard.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.KeyBoard.Controls.Add(this.KeyBoardText);
		this.KeyBoard.Controls.Add(this.ShiftKey);
		this.KeyBoard.Controls.Add(this.Button28);
		this.KeyBoard.Controls.Add(this.SpaceBar);
		this.KeyBoard.Controls.Add(this.Button27);
		this.KeyBoard.Controls.Add(this.Button26);
		this.KeyBoard.Controls.Add(this.Button25);
		this.KeyBoard.Controls.Add(this.Button24);
		this.KeyBoard.Controls.Add(this.Button23);
		this.KeyBoard.Controls.Add(this.Button22);
		this.KeyBoard.Controls.Add(this.Button21);
		this.KeyBoard.Controls.Add(this.Button20);
		this.KeyBoard.Controls.Add(this.Button19);
		this.KeyBoard.Controls.Add(this.Button18);
		this.KeyBoard.Controls.Add(this.Button17);
		this.KeyBoard.Controls.Add(this.Button16);
		this.KeyBoard.Controls.Add(this.Button15);
		this.KeyBoard.Controls.Add(this.Button14);
		this.KeyBoard.Controls.Add(this.Button13);
		this.KeyBoard.Controls.Add(this.Button12);
		this.KeyBoard.Controls.Add(this.Button11);
		this.KeyBoard.Controls.Add(this.Button10);
		this.KeyBoard.Controls.Add(this.Button9);
		this.KeyBoard.Controls.Add(this.Button8);
		this.KeyBoard.Controls.Add(this.Button7);
		this.KeyBoard.Controls.Add(this.Button6);
		this.KeyBoard.Controls.Add(this.Button5);
		this.KeyBoard.Controls.Add(this.Button4);
		this.KeyBoard.Controls.Add(this.Button3);
		this.KeyBoard.Controls.Add(this.Button2);
		this.KeyBoard.Controls.Add(this.Button1);
		this.KeyBoard.ForeColor = System.Drawing.Color.Black;
		this.KeyBoard.Location = new System.Drawing.Point(3, 3);
		this.KeyBoard.Name = "KeyBoard";
		this.KeyBoard.Size = new System.Drawing.Size(521, 263);
		this.KeyBoard.TabIndex = 3;
		this.KeyBoardText.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.KeyBoardText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.KeyBoardText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.KeyBoardText.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.KeyBoardText.ForeColor = System.Drawing.Color.Black;
		this.KeyBoardText.Location = new System.Drawing.Point(159, 7);
		this.KeyBoardText.Name = "KeyBoardText";
		this.KeyBoardText.Size = new System.Drawing.Size(201, 30);
		this.KeyBoardText.TabIndex = 59;
		this.KeyBoardText.Text = "_";
		this.KeyBoardText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.KeyBoardText.UseVisualStyleBackColor = false;
		this.ShiftKey.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.ShiftKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.ShiftKey.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ShiftKey.ForeColor = System.Drawing.SystemColors.ControlText;
		this.ShiftKey.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.ShiftKey.Location = new System.Drawing.Point(6, 204);
		this.ShiftKey.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.ShiftKey.Name = "ShiftKey";
		this.ShiftKey.Size = new System.Drawing.Size(78, 50);
		this.ShiftKey.TabIndex = 56;
		this.ShiftKey.Text = "shift";
		this.ShiftKey.UseVisualStyleBackColor = false;
		this.Button28.Location = new System.Drawing.Point(463, 203);
		this.Button28.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button28.Name = "Button28";
		this.Button28.Size = new System.Drawing.Size(50, 50);
		this.Button28.TabIndex = 58;
		this.Button28.Text = "-";
		this.Button28.UseVisualStyleBackColor = true;
		this.SpaceBar.Location = new System.Drawing.Point(134, 191);
		this.SpaceBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.SpaceBar.Name = "SpaceBar";
		this.SpaceBar.Size = new System.Drawing.Size(250, 50);
		this.SpaceBar.TabIndex = 56;
		this.SpaceBar.UseVisualStyleBackColor = true;
		this.Button27.Location = new System.Drawing.Point(409, 142);
		this.Button27.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button27.Name = "Button27";
		this.Button27.Size = new System.Drawing.Size(50, 50);
		this.Button27.TabIndex = 55;
		this.Button27.Text = "M";
		this.Button27.UseVisualStyleBackColor = true;
		this.Button26.Location = new System.Drawing.Point(359, 142);
		this.Button26.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button26.Name = "Button26";
		this.Button26.Size = new System.Drawing.Size(50, 50);
		this.Button26.TabIndex = 54;
		this.Button26.Text = "N";
		this.Button26.UseVisualStyleBackColor = true;
		this.Button25.Location = new System.Drawing.Point(309, 142);
		this.Button25.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button25.Name = "Button25";
		this.Button25.Size = new System.Drawing.Size(50, 50);
		this.Button25.TabIndex = 53;
		this.Button25.Text = "Q";
		this.Button25.UseVisualStyleBackColor = true;
		this.Button24.Location = new System.Drawing.Point(259, 142);
		this.Button24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button24.Name = "Button24";
		this.Button24.Size = new System.Drawing.Size(50, 50);
		this.Button24.TabIndex = 52;
		this.Button24.Text = "B";
		this.Button24.UseVisualStyleBackColor = true;
		this.Button23.Location = new System.Drawing.Point(209, 142);
		this.Button23.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button23.Name = "Button23";
		this.Button23.Size = new System.Drawing.Size(50, 50);
		this.Button23.TabIndex = 51;
		this.Button23.Text = "V";
		this.Button23.UseVisualStyleBackColor = true;
		this.Button22.Location = new System.Drawing.Point(159, 142);
		this.Button22.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button22.Name = "Button22";
		this.Button22.Size = new System.Drawing.Size(50, 50);
		this.Button22.TabIndex = 50;
		this.Button22.Text = "C";
		this.Button22.UseVisualStyleBackColor = true;
		this.Button21.Location = new System.Drawing.Point(109, 142);
		this.Button21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button21.Name = "Button21";
		this.Button21.Size = new System.Drawing.Size(50, 50);
		this.Button21.TabIndex = 49;
		this.Button21.Text = "X";
		this.Button21.UseVisualStyleBackColor = true;
		this.Button20.Location = new System.Drawing.Point(59, 142);
		this.Button20.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button20.Name = "Button20";
		this.Button20.Size = new System.Drawing.Size(50, 50);
		this.Button20.TabIndex = 48;
		this.Button20.Text = "Z";
		this.Button20.UseVisualStyleBackColor = true;
		this.Button19.Location = new System.Drawing.Point(434, 93);
		this.Button19.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button19.Name = "Button19";
		this.Button19.Size = new System.Drawing.Size(50, 50);
		this.Button19.TabIndex = 47;
		this.Button19.Text = "L";
		this.Button19.UseVisualStyleBackColor = true;
		this.Button18.Location = new System.Drawing.Point(384, 93);
		this.Button18.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button18.Name = "Button18";
		this.Button18.Size = new System.Drawing.Size(50, 50);
		this.Button18.TabIndex = 46;
		this.Button18.Text = "K";
		this.Button18.UseVisualStyleBackColor = true;
		this.Button17.Location = new System.Drawing.Point(334, 93);
		this.Button17.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button17.Name = "Button17";
		this.Button17.Size = new System.Drawing.Size(50, 50);
		this.Button17.TabIndex = 45;
		this.Button17.Text = "J";
		this.Button17.UseVisualStyleBackColor = true;
		this.Button16.Location = new System.Drawing.Point(284, 93);
		this.Button16.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button16.Name = "Button16";
		this.Button16.Size = new System.Drawing.Size(50, 50);
		this.Button16.TabIndex = 44;
		this.Button16.Text = "H";
		this.Button16.UseVisualStyleBackColor = true;
		this.Button15.Location = new System.Drawing.Point(234, 93);
		this.Button15.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button15.Name = "Button15";
		this.Button15.Size = new System.Drawing.Size(50, 50);
		this.Button15.TabIndex = 43;
		this.Button15.Text = "G";
		this.Button15.UseVisualStyleBackColor = true;
		this.Button14.Location = new System.Drawing.Point(184, 93);
		this.Button14.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button14.Name = "Button14";
		this.Button14.Size = new System.Drawing.Size(50, 50);
		this.Button14.TabIndex = 42;
		this.Button14.Text = "F";
		this.Button14.UseVisualStyleBackColor = true;
		this.Button13.Location = new System.Drawing.Point(134, 93);
		this.Button13.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button13.Name = "Button13";
		this.Button13.Size = new System.Drawing.Size(50, 50);
		this.Button13.TabIndex = 41;
		this.Button13.Text = "D";
		this.Button13.UseVisualStyleBackColor = true;
		this.Button12.Location = new System.Drawing.Point(84, 93);
		this.Button12.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button12.Name = "Button12";
		this.Button12.Size = new System.Drawing.Size(50, 50);
		this.Button12.TabIndex = 40;
		this.Button12.Text = "S";
		this.Button12.UseVisualStyleBackColor = true;
		this.Button11.Location = new System.Drawing.Point(34, 93);
		this.Button11.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button11.Name = "Button11";
		this.Button11.Size = new System.Drawing.Size(50, 50);
		this.Button11.TabIndex = 39;
		this.Button11.Text = "A";
		this.Button11.UseVisualStyleBackColor = true;
		this.Button10.Location = new System.Drawing.Point(459, 43);
		this.Button10.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(50, 50);
		this.Button10.TabIndex = 38;
		this.Button10.Text = "P";
		this.Button10.UseVisualStyleBackColor = true;
		this.Button9.Location = new System.Drawing.Point(409, 43);
		this.Button9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(50, 50);
		this.Button9.TabIndex = 37;
		this.Button9.Text = "O";
		this.Button9.UseVisualStyleBackColor = true;
		this.Button8.Location = new System.Drawing.Point(359, 43);
		this.Button8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(50, 50);
		this.Button8.TabIndex = 36;
		this.Button8.Text = "I";
		this.Button8.UseVisualStyleBackColor = true;
		this.Button7.Location = new System.Drawing.Point(309, 43);
		this.Button7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(50, 50);
		this.Button7.TabIndex = 35;
		this.Button7.Text = "U";
		this.Button7.UseVisualStyleBackColor = true;
		this.Button6.Location = new System.Drawing.Point(259, 43);
		this.Button6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(50, 50);
		this.Button6.TabIndex = 34;
		this.Button6.Text = "Y";
		this.Button6.UseVisualStyleBackColor = true;
		this.Button5.Location = new System.Drawing.Point(209, 43);
		this.Button5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(50, 50);
		this.Button5.TabIndex = 33;
		this.Button5.Text = "T";
		this.Button5.UseVisualStyleBackColor = true;
		this.Button4.Location = new System.Drawing.Point(159, 43);
		this.Button4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(50, 50);
		this.Button4.TabIndex = 32;
		this.Button4.Text = "R";
		this.Button4.UseVisualStyleBackColor = true;
		this.Button3.Location = new System.Drawing.Point(109, 43);
		this.Button3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(50, 50);
		this.Button3.TabIndex = 31;
		this.Button3.Text = "E";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(59, 43);
		this.Button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(50, 50);
		this.Button2.TabIndex = 30;
		this.Button2.Text = "W";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button1.Location = new System.Drawing.Point(9, 43);
		this.Button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(50, 50);
		this.Button1.TabIndex = 29;
		this.Button1.Text = "Q";
		this.Button1.UseVisualStyleBackColor = true;
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
		this.KeyPad.Location = new System.Drawing.Point(523, 3);
		this.KeyPad.Name = "KeyPad";
		this.KeyPad.Size = new System.Drawing.Size(240, 263);
		this.KeyPad.TabIndex = 4;
		this.EnterKey.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.EnterKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.EnterKey.Cursor = System.Windows.Forms.Cursors.Cross;
		this.EnterKey.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EnterKey.Location = new System.Drawing.Point(10, 156);
		this.EnterKey.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.EnterKey.Name = "EnterKey";
		this.EnterKey.Size = new System.Drawing.Size(59, 83);
		this.EnterKey.TabIndex = 55;
		this.EnterKey.Text = "ENT";
		this.EnterKey.UseVisualStyleBackColor = false;
		this.CLR.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.CLR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.CLR.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CLR.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.CLR.Location = new System.Drawing.Point(8, 100);
		this.CLR.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.CLR.Name = "CLR";
		this.CLR.Size = new System.Drawing.Size(61, 50);
		this.CLR.TabIndex = 54;
		this.CLR.Text = "CLR";
		this.CLR.UseVisualStyleBackColor = false;
		this.DEL.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.DEL.BackgroundImage = HydroTrain.My.Resources.Resources.BackSpace;
		this.DEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.DEL.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DEL.ImageAlign = System.Drawing.ContentAlignment.TopRight;
		this.DEL.Location = new System.Drawing.Point(8, 41);
		this.DEL.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.DEL.Name = "DEL";
		this.DEL.Size = new System.Drawing.Size(61, 50);
		this.DEL.TabIndex = 53;
		this.DEL.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.DEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.DEL.UseVisualStyleBackColor = false;
		this.Button39.Location = new System.Drawing.Point(183, 41);
		this.Button39.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button39.Name = "Button39";
		this.Button39.Size = new System.Drawing.Size(50, 50);
		this.Button39.TabIndex = 52;
		this.Button39.Text = "9";
		this.Button39.UseVisualStyleBackColor = true;
		this.Button38.Location = new System.Drawing.Point(133, 41);
		this.Button38.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button38.Name = "Button38";
		this.Button38.Size = new System.Drawing.Size(50, 50);
		this.Button38.TabIndex = 51;
		this.Button38.Text = "8";
		this.Button38.UseVisualStyleBackColor = true;
		this.Button37.Location = new System.Drawing.Point(83, 41);
		this.Button37.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button37.Name = "Button37";
		this.Button37.Size = new System.Drawing.Size(50, 50);
		this.Button37.TabIndex = 50;
		this.Button37.Text = "7";
		this.Button37.UseVisualStyleBackColor = true;
		this.Button36.Location = new System.Drawing.Point(183, 91);
		this.Button36.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button36.Name = "Button36";
		this.Button36.Size = new System.Drawing.Size(50, 50);
		this.Button36.TabIndex = 49;
		this.Button36.Text = "6";
		this.Button36.UseVisualStyleBackColor = true;
		this.Button35.Location = new System.Drawing.Point(133, 91);
		this.Button35.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button35.Name = "Button35";
		this.Button35.Size = new System.Drawing.Size(50, 50);
		this.Button35.TabIndex = 48;
		this.Button35.Text = "5";
		this.Button35.UseVisualStyleBackColor = true;
		this.Button34.Location = new System.Drawing.Point(83, 91);
		this.Button34.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button34.Name = "Button34";
		this.Button34.Size = new System.Drawing.Size(50, 50);
		this.Button34.TabIndex = 47;
		this.Button34.Text = "4";
		this.Button34.UseVisualStyleBackColor = true;
		this.Button33.Location = new System.Drawing.Point(183, 140);
		this.Button33.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button33.Name = "Button33";
		this.Button33.Size = new System.Drawing.Size(50, 50);
		this.Button33.TabIndex = 46;
		this.Button33.Text = "3";
		this.Button33.UseVisualStyleBackColor = true;
		this.Button32.Location = new System.Drawing.Point(83, 140);
		this.Button32.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button32.Name = "Button32";
		this.Button32.Size = new System.Drawing.Size(50, 50);
		this.Button32.TabIndex = 45;
		this.Button32.Text = "1";
		this.Button32.UseVisualStyleBackColor = true;
		this.Button31.Location = new System.Drawing.Point(133, 140);
		this.Button31.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button31.Name = "Button31";
		this.Button31.Size = new System.Drawing.Size(50, 50);
		this.Button31.TabIndex = 44;
		this.Button31.Text = "2";
		this.Button31.UseVisualStyleBackColor = true;
		this.Button30.Location = new System.Drawing.Point(183, 191);
		this.Button30.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Button30.Name = "Button30";
		this.Button30.Size = new System.Drawing.Size(50, 50);
		this.Button30.TabIndex = 43;
		this.Button30.Text = ".";
		this.Button30.UseVisualStyleBackColor = true;
		this.Button29.Location = new System.Drawing.Point(83, 191);
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(13f, 25f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		base.ClientSize = new System.Drawing.Size(765, 268);
		base.Controls.Add(this.KeyPad);
		base.Controls.Add(this.KeyBoard);
		this.Font = new System.Drawing.Font("Verdana", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.KeyPreview = true;
		base.Location = new System.Drawing.Point(420, 545);
		base.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
		base.Name = "InfoEnter";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "InfoEnter";
		base.TopMost = true;
		base.TransparencyKey = System.Drawing.Color.FromArgb(128, 128, 255);
		this.KeyBoard.ResumeLayout(false);
		this.KeyPad.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void InfoEnter_Activated(object sender, EventArgs e)
	{
		if (!CursorFlash.Enabled)
		{
			InputText = Preload;
			CursorFlash.Enabled = true;
			FlashCursor = true;
		}
		ControlKey = true;
	}

	private void InfoEnter_Deactivate(object sender, EventArgs e)
	{
		ControlLevel = 0;
	}

	private void InfoEnter_Load(object sender, EventArgs e)
	{
		ResMultiH = Display.ResMultiH;
		ResMultiW = Display.ResMultiW;
		if ((double)Screen.PrimaryScreen.Bounds.Height / (double)Screen.PrimaryScreen.Bounds.Width >= 0.75)
		{
			ResMultiW = ResMultiH;
		}
		KeyboardAdjust();
		checked
		{
			CentreLocX = (short)Math.Round((double)(Screen.PrimaryScreen.Bounds.Width - base.Bounds.Width) / 2.0);
			CentreLocY = (short)Math.Round((double)(Screen.PrimaryScreen.Bounds.Height - base.Bounds.Height) / 2.0 - 90.0);
			LowLocY = (short)(CentreLocY * 2);
			SetLocation(CentreLocX, CentreLocY);
		}
	}

	public void SetLocation(object LocX, object LocY)
	{
		base.Location = new Point(Conversions.ToInteger(LocX), Conversions.ToInteger(LocY));
	}

	private void KeyboardAdjust()
	{
		int num = base.Height;
		int num2 = base.Width;
		checked
		{
			base.Size = new Size((int)Math.Round((float)num2 * ResMultiW), (int)Math.Round((float)num * ResMultiH));
			Resolution("KeyBoard", "");
			Resolution("KeyPad", "");
			int num3 = 1;
			do
			{
				Resolution("Button" + num3, "KeyBoard");
				num3++;
			}
			while (num3 <= 28);
			num3 = 29;
			do
			{
				Resolution("Button" + num3, "KeyPad");
				num3++;
			}
			while (num3 <= 39);
			Resolution("CLR", "KeyPad");
			Resolution("Del", "KeyPad");
			Resolution("EnterKey", "KeyPad");
			Resolution("SpaceBar", "KeyBoard");
			Resolution("ShiftKey", "KeyBoard");
			Resolution("KeyBoardText", "KeyBoard");
			HeightExtended = base.Height;
			HeightNorm = Extension + (ShiftKey.Height + ShiftKey.Location.Y);
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
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainer].Controls[ControlName].Font.Size * ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Height * ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Width * ResMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Top * ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Left * ResMultiW);
					}
					else if (ResMultiW < ResMultiH)
					{
						float resMultiW = ResMultiW;
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainer].Controls[ControlName].Font.Size * resMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Height * resMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Width * resMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Top * resMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Left * resMultiW);
					}
					else
					{
						base.Controls[ControlContainer].Controls[ControlName].Font = new Font(base.Controls[ControlContainer].Controls[ControlName].Font.FontFamily, base.Controls[ControlContainer].Controls[ControlName].Font.Size / ResMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Height * ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Width / ResMultiW);
						base.Controls[ControlContainer].Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Top * ResMultiH);
						base.Controls[ControlContainer].Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlContainer].Controls[ControlName].Left / ResMultiW);
					}
				}
				else if (base.Controls[ControlName].InvokeRequired)
				{
					SetControl2Callback method2 = Resolution;
					Invoke(method2, ControlName, ControlContainer);
				}
				else if (!Display.ScreenType)
				{
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, base.Controls[ControlName].Font.Size * ResMultiH);
					base.Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlName].Height * ResMultiH);
					base.Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlName].Width * ResMultiW);
					base.Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlName].Top * ResMultiH);
					base.Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlName].Left * ResMultiW);
				}
				else if (ResMultiW < ResMultiH)
				{
					float resMultiW2 = ResMultiW;
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, base.Controls[ControlName].Font.Size * resMultiW2);
					base.Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlName].Height * resMultiW2);
					base.Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlName].Width * resMultiW2);
					base.Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlName].Top * resMultiW2);
					base.Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlName].Left * resMultiW2);
				}
				else
				{
					base.Controls[ControlName].Font = new Font(base.Controls[ControlName].Font.FontFamily, base.Controls[ControlName].Font.Size / ResMultiH);
					base.Controls[ControlName].Height = (int)Math.Round((float)base.Controls[ControlName].Height * ResMultiH);
					base.Controls[ControlName].Width = (int)Math.Round((float)base.Controls[ControlName].Width / ResMultiW);
					base.Controls[ControlName].Top = (int)Math.Round((float)base.Controls[ControlName].Top * ResMultiH);
					base.Controls[ControlName].Left = (int)Math.Round((float)base.Controls[ControlName].Left / ResMultiW);
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
			InputText = "";
		}
		base.Size = new Size(base.Width, HeightNorm);
		ControlBChange("KeyBoard", "KeyBoardText", "Text", " ");
		ControlBChange("KeyBoard", "KeyBoardText", "Visible", "False");
		base.Visible = false;
		ControlKey = false;
	}

	private void CLR_Click(object sender, EventArgs e)
	{
		CLR_Opp();
	}

	private void CLR_Opp()
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
		DEL_Opp();
	}

	private void DEL_Opp()
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
		if (Strings.Len(InputText) < 50)
		{
			string name = button.Name;
			int num = checked((int)Math.Round(Conversion.Val(Strings.Mid(name, 7, Strings.Len(name) - 6))));
			if (num > 28)
			{
				UpdateInputText(base.Controls["KeyPad"].Controls["Button" + num].Text);
				base.Controls["KeyPad"].Controls["Button" + Conversions.ToString(num)].Enabled = false;
			}
			else
			{
				UpdateInputText(base.Controls["KeyBoard"].Controls["Button" + num].Text);
				base.Controls["KeyBoard"].Controls["Button" + Conversions.ToString(num)].Enabled = false;
			}
			ButtonNumberHold = num;
			DoubleTouchSlow.Enabled = true;
		}
	}

	private void UpdateInputText(object InputChar)
	{
		CursorDel();
		InputText = Conversions.ToString(Operators.AddObject(InputText, InputChar));
		PasswordSet = InputText;
	}

	private void ButtonNumberReset()
	{
		if (ButtonNumberHold > 0)
		{
			if (ButtonNumberHold > 28)
			{
				base.Controls["KeyPad"].Controls["Button" + Conversions.ToString(ButtonNumberHold)].Enabled = true;
				ControlAChange("KeyPad", "Button" + Conversions.ToString(ButtonNumberHold), "Focus");
			}
			else
			{
				base.Controls["KeyBoard"].Controls["Button" + Conversions.ToString(ButtonNumberHold)].Enabled = true;
				ControlAChange("KeyBoard", "Button" + Conversions.ToString(ButtonNumberHold), "Focus");
			}
		}
	}

	private void SpaceBar_Click(object sender, EventArgs e)
	{
		SpaceBar_Opp();
	}

	private void SpaceBar_Opp()
	{
		UpdateInputText(' ');
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

	public void TextAlignChange(string Control, string Data)
	{
		if (ShiftKey.InvokeRequired)
		{
			SetControl2Callback method = TextAlignChange;
			Invoke(method, Data, Control);
		}
		else if (Operators.CompareString(Control, "ShiftKey", TextCompare: false) == 0)
		{
			switch (Data)
			{
			case "Left":
				ShiftKey.TextAlign = (ContentAlignment)0;
				break;
			case "Center":
				ShiftKey.TextAlign = ContentAlignment.TopCenter;
				break;
			case "Right":
				ShiftKey.TextAlign = ContentAlignment.TopLeft;
				break;
			}
		}
	}

	private void Form1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			EnterKeyPress();
		}
		else if (e.KeyChar == ' ')
		{
			SpaceBar_Opp();
		}
		else if (e.KeyChar == '\b')
		{
			DEL_Opp();
		}
		else if (((Strings.Asc(e.KeyChar) > 47) & (Strings.Asc(e.KeyChar) < 58)) | ((Strings.Asc(e.KeyChar) > 64) & (Strings.Asc(e.KeyChar) < 91)) | ((Strings.Asc(e.KeyChar) > 96) & (Strings.Asc(e.KeyChar) < 123)) | (Strings.Asc(e.KeyChar) == 45) | (Strings.Asc(e.KeyChar) == 46))
		{
			UpdateInputText(e.KeyChar);
		}
	}

	private void Program_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Delete)
		{
			CLR_Opp();
		}
	}

	private void Program_KeyUp(object sender, KeyEventArgs e)
	{
		ControlAChange("KeyPad", "Focus", "Set");
	}

	public void ControlAChange(string ControlName, string Setting, string Data)
	{
		checked
		{
			try
			{
				if (base.Controls[ControlName].InvokeRequired)
				{
					SetControl3Callback method = ControlAChange;
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
					if (Operators.CompareString(Data, "Red", TextCompare: false) == 0)
					{
						base.Controls[ControlName].ForeColor = Color.Red;
					}
					else
					{
						base.Controls[ControlName].ForeColor = Color.FromArgb(128, 255, 255);
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
					base.Controls[ControlName].Focus();
					break;
				default:
					if (Operators.CompareString(ControlName, "KeyBoard", TextCompare: false) == 0)
					{
						base.Controls[ControlName].Controls[Setting].Focus();
					}
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

	public void ControlBChange(string ControlBName, string ControlName, string Setting, string Data)
	{
		try
		{
			if (base.Controls[ControlBName].InvokeRequired)
			{
				SetControl4Callback method = ControlBChange;
				Invoke(method, ControlBName, ControlName, Setting, Data);
			}
			else if (Operators.CompareString(Setting, "Text", TextCompare: false) == 0)
			{
				base.Controls[ControlBName].Controls[ControlName].Text = Data;
			}
			else if (Operators.CompareString(Setting, "Visible", TextCompare: false) == 0)
			{
				if (Operators.CompareString(Data, "False", TextCompare: false) == 0)
				{
					base.Controls[ControlBName].Controls[ControlName].Visible = false;
				}
				else
				{
					base.Controls[ControlBName].Controls[ControlName].Visible = true;
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
