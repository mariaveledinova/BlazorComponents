#pragma checksum "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b36936be5f2a1659b0ad9db09b29bbd5bfaded57"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorComponents.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\_Imports.razor"
using BlazorComponents;

#line default
#line hidden
#line 7 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\_Imports.razor"
using BlazorComponents.Shared;

#line default
#line hidden
#line 2 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor"
using Telerik.Blazor;

#line default
#line hidden
#line 3 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor"
using Telerik.Blazor.Components.Button;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 39 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor"
      

    MarkupString helloMessage;

    private void SayHelloHandler()
    {
        string msg = string.Format("Hello from <strong>Telerik Blazor</strong> at {0}.<br /> Now you can use C# to write front-end!", DateTime.Now);
        helloMessage = new MarkupString(msg);

    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
