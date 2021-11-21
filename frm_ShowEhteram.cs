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
    public partial class frm_ShowEhteram : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();

        public frm_ShowEhteram()
        {
            InitializeComponent();
        }

        private void frm_ShowEhteram_Load(object sender, EventArgs e)
        {
            try
            {
                bsEhteram.DataSource = db.FillEhteram();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddEhteram.IsEdit = false;
                new frm_AddEhteram().ShowDialog();
                bsEhteram.DataSource = db.FillEhteram();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddEhteram.IsEdit = true;
                frm_AddEhteram.Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                frm_AddEhteram.EhteramName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                new frm_AddEhteram().ShowDialog();
                db = new dcBeratDataContext();
                bsEhteram.DataSource = db.FillEhteram();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
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
                if (MessageBoxFarsi.Show("آیا این احترام حذف گردد؟", "اخطار", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button2) == DialogResult.Yes)
                {
                    db.DeleteEhteram((int)dataGridView1.CurrentRow.Cells[0].Value);
                    bsEhteram.DataSource = db.FillEhteram();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnEdit.Enabled = false;
                        BtnDelete.Enabled = false;
                    }
                    else
                    {
                        BtnDelete.Enabled = true;
                        BtnEdit.Enabled = true;
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
