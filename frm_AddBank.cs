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
    public partial class frm_AddBank : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();
        public static string NameBank = "";
        public static bool IsEdit = false;
        public static int IdBank = 0;
        public frm_AddBank()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtName, txtName.Handle), 0x1501, 1, "ورود مقدار الزامی است");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AddBank_Load(object sender, EventArgs e)
        {
            try
            {
                if(IsEdit)
                {
                    groupBox1.Text = "ویرایش بانک";
                    bsBank.DataSource = db.FillBankById(IdBank);
                    txtName.Text = NameBank;
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
                if (txtName.Text==string.Empty)
                {
                    errorProvider1.SetError(txtName, "ورود مقدار الزامی می باشد");
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        db.UpdateBank(IdBank, txtName.Text);
                        MessageBoxFarsi.Show("بانک ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        this.Close();
                    }
                    else
                    {
                        db.InsertBank(txtName.Text);
                        txtName.Text = string.Empty;
                        txtName.Focus();
                        MessageBoxFarsi.Show("بانک جدید افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    }
                }
            }
            catch 
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bsBank_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
