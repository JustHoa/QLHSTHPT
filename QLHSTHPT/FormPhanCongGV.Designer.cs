namespace QLHSTHPT
{
    partial class FormPhanCongGV
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
            System.Windows.Forms.Label sOTIETLabel;
            System.Windows.Forms.Label mANHLabel;
            System.Windows.Forms.Label mAHKLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhanCongGV));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLHSTHPTDataSet = new QLHSTHPT.QLHSTHPTDataSet();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.MONHOCTableAdapter();
            this.pHANCONGGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHANCONGGVTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.PHANCONGGVTableAdapter();
            this.pHANCONGGVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxCT = new System.Windows.Forms.GroupBox();
            this.boxSoTiet = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMMH = new System.Windows.Forms.ComboBox();
            this.textBoxMaHK = new System.Windows.Forms.TextBox();
            this.textBoxMaNH = new System.Windows.Forms.TextBox();
            this.buttonTimNH = new System.Windows.Forms.Button();
            this.buttonTimHK = new System.Windows.Forms.Button();
            this.labelEMaHK = new System.Windows.Forms.Label();
            this.labelEMaNH = new System.Windows.Forms.Label();
            this.labelEMaLop = new System.Windows.Forms.Label();
            this.labelEMaGV = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTimLop = new System.Windows.Forms.Button();
            this.buttonTimGV = new System.Windows.Forms.Button();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.textBoxMaGV = new System.Windows.Forms.TextBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.labelTim = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            sOTIETLabel = new System.Windows.Forms.Label();
            mANHLabel = new System.Windows.Forms.Label();
            mAHKLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANCONGGVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANCONGGVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxSoTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTIETLabel
            // 
            sOTIETLabel.AutoSize = true;
            sOTIETLabel.Location = new System.Drawing.Point(569, 88);
            sOTIETLabel.Name = "sOTIETLabel";
            sOTIETLabel.Size = new System.Drawing.Size(37, 13);
            sOTIETLabel.TabIndex = 10;
            sOTIETLabel.Text = "Số tiết";
            // 
            // mANHLabel
            // 
            mANHLabel.AutoSize = true;
            mANHLabel.Location = new System.Drawing.Point(308, 44);
            mANHLabel.Name = "mANHLabel";
            mANHLabel.Size = new System.Drawing.Size(66, 13);
            mANHLabel.TabIndex = 8;
            mANHLabel.Text = "Mã năm học";
            // 
            // mAHKLabel
            // 
            mAHKLabel.AutoSize = true;
            mAHKLabel.Location = new System.Drawing.Point(308, 88);
            mAHKLabel.Name = "mAHKLabel";
            mAHKLabel.Size = new System.Drawing.Size(57, 13);
            mAHKLabel.TabIndex = 6;
            mAHKLabel.Text = "Mã học kỳ";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(569, 44);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(66, 13);
            mAMHLabel.TabIndex = 4;
            mAMHLabel.Text = "Mã môn học";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(43, 88);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(39, 13);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "Mã lớp";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(43, 44);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(68, 13);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã giáo viên";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Phân công GV";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Chỉnh sửa công việc";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa công việc";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Làm mới";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Lưu";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thoát";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(880, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 469);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(880, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 429);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(880, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 429);
            // 
            // qLHSTHPTDataSet
            // 
            this.qLHSTHPTDataSet.DataSetName = "QLHSTHPTDataSet";
            this.qLHSTHPTDataSet.EnforceConstraints = false;
            this.qLHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLHSTHPTDataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // pHANCONGGVBindingSource
            // 
            this.pHANCONGGVBindingSource.DataMember = "PHANCONGGV";
            this.pHANCONGGVBindingSource.DataSource = this.qLHSTHPTDataSet;
            // 
            // pHANCONGGVTableAdapter
            // 
            this.pHANCONGGVTableAdapter.ClearBeforeFill = true;
            // 
            // pHANCONGGVGridControl
            // 
            this.pHANCONGGVGridControl.DataSource = this.pHANCONGGVBindingSource;
            this.pHANCONGGVGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHANCONGGVGridControl.Location = new System.Drawing.Point(0, 40);
            this.pHANCONGGVGridControl.MainView = this.gridView1;
            this.pHANCONGGVGridControl.MenuManager = this.barManager1;
            this.pHANCONGGVGridControl.Name = "pHANCONGGVGridControl";
            this.pHANCONGGVGridControl.Size = new System.Drawing.Size(880, 257);
            this.pHANCONGGVGridControl.TabIndex = 10;
            this.pHANCONGGVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMALOP,
            this.colMAMH,
            this.colMAHK,
            this.colMANH,
            this.colSOTIET});
            this.gridView1.GridControl = this.pHANCONGGVGridControl;
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
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 1;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            // 
            // colMAHK
            // 
            this.colMAHK.FieldName = "MAHK";
            this.colMAHK.Name = "colMAHK";
            this.colMAHK.OptionsColumn.AllowEdit = false;
            this.colMAHK.Visible = true;
            this.colMAHK.VisibleIndex = 3;
            // 
            // colMANH
            // 
            this.colMANH.FieldName = "MANH";
            this.colMANH.Name = "colMANH";
            this.colMANH.OptionsColumn.AllowEdit = false;
            this.colMANH.Visible = true;
            this.colMANH.VisibleIndex = 4;
            // 
            // colSOTIET
            // 
            this.colSOTIET.FieldName = "SOTIET";
            this.colSOTIET.Name = "colSOTIET";
            this.colSOTIET.OptionsColumn.AllowEdit = false;
            this.colSOTIET.Visible = true;
            this.colSOTIET.VisibleIndex = 5;
            // 
            // groupBoxCT
            // 
            this.groupBoxCT.Controls.Add(this.boxSoTiet);
            this.groupBoxCT.Controls.Add(this.comboBoxMMH);
            this.groupBoxCT.Controls.Add(this.textBoxMaHK);
            this.groupBoxCT.Controls.Add(this.textBoxMaNH);
            this.groupBoxCT.Controls.Add(this.buttonTimNH);
            this.groupBoxCT.Controls.Add(this.buttonTimHK);
            this.groupBoxCT.Controls.Add(this.labelEMaHK);
            this.groupBoxCT.Controls.Add(this.labelEMaNH);
            this.groupBoxCT.Controls.Add(this.labelEMaLop);
            this.groupBoxCT.Controls.Add(this.labelEMaGV);
            this.groupBoxCT.Controls.Add(this.button2);
            this.groupBoxCT.Controls.Add(this.button1);
            this.groupBoxCT.Controls.Add(this.buttonTimLop);
            this.groupBoxCT.Controls.Add(this.buttonTimGV);
            this.groupBoxCT.Controls.Add(sOTIETLabel);
            this.groupBoxCT.Controls.Add(mANHLabel);
            this.groupBoxCT.Controls.Add(mAHKLabel);
            this.groupBoxCT.Controls.Add(mAMHLabel);
            this.groupBoxCT.Controls.Add(mALOPLabel);
            this.groupBoxCT.Controls.Add(this.textBoxMaLop);
            this.groupBoxCT.Controls.Add(mAGVLabel);
            this.groupBoxCT.Controls.Add(this.textBoxMaGV);
            this.groupBoxCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCT.Location = new System.Drawing.Point(0, 297);
            this.groupBoxCT.Name = "groupBoxCT";
            this.groupBoxCT.Size = new System.Drawing.Size(880, 172);
            this.groupBoxCT.TabIndex = 11;
            this.groupBoxCT.TabStop = false;
            this.groupBoxCT.Text = "PHÂN CÔNG GIÁO VIÊN";
            // 
            // boxSoTiet
            // 
            this.boxSoTiet.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pHANCONGGVBindingSource, "SOTIET", true));
            this.boxSoTiet.Location = new System.Drawing.Point(642, 85);
            this.boxSoTiet.Name = "boxSoTiet";
            this.boxSoTiet.Size = new System.Drawing.Size(64, 20);
            this.boxSoTiet.TabIndex = 25;
            // 
            // comboBoxMMH
            // 
            this.comboBoxMMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANCONGGVBindingSource, "MAMH", true));
            this.comboBoxMMH.DataSource = this.mONHOCBindingSource;
            this.comboBoxMMH.DisplayMember = "TENMH";
            this.comboBoxMMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMMH.FormattingEnabled = true;
            this.comboBoxMMH.Location = new System.Drawing.Point(641, 40);
            this.comboBoxMMH.Name = "comboBoxMMH";
            this.comboBoxMMH.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMMH.TabIndex = 24;
            this.comboBoxMMH.ValueMember = "MAMH";
            // 
            // textBoxMaHK
            // 
            this.textBoxMaHK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANCONGGVBindingSource, "MAHK", true));
            this.textBoxMaHK.Location = new System.Drawing.Point(380, 85);
            this.textBoxMaHK.Name = "textBoxMaHK";
            this.textBoxMaHK.Size = new System.Drawing.Size(121, 20);
            this.textBoxMaHK.TabIndex = 23;
            // 
            // textBoxMaNH
            // 
            this.textBoxMaNH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANCONGGVBindingSource, "MANH", true));
            this.textBoxMaNH.Location = new System.Drawing.Point(380, 41);
            this.textBoxMaNH.Name = "textBoxMaNH";
            this.textBoxMaNH.Size = new System.Drawing.Size(121, 20);
            this.textBoxMaNH.TabIndex = 22;
            // 
            // buttonTimNH
            // 
            this.buttonTimNH.Location = new System.Drawing.Point(507, 41);
            this.buttonTimNH.Name = "buttonTimNH";
            this.buttonTimNH.Size = new System.Drawing.Size(25, 20);
            this.buttonTimNH.TabIndex = 21;
            this.buttonTimNH.Text = "...";
            this.buttonTimNH.UseVisualStyleBackColor = true;
            this.buttonTimNH.Click += new System.EventHandler(this.buttonTimNH_Click);
            // 
            // buttonTimHK
            // 
            this.buttonTimHK.Location = new System.Drawing.Point(507, 85);
            this.buttonTimHK.Name = "buttonTimHK";
            this.buttonTimHK.Size = new System.Drawing.Size(25, 20);
            this.buttonTimHK.TabIndex = 20;
            this.buttonTimHK.Text = "...";
            this.buttonTimHK.UseVisualStyleBackColor = true;
            this.buttonTimHK.Click += new System.EventHandler(this.buttonTimHK_Click);
            // 
            // labelEMaHK
            // 
            this.labelEMaHK.AutoSize = true;
            this.labelEMaHK.ForeColor = System.Drawing.Color.Red;
            this.labelEMaHK.Location = new System.Drawing.Point(377, 108);
            this.labelEMaHK.Name = "labelEMaHK";
            this.labelEMaHK.Size = new System.Drawing.Size(0, 13);
            this.labelEMaHK.TabIndex = 19;
            // 
            // labelEMaNH
            // 
            this.labelEMaNH.AutoSize = true;
            this.labelEMaNH.ForeColor = System.Drawing.Color.Red;
            this.labelEMaNH.Location = new System.Drawing.Point(377, 65);
            this.labelEMaNH.Name = "labelEMaNH";
            this.labelEMaNH.Size = new System.Drawing.Size(0, 13);
            this.labelEMaNH.TabIndex = 18;
            // 
            // labelEMaLop
            // 
            this.labelEMaLop.AutoSize = true;
            this.labelEMaLop.ForeColor = System.Drawing.Color.Red;
            this.labelEMaLop.Location = new System.Drawing.Point(112, 108);
            this.labelEMaLop.Name = "labelEMaLop";
            this.labelEMaLop.Size = new System.Drawing.Size(0, 13);
            this.labelEMaLop.TabIndex = 17;
            // 
            // labelEMaGV
            // 
            this.labelEMaGV.AutoSize = true;
            this.labelEMaGV.ForeColor = System.Drawing.Color.Red;
            this.labelEMaGV.Location = new System.Drawing.Point(116, 65);
            this.labelEMaGV.Name = "labelEMaGV";
            this.labelEMaGV.Size = new System.Drawing.Size(0, 13);
            this.labelEMaGV.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTimLop
            // 
            this.buttonTimLop.Location = new System.Drawing.Point(246, 85);
            this.buttonTimLop.Name = "buttonTimLop";
            this.buttonTimLop.Size = new System.Drawing.Size(25, 20);
            this.buttonTimLop.TabIndex = 13;
            this.buttonTimLop.Text = "...";
            this.buttonTimLop.UseVisualStyleBackColor = true;
            this.buttonTimLop.Click += new System.EventHandler(this.buttonTimLop_Click);
            // 
            // buttonTimGV
            // 
            this.buttonTimGV.Location = new System.Drawing.Point(246, 42);
            this.buttonTimGV.Name = "buttonTimGV";
            this.buttonTimGV.Size = new System.Drawing.Size(25, 20);
            this.buttonTimGV.TabIndex = 12;
            this.buttonTimGV.Text = "...";
            this.buttonTimGV.UseVisualStyleBackColor = true;
            this.buttonTimGV.Click += new System.EventHandler(this.buttonTimGV_Click);
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANCONGGVBindingSource, "MALOP", true));
            this.textBoxMaLop.Location = new System.Drawing.Point(115, 85);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(125, 20);
            this.textBoxMaLop.TabIndex = 3;
            // 
            // textBoxMaGV
            // 
            this.textBoxMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHANCONGGVBindingSource, "MAGV", true));
            this.textBoxMaGV.Location = new System.Drawing.Point(115, 42);
            this.textBoxMaGV.Name = "textBoxMaGV";
            this.textBoxMaGV.Size = new System.Drawing.Size(125, 20);
            this.textBoxMaGV.TabIndex = 1;
            // 
            // textBoxTim
            // 
            this.textBoxTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTim.Location = new System.Drawing.Point(684, 47);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(184, 20);
            this.textBoxTim.TabIndex = 16;
            this.textBoxTim.TextChanged += new System.EventHandler(this.textBoxTim_TextChanged);
            this.textBoxTim.MouseHover += new System.EventHandler(this.textBoxTim_MouseHover);
            // 
            // labelTim
            // 
            this.labelTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTim.AutoSize = true;
            this.labelTim.Location = new System.Drawing.Point(629, 50);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(49, 13);
            this.labelTim.TabIndex = 17;
            this.labelTim.Text = "Tìm kiếm";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FormPhanCongGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(880, 469);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.groupBoxCT);
            this.Controls.Add(this.pHANCONGGVGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormPhanCongGV";
            this.Text = "FormPhanCongCV";
            this.Load += new System.EventHandler(this.FormPhanCongGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANCONGGVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANCONGGVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxCT.ResumeLayout(false);
            this.groupBoxCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxSoTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLHSTHPTDataSet qLHSTHPTDataSet;
        private QLHSTHPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLHSTHPTDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource pHANCONGGVBindingSource;
        private QLHSTHPTDataSetTableAdapters.PHANCONGGVTableAdapter pHANCONGGVTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxCT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonTimLop;
        private System.Windows.Forms.Button buttonTimGV;
        public System.Windows.Forms.TextBox textBoxMaLop;
        public System.Windows.Forms.TextBox textBoxMaGV;
        private DevExpress.XtraGrid.GridControl pHANCONGGVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHK;
        private DevExpress.XtraGrid.Columns.GridColumn colMANH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Button buttonTimNH;
        private System.Windows.Forms.Button buttonTimHK;
        public System.Windows.Forms.TextBox textBoxMaHK;
        public System.Windows.Forms.TextBox textBoxMaNH;
        private System.Windows.Forms.NumericUpDown boxSoTiet;
        private System.Windows.Forms.ComboBox comboBoxMMH;
        public System.Windows.Forms.Label labelEMaHK;
        public System.Windows.Forms.Label labelEMaNH;
        public System.Windows.Forms.Label labelEMaLop;
        public System.Windows.Forms.Label labelEMaGV;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}