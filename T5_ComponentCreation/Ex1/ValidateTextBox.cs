using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ex1
{
	public partial class ValidateTextBox : UserControl
	{
		bool correct;

		public ValidateTextBox()
		{
			InitializeComponent();
			txbPrincipal.Location = new Point(10, 10);
			correct = false;
			txbPrincipal.Width = Width - 20;
			Height = txbPrincipal.Height + 20;
		}


		[Category("Propias")]
		[Description("Recibe o asigna el texto al TextBox")]
		public string Texto
		{
			set
			{
				txbPrincipal.Text = value;
			}
			get
			{
				return txbPrincipal.Text;
			}
		}

		[Category("Propias")]
		[Description("Cambia la propiedad de multilinea del TextBox")]
		public bool Multilinea
		{
			set
			{
				txbPrincipal.Multiline = value;
			}
			get
			{
				return txbPrincipal.Multiline;
			}
		}

		public enum eTipo { NUMERICO, TEXTUAL }

		private eTipo tipo = eTipo.NUMERICO;

		[Category("Propias")]
		[Description("Asigna que tipo de carácteres se pueden escribir en el TextBox")]
		public eTipo Tipo
		{
			set { tipo = value; }
			get { return tipo; }
		}

		private void TxbPrincipal_TextChanged(object sender, EventArgs e)
		{
			OnTextChanged(e);
			TextValidation();
			Refresh();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			int stroke = 2;
			Color c;

			Rectangle r = new Rectangle(5, 5, Width - 5 - stroke, Height - 5 - stroke);

			if (correct)
			{
				c = Color.Green;
			}
			else
			{
				c = Color.Red;
			}

			Pen p = new Pen(c, stroke);
			g.DrawRectangle(p, r);

			p.Dispose();
		}

		private void ValidateTextBox_SizeChanged(object sender, EventArgs e)
		{
			txbPrincipal.Width = Width - 20;
			Height = txbPrincipal.Height + 20;
		}

		private void TextValidation()
		{
			if (int.TryParse(txbPrincipal.Text, out _) && Tipo is eTipo.NUMERICO)
			{
				correct = true;
			}
			else if (txbPrincipal.Text.All(c => char.IsLetter(c)) && Tipo is eTipo.TEXTUAL)
			{
				correct = true;
			}
			else
			{
				correct = false;
			}
		}
	}
}
