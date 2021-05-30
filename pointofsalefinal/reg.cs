using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pointofsalefinal
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

      

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String constring = "datasource=localhost;port=3306;username=root;password=;database=posv3;";
            String query = "insert into user(userid,firstname,lastname,middlename,gender,jobtitle,datehired,salary,username,password,email)values('" + userid.Text + "','" + firstname.Text + "','" + lastname.Text + "','" + middlename.Text + "','" + gender.Text + "','" + jobtitle.Text + "','" + datehired.Text + "','" + salary.Text + "','" + username.Text + "','" + password.Text + "','" + email.Text + "')";
            MySqlConnection condatabase = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, condatabase);
            MySqlDataReader reader;

            try
            {
                if (firstname.Text.Equals(""))
                {
                  MessageBox.Show("Firstname is empty!");
                } else if (lastname.Text.Equals("")){
                    MessageBox.Show(" Lastname is empty");
                } else if (middlename.Text.Equals(""))
                {
                  MessageBox.Show("middle name is empty!");

                } else if (gender.Text.Equals("")){ 
                    MessageBox.Show("Gender feild is Empty!");
                } else if (password.Text != rpassword.Text)
                {
                    MessageBox.Show("password doesn't match!");
                }else if (phonenumber.Text.Length > 11)
                {
                    MessageBox.Show("Invalid Number");
                }
                else if (jobtitle.Text.Equals(""))
                {
                    MessageBox.Show("No Job title declared");
                }
                else if (email.Text.Equals(""))
                {
                    MessageBox.Show("email is empty!");
                }
                else if (userid.Text.Equals(""))
                {
                    MessageBox.Show("Your UserId is Empty!");
                }

                else {
                    condatabase.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Save Successfully");
                    condatabase.Close();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void mname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jobtitle.Text.Equals("Crew"))
            {
                salary.Text = "500 a day";
            }
            else if(jobtitle.Text.Equals("Shift Leader"))
            {
                salary.Text = "600 a day";
            }


            }

        private void userid_TextChanged(object sender, EventArgs e)
        {

        }

        private void rpword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int s = r.Next(9999);
            userid.Text = s.ToString();
        }
    }
    }

