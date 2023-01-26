using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
	public partial class Form1 : Form
	{
		FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
		string folderName = "";
		FileInfo[] files;
		DirectoryInfo d;
		int cont = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnSelect_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.Description = "Seleccione directorio";
			folderBrowserDialog1.ShowNewFolderButton = false;
			folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				folderName = folderBrowserDialog1.SelectedPath;
				if (folderName != null)
				{
					txtFolder.Text = folderName;
					d = new DirectoryInfo(folderName);
					try
					{
						files = d.GetFiles("*.jpg");
					}
					catch (UnauthorizedAccessException)
					{
						txtFolder.ForeColor = Color.Red;
					}

					if (files.Length > 0)
					{
						picBoxPlayer.Image = new Bitmap(files[0].FullName);
						picBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;
					}
				}
			}
		}

		private void tmr_Tick(object sender, EventArgs e)
		{
			if (files != null)
			{
				if (mediaPlayer1.Play)
				{
					mediaPlayer1.SS++;
					cont++;
					if (cont == files.Length)
					{
						cont = 0;
					}
					if (mediaPlayer1.SS % (comboBox1.SelectedIndex + 1) == 0)
					{
						picBoxPlayer.Image = new Bitmap(files[cont].FullName);
					}
					mediaPlayer1.TextRefresh();
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 1; i <= 20; i++)
			{
				comboBox1.Items.Add(i);
			}
			comboBox1.SelectedIndex = 0;
		}
	}
}
