#pragma checksum "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Shared\Dialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d872a4f260b754e43b7f2b7820f2e569f58bc6d8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorComponents.Shared
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
    public class Dialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h3>Dialog</h3>\r\n");
            builder.OpenElement(1, "div");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenElement(3, "h1");
            builder.AddContent(4, 
#line 3 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Shared\Dialog.razor"
         Title

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(5, "\r\n    ");
            builder.OpenElement(6, "button");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 4 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Shared\Dialog.razor"
                       OnYes

#line default
#line hidden
            ));
            builder.AddContent(8, "Yes!");
            builder.CloseElement();
            builder.AddMarkupContent(9, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 7 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Shared\Dialog.razor"
       
[Parameter] private string Title { get; set; }
[Parameter] RenderFragment ChildContent { get; set; }

    private void OnYes()
    {
        Console.WriteLine("Write to the console in C#! 'Yes' button was selected.");
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591