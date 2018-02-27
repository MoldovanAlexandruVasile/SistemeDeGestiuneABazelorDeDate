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

namespace SGBD
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = ALEX\\SQLEXPRESS; Initial Catalog = StoreDB; Integrated Security = True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();

        SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
        DataSet dataSet2 = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Populate button
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Store", connection);
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
            ShopView.DataSource = dataSet.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add button
            try
            {
                dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Store(StoreID, StoreName) VALUES(@ID, @Name)", connection);
                dataAdapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Int32.Parse(AddStoreID.Text);
                dataAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = AddStoreName.Text;
                connection.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Info button
            try
            {
                dataAdapter2.SelectCommand = new SqlCommand("SELECT * FROM Car WHERE StoreID = @StoreID", connection);
                dataAdapter2.SelectCommand.Parameters.Add("@StoreID", SqlDbType.Int).Value = Int32.Parse(InfoStoreID.Text);
                dataSet2.Clear();
                dataAdapter2.Fill(dataSet2);
                InfoView.DataSource = dataSet2.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Update button
            try
            {
                dataAdapter.UpdateCommand = new SqlCommand("UPDATE Car SET Price = @Price WHERE CarID = @CarID", connection);
                dataAdapter.UpdateCommand.Parameters.Add("@Price", SqlDbType.Int).Value = Int32.Parse(UpdateNewPrice.Text);
                dataAdapter.UpdateCommand.Parameters.Add("@CarID", SqlDbType.Int).Value = Int32.Parse(UpdateCarID.Text);
                connection.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Delete button
            try
            {
                dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM Car WHERE CarID = @CarID", connection);
                dataAdapter.DeleteCommand.Parameters.Add("@CarID", SqlDbType.Int).Value = Int32.Parse(DeleteCarID.Text);
                connection.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
