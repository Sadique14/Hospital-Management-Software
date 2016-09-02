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
    public partial class Admin : Form
    {
        Database db;
        public Admin()
        {
            InitializeComponent();
            db = new Database();
        }

        Patient[] p;
        private void Admin_Load(object sender, EventArgs e)
        {
          
            try
            {
                p = db.findPatient();
                for(int i=0; i<p.Length; i++)
                {
                    if(p[i].name != null)
                    {
                        patientSerial.Items.Add(p[i].name);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string user="";
        private void patientSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(patientSerial.Text != null)
            {
                for(int i=0; i<p.Length; i++)
                {
                    if(patientSerial.Text.Equals(p[i].name))
                    {
                        user = p[i].userName;
                        birth.Text = p[i].dateOfBirth;
                        sexLabel.Text = p[i].sex;
                        addressLabel.Text = p[i].address;
                        contactLabel.Text = p[i].contactNo;
                        emailLabel.Text = p[i].email;
                        ageOfDLabel.Text = p[i].ageOfDisease;
                        illnessLabel.Text = p[i].illness;
                        familyLabel.Text = p[i].family;
                        previusLabel.Text = p[i].previous;
                        diseaseLabel.Text = p[i].disease;
                        doctorLabel.Text = p[i].doctor;
                        departmentLabel.Text = p[i].speciality;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Doctor[] d;
        int index = -1;
        private void departmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!departmentBox.Text.Equals("<none>"))
            {
                d = db.findSpecialDoctor(departmentBox.Text);
                for (int i = 0; i < 20; i++)
                {
                    if (d[i].fullName != null)
                    {
                        doctorBox.Items.Add(d[i].fullName);
                    }
                }
            }
            else
                doctorBox.Items.Clear();
        }
        private void doctorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorBox.Text != null)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (doctorBox.Text.Equals(d[i].fullName))
                    {
                        index = i;
                        break;
                    }
                }
            }
        }
        private void assignButton_Click(object sender, EventArgs e)
        {
            if (db.Assignment(patientSerial.Text, messageBox.Text, d[index]))
            {
                MessageBox.Show("Assigned and Message sent");
                //db.deleteAppointment(user);
                //MessageBox.Show(user);
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Start s = new Start();
            s.Show();
        }

       
    }
}
