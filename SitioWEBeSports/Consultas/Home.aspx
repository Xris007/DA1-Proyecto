<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SitioWEBeSports.Consultas.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>eSporst</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <style>
        .jumbotron{
            margin-top: -20px;
            color: #ffffff;
            background-image: linear-gradient(to right, #8E0E00,#1F1C18);
        }
        .navbar{
            border-radius: 0;
        }
        .bg-4 { 
            background-color: #2f2f2f; /* Black Gray */
            color: #fff;
        }
        .container-fluid2 {
            padding-top: 20px;
            padding-bottom: 20px;
        }
    </style>
</head>
<body>
    <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      
        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>                        
      </button>
      <a class="navbar-brand" href="/Consultas/Home">eSports</a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav">
        <li class="active"><a href="#">Home</a></li>
        <li class="dropdown">
          <a class="dropdown-toggle" data-toggle="dropdown" href="#">Consultas <span class="caret"></span></a>
          <ul class="dropdown-menu">
            <li><a href="/Consultas/Hero/WebHereoRol.aspx">Rol-Heroe</a></li>
            <li><a href="/Consultas/Jugador Consulta/WebJugadorCapitanPais.aspx">Capitan</a></li>
            <li><a href="/Consultas/Complejidad/WebAtributoComplejidad.aspx">Atributo - Complejidad</a></li>
          </ul>
        </li>
        <li><a href="/Mantenimiento/WebJugadorCRUD.aspx">Mantenimiento</a></li>
        
      </ul>
      <%--<ul class="nav navbar-nav navbar-right">
        <li><a href="#"><span class="glyphicon glyphicon-user"></span> Sign Up</a></li>
        <li><a href="#"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
      </ul>--%>
    </div>
  </div>
</nav>
<div class="jumbotron text-center">
  <h1>eSports 

  </h1>
  <p>A form of sport competition using video games</p> 
</div>
  
  
<div class="container">
  <div class="row">
    <div class="col-sm-4">
      <h3>Consultas Heroes</h3>
      
        <div class="thumbnail">
        <a href="/Consultas/Hero/WebHereoRol.aspx">
          
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/dota_heroes.png" />
          <div class="caption">
            
            <p>Consulta web para poder filtrar al heroe por rol en la partida.</p>
          </div>
        </a>
      </div>
    </div>
   <div class="col-sm-4">
      <h3>Consultas Capitan
      </h3>
      
        <div class="thumbnail">
        <a href="/Consultas/Jugador Consulta/WebJugadorCapitanPais.aspx">
          
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/lc.jpg" />
          <div class="caption">
            
            <p>Consulta web para filtrar por país y encontrar a los capitanes de cada equipo.</p>
          </div>
        </a>
      </div>
    </div>
    <div class="col-sm-4">
      <h3>Consultas Equipo Detalle</h3>
      
        <div class="thumbnail">
        <a href="/Consultas/Team Consulta/WebEquiposDetalle.aspx" >
          
            <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/te.jpg"/>
          <div class="caption">
            
            <p>Consulta web para encontrar a cada equipo que participó en diferentes torneos</p>
          </div>
        </a>
      </div>
    </div>
      <div class="col-sm-4">
      <h3>Consultas Atributos</h3>
      
        <div class="thumbnail">
        <a href="/Consultas/Complejidad/WebAtributoComplejidad.aspx"  >
          
            <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/elementales.jpg" />
          <div class="caption">
            
            <p>Consulta web que filtra atributo del heroe por complejidad.</p>
          </div>
        </a>
      </div>
    </div>
   <div class="col-sm-4">
      <h3>Consultas Jugador Detalle
      </h3>
      
        <div class="thumbnail">
        <a href="/Consultas/EquipoJugador Consulta/WebForm1.aspx" target="_blank">
          
            <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/drow.png" />
          <div class="caption">
            
            <p>Consulta web que detalla a cada jugador de un equipo.</p>
          </div>
        </a>
      </div>
    </div>
    <div class="col-sm-4">
      <h3>Mantenimiento Jugador</h3>
      
        <div class="thumbnail">
        <a href="/Mantenimiento/WebJugadorCRUD.aspx" >
          
            <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/serveimage.jpg"/>
          <div class="caption">
            
            <p>Mantenimiento web del jugador, en caso de un cambio en el equipo.</p>
          </div>
        </a>
      </div>
    </div>

                
  </div>
</div>
    <br />
    <hr />
 <footer class="container-fluid2 bg-4 text-center">
  <p> Develop by Us - 2019</p> 
</footer>
</body>
</html>
