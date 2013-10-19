namespace BadApple
{
	partial class frmLayered
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// frmLayered
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(290, 269);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLayered";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bad Apple";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLayered_FormClosing);
			this.Load += new System.EventHandler(this.frmLayered_Load);
			this.Shown += new System.EventHandler(this.frmLayered_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLayered_KeyDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLayered_MouseMove);
			this.ResumeLayout(false);

		}

		#endregion
	}
}