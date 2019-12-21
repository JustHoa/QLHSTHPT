namespace QLHSTHPT
{
    partial class FormTimNH_LHS
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
            System.Windows.Forms.Label tENNHLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.qLHSTHPTDataSet1 = new QLHSTHPT.QLHSTHPTDataSet1();
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAMHOCTableAdapter = new QLHSTHPT.QLHSTHPTDataSet1TableAdapters.NAMHOCTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSet1TableAdapters.TableAdapterManager();
            this.nAMHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.nAMKTTextBox = new System.Windows.Forms.TextBox();
            this.nAMBDTextBox = new System.Windows.Forms.TextBox();
            this.textBoxMaNH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTenNH = new System.Windows.Forms.TextBox();
            nAMKTLabel = new System.Windows.Forms.Label();
            nAMBDLabel = new System.Windows.Forms.Label();
            mANHLabel = new System.Windows.Forms.Label();
            tENNHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            mANHLabel.Location = new System.Drawing.Point(74, 26);
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
            this.label1.TabIndex = 3;
            this.label1.Text = "CHỌN MỘT NĂM HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qLHSTHPTDataSet1
            // 
            this.qLHSTHPTDataSet1.DataSetName = "QLHSTHPTDataSet1";
            this.qLHSTHPTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nAMHOCBindingSource
            // 
            this.nAMHOCBindingSource.DataMember = "NAMHOC";
            this.nAMHOCBindingSource.DataSource = this.qLHSTHPTDataSet1;
            // 
            // nAMHOCTableAdapter
            // 
            this.nAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOMONTableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.HS_LOPTableAdapter = null;
            this.tableAdapterManager.KHOITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = this.nAMHOCTableAdapter;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nAMHOCGridControl
            // 
            this.nAMHOCGridControl.DataSource = this.nAMHOCBindingSource;
            this.nAMHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nAMHOCGridControl.Location = new System.Drawing.Point(0, 58);
            this.nAMHOCGridControl.MainView = this.gridView1;
            this.nAMHOCGridControl.Name = "nAMHOCGridControl";
            this.nAMHOCGridControl.Size = new System.Drawing.Size(800, 278);
            this.nAMHOCGridControl.TabIndex = 4;
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
            // panel1
            // 
            this.panel1.Controls.Add(tENNHLabel);
            this.panel1.Controls.Add(this.textBoxTenNH);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.nAMKTTextBox);
            this.panel1.Controls.Add(this.nAMBDTextBox);
            this.panel1.Controls.Add(this.textBoxMaNH);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(nAMKTLabel);
            this.panel1.Controls.Add(nAMBDLabel);
            this.panel1.Controls.Add(mANHLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 105);
            this.panel1.TabIndex = 9;
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
            this.textBoxMaNH.Location = new System.Drawing.Point(146, 23);
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
            // tENNHLabel
            // 
            tENNHLabel.AutoSize = true;
            tENNHLabel.Location = new System.Drawing.Point(74, 66);
            tENNHLabel.Name = "tENNHLabel";
            tENNHLabel.Size = new System.Drawing.Size(70, 13);
            tENNHLabel.TabIndex = 11;
            tENNHLabel.Text = "Tên năm học";
            // 
            // textBoxTenNH
            // 
            this.textBoxTenNH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "TENNH", true));
            this.textBoxTenNH.Location = new System.Drawing.Point(146, 63);
            this.textBoxTenNH.Name = "textBoxTenNH";
            this.textBoxTenNH.ReadOnly = true;
            this.textBoxTenNH.Size = new System.Drawing.Size(100, 20);
            this.textBoxTenNH.TabIndex = 12;
            // 
            // FormTimNH_LHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nAMHOCGridControl);
            this.Controls.Add(this.label1);
            this.Name = "FormTimNH_LHS";
            this.Text = "FormTimNH_LHS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTimNH_LHS_FormClosing);
            this.Load += new System.EventHandler(this.FormTimNH_LHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLHSTHPTDataSet1 qLHSTHPTDataSet1;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private QLHSTHPTDataSet1TableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
        private QLHSTHPTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nAMHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNH;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMKT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nAMKTTextBox;
        private System.Windows.Forms.TextBox nAMBDTextBox;
        private System.Windows.Forms.TextBox textBoxMaNH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTenNH;
    }
}