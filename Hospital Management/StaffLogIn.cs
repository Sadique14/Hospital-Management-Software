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
    public partial class StaffLogIn : Form
    {
        public StaffLogIn()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox1.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Doctor d;
            try
            {
                d = new Doctor();
                d.userName = nameBox.Text;
                d.fullName = fullNameBox.Text;
                d.password = passBox.Text;
                d.pin = pinBox.Text;
                d.degree = degreeBox.Text;
                d.description = descriptionBox.Text;
                d.speciality = specialityBox.Text;
                d.image = imgBox.Text;
                if(db.saveDoctorData(d))
                {
                    MessageBox.Show("Your information is saved","Success",MessageBoxButtons.OK,MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("you must fill all fields correctly", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void StaffLogIn_Load(object sender, EventArgs e)
        {
            groupBox1.Parent = this;
            groupBox2.Location = groupBox1.Location;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.Filter = "JPG Files (*.jpg)|*.jpg|Gif Files (*.gif)|*.gif|All Files (*.*)|*.*";
                od.Title = "Select Profile Picture";
                if (od.ShowDialog() == DialogResult.OK)
                {
                    String img = od.FileName.ToString();
                    imgBox.Text = img;
                    pictureBox.ImageLocation = img;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
