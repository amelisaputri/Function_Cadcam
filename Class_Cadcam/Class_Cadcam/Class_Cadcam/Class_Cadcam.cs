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
            LoadHeaderToFirstColumn();
        }
        private void LoadHeaderToFirstColumn()
        {
            // Buat instance usercontrol
            uc_DataGrid1 dataGrid = new uc_DataGrid1();

            // Biar penuh di kolom
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;

            // (opsional) hapus margin agar rapih
            dataGrid.Margin = new Padding(0);

            // Tambahkan ke:
            // Column = 0
            // Row    = 1  (baris konten, bukan header atas)
            tlp_DataGrid.Controls.Add(dataGrid, 0, 2);
        }

        //// ===============================
        //// ENTER DI ROW
        //// ===============================
        private void txtRow_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(textSumRow.Text, out int row))
                {
                    MessageBox.Show("Row harus berupa angka");
                    return;
                }

                dataGrid.SetRow(row);
                dataGrid.SetColumn(GetColumnValue());

                e.SuppressKeyPress = true;
            }
        }

        // ===============================
        // ENTER DI COLUMN
        // ===============================
        private void txtColumn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(textSumCol.Text, out int col))
                {
                    MessageBox.Show("Column harus berupa angka");
                    return;
                }

                dataGrid.SetColumn(col);
                dataGrid.SetRow(GetRowValue());

                e.SuppressKeyPress = true;
            }
        }

        // ===============================
        // HELPER METHOD
        // ===============================
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


    }

}
