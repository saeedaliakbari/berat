namespace BeratAj
{
    partial class frm_EditMalekId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditMalekId));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intMalekId = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
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
            this.bsViewMalek = new System.Windows.Forms.BindingSource(this.components);
            this.bsMalekin = new System.Windows.Forms.BindingSource(this.components);
            this.bsViewMotorkhane = new System.Windows.Forms.BindingSource(this.components);
            this.bsEhteram = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMalek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMalekin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMotorkhane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEhteram)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(866, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "شماره مالکیت";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 594);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.intMalekId);
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1018, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات مالکین";
            // 
            // intMalekId
            // 
            this.intMalekId.Location = new System.Drawing.Point(759, 27);
            this.intMalekId.Name = "intMalekId";
            this.intMalekId.Size = new System.Drawing.Size(100, 27);
            this.intMalekId.TabIndex = 6;
            this.intMalekId.Text = "0";
            this.intMalekId.Leave += new System.EventHandler(this.intMalekId_Leave);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(9, 21);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(116, 36);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(133, 21);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(116, 36);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "ثبت";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.mobileDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsViewMalek;
            this.dataGridView1.Location = new System.Drawing.Point(7, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 507);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // malekIdDataGridViewTextBoxColumn
            // 
            this.malekIdDataGridViewTextBoxColumn.DataPropertyName = "MalekId";
            this.malekIdDataGridViewTextBoxColumn.HeaderText = "شماره مالکیت";
            this.malekIdDataGridViewTextBoxColumn.Name = "malekIdDataGridViewTextBoxColumn";
            this.malekIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.malekIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // motorkhaneIdDataGridViewTextBoxColumn
            // 
            this.motorkhaneIdDataGridViewTextBoxColumn.DataPropertyName = "MotorkhaneId";
            this.motorkhaneIdDataGridViewTextBoxColumn.HeaderText = "MotorkhaneId";
            this.motorkhaneIdDataGridViewTextBoxColumn.Name = "motorkhaneIdDataGridViewTextBoxColumn";
            this.motorkhaneIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.motorkhaneIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 110;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            this.familyDataGridViewTextBoxColumn.Width = 150;
            // 
            // ehteramDataGridViewTextBoxColumn
            // 
            this.ehteramDataGridViewTextBoxColumn.DataPropertyName = "Ehteram";
            this.ehteramDataGridViewTextBoxColumn.HeaderText = "احترام";
            this.ehteramDataGridViewTextBoxColumn.Name = "ehteramDataGridViewTextBoxColumn";
            this.ehteramDataGridViewTextBoxColumn.ReadOnly = true;
            this.ehteramDataGridViewTextBoxColumn.Width = 75;
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "نام پدر";
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fatherNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // minAbDataGridViewTextBoxColumn
            // 
            this.minAbDataGridViewTextBoxColumn.DataPropertyName = "MinAb";
            this.minAbDataGridViewTextBoxColumn.HeaderText = "دقیقه آب";
            this.minAbDataGridViewTextBoxColumn.Name = "minAbDataGridViewTextBoxColumn";
            this.minAbDataGridViewTextBoxColumn.ReadOnly = true;
            this.minAbDataGridViewTextBoxColumn.Width = 65;
            // 
            // secAbDataGridViewTextBoxColumn
            // 
            this.secAbDataGridViewTextBoxColumn.DataPropertyName = "SecAb";
            this.secAbDataGridViewTextBoxColumn.HeaderText = "ثانیه آب";
            this.secAbDataGridViewTextBoxColumn.Name = "secAbDataGridViewTextBoxColumn";
            this.secAbDataGridViewTextBoxColumn.ReadOnly = true;
            this.secAbDataGridViewTextBoxColumn.Width = 70;
            // 
            // habeDataGridViewTextBoxColumn
            // 
            this.habeDataGridViewTextBoxColumn.DataPropertyName = "Habe";
            this.habeDataGridViewTextBoxColumn.HeaderText = "حبه";
            this.habeDataGridViewTextBoxColumn.Name = "habeDataGridViewTextBoxColumn";
            this.habeDataGridViewTextBoxColumn.ReadOnly = true;
            this.habeDataGridViewTextBoxColumn.Width = 140;
            // 
            // codeMelliDataGridViewTextBoxColumn
            // 
            this.codeMelliDataGridViewTextBoxColumn.DataPropertyName = "CodeMelli";
            this.codeMelliDataGridViewTextBoxColumn.HeaderText = "کدملی";
            this.codeMelliDataGridViewTextBoxColumn.Name = "codeMelliDataGridViewTextBoxColumn";
            this.codeMelliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "موبایل";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsViewMalek
            // 
            this.bsViewMalek.DataSource = typeof(BeratAj.ViewMalekin);
            // 
            // bsMalekin
            // 
            this.bsMalekin.DataSource = typeof(BeratAj.Malekin);
            // 
            // bsViewMotorkhane
            // 
            this.bsViewMotorkhane.DataSource = typeof(BeratAj.ViewMotorkahneByBankName);
            // 
            // bsEhteram
            // 
            this.bsEhteram.DataSource = typeof(BeratAj.Ehteram);
            // 
            // frm_EditMalekId
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(1032, 594);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_EditMalekId";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditMalekId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMalek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMalekin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewMotorkhane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEhteram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bsViewMalek;
        private System.Windows.Forms.BindingSource bsMalekin;
        private System.Windows.Forms.BindingSource bsEhteram;
        private System.Windows.Forms.Button BtnSave;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsViewMotorkhane;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox intMalekId;
    }
}