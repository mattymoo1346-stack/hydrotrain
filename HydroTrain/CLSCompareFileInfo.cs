using System;
using System.Collections;
using System.IO;

namespace HydroTrain;

public class CLSCompareFileInfo : IComparer
{
	public int Compare(object x, object y)
	{
		FileInfo fileInfo = (FileInfo)x;
		FileInfo fileInfo2 = (FileInfo)y;
		return DateTime.Compare(fileInfo.CreationTime, fileInfo2.CreationTime);
	}

	int IComparer.Compare(object x, object y)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Compare
		return this.Compare(x, y);
	}
}
