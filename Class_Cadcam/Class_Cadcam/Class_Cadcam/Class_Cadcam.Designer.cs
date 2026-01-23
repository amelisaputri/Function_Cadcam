namespace Class_Cadcam
{
    partial class Program_Cadcam
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
            tlp_DataGrid = new TableLayoutPanel();
            panel_RowCol = new Panel();
            tlpRowCol = new TableLayoutPanel();
            Lb_Row = new Label();
            textNumRow = new TextBox();
            textSumRow = new TextBox();
            textBoxRow = new TextBox();
            Lb_Column = new Label();
            textNumCol = new TextBox();
            textSumCol = new TextBox();
            textBoxCol = new TextBox();
            panel_title = new Panel();
            Lb_title = new Label();
            tlp_DataGrid.SuspendLayout();
            panel_RowCol.SuspendLayout();
            tlpRowCol.SuspendLayout();
            panel_title.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_DataGrid
            // 
            tlp_DataGrid.ColumnCount = 3;
            tlp_DataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlp_DataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlp_DataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlp_DataGrid.Controls.Add(panel_RowCol, 0, 1);
            tlp_DataGrid.Controls.Add(panel_title, 0, 0);
            tlp_DataGrid.Dock = DockStyle.Fill;
            tlp_DataGrid.Location = new Point(0, 0);
            tlp_DataGrid.Name = "tlp_DataGrid";
            tlp_DataGrid.RowCount = 3;
            tlp_DataGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 7.01530552F));
            tlp_DataGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2880659F));
            tlp_DataGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 82.71605F));
            tlp_DataGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_DataGrid.Size = new Size(1008, 729);
            tlp_DataGrid.TabIndex = 0;
            // 
            // panel_RowCol
            // 
            tlp_DataGrid.SetColumnSpan(panel_RowCol, 2);
            panel_RowCol.Controls.Add(tlpRowCol);
            panel_RowCol.Dock = DockStyle.Fill;
            panel_RowCol.Location = new Point(3, 54);
            panel_RowCol.Name = "panel_RowCol";
            panel_RowCol.Size = new Size(666, 68);
            panel_RowCol.TabIndex = 2;
            // 
            // tlpRowCol
            // 
            tlpRowCol.Anchor = AnchorStyles.Left;
            tlpRowCol.ColumnCount = 4;
            tlpRowCol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowCol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowCol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowCol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowCol.Controls.Add(Lb_Row, 0, 0);
            tlpRowCol.Controls.Add(textNumRow, 0, 1);
            tlpRowCol.Controls.Add(textSumRow, 1, 0);
            tlpRowCol.Controls.Add(textBoxRow, 1, 1);
            tlpRowCol.Controls.Add(Lb_Column, 2, 0);
            tlpRowCol.Controls.Add(textNumCol, 2, 1);
            tlpRowCol.Controls.Add(textSumCol, 3, 0);
            tlpRowCol.Controls.Add(textBoxCol, 3, 1);
            tlpRowCol.Location = new Point(0, 3);
            tlpRowCol.Name = "tlpRowCol";
            tlpRowCol.RowCount = 2;
            tlpRowCol.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRowCol.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRowCol.Size = new Size(578, 62);
            tlpRowCol.TabIndex = 1;
            // 
            // Lb_Row
            // 
            Lb_Row.Anchor = AnchorStyles.None;
            Lb_Row.AutoSize = true;
            Lb_Row.Font = new Font("Pretendard SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Row.Location = new Point(55, 8);
            Lb_Row.Name = "Lb_Row";
            Lb_Row.Size = new Size(33, 15);
            Lb_Row.TabIndex = 0;
            Lb_Row.Text = "Row";
            // 
            // textNumRow
            // 
            textNumRow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNumRow.Location = new Point(3, 34);
            textNumRow.Name = "textNumRow";
            textNumRow.Size = new Size(138, 23);
            textNumRow.TabIndex = 1;
            // 
            // textSumRow
            // 
            textSumRow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSumRow.Location = new Point(147, 3);
            textSumRow.Name = "textSumRow";
            textSumRow.Size = new Size(138, 23);
            textSumRow.TabIndex = 2;
            textSumRow.Text = "5";
            textSumRow.KeyDown += txtRow_KeyDown;
            // 
            // textBoxRow
            // 
            textBoxRow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRow.Location = new Point(147, 34);
            textBoxRow.Name = "textBoxRow";
            textBoxRow.Size = new Size(138, 23);
            textBoxRow.TabIndex = 3;
            // 
            // Lb_Column
            // 
            Lb_Column.Anchor = AnchorStyles.None;
            Lb_Column.AutoSize = true;
            Lb_Column.Font = new Font("Pretendard SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Column.Location = new Point(333, 8);
            Lb_Column.Name = "Lb_Column";
            Lb_Column.Size = new Size(54, 15);
            Lb_Column.TabIndex = 4;
            Lb_Column.Text = "Column";
            // 
            // textNumCol
            // 
            textNumCol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNumCol.Location = new Point(291, 34);
            textNumCol.Name = "textNumCol";
            textNumCol.Size = new Size(138, 23);
            textNumCol.TabIndex = 5;
            // 
            // textSumCol
            // 
            textSumCol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSumCol.Location = new Point(435, 3);
            textSumCol.Name = "textSumCol";
            textSumCol.Size = new Size(140, 23);
            textSumCol.TabIndex = 6;
            textSumCol.Text = "8";
            textSumCol.KeyDown += txtColumn_KeyDown;
            // 
            // textBoxCol
            // 
            textBoxCol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCol.Location = new Point(435, 34);
            textBoxCol.Name = "textBoxCol";
            textBoxCol.Size = new Size(140, 23);
            textBoxCol.TabIndex = 7;
            // 
            // panel_title
            // 
            panel_title.BackColor = SystemColors.ActiveCaption;
            tlp_DataGrid.SetColumnSpan(panel_title, 3);
            panel_title.Controls.Add(Lb_title);
            panel_title.Dock = DockStyle.Fill;
            panel_title.Location = new Point(3, 3);
            panel_title.Name = "panel_title";
            panel_title.Size = new Size(1002, 45);
            panel_title.TabIndex = 3;
            // 
            // Lb_title
            // 
            Lb_title.Anchor = AnchorStyles.None;
            Lb_title.AutoSize = true;
            Lb_title.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_title.Location = new Point(425, 12);
            Lb_title.Name = "Lb_title";
            Lb_title.Size = new Size(173, 23);
            Lb_title.TabIndex = 0;
            Lb_title.Text = "Program CADCAM";
            // 
            // Program_Cadcam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tlp_DataGrid);
            Name = "Program_Cadcam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Program_Cadcam";
            Load += Class_Cadcam_Load;
            tlp_DataGrid.ResumeLayout(false);
            panel_RowCol.ResumeLayout(false);
            tlpRowCol.ResumeLayout(false);
            tlpRowCol.PerformLayout();
            panel_title.ResumeLayout(false);
            panel_title.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_DataGrid;
        private Label Lb_title;
        private Panel panel_RowCol;
        private TableLayoutPanel tlpRowCol;
        private Label Lb_Row;
        private TextBox textNumRow;
        private TextBox textSumRow;
        private TextBox textBoxRow;
        private Label Lb_Column;
        private TextBox textNumCol;
        private TextBox textSumCol;
        private TextBox textBoxCol;
        private Panel panel_title;
    }
}
