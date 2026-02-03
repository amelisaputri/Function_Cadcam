using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ExcelDataReader;
using System.Data;
using System.Data.SqlClient;
using System.IO;

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

            // ambil DataGridView dari UserControl
            var dgv = dataGrid.Grid;

            // HEADER
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            // CELL
            dgv.DefaultCellStyle.BackColor = Color.Black;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.ForeColor = Color.White;

            //Mengikuti ukuran isi cell kolom
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


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


        //// ===============================
        //// BAGIAN Button SAVE
        //// ===============================

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGrid.Grid.DataSource as DataTable;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk disimpan");
                return;
            }

            string[] requiredColumns = { "SERIAL_NUM" };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        // 🔹 Skip baris kosong total
                        bool emptyRow = true;
                        foreach (DataColumn col in dt.Columns)
                        {
                            if (row[col] != DBNull.Value &&
                                !string.IsNullOrWhiteSpace(row[col].ToString()))
                            {
                                emptyRow = false;
                                break;
                            }
                        }
                        if (emptyRow) continue;

                        // 🔹 Validasi kolom WAJIB
                        foreach (string colName in requiredColumns)
                        {
                            if (row[colName] == DBNull.Value ||
                                string.IsNullOrWhiteSpace(row[colName].ToString()))
                            {
                                int r = dt.Rows.IndexOf(row);
                                int c = dt.Columns[colName].Ordinal;

                                dataGrid.Grid.CurrentCell =
                                    dataGrid.Grid.Rows[r].Cells[c];
                                dataGrid.Grid.BeginEdit(true);

                                MessageBox.Show(
                                    $"Kolom {colName} wajib diisi",
                                    "Validasi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                trans.Rollback();
                                return;
                            }
                        }

                        // 🔹 INSERT (contoh kolom utama saja)
                        SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO MASTER_MOLD
                        (SERIAL_NUM, PO_DATE, O_ETC, DELIVERY, R_ETC, STAGE )
                        VALUES
                        (@SERIAL_NUM, @PO_DATE, @O_ETC, @DELIVERY, @R_ETC, @STAGE)",
                            conn, trans);

                        cmd.Parameters.AddWithValue("@SERIAL_NUM", row["SERIAL_NUM"]);
                        cmd.Parameters.AddWithValue("@PO_DATE", row["PO_DATE"] ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@O_ETC", row["O_ETC"] ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DELIVERY", row["DELIVERY"] ?? false);
                        cmd.Parameters.AddWithValue("@R_ETC", row["R_ETC"] ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@STAGE", row["STAGE"] ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Data berhasil disimpan");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Gagal menyimpan data:\n" + ex.Message);
                }
            }
        }

        //// ===============================
        //// BAGIAN Button IMPORT
        //// ===============================  

        private HashSet<string> GetDbColumns(SqlConnection conn)
        {
            HashSet<string> cols = new HashSet<string>();

            using (SqlCommand cmd = new SqlCommand(
                @"SELECT COLUMN_NAME 
          FROM INFORMATION_SCHEMA.COLUMNS
          WHERE TABLE_NAME = 'MASTER_MOLD'", conn))
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    cols.Add(rdr.GetString(0).ToUpper());
            }

            return cols;
        }

        private List<string> GetInvalidColumns(DataTable dt, HashSet<string> dbCols)
        {
            return dt.Columns
                .Cast<DataColumn>()
                .Where(c => !dbCols.Contains(c.ColumnName))
                .Select(c => c.ColumnName)
                .ToList();
        }


        private string NormalizeColumn(string col)
        {
            string c = col.Trim().ToUpper();

            // umum
            c = c.Replace("-", "_")
                 .Replace(" ", "_");

            // 🔥 Excel → Database
            if (c == "2D")
                return "_2D";

            if (c == "3D")
                return "_3D";

            // 🔥 duplikat Excel (_1) → CNC
            if (c.EndsWith("_1"))
                c = c.Replace("_1", "_CNC");

            return c;
        }


        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                // 1. Baca Excel
                DataTable dt = ReadExcel(ofd.FileName);

                // 🔥 WAJIB sebelum ImportToDatabase
                FixExcelDateColumns(dt, "PO_DATE", "O_ETC", "R_ETC");

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("File Excel kosong");
                    return;
                }

                // OPTIONAL preview
                // dgvPreview.DataSource = dt;

                // 2. Import ke Database
                ImportToDatabase(dt);

                MessageBox.Show("Import Excel ke Master_Mold berhasil 👍");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal import:\n" + ex.Message);
            }
        }

        private DataTable ReadExcel(string path)
        {
            System.Text.Encoding.RegisterProvider(
                System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(
                path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var conf = new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                };

                DataTable dt = reader.AsDataSet(conf).Tables[0];

                Dictionary<string, int> colCounter = new Dictionary<string, int>();

                foreach (DataColumn col in dt.Columns)
                {
                    string newName = NormalizeColumn(col.ColumnName);

                    // 🔁 HANDLE DUPLIKAT → TAMBAH _CNC
                    if (colCounter.ContainsKey(newName))
                    {
                        colCounter[newName]++;
                        newName = newName + "_CNC";
                    }
                    else
                    {
                        colCounter[newName] = 1;
                    }

                    col.ColumnName = newName; // 🔥 INI WAJIB
                }

                return dt;
            }
        }

        private void ImportToDatabase(DataTable dt)
        {
            using (SqlConnection conn = new SqlConnection(
                "Server=10.10.92.107;Database=CSTI_CADCAM;User ID=sa;Password=changshin2025!;TrustServerCertificate=True;"))
            {
                conn.Open();

                HashSet<string> dbCols = GetDbColumns(conn);
                List<string> invalidCols = GetInvalidColumns(dt, dbCols);

                // 🔔 TAMPILKAN KOLOM SALAH (INI YANG KAMU MAU)
                if (invalidCols.Count > 0)
                {
                    MessageBox.Show(
                        "Kolom berikut TIDAK ADA di database dan akan diisi NULL:\n\n" +
                        string.Join(", ", invalidCols),
                        "Info Kolom Tidak Valid",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                using (SqlBulkCopy bulk = new SqlBulkCopy(conn))
                {
                    bulk.DestinationTableName = "MASTER_MOLD";

                    foreach (DataColumn col in dt.Columns)
                    {
                        if (dbCols.Contains(col.ColumnName))
                        {
                            bulk.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                        }
                        // ❌ kolom invalid TIDAK dikirim → DB isi NULL
                    }

                    bulk.WriteToServer(dt);
                }
            }
        }

        private void FixExcelDateColumns(DataTable dt, params string[] dateColumns)
        {
            foreach (string col in dateColumns)
            {
                if (!dt.Columns.Contains(col)) continue;

                foreach (DataRow row in dt.Rows)
                {
                    if (row[col] == DBNull.Value) continue;

                    // Excel serial date (Double)
                    if (row[col] is double d)
                    {
                        // 0 atau invalid → NULL
                        if (d <= 0)
                        {
                            row[col] = DBNull.Value;
                        }
                        else
                        {
                            row[col] = DateTime.FromOADate(d);
                        }
                    }

                    // String tanggal (opsional)
                    else if (row[col] is string s && !string.IsNullOrWhiteSpace(s))
                    {
                        if (DateTime.TryParse(s, out DateTime parsed))
                        {
                            row[col] = parsed;
                        }
                        else
                        {
                            row[col] = DBNull.Value;
                        }
                    }
                }
            }
        }




    }

}
