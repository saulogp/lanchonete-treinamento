<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lanchonete.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 156px;
        }
        .auto-style2 {
            width: 100%;
            height: 120px;
        }
        .auto-style3 {
            width: 156px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body style="height: 112px">
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style1">Descrição</td>
                <td>
                    <asp:TextBox ID="txtDesc" runat="server" Width="317px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Valor</td>
                <td>
                    <asp:TextBox ID="txtValor" runat="server" Width="315px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Inserir" />
                    <asp:Label ID="lblMSG" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    <asp:GridView ID="gvPizza" runat="server" Width="406px">
                    </asp:GridView>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
