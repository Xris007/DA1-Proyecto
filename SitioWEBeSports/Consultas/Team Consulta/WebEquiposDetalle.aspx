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
            <td style="width: 144px">Seleccione Torneo:</td>
            <td>
                <asp:DropDownList ID="cboTorneo" runat="server" Width="220px">
                </asp:DropDownList>
                <ajaxToolkit:DropDownExtender ID="cboTorneo_DropDownExtender" runat="server" BehaviorID="DropDownList2_DropDownExtender" DynamicServicePath="" TargetControlID="cboTorneo">
                </ajaxToolkit:DropDownExtender>
            &nbsp;
                <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; height: 23px">&nbsp;</td>
            <td style="height: 23px">
&nbsp;
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
            <td style="height: 23px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 144px; height: 23px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Home.aspx">Ir al Home</asp:HyperLink>
            </td>
            <td style="height: 23px">
                &nbsp;</td>
            <td style="height: 23px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grvDetailTeam" runat="server" Width="604px" CssClass="table table-striped table-bordered table-hover">
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
