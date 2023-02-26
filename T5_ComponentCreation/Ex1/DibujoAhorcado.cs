using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
	public partial class DibujoAhorcado : UserControl
	{
		private int width;
		private int height;

		public DibujoAhorcado()
		{
			InitializeComponent();
			width = Width;
			height = Height;
		}

		private int maxErrors = 7;
		private int errors = 0;
		[Category("Errores")]
		[Description("Número de errores que se han cometido")]
		public int Errors
		{
			set
			{
				if (value > maxErrors)
				{
					value = maxErrors;
				}
				errors = value;
				OnErrorChanged(EventArgs.Empty);
				if (errors == maxErrors)
				{
					OnAhorcadoDone(EventArgs.Empty);
				}
				Refresh();
			}

			get { return errors; }
		}

		[Category("Propias")]
		[Description("Se lanza cuando la propiedad Errores cambia")]
		public event EventHandler CambiaError;

		protected virtual void OnErrorChanged(EventArgs e)
		{
			CambiaError?.Invoke(this, e);
		}

		[Category("Propias")]
		[Description("Se lanza cuando se dibuja el Ahorcado entero")]
		public event EventHandler Ahorcado;

		protected virtual void OnAhorcadoDone(EventArgs e)
		{
			Ahorcado?.Invoke(this, e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;
			int stroke = 5;
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			Pen pen = new Pen(Color.Black, stroke);

			switch (Errors)
			{
				case 0:
					g.DrawLine(pen, new Point(0, height - stroke), new Point(width / 2, height - stroke));
					break;
				case 1:
					g.DrawLine(pen, new Point(width / 4, height - stroke), new Point(width / 4, height / 3 - stroke));
					goto case 0;
				case 2:
					g.DrawLine(pen, new Point(width / 4 - stroke / 2, height / 3 - stroke), new Point(width / 4 + width / 2, height / 3 - stroke));
					goto case 1;
				case 3:
					g.DrawLine(pen, new Point(width / 4 + width / 2 - stroke / 2, height / 3 - stroke), new Point(width / 4 + width / 2 - stroke / 2, height / 2 - stroke));
					goto case 2;
				case 4:
					g.DrawEllipse(pen, new RectangleF(width / 4 + width / 2 - 40 / 2 - stroke / 2, height / 2 - stroke, 40, 40));
					goto case 3;
				case 5:
					g.DrawLine(pen, new Point(width / 4 + width / 2 - stroke / 2, height / 2 + 40 - stroke), new Point(width / 4 + width / 2 - stroke / 2, height / 2 + 100 - stroke));
					goto case 4;
				case 6:
					g.DrawLine(pen, new Point(width / 4 + width / 2 - stroke / 2 - 30, height / 2 + 60 - stroke), new Point(width / 4 + width / 2 - stroke / 2 + 30, height / 2 + 60 - stroke));
					goto case 5;
				case 7:
					g.DrawLine(pen, new Point(width / 4 + width / 2 - stroke / 2, height / 2 + 100 - stroke), new Point(width / 4 + width / 2 - stroke / 2 + 20, height / 2 + 100 - stroke + 30));
					g.DrawLine(pen, new Point(width / 4 + width / 2 - stroke / 2, height / 2 + 100 - stroke), new Point(width / 4 + width / 2 - stroke / 2 - 20, height / 2 + 100 - stroke + 30));
					goto case 6;
			}

			pen.Dispose();
		}
	}
}
