#pragma checksum "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b36936be5f2a1659b0ad9db09b29bbd5bfaded57"
// <auto-generated/>
#pragma warning disable 1591
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
            builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n<br>\r\n");
            builder.OpenComponent<BlazorComponents.Pages.Counter>(1);
            builder.AddAttribute(2, "Increment", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(
#line 7 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor"
                    10

#line default
#line hidden
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(3, "\r\n\r\n");
            builder.OpenComponent<Telerik.Blazor.Components.Button.TelerikButton>(4);
            builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 9 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor"
                          SayHelloHandler

#line default
#line hidden
            ));
            builder.AddAttribute(6, "Class", "RedText");
            builder.AddAttribute(7, "Primary", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 9 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor"
                                                                    true

#line default
#line hidden
            ));
            builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddContent(9, "Say Hello");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(10, "\r\n<br>\r\n");
            builder.OpenComponent<Telerik.Blazor.Components.Button.TelerikButton>(11);
            builder.AddAttribute(12, "Enabled", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 11 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor"
                        false

#line default
#line hidden
            ));
            builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddContent(14, "Disabled Button");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(15, "\r\n\r\nWelcome to your new app.\r\n<br>\r\n");
            builder.AddContent(16, 
#line 15 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor"
 helloMessage

#line default
#line hidden
            );
            builder.AddMarkupContent(17, "\r\n<br>\r\n");
            builder.OpenComponent<Telerik.Blazor.Components.Button.TelerikButton>(18);
            builder.AddAttribute(19, "SpriteClass", "k-icon netherlandsFlag");
            builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddContent(21, "Sprite");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(22, "\r\n");
            builder.OpenComponent<Telerik.Blazor.Components.Button.TelerikButton>(23);
            builder.AddAttribute(24, "Icon", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(
#line 18 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\Index.razor"
                      IconName.Filter

#line default
#line hidden
            ));
            builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddContent(26, "Icon");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(27, "\r\n");
            builder.OpenComponent<Telerik.Blazor.Components.Button.TelerikButton>(28);
            builder.AddAttribute(29, "ImageUrl", "https://demos.telerik.com/kendo-ui/content/shared/icons/sports/snowboarding.png");
            builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddContent(31, "Image URL");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(32, "\r\n\r\n");
            builder.AddMarkupContent(33, @"<style>
    /* the sprite for the first button is defined through a CSS rule matchin its Class */
    .netherlandsFlag {
        background-image: url(""https://demos.telerik.com/kendo-ui/content/shared/styles/flags.png"");
        background-position: 0 -64px;
    }
</style>

");
            builder.AddMarkupContent(34, "<style>\r\n    .RedText,\r\n    .RedText:hover {\r\n        color: red;\r\n    }\r\n</style>");
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
