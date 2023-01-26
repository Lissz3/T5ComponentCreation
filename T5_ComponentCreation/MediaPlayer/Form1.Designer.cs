namespace MediaPlayer
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.btnSelect = new System.Windows.Forms.Button();
			this.txtFolder = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.picBoxPlayer = new System.Windows.Forms.PictureBox();
			this.tmr = new System.Windows.Forms.Timer(this.components);
			this.mediaPlayer1 = new Ex1.MediaPlayer();
			((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(535, 11);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(29, 22);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Text = "...";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
			// 
			// txtFolder
			// 
			this.txtFolder.Location = new System.Drawing.Point(12, 12);
			this.txtFolder.Name = "txtFolder";
			this.txtFolder.Size = new System.Drawing.Size(520, 20);
			this.txtFolder.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(667, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 3;
			// 
			// picBoxPlayer
			// 
			this.picBoxPlayer.Location = new System.Drawing.Point(12, 38);
			this.picBoxPlayer.Name = "picBoxPlayer";
			this.picBoxPlayer.Size = new System.Drawing.Size(776, 327);
			this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picBoxPlayer.TabIndex = 4;
			this.picBoxPlayer.TabStop = false;
			// 
			// tmr
			// 
			this.tmr.Enabled = true;
			this.tmr.Interval = 1000;
			this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
			// 
			// mediaPlayer1
			// 
			this.mediaPlayer1.Location = new System.Drawing.Point(361, 371);
			this.mediaPlayer1.MM = 0;
			this.mediaPlayer1.Name = "mediaPlayer1";
			this.mediaPlayer1.Play = false;
			this.mediaPlayer1.Size = new System.Drawing.Size(82, 67);
			this.mediaPlayer1.SS = 0;
			this.mediaPlayer1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.picBoxPlayer);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.txtFolder);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.mediaPlayer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ex1.MediaPlayer mediaPlayer1;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.TextBox txtFolder;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.PictureBox picBoxPlayer;
		private System.Windows.Forms.Timer tmr;
	}
}

