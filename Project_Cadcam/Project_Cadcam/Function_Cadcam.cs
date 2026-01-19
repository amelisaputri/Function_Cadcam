using System.Globalization;

namespace Project_Cadcam
{
    public partial class Function_Cadcam : Form
    {
        public Function_Cadcam()
        {
            InitializeComponent();
            SetDateFormat();
        }

        //Change Date
        private void SetDateFormat()
        {
            dtpPlan.Format = DateTimePickerFormat.Custom;
            dtpPlan.CustomFormat = "yyyy-MM-dd";

            dtpPlan2.Format = DateTimePickerFormat.Custom;
            dtpPlan2.CustomFormat = "yyyy-MM-dd";

            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "yyyy-MM-dd";

            dtpStart2.Format = DateTimePickerFormat.Custom;
            dtpStart2.CustomFormat = "yyyy-MM-dd";

            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "yyyy-MM-dd";

            dtpEnd2.Format = DateTimePickerFormat.Custom;
            dtpEnd2.CustomFormat = "yyyy-MM-dd";
        }

        //-- Public function--//
        // Parsing Data 1
        private (bool valid, int status,
        DateTime plan, DateTime start, DateTime end)
        ParseData1(string input)
        {
            var p = input.Split('&');
            if (p.Length != 4)
                return default;

            // STATUS = ANGKA SAJA
            if (!int.TryParse(p[0], out int status))
                return default;

            if (!DateTime.TryParseExact(p[1], "yyyyMMdd", null,
                DateTimeStyles.None, out var plan)) return default;

            if (!DateTime.TryParseExact(p[2], "yyyyMMdd", null,
                DateTimeStyles.None, out var start)) return default;

            if (!DateTime.TryParseExact(p[3], "yyyyMMdd", null,
                DateTimeStyles.None, out var end)) return default;

            return (true, status, plan, start, end);
        }


        // Parsing Data 2
        private (bool valid, int status,
        DateTime plan, DateTime start, DateTime end,
        string part, string sizeX, string sizeY, string sizeZ)
        ParseData2(string input)
        {
            var p = input.Split('&');
            if (p.Length != 6)
                return default;

            // ===== STATUS =====
            if (!int.TryParse(p[0], out int status))
                return default;

            // ===== DATE =====
            if (!DateTime.TryParseExact(p[1], "yyyyMMdd", null,
                DateTimeStyles.None, out var plan)) return default;

            if (!DateTime.TryParseExact(p[2], "yyyyMMdd", null,
                DateTimeStyles.None, out var start)) return default;

            if (!DateTime.TryParseExact(p[3], "yyyyMMdd", null,
                DateTimeStyles.None, out var end)) return default;

            // ===== PART =====
            string part = p[4];

            // ===== SIZE (100X200X50) =====
            var size = p[5].Split('X');
            if (size.Length != 3)
                return default;

            string sizeX = size[0];
            string sizeY = size[1];
            string sizeZ = size[2];

            return (true, status, plan, start, end, part, sizeX, sizeY, sizeZ);
        }
        //-- Public function--//


        // --- function Enter Universal---//
        private void textBoxData1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;

            var d = ParseData1(textBoxData1.Text);
            if (!d.valid)
            {
                MessageBox.Show("Format Data 1 salah");
                return;
            }

            textStatus1.Text = d.status.ToString(); ;
            dtpPlan.Value = d.plan;
            dtpStart.Value = d.start;
            dtpEnd.Value = d.end;
        }

        private void textData2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;

            var d = ParseData2(textData2.Text);
            if (!d.valid)
            {
                MessageBox.Show("Format Data 2 salah");
                return;
            }

            // ===== STATUS =====
            textStatus2.Text = d.status.ToString();

            // ===== DATE =====
            dtpPlan2.Value = d.plan;
            dtpStart2.Value = d.start;
            dtpEnd2.Value = d.end;

            // ===== PART =====
            textPart.Text = d.part;

            // ===== SIZE =====
            textSizeX.Text = d.sizeX;
            textSizeY.Text = d.sizeY;
            textSizeZ.Text = d.sizeZ;
        }
        // --- function Enter Universal---//

        //--- Function Edit ----//
        private string BuildData1String()
        {
            int status = int.Parse(textStatus1.Text);

            string plan = dtpPlan.Value.ToString("yyyyMMdd");
            string start = dtpStart.Value.ToString("yyyyMMdd");
            string end = dtpEnd.Value.ToString("yyyyMMdd");

            return $"{status}&{plan}&{start}&{end}";
        }

        private string BuildData2String()
        {
            int status = int.Parse(textStatus2.Text);

            string plan = dtpPlan2.Value.ToString("yyyyMMdd");
            string start = dtpStart2.Value.ToString("yyyyMMdd");
            string end = dtpEnd2.Value.ToString("yyyyMMdd");

            string part = textPart.Text.Trim();

            string size = $"{textSizeX.Text}X{textSizeY.Text}X{textSizeZ.Text}";

            return $"{status}&{plan}&{start}&{end}&{part}&{size}";
        }


        // --- function Button Submit ---//
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            // 🔁 FORM → STRING
            string updatedData1 = BuildData1String();
            string updatedData2 = BuildData2String();

            // REFRESH textbox Data 1 & Data 2
            textBoxData1.Text = updatedData1;
            textData2.Text = updatedData2;

            // (opsional) feedback
            MessageBox.Show("Data berhasil diperbarui", "Submit");
        }
        // --- function Button Submit ---//
    }
}
