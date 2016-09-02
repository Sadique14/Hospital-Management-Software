using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class Start : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Visual Studio Projects\Hospital Management\Hospital Management\hospital.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        //Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\2nd year, 2nd term\Visual Studio Projects\Hospital Management\Hospital Management\hospital.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        int x, y;
        public Start()
        {
            InitializeComponent();
            x = 168;
            y = 33;
        }
        private void Start_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userBox.Text != "" && passwordBox.Text != "")
                {
                    cn.Open();
                    cmd.CommandText = "insert into patientForm (userName,password) values ('"+userBox.Text+"','"+passwordBox.Text+"')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    MessageBox.Show("Account Created Successfully, now you can log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("You must fill");
                }
            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from patientForm";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (textBox1.Text.Equals(dr["userName"].ToString()) && textBox2.Text.Equals(dr["password"].ToString()))
                    {
                        Introduction intro = new Introduction(dr["userName"].ToString(), dr["password"].ToString());
                        this.Hide();
                        intro.Show();
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                {
                    MessageBox.Show("Wrong Password", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffLogIn sfi = new StaffLogIn();
            sfi.ShowDialog();
        }

        private void nurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NurseStart ns = new NurseStart();
            ns.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x - 5;
            label3.Location = new Point(x, y);
            if (x < -70)
                x = 690;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
