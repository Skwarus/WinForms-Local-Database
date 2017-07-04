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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void employeeInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);
        }

        private void Details_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'employeeDataSet.EmployeeInfo' . Możesz go przenieść lub usunąć.
            this.employeeInfoTableAdapter.Fill(this.employeeDataSet.EmployeeInfo);

        }
    }
}
