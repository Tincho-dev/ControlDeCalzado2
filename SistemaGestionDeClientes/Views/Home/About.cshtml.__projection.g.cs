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

public class _Page_Views_Home_About_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Home_About_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
  
    ViewBag.Title = "Acerca de";


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
using (Html.BeginForm())
{


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
                        



#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = Html.ValidationSummary(true, "", new { @class = "text-danger" });


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
   __o = Html.LabelFor(model => model.Telefono, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.EditorFor(model => model.Telefono, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.ValidationMessageFor(model => model.Telefono, "", new { @class = "text-danger" });


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
   __o = Html.LabelFor(model => model.Mail, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.EditorFor(model => model.Mail, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.ValidationMessageFor(model => model.Mail, "", new { @class = "text-danger" });


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
   __o = Html.LabelFor(model => model.Condicion_Tributaria, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.EditorFor(model => model.Condicion_Tributaria, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.ValidationMessageFor(model => model.Condicion_Tributaria, "", new { @class = "text-danger" });


#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
   __o = Html.LabelFor(model => model.Nombre, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.EditorFor(model => model.Nombre, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.ValidationMessageFor(model => model.Nombre, "", new { @class = "text-danger" });


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
   __o = Html.LabelFor(model => model.Apellido, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.EditorFor(model => model.Apellido, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.ValidationMessageFor(model => model.Apellido, "", new { @class = "text-danger" });


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
   __o = Html.LabelFor(model => model.Id_Domicilio, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.EditorFor(model => model.Id_Domicilio, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.ValidationMessageFor(model => model.Id_Domicilio, "", new { @class = "text-danger" });


#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
      
}

#line default
#line hidden
DefineSection("Scripts", () => {


#line 26 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


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

public class _Page_Views_Home_About_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Home_About_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
  
    ViewBag.Title = "About";


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
using (Html.BeginForm()) 
{
    

#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"                         
    
    

#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.tml"
   __o = Html.ValidationSummary(true, "", new { @class = "text-danger" });


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.   
       __o = Html.LabelFor(model => model.Telefono, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.EditorFor(model => model.Telefono, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.ValidationMessageFor(model => model.Telefono, "", new { @class = "text-danger" });


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.   
       __o = Html.LabelFor(model => model.Mail, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.EditorFor(model => model.Mail, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.ValidationMessageFor(model => model.Mail, "", new { @class = "text-danger" });


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.   
       __o = Html.LabelFor(model => model.Condicion_Tributaria, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.EditorFor(model => model.Condicion_Tributaria, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.ValidationMessageFor(model => model.Condicion_Tributaria, "", new { @class = "text-danger" });


#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.   
       __o = Html.LabelFor(model => model.Nombre, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.EditorFor(model => model.Nombre, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.ValidationMessageFor(model => model.Nombre, "", new { @class = "text-danger" });


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.   
       __o = Html.LabelFor(model => model.Apellido, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.EditorFor(model => model.Apellido, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.ValidationMessageFor(model => model.Apellido, "", new { @class = "text-danger" });


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.   
       __o = Html.LabelFor(model => model.Id_Domicilio, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.EditorFor(model => model.Id_Domicilio, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.                __o = Html.ValidationMessageFor(model => model.Id_Domicilio, "", new { @class = "text-danger" });


#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.               
}

#line default
#line hidden

#lDefineSection("Scripts", () => {


#line 26 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default
#line hidden
});


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

public class _Page_Views_Home_About_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Home_About_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
  
    ViewBag.Title = "About";


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
using (Html.BeginForm()) 
{
    

#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
                            
    
    

#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
   __o = Html.ValidationSummary(true, "", new { @class = "text-danger" });


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.LabelFor(model => model.Telefono, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.EditorFor(model => model.Telefono, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.ValidationMessageFor(model => model.Telefono, "", new { @class = "text-danger" });


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.LabelFor(model => model.Mail, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.EditorFor(model => model.Mail, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.ValidationMessageFor(model => model.Mail, "", new { @class = "text-danger" });


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.LabelFor(model => model.Condicion_Tributaria, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.EditorFor(model => model.Condicion_Tributaria, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.ValidationMessageFor(model => model.Condicion_Tributaria, "", new { @class = "text-danger" });


#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.LabelFor(model => model.Nombre, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.EditorFor(model => model.Nombre, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.ValidationMessageFor(model => model.Nombre, "", new { @class = "text-danger" });


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.LabelFor(model => model.Apellido, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.EditorFor(model => model.Apellido, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.ValidationMessageFor(model => model.Apellido, "", new { @class = "text-danger" });


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
       __o = Html.LabelFor(model => model.Id_Domicilio, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.EditorFor(model => model.Id_Domicilio, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
           __o = Html.ValidationMessageFor(model => model.Id_Domicilio, "", new { @class = "text-danger" });


#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
          
}

#line default
#line hidden

#line 26 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = Html.ActionLink("Back to List", "Index");


#line default
#line hidden
DefineSection("Scripts", () => {


#line 27 "C:\Users\user\AppData\Local\Temp\BE002E2A76BDDD952D93DF5C028FC4DB41B9\10\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\About.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default
#line hidden
});

}
}
}
