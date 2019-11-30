namespace QLHSTHPT
{
    partial class FormTimGV
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tENGVLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.qLHSTHPTDataSet = new QLHSTHPT.QLHSTHPTDataSet();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager();
            this.gIAOVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.labelTim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMaGV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            mAGVLabel = new System.Windows.Forms.Label();
            tENGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(109, 20);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(68, 13);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã giáo viên";
            // 
            // tENGVLabel
            // 
            tENGVLabel.AutoSize = true;
            tENGVLabel.Location = new System.Drawing.Point(109, 54);
            tENGVLabel.Name = "tENGVLabel";
            tENGVLabel.Size = new System.Drawing.Size(39, 13);
            tENGVLabel.TabIndex = 2;
            tENGVLabel.Text = "Họ tên";
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
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN MỘT GIÁO VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qLHSTHPTDataSet
            // 
            this.qLHSTHPTDataSet.DataSetName = "QLHSTHPTDataSet";
            this.qLHSTHPTDataSet.EnforceConstraints = false;
            this.qLHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.qLHSTHPTDataSet;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIENGridControl
            // 
            this.gIAOVIENGridControl.DataSource = this.gIAOVIENBindingSource;
            this.gIAOVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIAOVIENGridControl.Location = new System.Drawing.Point(0, 58);
            this.gIAOVIENGridControl.MainView = this.gridView1;
            this.gIAOVIENGridControl.Name = "gIAOVIENGridControl";
            this.gIAOVIENGridControl.Size = new System.Drawing.Size(738, 293);
            this.gIAOVIENGridControl.TabIndex = 2;
            this.gIAOVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colTENGV,
            this.colGIOITINH,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colDIENTHOAI,
            this.colTOMON,
            this.colNGHI});
            this.gridView1.GridControl = this.gIAOVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colTENGV
            // 
            this.colTENGV.FieldName = "TENGV";
            this.colTENGV.Name = "colTENGV";
            this.colTENGV.OptionsColumn.AllowEdit = false;
            this.colTENGV.Visible = true;
            this.colTENGV.VisibleIndex = 1;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.FieldName = "GIOITINH";
            this.colGIOITINH.Name = "colGIOITINH";
            this.colGIOITINH.OptionsColumn.AllowEdit = false;
            this.colGIOITINH.Visible = true;
            this.colGIOITINH.VisibleIndex = 2;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colDIENTHOAI
            // 
            this.colDIENTHOAI.FieldName = "DIENTHOAI";
            this.colDIENTHOAI.Name = "colDIENTHOAI";
            this.colDIENTHOAI.OptionsColumn.AllowEdit = false;
            this.colDIENTHOAI.Visible = true;
            this.colDIENTHOAI.VisibleIndex = 5;
            // 
            // colTOMON
            // 
            this.colTOMON.FieldName = "TOMON";
            this.colTOMON.Name = "colTOMON";
            this.colTOMON.OptionsColumn.AllowEdit = false;
            this.colTOMON.Visible = true;
            this.colTOMON.VisibleIndex = 6;
            // 
            // colNGHI
            // 
            this.colNGHI.FieldName = "NGHI";
            this.colNGHI.Name = "colNGHI";
            this.colNGHI.OptionsColumn.AllowEdit = false;
            this.colNGHI.Visible = true;
            this.colNGHI.VisibleIndex = 7;
            // 
            // textBoxTim
            // 
            this.textBoxTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTim.Location = new System.Drawing.Point(557, 65);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(169, 20);
            this.textBoxTim.TabIndex = 3;
            this.textBoxTim.TextChanged += new System.EventHandler(this.textBoxTim_TextChanged);
            this.textBoxTim.MouseHover += new System.EventHandler(this.textBoxTim_MouseHover);
            // 
            // labelTim
            // 
            this.labelTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTim.AutoSize = true;
            this.labelTim.Location = new System.Drawing.Point(502, 68);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(49, 13);
            this.labelTim.TabIndex = 4;
            this.labelTim.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBoxMaGV);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(tENGVLabel);
            this.panel1.Controls.Add(this.textBoxTen);
            this.panel1.Controls.Add(mAGVLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 94);
            this.panel1.TabIndex = 5;
            // 
            // textBoxMaGV
            // 
            this.textBoxMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "MAGV", true));
            this.textBoxMaGV.Location = new System.Drawing.Point(183, 17);
            this.textBoxMaGV.Name = "textBoxMaGV";
            this.textBoxMaGV.ReadOnly = true;
            this.textBoxMaGV.Size = new System.Drawing.Size(152, 20);
            this.textBoxMaGV.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTen
            // 
            this.textBoxTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "TENGV", true));
            this.textBoxTen.Location = new System.Drawing.Point(181, 51);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.ReadOnly = true;
            this.textBoxTen.Size = new System.Drawing.Size(154, 20);
            this.textBoxTen.TabIndex = 3;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTimGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.gIAOVIENGridControl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTimGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTimGV";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTimGV_FormClosing);
            this.Load += new System.EventHandler(this.FormTimGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QLHSTHPTDataSet qLHSTHPTDataSet;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private QLHSTHPTDataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private QLHSTHPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIAOVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENGV;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTOMON;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHI;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMaGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}