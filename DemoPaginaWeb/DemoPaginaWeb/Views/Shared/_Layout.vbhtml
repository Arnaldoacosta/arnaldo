<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">





    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>

    @*<!-- Codigo de prueba para ver si saca error de acento-->
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>PAMPA seguridad privada</title>
        <meta name="description" content="custodia-de-camiones; cuastodia-de-valores; seguridad-privada; zona-oeste; vigilancia-custodia; informes; pericias; custodia-de-mercaderia">
        <meta name="viewport" content="custodia-de-camiones, cuastodia-de-valores, seguridad-privada, zona-oeste, vigilancia-custodia, informes,    pericias, custodia-de-mercaderia">
        <!-- fin error acento-->




        <link rel="apple-touch-icon" href="http://www.pampaseguridad.com.ar/apple-touch-icon.png">
        <!-- Place favicon.ico in the root directory -->
        <!-- Font -->
        <link href="~/Content/css/css" rel="stylesheet" type="text/css">
        <link href="~/Content/css/css(1)" rel="stylesheet" type="text/css">
        <!-- Font -->


        <link rel="stylesheet" href="~/Content/css/normalize.css">
        <link rel="stylesheet" href="~/Content/css/main.css">
        <link rel="stylesheet" href="~/Content/css/font-awesome.min.css">
        <link rel="stylesheet" href="~/Content/css/animate.css">
        @*<link rel="stylesheet" href="./Prueba_files/bootstrap.min.css">

        <link rel="stylesheet" href="~/Content/css/style.css">
        <link rel="stylesheet" href="~/Content/css/responsive.css">


        <script src="~/Scripts/scriptPag/analytics.js.descarga"></script>
        <script src="~/Scripts/scriptPag/modernizr-2.8.3.min.js.descarga"></script>*@



    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <link href="~/Content/css/StyloFer.css" rel="stylesheet" />
</head>
<body>

  
        <!-- Main Menu End -->
        <div class="navbar navbar-inverse navbar-fixed-top">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        @Html.ActionLink("Nombre de aplicación", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
                    </div>
                    <div class="navbar-collapse collapse">
                        <ul class="nav navbar-nav">
                            <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                            <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                            <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                        </ul>
                    </div>
                </div>
            </div>
        <div class="container-fluid">
            @RenderBody()
            <hr />
            <footer>
                <p>&copy; @DateTime.Now.Year - Mi aplicación ASP.NET</p>
            </footer>
        </div>

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
</body>
</html>
