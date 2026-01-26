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

            // JANGAN ColumnHeader
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dataGridView1.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Autosize PER KOLOM (bukan global)
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
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
            int r = row - 1;
            int c = col - 1;

            if (r < 0 || r >= dataGridView1.Rows.Count)
                return;
            if (c < 0 || c >= dataGridView1.Columns.Count)
                return;
            if (!dataGridView1.Columns[c].Visible)
                return;

            dataGridView1.CurrentCell = dataGridView1.Rows[r].Cells[c];
            dataGridView1.Focus();   // 🔥 WAJIB
            dataGridView1.BeginEdit(true);

            // 🔥 TRIGGER EVENT MANUAL
            CellPositionChanged?.Invoke(row, col);
        }

        private int ColumnLetterToIndex(string column)
        {
            int result = 0;

            foreach (char c in column)
            {
                result *= 26;
                result += (c - 'A' + 1);
            }

            return result - 1; // zero-based
        }


        // DIPAKAI OLEH FORM (textNumRow & textNumCol)
        public void SelectCellByAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                return;

            address = address.Trim().ToUpper();

            int i = 0;
            while (i < address.Length && char.IsLetter(address[i]))
                i++;

            if (i == 0 || i == address.Length)
                return;

            string colPart = address.Substring(0, i);
            string rowPart = address.Substring(i);

            if (!int.TryParse(rowPart, out int row))
                return;

            int col = ColumnLetterToIndex(colPart);

            SelectCell(row, col + 1);
        }

        // Isi Value Kolom dan Baris yang di Pilih
        public void SetValueToCurrentCell(string value)
        {
            if (dataGridView1.CurrentCell == null)
                return;

            dataGridView1.CurrentCell.Value = value;

            int col = dataGridView1.CurrentCell.ColumnIndex;

            // 🔥 resize kolom aktif
            dataGridView1.AutoResizeColumn(
                col,
                DataGridViewAutoSizeColumnMode.AllCells
            );
        }

    }
}
