using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using Newtonsoft.Json;
using System.IO;

namespace Leaderboard_JSON_Generator
{
    public partial class Generator : Form
    {
        List<LeaderboardModel> Leaderboard = new List<LeaderboardModel>();

        public Generator()
        {
            InitializeComponent();
        }

        private void GenerateJSON(string ExcelPath)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(ExcelPath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets["Leaderboard"];

                int j = 2;

                while (xlWorkSheet.Cells[j, 1].Text.ToString() != "")
                {
                    j++;
                }


                for (int i = 0; i < (j - 2); i++)
                {
                    int Index = Int32.Parse(xlWorkSheet.Cells[(i + 2), 130].Text.ToString());
                    string Name = xlWorkSheet.Cells[(i + 2), 4].Text.ToString();
                    string Class = xlWorkSheet.Cells[(i + 2), 3].Text.ToString();
                    string Tasks = xlWorkSheet.Cells[(i + 2), 125].Text.ToString();
                    string Points = xlWorkSheet.Cells[(i + 2), 129].Text.ToString();
                    LeaderboardModel lb = new LeaderboardModel(Index, Name, Class, Tasks, Points);
                    Leaderboard.Add(lb);
                }

                string path = "";

                if (jsonSaveLocation.ShowDialog() == DialogResult.OK)
                {
                    if (jsonSaveLocation.SelectedPath.Length == 3)
                    {
                        path = jsonSaveLocation.SelectedPath + "Leaderboard.json";
                    }
                    else
                    {
                        path = jsonSaveLocation.SelectedPath + @"\Leaderboard.json";
                    }                    
                }

                string JSONresult = JsonConvert.SerializeObject(Leaderboard);

                if (File.Exists(path))
                {
                    File.Delete(path);
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(JSONresult.ToString());
                        tw.Close();
                        MsgBox MsgSuccess = new MsgBox();
                        MsgSuccess.FilePath = path;
                        MsgSuccess.errorLabel1.Visible = false;
                        MsgSuccess.errorLabel2.Visible = false;
                        MsgSuccess.okErrorButton.Visible = false;
                        MsgSuccess.AcceptButton = MsgSuccess.okButton;
                        MsgSuccess.okButton.TabIndex = 0;
                        MsgSuccess.outputButton.TabIndex = 1;
                        MsgSuccess.closeButton.TabIndex = 2;
                        MsgSuccess.ShowDialog();
                    }
                }
                else if (!File.Exists(path))
                {
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(JSONresult.ToString());
                        tw.Close();
                        MsgBox MsgSuccess = new MsgBox();
                        MsgSuccess.FilePath = path;
                        MsgSuccess.errorLabel1.Visible = false;
                        MsgSuccess.errorLabel2.Visible = false;
                        MsgSuccess.okErrorButton.Visible = false;
                        MsgSuccess.AcceptButton = MsgSuccess.okButton;
                        MsgSuccess.okButton.TabIndex = 0;
                        MsgSuccess.outputButton.TabIndex = 1;
                        MsgSuccess.closeButton.TabIndex = 2;
                        MsgSuccess.ShowDialog();
                    }
                }
            }
            catch(Exception e)
            {
                MsgBox MsgError = new MsgBox();
                MsgError.successLabel.Visible = false;
                MsgError.okButton.Visible = false;
                MsgError.outputButton.Visible = false;
                MsgError.AcceptButton = MsgError.okErrorButton;
                MsgError.okErrorButton.TabIndex = 0;
                MsgError.closeButton.TabIndex = 1;
                MsgError.ShowDialog();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string excelPath = pathTextbox.Text;

            if (pathTextbox.Text == "")
            {
                if (browseDialog.ShowDialog() == DialogResult.OK)
                {
                    pathTextbox.Text = browseDialog.FileName;
                    excelPath = pathTextbox.Text;
                    GenerateJSON(excelPath);
                }
            }
            else
            {
                GenerateJSON(excelPath);
            }
            
        }
        private void browseButton_Click_1(object sender, EventArgs e)
        {
            if (browseDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextbox.Text = browseDialog.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
