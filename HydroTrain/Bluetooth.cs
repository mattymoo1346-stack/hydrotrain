using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[DesignerGenerated]
public class Bluetooth : Form
{
	public delegate bool PfnDeviceCallback(IntPtr pvParam, ref BLUETOOTH_DEVICE_INFO pDevice);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct BLUETOOTH_SELECT_DEVICE_PARAMS
	{
		public int dwSize;

		public int cNumOfClasses;

		public IntPtr prgClassOfDevices;

		public string pszInfo;

		public IntPtr hwndParent;

		public bool fForceAuthentication;

		public bool fShowAuthenticated;

		public bool fShowRemembered;

		public bool fShowUnknown;

		public bool fAddNewDeviceWizard;

		public bool fSkipServicesPage;

		public PfnDeviceCallback pfnDeviceCallback;

		public IntPtr pvParam;

		public int cNumDevices;

		public IntPtr pDevices;

		public int idevice;

		public BLUETOOTH_DEVICE_INFO[] Devices
		{
			get
			{
				checked
				{
					if (cNumDevices > 0)
					{
						object obj = new BLUETOOTH_DEVICE_INFO[cNumDevices - 1 + 1];
						int num = cNumDevices - 1;
						for (idevice = 0; idevice <= num; idevice++)
						{
							object[] obj2 = new object[2] { idevice, null };
							object obj3 = Marshal.PtrToStructure(new IntPtr(pDevices.ToInt64() + idevice * Marshal.SizeOf(typeof(BLUETOOTH_DEVICE_INFO))), typeof(BLUETOOTH_DEVICE_INFO));
							obj2[1] = ((obj3 != null) ? ((BLUETOOTH_DEVICE_INFO)obj3) : default(BLUETOOTH_DEVICE_INFO));
							NewLateBinding.LateIndexSet(obj, obj2, null);
						}
						return (BLUETOOTH_DEVICE_INFO[])obj;
					}
					return new BLUETOOTH_DEVICE_INFO[0];
				}
			}
		}

		public BLUETOOTH_DEVICE_INFO Device
		{
			get
			{
				if (cNumDevices > 0)
				{
					object obj = Marshal.PtrToStructure(pDevices, typeof(BLUETOOTH_DEVICE_INFO));
					return (obj != null) ? ((BLUETOOTH_DEVICE_INFO)obj) : default(BLUETOOTH_DEVICE_INFO);
				}
				return default(BLUETOOTH_DEVICE_INFO);
			}
		}
	}

	public struct SYSTEMTIME
	{
		public ushort wYear;

		public ushort wMonth;

		public ushort wDayOfWeek;

		public ushort wDay;

		public ushort wHour;

		public ushort wMinute;

		public ushort wSecond;

		public ushort wMilliseconds;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct BLUETOOTH_DEVICE_INFO
	{
		public uint dwSize;

		public ulong Address;

		public uint ulClassofDevice;

		public bool fConnected;

		public bool fRemembered;

		public bool fAuthenticated;

		public SYSTEMTIME stLastSeen;

		public SYSTEMTIME stLastUsed;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 248)]
		public string szName;
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BouGetdev")]
	private Button _BouGetdev;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ExitPage")]
	private Button _ExitPage;

	public static System.Threading.Timer BTScanTM;

	public object COD_FORMAT_BIT_OFFSET;

	public object COD_MINOR_BIT_OFFSET;

	public object COD_MAJOR_BIT_OFFSET;

	public object COD_SERVICE_BIT_OFFSET;

	public object COD_FORMAT_MASK;

	public object COD_MINOR_MASK;

	public object COD_MAJOR_MASK;

	public object COD_SERVICE_MASK;

	public static PfnDeviceCallback DeviceCallbackProc = null;

	internal virtual Button BouGetdev
	{
		[CompilerGenerated]
		get
		{
			return _BouGetdev;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BouGetdev_Click;
			Button button = _BouGetdev;
			if (button != null)
			{
				button.Click -= value2;
			}
			_BouGetdev = value;
			button = _BouGetdev;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LabRes")]
	internal virtual TextBox LabRes
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

	public Bluetooth()
	{
		base.Load += Bluetooth_Load;
		COD_FORMAT_BIT_OFFSET = 0;
		COD_MINOR_BIT_OFFSET = 2;
		COD_MAJOR_BIT_OFFSET = 8;
		COD_SERVICE_BIT_OFFSET = 13;
		COD_FORMAT_MASK = 3;
		COD_MINOR_MASK = 252;
		COD_MAJOR_MASK = 7936;
		COD_SERVICE_MASK = 16769024;
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
		this.BouGetdev = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.LabRes = new System.Windows.Forms.TextBox();
		this.ExitPage = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.BouGetdev.Location = new System.Drawing.Point(22, 32);
		this.BouGetdev.Name = "BouGetdev";
		this.BouGetdev.Size = new System.Drawing.Size(153, 100);
		this.BouGetdev.TabIndex = 0;
		this.BouGetdev.Text = "Get";
		this.BouGetdev.UseVisualStyleBackColor = true;
		this.Button1.Location = new System.Drawing.Point(23, 186);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		this.LabRes.Location = new System.Drawing.Point(314, 40);
		this.LabRes.Multiline = true;
		this.LabRes.Name = "LabRes";
		this.LabRes.Size = new System.Drawing.Size(235, 114);
		this.LabRes.TabIndex = 2;
		this.ExitPage.Location = new System.Drawing.Point(664, 19);
		this.ExitPage.Name = "ExitPage";
		this.ExitPage.Size = new System.Drawing.Size(63, 60);
		this.ExitPage.TabIndex = 3;
		this.ExitPage.Text = "X";
		this.ExitPage.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.ControlBox = false;
		base.Controls.Add(this.ExitPage);
		base.Controls.Add(this.LabRes);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.BouGetdev);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "Bluetooth";
		this.Text = "Bluetooth";
		base.TopMost = true;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Settings()
	{
		BLUETOOTH_SELECT_DEVICE_PARAMS pbtsdp = new BLUETOOTH_SELECT_DEVICE_PARAMS
		{
			dwSize = Marshal.SizeOf(typeof(BLUETOOTH_SELECT_DEVICE_PARAMS)),
			hwndParent = base.Handle,
			fShowAuthenticated = true,
			fShowUnknown = true,
			fShowRemembered = true
		};
		DeviceCallbackProc = DeviceCallback;
		pbtsdp.pfnDeviceCallback = DeviceCallbackProc;
		object value = BluetoothSelectDevices(ref pbtsdp);
		if (Conversions.ToBoolean(value))
		{
			object obj = Marshal.PtrToStructure(pbtsdp.pDevices, default(BLUETOOTH_DEVICE_INFO).GetType());
			BLUETOOTH_DEVICE_INFO bLUETOOTH_DEVICE_INFO = ((obj != null) ? ((BLUETOOTH_DEVICE_INFO)obj) : default(BLUETOOTH_DEVICE_INFO));
			object obj2 = string.Join(":", from b in BitConverter.GetBytes(bLUETOOTH_DEVICE_INFO.Address).Take(6).Reverse()
				select b.ToString("X2"));
			object szName = bLUETOOTH_DEVICE_INFO.szName;
			object objectValue = RuntimeHelpers.GetObjectValue(GET_COD_MAJOR(bLUETOOTH_DEVICE_INFO.ulClassofDevice));
			object objectValue2 = RuntimeHelpers.GetObjectValue(GET_COD_MINOR(bLUETOOTH_DEVICE_INFO.ulClassofDevice));
			BluetoothSelectDevicesFree(ref pbtsdp);
		}
	}

	private void Bluetooth_Load(object sender, EventArgs e)
	{
		BTScanTMSet();
		Settings();
	}

	private void BouGetdev_Click(object sender, EventArgs e)
	{
		LabRes.Text = "Searching devices...";
		BTScanTMon();
		BouGetdev.Enabled = false;
	}

	private void BTScanTM_Tick(object sender)
	{
	}

	private void SurroundingSub()
	{
	}

	private void ExitPage_Click(object sender, EventArgs e)
	{
		Hide();
	}

	public void BTScanTMSet()
	{
		BTScanTM = new System.Threading.Timer(BTScanTM_Tick, null, -1, -1);
	}

	public void BTScanTMOff()
	{
		BTScanTM.Change(-1, -1);
	}

	public void BTScanTMon()
	{
		BTScanTM.Change(5000, 5000);
	}

	[DllImport("Bthprops.cpl", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool BluetoothSelectDevices(ref BLUETOOTH_SELECT_DEVICE_PARAMS pbtsdp);

	[DllImport("Bthprops.cpl", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool BluetoothSelectDevicesFree(ref BLUETOOTH_SELECT_DEVICE_PARAMS pbtsdp);

	public object GET_COD_FORMAT(uint _cod)
	{
		return Operators.RightShiftObject(Operators.AndObject(_cod, COD_FORMAT_MASK), COD_FORMAT_BIT_OFFSET);
	}

	public object GET_COD_MINOR(uint _cod)
	{
		return Operators.RightShiftObject(Operators.AndObject(_cod, COD_MINOR_MASK), COD_MINOR_BIT_OFFSET);
	}

	public object GET_COD_MAJOR(uint _cod)
	{
		return Operators.RightShiftObject(Operators.AndObject(_cod, COD_MAJOR_MASK), COD_MAJOR_BIT_OFFSET);
	}

	public object GET_COD_SERVICE(uint _cod)
	{
		return Operators.RightShiftObject(Operators.AndObject(_cod, COD_SERVICE_MASK), COD_SERVICE_BIT_OFFSET);
	}

	public static bool DeviceCallback(IntPtr pvParam, ref BLUETOOTH_DEVICE_INFO pDevice)
	{
		return true;
	}
}
