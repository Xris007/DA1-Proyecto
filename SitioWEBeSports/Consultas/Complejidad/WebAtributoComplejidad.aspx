<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebAtributoComplejidad.aspx.cs" Inherits="SitioWEBeSports.Consultas.Complejidad.WebAtributoComplejidad" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .grid-container {
    display: grid;
    justify-content: space-around;
    grid-template-columns: 50px 50px 50px;
    grid-gap: 10px;
    
    
}


    </style>
    <p class="tituloForm">
        <br />
        Consulta de Atributo por Complejidad
    </p>
    <div class="container-fluid">
    <table style="width: 70%">
        <tr>
            <td>Seleccione Complejidad:</td>
            <td>
                <asp:DropDownList ID="cboComplejidad" runat="server">
                    <asp:ListItem>Baja</asp:ListItem>
                    <asp:ListItem>Moderado</asp:ListItem>
                    <asp:ListItem>Alta</asp:ListItem>
                </asp:DropDownList>
                <ajaxToolkit:DropDownExtender ID="cboComplejidad_DropDownExtender" runat="server" BehaviorID="cboComplejidad_DropDownExtender" DynamicServicePath="" TargetControlID="cboComplejidad">
                </ajaxToolkit:DropDownExtender>
            </td>
            <td style="width: 8px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 27px">Seleccione Atributo:</td>
            <td style="height: 27px">
                <asp:DropDownList ID="cboAtributo" runat="server">
                    <asp:ListItem>Fuerza</asp:ListItem>
                    <asp:ListItem>Agilidad</asp:ListItem>
                    <asp:ListItem>Inteligencia</asp:ListItem>
                </asp:DropDownList>
                <ajaxToolkit:DropDownExtender ID="cboAtributo_DropDownExtender" runat="server" BehaviorID="cboAtributo_DropDownExtender" DynamicServicePath="" TargetControlID="cboAtributo">
                </ajaxToolkit:DropDownExtender>
            </td>
            <td style="width: 8px; height: 27px;">
                <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Home.aspx">Ir a Home</asp:HyperLink>
            </td>
            <td>
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
            <td style="width: 8px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                
            </td>
        </tr>
    </table>
    </div>
    <br />
    <div class="container-fluid">
    <asp:GridView ID="grvAtributo" runat="server" DataKeyNames="IdHeroe" Width="517px" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover">
                    <Columns>
                        <asp:BoundField DataField="IdHeroe" HeaderText="Id.Heroe" />
                        <asp:BoundField DataField="NomHeroe" HeaderText="Heroe" />
                        <asp:BoundField DataField="Atributo" HeaderText="Atributo" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:BoundField DataField="Complejidad" HeaderText="Complejidad" />
                    </Columns>
                </asp:GridView>
        </div>
    <%--Este es el panel  que contiene los mensajes de error--%>
              <asp:LinkButton ID="lnkMensaje" runat="server"></asp:LinkButton>
    <ajaxToolkit:ModalPopupExtender id="mpeMensaje" runat="server" backgroundcssclass="FondoAplicacion" okcontrolid="btnAceptar" popupcontrolid="pnlMensaje" targetcontrolid="lnkMensaje" />
    <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="300">
        <table border="0" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;" width="300px">
            <tr>
                <td align="center" class="auto-style2">
                    <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" />
                </td>
                <td class="auto-style2" width="12%">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="Right" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" />
                </td>
            </tr>
        </table>
        <div>
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Black" />
        </div>
        <div>
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
        </div>
    </asp:Panel>
    <br />
</asp:Content>
