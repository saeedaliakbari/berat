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
    public partial class frm_AddPrice : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();

        public static bool ExitType = false;

        int? Price = 0;
        public frm_AddPrice()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExitType)
                {
                    db.InsertPrice((int)numPrice.Value);
                    MessageBoxFarsi.Show("قیمت افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.None, MessageBoxFarsiDefaultButton.Button1);
                }
                else
                {
                    db.UpdatePrice((int)numPrice.Value);
                    MessageBoxFarsi.Show("قیمت بروزرسانی شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.None, MessageBoxFarsiDefaultButton.Button1);
                }
                this.Close();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_AddPrice_Load(object sender, EventArgs e)
        {
            db.GetPrice(ref Price);
            if (ExitType==false)
            {
                numPrice.Value = (int)Price;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
