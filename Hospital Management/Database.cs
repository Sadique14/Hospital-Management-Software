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
using System.Configuration;
using System.IO;

namespace Hospital_Management
{
    class Database
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Database()
        {
            cmd.Connection = cn;
        }
        public Boolean savePatientData(Patient dt)
        { 
            try
            {
                cn.Open();
                cmd.CommandText = "update patientForm set date = '"+dt.date+"',speciality = '"+dt.speciality+"',doctor='"+dt.doctor+"',name='"+dt.name+"',dateOfBirth='"+dt.dateOfBirth+"',sex='"+dt.sex+"',address='"+dt.address+"',contactNo='"+dt.contactNo+"',email='"+dt.email+"',disease='"+dt.disease+"',ageOfDisease='"+dt.ageOfDisease+"',illness='"+dt.illness+"',family='"+dt.family+"',previous='"+dt.previous+"' where userName='"+dt.userName+"' and password='"+dt.password+"'";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
            }
            return false;
        }
        public Boolean saveDoctorData(Doctor d)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "insert into docInfo (userName,password,fullName,speciality,degree,description,pin) values ('" + d.userName + "','" + d.password + "','"+d.fullName+"','"+d.speciality+"','"+d.degree+"','"+d.description+"','"+d.pin+"')";
                cmd.ExecuteNonQuery();
                byte[] img = null;
                FileStream fs = new FileStream(d.image,FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                cmd.CommandText = "update docInfo set picture = '"+img+"' where userName='"+d.userName+"' and password='"+d.password+"'";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
            }
            return false;
        }
        public Doctor[] findSpecialDoctor(String s)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select * from docInfo where speciality = '"+s+"'";
                dr = cmd.ExecuteReader();
                Doctor[] d = new Doctor[20];
                for (int i = 0; i < 20; i++ )
                {
                    d[i] = new Doctor();
                }
                int k=0;
                while (dr.Read())
                {
                    d[k].fullName = dr[2].ToString();
                    d[k].speciality = dr[3].ToString();
                    d[k].degree = dr[4].ToString();
                    d[k].description = dr[5].ToString();
                    k++;
                }
                cn.Close();
                return d;
            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
                return null;
            }
        }
        public Boolean nurseLogIn(string user, string pass, string pin)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select password,PIN from nurse where userName='"+user+"'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    string x = dr[0].ToString();
                    string y = dr[1].ToString();
                    if (pass.Equals(x) && pin.Equals(y))
                    {
                        cn.Close();
                        return true;
                    }
                    else
                    {
                        cn.Close();
                        return false;
                    }
                }
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
                return false;
            }
        }

        public Patient[] findPatient()
        {
            Patient[] dt = new Patient[50];
            for (int i = 0; i < 50; i++ )
            {
                dt[i] = new Patient();
            }
                try
                {
                    cn.Open();
                    cmd.CommandText = "select * from patientForm";
                    dr = cmd.ExecuteReader();
                    Doctor[] d = new Doctor[20];
                    for (int i = 0; i < 20; i++)
                    {
                        d[i] = new Doctor();
                    }
                    int k = 0;
                    while (dr.Read())
                    {
                        dt[k].userName = dr[0].ToString();
                        dt[k].date = dr[2].ToString();
                        dt[k].speciality = dr[3].ToString();
                        dt[k].doctor = dr[4].ToString();
                        dt[k].name = dr[5].ToString();
                        dt[k].dateOfBirth = dr[6].ToString();
                        dt[k].sex = dr[7].ToString();
                        dt[k].address = dr[8].ToString();
                        dt[k].contactNo = dr[9].ToString();
                        dt[k].email = dr[10].ToString();
                        dt[k].disease = dr[11].ToString();
                        dt[k].ageOfDisease = dr[12].ToString();
                        dt[k].illness = dr[13].ToString();
                        dt[k].family = dr[14].ToString();
                        dt[k].previous = dr[15].ToString();
                        k++;
                    }
                    cn.Close();
                    return dt;
                }
                catch (Exception el)
                {
                    MessageBox.Show(el.Message);
                    return null;
                }
        }
        public Boolean Assignment(string patient, string m, Doctor d)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "update patientForm set message = '" + m + "' where name='" + patient + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
            }
            return false;
        }
        public string readMessage(string user)
        {
            try
            {
                string m = "";
                cn.Open();
                cmd.CommandText = "select message from patientForm where userName = '"+user+"'";
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    m = dr[0].ToString();
                }
                cn.Close();
                return m;
            }
            catch
            {
                return "";
            }
        }
        public Boolean deleteAppointment(string user)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "delete date,speciality,doctor,name,dateOfBirth,sex,address,contactNo,email,disease,ageOfDisease,illness,family,previous,message from patientForm where userName = '" + user + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
