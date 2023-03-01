<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 80px;
            left: 127px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 86px;
            left: 20px;
            z-index: 1;
            height: 16px;
            right: 884px;
            font-family: "Comic Sans MS";
            font-size: small;
            font-weight: bold;
            color: #000080;
        }
        .auto-style3 {
            position: absolute;
            top: 120px;
            left: 20px;
            z-index: 1;
            font-family: "Comic Sans MS";
            font-size: small;
            font-weight: bold;
            color: #000080;
        }
        .auto-style4 {
            position: absolute;
            top: 114px;
            left: 127px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 136px;
            left: 20px;
            z-index: 1;
            right: 937px;
            margin-top: 20px;
            font-family: "Comic Sans MS";
            font-size: small;
            font-weight: bold;
            color: #000080;
        }
        .auto-style6 {
            position: absolute;
            top: 149px;
            left: 127px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 192px;
            left: 20px;
            z-index: 1;
            right: 940px;
            font-family: "Comic Sans MS";
            font-size: small;
            font-weight: bold;
            color: #000080;
        }
        .auto-style8 {
            position: absolute;
            top: 184px;
            left: 127px;
            z-index: 1;
            width: 213px;
        }
        .auto-style9 {
            position: absolute;
            top: 224px;
            left: 20px;
            z-index: 1;
            font-family: "Comic Sans MS";
            font-size: small;
            font-weight: bold;
            color: #000080;
        }
        .auto-style10 {
            position: absolute;
            top: 218px;
            left: 128px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 259px;
            left: 20px;
            z-index: 1;
            bottom: 168px;
            right: 900px;
            font-family: "Comic Sans MS";
            font-size: small;
            font-weight: bold;
            color: #000080;
        }
        .auto-style12 {
            position: absolute;
            top: 252px;
            left: 128px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 287px;
            left: 128px;
            z-index: 1;
            font-family: "Comic Sans MS";
            font-size: small;
            font-weight: bold;
            color: #000080;
        }
        .auto-style14 {
            position: absolute;
            top: 289px;
            left: 20px;
            z-index: 1;
            height: 24px;
            font-family: "Comic Sans MS";
            font-size: small;
            font-weight: bold;
            color: #000080;
        }
        .auto-style15 {
            position: absolute;
            top: 155px;
            left: 407px;
            z-index: 1;
            font-family: "Comic Sans MS";
            font-size: small;
            font-weight: bold;
            color: #000080;
        }
        .auto-style16 {
            position: absolute;
            top: 363px;
            left: 50px;
            z-index: 1;
            height: 29px;
            right: 949px;
            font-family: "Comic Sans MS";
            font-size: small;
            color: #000080;
            font-weight: bold;
        }
        .auto-style17 {
            position: absolute;
            top: 363px;
            left: 154px;
            z-index: 1;
            font-family: "Comic Sans MS";
            font-size: small;
            color: #000080;
            font-weight: bold;
        }
        .auto-style19 {
            font-family: Consolas;
            font-weight: bold;
            color: #000080;
        }
        .auto-style20 {
            height: 362px;
        }
    </style>
</head>
<body>
    &nbsp;<form id="form1" runat="server" class="auto-style20">
          <p class="auto-style19">Customer Data Entry Page</p>
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" CssClass="auto-style2" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" CssClass="auto-style1" height="22px" width="221px"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style3" height="16px" Text="First Name" width="124px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style4" height="22px" width="221px"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" CssClass="auto-style5" height="16px" Text="Last Name" width="124px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style6" height="22px" width="221px"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" CssClass="auto-style7" height="16px" Text="Address" width="124px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" CssClass="auto-style8" height="22px" width="221px"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" CssClass="auto-style9" height="16px" Text="Post Code" width="124px"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" CssClass="auto-style10" height="22px" width="221px"></asp:TextBox>
        <asp:Label ID="lblDOB" runat="server" CssClass="auto-style11" height="16px" Text="Date of Birth" width="124px"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" CssClass="auto-style12" width="221px" height="22px"></asp:TextBox>
        
        <asp:Label ID="lblOver18" runat="server" CssClass="auto-style14" height="16px" Text="Over 18 ?" width="124px"></asp:Label>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style15"></asp:Label>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style16" height="29px" OnClick="btnOK_Click" Text="OK" width="60px" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style17" Text="Cancel" />
        
          <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 409px; top: 84px; position: absolute; color: #000080; font-weight: 700; font-family: 'Comic Sans MS';" Text="Find" OnClick="btnFind_Click" />
        
          <asp:CheckBox ID="chkOver18" runat="server" style="z-index: 1; left: 131px; top: 300px; position: absolute" />
        
    </form>
</body>
</html>
