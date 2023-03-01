namespace Mtsoft123
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRC8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRCTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNS12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNS8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSKKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBL12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBL8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBLKKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBLTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sF12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFKKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Mtsoft123.Products);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün Aktar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "İsim:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 378);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Çalıştır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.a1DataGridViewTextBoxColumn,
            this.aF2DataGridViewTextBoxColumn,
            this.fRCDataGridViewTextBoxColumn,
            this.fRC8DataGridViewTextBoxColumn,
            this.fRCTEKDataGridViewTextBoxColumn,
            this.iNS12DataGridViewTextBoxColumn,
            this.iNS8DataGridViewTextBoxColumn,
            this.iNSKKDataGridViewTextBoxColumn,
            this.iNSPSDataGridViewTextBoxColumn,
            this.iNSTEKDataGridViewTextBoxColumn,
            this.mBLDataGridViewTextBoxColumn,
            this.mBL12DataGridViewTextBoxColumn,
            this.mBL8DataGridViewTextBoxColumn,
            this.mBLKKDataGridViewTextBoxColumn,
            this.mBLTEKDataGridViewTextBoxColumn,
            this.sF12DataGridViewTextBoxColumn,
            this.sFDataGridViewTextBoxColumn,
            this.sFKKDataGridViewTextBoxColumn,
            this.sFTEKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(769, 328);
            this.dataGridView1.TabIndex = 13;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // a1DataGridViewTextBoxColumn
            // 
            this.a1DataGridViewTextBoxColumn.DataPropertyName = "A1";
            this.a1DataGridViewTextBoxColumn.HeaderText = "A1";
            this.a1DataGridViewTextBoxColumn.Name = "a1DataGridViewTextBoxColumn";
            this.a1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aF2DataGridViewTextBoxColumn
            // 
            this.aF2DataGridViewTextBoxColumn.DataPropertyName = "AF2";
            this.aF2DataGridViewTextBoxColumn.HeaderText = "AF2";
            this.aF2DataGridViewTextBoxColumn.Name = "aF2DataGridViewTextBoxColumn";
            this.aF2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fRCDataGridViewTextBoxColumn
            // 
            this.fRCDataGridViewTextBoxColumn.DataPropertyName = "FRC";
            this.fRCDataGridViewTextBoxColumn.HeaderText = "FRC";
            this.fRCDataGridViewTextBoxColumn.Name = "fRCDataGridViewTextBoxColumn";
            this.fRCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fRC8DataGridViewTextBoxColumn
            // 
            this.fRC8DataGridViewTextBoxColumn.DataPropertyName = "FRC_8";
            this.fRC8DataGridViewTextBoxColumn.HeaderText = "FRC_8";
            this.fRC8DataGridViewTextBoxColumn.Name = "fRC8DataGridViewTextBoxColumn";
            this.fRC8DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fRCTEKDataGridViewTextBoxColumn
            // 
            this.fRCTEKDataGridViewTextBoxColumn.DataPropertyName = "FRC_TEK";
            this.fRCTEKDataGridViewTextBoxColumn.HeaderText = "FRC_TEK";
            this.fRCTEKDataGridViewTextBoxColumn.Name = "fRCTEKDataGridViewTextBoxColumn";
            this.fRCTEKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNS12DataGridViewTextBoxColumn
            // 
            this.iNS12DataGridViewTextBoxColumn.DataPropertyName = "INS_12";
            this.iNS12DataGridViewTextBoxColumn.HeaderText = "INS_12";
            this.iNS12DataGridViewTextBoxColumn.Name = "iNS12DataGridViewTextBoxColumn";
            this.iNS12DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNS8DataGridViewTextBoxColumn
            // 
            this.iNS8DataGridViewTextBoxColumn.DataPropertyName = "INS_8";
            this.iNS8DataGridViewTextBoxColumn.HeaderText = "INS_8";
            this.iNS8DataGridViewTextBoxColumn.Name = "iNS8DataGridViewTextBoxColumn";
            this.iNS8DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNSKKDataGridViewTextBoxColumn
            // 
            this.iNSKKDataGridViewTextBoxColumn.DataPropertyName = "INS_KK";
            this.iNSKKDataGridViewTextBoxColumn.HeaderText = "INS_KK";
            this.iNSKKDataGridViewTextBoxColumn.Name = "iNSKKDataGridViewTextBoxColumn";
            this.iNSKKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNSPSDataGridViewTextBoxColumn
            // 
            this.iNSPSDataGridViewTextBoxColumn.DataPropertyName = "INS_PS";
            this.iNSPSDataGridViewTextBoxColumn.HeaderText = "INS_PS";
            this.iNSPSDataGridViewTextBoxColumn.Name = "iNSPSDataGridViewTextBoxColumn";
            this.iNSPSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNSTEKDataGridViewTextBoxColumn
            // 
            this.iNSTEKDataGridViewTextBoxColumn.DataPropertyName = "INS_TEK";
            this.iNSTEKDataGridViewTextBoxColumn.HeaderText = "INS_TEK";
            this.iNSTEKDataGridViewTextBoxColumn.Name = "iNSTEKDataGridViewTextBoxColumn";
            this.iNSTEKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mBLDataGridViewTextBoxColumn
            // 
            this.mBLDataGridViewTextBoxColumn.DataPropertyName = "MBL";
            this.mBLDataGridViewTextBoxColumn.HeaderText = "MBL";
            this.mBLDataGridViewTextBoxColumn.Name = "mBLDataGridViewTextBoxColumn";
            this.mBLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mBL12DataGridViewTextBoxColumn
            // 
            this.mBL12DataGridViewTextBoxColumn.DataPropertyName = "MBL_12";
            this.mBL12DataGridViewTextBoxColumn.HeaderText = "MBL_12";
            this.mBL12DataGridViewTextBoxColumn.Name = "mBL12DataGridViewTextBoxColumn";
            this.mBL12DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mBL8DataGridViewTextBoxColumn
            // 
            this.mBL8DataGridViewTextBoxColumn.DataPropertyName = "MBL_8";
            this.mBL8DataGridViewTextBoxColumn.HeaderText = "MBL_8";
            this.mBL8DataGridViewTextBoxColumn.Name = "mBL8DataGridViewTextBoxColumn";
            this.mBL8DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mBLKKDataGridViewTextBoxColumn
            // 
            this.mBLKKDataGridViewTextBoxColumn.DataPropertyName = "MBL_KK";
            this.mBLKKDataGridViewTextBoxColumn.HeaderText = "MBL_KK";
            this.mBLKKDataGridViewTextBoxColumn.Name = "mBLKKDataGridViewTextBoxColumn";
            this.mBLKKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mBLTEKDataGridViewTextBoxColumn
            // 
            this.mBLTEKDataGridViewTextBoxColumn.DataPropertyName = "MBL_TEK";
            this.mBLTEKDataGridViewTextBoxColumn.HeaderText = "MBL_TEK";
            this.mBLTEKDataGridViewTextBoxColumn.Name = "mBLTEKDataGridViewTextBoxColumn";
            this.mBLTEKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sF12DataGridViewTextBoxColumn
            // 
            this.sF12DataGridViewTextBoxColumn.DataPropertyName = "SF_12";
            this.sF12DataGridViewTextBoxColumn.HeaderText = "SF_12";
            this.sF12DataGridViewTextBoxColumn.Name = "sF12DataGridViewTextBoxColumn";
            this.sF12DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sFDataGridViewTextBoxColumn
            // 
            this.sFDataGridViewTextBoxColumn.DataPropertyName = "SF";
            this.sFDataGridViewTextBoxColumn.HeaderText = "SF";
            this.sFDataGridViewTextBoxColumn.Name = "sFDataGridViewTextBoxColumn";
            this.sFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sFKKDataGridViewTextBoxColumn
            // 
            this.sFKKDataGridViewTextBoxColumn.DataPropertyName = "SF_KK";
            this.sFKKDataGridViewTextBoxColumn.HeaderText = "SF_KK";
            this.sFKKDataGridViewTextBoxColumn.Name = "sFKKDataGridViewTextBoxColumn";
            this.sFKKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sFTEKDataGridViewTextBoxColumn
            // 
            this.sFTEKDataGridViewTextBoxColumn.DataPropertyName = "SF_TEK";
            this.sFTEKDataGridViewTextBoxColumn.HeaderText = "SF_TEK";
            this.sFTEKDataGridViewTextBoxColumn.Name = "sFTEKDataGridViewTextBoxColumn";
            this.sFTEKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tablo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 378);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dosya:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 23);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LİSTE";
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewTextBoxColumn isPrintedDataGridViewTextBoxColumn;
        private BindingSource productsBindingSource;
        private DataGridViewTextBoxColumn seriesNumberofRowDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn documentNumberInBnsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mainFabricCompDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn liningCompDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soleCompDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceField1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceField2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mansAdressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eACDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn conformityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataMatrixCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uniqueSerialNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceFieldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dimensionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kutuNoDataGridViewTextBoxColumn;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        #endregion

        private TabPage tabPage1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TabControl tabControl1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn a1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aF2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fRCDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fRC8DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fRCTEKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iNS12DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iNS8DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iNSKKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iNSPSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iNSTEKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mBLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mBL12DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mBL8DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mBLKKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mBLTEKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sF12DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sFKKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sFTEKDataGridViewTextBoxColumn;
    }
}