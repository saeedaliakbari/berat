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
    public partial class frm_Balances : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();
        int? Balance = 0;
        public frm_Balances()
        {
            InitializeComponent();
        }

        private void frm_Balances_Load(object sender, EventArgs e)
        {
            BtnDelete.Enabled = false;
            try
            {
                bsMotorkhaneh.DataSource = db.FillMotorkhane();
            }
            catch (Exception)
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
                    bsMotorkhaneh.DataSource = db.FilterMotorkhaneByName(txtFilter.Text);
                }else if(txtFilter.Text==string.Empty)
                {
                    bsMotorkhaneh.DataSource = db.FillMotorkhane();
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

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMotor.Text == string.Empty)
                {
                    errorProvider1.SetError(cmbMotor, "ورودمقدار الزامی می باشد");
                }
                else
                {
                    errorProvider1.Clear();
                    bsFactor.DataSource = db.FillFactorById((int)cmbMotor.SelectedValue);
                    db.GetBalances((int)cmbMotor.SelectedValue, ref Balance);
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnDelete.Enabled = false;
                    }
                    else
                    {
                        BtnDelete.Enabled = true;
                    }
                    if ((int)Balance > 0)
                    {
                        toolStripStatusLabel1.Text = "مبلغ" + " " + Balance.ToString() + "ریال باید پرداخت گردد";
                    }
                    else if ((int)Balance < 0)
                    {
                        Balance = -1 * Balance;
                        toolStripStatusLabel1.Text = "مبلغ" + " " + Balance.ToString() + "ریال باید دریافت گردد";
                    }
                    else if ((int)Balance == 0)
                    {
                        toolStripStatusLabel1.Text = "حساب تسویه است";
                    }
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا این سند حذف شود؟", "اخطار", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteFactor((int)dataGridView1.CurrentRow.Cells[0].Value);
                    db = new dcBeratDataContext();
                    bsFactor.DataSource = db.FillFactorById((int)cmbMotor.SelectedValue);
                    db.GetBalances((int)cmbMotor.SelectedValue, ref Balance);
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnDelete.Enabled = false;
                    }
                    else
                    {
                        BtnDelete.Enabled = true;
                    }
                    if ((int)Balance > 0)
                    {
                        toolStripStatusLabel1.Text = "مبلغ" + " " + Balance.ToString() + "ریال باید پرداخت گردد";
                    }
                    else if ((int)Balance < 0)
                    {
                        Balance = -1 * Balance;
                        toolStripStatusLabel1.Text = "مبلغ" + " " + Balance.ToString() + "ریال باید دریافت گردد";
                    }
                    else if ((int)Balance == 0)
                    {
                        toolStripStatusLabel1.Text = "حساب تسویه است";
                    }
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
