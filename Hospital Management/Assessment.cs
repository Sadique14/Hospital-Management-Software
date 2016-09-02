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
    public partial class Assessment : Form
    {
        private String name, password;
        Database db;
        public Assessment(String name, String password)
        {
            InitializeComponent();
            this.name = name;
            this.password = password;
            db = new Database();
        }
        String ill="";
        String history = "";
        String record = "";
        String sex = "";
        private void saveButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Patient dt = new Patient();
            dt.userName = name;
            dt.password = password;
            dt.date = DD.Text+" - "+MM.Text+" - "+Year.Text;
            dt.speciality = speBox.Text;
            dt.doctor = docBox.Text;
            dt.name = first.Text + " " + middle.Text + " " + last.Text;
            dt.dateOfBirth = birth1.Text + "-" + birth2.Text + "-" + birth3.Text;
            dt.sex = sex;
            dt.address = addressBox.Text;
            dt.contactNo = contactBox.Text;
            dt.email = emailBox.Text;
            dt.disease = diseaseBox.Text;
            dt.ageOfDisease = monthBox.Text+"month, "+dayBox.Text+"days";
            dt.illness = ill;
            dt.family = history;
            dt.previous = record;
            if (db.savePatientData(dt))
            {
                infoLabel.ForeColor = Color.Green;
                infoLabel.Text = "Appointment Saved.";
            }
            else
            {
                infoLabel.ForeColor = Color.Red;
                infoLabel.Text = "Please, fill all field correctly.";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient has hypertansion.";
            ill += "Patient had hypertansion.";
            ill += "Patient does not/did not have hypertansion.";
            ill += "Patient has diabetes";
            ill += "Patient had diabetes";
            ill += "Patient does not/did not have diabetes";
            ill += "Patient has cancer.";
            ill += "Patient had cancer.";
            ill += "Patient does not/did not have cancer.";
        }
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            history += "Mother has hypertension; ";
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            history += "Mother has diabetes; ";
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            history += "Father has hypertension; ";
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            history += "Father has diabetes; ";
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            history += "Grandfather has hypertension; ";
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            history += "grandfather has diabetes; ";
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            history += "Grandmother has hypertension; ";
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            history += "grandmother has diabetes; ";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            record += "Patient visited doctor before.";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            record += "Patient did not visit doctor before.";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient has hypertansion.";
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient had hypertansion.";
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient does not/did not have hypertansion.";
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient has diabetes";
           
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient had diabetes";
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient does not/did not have diabetes";
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient has cancer.";
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient had cancer.";
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ill += "Patient does not/did not have cancer.";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sex = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sex = "female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sex = "other";
        }


        Doctor[] d;
        private void speBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            docBox.Items.Clear();
            docBox.Text = null;
            if (!speBox.Text.Equals("<none>"))
            {
                d = db.findSpecialDoctor(speBox.Text);
                for (int i = 0; i < 20; i++)
                {
                    if (d[i].fullName != null)
                    {
                        docBox.Items.Add(d[i].fullName);
                    }
                }
            }
            else
                docBox.Items.Clear();
        }

        private void docBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(docBox.Text != null)
            {
                for(int i=0; i<20; i++)
                {
                    if(docBox.Text.Equals(d[i].fullName))
                    {
                        listBox1.Items.Add("DEPARTMENT:");
                        listBox1.Items.Add(d[i].speciality);
                        listBox1.Items.Add("");
                        listBox1.Items.Add("QUALIFICATION:");
                        listBox1.Items.Add(d[i].degree);
                        listBox1.Items.Add("");
                        listBox1.Items.Add("ABOUT DOCTOR:");
                        listBox1.Items.Add(d[i].description);
                    }
                }
            }
        }
    }
}
