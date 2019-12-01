﻿namespace QLHSTHPT
{
    partial class FormTimNH_CongViec
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
            System.Windows.Forms.Label nAMKTLabel;
            System.Windows.Forms.Label nAMBDLabel;
            System.Windows.Forms.Label mANHLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.nAMHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelTim = new System.Windows.Forms.Label();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.nAMKTTextBox = new System.Windows.Forms.TextBox();
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSTHPTDataSet = new QLHSTHPT.QLHSTHPTDataSet();
            this.nAMBDTextBox = new System.Windows.Forms.TextBox();
            this.textBoxMaNH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nAMHOCTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.NAMHOCTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager();
            nAMKTLabel = new System.Windows.Forms.Label();
            nAMBDLabel = new System.Windows.Forms.Label();
            mANHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nAMKTLabel
            // 
            nAMKTLabel.AutoSize = true;
            nAMKTLabel.Location = new System.Drawing.Point(279, 66);
            nAMKTLabel.Name = "nAMKTLabel";
            nAMKTLabel.Size = new System.Drawing.Size(71, 13);
            nAMKTLabel.TabIndex = 4;
            nAMKTLabel.Text = "Năm kết thúc";
            // 
            // nAMBDLabel
            // 
            nAMBDLabel.AutoSize = true;
            nAMBDLabel.Location = new System.Drawing.Point(279, 26);
            nAMBDLabel.Name = "nAMBDLabel";
            nAMBDLabel.Size = new System.Drawing.Size(69, 13);
            nAMBDLabel.TabIndex = 2;
            nAMBDLabel.Text = "Năm bắt đầu";
            // 
            // mANHLabel
            // 
            mANHLabel.AutoSize = true;
            mANHLabel.Location = new System.Drawing.Point(72, 46);
            mANHLabel.Name = "mANHLabel";
            mANHLabel.Size = new System.Drawing.Size(66, 13);
            mANHLabel.TabIndex = 0;
            mANHLabel.Text = "Mã năm học";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHỌN MỘT NĂM HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nAMHOCGridControl
            // 
            this.nAMHOCGridControl.DataSource = this.nAMHOCBindingSource;
            this.nAMHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nAMHOCGridControl.Location = new System.Drawing.Point(0, 58);
            this.nAMHOCGridControl.MainView = this.gridView1;
            this.nAMHOCGridControl.Name = "nAMHOCGridControl";
            this.nAMHOCGridControl.Size = new System.Drawing.Size(800, 281);
            this.nAMHOCGridControl.TabIndex = 3;
            this.nAMHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANH,
            this.colTENNH,
            this.colNAMBD,
            this.colNAMKT});
            this.gridView1.GridControl = this.nAMHOCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANH
            // 
            this.colMANH.FieldName = "MANH";
            this.colMANH.Name = "colMANH";
            this.colMANH.OptionsColumn.AllowEdit = false;
            this.colMANH.Visible = true;
            this.colMANH.VisibleIndex = 0;
            // 
            // colTENNH
            // 
            this.colTENNH.FieldName = "TENNH";
            this.colTENNH.Name = "colTENNH";
            this.colTENNH.OptionsColumn.AllowEdit = false;
            this.colTENNH.Visible = true;
            this.colTENNH.VisibleIndex = 1;
            // 
            // colNAMBD
            // 
            this.colNAMBD.FieldName = "NAMBD";
            this.colNAMBD.Name = "colNAMBD";
            this.colNAMBD.OptionsColumn.AllowEdit = false;
            this.colNAMBD.Visible = true;
            this.colNAMBD.VisibleIndex = 2;
            // 
            // colNAMKT
            // 
            this.colNAMKT.FieldName = "NAMKT";
            this.colNAMKT.Name = "colNAMKT";
            this.colNAMKT.OptionsColumn.AllowEdit = false;
            this.colNAMKT.Visible = true;
            this.colNAMKT.VisibleIndex = 3;
            // 
            // labelTim
            // 
            this.labelTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTim.AutoSize = true;
            this.labelTim.Location = new System.Drawing.Point(565, 68);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(49, 13);
            this.labelTim.TabIndex = 7;
            this.labelTim.Text = "Tìm kiếm";
            // 
            // textBoxTim
            // 
            this.textBoxTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTim.Location = new System.Drawing.Point(620, 65);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(168, 20);
            this.textBoxTim.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.nAMKTTextBox);
            this.panel1.Controls.Add(this.nAMBDTextBox);
            this.panel1.Controls.Add(this.textBoxMaNH);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(nAMKTLabel);
            this.panel1.Controls.Add(nAMBDLabel);
            this.panel1.Controls.Add(mANHLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 111);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nAMKTTextBox
            // 
            this.nAMKTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "NAMKT", true));
            this.nAMKTTextBox.Location = new System.Drawing.Point(354, 63);
            this.nAMKTTextBox.Name = "nAMKTTextBox";
            this.nAMKTTextBox.ReadOnly = true;
            this.nAMKTTextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMKTTextBox.TabIndex = 10;
            // 
            // nAMHOCBindingSource
            // 
            this.nAMHOCBindingSource.DataMember = "NAMHOC";
            this.nAMHOCBindingSource.DataSource = this.qLHSTHPTDataSet;
            // 
            // qLHSTHPTDataSet
            // 
            this.qLHSTHPTDataSet.DataSetName = "QLHSTHPTDataSet";
            this.qLHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nAMBDTextBox
            // 
            this.nAMBDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "NAMBD", true));
            this.nAMBDTextBox.Location = new System.Drawing.Point(354, 23);
            this.nAMBDTextBox.Name = "nAMBDTextBox";
            this.nAMBDTextBox.ReadOnly = true;
            this.nAMBDTextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMBDTextBox.TabIndex = 9;
            // 
            // textBoxMaNH
            // 
            this.textBoxMaNH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "MANH", true));
            this.textBoxMaNH.Location = new System.Drawing.Point(144, 43);
            this.textBoxMaNH.Name = "textBoxMaNH";
            this.textBoxMaNH.ReadOnly = true;
            this.textBoxMaNH.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaNH.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nAMHOCTableAdapter
            // 
            this.nAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = this.nAMHOCTableAdapter;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormTimNH_CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.nAMHOCGridControl);
            this.Controls.Add(this.label1);
            this.Name = "FormTimNH_CongViec";
            this.Text = "FormTimNH_CongViec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTimNH_CongViec_FormClosing);
            this.Load += new System.EventHandler(this.FormTimNH_CongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl nAMHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNH;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMKT;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private QLHSTHPTDataSet qLHSTHPTDataSet;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private QLHSTHPTDataSetTableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
        private QLHSTHPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nAMKTTextBox;
        private System.Windows.Forms.TextBox nAMBDTextBox;
        private System.Windows.Forms.TextBox textBoxMaNH;
        private System.Windows.Forms.Button button2;
    }
}