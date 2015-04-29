using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;

namespace facebook
{
    public partial class Form1 : Form
    {
        string connectionstring;
        public Form1()
        {
            InitializeComponent();
             connectionstring = "Fbcon";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dbhandler mydb = new Dbhandler();
            dataGridView1.DataSource = mydb.GetAllUsers().Tables[0];
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO  signups (firstname, lastname,email,gender, pasword) Values(@a,@b,@c,@d,@e)");
            cmd.Parameters.Add("@a", textBox1.Text);
            cmd.Parameters.Add("@b", textBox2.Text);
            cmd.Parameters.Add("@c", textBox3.Text);
            cmd.Parameters.Add("@d", textBox4.Text);
            cmd.Parameters.Add("@e", textBox5.Text);
            Database fbdb = DatabaseFactory.CreateDatabase(connectionstring);
            fbdb.ExecuteNonQuery(cmd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Database fbdb = DatabaseFactory.CreateDatabase(connectionstring);
            dataGridView1.DataSource = fbdb.ExecuteNonQuery("sp_Login", new Object[] { textBox6.Text, textBox7.Text });

            if (dataGridView1.RowCount>=0)
            {
                MessageBox.Show("login");
            }
            else
            {
                MessageBox.Show("not login");
            }
        }
    }
}
