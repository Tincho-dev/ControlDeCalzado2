//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
      
    ViewBag.Title = "Inicio";
    

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
   __o = Html.ActionLink("Crear Nuevo Color", "Create", "Color", new { @class = "btn" });


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.CodigoColor);


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.DescripcionColor);


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
        foreach (var item in Model) {
        

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.CodigoColor);


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.DescripcionColor);


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
           __o = Html.ActionLink("Editar", "Edit", new { id=item.CodigoColor }, new { @class = "btn" });


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
           __o = Html.ActionLink("Detalles", "Details", new { id=item.CodigoColor }, new { @class = "btn" });


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
           __o = Html.ActionLink("Eliminar", "Delete", new { id=item.CodigoColor }, new { @class = "btn" });


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
             
}

#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Color\Index.cshtml"
   __o = Html.ActionLink("Volver al Inicio", "Index", "Home", null , new{ @class = "btn" } );


#line default
#line hidden
}
}
}
