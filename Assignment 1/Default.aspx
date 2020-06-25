<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 47%;
            height: 135px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Image ID="Image1" runat="server" AlternateText="UHCL Logo" Height="239px" ImageUrl="https://upload.wikimedia.org/wikipedia/commons/5/5e/UHCL_logo_%282%29.png" Width="235px" />
            <br />
            <br />
            <asp:Label ID="lbClass" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="CINF 4320"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbAssignment" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Measurement Conversions"></asp:Label>
            <br />
            <br />
            <table class="auto-style3">
                <tr>
                    <td>
                        <asp:Label ID="lbType" runat="server" Font-Size="Large" Text="Type:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbAmount" runat="server" Font-Size="Large" Text="Amount:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbConversions" runat="server" Font-Size="Large" Text="Conversions:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddType_SelectedIndexChanged">
                            <asp:ListItem>Please choose a type</asp:ListItem>
                            <asp:ListItem>Length</asp:ListItem>
                            <asp:ListItem>Liquid</asp:ListItem>
                            <asp:ListItem>Temperature</asp:ListItem>
                            <asp:ListItem>Mass</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="txAmount" runat="server" Height="22px"></asp:TextBox>
&nbsp;&nbsp;
                        <asp:Label ID="lbMeasurement" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddConversions" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddConversions_SelectedIndexChanged">
                            <asp:ListItem>Please choose a type first</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btConvert" runat="server" OnClick="btConvert_Click" Text="Convert" />
                    </td>
                    <td>
                        <asp:Label ID="lbResult" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lbResultMeasurement" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btClear" runat="server" OnClick="btClear_Click" Text="Clear" />
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
