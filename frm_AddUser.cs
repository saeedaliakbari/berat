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
    public partial class frm_AddUser : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();

        public static bool ExitType = false;

        bool? Existusername = false;
        public frm_AddUser()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtPass, txtPass.Handle), 0x1501, 1, "ورود مقدار الزامی است");
            SendMessage(new HandleRef(txtUser, txtUser.Handle), 0x1501, 1, "ورود مقدار الزامی است");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //چک شود نام کاربری تکراری نباشد
                if (ExitType)
                {
                    if (txtUser.Text == string.Empty)
                    {
                        errorProvider1.SetError(txtUser, "ورودمقدار الزامی می باشد");
                    }
                    else if (txtPass.Text == string.Empty)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(txtPass, "ورودمقدار الزامی می باشد");
                    }
                    else
                    {
                        db.ExistUsername(ref Existusername, txtUser.Text);
                        //MessageBox.Show(Existusername.ToString());
                        if ((bool)Existusername == true)
                        {
                            errorProvider1.Clear();
                            errorProvider1.SetError(txtUser, "نام کاربری تکراری است");
                        }
                        else if ((bool)Existusername == false)
                        {
                            errorProvider1.Clear();
                            db.InsertUser(txtUser.Text, txtPass.Text);
                            MessageBoxFarsi.Show("کاربر جدید اضافه شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                            this.Close();
                        }

                    }
                }
                else
                {
                    if (txtUser.Text == string.Empty)
                    {
                        errorProvider1.SetError(txtUser, "ورودمقدار الزامی می باشد");
                    }
                    else if (txtPass.Text == string.Empty)
                    {
                        errorProvider1.Clear();
                        errorProvider1.SetError(txtPass, "ورودمقدار الزامی می باشد");
                    }
                    else
                    {
                        db.ExistUsername(ref Existusername, txtUser.Text);
                        //MessageBox.Show(Existusername.ToString());
                        if ((bool)Existusername == true)
                        {
                            errorProvider1.Clear();
                            errorProvider1.SetError(txtUser, "نام کاربری تکراری است");
                        }
                        else if ((bool)Existusername == false)
                        {
                            errorProvider1.Clear();
                            db.InsertUser(txtUser.Text, txtPass.Text);
                            MessageBoxFarsi.Show("کاربر جدید اضافه شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);

                        }

                    }
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
