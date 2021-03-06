using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BadApple
{
	public static class Win32API
	{
		[DllImport("winmm.dll")]
		public static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetShortPathName(
		   [MarshalAs(UnmanagedType.LPTStr)]
   string lpszLongPath,
		   [MarshalAs(UnmanagedType.LPTStr)]
   StringBuilder lpszShortPath,
		   uint cchBuffer);
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetShortPathName(string lpszLongPath, char[] lpszShortPath, int cchBuffer);

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct SHFILEINFO
		{
			public IntPtr hIcon;
			public int iIcon;
			public uint dwAttributes;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szDisplayName;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szTypeName;
		}

		[Flags]
		public enum SHGFI
		{
			SHGFI_ICON = 0x000000100,
			SHGFI_DISPLAYNAME = 0x000000200,
			SHGFI_TYPENAME = 0x000000400,
			SHGFI_ATTRIBUTES = 0x000000800,
			SHGFI_ICONLOCATION = 0x000001000,
			SHGFI_EXETYPE = 0x000002000,
			SHGFI_SYSICONINDEX = 0x000004000,
			SHGFI_LINKOVERLAY = 0x000008000,
			SHGFI_SELECTED = 0x000010000,
			SHGFI_ATTR_SPECIFIED = 0x000020000,
			SHGFI_LARGEICON = 0x000000000,
			SHGFI_SMALLICON = 0x000000001,
			SHGFI_OPENICON = 0x000000002,
			SHGFI_SHELLICONSIZE = 0x000000004,
			SHGFI_PIDL = 0x000000008,
			SHGFI_USEFILEATTRIBUTES = 0x000000010,
			SHGFI_ADDOVERLAYS = 0x000000020,
			SHGFI_OVERLAYINDEX = 0x000000040
		}

		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

		[DllImport("kernel32")]
		public static extern bool AllocConsole();

		[DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
		public static extern bool FreeConsole();

		[DllImport("winmm.dll", EntryPoint = "timeBeginPeriod")]
		public static extern uint MM_BeginPeriod(uint uMilliseconds);

		[DllImport("winmm.dll", EntryPoint = "timeEndPeriod")]
		public static extern uint MM_EndPeriod(uint uMilliseconds);

		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth,
		   int nHeight, IntPtr hObjSource, int nXSrc, int nYSrc, TernaryRasterOperations dwRop);

		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool DeleteDC(IntPtr hdc);

		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool DeleteObject(IntPtr hObject);

		public enum TernaryRasterOperations : uint
		{
			SRCCOPY = 0x00CC0020,
			SRCPAINT = 0x00EE0086,
			SRCAND = 0x008800C6,
			SRCINVERT = 0x00660046,
			SRCERASE = 0x00440328,
			NOTSRCCOPY = 0x00330008,
			NOTSRCERASE = 0x001100A6,
			MERGECOPY = 0x00C000CA,
			MERGEPAINT = 0x00BB0226,
			PATCOPY = 0x00F00021,
			PATPAINT = 0x00FB0A09,
			PATINVERT = 0x005A0049,
			DSTINVERT = 0x00550009,
			BLACKNESS = 0x00000042,
			WHITENESS = 0x00FF0062,
			CAPTUREBLT = 0x40000000 //only if WinVer >= 5.0.0 (see wingdi.h)
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		[StructLayout(LayoutKind.Sequential)]
		public struct Point
		{
			public int X;
			public int Y;

			public Point(int x, int y)
			{
				this.X = x;
				this.Y = y;
			}

			public Point(System.Drawing.Point pt) : this(pt.X, pt.Y) { }

			public static implicit operator System.Drawing.Point(Point p)
			{
				return new System.Drawing.Point(p.X, p.Y);
			}

			public static implicit operator Point(System.Drawing.Point p)
			{
				return new Point(p.X, p.Y);
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct Size
		{
			public int cx;
			public int cy;

			public Size(int cx, int cy)
			{
				this.cx = cx;
				this.cy = cy;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct BlendFunction
		{
			public byte BlendOp;
			public byte BlendFlags;
			public byte SourceConstantAlpha;
			public byte AlphaFormat;

			public BlendFunction(byte op, byte flags, byte alpha, byte format)
			{
				BlendOp = op;
				BlendFlags = flags;
				SourceConstantAlpha = alpha;
				AlphaFormat = format;
			}
		}

		public const int WS_EX_LAYERED = 0x00080000;
		public const uint ULW_ALPHA = 2;
		public const byte AC_SRC_OVER = 0;
		public const byte AC_SRC_ALPHA = 1;


		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst,
		   ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, uint crKey,
		   [In] ref BlendFunction pblend, uint dwFlags);

		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

	}
}
