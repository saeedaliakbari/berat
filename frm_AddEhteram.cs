using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using BehComponents;
using System.Runtime.InteropServices;

namespace BeratAj
{
    public partial class frm_AddEhteram : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();
        public static bool IsEdit = false;
        public static string EhteramName = "";
        public static int Id = 0;

        public frm_AddEhteram()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtEhteram, txtEhteram.Handle), 0x1501, 1, "ورود مقدار الزامی است");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEhteram.Text == string.Empty)
                {
                    errorProvider1.SetError(txtEhteram, "ورود مقدار الزامی می باشد");
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        db.UpdateEhteram(Id, txtEhteram.Text);
                        MessageBoxFarsi.Show("احترام ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        this.Close();
                    }
                    else
                    {
                        db.InsertEhteram(txtEhteram.Text);
                        txtEhteram.Text = string.Empty;
                        txtEhteram.Focus();
                        MessageBoxFarsi.Show("احترام جدید افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    }
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_AddEhteram_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    groupBox1.Text = "ویرایش احترام";
                    bsEhteram.DataSource = db.FillEhteramById(Id);
                    txtEhteram.Text = EhteramName;
                }
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
    }
}
