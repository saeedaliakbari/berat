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

namespace BeratAj
{
    public partial class frm_EditUser : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();

        public static int id = 0;
        public static string Username = "";

        string passAdmin = "";
        string password = "";

        public frm_EditUser()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtPassOld, txtPassOld.Handle), 0x1501, 1, "ورود مقدار الزامی است");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassNew.Text == string.Empty)
                {
                    errorProvider1.SetError(txtPassNew, "ورود مقدار الزامی است");
                }
                else if (txtPassNewR.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtPassNewR, "ورود مقدار الزامی است");
                }
                else if (txtPassNew.Text != txtPassNewR.Text)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtPassNew, "مقدار یکسان نیست");
                }
                else
                {
                    db.UpdateUser(id, Username, txtPassNew.Text);
                    MessageBoxFarsi.Show("کاربر ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    this.Close();
                }

            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtPassOld_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.GetPassUser(id, ref password);
                db.GetPassAdmin(ref passAdmin);
                if (txtPassOld.Text == password || txtPassOld.Text == passAdmin)
                {
                    txtPassNew.Enabled = true;
                    txtPassNewR.Enabled = true;
                    txtPassOld.Enabled = false;
                    BtnSave.Enabled = true;
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
