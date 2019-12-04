<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebHereoRol.aspx.cs" Inherits="SitioWEBeSports.Consultas.Hero_Consulta.WebHereoRol" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  

    <p class="tituloForm">
        <br />
        Consulta Heroes de Dota 2</p>
    <p class="tituloForm">
        &nbsp;</p>
    <div class="container">
    <table style="width: 86%">
        <tr>
            <td style="height: 23px; width: 217px">Seleccione Hereos:</td>
            <td style="height: 23px">
                <asp:DropDownList ID="cboHeroe" runat="server" Width="220px" >
                </asp:DropDownList>
                <ajaxToolkit:DropDownExtender ID="cboHeroe_DropDownExtender" runat="server" BehaviorID="cboHeroe_DropDownExtender" DynamicServicePath="" TargetControlID="cboHeroe">
                </ajaxToolkit:DropDownExtender>
            </td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td style="width: 217px; height: 23px">Seleccione Rol de Jugador:</td>
            <td style="height: 23px">
                <asp:DropDownList ID="cboRol" runat="server" Width="220px">
                    <asp:ListItem>Hard Carry</asp:ListItem>
                    <asp:ListItem>Midlaner</asp:ListItem>
                    <asp:ListItem>Offlaner</asp:ListItem>
                    <asp:ListItem>Roaming</asp:ListItem>
                    <asp:ListItem>Support</asp:ListItem>
                </asp:DropDownList>
                <ajaxToolkit:DropDownExtender ID="cboRol_DropDownExtender" runat="server" BehaviorID="cboRol_DropDownExtender" DynamicServicePath="" TargetControlID="cboRol">
                </ajaxToolkit:DropDownExtender>
&nbsp;
                <asp:Button ID="IdMostrar" runat="server" OnClick="IdMostrar_Click" Text="Mostrar" />
            </td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Home.aspx">Ir al Home</asp:HyperLink>
            </td>
            <td class="auto-style2">
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td colspan="3">
                <div class="grid-container">
                <asp:GridView ID="grvHereoRolDetalle" runat="server" Width="884px" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover">
                    <Columns>
                        <asp:BoundField DataField="NomTorneo" HeaderText="Torneo" />
                        <asp:BoundField DataField="RoundPartida" HeaderText="Round" />
                        <asp:BoundField DataField="NickJugador" HeaderText="Nick Name" />
                        <asp:BoundField DataField="NomHeroe" HeaderText="Heroe" />
                        <asp:BoundField DataField="Kills" HeaderText="Asesinatos" />
                        <asp:BoundField DataField="Deaths" HeaderText="Muertes" />
                        <asp:BoundField DataField="Assists" HeaderText="Asistencias" />
                    </Columns>
                </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    </div>
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
