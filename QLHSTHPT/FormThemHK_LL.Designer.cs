namespace QLHSTHPT
{
    partial class FormThemHK_LL
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
            System.Windows.Forms.Label mAHKLabel;
            System.Windows.Forms.Label tENHKLabel;
            System.Windows.Forms.Label tHANGBDLabel;
            System.Windows.Forms.Label nGAYBDLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.qLHSTHPTDataSet1 = new QLHSTHPT.QLHSTHPTDataSet1();
            this.hOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCKYTableAdapter = new QLHSTHPT.QLHSTHPTDataSet1TableAdapters.HOCKYTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSet1TableAdapters.TableAdapterManager();
            this.hOCKYGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHANGBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nGAYBDTextBox = new System.Windows.Forms.TextBox();
            this.tHANGBDTextBox = new System.Windows.Forms.TextBox();
            this.tENHKTextBox = new System.Windows.Forms.TextBox();
            this.mAHKTextBox = new System.Windows.Forms.TextBox();
            mAHKLabel = new System.Windows.Forms.Label();
            tENHKLabel = new System.Windows.Forms.Label();
            tHANGBDLabel = new System.Windows.Forms.Label();
            nGAYBDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAHKLabel
            // 
            mAHKLabel.AutoSize = true;
            mAHKLabel.Location = new System.Drawing.Point(49, 33);
            mAHKLabel.Name = "mAHKLabel";
            mAHKLabel.Size = new System.Drawing.Size(57, 13);
            mAHKLabel.TabIndex = 0;
            mAHKLabel.Text = "Mã học kỳ";
            // 
            // tENHKLabel
            // 
            tENHKLabel.AutoSize = true;
            tENHKLabel.Location = new System.Drawing.Point(279, 33);
            tENHKLabel.Name = "tENHKLabel";
            tENHKLabel.Size = new System.Drawing.Size(61, 13);
            tENHKLabel.TabIndex = 2;
            tENHKLabel.Text = "Tên học kỳ";
            // 
            // tHANGBDLabel
            // 
            tHANGBDLabel.AutoSize = true;
            tHANGBDLabel.Location = new System.Drawing.Point(49, 79);
            tHANGBDLabel.Name = "tHANGBDLabel";
            tHANGBDLabel.Size = new System.Drawing.Size(78, 13);
            tHANGBDLabel.TabIndex = 4;
            tHANGBDLabel.Text = "Tháng bắt đầu";
            // 
            // nGAYBDLabel
            // 
            nGAYBDLabel.AutoSize = true;
            nGAYBDLabel.Location = new System.Drawing.Point(279, 79);
            nGAYBDLabel.Name = "nGAYBDLabel";
            nGAYBDLabel.Size = new System.Drawing.Size(72, 13);
            nGAYBDLabel.TabIndex = 6;
            nGAYBDLabel.Text = "Ngày bắt đầu";
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
            this.panel1.TabIndex = 1;
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
            this.label1.Text = "THÊM HỌC KỲ MỚI";
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
            // 
            // qLHSTHPTDataSet1
            // 
            this.qLHSTHPTDataSet1.DataSetName = "QLHSTHPTDataSet1";
            this.qLHSTHPTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCKYBindingSource
            // 
            this.hOCKYBindingSource.DataMember = "HOCKY";
            this.hOCKYBindingSource.DataSource = this.qLHSTHPTDataSet1;
            // 
            // hOCKYTableAdapter
            // 
            this.hOCKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOMONTableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = this.hOCKYTableAdapter;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.HS_LOPTableAdapter = null;
            this.tableAdapterManager.KHOITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.TOTRUONGBMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCKYGridControl
            // 
            this.hOCKYGridControl.DataSource = this.hOCKYBindingSource;
            this.hOCKYGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.hOCKYGridControl.Location = new System.Drawing.Point(0, 61);
            this.hOCKYGridControl.MainView = this.gridView1;
            this.hOCKYGridControl.Name = "hOCKYGridControl";
            this.hOCKYGridControl.Size = new System.Drawing.Size(800, 271);
            this.hOCKYGridControl.TabIndex = 2;
            this.hOCKYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHK,
            this.colTENHK,
            this.colTHANGBD,
            this.colNGAYBD});
            this.gridView1.GridControl = this.hOCKYGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHK
            // 
            this.colMAHK.FieldName = "MAHK";
            this.colMAHK.Name = "colMAHK";
            this.colMAHK.OptionsColumn.AllowEdit = false;
            this.colMAHK.Visible = true;
            this.colMAHK.VisibleIndex = 0;
            // 
            // colTENHK
            // 
            this.colTENHK.FieldName = "TENHK";
            this.colTENHK.Name = "colTENHK";
            this.colTENHK.OptionsColumn.AllowEdit = false;
            this.colTENHK.Visible = true;
            this.colTENHK.VisibleIndex = 1;
            // 
            // colTHANGBD
            // 
            this.colTHANGBD.FieldName = "THANGBD";
            this.colTHANGBD.Name = "colTHANGBD";
            this.colTHANGBD.OptionsColumn.AllowEdit = false;
            this.colTHANGBD.Visible = true;
            this.colTHANGBD.VisibleIndex = 2;
            // 
            // colNGAYBD
            // 
            this.colNGAYBD.FieldName = "NGAYBD";
            this.colNGAYBD.Name = "colNGAYBD";
            this.colNGAYBD.OptionsColumn.AllowEdit = false;
            this.colNGAYBD.Visible = true;
            this.colNGAYBD.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(nGAYBDLabel);
            this.groupBox1.Controls.Add(this.nGAYBDTextBox);
            this.groupBox1.Controls.Add(tHANGBDLabel);
            this.groupBox1.Controls.Add(this.tHANGBDTextBox);
            this.groupBox1.Controls.Add(tENHKLabel);
            this.groupBox1.Controls.Add(this.tENHKTextBox);
            this.groupBox1.Controls.Add(mAHKLabel);
            this.groupBox1.Controls.Add(this.mAHKTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT HỌC KỲ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tiếp tục";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nGAYBDTextBox
            // 
            this.nGAYBDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "NGAYBD", true));
            this.nGAYBDTextBox.Location = new System.Drawing.Point(357, 76);
            this.nGAYBDTextBox.Name = "nGAYBDTextBox";
            this.nGAYBDTextBox.Size = new System.Drawing.Size(100, 20);
            this.nGAYBDTextBox.TabIndex = 7;
            // 
            // tHANGBDTextBox
            // 
            this.tHANGBDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "THANGBD", true));
            this.tHANGBDTextBox.Location = new System.Drawing.Point(133, 75);
            this.tHANGBDTextBox.Name = "tHANGBDTextBox";
            this.tHANGBDTextBox.Size = new System.Drawing.Size(100, 20);
            this.tHANGBDTextBox.TabIndex = 5;
            // 
            // tENHKTextBox
            // 
            this.tENHKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "TENHK", true));
            this.tENHKTextBox.Location = new System.Drawing.Point(357, 30);
            this.tENHKTextBox.Name = "tENHKTextBox";
            this.tENHKTextBox.Size = new System.Drawing.Size(186, 20);
            this.tENHKTextBox.TabIndex = 3;
            // 
            // mAHKTextBox
            // 
            this.mAHKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "MAHK", true));
            this.mAHKTextBox.Location = new System.Drawing.Point(133, 30);
            this.mAHKTextBox.Name = "mAHKTextBox";
            this.mAHKTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAHKTextBox.TabIndex = 1;
            // 
            // FormThemHK_LL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hOCKYGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "FormThemHK_LL";
            this.Text = "FormThemHK_LL";
            this.Load += new System.EventHandler(this.FormThemHK_LL_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSkip;
        private QLHSTHPTDataSet1 qLHSTHPTDataSet1;
        private System.Windows.Forms.BindingSource hOCKYBindingSource;
        private QLHSTHPTDataSet1TableAdapters.HOCKYTableAdapter hOCKYTableAdapter;
        private QLHSTHPTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl hOCKYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHK;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHK;
        private DevExpress.XtraGrid.Columns.GridColumn colTHANGBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nGAYBDTextBox;
        private System.Windows.Forms.TextBox tHANGBDTextBox;
        private System.Windows.Forms.TextBox tENHKTextBox;
        private System.Windows.Forms.TextBox mAHKTextBox;
    }
}