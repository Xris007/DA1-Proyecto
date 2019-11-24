<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebEquiposDetalle.aspx.cs" Inherits="SitioWEBeSports.Consultas.Team_Consulta.WebEquiposDetalle" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p aria-disabled="False">
        
    <p aria-disabled="False" class="tituloForm">
        
        Consulta Detail Team
        <p></p>
        
        <table style="width: 70%">
        <tr>
            <td style="height: 23px; width: 144px">Ingrese Equipo:</td>
            <td style="height: 23px">
                <asp:DropDownList ID="cboTeam" runat="server" Width="220px">
                </asp:DropDownList>
                <ajaxToolkit:DropDownExtender ID="cboTeam_DropDownExtender" runat="server" BehaviorID="DropDownList1_DropDownExtender" DynamicServicePath="" TargetControlID="cboTeam">
                </ajaxToolkit:DropDownExtender>
            </td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td style="width: 144px">Torneo 1:</td>
            <td>
                <asp:DropDownList ID="cboTmnt1" runat="server" Width="220px">
                </asp:DropDownList>
                <ajaxToolkit:DropDownExtender ID="cboTmnt1_DropDownExtender" runat="server" BehaviorID="DropDownList2_DropDownExtender" DynamicServicePath="" TargetControlID="cboTmnt1">
                </ajaxToolkit:DropDownExtender>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; height: 23px">Torneo 2:</td>
            <td style="height: 23px">
                <asp:DropDownList ID="cboTmnt2" runat="server" Width="220px">
                </asp:DropDownList>
                <ajaxToolkit:DropDownExtender ID="cboTmnt2_DropDownExtender" runat="server" BehaviorID="DropDownList3_DropDownExtender" DynamicServicePath="" TargetControlID="cboTmnt2">
                </ajaxToolkit:DropDownExtender>
&nbsp;
                <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
            </td>
            <td style="height: 23px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; height: 23px">&nbsp;</td>
            <td style="height: 23px">
                <asp:Label ID="lblMensaje1" runat="server"></asp:Label>
            </td>
            <td style="height: 23px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grvDetailTeam" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="604px">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
