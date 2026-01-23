using System.Windows.Forms;

namespace Project_Class
{
    public partial class Project_Class : Form
    {
        public Project_Class()
        {
            InitializeComponent();
        }

        private void Project_Class_Load(object sender, EventArgs e)
        {
            LoadHeaderToFirstColumn();
        }

        private void LoadHeaderToFirstColumn()
        {
            // Buat instance usercontrol
            UC_Header_CADCAM header = new UC_Header_CADCAM();

            // Biar penuh di kolom
            header.Anchor = AnchorStyles.Top | AnchorStyles.Right| AnchorStyles.Left;

            // (opsional) hapus margin agar rapih
            header.Margin = new Padding(0);

            // Pastikan TableLayoutPanel kosong di cell tersebut
            //tlp_Main.Controls.Clear();
 
            // Tambahkan ke:
            // Column = 0
            // Row    = 1  (baris konten, bukan header atas)
            tlp_Main.Controls.Add(header, 0, 1);
        }


    }
}
