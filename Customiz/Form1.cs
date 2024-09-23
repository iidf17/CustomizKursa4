using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customiz
{
    

    public partial class Form1 : Form
    {
        string[] grids = { "Main", "UMR", "OMR", "NIR" };
        DataGridView[] gridContainer;
        public Form1()
        {
            InitializeComponent();
            gridContainer = new DataGridView[] { mainGridView, umrGridView, omrGridView, nirGridView };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studying_planssDataSet.NIR". При необходимости она может быть перемещена или удалена.
            this.nIRTableAdapter.Fill(this.studying_planssDataSet.NIR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studying_planssDataSet.OMR". При необходимости она может быть перемещена или удалена.
            this.oMRTableAdapter.Fill(this.studying_planssDataSet.OMR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studying_planssDataSet.UMR". При необходимости она может быть перемещена или удалена.
            this.uMRTableAdapter.Fill(this.studying_planssDataSet.UMR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studying_planssDataSet.Main". При необходимости она может быть перемещена или удалена.
            // this.mainTableAdapter.Fill(this.studying_planssDataSet.Main);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studying_plansDataSet.Main". При необходимости она может быть перемещена или удалена.
            using (var conn = new SqlConnection(Properties.Settings.Default.Studying_planssConnectionString))
            {
                conn.Open();
                var command = new SqlCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text
                };
                
                for (int i = 0; i < gridContainer.Length; i++)
                {
                    command.CommandText = "SELECT * FROM " + grids[i];
                    using (var dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            for (int j = 0; j < 4; j++) gridContainer[i].Columns[j].ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void mainRefreshButt_Click(object sender, EventArgs e)
        {
            Console.WriteLine("OBNOVLYAYU");
            try
            {
                //INSERT INTO Main SELECT * FROM umr, omr, NIR WHERE dates <= NOW() + INTERVAL '30 days';
                var conn = new SqlConnection(Properties.Settings.Default.Studying_planssConnectionString);
                var command = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "TRUNCATE TABLE Main " +
                    "INSERT INTO Main " +
                    "SELECT * FROM UMR WHERE DATEDIFF(day, CONVERT (date, GETDATE()), dates) BETWEEN 0 AND 30 " + 
                    "union all" + " SELECT * FROM OMR WHERE DATEDIFF(day, CONVERT (date, GETDATE()), dates) BETWEEN 0 AND 30 " + 
                    "union all" + " SELECT * FROM NIR WHERE DATEDIFF(day, CONVERT (date, GETDATE()), dates) BETWEEN 0 AND 30"
                };
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                this.mainTableAdapter.Fill(this.studying_planssDataSet.Main);
            }
            catch
            {
                Console.WriteLine("ERRORrRRrRRR");
            }
        }

        private void tempTruncate_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(Properties.Settings.Default.Studying_planssConnectionString);
            var command = new SqlCommand
            {
                Connection = conn,
                CommandText = "TRUNCATE TABLE Main"
            };
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            this.mainTableAdapter.Fill(this.studying_planssDataSet.Main);
        }

        private void bindingSrc_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void mainBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void uMRBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void oMRBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void nIRBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void uMRBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fKMainUMRBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void studyingplansDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void umrButt_Click(object sender, EventArgs e)
        {
            addDataForm form = new addDataForm();
            GlobalVariables.tab = grids[1];
            form.ShowDialog();
            refreshAllData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(GlobalVariables.addingQuery);
            refreshAllData();
        }

        private void omrButt_Click(object sender, EventArgs e)
        {
            addDataForm form = new addDataForm();
            GlobalVariables.tab = grids[2];
            form.ShowDialog();
            refreshAllData();
        }

        private void nirButt_Click(object sender, EventArgs e)
        {
            addDataForm form = new addDataForm();
            GlobalVariables.tab = grids[3];
            form.ShowDialog();
            refreshAllData();
        }
        public void refreshAllData()
        {
            this.nIRTableAdapter.Fill(this.studying_planssDataSet.NIR);
            this.oMRTableAdapter.Fill(this.studying_planssDataSet.OMR);
            this.uMRTableAdapter.Fill(this.studying_planssDataSet.UMR);
        }

        public void umrGridCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            cellChanged(sender, e, 1);
        }

        public void omrGridCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            cellChanged(sender, e, 2);
        }
        public void nirGridCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            cellChanged(sender, e, 3);
        }

        public void cellChanged(object sender, DataGridViewCellEventArgs e, int idx)
        {
            if (e.ColumnIndex == gridContainer[idx].Columns[4].Index)
            {
                var newVal = gridContainer[idx].Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var changing = gridContainer[idx].Rows[e.RowIndex].Cells[0].Value;

                List<string> allowedValues = new List<string> { "Назначено", "В работе", "Выполнено", "Утверждено" };

                if (!allowedValues.Contains(newVal))
                {
                    MessageBox.Show("Неверное значение!\nВведите что-то из списка:\n \"Назначено\", \"В работе\", \"Выполнено\", \"Утверждено\"");
                }
                else 
                { 
                    if (newVal != changing)
                    {
                        using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Studying_planssConnectionString))
                        {
                            conn.Open();
                            string qry = "UPDATE " + grids[idx] + " SET status = @newVal WHERE work_type = @changing";

                            using (SqlCommand cmd = new SqlCommand(qry, conn))
                            {
                                cmd.Parameters.AddWithValue("@newVal", newVal);
                                cmd.Parameters.AddWithValue("@changing", changing);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        public void umrDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Console.WriteLine("SENDER ===== " + sender);
            DeletingRow(sender, e, 1);
            
        }
        public void omrDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DeletingRow(sender, e, 2);
        }
        public void nirDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DeletingRow(sender, e, 3);
        }
        public void DeletingRow(object sender, DataGridViewRowCancelEventArgs e, int idx)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Studying_planssConnectionString)) 
            {
                conn.Open();
                int i = 0;
                if (gridContainer[idx].Rows.Count > 0)
                {
                    try
                    {
                        var changing = gridContainer[idx].Rows[e.Row.Index].Cells[0].Value.ToString();
                        string qry = "DELETE FROM " + grids[idx] + " WHERE work_type = '" + changing + "'";
                        using (SqlCommand command = new SqlCommand(qry, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                }
            }
        }
    }

    public static class GlobalVariables
    {
        public static string addingQuery { get; set; }
        public static string tab { get; set; }
    }
}
