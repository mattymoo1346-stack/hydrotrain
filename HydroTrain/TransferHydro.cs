using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace HydroTrain;

[DesignerGenerated]
public class TransferHydro : Form
{
	public delegate void SetControlCallback(string ControlNameA, string ControlName, string Data);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ReadOpenbtn")]
	private Button _ReadOpenbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ReadOneDrivebtn")]
	private Button _ReadOneDrivebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Invisible")]
	private Button _Invisible;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Writebtn")]
	private Button _Writebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ReadRegbtn")]
	private Button _ReadRegbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LocalNetwork")]
	private Button _LocalNetwork;

	public static bool Startup = false;

	[field: AccessedThroughProperty("ReadWrite")]
	internal virtual GroupBox ReadWrite
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button ReadOpenbtn
	{
		[CompilerGenerated]
		get
		{
			return _ReadOpenbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ReadOpenbtn_Click;
			Button button = _ReadOpenbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ReadOpenbtn = value;
			button = _ReadOpenbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button ReadOneDrivebtn
	{
		[CompilerGenerated]
		get
		{
			return _ReadOneDrivebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ReadOneDrivebtn_Click;
			Button button = _ReadOneDrivebtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ReadOneDrivebtn = value;
			button = _ReadOneDrivebtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	internal virtual Button Writebtn
	{
		[CompilerGenerated]
		get
		{
			return _Writebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Writebtn_Click;
			Button button = _Writebtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Writebtn = value;
			button = _Writebtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button ReadRegbtn
	{
		[CompilerGenerated]
		get
		{
			return _ReadRegbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ReadRegbtn_Click;
			Button button = _ReadRegbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_ReadRegbtn = value;
			button = _ReadRegbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button LocalNetwork
	{
		[CompilerGenerated]
		get
		{
			return _LocalNetwork;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = LocalNetwork_Click;
			Button button = _LocalNetwork;
			if (button != null)
			{
				button.Click -= value2;
			}
			_LocalNetwork = value;
			button = _LocalNetwork;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	public TransferHydro()
	{
		base.Load += TransferHydro_Load;
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
		this.ReadWrite = new System.Windows.Forms.GroupBox();
		this.LocalNetwork = new System.Windows.Forms.Button();
		this.ReadOpenbtn = new System.Windows.Forms.Button();
		this.ReadOneDrivebtn = new System.Windows.Forms.Button();
		this.Invisible = new System.Windows.Forms.Button();
		this.Writebtn = new System.Windows.Forms.Button();
		this.ReadRegbtn = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.ReadWrite.SuspendLayout();
		base.SuspendLayout();
		this.ReadWrite.Controls.Add(this.Label3);
		this.ReadWrite.Controls.Add(this.Label4);
		this.ReadWrite.Controls.Add(this.Label2);
		this.ReadWrite.Controls.Add(this.Label1);
		this.ReadWrite.Controls.Add(this.LocalNetwork);
		this.ReadWrite.Controls.Add(this.ReadOpenbtn);
		this.ReadWrite.Controls.Add(this.ReadOneDrivebtn);
		this.ReadWrite.Controls.Add(this.Invisible);
		this.ReadWrite.Controls.Add(this.Writebtn);
		this.ReadWrite.Controls.Add(this.ReadRegbtn);
		this.ReadWrite.Location = new System.Drawing.Point(4, 0);
		this.ReadWrite.Name = "ReadWrite";
		this.ReadWrite.Size = new System.Drawing.Size(383, 445);
		this.ReadWrite.TabIndex = 6;
		this.ReadWrite.TabStop = false;
		this.LocalNetwork.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.LocalNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.LocalNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.LocalNetwork.Location = new System.Drawing.Point(21, 22);
		this.LocalNetwork.Name = "LocalNetwork";
		this.LocalNetwork.Size = new System.Drawing.Size(103, 43);
		this.LocalNetwork.TabIndex = 5;
		this.LocalNetwork.Text = "Local Network Setup";
		this.LocalNetwork.UseVisualStyleBackColor = false;
		this.ReadOpenbtn.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.ReadOpenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.ReadOpenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ReadOpenbtn.Location = new System.Drawing.Point(32, 270);
		this.ReadOpenbtn.Name = "ReadOpenbtn";
		this.ReadOpenbtn.Size = new System.Drawing.Size(160, 60);
		this.ReadOpenbtn.TabIndex = 4;
		this.ReadOpenbtn.Text = "Read From Public/Open";
		this.ReadOpenbtn.UseVisualStyleBackColor = false;
		this.ReadOneDrivebtn.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.ReadOneDrivebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.ReadOneDrivebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ReadOneDrivebtn.Location = new System.Drawing.Point(32, 190);
		this.ReadOneDrivebtn.Name = "ReadOneDrivebtn";
		this.ReadOneDrivebtn.Size = new System.Drawing.Size(160, 60);
		this.ReadOneDrivebtn.TabIndex = 3;
		this.ReadOneDrivebtn.Text = "Read From OneDrive";
		this.ReadOneDrivebtn.UseVisualStyleBackColor = false;
		this.Invisible.BackColor = System.Drawing.Color.Yellow;
		this.Invisible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Invisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Invisible.Location = new System.Drawing.Point(316, 19);
		this.Invisible.Name = "Invisible";
		this.Invisible.Size = new System.Drawing.Size(50, 50);
		this.Invisible.TabIndex = 2;
		this.Invisible.Text = "X";
		this.Invisible.UseVisualStyleBackColor = false;
		this.Writebtn.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.Writebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Writebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Writebtn.Location = new System.Drawing.Point(32, 372);
		this.Writebtn.Name = "Writebtn";
		this.Writebtn.Size = new System.Drawing.Size(160, 57);
		this.Writebtn.TabIndex = 1;
		this.Writebtn.Text = "Write All";
		this.Writebtn.UseVisualStyleBackColor = false;
		this.ReadRegbtn.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.ReadRegbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.ReadRegbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ReadRegbtn.Location = new System.Drawing.Point(32, 110);
		this.ReadRegbtn.Name = "ReadRegbtn";
		this.ReadRegbtn.Size = new System.Drawing.Size(160, 60);
		this.ReadRegbtn.TabIndex = 0;
		this.ReadRegbtn.Text = "Read From Registry";
		this.ReadRegbtn.UseVisualStyleBackColor = false;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(198, 119);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(155, 48);
		this.Label1.TabIndex = 6;
		this.Label1.Text = "Read Registry Data and \r\ntransfer to USB memory \r\ndrive. ";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(198, 199);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(152, 48);
		this.Label2.TabIndex = 7;
		this.Label2.Text = "Read History Data from \r\nOnedrive and transfer to \r\nUSB memory drive. ";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.White;
		this.Label4.Location = new System.Drawing.Point(198, 379);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(168, 32);
		this.Label4.TabIndex = 9;
		this.Label4.Text = "Read all Data from USB \r\nmemory drive and transfer. ";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.White;
		this.Label3.Location = new System.Drawing.Point(201, 282);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(171, 48);
		this.Label3.TabIndex = 10;
		this.Label3.Text = "Read History Data from \r\nPublic/Open and transfer to \r\nUSB memory drive. ";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
		base.ClientSize = new System.Drawing.Size(397, 453);
		base.Controls.Add(this.ReadWrite);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "TransferHydro";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "TransferHydro";
		base.TopMost = true;
		this.ReadWrite.ResumeLayout(false);
		this.ReadWrite.PerformLayout();
		base.ResumeLayout(false);
	}

	private void ReadRegbtn_Click(object sender, EventArgs e)
	{
		SelectColour("ReadWrite", "ReadRegbtn", "DarkViolet");
		ReadOneDrivebtn.Enabled = false;
		ReadOpenbtn.Enabled = false;
		ReadRegbtn.Enabled = false;
		Writebtn.Enabled = false;
		TransReadReg();
	}

	private void ReadOneDrivebtn_Click(object sender, EventArgs e)
	{
		SelectColour("ReadWrite", "ReadOneDrivebtn", "DarkViolet");
		ReadOneDrivebtn.Enabled = false;
		ReadOpenbtn.Enabled = false;
		ReadRegbtn.Enabled = false;
		Writebtn.Enabled = false;
		TransReadOneDrive();
	}

	private void ReadOpenbtn_Click(object sender, EventArgs e)
	{
		SelectColour("ReadWrite", "ReadOpenbtn", "DarkViolet");
		ReadOneDrivebtn.Enabled = false;
		ReadOpenbtn.Enabled = false;
		ReadRegbtn.Enabled = false;
		Writebtn.Enabled = false;
		TransReadOpen();
	}

	private void Writebtn_Click(object sender, EventArgs e)
	{
		SelectColour("ReadWrite", "Writebtn", "DarkViolet");
		ReadOneDrivebtn.Enabled = false;
		ReadOpenbtn.Enabled = false;
		ReadRegbtn.Enabled = false;
		Writebtn.Enabled = false;
		TransWrite();
	}

	private void ClearButtons()
	{
		ReadOneDrivebtn.Enabled = true;
		ReadOpenbtn.Enabled = true;
		ReadRegbtn.Enabled = true;
		Writebtn.Enabled = true;
		SelectColour("ReadWrite", "ReadRegbtn", "OrangeRed");
		SelectColour("ReadWrite", "ReadOneDrivebtn", "OrangeRed");
		SelectColour("ReadWrite", "ReadOpenbtn", "OrangeRed");
		SelectColour("ReadWrite", "Writebtn", "OrangeRed");
	}

	private void SelectColour(string ControlNameA, string ControlName, string SetColour)
	{
		try
		{
			if (base.Controls[ControlNameA].Controls[ControlName].InvokeRequired)
			{
				SetControlCallback method = SelectColour;
				Invoke(method, ControlNameA, ControlName, SetColour);
			}
			else if (Operators.CompareString(SetColour, "DarkViolet", TextCompare: false) == 0)
			{
				base.Controls[ControlNameA].Controls[ControlName].BackColor = Color.DarkViolet;
			}
			else
			{
				base.Controls[ControlNameA].Controls[ControlName].BackColor = Color.OrangeRed;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void TransReadReg()
	{
		object instance = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Treadmill\\ByteSet\\\\", writable: true);
		object instance2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Treadmill\\ByteSetDeg\\\\", writable: true);
		object instance3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Treadmill\\Health\\\\", writable: true);
		object instance4 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Dtread\\Setup\\\\", writable: true);
		object instance5 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Health\\Setup\\\\", writable: true);
		object instance6 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Dtread\\Aqua\\\\", writable: true);
		object instance7 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Dtread\\File\\\\", writable: true);
		object instance8 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Machine\\Passed\\\\", writable: true);
		string text = "0";
		string text2 = ",";
		string text3 = ";";
		int num = 0;
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		do
		{
			try
			{
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(instance, null, "GetValue", new object[1] { "Byte" + num }, null, null, null), "", TextCompare: false))
				{
					text4 = ((Operators.CompareString(text4, "", TextCompare: false) != 0) ? Conversions.ToString(Operators.ConcatenateObject(text4 + text3, NewLateBinding.LateGet(instance, null, "GetValue", new object[1] { "Byte" + num }, null, null, null))) : Conversions.ToString(NewLateBinding.LateGet(instance, null, "GetValue", new object[1] { "Byte" + num }, null, null, null)));
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
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(instance2, null, "GetValue", new object[1] { "Byte" + num }, null, null, null), "", TextCompare: false))
				{
					text5 = ((Operators.CompareString(text5, "", TextCompare: false) != 0) ? Conversions.ToString(Operators.ConcatenateObject(text5 + text3, NewLateBinding.LateGet(instance2, null, "GetValue", new object[1] { "Byte" + num }, null, null, null))) : Conversions.ToString(NewLateBinding.LateGet(instance2, null, "GetValue", new object[1] { "Byte" + num }, null, null, null)));
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(instance4, null, "GetValue", new object[1] { "RPMInd" + num }, null, null, null), "", TextCompare: false))
				{
					text6 = ((Operators.CompareString(text6, "", TextCompare: false) != 0) ? Conversions.ToString(Operators.ConcatenateObject(text6 + text3, NewLateBinding.LateGet(instance4, null, "GetValue", new object[1] { "RPMInd" + num }, null, null, null))) : Conversions.ToString(NewLateBinding.LateGet(instance4, null, "GetValue", new object[1] { "RPMInd" + num }, null, null, null)));
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(instance4, null, "GetValue", new object[1] { "DegInd" + num }, null, null, null), "", TextCompare: false))
				{
					text = ((Operators.CompareString(text, "", TextCompare: false) != 0) ? Conversions.ToString(Operators.ConcatenateObject(text + text3, NewLateBinding.LateGet(instance4, null, "GetValue", new object[1] { "DegInd" + num }, null, null, null))) : Conversions.ToString(NewLateBinding.LateGet(instance4, null, "GetValue", new object[1] { "DegInd" + num }, null, null, null)));
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ProjectData.ClearProjectError();
			}
			num = checked(num + 1);
		}
		while (num <= 200);
		string left;
		try
		{
			left = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(instance5, null, "GetValue", new object[1] { "DeadbandSet" }, null, null, null), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance5, null, "GetValue", new object[1] { "DeadbandGradSet" }, null, null, null)), text3));
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			left = ";;";
			ProjectData.ClearProjectError();
		}
		try
		{
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance3, null, "GetValue", new object[1] { "Lock" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance3, null, "GetValue", new object[1] { "Net" }, null, null, null)), text3));
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			left += ";;";
			ProjectData.ClearProjectError();
		}
		try
		{
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "Voice" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "Incline" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "FloatSw" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "JetOnOff" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "DoorSensors" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "TempGauge" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "Reverse" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "HeatCircFitted" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "UVCLampFitted" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "PDFOrPrint" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "CalorieIndWet" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "DepthAdjustOnOff" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "CleanOnOff" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "CleanTimer" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "TimerBox" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "Gearbox" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "BedLength" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "MaxBedHeight" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "CustomerName" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "MaxRPM" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "Maxkph" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthSet" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "FloatSwDepth" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "DrumCircumferenceSet" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "LanDriveMapLetter" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "MemDriveMapLetter" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "DisplayLevels" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange0Minus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange0Plus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange10Minus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange10Plus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange20Minus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange20Plus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange30Minus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange30Plus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange40Minus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange40Plus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange50Minus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange50Plus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange60Minus" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance6, null, "GetValue", new object[1] { "WaterDepthRange60Plus" }, null, null, null)), text3));
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			left += ";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;";
			ProjectData.ClearProjectError();
		}
		try
		{
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance7, null, "GetValue", new object[1] { "SerialFile" }, null, null, null)), text3));
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance7, null, "GetValue", new object[1] { "SerialFile1" }, null, null, null)), text3));
		}
		catch (Exception ex15)
		{
			ProjectData.SetProjectError(ex15);
			Exception ex16 = ex15;
			left += ";;";
			ProjectData.ClearProjectError();
		}
		try
		{
			left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(left, NewLateBinding.LateGet(instance8, null, "GetValue", new object[1] { "MpgOrMm" }, null, null, null)), text3));
		}
		catch (Exception ex17)
		{
			ProjectData.SetProjectError(ex17);
			Exception ex18 = ex17;
			left += ";";
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text4, "", TextCompare: false) == 0)
		{
			text4 = "0";
		}
		if (Operators.CompareString(text5, "", TextCompare: false) == 0)
		{
			text5 = "0";
		}
		if (Operators.CompareString(text6, "", TextCompare: false) == 0)
		{
			text6 = "0";
		}
		if (Operators.CompareString(text, "", TextCompare: false) == 0)
		{
			text = "0";
		}
		if (Operators.CompareString(left, "", TextCompare: false) == 0)
		{
			left = "0";
		}
		try
		{
			string text7 = Functions.GetDrive();
			string path = "\\Transfer.txt";
			string fileTextString = text4 + text2 + text5 + text2 + text6 + text2 + text + text2 + left + "END";
			string dir = default(string);
			if (Operators.CompareString(text7, "", TextCompare: false) == 0)
			{
				text7 = "C:";
				dir = "/" + Functions.SerialNo;
			}
			Functions.WriteInformationFile(text7, dir, path, fileTextString, newfile: true);
		}
		catch (Exception ex19)
		{
			ProjectData.SetProjectError(ex19);
			Exception ex20 = ex19;
			ProjectData.ClearProjectError();
		}
		ClearButtons();
	}

	private void TransReadOneDrive()
	{
		string text = Conversions.ToString(Functions.GetDirectories("C:\\Users\\", "\\OneDrive"));
		string drive = Functions.GetDrive();
		try
		{
			Functions.DirectoryCopy(text + "\\DWS-History", drive + "\\DWS-History", ok: true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		ClearButtons();
	}

	private void TransReadOpen()
	{
		string text = Conversions.ToString(Functions.GetDirectories("C:\\Users\\", "\\OneDrive"));
		string drive = Functions.GetDrive();
		try
		{
			Functions.DirectoryCopy("C:\\Users\\Public\\Open\\DWS-History", drive + "\\DWS-History", ok: true);
			Functions.DirectoryCopy("C:\\Users\\Public\\Open\\DWS", drive + "\\DWS", ok: true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		ClearButtons();
	}

	public void TransWrite()
	{
		object instance = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\VB and VBA Program Settings\\\\Treadmill\\\\ByteSet\\\\", writable: true);
		object instance2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\VB and VBA Program Settings\\\\Treadmill\\\\ByteSetDeg\\\\", writable: true);
		object instance3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\VB and VBA Program Settings\\\\Treadmill\\Health\\\\", writable: true);
		object instance4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\VB and VBA Program Settings\\\\Dtread\\\\Setup\\\\", writable: true);
		object instance5 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\VB and VBA Program Settings\\\\Health\\\\Setup\\\\", writable: true);
		object instance6 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\VB and VBA Program Settings\\\\Dtread\\Aqua\\\\", writable: true);
		object instance7 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\VB and VBA Program Settings\\\\Dtread\\\\File\\\\", writable: true);
		object instance8 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\VB and VBA Program Settings\\\\Machine\\\\Passed\\\\", writable: true);
		string text = ",";
		string text2 = ";";
		string drive = Functions.GetDrive();
		string path = "\\Transfer.txt";
		string direct = default(string);
		string expression = ReadTransferFile(drive, direct, path);
		Array array = Strings.Split(expression, ",");
		int num = Microsoft.VisualBasic.Information.UBound(array);
		checked
		{
			if (num == 5)
			{
				Array array2 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { 0 }, null)), ";");
				Array array3 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { 1 }, null)), ";");
				Array array4 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { 2 }, null)), ";");
				Array array5 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { 3 }, null)), ";");
				Array array6 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { 4 }, null)), ";");
				int num2 = Microsoft.VisualBasic.Information.UBound(array2);
				for (int i = 0; i <= num2; i++)
				{
					object[] obj = new object[2]
					{
						"Byte" + i,
						null
					};
					Array array7 = array2;
					Array instance9 = array7;
					object[] array8 = new object[1];
					object obj2 = (array8[0] = i);
					obj[1] = NewLateBinding.LateIndexGet(instance9, array8, null);
					object[] array9 = obj;
					bool[] array10;
					NewLateBinding.LateCall(instance, null, "SetValue", obj, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
				}
				int num3 = Microsoft.VisualBasic.Information.UBound(array3);
				for (int i = 0; i <= num3; i++)
				{
					object[] obj3 = new object[2]
					{
						"Byte" + i,
						null
					};
					Array array7 = array3;
					Array instance10 = array7;
					object[] array11 = new object[1];
					object obj2 = (array11[0] = i);
					obj3[1] = NewLateBinding.LateIndexGet(instance10, array11, null);
					object[] array9 = obj3;
					bool[] array10;
					NewLateBinding.LateCall(instance2, null, "SetValue", obj3, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
				}
				int num4 = Microsoft.VisualBasic.Information.UBound(array4);
				for (int i = 0; i <= num4; i++)
				{
					object[] obj4 = new object[2]
					{
						"RPMInd" + i,
						null
					};
					Array array7 = array4;
					Array instance11 = array7;
					object[] array12 = new object[1];
					object obj2 = (array12[0] = i);
					obj4[1] = NewLateBinding.LateIndexGet(instance11, array12, null);
					object[] array9 = obj4;
					bool[] array10;
					NewLateBinding.LateCall(instance4, null, "SetValue", obj4, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
				}
				int num5 = Microsoft.VisualBasic.Information.UBound(array5);
				for (int i = 0; i <= num5; i++)
				{
					object[] obj5 = new object[2]
					{
						"DegInd" + i,
						null
					};
					Array array7 = array5;
					Array instance12 = array7;
					object[] array13 = new object[1];
					object obj2 = (array13[0] = i);
					obj5[1] = NewLateBinding.LateIndexGet(instance12, array13, null);
					object[] array9 = obj5;
					bool[] array10;
					NewLateBinding.LateCall(instance4, null, "SetValue", obj5, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
				}
				int num6 = Microsoft.VisualBasic.Information.UBound(array6);
				if (num6 == 36)
				{
					int i = 0;
					object[] obj6 = new object[2] { "DeadbandSet", null };
					Array array7 = array6;
					Array instance13 = array7;
					object[] array14 = new object[1];
					object obj2 = (array14[0] = i);
					obj6[1] = NewLateBinding.LateIndexGet(instance13, array14, null);
					object[] array9 = obj6;
					bool[] obj7 = new bool[2] { false, true };
					bool[] array10 = obj7;
					NewLateBinding.LateCall(instance5, null, "SetValue", obj6, null, null, obj7, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj8 = new object[2] { "DeadbandGradSet", null };
					array7 = array6;
					Array instance14 = array7;
					object[] array15 = new object[1];
					obj2 = (array15[0] = i);
					obj8[1] = NewLateBinding.LateIndexGet(instance14, array15, null);
					array9 = obj8;
					NewLateBinding.LateCall(instance5, null, "SetValue", obj8, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj9 = new object[2] { "Lock", null };
					array7 = array6;
					Array instance15 = array7;
					object[] array16 = new object[1];
					obj2 = (array16[0] = i);
					obj9[1] = NewLateBinding.LateIndexGet(instance15, array16, null);
					array9 = obj9;
					NewLateBinding.LateCall(instance3, null, "SetValue", obj9, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj10 = new object[2] { "Net", null };
					array7 = array6;
					Array instance16 = array7;
					object[] array17 = new object[1];
					obj2 = (array17[0] = i);
					obj10[1] = NewLateBinding.LateIndexGet(instance16, array17, null);
					array9 = obj10;
					NewLateBinding.LateCall(instance3, null, "SetValue", obj10, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj11 = new object[2] { "Voice", null };
					array7 = array6;
					Array instance17 = array7;
					object[] array18 = new object[1];
					obj2 = (array18[0] = i);
					obj11[1] = NewLateBinding.LateIndexGet(instance17, array18, null);
					array9 = obj11;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj11, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj12 = new object[2] { "Incline", null };
					array7 = array6;
					Array instance18 = array7;
					object[] array19 = new object[1];
					obj2 = (array19[0] = i);
					obj12[1] = NewLateBinding.LateIndexGet(instance18, array19, null);
					array9 = obj12;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj12, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj13 = new object[2] { "FloatSw", null };
					array7 = array6;
					Array instance19 = array7;
					object[] array20 = new object[1];
					obj2 = (array20[0] = i);
					obj13[1] = NewLateBinding.LateIndexGet(instance19, array20, null);
					array9 = obj13;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj13, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj14 = new object[2] { "JetOnOff", null };
					array7 = array6;
					Array instance20 = array7;
					object[] array21 = new object[1];
					obj2 = (array21[0] = i);
					obj14[1] = NewLateBinding.LateIndexGet(instance20, array21, null);
					array9 = obj14;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj14, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj15 = new object[2] { "DoorSensors", null };
					array7 = array6;
					Array instance21 = array7;
					object[] array22 = new object[1];
					obj2 = (array22[0] = i);
					obj15[1] = NewLateBinding.LateIndexGet(instance21, array22, null);
					array9 = obj15;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj15, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj16 = new object[2] { "TempGauge", null };
					array7 = array6;
					Array instance22 = array7;
					object[] array23 = new object[1];
					obj2 = (array23[0] = i);
					obj16[1] = NewLateBinding.LateIndexGet(instance22, array23, null);
					array9 = obj16;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj16, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj17 = new object[2] { "Reverse", null };
					array7 = array6;
					Array instance23 = array7;
					object[] array24 = new object[1];
					obj2 = (array24[0] = i);
					obj17[1] = NewLateBinding.LateIndexGet(instance23, array24, null);
					array9 = obj17;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj17, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj18 = new object[2] { "HeatCircFitted", null };
					array7 = array6;
					Array instance24 = array7;
					object[] array25 = new object[1];
					obj2 = (array25[0] = i);
					obj18[1] = NewLateBinding.LateIndexGet(instance24, array25, null);
					array9 = obj18;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj18, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj19 = new object[2] { "UVCLampFitted", null };
					array7 = array6;
					Array instance25 = array7;
					object[] array26 = new object[1];
					obj2 = (array26[0] = i);
					obj19[1] = NewLateBinding.LateIndexGet(instance25, array26, null);
					array9 = obj19;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj19, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj20 = new object[2] { "PDFOrPrint", null };
					array7 = array6;
					Array instance26 = array7;
					object[] array27 = new object[1];
					obj2 = (array27[0] = i);
					obj20[1] = NewLateBinding.LateIndexGet(instance26, array27, null);
					array9 = obj20;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj20, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj21 = new object[2] { "CalorieIndWet", null };
					array7 = array6;
					Array instance27 = array7;
					object[] array28 = new object[1];
					obj2 = (array28[0] = i);
					obj21[1] = NewLateBinding.LateIndexGet(instance27, array28, null);
					array9 = obj21;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj21, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj22 = new object[2] { "DepthAdjustOnOff", null };
					array7 = array6;
					Array instance28 = array7;
					object[] array29 = new object[1];
					obj2 = (array29[0] = i);
					obj22[1] = NewLateBinding.LateIndexGet(instance28, array29, null);
					array9 = obj22;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj22, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj23 = new object[2] { "CleanOnOff", null };
					array7 = array6;
					Array instance29 = array7;
					object[] array30 = new object[1];
					obj2 = (array30[0] = i);
					obj23[1] = NewLateBinding.LateIndexGet(instance29, array30, null);
					array9 = obj23;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj23, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj24 = new object[2] { "CleanTimer", null };
					array7 = array6;
					Array instance30 = array7;
					object[] array31 = new object[1];
					obj2 = (array31[0] = i);
					obj24[1] = NewLateBinding.LateIndexGet(instance30, array31, null);
					array9 = obj24;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj24, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj25 = new object[2] { "TimerBox", null };
					array7 = array6;
					Array instance31 = array7;
					object[] array32 = new object[1];
					obj2 = (array32[0] = i);
					obj25[1] = NewLateBinding.LateIndexGet(instance31, array32, null);
					array9 = obj25;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj25, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj26 = new object[2] { "Gearbox", null };
					array7 = array6;
					Array instance32 = array7;
					object[] array33 = new object[1];
					obj2 = (array33[0] = i);
					obj26[1] = NewLateBinding.LateIndexGet(instance32, array33, null);
					array9 = obj26;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj26, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj27 = new object[2] { "BedLength", null };
					array7 = array6;
					Array instance33 = array7;
					object[] array34 = new object[1];
					obj2 = (array34[0] = i);
					obj27[1] = NewLateBinding.LateIndexGet(instance33, array34, null);
					array9 = obj27;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj27, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj28 = new object[2] { "MaxBedHeight", null };
					array7 = array6;
					Array instance34 = array7;
					object[] array35 = new object[1];
					obj2 = (array35[0] = i);
					obj28[1] = NewLateBinding.LateIndexGet(instance34, array35, null);
					array9 = obj28;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj28, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj29 = new object[2] { "CustomerName", null };
					array7 = array6;
					Array instance35 = array7;
					object[] array36 = new object[1];
					obj2 = (array36[0] = i);
					obj29[1] = NewLateBinding.LateIndexGet(instance35, array36, null);
					array9 = obj29;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj29, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj30 = new object[2] { "MaxRPM", null };
					array7 = array6;
					Array instance36 = array7;
					object[] array37 = new object[1];
					obj2 = (array37[0] = i);
					obj30[1] = NewLateBinding.LateIndexGet(instance36, array37, null);
					array9 = obj30;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj30, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj31 = new object[2] { "Maxkph", null };
					array7 = array6;
					Array instance37 = array7;
					object[] array38 = new object[1];
					obj2 = (array38[0] = i);
					obj31[1] = NewLateBinding.LateIndexGet(instance37, array38, null);
					array9 = obj31;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj31, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj32 = new object[2] { "WaterDepthSet", null };
					array7 = array6;
					Array instance38 = array7;
					object[] array39 = new object[1];
					obj2 = (array39[0] = i);
					obj32[1] = NewLateBinding.LateIndexGet(instance38, array39, null);
					array9 = obj32;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj32, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj33 = new object[2] { "FloatSwDepth", null };
					array7 = array6;
					Array instance39 = array7;
					object[] array40 = new object[1];
					obj2 = (array40[0] = i);
					obj33[1] = NewLateBinding.LateIndexGet(instance39, array40, null);
					array9 = obj33;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj33, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj34 = new object[2] { "DrumCircumferenceSet", null };
					array7 = array6;
					Array instance40 = array7;
					object[] array41 = new object[1];
					obj2 = (array41[0] = i);
					obj34[1] = NewLateBinding.LateIndexGet(instance40, array41, null);
					array9 = obj34;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj34, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj35 = new object[2] { "LanDriveMapLetter", null };
					array7 = array6;
					Array instance41 = array7;
					object[] array42 = new object[1];
					obj2 = (array42[0] = i);
					obj35[1] = NewLateBinding.LateIndexGet(instance41, array42, null);
					array9 = obj35;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj35, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj36 = new object[2] { "MemDriveMapLetter", null };
					array7 = array6;
					Array instance42 = array7;
					object[] array43 = new object[1];
					obj2 = (array43[0] = i);
					obj36[1] = NewLateBinding.LateIndexGet(instance42, array43, null);
					array9 = obj36;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj36, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj37 = new object[2] { "DisplayLevels", null };
					array7 = array6;
					Array instance43 = array7;
					object[] array44 = new object[1];
					obj2 = (array44[0] = i);
					obj37[1] = NewLateBinding.LateIndexGet(instance43, array44, null);
					array9 = obj37;
					NewLateBinding.LateCall(instance6, null, "SetValue", obj37, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj38 = new object[2] { "WaterDepthRange0Minus", null };
					array7 = array6;
					Array instance44 = array7;
					object[] array45 = new object[1];
					obj2 = (array45[0] = i);
					obj38[1] = NewLateBinding.LateIndexGet(instance44, array45, null);
					array9 = obj38;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj38, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj39 = new object[2] { "WaterDepthRange0Plus", null };
					array7 = array6;
					Array instance45 = array7;
					object[] array46 = new object[1];
					obj2 = (array46[0] = i);
					obj39[1] = NewLateBinding.LateIndexGet(instance45, array46, null);
					array9 = obj39;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj39, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj40 = new object[2] { "WaterDepthRange10Minus", null };
					array7 = array6;
					Array instance46 = array7;
					object[] array47 = new object[1];
					obj2 = (array47[0] = i);
					obj40[1] = NewLateBinding.LateIndexGet(instance46, array47, null);
					array9 = obj40;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj40, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj41 = new object[2] { "WaterDepthRange10Plus", null };
					array7 = array6;
					Array instance47 = array7;
					object[] array48 = new object[1];
					obj2 = (array48[0] = i);
					obj41[1] = NewLateBinding.LateIndexGet(instance47, array48, null);
					array9 = obj41;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj41, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj42 = new object[2] { "WaterDepthRange20Minus", null };
					array7 = array6;
					Array instance48 = array7;
					object[] array49 = new object[1];
					obj2 = (array49[0] = i);
					obj42[1] = NewLateBinding.LateIndexGet(instance48, array49, null);
					array9 = obj42;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj42, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj43 = new object[2] { "WaterDepthRange20Plus", null };
					array7 = array6;
					Array instance49 = array7;
					object[] array50 = new object[1];
					obj2 = (array50[0] = i);
					obj43[1] = NewLateBinding.LateIndexGet(instance49, array50, null);
					array9 = obj43;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj43, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj44 = new object[2] { "WaterDepthRange30Minus", null };
					array7 = array6;
					Array instance50 = array7;
					object[] array51 = new object[1];
					obj2 = (array51[0] = i);
					obj44[1] = NewLateBinding.LateIndexGet(instance50, array51, null);
					array9 = obj44;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj44, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj45 = new object[2] { "WaterDepthRange30Plus", null };
					array7 = array6;
					Array instance51 = array7;
					object[] array52 = new object[1];
					obj2 = (array52[0] = i);
					obj45[1] = NewLateBinding.LateIndexGet(instance51, array52, null);
					array9 = obj45;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj45, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj46 = new object[2] { "WaterDepthRange40Minus", null };
					array7 = array6;
					Array instance52 = array7;
					object[] array53 = new object[1];
					obj2 = (array53[0] = i);
					obj46[1] = NewLateBinding.LateIndexGet(instance52, array53, null);
					array9 = obj46;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj46, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj47 = new object[2] { "WaterDepthRange40Plus", null };
					array7 = array6;
					Array instance53 = array7;
					object[] array54 = new object[1];
					obj2 = (array54[0] = i);
					obj47[1] = NewLateBinding.LateIndexGet(instance53, array54, null);
					array9 = obj47;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj47, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj48 = new object[2] { "WaterDepthRange50Minus", null };
					array7 = array6;
					Array instance54 = array7;
					object[] array55 = new object[1];
					obj2 = (array55[0] = i);
					obj48[1] = NewLateBinding.LateIndexGet(instance54, array55, null);
					array9 = obj48;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj48, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj49 = new object[2] { "WaterDepthRange50Plus", null };
					array7 = array6;
					Array instance55 = array7;
					object[] array56 = new object[1];
					obj2 = (array56[0] = i);
					obj49[1] = NewLateBinding.LateIndexGet(instance55, array56, null);
					array9 = obj49;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj49, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj50 = new object[2] { "WaterDepthRange60Minus", null };
					array7 = array6;
					Array instance56 = array7;
					object[] array57 = new object[1];
					obj2 = (array57[0] = i);
					obj50[1] = NewLateBinding.LateIndexGet(instance56, array57, null);
					array9 = obj50;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj50, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj51 = new object[2] { "WaterDepthRange60Plus", null };
					array7 = array6;
					Array instance57 = array7;
					object[] array58 = new object[1];
					obj2 = (array58[0] = i);
					obj51[1] = NewLateBinding.LateIndexGet(instance57, array58, null);
					array9 = obj51;
					NewLateBinding.LateCall(instance6, null, "GetValue", obj51, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj52 = new object[2] { "SerialFile", null };
					array7 = array6;
					Array instance58 = array7;
					object[] array59 = new object[1];
					obj2 = (array59[0] = i);
					obj52[1] = NewLateBinding.LateIndexGet(instance58, array59, null);
					array9 = obj52;
					NewLateBinding.LateCall(instance7, null, "SetValue", obj52, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj53 = new object[2] { "SerialFile1", null };
					array7 = array6;
					Array instance59 = array7;
					object[] array60 = new object[1];
					obj2 = (array60[0] = i);
					obj53[1] = NewLateBinding.LateIndexGet(instance59, array60, null);
					array9 = obj53;
					NewLateBinding.LateCall(instance7, null, "SetValue", obj53, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
					object[] obj54 = new object[2] { "MpgOrMm", null };
					array7 = array6;
					Array instance60 = array7;
					object[] array61 = new object[1];
					obj2 = (array61[0] = i);
					obj54[1] = NewLateBinding.LateIndexGet(instance60, array61, null);
					array9 = obj54;
					NewLateBinding.LateCall(instance8, null, "SetValue", obj54, null, null, array10 = new bool[2] { false, true }, IgnoreReturn: true);
					if (array10[1])
					{
						NewLateBinding.LateIndexSetComplex(array7, new object[2]
						{
							obj2,
							array9[1]
						}, null, OptimisticSet: true, RValueBase: false);
					}
					i++;
				}
			}
			string mainDirName = Functions.GetMainDirName();
			string text3 = Conversions.ToString(Functions.GetDirectories("C:\\Users\\", "\\OneDrive"));
			if (Operators.CompareString(Functions.DirExist(text3, ""), "Exists", TextCompare: false) == 0)
			{
				Functions.DirectoryCopy(drive + "\\DWS-History", text3 + "\\DWS-History", ok: true);
				if (Operators.CompareString(Functions.DirExist(drive, "\\DWS"), "Exists", TextCompare: false) == 0)
				{
					Functions.DirectoryCopy(drive + "\\DWS", text3 + "\\DWS-History", ok: true);
				}
			}
			else
			{
				Functions.DirectoryCopy(drive + "\\DWS-History", "C:\\Users\\Public\\Open\\DWS-History", ok: true);
				Functions.DirectoryCopy(drive + "\\DWS", "C:\\Users\\Public\\Open\\DWS", ok: true);
			}
			ClearButtons();
		}
	}

	public string ReadTransferFile(string Drive, string Direct, string Path)
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
			}
			while (text != null);
			streamReader.Close();
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

	private void Invisible_Click(object sender, EventArgs e)
	{
		if (!Startup)
		{
			MyProject.Forms.Display.EndProgram();
		}
		else
		{
			Hide();
		}
	}

	private void TransferHydro_Load(object sender, EventArgs e)
	{
		ClearButtons();
	}

	private void OpenNetwork()
	{
		try
		{
			object obj = Path.Combine(Environment.SystemDirectory, "control.exe");
			Process.Start(Conversions.ToString(obj), "/name Microsoft.NetworkAndSharingCenter");
			Process.Start("explorer.exe", "c:\\Users");
			string path = "c:\\Users\\Public";
			string identity = "Everyone";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.Modify, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void LocalNetwork_Click(object sender, EventArgs e)
	{
		OpenNetwork();
	}
}
