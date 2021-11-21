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
    public partial class frm_PrinListBerat : Form
    {
        public frm_PrinListBerat()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrinBeratList_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();

            Report.Load("Reports/RptListBerat.mrt");
            Report.Compile();

            Report["Start"] = mskDateStart.Text;
            Report["End"] = mskDateEnd.Text;

            Report.ShowWithRibbonGUI();
        }
    }
}
