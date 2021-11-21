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
    public partial class frm_Babats : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();
        private bool IsEdit = false;
        public frm_Babats()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtBabat, txtBabat.Handle), 0x1501, 1, "ورود مقدار بابت الزامی است");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBabat.Text == string.Empty)
                {
                    errorProvider1.SetError(txtBabat, "ورود مقدار الزامی می باشد");
                }
                else
                {
                    if (IsEdit)
                    {
                        db.UpdateBabat((int)dataGridView1.CurrentRow.Cells[0].Value, txtBabat.Text);
                        db = new dcBeratDataContext();
                        bsBabat.DataSource = db.FillBabat();
                        BtnDelete.Enabled = true;
                        BtnEdit.Enabled = true;
                        IsEdit = false;
                    }
                    else
                    {
                        db.InsertBabat(txtBabat.Text);
                        bsBabat.DataSource = db.FillBabat();
                        BtnDelete.Enabled = true;
                        BtnEdit.Enabled = true;
                        
                    }
                    txtBabat.Text = string.Empty;
                    
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_Babat_Load(object sender, EventArgs e)
        {
            try
            {
                bsBabat.DataSource = db.FillBabat();
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
                    db.DeleteBabat((int)dataGridView1.CurrentRow.Cells[0].Value);
                    bsBabat.DataSource = db.FillBabat();
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
                txtBabat.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;
                IsEdit = true;
            }
            catch (Exception)
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
