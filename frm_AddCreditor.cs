using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using BehComponents;
using System.Runtime.InteropServices;

namespace BeratAj
{
    public partial class frm_AddCreditor : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();
        PersianCalendar pc = new PersianCalendar();
        string strtoday = "";
        int? Balances = 0;
        public frm_AddCreditor()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtFilter, txtFilter.Handle), 0x1501, 1, "جستجوی نام موتورخانه...");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMotor.Text == string.Empty)
                {
                    errorProvider1.SetError(cmbMotor, "ورود مقدار الزامی است");
                }
                else if (intPrice.Value == 0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(intPrice, "ورود مقدار الزامی است");
                }
                else if (mskDate.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(mskDate, "ورود مقدار الزامی است");
                }
                else
                {
                    errorProvider1.Clear();
                    db.InsertFactorCreditor((int)intFactorId.Value, (int)cmbMotor.SelectedValue, mskDate.Text, (int)intPrice.Value);
                    MessageBoxFarsi.Show("سند جدید ثبت شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    this.Close();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_AddCreditor_Load(object sender, EventArgs e)
        {
            strtoday = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            mskDate.Text = strtoday;
            intFactorId.Value = Convert.ToInt32(pc.GetYear(DateTime.Now).ToString("00") + pc.GetMonth(DateTime.Now).ToString("00") + pc.GetDayOfMonth(DateTime.Now).ToString("00") + pc.GetSecond(DateTime.Now).ToString("00"));
            bsMotorkhane.DataSource = db.FillMotorkhane();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFilter.Text != string.Empty)
                {
                    bsMotorkhane.DataSource = db.FilterMotorkhaneByName(txtFilter.Text);
                }else if (txtFilter.Text == string.Empty)
                {
                    bsMotorkhane.DataSource = db.FillMotorkhane();
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
                db.GetBalances((int)cmbMotor.SelectedValue, ref Balances);
                if ((int)Balances <= 0)
                {
                    lblBalance.ForeColor = Color.Red;
                    lblBalance.Text = ((int)Balances).ToString();
                }
                else
                {
                    lblBalance.ForeColor = Color.Green;
                    lblBalance.Text = ((int)Balances).ToString();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
