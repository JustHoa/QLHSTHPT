namespace QLHSTHPT
{
    partial class FormBangDiemHS
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelMaHK = new System.Windows.Forms.Label();
            this.labelMaNH = new System.Windows.Forms.Label();
            this.labelMaHS = new System.Windows.Forms.Label();
            this.buttonBrMaHK = new System.Windows.Forms.Button();
            this.buttonBrMaNH = new System.Windows.Forms.Button();
            this.buttonBrMaHS = new System.Windows.Forms.Button();
            this.textBoxMaHK = new System.Windows.Forms.TextBox();
            this.textBoxMaNH = new System.Windows.Forms.TextBox();
            this.textBoxMaHS = new System.Windows.Forms.TextBox();
            this.labelEMaHS = new System.Windows.Forms.Label();
            this.labelEMaNH = new System.Windows.Forms.Label();
            this.labelEMaHK = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỂM HỌC SINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 377);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelEMaHK);
            this.panel1.Controls.Add(this.labelEMaNH);
            this.panel1.Controls.Add(this.labelEMaHS);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.labelMaHK);
            this.panel1.Controls.Add(this.labelMaNH);
            this.panel1.Controls.Add(this.labelMaHS);
            this.panel1.Controls.Add(this.buttonBrMaHK);
            this.panel1.Controls.Add(this.buttonBrMaNH);
            this.panel1.Controls.Add(this.buttonBrMaHS);
            this.panel1.Controls.Add(this.textBoxMaHK);
            this.panel1.Controls.Add(this.textBoxMaNH);
            this.panel1.Controls.Add(this.textBoxMaHS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(163, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 371);
            this.panel1.TabIndex = 0;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(263, 177);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 22;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(167, 177);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelMaHK
            // 
            this.labelMaHK.AutoSize = true;
            this.labelMaHK.Location = new System.Drawing.Point(95, 132);
            this.labelMaHK.Name = "labelMaHK";
            this.labelMaHK.Size = new System.Drawing.Size(57, 13);
            this.labelMaHK.TabIndex = 20;
            this.labelMaHK.Text = "Mã học kỳ";
            // 
            // labelMaNH
            // 
            this.labelMaNH.AutoSize = true;
            this.labelMaNH.Location = new System.Drawing.Point(95, 86);
            this.labelMaNH.Name = "labelMaNH";
            this.labelMaNH.Size = new System.Drawing.Size(66, 13);
            this.labelMaNH.TabIndex = 19;
            this.labelMaNH.Text = "Mã năm học";
            // 
            // labelMaHS
            // 
            this.labelMaHS.AutoSize = true;
            this.labelMaHS.Location = new System.Drawing.Point(95, 42);
            this.labelMaHS.Name = "labelMaHS";
            this.labelMaHS.Size = new System.Drawing.Size(65, 13);
            this.labelMaHS.TabIndex = 18;
            this.labelMaHS.Text = "Mã học sinh";
            // 
            // buttonBrMaHK
            // 
            this.buttonBrMaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrMaHK.Location = new System.Drawing.Point(310, 128);
            this.buttonBrMaHK.Name = "buttonBrMaHK";
            this.buttonBrMaHK.Size = new System.Drawing.Size(28, 20);
            this.buttonBrMaHK.TabIndex = 17;
            this.buttonBrMaHK.Text = "...";
            this.buttonBrMaHK.UseVisualStyleBackColor = true;
            // 
            // buttonBrMaNH
            // 
            this.buttonBrMaNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrMaNH.Location = new System.Drawing.Point(310, 83);
            this.buttonBrMaNH.Name = "buttonBrMaNH";
            this.buttonBrMaNH.Size = new System.Drawing.Size(28, 20);
            this.buttonBrMaNH.TabIndex = 16;
            this.buttonBrMaNH.Text = "...";
            this.buttonBrMaNH.UseVisualStyleBackColor = true;
            // 
            // buttonBrMaHS
            // 
            this.buttonBrMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrMaHS.Location = new System.Drawing.Point(310, 39);
            this.buttonBrMaHS.Name = "buttonBrMaHS";
            this.buttonBrMaHS.Size = new System.Drawing.Size(28, 19);
            this.buttonBrMaHS.TabIndex = 15;
            this.buttonBrMaHS.Text = "...";
            this.buttonBrMaHS.UseVisualStyleBackColor = true;
            this.buttonBrMaHS.Click += new System.EventHandler(this.buttonBrMaHS_Click);
            // 
            // textBoxMaHK
            // 
            this.textBoxMaHK.Location = new System.Drawing.Point(167, 128);
            this.textBoxMaHK.Name = "textBoxMaHK";
            this.textBoxMaHK.Size = new System.Drawing.Size(137, 20);
            this.textBoxMaHK.TabIndex = 14;
            // 
            // textBoxMaNH
            // 
            this.textBoxMaNH.Location = new System.Drawing.Point(167, 83);
            this.textBoxMaNH.Name = "textBoxMaNH";
            this.textBoxMaNH.Size = new System.Drawing.Size(137, 20);
            this.textBoxMaNH.TabIndex = 13;
            // 
            // textBoxMaHS
            // 
            this.textBoxMaHS.Location = new System.Drawing.Point(167, 39);
            this.textBoxMaHS.Name = "textBoxMaHS";
            this.textBoxMaHS.Size = new System.Drawing.Size(137, 20);
            this.textBoxMaHS.TabIndex = 12;
            // 
            // labelEMaHS
            // 
            this.labelEMaHS.AutoSize = true;
            this.labelEMaHS.ForeColor = System.Drawing.Color.Red;
            this.labelEMaHS.Location = new System.Drawing.Point(164, 62);
            this.labelEMaHS.Name = "labelEMaHS";
            this.labelEMaHS.Size = new System.Drawing.Size(0, 13);
            this.labelEMaHS.TabIndex = 23;
            // 
            // labelEMaNH
            // 
            this.labelEMaNH.AutoSize = true;
            this.labelEMaNH.ForeColor = System.Drawing.Color.Red;
            this.labelEMaNH.Location = new System.Drawing.Point(164, 106);
            this.labelEMaNH.Name = "labelEMaNH";
            this.labelEMaNH.Size = new System.Drawing.Size(0, 13);
            this.labelEMaNH.TabIndex = 24;
            // 
            // labelEMaHK
            // 
            this.labelEMaHK.AutoSize = true;
            this.labelEMaHK.ForeColor = System.Drawing.Color.Red;
            this.labelEMaHK.Location = new System.Drawing.Point(164, 151);
            this.labelEMaHK.Name = "labelEMaHK";
            this.labelEMaHK.Size = new System.Drawing.Size(0, 13);
            this.labelEMaHK.TabIndex = 25;
            // 
            // FormBangDiemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FormBangDiemHS";
            this.Text = "FormBangDiemHS";
            this.Load += new System.EventHandler(this.FormBangDiemHS_Load);
            this.SizeChanged += new System.EventHandler(this.FormBangDiemHS_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelMaHK;
        private System.Windows.Forms.Label labelMaNH;
        private System.Windows.Forms.Label labelMaHS;
        private System.Windows.Forms.Button buttonBrMaHK;
        private System.Windows.Forms.Button buttonBrMaNH;
        private System.Windows.Forms.Button buttonBrMaHS;
        public System.Windows.Forms.TextBox textBoxMaHK;
        public System.Windows.Forms.TextBox textBoxMaNH;
        public System.Windows.Forms.TextBox textBoxMaHS;
        public System.Windows.Forms.Label labelEMaHK;
        public System.Windows.Forms.Label labelEMaNH;
        public System.Windows.Forms.Label labelEMaHS;
    }
}