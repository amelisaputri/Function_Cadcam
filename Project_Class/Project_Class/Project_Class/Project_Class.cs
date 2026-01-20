using System.Windows.Forms;

namespace Project_Class
{
    public partial class Project_Class : Form
    {
        public Project_Class()
        {
            InitializeComponent();
        }

        Label lblCadCam;

        private void Project_Class_Load(object sender, EventArgs e)
        {
            FormatGrid(dgv1);
            CreateLabel();
            SyncBandWidth();
        }

        private void FormatGrid(DataGridView dgv)
        {
            if (dgv == null) return;

            // Header center
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);

            // Auto size by HEADER (bukan isi)
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            // === INI KUNCINYA ===
            dgv.ScrollBars = ScrollBars.Both;

            // Biar horizontal scroll muncul
            dgv.Dock = DockStyle.Fill;   // atau NONE, asal jangan AutoSize

            // Disable auto resize yang bikin kolom dipaksa muat layar
            dgv.AutoSize = false;

            // Cosmetic
            //dgv.RowHeadersVisible = false;
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CreateLabel()
        {
            lblCadCam = new Label()
            {
                Text = "CAD / CAM",
                Height = 32,
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGray,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            panelBandHeader.Controls.Add(lblCadCam);
        }



        private void SyncBandWidth()
        {
            if (lblCadCam == null) return;
            if (dgv1.Columns.Count == 0) return;

            int totalWidth = 0;
            int startX = int.MaxValue;

            foreach (DataGridViewColumn col in dgv1.Columns)
            {
                if (!col.Visible) continue;

                totalWidth += col.Width;

                Rectangle rect = dgv1.GetColumnDisplayRectangle(col.Index, true);
                if (rect.X < startX)
                    startX = rect.X;
            }

            if (startX == int.MaxValue)
                startX = 0;

            lblCadCam.Left = startX;
            lblCadCam.Width = totalWidth;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                panelBandHeader.Left = -dgv1.HorizontalScrollingOffset;
            }
        }

        private void dgv1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            SyncBandWidth();
        }
    }
}
