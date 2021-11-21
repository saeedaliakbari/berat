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
    public partial class frm_EditMalekId : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();
        public static int MotorkhaneId = 0;
        public static string MotorkhaneName = "";
        public frm_EditMalekId()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                db.UpdateMalekId((int)dataGridView1.CurrentRow.Cells[0].Value, Convert.ToInt32(intMalekId.Text));
                intMalekId.Enabled = true;
                dataGridView1.Enabled = false;
            }
            catch (Exception)
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
            
        }

        private void EditMalekId_Load(object sender, EventArgs e)
        {
            try
            {
                bsViewMalek.DataSource = db.FillMalekOrder(MotorkhaneId);
                intMalekId.Enabled = false;
                groupBox1.Text = "ویرایش شماره مالکین موتورخانه" + " " + MotorkhaneName;
            }
            catch (Exception)
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
                
            }
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                db.UpdateMalekId((int)dataGridView1.CurrentRow.Cells[0].Value, Convert.ToInt32(intMalekId.Text));
                db = new dcBeratDataContext();
                bsViewMalek.DataSource = db.FillMalekOrder(MotorkhaneId);
                intMalekId.Enabled = false;
                dataGridView1.Enabled = true;
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

        private void intMalekId_Leave(object sender, EventArgs e)
        {
            if (intMalekId.Text==string.Empty)
            {
                intMalekId.Text = "0";
            }
        }
    }
}
