namespace BeratAj
{
    partial class frm_AddMotorkhaneh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddMotorkhaneh));
            this.bsViewMotor = new System.Windows.Forms.BindingSource(this.components);
            this.bsMotorkhaneh = new System.Windows.Forms.BindingSource(this.components);
            this.bsBank = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMedarAb = new System.Windows.Forms.TextBox();
            this.txtCode4 = new System.Windows.Forms.TextBox();
            this.txtNameMotorchi = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNameMotesadi = new System.Windows.Forms.TextBox();
            this.txtCodeSahraei = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.mskMobileMotesadi = new System.Windows.Forms.MaskedTextBox();
            this.mskPhoneMotesadi = new System.Windows.Forms.MaskedTextBox();
            this.mskMobileMotorchi = new System.Windows.Forms.MaskedTextBox();
            this.txtMinKol = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHabeKol = new System.Windows.Forms.TextBox();
            this.txtHabeMin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotorkhaneh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsViewMotor
            // 
            this.bsViewMotor.DataSource = typeof(BeratAj.ViewMotorkahneByBankName);
            // 
            // bsMotorkhaneh
            // 
            this.bsMotorkhaneh.DataSource = typeof(BeratAj.Motorkhane);
            // 
            // bsBank
            // 
            this.bsBank.DataSource = typeof(BeratAj.Bank);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Location = new System.Drawing.Point(15, 410);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(738, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(615, 17);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(116, 36);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "ثبت";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(599, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام موتورخانه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(599, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "کد4حرفی";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(599, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "مدارآب";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(267, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 27);
            this.label11.TabIndex = 4;
            this.label11.Text = "موبایل متصدی";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(599, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "حبه>دقیقه";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(267, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 27);
            this.label12.TabIndex = 4;
            this.label12.Text = "نام موتورچی";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(599, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "کدموتورخانه";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(599, 316);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "نام بانک";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(267, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "نام متصدی";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(599, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "دقیقه کل";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(599, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "کدصحرایی";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(267, 213);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 27);
            this.label14.TabIndex = 4;
            this.label14.Text = "موبایل موتورچی";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(599, 281);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "تعداد حبه";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(267, 144);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "تلفن متصدی";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(599, 350);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 27);
            this.label10.TabIndex = 4;
            this.label10.Text = "شماره حساب";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "Name", true));
            this.txtName.Location = new System.Drawing.Point(49, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(541, 27);
            this.txtName.TabIndex = 0;
            // 
            // txtMedarAb
            // 
            this.txtMedarAb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "MedarAb", true));
            this.txtMedarAb.Location = new System.Drawing.Point(441, 178);
            this.txtMedarAb.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedarAb.Name = "txtMedarAb";
            this.txtMedarAb.Size = new System.Drawing.Size(149, 27);
            this.txtMedarAb.TabIndex = 4;
            // 
            // txtCode4
            // 
            this.txtCode4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "Code4", true));
            this.txtCode4.Location = new System.Drawing.Point(441, 109);
            this.txtCode4.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode4.Name = "txtCode4";
            this.txtCode4.Size = new System.Drawing.Size(149, 27);
            this.txtCode4.TabIndex = 2;
            // 
            // txtNameMotorchi
            // 
            this.txtNameMotorchi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "NameMotorChi", true));
            this.txtNameMotorchi.Location = new System.Drawing.Point(49, 178);
            this.txtNameMotorchi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameMotorchi.Name = "txtNameMotorchi";
            this.txtNameMotorchi.Size = new System.Drawing.Size(210, 27);
            this.txtNameMotorchi.TabIndex = 13;
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(441, 75);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(149, 27);
            this.txtCode.TabIndex = 1;
            // 
            // txtNameMotesadi
            // 
            this.txtNameMotesadi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "NameMotesadi", true));
            this.txtNameMotesadi.Location = new System.Drawing.Point(49, 75);
            this.txtNameMotesadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameMotesadi.Name = "txtNameMotesadi";
            this.txtNameMotesadi.Size = new System.Drawing.Size(210, 27);
            this.txtNameMotesadi.TabIndex = 10;
            // 
            // txtCodeSahraei
            // 
            this.txtCodeSahraei.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "CodeSahraei", true));
            this.txtCodeSahraei.Location = new System.Drawing.Point(441, 144);
            this.txtCodeSahraei.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeSahraei.Name = "txtCodeSahraei";
            this.txtCodeSahraei.Size = new System.Drawing.Size(149, 27);
            this.txtCodeSahraei.TabIndex = 3;
            // 
            // txtAccount
            // 
            this.txtAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "ShomareHesab", true));
            this.txtAccount.Location = new System.Drawing.Point(441, 350);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(149, 27);
            this.txtAccount.TabIndex = 9;
            // 
            // cmbBank
            // 
            this.cmbBank.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "NameBank", true));
            this.cmbBank.DataSource = this.bsBank;
            this.cmbBank.DisplayMember = "NameBank";
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(436, 316);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(154, 27);
            this.cmbBank.TabIndex = 8;
            this.cmbBank.ValueMember = "Id";
            // 
            // mskMobileMotesadi
            // 
            this.mskMobileMotesadi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "MobileMotesadi", true));
            this.mskMobileMotesadi.Location = new System.Drawing.Point(131, 109);
            this.mskMobileMotesadi.Margin = new System.Windows.Forms.Padding(4);
            this.mskMobileMotesadi.Mask = "0000-000-0000";
            this.mskMobileMotesadi.Name = "mskMobileMotesadi";
            this.mskMobileMotesadi.Size = new System.Drawing.Size(127, 27);
            this.mskMobileMotesadi.TabIndex = 11;
            // 
            // mskPhoneMotesadi
            // 
            this.mskPhoneMotesadi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "PhoneMotesadi", true));
            this.mskPhoneMotesadi.Location = new System.Drawing.Point(131, 144);
            this.mskPhoneMotesadi.Margin = new System.Windows.Forms.Padding(4);
            this.mskPhoneMotesadi.Mask = "000-0000-0000";
            this.mskPhoneMotesadi.Name = "mskPhoneMotesadi";
            this.mskPhoneMotesadi.Size = new System.Drawing.Size(127, 27);
            this.mskPhoneMotesadi.TabIndex = 12;
            // 
            // mskMobileMotorchi
            // 
            this.mskMobileMotorchi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "MobileMotorChi", true));
            this.mskMobileMotorchi.Location = new System.Drawing.Point(131, 213);
            this.mskMobileMotorchi.Margin = new System.Windows.Forms.Padding(4);
            this.mskMobileMotorchi.Mask = "0000-000-0000";
            this.mskMobileMotorchi.Name = "mskMobileMotorchi";
            this.mskMobileMotorchi.Size = new System.Drawing.Size(127, 27);
            this.mskMobileMotorchi.TabIndex = 14;
            // 
            // txtMinKol
            // 
            this.txtMinKol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "MinKol", true));
            this.txtMinKol.Location = new System.Drawing.Point(441, 214);
            this.txtMinKol.Name = "txtMinKol";
            this.txtMinKol.Size = new System.Drawing.Size(149, 27);
            this.txtMinKol.TabIndex = 15;
            this.txtMinKol.Text = "0";
            this.txtMinKol.Leave += new System.EventHandler(this.txtMinKol_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHabeKol);
            this.groupBox1.Controls.Add(this.txtHabeMin);
            this.groupBox1.Controls.Add(this.txtMinKol);
            this.groupBox1.Controls.Add(this.mskMobileMotorchi);
            this.groupBox1.Controls.Add(this.mskPhoneMotesadi);
            this.groupBox1.Controls.Add(this.mskMobileMotesadi);
            this.groupBox1.Controls.Add(this.cmbBank);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.txtCodeSahraei);
            this.groupBox1.Controls.Add(this.txtNameMotesadi);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtNameMotorchi);
            this.groupBox1.Controls.Add(this.txtCode4);
            this.groupBox1.Controls.Add(this.txtMedarAb);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(738, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت اطلاعات موتورخانه";
            // 
            // txtHabeKol
            // 
            this.txtHabeKol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "HabeKol", true));
            this.txtHabeKol.Location = new System.Drawing.Point(441, 282);
            this.txtHabeKol.Name = "txtHabeKol";
            this.txtHabeKol.Size = new System.Drawing.Size(149, 27);
            this.txtHabeKol.TabIndex = 15;
            this.txtHabeKol.Text = "0";
            this.txtHabeKol.Leave += new System.EventHandler(this.txtHabeKol_Leave);
            // 
            // txtHabeMin
            // 
            this.txtHabeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewMotor, "HabeMin", true));
            this.txtHabeMin.Location = new System.Drawing.Point(441, 248);
            this.txtHabeMin.Name = "txtHabeMin";
            this.txtHabeMin.Size = new System.Drawing.Size(149, 27);
            this.txtHabeMin.TabIndex = 15;
            this.txtHabeMin.Text = "0";
            this.txtHabeMin.Leave += new System.EventHandler(this.txtHabeMin_Leave);
            // 
            // frm_AddMotorkhaneh
            // 
            this.AcceptButton = this.BtnSave;
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
            this.Name = "frm_AddMotorkhaneh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_AddMotorkhaneh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotorkhaneh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.BindingSource bsMotorkhaneh;
        private System.Windows.Forms.BindingSource bsBank;
        private System.Windows.Forms.BindingSource bsViewMotor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtHabeKol;
        private System.Windows.Forms.TextBox txtHabeMin;
        private System.Windows.Forms.TextBox txtMinKol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMedarAb;
        private System.Windows.Forms.TextBox txtCode4;
        private System.Windows.Forms.TextBox txtNameMotorchi;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNameMotesadi;
        private System.Windows.Forms.TextBox txtCodeSahraei;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.MaskedTextBox mskMobileMotesadi;
        private System.Windows.Forms.MaskedTextBox mskPhoneMotesadi;
        private System.Windows.Forms.MaskedTextBox mskMobileMotorchi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}