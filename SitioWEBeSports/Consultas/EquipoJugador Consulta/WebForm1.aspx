<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SitioWEBeSports.Consultas.EquipoJugador_Consulta.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Consulta Equipo-Jugador Dota 2</p>
    <table class="nav-justified" style="width: 59%">
        <tr>
            <td>Equipo:</td>
            <td class="modal-sm" style="width: 249px">
                <asp:DropDownList ID="cboEquipos" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Home.aspx">Ir al Home</asp:HyperLink>
            </td>
            <td class="modal-sm" style="width: 249px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grvJugadores" runat="server" AutoGenerateColumns="False" Width="535px" CssClass="table table-striped table-bordered table-hover">
                    <Columns>
                        <asp:BoundField DataField="NomJugador" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApeJugador" HeaderText="Apellido" />
                        <asp:BoundField DataField="NickJugador" HeaderText="NickName" />
                        <asp:BoundField DataField="PaisJugador" HeaderText="Pais" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td class="modal-sm" style="width: 249px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
