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
            toLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            play.SizeMode = PictureBoxSizeMode.StretchImage;
            pause.SizeMode = PictureBoxSizeMode.StretchImage;
            stop.SizeMode = PictureBoxSizeMode.StretchImage;
            toRight.SizeMode = PictureBoxSizeMode.StretchImage;
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
            static public int playingIndex = 0;
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
            playing.playingIndex = this.playlist.IndexFromPoint(e.Location);
            // 재생할 파일 : playlistClass.songFilePath[index]

            playing.mMediaPlayer.Open(new Uri(playlistClass.songFilePath[playing.
                playingIndex], UriKind.Absolute));
            playing.mMediaPlayer.Play();
        }

        private void toLeft_Click(object sender, EventArgs e)
        {
            --playing.playingIndex;
            if (playing.playingIndex < 0)
                playing.playingIndex += playlist.Items.Count;

            playing.mMediaPlayer.Open(new Uri(playlistClass.songFilePath[playing.
                playingIndex], UriKind.Absolute));
            playing.mMediaPlayer.Play();
        }

        private void toRight_Click(object sender, EventArgs e)
        {
            ++playing.playingIndex;
            if (playing.playingIndex >= playlist.Items.Count)
                playing.playingIndex -= playlist.Items.Count;

            playing.mMediaPlayer.Open(new Uri(playlistClass.songFilePath[playing.
                playingIndex], UriKind.Absolute));
            playing.mMediaPlayer.Play();
        }

        private void play_Click(object sender, EventArgs e)
        {
            playing.mMediaPlayer.Play();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            playing.mMediaPlayer.Pause();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            playing.mMediaPlayer.Stop();
        }
    }
}
