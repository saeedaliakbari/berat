using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;//برای watermark
using BehComponents;

namespace BeratAj
{
    public partial class frm_Login : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark
        dcBeratDataContext db = new dcBeratDataContext();

        bool? checkname = false;
        bool? checkpass = false;
        int? iduseractive = 0;
        public frm_Login()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtUser, txtUser.Handle), 0x1501, 1, "ورود مقدار الزامی است");
            SendMessage(new HandleRef(txtPass, txtPass.Handle), 0x1501, 1, "ورود مقدار الزامی است");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                db.CheckUser(ref checkname, txtUser.Text);
                db.CheckPass(ref checkpass, txtPass.Text);
                if (checkname == false || checkpass == false)
                {
                    errorProvider1.SetError(txtUser, "نام کاربری یا رمز عبور صحیح نمی باشد");
                }
                else
                {
                    errorProvider1.Clear();
                    frm_Main.useractive = txtUser.Text;
                    db.GetIdUserActive(ref iduseractive, txtUser.Text);
                    frm_Main.iduseractive = (int)iduseractive;
                    this.Close();
                }
            }
            catch 
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
