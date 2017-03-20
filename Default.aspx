<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lbl_selector1" runat="server" Text="Select"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddl_Selector1" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                </td>
            </tr>
    </table>
    </div>
    <div>
        <table>
            <tr>
                <td>
                    <%--<asp:DataGrid ID="dgSearchResults" runat="server" Visible="false" AllowPaging="true" PageSize="20"></asp:DataGrid>--%>
                    <asp:GridView ID="grdSearchResults" runat="server" Visible="false" AllowPaging="true" PageSize="15"></asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
