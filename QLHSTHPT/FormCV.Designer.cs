namespace QLHSTHPT
{
    partial class FormCV
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label sOTIETLabel;
            System.Windows.Forms.Label cHUNHIEMLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenGV = new System.Windows.Forms.TextBox();
            this.textBoxMaGV = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.labelEMaHK = new System.Windows.Forms.Label();
            this.labelEMaNH = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaNH = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cHUNHIEMCheckBox = new System.Windows.Forms.CheckBox();
            this.sP_CV_GVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSTHPTDataSet1 = new QLHSTHPT.QLHSTHPTDataSet1();
            this.tENHKTextBox = new System.Windows.Forms.TextBox();
            this.tENNHTextBox = new System.Windows.Forms.TextBox();
            this.sOTIETTextBox = new System.Windows.Forms.TextBox();
            this.tENMHTextBox = new System.Windows.Forms.TextBox();
            this.tENLOPTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sP_CV_GVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUNHIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelRB = new System.Windows.Forms.Panel();
            this.rbtnCN = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.sP_CV_GVTableAdapter = new QLHSTHPT.QLHSTHPTDataSet1TableAdapters.SP_CV_GVTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSet1TableAdapters.TableAdapterManager();
            this.comboBoxHK = new System.Windows.Forms.ComboBox();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sOTIETLabel = new System.Windows.Forms.Label();
            cHUNHIEMLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CV_GVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CV_GVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelRB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(45, 75);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(43, 13);
            tENLOPLabel.TabIndex = 0;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(45, 119);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(49, 13);
            tENMHLabel.TabIndex = 2;
            tENMHLabel.Text = "Môn học";
            // 
            // sOTIETLabel
            // 
            sOTIETLabel.AutoSize = true;
            sOTIETLabel.Location = new System.Drawing.Point(45, 164);
            sOTIETLabel.Name = "sOTIETLabel";
            sOTIETLabel.Size = new System.Drawing.Size(37, 13);
            sOTIETLabel.TabIndex = 4;
            sOTIETLabel.Text = "Số tiết";
            // 
            // cHUNHIEMLabel
            // 
            cHUNHIEMLabel.AutoSize = true;
            cHUNHIEMLabel.Location = new System.Drawing.Point(291, 164);
            cHUNHIEMLabel.Name = "cHUNHIEMLabel";
            cHUNHIEMLabel.Size = new System.Drawing.Size(57, 13);
            cHUNHIEMLabel.TabIndex = 15;
            cHUNHIEMLabel.Text = "Chủ nhiệm";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.95078F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.04922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxTenGV);
            this.panel1.Controls.Add(this.textBoxMaGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 108);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã giáo viên";
            // 
            // textBoxTenGV
            // 
            this.textBoxTenGV.Location = new System.Drawing.Point(123, 64);
            this.textBoxTenGV.Name = "textBoxTenGV";
            this.textBoxTenGV.ReadOnly = true;
            this.textBoxTenGV.Size = new System.Drawing.Size(147, 20);
            this.textBoxTenGV.TabIndex = 1;
            // 
            // textBoxMaGV
            // 
            this.textBoxMaGV.Location = new System.Drawing.Point(123, 21);
            this.textBoxMaGV.Name = "textBoxMaGV";
            this.textBoxMaGV.ReadOnly = true;
            this.textBoxMaGV.Size = new System.Drawing.Size(147, 20);
            this.textBoxMaGV.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.Orange;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.comboBoxHK);
            this.panel.Controls.Add(this.labelEMaHK);
            this.panel.Controls.Add(this.labelEMaNH);
            this.panel.Controls.Add(this.button4);
            this.panel.Controls.Add(this.button3);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.textBoxMaNH);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(568, 6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(565, 108);
            this.panel.TabIndex = 1;
            // 
            // labelEMaHK
            // 
            this.labelEMaHK.AutoSize = true;
            this.labelEMaHK.ForeColor = System.Drawing.Color.Red;
            this.labelEMaHK.Location = new System.Drawing.Point(114, 87);
            this.labelEMaHK.Name = "labelEMaHK";
            this.labelEMaHK.Size = new System.Drawing.Size(0, 13);
            this.labelEMaHK.TabIndex = 9;
            // 
            // labelEMaNH
            // 
            this.labelEMaNH.AutoSize = true;
            this.labelEMaNH.ForeColor = System.Drawing.Color.Red;
            this.labelEMaNH.Location = new System.Drawing.Point(114, 44);
            this.labelEMaNH.Name = "labelEMaNH";
            this.labelEMaNH.Size = new System.Drawing.Size(0, 13);
            this.labelEMaNH.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Tìm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã học kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã năm học";
            // 
            // textBoxMaNH
            // 
            this.textBoxMaNH.Location = new System.Drawing.Point(117, 21);
            this.textBoxMaNH.Name = "textBoxMaNH";
            this.textBoxMaNH.Size = new System.Drawing.Size(147, 20);
            this.textBoxMaNH.TabIndex = 0;
            this.textBoxMaNH.TextChanged += new System.EventHandler(this.textBoxMaNH_TextChanged);
            this.textBoxMaNH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaNH_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(cHUNHIEMLabel);
            this.panel3.Controls.Add(this.cHUNHIEMCheckBox);
            this.panel3.Controls.Add(this.tENHKTextBox);
            this.panel3.Controls.Add(this.tENNHTextBox);
            this.panel3.Controls.Add(this.sOTIETTextBox);
            this.panel3.Controls.Add(this.tENMHTextBox);
            this.panel3.Controls.Add(this.tENLOPTextBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.labelTitle);
            this.panel3.Controls.Add(sOTIETLabel);
            this.panel3.Controls.Add(tENMHLabel);
            this.panel3.Controls.Add(tENLOPLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(568, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 321);
            this.panel3.TabIndex = 2;
            // 
            // cHUNHIEMCheckBox
            // 
            this.cHUNHIEMCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sP_CV_GVBindingSource, "CHUNHIEM", true));
            this.cHUNHIEMCheckBox.Enabled = false;
            this.cHUNHIEMCheckBox.Location = new System.Drawing.Point(354, 159);
            this.cHUNHIEMCheckBox.Name = "cHUNHIEMCheckBox";
            this.cHUNHIEMCheckBox.Size = new System.Drawing.Size(104, 24);
            this.cHUNHIEMCheckBox.TabIndex = 16;
            this.cHUNHIEMCheckBox.UseVisualStyleBackColor = true;
            // 
            // sP_CV_GVBindingSource
            // 
            this.sP_CV_GVBindingSource.DataMember = "SP_CV_GV";
            this.sP_CV_GVBindingSource.DataSource = this.qLHSTHPTDataSet1;
            // 
            // qLHSTHPTDataSet1
            // 
            this.qLHSTHPTDataSet1.DataSetName = "QLHSTHPTDataSet1";
            this.qLHSTHPTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tENHKTextBox
            // 
            this.tENHKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_CV_GVBindingSource, "TENHK", true));
            this.tENHKTextBox.Location = new System.Drawing.Point(354, 115);
            this.tENHKTextBox.Name = "tENHKTextBox";
            this.tENHKTextBox.ReadOnly = true;
            this.tENHKTextBox.Size = new System.Drawing.Size(147, 20);
            this.tENHKTextBox.TabIndex = 15;
            // 
            // tENNHTextBox
            // 
            this.tENNHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_CV_GVBindingSource, "TENNH", true));
            this.tENNHTextBox.Location = new System.Drawing.Point(354, 72);
            this.tENNHTextBox.Name = "tENNHTextBox";
            this.tENNHTextBox.ReadOnly = true;
            this.tENNHTextBox.Size = new System.Drawing.Size(147, 20);
            this.tENNHTextBox.TabIndex = 14;
            // 
            // sOTIETTextBox
            // 
            this.sOTIETTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_CV_GVBindingSource, "SOTIET", true));
            this.sOTIETTextBox.Location = new System.Drawing.Point(117, 161);
            this.sOTIETTextBox.Name = "sOTIETTextBox";
            this.sOTIETTextBox.ReadOnly = true;
            this.sOTIETTextBox.Size = new System.Drawing.Size(147, 20);
            this.sOTIETTextBox.TabIndex = 13;
            // 
            // tENMHTextBox
            // 
            this.tENMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_CV_GVBindingSource, "TENMH", true));
            this.tENMHTextBox.Location = new System.Drawing.Point(117, 116);
            this.tENMHTextBox.Name = "tENMHTextBox";
            this.tENMHTextBox.ReadOnly = true;
            this.tENMHTextBox.Size = new System.Drawing.Size(147, 20);
            this.tENMHTextBox.TabIndex = 12;
            // 
            // tENLOPTextBox
            // 
            this.tENLOPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_CV_GVBindingSource, "TENLOP", true));
            this.tENLOPTextBox.Location = new System.Drawing.Point(117, 72);
            this.tENLOPTextBox.Name = "tENLOPTextBox";
            this.tENLOPTextBox.ReadOnly = true;
            this.tENLOPTextBox.Size = new System.Drawing.Size(147, 20);
            this.tENLOPTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Học kỳ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Năm học";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTitle.Location = new System.Drawing.Point(45, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(198, 20);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "THÔNG TIN GIẢNG DẠY";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.sP_CV_GVGridControl);
            this.panel2.Controls.Add(this.panelRB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 321);
            this.panel2.TabIndex = 3;
            // 
            // sP_CV_GVGridControl
            // 
            this.sP_CV_GVGridControl.DataSource = this.sP_CV_GVBindingSource;
            this.sP_CV_GVGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_CV_GVGridControl.Location = new System.Drawing.Point(0, 42);
            this.sP_CV_GVGridControl.MainView = this.gridView1;
            this.sP_CV_GVGridControl.Name = "sP_CV_GVGridControl";
            this.sP_CV_GVGridControl.Size = new System.Drawing.Size(553, 279);
            this.sP_CV_GVGridControl.TabIndex = 4;
            this.sP_CV_GVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENLOP,
            this.colTENMH,
            this.colSOTIET,
            this.colTENNH,
            this.colTENHK,
            this.colCHUNHIEM});
            this.gridView1.GridControl = this.sP_CV_GVGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colSOTIET
            // 
            this.colSOTIET.FieldName = "SOTIET";
            this.colSOTIET.Name = "colSOTIET";
            this.colSOTIET.OptionsColumn.AllowEdit = false;
            this.colSOTIET.Visible = true;
            this.colSOTIET.VisibleIndex = 2;
            // 
            // colTENNH
            // 
            this.colTENNH.FieldName = "TENNH";
            this.colTENNH.Name = "colTENNH";
            this.colTENNH.OptionsColumn.AllowEdit = false;
            this.colTENNH.Visible = true;
            this.colTENNH.VisibleIndex = 3;
            // 
            // colTENHK
            // 
            this.colTENHK.FieldName = "TENHK";
            this.colTENHK.Name = "colTENHK";
            this.colTENHK.OptionsColumn.AllowEdit = false;
            this.colTENHK.Visible = true;
            this.colTENHK.VisibleIndex = 4;
            // 
            // colCHUNHIEM
            // 
            this.colCHUNHIEM.FieldName = "CHUNHIEM";
            this.colCHUNHIEM.Name = "colCHUNHIEM";
            this.colCHUNHIEM.OptionsColumn.AllowEdit = false;
            this.colCHUNHIEM.Visible = true;
            this.colCHUNHIEM.VisibleIndex = 5;
            // 
            // panelRB
            // 
            this.panelRB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRB.Controls.Add(this.rbtnCN);
            this.panelRB.Controls.Add(this.rbtnAll);
            this.panelRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRB.Location = new System.Drawing.Point(0, 0);
            this.panelRB.Name = "panelRB";
            this.panelRB.Size = new System.Drawing.Size(553, 42);
            this.panelRB.TabIndex = 4;
            // 
            // rbtnCN
            // 
            this.rbtnCN.AutoSize = true;
            this.rbtnCN.Location = new System.Drawing.Point(195, 12);
            this.rbtnCN.Name = "rbtnCN";
            this.rbtnCN.Size = new System.Drawing.Size(75, 17);
            this.rbtnCN.TabIndex = 1;
            this.rbtnCN.Text = "Chủ nhiệm";
            this.rbtnCN.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(48, 12);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(106, 17);
            this.rbtnAll.TabIndex = 0;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "Tất cả công việc";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // sP_CV_GVTableAdapter
            // 
            this.sP_CV_GVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOMONTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
            this.tableAdapterManager.HS_LOPTableAdapter = null;
            this.tableAdapterManager.KHOITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.PHANCONGGVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHSTHPT.QLHSTHPTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBoxHK
            // 
            this.comboBoxHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHK.FormattingEnabled = true;
            this.comboBoxHK.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxHK.Location = new System.Drawing.Point(117, 64);
            this.comboBoxHK.Name = "comboBoxHK";
            this.comboBoxHK.Size = new System.Drawing.Size(147, 21);
            this.comboBoxHK.TabIndex = 10;
            // 
            // FormCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCV";
            this.Text = "FormCV";
            this.Load += new System.EventHandler(this.FormCV_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CV_GVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_CV_GVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelRB.ResumeLayout(false);
            this.panelRB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenGV;
        private System.Windows.Forms.TextBox textBoxMaGV;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelEMaHK;
        public System.Windows.Forms.Label labelEMaNH;
        public System.Windows.Forms.TextBox textBoxMaNH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tENHKTextBox;
        private System.Windows.Forms.TextBox tENNHTextBox;
        private System.Windows.Forms.TextBox sOTIETTextBox;
        private System.Windows.Forms.TextBox tENMHTextBox;
        private System.Windows.Forms.TextBox tENLOPTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelRB;
        private System.Windows.Forms.RadioButton rbtnCN;
        private System.Windows.Forms.RadioButton rbtnAll;
        private QLHSTHPTDataSet1 qLHSTHPTDataSet1;
        private System.Windows.Forms.BindingSource sP_CV_GVBindingSource;
        private QLHSTHPTDataSet1TableAdapters.SP_CV_GVTableAdapter sP_CV_GVTableAdapter;
        private QLHSTHPTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_CV_GVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHK;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUNHIEM;
        private System.Windows.Forms.CheckBox cHUNHIEMCheckBox;
        private System.Windows.Forms.ComboBox comboBoxHK;
    }
}