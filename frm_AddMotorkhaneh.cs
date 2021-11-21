using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;

namespace BeratAj
{
    public partial class frm_AddMotorkhaneh : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();

        public static bool IsEdit = false;

        public static int Id = 0;
        public static string BankName = "";
        public frm_AddMotorkhaneh()
        {
            InitializeComponent();
        }

        private void frm_AddMotorkhaneh_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsBank.DataSource = db.FillBank();
                    cmbBank.DisplayMember = BankName;
                    bsMotorkhaneh.DataSource = db.FillMotorkhaneById(Id);
                    bsViewMotor.DataSource = db.FillViewMotorkhaneById(Id);
                }
                else
                {
                    bsBank.DataSource = db.FillBank();
                    txtNameMotorchi.Text = string.Empty;
                    txtNameMotesadi.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtMedarAb.Text = string.Empty;
                    txtCodeSahraei.Text = string.Empty;
                    txtCode4.Text = string.Empty;
                    txtCode.Text = string.Empty;
                    txtAccount.Text = string.Empty;
                    txtHabeKol.Text = "0";
                    txtMinKol.Text = "0";
                    txtHabeMin.Text = "0";
                    mskMobileMotesadi.Text = string.Empty;
                    mskMobileMotorchi.Text = string.Empty;
                    mskPhoneMotesadi.Text = string.Empty;
                    txtName.Focus();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text==string.Empty)
                {
                    errorProvider1.SetError(txtName, "ورود مقدار الزامی است");
                }
                else
                {
                    errorProvider1.Clear();
                    if (IsEdit)
                    {
                        db.UpdateMotorkhane(Id, txtName.Text, txtCode.Text, txtCode4.Text, txtCodeSahraei.Text, txtMedarAb.Text, Int32.Parse(txtMinKol.Text), Int32.Parse(txtHabeMin.Text), Int32.Parse(txtHabeKol.Text), (int)cmbBank.SelectedValue, txtAccount.Text, txtNameMotesadi.Text, mskMobileMotesadi.Text, mskPhoneMotesadi.Text, txtNameMotorchi.Text, mskMobileMotorchi.Text);
                        MessageBoxFarsi.Show("موتورخانه ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        this.Close();
                    }
                    else
                    {
                        db.InsertMotorkhane(txtName.Text, txtCode.Text, txtCode4.Text, txtCodeSahraei.Text, txtMedarAb.Text, Int32.Parse(txtMinKol.Text), Int32.Parse(txtHabeMin.Text), Int32.Parse(txtHabeKol.Text), (int)cmbBank.SelectedValue, txtAccount.Text, txtNameMotesadi.Text, mskMobileMotesadi.Text, mskPhoneMotesadi.Text, txtNameMotorchi.Text, mskMobileMotorchi.Text);
                        MessageBoxFarsi.Show("موتورخانه جدید افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        txtNameMotorchi.Text = string.Empty;
                        txtNameMotesadi.Text = string.Empty;
                        txtName.Text = string.Empty;
                        txtMedarAb.Text = string.Empty;
                        txtCodeSahraei.Text = string.Empty;
                        txtCode4.Text = string.Empty;
                        txtCode.Text = string.Empty;
                        txtAccount.Text = string.Empty;
                        txtHabeKol.Text = "0";
                        txtMinKol.Text = "0";
                        txtHabeMin.Text = "0";
                        mskMobileMotesadi.Text = string.Empty;
                        mskMobileMotorchi.Text = string.Empty;
                        mskPhoneMotesadi.Text = string.Empty;
                        txtName.Focus();
                    }
                }
            }
            catch
            {

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMinKol_Leave(object sender, EventArgs e)
        {
            if (txtMinKol.Text==string.Empty)
            {
                txtMinKol.Text = "0";
            }
        }

        private void txtHabeMin_Leave(object sender, EventArgs e)
        {
            if (txtHabeMin.Text==string.Empty)
            {
                txtHabeMin.Text = "0";
            }
        }

        private void txtHabeKol_Leave(object sender, EventArgs e)
        {
            if (txtHabeKol.Text==string.Empty)
            {
                txtHabeKol.Text = "0";
            }
        }
    }
}