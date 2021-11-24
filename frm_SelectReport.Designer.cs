namespace BeratAj
{
    partial class frm_SelectReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SelectReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRptName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnPostBank = new System.Windows.Forms.Button();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnBerat = new System.Windows.Forms.Button();
            this.btnMotesadi = new System.Windows.Forms.Button();
            this.btnAlephba = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRptName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Controls.Add(this.btnPostBank);
            this.groupBox1.Controls.Add(this.btnBank);
            this.groupBox1.Controls.Add(this.btnBerat);
            this.groupBox1.Controls.Add(this.btnMotesadi);
            this.groupBox1.Controls.Add(this.btnAlephba);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(500, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب گزارش چاپ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRptName
            // 
            this.txtRptName.Location = new System.Drawing.Point(170, 125);
            this.txtRptName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRptName.Name = "txtRptName";
            this.txtRptName.Size = new System.Drawing.Size(201, 27);
            this.txtRptName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "نام گزارش";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(170, 197);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(156, 36);
            this.BtnExit.TabIndex = 12;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnPostBank
            // 
            this.btnPostBank.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostBank.Location = new System.Drawing.Point(57, 119);
            this.btnPostBank.Margin = new System.Windows.Forms.Padding(4);
            this.btnPostBank.Name = "btnPostBank";
            this.btnPostBank.Size = new System.Drawing.Size(105, 36);
            this.btnPostBank.TabIndex = 7;
            this.btnPostBank.Text = "انتخاب";
            this.btnPostBank.UseVisualStyleBackColor = true;
            this.btnPostBank.Click += new System.EventHandler(this.btnPostBank_Click);
            // 
            // btnBank
            // 
            this.btnBank.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBank.Image = ((System.Drawing.Image)(resources.GetObject("btnBank.Image")));
            this.btnBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBank.Location = new System.Drawing.Point(57, 66);
            this.btnBank.Margin = new System.Windows.Forms.Padding(4);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(156, 36);
            this.btnBank.TabIndex = 3;
            this.btnBank.Text = "بانک پیش فرض";
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnBerat
            // 
            this.btnBerat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerat.Image = ((System.Drawing.Image)(resources.GetObject("btnBerat.Image")));
            this.btnBerat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBerat.Location = new System.Drawing.Point(56, 26);
            this.btnBerat.Margin = new System.Windows.Forms.Padding(4);
            this.btnBerat.Name = "btnBerat";
            this.btnBerat.Size = new System.Drawing.Size(156, 36);
            this.btnBerat.TabIndex = 2;
            this.btnBerat.Text = "برات";
            this.btnBerat.UseVisualStyleBackColor = true;
            this.btnBerat.Click += new System.EventHandler(this.btnBerat_Click);
            // 
            // btnMotesadi
            // 
            this.btnMotesadi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotesadi.Image = ((System.Drawing.Image)(resources.GetObject("btnMotesadi.Image")));
            this.btnMotesadi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotesadi.Location = new System.Drawing.Point(294, 66);
            this.btnMotesadi.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotesadi.Name = "btnMotesadi";
            this.btnMotesadi.Size = new System.Drawing.Size(156, 36);
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
            this.btnAlephba.Location = new System.Drawing.Point(294, 26);
            this.btnAlephba.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlephba.Name = "btnAlephba";
            this.btnAlephba.Size = new System.Drawing.Size(156, 36);
            this.btnAlephba.TabIndex = 0;
            this.btnAlephba.Text = "لیست الفبایی";
            this.btnAlephba.UseVisualStyleBackColor = true;
            this.btnAlephba.Click += new System.EventHandler(this.btnAlephba_Click);
            // 
            // frm_SelectReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(512, 247);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            //this.Name = "frm_SelectReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_SelectReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button btnBerat;
        private System.Windows.Forms.Button btnMotesadi;
        private System.Windows.Forms.Button btnAlephba;
        private System.Windows.Forms.Button btnPostBank;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox txtRptName;
        private System.Windows.Forms.Label label1;
    }
}