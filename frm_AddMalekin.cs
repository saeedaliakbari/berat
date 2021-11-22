using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using Stimulsoft.Report;
using System.Globalization;

namespace BeratAj
{
    public partial class frm_AddMalekin : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();
        PersianCalendar pc = new PersianCalendar();

        public static int MotorkhaneId = 0;

        public static string MotorkhaneName = "";

        int? SumMalek = 0;
        int? MinKolMotor = 0;
        int? HabeMin = 0;

        bool? ExistMalekId = false;
        bool IsEdit = false;

        int? Min = 0;
        double? Sec = 0;

        int Habe = 0;
        int Habedec = 0;
        string strHabe = "";

        int ekhMin;
        double ekhSec;

        string strtoday = "";
        public frm_AddMalekin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AddMalekin_Load(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Text = "ثبت مالکین موتورخانه" + " " + MotorkhaneName;
                db.GetSumTedadMalek(MotorkhaneId, ref SumMalek);
                db.GetHabeMin(MotorkhaneId, ref HabeMin);
                strtoday= pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
                //bsMalekin.DataSource = db.FillMalek(MotorkhaneId);
                bsViewMalek.DataSource = db.FillViewMalek(MotorkhaneId);
                bsEhteram.DataSource = db.FillEhteram();
                db.GetMinKolMotor(MotorkhaneId, ref MinKolMotor);
                lblMinMotor.Text = "دقیقه کل" + "=" + MinKolMotor.ToString();
                db.GetSumMin(MotorkhaneId, ref Min, ref Sec);
                if (Sec >= 100)
                {
                    Min += (int)Sec / 100;
                    Sec = Sec % 100;
                }
                lblMinkol.Text = "دقیقه کل مالکین" + "=" + Min.ToString() + ":" + Sec.ToString();
                
                if (Sec != 0)
                {
                    ekhMin = Convert.ToInt32(MinKolMotor - Min - 1);
                    ekhSec = Convert.ToDouble(100 - Sec);
                }
                else
                {
                    ekhMin = Convert.ToInt32(MinKolMotor - Min);
                }
                lblMinus.Text = "اختلاف" + "=" + ekhMin.ToString() + ":" + ekhSec.ToString();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
                }
                else
                {
                    BtnEdit.Enabled = true;
                    BtnDelete.Enabled = true;
                }


            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit == true)
                {
                    errorProvider1.Clear();
                    db.UpdateMalek((int)dataGridView1.CurrentRow.Cells[0].Value, Convert.ToInt32(txtMalekId.Text), MotorkhaneId, txtName.Text, txtFamily.Text, (int)cmbEhteram.SelectedValue, txtFatherName.Text, Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtSec.Text), txtHabe.Text, mskMelliCode.Text, mskMobile.Text);
                    MessageBoxFarsi.Show("مالک ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtName.Text = string.Empty;
                    txtFamily.Text = string.Empty;
                    cmbEhteram.Text = string.Empty;
                    txtFatherName.Text = string.Empty;
                    txtMin.Text = "0";
                    txtSec.Text = "0";
                    txtHabe.Text = string.Empty;
                    mskMelliCode.Text = string.Empty;
                    mskMobile.Text = string.Empty;
                    txtMalekId.Focus();
                    db = new dcBeratDataContext();
                    bsViewMalek.DataSource = db.FillViewMalek(MotorkhaneId);
                    bsEhteram.DataSource = db.FillEhteram();
                    db.GetSumMin(MotorkhaneId, ref Min, ref Sec);
                    if (Sec >= 100)
                    {
                        Min += (int)Sec / 100;
                        Sec = Sec % 100;
                    }
                    lblMinkol.Text = "دقیقه کل مالکین" + "=" + Min.ToString() + ":" + Sec.ToString();

                    if (Sec != 0)
                    {
                        ekhMin = Convert.ToInt32(MinKolMotor - Min - 1);
                        ekhSec = Convert.ToDouble(100 - Sec);
                    }
                    else
                    {
                        ekhMin = Convert.ToInt32(MinKolMotor - Min);
                    }
                    lblMinus.Text = "اختلاف" + "=" + ekhMin.ToString() + ":" + ekhSec.ToString();
                    dataGridView1.Enabled = true;
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnEdit.Enabled = false;
                        BtnDelete.Enabled = false;
                    }
                    else
                    {
                        BtnEdit.Enabled = true;
                        BtnDelete.Enabled = true;
                    }
                    txtMalekId.Text = "0";
                    txtName.Text = string.Empty;
                    txtFamily.Text = string.Empty;
                    cmbEhteram.Text = string.Empty;
                    txtFatherName.Text = string.Empty;
                    txtMin.Text = "0";
                    txtSec.Text = "0";
                    txtHabe.Text = string.Empty;
                    mskMelliCode.Text = string.Empty;
                    mskMobile.Text = string.Empty;
                    txtMalekId.Focus();
                    IsEdit = false;
                    txtMalekId.Enabled = true;
                }
                else
                {
                    errorProvider1.Clear();
                    db.ExistMalekId(ref ExistMalekId, MotorkhaneId, Int32.Parse(txtMalekId.Text));
                    if (txtMalekId.Text=="0" || txtMalekId.Text==string.Empty)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(txtMalekId, "مقدار صفر نمیتواند باشد");
                    }
                    else if ((bool)ExistMalekId != true)
                    {
                        errorProvider1.Clear();
                        db.InsertMalek(Convert.ToInt32(txtMalekId.Text), MotorkhaneId, txtName.Text, txtFamily.Text, (int)cmbEhteram.SelectedValue, txtFatherName.Text, Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtSec.Text), txtHabe.Text, mskMelliCode.Text, mskMobile.Text);
                        bsViewMalek.DataSource = db.FillViewMalek(MotorkhaneId);
                        bsEhteram.DataSource = db.FillEhteram();
                        db.GetSumMin(MotorkhaneId, ref Min, ref Sec);
                        if (Sec >= 100)
                        {
                            Min += (int)Sec / 100;
                            Sec = Sec % 100;
                        }
                        lblMinkol.Text = "دقیقه کل مالکین" + "=" + Min.ToString() + ":" + Sec.ToString();

                        if (Sec != 0)
                        {
                            ekhMin = Convert.ToInt32(MinKolMotor - Min - 1);
                            ekhSec = Convert.ToDouble(100 - Sec);
                        }
                        else
                        {
                            ekhMin = Convert.ToInt32(MinKolMotor - Min);
                        }
                        lblMinus.Text = "اختلاف" + "=" + ekhMin.ToString() + ":" + ekhSec.ToString();
                        if (dataGridView1.Rows.Count == 0)
                        {
                            BtnEdit.Enabled = false;
                            BtnDelete.Enabled = false;
                        }
                        else
                        {
                            BtnEdit.Enabled = true;
                            BtnDelete.Enabled = true;
                        }
                        txtMalekId.Text = "0";
                        txtName.Text = string.Empty;
                        txtFamily.Text = string.Empty;
                        cmbEhteram.Text = string.Empty;
                        txtFatherName.Text = string.Empty;
                        txtMin.Text = "0";
                        txtSec.Text = "0";
                        txtHabe.Text = string.Empty;
                        mskMelliCode.Text = string.Empty;
                        mskMobile.Text = string.Empty;
                        txtMalekId.Focus();
                    }
                    else
                    {
                        MessageBoxFarsi.Show("شماره مالکیت تکراری است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Stop, MessageBoxFarsiDefaultButton.Button1);
                    }
                }

            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bsMalekin.DataSource = db.FillMalekById((int)dataGridView1.CurrentRow.Cells[0].Value);
                txtMalekId.Enabled = false;
                //txtName.Enabled = true;
                //txtFamily.Enabled = true;
                //cmbEhteram.Enabled = true;
                //txtFatherName.Enabled = true;
                //intMin.Enabled = true;
                //dblSec.Enabled = true;
                //txtHabe.Enabled = true;
                //mskMelliCode.Enabled = true;
                //mskMobile.Enabled = true;
                txtName.Focus();
                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;
                dataGridView1.Enabled = false;
                IsEdit = true;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBoxFarsi.Show("آیا مالک با مشخصات زیر حذف گردد؟"+"\n"+"شماره مالکیت"+ dataGridView1.CurrentRow.Cells[1].Value+" "+ dataGridView1.CurrentRow.Cells[5].Value + " " + dataGridView1.CurrentRow.Cells[3].Value + " " + dataGridView1.CurrentRow.Cells[4].Value , "اخطار", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
            {
                db.DeleteMalek((int)dataGridView1.CurrentRow.Cells[0].Value);
                txtName.Text = string.Empty;
                txtFamily.Text = string.Empty;
                cmbEhteram.Text = string.Empty;
                txtFatherName.Text = string.Empty;
                txtMin.Text = "0";
                txtSec.Text = "0";
                txtHabe.Text = string.Empty;
                mskMelliCode.Text = string.Empty;
                mskMobile.Text = string.Empty;
                txtMalekId.Focus();
                bsViewMalek.DataSource = db.FillViewMalek(MotorkhaneId);
                bsEhteram.DataSource = db.FillEhteram();
                db.GetSumMin(MotorkhaneId, ref Min, ref Sec);
                if (Sec >= 100)
                {
                    Min += (int)Sec / 100;
                    Sec = Sec % 100;
                }
                lblMinkol.Text = "دقیقه کل مالکین" + "=" + Min.ToString() + ":" + Sec.ToString();

                if (Sec != 0)
                {
                    ekhMin = Convert.ToInt32(MinKolMotor - Min - 1);
                    ekhSec = Convert.ToDouble(100 - Sec);
                }
                else
                {
                    ekhMin = Convert.ToInt32(MinKolMotor - Min);
                }
                lblMinus.Text = "اختلاف" + "=" + ekhMin.ToString() + ":" + ekhSec.ToString();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
                }
                else
                {
                    BtnEdit.Enabled = true;
                    BtnDelete.Enabled = true;
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //bsViewMalek.DataSource = db.FillViewMalkin(MotorkhaneId);
                //bsViewMotorkhane.DataSource = db.FillViewMotorkhaneById(MotorkhaneId);
                StiReport Report = new StiReport();

                Report.Load("Reports/RptListMalek.mrt");
                Report.Compile();

                Report["IdMotorkhaneh"] = MotorkhaneId;
                Report["StrDate"] = strtoday;
                Report["SumMalek"] = (int)SumMalek;
                Report["Min"] = (int)Min;
                Report["Sec"] = (double)Sec;
                Report.ShowWithRibbonGUI();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void intMin_ValueChanged(object sender, EventArgs e)
        {
            if (txtSec.Text == string.Empty)
                txtSec.Text = "0";
            if (txtMin.Text == string.Empty)
                txtMin.Text = "0";
            int sum = Int32.Parse(txtMin.Text)*100 + Int32.Parse(txtSec.Text);
            //int Habeminlocal = (int)HabeMin;
            int Habeminlocal = (int)HabeMin*100;
            Habe = (int)(sum / Habeminlocal);
            Habedec = (int)(sum% Habeminlocal);
            int gcd = Fraction.GCD(Habedec, Habeminlocal);
            if (Habedec != 0)
            {
                while (gcd > 1)
                {
                    Habedec = Habedec / gcd;
                    Habeminlocal = Habeminlocal / gcd;
                    gcd = Fraction.GCD(Habedec, Habeminlocal);
                }
                if (Habe == 0)
                {
                    strHabe = JntNum2Text.Num2Text.ToFarsi(Habedec) + " " + JntNum2Text.Num2Text.ToFarsi(Habeminlocal) + "م";
                }
                else
                    strHabe = JntNum2Text.Num2Text.ToFarsi(Habe) + " و" + JntNum2Text.Num2Text.ToFarsi(Habedec) + " " + JntNum2Text.Num2Text.ToFarsi(Habeminlocal) + "م";
            }
            else
                strHabe = JntNum2Text.Num2Text.ToFarsi(Habe);
            //sum = sum / Habeminlocal;
            //strHabe = JntNum2Text.Num2Text.ToFarsi(Habe);
            //MessageBox.Show(strHabe);
            lblHabe.Text = strHabe;
            
        }

        private void txtMalekId_Leave(object sender, EventArgs e)
        {
            if (txtMalekId.Text==string.Empty)
            {
                txtMalekId.Text = "0";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bsMalekin.DataSource = db.FillMalekById((int)dataGridView1.CurrentRow.Cells[0].Value);
                txtMalekId.Enabled = false;
                //txtName.Enabled = true;
                //txtFamily.Enabled = true;
                //cmbEhteram.Enabled = true;
                //txtFatherName.Enabled = true;
                //intMin.Enabled = true;
                //dblSec.Enabled = true;
                //txtHabe.Enabled = true;
                //mskMelliCode.Enabled = true;
                //mskMobile.Enabled = true;
                txtName.Focus();
                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;
                dataGridView1.Enabled = false;
                IsEdit = true;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMalekId.Text = "0";
            txtName.Text = string.Empty;
            txtFamily.Text = string.Empty;
            cmbEhteram.Text = string.Empty;
            txtFatherName.Text = string.Empty;
            txtMin.Text = "0";
            txtSec.Text = "0";
            txtHabe.Text = string.Empty;
            mskMelliCode.Text = string.Empty;
            mskMobile.Text = string.Empty;
            txtMalekId.Focus();
            IsEdit = false;
            txtMalekId.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                //bsViewMalek.DataSource = db.FillViewMalkin(MotorkhaneId);
                //bsViewMotorkhane.DataSource = db.FillViewMotorkhaneById(MotorkhaneId);
                StiReport Report = new StiReport();
                //Report.ExportDocument(StiExportFormat.Excel,"d:\\1.xlsx")
                Report.Load("Reports/RptListExcell.mrt");
                Report.Compile();

                Report["IdMotorkhaneh"] = MotorkhaneId;
                Report["StrDate"] = strtoday;
                Report["SumMalek"] = (int)SumMalek;
                Report["Min"] = (int)Min;
                Report["Sec"] = (double)Sec;
                Report.ShowWithRibbonGUI();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
