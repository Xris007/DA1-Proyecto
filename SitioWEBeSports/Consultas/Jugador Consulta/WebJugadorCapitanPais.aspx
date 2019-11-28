<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebJugadorCapitanPais.aspx.cs" Inherits="SitioWEBeSports.Consultas.Jugador_Consulta.WebJugadorCapitanPais" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<p class="tituloForm">
        <br />
        Consultas de Jugadores</p>
    <p class="tituloForm">
        &nbsp;</p>
    <table style="width: 86%">
        <tr>
            <td style="height: 23px; width: 264px">Seleccionar por País (opcional):</td>
            <td style="height: 23px">
                <asp:DropDownList ID="cboPais" runat="server" Width="220px">
                    <asp:ListItem>Ninguno</asp:ListItem>
                </asp:DropDownList>
                <ajaxToolkit:DropDownExtender ID="cboPais_DropDownExtender" runat="server" BehaviorID="cboHeroe_DropDownExtender" DynamicServicePath="" TargetControlID="cboPais">
                </ajaxToolkit:DropDownExtender>
            </td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td style="width: 264px; height: 23px">Solo mostrar Capitanes</td>
            <td style="height: 23px">
&nbsp;
                <asp:CheckBox ID="chkCapitan" runat="server" />
&nbsp;</td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td style="width: 264px"><asp:Button ID="IdMostrar" runat="server" OnClick="IdMostrar_Click" Text="Mostrar" />
            </td>
            <td>
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Home.aspx">Ir al Home</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grvJugador" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="884px" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ApeJugador" HeaderText="Apellido" />
                        <asp:BoundField DataField="NomJugador" HeaderText="Nombre" />
                        <asp:BoundField DataField="NickJugador" HeaderText="Nickname " />
                        <asp:BoundField DataField="PaisJugador" HeaderText="País" />
                        <asp:BoundField DataField="RolJugador" HeaderText="Rol" />
                        <asp:BoundField DataField="NomEquipo" HeaderText="Equipo" />
                    </Columns>
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
    <br />
    <%--Este es el panel  que contiene los mensajes de error--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
               <ajaxToolkit:ModalPopupExtender ID="mpeMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" 
                     />
<asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="300"> 
                    <table border="0" width="300px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center" class="auto-style2"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="auto-style2"> 
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table> 
                    <div> 
                        <asp:Label ID="lblMensaje" runat="server" ForeColor ="Black" /> 
                    </div> 
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" /> 
                    </div> 
                </asp:Panel> 
</asp:Content>
