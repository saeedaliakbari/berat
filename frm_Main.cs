using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BehComponents;

namespace BeratAj
{
    public partial class frm_Main : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();
        PersianCalendar pc = new PersianCalendar();

        public static int iduseractive = 0;
        public static string useractive = "";

        string strtoday = "";
        string strtime = "";
        string strday = "";
        bool? ExistUser = false;
        bool? ExistPrice = false;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBoxFarsi.Show("از خروج مطمئنید؟", "خروج از برنامه", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Stop, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }

        private void ذخیرهسازیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string str_filename = string.Empty;
            sfd.FileName = "backup_BeratAj_" + strtoday.Replace("/", "_");
            sfd.Filter = @"backup files(*.bak)|*.bak|all files(*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.OverwritePrompt = true;
            sfd.Title = "***ذخیره سازی پشتیبان***";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                str_filename = sfd.FileName;
                backup(str_filename);
            }
        }
        private void backup(string str_filename)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                db.ExecuteCommand(@"BACKUP DATABASE " + db.Mapping.DatabaseName + " to DISK='" + str_filename + "'");
                this.Cursor = Cursors.Default;
                MessageBox.Show("عملیات ذخیره سازی موفقیت آمیز بود");
            }
            catch (Exception ex)
            {
                MessageBox.Show("عملیات ذخیره سازی موفقیت آمیز نبود |" + ex.Message);
            }
        }

        private void بازیابیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            string str_filename = string.Empty;

            sfd.Filter = @"backup files(*.bak)|*.bak|all files(*.*)|*.*";
            sfd.FilterIndex = 1;

            sfd.Title = "***بازیابی پشتیبان***";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                str_filename = sfd.FileName;
                restore(str_filename);


            }
        }
        private void restore(string str_filename)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                db.ExecuteCommand(@"ALTER DATABASE " + db.Mapping.DatabaseName + "  SET SINGLE_USER with ROLLBACK IMMEDIATE "
               + " USE MASTER " +
               "  RESTORE DATABASE " + db.Mapping.DatabaseName + " from DISK='" + str_filename + "' with REPLACE");
                this.Cursor = Cursors.Default;
                MessageBox.Show("عملیات بازیابی پشتیبان موفقیت آمیز بود");
            }
            catch (Exception ex)
            {
                MessageBox.Show("عملیات بازیابی پشتیبان موفقیت آمیز نبود|" + ex.Message);
            }
        }

        private void بانکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ShowBank().ShowDialog();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            CultureInfo language = new CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
            dcBeratDataContext db = new dcBeratDataContext();
            db.ExistUser(ref ExistUser);
            db.ExistPrice(ref ExistPrice);
            if ((bool)ExistUser==false)
            {
                //کدهانوشته شود
                this.Close();
            }
            else if ((bool)ExistPrice==false)
            {
                //کدها نوشته شود
                this.Close();
            }
            else
            {
                new frm_Login().ShowDialog();
            }
            strtoday = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            strtime = pc.GetHour(DateTime.Now).ToString("00") + ":" + pc.GetMinute(DateTime.Now).ToString("00") + ":" + pc.GetSecond(DateTime.Now).ToString("00");
            lblDate.Text = "تاریخ" + ":" + strtoday;
            lblTime.Text = "زمان" + ":" + strtime;
            strday= pc.GetDayOfWeek(DateTime.Now).ToString();
            lblDayOfWeek.Text = strday;
            lbluser.Text = "کاربر فعال" + " " + useractive;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            strtoday = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            strtime = pc.GetHour(DateTime.Now).ToString("00") + ":" + pc.GetMinute(DateTime.Now).ToString("00") + ":" + pc.GetSecond(DateTime.Now).ToString("00");
            lblDate.Text = "تاریخ" + ":" + strtoday;
            lblTime.Text = "زمان" + ":" + strtime;
            strday = pc.GetDayOfWeek(DateTime.Now).ToString();
            switch (strday)
            {
                case "Saturday":
                    strday = "شنبه";
                    break;
                case "Sunday":
                    strday = "یکشنبه";
                    break;
                case "Monday":
                    strday = "دوشنبه";
                    break;
                case "Tuesday":
                    strday = "سه شنبه";
                    break;
                case "Wednesday":
                    strday = "چهارشنبه";
                    break;
                case "Thursday":
                    strday = "پنج شنبه";
                    break;
                case "Friday":
                    strday = "جمعه";
                    break;
                default:
                    strday = "خطا ";
                    break;

            }
            lblDayOfWeek.Text = strday;
        }

        private void احترامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ShowEhteram().ShowDialog();
        }

        private void موتورخانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ShowMotor.StrDate = strday;
            new frm_ShowMotor().ShowDialog();
        }

        private void قیمتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_AddPrice().ShowDialog();
        }

        private void کاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ShowUsers().ShowDialog();
        }

        private void مالکینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_SelectMotor().ShowDialog();
        }

        private void براتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ShowBerat().ShowDialog();
        }

        

        private void دریافتسندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_AddCreditor().ShowDialog();
        }

        private void لیستموتورخانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ListMalekin().ShowDialog();
        }

        private void براتتکیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_BeratTak().ShowDialog();
        }
        
        private void بابتToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                new frm_Babats().ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void صورتحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Balances().ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBoxFarsi.Show("از خروج مطمئنید؟", "خروج از برنامه", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Stop, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text==string.Empty)
            {
                textBox1.Text = "0";
            }
        }

        private void مهلتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Mohlats().ShowDialog();
        }

        private void گزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Reports().ShowDialog();
        }
    }
}
