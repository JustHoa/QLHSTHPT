namespace QLHSTHPT
{
    partial class FormTimHS
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
            this.label1 = new System.Windows.Forms.Label();
            this.qLHSTHPTDataSet = new QLHSTHPT.QLHSTHPTDataSet();
            this.hOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCSINHTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.HOCSINHTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager();
            this.hOCSINHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tENHSTextBox = new System.Windows.Forms.TextBox();
            this.textBoxMaHS = new System.Windows.Forms.TextBox();
            this.colMAHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANTOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            mAHSLabel = new System.Windows.Forms.Label();
            tENHSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAHSLabel
            // 
            mAHSLabel.AutoSize = true;
            mAHSLabel.Location = new System.Drawing.Point(95, 22);
            mAHSLabel.Name = "mAHSLabel";
            mAHSLabel.Size = new System.Drawing.Size(65, 13);
            mAHSLabel.TabIndex = 0;
            mAHSLabel.Text = "Mã học sinh";
            // 
            // tENHSLabel
            // 
            tENHSLabel.AutoSize = true;
            tENHSLabel.Location = new System.Drawing.Point(95, 57);
            tENHSLabel.Name = "tENHSLabel";
            tENHSLabel.Size = new System.Drawing.Size(69, 13);
            tENHSLabel.TabIndex = 2;
            tENHSLabel.Text = "Tên học sinh";
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
            this.label1.TabIndex = 1;
            this.label1.Text = "CHỌN MỘT HỌC SINH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qLHSTHPTDataSet
            // 
            this.qLHSTHPTDataSet.DataSetName = "QLHSTHPTDataSet";
            this.qLHSTHPTDataSet.EnforceConstraints = false;
            this.qLHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCSINHBindingSource
            // 
            this.hOCSINHBindingSource.DataMember = "HOCSINH";
            this.hOCSINHBindingSource.DataSource = this.qLHSTHPTDataSet;
            // 
            // hOCSINHTableAdapter
            // 
            this.hOCSINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = this.hOCSINHTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCSINHGridControl
            // 
            this.hOCSINHGridControl.DataSource = this.hOCSINHBindingSource;
            this.hOCSINHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.hOCSINHGridControl.Location = new System.Drawing.Point(0, 58);
            this.hOCSINHGridControl.MainView = this.gridView1;
            this.hOCSINHGridControl.Name = "hOCSINHGridControl";
            this.hOCSINHGridControl.Size = new System.Drawing.Size(800, 297);
            this.hOCSINHGridControl.TabIndex = 2;
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
            this.colMALOP,
            this.colNGHIHOC});
            this.gridView1.GridControl = this.hOCSINHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(tENHSLabel);
            this.panel1.Controls.Add(this.tENHSTextBox);
            this.panel1.Controls.Add(mAHSLabel);
            this.panel1.Controls.Add(this.textBoxMaHS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tENHSTextBox
            // 
            this.tENHSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCSINHBindingSource, "TENHS", true));
            this.tENHSTextBox.Location = new System.Drawing.Point(170, 54);
            this.tENHSTextBox.Name = "tENHSTextBox";
            this.tENHSTextBox.ReadOnly = true;
            this.tENHSTextBox.Size = new System.Drawing.Size(141, 20);
            this.tENHSTextBox.TabIndex = 3;
            // 
            // textBoxMaHS
            // 
            this.textBoxMaHS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCSINHBindingSource, "MAHS", true));
            this.textBoxMaHS.Location = new System.Drawing.Point(170, 19);
            this.textBoxMaHS.Name = "textBoxMaHS";
            this.textBoxMaHS.ReadOnly = true;
            this.textBoxMaHS.Size = new System.Drawing.Size(141, 20);
            this.textBoxMaHS.TabIndex = 1;
            // 
            // colMAHS
            // 
            this.colMAHS.FieldName = "MAHS";
            this.colMAHS.Name = "colMAHS";
            this.colMAHS.Visible = true;
            this.colMAHS.VisibleIndex = 0;
            // 
            // colTENHS
            // 
            this.colTENHS.FieldName = "TENHS";
            this.colTENHS.Name = "colTENHS";
            this.colTENHS.Visible = true;
            this.colTENHS.VisibleIndex = 1;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 2;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.FieldName = "GIOITINH";
            this.colGIOITINH.Name = "colGIOITINH";
            this.colGIOITINH.Visible = true;
            this.colGIOITINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colDANTOC
            // 
            this.colDANTOC.FieldName = "DANTOC";
            this.colDANTOC.Name = "colDANTOC";
            this.colDANTOC.Visible = true;
            this.colDANTOC.VisibleIndex = 5;
            // 
            // colDIENTHOAI
            // 
            this.colDIENTHOAI.FieldName = "DIENTHOAI";
            this.colDIENTHOAI.Name = "colDIENTHOAI";
            this.colDIENTHOAI.Visible = true;
            this.colDIENTHOAI.VisibleIndex = 6;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 7;
            // 
            // colNGHIHOC
            // 
            this.colNGHIHOC.FieldName = "NGHIHOC";
            this.colNGHIHOC.Name = "colNGHIHOC";
            this.colNGHIHOC.Visible = true;
            this.colNGHIHOC.VisibleIndex = 8;
            // 
            // FormTimHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hOCSINHGridControl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTimHS";
            this.Text = "FormTimHS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTimHS_FormClosing);
            this.Load += new System.EventHandler(this.FormTimHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLHSTHPTDataSet qLHSTHPTDataSet;
        private System.Windows.Forms.BindingSource hOCSINHBindingSource;
        private QLHSTHPTDataSetTableAdapters.HOCSINHTableAdapter hOCSINHTableAdapter;
        private QLHSTHPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl hOCSINHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tENHSTextBox;
        private System.Windows.Forms.TextBox textBoxMaHS;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHS;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHS;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDANTOC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIHOC;
    }
}