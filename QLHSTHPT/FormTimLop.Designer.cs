namespace QLHSTHPT
{
    partial class FormTimLop
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.qLHSTHPTDataSet2 = new QLHSTHPT.QLHSTHPTDataSet2();
            this.sP_DSLOP_FIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSLOP_FITableAdapter = new QLHSTHPT.QLHSTHPTDataSet2TableAdapters.SP_DSLOP_FITableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSet2TableAdapters.TableAdapterManager();
            this.sP_DSLOP_FIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.labelTim = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLOP_FIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLOP_FIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(772, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHỌN MỘT LỚP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxTenLop);
            this.panel1.Controls.Add(this.textBoxMaLop);
            this.panel1.Controls.Add(tENLOPLabel);
            this.panel1.Controls.Add(mALOPLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 121);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Turquoise;
            this.panelFilter.Controls.Add(this.radioButton2);
            this.panelFilter.Controls.Add(this.rbAll);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 58);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(772, 44);
            this.panelFilter.TabIndex = 3;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(61, 15);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 17);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất cả";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(209, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // qLHSTHPTDataSet2
            // 
            this.qLHSTHPTDataSet2.DataSetName = "QLHSTHPTDataSet2";
            this.qLHSTHPTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DSLOP_FIBindingSource
            // 
            this.sP_DSLOP_FIBindingSource.DataMember = "SP_DSLOP_FI";
            this.sP_DSLOP_FIBindingSource.DataSource = this.qLHSTHPTDataSet2;
            // 
            // sP_DSLOP_FITableAdapter
            // 
            this.sP_DSLOP_FITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOMONTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.DIEMTBM_HKTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.HS_LOPTableAdapter = null;
            this.tableAdapterManager.KHOITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_DSLOP_FIGridControl
            // 
            this.sP_DSLOP_FIGridControl.DataSource = this.sP_DSLOP_FIBindingSource;
            this.sP_DSLOP_FIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DSLOP_FIGridControl.Location = new System.Drawing.Point(0, 102);
            this.sP_DSLOP_FIGridControl.MainView = this.gridView1;
            this.sP_DSLOP_FIGridControl.Name = "sP_DSLOP_FIGridControl";
            this.sP_DSLOP_FIGridControl.Size = new System.Drawing.Size(772, 333);
            this.sP_DSLOP_FIGridControl.TabIndex = 4;
            this.sP_DSLOP_FIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colTENNH,
            this.colBAN,
            this.colMAKHOI});
            this.gridView1.GridControl = this.sP_DSLOP_FIGridControl;
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
            // colTENNH
            // 
            this.colTENNH.FieldName = "TENNH";
            this.colTENNH.Name = "colTENNH";
            this.colTENNH.OptionsColumn.AllowEdit = false;
            this.colTENNH.Visible = true;
            this.colTENNH.VisibleIndex = 2;
            // 
            // colBAN
            // 
            this.colBAN.FieldName = "BAN";
            this.colBAN.Name = "colBAN";
            this.colBAN.OptionsColumn.AllowEdit = false;
            this.colBAN.Visible = true;
            this.colBAN.VisibleIndex = 3;
            // 
            // colMAKHOI
            // 
            this.colMAKHOI.FieldName = "MAKHOI";
            this.colMAKHOI.Name = "colMAKHOI";
            this.colMAKHOI.OptionsColumn.AllowEdit = false;
            this.colMAKHOI.Visible = true;
            this.colMAKHOI.VisibleIndex = 4;
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(93, 31);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(39, 13);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "Mã lớp";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(93, 71);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(43, 13);
            tENLOPLabel.TabIndex = 4;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DSLOP_FIBindingSource, "MALOP", true));
            this.textBoxMaLop.Location = new System.Drawing.Point(142, 28);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.ReadOnly = true;
            this.textBoxMaLop.Size = new System.Drawing.Size(131, 20);
            this.textBoxMaLop.TabIndex = 5;
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_DSLOP_FIBindingSource, "TENLOP", true));
            this.textBoxTenLop.Location = new System.Drawing.Point(142, 69);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.ReadOnly = true;
            this.textBoxTenLop.Size = new System.Drawing.Size(131, 20);
            this.textBoxTenLop.TabIndex = 7;
            // 
            // textBoxTim
            // 
            this.textBoxTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTim.Location = new System.Drawing.Point(602, 109);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(161, 20);
            this.textBoxTim.TabIndex = 5;
            this.textBoxTim.TextChanged += new System.EventHandler(this.textBoxTim_TextChanged);
            this.textBoxTim.MouseHover += new System.EventHandler(this.textBoxTim_MouseHover);
            // 
            // labelTim
            // 
            this.labelTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTim.AutoSize = true;
            this.labelTim.Location = new System.Drawing.Point(547, 112);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(49, 13);
            this.labelTim.TabIndex = 6;
            this.labelTim.Text = "Tìm kiếm";
            // 
            // FormTimLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(772, 556);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.sP_DSLOP_FIGridControl);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTimLop";
            this.Text = "FormTimLop";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTimLop_FormClosing);
            this.Load += new System.EventHandler(this.FormTimLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLOP_FIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSLOP_FIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbAll;
        private QLHSTHPTDataSet2 qLHSTHPTDataSet2;
        private System.Windows.Forms.BindingSource sP_DSLOP_FIBindingSource;
        private QLHSTHPTDataSet2TableAdapters.SP_DSLOP_FITableAdapter sP_DSLOP_FITableAdapter;
        private QLHSTHPTDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private DevExpress.XtraGrid.GridControl sP_DSLOP_FIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNH;
        private DevExpress.XtraGrid.Columns.GridColumn colBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOI;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Label labelTim;
    }
}