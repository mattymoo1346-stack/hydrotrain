using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] Args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		MyProject.Application.Run(Args);
	}

	private void MyApplication_Startup(object sender, StartupEventArgs e)
	{
	}

	private void MyApplication_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
	{
		string text = "/input=";
		string text2 = "";
		foreach (string item in e.CommandLine)
		{
			if (item.ToLower().StartsWith(text))
			{
				text2 = item.Remove(0, text.Length);
			}
		}
		if (Operators.CompareString(text2, "", TextCompare: false) == 0)
		{
			Interaction.MsgBox("No input name");
		}
		else
		{
			Interaction.MsgBox("Input name: " + text2);
		}
	}

	private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
	{
		MyProject.Application.Log.WriteException(e.Exception, TraceEventType.Critical, "Unhandled Exception.");
	}

	public void MyApplication_Application_Error(object sender, EventArgs e)
	{
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base(AuthenticationMode.Windows)
	{
		base.Startup += MyApplication_Startup;
		base.StartupNextInstance += MyApplication_StartupNextInstance;
		base.UnhandledException += MyApplication_UnhandledException;
		base.UnhandledException += MyApplication_Application_Error;
		base.IsSingleInstance = false;
		base.EnableVisualStyles = false;
		base.SaveMySettingsOnExit = true;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		base.MainForm = MyProject.Forms.Display;
	}

	[DebuggerStepThrough]
	protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
	{
		base.MinimumSplashScreenDisplayTime = 0;
		return base.OnInitialize(commandLineArgs);
	}
}
