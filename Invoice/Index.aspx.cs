using System;
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
                //Random r = new Random();
               // lvlNo.Text = LumexLibraryManager.GetAppDateView(DateTime.Today.ToString());
                //int time =Convert.ToInt32( DateTime.Now.ToString("hh:mm:ss")); 
                //int date =Convert.ToInt32(DateTime.Now.ToString("dd/MM/yy"));
                //lvlNo.Text = Convert.ToString(date + time);
                DateTime NowTime = DateTime.Now;
                string day = Convert.ToString(NowTime.Day); // Current Date with Day Display
                string month = Convert.ToString(DateTime.Today.Month);  //Current Month as a Single Integer Display
                string year = Convert.ToString(DateTime.Today.Year); // Display Year as Integer
                string hour = Convert.ToString(NowTime.Hour);
                string minute = Convert.ToString(NowTime.Minute);

                lvlNo.Text = (day + month + year + hour + minute).ToString();

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
        }

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
           
        }

        protected void ddlBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlBy.SelectedValue.ToString() == "C")
            {
                txtbxBy.Text = "Cash";
            }
            else
            {
                txtbxBy.Text = "";
            }
            
                if (ddlBy.SelectedValue.ToString() == "CH")
                {
                    RequiredFieldValidator3.ErrorMessage = "Enter the Checque Number";
                }
                if (ddlBy.SelectedValue.ToString() == "D")
                {
                    RequiredFieldValidator3.ErrorMessage = "Enter the D.D Number";
                }
                if (ddlBy.SelectedValue.ToString() == "P")
                {
                    RequiredFieldValidator3.ErrorMessage = "Enter the P.O Number";
                }

            
        }
    }
}