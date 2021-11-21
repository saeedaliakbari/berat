namespace BeratAj
{
    partial class frm_BeratTak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BeratTak));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.cmbMalekFamily = new System.Windows.Forms.ComboBox();
            this.bsViewMalek = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMalek = new System.Windows.Forms.ComboBox();
            this.txtFilterMalek = new System.Windows.Forms.TextBox();
            this.cmbMotor = new System.Windows.Forms.ComboBox();
            this.bsMotorkhaneh = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodeMelli = new System.Windows.Forms.MaskedTextBox();
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtSec = new System.Windows.Forms.NumericUpDown();
            this.txtMin = new System.Windows.Forms.NumericUpDown();
            this.cmbBabat = new System.Windows.Forms.ComboBox();
            this.bsBabat = new System.Windows.Forms.BindingSource(this.components);
            this.mskDatePardakht = new System.Windows.Forms.MaskedTextBox();
            this.mskDatePrint = new System.Windows.Forms.MaskedTextBox();
            this.intNumPrint = new System.Windows.Forms.NumericUpDown();
            this.intPrice = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHabe = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtEhteram = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.cmbMalekId = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMalek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotorkhaneh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBabat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intNumPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intPrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSelect);
            this.groupBox1.Controls.Add(this.cmbMalekFamily);
            this.groupBox1.Controls.Add(this.cmbMalekId);
            this.groupBox1.Controls.Add(this.cmbMalek);
            this.groupBox1.Controls.Add(this.txtFilterMalek);
            this.groupBox1.Controls.Add(this.cmbMotor);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Location = new System.Drawing.Point(5, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(761, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب موتورخانه و مالک";
            // 
            // BtnSelect
            // 
            this.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelect.Image")));
            this.BtnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelect.Location = new System.Drawing.Point(5, 69);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(86, 34);
            this.BtnSelect.TabIndex = 5;
            this.BtnSelect.Text = "انتخاب";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // cmbMalekFamily
            // 
            this.cmbMalekFamily.DataSource = this.bsViewMalek;
            this.cmbMalekFamily.DisplayMember = "Family";
            this.cmbMalekFamily.Enabled = false;
            this.cmbMalekFamily.FormattingEnabled = true;
            this.cmbMalekFamily.Location = new System.Drawing.Point(8, 33);
            this.cmbMalekFamily.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMalekFamily.Name = "cmbMalekFamily";
            this.cmbMalekFamily.Size = new System.Drawing.Size(165, 27);
            this.cmbMalekFamily.TabIndex = 4;
            this.cmbMalekFamily.ValueMember = "Id";
            this.cmbMalekFamily.SelectedIndexChanged += new System.EventHandler(this.cmbMalek_SelectedIndexChanged);
            // 
            // bsViewMalek
            // 
            this.bsViewMalek.DataSource = typeof(BeratAj.ViewMalekin);
            // 
            // cmbMalek
            // 
            this.cmbMalek.DataSource = this.bsViewMalek;
            this.cmbMalek.DisplayMember = "Name";
            this.cmbMalek.Enabled = false;
            this.cmbMalek.FormattingEnabled = true;
            this.cmbMalek.Location = new System.Drawing.Point(181, 33);
            this.cmbMalek.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMalek.Name = "cmbMalek";
            this.cmbMalek.Size = new System.Drawing.Size(117, 27);
            this.cmbMalek.TabIndex = 3;
            this.cmbMalek.ValueMember = "Id";
            this.cmbMalek.SelectedIndexChanged += new System.EventHandler(this.cmbMalek_SelectedIndexChanged);
            // 
            // txtFilterMalek
            // 
            this.txtFilterMalek.Enabled = false;
            this.txtFilterMalek.Location = new System.Drawing.Point(94, 72);
            this.txtFilterMalek.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterMalek.Name = "txtFilterMalek";
            this.txtFilterMalek.Size = new System.Drawing.Size(186, 27);
            this.txtFilterMalek.TabIndex = 2;
            this.txtFilterMalek.TextChanged += new System.EventHandler(this.txtFilterMalek_TextChanged);
            // 
            // cmbMotor
            // 
            this.cmbMotor.DataSource = this.bsMotorkhaneh;
            this.cmbMotor.DisplayMember = "Name";
            this.cmbMotor.FormattingEnabled = true;
            this.cmbMotor.Location = new System.Drawing.Point(459, 33);
            this.cmbMotor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMotor.Name = "cmbMotor";
            this.cmbMotor.Size = new System.Drawing.Size(256, 27);
            this.cmbMotor.TabIndex = 1;
            this.cmbMotor.ValueMember = "Id";
            this.cmbMotor.SelectedIndexChanged += new System.EventHandler(this.cmbMotor_SelectedIndexChanged);
            // 
            // bsMotorkhaneh
            // 
            this.bsMotorkhaneh.DataSource = typeof(BeratAj.Motorkhane);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام مالک";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(709, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "نام موتورخانه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(459, 68);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(256, 27);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodeMelli);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.txtSec);
            this.groupBox2.Controls.Add(this.txtMin);
            this.groupBox2.Controls.Add(this.cmbBabat);
            this.groupBox2.Controls.Add(this.mskDatePardakht);
            this.groupBox2.Controls.Add(this.mskDatePrint);
            this.groupBox2.Controls.Add(this.intNumPrint);
            this.groupBox2.Controls.Add(this.intPrice);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFamily);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtHabe);
            this.groupBox2.Controls.Add(this.txtFatherName);
            this.groupBox2.Controls.Add(this.txtBank);
            this.groupBox2.Controls.Add(this.txtEhteram);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(5, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(761, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نمایش و ویرایش مشخصات";
            // 
            // txtCodeMelli
            // 
            this.txtCodeMelli.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeMelli.Location = new System.Drawing.Point(507, 236);
            this.txtCodeMelli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeMelli.Mask = "000-000000-0";
            this.txtCodeMelli.Name = "txtCodeMelli";
            this.txtCodeMelli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodeMelli.Size = new System.Drawing.Size(153, 27);
            this.txtCodeMelli.TabIndex = 6;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(507, 274);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.Mask = "0000-000-0000";
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMobile.Size = new System.Drawing.Size(153, 27);
            this.txtMobile.TabIndex = 7;
            // 
            // txtSec
            // 
            this.txtSec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSec.Location = new System.Drawing.Point(571, 159);
            this.txtSec.Margin = new System.Windows.Forms.Padding(4);
            this.txtSec.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.txtSec.Minimum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            -2147483648});
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(90, 27);
            this.txtSec.TabIndex = 4;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(473, 159);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtMin.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.txtMin.Minimum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            -2147483648});
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(90, 27);
            this.txtMin.TabIndex = 3;
            // 
            // cmbBabat
            // 
            this.cmbBabat.DataSource = this.bsBabat;
            this.cmbBabat.DisplayMember = "Babats";
            this.cmbBabat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBabat.FormattingEnabled = true;
            this.cmbBabat.Location = new System.Drawing.Point(13, 274);
            this.cmbBabat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBabat.Name = "cmbBabat";
            this.cmbBabat.Size = new System.Drawing.Size(354, 27);
            this.cmbBabat.TabIndex = 14;
            this.cmbBabat.ValueMember = "Id";
            // 
            // bsBabat
            // 
            this.bsBabat.DataSource = typeof(BeratAj.Babat);
            // 
            // mskDatePardakht
            // 
            this.mskDatePardakht.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDatePardakht.Location = new System.Drawing.Point(239, 197);
            this.mskDatePardakht.Margin = new System.Windows.Forms.Padding(4);
            this.mskDatePardakht.Mask = "0000/00/00";
            this.mskDatePardakht.Name = "mskDatePardakht";
            this.mskDatePardakht.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDatePardakht.Size = new System.Drawing.Size(127, 27);
            this.mskDatePardakht.TabIndex = 12;
            // 
            // mskDatePrint
            // 
            this.mskDatePrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDatePrint.Location = new System.Drawing.Point(239, 160);
            this.mskDatePrint.Margin = new System.Windows.Forms.Padding(4);
            this.mskDatePrint.Mask = "0000/00/00";
            this.mskDatePrint.Name = "mskDatePrint";
            this.mskDatePrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDatePrint.Size = new System.Drawing.Size(127, 27);
            this.mskDatePrint.TabIndex = 11;
            // 
            // intNumPrint
            // 
            this.intNumPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intNumPrint.Location = new System.Drawing.Point(239, 121);
            this.intNumPrint.Margin = new System.Windows.Forms.Padding(4);
            this.intNumPrint.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.intNumPrint.Name = "intNumPrint";
            this.intNumPrint.Size = new System.Drawing.Size(129, 27);
            this.intNumPrint.TabIndex = 10;
            // 
            // intPrice
            // 
            this.intPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intPrice.Location = new System.Drawing.Point(127, 236);
            this.intPrice.Margin = new System.Windows.Forms.Padding(4);
            this.intPrice.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.intPrice.Name = "intPrice";
            this.intPrice.Size = new System.Drawing.Size(240, 27);
            this.intPrice.TabIndex = 13;
            this.intPrice.ThousandsSeparator = true;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(375, 273);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 31);
            this.label16.TabIndex = 7;
            this.label16.Text = "بابت";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 31);
            this.label9.TabIndex = 7;
            this.label9.Text = "موبایل";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(375, 159);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 31);
            this.label15.TabIndex = 7;
            this.label15.Text = "تاریخ چاپ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(669, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "مقدار آب";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(375, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 31);
            this.label14.TabIndex = 7;
            this.label14.Text = "مهلت پرداخت";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(669, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "حبه";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(375, 235);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 31);
            this.label13.TabIndex = 7;
            this.label13.Text = "مبلغ کل";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(669, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "کدملی";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(375, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 31);
            this.label12.TabIndex = 7;
            this.label12.Text = "نام بانک";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "نام";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(375, 121);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 31);
            this.label11.TabIndex = 7;
            this.label11.Text = "شماره چاپ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(669, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "نام پدر";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(375, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 31);
            this.label10.TabIndex = 7;
            this.label10.Text = "احترام";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "نام خانوادگی";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFamily
            // 
            this.txtFamily.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamily.Location = new System.Drawing.Point(473, 46);
            this.txtFamily.Margin = new System.Windows.Forms.Padding(4);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(187, 27);
            this.txtFamily.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(473, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtHabe
            // 
            this.txtHabe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabe.Location = new System.Drawing.Point(473, 198);
            this.txtHabe.Margin = new System.Windows.Forms.Padding(4);
            this.txtHabe.Name = "txtHabe";
            this.txtHabe.Size = new System.Drawing.Size(187, 27);
            this.txtHabe.TabIndex = 5;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.Location = new System.Drawing.Point(473, 122);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(187, 27);
            this.txtFatherName.TabIndex = 2;
            // 
            // txtBank
            // 
            this.txtBank.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(168, 84);
            this.txtBank.Margin = new System.Windows.Forms.Padding(4);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(198, 27);
            this.txtBank.TabIndex = 9;
            // 
            // txtEhteram
            // 
            this.txtEhteram.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEhteram.Location = new System.Drawing.Point(168, 46);
            this.txtEhteram.Margin = new System.Windows.Forms.Padding(4);
            this.txtEhteram.Name = "txtEhteram";
            this.txtEhteram.Size = new System.Drawing.Size(198, 27);
            this.txtEhteram.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnExit);
            this.groupBox3.Controls.Add(this.BtnPrint);
            this.groupBox3.Location = new System.Drawing.Point(5, 456);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(761, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(8, 19);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(116, 41);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Enabled = false;
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Location = new System.Drawing.Point(617, 19);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(134, 41);
            this.BtnPrint.TabIndex = 0;
            this.BtnPrint.Text = "پیش نمایش";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // cmbMalekId
            // 
            this.cmbMalekId.DataSource = this.bsViewMalek;
            this.cmbMalekId.DisplayMember = "MalekId";
            this.cmbMalekId.Enabled = false;
            this.cmbMalekId.FormattingEnabled = true;
            this.cmbMalekId.Location = new System.Drawing.Point(306, 33);
            this.cmbMalekId.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMalekId.Name = "cmbMalekId";
            this.cmbMalekId.Size = new System.Drawing.Size(71, 27);
            this.cmbMalekId.TabIndex = 3;
            this.cmbMalekId.ValueMember = "Id";
            this.cmbMalekId.SelectedIndexChanged += new System.EventHandler(this.cmbMalek_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(260, 72);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 28);
            this.label17.TabIndex = 7;
            this.label17.Text = "جستجوی نام یا نام خانوادگی";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_BeratTak
            // 
            this.AcceptButton = this.BtnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(769, 540);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BeratTak";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_BeratTak_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMalek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotorkhaneh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBabat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intNumPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intPrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbMalek;
        private System.Windows.Forms.TextBox txtFilterMalek;
        private System.Windows.Forms.ComboBox cmbMotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.BindingSource bsMotorkhaneh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHabe;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtEhteram;
        private System.Windows.Forms.MaskedTextBox mskDatePardakht;
        private System.Windows.Forms.MaskedTextBox mskDatePrint;
        private System.Windows.Forms.NumericUpDown intNumPrint;
        private System.Windows.Forms.NumericUpDown intPrice;
        private System.Windows.Forms.ComboBox cmbBabat;
        private System.Windows.Forms.MaskedTextBox txtCodeMelli;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.NumericUpDown txtSec;
        private System.Windows.Forms.NumericUpDown txtMin;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.BindingSource bsBabat;
        private System.Windows.Forms.BindingSource bsViewMalek;
        private System.Windows.Forms.ComboBox cmbMalekFamily;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.ComboBox cmbMalekId;
        private System.Windows.Forms.Label label17;
    }
}