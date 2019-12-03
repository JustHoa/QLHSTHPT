namespace QLHSTHPT
{
    partial class Form1
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
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tOMONLabel;
            System.Windows.Forms.Label dIENTHOAILabel;
            System.Windows.Forms.Label nGHILabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gIAOVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSTHPTDataSet = new QLHSTHPT.QLHSTHPTDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nGHICheckBox = new System.Windows.Forms.CheckBox();
            this.dIENTHOAITextBox = new System.Windows.Forms.TextBox();
            this.tOMONTextBox = new System.Windows.Forms.TextBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.gIOITINHComboBox = new System.Windows.Forms.ComboBox();
            this.tENGVTextBox = new System.Windows.Forms.TextBox();
            this.mAGVTextBox = new System.Windows.Forms.TextBox();
            this.gIAOVIENTableAdapter = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new QLHSTHPT.QLHSTHPTDataSetTableAdapters.TableAdapterManager();
            this.btnExportExcel = new System.Windows.Forms.Button();
            mAGVLabel = new System.Windows.Forms.Label();
            tENGVLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tOMONLabel = new System.Windows.Forms.Label();
            dIENTHOAILabel = new System.Windows.Forms.Label();
            nGHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(30, 40);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(68, 13);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã giáo viên";
            // 
            // tENGVLabel
            // 
            tENGVLabel.AutoSize = true;
            tENGVLabel.Location = new System.Drawing.Point(30, 81);
            tENGVLabel.Name = "tENGVLabel";
            tENGVLabel.Size = new System.Drawing.Size(72, 13);
            tENGVLabel.TabIndex = 2;
            tENGVLabel.Text = "Tên giáo viên";
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(30, 124);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(47, 13);
            gIOITINHLabel.TabIndex = 4;
            gIOITINHLabel.Text = "Giới tính";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(30, 168);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(54, 13);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "Ngày sinh";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(30, 208);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(40, 13);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // tOMONLabel
            // 
            tOMONLabel.AutoSize = true;
            tOMONLabel.Location = new System.Drawing.Point(30, 291);
            tOMONLabel.Name = "tOMONLabel";
            tOMONLabel.Size = new System.Drawing.Size(43, 13);
            tOMONLabel.TabIndex = 10;
            tOMONLabel.Text = "Tổ môn";
            // 
            // dIENTHOAILabel
            // 
            dIENTHOAILabel.AutoSize = true;
            dIENTHOAILabel.Location = new System.Drawing.Point(30, 250);
            dIENTHOAILabel.Name = "dIENTHOAILabel";
            dIENTHOAILabel.Size = new System.Drawing.Size(55, 13);
            dIENTHOAILabel.TabIndex = 12;
            dIENTHOAILabel.Text = "Điện thoại";
            // 
            // nGHILabel
            // 
            nGHILabel.AutoSize = true;
            nGHILabel.Location = new System.Drawing.Point(30, 330);
            nGHILabel.Name = "nGHILabel";
            nGHILabel.Size = new System.Drawing.Size(29, 13);
            nGHILabel.TabIndex = 14;
            nGHILabel.Text = "Nghỉ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gIAOVIENGridControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 484;
            this.splitContainer1.TabIndex = 0;
            // 
            // gIAOVIENGridControl
            // 
            this.gIAOVIENGridControl.DataSource = this.gIAOVIENBindingSource;
            this.gIAOVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIAOVIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.gIAOVIENGridControl.MainView = this.gridView1;
            this.gIAOVIENGridControl.Name = "gIAOVIENGridControl";
            this.gIAOVIENGridControl.Size = new System.Drawing.Size(484, 450);
            this.gIAOVIENGridControl.TabIndex = 0;
            this.gIAOVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.qLHSTHPTDataSet;
            // 
            // qLHSTHPTDataSet
            // 
            this.qLHSTHPTDataSet.DataSetName = "QLHSTHPTDataSet";
            this.qLHSTHPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gIAOVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportExcel);
            this.groupBox1.Controls.Add(nGHILabel);
            this.groupBox1.Controls.Add(this.nGHICheckBox);
            this.groupBox1.Controls.Add(dIENTHOAILabel);
            this.groupBox1.Controls.Add(this.dIENTHOAITextBox);
            this.groupBox1.Controls.Add(tOMONLabel);
            this.groupBox1.Controls.Add(this.tOMONTextBox);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.dIACHITextBox);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(this.nGAYSINHDateEdit);
            this.groupBox1.Controls.Add(gIOITINHLabel);
            this.groupBox1.Controls.Add(this.gIOITINHComboBox);
            this.groupBox1.Controls.Add(tENGVLabel);
            this.groupBox1.Controls.Add(this.tENGVTextBox);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.mAGVTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // nGHICheckBox
            // 
            this.nGHICheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gIAOVIENBindingSource, "NGHI", true));
            this.nGHICheckBox.Location = new System.Drawing.Point(108, 325);
            this.nGHICheckBox.Name = "nGHICheckBox";
            this.nGHICheckBox.Size = new System.Drawing.Size(104, 24);
            this.nGHICheckBox.TabIndex = 15;
            this.nGHICheckBox.UseVisualStyleBackColor = true;
            // 
            // dIENTHOAITextBox
            // 
            this.dIENTHOAITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "DIENTHOAI", true));
            this.dIENTHOAITextBox.Location = new System.Drawing.Point(108, 247);
            this.dIENTHOAITextBox.Name = "dIENTHOAITextBox";
            this.dIENTHOAITextBox.Size = new System.Drawing.Size(121, 20);
            this.dIENTHOAITextBox.TabIndex = 13;
            // 
            // tOMONTextBox
            // 
            this.tOMONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "TOMON", true));
            this.tOMONTextBox.Location = new System.Drawing.Point(108, 288);
            this.tOMONTextBox.Name = "tOMONTextBox";
            this.tOMONTextBox.Size = new System.Drawing.Size(121, 20);
            this.tOMONTextBox.TabIndex = 11;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(108, 205);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(121, 20);
            this.dIACHITextBox.TabIndex = 9;
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIENBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateEdit.EditValue = null;
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(108, 165);
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(121, 20);
            this.nGAYSINHDateEdit.TabIndex = 7;
            // 
            // gIOITINHComboBox
            // 
            this.gIOITINHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "GIOITINH", true));
            this.gIOITINHComboBox.FormattingEnabled = true;
            this.gIOITINHComboBox.Location = new System.Drawing.Point(108, 121);
            this.gIOITINHComboBox.Name = "gIOITINHComboBox";
            this.gIOITINHComboBox.Size = new System.Drawing.Size(121, 21);
            this.gIOITINHComboBox.TabIndex = 5;
            // 
            // tENGVTextBox
            // 
            this.tENGVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "TENGV", true));
            this.tENGVTextBox.Location = new System.Drawing.Point(108, 78);
            this.tENGVTextBox.Name = "tENGVTextBox";
            this.tENGVTextBox.Size = new System.Drawing.Size(121, 20);
            this.tENGVTextBox.TabIndex = 3;
            // 
            // mAGVTextBox
            // 
            this.mAGVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "MAGV", true));
            this.mAGVTextBox.Location = new System.Drawing.Point(108, 37);
            this.mAGVTextBox.Name = "mAGVTextBox";
            this.mAGVTextBox.Size = new System.Drawing.Size(121, 20);
            this.mAGVTextBox.TabIndex = 1;
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
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(53, 372);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExportExcel.TabIndex = 16;
            this.btnExportExcel.Text = "button1";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSTHPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private QLHSTHPTDataSet qLHSTHPTDataSet;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private QLHSTHPTDataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private QLHSTHPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIAOVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.CheckBox nGHICheckBox;
        private System.Windows.Forms.TextBox dIENTHOAITextBox;
        private System.Windows.Forms.TextBox tOMONTextBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private System.Windows.Forms.ComboBox gIOITINHComboBox;
        private System.Windows.Forms.TextBox tENGVTextBox;
        private System.Windows.Forms.TextBox mAGVTextBox;
        private System.Windows.Forms.Button btnExportExcel;
    }
}