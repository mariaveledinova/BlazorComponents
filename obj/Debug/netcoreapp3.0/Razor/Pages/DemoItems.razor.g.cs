#pragma checksum "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aa095129bd53930973fd95421aef9ef24ab486d"
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
#line 2 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor"
using BlazorComponents.Data;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/demoitems")]
    public class DemoItems : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h3>Demo Items</h3>\r\n\r\n");
            builder.OpenElement(1, "ul");
            builder.AddMarkupContent(2, "\r\n");
#line 6 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor"
     foreach (var item in demoItemsList)
    {

#line default
#line hidden
            builder.AddContent(3, "        ");
            builder.OpenElement(4, "li");
            builder.AddMarkupContent(5, "\r\n            ");
            builder.OpenElement(6, "input");
            builder.AddAttribute(7, "placeholder", "Add your demo item here");
            builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(
#line 9 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor"
                                                                 itemName

#line default
#line hidden
            ));
            builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => itemName = __value, itemName));
            builder.CloseElement();
            builder.AddMarkupContent(10, "\r\n            ");
            builder.OpenElement(11, "input");
            builder.AddAttribute(12, "type", "text");
            builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(
#line 10 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor"
                                       itemCount

#line default
#line hidden
            ));
            builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => itemCount = __value, itemCount));
            builder.CloseElement();
            builder.AddMarkupContent(15, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(16, "\r\n");
#line 12 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor"
    }

#line default
#line hidden
            builder.CloseElement();
            builder.AddMarkupContent(17, "\r\n\r\n    ");
            builder.OpenElement(18, "input");
            builder.AddAttribute(19, "placeholder", "Something todo");
            builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(
#line 15 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor"
                                                itemName

#line default
#line hidden
            ));
            builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => itemName = __value, itemName));
            builder.CloseElement();
            builder.AddMarkupContent(22, "\r\n    ");
            builder.OpenElement(23, "input");
            builder.AddAttribute(24, "type", "text");
            builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(
#line 16 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor"
                               itemCount

#line default
#line hidden
            ));
            builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => itemCount = __value, itemCount));
            builder.CloseElement();
            builder.AddMarkupContent(27, "\r\n\r\n    ");
            builder.OpenElement(28, "button");
            builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 18 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor"
                       AddToItem

#line default
#line hidden
            ));
            builder.AddContent(30, "Add Demo Items");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 20 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\DemoItems.razor"
           

        private IList<DemoItem> demoItemsList = new List<DemoItem>();
        private string itemName;
        private int itemCount;

        private void AddToItem()
        {
            if (!string.IsNullOrWhiteSpace(itemName))
            {
                demoItemsList.Add(new DemoItem { DemoItemName = itemName, DemoItemCount = itemCount });
            }
        }

    

#line default
#line hidden
    }
}
#pragma warning restore 1591
