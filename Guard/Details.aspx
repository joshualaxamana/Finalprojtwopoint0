<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Guard_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Blue Form Details</title>
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/font-awesome.css" rel="stylesheet" />
</head>
<body class="bgimg4">
    <div class="header bg-success">
        <h3 class="text-right">Welcome, <asp:Literal ID="ltGuard" runat="server"/>!</h3>
        <a href="../Default.aspx" class="btn btn-warning btn-xs pull-right" onclick='return confirm("are you sure you want to Logout?")'>
            <i class="fa fa-lock"></i>Logout
        </a>
    </div>
     <div class="container">
        <div class="col-lg-offset-2 col-lg-8">
            <h1 class="text-center"><i class="fa fa-phone"></i> Personal Property Form no. <asp:Literal ID="ltBlueform" runat="server" /></h1>
            <div class="well">
                <form runat="server" class="form-horizontal">
                    <div class="form-group">
                        <label class="control-label col-lg-4">ID Number</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtIDNo" runat="server" CssClass="form-control" Maxlength="8" required Enabled="False" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Purpose</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPurpose" runat="server" CssClass="form-control" Maxlength="500" required textmode="MultiLine" Rows="4" Enabled="False"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Item</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtItem" runat="server" CssClass="form-control" Maxlength="100" required Enabled="False" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Details</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDetails" runat="server" CssClass="form-control" Maxlength="500" textmode="MultiLine" Rows="4" Enabled="False" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Serial No.</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtserial" runat="server" CssClass="form-control" Maxlength="50" required Enabled="False" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Campus</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtCampus" runat="server" CssClass="form-control" Maxlength="50" required />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Date Filed</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" type="date" required Enabled="False" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Period Covered</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPeriod" runat="server" CssClass="form-control" Maxlength="20" required Enabled="False" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div  class="col-lg-offset-4 col-lg-8">
                            <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-warning btn-block" Text="Approve" Onclick="btnUpdate_Click"/>
                            <a href="Default.aspx" class="btn btn-default btn-block">Cancel</a>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</body> 
</html>
