#pragma checksum "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\DrinkView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f7d72b7740298f293fc7b57e8fe674c928f7785"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using BlazorWasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using BlazorWasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\DrinkView.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DrinkView")]
    public partial class DrinkView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "marginclass");
            __builder.AddAttribute(2, "b-na9dfjliwd");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddAttribute(5, "b-na9dfjliwd");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddAttribute(8, "b-na9dfjliwd");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-12 drinkview");
            __builder.AddAttribute(11, "b-na9dfjliwd");
            __builder.AddContent(12, 
#nullable restore
#line 18 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\DrinkView.razor"
             drink.strDrink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-12 alcoview");
            __builder.AddAttribute(16, "b-na9dfjliwd");
            __builder.AddContent(17, 
#nullable restore
#line 21 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\DrinkView.razor"
             drink.strAlcoholic

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "DrInstructions");
            __builder.AddAttribute(21, "b-na9dfjliwd");
            __builder.AddContent(22, 
#nullable restore
#line 25 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\DrinkView.razor"
             drink.strInstructions

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\DrinkView.razor"
       

    [Parameter]
    public Models.Drinks drink { get; set; }

    //public int fontSize-strDrink;

    //public int fontSize-strAlcoholic;

    //protected override void OnInitialized()
    //{

    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoggerFactory LoggerFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
