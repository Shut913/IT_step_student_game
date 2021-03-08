using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bojko_Tarasenko_exam
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\Save\saved.bin"))
                btnContinue.Enabled=true;

            btnStart.Text = "";
            btnStart.Image = Image.FromFile("..\\..\\Images\\btnPlay.png");
            btnContinue.Text = "";
            btnContinue.Image = Image.FromFile("..\\..\\Images\\btnContinue.png");
            btnExit.Text = "";
            btnExit.Image = Image.FromFile("..\\..\\Images\\btnExit.png");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm mainform = new MainForm();
            mainform.ShowDialog();

            this.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm mainform = new MainForm(true);
            mainform.ShowDialog();

            this.Visible = true;
        }


    }
}
