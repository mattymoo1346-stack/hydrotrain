using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HydroTrain.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

[StandardModule]
internal sealed class WifiSocket
{
	public static int Port = 2000;

	public static TcpClient tcpClient;

	public static string CommsData;

	public static string ReceivedDataListener;

	public static bool SendFull;

	public static string SentData;

	private static TcpListener Listener = null;

	private static Thread thdListener = new Thread(CreateListener);

	private static void Listen(object Data)
	{
		if (Operators.ConditionalCompareObjectEqual(Data, "Open", TextCompare: false))
		{
			if (thdListener.ThreadState == ThreadState.Unstarted)
			{
				thdListener.Start();
			}
		}
		else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(Data, "Open", TextCompare: false), thdListener.IsAlive)))
		{
			thdListener.Abort();
		}
	}

	private static void CreateListener()
	{
		string text = "";
		checked
		{
			try
			{
				IPAddress localaddr = IPAddress.Parse(MyProject.Forms.WIFI.HostIP4Address);
				if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
				{
					Port = 2000 + WIFI.HostPort;
				}
				else
				{
					Port = 2000 + WIFI.ClientPort;
				}
				Listener = new TcpListener(localaddr, Port);
				Listener.Start();
				CommsData = "Waiting for a connection...";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				CommsData = "Error: " + ex2.ToString();
				MessageBox.Show(text);
				ProjectData.ClearProjectError();
			}
			while (true)
			{
				try
				{
					tcpClient = Listener.AcceptTcpClient();
					if (Operators.CompareString(Display.RemoteControl, "REMOTE", TextCompare: false) == 0)
					{
						if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "Demand", "BTN", "Get"), "BTN", TextCompare: false) == 0)
						{
							Thread.Sleep((int)Math.Round(140.0 + Conversion.Val(MyProject.Forms.WIFI.CommsDelay.Text)));
						}
						else if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "Demand", "BTN", "Get"), "DTA", TextCompare: false) == 0)
						{
							Thread.Sleep((int)Math.Round(90.0 + Conversion.Val(MyProject.Forms.WIFI.CommsDelay.Text)));
						}
						else if (Operators.CompareString(Functions.RegUpdate("Dtread", "Treadmill", "Demand", "BTN", "Get"), "CNT", TextCompare: false) == 0)
						{
							Thread.Sleep((int)Math.Round(90.0 + Conversion.Val(MyProject.Forms.WIFI.CommsDelay.Text)));
						}
						else
						{
							Thread.Sleep((int)Math.Round(100.0 + Conversion.Val(MyProject.Forms.WIFI.CommsDelay.Text)));
						}
					}
					else
					{
						Thread.Sleep((int)Math.Round(10.0 + Conversion.Val(MyProject.Forms.WIFI.CommsDelay.Text)));
					}
					NetworkStream stream = tcpClient.GetStream();
					byte[] array = new byte[129];
					StringBuilder stringBuilder = new StringBuilder();
					int num = 0;
					do
					{
						num = stream.Read(array, 0, array.Length);
						stringBuilder.AppendFormat("{0}", Encoding.ASCII.GetString(array, 0, num));
					}
					while (stream.DataAvailable);
					stream.Flush();
					stream.Close();
					ReceivedDataListener = stringBuilder.ToString();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
					break;
				}
			}
		}
	}

	private static void Connect(string serverIP, string message)
	{
		string text = "";
		SendFull = true;
		try
		{
			TcpClient tcpClient = new TcpClient(serverIP, Port)
			{
				ReceiveTimeout = 5
			};
			byte[] array = new byte[1025];
			array = Encoding.ASCII.GetBytes(message);
			NetworkStream stream = tcpClient.GetStream();
			stream.Write(array, 0, array.Length);
			stream.Flush();
			stream.Close();
			tcpClient.Close();
		}
		catch (ArgumentNullException ex)
		{
			ProjectData.SetProjectError(ex);
			ArgumentNullException ex2 = ex;
			text = "ArgumentNullException: " + ex2.ToString();
			ProjectData.ClearProjectError();
		}
		catch (SocketException ex3)
		{
			ProjectData.SetProjectError(ex3);
			SocketException ex4 = ex3;
			text = "SocketException: " + ex4.ToString();
			if (WifiSocket.tcpClient != null && WifiSocket.tcpClient.Connected)
			{
				WifiSocket.tcpClient.Close();
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			text = "Exception: " + ex6.ToString();
			ProjectData.ClearProjectError();
		}
		text = "Sent: " + message;
		SentData += text;
		SendFull = false;
	}
}
