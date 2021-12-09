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
            // запрос
            string command = "select * from cashiers where login = '"+ logTB.Text + "' and password = '"+ passTB.Text + "'";
            // создание SqlConnection
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // открытие потока 
            sqlConnection.Open();
            // создание SqlCommand
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            // создание SqlDataReader
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            // проверка условий
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
            // закрытие потока
            sqlConnection.Close();
        }

        private void oilButton_Click(object sender, EventArgs e)
        {
            OilForm oilForm = new OilForm();
            oilForm.Owner = this;
            Visible = false;
            oilForm.ShowDialog();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.Owner = this;
            Visible = false;
            infoForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Owner = this;
            Visible = false;
            orderForm.ShowDialog();
        }
    }
}
