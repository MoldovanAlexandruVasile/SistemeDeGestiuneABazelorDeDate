﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SGBD
{
    public partial class Form1 : Form
    {
        private static SqlDataAdapter da = new SqlDataAdapter();
        private static DataSet ds = new DataSet();

        private static SqlDataAdapter da1 = new SqlDataAdapter();
        private static DataSet ds1 = new DataSet();

        private static string con = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private static SqlConnection cs = new SqlConnection(con);

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            //Connect button
            cs.Open();
            string selectC = ConfigurationManager.AppSettings["Select"];
            da.SelectCommand = new SqlCommand(selectC, cs);
            da.Fill(ds);
            MyView.DataSource = ds.Tables[0];

            string selectS = ConfigurationManager.AppSettings["SelectStore"];
            da1.SelectCommand = new SqlCommand(selectS, cs);
            da1.Fill(ds1);
            StoreView.DataSource = ds1.Tables[0];
            cs.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Add button
            try
            {  
                List<string> ColumnNamesList = new List<string>(ConfigurationManager.AppSettings["ChildColumnNames"].Split(','));
                SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["InsertQuery"], cs);
                foreach (string column in ColumnNamesList)
                {
                    TextBox textBox = (TextBox)MyPanel.Controls[column];
                    cmd.Parameters.AddWithValue("@" + column, textBox.Text);
                }
                cs.Open();
                cmd.ExecuteNonQuery();
                ds.Clear();
                da.Fill(ds);
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Update button
            try
            {
                List<string> ColumnNamesList = new List<string>(ConfigurationManager.AppSettings["ChildColumnNames"].Split(','));
                SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["UpdateQuery"], cs);
                foreach (string column in ColumnNamesList)
                {
                    TextBox textBox = (TextBox)MyPanel.Controls[column];
                    cmd.Parameters.AddWithValue("@" + column, textBox.Text);
                }
                cs.Open();
                cmd.ExecuteNonQuery();
                ds.Clear();
                da.Fill(ds);
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Delete button
            try
            {
                List<string> ColumnNamesList = new List<string>(ConfigurationManager.AppSettings["ChildColumnNames"].Split(','));
                SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["DeleteQuery"], cs);
                TextBox textBox = (TextBox)MyPanel.Controls["EmployeeID"];
                cmd.Parameters.AddWithValue("@EmployeeID", textBox.Text);
                cs.Open();
                cmd.ExecuteNonQuery();
                ds.Clear();
                da.Fill(ds);
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //GenerateButton
            try
            {
                int ChildNumberOfColumns = int.Parse(ConfigurationManager.AppSettings["ChildNumberOfColumns"]);
                string ChildColumnNames = ConfigurationManager.AppSettings["ChildColumnNames"];
                List<string> ColumnNamesList = new List<string>(ConfigurationManager.AppSettings["ChildColumnNames"].Split(','));
                int pointX = 80;
                int pointY = 40;
                MyPanel.Controls.Clear();
                for (int i = 0; i < ChildNumberOfColumns; i++)
                {
                    TextBox a = new TextBox();
                    a.Width = 200;
                    a.Name = ColumnNamesList[i].ToString();
                    a.Text = ColumnNamesList[i].ToString();
                    a.Location = new Point(pointX, pointY);
                    MyPanel.Controls.Add(a);
                    MyPanel.Show();
                    pointY += 45;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {

            //Info button
            try
            {
                int index = StoreView.CurrentCell.RowIndex;
                DataGridViewRow row = StoreView.Rows[index];
                string StoreID = row.Cells["StoreID"].Value.ToString();
                string selectC = ConfigurationManager.AppSettings["SelectByID"];
                da.SelectCommand = new SqlCommand(selectC, cs);
                da.SelectCommand.Parameters.Add("@StoreID", SqlDbType.Int).Value = Int32.Parse(StoreID);
                ds.Clear();
                da.Fill(ds);
                MyView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }
    }
}