using System;
using System.Collections.Generic;
using System.Text;

namespace BadApple
{
	public class MCIMedia
	{
		private string Alias { get; set; }
		private string FileName { get; set; }

		public MCIMedia(string Alias)
		{
			this.Alias = Alias;
		}
		public bool Open(string FileName)
		{
			StringBuilder shortFilename = new StringBuilder(256);
			Win32API.GetShortPathName(FileName, shortFilename, 256);
			string strCmd = "open " + shortFilename.ToString() + " alias " + this.Alias;
			if (Win32API.mciSendString(strCmd, shortFilename, 256, IntPtr.Zero) == 0)
			{
				this.FileName = FileName;
				return true;
			}
			return false;
		}
		public bool PlayFrom0()
		{
			if (Win32API.mciSendString("play " + this.Alias + " from 0", new StringBuilder(), 256, IntPtr.Zero) == 0)
			{
				return true;
			}
			return false;
		}
		public bool Close()
		{
			if (Win32API.mciSendString("close " + this.Alias, new StringBuilder(), 256, IntPtr.Zero) == 0)
			{
				return true;
			}
			return false;
		}
		public bool Play()
		{
			if (Win32API.mciSendString("play " + this.Alias, new StringBuilder(), 256, IntPtr.Zero) == 0)
			{
				return true;
			}
			return false;
		}
		public bool Pause()
		{
			if (Win32API.mciSendString("pause " + this.Alias, new StringBuilder(), 256, IntPtr.Zero) == 0)
			{
				return true;
			}
			return false;
		}
		public int Position()
		{
			StringBuilder pos = new StringBuilder();
			if (Win32API.mciSendString("status " + this.Alias + " position ", pos, pos.Capacity, IntPtr.Zero) == 0)
			{
				return int.Parse(pos.ToString());
			}
			return -1;
		}
		
		public int Length()
		{
			StringBuilder len = new StringBuilder();
			if (Win32API.mciSendString("status " + this.Alias + " length ", len, len.Capacity, IntPtr.Zero) == 0)
			{
				return int.Parse(len.ToString());
			}
			return 0;
		}
	}
}
