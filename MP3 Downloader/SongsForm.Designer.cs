namespace MP3_Downloader
{
    partial class SongsForm
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
            this.songsList = new System.Windows.Forms.ListView();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songsList
            // 
            this.songsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.songsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.songsList.FullRowSelect = true;
            this.songsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.songsList.HideSelection = false;
            this.songsList.Location = new System.Drawing.Point(0, 20);
            this.songsList.MultiSelect = false;
            this.songsList.Name = "songsList";
            this.songsList.ShowGroups = false;
            this.songsList.Size = new System.Drawing.Size(463, 237);
            this.songsList.TabIndex = 6;
            this.songsList.UseCompatibleStateImageBehavior = false;
            this.songsList.View = System.Windows.Forms.View.Details;
            this.songsList.Visible = false;
            this.songsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.songsList_MouseDoubleClick);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 459;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Double click a song below to play it.";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 137);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(439, 23);
            this.progressBar.TabIndex = 9;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Location = new System.Drawing.Point(185, 121);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(78, 13);
            this.loadingLabel.TabIndex = 10;
            this.loadingLabel.Text = "Searching - 0%";
            // 
            // SongsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 257);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songsList);
            this.Name = "SongsForm";
            this.Text = "MP3 Buddy - Step 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView songsList;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label loadingLabel;
    }
}