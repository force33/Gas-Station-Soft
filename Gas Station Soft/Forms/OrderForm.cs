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
    public partial class OrderForm : Form
    {
        static Random rand = new Random();
        // вычисления переменных
        double randСost1 = Math.Round(42 + (rand.NextDouble() * 1.5), 2);
        double randCost2 = Math.Round(45 + (rand.NextDouble() * 1.5), 2);
        double randCost3 = Math.Round(49 + (rand.NextDouble() * 1.5), 2);
        int timer_temp = 10;

        public string connectionString = "Server=localhost;Database=GasStation;Trusted_Connection=True";
        
        public OrderForm()
        {
            InitializeComponent();
            // вывод переменных на форму
            randCostLabel.Text = "Цена/литр (92): " + randСost1.ToString();
            randCostLabel2.Text = "Цена/литр (95): " + randCost2.ToString();
            randCostLabel3.Text = "Цена/литр: (ДТ): " + randCost3.ToString();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void oilAmountTB1_TextChanged(object sender, EventArgs e)
        {
            summCost1.Text = Convert.ToString("Сумма: " + randСost1 * Convert.ToDouble(oilAmountTB1.Text)); 
        }

        private void oilAmountTB2_TextChanged(object sender, EventArgs e)
        {
            summCost2.Text = Convert.ToString("Сумма: " + randCost2 * Convert.ToDouble(oilAmountTB2.Text));
        }

        private void oilAmountTB3_TextChanged(object sender, EventArgs e)
        {
            summCost3.Text = Convert.ToString("Сумма: " + randCost3 * Convert.ToDouble(oilAmountTB3.Text));
        }

        private void orderStartButton_Click(object sender, EventArgs e)
        {
            //вывод диалогового окна
            DialogResult result = MessageBox.Show( "Продолжить?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                timer1.Interval = 1000;
                timer1.Start();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_temp--;

            if (oilAmountTB1.Text != "" && timer_temp < 1)
            {
                // создание SqlConnection
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string command1 = "select total_oil92 from total_oil";
                // создание SqlCommand1
                SqlCommand sqlCommand1 = new SqlCommand(command1, sqlConnection);
                // создание SqlDataReader
                SqlDataReader reader = sqlCommand1.ExecuteReader();
                // открытие потока Read
                reader.Read();
                string oil92 = reader.GetString(0);
                double total = Convert.ToDouble(reader[0]);
                string total_oilAfter = Convert.ToString(total + Convert.ToDouble(oilAmountTB1.Text));
                // закрытие потока Read
                reader.Close();

                string command2 = "update total_oil set total_oil92 ='" + total_oilAfter + "'";
                SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConnection);
                sqlCommand2.ExecuteNonQuery();
                sqlConnection.Close();
            }
            if (oilAmountTB2.Text != "" && timer_temp < 1)
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string command1 = "select total_oil95 from total_oil";
                SqlCommand sqlCommand1 = new SqlCommand(command1, sqlConnection);
                SqlDataReader reader = sqlCommand1.ExecuteReader();

                reader.Read();
                string oil92 = reader.GetString(0);
                double total = Convert.ToDouble(reader[0]);
                string total_oilAfter = Convert.ToString(total + Convert.ToDouble(oilAmountTB2.Text));
                reader.Close();

                string command2 = "update total_oil set total_oil95 ='" + total_oilAfter + "'";
                SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConnection);
                sqlCommand2.ExecuteNonQuery();
                sqlConnection.Close();
            }
            if (oilAmountTB3.Text != "" && timer_temp < 1)
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string command1 = "select total_oilDT from total_oil";
                SqlCommand sqlCommand1 = new SqlCommand(command1, sqlConnection);
                SqlDataReader reader = sqlCommand1.ExecuteReader();

                reader.Read();
                string oil92 = reader.GetString(0);
                double total = Convert.ToDouble(reader[0]);
                string total_oilAfter = Convert.ToString(total + Convert.ToDouble(oilAmountTB3.Text));
                reader.Close();

                string command2 = "update total_oil set total_oilDT ='" + total_oilAfter + "'";
                SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConnection);
                sqlCommand2.ExecuteNonQuery();
                sqlConnection.Close();
            }
            if (timer_temp < 1)
            {
                timer1.Stop();
            }
        }

        private void oilAmountTB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void oilAmountTB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void oilAmountTB3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
