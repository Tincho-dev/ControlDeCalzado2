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

#line 1 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
      
    ViewBag.Title = "Detalle";
    

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
   __o = Html.ActionLink("Crear Nuevo Detalle", "Create", "Detalle", new { @class = "btn" });


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.PrecioU);


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.SubTotal);


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.Cantidad);


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.Descripcion);


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.Id_Proyecto);


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.Titulo);


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
        foreach (var item in Model) {
        

#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.PrecioU);


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.SubTotal);


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.Cantidad);


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.Descripcion  );


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.Id_Proyecto);


#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.Titulo);


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.ActionLink("Editar", "Edit", new { id=item.id }, new { @class = "btn" });


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.ActionLink("Detalles", "Details", new { id=item.id }, new { @class = "btn" });


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
           __o = Html.ActionLink("Eliminar", "Delete", new { id=item.id }, new { @class = "btn" });


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Detalle\Index.cshtml"
             
}

#line default
#line hidden
}
}
}