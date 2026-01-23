namespace Project_Class
{
    partial class Project_Class
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tlp_Main = new TableLayoutPanel();
            tlp_Main.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 14);
            label1.Name = "label1";
            label1.Size = new Size(173, 23);
            label1.TabIndex = 0;
            label1.Text = "Program CADCAM";
            // 
            // tlp_Main
            // 
            tlp_Main.BackColor = Color.White;
            tlp_Main.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlp_Main.ColumnCount = 3;
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.02721F));
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.5620461F));
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.41075F));
            tlp_Main.Controls.Add(label1, 1, 0);
            tlp_Main.Dock = DockStyle.Fill;
            tlp_Main.Location = new Point(0, 0);
            tlp_Main.Name = "tlp_Main";
            tlp_Main.RowCount = 2;
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 7.00549459F));
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 92.99451F));
            tlp_Main.Size = new Size(1008, 729);
            tlp_Main.TabIndex = 0;
            // 
            // Project_Class
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tlp_Main);
            Name = "Project_Class";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project";
            WindowState = FormWindowState.Maximized;
            Load += Project_Class_Load;
            tlp_Main.ResumeLayout(false);
            tlp_Main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tlp_Main;
    }
}
