using BehComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace BeratAj
{
    public partial class frm_Reports : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();
        private bool IsEdit = false;
        public frm_Reports()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtNameReport, txtNameReport.Handle), 0x1501, 1, "ورود مقدار نام گزارش الزامی است");
            SendMessage(new HandleRef(txtAddressReport, txtAddressReport.Handle), 0x1501, 1, "ورود مقدار آدرس گزارش الزامی است");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameReport.Text == string.Empty)
                {
                    errorProvider1.SetError(txtNameReport, "ورود مقدار الزامی می باشد");
                }else if (txtAddressReport.Text == string.Empty)
                {
                    errorProvider1.SetError(txtAddressReport, "ورود مقدار الزامی می باشد");
                }
                else
                {
                    if (IsEdit)
                    {
                        db.UpdateReport((int)dataGridView1.CurrentRow.Cells[0].Value, txtNameReport.Text,txtAddressReport.Text);
                        db = new dcBeratDataContext();
                        bsReport.DataSource = db.FillReport();
                        BtnDelete.Enabled = true;
                        BtnEdit.Enabled = true;
                        IsEdit = false;
                    }
                    else
                    {
                        db.InsertReport(txtNameReport.Text, txtAddressReport.Text);
                        bsReport.DataSource = db.FillReport();
                        BtnDelete.Enabled = true;
                        BtnEdit.Enabled = true;

                    }
                    txtNameReport.Text = string.Empty;
                    txtAddressReport.Text = string.Empty;

                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_Reports_Load(object sender, EventArgs e)
        {
            try
            {
                bsReport.DataSource = db.FillReport();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;
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
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (MessageBoxFarsi.Show("آیا گزارش "+ dataGridView1.CurrentRow.Cells[1].Value + " حذف گردد؟", "اخطار", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button2) == DialogResult.Yes)
                {
                    db.DeleteReport(id);
                    bsReport.DataSource = db.FillReport();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnDelete.Enabled = false;
                        BtnEdit.Enabled = false;
                    }
                    else
                    {
                        BtnDelete.Enabled = true;
                        BtnEdit.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                txtAddressReport.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtNameReport.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;
                IsEdit = true;
            }
            catch (Exception)
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
