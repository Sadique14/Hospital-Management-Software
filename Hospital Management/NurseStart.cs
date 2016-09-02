using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class NurseStart : Form
    {
        public NurseStart()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        Database db = new Database();
        private void enterButton_Click(object sender, EventArgs e)
        {
            if(db.nurseLogIn(idBox.Text,passBox.Text,pinBox.Text))
            {
                Admin a = new Admin();
                this.Close();
                a.Show();
                Start s = new Start();
                s.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
