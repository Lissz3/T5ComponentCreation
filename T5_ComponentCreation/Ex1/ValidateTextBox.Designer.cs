namespace Ex1
{
	partial class ValidateTextBox
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
			this.txbPrincipal = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txbPrincipal
			// 
			this.txbPrincipal.Location = new System.Drawing.Point(28, 15);
			this.txbPrincipal.Name = "txbPrincipal";
			this.txbPrincipal.Size = new System.Drawing.Size(100, 20);
			this.txbPrincipal.TabIndex = 0;
			this.txbPrincipal.TextChanged += new System.EventHandler(this.TxbPrincipal_TextChanged);
			// 
			// ValidateTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txbPrincipal);
			this.Name = "ValidateTextBox";
			this.Size = new System.Drawing.Size(157, 50);
			this.SizeChanged += new System.EventHandler(this.ValidateTextBox_SizeChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txbPrincipal;
	}
}
