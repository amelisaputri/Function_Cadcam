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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            lb_judul = new Label();
            flpRows = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.24228F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.75772F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(lb_judul, 0, 0);
            tableLayoutPanel1.Controls.Add(flpRows, 0, 2);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.40740633F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.38957453F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.3401947F));
            tableLayoutPanel1.Size = new Size(1008, 729);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Font = new Font("Pretendard", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(930, 15);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lb_judul
            // 
            lb_judul.Anchor = AnchorStyles.Left;
            lb_judul.AutoSize = true;
            lb_judul.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_judul.Location = new Point(3, 17);
            lb_judul.Name = "lb_judul";
            lb_judul.Size = new Size(122, 19);
            lb_judul.TabIndex = 2;
            lb_judul.Text = "Project Cadcam";
            // 
            // flpRows
            // 
            flpRows.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.SetColumnSpan(flpRows, 2);
            flpRows.Dock = DockStyle.Fill;
            flpRows.FlowDirection = FlowDirection.TopDown;
            flpRows.Location = new Point(3, 87);
            flpRows.Name = "flpRows";
            flpRows.Padding = new Padding(0, 0, 0, 5);
            flpRows.Size = new Size(1002, 639);
            flpRows.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1002, 25);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "SERIAL NUM";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "PO-DATE";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "O-ETC";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "DELIVERY";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "R-ETC";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "STAGE";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "MOLD-CODE";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "SEASON";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "MODEL";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "PART";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "O_MOLD-P";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "PICTURE";
            Column12.Name = "Column12";
            // 
            // Project_Class
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tableLayoutPanel1);
            Name = "Project_Class";
            Text = "Project";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpRows;
        private Button button1;
        private Label lb_judul;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}
