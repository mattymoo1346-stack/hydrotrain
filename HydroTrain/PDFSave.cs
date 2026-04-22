using System;
using System.IO;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace HydroTrain;

[StandardModule]
internal sealed class PDFSave
{
	private static string ProgramS;

	private static string ProgramG;

	public static void PDFChart(object FileNo, object Drive, object Path, object FileName)
	{
		try
		{
			Array array = Strings.Split(NameListSort.DistanceHistory[Conversions.ToInteger(FileNo)], ";");
			string text = Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { Microsoft.VisualBasic.Information.UBound(array) }, null));
			Array array2 = Strings.Split(NameListSort.CalorieDryHistory[Conversions.ToInteger(FileNo)], ";");
			string text2 = Conversions.ToString(NewLateBinding.LateIndexGet(array2, new object[1] { Microsoft.VisualBasic.Information.UBound(array2) }, null));
			Array array3 = Strings.Split(NameListSort.CalorieWetHistory[Conversions.ToInteger(FileNo)], ";");
			string text3 = Conversions.ToString(NewLateBinding.LateIndexGet(array3, new object[1] { Microsoft.VisualBasic.Information.UBound(array3) }, null));
			string setting = Interaction.GetSetting("Dtread", "Aqua", "SerialNo", "0");
			PdfDocument pdfDocument = new PdfDocument();
			pdfDocument.Info.Title = "DWS Hydrotherapy Serial No." + setting;
			pdfDocument.Info.Author = "Jerry Fenn - JMF Micro";
			pdfDocument.Info.Subject = "Session Report " + NameListSort.ReportNumberHistory[Conversions.ToInteger(FileNo)];
			PdfPage pdfPage = pdfDocument.AddPage();
			pdfPage.Orientation = PageOrientation.Landscape;
			XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);
			XFont font = new XFont("Verdana", 16.0, XFontStyle.Bold);
			xGraphics.DrawString(MyProject.Forms.MachineSetup.CustomerName.Text, font, XBrushes.Black, new XRect(0.0, 5.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
			font = new XFont("Verdana", 11.0, XFontStyle.Regular);
			xGraphics.DrawString("Date & Time: " + NameListSort.DateTimeHistory[Conversions.ToInteger(FileNo)], font, XBrushes.Black, new XRect(10.0, 30.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString("Report: " + NameListSort.ReportNumberHistory[Conversions.ToInteger(FileNo)], font, XBrushes.Black, new XRect(702.0, 30.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			string text4 = "ID : " + NameListSort.IDHistory[1] + "  --  Name: " + NameListSort.NamePersonHistory[Conversions.ToInteger(FileNo)] + "  --  House No: " + NameListSort.HouseNoHistory[Conversions.ToInteger(FileNo)] + "  --  Post Code: " + NameListSort.PostCodeHistory[Conversions.ToInteger(FileNo)] + "  --  Referral End Date: " + NameListSort.RefPersonHistory[Conversions.ToInteger(FileNo)];
			string text5 = "";
			if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0)
			{
				text5 = text5 + "Animal Name: " + NameListSort.AnimalNameHistory[Conversions.ToInteger(FileNo)] + "  --  ";
			}
			if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0)
			{
				text5 = text5 + "Dog Name: " + NameListSort.AnimalNameHistory[Conversions.ToInteger(FileNo)] + "  --  ";
			}
			if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0))
			{
				text5 = text5 + "Breed: " + NameListSort.BreedHistory[Conversions.ToInteger(FileNo)] + "  --  ";
			}
			else if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) == 0)
			{
				text5 += "Health:   --  ";
			}
			text5 = text5 + "Weight kg : " + NameListSort.WeightHistory[Conversions.ToInteger(FileNo)] + "  --  Height cm: " + NameListSort.HeightHistory[Conversions.ToInteger(FileNo)] + "  --  Sex: " + NameListSort.SexHistory[Conversions.ToInteger(FileNo)] + "  --  DOB: " + NameListSort.DOBHistory[Conversions.ToInteger(FileNo)];
			if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
			{
				text5 = text5 + "  --  BMI: " + NameListSort.BMIHistory[Conversions.ToInteger(FileNo)];
			}
			string text6 = "";
			if (Operators.CompareString(NameListSort.TrainerHistory[Conversions.ToInteger(FileNo)], "", TextCompare: false) != 0)
			{
				text6 = text6 + "Therapist: " + NameListSort.TrainerHistory[Conversions.ToInteger(FileNo)] + "   --   ";
			}
			text6 = text6 + "Duration " + NameListSort.DurationHistory[Conversions.ToInteger(FileNo)] + "  --  Rest " + NameListSort.RestTotalHistory[Conversions.ToInteger(FileNo)];
			if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
			{
				text6 = text6 + "  --  Used Cal Dry: " + text2 + " kcal";
				if (MachineSetup.CalorieIndWetOnOff)
				{
					text6 = text6 + "  --  Used Cal Wet: " + text3 + " kcal";
				}
			}
			string text7 = "";
			text7 = text7 + "Speed P " + NameListSort.ProgramSHistory[Conversions.ToInteger(FileNo)];
			if (Operators.CompareString(NameListSort.ProgramSHistory[Conversions.ToInteger(FileNo)], "Manual", TextCompare: false) == 0)
			{
				text7 = text7 + "\\" + NameListSort.DirectionHistory[Conversions.ToInteger(FileNo)];
			}
			text7 = text7 + "  --  Max kmh: " + NameListSort.MaxkmhHistory[Conversions.ToInteger(FileNo)] + "  --  Max M/m: " + Conversions.ToString(Math.Round(Conversions.ToDouble(NameListSort.MaxkmhHistory[Conversions.ToInteger(FileNo)]) * 1000.0 / 60.0, 3)) + "  --  Distance: " + text + " km";
			string text8 = "";
			if (MachineSetup.InclineDisplayOnOff)
			{
				text8 = text8 + "Gradient P " + NameListSort.ProgramGHistory[Conversions.ToInteger(FileNo)] + "  --  Max %: " + NameListSort.MaxPercentHistory[Conversions.ToInteger(FileNo)] + "  --  Max Deg: " + NameListSort.MaxDegHistory[Conversions.ToInteger(FileNo)];
			}
			string text9 = "";
			text9 = text9 + "DWS Hydrotherapy   --  Unit 24a, Wassage Way, Hampton Lovett Industrial Estate, Droitwich WR9 0NX : 01905 863288 : www.d-w-s.org  --  Serial No: " + setting;
			font = new XFont("Verdana", 11.0, XFontStyle.Regular);
			xGraphics.DrawString(text4, font, XBrushes.Black, new XRect(10.0, 50.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString(text5, font, XBrushes.Black, new XRect(10.0, 70.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString(text6, font, XBrushes.Black, new XRect(10.0, 90.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString(text7, font, XBrushes.Black, new XRect(10.0, 110.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString(text8, font, XBrushes.Black, new XRect(10.0, 130.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			XImage image = XImage.FromFile(MyProject.Application.Info.DirectoryPath + "\\MainChart.tif");
			xGraphics.DrawImage(image, 0, 150, 822, 254);
			font = new XFont("Arial", 9.0, XFontStyle.Italic);
			xGraphics.DrawString(text9, font, XBrushes.Black, new XRect(10.0, 580.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
			string directoryName = new FileInfo(Application.ExecutablePath).DirectoryName;
			if (Functions.FileExist(directoryName + "\\", "PdfSharp.dll"))
			{
				NewLateBinding.LateCall(pdfDocument, null, "Save", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Drive, Path), FileName) }, null, null, null, IgnoreReturn: true);
				MyProject.Forms.Display.ControlChange("InformationInd", "ForeColor", "Blue");
			}
			else
			{
				MyProject.Forms.Display.ControlChange("InformationInd", "ForeColor", "Red");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void PDFChartOne(object Drive, object Path, object FileName)
	{
		int num = 1;
		try
		{
			Array array = Strings.Split(NameListSort.DistanceHistory[num], ";");
			string text = Conversions.ToString(NewLateBinding.LateIndexGet(array, new object[1] { Microsoft.VisualBasic.Information.UBound(array) }, null));
			Array array2 = Strings.Split(NameListSort.CalorieDryHistory[num], ";");
			string text2 = Conversions.ToString(NewLateBinding.LateIndexGet(array2, new object[1] { Microsoft.VisualBasic.Information.UBound(array2) }, null));
			Array array3 = Strings.Split(NameListSort.CalorieWetHistory[num], ";");
			string text3 = Conversions.ToString(NewLateBinding.LateIndexGet(array3, new object[1] { Microsoft.VisualBasic.Information.UBound(array3) }, null));
			string setting = Interaction.GetSetting("Dtread", "Aqua", "SerialNo", "0");
			PdfDocument pdfDocument = new PdfDocument();
			pdfDocument.Info.Title = "DWS Hydrotherapy Serial No." + setting;
			pdfDocument.Info.Author = "Jerry Fenn - JMF Micro";
			pdfDocument.Info.Subject = "Session Report " + NameListSort.ReportNumberHistory[num];
			PdfPage pdfPage = pdfDocument.AddPage();
			pdfPage.Orientation = PageOrientation.Landscape;
			XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);
			XFont font = new XFont("Verdana", 16.0, XFontStyle.Bold);
			xGraphics.DrawString(MyProject.Forms.MachineSetup.CustomerName.Text, font, XBrushes.Black, new XRect(0.0, 5.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
			font = new XFont("Verdana", 11.0, XFontStyle.Regular);
			xGraphics.DrawString("Date & Time: " + Display.DateTimeRecord, font, XBrushes.Black, new XRect(10.0, 30.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString("Report: " + Display.ReportNumber, font, XBrushes.Black, new XRect(702.0, 30.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			string text4 = "ID : " + MyProject.Forms.Information.ID.Text + "  --  Name: " + MyProject.Forms.Information.PersonName.Text + "  --  House No: " + MyProject.Forms.Information.HouseNo.Text + "  --  Post Code: " + MyProject.Forms.Information.PostCode.Text + "  --  Referral End Date: " + MyProject.Forms.Information.ReferralEnd.Text;
			string text5 = "";
			if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0)
			{
				text5 = text5 + "Animal Name: " + MyProject.Forms.Information.AnimalName.Text + "  --  ";
			}
			if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0)
			{
				text5 = text5 + "Dog Name: " + MyProject.Forms.Information.AnimalName.Text + "  --  ";
			}
			if ((Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Canine", TextCompare: false) == 0) | (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Animal", TextCompare: false) == 0))
			{
				text5 = text5 + "Breed: " + MyProject.Forms.Information.Breed.Text + "  --  ";
			}
			else if (Operators.CompareString(MyProject.Forms.MachineSetup.TypeSw.Text, "Person", TextCompare: false) == 0)
			{
				text5 += "Health:   --  ";
			}
			text5 = text5 + "Weight kg : " + MyProject.Forms.Information.PersonWeightkg.Text + "  --  Height cm: " + MyProject.Forms.Information.PersonHeightcm.Text + "  --  Sex: " + MyProject.Forms.Information.PersonSex.Text + "  --  DOB: " + MyProject.Forms.Information.DOB.Text;
			if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
			{
				text5 = text5 + "  --  BMI: " + MyProject.Forms.Information.BMI.Text;
			}
			string text6 = "";
			if (Operators.CompareString(NameListSort.TrainerHistory[num], "", TextCompare: false) != 0)
			{
				text6 = text6 + "Therapist: " + MyProject.Forms.Information.Trainer.Text + "   --   ";
			}
			text6 = text6 + "Duration " + MyProject.Forms.Display.DurationInd.Text + "  --  Rest " + MyProject.Forms.Display.DurationRest.Text;
			if (Operators.CompareString(MachineSetup.Type, "Person", TextCompare: false) == 0)
			{
				text6 = text6 + "  --  Used Cal Dry: " + MyProject.Forms.Display.Calorie_Dry.Text + " kcal";
				if (MachineSetup.CalorieIndWetOnOff)
				{
					text6 = text6 + "  --  Used Cal Wet: " + MyProject.Forms.Display.Calorie_Wet.Text + " kcal";
				}
			}
			string text7 = "";
			if (!Display.CleanOp)
			{
				if (MyProject.Forms.Display.SpeedProgramSet == 0)
				{
					if (Display.SpeedProgramReverse)
					{
						ProgramS = "Manual/R";
					}
					else
					{
						ProgramS = "Manual/F";
					}
				}
				else
				{
					ProgramS = Conversions.ToString(MyProject.Forms.Display.SpeedProgramSet) ?? "";
				}
				if (MyProject.Forms.Display.GradientProgramSet == 0)
				{
					ProgramG = "Manual";
				}
				else
				{
					ProgramG = Conversions.ToString(MyProject.Forms.Display.GradientProgramSet) ?? "";
				}
			}
			else
			{
				ProgramS = "Cleaning";
				ProgramG = "Cleaning";
			}
			text7 = text7 + "Speed P " + ProgramS + "  --  Max kmh: " + MyProject.Forms.Display.MaxSpeedIndkm.Text + "  --  Max M/m: " + Conversions.ToString(Math.Round(Conversion.Val(MyProject.Forms.Display.MaxSpeedIndkm.Text) * 1000.0 / 60.0, 3)) + "  --  Distance: " + MyProject.Forms.Display.Distance_km.Text + " km";
			string text8 = "";
			if (MachineSetup.InclineDisplayOnOff)
			{
				text8 = text8 + "Gradient P " + ProgramG + "  --  Max %: " + MyProject.Forms.Display.InclinePercentage.Text + "  --  Max Deg: " + MyProject.Forms.Display.InclineDeg.Text;
			}
			string text9 = "";
			text9 = text9 + "DWS Hydrotherapy   --  Unit 24a, Wassage Way, Hampton Lovett Industrial Estate, Droitwich WR9 0NX : 01905 863288 : www.d-w-s.org  --  Serial No: " + setting;
			font = new XFont("Verdana", 11.0, XFontStyle.Regular);
			xGraphics.DrawString(text4, font, XBrushes.Black, new XRect(10.0, 50.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString(text5, font, XBrushes.Black, new XRect(10.0, 70.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString(text6, font, XBrushes.Black, new XRect(10.0, 90.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString(text7, font, XBrushes.Black, new XRect(10.0, 110.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			xGraphics.DrawString(text8, font, XBrushes.Black, new XRect(10.0, 130.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
			XImage image = XImage.FromFile(MyProject.Application.Info.DirectoryPath + "\\MainChart.tif");
			xGraphics.DrawImage(image, 0, 150, 822, 254);
			font = new XFont("Arial", 9.0, XFontStyle.Italic);
			xGraphics.DrawString(text9, font, XBrushes.Black, new XRect(10.0, 580.0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
			string directoryName = new FileInfo(Application.ExecutablePath).DirectoryName;
			if (Functions.FileExist(directoryName + "\\", "PdfSharp.dll"))
			{
				NewLateBinding.LateCall(pdfDocument, null, "Save", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Drive, Path), FileName) }, null, null, null, IgnoreReturn: true);
				MyProject.Forms.Display.ControlChange("InformationInd", "ForeColor", "Blue");
			}
			else
			{
				MyProject.Forms.Display.ControlChange("InformationInd", "ForeColor", "Red");
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
