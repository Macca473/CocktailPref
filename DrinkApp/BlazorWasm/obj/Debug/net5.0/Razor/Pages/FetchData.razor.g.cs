#pragma checksum "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c17438197961b30f465f7cde49e7b3d8ba8660"
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
#line 4 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Drink Search</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 11 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
 if (searchedDrinks == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>strDrink</th>\r\n                <th>strInstructions</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 25 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
             foreach (var drink in searchedDrinks)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 28 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                         drink.StrDrink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 29 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                         drink.StrInstructions

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
       

    private BlazorWasm.Root searchedDrinks;

    protected override async Task OnInitializedAsync()
    {
        var logger = LoggerFactory.CreateLogger<FetchData>();

        logger.LogDebug("Getting api");

        swaggerClient client = new("https://www.thecocktaildb.com/api/json/v1/1/", Http);

        logger.LogDebug("Getting search: ", typeof(BlazorWasm.Root));

        //searchedDrinks = await client.GetDrinkAsync("margarita");

        logger.LogCritical("Testing Error Logging");
    }

    public class JSONRoot
    {

    };

    public class Drinks
    {
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public string strDrinkAlternate { get; set; }
        public string strDrinkES { get; set; }
        public string strDrinkDE { get; set; }
        public string strDrinkFR { get; set; }
        public string StrDrinkZHHANS { get; set; }
        public string StrDrinkZHHANT { get; set; }
        public string strTags { get; set; }
        public string strVideo { get; set; }
        public string strCategory { get; set; }
        public string strIBA { get; set; }
        public string strAlcoholic { get; set; }
        public string strGlass { get; set; }
        public string strInstructions { get; set; }
        public string strInstructionsES { get; set; }
        public string strInstructionsDE { get; set; }
        public string strInstructionsFR { get; set; }
        public string StrInstructionsZHHANS { get; set; }
        public string StrInstructionsZHHANT { get; set; }
        public string strDrinkThumb { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
        public string strIngredient5 { get; set; }
        public string strIngredient6 { get; set; }
        public string strIngredient7 { get; set; }
        public string strIngredient8 { get; set; }
        public string strIngredient9 { get; set; }
        public string strIngredient10 { get; set; }
        public string strIngredient11 { get; set; }
        public string strIngredient12 { get; set; }
        public string strIngredient13 { get; set; }
        public string strIngredient14 { get; set; }
        public string strIngredient15 { get; set; }
        public string strMeasure1 { get; set; }
        public string strMeasure2 { get; set; }
        public string strMeasure3 { get; set; }
        public string strMeasure4 { get; set; }
        public string strMeasure5 { get; set; }
        public string strMeasure6 { get; set; }
        public string strMeasure7 { get; set; }
        public string strMeasure8 { get; set; }
        public string strMeasure9 { get; set; }
        public string strMeasure10 { get; set; }
        public string strMeasure11 { get; set; }
        public string strMeasure12 { get; set; }
        public string strMeasure13 { get; set; }
        public string strMeasure14 { get; set; }
        public string strMeasure15 { get; set; }
        public string strImageSource { get; set; }
        public string strImageAttribution { get; set; }
        public string strCreativeCommonsConfirmed { get; set; }
        public string dateModified { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoggerFactory LoggerFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
