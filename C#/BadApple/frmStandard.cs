using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace BadApple
{
	public partial class frmStandard : Form
	{
		private bool _isShown = false;
		private Stopwatch _sw = new Stopwatch();
		private Size _display = Size.Empty;
		private int _imgIndex = 0;

		private Thread _drawLoop;

		public frmStandard()
		{
			InitializeComponent();
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.UserPaint, false);
		}

		private void frmStandard_Load(object sender, EventArgs e)
		{
			this.Icon = Publics.GetIcon(Application.ExecutablePath, true);
			this.TopMost = Publics.isTopMost;
			Win32API.MM_BeginPeriod(1);
		}

		private void frmStandard_FormClosing(object sender, FormClosingEventArgs e)
		{
			Win32API.MM_EndPeriod(1);
			_drawLoop.Abort();
			Application.Exit();
		}

		private void frmStandard_Resize(object sender, EventArgs e)
		{
			if (this.ClientSize.Width > 3 && this.ClientSize.Height > 3)
			{
				_display = this.ClientSize;
			}
		}

		private void frmStandard_Shown(object sender, EventArgs e)
		{
			if (!_isShown)
			{
				Publics.BGM.PlayFrom0();
				_isShown = true;
				_sw.Start();
				if (this.ClientSize.Width > 3 && this.ClientSize.Height > 3)
				{
					_display = this.ClientSize;
				}
				_drawLoop = new Thread(delegate()
				{
					while (this.Visible && !this.IsDisposed && !this.Disposing)
					{
						using (Graphics g = this.CreateGraphics())
						{
							_imgIndex = (int)Math.Floor(_sw.ElapsedMilliseconds / 33.2);
							if (_imgIndex >= 6569)
							{
								this.Invoke((MethodInvoker)delegate()
								{
									Publics.BGM.PlayFrom0();
								});
							}

							using (Bitmap b = new Bitmap(_display.Width, _display.Height))
							{
								using (Graphics gb = Graphics.FromImage(b))
								{
									using (Bitmap bFrame = new Bitmap(Publics.GetFrame(_imgIndex)))
									{
										gb.Clear(Color.White);
										gb.DrawImage(bFrame, this.ClientRectangle);
									}
								};

								if (Publics.useBitBlt)
								{
									IntPtr hDc = g.GetHdc();
									IntPtr hMemDc = Win32API.CreateCompatibleDC(hDc);
									IntPtr hBmp = b.GetHbitmap();
									IntPtr hOldBmp = Win32API.SelectObject(hMemDc, hBmp);

									Win32API.BitBlt(hDc, 0, 0, b.Width, b.Height, hMemDc, 0, 0, Win32API.TernaryRasterOperations.SRCCOPY);
									Win32API.SelectObject(hMemDc, hOldBmp);
									Win32API.DeleteObject(hBmp);
									g.ReleaseHdc(hDc);
									Win32API.DeleteDC(hMemDc);
								}
								else
								{
									g.DrawImageUnscaled(b, Point.Empty);
								}
							};
						};
					};
				}) { IsBackground = true };
				_drawLoop.Start();
			}
		}
	}
}
