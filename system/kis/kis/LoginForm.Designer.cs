
namespace kis
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLabel = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.userPasswordText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.closeLabel = new System.Windows.Forms.Label();
            this.PasswordPicture = new System.Windows.Forms.PictureBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(80, 16);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(180, 32);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Авторизация";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameText
            // 
            this.userNameText.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameText.Location = new System.Drawing.Point(118, 64);
            this.userNameText.Name = "userNameText";
            this.userNameText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.userNameText.Size = new System.Drawing.Size(175, 32);
            this.userNameText.TabIndex = 3;
            // 
            // userPasswordText
            // 
            this.userPasswordText.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPasswordText.Location = new System.Drawing.Point(118, 121);
            this.userPasswordText.Name = "userPasswordText";
            this.userPasswordText.PasswordChar = '*';
            this.userPasswordText.Size = new System.Drawing.Size(174, 32);
            this.userPasswordText.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(121, 179);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(99, 40);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.Location = new System.Drawing.Point(301, 2);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(22, 24);
            this.closeLabel.TabIndex = 6;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // PasswordPicture
            // 
            this.PasswordPicture.Image = global::kis.Properties.Resources.password;
            this.PasswordPicture.Location = new System.Drawing.Point(48, 117);
            this.PasswordPicture.Name = "PasswordPicture";
            this.PasswordPicture.Size = new System.Drawing.Size(40, 40);
            this.PasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordPicture.TabIndex = 2;
            this.PasswordPicture.TabStop = false;
            // 
            // userPicture
            // 
            this.userPicture.Image = global::kis.Properties.Resources.user;
            this.userPicture.Location = new System.Drawing.Point(48, 60);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(40, 40);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 1;
            this.userPicture.TabStop = false;
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(325, 231);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userPasswordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.PasswordPicture);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хранилище платформы SPOT";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.PictureBox PasswordPicture;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox userPasswordText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label closeLabel;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
    }
}

