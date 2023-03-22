<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 43px;
            left: 27px;
            z-index: 1;
            width: 328px;
            height: 412px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" style="z-index: 1; left: 637px; top: 150px; position: absolute" Text="Filter List" />
        <asp:ListBox ID="lstCustomerList" runat="server" CssClass="auto-style1"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAddNewRecord" runat="server"  style="z-index: 1; left: 25px; top: 487px; position: absolute; width: 122px;" Text="Add New Record" OnClick="btnAddNewRecord_Click" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 424px; top: 151px; position: absolute" Text="Enter a name in the box below"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="position: relative; top: -111px; left: 730px" Text="Clear Filter" />
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="height: 26px; z-index: 1; top: 487px; position: absolute; left: 165px; right: 1198px;" Text="Edit Record" width="122px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 469px; top: 313px; position: absolute" Font-Bold="True" ForeColor="Red"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 307px; top: 487px; position: absolute; height: 26px;" Text="Delete Record" width="122px" />
        </p>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 420px; top: 187px; position: absolute; width: 378px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
