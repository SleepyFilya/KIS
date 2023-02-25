
namespace kis
{
    partial class AdminForm
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
            this.adminNameLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.dataBaseGroupBox = new System.Windows.Forms.GroupBox();
            this.currentTableNameLabel = new System.Windows.Forms.Label();
            this.genresTableButton = new System.Windows.Forms.Button();
            this.songsTableButton = new System.Windows.Forms.Button();
            this.playlistsTableButton = new System.Windows.Forms.Button();
            this.countriesTableButton = new System.Windows.Forms.Button();
            this.customersTableButton = new System.Windows.Forms.Button();
            this.usersTableButton = new System.Windows.Forms.Button();
            this.dataBaseGridView = new System.Windows.Forms.DataGridView();
            this.reportsListGroupBox = new System.Windows.Forms.GroupBox();
            this.songsListReportButton = new System.Windows.Forms.Button();
            this.popularSongsReportButton = new System.Windows.Forms.Button();
            this.countriesRatingReportButton = new System.Windows.Forms.Button();
            this.playlistsRatingReportButton = new System.Windows.Forms.Button();
            this.genresRatingReportButton = new System.Windows.Forms.Button();
            this.adminPicture = new System.Windows.Forms.PictureBox();
            this.dataBaseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGridView)).BeginInit();
            this.reportsListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // adminNameLabel
            // 
            this.adminNameLabel.AutoSize = true;
            this.adminNameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminNameLabel.Location = new System.Drawing.Point(32, 4);
            this.adminNameLabel.Name = "adminNameLabel";
            this.adminNameLabel.Size = new System.Drawing.Size(90, 19);
            this.adminNameLabel.TabIndex = 12;
            this.adminNameLabel.Text = "adminName";
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.Location = new System.Drawing.Point(949, 2);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(22, 24);
            this.closeLabel.TabIndex = 10;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // dataBaseGroupBox
            // 
            this.dataBaseGroupBox.Controls.Add(this.currentTableNameLabel);
            this.dataBaseGroupBox.Controls.Add(this.genresTableButton);
            this.dataBaseGroupBox.Controls.Add(this.songsTableButton);
            this.dataBaseGroupBox.Controls.Add(this.playlistsTableButton);
            this.dataBaseGroupBox.Controls.Add(this.countriesTableButton);
            this.dataBaseGroupBox.Controls.Add(this.customersTableButton);
            this.dataBaseGroupBox.Controls.Add(this.usersTableButton);
            this.dataBaseGroupBox.Controls.Add(this.dataBaseGridView);
            this.dataBaseGroupBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBaseGroupBox.Location = new System.Drawing.Point(12, 36);
            this.dataBaseGroupBox.Name = "dataBaseGroupBox";
            this.dataBaseGroupBox.Size = new System.Drawing.Size(551, 392);
            this.dataBaseGroupBox.TabIndex = 13;
            this.dataBaseGroupBox.TabStop = false;
            this.dataBaseGroupBox.Text = "Работа с хранилищем данных";
            // 
            // currentTableNameLabel
            // 
            this.currentTableNameLabel.AutoSize = true;
            this.currentTableNameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTableNameLabel.Location = new System.Drawing.Point(6, 89);
            this.currentTableNameLabel.Name = "currentTableNameLabel";
            this.currentTableNameLabel.Size = new System.Drawing.Size(0, 19);
            this.currentTableNameLabel.TabIndex = 20;
            // 
            // genresTableButton
            // 
            this.genresTableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.genresTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genresTableButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresTableButton.Location = new System.Drawing.Point(364, 50);
            this.genresTableButton.Name = "genresTableButton";
            this.genresTableButton.Size = new System.Drawing.Size(180, 29);
            this.genresTableButton.TabIndex = 19;
            this.genresTableButton.Text = "Жанры";
            this.genresTableButton.UseVisualStyleBackColor = true;
            this.genresTableButton.Click += new System.EventHandler(this.genresTableButton_Click);
            // 
            // songsTableButton
            // 
            this.songsTableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.songsTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songsTableButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songsTableButton.Location = new System.Drawing.Point(185, 50);
            this.songsTableButton.Name = "songsTableButton";
            this.songsTableButton.Size = new System.Drawing.Size(180, 29);
            this.songsTableButton.TabIndex = 18;
            this.songsTableButton.Text = "Песни";
            this.songsTableButton.UseVisualStyleBackColor = true;
            this.songsTableButton.Click += new System.EventHandler(this.songsTableButton_Click);
            // 
            // playlistsTableButton
            // 
            this.playlistsTableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playlistsTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistsTableButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistsTableButton.Location = new System.Drawing.Point(6, 50);
            this.playlistsTableButton.Name = "playlistsTableButton";
            this.playlistsTableButton.Size = new System.Drawing.Size(180, 29);
            this.playlistsTableButton.TabIndex = 17;
            this.playlistsTableButton.Text = "Плейлисты";
            this.playlistsTableButton.UseVisualStyleBackColor = true;
            this.playlistsTableButton.Click += new System.EventHandler(this.playlistsTableButton_Click);
            // 
            // countriesTableButton
            // 
            this.countriesTableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.countriesTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countriesTableButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countriesTableButton.Location = new System.Drawing.Point(364, 22);
            this.countriesTableButton.Name = "countriesTableButton";
            this.countriesTableButton.Size = new System.Drawing.Size(180, 29);
            this.countriesTableButton.TabIndex = 16;
            this.countriesTableButton.Text = "Страны";
            this.countriesTableButton.UseVisualStyleBackColor = true;
            this.countriesTableButton.Click += new System.EventHandler(this.countriesTableButton_Click);
            // 
            // customersTableButton
            // 
            this.customersTableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.customersTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersTableButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersTableButton.Location = new System.Drawing.Point(185, 22);
            this.customersTableButton.Name = "customersTableButton";
            this.customersTableButton.Size = new System.Drawing.Size(180, 29);
            this.customersTableButton.TabIndex = 15;
            this.customersTableButton.Text = "Слушатели";
            this.customersTableButton.UseVisualStyleBackColor = true;
            this.customersTableButton.Click += new System.EventHandler(this.customersTableButton_Click);
            // 
            // usersTableButton
            // 
            this.usersTableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.usersTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersTableButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersTableButton.Location = new System.Drawing.Point(6, 22);
            this.usersTableButton.Name = "usersTableButton";
            this.usersTableButton.Size = new System.Drawing.Size(180, 29);
            this.usersTableButton.TabIndex = 14;
            this.usersTableButton.Text = "Пользователи";
            this.usersTableButton.UseVisualStyleBackColor = true;
            this.usersTableButton.Click += new System.EventHandler(this.usersTableButton_Click);
            // 
            // dataBaseGridView
            // 
            this.dataBaseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBaseGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dataBaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseGridView.Location = new System.Drawing.Point(6, 110);
            this.dataBaseGridView.Name = "dataBaseGridView";
            this.dataBaseGridView.Size = new System.Drawing.Size(538, 276);
            this.dataBaseGridView.TabIndex = 0;
            this.dataBaseGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaseGridView_CellValueChanged);
            this.dataBaseGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataBaseGridView_DataError);
            this.dataBaseGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataBaseGridView_UserAddedRow);
            // 
            // reportsListGroupBox
            // 
            this.reportsListGroupBox.Controls.Add(this.songsListReportButton);
            this.reportsListGroupBox.Controls.Add(this.popularSongsReportButton);
            this.reportsListGroupBox.Controls.Add(this.countriesRatingReportButton);
            this.reportsListGroupBox.Controls.Add(this.playlistsRatingReportButton);
            this.reportsListGroupBox.Controls.Add(this.genresRatingReportButton);
            this.reportsListGroupBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsListGroupBox.Location = new System.Drawing.Point(569, 36);
            this.reportsListGroupBox.Name = "reportsListGroupBox";
            this.reportsListGroupBox.Size = new System.Drawing.Size(391, 392);
            this.reportsListGroupBox.TabIndex = 14;
            this.reportsListGroupBox.TabStop = false;
            this.reportsListGroupBox.Text = "Работа с отчётами";
            // 
            // songsListReportButton
            // 
            this.songsListReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.songsListReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songsListReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songsListReportButton.Location = new System.Drawing.Point(6, 326);
            this.songsListReportButton.Name = "songsListReportButton";
            this.songsListReportButton.Size = new System.Drawing.Size(375, 59);
            this.songsListReportButton.TabIndex = 21;
            this.songsListReportButton.Text = "Список песен каждого музыкального жанра";
            this.songsListReportButton.UseVisualStyleBackColor = true;
            this.songsListReportButton.Click += new System.EventHandler(this.songsListReportButton_Click);
            // 
            // popularSongsReportButton
            // 
            this.popularSongsReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.popularSongsReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popularSongsReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popularSongsReportButton.Location = new System.Drawing.Point(6, 250);
            this.popularSongsReportButton.Name = "popularSongsReportButton";
            this.popularSongsReportButton.Size = new System.Drawing.Size(375, 59);
            this.popularSongsReportButton.TabIndex = 20;
            this.popularSongsReportButton.Text = "Самые популярные композиции в каждом жанре";
            this.popularSongsReportButton.UseVisualStyleBackColor = true;
            this.popularSongsReportButton.Click += new System.EventHandler(this.popularSongsReportButton_Click);
            // 
            // countriesRatingReportButton
            // 
            this.countriesRatingReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.countriesRatingReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countriesRatingReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countriesRatingReportButton.Location = new System.Drawing.Point(6, 174);
            this.countriesRatingReportButton.Name = "countriesRatingReportButton";
            this.countriesRatingReportButton.Size = new System.Drawing.Size(375, 59);
            this.countriesRatingReportButton.TabIndex = 19;
            this.countriesRatingReportButton.Text = "Рейтинг стран по наибольшему числу слушателей";
            this.countriesRatingReportButton.UseVisualStyleBackColor = true;
            this.countriesRatingReportButton.Click += new System.EventHandler(this.countriesRatingReportButton_Click);
            // 
            // playlistsRatingReportButton
            // 
            this.playlistsRatingReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playlistsRatingReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistsRatingReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistsRatingReportButton.Location = new System.Drawing.Point(6, 98);
            this.playlistsRatingReportButton.Name = "playlistsRatingReportButton";
            this.playlistsRatingReportButton.Size = new System.Drawing.Size(375, 59);
            this.playlistsRatingReportButton.TabIndex = 18;
            this.playlistsRatingReportButton.Text = "Рейтинг плейлистов среди слушателей";
            this.playlistsRatingReportButton.UseVisualStyleBackColor = true;
            this.playlistsRatingReportButton.Click += new System.EventHandler(this.playlistsRatingReportButton_Click);
            // 
            // genresRatingReportButton
            // 
            this.genresRatingReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.genresRatingReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genresRatingReportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresRatingReportButton.Location = new System.Drawing.Point(6, 22);
            this.genresRatingReportButton.Name = "genresRatingReportButton";
            this.genresRatingReportButton.Size = new System.Drawing.Size(375, 59);
            this.genresRatingReportButton.TabIndex = 17;
            this.genresRatingReportButton.Text = "Рейтинг популярности музыкальных жанров среди слушателей";
            this.genresRatingReportButton.UseVisualStyleBackColor = true;
            this.genresRatingReportButton.Click += new System.EventHandler(this.genresRatingReportButton_Click);
            // 
            // adminPicture
            // 
            this.adminPicture.Image = global::kis.Properties.Resources.user;
            this.adminPicture.Location = new System.Drawing.Point(0, 0);
            this.adminPicture.Name = "adminPicture";
            this.adminPicture.Size = new System.Drawing.Size(30, 30);
            this.adminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminPicture.TabIndex = 11;
            this.adminPicture.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(972, 439);
            this.Controls.Add(this.reportsListGroupBox);
            this.Controls.Add(this.dataBaseGroupBox);
            this.Controls.Add(this.adminNameLabel);
            this.Controls.Add(this.adminPicture);
            this.Controls.Add(this.closeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adminForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adminForm_MouseMove);
            this.dataBaseGroupBox.ResumeLayout(false);
            this.dataBaseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseGridView)).EndInit();
            this.reportsListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminNameLabel;
        private System.Windows.Forms.PictureBox adminPicture;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.GroupBox dataBaseGroupBox;
        private System.Windows.Forms.DataGridView dataBaseGridView;
        private System.Windows.Forms.Button usersTableButton;
        private System.Windows.Forms.Button customersTableButton;
        private System.Windows.Forms.Button countriesTableButton;
        private System.Windows.Forms.Button playlistsTableButton;
        private System.Windows.Forms.Button songsTableButton;
        private System.Windows.Forms.Button genresTableButton;
        private System.Windows.Forms.Label currentTableNameLabel;
        private System.Windows.Forms.GroupBox reportsListGroupBox;
        private System.Windows.Forms.Button songsListReportButton;
        private System.Windows.Forms.Button popularSongsReportButton;
        private System.Windows.Forms.Button countriesRatingReportButton;
        private System.Windows.Forms.Button playlistsRatingReportButton;
        private System.Windows.Forms.Button genresRatingReportButton;
    }
}