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

namespace Gas_Station_Soft
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            // запросы
            string command2 = "select total_oil92 from total_oil";
            string command3 = "select total_oil95 from total_oil";
            string command4 = "select total_oilDT from total_oil";
            string command = "select * from Info";
            // создание SqlConnection
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // открытие потока
            sqlConnection.Open();
            // создание SqlDataAdapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, connectionString);
            // создание SqlCommand
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            // создание SqlCommand2
            SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConnection);
            // создание SqlDataReader
            SqlDataReader reader = sqlCommand2.ExecuteReader();
            // открытие потока Read
            reader.Read();
            string oil92 = reader.GetString(0);
            label92.Text = "92: " + oil92 + " литров";
            // закрытие потока Read
            reader.Close();

            SqlCommand sqlCommand3 = new SqlCommand(command3, sqlConnection);
            SqlDataReader reader1 = sqlCommand3.ExecuteReader();
            reader1.Read();
            string oil95 = reader1.GetString(0);
            label95.Text = "95: " + oil95 + " литров";
            reader1.Close();

            SqlCommand sqlCommand4 = new SqlCommand(command4, sqlConnection);
            SqlDataReader reader2 = sqlCommand4.ExecuteReader();
            reader2.Read();
            string oilDT = reader2.GetString(0);
            labelDT.Text = "ДТ: " + oilDT + " литров";
            reader2.Close();

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            // вывод данных в таблицу
            dataGridView1.DataSource = dataSet.Tables[0];
            // закрытие потока
            sqlConnection.Close();

        }

        public string connectionString = "Server=localhost;Database=GasStation;Trusted_Connection=True";

        private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Visible = true;
        }
    }
}
