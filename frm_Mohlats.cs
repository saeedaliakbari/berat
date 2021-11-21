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
    public partial class frm_Mohlats : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();
        public frm_Mohlats()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtMohlat, txtMohlat.Handle), 0x1501, 1, "ورود مقدار بابت الزامی است");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMohlat.Text==string.Empty)
                {
                    errorProvider1.SetError(txtMohlat, "ورود مقدار الزامی می باشد");
                }
                else
                {
                    errorProvider1.Clear();
                    db.InsertMohlat(txtMohlat.Text);
                    bsMohlat.DataSource = db.FillMohlat();
                    BtnDelete.Enabled = true;
                    txtMohlat.Text = string.Empty;
                }
            }
            catch (Exception)
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
                throw;
            }
        }

        private void frm_Mohlats_Load(object sender, EventArgs e)
        {
            try
            {
                bsMohlat.DataSource = db.FillMohlat();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                }
                else
                {
                    BtnDelete.Enabled = true;
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا بابت حذف گردد؟", "اخطار", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button2) == DialogResult.Yes)
                {
                    db.DeleteMohlat((int)dataGridView1.CurrentRow.Cells[0].Value);
                    bsMohlat.DataSource = db.FillMohlat();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnDelete.Enabled = false;
                    }
                    else
                    {
                        BtnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
