#pragma checksum "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f90884c94dad69560d47c306c83fffa5f2b967a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SinglePost), @"mvc.1.0.view", @"/Views/Home/SinglePost.cshtml")]
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
#line 1 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\_ViewImports.cshtml"
using Coddit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\_ViewImports.cshtml"
using Coddit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f90884c94dad69560d47c306c83fffa5f2b967a", @"/Views/Home/SinglePost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"016796766b5c48084a03a8fb2e3b536bb38caa9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SinglePost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"headerDiv\">\r\n    <h1><a href=\"/posts/new\">make post</a></h1>\r\n    <h1>");
#nullable restore
#line 5 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
   Write(ViewBag.LoggedUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div>\r\n    <div class=\"postBox\">\r\n            <div class=\"postLikes\">\r\n                <span><a");
            BeginWriteAttribute("href", " href=\"", 237, "\"", 282, 3);
            WriteAttributeValue("", 244, "/posts/", 244, 7, true);
#nullable restore
#line 11 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
WriteAttributeValue("", 251, ViewBag.SinglePost.PostId, 251, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 277, "/like", 277, 5, true);
            EndWriteAttribute();
            WriteLiteral(">👍</a></span>\r\n                <span>");
#nullable restore
#line 12 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
                 Write(ViewBag.SinglePost.Likes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"postBoxInfo\">\r\n                <h3><a");
            BeginWriteAttribute("href", " href=\"", 442, "\"", 473, 1);
#nullable restore
#line 15 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
WriteAttributeValue("", 449, ViewBag.SinglePost.Link, 449, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
                                                  Write(ViewBag.SinglePost.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                <p>Posted by ");
#nullable restore
#line 16 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
                        Write(ViewBag.SinglePost.Creator.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>on ");
#nullable restore
#line 17 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
                 Write(ViewBag.SinglePost.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><a");
            BeginWriteAttribute("href", " href=\"", 660, "\"", 700, 2);
            WriteAttributeValue("", 667, "/posts/", 667, 7, true);
#nullable restore
#line 18 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
WriteAttributeValue("", 674, ViewBag.SinglePost.PostId, 674, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
                                                          Write(ViewBag.SinglePost.CommentsMade.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments</a> Topic: ");
#nullable restore
#line 18 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
                                                                                                                     Write(ViewBag.SinglePost.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f90884c94dad69560d47c306c83fffa5f2b967a8539", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9f90884c94dad69560d47c306c83fffa5f2b967a8805", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 23 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PostId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
                                         WriteLiteral(ViewBag.SinglePost.PostId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f90884c94dad69560d47c306c83fffa5f2b967a11231", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 24 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" class=\"btn btn-lg btn-primary\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 29 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
     foreach(Comment cmt in ViewBag.SinglePost.CommentsMade)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"commentBox\">\r\n            <b>");
#nullable restore
#line 32 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
          Write(cmt.Creator.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> says: \"");
#nullable restore
#line 32 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
                                           Write(cmt.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\Mutah\OneDrive\Desktop\Projects\C# Project\Coddit\Views\Home\SinglePost.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591