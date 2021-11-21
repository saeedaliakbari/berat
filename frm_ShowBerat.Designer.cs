namespace BeratAj
{
    partial class frm_ShowBerat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ShowBerat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorKhaneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePrintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateMohlatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedadMalekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceKolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.babatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceFactorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsViewBerat = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAdd = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrinBeratList = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewBerat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(738, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست برات ها";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.motorKhaneIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.datePrintDataGridViewTextBoxColumn,
            this.dateMohlatDataGridViewTextBoxColumn,
            this.printNumberDataGridViewTextBoxColumn,
            this.tedadMalekDataGridViewTextBoxColumn,
            this.priceKolDataGridViewTextBoxColumn,
            this.minPriceDataGridViewTextBoxColumn,
            this.babatDataGridViewTextBoxColumn,
            this.factorIdDataGridViewTextBoxColumn,
            this.priceFactorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsViewBerat;
            this.dataGridView1.Location = new System.Drawing.Point(8, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(723, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // motorKhaneIdDataGridViewTextBoxColumn
            // 
            this.motorKhaneIdDataGridViewTextBoxColumn.DataPropertyName = "MotorKhaneId";
            this.motorKhaneIdDataGridViewTextBoxColumn.HeaderText = "MotorKhaneId";
            this.motorKhaneIdDataGridViewTextBoxColumn.Name = "motorKhaneIdDataGridViewTextBoxColumn";
            this.motorKhaneIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.motorKhaneIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام موتورخانه";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // datePrintDataGridViewTextBoxColumn
            // 
            this.datePrintDataGridViewTextBoxColumn.DataPropertyName = "DatePrint";
            this.datePrintDataGridViewTextBoxColumn.HeaderText = "تاریخ چاپ";
            this.datePrintDataGridViewTextBoxColumn.Name = "datePrintDataGridViewTextBoxColumn";
            this.datePrintDataGridViewTextBoxColumn.ReadOnly = true;
            this.datePrintDataGridViewTextBoxColumn.Width = 80;
            // 
            // dateMohlatDataGridViewTextBoxColumn
            // 
            this.dateMohlatDataGridViewTextBoxColumn.DataPropertyName = "DateMohlat";
            this.dateMohlatDataGridViewTextBoxColumn.HeaderText = "مهلت پرداخت";
            this.dateMohlatDataGridViewTextBoxColumn.Name = "dateMohlatDataGridViewTextBoxColumn";
            this.dateMohlatDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateMohlatDataGridViewTextBoxColumn.Width = 80;
            // 
            // printNumberDataGridViewTextBoxColumn
            // 
            this.printNumberDataGridViewTextBoxColumn.DataPropertyName = "PrintNumber";
            this.printNumberDataGridViewTextBoxColumn.HeaderText = "شماره چاپ";
            this.printNumberDataGridViewTextBoxColumn.Name = "printNumberDataGridViewTextBoxColumn";
            this.printNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.printNumberDataGridViewTextBoxColumn.Width = 50;
            // 
            // tedadMalekDataGridViewTextBoxColumn
            // 
            this.tedadMalekDataGridViewTextBoxColumn.DataPropertyName = "TedadMalek";
            this.tedadMalekDataGridViewTextBoxColumn.HeaderText = "تعداد مالک";
            this.tedadMalekDataGridViewTextBoxColumn.Name = "tedadMalekDataGridViewTextBoxColumn";
            this.tedadMalekDataGridViewTextBoxColumn.ReadOnly = true;
            this.tedadMalekDataGridViewTextBoxColumn.Width = 50;
            // 
            // priceKolDataGridViewTextBoxColumn
            // 
            this.priceKolDataGridViewTextBoxColumn.DataPropertyName = "PriceKol";
            this.priceKolDataGridViewTextBoxColumn.HeaderText = "قیمت کل";
            this.priceKolDataGridViewTextBoxColumn.Name = "priceKolDataGridViewTextBoxColumn";
            this.priceKolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minPriceDataGridViewTextBoxColumn
            // 
            this.minPriceDataGridViewTextBoxColumn.DataPropertyName = "MinPrice";
            this.minPriceDataGridViewTextBoxColumn.HeaderText = "قیمت هر دقیقه";
            this.minPriceDataGridViewTextBoxColumn.Name = "minPriceDataGridViewTextBoxColumn";
            this.minPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.minPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // babatDataGridViewTextBoxColumn
            // 
            this.babatDataGridViewTextBoxColumn.DataPropertyName = "Babat";
            this.babatDataGridViewTextBoxColumn.HeaderText = "بابت";
            this.babatDataGridViewTextBoxColumn.Name = "babatDataGridViewTextBoxColumn";
            this.babatDataGridViewTextBoxColumn.ReadOnly = true;
            this.babatDataGridViewTextBoxColumn.Width = 150;
            // 
            // factorIdDataGridViewTextBoxColumn
            // 
            this.factorIdDataGridViewTextBoxColumn.DataPropertyName = "FactorId";
            this.factorIdDataGridViewTextBoxColumn.HeaderText = "شماره فاکتور";
            this.factorIdDataGridViewTextBoxColumn.Name = "factorIdDataGridViewTextBoxColumn";
            this.factorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // priceFactorDataGridViewTextBoxColumn
            // 
            this.priceFactorDataGridViewTextBoxColumn.DataPropertyName = "PriceFactor";
            this.priceFactorDataGridViewTextBoxColumn.HeaderText = "قیمت فاکتور";
            this.priceFactorDataGridViewTextBoxColumn.Name = "priceFactorDataGridViewTextBoxColumn";
            this.priceFactorDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceFactorDataGridViewTextBoxColumn.Width = 70;
            // 
            // bsViewBerat
            // 
            this.bsViewBerat.DataSource = typeof(BeratAj.ViewBeratByName);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(8, 18);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(116, 36);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "جدید";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(332, 23);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(397, 27);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnPrinBeratList);
            this.groupBox2.Controls.Add(this.BtnPrint);
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Location = new System.Drawing.Point(15, 405);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(738, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnPrinBeratList
            // 
            this.btnPrinBeratList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinBeratList.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinBeratList.Image")));
            this.btnPrinBeratList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrinBeratList.Location = new System.Drawing.Point(255, 17);
            this.btnPrinBeratList.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrinBeratList.Name = "btnPrinBeratList";
            this.btnPrinBeratList.Size = new System.Drawing.Size(145, 36);
            this.btnPrinBeratList.TabIndex = 3;
            this.btnPrinBeratList.Text = "لیست برات براساس تاریخ";
            this.btnPrinBeratList.UseVisualStyleBackColor = true;
            this.btnPrinBeratList.Click += new System.EventHandler(this.btnPrinBeratList_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Location = new System.Drawing.Point(597, 17);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(134, 36);
            this.BtnPrint.TabIndex = 0;
            this.BtnPrint.Text = "پرینت";
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
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(131, 18);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(116, 36);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(408, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "لیست برات براساس موتورخانه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPrinBeratList_Click);
            // 
            // frm_ShowBerat
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
            this.Name = "frm_ShowBerat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frm_ShowBerat_Load);
            this.Load += new System.EventHandler(this.frm_ShowBerat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewBerat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsViewBerat;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceFactorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn babatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceKolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedadMalekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateMohlatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePrintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorKhaneIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPrinBeratList;
        private System.Windows.Forms.Button button1;
    }
}