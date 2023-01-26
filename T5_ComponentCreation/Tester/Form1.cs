using Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLblTxt_Click(object sender, EventArgs e)
		{
			lbltxtP.Posicion = lbltxtP.Posicion == ePosicion.IZQUIERDA ? ePosicion.DERECHA : ePosicion.IZQUIERDA;
			Text = lbltxtP.Posicion.ToString();
		}

		private void warningLabel1_ClickMark(object sender, EventArgs e)
		{
			MessageBox.Show("click");

		}

		private void lbltxtP_SeparacionChanged(object sender, EventArgs e)
		{
			MessageBox.Show("sep cambió");
		}

		private void btnSep_Click(object sender, EventArgs e)
		{
			lbltxtP.Separacion += 10;
		}

		private void lbltxtP_KeyUp(object sender, KeyEventArgs e)
		{
			MessageBox.Show("key up");
		}
	}
}
