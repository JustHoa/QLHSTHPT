namespace QLHSTHPT
{
    partial class FormLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAHKLabel;
            System.Windows.Forms.Label mANHLabel;
            System.Windows.Forms.Label bANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLop));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLHSTHPTDataSet = new QLHSTHPT.QLHSTHPTDataSet();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxCT = new System.Windows.Forms.GroupBox();
            this.labelEMaNH = new System.Windows.Forms.Label();
            this.labelEMaHK = new System.Windows.Forms.Label();
            this.labelETenLop = new System.Windows.Forms.Label();
            this.labelEBan = new System.Windows.Forms.Label();
            this.labelEMaLop = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxBan = new System.Windows.Forms.ComboBox();
            this.textBoxMaNH = new System.Windows.Forms.TextBox();
            this.textBoxMaHK = new System.Windows.Forms.TextBox();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.labelTim = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAHKLabel = new System.Windows.Forms.Label();
            mANHLabel = new System.Windows.Forms.Label();
            bANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(43, 36);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(39, 13);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(43, 79);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(43, 13);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // mAHKLabel
            // 
            mAHKLabel.AutoSize = true;
            mAHKLabel.Location = new System.Drawing.Point(391, 36);
            mAHKLabel.Name = "mAHKLabel";
            mAHKLabel.Size = new System.Drawing.Size(57, 13);
            mAHKLabel.TabIndex = 4;
            mAHKLabel.Text = "Mã học kỳ";
            // 
            // mANHLabel
            // 
            mANHLabel.AutoSize = true;
            mANHLabel.Location = new System.Drawing.Point(391, 79);
            mANHLabel.Name = "mANHLabel";
            mANHLabel.Size = new System.Drawing.Size(66, 13);
            mANHLabel.TabIndex = 6;
            mANHLabel.Text = "Mã năm học";
            // 
            // bANLabel
            // 
            bANLabel.AutoSize = true;
            bANLabel.Location = new System.Drawing.Point(222, 36);
            bANLabel.Name = "bANLabel";
            bANLabel.Size = new System.Drawing.Size(26, 13);
            bANLabel.TabIndex = 8;
            bANLabel.Text = "Ban";
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
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Làm mới";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lưu";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(800, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // qLHSTHPTDataSet
            // 
            this.qLHSTHPTDataSet.DataSetName = "QLHSTHPTDataSet";
            this.qLHSTHPTDataSet.EnforceConstraints = false;
            this.qLHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLHSTHPTDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.lOPBindingSource;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOPGridControl.Location = new System.Drawing.Point(0, 40);
            this.lOPGridControl.MainView = this.gridView1;
            this.lOPGridControl.MenuManager = this.barManager1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(800, 220);
            this.lOPGridControl.TabIndex = 11;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAHK,
            this.colMANH,
            this.colBAN});
            this.gridView1.GridControl = this.lOPGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colMAHK
            // 
            this.colMAHK.FieldName = "MAHK";
            this.colMAHK.Name = "colMAHK";
            this.colMAHK.OptionsColumn.AllowEdit = false;
            this.colMAHK.Visible = true;
            this.colMAHK.VisibleIndex = 2;
            // 
            // colMANH
            // 
            this.colMANH.FieldName = "MANH";
            this.colMANH.Name = "colMANH";
            this.colMANH.OptionsColumn.AllowEdit = false;
            this.colMANH.Visible = true;
            this.colMANH.VisibleIndex = 3;
            // 
            // colBAN
            // 
            this.colBAN.FieldName = "BAN";
            this.colBAN.Name = "colBAN";
            this.colBAN.OptionsColumn.AllowEdit = false;
            this.colBAN.Visible = true;
            this.colBAN.VisibleIndex = 4;
            // 
            // groupBoxCT
            // 
            this.groupBoxCT.Controls.Add(this.labelEMaNH);
            this.groupBoxCT.Controls.Add(this.labelEMaHK);
            this.groupBoxCT.Controls.Add(this.labelETenLop);
            this.groupBoxCT.Controls.Add(this.labelEBan);
            this.groupBoxCT.Controls.Add(this.labelEMaLop);
            this.groupBoxCT.Controls.Add(this.button2);
            this.groupBoxCT.Controls.Add(this.button1);
            this.groupBoxCT.Controls.Add(bANLabel);
            this.groupBoxCT.Controls.Add(this.comboBoxBan);
            this.groupBoxCT.Controls.Add(mANHLabel);
            this.groupBoxCT.Controls.Add(this.textBoxMaNH);
            this.groupBoxCT.Controls.Add(mAHKLabel);
            this.groupBoxCT.Controls.Add(this.textBoxMaHK);
            this.groupBoxCT.Controls.Add(tENLOPLabel);
            this.groupBoxCT.Controls.Add(this.textBoxTenLop);
            this.groupBoxCT.Controls.Add(mALOPLabel);
            this.groupBoxCT.Controls.Add(this.textBoxMaLop);
            this.groupBoxCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCT.Location = new System.Drawing.Point(0, 260);
            this.groupBoxCT.Name = "groupBoxCT";
            this.groupBoxCT.Size = new System.Drawing.Size(800, 190);
            this.groupBoxCT.TabIndex = 12;
            this.groupBoxCT.TabStop = false;
            this.groupBoxCT.Text = "CHI TIẾT LỚP";
            // 
            // labelEMaNH
            // 
            this.labelEMaNH.AutoSize = true;
            this.labelEMaNH.ForeColor = System.Drawing.Color.Red;
            this.labelEMaNH.Location = new System.Drawing.Point(460, 99);
            this.labelEMaNH.Name = "labelEMaNH";
            this.labelEMaNH.Size = new System.Drawing.Size(0, 13);
            this.labelEMaNH.TabIndex = 16;
            // 
            // labelEMaHK
            // 
            this.labelEMaHK.AutoSize = true;
            this.labelEMaHK.ForeColor = System.Drawing.Color.Red;
            this.labelEMaHK.Location = new System.Drawing.Point(460, 55);
            this.labelEMaHK.Name = "labelEMaHK";
            this.labelEMaHK.Size = new System.Drawing.Size(0, 13);
            this.labelEMaHK.TabIndex = 15;
            // 
            // labelETenLop
            // 
            this.labelETenLop.AutoSize = true;
            this.labelETenLop.ForeColor = System.Drawing.Color.Red;
            this.labelETenLop.Location = new System.Drawing.Point(89, 99);
            this.labelETenLop.Name = "labelETenLop";
            this.labelETenLop.Size = new System.Drawing.Size(0, 13);
            this.labelETenLop.TabIndex = 14;
            // 
            // labelEBan
            // 
            this.labelEBan.AutoSize = true;
            this.labelEBan.ForeColor = System.Drawing.Color.Red;
            this.labelEBan.Location = new System.Drawing.Point(251, 55);
            this.labelEBan.Name = "labelEBan";
            this.labelEBan.Size = new System.Drawing.Size(0, 13);
            this.labelEBan.TabIndex = 13;
            // 
            // labelEMaLop
            // 
            this.labelEMaLop.AutoSize = true;
            this.labelEMaLop.ForeColor = System.Drawing.Color.Red;
            this.labelEMaLop.Location = new System.Drawing.Point(89, 56);
            this.labelEMaLop.Name = "labelEMaLop";
            this.labelEMaLop.Size = new System.Drawing.Size(0, 13);
            this.labelEMaLop.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(390, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxBan
            // 
            this.comboBoxBan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "BAN", true));
            this.comboBoxBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBan.FormattingEnabled = true;
            this.comboBoxBan.Items.AddRange(new object[] {
            "Ban cơ bản",
            "Ban nâng cao"});
            this.comboBoxBan.Location = new System.Drawing.Point(254, 33);
            this.comboBoxBan.Name = "comboBoxBan";
            this.comboBoxBan.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBan.TabIndex = 9;
            // 
            // textBoxMaNH
            // 
            this.textBoxMaNH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MANH", true));
            this.textBoxMaNH.Location = new System.Drawing.Point(463, 76);
            this.textBoxMaNH.Name = "textBoxMaNH";
            this.textBoxMaNH.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaNH.TabIndex = 7;
            // 
            // textBoxMaHK
            // 
            this.textBoxMaHK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MAHK", true));
            this.textBoxMaHK.Location = new System.Drawing.Point(463, 33);
            this.textBoxMaHK.Name = "textBoxMaHK";
            this.textBoxMaHK.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaHK.TabIndex = 5;
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.textBoxTenLop.Location = new System.Drawing.Point(92, 76);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(262, 20);
            this.textBoxTenLop.TabIndex = 3;
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.textBoxMaLop.Enabled = false;
            this.textBoxMaLop.Location = new System.Drawing.Point(92, 33);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaLop.TabIndex = 1;
            // 
            // textBoxTim
            // 
            this.textBoxTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTim.Location = new System.Drawing.Point(597, 47);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(191, 20);
            this.textBoxTim.TabIndex = 0;
            // 
            // labelTim
            // 
            this.labelTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTim.AutoSize = true;
            this.labelTim.Location = new System.Drawing.Point(542, 50);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(49, 13);
            this.labelTim.TabIndex = 17;
            this.labelTim.Text = "Tìm kiếm";
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.groupBoxCT);
            this.Controls.Add(this.lOPGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormLop";
            this.Text = "FormLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxCT.ResumeLayout(false);
            this.groupBoxCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLHSTHPTDataSet qLHSTHPTDataSet;
        private QLHSTHPTDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLHSTHPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBoxCT;
        private System.Windows.Forms.ComboBox comboBoxBan;
        private System.Windows.Forms.TextBox textBoxMaNH;
        private System.Windows.Forms.TextBox textBoxMaHK;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHK;
        private DevExpress.XtraGrid.Columns.GridColumn colMANH;
        private DevExpress.XtraGrid.Columns.GridColumn colBAN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelEMaNH;
        private System.Windows.Forms.Label labelEMaHK;
        private System.Windows.Forms.Label labelETenLop;
        private System.Windows.Forms.Label labelEBan;
        private System.Windows.Forms.Label labelEMaLop;
    }
}