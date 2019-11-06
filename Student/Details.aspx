<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Student_Details" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Blue Form</title>
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/font-awesome.css" rel="stylesheet" />
</head>
<body class="bgimg4">
    <div class="header bg-success">
        <h3 class="text-right">Welcome, <asp:Literal ID="ltStudent" runat="server"/>!</h3>
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
                            <asp:TextBox ID="txtID" runat="server" CssClass="form-control" MaxLength="8" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Name</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" MaxLength="80" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Purpose</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPurpose" runat="server" CssClass="form-control" MaxLength="500" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Item</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtItem" runat="server" CssClass="form-control" MaxLength="100" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Details</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDetails" runat="server" CssClass="form-control" MaxLength="200" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Serial Number</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtSerialNo" runat="server" CssClass="form-control" MaxLength="50" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Campus</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtCampus" runat="server" CssClass="form-control" MaxLength="50" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Date Filed</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" type="date" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Period Covered</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPC" runat="server" CssClass="form-control" MaxLength="50" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Status</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control" MaxLength="50" required Enabled="false"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Approved by</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtGID" runat="server" CssClass="form-control" MaxLength="8" required Enabled="false" />
                        </div>
                    </div>
                    <div class="form-group">
                           <div class="col-lg-offset-4 col-lg-6">
                               <a href="Default.aspx" class="btn btn-success">Back</a>
                           </div>
                       </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
