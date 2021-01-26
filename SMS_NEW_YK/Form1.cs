using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace SMS_NEW_YK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings conns = 
                ConfigurationManager.ConnectionStrings["SMSYK-Connection"];

            // Connection string ====> Server Name and database Name
            string strconn = conns.ConnectionString;
            
            conn = new SqlConnection(strconn);
            conn.Open();

            SqlCommand comm = new SqlCommand("Select * from Department", conn);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);
            comDepartment.DataSource = data1;
            comDepartment.DisplayMember = "DepartmentName";
            comDepartment.ValueMember = "DepartmentId";
            comDepartment.SelectedItem = null;
            comDepartment.SelectedText = "--Select Department";

        }

        private void btnallStudent_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Student", conn);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            grdvStudent.DataSource = data1;
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Faculty", conn);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            grdvStudent.DataSource = data1;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Department", conn);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            grdvStudent.DataSource = data1;
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Course", conn);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            grdvStudent.DataSource = data1;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Grade", conn);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            grdvStudent.DataSource = data1;
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Student where FName = @FName or LName = @LName", conn);
            
            // parameters 
            comm.Parameters.AddWithValue("@FName", txtName.Text);
            comm.Parameters.AddWithValue("@LName", txtName.Text);

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            grdvStudent.DataSource = data1;
        }

        private void comDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnByDepartment_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Student where DepartmentId = @DepartmentId ", conn);

            // parameters 
            comm.Parameters.AddWithValue("@DepartmentId", comDepartment.SelectedValue);
            

            // place to store incoming Data from source
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable data1 = new DataTable();
            data.Fill(data1);

            // Name off gridView
            grdvStudent.DataSource = data1;
        }
    }
}
