using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace BadApple
{
	public partial class frmLayered : Form
	{
		private IntPtr _hWnd = IntPtr.Zero;
		private Size _display = Size.Empty;
		private bool _isShown = false;
		private Stopwatch _sw = new Stopwatch();
		private int _imgIndex = 0;
		private Thread _drawLoop;

		public frmLayered()
		{
			InitializeComponent();
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.UserPaint, false);
		}

		private void frmLayered_FormClosing(object sender, FormClosingEventArgs e)
		{
			Win32API.MM_EndPeriod(1);
			_drawLoop.Abort();
			Application.Exit();
		}

		private void frmLayered_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Win32API.ReleaseCapture();
				Win32API.SendMessage(this.Handle, Win32API.WM_NCLBUTTONDOWN, Win32API.HT_CAPTION, 0);
			}
		}

		private void frmLayered_Load(object sender, EventArgs e)
		{
			Win32API.MM_BeginPeriod(1);
			this.TopMost = Publics.isTopMost;
			if (Publics.isFullscreen)
			{
				if (Publics.showTaskbar)
				{
					this.Location = Point.Empty;
					_display = Screen.PrimaryScreen.WorkingArea.Size;
				}
				else
				{
					this.WindowState = FormWindowState.Maximized;
					_display = this.Size;
				}
			}
			else
			{
				_display = new Size(700, 500);
			}
			this.Size = _display;
			_hWnd = this.Handle;
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ExStyle = cp.ExStyle | Win32API.WS_EX_LAYERED;
				return cp;
			}
		}

		private void frmLayered_Shown(object sender, EventArgs e)
		{
			if (!_isShown)
			{
				_isShown = true;
				Publics.BGM.PlayFrom0();
				_sw.Start();
				_drawLoop = new Thread(delegate()
				{
					while (this.Visible && !this.IsDisposed && !this.Disposing)
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
							using (Graphics g = Graphics.FromImage(b))
							{
								using (Bitmap frame = new Bitmap(Publics.GetFrame(_imgIndex)))
								{
									if (!Publics.isBackTrans)
									{
										g.Clear(Color.White);
									}
									g.DrawImage(frame, this.ClientRectangle);
								};
							};
							drawBitmap(b);
						};
					};
				}) { IsBackground = true};
				_drawLoop.Start();
			}
		}

		private void drawBitmap(Bitmap b)
		{
			if (b.PixelFormat != System.Drawing.Imaging.PixelFormat.Format32bppArgb)
			{
				throw new Exception("Unsupported bitmap");
			}

			IntPtr srcDc = Win32API.GetDC(IntPtr.Zero);
			IntPtr memDc = Win32API.CreateCompatibleDC(srcDc);
			IntPtr hBmp = b.GetHbitmap(Color.FromArgb(0));
			IntPtr hOldBmp = Win32API.SelectObject(memDc, hBmp);

			Win32API.Point pLayer = new Win32API.Point(0, 0);
			Win32API.Point pFrm = new Win32API.Point(this.Left, this.Top);
			Win32API.Size szFrm = new Win32API.Size(b.Width, b.Height);

			Win32API.BlendFunction bf = new Win32API.BlendFunction()
				{
					BlendOp = Win32API.AC_SRC_OVER,
					BlendFlags =0,
					SourceConstantAlpha = 255,
					AlphaFormat = Win32API.AC_SRC_ALPHA
				};
			Win32API.UpdateLayeredWindow(_hWnd, srcDc, ref pFrm, ref szFrm, memDc, ref pLayer, 0, ref bf, Win32API.ULW_ALPHA);
			Win32API.ReleaseDC(IntPtr.Zero, srcDc);
			if (hBmp != IntPtr.Zero)
			{
				Win32API.SelectObject(memDc, hOldBmp);
				Win32API.DeleteObject(hBmp);
			}
			Win32API.DeleteDC(memDc);


		}

		private void frmLayered_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				frmLayered_FormClosing(sender, new FormClosingEventArgs(CloseReason.ApplicationExitCall,false));
			}
		}
	}
}
