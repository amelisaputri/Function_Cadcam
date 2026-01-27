using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Class_Cadcam
{
    public partial class Program_Cadcam : Form
    {
        public Program_Cadcam()
        {
            InitializeComponent();
        }
        string connectionString = "Server=10.10.92.107;Database=CSTI_CADCAM;User ID=sa;Password=changshin2025!;TrustServerCertificate=True;";

        private uc_DataGrid1 dataGrid;   // ✅ FIELD


        private void Class_Cadcam_Load(object sender, EventArgs e)
        {
            LoadDataToFirstColumn();
            LoadDataFromDatabase();
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
            
            string colLetter = ColumnIndexToLetter(col);
            string address = $"{colLetter}{row}";

            textNumRow.Text = address;
            textNumCol.Text = address;
        }

        private string ColumnIndexToLetter(int col)
        {
            string result = "";
            while (col > 0)
            {
                col--;
                result = (char)('A' + (col % 26)) + result;
                col /= 26;
            }
            return result;
        }


        private void txtKolomKe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGrid.SelectCellByAddress(textNumCol.Text);

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


        // Pengisian Kolom dan baris yang telah dipilih
        private void textIsiCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGrid.SetValueToCurrentCell(textBoxCol.Text);

                // opsional: kosongkan textbox
                textBoxCol.Clear();

                // opsional: fokus balik ke grid
                dataGrid.Focus();

                e.SuppressKeyPress = true;
            }
        }


        //// ===============================
        //// BAGIAN DATABASE
        //// ===============================
        private void LoadDataFromDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM MASTER_MOLD";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 🔥 BIND KE DATAGRIDVIEW DI USERCONTROL
                    dataGrid.Grid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }




    }

}
