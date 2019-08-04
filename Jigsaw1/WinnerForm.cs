using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MinThantSin.OpenSourceGames
{
    public partial class WinnerForm : Form
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
        public string imagePath { get; set; }
        public string result { get; set; }
        public WinnerForm()
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        private void WinnerForm_Load(object sender, EventArgs e)
        {
            //CenterPictureBox(picBoxView, new Bitmap(selectedImage));
            panelCenter();
            showResult();
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 15;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();


        }

        private void showResult()
        {
            //panel1.BackgroundImage = new Bitmap(imagePath);

            if (result.Equals("winner"))
            {
                pictureBox1.Image = new Bitmap(Properties.Resources.winner);
                //trophyPanel.BackgroundImage = getResourceDirectory();

                lblMessage.Text = "Woooow, The puzzle has been solved!";
                //MessageBox.Show("The puzzle has been solved!", "Congratulations!", MessageBoxButtons.OK);
            }
            else
            {
                pictureBox1.Image = new Bitmap(Properties.Resources.loser);
                lblMessage.Text = "Ohhh, The puzzle has not been solved!";
                //MessageBox.Show("Ohhh, The puzzle has not been solved!", "You miss the chance!", MessageBoxButtons.OK);
            }

        }

        private void panelCenter()
        {
            mainPanel.Location = new Point(
            this.ClientSize.Width / 2 - mainPanel.Size.Width / 2,
            this.ClientSize.Height / 2 - mainPanel.Size.Height / 2);
            mainPanel.Anchor = AnchorStyles.None;
        }



        Timer t1 = new Timer();
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void CenterPictureBox(PictureBox picBox, Bitmap picImage)
        {
            picBox.Image = picImage;
            picBox.Location = new Point((picBox.Parent.ClientSize.Width / 2) - (picImage.Width / 2),
                                        (picBox.Parent.ClientSize.Height / 2) - (picImage.Height / 2));
            picBox.Refresh();
        }

        public static Image fadeImages(Image image1, Image image2, double fade)
        {
            Bitmap bitmap1 = new Bitmap(image1);
            Bitmap bitmap2 = new Bitmap(image2);
            Bitmap finalImage = new Bitmap(image1.Width, image1.Height);
            fade = fade < 0 || fade > 100 ? 0 : fade; //user control (must be within 0 and 100)
            fade = 100 - fade; //flip value
            fade /= 100; //convert to percent

            for (int heigth = 0; heigth < finalImage.Height; heigth++)
            {
                for (int width = 0; width < finalImage.Width; width++)
                {
                    int alpha1 = bitmap1.GetPixel(width, heigth).A; //get alpha pixel from first image
                    int alpha2 = bitmap2.GetPixel(width, heigth).A; //get alpha pixel from second image
                    int newAlpha = (int)(alpha2 + (alpha1 - alpha2) * fade); //combine and fade
                    int red1 = bitmap1.GetPixel(width, heigth).R;
                    int red2 = bitmap2.GetPixel(width, heigth).R;
                    int newRed = (int)(red2 + (red1 - red2) * fade);
                    int green1 = bitmap1.GetPixel(width, heigth).G;
                    int green2 = bitmap2.GetPixel(width, heigth).G;
                    int newGreen = (int)(green2 + (green1 - green2) * fade);
                    int blue1 = bitmap1.GetPixel(width, heigth).B;
                    int blue2 = bitmap2.GetPixel(width, heigth).B;
                    int newBlue = (int)(blue2 + (blue1 - blue2) * fade);
                    Color newColor = Color.FromArgb(newAlpha, newRed, newGreen, newBlue); //create new color
                    finalImage.SetPixel(width, heigth, newColor);
                }
            }

            return finalImage;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
