using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerApplication
{
    public partial class Form1 : Form
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=Kaaner4mir\SQLEXPRESS;Initial Catalog=CustomersDB;Integrated Security=True;Encrypt=False");


        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _connection.Open();

            List();

            _connection.Close();
        }

        string date;
        string time;
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateAndTime();
        }

        void UpdateDateAndTime()
        {
            lblDate.Text = (date = DateTime.Now.ToString("dd.MM.yyyy"));
            lblTime.Text = (time = DateTime.Now.ToString("HH:mm:ss"));
        }

        void List()
        {
            string command = "select * from Customers";

            SqlDataAdapter _adapter = new SqlDataAdapter(command, _connection);
            DataTable table = new DataTable();
            _adapter.Fill(table);

            dgwCustomers.DataSource = table;
        }

        private void dgwCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _connection.Open();

            var id = dgwCustomers.Rows[e.RowIndex].Cells[0].Value;

            string command = "select * from Customers where Id=@id";
            SqlDataAdapter adapter = new SqlDataAdapter(command, _connection);
            adapter.SelectCommand.Parameters.AddWithValue("@id", id);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                txtId.Text = table.Rows[0]["Id"].ToString();
                txtTckn.Text = table.Rows[0]["Tckn"].ToString();
                txtFirstName.Text = table.Rows[0]["FirstName"].ToString();
                txtLastName.Text = table.Rows[0]["LastName"].ToString();
                txtCity.Text = table.Rows[0]["City"].ToString();
                txtOccupation.Text = table.Rows[0]["Occupation"].ToString();
            }

            if (table.Rows[0]["MaritalStatus"].ToString() == "True")
            {
                rbMarried.Checked = true;
            }
            else
            {
                rbSingle.Checked = true;
            }
            _connection.Close();
        }

        void Clear()
        {
            txtId.Clear();
            txtTckn.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            rbMarried.Checked = false;
            rbSingle.Checked = false;
            txtOccupation.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tckn = txtTckn.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string city = txtCity.Text;
            bool maritalStatus = rbMarried.Checked;
            string occupation = txtOccupation.Text;

            _connection.Open();

            string commandText = "insert into Customers (Tckn, FirstName, LastName, City, MaritalStatus, Occupation) " +
                                 "values ( @tckn, @firstName, @lastName, @city, @maritalStatus, @occupation)";

            SqlCommand command = new SqlCommand(commandText, _connection);

            command.Parameters.AddWithValue("@tckn", tckn);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@maritalStatus", maritalStatus);
            command.Parameters.AddWithValue("@occupation", occupation);

            command.ExecuteNonQuery();

            List();

            MessageBox.Show("Customer Added Successfully!");

            _connection.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string commandText = "delete from Customers where Id=@id";

            if (txtId.Text != "")
            {
                _connection.Open();

                SqlCommand command = new SqlCommand(commandText, _connection);
                command.Parameters.AddWithValue("@id", txtId.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Customer Deleted Successfully!");

                List();
                Clear();

                _connection.Close();
            }
            else
            {
                MessageBox.Show("Please select a customer!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string commandText = "update Customers set Tckn=@tckn, FirstName=@firstName, LastName=@lastName, " +
                                 "City=@city, MaritalStatus=@maritalStatus, Occupation=@occupation where Id=@id";

            if (txtId.Text != "")
            {
                _connection.Open();

                SqlCommand command = new SqlCommand(commandText, _connection);
                command.Parameters.AddWithValue("@tckn", txtTckn.Text);
                command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@lastName", txtLastName.Text);
                command.Parameters.AddWithValue("@city", txtCity.Text);
                command.Parameters.AddWithValue("@maritalStatus", rbMarried.Checked);
                command.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                command.Parameters.AddWithValue("@id", txtId.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Customer Updated Successfully!");

                List();
                Clear();

                _connection.Close();
            }
            else
            {
                MessageBox.Show("Please select a value!");
            }
        }
    }
}
