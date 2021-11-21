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
    public partial class frm_ShowUsers : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();

        public frm_ShowUsers()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddUser.ExitType = false;
                new frm_AddUser().ShowDialog();
                bsUser.DataSource = db.FillUser();
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frm_EditUser.id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                frm_EditUser.Username = (string)dataGridView1.CurrentRow.Cells[1].Value;
                new frm_EditUser().ShowDialog();
                db = new dcBeratDataContext();
                bsUser.DataSource = db.FillUser();
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
                frm_ConfirmDelete.id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                frm_ConfirmDelete.pass = (string)dataGridView1.CurrentRow.Cells[2].Value;
                frm_ConfirmDelete.ConfirmMode = false;
                new frm_ConfirmDelete().ShowDialog();
                bsUser.DataSource = db.FillUser();
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

        private void frm_ShowUsers_Load(object sender, EventArgs e)
        {
            try
            {
                bsUser.DataSource = db.FillUser();
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
    }
}
