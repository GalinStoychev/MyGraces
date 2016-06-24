using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGracesApp
{
    public partial class InitializeTheBeginnig : Form
    {
        public InitializeTheBeginnig()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to exit ?", "Exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void rbtn1Player_CheckedChanged(object sender, EventArgs e)
        {
            txtPlayer1Name2.Enabled = false;
            txtPlayer2Name.Enabled = false;
            txtPlayer1Name.Enabled = true;

            txtPlayer1Name.ForeColor = Color.Black;
        }

        private void rbtn2Players_CheckedChanged(object sender, EventArgs e)
        {

            txtPlayer1Name2.Enabled = true;
            txtPlayer2Name.Enabled = true;
            txtPlayer1Name.Enabled = false;

            txtPlayer1Name2.ForeColor = Color.Black;
            txtPlayer2Name.ForeColor = Color.Black;
        }
    }
}
