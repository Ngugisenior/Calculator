<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 4px solid #00FF00;
            background-color: #000000;
        }
        .auto-style9 {
            width: 71px;
            text-align: center;
        }
        .auto-style10 {
            width: 71px;
            height: 42px;
            text-align: center;
        }
        .auto-style11 {
            width: 75px;
            text-align: center;
        }
        .auto-style12 {
            width: 75px;
            height: 42px;
            text-align: center;
        }
        .auto-style15 {
            margin-right: 404px;
        }
        .auto-style18 {
            text-align: center;
            width: 97px;
        }
        .auto-style19 {
            height: 42px;
            text-align: center;
            width: 97px;
        }
        .auto-style20 {
            text-decoration: underline;
            color: #6666FF;
            text-align: left;
        }
        .auto-style21 {
            height: 42px;
            width: 97px;
        }
        .auto-style22 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style20">PaCasio Calculator App</h1>
            <br />
            <div class="auto-style22">
            <asp:Panel ID="Panel1" runat="server" CssClass="auto-style15" Height="346px" Width="255px" BackColor="#6600CC" BorderStyle="Outset" BorderWidth="5px" Direction="LeftToRight" HorizontalAlign="Justify">
                <br />
                <asp:Label ID="LblResults" runat="server" ForeColor="White" BorderStyle="Inset" BorderWidth="5px" Font-Bold="True" Font-Size="Large" Height="30px" Width="241px"></asp:Label>
                <br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style9">
                            <asp:Button ID="BtnOne" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnOne_Click" Text="1" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style11">
                            <asp:Button ID="BtnTwo" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnTwo_Click" Text="2" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style18">
                            <asp:Button ID="BtnThree" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnThree_Click" Text="3" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Button ID="BtnFour" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnFour_Click" Text="4" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style11">
                            <asp:Button ID="BtnFive" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnFive_Click" Text="5" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style18">
                            <asp:Button ID="BtnSix" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnSix_Click" Text="6" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Button ID="BtnSeven" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnSeven_Click" Text="7" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style11">
                            <asp:Button ID="BtnEight" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnEight_Click" Text="8" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style18">
                            <asp:Button ID="BtnNine" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnNine_Click" Text="9" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">
                            <asp:Button ID="BtnZero" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnZero_Click" Text="0" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style12">
                            <asp:Button ID="BtnDiv" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnDiv_Click" Text="/" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style19">
                            <asp:Button ID="BtnMult" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnMult_Click" Text="*" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">
                            <asp:Button ID="BtnAdd" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnAdd_Click" Text="+" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style12">
                            <asp:Button ID="BtnSub" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnSub_Click" Text="-" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style19">
                            <asp:Button ID="BtnEquals" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnEquals_Click" Text="=" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">
                            <asp:Button ID="BtnDelete" runat="server" BackColor="Fuchsia" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnDelete_Click" Text="Clr" Width="77px" BorderStyle="Outset" BorderWidth="5px" />
                        </td>
                        <td class="auto-style12">
                            <asp:Button ID="BtnDelVar" runat="server" BackColor="Fuchsia" BorderStyle="Outset" BorderWidth="5px" Font-Bold="True" Font-Size="Large" ForeColor="#66FFFF" Height="38px" OnClick="BtnDelVar_Click" Text="Del" Width="77px" />
                        </td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
