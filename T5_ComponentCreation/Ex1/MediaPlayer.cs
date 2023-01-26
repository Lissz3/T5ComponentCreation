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

namespace Ex1
{
	public partial class MediaPlayer : UserControl
	{
		private bool play = false;
		public bool Play
		{
			set { play = value; }
			get { return play; }
		}

		public MediaPlayer()
		{
			InitializeComponent();
			lblTime.Text = $"{MM:00}:{SS:00}";
		}

		public void ChangeImgOnClick()
		{
			if (play)
			{
				btnPlayPause.Image = Properties.Resources.play;
			}
			else
			{
				btnPlayPause.Image = Properties.Resources.pause;
			}
		}

		private void BtnPlayPause_Click(object sender, EventArgs e)
		{
			ChangeImgOnClick();
			OnPlayClick(e);
			play = !play;
		}

		[Category("Click en Play/Pause")]
		[Description("Se lanza cuando se hace click en el boton de play/pause")]
		public event EventHandler PlayClick;

		protected virtual void OnPlayClick(EventArgs e)
		{
			PlayClick?.Invoke(this, e);
		}

		private int mm = 0;
		[Category("Texto")]
		[Description("Minutos")]
		public int MM
		{
			set
			{
				if (value >= 0)
				{
					mm = value;
					if (mm > 59)
					{
						mm = 0;
					}
				}
				else
				{
					throw new ArgumentException();
				}
			}

			get
			{
				return mm;
			}
		}

		private int ss = 0;
		[Category("Texto")]
		[Description("Segundos")]
		public int SS
		{
			set
			{
				if (value >= 0)
				{
					ss = value;
					if (ss > 59)
					{
						ss %= 60;
						OnDesbordaTiempo(EventArgs.Empty);
					}
				}
				else
				{
					throw new ArgumentException();
				}
			}

			get
			{
				return ss;
			}
		}

		[Category("Desborda tiempo")]
		[Description("Se lanza cuando los segundos superan 59")]
		public event EventHandler DesbordaTiempo;

		protected virtual void OnDesbordaTiempo(EventArgs e)
		{
			DesbordaTiempo?.Invoke(this, e);
			MM++;
		}

		public void TextRefresh()
		{
			lblTime.Text = $"{MM:00}:{SS:00}";
		}

	}
}
