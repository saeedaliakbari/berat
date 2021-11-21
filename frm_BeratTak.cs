using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using JntNum2Text;
using System.Globalization;

namespace BeratAj
{
    public partial class frm_BeratTak : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();
        PersianCalendar pc = new PersianCalendar();
        private Num2Text change = new Num2Text();

        int? MalekId = 0;
        string Name = "";
        string Family = "";
        string Ehteram = "";
        string FatherName = "";
        int? MinAb = 0;
        double? SecAb = 0;
        string Habe = "";
        string CodeMelli = "";
        string Mobile = "";
        int? MinKol = 0;
        string BankName = "";

        long Mablagh = 0;
        double Sadgan = 0;
        string HorofMablagh = "";
        double MinPrice = 0;
        int SumSec = 0;
        string strToday = "";
        string strMohalt = "";
        public frm_BeratTak()
        {
            InitializeComponent();
        }

        private void frm_BeratTak_Load(object sender, EventArgs e)
        {
            try
            {
                strToday = pc.GetYear(DateTime.Now).ToString("0000") + pc.GetMonth(DateTime.Now).ToString("00") + pc.GetDayOfMonth(DateTime.Now).ToString("00");
                strMohalt = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now.AddDays(20)).ToString("00");
                mskDatePardakht.Text = strMohalt;
                mskDatePrint.Text = strToday;
                bsMotorkhaneh.DataSource = db.FillMotorkhane();
                bsBabat.DataSource = db.FillBabat();
                BtnSelect.Enabled = false;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFilter.Text != string.Empty)
                {
                    bsMotorkhaneh.DataSource = db.FilterMotorkhaneByName(txtFilter.Text);
                }
                else if(txtFilter.Text==string.Empty)
                {
                    bsMotorkhaneh.DataSource = db.FillMotorkhane();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void cmbMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bsViewMalek.DataSource = db.FillViewMalek((int)cmbMotor.SelectedValue);
                txtFilterMalek.Enabled = true;
                cmbMalek.Enabled = true;
                cmbMalekFamily.Enabled = true;
                cmbMalekId.Enabled = true;
                BtnSelect.Enabled = true;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtFilterMalek_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFilterMalek.Text!=string.Empty)
                {
                    bsViewMalek.DataSource = db.FilteMalekByName(txtFilterMalek.Text, (int)cmbMotor.SelectedValue);

                }
                else if (txtFilterMalek.Text == string.Empty)
                {
                    bsViewMalek.DataSource = db.FillViewMalek((int)cmbMotor.SelectedValue);
                }
                
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void cmbMalek_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BtnSelect.Enabled = true;

            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = true;
                db.GetMalekById((int)cmbMalek.SelectedValue, (int)cmbMotor.SelectedValue, ref MalekId, ref Name, ref Family, ref Ehteram, ref FatherName, ref MinAb, ref SecAb, ref Habe, ref CodeMelli, ref Mobile);
                db.GetBankName((int)cmbMotor.SelectedValue, ref BankName);
                txtName.Text = Name;
                txtFamily.Text = Family;
                txtEhteram.Text = Ehteram;
                txtFatherName.Text = FatherName;
                txtCodeMelli.Text = CodeMelli;
                txtHabe.Text = Habe;
                txtMin.Value = (int)MinAb;
                txtMobile.Text = Mobile;
                txtSec.Value = (int)SecAb;
                txtBank.Text = BankName;
                BtnPrint.Enabled = true;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                db.GetMinKolMotor((int)cmbMotor.SelectedValue, ref MinKol);
                MinPrice = (long)intPrice.Value / (int)MinKol;
                SumSec = Convert.ToInt32(txtMin.Text) * 100 + Convert.ToInt32(txtSec.Text);
                Mablagh = Convert.ToInt64(SumSec * ((double)intPrice.Value / (int)MinKol) *0.01);
                Sadgan = (long)Mablagh % 1000;
                Mablagh = (long)Mablagh - (long)Sadgan;
                if (Sadgan != 0)
                {
                    Mablagh += 1000;
                }
                HorofMablagh = Num2Text.ToFarsi(Mablagh);
                //MessageBoxFarsi.Show(MinPrice.ToString() + Environment.NewLine + SumSec.ToString() + Environment.NewLine + Mablagh.ToString() + Environment.NewLine + HorofMablagh.ToString());
                frm_SelectReport.MotorId = (int)cmbMotor.SelectedValue;
                frm_SelectReport.MalekId = (int)MalekId;
                frm_SelectReport.Ehteram = txtEhteram.Text;
                frm_SelectReport.Name = txtName.Text;
                frm_SelectReport.Family = txtFamily.Text;
                frm_SelectReport.FatherName = txtFatherName.Text;
                frm_SelectReport.Min = txtMin.Text;
                frm_SelectReport.Sec = txtSec.Text;
                frm_SelectReport.Babat = cmbBabat.Text;
                frm_SelectReport.PrintDate = mskDatePrint.Text;
                frm_SelectReport.Mohlat = mskDatePardakht.Text;
                frm_SelectReport.PrintNumber = (int)intNumPrint.Value;
                frm_SelectReport.Habe = txtHabe.Text;
                frm_SelectReport.IntPrice = (long)intPrice.Value;
                frm_SelectReport.MelliCode = txtCodeMelli.Text;
                frm_SelectReport.Mobile = txtMobile.Text;
                frm_SelectReport.MablaghHorof = HorofMablagh;
                frm_SelectReport.Mablagh = (long)Mablagh;
                frm_SelectReport.MinPrice = MinPrice;
                frm_SelectReport.IsTak = true;
                new frm_SelectReport().ShowDialog();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
