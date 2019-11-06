<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="BlueForm_Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Blue From</title>
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/font-awesome.css" rel="stylesheet" />
</head>
<body class="bgimage">
    <div class="container">
        <div class="col-lg-offset-3 col-lg-6">
            <h1 class="text-center">Add a BlueForm</h1>
            <div class="well">
                <form runat="server" class="form-horizontal">
                    <div class="form-group">
                        <label class="control-label col-lg-4">ID Number</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtID" runat="server" CssClass="form-control" MaxLength="8" required Enabled="False" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Purpose</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPurpose" runat="server" CssClass="form-control" MaxLength="500" required />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Item</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtItem" runat="server" CssClass="form-control" MaxLength="100" required />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Details</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDetails" runat="server" CssClass="form-control" MaxLength="200" required />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Serial Number</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtSerialNo" runat="server" CssClass="form-control" MaxLength="50" required />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Campus</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtCampus" runat="server" CssClass="form-control" MaxLength="50" required />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Date Filed</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" type="date" required />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Period Covered</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPC" runat="server" CssClass="form-control" MaxLength="50" required />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Status</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control" MaxLength="50" required Enabled="False" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-lg-4">Guard ID</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtGID" runat="server" CssClass="form-control" MaxLength="8" required Enabled="False" />
                        </div>
                    </div>
                    <div class="form-group">
                           <div class="col-lg-offset-4 col-lg-6">
                               <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success" Text="Add" OnClick="btnAdd_Click"/>
                           </div>
                       </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
