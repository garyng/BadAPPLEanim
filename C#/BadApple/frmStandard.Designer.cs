﻿namespace BadApple
{
	partial class frmStandard
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
			// frmStandard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(612, 471);
			this.Name = "frmStandard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bad Apple";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStandard_FormClosing);
			this.Load += new System.EventHandler(this.frmStandard_Load);
			this.Shown += new System.EventHandler(this.frmStandard_Shown);
			this.Resize += new System.EventHandler(this.frmStandard_Resize);
			this.ResumeLayout(false);

		}

		#endregion
	}
}