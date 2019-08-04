using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MinThantSin.OpenSourceGames
{
    public partial class StartForm : Form
    {

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }
        public StartForm()
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

            panelCenter();
            playMusic();
        }

        private void panelCenter()
        {
            mainPanel.Location = new Point(
            this.ClientSize.Width / 2 - mainPanel.Size.Width / 2,
            this.ClientSize.Height / 2 - mainPanel.Size.Height / 2);
            mainPanel.Anchor = AnchorStyles.None;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            playButton.Image = new Bitmap(Properties.Resources.button_clicked);
            /*MainForm main_form = new MainForm();
            main_form.ShowDialog();*/
            //this.Close();
            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();
            //this.Hide();
        }


        private void PlayButton_MouseHover(object sender, EventArgs e)
        {
            playButton.Image = new Bitmap(Properties.Resources.start_btn);
        }

        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.Image = new Bitmap(Properties.Resources.start_btn);
        }
        private void playMusic()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.bgm_music);
            sound.PlayLooping();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    } 
}
