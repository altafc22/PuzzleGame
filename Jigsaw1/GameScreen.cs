using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MinThantSin.OpenSourceGames
{
    public partial class GameScreen : Form
    {
        GtClass gtClass;
        string selectedImage = "";
        MainForm playArea;
        public string imagePath { get; set; }
        Timer t1 = new Timer();


        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        public GameScreen()
        {
            InitializeComponent();

            /*int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);*/
        }

        /*  protected override CreateParams CreateParams
          {
              get
              {
                  CreateParams cp = base.CreateParams;
                  cp.ExStyle |= 0x02000000;
                  return cp;
              }
          }*/

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();


            gtClass = new GtClass();
            gameFramePanel.Margin = new Padding(50, 0, 50, 0);
            gameFramePanel.Width = Screen.PrimaryScreen.Bounds.Width;
            gameFramePanel.Height = Screen.PrimaryScreen.Bounds.Width + 200;

            lblCountDown.Text = "Time " + 60;


            lblHintText.Visible = true;

            panelCenter(gameFramePanel);

            panelCenter(gamePanel);
            selectedImage = gtClass.selectImage();
            pbHint.Image = new Bitmap(selectedImage);
            // new method to show hint
            hintCenter(pbHint);
            showHint();

        }

        private void loadGame()
        {
            try
            {
                playArea = new MainForm();
                playArea.imagePath = selectedImage;
                playArea.puzzle_height = gamePanel.Height+3;
                playArea.puzzle_width = gamePanel.Width+3;
                playArea.TopLevel = false;
                playArea.AutoScroll = true;
                this.gamePanel.Controls.Add(playArea);
                playArea.Show();
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
            }
           
        }

        private void panelCenter(Control panel)
        {

            panel.Location = new Point(
            this.ClientSize.Width / 2 - panel.Size.Width / 2,
            this.ClientSize.Height / 2 - panel.Size.Height / 2);
            //panel.Visible = true;
        }

        private void hintCenter(Control panel)
        {

            panel.Location = new Point(
            gameFramePanel.ClientSize.Width / 2 - panel.Size.Width / 2,
            gameFramePanel.ClientSize.Height / 2 - panel.Size.Height / 2);
            panel.Visible = true;
        }

        int hintcounter = 5;
        private void showHint()
        {
            hintTimer = new System.Windows.Forms.Timer();
            hintTimer.Tick += new EventHandler(HintTimer_Tick);
            hintTimer.Interval = 1000; // 1 second
            lblHintText.Visible = true;
            pbHint.Visible = true;
            hintTimer.Start();
        }

        private int counter = 60;
        private void startCountdown()
        {
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Tick += new EventHandler(GameTimer_Tick);
            gameTimer.Interval = 1000; // 1 second
            gameTimer.Start();
            lblCountDown.Text = "Time " + counter.ToString();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gtClass.playAudio("tick.wav");
            counter--;
            if (counter == 0)
            {

                #region Victory announcement


                if (playArea._clusters.Count != 1)
                {

                    if (playArea._victoryAnnounced == false)
                    {
                        //gtClass.playAudio("lose.wav");
                        gameTimer.Stop();
                        playArea._victoryAnnounced = true;
                        WinnerForm winnerForm = new WinnerForm();
                        winnerForm.imagePath = gtClass.getImagePath();
                        winnerForm.result = "loser";
                        winnerForm.ShowDialog();
                        this.Close();
                    }
                }

                #endregion
                //StartForm start_form = new StartForm();
                //start_form.Show();
                //this.Hide();
                //this.Close();
            }

            lblCountDown.Text = "Time " + counter.ToString();
        }

        private void HintTimer_Tick(object sender, EventArgs e)
        {
            lblHintText.Text = "Analyze Image Carefully\n time: " + hintcounter;
            hintcounter--;
            if (hintcounter == 0)
            {
                hintTimer.Stop();
                pbHint.Visible = false;
                lblHintText.Visible = false;
                loadGame();
                startCountdown();
            }
        }
    }
}
