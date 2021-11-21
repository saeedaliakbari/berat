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
using Stimulsoft.Report;
//using Microsoft.Office.Interop.Excel;

namespace BeratAj
{
    public partial class frm_ShowMotor : Form
    {
        [DllImport("user32.dll")]//برای watermark
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] String lParam);//watermark

        dcBeratDataContext db = new dcBeratDataContext();

        public static int iduseractive = 0;
        public static string StrDate = "";

        string passidactive = "";
        public frm_ShowMotor()
        {
            InitializeComponent();
            SendMessage(new HandleRef(txtFilter, txtFilter.Handle), 0x1501, 1, "نام موتورخانه را برای جستجو واردکنید");
        }

        //void exprorttoexel(DataGridView dgv)
        //{
        //    //try
        //    //{
        //        Microsoft.Office.Interop.Excel.Application exeleapp = new Microsoft.Office.Interop.Excel.Application();
        //        Microsoft.Office.Interop.Excel.Workbook workbook = exeleapp.Workbooks.Add(XlSheetType.xlWorksheet);
        //        Microsoft.Office.Interop.Excel.Worksheet worksheet = (Worksheet)(workbook.Worksheets[1]); ;
        //        worksheet.DisplayRightToLeft = true;
        //        exeleapp.Visible = true;

        //        //worksheet = workbook.Sheets["Sheet1"];
        //        //worksheet = workbook.ActiveSheet;
        //        //worksheet.Name = "Exported from gridview";

        //        for (int i = 1; i < dgv.Columns.Count + 1; i++)
        //        {

        //            worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;

        //        }

        //        for (int i = 0; i < dgv.Rows.Count - 1; i++)
        //        {
        //            for (int j = 0; j < dgv.Columns.Count; j++)
        //            {
        //                worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }

        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message);
        //    //}

        //}
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ShowMotor_Load(object sender, EventArgs e)
        {
             try
            {
                bsViewMotorkhane.DataSource = db.FillViewMotorkhane();
                if (dataGridView1.Rows.Count==0)
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFilter.Text != string.Empty)
                {
                    bsViewMotorkhane.DataSource = db.FilterViewMotorkhaneByName(txtFilter.Text);
                }else if (txtFilter.Text == string.Empty)
                {
                    bsViewMotorkhane.DataSource = db.FillViewMotorkhane();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddMotorkhaneh.IsEdit = false;
                new frm_AddMotorkhaneh().ShowDialog();
                bsViewMotorkhane.DataSource = db.FillViewMotorkhane();
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
                frm_AddMotorkhaneh.IsEdit = true;
                frm_AddMotorkhaneh.Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                frm_AddMotorkhaneh.BankName = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                new frm_AddMotorkhaneh().ShowDialog();
                db = new dcBeratDataContext();
                bsViewMotorkhane.DataSource = db.FillViewMotorkhane();
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
                db.GetPassUser(iduseractive, ref passidactive);
                frm_ConfirmDelete.pass = (string)passidactive;
                frm_ConfirmDelete.id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                frm_ConfirmDelete.ConfirmMode = true;
                new frm_ConfirmDelete().ShowDialog();
                bsViewMotorkhane.DataSource = db.FillViewMotorkhane();
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

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //bsViewMotorkhane.DataSource = db.FillViewMotorkhane();
                StiReport Report = new StiReport();

                Report.Load("Reports/RptListMotorkhane.mrt");
                Report.Compile();

                Report["DateToday"] = StrDate;

                Report.ShowWithRibbonGUI();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
}

        //private void btnExcell_Click(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //        //exprorttoexel(dataGridView1);
        //    //}
        //    //catch
        //    //{
        //    //    MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
        //    //}
        //}
    }
}
