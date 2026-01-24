namespace Class_Cadcam
{
    public partial class Program_Cadcam : Form
    {
        public Program_Cadcam()
        {
            InitializeComponent();
        }
        private uc_DataGrid1 dataGrid;   // ✅ FIELD
        private void Class_Cadcam_Load(object sender, EventArgs e)
        {
            LoadDataToFirstColumn();
        }
        private void LoadDataToFirstColumn()
        {
            // Buat instance usercontrol
            dataGrid = new uc_DataGrid1(); // ✅ isi FIELD

            // Biar penuh di kolom
            //dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            dataGrid.Dock = DockStyle.Fill;

            // (opsional) hapus margin agar rapih
            dataGrid.Margin = new Padding(0);

            // 🔥 INI KUNCI SPAN COL
            tlp_DataGrid.SetColumnSpan(dataGrid, 3);

            dataGrid.CellPositionChanged += DataGrid_CellPositionChanged;

            // Tambahkan ke:
            // Column = 0
            // Row    = 1  
            tlp_DataGrid.Controls.Add(dataGrid, 0, 2);

        }

        //// ===============================
        //// BAGIAN PILIH ROW DAN COL
        //// ===============================

        private void DataGrid_CellPositionChanged(int row, int col)
        {
            textNumRow.Text = row.ToString();
            textNumCol.Text = col.ToString();
        }

        private void txtKolomKe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(textNumRow.Text, out int row) ||
                    !int.TryParse(textNumCol.Text, out int col))
                {
                    MessageBox.Show("Baris dan Kolom harus berupa angka");
                    return;
                }

                dataGrid.SelectCell(row, col);

                e.SuppressKeyPress = true;
            }
        }

        //// ===============================
        

        //// ===============================
        //// ENTER DI ROW

        private void txtRow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&
                int.TryParse(textSumRow.Text, out int row))
            {
                dataGrid.SetRow(row);
                dataGrid.SetColumn(GetColumnValue());
                e.SuppressKeyPress = true;
            }
        }

        private void txtColumn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&
                int.TryParse(textSumCol.Text, out int col))
            {
                dataGrid.SetColumn(col);
                dataGrid.SetRow(GetRowValue());
                e.SuppressKeyPress = true;
            }
        }

        private int GetColumnValue()
        {
            return int.TryParse(textSumCol.Text, out int c)
                ? Math.Min(c, dataGrid.MaxColumn)
                : dataGrid.MaxColumn;
        }

        private int GetRowValue()
        {
            return int.TryParse(textSumRow.Text, out int r) ? r : 0;
        }

        //// ENTER DI ROW
        //// ===============================

    }

}
