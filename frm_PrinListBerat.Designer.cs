namespace BeratAj
{
    partial class frm_PrinListBerat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PrinListBerat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskDateStart = new System.Windows.Forms.MaskedTextBox();
            this.mskDateEnd = new System.Windows.Forms.MaskedTextBox();
            this.btnPrinBeratList = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskDateEnd);
            this.groupBox1.Controls.Add(this.mskDateStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب تاریخ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Controls.Add(this.btnPrinBeratList);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(208, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "تاریخ ابتدا";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(208, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "تاریخ انتها";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mskDateStart
            // 
            this.mskDateStart.Location = new System.Drawing.Point(73, 40);
            this.mskDateStart.Margin = new System.Windows.Forms.Padding(4);
            this.mskDateStart.Mask = "0000/00/00";
            this.mskDateStart.Name = "mskDateStart";
            this.mskDateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDateStart.Size = new System.Drawing.Size(127, 27);
            this.mskDateStart.TabIndex = 0;
            // 
            // mskDateEnd
            // 
            this.mskDateEnd.Location = new System.Drawing.Point(73, 87);
            this.mskDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.mskDateEnd.Mask = "0000/00/00";
            this.mskDateEnd.Name = "mskDateEnd";
            this.mskDateEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDateEnd.Size = new System.Drawing.Size(127, 27);
            this.mskDateEnd.TabIndex = 1;
            // 
            // btnPrinBeratList
            // 
            this.btnPrinBeratList.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinBeratList.Image")));
            this.btnPrinBeratList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrinBeratList.Location = new System.Drawing.Point(231, 17);
            this.btnPrinBeratList.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrinBeratList.Name = "btnPrinBeratList";
            this.btnPrinBeratList.Size = new System.Drawing.Size(94, 36);
            this.btnPrinBeratList.TabIndex = 0;
            this.btnPrinBeratList.Text = "پرینت";
            this.btnPrinBeratList.UseVisualStyleBackColor = true;
            this.btnPrinBeratList.Click += new System.EventHandler(this.btnPrinBeratList_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(7, 17);
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
            // frm_PrinListBerat
            // 
            this.AcceptButton = this.btnPrinBeratList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(356, 224);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_PrinListBerat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskDateEnd;
        private System.Windows.Forms.MaskedTextBox mskDateStart;
        private System.Windows.Forms.Button btnPrinBeratList;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}