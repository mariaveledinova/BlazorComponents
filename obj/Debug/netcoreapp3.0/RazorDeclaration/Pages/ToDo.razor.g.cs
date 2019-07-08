#pragma checksum "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e7d1f24de2c1f790b49b2758d71392aeef81f01"
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
#line 2 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\ToDo.razor"
using BlazorComponents.Data;

#line default
#line hidden
#line 3 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\ToDo.razor"
using Telerik.Blazor.Components.Calendar;

#line default
#line hidden
#line 4 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\ToDo.razor"
using Telerik.Blazor;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 30 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\ToDo.razor"
       

private IList<ToDoItem> todos = new List<ToDoItem>();
private string newTodo;
private bool isDone;
private DateTime newDate = DateTime.Now;

private DateTime min = new DateTime(2019, 1, 1);
private DateTime max = new DateTime(2039, 1, 1);
private DateTime selectedDate { get; set; } = DateTime.Now;

private void AddToDo()
{
    if (!string.IsNullOrWhiteSpace(newTodo))
    {
        todos.Add(new ToDoItem { Title = newTodo, IsDone = isDone,  ToDoDate = selectedDate});
        newTodo = string.Empty;

    }
}

private void MyValueChangeHandler(DateTime newValue)
{
    selectedDate = newValue;
    StateHasChanged();
}


#line default
#line hidden
    }
}
#pragma warning restore 1591