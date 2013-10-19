using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;
using System.Drawing;


namespace BadApple
{
	public class SSPReader : IDisposable
	{
		private List<int> _filesSize;
		private int _filesCount;
		private List<int> _filesPos;
		FileStream _fsSSP;
		StreamReader _srReader;
		BinaryReader _brReader;

		int _headerLen = 0;

		public int FilesCount
		{
			get
			{
				return _filesCount;
			}
			set
			{
				_filesCount = value;
			}
		}

		public SSPReader(string filename)
		{
			_fsSSP = new FileStream(filename, FileMode.Open, FileAccess.Read);
			_srReader = new StreamReader(_fsSSP);
			_brReader = new BinaryReader(_fsSSP);
			// Get header length
			_fsSSP.Seek(6, SeekOrigin.Begin);
			char c = (char)_fsSSP.ReadByte();
			int num = 0;
			if (c != '~')
			{
				throw new InvalidSSPException();
			}
			while (true)
			{
				c = (char)_fsSSP.ReadByte();
				if (int.TryParse(c.ToString(), out num))
				{
					_headerLen *= 10;
					_headerLen += num;
				}
				else
				{
					break;
				}
			}
			_fsSSP.Seek(0, SeekOrigin.Begin);
			char[] buffer = new char[_headerLen];
			_brReader.Read(buffer, 0, _headerLen);

			string header = new string(buffer);
			if (!header.StartsWith("MaiSSP"))
			{
				throw new InvalidSSPException();
			}
			header = header.Substring(header.IndexOf("//") + 2);
			header = header.Substring(0, header.IndexOf("//"));

			string[] fileSize = header.Split('/');
			this.FilesCount = fileSize.Length;

			_filesPos = new List<int>();
			_filesSize = new List<int>();

			int curFilePos = 0;
			for (int i = 0; i < fileSize.Length; i++)
			{

				_filesPos.Add(Convert.ToInt32(curFilePos));
				curFilePos += Convert.ToInt32(fileSize[i]);
				_filesSize.Add(Convert.ToInt32(fileSize[i]));
			}
		}

		public Image Get(int index)
		{
			byte[] file = new byte[_filesSize[index]];
			_fsSSP.Seek(_filesPos[index] + _headerLen, SeekOrigin.Begin);
			_brReader.Read(file, 0, _filesSize[index]);
			return Bitmap.FromStream(new MemoryStream(file));
		}

		public void Dispose()
		{
			
			_fsSSP.Dispose();
		}
	}
}
