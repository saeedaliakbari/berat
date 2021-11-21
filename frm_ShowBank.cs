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
namespace BeratAj
{
    public partial class frm_ShowBank : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();
        public frm_ShowBank()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddBank.IsEdit = false;
                new frm_AddBank().ShowDialog();
                bsBank.DataSource = db.FillBank();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                    BtnEdit.Enabled = true;
                    BtnDelete.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_ShowBank_Load(object sender, EventArgs e)
        {
            try
            {
                bsBank.DataSource = db.FillBank();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                    BtnEdit.Enabled = true;
                    BtnDelete.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddBank.IsEdit = true;
                frm_AddBank.NameBank = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm_AddBank.IdBank = (int)dataGridView1.CurrentRow.Cells[0].Value;
                new frm_AddBank().ShowDialog();
                db = new dcBeratDataContext();
                bsBank.DataSource = db.FillBank();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                    BtnEdit.Enabled = true;
                    BtnDelete.Enabled = true;
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
                if (MessageBoxFarsi.Show("آیا بانک حذف گردد؟", "اخطار", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button2) == DialogResult.Yes)
                {
                    db.DeleteBank((int)dataGridView1.CurrentRow.Cells[0].Value);
                    bsBank.DataSource = db.FillBank();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnDelete.Enabled = false;
                        BtnEdit.Enabled = false;
                    }
                    else
                    {
                        BtnEdit.Enabled = true;
                        BtnDelete.Enabled = true;
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
