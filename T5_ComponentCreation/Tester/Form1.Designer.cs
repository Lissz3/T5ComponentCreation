namespace Tester
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
			this.btnPos = new System.Windows.Forms.Button();
			this.btnSep = new System.Windows.Forms.Button();
			this.lbltxtP = new Components.LabelTextBox();
			this.warningLabel1 = new Components.WarningLabel();
			this.SuspendLayout();
			// 
			// btnPos
			// 
			this.btnPos.AutoSize = true;
			this.btnPos.Location = new System.Drawing.Point(263, 202);
			this.btnPos.Name = "btnPos";
			this.btnPos.Size = new System.Drawing.Size(75, 23);
			this.btnPos.TabIndex = 2;
			this.btnPos.Text = "Cambiar pos";
			this.btnPos.UseVisualStyleBackColor = true;
			this.btnPos.Click += new System.EventHandler(this.btnLblTxt_Click);
			// 
			// btnSep
			// 
			this.btnSep.Location = new System.Drawing.Point(375, 202);
			this.btnSep.Name = "btnSep";
			this.btnSep.Size = new System.Drawing.Size(75, 23);
			this.btnSep.TabIndex = 3;
			this.btnSep.Text = "Separar";
			this.btnSep.UseVisualStyleBackColor = true;
			this.btnSep.Click += new System.EventHandler(this.btnSep_Click);
			// 
			// lbltxtP
			// 
			this.lbltxtP.Location = new System.Drawing.Point(103, 94);
			this.lbltxtP.Name = "lbltxtP";
			this.lbltxtP.Posicion = Components.ePosicion.IZQUIERDA;
			this.lbltxtP.PswChar = '\0';
			this.lbltxtP.Separacion = 0;
			this.lbltxtP.Size = new System.Drawing.Size(135, 20);
			this.lbltxtP.TabIndex = 1;
			this.lbltxtP.TextLbl = "label1";
			this.lbltxtP.TextTxt = "";
			this.lbltxtP.SeparacionChanged += new System.EventHandler(this.lbltxtP_SeparacionChanged);
			this.lbltxtP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbltxtP_KeyUp);
			// 
			// warningLabel1
			// 
			this.warningLabel1.FirstColor = System.Drawing.Color.Transparent;
			this.warningLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.warningLabel1.Gardient = false;
			this.warningLabel1.Location = new System.Drawing.Point(12, 318);
			this.warningLabel1.Marca = Components.WarningLabel.eMarca.Imagen;
			this.warningLabel1.MarcaImage = global::Tester.Properties.Resources.Sin_título;
			this.warningLabel1.Name = "warningLabel1";
			this.warningLabel1.SecondColor = System.Drawing.Color.RosyBrown;
			this.warningLabel1.Size = new System.Drawing.Size(785, 120);
			this.warningLabel1.TabIndex = 0;
			this.warningLabel1.Text = "warningLabel1";
			this.warningLabel1.ClickMark += new System.EventHandler(this.warningLabel1_ClickMark);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSep);
			this.Controls.Add(this.btnPos);
			this.Controls.Add(this.lbltxtP);
			this.Controls.Add(this.warningLabel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Components.WarningLabel warningLabel1;
		private Components.LabelTextBox lbltxtP;
		private System.Windows.Forms.Button btnPos;
		private System.Windows.Forms.Button btnSep;
	}
}

