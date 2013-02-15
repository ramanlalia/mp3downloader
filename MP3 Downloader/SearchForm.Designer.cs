namespace MP3_Downloader
{
    partial class SearchForm
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
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(9, 22);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(354, 20);
            this.searchTxt.TabIndex = 1;
            this.searchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type the name of the song in the box below, then click the big green arrow.";
            // 
            // goBtn
            // 
            this.goBtn.Image = global::MP3_Downloader.Properties.Resources.arrow1;
            this.goBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.goBtn.Location = new System.Drawing.Point(375, 8);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(38, 34);
            this.goBtn.TabIndex = 3;
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 55);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "MP3 Buddy - Step 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goBtn;
    }
}

