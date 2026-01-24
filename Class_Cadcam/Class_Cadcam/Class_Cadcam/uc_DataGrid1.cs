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

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        public int MaxColumn => dataGridView1.Columns.Count;
        public event Action<int, int> CellPositionChanged;


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

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
                return;

            int row = dataGridView1.CurrentCell.RowIndex + 1;
            int col = dataGridView1.CurrentCell.ColumnIndex + 1;

            CellPositionChanged?.Invoke(row, col);
        }

        public void SelectCell(int row, int col)
        {
            // ubah dari user (1-based) ke grid (0-based)
            int r = row - 1;
            int c = col - 1;

            // validasi batas
            if (r < 0 || r >= dataGridView1.Rows.Count)
                return;

            if (c < 0 || c >= dataGridView1.Columns.Count)
                return;

            if (!dataGridView1.Columns[c].Visible)
                return;

            dataGridView1.CurrentCell = dataGridView1.Rows[r].Cells[c];
            dataGridView1.BeginEdit(true); // langsung bisa ngetik
        }


    }
}
