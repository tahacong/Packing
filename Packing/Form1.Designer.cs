namespace Packing
{
    partial class Form1
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
            this.dgvVanDon = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblSoMaHangTrenDon = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBienThe = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHang_SKU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVanDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picAnhMau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMau)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVanDon
            // 
            this.dgvVanDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVanDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVanDon.Location = new System.Drawing.Point(0, 0);
            this.dgvVanDon.Name = "dgvVanDon";
            this.dgvVanDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVanDon.Size = new System.Drawing.Size(604, 147);
            this.dgvVanDon.TabIndex = 3;
            this.dgvVanDon.SelectionChanged += new System.EventHandler(this.dgvVanDon_SelectionChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvVanDon);
            this.splitContainer1.Size = new System.Drawing.Size(604, 534);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblSoMaHangTrenDon);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.lblBienThe);
            this.splitContainer2.Panel1.Controls.Add(this.lblTenHang);
            this.splitContainer2.Panel1.Controls.Add(this.lblSoLuong);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.txtMaHang_SKU);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.txtVanDon);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.picAnhMau);
            this.splitContainer2.Size = new System.Drawing.Size(604, 383);
            this.splitContainer2.SplitterDistance = 396;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblSoMaHangTrenDon
            // 
            this.lblSoMaHangTrenDon.AutoSize = true;
            this.lblSoMaHangTrenDon.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoMaHangTrenDon.ForeColor = System.Drawing.Color.Lime;
            this.lblSoMaHangTrenDon.Location = new System.Drawing.Point(235, 320);
            this.lblSoMaHangTrenDon.Name = "lblSoMaHangTrenDon";
            this.lblSoMaHangTrenDon.Size = new System.Drawing.Size(31, 36);
            this.lblSoMaHangTrenDon.TabIndex = 13;
            this.lblSoMaHangTrenDon.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 36);
            this.label10.TabIndex = 12;
            this.label10.Text = "Mã hàng/Đơn:";
            // 
            // lblBienThe
            // 
            this.lblBienThe.AutoSize = true;
            this.lblBienThe.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienThe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBienThe.Location = new System.Drawing.Point(152, 148);
            this.lblBienThe.Name = "lblBienThe";
            this.lblBienThe.Size = new System.Drawing.Size(150, 36);
            this.lblBienThe.TabIndex = 11;
            this.lblBienThe.Text = "Size, Màu";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.ForeColor = System.Drawing.Color.Red;
            this.lblTenHang.Location = new System.Drawing.Point(97, 90);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(68, 36);
            this.lblTenHang.TabIndex = 10;
            this.lblTenHang.Text = "Tên";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSoLuong.Location = new System.Drawing.Point(166, 204);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(31, 36);
            this.lblSoLuong.TabIndex = 9;
            this.lblSoLuong.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Biến thể:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // txtMaHang_SKU
            // 
            this.txtMaHang_SKU.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang_SKU.Location = new System.Drawing.Point(113, 52);
            this.txtMaHang_SKU.Name = "txtMaHang_SKU";
            this.txtMaHang_SKU.ReadOnly = true;
            this.txtMaHang_SKU.Size = new System.Drawing.Size(661, 29);
            this.txtMaHang_SKU.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "SKU:";
            // 
            // txtVanDon
            // 
            this.txtVanDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVanDon.Location = new System.Drawing.Point(113, 17);
            this.txtVanDon.Name = "txtVanDon";
            this.txtVanDon.ReadOnly = true;
            this.txtVanDon.Size = new System.Drawing.Size(661, 29);
            this.txtVanDon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vận Đơn:";
            // 
            // picAnhMau
            // 
            this.picAnhMau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAnhMau.Location = new System.Drawing.Point(0, 0);
            this.picAnhMau.Name = "picAnhMau";
            this.picAnhMau.Size = new System.Drawing.Size(204, 383);
            this.picAnhMau.TabIndex = 0;
            this.picAnhMau.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 534);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanDon)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVanDon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox picAnhMau;
        private System.Windows.Forms.Label lblBienThe;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHang_SKU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVanDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoMaHangTrenDon;
        private System.Windows.Forms.Label label10;
    }
}

