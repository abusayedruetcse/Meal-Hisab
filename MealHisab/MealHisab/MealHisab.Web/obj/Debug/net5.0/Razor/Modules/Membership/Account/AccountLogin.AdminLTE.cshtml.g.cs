#pragma checksum "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90387165854629f47f8c784388c9fda06ff13258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_AccountLogin_AdminLTE), @"mvc.1.0.view", @"/Modules/Membership/Account/AccountLogin.AdminLTE.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using MealHisab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90387165854629f47f8c784388c9fda06ff13258", @"/Modules/Membership/Account/AccountLogin.AdminLTE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8602ea686e52cb9df8888bbf826dc27189c74926", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_AccountLogin_AdminLTE : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/iCheck/square/blue.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.icheck.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.Login.FormTitle.ToString(Localizer);
    ViewData["PageId"] = "Login";
    ViewData["BodyClass"] = "login-page";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90387165854629f47f8c784388c9fda06ff132585521", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90387165854629f47f8c784388c9fda06ff132586699", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<script id=""Template_Membership_LoginPanel"" type=""text/template"">
    <div class=""s-Form"">
        <form id=""~_Form"" action="""">            
            <div id=""~_PropertyGrid""></div>
            <div class=""row"">
                <div class=""col-xs-7"">
                    <div class=""checkbox icheck"">
                        <label>
                            <input type=""checkbox""> ");
#nullable restore
#line 24 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                               Write(Texts.Forms.Membership.Login.RememberMe.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-xs-5\">\r\n                    <button id=\"~_LoginButton\" type=\"submit\" class=\"btn btn-primary btn-block btn-flat\">");
#nullable restore
#line 29 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                                                                                   Write(Texts.Forms.Membership.Login.SignInButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</script>\r\n\r\n");
#nullable restore
#line 36 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
 if (DataMigrations.SkippedMigrations)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""alert alert-error alert-dismissible"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
    <h4><i class=""icon fa fa-warning""></i> Warning!</h4>
    MealHisab skipped running migrations to avoid modifying an arbitrary database.
    If you'd like to run migrations on this database, remove the safety check 
    in SiteInitialization.RunMigrations method.
</div>
");
#nullable restore
#line 45 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 47 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
 if (ViewData["Activated"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-info alert-dismissible\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n    <h4><i class=\"icon fa fa-info\"></i>");
#nullable restore
#line 51 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                  Write(Localizer.Get("Dialogs.InformationTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    ");
#nullable restore
#line 52 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
Write(Texts.Forms.Membership.SignUp.ActivationCompleteMessage.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 54 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"login-box\">\r\n    <div class=\"login-logo\">\r\n        ");
#nullable restore
#line 58 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
   Write(Texts.Navigation.SiteTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"login-box-body\">\r\n        <p class=\"login-box-msg\">");
#nullable restore
#line 61 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                            Write(Texts.Forms.Membership.Login.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div id=\"LoginPanel\">\r\n        </div>\r\n        <div class=\"social-auth-links text-center\">\r\n            <p>- ");
#nullable restore
#line 65 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
            Write(Texts.Forms.Membership.Login.OR.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -</p>\r\n            <a href=\"#\" class=\"btn btn-block btn-social btn-facebook btn-flat\">\r\n                <i class=\"fa fa-facebook\"></i> ");
#nullable restore
#line 67 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                          Write(Texts.Forms.Membership.Login.FacebookButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n            <a href=\"#\" class=\"btn btn-block btn-social btn-google btn-flat\">\r\n                <i class=\"fa fa-google-plus\"></i> ");
#nullable restore
#line 70 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                             Write(Texts.Forms.Membership.Login.GoogleButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3035, "\"", 3082, 1);
#nullable restore
#line 73 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
WriteAttributeValue("", 3042, Url.Content("~/Account/ForgotPassword"), 3042, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                                      Write(Texts.Forms.Membership.Login.ForgotPassword.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3168, "\"", 3207, 1);
#nullable restore
#line 74 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
WriteAttributeValue("", 3175, Url.Content("~/Account/SignUp"), 3175, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\">");
#nullable restore
#line 74 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                                                  Write(Texts.Forms.Membership.Login.SignUpButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
    </div>
</div>

<script type=""text/javascript"">
jQuery(function() {
    new MealHisab.Membership.LoginPanel($('#LoginPanel')).init();
    $('.field.Username,.field.Password').addClass(""has-icon"");
    $('.field.Username input').after(""<span class='glyphicon glyphicon-user form-control-feedback'></span>"");
    $('.field.Password input').after(""<span class='glyphicon glyphicon-lock form-control-feedback'></span>"");
    $('input').iCheck({
        checkboxClass: 'icheckbox_square-blue',
        radioClass: 'iradio_square-blue',
        increaseArea: '20%'
    });
");
#nullable restore
#line 89 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
 if (ViewData["Activated"] != null)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    $(function() { \r\n        $(\'#MealHisab_Membership_LoginPanel0_Username\').val(");
#nullable restore
#line 93 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
                                                       Write(Html.Raw(Serenity.JSON.Stringify(ViewData["Activated"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n        $(\'#MealHisab_Membership_LoginPanel0_Password\').focus();\r\n    });\r\n    ");
#nullable restore
#line 96 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\AccountLogin.AdminLTE.cshtml"
           
}

#line default
#line hidden
#nullable disable
            WriteLiteral("});\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MealHisab.IDataMigrations DataMigrations { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
