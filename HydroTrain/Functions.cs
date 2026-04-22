using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

namespace HydroTrain;

[StandardModule]
internal sealed class Functions
{
	public struct NETRESOURCE
	{
		public int dwScope;

		public int dwType;

		public int dwDisplayType;

		public int dwUsage;

		public string lpLocalName;

		public string lpRemoteName;

		public string lpComment;

		public string lpProvider;
	}

	public static object LicenceVersion = Registry.CurrentUser.OpenSubKey("Control\\\\Windows\\\\Panel\\\\", writable: true);

	public const int ForceDisconnect = 1;

	public const long RESOURCETYPE_DISK = 1L;

	private const long ERROR_BAD_NETPATH = 53L;

	private const long ERROR_NETWORK_ACCESS_DENIED = 65L;

	private const long ERROR_INVALID_PASSWORD = 86L;

	private const long ERROR_NETWORK_BUSY = 54L;

	private static readonly Thread ReadControlThread = null;

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	private const string WallpaperFile = "Wallpaper.bmp";

	public static object CommPorts = MyProject.Computer.Registry.LocalMachine.OpenSubKey("Hardware\\\\DeviceMap\\\\SerialComm\\\\");

	public static object SecurityInfo = MyProject.Computer.Registry.CurrentUser.CreateSubKey("Control\\\\Windows\\\\Panel\\\\Prep\\\\");

	public static string SerialNo = Interaction.GetSetting("Dtread", "Aqua", "SerialNo", "0");

	private static TripleDESCryptoServiceProvider TripleDes = new TripleDESCryptoServiceProvider();

	private static byte[] key = new byte[24]
	{
		1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
		11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
		21, 22, 23, 24
	};

	private static byte[] iv = new byte[8] { 8, 7, 6, 5, 4, 3, 2, 1 };

	private static string abc = Conversions.ToString(SetupKey());

	private static cTripleDES des = new cTripleDES(key, iv);

	private static readonly string encryptedData = "Test";

	private static string newEncryptedData = des.Encrypt(encryptedData);

	private static string decryptedData = des.Decrypt(newEncryptedData);

	private static string decryptedDat = des.Decrypt(newEncryptedData);

	public static bool MemoryDrive;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SystemParametersInfo(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	public static object SetupKey()
	{
		checked
		{
			if (Strings.Len(SerialNo) >= 4)
			{
				key[4] = (byte)Strings.Asc(Strings.Mid(SerialNo, 1, 1));
				key[8] = (byte)Strings.Asc(Strings.Mid(SerialNo, 2, 1));
				key[12] = (byte)Strings.Asc(Strings.Mid(SerialNo, 3, 1));
				key[16] = (byte)Strings.Asc(Strings.Mid(SerialNo, 4, 1));
				iv[1] = key[16];
				iv[3] = key[12];
				iv[5] = key[8];
				iv[7] = key[4];
			}
			object result = default(object);
			return result;
		}
	}

	public static string GetComputerName()
	{
		return Dns.GetHostName();
	}

	public static void SetWallpaper(Image img)
	{
		string lpvParam = MyProject.Computer.FileSystem.CombinePath(MyProject.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "Wallpaper.bmp");
		try
		{
			img.Save(lpvParam, ImageFormat.Bmp);
			SystemParametersInfo(20, 0, ref lpvParam, 3);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static string CheckForDrives(int DriveType)
	{
		string text = "";
		byte b;
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject"));
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Drives", new object[0], null, null, null));
			b = 1;
			string text2 = "";
			object obj = "";
			foreach (object item in (IEnumerable)objectValue2)
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(item);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue3, null, "DriveType", new object[0], null, null, null), DriveType, TextCompare: false), Operators.CompareObjectEqual(NewLateBinding.LateGet(objectValue3, null, "isready", new object[0], null, null, null), true, TextCompare: false))))
				{
					text2 = Conversions.ToString(NewLateBinding.LateGet(objectValue3, null, "path", new object[0], null, null, null));
					b = 0;
					obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, null, "volumeName", new object[0], null, null, null));
					if (Operators.ConditionalCompareObjectEqual(obj, "", TextCompare: false))
					{
						obj = "nul";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text + "," + text2 + ",", obj));
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			b = (byte)((Microsoft.VisualBasic.Information.Err().Number != 71) ? 3 : 2);
			ProjectData.ClearProjectError();
		}
		return Conversions.ToString(b) + "," + text;
	}

	public static string GetDrive()
	{
		string result = "";
		short driveType = 1;
		string expression = CheckForDrives(driveType);
		string[] array = Strings.Split(expression, ",");
		checked
		{
			if ((int)Math.Round(Conversion.Val(array[Microsoft.VisualBasic.Information.LBound(array)])) == 0)
			{
				int num = Microsoft.VisualBasic.Information.UBound(array);
				for (int i = 1; i <= num; i += 2)
				{
					result = array[i];
				}
			}
			return result;
		}
	}

	public static string App_Path()
	{
		return AppDomain.CurrentDomain.BaseDirectory;
	}

	public static object GetDirectories(string path, string dirname)
	{
		string[] directories = Directory.GetDirectories(path);
		foreach (string text in directories)
		{
			try
			{
				string[] directories2 = Directory.GetDirectories(text);
				foreach (string text2 in directories2)
				{
					if (Strings.InStr(text2, dirname) != 0)
					{
						return text2;
					}
				}
				if (Strings.InStr(text, dirname) != 0)
				{
					return text;
				}
			}
			catch (UnauthorizedAccessException ex)
			{
				ProjectData.SetProjectError(ex);
				UnauthorizedAccessException ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		return "";
	}

	public static string GetMainDirName()
	{
		checked
		{
			string result = default(string);
			try
			{
				string expression = App_Path();
				Array array = Strings.Split(expression, "\\");
				int num = Microsoft.VisualBasic.Information.UBound(array);
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(array, new object[1] { i }, null), "Users", TextCompare: false))
					{
						result = Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { i + 1 }, null));
						return result;
					}
				}
				result = Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { 2 }, null));
				return result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static string NumberToString(float Number, int Places)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		text = Number.ToString();
		string[] array = Strings.Split(text, ",");
		if (Microsoft.VisualBasic.Information.UBound(array) > 0)
		{
			text2 = array[0];
			text3 = Strings.Mid(array[Microsoft.VisualBasic.Information.UBound(array)], 1, Places);
		}
		else
		{
			array = Strings.Split(text, ".");
			if (Microsoft.VisualBasic.Information.UBound(array) > 0)
			{
				text2 = array[0];
				text3 = Strings.Mid(array[Microsoft.VisualBasic.Information.UBound(array)], 1, Places);
			}
			else
			{
				text2 = text;
			}
		}
		checked
		{
			if (Number > 0f)
			{
				return text2 + "." + text3 + Strings.Mid("000000", 6 - Places + 1, Places - Strings.Len(text3.ToString()));
			}
			return "0." + Strings.Mid("000000", 6 - Places, Places);
		}
	}

	public static object GetPortInfo()
	{
		string text = "";
		byte b = 0;
		checked
		{
			try
			{
				b = 0;
				do
				{
					try
					{
						if (NewLateBinding.LateGet(CommPorts, null, "GetValue", new object[2]
						{
							"\\Device\\USBSER00" + b,
							""
						}, null, null, null) != "")
						{
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text, NewLateBinding.LateGet(CommPorts, null, "GetValue", new object[2]
							{
								"\\Device\\USBSER00" + b,
								""
							}, null, null, null)), ","));
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						text = "";
						ProjectData.ClearProjectError();
					}
					try
					{
						if (NewLateBinding.LateGet(CommPorts, null, "GetValue", new object[2]
						{
							"\\Device\\VCP" + b,
							""
						}, null, null, null) != "")
						{
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text, NewLateBinding.LateGet(CommPorts, null, "GetValue", new object[2]
							{
								"\\Device\\VCP" + b,
								""
							}, null, null, null)), ","));
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						text = "";
						ProjectData.ClearProjectError();
					}
					b = (byte)unchecked((uint)(b + 1));
				}
				while (unchecked((uint)b) <= 9u);
				text = Strings.Mid(text, 1, Strings.Len(text) - 1);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				text = "";
				ProjectData.ClearProjectError();
			}
			return text;
		}
	}

	public static object InformationPrint(string Info)
	{
		string text = "";
		string text2 = "";
		Array array = Strings.Split(Info, ";");
		checked
		{
			short num = (short)Microsoft.VisualBasic.Information.UBound(array);
			short num2 = num;
			for (short num3 = 0; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				double num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(array, new object[1] { num3 }, null)));
				if (num4 == 1.0)
				{
					text = Display.WfUS;
				}
				else if (num4 == 2.0)
				{
					text = Display.DECT;
				}
				else if (num4 == 3.0)
				{
					text = Display.DEIT;
				}
				else if (num4 == 4.0)
				{
					text = Display.IPHS;
				}
				else if (num4 == 5.0)
				{
					text = Display.PSWR;
				}
				else if (num4 == 6.0)
				{
					text = Display.BBRR;
				}
				else if (num4 == 7.0)
				{
					text = Display.USKR;
				}
				else if (num4 == 8.0)
				{
					text = Display.RLY88VERR;
				}
				else if (num4 == 9.0)
				{
					text = Display.RLY816VERR;
				}
				else if (num4 == 10.0)
				{
					text = Display.RLY88ERR;
				}
				else if (num4 == 11.0)
				{
					text = Display.RLY816ERR;
				}
				else if (num4 == 12.0)
				{
					text = Display.SP4626ERR;
				}
				else if (num4 == 13.0)
				{
					text = Display.IN4626ERR;
				}
				else if (num4 == 14.0)
				{
					text = Display.INDO;
				}
				else if (num4 == 15.0)
				{
					text = Display.OTDO;
				}
				else if (num4 == 16.0)
				{
					text = Display.TPCE;
				}
				else if (num4 == 17.0)
				{
					text = Display.FEPERR;
				}
				else if (num4 == 18.0)
				{
					text = Display.ICERR;
				}
				else if (num4 == 19.0)
				{
					text = Display.RSES;
				}
				else if (num4 == 20.0)
				{
					text = Display.PHIR;
				}
				else if (num4 == 21.0)
				{
					text = Display.PRWR;
				}
				else if (num4 == 22.0)
				{
					text = Display.IVLC;
				}
				else if (num4 == 23.0)
				{
					text = Display.UP8ERR;
				}
				else if (num4 == 24.0)
				{
					text = Display.RLY04ERR;
				}
				else if (num4 == 25.0)
				{
					text = Display.SNNE;
				}
				else if (num4 == 26.0)
				{
					text = Display.RLY08ERR;
				}
				else if (num4 == 27.0)
				{
					text = Display.PREX;
				}
				else if (num4 == 28.0)
				{
					text = Display.CLDN;
				}
				else if (num4 == 29.0)
				{
					text = Display.BYEtxt;
				}
				else if (num4 == 30.0)
				{
					text = Display.BMItxt;
				}
				else if (num4 == 31.0)
				{
					text = Display.DYWU;
				}
				else if (num4 == 32.0)
				{
					text = Display.BMItxt;
				}
				else if (num4 == 33.0)
				{
					text = Display.Reftxt;
				}
				else if (num4 == 34.0)
				{
					text = Display.Memtxt;
				}
				else if (num4 == 35.0)
				{
					text = Display.Circtxt;
				}
				else if (num4 == 36.0)
				{
					text = Display.ISSERR;
				}
				else if (num4 == 37.0)
				{
					text = Display.I2CERR;
				}
				else if (num4 == 38.0)
				{
					text = Display.IOPERR;
				}
				else if (num4 == 39.0)
				{
					text = Display.VCO;
				}
				else if (num4 == 40.0)
				{
					text = Display.RLY82ERR;
				}
				else if (num4 == 41.0)
				{
					text = Display.RLY82VERR;
				}
				else if (num4 == 42.0)
				{
					text = Display.VCOF;
				}
				else if (num4 == 43.0)
				{
					text = Display.CNI;
				}
				else if (num4 == 44.0)
				{
					text = Display.IFERR;
				}
				else if (num4 == 45.0)
				{
					text = Display.LTUP;
				}
				else if (num4 == 46.0)
				{
					text = Display.MDLO;
				}
				else if (num4 == 47.0)
				{
					text = Display.MDRO;
				}
				else if (num4 == 48.0)
				{
					text = Display.LGDO;
				}
				else if (num4 == 49.0)
				{
					text = Display.LLR;
				}
				else if (num4 == 50.0)
				{
					text = Display.ULR;
				}
				else if (num4 == 51.0)
				{
					text = Display.LMO;
				}
				else if (num4 == 52.0)
				{
					text = Display.LME;
				}
				else if (num4 == 53.0)
				{
					text = Display.LMDE;
				}
				text2 = ((Operators.CompareString(text2, "", TextCompare: false) != 0) ? (text2 + "\r\n" + text) : text);
			}
			text = "";
			object result = text2;
			text2 = "";
			return result;
		}
	}

	public static bool FileRename(string sourceDir, string fname, string NewName)
	{
		bool flag = false;
		try
		{
			string file = sourceDir + fname;
			MyProject.Computer.FileSystem.RenameFile(file, NewName);
			flag = true;
		}
		catch (IOException ex)
		{
			ProjectData.SetProjectError(ex);
			IOException ex2 = ex;
			flag = false;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static string ReadDrives()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		string left = default(string);
		foreach (object instance in array)
		{
			left = "Drive Name: {0}" + Conversions.ToString(NewLateBinding.LateGet(instance, null, "Name", new object[0], null, null, null));
			left = Conversions.ToString(Operators.ConcatenateObject(left, Operators.ConcatenateObject("\tDrive Type: {0}", NewLateBinding.LateGet(instance, null, "DriveType", new object[0], null, null, null))));
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(instance, null, "IsReady", new object[0], null, null, null), true, TextCompare: false))
			{
				long num = 0L;
				num = Conversions.ToLong(Operators.DivideObject(NewLateBinding.LateGet(instance, null, "TotalSize", new object[0], null, null, null), 1073741824));
				left = Conversions.ToString(Operators.ConcatenateObject(left, Operators.ConcatenateObject("\tDrive Label: {0}", NewLateBinding.LateGet(instance, null, "VolumeLabel", new object[0], null, null, null))));
				left = left + "\tSize of drive in GB {0}" + Conversions.ToString(num) + "\r\n";
			}
		}
		return left;
	}

	public static bool SerialPortCheck(int Com)
	{
		bool result;
		try
		{
			ReadOnlyCollection<string> serialPortNames = MyProject.Computer.Ports.SerialPortNames;
			result = (serialPortNames.Contains("COM" + Conversions.ToString(Com)) ? true : false);
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

	public static string OneDriveCheck()
	{
		string mainDirName = GetMainDirName();
		string text = "\\OneDrive";
		string text2 = "C:\\Users\\" + mainDirName;
		if (Operators.CompareString(DirExist(text2, text), "Failed", TextCompare: false) != 0)
		{
			return text2 + text;
		}
		return "Failed";
	}

	public static string GoogleDriveCheck()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		string result = "Failed";
		string expression = "Google";
		DriveInfo[] array = drives;
		foreach (object instance in array)
		{
			string left = "Drive Name: {0}" + Conversions.ToString(NewLateBinding.LateGet(instance, null, "Name", new object[0], null, null, null));
			left = Conversions.ToString(Operators.ConcatenateObject(left, Operators.ConcatenateObject("\tDrive Type: {0}", NewLateBinding.LateGet(instance, null, "DriveType", new object[0], null, null, null))));
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(instance, null, "IsReady", new object[0], null, null, null), true, TextCompare: false))
			{
				long num = 0L;
				num = Conversions.ToLong(Operators.DivideObject(NewLateBinding.LateGet(instance, null, "TotalSize", new object[0], null, null, null), 1073741824));
				left = Conversions.ToString(NewLateBinding.LateGet(instance, null, "VolumeLabel", new object[0], null, null, null));
				if (Strings.Len(left) >= Strings.Len(expression) && Operators.CompareString(Strings.Mid(left, 1, Strings.Len(expression)), "Google", TextCompare: false) == 0)
				{
					result = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(instance, null, "Name", new object[0], null, null, null), "My Drive"));
				}
			}
		}
		return result;
	}

	public static string PublicDriveCheck()
	{
		string mainDirName = GetMainDirName();
		string text = "Public\\Downloads";
		string text2 = "C:\\Users\\";
		if (Operators.CompareString(DirExist(text2, text), "Failed", TextCompare: false) != 0)
		{
			return text2 + text;
		}
		return "Failed";
	}

	public static object ListDir(object sender, EventArgs e)
	{
		string[] logicalDrives = Directory.GetLogicalDrives();
		long num = logicalDrives.GetLowerBound(0);
		long num2 = logicalDrives.GetUpperBound(0);
		checked
		{
			string text = default(string);
			for (long num3 = num; num3 <= num2; num3++)
			{
				text += Conversions.ToString(text[Conversions.ToInteger(logicalDrives[(int)num3])]);
			}
			object result = default(object);
			return result;
		}
	}

	public static object CreateFile(object Drive, object Path, object NewFile)
	{
		string result;
		try
		{
			if (Conversions.ToBoolean(Operators.AndObject(File.Exists(Conversions.ToString(Operators.ConcatenateObject(Drive, Path))), Operators.CompareObjectEqual(NewFile, false, TextCompare: false))))
			{
				result = "Exists";
			}
			else
			{
				if (File.Exists(Conversions.ToString(Operators.ConcatenateObject(Drive, Path))))
				{
					File.Delete(Conversions.ToString(Operators.ConcatenateObject(Drive, Path)));
				}
				FileStream fileStream = File.Create(Conversions.ToString(Operators.ConcatenateObject(Drive, Path)));
				fileStream.Close();
				result = "Done";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "Failed";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string DirectoryCopy(string Drive, string Path, bool ok)
	{
		string text = Conversions.ToString(Value: false);
		try
		{
			MyProject.Computer.FileSystem.CopyDirectory(Drive, Path, ok);
			text = Conversions.ToString(Value: true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			text = Conversions.ToString(Value: false);
			ProjectData.ClearProjectError();
		}
		return text;
	}

	public static bool IsFileLocked(FileInfo file)
	{
		object obj = null;
		bool result;
		try
		{
			obj = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (IOException ex)
		{
			ProjectData.SetProjectError(ex);
			IOException ex2 = ex;
			result = true;
			ProjectData.ClearProjectError();
			goto IL_004b;
		}
		finally
		{
			if (obj != null)
			{
				NewLateBinding.LateCall(obj, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
			}
		}
		result = false;
		goto IL_004b;
		IL_004b:
		return result;
	}

	public static bool FileInUse(string sFile)
	{
		bool result = false;
		if (File.Exists(sFile))
		{
			try
			{
				using (new FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
				{
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = true;
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	public static bool FileExist(string Drive, string Path)
	{
		bool result;
		try
		{
			result = (File.Exists(Drive + Path) ? true : false);
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

	public static string DirExist(string Drive, string Path)
	{
		string text = "Failed";
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Drive + Path);
			text = ((!directoryInfo.Exists) ? "Failed" : "Exists");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			text = "Failed";
			ProjectData.ClearProjectError();
		}
		return text;
	}

	public static string DirCreate(string Drive, string Path)
	{
		string result;
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Drive + Path);
			if (directoryInfo.Exists)
			{
				result = "Exists";
			}
			else
			{
				directoryInfo.Create();
				result = "Done";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "Failed";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object DirDelete(object Drive, object Path)
	{
		string result;
		try
		{
			if (Directory.Exists(Conversions.ToString(Operators.ConcatenateObject(Drive, Path))))
			{
				string[] files = Directory.GetFiles(Conversions.ToString(Operators.ConcatenateObject(Drive, Path)));
				foreach (string path in files)
				{
					File.Delete(path);
				}
				string[] directories = Directory.GetDirectories(Conversions.ToString(Operators.ConcatenateObject(Drive, Path)));
				foreach (string path2 in directories)
				{
					Directory.Delete(path2);
				}
				Directory.Delete(Conversions.ToString(Operators.ConcatenateObject(Drive, Path)));
			}
			result = "Done";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "Failed";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object Hidden(string path, bool ShowHide)
	{
		object result;
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			if (ShowHide)
			{
				directoryInfo.Attributes = FileAttributes.Hidden;
			}
			else
			{
				directoryInfo.Attributes = FileAttributes.Normal;
			}
			result = true;
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

	public static object SetAttributes(object Drive, object Path, object ShowOrHidden)
	{
		string path = Conversions.ToString(Operators.ConcatenateObject(Drive, Path));
		string result;
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			if (directoryInfo.Exists | FileExist(Conversions.ToString(Drive), Conversions.ToString(Path)))
			{
				FileAttributes attributes = File.GetAttributes(path);
				if (Conversions.ToBoolean(Operators.AndObject((attributes & FileAttributes.Hidden) == FileAttributes.Hidden, Operators.CompareObjectEqual(ShowOrHidden, false, TextCompare: false))))
				{
					attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
					File.SetAttributes(path, attributes);
					result = "Show";
				}
				else if (Operators.ConditionalCompareObjectEqual(ShowOrHidden, true, TextCompare: false))
				{
					File.SetAttributes(path, File.GetAttributes(Conversions.ToString(Path)) | FileAttributes.Hidden);
					result = "Hidden";
				}
				else
				{
					result = "Hidden";
				}
			}
			else
			{
				result = "Dir Missing";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "Failed";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
	{
		return attributes & ~attributesToRemove;
	}

	public static object KeyCheck(object KeyString)
	{
		string text = "";
		bool flag = false;
		string text2 = "C:";
		checked
		{
			short num = (short)Strings.Len(RuntimeHelpers.GetObjectValue(KeyString));
			Display.KeyNumber = 0;
			string setting = Interaction.GetSetting("Dtread", "Aqua", "SerialNo", "0");
			string text3 = "\\" + setting + "\\11525.dll";
			string right = Conversions.ToString(Operators.ConcatenateObject(setting, KeyString));
			if (FileExist(text2, text3))
			{
				try
				{
					StreamReader streamReader = new StreamReader(text2 + text3);
					int num2 = default(int);
					string text4;
					do
					{
						num2++;
						text4 = streamReader.ReadLine();
						text = Strings.Mid(text4, 1);
						if (Operators.CompareString(text, right, TextCompare: false) == 0)
						{
							Display.KeyNumber = (short)num2;
							flag = true;
						}
					}
					while (!unchecked(text4 == null || flag));
					streamReader.Close();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			return flag;
		}
	}

	public static bool CreateShortCut(string TargetName, string ShortCutPath, string ShortCutName)
	{
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell"));
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "CreateShortcut", new object[1] { ShortCutPath + "\\" + ShortCutName + ".lnk" }, null, null, null));
			NewLateBinding.LateSet(objectValue2, null, "TargetPath", new object[1] { TargetName }, null, null);
			NewLateBinding.LateSet(objectValue2, null, "WindowStyle", new object[1] { 1 }, null, null);
			NewLateBinding.LateCall(objectValue2, null, "Save", new object[0], null, null, null, IgnoreReturn: true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		bool result = default(bool);
		return result;
	}

	private static void CheckLicenceThreadStart()
	{
		CheckLicence();
	}

	public static bool CheckLicence()
	{
		int num = 0;
		int num2 = 0;
		string text = "";
		string text2 = "";
		bool flag = false;
		string text3 = "C:";
		string setting = Interaction.GetSetting("Dtread", "Aqua", "SerialNo", "0");
		string text4 = default(string);
		try
		{
			cTripleDES instance = des;
			object[] array = new object[1];
			object securityInfo = SecurityInfo;
			object instance2 = securityInfo;
			object[] array2 = new object[1];
			object obj = (array2[0] = "U0000");
			array[0] = NewLateBinding.LateGet(instance2, null, "GetValue", array2, null, null, null);
			object[] array3 = array;
			bool[] obj2 = new bool[1] { true };
			bool[] array4 = obj2;
			object obj3 = NewLateBinding.LateGet(instance, null, "Decrypt", array, null, null, obj2);
			if (array4[0])
			{
				NewLateBinding.LateSetComplex(securityInfo, null, "GetValue", new object[2]
				{
					obj,
					array3[0]
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			string left = obj3.ToString();
			if (Operators.CompareString(left, "264180" + setting, TextCompare: false) == 0)
			{
				LicenceSet();
				NewLateBinding.LateCall(SecurityInfo, null, "SetValue", new object[2]
				{
					"U0000",
					des.Encrypt("LicenceChecked")
				}, null, null, null, IgnoreReturn: true);
				Process.Start("shutdown", "/r /t 05");
			}
			else
			{
				text4 = Conversions.ToString(NewLateBinding.LateGet(SecurityInfo, null, "GetValue", new object[1] { "U0001".ToString() }, null, null, null));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			text4 = "Failed";
			ProjectData.ClearProjectError();
		}
		flag = false;
		string text5 = GetMACAddress();
		if (Operators.CompareString(text5, "", TextCompare: false) == 0)
		{
			text5 = "0";
		}
		string text6 = GetVolumeSerial();
		if (Operators.CompareString(text6, "", TextCompare: false) == 0)
		{
			text6 = "0";
		}
		string text7 = GetProcessorId();
		if (Operators.CompareString(text7, "", TextCompare: false) == 0)
		{
			text7 = "0";
		}
		string text8 = GetMotherBoardID();
		if (Operators.CompareString(text8, "", TextCompare: false) == 0)
		{
			text8 = "0";
		}
		checked
		{
			if (((object)text4 != "Failed") & (Operators.CompareString(setting, "1444", TextCompare: false) != 0) & (Operators.CompareString(setting, "1449", TextCompare: false) != 0) & (Operators.CompareString(setting, "1452", TextCompare: false) != 0))
			{
				try
				{
					do
					{
						num2++;
						if (num2 == 1)
						{
							num = 1;
						}
						cTripleDES instance3 = des;
						object[] array5 = new object[1];
						object obj = SecurityInfo;
						object instance4 = obj;
						object[] array6 = new object[1];
						object securityInfo = (array6[0] = "U000" + num);
						array5[0] = NewLateBinding.LateGet(instance4, null, "GetValue", array6, null, null, null);
						object[] array3 = array5;
						bool[] array4;
						object obj3 = NewLateBinding.LateGet(instance3, null, "Decrypt", array5, null, null, array4 = new bool[1] { true });
						if (array4[0])
						{
							NewLateBinding.LateSetComplex(obj, null, "GetValue", new object[2]
							{
								securityInfo,
								array3[0]
							}, null, null, OptimisticSet: true, RValueBase: false);
						}
						text4 = Conversions.ToString(obj3);
						text = text4;
						if (num2 == 1)
						{
							num++;
							text2 = " 1: " + text5 + ",";
						}
						if (Operators.CompareString(text6, text, TextCompare: false) == 0)
						{
							num++;
							text2 = text2 + " 2: " + text6 + ",";
						}
						if (Operators.CompareString(text7, text, TextCompare: false) == 0)
						{
							num++;
							text2 = text2 + " 3: " + text7 + ",";
						}
						if (Operators.CompareString(text8, text, TextCompare: false) == 0)
						{
							num++;
							text2 = text2 + " 4: " + text8;
						}
					}
					while (num2 != 4);
					if (num >= 5)
					{
						flag = true;
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					flag = false;
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				string text9 = "\\" + setting + "\\129351435.dll";
				if (FileExist(text3, text9))
				{
					try
					{
						StreamReader streamReader = new StreamReader(text3 + text9);
						string text10;
						do
						{
							text10 = streamReader.ReadLine();
							text = Strings.Mid(text10, 1);
							if (num == 0)
							{
								text2 = " 1: " + text5 + ",";
							}
							if (Operators.CompareString(text6, text, TextCompare: false) == 0)
							{
								num++;
								text2 = text2 + " 2: " + text6 + ",";
							}
							if (Operators.CompareString(text7, text, TextCompare: false) == 0)
							{
								num++;
								text2 = text2 + " 3: " + text7 + ",";
							}
							if (Operators.CompareString(text8, text, TextCompare: false) == 0)
							{
								num++;
								text2 = text2 + " 4: " + text8;
							}
							num2++;
						}
						while (!unchecked(text10 == null || flag));
						if ((num > 1) & (num == num2 - 2))
						{
							flag = true;
						}
						streamReader.Close();
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						flag = false;
						ProjectData.ClearProjectError();
					}
				}
			}
			if (flag)
			{
				if (Display.EngPass)
				{
					MyProject.Forms.MachineSetup.MessageBoxChange("OK:" + text2);
				}
				else
				{
					MyProject.Forms.MachineSetup.MessageBoxChange("OK");
				}
			}
			else if (Display.EngPass)
			{
				MyProject.Forms.MachineSetup.MessageBoxChange("Failed:" + text2);
			}
			else
			{
				MyProject.Forms.MachineSetup.MessageBoxChange("Failed");
			}
			return flag;
		}
	}

	public static object KeySet(object KeyString)
	{
		string drive = "C:";
		string text = "\\11525.dll";
		bool flag = false;
		string setting = Interaction.GetSetting("Dtread", "Aqua", "SerialNo", "0");
		string fileTextString = Conversions.ToString(Operators.ConcatenateObject(setting, KeyString));
		string text2 = "\\" + setting;
		if (Operators.ConditionalCompareObjectEqual(KeyCheck(RuntimeHelpers.GetObjectValue(KeyString)), false, TextCompare: false))
		{
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(KeyString, "", TextCompare: false), Operators.CompareString(setting, "0", TextCompare: false) != 0)))
			{
				string text3 = DirCreate(drive, text2);
				text3 = Conversions.ToString(CreateFile(drive, text2 + text, false));
				if (Operators.CompareString(text3, "Failed", TextCompare: false) == 0)
				{
					flag = false;
				}
				else
				{
					WriteInformationFile(drive, text2, text, fileTextString, newfile: false);
					SetAttributes(drive, text2, true);
					SetAttributes(drive, text2 + text, true);
					flag = true;
				}
			}
		}
		else
		{
			flag = false;
		}
		return flag;
	}

	public static object ChangeAttributes(object Attribute)
	{
		string drive = "C:";
		string text = "\\129351435.dll";
		string text2 = "\\11525.dll";
		bool flag = false;
		string setting = Interaction.GetSetting("Dtread", "Aqua", "SerialNo", "0");
		string text3 = "\\" + setting;
		SetAttributes(drive, text3, RuntimeHelpers.GetObjectValue(Attribute));
		SetAttributes(drive, text3 + text, RuntimeHelpers.GetObjectValue(Attribute));
		SetAttributes(drive, text3 + text2, RuntimeHelpers.GetObjectValue(Attribute));
		return flag;
	}

	public static object LicenceSet()
	{
		string drive = "C:";
		string text = "\\129351435.dll";
		bool flag = false;
		string setting = Interaction.GetSetting("Dtread", "Aqua", "SerialNo", "0");
		string text2 = "\\" + setting;
		string text3 = GetMACAddress();
		if (Operators.CompareString(text3, "", TextCompare: false) == 0)
		{
			text3 = "0";
		}
		string text4 = GetVolumeSerial();
		if (Operators.CompareString(text4, "", TextCompare: false) == 0)
		{
			text4 = "0";
		}
		string text5 = GetProcessorId();
		if (Operators.CompareString(text5, "", TextCompare: false) == 0)
		{
			text5 = "0";
		}
		string text6 = GetMotherBoardID();
		if (Operators.CompareString(text6, "", TextCompare: false) == 0)
		{
			text6 = "0";
		}
		if (SecurityInfo == null)
		{
			SecurityInfo = Registry.CurrentUser.CreateSubKey("Control\\\\Windows\\\\Panel\\\\Prep\\\\");
		}
		try
		{
			string text7 = Conversions.ToString(NewLateBinding.LateGet(SecurityInfo, null, "GetValue", new object[1] { "U0001" }, null, null, null));
			NewLateBinding.LateCall(SecurityInfo, null, "SetValue", new object[2]
			{
				"U0001",
				des.Encrypt(text3)
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(SecurityInfo, null, "SetValue", new object[2]
			{
				"U0002",
				des.Encrypt(text4)
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(SecurityInfo, null, "SetValue", new object[2]
			{
				"U0003",
				des.Encrypt(text5)
			}, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(SecurityInfo, null, "SetValue", new object[2]
			{
				"U0004",
				des.Encrypt(text6)
			}, null, null, null, IgnoreReturn: true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string text7 = "Failed";
			ProjectData.ClearProjectError();
		}
		string text8 = text3 + "," + text4 + "," + text5 + "," + text6;
		MyProject.Forms.MachineSetup.MessageBoxChange(text8);
		if ((Operators.CompareString(text3, "", TextCompare: false) > 0) & (Operators.CompareString(text4, "", TextCompare: false) > 0) & (Operators.CompareString(text5, "", TextCompare: false) > 0) & (Operators.CompareString(text6, "", TextCompare: false) > 0) & (Operators.CompareString(setting, "0", TextCompare: false) != 0))
		{
			string text9 = DirCreate(drive, text2);
			text9 = Conversions.ToString(CreateFile(drive, text2 + text, false));
			if (Operators.CompareString(text9, "Failed", TextCompare: false) == 0)
			{
				flag = false;
			}
			else
			{
				WriteInformationFile(drive, text2, text, text8, newfile: true);
				SetAttributes(drive, text2, true);
				SetAttributes(drive, text2 + text, true);
				flag = true;
			}
		}
		return flag;
	}

	public static string WriteInformationFile(string Drive, string Dir, string Path, string FileTextString, bool newfile)
	{
		string text = ((Operators.CompareString(Drive, "C:", TextCompare: false) != 0) ? "Done" : DirCreate(Drive, Dir));
		if ((Operators.CompareString(text, "Done", TextCompare: false) == 0) | (Operators.CompareString(text, "Exists", TextCompare: false) == 0))
		{
			if (Operators.CompareString(FileTextString, "", TextCompare: false) != 0)
			{
				try
				{
					if (!newfile)
					{
						text = Conversions.ToString(TextAppend(Drive + Dir + Path, FileTextString));
					}
					else
					{
						if (File.Exists(Drive + Dir + Path))
						{
							File.Delete(Drive + Dir + Path);
						}
						text = Conversions.ToString(TextCreate(Drive + Dir + Path, FileTextString));
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					text = "Failed";
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				text = "Failed";
			}
		}
		return text;
	}

	public static object WriteRemoteFileA(object Drive, object Dir, object Path, object FileTextString, object newfile, object Attribute)
	{
		string text = DirCreate(Conversions.ToString(Drive), Conversions.ToString(Dir));
		if ((Operators.CompareString(text, "Done", TextCompare: false) == 0) | (Operators.CompareString(text, "Exists", TextCompare: false) == 0))
		{
			if (Operators.ConditionalCompareObjectEqual(newfile, false, TextCompare: false))
			{
				text = Conversions.ToString(TextAppend(Operators.ConcatenateObject(Operators.ConcatenateObject(Drive, Dir), Path), RuntimeHelpers.GetObjectValue(FileTextString)));
			}
			else
			{
				try
				{
					text = Conversions.ToString(TextCreate(Operators.ConcatenateObject(Operators.ConcatenateObject(Drive, Dir), Path), RuntimeHelpers.GetObjectValue(FileTextString)));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(text, "Failed", TextCompare: false) != 0, Operators.CompareObjectEqual(Attribute, true, TextCompare: false))))
		{
			SetAttributes(RuntimeHelpers.GetObjectValue(Drive), Operators.ConcatenateObject(Dir, "\\"), true);
			SetAttributes(RuntimeHelpers.GetObjectValue(Drive), Operators.ConcatenateObject(Dir, Path), true);
		}
		return text;
	}

	public static string WriteRemoteFile(object Drive, object Dir, object Path, object FileTextString, object newfile, object Attribute, object Existing)
	{
		string text = ((!Operators.ConditionalCompareObjectEqual(Existing, false, TextCompare: false)) ? "Exists" : DirCreate(Conversions.ToString(Drive), Conversions.ToString(Dir)));
		if ((Operators.CompareString(text, "Done", TextCompare: false) == 0) | (Operators.CompareString(text, "Exists", TextCompare: false) == 0))
		{
			if (Operators.ConditionalCompareObjectEqual(newfile, false, TextCompare: false))
			{
				try
				{
					text = Conversions.ToString(TextAppend(Operators.ConcatenateObject(Operators.ConcatenateObject(Drive, Dir), Path), RuntimeHelpers.GetObjectValue(FileTextString)));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				try
				{
					text = Conversions.ToString(TextCreate(Operators.ConcatenateObject(Operators.ConcatenateObject(Drive, Dir), Path), RuntimeHelpers.GetObjectValue(FileTextString)));
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
		}
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(text, "Failed", TextCompare: false) != 0, Operators.CompareObjectEqual(Attribute, true, TextCompare: false))))
		{
			SetAttributes(RuntimeHelpers.GetObjectValue(Drive), Operators.ConcatenateObject(Dir, "\\"), true);
			SetAttributes(RuntimeHelpers.GetObjectValue(Drive), Operators.ConcatenateObject(Dir, Path), true);
		}
		return text;
	}

	public static string ReadRemoteFile(string Drive, string Direct, string Path, bool CheckExist)
	{
		string text = "";
		string text2 = "";
		bool flag = false;
		try
		{
			StreamReader streamReader = new StreamReader(Drive + Direct + Path);
			do
			{
				text = streamReader.ReadLine();
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					text2 = text2 + text + ",";
				}
				Application.DoEvents();
			}
			while (text != null);
			streamReader.Close();
			DeleteFile(Drive, Direct + Path);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			text2 = "Failed";
			ProjectData.ClearProjectError();
		}
		return text2;
	}

	public static object DeleteFile(object Drive, object Path)
	{
		bool flag = false;
		try
		{
			MyProject.Computer.FileSystem.DeleteFile(Conversions.ToString(Operators.ConcatenateObject(Drive, Path)), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing);
			flag = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static object TextAppend(object FileName, object FileTextString)
	{
		string result;
		try
		{
			StreamWriter streamWriter = File.AppendText(Conversions.ToString(FileName));
			string[] array = Strings.Split(Conversions.ToString(FileTextString), ",");
			int num = Microsoft.VisualBasic.Information.UBound(array);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string value = array[i];
				streamWriter.WriteLine(value);
			}
			streamWriter.Close();
			result = "Done";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "Failed";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object TextCreate(object FileName, object FileTextString)
	{
		string result;
		try
		{
			StreamWriter streamWriter = File.CreateText(Conversions.ToString(FileName));
			string[] array = Strings.Split(Conversions.ToString(FileTextString), ",");
			int num = Microsoft.VisualBasic.Information.UBound(array);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string value = array[i];
				streamWriter.WriteLine(value);
			}
			streamWriter.Close();
			result = "Done";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "Failed";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string GetProcessorId()
	{
		string result = string.Empty;
		SelectQuery query = new SelectQuery("Win32_processor");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
		foreach (ManagementObject item in managementObjectSearcher.Get())
		{
			result = item["processorId"].ToString();
		}
		return result;
	}

	public static string GetMACAddress()
	{
		ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
		ManagementObjectCollection instances = managementClass.GetInstances();
		string text = string.Empty;
		foreach (ManagementObject item in instances)
		{
			if (text.Equals(string.Empty))
			{
				if (Conversions.ToBoolean(item["IPEnabled"]))
				{
					text = item["MacAddress"].ToString();
				}
				item.Dispose();
			}
			text = text.Replace(":", string.Empty);
		}
		return text;
	}

	public static string GetVolumeSerial(string strDriveLetter = "C")
	{
		ManagementObject managementObject = new ManagementObject($"win32_logicaldisk.deviceid=\"{strDriveLetter}:\"");
		managementObject.Get();
		return managementObject["VolumeSerialNumber"].ToString();
	}

	public static string GetMotherBoardID()
	{
		string result = string.Empty;
		SelectQuery query = new SelectQuery("Win32_BaseBoard");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
		foreach (ManagementObject item in managementObjectSearcher.Get())
		{
			result = item["SerialNumber"].ToString();
		}
		return result;
	}

	public static string GetSerialNumberFromDriveLetter(string driveLetter)
	{
		if (!driveLetter.EndsWith(":"))
		{
			driveLetter += ":";
		}
		return MatchDriveLetterWithSerial(driveLetter);
	}

	private static string MatchDriveLetterWithSerial(string driveLetter)
	{
		string result = "";
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDiskToPartition");
		try
		{
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				string[] array = null;
				string valueInQuotes = GetValueInQuotes(item["Dependent"].ToString());
				array = GetValueInQuotes(item["Antecedent"].ToString()).Split(',');
				string text = array[0].Remove(0, 6).Trim();
				if (Operators.CompareString(valueInQuotes, driveLetter, TextCompare: false) != 0)
				{
					continue;
				}
				ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
				foreach (ManagementObject item2 in managementObjectSearcher2.Get())
				{
					if ((Operators.CompareString(item2["Name"].ToString(), "\\\\.\\PHYSICALDRIVE" + text, TextCompare: false) == 0) & (Operators.CompareString(item2["InterfaceType"].ToString(), "USB", TextCompare: false) == 0))
					{
						result = ParseSerialFromDeviceID(item2["PNPDeviceID"].ToString());
						break;
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
		return result;
	}

	private static string ParseSerialFromDeviceID(string deviceId)
	{
		string[] array = deviceId.Split('\\');
		int num = checked(array.Length - 1);
		string[] array2 = array[num].Split('&');
		return array2[0];
	}

	private static string GetValueInQuotes(string inValue)
	{
		string text = "";
		int num = 0;
		int num2 = 0;
		num = inValue.IndexOf("\"");
		checked
		{
			num2 = inValue.IndexOf("\"", num + 1);
			return inValue.Substring(num + 1, num2 - num - 1);
		}
	}

	public static string GetDriveSerialNumber()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject"));
		object instance = objectValue;
		object[] array = new object[1];
		object instance2 = objectValue;
		object[] array2 = new object[1];
		object obj = (array2[0] = AppDomain.CurrentDomain.BaseDirectory);
		array[0] = NewLateBinding.LateGet(instance2, null, "GetDriveName", array2, null, null, null);
		object[] array3 = array;
		bool[] obj2 = new bool[1] { true };
		bool[] array4 = obj2;
		object obj3 = NewLateBinding.LateGet(instance, null, "GetDrive", array, null, null, obj2);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(instance2, null, "GetDriveName", new object[2]
			{
				obj,
				array3[0]
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
		object instance3 = objectValue2;
		long number = ((!Conversions.ToBoolean(NewLateBinding.LateGet(instance3, null, "IsReady", new object[0], null, null, null))) ? (-1) : Conversions.ToLong(NewLateBinding.LateGet(instance3, null, "SerialNumber", new object[0], null, null, null)));
		instance3 = null;
		objectValue2 = null;
		objectValue = null;
		return Conversion.Hex(number);
	}

	public static object FormVisable(Form targetForm)
	{
		foreach (Form openForm in Application.OpenForms)
		{
			if (openForm.Visible && openForm == targetForm)
			{
				return true;
			}
		}
		return false;
	}

	public static void MainMapDriveLan(object Client)
	{
		string setting = Interaction.GetSetting("Dtread", "Aqua", "LanDriveMapLetter", "R");
		UnMapDrive(setting);
		MapDrive(setting, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("\\\\", Client), "\\Public")));
	}

	public static void MainUnMapDriveLan()
	{
		string setting = Interaction.GetSetting("Dtread", "Aqua", "LanDriveMapLetter", "R");
		UnMapDrive(setting);
	}

	public static void MainMapDriveMemory(object Client)
	{
		MemoryDrive = false;
		if (Strings.Len(Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M")) == 1)
		{
			string setting = Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M");
			UnMapDrive(setting);
			MemoryDrive = MapDrive(setting, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("\\\\", Client), "\\Public")));
		}
	}

	public static void MainUnMapDriveMemory()
	{
		MemoryDrive = false;
		if (Strings.Len(Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M")) == 1)
		{
			string setting = Interaction.GetSetting("Dtread", "Aqua", "MemDriveMapLetter", "M");
			UnMapDrive(setting);
		}
	}

	public static bool MapDrive(string DriveLetter, string UNCPath)
	{
		NETRESOURCE lpNetResource = new NETRESOURCE
		{
			lpRemoteName = UNCPath,
			lpLocalName = DriveLetter + ":"
		};
		string lpUserName = null;
		string lpPassword = null;
		lpNetResource.dwType = 1;
		if (SafeNativeMethods.WNetAddConnection2(ref lpNetResource, ref lpPassword, ref lpUserName, 0) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool UnMapDrive1(string DriveLetter)
	{
		string lpName = DriveLetter + ":";
		if (SafeNativeMethods.WNetCancelConnection2(ref lpName, 0, 1) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool UnMapDrive(string DriveLetter)
	{
		string lpName = DriveLetter + ":";
		if (SafeNativeMethods.WNetCancelConnection2(ref lpName, 0, 1) == 0)
		{
			return true;
		}
		return false;
	}

	public static string CheckFileName(string Drive, string FileName, string Ext, Version FileVersionNo, bool VersionCheck)
	{
		if (!FileExist(Drive, FileName + Ext))
		{
			string[] files = Directory.GetFiles(Drive, "*" + Ext);
			string[] array = files;
			foreach (string text in array)
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(text);
				Version version = new Version(versionInfo.FileVersion);
				if ((version.CompareTo(FileVersionNo) > 0 || !VersionCheck) && Operators.CompareString(Strings.Mid(text, checked(Strings.Len(Drive) + 1), Strings.Len(FileName)), FileName, TextCompare: false) == 0)
				{
					FileRename(Drive, checked(Strings.Mid(text, Strings.Len(Drive) + 1, Strings.Len(text) - 3)), FileName + Ext);
				}
			}
		}
		string result = default(string);
		return result;
	}

	public static bool CopyFiles(string sourceDir, string filename, string backupDir)
	{
		bool result = default(bool);
		try
		{
			string sourceFileName = sourceDir + filename;
			object obj = backupDir + filename;
			File.Copy(sourceFileName, Conversions.ToString(obj), overwrite: true);
			result = true;
		}
		catch (IOException ex)
		{
			ProjectData.SetProjectError(ex);
			IOException ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string RegUpdate(string Address1, string Address2, string Address3, string Data, string State)
	{
		if (Operators.CompareString(State, "Save", TextCompare: false) == 0)
		{
			Interaction.SaveSetting(Address1, Address2, Address3, Data);
			return Interaction.GetSetting(Address1, Address2, Address3, Data);
		}
		return Interaction.GetSetting(Address1, Address2, Address3, Data);
	}

	public static bool IsEven(int numToCheck)
	{
		return (numToCheck & 1) == 0;
	}

	public static bool InternetConnection()
	{
		bool result;
		try
		{
			result = MyProject.Computer.Network.Ping("www.onedrive.live.com");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool CheckIfRunning(string ProcessName)
	{
		Process[] processesByName = Process.GetProcessesByName(ProcessName);
		if (processesByName.Length > 0)
		{
			return true;
		}
		return false;
	}
}
