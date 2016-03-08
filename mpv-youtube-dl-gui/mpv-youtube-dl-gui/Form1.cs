using System;
using System.Windows.Forms;

namespace mpv_youtube_dl_gui
{
	public partial class Form1 : Form
	{
		public const string MpvRoot = "mpv";
		public const string QualRoot = "ytdl-format=";

		public const string QualBest = "best";
		public const string QualLow = "\"best[height=360]\"";
		public const string QualAudio = "bestaudio";


		public Form1 ()
		{
			InitializeComponent();
		}

		private void Form1_Load (object sender, EventArgs e)
		{
			textBox1.Text = Clipboard.GetText();
		}

		private void button1_Click (object sender, EventArgs e)
		{
			string url = textBox1.Text;
			if (qualBest.Checked)
				PlayVideo(QualBest, url);
			else if (qualLow.Checked)
				PlayVideo(QualLow, url);
			else if (qualAudio.Checked)
				PlayVideo(QualAudio, url);
			else
				return;
		}

		private void PlayVideo(string quality, string url)
		{
			string command = "/K mpv " + url + " --ytdl-format=" + quality;
			System.Diagnostics.Process.Start("CMD.exe", command);
		}

	}
}
