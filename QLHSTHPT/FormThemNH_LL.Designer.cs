namespace QLHSTHPT
{
    partial class FormThemNH_LL
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
            System.Windows.Forms.Label mANHLabel;
            System.Windows.Forms.Label nAMBDLabel;
            System.Windows.Forms.Label nAMKTLabel;
            System.Windows.Forms.Label tENNHLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSkip = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTNH = new System.Windows.Forms.TextBox();
            this.textBoxNKT = new System.Windows.Forms.TextBox();
            this.textBoxNBD = new System.Windows.Forms.TextBox();
            this.textBoxMNH = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelEMNH = new System.Windows.Forms.Label();
            this.labelETNH = new System.Windows.Forms.Label();
            this.labelENBD = new System.Windows.Forms.Label();
            this.labelENKT = new System.Windows.Forms.Label();
            mANHLabel = new System.Windows.Forms.Label();
            nAMBDLabel = new System.Windows.Forms.Label();
            nAMKTLabel = new System.Windows.Forms.Label();
            tENNHLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANHLabel
            // 
            mANHLabel.AutoSize = true;
            mANHLabel.Location = new System.Drawing.Point(40, 32);
            mANHLabel.Name = "mANHLabel";
            mANHLabel.Size = new System.Drawing.Size(66, 13);
            mANHLabel.TabIndex = 0;
            mANHLabel.Text = "Mã năm học";
            // 
            // nAMBDLabel
            // 
            nAMBDLabel.AutoSize = true;
            nAMBDLabel.Location = new System.Drawing.Point(40, 75);
            nAMBDLabel.Name = "nAMBDLabel";
            nAMBDLabel.Size = new System.Drawing.Size(69, 13);
            nAMBDLabel.TabIndex = 4;
            nAMBDLabel.Text = "Năm bắt đầu";
            // 
            // nAMKTLabel
            // 
            nAMKTLabel.AutoSize = true;
            nAMKTLabel.Location = new System.Drawing.Point(268, 75);
            nAMKTLabel.Name = "nAMKTLabel";
            nAMKTLabel.Size = new System.Drawing.Size(71, 13);
            nAMKTLabel.TabIndex = 6;
            nAMKTLabel.Text = "Năm kết thúc";
            // 
            // tENNHLabel
            // 
            tENNHLabel.AutoSize = true;
            tENNHLabel.Location = new System.Drawing.Point(268, 32);
            tENNHLabel.Name = "tENNHLabel";
            tENNHLabel.Size = new System.Drawing.Size(70, 13);
            tENNHLabel.TabIndex = 7;
            tENNHLabel.Text = "Tên năm học";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 61);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÊM NĂM HỌC MỚI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonSkip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(717, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 61);
            this.panel2.TabIndex = 0;
            // 
            // buttonSkip
            // 
            this.buttonSkip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkip.Location = new System.Drawing.Point(0, 0);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(79, 57);
            this.buttonSkip.TabIndex = 1;
            this.buttonSkip.Text = "BỎ QUA";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
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
            this.tableAdapterManager.TOTRUONGBMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nAMHOCGridControl
            // 
            this.nAMHOCGridControl.DataSource = this.nAMHOCBindingSource;
            this.nAMHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nAMHOCGridControl.Location = new System.Drawing.Point(0, 61);
            this.nAMHOCGridControl.MainView = this.gridView1;
            this.nAMHOCGridControl.Name = "nAMHOCGridControl";
            this.nAMHOCGridControl.Size = new System.Drawing.Size(800, 271);
            this.nAMHOCGridControl.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelENKT);
            this.groupBox1.Controls.Add(this.labelENBD);
            this.groupBox1.Controls.Add(this.labelETNH);
            this.groupBox1.Controls.Add(this.labelEMNH);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(tENNHLabel);
            this.groupBox1.Controls.Add(this.textBoxTNH);
            this.groupBox1.Controls.Add(nAMKTLabel);
            this.groupBox1.Controls.Add(this.textBoxNKT);
            this.groupBox1.Controls.Add(nAMBDLabel);
            this.groupBox1.Controls.Add(this.textBoxNBD);
            this.groupBox1.Controls.Add(mANHLabel);
            this.groupBox1.Controls.Add(this.textBoxMNH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT NĂM HỌC";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tiếp tục";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTNH
            // 
            this.textBoxTNH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "TENNH", true));
            this.textBoxTNH.Location = new System.Drawing.Point(345, 29);
            this.textBoxTNH.Name = "textBoxTNH";
            this.textBoxTNH.Size = new System.Drawing.Size(195, 20);
            this.textBoxTNH.TabIndex = 8;
            // 
            // textBoxNKT
            // 
            this.textBoxNKT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "NAMKT", true));
            this.textBoxNKT.Location = new System.Drawing.Point(345, 72);
            this.textBoxNKT.Name = "textBoxNKT";
            this.textBoxNKT.Size = new System.Drawing.Size(100, 20);
            this.textBoxNKT.TabIndex = 7;
            // 
            // textBoxNBD
            // 
            this.textBoxNBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "NAMBD", true));
            this.textBoxNBD.Location = new System.Drawing.Point(115, 72);
            this.textBoxNBD.Name = "textBoxNBD";
            this.textBoxNBD.Size = new System.Drawing.Size(100, 20);
            this.textBoxNBD.TabIndex = 5;
            // 
            // textBoxMNH
            // 
            this.textBoxMNH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "MANH", true));
            this.textBoxMNH.Location = new System.Drawing.Point(115, 29);
            this.textBoxMNH.Name = "textBoxMNH";
            this.textBoxMNH.Size = new System.Drawing.Size(100, 20);
            this.textBoxMNH.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(719, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelEMNH
            // 
            this.labelEMNH.AutoSize = true;
            this.labelEMNH.ForeColor = System.Drawing.Color.Red;
            this.labelEMNH.Location = new System.Drawing.Point(112, 52);
            this.labelEMNH.Name = "labelEMNH";
            this.labelEMNH.Size = new System.Drawing.Size(0, 13);
            this.labelEMNH.TabIndex = 10;
            // 
            // labelETNH
            // 
            this.labelETNH.AutoSize = true;
            this.labelETNH.ForeColor = System.Drawing.Color.Red;
            this.labelETNH.Location = new System.Drawing.Point(342, 52);
            this.labelETNH.Name = "labelETNH";
            this.labelETNH.Size = new System.Drawing.Size(0, 13);
            this.labelETNH.TabIndex = 11;
            // 
            // labelENBD
            // 
            this.labelENBD.AutoSize = true;
            this.labelENBD.ForeColor = System.Drawing.Color.Red;
            this.labelENBD.Location = new System.Drawing.Point(112, 95);
            this.labelENBD.Name = "labelENBD";
            this.labelENBD.Size = new System.Drawing.Size(0, 13);
            this.labelENBD.TabIndex = 12;
            // 
            // labelENKT
            // 
            this.labelENKT.AutoSize = true;
            this.labelENKT.ForeColor = System.Drawing.Color.Red;
            this.labelENKT.Location = new System.Drawing.Point(342, 95);
            this.labelENKT.Name = "labelENKT";
            this.labelENKT.Size = new System.Drawing.Size(0, 13);
            this.labelENKT.TabIndex = 13;
            // 
            // FormThemNH_LL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nAMHOCGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "FormThemNH_LL";
            this.Text = "FormThemNH_LL";
            this.Load += new System.EventHandler(this.FormThemNH_LL_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSkip;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTNH;
        private System.Windows.Forms.TextBox textBoxNKT;
        private System.Windows.Forms.TextBox textBoxNBD;
        private System.Windows.Forms.TextBox textBoxMNH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelENKT;
        private System.Windows.Forms.Label labelENBD;
        private System.Windows.Forms.Label labelETNH;
        private System.Windows.Forms.Label labelEMNH;
    }
}