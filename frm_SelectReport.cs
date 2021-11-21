using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using Stimulsoft.Report;

namespace BeratAj
{
    public partial class frm_SelectReport : Form
    {
        dcBeratDataContext db = new dcBeratDataContext();

        public static int MotorId = 0;
        public static int IntNum = 0;
        public static long IntPrice = 0;
        public static int SumMalek = 0;
        public static int PrintNumber = 0;
        public static int MalekId = 0;
        public static long Mablagh = 0;
        public static int BeratId = 0;

        public static double MinPrice = 0;

        public static bool IsTak = false;

        public static string Name = "";
        public static string Family = "";
        public static string FatherName = "";
        public static string Min = "";
        public static string Sec = "";
        public static string Habe = "";
        public static string MelliCode = "";
        public static string Mobile = "";
        public static string Ehteram = "";
        public static string Babat = "";
        public static string Mohlat = "";
        public static string PrintDate = "";
        public static string MablaghHorof = "";

        public frm_SelectReport()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_SelectReport_Load(object sender, EventArgs e)
        {
            if (IsTak)
            {
                btnAlephba.Enabled = false;
                btnMotesadi.Enabled = false;
            }
            else
            {
                btnAlephba.Enabled = true;
                btnMotesadi.Enabled = true;
            }
        }

        private void btnKeshavarzi_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptKeshavarziTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;

                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptKeshavarzi.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;

                    Report.ShowWithRibbonGUI();
                }

            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnMelli_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptMelliTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;

                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptMelli.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;

                    Report.ShowWithRibbonGUI();
                }

            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnSaderat_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptSaderatTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;

                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptSaderat.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;

                    Report.ShowWithRibbonGUI();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnMellat_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptMellatTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;

                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptMellat.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report.ShowWithRibbonGUI();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnRefah_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptRefahTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;

                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptRefah.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report.ShowWithRibbonGUI();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnSepah_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptSepahTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;

                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptSepah.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report.ShowWithRibbonGUI();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnTejarat_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptTejaratTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;

                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptTejarat.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report.ShowWithRibbonGUI();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnPostBank_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptPstbankTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;

                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptPstbank.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report.ShowWithRibbonGUI();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnAlephba_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (IsTak)
                {

                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillViewMalkinAlphba(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptListAlphbatic.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = PrintNumber;
                    Report["SumMalek"] = SumMalek;
                    Report["PriceKol"] = IntPrice;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["BeratId"] = BeratId;
                    Report.ShowWithRibbonGUI();
                }
            //}
            //catch
            //{
            //    MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            //}
    }

        private void btnMotesadi_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptList.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = PrintNumber;
                    Report["SumMalek"] = SumMalek;
                    Report["PriceKol"] = IntPrice;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["BeratId"] = BeratId;
                    Report.ShowWithRibbonGUI();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnBerat_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptBeratTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;
                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    //bsBeratMaleki.DataSource = db.FillBeratMalek(BeratId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptBerat.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;

                    Report.ShowWithRibbonGUI();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsTak)
                {
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptOtherTak.mrt");
                    Report.Compile();

                    Report["MotorkhaneId"] = MotorId;
                    Report["MalekId"] = MalekId;
                    Report["Ehteram"] = Ehteram;
                    Report["Name"] = Name;
                    Report["Family"] = Family;
                    Report["FatherName"] = FatherName;
                    Report["MinPrice"] = MinPrice;
                    Report["Mablagh"] = Mablagh;
                    Report["Horof"] = MablaghHorof;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report["Babat"] = Babat;
                    Report["PrintDay"] = PrintDate;
                    Report["DateMohlat"] = Mohlat;
                    Report["PrintNum"] = PrintNumber;
                    Report["Habe"] = Habe;
                    Report["PriceKol"] = IntPrice;
                    Report["MelliCode"] = MelliCode;
                    Report["Mobile"] = Mobile;

                    Report.ShowWithRibbonGUI();
                }
                else
                {
                    //bsViewMalekin.DataSource = db.FillMalek(MotorId);
                    StiReport Report = new StiReport();

                    Report.Load("Reports/RptOther.mrt");
                    Report.Compile();

                    Report["BeratId"] = BeratId;
                    Report["MotorkhaneId"] = MotorId;
                    Report["Babat"] = Babat;
                    Report["DateMohlat"] = Mohlat;
                    Report["DateToday"] = PrintDate;
                    Report["PrintNum"] = IntNum;
                    Report["PriceKol"] = IntPrice;
                    Report["SumMalek"] = SumMalek;
                    Report["PrintNum"] = PrintNumber;
                    Report["Min"] = Min;
                    Report["Sec"] = Sec;
                    Report.ShowWithRibbonGUI();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
