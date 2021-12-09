using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gas_Station_Soft
{
    public partial class OilForm : Form
    {
        public OilForm()
        {
            InitializeComponent();
            comboBox.Text = comboBox.Items[0].ToString();
            literTB.MaxLength = 5;
            summTB.MaxLength = 5;
        }

        public string connectionString = "Server=localhost;Database=GasStation;Trusted_Connection=True";

        private void OilForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Visible = true;
        }


        public void startButton1_Click(object sender, EventArgs e)
        {
            if (literTB.Text == "" && summTB.Text == "") //условие при незаполненных полях 
            {
                MessageBox.Show("Заполните все поля");
            }
            string oil_type = "gl";
            // сбор данных
            int index = Convert.ToInt32(comboBox.SelectedIndex + 1);
            int oilIndex;

            double amount_litres = Convert.ToDouble(literTB.Text);
            double summ = Convert.ToDouble(summTB.Text);

            if (rB1.Checked) { oilIndex = 0; oil_type = "total_oil92"; }
            else if (rB2.Checked) { oilIndex = 1; oil_type = "total_oil95"; }
            else if (rB3.Checked) { oilIndex = 2; oil_type = "total_oilDT"; }
            else {oilIndex = -1;}
            // запросы
            string command2 = "select "+oil_type+" from total_oil";
            string command = "insert into Info (number_fd, oil_type, summ, oil_amount) values ('" + index + "', '" + oilIndex + "', '" + summ + "', '" + amount_litres + "')";
            // создание SqlConnection
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            // создание SqlCommand
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            // создание SqlCommand2
            SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConnection);
            SqlDataReader reader = sqlCommand2.ExecuteReader();
            // открытие потока Read
            reader.Read();

            double total = Convert.ToDouble(reader[0]);
            string total_oilAfter = Convert.ToString(total - amount_litres);
            // закрытие потока Read
            reader.Close();

            string command3 = "update total_oil set "+oil_type+"='"+total_oilAfter+"'";
            // создание SqlCommand3
            SqlCommand sqlCommand3 = new SqlCommand(command3, sqlConnection);
            sqlCommand3.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void literTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void summTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void literTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //возможность ввода чисел
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            
        }

        private void costTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //возможность ввода чисел
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            
        }

        private void rB1_Click(object sender, EventArgs e)
        {
            // сбор данных
            int oilIndex = rB1.Checked ? 1 : rB2.Checked ? 2 : rB3.Checked ? 3 : -1;
            // запрос
            string command = "select cost from oil where id = '" + oilIndex + "'";
            // создание SqlConnection
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // открытие потока 
            sqlConnection.Open();
            // создание SqlCommand
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            double a = Convert.ToDouble(sqlCommand.ExecuteScalar().ToString());
            costTB.Text = a.ToString();
            // закрытие потока
            sqlConnection.Close();
            
        }

        private void rB2_Click(object sender, EventArgs e)
        {
            int oilIndex = rB1.Checked ? 1 : rB2.Checked ? 2 : rB3.Checked ? 3 : -1;
            string command = "select cost from oil where id = '" + oilIndex + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            double a = Convert.ToDouble(sqlCommand.ExecuteScalar().ToString());
            costTB.Text = a.ToString();
            sqlConnection.Close();
            
        }

        private void rB3_Click(object sender, EventArgs e)
        {
            int oilIndex = rB1.Checked ? 1 : rB2.Checked ? 2 : rB3.Checked ? 3 : -1;
            string command = "select cost from oil where id = '" + oilIndex + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            double a = Convert.ToDouble(sqlCommand.ExecuteScalar().ToString());
            costTB.Text = a.ToString();
            sqlConnection.Close();
        }

        private void costTB_TextChanged_1(object sender, EventArgs e)
        {
            if (costTB.Text != "" && literTB.Text != "")
            {
                double temp = Convert.ToDouble(costTB.Text);
                double total = temp * Convert.ToDouble(literTB.Text);
                summTB.Text = total.ToString();
            }
            
        }

        private void summTB_KeyUp(object sender, KeyEventArgs e)
        {

            
            if (summTB.Text != "")
            {
                literTB.Text = MathLiter(costTB.Text, summTB.Text);
            
            }
        }

        private void literTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (literTB.Text != "")
            {
                summTB.Text = MathSumm(costTB.Text, literTB.Text);
                
            }
        }

        public static string MathLiter(string cost, string summ)
        {
            double temp = Convert.ToDouble(cost);
            double total = Math.Round(Convert.ToDouble(summ) / temp, 2);
            return total.ToString(); 
        }

        public static string MathSumm(string cost, string liter)
        {
            double temp = Convert.ToDouble(cost);
            double total = Math.Round(temp * Convert.ToDouble(liter), 2);
            return total.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
