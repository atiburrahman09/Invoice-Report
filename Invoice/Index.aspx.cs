﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Microsoft.Reporting.WebForms;
using Lumex.Tech;


namespace Invoice
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Random r = new Random();
                lvlNo.Text = Convert.ToString(r.Next(5, 5000));
            }

            if (DDLHeader.SelectedValue == "LT")
            {
                lblAddress4.Text = "E-mail: contact@lumextech.com";
                lblAddress5.Text = "Web: www.lumextech.com";
                //ClearAll();
            }
            else if (DDLHeader.SelectedValue == "L")
            {
                lblAddress4.Text = "E-mail: contact@lumexit.com";
                lblAddress5.Text = "Web: www.lumexit.com";
                //ClearAll();
            }
            //else
            //{
            //    lblAddress4.Text = "";
            //    lblAddress5.Text = "";
            //    ClearAll();
            //}
        }

        //private void ClearAll()
        //{
        //    txtbxService.Text = "";
        //    txtbxReceive.Text = "";
        //    txtbxInWords.Text = "";
        //    txtbxDues.Text = "";
        //    txtbxDate.Text = "";
        //    txtbxBy.Text = "";
        //    txtbxAmount.Text = "";
        //}

        //protected void DDLHeader_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (DDLHeader.SelectedValue=="LT")
        //    {
        //       lblAddress4.Text = "E-mail: contact@lumextech.com";
        //       lblAddress5.Text = "Web: www.lumextech.com";
        //    }
        //    else
        //    {
        //        lblAddress4.Text = "E-mail: contact@lumexit.com";
        //        lblAddress5.Text = "Web: www.lumexit.com";
        //    }
        //}
        
        protected void btnPrint_OnClick(object sender, EventArgs e)
        {
            LumexSessionManager.Add("name", txtbxReceive.Text.Trim().ToString());
            LumexSessionManager.Add("Serial", lvlNo.Text.Trim().ToString());
            LumexSessionManager.Add("Service", txtbxService.Text.ToString());
            LumexSessionManager.Add("CashNo", txtbxBy.Text.ToString());
            LumexSessionManager.Add("Date", txtbxDate.Text.ToString());
            LumexSessionManager.Add("Dues", txtbxDues.Text.ToString());
            LumexSessionManager.Add("Word", txtbxInWords.Text.ToString());
            LumexSessionManager.Add("Amount", txtbxAmount.Text.ToString());
            LumexSessionManager.Add("CompanyName", DDLHeader.SelectedItem.ToString());
            LumexSessionManager.Add("LumexEmail", lblAddress4.Text.ToString());
            LumexSessionManager.Add("LumexMobile", lblAddress5.Text.ToString());
            Response.Redirect("Print.aspx");
            //ReportViewer aReportViewer=new ReportViewer();
            //ReportDataSource rds = new ReportDataSource();
            //rds.Name = "DataSet1";
            //rds.Value = dt;

            //ReportParameter rp1 = new ReportParameter("name", txtbxReceive.Text.ToString());
            //ReportParameter rp2 = new ReportParameter("Service", txtbxService.Text.ToString());
            //ReportParameter rp3 = new ReportParameter("CashNo", txtbxBy.Text.ToString());
            //ReportParameter rp4 = new ReportParameter("Date", txtbxDate.Text.ToString());
            //ReportParameter rp5 = new ReportParameter("Dues", txtbxDues.Text.ToString());
            //ReportParameter rp6 = new ReportParameter("Word", txtbxInWords.Text.ToString());
            //ReportParameter rp7 = new ReportParameter("Amount", txtbxAmount.Text.ToString());
            //ReportParameter rp8 = new ReportParameter("CompanyName", DDLHeader.SelectedIndex.ToString());
            //ReportParameter rp9 = new ReportParameter("LumexEmail", lblAddress4.Text.ToString());
            //ReportParameter rp10 = new ReportParameter("LumexMobile", lblAddress5.Text.ToString());
            
            //ReportViewer1.LocalReport.ReportPath = "invorpt/invo.rdlc";
            //ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3, rp4, rp5, rp6, rp7, rp8, rp9, rp10 });
            //ReportViewer1.LocalReport.Refresh();
            //Session["ctrl"] = PrintPage;
            //ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=1024px,width=800px,scrollbars=1');</script>,info");
        }
    }
}