namespace Project_Class
{
    public partial class Project_Class : Form
    {
        public Project_Class()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_ExcelRow row = new UC_ExcelRow();

            // samakan lebar dengan FlowLayoutPanel
            row.Width = flpRows.ClientSize.Width - 25;

            flpRows.Controls.Add(row);
        }
    }
}
