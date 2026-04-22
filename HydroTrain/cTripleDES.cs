using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

internal class cTripleDES
{
	private TripleDESCryptoServiceProvider m_des;

	private UTF8Encoding m_utf8;

	private byte[] m_key;

	private byte[] m_iv;

	public cTripleDES(byte[] key, byte[] iv)
	{
		m_des = new TripleDESCryptoServiceProvider();
		m_utf8 = new UTF8Encoding();
		m_key = key;
		m_iv = iv;
	}

	public byte[] Encrypt(byte[] input)
	{
		return Transform(input, m_des.CreateEncryptor(m_key, m_iv));
	}

	public byte[] Decrypt(byte[] input)
	{
		return Transform(input, m_des.CreateDecryptor(m_key, m_iv));
	}

	public string Encrypt(string text)
	{
		byte[] bytes = m_utf8.GetBytes(text);
		byte[] inArray = Transform(bytes, m_des.CreateEncryptor(m_key, m_iv));
		return Convert.ToBase64String(inArray);
	}

	public string Decrypt(string text)
	{
		byte[] input = Convert.FromBase64String(text);
		byte[] bytes = Transform(input, m_des.CreateDecryptor(m_key, m_iv));
		return m_utf8.GetString(bytes);
	}

	private byte[] Transform(byte[] input, ICryptoTransform CryptoTransform)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, CryptoTransform, CryptoStreamMode.Write);
			cryptoStream.Write(input, 0, input.Length);
			cryptoStream.FlushFinalBlock();
			memoryStream.Position = 0L;
			byte[] array = new byte[checked((int)(memoryStream.Length - 1) + 1)];
			memoryStream.Read(array, 0, array.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return array;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return new byte[1];
	}
}
