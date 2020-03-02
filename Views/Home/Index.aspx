<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>IndexVideos</title>
    
</head>
<body>
  <meta charset="UTF-8">
    <%//Como la gente lo busca en internet %>
  <meta name="description" content="ASP.NET MVC 2 CRUD Video">
  <meta name="keywords" content="ASP.NET, MVC, Facpya">
  <meta name="author" content="Mauricio Hernandez">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <h1>Menu de Opciones</h1>
    <a href="/Video/Create">Agregar Video</a>
    <hr />
    <a href="/Video/Delete">EliminarVideo</a>
</body>
</html>
