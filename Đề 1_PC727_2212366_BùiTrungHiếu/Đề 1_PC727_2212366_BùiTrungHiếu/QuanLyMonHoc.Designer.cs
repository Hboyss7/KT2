namespace Đề_1_PC727_2212366_BùiTrungHiếu
{
    partial class QuanLyMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rd2015 = new System.Windows.Forms.RadioButton();
            this.rd2017 = new System.Windows.Forms.RadioButton();
            this.rd2020 = new System.Windows.Forms.RadioButton();
            this.rdMaTenMH = new System.Windows.Forms.RadioButton();
            this.rdSoTC = new System.Windows.Forms.RadioButton();
            this.dgvDSMH = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCaculator = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd2020);
            this.groupBox1.Controls.Add(this.rd2017);
            this.groupBox1.Controls.Add(this.rd2015);
            this.groupBox1.Controls.Add(this.rdAll);
            this.groupBox1.Location = new System.Drawing.Point(62, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chương trình đào tạo";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.dgvDSMH);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.rdSoTC);
            this.groupBox3.Controls.Add(this.rdMaTenMH);
            this.groupBox3.Location = new System.Drawing.Point(62, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(31, 44);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(56, 17);
            this.rdAll.TabIndex = 0;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Tất cả";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // rd2015
            // 
            this.rd2015.AutoSize = true;
            this.rd2015.Location = new System.Drawing.Point(190, 44);
            this.rd2015.Name = "rd2015";
            this.rd2015.Size = new System.Drawing.Size(49, 17);
            this.rd2015.TabIndex = 1;
            this.rd2015.TabStop = true;
            this.rd2015.Text = "2015";
            this.rd2015.UseVisualStyleBackColor = true;
            this.rd2015.CheckedChanged += new System.EventHandler(this.rd2015_CheckedChanged);
            // 
            // rd2017
            // 
            this.rd2017.AutoSize = true;
            this.rd2017.Location = new System.Drawing.Point(360, 44);
            this.rd2017.Name = "rd2017";
            this.rd2017.Size = new System.Drawing.Size(49, 17);
            this.rd2017.TabIndex = 2;
            this.rd2017.TabStop = true;
            this.rd2017.Text = "2017";
            this.rd2017.UseVisualStyleBackColor = true;
            this.rd2017.CheckedChanged += new System.EventHandler(this.rd2017_CheckedChanged);
            // 
            // rd2020
            // 
            this.rd2020.AutoSize = true;
            this.rd2020.Location = new System.Drawing.Point(528, 44);
            this.rd2020.Name = "rd2020";
            this.rd2020.Size = new System.Drawing.Size(49, 17);
            this.rd2020.TabIndex = 3;
            this.rd2020.TabStop = true;
            this.rd2020.Text = "2020";
            this.rd2020.UseVisualStyleBackColor = true;
            this.rd2020.CheckedChanged += new System.EventHandler(this.rd2020_CheckedChanged);
            // 
            // rdMaTenMH
            // 
            this.rdMaTenMH.AutoSize = true;
            this.rdMaTenMH.Location = new System.Drawing.Point(6, 42);
            this.rdMaTenMH.Name = "rdMaTenMH";
            this.rdMaTenMH.Size = new System.Drawing.Size(107, 17);
            this.rdMaTenMH.TabIndex = 0;
            this.rdMaTenMH.TabStop = true;
            this.rdMaTenMH.Text = "Theo mã/tên MH";
            this.rdMaTenMH.UseVisualStyleBackColor = true;
            // 
            // rdSoTC
            // 
            this.rdSoTC.AutoSize = true;
            this.rdSoTC.Location = new System.Drawing.Point(155, 42);
            this.rdSoTC.Name = "rdSoTC";
            this.rdSoTC.Size = new System.Drawing.Size(81, 17);
            this.rdSoTC.TabIndex = 1;
            this.rdSoTC.TabStop = true;
            this.rdSoTC.Text = "Theo số TC";
            this.rdSoTC.UseVisualStyleBackColor = true;
            // 
            // dgvDSMH
            // 
            this.dgvDSMH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMH.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDSMH.Location = new System.Drawing.Point(0, 34);
            this.dgvDSMH.Name = "dgvDSMH";
            this.dgvDSMH.Size = new System.Drawing.Size(776, 234);
            this.dgvDSMH.TabIndex = 0;
            this.dgvDSMH.DoubleClick += new System.EventHandler(this.dgvDSMH_DoubleClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(272, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(351, 20);
            this.txtTimKiem.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(695, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXoa,
            this.tsmView,
            this.tsmCaculator});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(302, 70);
            // 
            // tsmXoa
            // 
            this.tsmXoa.Name = "tsmXoa";
            this.tsmXoa.Size = new System.Drawing.Size(301, 22);
            this.tsmXoa.Text = "Xóa";
            // 
            // tsmView
            // 
            this.tsmView.Name = "tsmView";
            this.tsmView.Size = new System.Drawing.Size(301, 22);
            this.tsmView.Text = "Xem danh sách sinh viên đăng ký môn học";
            // 
            // tsmCaculator
            // 
            this.tsmCaculator.Name = "tsmCaculator";
            this.tsmCaculator.Size = new System.Drawing.Size(301, 22);
            this.tsmCaculator.Text = "Tổng số lượng SV đăng ký MH";
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd2020;
        private System.Windows.Forms.RadioButton rd2017;
        private System.Windows.Forms.RadioButton rd2015;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.DataGridView dgvDSMH;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdSoTC;
        private System.Windows.Forms.RadioButton rdMaTenMH;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmView;
        private System.Windows.Forms.ToolStripMenuItem tsmCaculator;
    }
}