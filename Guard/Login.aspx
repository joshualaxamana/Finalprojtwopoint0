<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Guard_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Login</title>
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/elegant-icons-style.css" rel="stylesheet" />
    <link href="../css/font-awesome.css" rel="stylesheet" />
    <link href="../css/style-responsive.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
</head>
<body class="bgimage">
    <div class="container">
        <form class="login-form" runat="server">
            <div class="login-wrap">
                
            <h1 class="text-center"><i class="icon-login-l"></i> User Login</h1>
            <div class="well clearfix">
                
                    <div id="Error" runat="server" class="alert alert-danger" visible="false">
                        Invalid ID number or Password
                    </div>
                    <div class="form-group col-lg-12">
                        <label class="col-lg-4">ID number</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtIDnum" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group col-lg-12">
                        <label class="col-lg-4">Password</label>
                        <div class="col-lg-8">
                            <asp:TextBox ID="txtPW" runat="server" textmode="Password" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="form-group col-lg-12">
                        <div class="col-lg-offset-2 col-lg-8">
                            <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-success btn-block" Text="Login" OnClick="btnLogin_Click" />
                        </div>
                    </div>
                    <div class="form-group col-lg-12">
                        <div class="col-lg-offset-2 col-lg-8">
                            <a href="Register.aspx" class="btn btn-default btn-block">Register</a>
                        </div>
                    </div>
            </div>
            </div>
        </form>
    </div>
    
</body>
</html>

