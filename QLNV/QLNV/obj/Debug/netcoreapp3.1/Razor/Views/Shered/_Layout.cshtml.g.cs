#pragma checksum "C:\Users\Phong\Desktop\20t4\QLNV\QLNV\Views\Shered\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61dfbb41a106205a0889b1bbb091d335b0ecd469"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shered__Layout), @"mvc.1.0.view", @"/Views/Shered/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61dfbb41a106205a0889b1bbb091d335b0ecd469", @"/Views/Shered/_Layout.cshtml")]
    public class Views_Shered__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61dfbb41a106205a0889b1bbb091d335b0ecd4692709", async() => {
                WriteLiteral(@"
    <title></title>
    <style>
        * {
            margin: 0;
            padding: 0px;
            font-family: ""Helvetica"";
        }

        body {
            margin: 0 20px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        th, td {
            padding: 8px;
            border: 1px solid #dee2e6;
        }

        tr:first-child {
            background: #212529;
            color: white;
        }

        th {
            height: 40px;
            text-align: left;
        }

        a {
            text-decoration: none;
            color: #000;
        }

        .header {
            display: flex;
            justify-content: space-between;
        }

        .search {
        }

            .search input {
            }

            .search a {
            }

        .header {
            margin-top: 10px;
            display: flex;
            h");
                WriteLiteral(@"eight: 38px;
            align-items: center;
        }

        .search_header {
            display: flex;
        }

            .search_header .btn_search {
                background-color: #4e92df;
                border: none;
                color: white;
                text-align: center;
                text-decoration: none;
                font-size: 16px;
                margin: 4px 2px;
                cursor: pointer;
                height: 100%;
                margin: 0;
                padding: 10px 20px;
            }

            .search_header input:first-child {
                width: 200px;
                margin-right: 10px;
                outline: none;
                padding-left: 10px;
                border: 1px solid #4e92df;
            }

        .link_btn {
            background-color: #4e92df;
            font-size: 16px;
            color: white;
            padding: 10px 20px;
            border-radius: 2px;
        }

        .btn_");
                WriteLiteral(@"search:hover {
            background: #2e7dd6;
            transition: 0,4s;
        }

        .link_btn:hover {
            background: #2e7dd6;
            transition: 0,4s;
        }

        .dowload {
        }

        .view:hover {
            color: #2e7dd6;
        }

        body {
            display: flex;
            margin: 0px;
            padding: 0px;
        }

        .menu {
            width: 200px;
            background: #283237;
            position: fixed;
            height: 100%;
            box-shadow: 5px 0 5px -2px #888;
        }

            .menu ul {
                margin: 50px 0px 0px 50px;
                margin:auto;
            }

                .menu ul li {
                    list-style: none;
                    margin: 20px;
                }

                    .menu ul li a {
                        text-decoration: none;
                        color: #8a9199;
                        font-size: 20px;
              ");
                WriteLiteral(@"      }

                        .menu ul li a:hover {
                            cursor: pointer;
                            color: #e8f0f9;
                        }

        .content {
            margin-left: 220px;
            
            width:87%;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61dfbb41a106205a0889b1bbb091d335b0ecd4697148", async() => {
                WriteLiteral(@"
        <div class=""menu"">
            <ul>
                <li><a href=""/Home"">Home</a></li>
                <li><a href=""/Duyet"">Duyệt CV</a></li>
                <li><a href=""/Duyet/DaduyetCV"">Gửi Mail</a></li>
                <li><a href=""/LienHe"">Đặt Lịch</a></li>
                <li><a href=""/Calenda"">Calendar</a></li>
            </ul>
        </div>
        <div class=""content"">
            ");
#nullable restore
#line 172 "C:\Users\Phong\Desktop\20t4\QLNV\QLNV\Views\Shered\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591