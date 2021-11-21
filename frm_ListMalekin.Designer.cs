namespace BeratAj
{
    partial class frm_ListMalekin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListMalekin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMotor = new System.Windows.Forms.ComboBox();
            this.bsMotorkhaneh = new System.Windows.Forms.BindingSource(this.components);
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malekIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorkhaneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ehteramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minAbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secAbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeMelliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SahmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorofMabalgh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsViewMalekin = new System.Windows.Forms.BindingSource(this.components);
            this.mskDatePrint = new System.Windows.Forms.MaskedTextBox();
            this.intNumPrint = new System.Windows.Forms.NumericUpDown();
            this.intPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnMotesadi = new System.Windows.Forms.Button();
            this.btnAlephba = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotorkhaneh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMalekin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intNumPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intPrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMotor);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(384, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب موتورخانه";
            // 
            // cmbMotor
            // 
            this.cmbMotor.DataSource = this.bsMotorkhaneh;
            this.cmbMotor.DisplayMember = "Name";
            this.cmbMotor.FormattingEnabled = true;
            this.cmbMotor.Location = new System.Drawing.Point(46, 38);
            this.cmbMotor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMotor.Name = "cmbMotor";
            this.cmbMotor.Size = new System.Drawing.Size(253, 27);
            this.cmbMotor.TabIndex = 1;
            this.cmbMotor.ValueMember = "Id";
            // 
            // bsMotorkhaneh
            // 
            this.bsMotorkhaneh.DataSource = typeof(BeratAj.Motorkhane);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(46, 73);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(253, 27);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "نام موتورخانه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.mskDatePrint);
            this.groupBox2.Controls.Add(this.intNumPrint);
            this.groupBox2.Controls.Add(this.intPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(384, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تنظیمات لیست مالکین";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.malekIdDataGridViewTextBoxColumn,
            this.motorkhaneIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.ehteramDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.minAbDataGridViewTextBoxColumn,
            this.secAbDataGridViewTextBoxColumn,
            this.habeDataGridViewTextBoxColumn,
            this.codeMelliDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.SahmPrice,
            this.HorofMabalgh});
            this.dataGridView1.DataSource = this.bsViewMalekin;
            this.dataGridView1.Location = new System.Drawing.Point(10, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(75, 18);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // malekIdDataGridViewTextBoxColumn
            // 
            this.malekIdDataGridViewTextBoxColumn.DataPropertyName = "MalekId";
            this.malekIdDataGridViewTextBoxColumn.HeaderText = "MalekId";
            this.malekIdDataGridViewTextBoxColumn.Name = "malekIdDataGridViewTextBoxColumn";
            // 
            // motorkhaneIdDataGridViewTextBoxColumn
            // 
            this.motorkhaneIdDataGridViewTextBoxColumn.DataPropertyName = "MotorkhaneId";
            this.motorkhaneIdDataGridViewTextBoxColumn.HeaderText = "MotorkhaneId";
            this.motorkhaneIdDataGridViewTextBoxColumn.Name = "motorkhaneIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // ehteramDataGridViewTextBoxColumn
            // 
            this.ehteramDataGridViewTextBoxColumn.DataPropertyName = "Ehteram";
            this.ehteramDataGridViewTextBoxColumn.HeaderText = "Ehteram";
            this.ehteramDataGridViewTextBoxColumn.Name = "ehteramDataGridViewTextBoxColumn";
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            // 
            // minAbDataGridViewTextBoxColumn
            // 
            this.minAbDataGridViewTextBoxColumn.DataPropertyName = "MinAb";
            this.minAbDataGridViewTextBoxColumn.HeaderText = "MinAb";
            this.minAbDataGridViewTextBoxColumn.Name = "minAbDataGridViewTextBoxColumn";
            // 
            // secAbDataGridViewTextBoxColumn
            // 
            this.secAbDataGridViewTextBoxColumn.DataPropertyName = "SecAb";
            this.secAbDataGridViewTextBoxColumn.HeaderText = "SecAb";
            this.secAbDataGridViewTextBoxColumn.Name = "secAbDataGridViewTextBoxColumn";
            // 
            // habeDataGridViewTextBoxColumn
            // 
            this.habeDataGridViewTextBoxColumn.DataPropertyName = "Habe";
            this.habeDataGridViewTextBoxColumn.HeaderText = "Habe";
            this.habeDataGridViewTextBoxColumn.Name = "habeDataGridViewTextBoxColumn";
            // 
            // codeMelliDataGridViewTextBoxColumn
            // 
            this.codeMelliDataGridViewTextBoxColumn.DataPropertyName = "CodeMelli";
            this.codeMelliDataGridViewTextBoxColumn.HeaderText = "CodeMelli";
            this.codeMelliDataGridViewTextBoxColumn.Name = "codeMelliDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // SahmPrice
            // 
            this.SahmPrice.HeaderText = "مبلغ قابل پرداخت";
            this.SahmPrice.Name = "SahmPrice";
            // 
            // HorofMabalgh
            // 
            this.HorofMabalgh.HeaderText = "مبلغ به حروف";
            this.HorofMabalgh.Name = "HorofMabalgh";
            // 
            // bsViewMalekin
            // 
            this.bsViewMalekin.DataSource = typeof(BeratAj.ViewMalekin);
            // 
            // mskDatePrint
            // 
            this.mskDatePrint.Location = new System.Drawing.Point(129, 30);
            this.mskDatePrint.Margin = new System.Windows.Forms.Padding(4);
            this.mskDatePrint.Mask = "0000/00/00";
            this.mskDatePrint.Name = "mskDatePrint";
            this.mskDatePrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDatePrint.Size = new System.Drawing.Size(127, 27);
            this.mskDatePrint.TabIndex = 0;
            // 
            // intNumPrint
            // 
            this.intNumPrint.Location = new System.Drawing.Point(129, 104);
            this.intNumPrint.Margin = new System.Windows.Forms.Padding(4);
            this.intNumPrint.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.intNumPrint.Name = "intNumPrint";
            this.intNumPrint.Size = new System.Drawing.Size(129, 27);
            this.intNumPrint.TabIndex = 2;
            // 
            // intPrice
            // 
            this.intPrice.Location = new System.Drawing.Point(26, 66);
            this.intPrice.Margin = new System.Windows.Forms.Padding(4);
            this.intPrice.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.intPrice.Name = "intPrice";
            this.intPrice.Size = new System.Drawing.Size(231, 27);
            this.intPrice.TabIndex = 1;
            this.intPrice.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "شماره چاپ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "مبلغ کل برات";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "تاریخ چاپ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnExit);
            this.groupBox3.Controls.Add(this.btnMotesadi);
            this.groupBox3.Controls.Add(this.btnAlephba);
            this.groupBox3.Location = new System.Drawing.Point(3, 278);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(384, 111);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(8, 65);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(134, 41);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMotesadi
            // 
            this.btnMotesadi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotesadi.Image = ((System.Drawing.Image)(resources.GetObject("btnMotesadi.Image")));
            this.btnMotesadi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotesadi.Location = new System.Drawing.Point(243, 65);
            this.btnMotesadi.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotesadi.Name = "btnMotesadi";
            this.btnMotesadi.Size = new System.Drawing.Size(134, 41);
            this.btnMotesadi.TabIndex = 1;
            this.btnMotesadi.Text = "لیست متصدی";
            this.btnMotesadi.UseVisualStyleBackColor = true;
            this.btnMotesadi.Click += new System.EventHandler(this.btnMotesadi_Click);
            // 
            // btnAlephba
            // 
            this.btnAlephba.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlephba.Image = ((System.Drawing.Image)(resources.GetObject("btnAlephba.Image")));
            this.btnAlephba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlephba.Location = new System.Drawing.Point(243, 16);
            this.btnAlephba.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlephba.Name = "btnAlephba";
            this.btnAlephba.Size = new System.Drawing.Size(134, 41);
            this.btnAlephba.TabIndex = 0;
            this.btnAlephba.Text = "لیست الفبایی";
            this.btnAlephba.UseVisualStyleBackColor = true;
            this.btnAlephba.Click += new System.EventHandler(this.btnAlephba_Click);
            // 
            // frm_ListMalekin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(390, 395);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ListMalekin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ListMalekin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotorkhaneh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMalekin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intNumPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intPrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMotesadi;
        private System.Windows.Forms.Button btnAlephba;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ComboBox cmbMotor;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDatePrint;
        private System.Windows.Forms.NumericUpDown intNumPrint;
        private System.Windows.Forms.NumericUpDown intPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bsViewMalekin;
        private System.Windows.Forms.BindingSource bsMotorkhaneh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malekIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorkhaneIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ehteramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minAbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secAbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMelliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SahmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorofMabalgh;
    }
}