using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BadApple
{
	public partial class frmSetup : Form
	{
		public frmSetup()
		{
			InitializeComponent();
		}

		private void rbLayered_CheckedChanged(object sender, EventArgs e)
		{
			cbBitBlt.Enabled = !rbLayered.Checked;
			cbTransBack.Enabled = rbLayered.Checked;
			cbFullScr.Enabled = rbLayered.Checked;
		}

		private void cbFullScr_CheckedChanged(object sender, EventArgs e)
		{
			cbShowTskBar.Enabled = cbFullScr.Checked && cbFullScr.Enabled;
		}

		private void rbWindowed_CheckedChanged(object sender, EventArgs e)
		{
			cbShowTskBar.Enabled = !rbWindowed.Checked;
		}

		private void frmSetup_Load(object sender, EventArgs e)
		{
			this.Icon = Publics.GetIcon(Application.ExecutablePath, true);
			txtPath.Text = Path.GetFullPath("ba.mp3");
			txtSSP.Text = Path.GetFullPath("ba.ssp");
		}

		private void lnkBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string filename = Publics.OpenFile("Select BGM file for Bad Apple", "ba.mp3", "Music Files|*.mp3;*.wma");
			if (filename != "")
			{
				txtPath.Text = filename;
			}
		}

		private void lnkSSP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string filename = Publics.OpenFile("Select SSP file for Bad Apple", "ba.ssp", "SSP|*.ssp");
			if (filename != "")
			{
				txtSSP.Text = filename;
				//TODO: check invalid
			}
		}

		private void lnkTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (Publics.BGM.Open(txtPath.Text))
			{
				Publics.BGM.PlayFrom0();
				Win32API.AllocConsole();
				new Thread(delegate() {
					while (true)
					{
						this.Invoke((MethodInvoker)delegate()
						{
							Console.CursorLeft = 0;
							Console.CursorTop = 0;
							Console.Write(Publics.BGM.Position());
						});
						Thread.Sleep(1000);
					}
				}) { IsBackground = true }.Start();
				MessageBox.Show("BGM playing..." + Environment.NewLine + "Press OK to stop", "Playing", MessageBoxButtons.OK);
				Publics.BGM.Close();
			}
			else
			{
				MessageBox.Show("Failed to open BGM file","Failed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
	}
}
