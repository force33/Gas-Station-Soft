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
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        public string connectionString = "Server=localhost;Database=GasStation;Trusted_Connection=True";
        private void mainWindow_Load(object sender, EventArgs e)
        {
            oilButton.Visible = false;
            infoButton.Visible = false;
            orderButton.Visible = false;
            exitButton.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string command = "select * from cashiers where login = '"+ logTB.Text + "' and password = '"+ passTB.Text + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                oilButton.Visible = true;
                infoButton.Visible = true;
                orderButton.Visible = true;
                exitButton.Visible = true;
                logTB.Visible = false;
                passTB.Visible = false;
                loginButton.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            sqlConnection.Close();
        }
    }
}
