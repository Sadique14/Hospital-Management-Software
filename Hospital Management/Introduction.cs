using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Introduction : Form
    {
        String name, password;
        int x, y;
        Database db;
        public Introduction(String name, String password)
        {
            InitializeComponent();
            this.name = name;
            this.password = password;
            db = new Database();
            x = 122;
            y = 6;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = "Aisa Des Hai Mera - Full song - Veer-Zaara.mp4";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            //C:\MyProjects\Music\MusicApp\bin\Debug\Data\ich_will.mp3

            //axWindowsMediaPlayer1.URL = path;
            //axWindowsMediaPlayer1.Ctlcontrols.play();
            userName.Text = "Welcome " + name;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void appointButton_Click(object sender, EventArgs e)
        {
            Assessment f2 = new Assessment(name, password);
            f2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Start s = new Start();
            s.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x - 3;
            userName.Location = new Point(x,y);
            if (x < -30)
                x = 415;
        }
        //string m = "";
        private void renponseButton_Click(object sender, EventArgs e)
        {
           // m = db.readMessage(name);
            MessageBox.Show(db.readMessage(name));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AmbulaneService asa =new AmbulaneService();
            asa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutUS au = new AboutUS();
            au.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Feedback fd = new Feedback();
            fd.ShowDialog();
        }
    }
}
