using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Lumex.Tech;
using Microsoft.Reporting.WebForms;


namespace Invoice
{
    public partial class Print : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
            
        }

        private void GetData()
        {
            ReportViewer1.Visible = true;
            string a = LumexSessionManager.Get("name").ToString();
            ReportParameter rp1 = new ReportParameter("name", LumexSessionManager.Get("name").ToString());
            ReportParameter rp2 = new ReportParameter("Service", LumexSessionManager.Get("Service").ToString());
            ReportParameter rp3 = new ReportParameter("CashNo", LumexSessionManager.Get("CashNo").ToString());
            ReportParameter rp4 = new ReportParameter("Date", LumexSessionManager.Get("Date").ToString());
            ReportParameter rp5 = new ReportParameter("Dues", LumexSessionManager.Get("Dues").ToString());
            ReportParameter rp6 = new ReportParameter("Word", LumexSessionManager.Get("Word").ToString());
            ReportParameter rp7 = new ReportParameter("Amount", LumexSessionManager.Get("Amount").ToString());
            ReportParameter rp8 = new ReportParameter("CompanyName", LumexSessionManager.Get("CompanyName").ToString());
            ReportParameter rp9 = new ReportParameter("LumexEmail", LumexSessionManager.Get("LumexEmail").ToString());
            ReportParameter rp10 = new ReportParameter("LumexMobile", LumexSessionManager.Get("LumexMobile").ToString());
            ReportParameter rp11 = new ReportParameter("Serial", LumexSessionManager.Get("Serial").ToString());

            ReportViewer1.LocalReport.ReportPath = "invorpt/invo.rdlc";
            ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3, rp4, rp5, rp6, rp7, rp8, rp9, rp10, rp11 });
            ReportViewer1.LocalReport.Refresh();
        }
    }
}