using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Leaderboard_JSON_Generator
{
    public partial class MsgBox : Form
    {
        public string FilePath;
        public MsgBox()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string arg = "/select, \"" + FilePath + "\"";
            Process.Start("explorer.exe", arg);
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MsgBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void MsgBox_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okErrorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
