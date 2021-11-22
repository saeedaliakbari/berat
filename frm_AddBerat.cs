using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using JntNum2Text;
using Stimulsoft.Report;
using BehComponents;

namespace BeratAj
{
    public partial class frm_AddBerat : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();
        PersianCalendar pc = new PersianCalendar();
        private Num2Text change = new Num2Text();

        int FactorPrice = 0;
        int Minute = 0;
        int Seconds = 0;
        long Mablagh = 0;
        int SumSec = 0;
        long SumMablagh = 0;
        int TedadList = 0;

        long Sadgan = 0;

        string MablaghHorof = "";
        double MinPrice = 0;

        string strtoday = "";
        string bankname = "";
        string strMohlat = "";

        int? Min = 0;
        int? SumMalek = 0;
        int? MinKol = 0;
        int? PrintPrice = 0;
        int? FactorId = 0;
        int? MaxBeratId = 0;

        double? Sec = 0;
        public frm_AddBerat()
        {
            InitializeComponent();
        }

        private void frm_AddBerat_Load(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedTab = tabPage1;//start tab is seleceted tabpage 1
                HideAllTabsOnTabControl(tabControl1);//hide header tab contorl1
                BtnPrint.Enabled = false;
                BtnBack.Enabled = false;
                BtnNext.Enabled = true;
                strtoday = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
                if (pc.GetDayOfMonth(DateTime.Now)+20>30)
                {
                    strMohlat = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now.AddMonths(1)).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now.AddDays(20)).ToString("00");
                }
                else
                {
                    strMohlat = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now.AddDays(20)).ToString("00");
                }
                
                mskDatePrint.Text = strtoday;
                mskDatePardakht.Text = strMohlat;
                bsMotorkhane.DataSource = db.FillMotorkhane();
                bsBabats.DataSource = db.FillBabat();
                bsMohlat.DataSource = db.FillMohlat();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void HideAllTabsOnTabControl(TabControl theTabControl)//hide header in tab control
        {
            theTabControl.Appearance = TabAppearance.Normal;
            theTabControl.ItemSize = new Size(0, 1);
            theTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (cmbMotor.Text == string.Empty)
                {
                    errorProvider1.SetError(cmbMotor, "ورودمقدار الزامی است");
                }
                else if (mskDatePrint.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(mskDatePrint, "ورودمقدار الزامی است");
                }
                else if (mskDatePardakht.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(mskDatePardakht, "ورودمقدار الزامی است");
                }
                else if (txtPrice.Text=="0" || txtPrice.Text==string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtPrice, "ورودمقدار الزامی است");
                }
                else if (txtNumPrint.Text == "0"||txtPrice.Text==string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtNumPrint, "ورودمقدار الزامی است");
                }
                else if (cmbBabat.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(cmbBabat, "ورودمقدار الزامی است");
                }
                else
                {
                    tabControl1.SelectedTab = tabPage2;
                    BtnBack.Enabled = true;
                    BtnNext.Enabled = true;
                    bsViewMalekin.DataSource = db.FillViewMalkin((int)cmbMotor.SelectedValue);
                    db.GetSumMin((int)cmbMotor.SelectedValue, ref Min, ref Sec);
                    if (Sec >= 100)
                    {
                        Min += (int)Sec / 100;
                        Sec = Sec % 100;
                    }
                    db.GetSumTedadMalek((int)cmbMotor.SelectedValue, ref SumMalek);
                    db.GetMinKolMotor((int)cmbMotor.SelectedValue, ref MinKol);
                    MinPrice =long.Parse(txtPrice.Text) / (int)MinKol;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        Mablagh = 0;
                        Minute = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
                        Seconds = Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                        //if (Minute < 0 && Seconds < 0)//برای آب منفی چکار باید بکنم؟؟؟
                        //{
                        //    Minute = -Minute;
                        //    Seconds = -Seconds;
                        //}
                        SumSec = Minute * 100 + Seconds;
                        Mablagh = Convert.ToInt64(SumSec * (double.Parse(txtPrice.Text) / (int)MinKol) * .01);
                        //Yekan = Mablagh % 10;
                        //Dahgan= Mablagh % 100;
                        Sadgan = Mablagh % 1000;
                        Mablagh = Mablagh - Sadgan;
                        if (Sadgan != 0)
                        {
                            Mablagh += 1000;
                        }
                        SumMablagh += Mablagh;

                        dataGridView1.Rows[i].Cells[10].Value = Mablagh.ToString();
                        if (Mablagh < 0)
                        {
                            Mablagh = -Mablagh;
                            dataGridView1.Rows[i].Cells[11].Value = "منفی" + Num2Text.ToFarsi(Mablagh);
                        }
                        dataGridView1.Rows[i].Cells[11].Value = Num2Text.ToFarsi(Mablagh);

                    }
                    toolStripStatusLabel1.Text = "|" + "مجموع آب" + "=" + Min.ToString() + ":" + Sec.ToString() + " | " + "تعداد مالکین" + "=" + SumMalek.ToString() + " | " + "جمع آب موتورخانه" + "=" + MinKol.ToString() + " | " + "سهم هر دقیقه" + "=" + MinPrice.ToString() + " | " + "جمع مبلغ برات" + "=" + SumMablagh.ToString() + " | ";
                    //panel1.Text = "|" + "مجموع آب" + "=" + Min.ToString() + ":" + Sec.ToString() + " | " + "تعداد مالکین" + "=" + SumMalek.ToString() + " | " + "جمع آب موتورخانه" + "=" + MinKol.ToString() + " | " + "سهم هر دقیقه" + "=" + MinPrice.ToString() + " | " + "جمع مبلغ برات" + "=" + SumMablagh.ToString() + " | ";
                }
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                db.GetMaxNumFactor(ref FactorId);
                tabControl1.SelectedTab = tabPage3;
                BtnBack.Enabled = true;
                BtnNext.Enabled = true;
                intFactorId.Text = ((int)FactorId + 1).ToString();
                db.GetPrice(ref PrintPrice);
                ////PrintPrice = 3000;//todo : مبلغ را از تنظیمات باید بگیرد
                TedadList = (int)SumMalek / 44 + 1;
                FactorPrice = (int)(Convert.ToInt32(SumMalek) * (int)PrintPrice * 2 + ((Convert.ToInt32(SumMalek) / 40) * (int)PrintPrice) + (int)PrintPrice);//مبلغ فاکتور بدون تخفیف
                txtPriceFactor.Text = FactorPrice.ToString();
                txtPardakht.Text = (Int32.Parse(txtPriceFactor.Text) + Int32.Parse(txtAddPrice.Text) - Int32.Parse(txtCut.Text)).ToString();
                lblPrice.Text = Num2Text.ToFarsi(Int32.Parse(txtPardakht.Text)) + " " + "ریال";
                db.GetBankName((int)cmbMotor.SelectedValue, ref bankname);
                toolStripStatusLabel2.Text = "نام بانک" + ":" + bankname;
                //panel1.Text = "نام بانک" + ":" + bankname;
                BtnNext.Enabled = false;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                bsBeratMalek.DataSource = db.FillBeratMalek((int)MaxBeratId);
                tabControl1.SelectedTab = tabPage4;
                BtnNext.Enabled = false;
                BtnBack.Enabled = true;
            }
            //}
            //    catch (Exception)
            //    {
            //        MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            //    }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                tabControl1.SelectedTab = tabPage1;
                Minute = 0;
                Seconds = 0;
                Mablagh = 0;
                SumSec = 0;
                SumMablagh = 0;
                BtnBack.Enabled = false;
                BtnNext.Enabled = true;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                tabControl1.SelectedTab = tabPage2;
                BtnBack.Enabled = true;
                BtnNext.Enabled = true;
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                tabControl1.SelectedTab = tabPage3;
                BtnBack.Enabled = false;
                BtnNext.Enabled = true;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBoxFarsi.Show("آیا مطمئن هستید؟", "خروج", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Warning, MessageBoxFarsiDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                //try
                //{
                //    bsViewBerat.DataSource = db.FillViewBerats();
                //}
                //catch
                //{
                //    MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
                //}
            }
        }

        private void intCut_ValueChanged(object sender, EventArgs e)
        {
            txtPardakht.Text = (Int32.Parse(txtPriceFactor.Text) + Int32.Parse(txtAddPrice.Text) - Int32.Parse(txtCut.Text)).ToString();
            lblPrice.Text = Num2Text.ToFarsi(Int32.Parse(txtPardakht.Text)) + " " + "ریال";
        }

        private void intAddprice_ValueChanged(object sender, EventArgs e)
        {
            txtPardakht.Text = (Int32.Parse(txtPriceFactor.Text) + Int32.Parse(txtAddPrice.Text) - Int32.Parse(txtCut.Text)).ToString();
            lblPrice.Text = Num2Text.ToFarsi(Int32.Parse(txtPardakht.Text)) + " " + "ریال";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا این برات ثبت شود؟امکان بازگشت وجود ندارد", "ثبت برات", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button2) == DialogResult.Yes)
                {

                    
                    //BtnBack.Enabled = false;
                    if (checkBox3.Checked == true)
                    {
                        db.InsertBerat((int)cmbMotor.SelectedValue, mskDatePrint.Text, cmbMohlat.Text, Int32.Parse(txtNumPrint.Text), SumMalek, long.Parse(txtPrice.Text), (double)MinPrice, cmbBabat.Text, Int32.Parse(intFactorId.Text), Int32.Parse(txtPardakht.Text));
                    }
                    else
                    {
                        db.InsertBerat((int)cmbMotor.SelectedValue, mskDatePrint.Text, mskDatePardakht.Text, Int32.Parse(txtNumPrint.Text), SumMalek, long.Parse(txtPrice.Text), (double)MinPrice, cmbBabat.Text, Int32.Parse(intFactorId.Text), Int32.Parse(txtPardakht.Text));
                    }

                    db.GetMaxBeratId(ref MaxBeratId);
                    //MessageBox.Show(dataGridView1.RowCount.ToString());
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        db.InsertMalekBerat(Convert.ToInt32(MaxBeratId), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[6].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value), dataGridView1.Rows[i].Cells[9].Value.ToString(), 0, Convert.ToInt64(dataGridView1.Rows[i].Cells[10].Value), dataGridView1.Rows[i].Cells[12].Value.ToString(), dataGridView1.Rows[i].Cells[13].Value.ToString());

                    }
                    //db.InsertFactorDeptor(intFactorId.Value, (int)cmbMotor.SelectedValue, mskDatePrint.Text, intPardakht.Value);
                    MessageBoxFarsi.Show("برات جدید ثبت شددر ادامه امکان چاپ برات وجود دارد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    BtnSave.Enabled = false;
                    intFactorId.Enabled = false;
                    txtCut.Enabled = false;
                    txtAddPrice.Enabled = false;
                    BtnNext.Enabled = true;
                    BtnBack.Enabled = false;
                    BtnPrint.Enabled = true;
                }
            }
            catch (Exception)
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
                    bsMotorkhane.DataSource = db.FilterMotorkhaneByName(txtFilter.Text);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void intPrice_ValueChanged(object sender, EventArgs e)
        {
            //txtPrice.Text= long.Parse(txtPrice.Text).ToString("#,##0");
            lblPriceKol.Text = Num2Text.ToFarsi(long.Parse(txtPrice.Text)) + " " + "ریال";
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            frm_SelectReport.IntPrice = long.Parse(txtPrice.Text);
            frm_SelectReport.IntNum = int.Parse(txtNumPrint.Text);
            frm_SelectReport.Mohlat = checkBox3.Checked?cmbMohlat.Text:mskDatePardakht.Text;
            frm_SelectReport.MotorId = (int)cmbMotor.SelectedValue;
            frm_SelectReport.PrintDate = mskDatePrint.Text;
            frm_SelectReport.Babat = cmbBabat.Text;
            frm_SelectReport.SumMalek = (int)SumMalek;
            frm_SelectReport.PrintNumber = int.Parse(txtNumPrint.Text);
            frm_SelectReport.Min = Min.ToString();
            frm_SelectReport.Sec = Sec.ToString();
            frm_SelectReport.IsTak = false;
            frm_SelectReport.BeratId = (int)MaxBeratId;
            new frm_SelectReport().ShowDialog();
        }

        private void btnPriceBedehi_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked==true)
                {
                    db.UpdateBeratMalek((int)dataGridView2.CurrentRow.Cells[0].Value, long.Parse(txtPriceBedehi.Text));
                    dcBeratDataContext db1 = new dcBeratDataContext();
                    bsBeratMalek.DataSource = db1.FillBeratMalek((int)MaxBeratId);
                }
                else
                {
                    db.UpdateBeratMalekBedehi((int)dataGridView2.CurrentRow.Cells[0].Value, long.Parse(txtPriceBedehi.Text));
                    dcBeratDataContext db1 = new dcBeratDataContext();
                    bsBeratMalek.DataSource = db1.FillBeratMalek((int)MaxBeratId);
                }
                MessageBoxFarsi.Show("بدهی با موفقیت ثبت شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked==true)
            {
                mskDatePardakht.Enabled = false;
                cmbMohlat.Visible = true;
                //mskDatePardakht.Text = "فوری";
                //mskDatePardakht.Mask = "فوری";

            }
            else
            {
                mskDatePardakht.Enabled = true;
                cmbMohlat.Visible = false;
                mskDatePardakht.Mask = "0000/00/00";
            }
        }

        private void BtnPrintFactor_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();

            Report.Load("Reports/RptFactor.mrt");
            Report.Compile();

            Report["MotorkhaneId"] = cmbMotor.SelectedValue;
            Report["FactorId"] = Int32.Parse(intFactorId.Text);
            Report["DateToday"] = mskDatePrint.Text;
            Report["PrintNum"] = int.Parse(txtNumPrint.Text);
            Report["FiPrice"] = (int)PrintPrice;
            Report["TedadBerat"] = (int)SumMalek;
            Report["TedadList"] = (int)TedadList;
            Report["JamKol"] = Int32.Parse(txtPardakht.Text);
            if (txtCut.Text== "0")
            {
                Report["CutPrice"] = txtAddPrice.Text;
                Report["lblcut"] = "کاراضافه";
            }
            else
            {
                Report["CutPrice"] = txtCut.Text;
                Report["lblcut"] = "تخفیف";
            }

            Report.ShowWithRibbonGUI();
        }

    }
}
