namespace MinThantSin.OpenSourceGames
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gamePanel = new System.Windows.Forms.Panel();
            this.pbHint = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.hintTimer = new System.Windows.Forms.Timer(this.components);
            this.gameFramePanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.lblHintText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).BeginInit();
            this.gameFramePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.Control;
            this.gamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePanel.BackgroundImage")));
            this.gamePanel.Controls.Add(this.pbHint);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(5, 5);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1037, 513);
            this.gamePanel.TabIndex = 0;
            // 
            // pbHint
            // 
            this.pbHint.Location = new System.Drawing.Point(211, 58);
            this.pbHint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbHint.Name = "pbHint";
            this.pbHint.Size = new System.Drawing.Size(600, 601);
            this.pbHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHint.TabIndex = 1;
            this.pbHint.TabStop = false;
            this.pbHint.Visible = false;
            // 
            // gameFramePanel
            // 
            this.gameFramePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gameFramePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(63)))), ((int)(((byte)(35)))));
            this.gameFramePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameFramePanel.Controls.Add(this.gamePanel);
            this.gameFramePanel.Location = new System.Drawing.Point(0, 198);
            this.gameFramePanel.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.gameFramePanel.Name = "gameFramePanel";
            this.gameFramePanel.Padding = new System.Windows.Forms.Padding(5);
            this.gameFramePanel.Size = new System.Drawing.Size(1047, 523);
            this.gameFramePanel.TabIndex = 11;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.BackgroundImage = global::MinThantSin.OpenSourceGames.Properties.Resources.new_bg;
            this.topPanel.ColumnCount = 3;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.59146F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.40854F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.topPanel.Controls.Add(this.lblCountDown, 0, 0);
            this.topPanel.Controls.Add(this.lblHintText, 1, 0);
            this.topPanel.Controls.Add(this.pictureBox1, 2, 0);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 1;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topPanel.Size = new System.Drawing.Size(1047, 198);
            this.topPanel.TabIndex = 12;
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountDown.Font = new System.Drawing.Font("Digital-7", 36F);
            this.lblCountDown.ForeColor = System.Drawing.Color.Red;
            this.lblCountDown.Location = new System.Drawing.Point(3, 0);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(211, 198);
            this.lblCountDown.TabIndex = 4;
            this.lblCountDown.Text = "label1";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHintText
            // 
            this.lblHintText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHintText.AutoSize = true;
            this.lblHintText.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintText.ForeColor = System.Drawing.Color.Gray;
            this.lblHintText.Location = new System.Drawing.Point(220, 0);
            this.lblHintText.Name = "lblHintText";
            this.lblHintText.Size = new System.Drawing.Size(563, 198);
            this.lblHintText.TabIndex = 5;
            this.lblHintText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MinThantSin.OpenSourceGames.Properties.Resources.mall_logo;
            this.pictureBox1.Location = new System.Drawing.Point(789, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinThantSin.OpenSourceGames.Properties.Resources.new_bg;
            this.ClientSize = new System.Drawing.Size(1047, 721);
            this.Controls.Add(this.gameFramePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameScreen";
            this.Opacity = 0D;
            this.Text = "GameScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).EndInit();
            this.gameFramePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox pbHint;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer hintTimer;
        private System.Windows.Forms.Panel gameFramePanel;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label lblHintText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}