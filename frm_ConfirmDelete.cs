using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using System.Runtime.InteropServices;

namespace BeratAj
{
    public partial class frm_ConfirmDelete : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();

        public static bool ConfirmMode = false;//true motorkhane,fals user
        public static int id = 0;

        public static string pass = "";
        public static string passAdmin = "";
        public frm_ConfirmDelete()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtpass, txtpass.Handle), 0x1501, 1, "رمز کاربر Admin را واردکنید");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpass.Text == pass || txtpass.Text == passAdmin.ToString())
                {
                    errorProvider1.Clear();
                    if (MessageBoxFarsi.Show("مطمئن به حذف هستید ؟", "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (ConfirmMode == false)
                        {
                            db.DeleteUser(id);
                            MessageBoxFarsi.Show("کاربر حذف شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        }
                        else
                        {
                            db.DeleteMotorkhane(id);
                            MessageBoxFarsi.Show("موتورخانه حذف شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        }

                        this.Close();
                    }
                }
                else
                {
                    errorProvider1.SetError(txtpass, "رمز عبور صحیح نمی باشد");
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_ConfirmDelete_Load(object sender, EventArgs e)
        {
            db.GetPassAdmin(ref passAdmin);
        }
    }
}
