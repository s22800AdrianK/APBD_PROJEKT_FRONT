#pragma checksum "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5c32a71c3506aa2f25ce0231e0d7ecc9fd2f5cf"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjektFront.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using ProjektFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using ProjektFront.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using ProjektFront.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using ProjektFront.Models.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using ProjektFront.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using ProjektFront.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\adria\APBD\ProjektFront\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stock/{ticker}")]
    public partial class Company : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
 if (DataSource == null || CompanyDetailed == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div>Loading...</div>");
#nullable restore
#line 12 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
}
else
{ 

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Layouts.SfDashboardLayout>(1);
            __builder.AddAttribute(2, "Columns", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "AllowResizing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "MediaQuery", "height:auto");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Layouts.DashboardLayoutPanels>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Layouts.DashboardLayoutPanel>(8);
                    __builder3.AddAttribute(9, "Column", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                          0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Row", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                  0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "SizeX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                            3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "<div>Logo</div>");
                    }
                    ));
                    __builder3.AddAttribute(14, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(15, "img");
                        __builder4.AddAttribute(16, "src", (
#nullable restore
#line 20 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                CompanyDetailed.branding.logo_url

#line default
#line hidden
#nullable disable
                        ) + "?apiKey=1p7pfT07fHfgmupzsl4vHGteG2tEZMh7");
                        __builder4.AddAttribute(17, "alt", (
#nullable restore
#line 20 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                                                                                   CompanyDetailed.name

#line default
#line hidden
#nullable disable
                        ) + " Logo");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Layouts.DashboardLayoutPanel>(19);
                    __builder3.AddAttribute(20, "Column", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                          1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Row", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                  0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "SizeX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                            3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(24, "<div>More Info</div>");
                    }
                    ));
                    __builder3.AddAttribute(25, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(26, "div");
                        __builder4.OpenElement(27, "button");
                        __builder4.AddAttribute(28, "type", "button");
                        __builder4.AddAttribute(29, "class", "btn btn-warning");
                        __builder4.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                                                  () => AddToWatchList()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(31, "Add to WatchList");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(32, "\r\n                        ");
                        __builder4.OpenElement(33, "table");
                        __builder4.AddAttribute(34, "class", "table table-striped");
                        __builder4.AddMarkupContent(35, @"<thead><tr><th scope=""col"">Ticker</th>
                                    <th scope=""col"">Name</th>
                                    <th scope=""col"">Locale</th>
                                    <th scope=""col"">Description</th></tr></thead>
                            ");
                        __builder4.OpenElement(36, "tbody");
                        __builder4.OpenElement(37, "tr");
                        __builder4.OpenElement(38, "td");
                        __builder4.AddContent(39, 
#nullable restore
#line 39 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                         CompanyDetailed.ticker

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(40, "\r\n                                    ");
                        __builder4.OpenElement(41, "td");
                        __builder4.AddContent(42, 
#nullable restore
#line 40 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                         CompanyDetailed.name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(43, "\r\n                                    ");
                        __builder4.OpenElement(44, "td");
                        __builder4.AddContent(45, 
#nullable restore
#line 41 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                         CompanyDetailed.locale

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(46, "\r\n                                    ");
                        __builder4.OpenElement(47, "td");
                        __builder4.AddContent(48, 
#nullable restore
#line 42 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                         CompanyDetailed.description

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Layouts.DashboardLayoutPanel>(50);
                    __builder3.AddAttribute(51, "Column", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                          2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Row", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                  2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "SizeX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                            3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "SizeY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                                      2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(56, "Chart");
                    }
                    ));
                    __builder3.AddAttribute(57, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(58, "button");
                        __builder4.AddAttribute(59, "type", "button");
                        __builder4.AddAttribute(60, "class", "btn btn-primary");
                        __builder4.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                                              () => GetToTodayData()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(62, "Current day");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(63, "\r\n                    ");
                        __builder4.OpenElement(64, "button");
                        __builder4.AddAttribute(65, "type", "button");
                        __builder4.AddAttribute(66, "class", "btn btn-primary");
                        __builder4.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                                              () => GetWeekData()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(68, "Last week");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(69, "\r\n                    ");
                        __builder4.OpenElement(70, "button");
                        __builder4.AddAttribute(71, "type", "button");
                        __builder4.AddAttribute(72, "class", "btn btn-primary");
                        __builder4.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                                              () => GetThreeMonthsData()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(74, "Last 3 months");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(75, "\r\n                    ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.SfChart>(76);
                        __builder4.AddAttribute(77, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                  ticker

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryXAxis>(79);
                            __builder5.AddAttribute(80, "ValueType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ValueType>(
#nullable restore
#line 56 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                      Syncfusion.Blazor.Charts.ValueType.Category

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(81, "\r\n                        ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.ChartTooltipSettings>(82);
                            __builder5.AddAttribute(83, "Enable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                      true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(84, "\r\n                        ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.ChartSeriesCollection>(85);
                            __builder5.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(87);
                                __builder6.AddAttribute(88, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 59 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                      DataSource

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(89, "High", "High");
                                __builder6.AddAttribute(90, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 59 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                                                     5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(91, "BearFillColor", "darkred");
                                __builder6.AddAttribute(92, "XName", "Date");
                                __builder6.AddAttribute(93, "Volume", "Volume");
                                __builder6.AddAttribute(94, "BullFillColor", "darkgreen");
                                __builder6.AddAttribute(95, "Low", "Low");
                                __builder6.AddAttribute(96, "Open", "Open");
                                __builder6.AddAttribute(97, "Close", "Close");
                                __builder6.AddAttribute(98, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 59 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                                                                                                                                                                                                 ChartSeriesType.HiloOpenClose

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.AddComponentReferenceCapture(99, (__value) => {
#nullable restore
#line 55 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
                                   Chart = (Syncfusion.Blazor.Charts.SfChart)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 67 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(100, @"<style>
    img {
        width: 100px;
        aspect-ratio: 1/1;
    }

    .e-panel-header {
        background-color: rgba(0, 0, 0, .1);
        text-align: center;
    }

    .e-panel-content {
        text-align: center;
        margin-top: 10px;
        height: auto;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\adria\APBD\ProjektFront\Pages\Company.razor"
      
    [Parameter]
    public string ticker { get; set; }
    public CompanyDetailed CompanyDetailed { get; set; }
    public List<ChartData> DataSource { get; set; }
    public SfChart Chart;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            CompanyDetailed = await StockService.GetCompany(ticker);
            DataSource = StockService.ToChartData(await StockService.GetOHLC(ticker, DateTime.Now.AddMonths(-3), DateTime.Now, "day"));
            await CheckIfEmpty();
            Console.WriteLine(DataSource);
        }
        catch (Exception e)
        {
            await JsRuntime.InvokeVoidAsync("alert", e.Message);
            NavigationManager.NavigateTo("search");
        }
    }
    private async Task GetToTodayData()
    {
        DataSource = StockService.ToChartData(await StockService.GetOHLC(ticker, DateTime.Now.AddDays(-1), DateTime.Now, "hour"));
        await CheckIfEmpty();
        await Chart.RefreshAsync();
    }

    private async Task GetThreeMonthsData()
    {
        DataSource = StockService.ToChartData(await StockService.GetOHLC(ticker, DateTime.Now.AddMonths(-3), DateTime.Now, "day"));
        await CheckIfEmpty();
        await Chart.RefreshAsync();
    }

    private async Task GetWeekData()
    {
        DataSource = StockService.ToChartData(await StockService.GetOHLC(ticker, DateTime.Now.AddDays(-7), DateTime.Now, "day"));
        await CheckIfEmpty();
        await Chart.RefreshAsync();
    }

    private async Task CheckIfEmpty()
    {
        if (DataSource.Count() == 0) await JsRuntime.InvokeVoidAsync("alert", "Try diffrent date no data to schow");
    }

    private async Task AddToWatchList()
    {
        await StockService.AddToWatchlist(AccountService.User.id,ticker);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStockService StockService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
