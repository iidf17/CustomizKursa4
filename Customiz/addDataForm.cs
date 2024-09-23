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

namespace Customiz
{
    public partial class addDataForm : Form
    {
        public addDataForm()
        {
            InitializeComponent();
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            string wTypeText = workTypeTextBox.Text,
                descText = DescTextBox.Text,
                timePlanText = timePlanTextBox.Text,
                datesText = dateTimePicker1.Value.ToString(),
                statusText = statusesComboBox.Text;
            if (!string.IsNullOrEmpty(wTypeText) && !string.IsNullOrEmpty(timePlanText) && !string.IsNullOrEmpty(datesText) && !string.IsNullOrEmpty(statusText))
            {
                GlobalVariables.addingQuery = "INSERT INTO " + GlobalVariables.tab + " VALUES('" + wTypeText + "', '" + descText + "', '" + timePlanText + "', CONVERT (date, '" + datesText + "'), '" + statusText + "');";
                Console.WriteLine(GlobalVariables.addingQuery);
                try
                {
                    var conn = new SqlConnection(Properties.Settings.Default.Studying_planssConnectionString);
                    var command = new SqlCommand
                    {
                        Connection = conn,
                        CommandText = GlobalVariables.addingQuery
                    };
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    this.Close();
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Неверно введены данные!\nПопробуйте еще раз.");
            }
        }
    }
}
