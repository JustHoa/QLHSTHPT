﻿namespace QLHSTHPT
{
    partial class FormHocKy
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
            System.Windows.Forms.Label nGAYBDLabel;
            System.Windows.Forms.Label tHANGBDLabel;
            System.Windows.Forms.Label tENHKLabel;
            System.Windows.Forms.Label mAHKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocKy));
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
            this.hOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCKYTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.HOCKYTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager();
            this.hOCKYGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHANGBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nGAYBDTextBox = new System.Windows.Forms.TextBox();
            this.tENHKTextBox = new System.Windows.Forms.TextBox();
            this.mAHKTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tHANGBDComboBox = new System.Windows.Forms.ComboBox();
            nGAYBDLabel = new System.Windows.Forms.Label();
            tHANGBDLabel = new System.Windows.Forms.Label();
            tENHKLabel = new System.Windows.Forms.Label();
            mAHKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nGAYBDLabel
            // 
            nGAYBDLabel.AutoSize = true;
            nGAYBDLabel.Location = new System.Drawing.Point(259, 81);
            nGAYBDLabel.Name = "nGAYBDLabel";
            nGAYBDLabel.Size = new System.Drawing.Size(72, 13);
            nGAYBDLabel.TabIndex = 6;
            nGAYBDLabel.Text = "Ngày bắt đầu";
            // 
            // tHANGBDLabel
            // 
            tHANGBDLabel.AutoSize = true;
            tHANGBDLabel.Location = new System.Drawing.Point(40, 81);
            tHANGBDLabel.Name = "tHANGBDLabel";
            tHANGBDLabel.Size = new System.Drawing.Size(78, 13);
            tHANGBDLabel.TabIndex = 4;
            tHANGBDLabel.Text = "Tháng bắt đầu";
            // 
            // tENHKLabel
            // 
            tENHKLabel.AutoSize = true;
            tENHKLabel.Location = new System.Drawing.Point(259, 39);
            tENHKLabel.Name = "tENHKLabel";
            tENHKLabel.Size = new System.Drawing.Size(61, 13);
            tENHKLabel.TabIndex = 2;
            tENHKLabel.Text = "Tên học kỳ";
            // 
            // mAHKLabel
            // 
            mAHKLabel.AutoSize = true;
            mAHKLabel.Location = new System.Drawing.Point(40, 39);
            mAHKLabel.Name = "mAHKLabel";
            mAHKLabel.Size = new System.Drawing.Size(57, 13);
            mAHKLabel.TabIndex = 0;
            mAHKLabel.Text = "Mã học kỳ";
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
            this.bar2.FloatLocation = new System.Drawing.Point(314, 261);
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
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lưu";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Làm mới";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thoát";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(820, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 470);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(820, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 430);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(820, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 430);
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
            this.hOCKYGridControl.Location = new System.Drawing.Point(0, 40);
            this.hOCKYGridControl.MainView = this.gridView1;
            this.hOCKYGridControl.MenuManager = this.barManager1;
            this.hOCKYGridControl.Name = "hOCKYGridControl";
            this.hOCKYGridControl.Size = new System.Drawing.Size(820, 220);
            this.hOCKYGridControl.TabIndex = 11;
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
            this.groupBox1.Controls.Add(this.tHANGBDComboBox);
            this.groupBox1.Controls.Add(this.nGAYBDTextBox);
            this.groupBox1.Controls.Add(this.tENHKTextBox);
            this.groupBox1.Controls.Add(this.mAHKTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(nGAYBDLabel);
            this.groupBox1.Controls.Add(tHANGBDLabel);
            this.groupBox1.Controls.Add(tENHKLabel);
            this.groupBox1.Controls.Add(mAHKLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 210);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT HỌC KỲ";
            // 
            // nGAYBDTextBox
            // 
            this.nGAYBDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "NGAYBD", true));
            this.nGAYBDTextBox.Location = new System.Drawing.Point(337, 78);
            this.nGAYBDTextBox.Name = "nGAYBDTextBox";
            this.nGAYBDTextBox.Size = new System.Drawing.Size(100, 20);
            this.nGAYBDTextBox.TabIndex = 12;
            // 
            // tENHKTextBox
            // 
            this.tENHKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "TENHK", true));
            this.tENHKTextBox.Location = new System.Drawing.Point(337, 36);
            this.tENHKTextBox.Name = "tENHKTextBox";
            this.tENHKTextBox.Size = new System.Drawing.Size(228, 20);
            this.tENHKTextBox.TabIndex = 11;
            // 
            // mAHKTextBox
            // 
            this.mAHKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "MAHK", true));
            this.mAHKTextBox.Location = new System.Drawing.Point(124, 36);
            this.mAHKTextBox.Name = "mAHKTextBox";
            this.mAHKTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAHKTextBox.TabIndex = 9;
            this.mAHKTextBox.TextChanged += new System.EventHandler(this.mAHKTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(617, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tHANGBDComboBox
            // 
            this.tHANGBDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCKYBindingSource, "THANGBD", true));
            this.tHANGBDComboBox.FormattingEnabled = true;
            this.tHANGBDComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.tHANGBDComboBox.Location = new System.Drawing.Point(124, 78);
            this.tHANGBDComboBox.Name = "tHANGBDComboBox";
            this.tHANGBDComboBox.Size = new System.Drawing.Size(100, 21);
            this.tHANGBDComboBox.TabIndex = 13;
            // 
            // FormHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 470);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hOCKYGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormHocKy";
            this.Text = "FormHocKy";
            this.Load += new System.EventHandler(this.FormHocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.BindingSource hOCKYBindingSource;
        private QLHSTHPTDataSet qLHSTHPTDataSet;
        private QLHSTHPTDataSetTableAdapters.HOCKYTableAdapter hOCKYTableAdapter;
        private QLHSTHPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mAHKTextBox;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl hOCKYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHK;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHK;
        private DevExpress.XtraGrid.Columns.GridColumn colTHANGBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYBD;
        private System.Windows.Forms.TextBox nGAYBDTextBox;
        private System.Windows.Forms.TextBox tENHKTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox tHANGBDComboBox;
    }
}