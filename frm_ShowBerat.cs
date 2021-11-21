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
    public partial class frm_ShowBerat : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();
        public frm_ShowBerat()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtFilter, txtFilter.Handle), 0x1501, 1, "جستجوی نام موتورخانه...");
        }

        private void frm_ShowBerat_Load(object sender, EventArgs e)
        {
            //bsViewBerat.DataSource = db.FillViewBerats();
            try
            {
                bsViewBerat.DataSource = db.FillViewBerats();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new frm_AddBerat().ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFilter.Text == string.Empty)
                {
                    //db = new dcBeratDataContext();
                    bsViewBerat.DataSource = db.FillViewBerats();
                }
                else if (txtFilter.Text!=string.Empty)
                {
                    //db = new dcBeratDataContext();
                    bsViewBerat.DataSource = db.FilterViewBeratsByName(txtFilter.Text);
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
                if (MessageBoxFarsi.Show("آیا این برات حذف گردد؟", "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteBerats((int)dataGridView1.CurrentRow.Cells[0].Value, (int)dataGridView1.CurrentRow.Cells[10].Value);
                    //db.DeleteFactorByFactorId((int)dataGridView1.CurrentRow.Cells[10].Value);
                    db.DeleteMelekin((int)dataGridView1.CurrentRow.Cells[0].Value);
                    bsViewBerat.DataSource = db.FillViewBerats();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
                frm_SelectReport.IntPrice = (long)dataGridView1.CurrentRow.Cells[7].Value;
                frm_SelectReport.IntNum = (int)dataGridView1.CurrentRow.Cells[5].Value;
                frm_SelectReport.Mohlat = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm_SelectReport.MotorId = (int)dataGridView1.CurrentRow.Cells[1].Value;
                frm_SelectReport.PrintDate = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm_SelectReport.Babat = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frm_SelectReport.SumMalek = (int)dataGridView1.CurrentRow.Cells[6].Value;
                frm_SelectReport.PrintNumber = (int)dataGridView1.CurrentRow.Cells[5].Value;
                //FrmSelectReport.Min = Min.ToString();
                //FrmSelectReport.Sec = Sec.ToString();
                frm_SelectReport.BeratId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                frm_SelectReport.IsTak = false;
                new frm_SelectReport().ShowDialog();
            //}
            //catch
            //{
            //    MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            //}
        }

        private void btnPrinBeratList_Click(object sender, EventArgs e)
        {
            new frm_PrinListBerat().ShowDialog();
        }
    }
}
