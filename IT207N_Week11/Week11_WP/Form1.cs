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

namespace Week11_WP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-F8D7AI8;Initial Catalog=TextConnection;Integrated Security=True");

        private void btnShow_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string commandSelect = "select FirstName,LastName from SampleData";
            SqlCommand sqlCmd = new SqlCommand(commandSelect,sqlCon);

            SqlDataReader show = sqlCmd.ExecuteReader();

            while (show.Read())
            {
                txtFirst.Text = show["FirstName"].ToString();
                txtLast.Text = show["LastName"].ToString();
            }

            sqlCon.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text=="" || txtLast.Text=="")
            {
                MessageBox.Show("All fields are compulsary!");
            }
            else
            {
                sqlCon.Open();

                SqlCommand cmdinsert = new SqlCommand("Insert into SampleData(FirstName,LastName)values(@firstname,@lastname)",sqlCon);
                cmdinsert.Parameters.AddWithValue("@firstname",txtFirst.Text);
                cmdinsert.Parameters.AddWithValue("@lastname", txtLast.Text);
                cmdinsert.ExecuteNonQuery();

                MessageBox.Show("Data inserted successfully.");
            }
            sqlCon.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            SqlCommand cmdupdate = new SqlCommand("Update SampleData SET FirstName='"+txtFirst.Text+"'",sqlCon);
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.ExecuteNonQuery();

            MessageBox.Show("Data updated successfully.");

            sqlCon.Close();
        }

        private void btnGridView_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from SampleData",sqlCon);
            adapt.Fill(dt);
            dataGridView.DataSource = dt;

            sqlCon.Close();
        }
    }
}
