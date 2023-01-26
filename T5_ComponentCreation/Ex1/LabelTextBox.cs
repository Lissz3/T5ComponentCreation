using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Components
{
	public partial class LabelTextBox : UserControl
	{
		public LabelTextBox()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			recolocar();
		}

		private ePosicion posicion = ePosicion.IZQUIERDA;
		[Category("Appearance")]
		[Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
		public ePosicion Posicion
		{
			set
			{
				if (Enum.IsDefined(typeof(ePosicion), value))
				{
					posicion = value;
					Refresh();
					OnPosicionChanged(EventArgs.Empty);
				}
				else
				{
					throw new InvalidEnumArgumentException();
				}
			}

			get
			{
				return posicion;
			}
		}

		//Pixeles de separación entre label y textbox
		private int separacion = 0;
		[Category("Design")]
		[Description("Píxels de separación entre Label y Textbox")]
		public int Separacion
		{
			set
			{
				if (value >= 0)
				{
					separacion = value;
					Refresh();
					OnSeparacionChanged(EventArgs.Empty);
				}
				else
				{
					throw new ArgumentOutOfRangeException();
				}
			}
			get
			{
				return separacion;
			}
		}

		[Category("Appearance")]
		[Description("Texto asociado a la Label del control")]
		public string TextLbl
		{
			set
			{
				lbl.Text = value;
				Refresh();
			}
			get
			{
				return lbl.Text;
			}
		}
		[Category("Appearance")]
		[Description("Texto asociado al TextBox del control")]
		public string TextTxt
		{
			set
			{
				txt.Text = value;
			}
			get
			{
				return txt.Text;
			}
		}

		private void recolocar()
		{
			switch (posicion)
			{
				case ePosicion.IZQUIERDA:
					//Establecemos posición del componente lbl
					lbl.Location = new Point(0, 0);
					// Establecemos posición componente txt
					txt.Location = new Point(lbl.Width + Separacion, 0);
					//Establecemos ancho del Textbox 
					//(la label tiene ancho por autosize)
					Width = txt.Width + lbl.Width + Separacion;
					//Establecemos altura del componente
					Height = Math.Max(txt.Height, lbl.Height);
					break;
				case ePosicion.DERECHA:
					//Establecemos posición del componente txt
					txt.Location = new Point(0, 0);
					//Establecemos ancho del Textbox 
					Width = txt.Width + lbl.Width + Separacion;
					//Establecemos posición del componente lbl
					lbl.Location = new Point(txt.Width + Separacion, 0);
					//Establecemos altura del componente (Puede sacarse del switch)
					Height = Math.Max(txt.Height, lbl.Height);
					break;
			}
		}

		//Esta función has de enlazarla con el evento SizeChanged.
		//Sería necesario también tener en cuenta otros eventos como FontChanged
		// que aquí nos saltamos.
		//private void LabelTextBox_SizeChanged(object sender, EventArgs e)
		//{
		//	Refresh();
		//}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			Refresh();
		}

		[Category("Propia")]
		[Description("Se lanza cuando la propiedad Separacion cambia")]
		public event EventHandler PosicionChanged;

		protected virtual void OnPosicionChanged(EventArgs e)
		{
			PosicionChanged?.Invoke(this, e);
		}

		[Category("Propia")]
		[Description("Se lanza cuando la propiedad Separacion cambia")]
		public event EventHandler SeparacionChanged;

		protected virtual void OnSeparacionChanged(EventArgs e)
		{
			SeparacionChanged?.Invoke(this, e);
		}

		private void Txt_KeyUp(object sender, KeyEventArgs e)
		{
			base.OnKeyUp(e);
		}

		[Category("Propia")]
		[Description("Se lanza cuando el texto cambia")]
		public event EventHandler TxtChanged;

		protected virtual void OnTxtChanged(EventArgs e)
		{
			TxtChanged?.Invoke(this, e);
		}

		private void Txt_TextChanged(object sender, EventArgs e)
		{
			OnTxtChanged(e);
		}

		[Category("Appearance")]
		[Description("Caracter que aparece cuando se escribe en el textbox")]
		public char PswChar
		{
			set
			{
				txt.PasswordChar = value;
			}
			get
			{
				return txt.PasswordChar;
			}
		}
	}

	public enum ePosicion
	{
		IZQUIERDA,
		DERECHA
	}

}
