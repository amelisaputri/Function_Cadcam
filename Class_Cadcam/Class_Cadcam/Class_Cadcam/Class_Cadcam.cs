namespace Class_Cadcam
{
    public partial class Program_Cadcam : Form
    {
        public Program_Cadcam()
        {
            InitializeComponent();
        }

        private void Class_Cadcam_Load(object sender, EventArgs e)
        {

        }

        // ===============================
        // ENTER DI ROW
        // ===============================
        private void txtRow_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(textSumRow.Text, out int row))
                {
                    MessageBox.Show("Row harus berupa angka");
                    return;
                }

                uc_DataGrid1.SetRow(row);
                uc_DataGrid1.SetColumn(GetColumnValue());

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

                uc_DataGrid1.SetColumn(col);
                uc_DataGrid1.SetRow(GetRowValue());

                e.SuppressKeyPress = true;
            }
        }

        // ===============================
        // HELPER METHOD
        // ===============================
        private int GetColumnValue()
        {
            return int.TryParse(textSumCol.Text, out int c)
                ? Math.Min(c, uc_DataGrid1.MaxColumn)
                : uc_DataGrid1.MaxColumn;
        }

        private int GetRowValue()
        {
            return int.TryParse(textSumRow.Text, out int r) ? r : 0;
        }


    }

}
