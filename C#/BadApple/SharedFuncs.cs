using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace BadApple
{
	public static class Publics
	{
		public static MCIMedia BGM = new MCIMedia("baBGM");

		public static string OpenFile(string Title, string FileName, string Filter)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = Title;
			ofd.FileName = FileName;
			ofd.Filter = Filter;
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				return ofd.FileName;
			}
			else
			{
				return "";
			}
		}

		public static Icon GetIcon(string FileName, bool isLargeIcon)
		{
			Win32API.SHFILEINFO fileInfo = new Win32API.SHFILEINFO();
			int szFileInfo = Marshal.SizeOf(fileInfo);
			Win32API.SHGFI flags = new Win32API.SHGFI();
			if (isLargeIcon)
			{
				flags = Win32API.SHGFI.SHGFI_ICON | Win32API.SHGFI.SHGFI_LARGEICON;
			}
			else
			{
				flags = Win32API.SHGFI.SHGFI_ICON | Win32API.SHGFI.SHGFI_SMALLICON;
			}
			Win32API.SHGetFileInfo(FileName, (uint)256, ref fileInfo, (uint)szFileInfo, (uint)flags);
			return Icon.FromHandle(fileInfo.hIcon);
		}

	}
}
