
namespace kis
{
    partial class UserForm
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
            this.closeLabel = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.reportsListLabel = new System.Windows.Forms.Label();
            this.genresRatingReportButton = new System.Windows.Forms.Button();
            this.playlistsRatingReportButton = new System.Windows.Forms.Button();
            this.countriesRatingReportButton = new System.Windows.Forms.Button();
            this.popularSongsReportButton = new System.Windows.Forms.Button();
            this.songsListReportButton = new System.Windows.Forms.Button();
            this.dataBaseGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.Location = new System.Drawing.Point(402, 2);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(22, 24);
            this.closeLabel.TabIndex = 7;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // userPicture
            // 
            this.userPicture.Image = global::kis.Properties.Resources.user;
            this.userPicture.Location = new System.Drawing.Point(0, 0);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(30, 30);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 8;
            this.userPicture.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(32, 4);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(81, 19);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "userName";
            // 
            // reportsListLabel
            // 
            this.reportsListLabel.AutoSize = true;
            this.reportsListLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsListLabel.Location = new System.Drawing.Point(20, 43);
            this.reportsListLabel.Name = "reportsListLabel";
            this.reportsListLabel.Size = new System.Drawing.Size(162, 19);
            this.reportsListLabel.TabIndex = 10;
            this.reportsListLabel.Text = "Доступные отчёты:";
            // 
            // genresRatingReportButton
            // 
            this.genresRatingReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.genresRatingReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genresRatingReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresRatingReportButton.Location = new System.Drawing.Point(24, 69);
            this.genresRatingReportButton.Name = "genresRatingReportButton";
            this.genresRatingReportButton.Size = new System.Drawing.Size(375, 59);
            this.genresRatingReportButton.TabIndex = 11;
            this.genresRatingReportButton.Text = "Рейтинг популярности музыкальных жанров среди слушателей";
            this.genresRatingReportButton.UseVisualStyleBackColor = true;
            this.genresRatingReportButton.Click += new System.EventHandler(this.genresRatingReportButton_Click);
            // 
            // playlistsRatingReportButton
            // 
            this.playlistsRatingReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playlistsRatingReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistsRatingReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistsRatingReportButton.Location = new System.Drawing.Point(24, 134);
            this.playlistsRatingReportButton.Name = "playlistsRatingReportButton";
            this.playlistsRatingReportButton.Size = new System.Drawing.Size(375, 59);
            this.playlistsRatingReportButton.TabIndex = 12;
            this.playlistsRatingReportButton.Text = "Рейтинг плейлистов среди слушателей";
            this.playlistsRatingReportButton.UseVisualStyleBackColor = true;
            this.playlistsRatingReportButton.Click += new System.EventHandler(this.playlistsRatingReportButton_Click);
            // 
            // countriesRatingReportButton
            // 
            this.countriesRatingReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.countriesRatingReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countriesRatingReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countriesRatingReportButton.Location = new System.Drawing.Point(24, 199);
            this.countriesRatingReportButton.Name = "countriesRatingReportButton";
            this.countriesRatingReportButton.Size = new System.Drawing.Size(375, 59);
            this.countriesRatingReportButton.TabIndex = 13;
            this.countriesRatingReportButton.Text = "Рейтинг стран по наибольшему числу слушателей";
            this.countriesRatingReportButton.UseVisualStyleBackColor = true;
            this.countriesRatingReportButton.Click += new System.EventHandler(this.countriesRatingReportButton_Click);
            // 
            // popularSongsReportButton
            // 
            this.popularSongsReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.popularSongsReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popularSongsReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popularSongsReportButton.Location = new System.Drawing.Point(24, 264);
            this.popularSongsReportButton.Name = "popularSongsReportButton";
            this.popularSongsReportButton.Size = new System.Drawing.Size(375, 59);
            this.popularSongsReportButton.TabIndex = 14;
            this.popularSongsReportButton.Text = "Самые популярные композиции в каждом жанре";
            this.popularSongsReportButton.UseVisualStyleBackColor = true;
            this.popularSongsReportButton.Click += new System.EventHandler(this.popularSongsReportButton_Click);
            // 
            // songsListReportButton
            // 
            this.songsListReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.songsListReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songsListReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songsListReportButton.Location = new System.Drawing.Point(24, 329);
            this.songsListReportButton.Name = "songsListReportButton";
            this.songsListReportButton.Size = new System.Drawing.Size(375, 59);
            this.songsListReportButton.TabIndex = 15;
            this.songsListReportButton.Text = "Список песен каждого музыкального жанра";
            this.songsListReportButton.UseVisualStyleBackColor = true;
            this.songsListReportButton.Click += new System.EventHandler(this.songsListReportButton_Click);
            // 
            // dataBaseGridView
            // 
            this.dataBaseGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dataBaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseGridView.Location = new System.Drawing.Point(119, 43);
            this.dataBaseGridView.Name = "dataBaseGridView";
            this.dataBaseGridView.Size = new System.Drawing.Size(240, 150);
            this.dataBaseGridView.TabIndex = 16;
            this.dataBaseGridView.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(426, 407);
            this.Controls.Add(this.dataBaseGridView);
            this.Controls.Add(this.songsListReportButton);
            this.Controls.Add(this.popularSongsReportButton);
            this.Controls.Add(this.countriesRatingReportButton);
            this.Controls.Add(this.playlistsRatingReportButton);
            this.Controls.Add(this.genresRatingReportButton);
            this.Controls.Add(this.reportsListLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.closeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хранилище платформы SPOT";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.userForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label reportsListLabel;
        private System.Windows.Forms.Button genresRatingReportButton;
        private System.Windows.Forms.Button playlistsRatingReportButton;
        private System.Windows.Forms.Button countriesRatingReportButton;
        private System.Windows.Forms.Button popularSongsReportButton;
        private System.Windows.Forms.Button songsListReportButton;
        private System.Windows.Forms.DataGridView dataBaseGridView;
    }
}