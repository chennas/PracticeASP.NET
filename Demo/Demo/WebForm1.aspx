<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="border: 1px solid black; font-family:Arial">
        <tr>
            <td>
                <b>FirstName</b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFirstName"/>
                <asp:Label Text="lblFirstName" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                <b>
                    LastName
                </b>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtLastName"/>
                <asp:Label Text="lblLastName" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                <b>
                    Email
                </b>
            </td>
            <td>
                <asp:TextBox runat="server" id="txtEmail"/>
                <asp:Label Text="lblEmail" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
