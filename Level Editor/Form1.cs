using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddRows_Click(object sender, EventArgs e)
        {
            NewShape.Rows.Add();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * if click on button iside the table, it will print 1/0 in match to value
             */ 


            if (NewShape.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                NewShape.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "1";

            if (NewShape.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals("1"))
                NewShape.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
            else
                NewShape.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "1";
        }

        private void AddColumn_Click_1(object sender, EventArgs e)
        {
            NewShape.Columns.Add(new DataGridViewButtonColumn() { Width = 20, Text = "0" } );
        }
    }
}
