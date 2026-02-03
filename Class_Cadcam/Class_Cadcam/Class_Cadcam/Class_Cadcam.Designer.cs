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
            panel_title = new Panel();
            Lb_title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_save = new Button();
            btn_Import = new Button();
            tlpRowCol = new TableLayoutPanel();
            Lb_Row = new Label();
            Lb_Column = new Label();
            textNumCol = new TextBox();
            textSumCol = new TextBox();
            textBoxCol = new TextBox();
            textSumRow = new TextBox();
            textNumRow = new TextBox();
            tlp_DataGrid.SuspendLayout();
            panel_title.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlpRowCol.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_DataGrid
            // 
            tlp_DataGrid.ColumnCount = 3;
            tlp_DataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tlp_DataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tlp_DataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.72222F));
            tlp_DataGrid.Controls.Add(panel_title, 0, 0);
            tlp_DataGrid.Controls.Add(tableLayoutPanel1, 2, 1);
            tlp_DataGrid.Controls.Add(tlpRowCol, 0, 1);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2160282F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.78397F));
            tableLayoutPanel1.Controls.Add(btn_save, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_Import, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(409, 54);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(596, 68);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Right;
            btn_save.Font = new Font("Pretendard SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(518, 39);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 0;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btnSave_Click;
            // 
            // btn_Import
            // 
            btn_Import.Anchor = AnchorStyles.Left;
            btn_Import.Font = new Font("Pretendard SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Import.Location = new Point(3, 39);
            btn_Import.Name = "btn_Import";
            btn_Import.Size = new Size(75, 23);
            btn_Import.TabIndex = 1;
            btn_Import.Text = "Import Excel";
            btn_Import.UseVisualStyleBackColor = true;
            btn_Import.Click += btn_Import_Click;
            // 
            // tlpRowCol
            // 
            tlpRowCol.ColumnCount = 4;
            tlp_DataGrid.SetColumnSpan(tlpRowCol, 2);
            tlpRowCol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0120125F));
            tlpRowCol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.75F));
            tlpRowCol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.75F));
            tlpRowCol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpRowCol.Controls.Add(Lb_Row, 0, 0);
            tlpRowCol.Controls.Add(Lb_Column, 2, 0);
            tlpRowCol.Controls.Add(textNumCol, 2, 1);
            tlpRowCol.Controls.Add(textSumCol, 3, 0);
            tlpRowCol.Controls.Add(textBoxCol, 3, 1);
            tlpRowCol.Controls.Add(textSumRow, 1, 0);
            tlpRowCol.Controls.Add(textNumRow, 1, 1);
            tlpRowCol.Dock = DockStyle.Fill;
            tlpRowCol.Location = new Point(3, 54);
            tlpRowCol.Name = "tlpRowCol";
            tlpRowCol.RowCount = 2;
            tlpRowCol.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRowCol.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRowCol.Size = new Size(400, 68);
            tlpRowCol.TabIndex = 1;
            // 
            // Lb_Row
            // 
            Lb_Row.Anchor = AnchorStyles.None;
            Lb_Row.AutoSize = true;
            Lb_Row.Font = new Font("Pretendard SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Row.Location = new Point(7, 9);
            Lb_Row.Name = "Lb_Row";
            Lb_Row.Size = new Size(33, 15);
            Lb_Row.TabIndex = 0;
            Lb_Row.Text = "Row";
            // 
            // Lb_Column
            // 
            Lb_Column.Anchor = AnchorStyles.None;
            Lb_Column.AutoSize = true;
            Lb_Column.Font = new Font("Pretendard SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Column.Location = new Point(185, 9);
            Lb_Column.Name = "Lb_Column";
            Lb_Column.Size = new Size(54, 15);
            Lb_Column.TabIndex = 4;
            Lb_Column.Text = "Column";
            // 
            // textNumCol
            // 
            textNumCol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNumCol.Location = new Point(160, 37);
            textNumCol.Name = "textNumCol";
            textNumCol.Size = new Size(104, 23);
            textNumCol.TabIndex = 5;
            textNumCol.Text = "Kolom Ke";
            textNumCol.KeyDown += txtKolomKe_KeyDown;
            // 
            // textSumCol
            // 
            textSumCol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSumCol.Location = new Point(270, 3);
            textSumCol.Name = "textSumCol";
            textSumCol.Size = new Size(127, 23);
            textSumCol.TabIndex = 6;
            textSumCol.Text = "8";
            textSumCol.KeyDown += txtColumn_KeyDown;
            // 
            // textBoxCol
            // 
            textBoxCol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCol.Location = new Point(270, 37);
            textBoxCol.Name = "textBoxCol";
            textBoxCol.Size = new Size(127, 23);
            textBoxCol.TabIndex = 7;
            textBoxCol.KeyDown += textIsiCell_KeyDown;
            // 
            // textSumRow
            // 
            textSumRow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSumRow.Location = new Point(50, 3);
            textSumRow.Name = "textSumRow";
            textSumRow.Size = new Size(104, 23);
            textSumRow.TabIndex = 2;
            textSumRow.Text = "5";
            textSumRow.KeyDown += txtRow_KeyDown;
            // 
            // textNumRow
            // 
            textNumRow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNumRow.Location = new Point(50, 37);
            textNumRow.Name = "textNumRow";
            textNumRow.Size = new Size(104, 23);
            textNumRow.TabIndex = 1;
            textNumRow.Text = "Baris ke ";
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
            panel_title.ResumeLayout(false);
            panel_title.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tlpRowCol.ResumeLayout(false);
            tlpRowCol.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_DataGrid;
        private Label Lb_title;
        private Panel panel_title;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tlpRowCol;
        private Label Lb_Row;
        private TextBox textNumRow;
        private TextBox textSumRow;
        private Label Lb_Column;
        private TextBox textNumCol;
        private TextBox textSumCol;
        private TextBox textBoxCol;
        private Button btn_save;
        private Button btn_Import;
    }
}
