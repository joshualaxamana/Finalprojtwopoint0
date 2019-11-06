﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Guard_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal Property Approved Form</title>
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/elegant-icons-style.css" rel="stylesheet" />
    <link href="../css/font-awesome.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <link href="../css/style-responsive.css" rel="stylesheet" />
</head>
<body class="bgimg2">
    <div class="header bg-success">
        <h3 class="text-right">Welcome, <asp:Literal ID="ltGuard" runat="server"/>!</h3>
        <a href="../Default.aspx" class="btn btn-warning btn-xs pull-right" onclick='return confirm("are you sure you want to Logout?")'>
            <i class="fa fa-lock"></i>Logout
        </a>
    </div>
    <div><br /></div>
   <div class="container">
        <div class="col-lg-12">
            <form runat="server" class="form-horizontal">

                <h1 class="text-center"><i class="fa fa-archive"></i> Personal Property Forms</h1>
                <div class="col-lg-offset-6">
                    <div class="input-group">
                        <asp:TextBox ID="txtKeyword" runat="server" class="form-control" placeholder="Keyword..." />
                        <span class="input-group-btn">
                            <asp:LinkButton ID="btnSearch" runat="server" class="btn btn-info" OnClick="btnSearch_Click">
                                <i class="fa fa-search"></i>
                            </asp:LinkButton>
                        </span>
                    </div>
                </div>
                <table class="table table-hover">
                    <thead class="green-bg">
                        
                        <th>BlueForm ID #</th>
                        <th class="hidden-xs hidden-sm hidden-md">ID number</th>
                        <th>Name</th>
                        <th class="hidden-xs hidden-sm hidden-md">Purpose</th>
                        <th>Item</th>
                        <th class="hidden-xs hidden-sm hidden-md">Details</th>
                        <th>Serial No.</th>
                        <th class="hidden-xs hidden-sm hidden-md">Campus</th>
                        <th>Date Filed</th>
                        <th>Period Covered</th>
                        <th>Status</th>
                        <th>Approved by</th>
                        <th>Actions</th>
                    </thead>
                    <tbody class="white-bg">
                        <asp:ListView ID="lvBlueform" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("blueformID") %></td>
                                    <td><%# Eval("IDnumber") %></td>
                                    <td><%# Eval("Name") %></td>
                                    <td><%# Eval("Purpose") %></td>
                                    <td><%# Eval("Item") %></td>
                                    <td><%# Eval("Details") %></td>
                                    <td><%# Eval("Serialno") %></td>
                                    <td><%# Eval("campus") %></td>
                                    <td><%# Eval("DateFiled") %></td>
                                    <td><%# Eval("PeriodCovered") %></td>
                                    <td><%# Eval("Status") %></td>
                                    <td><%# Eval("GuardName") %></td>
                                    <td>
                                        <a href='Details.aspx?ID=<%# Eval("BlueformID") %>' class="btn btn-xs btn-warning">
                                            <i class="fa fa-edit"></i>

                                        </a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <EmptyDataTemplate>
                                <tr>
                                    <td colspan="13">
                                        <h2 class="text-center">No Records Found</h2>
                                    </td>
                                </tr>
                            </EmptyDataTemplate>
                        </asp:ListView>
                    </tbody>
                </table>

            </form>
        </div>
    </div>
</body>
</html>
