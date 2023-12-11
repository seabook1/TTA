namespace WFQuanLyTrungTamTiengAnh
{
    partial class PhieuThuHocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuThuHocPhi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Lamlai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Trove = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sophieu = new System.Windows.Forms.TextBox();
            this.txt_lido = new System.Windows.Forms.TextBox();
            this.txt_sotien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.date_Ngaythu = new DevExpress.XtraEditors.DateEdit();
            this.cbx_khoahoc = new System.Windows.Forms.ComboBox();
            this.cbx_lophoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_nguoinop = new System.Windows.Forms.ComboBox();
            this.cbx_nguoithu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Ngaythu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Ngaythu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 247);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_Lamlai
            // 
            this.btn_Lamlai.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Lamlai.Appearance.Options.UseFont = true;
            this.btn_Lamlai.Image = ((System.Drawing.Image)(resources.GetObject("btn_Lamlai.Image")));
            this.btn_Lamlai.Location = new System.Drawing.Point(2, 503);
            this.btn_Lamlai.Name = "btn_Lamlai";
            this.btn_Lamlai.Size = new System.Drawing.Size(103, 33);
            this.btn_Lamlai.TabIndex = 2;
            this.btn_Lamlai.Text = "Làm lại";
            this.btn_Lamlai.Click += new System.EventHandler(this.btn_Lamlai_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_luu.Appearance.Options.UseFont = true;
            this.btn_luu.Image = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.save;
            this.btn_luu.Location = new System.Drawing.Point(123, 503);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(124, 33);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu phiếu thu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_Trove
            // 
            this.btn_Trove.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Trove.Appearance.Options.UseFont = true;
            this.btn_Trove.Image = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.back;
            this.btn_Trove.Location = new System.Drawing.Point(563, 503);
            this.btn_Trove.Name = "btn_Trove";
            this.btn_Trove.Size = new System.Drawing.Size(83, 33);
            this.btn_Trove.TabIndex = 5;
            this.btn_Trove.Text = "Trở về";
            this.btn_Trove.Click += new System.EventHandler(this.btn_Trove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người nộp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(33, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(44, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lý do:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(19, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Khóa học:";
            // 
            // txt_sophieu
            // 
            this.txt_sophieu.Location = new System.Drawing.Point(105, 26);
            this.txt_sophieu.Name = "txt_sophieu";
            this.txt_sophieu.Size = new System.Drawing.Size(185, 20);
            this.txt_sophieu.TabIndex = 7;
            // 
            // txt_lido
            // 
            this.txt_lido.Location = new System.Drawing.Point(104, 179);
            this.txt_lido.Name = "txt_lido";
            this.txt_lido.Size = new System.Drawing.Size(492, 20);
            this.txt_lido.TabIndex = 13;
            // 
            // txt_sotien
            // 
            this.txt_sotien.Location = new System.Drawing.Point(105, 141);
            this.txt_sotien.Name = "txt_sotien";
            this.txt_sotien.Size = new System.Drawing.Size(185, 20);
            this.txt_sotien.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(340, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Lớp học :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(336, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ngày thu :";
            // 
            // date_Ngaythu
            // 
            this.date_Ngaythu.EditValue = new System.DateTime(2016, 11, 20, 0, 0, 0, 0);
            this.date_Ngaythu.Location = new System.Drawing.Point(411, 26);
            this.date_Ngaythu.Name = "date_Ngaythu";
            this.date_Ngaythu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Ngaythu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Ngaythu.Size = new System.Drawing.Size(185, 20);
            this.date_Ngaythu.TabIndex = 24;
            // 
            // cbx_khoahoc
            // 
            this.cbx_khoahoc.FormattingEnabled = true;
            this.cbx_khoahoc.Location = new System.Drawing.Point(105, 101);
            this.cbx_khoahoc.Name = "cbx_khoahoc";
            this.cbx_khoahoc.Size = new System.Drawing.Size(185, 22);
            this.cbx_khoahoc.TabIndex = 25;
            this.cbx_khoahoc.SelectedIndexChanged += new System.EventHandler(this.cbx_khoahoc_SelectedIndexChanged);
            // 
            // cbx_lophoc
            // 
            this.cbx_lophoc.FormattingEnabled = true;
            this.cbx_lophoc.Location = new System.Drawing.Point(411, 101);
            this.cbx_lophoc.Name = "cbx_lophoc";
            this.cbx_lophoc.Size = new System.Drawing.Size(185, 22);
            this.cbx_lophoc.TabIndex = 26;
            this.cbx_lophoc.SelectedIndexChanged += new System.EventHandler(this.cbx_lophoc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(334, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Người thu:";
            // 
            // cbx_nguoinop
            // 
            this.cbx_nguoinop.FormattingEnabled = true;
            this.cbx_nguoinop.Location = new System.Drawing.Point(105, 62);
            this.cbx_nguoinop.Name = "cbx_nguoinop";
            this.cbx_nguoinop.Size = new System.Drawing.Size(185, 22);
            this.cbx_nguoinop.TabIndex = 29;
            // 
            // cbx_nguoithu
            // 
            this.cbx_nguoithu.FormattingEnabled = true;
            this.cbx_nguoithu.Location = new System.Drawing.Point(411, 62);
            this.cbx_nguoithu.Name = "cbx_nguoithu";
            this.cbx_nguoithu.Size = new System.Drawing.Size(185, 22);
            this.cbx_nguoithu.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbx_nguoithu);
            this.panel1.Controls.Add(this.cbx_nguoinop);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbx_lophoc);
            this.panel1.Controls.Add(this.cbx_khoahoc);
            this.panel1.Controls.Add(this.date_Ngaythu);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_sotien);
            this.panel1.Controls.Add(this.txt_lido);
            this.panel1.Controls.Add(this.txt_sophieu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 213);
            this.panel1.TabIndex = 0;
            // 
            // PhieuThuHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 540);
            this.Controls.Add(this.btn_Trove);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_Lamlai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhieuThuHocPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuThu";
            this.Load += new System.EventHandler(this.PhieuThuHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Ngaythu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Ngaythu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Lamlai;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_Trove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sophieu;
        private System.Windows.Forms.TextBox txt_lido;
        private System.Windows.Forms.TextBox txt_sotien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.DateEdit date_Ngaythu;
        private System.Windows.Forms.ComboBox cbx_khoahoc;
        private System.Windows.Forms.ComboBox cbx_lophoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_nguoinop;
        private System.Windows.Forms.ComboBox cbx_nguoithu;
        private System.Windows.Forms.Panel panel1;
    }
}