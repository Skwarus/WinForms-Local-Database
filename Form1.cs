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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//gridView
        {
            DataGridView data = new DataGridView();
            data.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)//Details
        {
            Details det = new Details();
            det.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
