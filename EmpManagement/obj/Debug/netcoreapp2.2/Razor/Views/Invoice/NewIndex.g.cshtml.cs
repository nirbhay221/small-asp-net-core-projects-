#pragma checksum "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Invoice\NewIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2a67824bccadb70b507abc285d95825449482b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_NewIndex), @"mvc.1.0.view", @"/Views/Invoice/NewIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/NewIndex.cshtml", typeof(AspNetCore.Views_Invoice_NewIndex))]
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
#line 1 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using EmpManagement.Models;

#line default
#line hidden
#line 2 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using EmpManagement.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a2a67824bccadb70b507abc285d95825449482b", @"/Views/Invoice/NewIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d6ec5c308294d61a3bbb40d8c9044fb01a3987", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_NewIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3778, true);
            WriteLiteral(@"<ul class=""timeline"">
    <li class=""year first"">2013</li>
    <li class=""event"">Something amazing happened today, but it's a secret</li>
    <li class=""event"" href=""#"">Timeline.css is <b>dynamic</b>, <b>responsive</b> and optimized to <b>demonstrate events</b> in your life in a <b>simple and clear</b> way</li>
    <li class=""year"">2012</li>
    <li class=""event"">A whole new event in a whole new year!</li>
</ul>

<script>https://cdnjs.cloudflare.com/ajax/libs/dragula/3.7.2/dragula.min.js</script>

<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<style>
    .timeline {
        margin: 0 auto;
        max-width: 700px;
        overflow: hidden;
        height: auto;
        position: relative;
        padding: 0;
        list-style-type: none;
        background: url(""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAACCAYAAACZgbYnAAAAEElEQVQIW2NMTE");
            WriteLiteral(@"z8z8gABAAPKwIlXWq1kgAAAABJRU5ErkJggg=="");
        background-repeat: repeat-y;
        background-position: 50% 0;
    }

        .timeline *, .timeline *:after, .timeline *:before {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box
        }

        .timeline .year {
            background: #505050;
            font-size: 3em;
            max-width: 4em;
            clear: both;
            margin: 1em auto;
            color: #fff;
            border-radius: 30%/100%;
            text-align: center;
            margin-top: 50px;
        }

            .timeline .year:first-of-type {
                margin-top: 0 !important
            }

            .timeline .year + .event {
                margin-top: -1.5em
            }

        .timeline .event {
            position: relative;
            text-align: center;
            float: right;
            clear: right;
            width: 45%;
            ");
            WriteLiteral(@"margin: 10px 2.5%;
            border-radius: 5px;
            list-style-type: none;
            display: block;
            padding: .4em;
            background: #fff;
            z-index: 15;
            color: #4d4d4d;
            border: 1px solid #a8a8a8;
            text-decoration: none;
            -webkit-transition: background .15s linear;
            -moz-transition: background .15s linear;
            -ms-transition: background .15s linear;
            -o-transition: background .15s linear;
            transition: background .15s linear;
        }

            .timeline .event img {
                max-height: 7em;
                max-width: 100%
            }

            .timeline .event.featured {
                width: 95% !important;
            }

                .timeline .event.featured:after, .timeline .event.featured:before {
                    display: none
                }

            .timeline .event.offset-first {
                margin-top: -1.5em");
            WriteLiteral(@"
            }

            .timeline .event img {
                margin-top: 10px;
                max-width: 100%
            }

            .timeline .event:hover {
                background: #f6f6f6;
            }

                .timeline .event:hover:after {
                    background: #505050
                }

            .timeline .event:nth-of-type(2n) {
                float: left;
                clear: left;
            }

                .timeline .event:nth-of-type(2n):after {
                    right: -5%;
                    left: auto
                }

        .timeline time {
            display: block;
            font-weight: bold
</style>");
            EndContext();
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
