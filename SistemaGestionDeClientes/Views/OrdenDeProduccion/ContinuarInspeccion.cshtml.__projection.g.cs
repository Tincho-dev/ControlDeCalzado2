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

#line 2 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
using Services;

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
using Model.Domain.ControlDeCalzado;

#line default
#line hidden

public class _Page_ContinuarInspeccion_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_ContinuarInspeccion_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
__o = model;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
  
    ViewBag.Title = "Continuar Inspeccion";
    Modelo modelo = ModeloService.Get(Model.Sku);
    Color color = ColorService.Get(Model.CodigoColor);
    var DefectosR = DefectoService.GetReproceso();
    var DefectosO = DefectoService.GetObservado();
    var horaActual = DateTime.Now.TimeOfDay;
    int contadorParesDePrimera = Model.CantidadDePrimera;


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                         __o = Model.FechaDeInicio;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                               __o = Model.IdLinea;


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                             __o = Model.Sku;


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                __o = modelo.Denominacion;


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                      __o = Model.CodigoColor;


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                               __o = color.DescripcionColor;


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                          __o = Model.CantidadDePrimera;


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
            foreach (var item in DefectosO)
            {
                

#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                                                        __o = item.IdDefecto;


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                     
            }

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
            foreach (var item in DefectosR)
            {
                

#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                     
            }

#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
__o = Html.ActionLink("Volver a Detalles", "Details", new { id = Model.Numero }, new { @class = "btn" });


#line default
#line hidden
DefineSection("Scripts", () => {


#line 20 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                            __o = Model.Numero;


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\116668446E4AAC94DEC00FC5759EA5DDFDD3\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                 __o = Url.Action("ActualizarCantidad", "OrdenDeProduccion");


#line default
#line hidden
});

}
}
}
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

#line 2 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
using Services;

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
using Model.Domain.ControlDeCalzado;

#line default
#line hidden

public class _Page_Views_OrdenDeProduccion_ContinuarInspeccion_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_OrdenDeProduccion_ContinuarInspeccion_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
__o = model;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
  
    ViewBag.Title = "Continuar Inspeccion";
    Modelo modelo = ModeloService.Get(Model.Sku);
    Color color = ColorService.Get(Model.CodigoColor);
    var DefectosR = DefectoService.GetReproceso();
    var DefectosO = DefectoService.GetObservado();
    var horaActual = DateTime.Now.TimeOfDay;
    int contadorParesDePrimera = Model.CantidadDePrimera;


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                         __o = Model.FechaDeInicio;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                               __o = Model.IdLinea;


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                             __o = Model.Sku;


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                __o = modelo.Denominacion;


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                      __o = Model.CodigoColor;


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                               __o = color.DescripcionColor;


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                          __o = Model.CantidadDePrimera;


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
            foreach (var item in DefectosO)
            {
                

#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                                                     __o = ;
.n
#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                     
            }

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
            foreach (var item in DefectosR)
            {
                

#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                     
            }

#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
__o = Html.ActionLink("Volver a Detalles", "Details", new { id = Model.Numero }, new { @class = "btn" });


#line default
#line hidden
DefineSection("Scripts", () => {


#line 20 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                            __o = Model.Numero;


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
on.cshtml"
                 __o = Url.Action("ActualizarCantidad", "OrdenDeProduccion");


#line default
#line hidden
});

}
}
}
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

#line 2 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
using Services;

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
using Model.Domain.ControlDeCalzado;

#line default
#line hidden

public class _Page_ContinuarInspeccion_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_ContinuarInspeccion_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
__o = model;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
  
    ViewBag.Title = "Continuar Inspeccion";
    Modelo modelo = ModeloService.Get(Model.Sku);
    Color color = ColorService.Get(Model.CodigoColor);
    var DefectosR = DefectoService.GetReproceso();
    var DefectosO = DefectoService.GetObservado();
    var horaActual = DateTime.Now.TimeOfDay;
    int contadorParesDePrimera = Model.CantidadDePrimera;


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                         __o = Model.FechaDeInicio;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                               __o = Model.IdLinea;


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                             __o = Model.Sku;


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                __o = modelo.Denominacion;


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                                      __o = Model.CodigoColor;


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                               __o = color.DescripcionColor;


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                                          __o = Model.CantidadDePrimera;


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
            foreach (var item in DefectosO)
            {
                

#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                     
            }

#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
            foreach (var item in DefectosR)
            {
                

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                   __o = Html.Raw(item.DescripcionDefecto);


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                     
            }

#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
__o = Html.ActionLink("Volver a Detalles", "Details", new { id = Model.Numero }, new { @class = "btn" });


#line default
#line hidden
DefineSection("Scripts", () => {


#line 19 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                           __o = Model.Numero;


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
                 __o = Url.Action("ActualizarCantidad", "OrdenDeProduccion");


#line default
#line hidden
});

}
}
}
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

public class _Page_Views_OrdenDeProduccion_ContinuarInspeccion_cshtml : System.Web.WebPages.WebPage {
#line hidden
public _Page_Views_OrdenDeProduccion_ContinuarInspeccion_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\ContinuarInspeccion.cshtml"
  
    ViewBag.Title = "ContinuarInspeccion";


#line default
#line hidden
}
}
}
