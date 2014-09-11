﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static ProjectAriel.Controllers.AccountController Account = new ProjectAriel.Controllers.T4MVC_AccountController();
    public static ProjectAriel.Controllers.CardController Card = new ProjectAriel.Controllers.T4MVC_CardController();
    public static ProjectAriel.Controllers.ElmahController Elmah = new ProjectAriel.Controllers.T4MVC_ElmahController();
    public static ProjectAriel.Controllers.HomeController Home = new ProjectAriel.Controllers.T4MVC_HomeController();
    public static ProjectAriel.Controllers.ManageController Manage = new ProjectAriel.Controllers.T4MVC_ManageController();
    public static ProjectAriel.Controllers.PlayerController Player = new ProjectAriel.Controllers.T4MVC_PlayerController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string bootbox_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootbox.min.js") ? Url("bootbox.min.js") : Url("bootbox.js");
        public static readonly string bootbox_min_js = Url("bootbox.min.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
        public static readonly string modernizr_2_8_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.8.3.min.js") ? Url("modernizr-2.8.3.min.js") : Url("modernizr-2.8.3.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class PageSpecific {
            private const string URLPATH = "~/Scripts/PageSpecific";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string CardIndex_coffee = Url("CardIndex.coffee");
            public static readonly string CardIndex_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CardIndex.min.js") ? Url("CardIndex.min.js") : Url("CardIndex.js");
            public static readonly string CardIndex_js_map = Url("CardIndex.js.map");
            public static readonly string CardIndex_min_js = Url("CardIndex.min.js");
            public static readonly string CardIndex_min_js_map = Url("CardIndex.min.js.map");
            public static readonly string EditCard_coffee = Url("EditCard.coffee");
            public static readonly string EditCard_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/EditCard.min.js") ? Url("EditCard.min.js") : Url("EditCard.js");
            public static readonly string EditCard_js_map = Url("EditCard.js.map");
            public static readonly string EditCard_min_js = Url("EditCard.min.js");
            public static readonly string EditCard_min_js_map = Url("EditCard.min.js.map");
            public static readonly string Logout_coffee = Url("Logout.coffee");
            public static readonly string Logout_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Logout.min.js") ? Url("Logout.min.js") : Url("Logout.js");
            public static readonly string Logout_js_map = Url("Logout.js.map");
            public static readonly string Logout_min_js = Url("Logout.min.js");
            public static readonly string Logout_min_js_map = Url("Logout.min.js.map");
            public static readonly string PlayerIndex_coffee = Url("PlayerIndex.coffee");
            public static readonly string PlayerIndex_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/PlayerIndex.min.js") ? Url("PlayerIndex.min.js") : Url("PlayerIndex.js");
            public static readonly string PlayerIndex_js_map = Url("PlayerIndex.js.map");
            public static readonly string PlayerIndex_min_js = Url("PlayerIndex.min.js");
            public static readonly string PlayerIndex_min_js_map = Url("PlayerIndex.min.js.map");
        }
    
        public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
        public static readonly string respond_min_js = Url("respond.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-theme.min.css") ? Url("bootstrap-theme.min.css") : Url("bootstrap-theme.css");
             
        public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
        public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
             
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Images {
            private const string URLPATH = "~/Content/Images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string slabWide_jpg = Url("slabWide.jpg");
        }
    
        public static readonly string Responsive_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Responsive.min.css") ? Url("Responsive.min.css") : Url("Responsive.css");
             
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
             
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009


