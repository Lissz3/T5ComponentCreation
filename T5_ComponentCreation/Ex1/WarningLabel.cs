using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
	public partial class WarningLabel : Control
	{
		public WarningLabel()
		{
			InitializeComponent();
		}

		int offsetX = 0;

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;
			int grosor = 0; //Grosor de las líneas de dibujo
			offsetX = 0; //Desplazamiento a la derecha del texto
			int offsetY = 0; //Desplazamiento hacia abajo del texto
			int h = Font.Height; // Altura de fuente, usada como referencia en varias partes

			//Esta propiedad provoca mejoras en la apariencia o en la eficiencia a la hora de dibujar
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			//Dependiendo del valor de la propiedad marca dibujamos una Cruz o un Círculo
			switch (Marca)
			{
				case eMarca.Circulo:
					grosor = 10;
					g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, h, h);
					offsetX = h + grosor;
					offsetY = grosor;
					break;
				case eMarca.Cruz:
					grosor = 3;
					Pen lapiz = new Pen(Color.Red, grosor);
					g.DrawLine(lapiz, grosor, grosor, h, h);
					g.DrawLine(lapiz, h, grosor, grosor, h);
					offsetX = h + grosor;
					offsetY = grosor / 2;
					//Es recomendable liberar recursos de dibujo pues se pueden realizar muchos y cogen memoria
					lapiz.Dispose();
					break;

				case eMarca.Imagen:
					if (MarcaImage != null)
					{
						Image img = MarcaImage;
						offsetX = h;
						offsetY = grosor;
						g.DrawImage(img, 0, 0, h, h);
					}
					break;
			}

			Size tam = g.MeasureString(Text, Font).ToSize();
			Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);

			if (gardient)
			{
				LinearGradientBrush gPen = new LinearGradientBrush(new Point(0, 10), new Point(200, 10), FirstColor, SecondColor);
				g.FillRectangle(gPen, offsetX, offsetY, tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
			}

			//Finalmente pintamos el Texto; desplazado si fuera necesario
			SolidBrush b = new SolidBrush(ForeColor);
			g.DrawString(Text, Font, b, offsetX + grosor, offsetY);
			b.Dispose();
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			Refresh();
		}

		public enum eMarca
		{
			Nada,
			Cruz,
			Circulo,
			Imagen
		}

		private eMarca marca = eMarca.Nada;
		[Category("Appearance")]
		[Description("Indica el tipo de marca que aparece junto al texto")]
		public eMarca Marca
		{
			set
			{
				marca = value;
				Refresh();
			}
			get
			{
				return marca;
			}
		}


		private bool gardient = false;
		[Category("Appearance")]
		[Description("Indica si el fondo es un gradiente")]
		public bool Gardient
		{
			set
			{
				gardient = value;
				Refresh();
			}
			get
			{
				return gardient;
			}
		}

		private Color firstColor = Color.White;
		[Category("Appearance")]
		[Description("Color inicial del gardiente")]
		public Color FirstColor
		{
			set
			{
				firstColor = value;
				Refresh();
			}
			get
			{
				return firstColor;
			}
		}

		private Color secondColor = Color.Black;
		[Category("Appearance")]
		[Description("Color final del gardiente")]
		public Color SecondColor
		{
			set
			{
				secondColor = value;
				Refresh();
			}
			get
			{
				return secondColor;
			}
		}

		private Image marcaImage = null;
		[Category("Appearance")]
		[Description("Imagen de la etiqueta")]
		public Image MarcaImage
		{
			set
			{
				marcaImage = value;
				Refresh();
			}

			get
			{
				return marcaImage;
			}
		}

		[Category("Click en marca")]
		[Description("Se lanza cuando se hace click en la marca")]
		public event EventHandler ClickMark;

		protected virtual void OnClickMark(EventArgs e)
		{
			ClickMark(this, e);
		}

		protected override void OnMouseClick(MouseEventArgs e)
		{
			base.OnMouseClick(e);
			if (ClickMark != null && Marca != eMarca.Nada)
			{
				if (e.X < offsetX)
				{
					OnClickMark(e);
				}
			}
		}
	}
}
