using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//import two libraries for Database connection
using System.Data.SqlClient;
using System.Configuration;

namespace IT207N_Week11_DbConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Establish Database Connection
        //Initial Catalog = database name
        //Data Source = server name
        //ADO.NET = technology belongs to .NET framework
        SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-4FD43GN7\\SQLEXPRESS;Initial Catalog=TestConnection;Integrated Security=True");

        //select data from database
        private void btnShow_Click(object sender, EventArgs e)
        {
            //always open the database connection
            sqlCon.Open();

            string commandSelect = "select FirstName, LastName from Detail";
            //SqlCommand has two parameters (CRUD statement, db connection)
            SqlCommand sqlCmd = new SqlCommand(commandSelect, sqlCon);

            //SqlDataReader is to read data from database (select statement)
            SqlDataReader show = sqlCmd.ExecuteReader();//select statement

            while (show.Read())
            {
                //FirstName and LastName = field or column name in database table
                txtFirst.Text = show["FirstName"].ToString();
                txtLast.Text = show["LastName"].ToString();
            }

            sqlCon.Close();
        }

        //insert data into database
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //input validation
            if (txtFirst.Text == "" || txtLast.Text == "")
            {
                MessageBox.Show("All fields are compulsory!");
            }
            else
            {
                sqlCon.Open();

                SqlCommand cmdinsert = new SqlCommand("Insert into Detail (FirstName, LastName) values(@firstname,@lastname)", sqlCon);
                cmdinsert.Parameters.AddWithValue("@firstname", txtFirst.Text);
                cmdinsert.Parameters.AddWithValue("@lastname", txtLast.Text);
                cmdinsert.ExecuteNonQuery();//insert and update statement

                MessageBox.Show("Data inserted successfully.");
            }
            sqlCon.Close();
        }

        //update data in database
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            SqlCommand cmdupdate = new SqlCommand("Update Detail SET FirstName = '"+txtFirst.Text+"'", sqlCon);
            cmdupdate.CommandType = CommandType.Text;//only for update statement
            cmdupdate.ExecuteNonQuery();

            MessageBox.Show("Data updated successfully.");

            sqlCon.Close();
        }

        //display data in GridView format (DataTable)
        private void btnGridView_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            //create data table first
            DataTable dt = new DataTable();
            
            //get the records using data adapter
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Detail", sqlCon);
            
            //use data adapter to fill data table
            adapt.Fill(dt);

            //view the data table records in gridview format
            dataGridView.DataSource = dt;

            sqlCon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testConnectionDataSet.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.testConnectionDataSet.Detail);

        }
    }
}
