<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebJugadorCRUD.aspx.cs" Inherits="SitioWEBeSports.Mantenimento.WebJugadorCRUD" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p class="tituloForm">
        <br />
        Mantenimiento Jugadores</p>
    <p>
        <asp:Button ID="btnNuevo" runat="server" CssClass="boton-new" Text="Nuevo" OnClick="btnNuevo_Click" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Home.aspx">Ir al Home</asp:HyperLink>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="935px"  OnRowCommand="GridView1_RowCommand" CssClass="table table-striped table-bordered table-hover">
            <Columns>
                <asp:ButtonField ButtonType="Image" CommandName="Editar" ImageUrl="~/Images/docRM.png" Text="Botón">
                <ItemStyle Width="30px" />
                </asp:ButtonField>
                <asp:BoundField DataField="IdJugador" HeaderText="ID">
                <ItemStyle Width="20px" />
                </asp:BoundField>
                <asp:BoundField DataField="ApeJugador" HeaderText="Apellido">
                <ItemStyle Width="180px" />
                </asp:BoundField>
                <asp:BoundField DataField="NomJugador" HeaderText="Nombre">
                <ItemStyle Width="180px" />
                </asp:BoundField>
                <asp:BoundField DataField="EdadJugador" HeaderText="Edad">
                <ItemStyle Width="50px" />
                </asp:BoundField>
                <asp:BoundField DataField="PaisJugador" HeaderText="País">
                <ItemStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="RolJugador" HeaderText="Rol">
                <ItemStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="NomEquipo" HeaderText="Equipo">
                <ItemStyle Width="120px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </p>

    <%--Este es el panel  que contiene los mensajes de error--%><%--el link button o cualquiero otro control para el manejo del modal--%>
           <asp:LinkButton Text="" ID = "btnPopup" runat="server" />
    <%--El modalpoput extender : vease el TargetControl que apunta al linkbutton y el popuconttol ID que apunhta al panel--%> 
      <ajaxtoolkit:modalpopupextender ID="PopMant" runat="server" BackgroundCssClass="FondoAplicacion"  
        TargetControlID="btnPopup" PopupControlID="Panel1"  >
    </ajaxtoolkit:modalpopupextender>
    <asp:Panel ID="Panel1" runat="server" CssClass="CajaDialogo" align="center" Style="display:normal" Width="700">
          
            <table style="border: Solid 3px #D55500; height: 308px;"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: darkred">
                    <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                        align="center">
                        Nuevo Jugador
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 45%" class="labelContenido">
                        &nbsp;</td>
                      <td align="left">
                          &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 45px">
                        Nombre:
                    </td>
                    <td align="left" style="height: 45px">
                        <asp:TextBox ID="txtNombre" runat="server" Width="487px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">
                        Apellido:
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtApellido" runat="server" Width="487px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 37px">
                        Nickname:
                    </td>
                    <td align="left" style="height: 37px">
                        <asp:TextBox ID="txtNick" runat="server" Width="487px" />
                    </td>
                </tr>
               
                     <tr>
                         <td align="right" class="labelContenido" style="height: 37px">Edad: </td>
                         <td align="left" style="height: 37px">
                             <asp:TextBox ID="txtEdad" runat="server" Width="49px" />
                         </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 36px">País:</td>
                    <td align="left" style="height: 36px">
                        <asp:TextBox ID="txtPais" runat="server" Width="487px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 37px">¿Es capitán?</td>
                    <td align="left" style="height: 37px">
                        <asp:CheckBox ID="chkCapitan" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 37px">Rol:</td>
                    <td align="left" style="height: 37px">
                        <asp:DropDownList ID="dropRol" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Hard Carry</asp:ListItem>
                            <asp:ListItem>Midlaner</asp:ListItem>
                            <asp:ListItem>Offlaner</asp:ListItem>
                            <asp:ListItem>Roaming</asp:ListItem>
                            <asp:ListItem>Support</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 37px">Equipo:</td>
                    <td align="left" style="height: 37px">
                        <asp:DropDownList ID="dropEquipo" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMensaje2" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="btnGrabar" runat="server" CssClass="boton-new" OnClick="btnGrabar_Click" Text="Grabar" Width="100px" />
                        <ajaxToolkit:ConfirmButtonExtender ID="btnGrabar_ConfirmButtonExtender" runat="server" BehaviorID="btnGrabar_ConfirmButtonExtender" ConfirmText="¿Seguro(a) de grabar?" TargetControlID="btnGrabar" />
                        &nbsp;<asp:Button ID="btnCerrar" runat="server" CssClass="boton-new" Text="Cancelar" Width="100px" />
                    </td>
                </tr>
              
            </table>
                        
        </asp:Panel>

    <%--Este es el panel  que contiene los mensajes de error--%>            <%--el link button o cualquiero otro control para el manejo del modal--%>
           <asp:LinkButton Text="" ID = "btnPopup2" runat="server" />
    <%--El modalpoput extender : vease el TargetControl que apunta al linkbutton y el popuconttol ID que apunhta al panel--%> 
      <ajaxtoolkit:modalpopupextender ID="PopMant2" runat="server" BackgroundCssClass="FondoAplicacion"  
        TargetControlID="btnPopup2" PopupControlID="Panel2"  >
    </ajaxtoolkit:modalpopupextender>
    <asp:Panel ID="Panel2" runat="server" CssClass="CajaDialogo" align="center" Style="display:normal" Width="700">
          
            <table style="border: Solid 3px #D55500; height: 308px;"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: darkred">
                    <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                        align="center">
                        Actualizar Jugador
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 45%; height: 27px;" class="labelContenido">
                        </td>
                      <td align="left" style="height: 27px">
                          </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="width: 45%; height: 27px;">Id:</td>
                    <td align="left" style="height: 27px">
                        <asp:Label ID="lblJugador" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 45px">
                        Nombre:
                    </td>
                    <td align="left" style="height: 45px">
                        <asp:TextBox ID="txtNombre0" runat="server" Width="487px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido">
                        Apellido:
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtApellido0" runat="server" Width="487px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 37px">
                        Nickname:
                    </td>
                    <td align="left" style="height: 37px">
                        <asp:TextBox ID="txtNick0" runat="server" Width="487px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 37px">
                        Edad:
                    </td>
                    <td align="left" style="height: 37px">
                        <asp:TextBox ID="txtEdad0" runat="server" Width="49px" />
                    </td>
                </tr>
               
                     <tr>
                         <td align="right" class="labelContenido" style="height: 36px">País:</td>
                         <td align="left" style="height: 36px">
                             <asp:TextBox ID="txtPais0" runat="server" Width="487px" />
                         </td>
                     </tr>
                     <tr>
                         <td align="right" class="labelContenido" style="height: 37px">¿Es capitán?</td>
                         <td align="left" style="height: 37px">
                             <asp:CheckBox ID="chkCapitan0" runat="server" />
                         </td>
                </tr>
                     <tr>
                         <td align="right" class="labelContenido" style="height: 37px">Rol:</td>
                         <td align="left" style="height: 37px">
                             <asp:DropDownList ID="dropRol0" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                 <asp:ListItem>Hard Carry</asp:ListItem>
                                 <asp:ListItem>Midlaner</asp:ListItem>
                                 <asp:ListItem>Offlaner</asp:ListItem>
                                 <asp:ListItem>Roaming</asp:ListItem>
                                 <asp:ListItem>Support</asp:ListItem>
                             </asp:DropDownList>
                         </td>
                </tr>
                <tr>
                    <td align="right" class="labelContenido" style="height: 37px">Equipo:</td>
                    <td align="left" style="height: 37px">
                        <asp:DropDownList ID="dropEquipo0" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                     <tr>
                         <td colspan="2">
                             <asp:Label ID="lblMensaje3" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style1">
                             &nbsp;</td>
                         <td class="auto-style1">
                             <asp:Button ID="btnGrabar2" runat="server" Text="Grabar" Width="100px" CssClass="boton-new" OnClick="btnGrabar2_Click" />
                             <ajaxToolkit:ConfirmButtonExtender ID="btnGrabar2_ConfirmButtonExtender" runat="server" BehaviorID="btnGrabar2_ConfirmButtonExtender" ConfirmText="¿Seguro(a) de actualizar registro?" TargetControlID="btnGrabar2" />
                             &nbsp;<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="100px" CssClass="boton-new" OnClick="btnEliminar_Click" />
                             <ajaxToolkit:ConfirmButtonExtender ID="btnEliminar_ConfirmButtonExtender" runat="server" BehaviorID="btnEliminar_ConfirmButtonExtender" ConfirmText="¿Seguro(a) de eliminar este registro?" TargetControlID="btnEliminar" />
                             &nbsp;<asp:Button ID="Button2" runat="server"  Text="Cancelar" Width="100px" CssClass="boton-new" />
                         </td>
                     </tr>
              
            </table>
                        
        </asp:Panel>


     <%--Este es el panel  que contiene los mensajes de error--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
               <ajaxtoolkit:modalpopupextender ID="mpeMensaje" runat="server" TargetControlID="lnkMensaje" 
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
                        <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor ="Black" /> 
                    </div> 
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="boton-new" /> 
                    </div> 
                </asp:Panel>
    

</asp:Content>
