using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media;

namespace My_MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            albumCover.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private static class playlistClass
        {
            public static List<string> songFilePath = new List<string>();
            public static int songNum = 0;
            public static void Add(string s)
            {
                songFilePath.Add(s);
                songNum++;
            }
        }

        private static class playing
        {
            static public MediaPlayer mMediaPlayer = new MediaPlayer();
        }

        private void playlist_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void playlist_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            string[] tmp = (string[])e.Data.GetData(DataFormats.FileDrop, false);


            for (int i = 0; i < tmp.Length; i++)
                playlistClass.Add(tmp[i]);

            playlist.Items.Clear();

            for (int i = 0; i < playlistClass.songNum; i++)
                playlist.Items.Add(Path.GetFileName(playlistClass.songFilePath[i]));

        }

        // 재생 해야 됨
        private void playlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.playlist.IndexFromPoint(e.Location);

            // 재생할 파일 : playlistClass.songFilePath[index]

            playing.mMediaPlayer.Open(new Uri(playlistClass.songFilePath[index], UriKind.Absolute));
            playing.mMediaPlayer.Play();
        }
}
}
