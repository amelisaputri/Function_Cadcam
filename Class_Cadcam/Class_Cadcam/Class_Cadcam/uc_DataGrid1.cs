using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Cadcam
{
    public partial class uc_DataGrid1 : UserControl
    {
        public uc_DataGrid1()
        {
            InitializeComponent();
            InitGrid();
        }

        public int MaxColumn => dataGridView1.Columns.Count;

        private void InitGrid()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        // ===============================
        // METHOD UNTUK DIPANGGIL FORM
        // ===============================

        public void SetRow(int totalRow)
        {
            dataGridView1.Rows.Clear();
            if (totalRow > 0)
                dataGridView1.Rows.Add(totalRow);
        }

        public void SetColumn(int totalColumn)
        {
            int maxColumn = dataGridView1.Columns.Count;

            if (totalColumn > maxColumn)
                totalColumn = maxColumn;

            for (int i = 0; i < maxColumn; i++)
                dataGridView1.Columns[i].Visible = i < totalColumn;
        }

       
    }
}
