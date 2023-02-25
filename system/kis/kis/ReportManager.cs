using System;
using System.Data;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;

namespace kis
{
    public class ReportManager
    {
        public ReportManager() { }

        public bool CreateReportAsync(String reportName, DataGridView table)
        {
            if (table.Rows.Count != 0)
            {
                int RowCount = table.Rows.Count;
                int ColumnCount = table.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                        DataArray[r, c] = table.Rows[r].Cells[c].Value;
                }

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = false;

                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                            oTemp = oTemp + DataArray[r, c] + "\t";
                }

                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();

                for (int c = 0; c <= ColumnCount - 1; c++)
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = table.Columns[c].HeaderText + "\n";

                String reportPath;
                switch (reportName)
                {
                    case "genresRating":
                        reportPath = "C:/Users/USER/Desktop/отчет Рейтинг популярности музыкальных жанров среди слушателей.docx";
                        break;
                    case "playlistsRating":
                        reportPath = "C:/Users/USER/Desktop/отчет Рейтинг плейлистов среди слушателей.docx";
                        break;
                    case "countriesRating":
                        reportPath = "C:/Users/USER/Desktop/отчет Рейтинг стран по наибольшему числу слушателей.docx";
                        break;
                    case "popularSongs":
                        reportPath = "C:/Users/USER/Desktop/отчет Самые популярные композиции в каждом жанре.docx";
                        break;
                    case "songsList":
                        reportPath = "C:/Users/USER/Desktop/отчет Список песен каждого музыкального жанра.docx";
                        break;
                    default:
                        reportPath = "C:/Users/USER/Desktop/отчет.docx";
                        break;
                }
                oDoc.SaveAs2(reportPath);
                oDoc.Close();

                return true;
            }

            return false;
        }
    }
}
