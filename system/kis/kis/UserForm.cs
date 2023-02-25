using System;
using System.Drawing;
using System.Windows.Forms;

namespace kis
{
    public partial class UserForm : Form
    {
        private DataBaseManager dbManager;
        private ReportManager reportManager;
        public UserForm(String userName)
        {
            InitializeComponent();

            dbManager = new DataBaseManager();
            reportManager = new ReportManager();

            userNameLabel.Text = userName;
            userNameLabel.Focus();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void userForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void userForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void genresRatingReportButton_Click(object sender, EventArgs e)
        {
            dataBaseGridView.Visible = false;
            dataBaseGridView.DataSource = dbManager.ReportRequest("genresRating");
            dataBaseGridView.Update();

            if (reportManager.CreateReportAsync("genresRating", dataBaseGridView))
                MessageBox.Show("Отчет создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Произошел сбой при создании отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void playlistsRatingReportButton_Click(object sender, EventArgs e)
        {
            dataBaseGridView.Visible = false;
            dataBaseGridView.DataSource = dbManager.ReportRequest("playlistsRating");
            dataBaseGridView.Update();

            if (reportManager.CreateReportAsync("playlistsRating", dataBaseGridView))
                MessageBox.Show("Отчет создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Произошел сбой при создании отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void countriesRatingReportButton_Click(object sender, EventArgs e)
        {
            dataBaseGridView.Visible = false;
            dataBaseGridView.DataSource = dbManager.ReportRequest("countriesRating");
            dataBaseGridView.Update();

            if (reportManager.CreateReportAsync("countriesRating", dataBaseGridView))
                MessageBox.Show("Отчет создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Произошел сбой при создании отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void popularSongsReportButton_Click(object sender, EventArgs e)
        {
            dataBaseGridView.Visible = false;
            dataBaseGridView.DataSource = dbManager.ReportRequest("popularSongs");
            dataBaseGridView.Update();

            if (reportManager.CreateReportAsync("popularSongs", dataBaseGridView))
                MessageBox.Show("Отчет создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Произошел сбой при создании отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void songsListReportButton_Click(object sender, EventArgs e)
        {
            dataBaseGridView.Visible = false;
            dataBaseGridView.DataSource = dbManager.ReportRequest("songsList");
            dataBaseGridView.Update();

            if (reportManager.CreateReportAsync("songsList", dataBaseGridView))
                MessageBox.Show("Отчет создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Произошел сбой при создании отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
