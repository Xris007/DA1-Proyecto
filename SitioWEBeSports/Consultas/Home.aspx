<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SitioWEBeSports.Consultas.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Bootstrap Example</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    
    <div class="jumbotron text-center">
  <h1>eSports Consultas

  </h1>
  <p>Resize this responsive page to see the effect!</p> 
</div>
  
<div class="container">
  <div class="row">
    <div class="col-sm-4">
      <h3>Consultas Heroes</h3>
      
        <div class="thumbnail">
        <a href="/Consultas/Hero/WebHereoRol.aspx" target="_blank" >
          
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/dota_heroes.png" />
          <div class="caption">
            <p>Lorem ipsum donec id elit non mi porta gravida at eget metus.</p>
          </div>
        </a>
      </div>
    </div>
   <div class="col-sm-4">
      <h3>Consultas Capitan
      </h3>
      
        <div class="thumbnail">
        <a href="/Consultas/Jugador Consulta/WebJugadorCapitanPais.aspx" target="_blank">
          
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/lc.jpg" />
          <div class="caption">
            <p>Lorem ipsum donec id elit non mi porta gravida at eget metus.</p>
          </div>
        </a>
      </div>
    </div>
    <div class="col-sm-4">
      <h3>Consultas Equipo Detalle</h3>
      
        <div class="thumbnail">
        <a href="/Consultas/Team Consulta/WebEquiposDetalle.aspx" >
          
            <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/serveimage.jpg"/>
          <div class="caption">
            <p>Lorem ipsum donec id elit non mi porta gravida at eget metus.</p>
          </div>
        </a>
      </div>
    </div>
  </div>
</div>
</body>
</html>
