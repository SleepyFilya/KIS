using System;
using System.Drawing;
using System.Windows.Forms;

namespace kis
{
    public partial class AdminForm : Form
    {
        private DataBaseManager dbManager;
        private ReportManager reportManager;
        private bool newRowAdding = false;

        public AdminForm(String adminName)
        {
            InitializeComponent();

            adminNameLabel.Text = adminName;

            dbManager = new DataBaseManager();
            reportManager = new ReportManager();
        }

        //Тыки на кнопки загрузки таблиц
        private void usersTableButton_Click(object sender, EventArgs e)
        {
            currentTableNameLabel.Text = "Пользователи системы";
            LoadTable("user_system");
        }
        private void customersTableButton_Click(object sender, EventArgs e)
        {
            currentTableNameLabel.Text = "Слушатели приложения";
            LoadTable("customer");
        }
        private void countriesTableButton_Click(object sender, EventArgs e)
        {
            currentTableNameLabel.Text = "Страны слушателей";
            LoadTable("country");
        }
        private void playlistsTableButton_Click(object sender, EventArgs e)
        {
            currentTableNameLabel.Text = "Плейлисты приложения";
            LoadTable("playlist");
        }
        private void songsTableButton_Click(object sender, EventArgs e)
        {
            currentTableNameLabel.Text = "Песни приложения";
            LoadTable("song");
        }
        private void genresTableButton_Click(object sender, EventArgs e)
        {
            currentTableNameLabel.Text = "Жанры приложения";
            LoadTable("genre");
        }
        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Перемещение окна
        Point lastPoint;
        private void adminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void adminForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //взаимодействие с ячейками dataGridView
        private void dataBaseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == dataBaseGridView.Columns.Count-1)
                {
                    String task = dataBaseGridView.Rows[e.RowIndex].Cells[dataBaseGridView.Columns.Count - 1].Value.ToString();

                    if(task == "Delete")
                    {
                        String data = "";

                        for(int i = 0; i < dataBaseGridView.Columns.Count; i++)
                        {
                            data += dataBaseGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
                            if (i != dataBaseGridView.Columns.Count - 1)
                                data += " ";
                        }

                        dbManager.DeleteEntry(currentTableNameLabel.Text, data);

                        ReloadTable(currentTableNameLabel.Text);
                    }
                    else if(task == "Insert")
                    {
                        newRowAdding = false;

                        dataBaseGridView.Rows[e.RowIndex].Cells[dataBaseGridView.Columns.Count - 1].Value = "Delete";
                        String data = "";

                        for (int i = 0; i < dataBaseGridView.Columns.Count - 1; i++)
                        {
                            data += dataBaseGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
                            if (i != dataBaseGridView.Columns.Count - 2)
                                data += " ";
                        }

                        dbManager.InsertEntry(currentTableNameLabel.Text, data);

                        ReloadTable(currentTableNameLabel.Text);
                    }
                    else if(task == "Update")
                    {
                        dataBaseGridView.Rows[e.RowIndex].Cells[dataBaseGridView.Columns.Count - 1].Value = "Delete";
                        String data = "";

                        for (int i = 1; i < dataBaseGridView.Columns.Count - 1; i++)
                        {
                            data += dataBaseGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
                            if (i != dataBaseGridView.Columns.Count - 2)
                                data += "/";
                        }

                        dbManager.UpdateEntry(currentTableNameLabel.Text, e.RowIndex, data);

                        ReloadTable(currentTableNameLabel.Text);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataBaseGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if(!newRowAdding)
                {
                    newRowAdding = true;

                    int lastRow = dataBaseGridView.Rows.Count - 2;
                    DataGridViewRow row = dataBaseGridView.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataBaseGridView[dataBaseGridView.Columns.Count - 1, lastRow] = linkCell;
                    row.Cells[dataBaseGridView.Columns.Count - 1].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataBaseGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(!newRowAdding)
                {
                    int rowIndex = dataBaseGridView.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataBaseGridView.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataBaseGridView[dataBaseGridView.Columns.Count - 1, rowIndex] = linkCell;
                    editingRow.Cells[dataBaseGridView.Columns.Count - 1].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //загрузка таблиц
        private void LoadTable(String name)
        {
            dataBaseGridView.DataSource = dbManager.LoadTable(name);

            for(int i = 0; i < dataBaseGridView.Columns.Count; i++)
            {
                if (dataBaseGridView.Columns[(name + "_id")].Visible)
                    dataBaseGridView.Columns[(name + "_id")].Visible = false;
                else if(dataBaseGridView.Columns[i].HeaderText.Contains("genre_id") && name != "genre")
                {
                    dataBaseGridView.Columns[i].Visible = true;
                    dataBaseGridView.Columns[i].DisplayIndex = 5;
                }
            }

            dataBaseGridView.Columns["Action"].DisplayIndex = dataBaseGridView.Columns.Count - 1;

            for (int i = 0; i < dataBaseGridView.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataBaseGridView[dataBaseGridView.Columns.Count - 1, i] = linkCell;
            }

            dataBaseGridView.Visible = true;
            dataBaseGridView.Update();
        }
        private void ReloadTable(String name)
        {
            switch(name)
            {
                case "Пользователи системы":
                    LoadTable("user_system");
                    break;
                case "Слушатели приложения":
                    LoadTable("customer");
                    break;
                case "Страны слушателей":
                    LoadTable("country");
                    break;
                case "Плейлисты приложения":
                    LoadTable("playlist");
                    break;
                case "Песни приложения":
                    LoadTable("song");
                    break;
                case "Жанры приложения":
                    LoadTable("genre");
                    break;
            }
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

            if(reportManager.CreateReportAsync("countriesRating", dataBaseGridView))
                MessageBox.Show("Отчет создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Произошел сбой при создании отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void popularSongsReportButton_Click(object sender, EventArgs e)
        {
            dataBaseGridView.Visible = false;
            dataBaseGridView.DataSource = dbManager.ReportRequest("popularSongs");
            dataBaseGridView.Update();

            if(reportManager.CreateReportAsync("popularSongs", dataBaseGridView))
                 MessageBox.Show("Отчет создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Произошел сбой при создании отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void songsListReportButton_Click(object sender, EventArgs e)
        {
            dataBaseGridView.Visible = false;
            dataBaseGridView.DataSource = dbManager.ReportRequest("songsList");
            dataBaseGridView.Update();

            if(reportManager.CreateReportAsync("songsList", dataBaseGridView))
                MessageBox.Show("Отчет создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Произошел сбой при создании отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataBaseGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Недопустимый формат введённых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
