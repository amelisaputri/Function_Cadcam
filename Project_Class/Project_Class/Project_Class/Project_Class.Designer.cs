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
            panel2 = new Panel();
            button1 = new Button();
            lb_judul = new Label();
            panel3 = new Panel();
            dgv1 = new DataGridView();
            COL_SERIAL_NUM = new DataGridViewTextBoxColumn();
            COL_PO_DATE = new DataGridViewTextBoxColumn();
            COL_O_ETC = new DataGridViewTextBoxColumn();
            COL_DELIVERY = new DataGridViewTextBoxColumn();
            COL_R_ETC = new DataGridViewTextBoxColumn();
            COL_STAGE = new DataGridViewTextBoxColumn();
            COL_MOLD_CODE = new DataGridViewTextBoxColumn();
            COL_SEASON = new DataGridViewTextBoxColumn();
            COL_MODEL = new DataGridViewTextBoxColumn();
            COL_PART = new DataGridViewTextBoxColumn();
            COL_O_MOLD = new DataGridViewTextBoxColumn();
            COL_PICTURE = new DataGridViewTextBoxColumn();
            panelBandHeader = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.24228F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.75772F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.898491F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.10151F));
            tableLayoutPanel1.Size = new Size(1008, 729);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lb_judul);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 37);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(909, 8);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lb_judul
            // 
            lb_judul.Dock = DockStyle.Fill;
            lb_judul.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_judul.Location = new Point(0, 0);
            lb_judul.Name = "lb_judul";
            lb_judul.Size = new Size(1002, 37);
            lb_judul.TabIndex = 2;
            lb_judul.Text = "Project Cadcam";
            lb_judul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            tableLayoutPanel1.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(dgv1);
            panel3.Controls.Add(panelBandHeader);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(1002, 680);
            panel3.TabIndex = 6;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { COL_SERIAL_NUM, COL_PO_DATE, COL_O_ETC, COL_DELIVERY, COL_R_ETC, COL_STAGE, COL_MOLD_CODE, COL_SEASON, COL_MODEL, COL_PART, COL_O_MOLD, COL_PICTURE });
            dgv1.Location = new Point(0, 38);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(1002, 642);
            dgv1.TabIndex = 3;
            dgv1.ColumnWidthChanged += dgv1_ColumnWidthChanged;
            dgv1.Scroll += dgv1_Scroll;
            // 
            // COL_SERIAL_NUM
            // 
            COL_SERIAL_NUM.HeaderText = "SERIAL NUM";
            COL_SERIAL_NUM.Name = "COL_SERIAL_NUM";
            // 
            // COL_PO_DATE
            // 
            COL_PO_DATE.HeaderText = "PO-DATE";
            COL_PO_DATE.Name = "COL_PO_DATE";
            // 
            // COL_O_ETC
            // 
            COL_O_ETC.HeaderText = "O-ETC";
            COL_O_ETC.Name = "COL_O_ETC";
            // 
            // COL_DELIVERY
            // 
            COL_DELIVERY.HeaderText = "DELIVERY";
            COL_DELIVERY.Name = "COL_DELIVERY";
            // 
            // COL_R_ETC
            // 
            COL_R_ETC.HeaderText = "R-ETC";
            COL_R_ETC.Name = "COL_R_ETC";
            // 
            // COL_STAGE
            // 
            COL_STAGE.HeaderText = "STAGE";
            COL_STAGE.Name = "COL_STAGE";
            // 
            // COL_MOLD_CODE
            // 
            COL_MOLD_CODE.HeaderText = "MOLD-CODE";
            COL_MOLD_CODE.Name = "COL_MOLD_CODE";
            // 
            // COL_SEASON
            // 
            COL_SEASON.HeaderText = "SEASON";
            COL_SEASON.Name = "COL_SEASON";
            // 
            // COL_MODEL
            // 
            COL_MODEL.HeaderText = "MODEL";
            COL_MODEL.Name = "COL_MODEL";
            // 
            // COL_PART
            // 
            COL_PART.HeaderText = "PART";
            COL_PART.Name = "COL_PART";
            // 
            // COL_O_MOLD
            // 
            COL_O_MOLD.HeaderText = "O_MOLD-P";
            COL_O_MOLD.Name = "COL_O_MOLD";
            // 
            // COL_PICTURE
            // 
            COL_PICTURE.HeaderText = "PICTURE";
            COL_PICTURE.Name = "COL_PICTURE";
            // 
            // panelBandHeader
            // 
            panelBandHeader.Dock = DockStyle.Top;
            panelBandHeader.Location = new Point(0, 0);
            panelBandHeader.Name = "panelBandHeader";
            panelBandHeader.Size = new Size(1002, 32);
            panelBandHeader.TabIndex = 4;
            // 
            // Project_Class
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tableLayoutPanel1);
            Name = "Project_Class";
            Text = "Project";
            Load += Project_Class_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Label lb_judul;
        private DataGridView dgv1;
        private DataGridViewTextBoxColumn COL_SERIAL_NUM;
        private DataGridViewTextBoxColumn COL_PO_DATE;
        private DataGridViewTextBoxColumn COL_O_ETC;
        private DataGridViewTextBoxColumn COL_DELIVERY;
        private DataGridViewTextBoxColumn COL_R_ETC;
        private DataGridViewTextBoxColumn COL_STAGE;
        private DataGridViewTextBoxColumn COL_MOLD_CODE;
        private DataGridViewTextBoxColumn COL_SEASON;
        private DataGridViewTextBoxColumn COL_MODEL;
        private DataGridViewTextBoxColumn COL_PART;
        private DataGridViewTextBoxColumn COL_O_MOLD;
        private DataGridViewTextBoxColumn COL_PICTURE;
        private Panel panel2;
        private Panel panel3;
        private Panel panelBandHeader;
    }
}
