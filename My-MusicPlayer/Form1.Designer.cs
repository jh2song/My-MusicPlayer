namespace My_MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playlist = new System.Windows.Forms.ListBox();
            this.toLeft = new System.Windows.Forms.PictureBox();
            this.albumCover = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.toRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toRight)).BeginInit();
            this.SuspendLayout();
            // 
            // playlist
            // 
            this.playlist.AllowDrop = true;
            this.playlist.Dock = System.Windows.Forms.DockStyle.Right;
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 12;
            this.playlist.Location = new System.Drawing.Point(557, 0);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(161, 622);
            this.playlist.TabIndex = 0;
            this.playlist.DragDrop += new System.Windows.Forms.DragEventHandler(this.playlist_DragDrop);
            this.playlist.DragEnter += new System.Windows.Forms.DragEventHandler(this.playlist_DragEnter);
            this.playlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playlist_MouseDoubleClick);
            // 
            // toLeft
            // 
            this.toLeft.Image = global::My_MusicPlayer.Properties.Resources.backward;
            this.toLeft.Location = new System.Drawing.Point(102, 320);
            this.toLeft.Name = "toLeft";
            this.toLeft.Size = new System.Drawing.Size(55, 55);
            this.toLeft.TabIndex = 2;
            this.toLeft.TabStop = false;
            this.toLeft.Click += new System.EventHandler(this.toLeft_Click);
            // 
            // albumCover
            // 
            this.albumCover.Image = global::My_MusicPlayer.Properties.Resources.guitar;
            this.albumCover.Location = new System.Drawing.Point(224, 103);
            this.albumCover.Name = "albumCover";
            this.albumCover.Size = new System.Drawing.Size(135, 124);
            this.albumCover.TabIndex = 1;
            this.albumCover.TabStop = false;
            // 
            // play
            // 
            this.play.Image = global::My_MusicPlayer.Properties.Resources.play;
            this.play.Location = new System.Drawing.Point(185, 320);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(55, 55);
            this.play.TabIndex = 3;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Image = global::My_MusicPlayer.Properties.Resources.pause;
            this.pause.Location = new System.Drawing.Point(268, 320);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(55, 55);
            this.pause.TabIndex = 4;
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // stop
            // 
            this.stop.Image = global::My_MusicPlayer.Properties.Resources.stop;
            this.stop.Location = new System.Drawing.Point(351, 320);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(55, 55);
            this.stop.TabIndex = 5;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // toRight
            // 
            this.toRight.Image = global::My_MusicPlayer.Properties.Resources.forwards;
            this.toRight.Location = new System.Drawing.Point(434, 320);
            this.toRight.Name = "toRight";
            this.toRight.Size = new System.Drawing.Size(55, 55);
            this.toRight.TabIndex = 6;
            this.toRight.TabStop = false;
            this.toRight.Click += new System.EventHandler(this.toRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(718, 622);
            this.Controls.Add(this.toRight);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.toLeft);
            this.Controls.Add(this.albumCover);
            this.Controls.Add(this.playlist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JH2MusicPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.toLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.PictureBox albumCover;
        private System.Windows.Forms.PictureBox toLeft;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox toRight;
    }
}

