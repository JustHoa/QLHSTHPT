namespace QLHSTHPT
{
    partial class FormNamHoc
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
            System.Windows.Forms.Label tENNHLabel;
            System.Windows.Forms.Label mANHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNamHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLHSTHPTDataSet = new QLHSTHPT.QLHSTHPTDataSet();
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAMHOCTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.NAMHOCTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager();
            this.nAMHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxCT = new System.Windows.Forms.GroupBox();
            this.labelEBD = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxKT = new System.Windows.Forms.TextBox();
            this.textBoxBD = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.textBoxMNH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.labelTim = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelEKT = new System.Windows.Forms.Label();
            this.labelET = new System.Windows.Forms.Label();
            nAMKTLabel = new System.Windows.Forms.Label();
            nAMBDLabel = new System.Windows.Forms.Label();
            tENNHLabel = new System.Windows.Forms.Label();
            mANHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // nAMKTLabel
            // 
            nAMKTLabel.AutoSize = true;
            nAMKTLabel.Location = new System.Drawing.Point(232, 77);
            nAMKTLabel.Name = "nAMKTLabel";
            nAMKTLabel.Size = new System.Drawing.Size(71, 13);
            nAMKTLabel.TabIndex = 6;
            nAMKTLabel.Text = "Năm kết thúc";
            // 
            // nAMBDLabel
            // 
            nAMBDLabel.AutoSize = true;
            nAMBDLabel.Location = new System.Drawing.Point(34, 77);
            nAMBDLabel.Name = "nAMBDLabel";
            nAMBDLabel.Size = new System.Drawing.Size(69, 13);
            nAMBDLabel.TabIndex = 4;
            nAMBDLabel.Text = "Năm bắt đầu";
            // 
            // tENNHLabel
            // 
            tENNHLabel.AutoSize = true;
            tENNHLabel.Location = new System.Drawing.Point(232, 32);
            tENNHLabel.Name = "tENNHLabel";
            tENNHLabel.Size = new System.Drawing.Size(70, 13);
            tENNHLabel.TabIndex = 2;
            tENNHLabel.Text = "Tên năm học";
            // 
            // mANHLabel
            // 
            mANHLabel.AutoSize = true;
            mANHLabel.Location = new System.Drawing.Point(34, 32);
            mANHLabel.Name = "mANHLabel";
            mANHLabel.Size = new System.Drawing.Size(66, 13);
            mANHLabel.TabIndex = 0;
            mANHLabel.Text = "Mã năm học";
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
            this.bar2.FloatLocation = new System.Drawing.Point(321, 260);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.barButtonItem6.Caption = "Làm mới";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thoát";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
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
            this.qLHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nAMHOCBindingSource
            // 
            this.nAMHOCBindingSource.DataMember = "NAMHOC";
            this.nAMHOCBindingSource.DataSource = this.qLHSTHPTDataSet;
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
            // nAMHOCGridControl
            // 
            this.nAMHOCGridControl.DataSource = this.nAMHOCBindingSource;
            this.nAMHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nAMHOCGridControl.Location = new System.Drawing.Point(0, 40);
            this.nAMHOCGridControl.MainView = this.gridView1;
            this.nAMHOCGridControl.MenuManager = this.barManager1;
            this.nAMHOCGridControl.Name = "nAMHOCGridControl";
            this.nAMHOCGridControl.Size = new System.Drawing.Size(800, 220);
            this.nAMHOCGridControl.TabIndex = 11;
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
            // groupBoxCT
            // 
            this.groupBoxCT.Controls.Add(this.labelET);
            this.groupBoxCT.Controls.Add(this.labelEKT);
            this.groupBoxCT.Controls.Add(this.labelEBD);
            this.groupBoxCT.Controls.Add(this.button2);
            this.groupBoxCT.Controls.Add(this.textBoxKT);
            this.groupBoxCT.Controls.Add(this.textBoxBD);
            this.groupBoxCT.Controls.Add(this.textBoxTen);
            this.groupBoxCT.Controls.Add(this.textBoxMNH);
            this.groupBoxCT.Controls.Add(this.button1);
            this.groupBoxCT.Controls.Add(nAMKTLabel);
            this.groupBoxCT.Controls.Add(nAMBDLabel);
            this.groupBoxCT.Controls.Add(tENNHLabel);
            this.groupBoxCT.Controls.Add(mANHLabel);
            this.groupBoxCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCT.Location = new System.Drawing.Point(0, 260);
            this.groupBoxCT.Name = "groupBoxCT";
            this.groupBoxCT.Size = new System.Drawing.Size(800, 190);
            this.groupBoxCT.TabIndex = 12;
            this.groupBoxCT.TabStop = false;
            this.groupBoxCT.Text = "CHI TIẾT NĂM HỌC";
            // 
            // labelEBD
            // 
            this.labelEBD.AutoSize = true;
            this.labelEBD.ForeColor = System.Drawing.Color.Red;
            this.labelEBD.Location = new System.Drawing.Point(106, 97);
            this.labelEBD.Name = "labelEBD";
            this.labelEBD.Size = new System.Drawing.Size(0, 13);
            this.labelEBD.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxKT
            // 
            this.textBoxKT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "NAMKT", true));
            this.textBoxKT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxKT.Location = new System.Drawing.Point(309, 74);
            this.textBoxKT.Name = "textBoxKT";
            this.textBoxKT.Size = new System.Drawing.Size(100, 20);
            this.textBoxKT.TabIndex = 12;
            this.textBoxKT.TextChanged += new System.EventHandler(this.textBoxKT_TextChanged);
            this.textBoxKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKT_KeyPress);
            // 
            // textBoxBD
            // 
            this.textBoxBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "NAMBD", true));
            this.textBoxBD.Location = new System.Drawing.Point(109, 74);
            this.textBoxBD.Name = "textBoxBD";
            this.textBoxBD.Size = new System.Drawing.Size(100, 20);
            this.textBoxBD.TabIndex = 11;
            this.textBoxBD.TextChanged += new System.EventHandler(this.textBoxBD_TextChanged);
            this.textBoxBD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBD_KeyPress);
            // 
            // textBoxTen
            // 
            this.textBoxTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "TENNH", true));
            this.textBoxTen.Location = new System.Drawing.Point(309, 29);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(212, 20);
            this.textBoxTen.TabIndex = 10;
            this.textBoxTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTen_KeyPress);
            // 
            // textBoxMNH
            // 
            this.textBoxMNH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nAMHOCBindingSource, "MANH", true));
            this.textBoxMNH.Enabled = false;
            this.textBoxMNH.Location = new System.Drawing.Point(109, 29);
            this.textBoxMNH.Name = "textBoxMNH";
            this.textBoxMNH.Size = new System.Drawing.Size(100, 20);
            this.textBoxMNH.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTim
            // 
            this.textBoxTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTim.Location = new System.Drawing.Point(597, 46);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(191, 20);
            this.textBoxTim.TabIndex = 17;
            this.textBoxTim.TextChanged += new System.EventHandler(this.textBoxTim_TextChanged);
            this.textBoxTim.MouseHover += new System.EventHandler(this.textBoxTim_MouseHover);
            // 
            // labelTim
            // 
            this.labelTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTim.AutoSize = true;
            this.labelTim.Location = new System.Drawing.Point(542, 49);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(49, 13);
            this.labelTim.TabIndex = 22;
            this.labelTim.Text = "Tìm kiếm";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // labelEKT
            // 
            this.labelEKT.AutoSize = true;
            this.labelEKT.ForeColor = System.Drawing.Color.Red;
            this.labelEKT.Location = new System.Drawing.Point(306, 97);
            this.labelEKT.Name = "labelEKT";
            this.labelEKT.Size = new System.Drawing.Size(0, 13);
            this.labelEKT.TabIndex = 15;
            // 
            // labelET
            // 
            this.labelET.AutoSize = true;
            this.labelET.ForeColor = System.Drawing.Color.Red;
            this.labelET.Location = new System.Drawing.Point(306, 52);
            this.labelET.Name = "labelET";
            this.labelET.Size = new System.Drawing.Size(0, 13);
            this.labelET.TabIndex = 16;
            // 
            // FormNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.groupBoxCT);
            this.Controls.Add(this.nAMHOCGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNamHoc";
            this.Text = "FormNamHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxCT.ResumeLayout(false);
            this.groupBoxCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private QLHSTHPTDataSet qLHSTHPTDataSet;
        private QLHSTHPTDataSetTableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
        private QLHSTHPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBoxCT;
        private System.Windows.Forms.TextBox textBoxKT;
        private System.Windows.Forms.TextBox textBoxBD;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.TextBox textBoxMNH;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl nAMHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNH;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMKT;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelEBD;
        private System.Windows.Forms.Label labelEKT;
        private System.Windows.Forms.Label labelET;
    }
}