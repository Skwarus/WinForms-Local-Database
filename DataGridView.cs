using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Local_Database
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void employeeInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);
            

        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'employeeDataSet.EmployeeInfo' . Możesz go przenieść lub usunąć.
            this.employeeInfoTableAdapter.Fill(this.employeeDataSet.EmployeeInfo);
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = employeeInfoBindingSource.Count;
            label1.Text = "Your database cointain a : " + count.ToString() + " rows.";
            if(count<2)//appear / disappear previos and last buttons
            {
                button2.Visible = false;
                button3.Visible = false;
            }
            else
            {
                button2.Visible = true;
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeInfoBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeeInfoBindingSource.MoveNext();
        }

        private void searchSurnameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeInfoTableAdapter.SearchSurname(this.employeeDataSet.EmployeeInfo, surnameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeInfoTableAdapter.SearchSurname(this.employeeDataSet.EmployeeInfo, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Refresh();
        }
    }
}
