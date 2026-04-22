using System;
using System.Runtime.InteropServices;
using HydroTrain.My;

namespace HydroTrain;

public class NativeMethods
{
	public const long WM_SYSCOMMAND = 274L;

	public const long SC_MONITORPOWER = 61808L;

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "PostMessageA", ExactSpelling = true, SetLastError = true)]
	private static extern int PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

	public static void TurnOffScreen()
	{
		PostMessage(MyProject.Forms.Display.Handle, 274, 61808, 2);
	}

	public static void TurnOnScreen()
	{
		PostMessage(MyProject.Forms.Display.Handle, 274, 61808, -1);
	}
}
