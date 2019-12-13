namespace QLHSTHPT
{
    partial class FormTimInfoHS
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
            System.Windows.Forms.Label mAHSLabel;
            System.Windows.Forms.Label tENHSLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label dANTOCLabel;
            System.Windows.Forms.Label dIENTHOAILabel;
            System.Windows.Forms.Label nGHIHOCLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.qLHSTHPTDataSet1 = new QLHSTHPT.QLHSTHPTDataSet1();
            this.hOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCSINHTableAdapter = new QLHSTHPT.QLHSTHPTDataSet1TableAdapters.HOCSINHTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSet1TableAdapters.TableAdapterManager();
            this.hOCSINHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBoxCT = new System.Windows.Forms.GroupBox();
            this.colMAHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANTOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBoxMHS = new System.Windows.Forms.TextBox();
            this.textBoxTenHS = new System.Windows.Forms.TextBox();
            this.textBoxGT = new System.Windows.Forms.TextBox();
            this.textBoxDC = new System.Windows.Forms.TextBox();
            this.textBoxDTo = new System.Windows.Forms.TextBox();
            this.textBoxDT = new System.Windows.Forms.TextBox();
            this.checkBoxNghi = new System.Windows.Forms.CheckBox();
            this.textBoxNS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            mAHSLabel = new System.Windows.Forms.Label();
            tENHSLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            dANTOCLabel = new System.Windows.Forms.Label();
            dIENTHOAILabel = new System.Windows.Forms.Label();
            nGHIHOCLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxCT.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(785, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHỌN MỘT HỌC SINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qLHSTHPTDataSet1
            // 
            this.qLHSTHPTDataSet1.DataSetName = "QLHSTHPTDataSet1";
            this.qLHSTHPTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCSINHBindingSource
            // 
            this.hOCSINHBindingSource.DataMember = "HOCSINH";
            this.hOCSINHBindingSource.DataSource = this.qLHSTHPTDataSet1;
            // 
            // hOCSINHTableAdapter
            // 
            this.hOCSINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOMONTableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = this.hOCSINHTableAdapter;
            this.tableAdapterManager.HS_LOPTableAdapter = null;
            this.tableAdapterManager.KHOITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.TOTRUONGBMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCSINHGridControl
            // 
            this.hOCSINHGridControl.DataSource = this.hOCSINHBindingSource;
            this.hOCSINHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.hOCSINHGridControl.Location = new System.Drawing.Point(0, 58);
            this.hOCSINHGridControl.MainView = this.gridView1;
            this.hOCSINHGridControl.Name = "hOCSINHGridControl";
            this.hOCSINHGridControl.Size = new System.Drawing.Size(785, 247);
            this.hOCSINHGridControl.TabIndex = 3;
            this.hOCSINHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHS,
            this.colTENHS,
            this.colNGAYSINH,
            this.colGIOITINH,
            this.colDIACHI,
            this.colDANTOC,
            this.colDIENTHOAI,
            this.colNGHIHOC});
            this.gridView1.GridControl = this.hOCSINHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBoxCT
            // 
            this.groupBoxCT.Controls.Add(this.button2);
            this.groupBoxCT.Controls.Add(this.button1);
            this.groupBoxCT.Controls.Add(nGAYSINHLabel);
            this.groupBoxCT.Controls.Add(this.textBoxNS);
            this.groupBoxCT.Controls.Add(nGHIHOCLabel);
            this.groupBoxCT.Controls.Add(this.checkBoxNghi);
            this.groupBoxCT.Controls.Add(dIENTHOAILabel);
            this.groupBoxCT.Controls.Add(this.textBoxDT);
            this.groupBoxCT.Controls.Add(dANTOCLabel);
            this.groupBoxCT.Controls.Add(this.textBoxDTo);
            this.groupBoxCT.Controls.Add(dIACHILabel);
            this.groupBoxCT.Controls.Add(this.textBoxDC);
            this.groupBoxCT.Controls.Add(gIOITINHLabel);
            this.groupBoxCT.Controls.Add(this.textBoxGT);
            this.groupBoxCT.Controls.Add(tENHSLabel);
            this.groupBoxCT.Controls.Add(this.textBoxTenHS);
            this.groupBoxCT.Controls.Add(mAHSLabel);
            this.groupBoxCT.Controls.Add(this.textBoxMHS);
            this.groupBoxCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCT.Location = new System.Drawing.Point(0, 305);
            this.groupBoxCT.Name = "groupBoxCT";
            this.groupBoxCT.Size = new System.Drawing.Size(785, 213);
            this.groupBoxCT.TabIndex = 4;
            this.groupBoxCT.TabStop = false;
            // 
            // colMAHS
            // 
            this.colMAHS.FieldName = "MAHS";
            this.colMAHS.Name = "colMAHS";
            this.colMAHS.OptionsColumn.AllowEdit = false;
            this.colMAHS.Visible = true;
            this.colMAHS.VisibleIndex = 0;
            // 
            // colTENHS
            // 
            this.colTENHS.FieldName = "TENHS";
            this.colTENHS.Name = "colTENHS";
            this.colTENHS.OptionsColumn.AllowEdit = false;
            this.colTENHS.Visible = true;
            this.colTENHS.VisibleIndex = 1;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 2;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.FieldName = "GIOITINH";
            this.colGIOITINH.Name = "colGIOITINH";
            this.colGIOITINH.OptionsColumn.AllowEdit = false;
            this.colGIOITINH.Visible = true;
            this.colGIOITINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colDANTOC
            // 
            this.colDANTOC.FieldName = "DANTOC";
            this.colDANTOC.Name = "colDANTOC";
            this.colDANTOC.OptionsColumn.AllowEdit = false;
            this.colDANTOC.Visible = true;
            this.colDANTOC.VisibleIndex = 5;
            // 
            // colDIENTHOAI
            // 
            this.colDIENTHOAI.FieldName = "DIENTHOAI";
            this.colDIENTHOAI.Name = "colDIENTHOAI";
            this.colDIENTHOAI.OptionsColumn.AllowEdit = false;
            this.colDIENTHOAI.Visible = true;
            this.colDIENTHOAI.VisibleIndex = 6;
            // 
            // colNGHIHOC
            // 
            this.colNGHIHOC.FieldName = "NGHIHOC";
            this.colNGHIHOC.Name = "colNGHIHOC";
            this.colNGHIHOC.OptionsColumn.AllowEdit = false;
            this.colNGHIHOC.Visible = true;
            this.colNGHIHOC.VisibleIndex = 7;
            // 
            // mAHSLabel
            // 
            mAHSLabel.AutoSize = true;
            mAHSLabel.Location = new System.Drawing.Point(77, 35);
            mAHSLabel.Name = "mAHSLabel";
            mAHSLabel.Size = new System.Drawing.Size(65, 13);
            mAHSLabel.TabIndex = 0;
            mAHSLabel.Text = "Mã học sinh";
            // 
            // textBoxMHS
            // 
            this.textBoxMHS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCSINHBindingSource, "MAHS", true));
            this.textBoxMHS.Location = new System.Drawing.Point(148, 32);
            this.textBoxMHS.Name = "textBoxMHS";
            this.textBoxMHS.ReadOnly = true;
            this.textBoxMHS.Size = new System.Drawing.Size(100, 20);
            this.textBoxMHS.TabIndex = 1;
            // 
            // tENHSLabel
            // 
            tENHSLabel.AutoSize = true;
            tENHSLabel.Location = new System.Drawing.Point(77, 75);
            tENHSLabel.Name = "tENHSLabel";
            tENHSLabel.Size = new System.Drawing.Size(39, 13);
            tENHSLabel.TabIndex = 2;
            tENHSLabel.Text = "Họ tên";
            // 
            // textBoxTenHS
            // 
            this.textBoxTenHS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCSINHBindingSource, "TENHS", true));
            this.textBoxTenHS.Location = new System.Drawing.Point(148, 72);
            this.textBoxTenHS.Name = "textBoxTenHS";
            this.textBoxTenHS.ReadOnly = true;
            this.textBoxTenHS.Size = new System.Drawing.Size(175, 20);
            this.textBoxTenHS.TabIndex = 3;
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(372, 75);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(47, 13);
            gIOITINHLabel.TabIndex = 4;
            gIOITINHLabel.Text = "Giới tính";
            // 
            // textBoxGT
            // 
            this.textBoxGT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCSINHBindingSource, "GIOITINH", true));
            this.textBoxGT.Location = new System.Drawing.Point(428, 72);
            this.textBoxGT.Name = "textBoxGT";
            this.textBoxGT.ReadOnly = true;
            this.textBoxGT.Size = new System.Drawing.Size(100, 20);
            this.textBoxGT.TabIndex = 5;
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(77, 116);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(40, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // textBoxDC
            // 
            this.textBoxDC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCSINHBindingSource, "DIACHI", true));
            this.textBoxDC.Location = new System.Drawing.Point(148, 113);
            this.textBoxDC.Name = "textBoxDC";
            this.textBoxDC.ReadOnly = true;
            this.textBoxDC.Size = new System.Drawing.Size(175, 20);
            this.textBoxDC.TabIndex = 7;
            // 
            // dANTOCLabel
            // 
            dANTOCLabel.AutoSize = true;
            dANTOCLabel.Location = new System.Drawing.Point(372, 35);
            dANTOCLabel.Name = "dANTOCLabel";
            dANTOCLabel.Size = new System.Drawing.Size(45, 13);
            dANTOCLabel.TabIndex = 8;
            dANTOCLabel.Text = "Dân tộc";
            // 
            // textBoxDTo
            // 
            this.textBoxDTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCSINHBindingSource, "DANTOC", true));
            this.textBoxDTo.Location = new System.Drawing.Point(428, 32);
            this.textBoxDTo.Name = "textBoxDTo";
            this.textBoxDTo.ReadOnly = true;
            this.textBoxDTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDTo.TabIndex = 9;
            // 
            // dIENTHOAILabel
            // 
            dIENTHOAILabel.AutoSize = true;
            dIENTHOAILabel.Location = new System.Drawing.Point(575, 35);
            dIENTHOAILabel.Name = "dIENTHOAILabel";
            dIENTHOAILabel.Size = new System.Drawing.Size(55, 13);
            dIENTHOAILabel.TabIndex = 10;
            dIENTHOAILabel.Text = "Điện thoại";
            // 
            // textBoxDT
            // 
            this.textBoxDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCSINHBindingSource, "DIENTHOAI", true));
            this.textBoxDT.Location = new System.Drawing.Point(636, 32);
            this.textBoxDT.Name = "textBoxDT";
            this.textBoxDT.ReadOnly = true;
            this.textBoxDT.Size = new System.Drawing.Size(105, 20);
            this.textBoxDT.TabIndex = 11;
            // 
            // nGHIHOCLabel
            // 
            nGHIHOCLabel.AutoSize = true;
            nGHIHOCLabel.Location = new System.Drawing.Point(580, 75);
            nGHIHOCLabel.Name = "nGHIHOCLabel";
            nGHIHOCLabel.Size = new System.Drawing.Size(50, 13);
            nGHIHOCLabel.TabIndex = 12;
            nGHIHOCLabel.Text = "Nghỉ học";
            // 
            // checkBoxNghi
            // 
            this.checkBoxNghi.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hOCSINHBindingSource, "NGHIHOC", true));
            this.checkBoxNghi.Enabled = false;
            this.checkBoxNghi.Location = new System.Drawing.Point(636, 70);
            this.checkBoxNghi.Name = "checkBoxNghi";
            this.checkBoxNghi.Size = new System.Drawing.Size(104, 24);
            this.checkBoxNghi.TabIndex = 13;
            this.checkBoxNghi.UseVisualStyleBackColor = true;
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(372, 116);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(54, 13);
            nGAYSINHLabel.TabIndex = 14;
            nGAYSINHLabel.Text = "Ngày sinh";
            // 
            // textBoxNS
            // 
            this.textBoxNS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCSINHBindingSource, "NGAYSINH", true));
            this.textBoxNS.Location = new System.Drawing.Point(428, 113);
            this.textBoxNS.Name = "textBoxNS";
            this.textBoxNS.ReadOnly = true;
            this.textBoxNS.Size = new System.Drawing.Size(100, 20);
            this.textBoxNS.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTimInfoHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 451);
            this.Controls.Add(this.groupBoxCT);
            this.Controls.Add(this.hOCSINHGridControl);
            this.Controls.Add(this.label1);
            this.Name = "FormTimInfoHS";
            this.Text = "FormTimInfoHS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTimInfoHS_FormClosing);
            this.Load += new System.EventHandler(this.FormTimInfoHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxCT.ResumeLayout(false);
            this.groupBoxCT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLHSTHPTDataSet1 qLHSTHPTDataSet1;
        private System.Windows.Forms.BindingSource hOCSINHBindingSource;
        private QLHSTHPTDataSet1TableAdapters.HOCSINHTableAdapter hOCSINHTableAdapter;
        private QLHSTHPTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl hOCSINHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHS;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHS;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDANTOC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIHOC;
        private System.Windows.Forms.GroupBox groupBoxCT;
        private System.Windows.Forms.TextBox textBoxNS;
        private System.Windows.Forms.CheckBox checkBoxNghi;
        private System.Windows.Forms.TextBox textBoxDT;
        private System.Windows.Forms.TextBox textBoxDTo;
        private System.Windows.Forms.TextBox textBoxDC;
        private System.Windows.Forms.TextBox textBoxGT;
        private System.Windows.Forms.TextBox textBoxTenHS;
        private System.Windows.Forms.TextBox textBoxMHS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}