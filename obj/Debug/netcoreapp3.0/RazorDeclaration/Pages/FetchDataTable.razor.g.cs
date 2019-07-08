#pragma checksum "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\FetchDataTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19c1855666b578402ba8ecc1f6e7329980d97fcd"
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
#line 2 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\FetchDataTable.razor"
using BlazorComponents.Data;

#line default
#line hidden
#line 3 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\FetchDataTable.razor"
using BlazorComponents.Data.DBData;

#line default
#line hidden
#line 4 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\FetchDataTable.razor"
using Telerik.Blazor.Components.Grid;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdatatable")]
    public class FetchDataTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 91 "C:\Users\veledino\source\repos\BlazorComponents\BlazorComponents\Pages\FetchDataTable.razor"
      

    List<WeatherForecast> forecasts;
    WeatherForecast objWeatherForecast = new WeatherForecast();


    protected override async Task OnInitAsync()
    {
        forecasts = await ForecastService.GetForecastAsync();
    }

    void EditForecast(WeatherForecast weatherForecast)
    {
        // Set the selected forecast as the current forecast
        objWeatherForecast = weatherForecast;
        // Open the Popup
        ShowPopup = true;
    }

    bool ShowPopup = false;

    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }

    void AddNewForecast()
    {
        // Make new forecast
        objWeatherForecast = new WeatherForecast();
        // Set Id to 0 so we know it is a new record
        objWeatherForecast.Id = 0;
        // Open the Popup
        ShowPopup = true;
    }

    async Task SaveForecast()
    {
        // Close the Popup
        ShowPopup = false;
        // A new forecast will have the Id set to 0
        if (objWeatherForecast.Id == 0)
        {
            // Create new forecast
            WeatherForecast objNewWeatherForecast = new WeatherForecast();

            objNewWeatherForecast.Date = System.DateTime.Now;
            objNewWeatherForecast.Summary = objWeatherForecast.Summary;
            objNewWeatherForecast.TemperatureC =
            Convert.ToInt32(objWeatherForecast.TemperatureC);
            objNewWeatherForecast.TemperatureF =
            Convert.ToInt32(objWeatherForecast.TemperatureF);
            // Save the result
            var result = ForecastService.CreateForecastAsync(objNewWeatherForecast);
        }
    else
    {
        // This is an update
        var result = ForecastService.UpdateForecastAsync(objWeatherForecast);
    }
        // Get the forecasts for the current user
        forecasts = await ForecastService.GetForecastAsync();
    }
 

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
