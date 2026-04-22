using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace HydroTrain;

public class ListViewSorter : IComparer
{
	public enum EnumSortOrder
	{
		Ascending,
		Descending
	}

	public EnumSortOrder SortOrder;

	public int SortColumn;

	public ListViewSorter(int SortColumn, EnumSortOrder SortOrder)
	{
		SortColumn = SortColumn;
		SortOrder = SortOrder;
	}

	public int Compare(object x, object y)
	{
		ListViewItem listViewItem = (ListViewItem)x;
		ListViewItem listViewItem2 = (ListViewItem)y;
		ListViewItem listViewItem3 = (ListViewItem)y;
		string left;
		string right;
		if (SortColumn == 0)
		{
			left = listViewItem.Text;
			right = listViewItem2.Text;
			string text = listViewItem3.Text;
		}
		else
		{
			left = listViewItem.SubItems[SortColumn].ToString();
			right = listViewItem2.SubItems[SortColumn].ToString();
			string text = listViewItem3.SubItems[SortColumn].ToString();
		}
		if (Operators.CompareString(left, right, TextCompare: false) == 0)
		{
			return 0;
		}
		if (Operators.CompareString(left, right, TextCompare: false) > 0)
		{
			if (SortOrder == EnumSortOrder.Ascending)
			{
				return 1;
			}
			return -1;
		}
		if (Operators.CompareString(left, right, TextCompare: false) < 0)
		{
			if (SortOrder == EnumSortOrder.Ascending)
			{
				return -1;
			}
			return 1;
		}
		int result = default(int);
		return result;
	}

	int IComparer.Compare(object x, object y)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Compare
		return this.Compare(x, y);
	}
}
