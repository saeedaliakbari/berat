using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BehComponents;
using System.Globalization;
using JntNum2Text;
using Stimulsoft.Report;

namespace BeratAj
{
    public partial class frm_ListMalekin : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark
        dcBeratDataContext db = new dcBeratDataContext();
        private Num2Text change = new Num2Text();
        PersianCalendar pc = new PersianCalendar();

        int Mablagh = 0;
        int Minute = 0;
        int Seconds = 0;
        int SumSec = 0;
        int SumMablagh = 0;

        double MinPrice = 0;

        string strtoday = "";

        int? Min = 0;
        int? SumMalek = 0;
        int? MinKol = 0;

        double? Sec = 0;
        public frm_ListMalekin()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtFilter, txtFilter.Handle), 0x1501, 1, "جستجوی نام موتورخانه...");
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFilter.Text != string.Empty)
                {
                    bsMotorkhaneh.DataSource = db.FilterMotorkhaneByName(txtFilter.Text);
                } else if (txtFilter.Text == string.Empty)
                {
                    bsMotorkhaneh.DataSource = db.FillMotorkhane();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_ListMalekin_Load(object sender, EventArgs e)
        {
            strtoday = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            mskDatePrint.Text = strtoday;
            bsMotorkhaneh.DataSource = db.FillMotorkhane();
        }

        private void btnAlephba_Click(object sender, EventArgs e)
        {
            //try
            //{

            bsViewMalekin.DataSource = db.FillViewMalkinAlphba((int)cmbMotor.SelectedValue);
            db.GetSumMin((int)cmbMotor.SelectedValue, ref Min, ref Sec);
            if (Sec >= 60)
            {
                Min += (int)Sec / 60;
                Sec = Sec % 60;
            }
            db.GetSumTedadMalek((int)cmbMotor.SelectedValue, ref SumMalek);
            db.GetMinKolMotor((int)cmbMotor.SelectedValue, ref MinKol);
            
            StiReport Report = new StiReport();

            Report.Load("Reports/RptListAlphbatic1.mrt");
            Report.Compile();

            Report["MotorkhaneId"] = cmbMotor.SelectedValue;
            Report["DateToday"] = mskDatePrint.Text;
            Report["PrintNum"] = (int)intNumPrint.Value;
            Report["PriceKol"] = (long)intPrice.Value;
            Report["SumMalek"] = SumMalek;
            Report["Min"] = Min.ToString();
            Report["Sec"] = Sec.ToString();
            Report.ShowWithRibbonGUI();

            //}
            //catch
            //{
            //    MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            //}
        }

        private void btnMotesadi_Click(object sender, EventArgs e)
        {
            //try
            //{

            bsViewMalekin.DataSource = db.FillViewMalkinAlphba((int)cmbMotor.SelectedValue);
            db.GetSumMin((int)cmbMotor.SelectedValue, ref Min, ref Sec);
            if (Sec >= 60)
            {
                Min += (int)Sec / 60;
                Sec = Sec % 60;
            }
            db.GetSumTedadMalek((int)cmbMotor.SelectedValue, ref SumMalek);
            db.GetMinKolMotor((int)cmbMotor.SelectedValue, ref MinKol);
            
            StiReport Report = new StiReport();

            Report.Load("Reports/RptList1.mrt");
            Report.Compile();

            Report["MotorkhaneId"] = (int)cmbMotor.SelectedValue;
            Report["DateToday"] = mskDatePrint.Text;
            Report["PrintNum"] = (int)intNumPrint.Value;
            Report["PriceKol"] = (long)intPrice.Value;
            Report["SumMalek"] = SumMalek;
            Report["Min"] = Min.ToString();
            Report["Sec"] = Sec.ToString();
            Report.ShowWithRibbonGUI();

        }
        //catch
        //{
        //    MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
        //}

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}