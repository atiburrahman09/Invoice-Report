<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" EnableEventValidation="true" Inherits="Invoice.Index" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Invoice</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <%-- <script src="js/jquery.js"></script>
    <script src="js/jquery.datetimepicker.js"></script>--%>
    <link href="css/Custom.css" rel="stylesheet" />
    <script src="//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <link rel="stylesheet" href="//ajax.googleapis.com/ajax/libs/jqueryui/1.11.2/themes/smoothness/jquery-ui.css" />
    <script src="//ajax.googleapis.com/ajax/libs/jqueryui/1.11.2/jquery-ui.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#txtbxDate").datepicker();
        });
    </script>
    <%-- <script>

        <%--function PrintPanel() {
            var divElements = document.getElementById("<%= PrintPage.ClientID %>").innerHTML;
            window.print(divElements);

        }--%>
    <%--function PrintPanel() {
            string strHTML = stringWrite.ToString();
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Write("<link href='css/bootstrap.css' rel='stylesheet' type='text/css' />");
            HttpContext.Current.Response.Write(strHTML);
            var panel = document.getElementById("<%=PrintPage.ClientID %>");
            var printWindow = window.open('', '', 'height=400,width=800');
            printWindow.document.write('<html><head><title>DIV Contents</title>');
            printWindow.document.write('</head><body >');
            printWindow.document.write(panel.innerHTML);
            
            printWindow.document.write('</body></html>');
            printWindow.document.close();
            setTimeout(function () {
                printWindow.print();
            }, 500);
            return false;
        }
    </script>--%>
</head>
<body>
    <form id="form" runat="server">


        <div class="container">
            <asp:Panel ID="PrintPage" runat="server">

                <div class="row">
                    <div class="col-lg-12 margin-top">
                        <div class="col-lg-3">
                            <asp:DropDownList ID="DDLHeader" runat="server" AutoPostBack="True">
                                <asp:ListItem Value="">Select..</asp:ListItem>
                                <asp:ListItem Value="L">LumexIT</asp:ListItem>
                                <asp:ListItem Value="LT">LumexTech</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Select Any Option:" ControlToValidate="DDLHeader" ForeColor="red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-lg-9 text-right margin-top">
                            <asp:Label ID="lblAddress1" runat="server" Text="63/3 (Dolphin Goli), Kolabagan"></asp:Label><br />
                            <asp:Label ID="lblAddress2" runat="server" Text="Dhanmondi, Dhaka-1207"></asp:Label><br />
                            <asp:Label ID="lblAddress3" runat="server" Text="Cell: +8801611755545"></asp:Label><br />
                            <asp:Label ID="lblAddress4" runat="server" Text=""></asp:Label><br />
                            <asp:Label ID="lblAddress5" runat="server" Text=""></asp:Label><br />
                        </div>
                    </div>
                    <div class="col-lg-12">
                        <div class="col-lg-3">
                            <asp:Label ID="lvlName" runat="server" Text="No: "></asp:Label>
                            <asp:Label ID="lvlNo" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col-lg-9 text-center well">
                            <asp:Label ID="lvlMoneyReceipt" runat="server" Text="Money Receipt"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group">
                        <div class="col-lg-3">
                            <asp:Label ID="lvlReceive" runat="server" Text="Recived with Thanks from: "></asp:Label>
                        </div>
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtbxReceive" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Recive Thanks From:" ControlToValidate="txtbxReceive" ForeColor="red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-3">
                            <asp:Label ID="lvlServices" runat="server" Text="Service's"></asp:Label>
                        </div>
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtbxService" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Service:" ControlToValidate="txtbxService" ForeColor="red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group ">
                        <div class="col-lg-3">
                            <asp:Label ID="lvlBy" runat="server" Text="By Cash/ Cheque/ D.D/ P.O.No: "></asp:Label>
                        </div>
                        <div class="col-lg-3">
                            <asp:DropDownList ID="ddlBy" CssClass="form-control" AutoPostBack="True" runat="server" OnSelectedIndexChanged="ddlBy_SelectedIndexChanged">
                                <asp:ListItem Value="">Select..</asp:ListItem>
                                <asp:ListItem Value="C">Cash</asp:ListItem>
                                <asp:ListItem Value="CH">Cheque</asp:ListItem>
                                <asp:ListItem Value="D">D.D</asp:ListItem>
                                <asp:ListItem Value="P">P.O</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Enter Payment Type:" ControlToValidate="ddlBy" ForeColor="red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-lg-3">
                            <asp:TextBox ID="txtbxBy" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Payment Type:" ControlToValidate="txtbxBy" ForeColor="red"></asp:RequiredFieldValidator>
                        </div>

                        <div class="col-lg-1">
                            <asp:Label ID="lvlDate" runat="server" Text="Date: "></asp:Label>
                        </div>
                        <div class="col-lg-2 ">
                            <asp:TextBox ID="txtbxDate" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Date:" ControlToValidate="txtbxDate" ForeColor="red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="clearfix "></div>
                    <div class="form-group ">
                        <div class="col-lg-3">
                            <asp:Label ID="lvlDues" runat="server" Text="Dues Of"></asp:Label>
                        </div>
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtbxDues" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Dues:" ControlToValidate="txtbxDues" ForeColor="red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-3">
                            <asp:Label ID="lvlInWords" runat="server" Text="In Words"></asp:Label>
                        </div>
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtbxInWords" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter Words:" ControlToValidate="txtbxInWords" ForeColor="red"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="form-group ">
                        <div class="col-lg-3">
                            <asp:Label ID="lvlAmount" runat="server" Text="Amount"></asp:Label>
                        </div>
                        <div class="col-lg-3">
                            <asp:TextBox ID="txtbxAmount" class="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter Amount:" ControlToValidate="txtbxAmount" ForeColor="red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                    <br />
                    <div class="form-group ">
                        <div class="col-lg-6"></div>
                        <div class="col-lg-3 pull-left" style="padding-top: 20px">
                            <asp:Label ID="lvlPayee" runat="server" Text="Payee by"></asp:Label>
                        </div>
                        <div class="col-lg-3 pull-right" style="padding-top: 20px">
                            <asp:Label ID="lvlAuthorise" runat="server" Text="Authorised By"></asp:Label>
                        </div>
                    </div>

                </div>

            </asp:Panel>
            <div class="col-lg-12 printbutton">
                <asp:Button ID="btnPrint" runat="server" class="btn btn-primary" OnClick="btnPrint_OnClick" Text="Print" />
                <%--OnClientClick="javascript:PrintPanel();"--%>
            </div>

        </div>

    </form>
</body>
</html>
