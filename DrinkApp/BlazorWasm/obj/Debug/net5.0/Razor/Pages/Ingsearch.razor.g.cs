#pragma checksum "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0496b4f46ba53c2e5fe5a92905fffe8c62a37535"
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
#line 4 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ingsearch")]
    public partial class Ingsearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-inx6fnyr39");
            __builder.AddMarkupContent(2, "\r\n    Ingredient: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
                                             filtering

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "dropbtn");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
                                                                IngFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IngFilter = __value, IngFilter));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(9, "b-inx6fnyr39");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "dropdown-content");
            __builder.AddAttribute(13, "b-inx6fnyr39");
#nullable restore
#line 12 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
         if (IngredientList == null)
        { }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
             foreach (var Ingredient in IngredientList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "style", "background-color:" + (
#nullable restore
#line 19 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
                                                Ingredient.Colors

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddAttribute(17, "value", 
#nullable restore
#line 20 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
                               Ingredient.Ingredients

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
                                 (e => selectIngredient(Ingredient.Ingredients))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "b-inx6fnyr39");
            __builder.CloseElement();
#nullable restore
#line 22 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.AddMarkupContent(21, "<div b-inx6fnyr39><p b-inx6fnyr39></p></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\Ingsearch.razor"
       

    [Parameter]
    public string IngFilter { get; set; }

    private List<Models.IngredientColList.IngWcolClass> IngredientList;

    private void filtering(ChangeEventArgs IngInput)
    {
        var logger = LoggerFactory.CreateLogger<FetchData>();

        //Models.IngredientList GetingredientList = new();

        Models.IngredientColList GetingredientList = new();

        IngredientList = GetingredientList.GetIngredients();

        string StringInput = IngInput.Value.ToString().ToLower();

        string fixedsearch = "";

        if (StringInput.Length >= 2)
        {
            fixedsearch = char.ToUpper(StringInput[0]) + StringInput.Substring(1);
        }
        else
        {
            fixedsearch = StringInput;
        }

        if (IngInput.Value.ToString() == "")
        {
            IngredientList = null;
        }
        else
        {
            for (int Ingredientindex = IngredientList.Count - 1; Ingredientindex >= 0; --Ingredientindex)
            {
                if (IngredientList[Ingredientindex].Ingredients.Contains(fixedsearch))
                { }
                else
                {
                    IngredientList.RemoveAt(Ingredientindex);
                }
            }
        }


    }

    public string selectIngredient(string Ingredient)
    {
        var logger = LoggerFactory.CreateLogger<Ingsearch>();

        logger.LogDebug("(Ingsearch)Ingredient: " + Ingredient);

        IngFilter = Ingredient;

        LocalStorage.SetItemAsync("Ing", IngFilter);

        return Ingredient;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoggerFactory LoggerFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
