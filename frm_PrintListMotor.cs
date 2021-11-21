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
using Stimulsoft.Report;

namespace BeratAj
{
    public partial class frm_PrintListMotor : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark
        
        public frm_PrintListMotor()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtFilter, txtFilter.Handle), 0x1501, 1, "جستجوی نام موتورخانه...");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrinBeratList_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMotor.Text == string.Empty)
                {
                    errorProvider1.SetError(cmbMotor, "ورود مقدار الزامی می باشد");
                }
                else
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptListBeratByMotor.mrt");
                    Report.Compile();

                    Report["motorid"] = cmbMotor.SelectedValue;


                    Report.ShowWithRibbonGUI();
                }

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
                    bsMotorkhane.DataSource = db.FilterMotorkhaneByName(txtFilter.Text);
                }
                else if (txtFilter.Text == string.Empty)
                {
                    bsMotorkhane.DataSource = db.FillMotorkhane();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_PrintListMotor_Load(object sender, EventArgs e)
        {
            try
            {
                bsMotorkhane.DataSource = db.FillMotorkhane();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
