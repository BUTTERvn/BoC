﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace mytest
{
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
    using DotNetOpenAuth.Mvc;
    
    public class LogOn_cshtml : System.Web.Mvc.WebViewPage<BoC.Security.Mvc.ViewModels.LogOnModel>
    {
#line hidden

        protected System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        public override void Execute()
        {

WriteLiteral("\r\n");



  
    View.Title = "Log On";



DefineSection("head", () => {

WriteLiteral("\r\n    <link type=\"text/css\" rel=\"Stylesheet\" href=\"");


                                            Write(Html.GetResourceUrl(typeof(DotNetOpenAuth.OpenId.RelyingParty.OpenIdSelector), "DotNetOpenAuth.OpenId.RelyingParty.OpenIdSelector.css"));

WriteLiteral("\" />\r\n    <link type=\"text/css\" rel=\"Stylesheet\" href=\"");


                                            Write(Html.GetResourceUrl(typeof(DotNetOpenAuth.OpenId.RelyingParty.OpenIdSelector), "DotNetOpenAuth.OpenId.RelyingParty.OpenIdAjaxTextBox.css"));

WriteLiteral("\" />\r\n    ");


Write(MvcHtmlString.Create(Html.OpenIdSelectorStyles()));

WriteLiteral("\r\n");


});

WriteLiteral("\r\n\r\n");


Write(Html.ValidationSummary(true, "Login was unsuccessful. Please correct the errors and try again."));

WriteLiteral("\r\n");


Write(Html.ValidationMessage("_FORM"));

WriteLiteral("\r\n");


Write(Html.Partial("_LogonOpenId"));

WriteLiteral("\r\n");


Write(Html.Partial("_LogonNative"));

WriteLiteral("\r\n");


        }
    }
}

