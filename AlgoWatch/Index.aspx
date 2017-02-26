<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AlgoWatch.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Dll Path:
            <asp:TextBox ID="txtDll" runat="server" Width="512px"></asp:TextBox><br />

            <br />
            <asp:Button ID="btnGetMethods" runat="server" Text="GetMethods" OnClick="btnGetMethods_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            Input Array:
             <asp:TextBox ID="txtInput" runat="server" Width="457px" Text="3 5 2 1 6"></asp:TextBox><br />

            Call Method:
             <asp:TextBox ID="txtMethod" runat="server" Width="457px"></asp:TextBox><br />

            
            <br />
            <asp:Button ID="btnCall" runat="server" Text="Call" OnClick="btnCall_Click" /> <br />

            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
