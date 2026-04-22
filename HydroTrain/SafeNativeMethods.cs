using System.Runtime.InteropServices;

namespace HydroTrain;

internal class SafeNativeMethods
{
	[DllImport("mpr.dll", CharSet = CharSet.Ansi, EntryPoint = "WNetAddConnection2A", ExactSpelling = true, SetLastError = true)]
	public static extern int WNetAddConnection2(ref Functions.NETRESOURCE lpNetResource, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpPassword, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpUserName, int dwFlags);

	[DllImport("mpr", CharSet = CharSet.Ansi, EntryPoint = "WNetCancelConnection2A", ExactSpelling = true, SetLastError = true)]
	public static extern int WNetCancelConnection2([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpName, int dwFlags, int fForce);
}
