using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bluetooth m_Bluetooth;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Display m_Display;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public I2CPot m_I2CPot;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public InfoEnter m_InfoEnter;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Information m_Information;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public IOCOMMS m_IOCOMMS;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public IOPOT m_IOPOT;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public KeyPadEnter m_KeyPadEnter;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MachineSetup m_MachineSetup;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public NameListSort m_NameListSort;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public RLY82 m_RLY82;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public RS232_IO m_RS232_IO;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public SetupDepth m_SetupDepth;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Speaker m_Speaker;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public TransferHydro m_TransferHydro;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public UPOT8PROXR m_UPOT8PROXR;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public USBISS m_USBISS;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public USBOPTORLY816 m_USBOPTORLY816;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public USBOPTORLY88 m_USBOPTORLY88;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public USBRLY04 m_USBRLY04;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public USBRLY08 m_USBRLY08;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public VoiceRecognizer m_VoiceRecognizer;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public WIFI m_WIFI;

		public Bluetooth Bluetooth
		{
			[DebuggerHidden]
			get
			{
				m_Bluetooth = Create__Instance__(m_Bluetooth);
				return m_Bluetooth;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Bluetooth)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Bluetooth);
				}
			}
		}

		public Display Display
		{
			[DebuggerHidden]
			get
			{
				m_Display = Create__Instance__(m_Display);
				return m_Display;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Display)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Display);
				}
			}
		}

		public I2CPot I2CPot
		{
			[DebuggerHidden]
			get
			{
				m_I2CPot = Create__Instance__(m_I2CPot);
				return m_I2CPot;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_I2CPot)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_I2CPot);
				}
			}
		}

		public InfoEnter InfoEnter
		{
			[DebuggerHidden]
			get
			{
				m_InfoEnter = Create__Instance__(m_InfoEnter);
				return m_InfoEnter;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_InfoEnter)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_InfoEnter);
				}
			}
		}

		public Information Information
		{
			[DebuggerHidden]
			get
			{
				m_Information = Create__Instance__(m_Information);
				return m_Information;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Information)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Information);
				}
			}
		}

		public IOCOMMS IOCOMMS
		{
			[DebuggerHidden]
			get
			{
				m_IOCOMMS = Create__Instance__(m_IOCOMMS);
				return m_IOCOMMS;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_IOCOMMS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_IOCOMMS);
				}
			}
		}

		public IOPOT IOPOT
		{
			[DebuggerHidden]
			get
			{
				m_IOPOT = Create__Instance__(m_IOPOT);
				return m_IOPOT;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_IOPOT)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_IOPOT);
				}
			}
		}

		public KeyPadEnter KeyPadEnter
		{
			[DebuggerHidden]
			get
			{
				m_KeyPadEnter = Create__Instance__(m_KeyPadEnter);
				return m_KeyPadEnter;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_KeyPadEnter)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_KeyPadEnter);
				}
			}
		}

		public MachineSetup MachineSetup
		{
			[DebuggerHidden]
			get
			{
				m_MachineSetup = Create__Instance__(m_MachineSetup);
				return m_MachineSetup;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MachineSetup)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MachineSetup);
				}
			}
		}

		public NameListSort NameListSort
		{
			[DebuggerHidden]
			get
			{
				m_NameListSort = Create__Instance__(m_NameListSort);
				return m_NameListSort;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_NameListSort)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_NameListSort);
				}
			}
		}

		public RLY82 RLY82
		{
			[DebuggerHidden]
			get
			{
				m_RLY82 = Create__Instance__(m_RLY82);
				return m_RLY82;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_RLY82)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_RLY82);
				}
			}
		}

		public RS232_IO RS232_IO
		{
			[DebuggerHidden]
			get
			{
				m_RS232_IO = Create__Instance__(m_RS232_IO);
				return m_RS232_IO;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_RS232_IO)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_RS232_IO);
				}
			}
		}

		public SetupDepth SetupDepth
		{
			[DebuggerHidden]
			get
			{
				m_SetupDepth = Create__Instance__(m_SetupDepth);
				return m_SetupDepth;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SetupDepth)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_SetupDepth);
				}
			}
		}

		public Speaker Speaker
		{
			[DebuggerHidden]
			get
			{
				m_Speaker = Create__Instance__(m_Speaker);
				return m_Speaker;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Speaker)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Speaker);
				}
			}
		}

		public TransferHydro TransferHydro
		{
			[DebuggerHidden]
			get
			{
				m_TransferHydro = Create__Instance__(m_TransferHydro);
				return m_TransferHydro;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_TransferHydro)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_TransferHydro);
				}
			}
		}

		public UPOT8PROXR UPOT8PROXR
		{
			[DebuggerHidden]
			get
			{
				m_UPOT8PROXR = Create__Instance__(m_UPOT8PROXR);
				return m_UPOT8PROXR;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_UPOT8PROXR)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_UPOT8PROXR);
				}
			}
		}

		public USBISS USBISS
		{
			[DebuggerHidden]
			get
			{
				m_USBISS = Create__Instance__(m_USBISS);
				return m_USBISS;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_USBISS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_USBISS);
				}
			}
		}

		public USBOPTORLY816 USBOPTORLY816
		{
			[DebuggerHidden]
			get
			{
				m_USBOPTORLY816 = Create__Instance__(m_USBOPTORLY816);
				return m_USBOPTORLY816;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_USBOPTORLY816)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_USBOPTORLY816);
				}
			}
		}

		public USBOPTORLY88 USBOPTORLY88
		{
			[DebuggerHidden]
			get
			{
				m_USBOPTORLY88 = Create__Instance__(m_USBOPTORLY88);
				return m_USBOPTORLY88;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_USBOPTORLY88)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_USBOPTORLY88);
				}
			}
		}

		public USBRLY04 USBRLY04
		{
			[DebuggerHidden]
			get
			{
				m_USBRLY04 = Create__Instance__(m_USBRLY04);
				return m_USBRLY04;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_USBRLY04)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_USBRLY04);
				}
			}
		}

		public USBRLY08 USBRLY08
		{
			[DebuggerHidden]
			get
			{
				m_USBRLY08 = Create__Instance__(m_USBRLY08);
				return m_USBRLY08;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_USBRLY08)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_USBRLY08);
				}
			}
		}

		public VoiceRecognizer VoiceRecognizer
		{
			[DebuggerHidden]
			get
			{
				m_VoiceRecognizer = Create__Instance__(m_VoiceRecognizer);
				return m_VoiceRecognizer;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_VoiceRecognizer)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_VoiceRecognizer);
				}
			}
		}

		public WIFI WIFI
		{
			[DebuggerHidden]
			get
			{
				m_WIFI = Create__Instance__(m_WIFI);
				return m_WIFI;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_WIFI)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_WIFI);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || Instance.IsDisposed)
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
