#pragma checksum "D:\Development\C#\MagentaGithub\MagentaSportwear\Views\AdminPanel\Articulos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "259f24dfa0bccaa481bb862ef5721aeb6143e47c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Articulos), @"mvc.1.0.view", @"/Views/AdminPanel/Articulos.cshtml")]
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
#line 1 "D:\Development\C#\MagentaGithub\MagentaSportwear\Views\_ViewImports.cshtml"
using MagentaSportwear;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\C#\MagentaGithub\MagentaSportwear\Views\_ViewImports.cshtml"
using MagentaSportwear.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259f24dfa0bccaa481bb862ef5721aeb6143e47c", @"/Views/AdminPanel/Articulos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f25fbdd4550a61b7edbbba3e9deb6c576aa763", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminPanel_Articulos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Development\C#\MagentaGithub\MagentaSportwear\Views\AdminPanel\Articulos.cshtml"
  
    Layout = "/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .btn {
        background-color: #667eea;
        color: white;
        margin-right: .5rem;
    }

    .btn:hover {
        color: white;
        background-color: #764ba2;
    }
</style>

<!-- Modal Agregar Articulo -->
<div class=""modal fade"" id=""AddArticle"" data-bs-backdrop=""static"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Agregar Articulo</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <p>Modal body text goes here.</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
      ");
            WriteLiteral(@"      </div>
        </div>
    </div>
</div>

<!-- Modal Agregar Categoria -->
<div class=""modal fade"" id=""AddCategory"" data-bs-backdrop=""static"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Agregar Categoria</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <p>Modal body text goes here.</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>

<hr style=""margin: 2%; color: #F7F7F7;"" />

<h3> Articulos </h3>

<hr style=""margin: 1%; color: #F7F7F7;"" ");
            WriteLiteral(@"/>

<button type=""button""data-bs-toggle=""modal"" data-bs-target=""#AddArticle"" class=""btn""> <svg xmlns=""http://www.w3.org/2000/svg"" x=""0px"" y=""0px"" width=""18"" height=""18"" viewBox=""0 0 172 172"" style="" fill:#000000;""><g fill=""none"" fill-rule=""nonzero"" stroke=""none"" stroke-width=""1"" stroke-linecap=""butt"" stroke-linejoin=""miter"" stroke-miterlimit=""10""");
            BeginWriteAttribute("stroke-dasharray", " stroke-dasharray=\"", 2456, "\"", 2475, 0);
            EndWriteAttribute();
            WriteLiteral(@" stroke-dashoffset=""0"" font-family=""none"" font-weight=""none"" font-size=""none"" text-anchor=""none"" style=""mix-blend-mode: normal""><path d=""M0,172v-172h172v172z"" fill=""none""></path><g fill=""#ffffff""><path d=""M80.625,10.75c-38.50683,0 -69.875,31.36817 -69.875,69.875c0,38.50683 31.36817,69.875 69.875,69.875c38.50683,0 69.875,-31.36817 69.875,-69.875c0,-38.50683 -31.36817,-69.875 -69.875,-69.875zM80.625,21.5c32.71192,0 59.125,26.41308 59.125,59.125c0,32.71192 -26.41308,59.125 -59.125,59.125c-32.71192,0 -59.125,-26.41308 -59.125,-59.125c0,-32.71192 26.41308,-59.125 59.125,-59.125zM75.25,53.75v21.5h-21.5v10.75h21.5v21.5h10.75v-21.5h21.5v-10.75h-21.5v-21.5z""></path></g></g></svg> Articulo </button>
<button type=""button""data-bs-toggle=""modal"" data-bs-target=""#AddCategory"" class=""btn""> <svg xmlns=""http://www.w3.org/2000/svg"" x=""0px"" y=""0px"" width=""18"" height=""18"" viewBox=""0 0 172 172"" style="" fill:#000000;""><g fill=""none"" fill-rule=""nonzero"" stroke=""none"" stroke-width=""1"" stroke-linecap=""butt"" stroke-linejoin=""miter"" s");
            WriteLiteral("troke-miterlimit=\"10\"");
            BeginWriteAttribute("stroke-dasharray", " stroke-dasharray=\"", 3521, "\"", 3540, 0);
            EndWriteAttribute();
            WriteLiteral(@" stroke-dashoffset=""0"" font-family=""none"" font-weight=""none"" font-size=""none"" text-anchor=""none"" style=""mix-blend-mode: normal""><path d=""M0,172v-172h172v172z"" fill=""none""></path><g fill=""#ffffff""><path d=""M80.625,10.75c-38.50683,0 -69.875,31.36817 -69.875,69.875c0,38.50683 31.36817,69.875 69.875,69.875c38.50683,0 69.875,-31.36817 69.875,-69.875c0,-38.50683 -31.36817,-69.875 -69.875,-69.875zM80.625,21.5c32.71192,0 59.125,26.41308 59.125,59.125c0,32.71192 -26.41308,59.125 -59.125,59.125c-32.71192,0 -59.125,-26.41308 -59.125,-59.125c0,-32.71192 26.41308,-59.125 59.125,-59.125zM75.25,53.75v21.5h-21.5v10.75h21.5v21.5h10.75v-21.5h21.5v-10.75h-21.5v-21.5z""></path></g></g></svg> Categoria </button>");
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
