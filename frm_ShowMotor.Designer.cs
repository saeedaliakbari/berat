namespace BeratAj
{
    partial class frm_ShowMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ShowMotor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsViewMotorkhane = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeSahraeiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medarAbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minKolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habeMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habeKolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shomareHesabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMotesadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileMotesadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneMotesadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMotorChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileMotorChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMotorkhane)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(738, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست موتورخانه ها";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(287, 34);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(442, 27);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(8, 26);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(116, 36);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "جدید";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.code4DataGridViewTextBoxColumn,
            this.codeSahraeiDataGridViewTextBoxColumn,
            this.medarAbDataGridViewTextBoxColumn,
            this.minKolDataGridViewTextBoxColumn,
            this.habeMinDataGridViewTextBoxColumn,
            this.habeKolDataGridViewTextBoxColumn,
            this.NameBank,
            this.shomareHesabDataGridViewTextBoxColumn,
            this.nameMotesadiDataGridViewTextBoxColumn,
            this.mobileMotesadiDataGridViewTextBoxColumn,
            this.phoneMotesadiDataGridViewTextBoxColumn,
            this.nameMotorChiDataGridViewTextBoxColumn,
            this.mobileMotorChiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsViewMotorkhane;
            this.dataGridView1.Location = new System.Drawing.Point(8, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(723, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // bsViewMotorkhane
            // 
            this.bsViewMotorkhane.DataSource = typeof(BeratAj.ViewMotorkahneByBankName);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnPrint);
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Location = new System.Drawing.Point(15, 410);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(738, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Location = new System.Drawing.Point(131, 17);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(197, 36);
            this.BtnPrint.TabIndex = 2;
            this.BtnPrint.Text = "گزارش موتورخانه ها";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(8, 17);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(116, 36);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(611, 17);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(116, 36);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(487, 17);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(116, 36);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام موتورخانه";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 220;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کدموتورخانه";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // code4DataGridViewTextBoxColumn
            // 
            this.code4DataGridViewTextBoxColumn.DataPropertyName = "Code4";
            this.code4DataGridViewTextBoxColumn.HeaderText = "کد4حرفی";
            this.code4DataGridViewTextBoxColumn.Name = "code4DataGridViewTextBoxColumn";
            this.code4DataGridViewTextBoxColumn.ReadOnly = true;
            this.code4DataGridViewTextBoxColumn.Width = 50;
            // 
            // codeSahraeiDataGridViewTextBoxColumn
            // 
            this.codeSahraeiDataGridViewTextBoxColumn.DataPropertyName = "CodeSahraei";
            this.codeSahraeiDataGridViewTextBoxColumn.HeaderText = "کدصحرایی";
            this.codeSahraeiDataGridViewTextBoxColumn.Name = "codeSahraeiDataGridViewTextBoxColumn";
            this.codeSahraeiDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeSahraeiDataGridViewTextBoxColumn.Width = 20;
            // 
            // medarAbDataGridViewTextBoxColumn
            // 
            this.medarAbDataGridViewTextBoxColumn.DataPropertyName = "MedarAb";
            this.medarAbDataGridViewTextBoxColumn.HeaderText = "مدارآب";
            this.medarAbDataGridViewTextBoxColumn.Name = "medarAbDataGridViewTextBoxColumn";
            this.medarAbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minKolDataGridViewTextBoxColumn
            // 
            this.minKolDataGridViewTextBoxColumn.DataPropertyName = "MinKol";
            this.minKolDataGridViewTextBoxColumn.HeaderText = "دقیقه کل";
            this.minKolDataGridViewTextBoxColumn.Name = "minKolDataGridViewTextBoxColumn";
            this.minKolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // habeMinDataGridViewTextBoxColumn
            // 
            this.habeMinDataGridViewTextBoxColumn.DataPropertyName = "HabeMin";
            this.habeMinDataGridViewTextBoxColumn.HeaderText = "حبه>دقیقه";
            this.habeMinDataGridViewTextBoxColumn.Name = "habeMinDataGridViewTextBoxColumn";
            this.habeMinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // habeKolDataGridViewTextBoxColumn
            // 
            this.habeKolDataGridViewTextBoxColumn.DataPropertyName = "HabeKol";
            this.habeKolDataGridViewTextBoxColumn.HeaderText = "حبه کل";
            this.habeKolDataGridViewTextBoxColumn.Name = "habeKolDataGridViewTextBoxColumn";
            this.habeKolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NameBank
            // 
            this.NameBank.DataPropertyName = "NameBank";
            this.NameBank.HeaderText = "نام بانک";
            this.NameBank.Name = "NameBank";
            this.NameBank.ReadOnly = true;
            // 
            // shomareHesabDataGridViewTextBoxColumn
            // 
            this.shomareHesabDataGridViewTextBoxColumn.DataPropertyName = "ShomareHesab";
            this.shomareHesabDataGridViewTextBoxColumn.HeaderText = "شماره حساب";
            this.shomareHesabDataGridViewTextBoxColumn.Name = "shomareHesabDataGridViewTextBoxColumn";
            this.shomareHesabDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameMotesadiDataGridViewTextBoxColumn
            // 
            this.nameMotesadiDataGridViewTextBoxColumn.DataPropertyName = "NameMotesadi";
            this.nameMotesadiDataGridViewTextBoxColumn.HeaderText = "نام متصدی";
            this.nameMotesadiDataGridViewTextBoxColumn.Name = "nameMotesadiDataGridViewTextBoxColumn";
            this.nameMotesadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileMotesadiDataGridViewTextBoxColumn
            // 
            this.mobileMotesadiDataGridViewTextBoxColumn.DataPropertyName = "MobileMotesadi";
            this.mobileMotesadiDataGridViewTextBoxColumn.HeaderText = "موبایل متصدی";
            this.mobileMotesadiDataGridViewTextBoxColumn.Name = "mobileMotesadiDataGridViewTextBoxColumn";
            this.mobileMotesadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileMotesadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // phoneMotesadiDataGridViewTextBoxColumn
            // 
            this.phoneMotesadiDataGridViewTextBoxColumn.DataPropertyName = "PhoneMotesadi";
            this.phoneMotesadiDataGridViewTextBoxColumn.HeaderText = "نلفن متصدی";
            this.phoneMotesadiDataGridViewTextBoxColumn.Name = "phoneMotesadiDataGridViewTextBoxColumn";
            this.phoneMotesadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneMotesadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameMotorChiDataGridViewTextBoxColumn
            // 
            this.nameMotorChiDataGridViewTextBoxColumn.DataPropertyName = "NameMotorChi";
            this.nameMotorChiDataGridViewTextBoxColumn.HeaderText = "نام موتورچی";
            this.nameMotorChiDataGridViewTextBoxColumn.Name = "nameMotorChiDataGridViewTextBoxColumn";
            this.nameMotorChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileMotorChiDataGridViewTextBoxColumn
            // 
            this.mobileMotorChiDataGridViewTextBoxColumn.DataPropertyName = "MobileMotorChi";
            this.mobileMotorChiDataGridViewTextBoxColumn.HeaderText = "موبایل موتورچی";
            this.mobileMotorChiDataGridViewTextBoxColumn.Name = "mobileMotorChiDataGridViewTextBoxColumn";
            this.mobileMotorChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileMotorChiDataGridViewTextBoxColumn.Width = 120;
            // 
            // frm_ShowMotor
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(769, 473);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ShowMotor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ShowMotor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMotorkhane)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsViewMotorkhane;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileMotorChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMotorChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneMotesadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileMotesadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMotesadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shomareHesabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn habeKolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habeMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minKolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medarAbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeSahraeiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn code4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}