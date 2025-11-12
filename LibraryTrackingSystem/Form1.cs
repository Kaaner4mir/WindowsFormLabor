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

namespace LibraryTrackingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection(@"Data Source=Kaaner4mir\SQLEXPRESS;Initial Catalog=BooksDB;Integrated Security=True;Encrypt=False");

        private void Form1_Load(object sender, EventArgs e)
        {
            _connection.Open();
            List();
            dgwBooks.ReadOnly = true;
            _connection.Close();
        }

        void List()
        {
            string command = "select * from Books";
            SqlDataAdapter _adapter = new SqlDataAdapter(command, _connection);
            DataTable table = new DataTable();
            _adapter.Fill(table);
            dgwBooks.DataSource = table;
        }

        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _connection.Open();
            var id = dgwBooks.Rows[e.RowIndex].Cells[0].Value;

            string command = "select * from Books where Id=@id";
            SqlDataAdapter adapter = new SqlDataAdapter(command, _connection);
            adapter.SelectCommand.Parameters.AddWithValue("@id", id);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                txtId.Text = table.Rows[0]["Id"].ToString();
                txtTitle.Text = table.Rows[0]["Title"].ToString();
                txtGenre.Text = table.Rows[0]["Genre"].ToString();
                txtAuthor.Text = table.Rows[0]["Author"].ToString();
                txtLanguage.Text = table.Rows[0]["Language"].ToString();
                txtPublisher.Text = table.Rows[0]["Publisher"].ToString();
                txtPageCount.Text = table.Rows[0]["PageCount"].ToString();
                txtPublicationYear.Text = table.Rows[0]["PublicationYear"].ToString();
            }

            _connection.Close();
        }

        void Clear()
        {
            txtId.Clear();
            txtTitle.Clear();
            txtGenre.Clear();
            txtAuthor.Clear();
            txtLanguage.Clear();
            txtPublisher.Clear();
            txtPageCount.Clear();
            txtPublicationYear.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _connection.Open();

            string commandText = "insert into Books (Title, Genre, Author, Language, Publisher, PageCount, PublicationYear) " +
                                 "values ( @title, @genre, @author, @language, @publisher, @pageCount, @publicationYear)";

            SqlCommand command = new SqlCommand(commandText, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter();

            command.Parameters.AddWithValue("@title", txtTitle.Text);
            command.Parameters.AddWithValue("@genre", txtGenre.Text);
            command.Parameters.AddWithValue("@author", txtAuthor.Text);
            command.Parameters.AddWithValue("@language", txtLanguage.Text);
            command.Parameters.AddWithValue("@publisher", txtPublisher.Text);
            command.Parameters.AddWithValue("@pageCount", txtPageCount.Text);
            command.Parameters.AddWithValue("@publicationYear", txtPublicationYear.Text);

            command.ExecuteNonQuery();

            MessageBox.Show("The book has been successfully added!");

            List();

            _connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _connection.Open();

            string commandText = "update Books set Title=@title, Genre=@genre, Author=@author, Language=@language, " +
                                 "Publisher=@publisher, PageCount=@pageCount, PublicationYear=@publicationYear where Id=@id";

            if (txtId.Text != "")
            {
                SqlCommand command = new SqlCommand(commandText, _connection);
                command.Parameters.AddWithValue("@id", txtId.Text);
                command.Parameters.AddWithValue("@title", txtTitle.Text);
                command.Parameters.AddWithValue("@genre", txtGenre.Text);
                command.Parameters.AddWithValue("@author", txtAuthor.Text);
                command.Parameters.AddWithValue("@language", txtLanguage.Text);
                command.Parameters.AddWithValue("@publisher", txtPublisher.Text);
                command.Parameters.AddWithValue("@pageCount", txtPageCount.Text);
                command.Parameters.AddWithValue("@publicationYear", txtPublicationYear.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("The book has been successfully updated!");

                List();
            }
            else
            {
                MessageBox.Show("Please enter a value!");
            }

            _connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string commandText = "delete from Books where Id=@id";

            _connection.Open();

            if (txtId.Text != "")
            {
                SqlCommand command = new SqlCommand(commandText, _connection);
                command.Parameters.AddWithValue("@id", txtId.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("The book has been successfully deleted!");
                List();
            }
            else
            {
                MessageBox.Show("Please enter a value!");
            }
            _connection.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgwBooks.DataSource is DataTable table)
            {
                DataView dv = table.DefaultView;

                string searchTerm = txtSearch.Text.Replace("'", "''");

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    dv.RowFilter = string.Empty;
                }
                else
                {
                    dv.RowFilter = string.Format(
                        "CONVERT(Id, 'System.String') LIKE '%{0}%' OR " +
                        "Title LIKE '%{0}%' OR " +
                        "Author LIKE '%{0}%' OR " +
                        "Genre LIKE '%{0}%'",
                        searchTerm
                    );
                }
            }
        }
    }
}
