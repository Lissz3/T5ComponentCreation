namespace Ex1
{
	partial class MediaPlayer
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnPlayPause = new System.Windows.Forms.Button();
			this.lblTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPlayPause
			// 
			this.btnPlayPause.Image = global::Ex1.Properties.Resources.play;
			this.btnPlayPause.Location = new System.Drawing.Point(3, 3);
			this.btnPlayPause.Name = "btnPlayPause";
			this.btnPlayPause.Size = new System.Drawing.Size(75, 36);
			this.btnPlayPause.TabIndex = 0;
			this.btnPlayPause.UseVisualStyleBackColor = true;
			this.btnPlayPause.Click += new System.EventHandler(this.BtnPlayPause_Click);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(23, 45);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(35, 13);
			this.lblTime.TabIndex = 1;
			this.lblTime.Text = "label1";
			// 
			// MediaPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.btnPlayPause);
			this.Name = "MediaPlayer";
			this.Size = new System.Drawing.Size(82, 67);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPlayPause;
		private System.Windows.Forms.Label lblTime;
	}
}
