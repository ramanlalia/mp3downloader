namespace MP3_Downloader
{
    partial class PlaySongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaySongForm));
            this.mp3Button = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // mp3Button
            // 
            this.mp3Button.Location = new System.Drawing.Point(291, 63);
            this.mp3Button.Name = "mp3Button";
            this.mp3Button.Size = new System.Drawing.Size(103, 23);
            this.mp3Button.TabIndex = 3;
            this.mp3Button.Text = "Put on MP3 Player";
            this.mp3Button.UseVisualStyleBackColor = true;
            this.mp3Button.Click += new System.EventHandler(this.mp3Button_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(9, 70);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(219, 13);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "If the song plays, click the button to the right.";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(382, 45);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // PlaySongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 91);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.mp3Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlaySongForm";
            this.Text = "MP3 Buddy - Step 3";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mp3Button;
        private System.Windows.Forms.Label instructionLabel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;

    }
}