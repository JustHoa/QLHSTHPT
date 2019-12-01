namespace QLHSTHPT
{
    partial class FormTimHK_PhanCong
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
            System.Windows.Forms.Label tHANGBDLabel;
            System.Windows.Forms.Label nGAYBDLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.qLHSTHPTDataSet = new QLHSTHPT.QLHSTHPTDataSet();
            this.hOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCKYTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.HOCKYTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager();
            this.hOCKYGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHANGBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nGAYBDTextBox = new System.Windows.Forms.TextBox();
            this.tHANGBDTextBox = new System.Windows.Forms.TextBox();
            this.textBoxMaHK = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            mAHKLabel = new System.Windows.Forms.Label();
            tHANGBDLabel = new System.Windows.Forms.Label();
            nGAYBDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAHKLabel
            // 
            mAHKLabel.AutoSize = true;
            mAHKLabel.Location = new System.Drawing.Point(66, 48);
            mAHKLabel.Name = "mAHKLabel";
            mAHKLabel.Size = new System.Drawing.Size(57, 13);
            mAHKLabel.TabIndex = 0;
            mAHKLabel.Text = "Mã học kỳ";
            // 
            // tHANGBDLabel
            // 
            tHANGBDLabel.AutoSize = true;
            tHANGBDLabel.Location = new System.Drawing.Point(266, 28);
            tHANGBDLabel.Name = "tHANGBDLabel";
            tHANGBDLabel.Size = new System.Drawing.Size(78, 13);
            tHANGBDLabel.TabIndex = 2;
            tHANGBDLabel.Text = "Tháng bắt đầu";
            // 
            // nGAYBDLabel
            // 
            nGAYBDLabel.AutoSize = true;
            nGAYBDLabel.Location = new System.Drawing.Point(266, 72);
            nGAYBDLabel.Name = "nGAYBDLabel";
            nGAYBDLabel.Size = new System.Drawing.Size(72, 13);
            nGAYBDLabel.TabIndex = 4;
            nGAYBDLabel.Text = "Ngày bắt đầu";
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
            this.label1.Size = new System.Drawing.Size(738, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHỌN MỘT HỌC KỲ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qLHSTHPTDataSet
            // 
            this.qLHSTHPTDataSet.DataSetName = "QLHSTHPTDataSet";
            this.qLHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCKYBindingSource
            // 
            this.hOCKYBindingSource.DataMember = "HOCKY";
            this.hOCKYBindingSource.DataSource = this.qLHSTHPTDataSet;
            // 
            // hOCKYTableAdapter
            // 
            this.hOCKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = this.hOCKYTableAdapter;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCKYGridControl
            // 
            this.hOCKYGridControl.DataSource = this.hOCKYBindingSource;
            this.hOCKYGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.hOCKYGridControl.Location = new System.Drawing.Point(0, 58);
            this.hOCKYGridControl.MainView = this.gridView1;
            this.hOCKYGridControl.Name = "hOCKYGridControl";
            this.hOCKYGridControl.Size = new System.Drawing.Size(738, 286);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(nGAYBDLabel);
            this.panel1.Controls.Add(this.nGAYBDTextBox);
            this.panel1.Controls.Add(tHANGBDLabel);
            this.panel1.Controls.Add(this.tHANGBDTextBox);
            this.panel1.Controls.Add(mAHKLabel);
            this.panel1.Controls.Add(this.textBoxMaHK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 120);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nGAYBDTextBox
            // 
            this.nGAYBDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "NGAYBD", true));
            this.nGAYBDTextBox.Location = new System.Drawing.Point(350, 69);
            this.nGAYBDTextBox.Name = "nGAYBDTextBox";
            this.nGAYBDTextBox.ReadOnly = true;
            this.nGAYBDTextBox.Size = new System.Drawing.Size(100, 20);
            this.nGAYBDTextBox.TabIndex = 5;
            // 
            // tHANGBDTextBox
            // 
            this.tHANGBDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "THANGBD", true));
            this.tHANGBDTextBox.Location = new System.Drawing.Point(350, 25);
            this.tHANGBDTextBox.Name = "tHANGBDTextBox";
            this.tHANGBDTextBox.ReadOnly = true;
            this.tHANGBDTextBox.Size = new System.Drawing.Size(100, 20);
            this.tHANGBDTextBox.TabIndex = 3;
            // 
            // textBoxMaHK
            // 
            this.textBoxMaHK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "MAHK", true));
            this.textBoxMaHK.Location = new System.Drawing.Point(129, 45);
            this.textBoxMaHK.Name = "textBoxMaHK";
            this.textBoxMaHK.ReadOnly = true;
            this.textBoxMaHK.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaHK.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTimHK_PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hOCKYGridControl);
            this.Controls.Add(this.label1);
            this.Name = "FormTimHK_PhanCong";
            this.Text = "FormTimHK";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTimHK_FormClosing);
            this.Load += new System.EventHandler(this.FormTimHK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLHSTHPTDataSet qLHSTHPTDataSet;
        private System.Windows.Forms.BindingSource hOCKYBindingSource;
        private QLHSTHPTDataSetTableAdapters.HOCKYTableAdapter hOCKYTableAdapter;
        private QLHSTHPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl hOCKYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHK;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHK;
        private DevExpress.XtraGrid.Columns.GridColumn colTHANGBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nGAYBDTextBox;
        private System.Windows.Forms.TextBox tHANGBDTextBox;
        private System.Windows.Forms.TextBox textBoxMaHK;
        private System.Windows.Forms.Button button2;
    }
}