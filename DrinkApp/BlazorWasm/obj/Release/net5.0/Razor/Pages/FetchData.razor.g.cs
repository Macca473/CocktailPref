#pragma checksum "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcac08af6955a8154c73b730a0186e582fe71220"
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
#line 12 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "background");
            __builder.AddAttribute(2, "b-3su10ndsq5");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "page Cpersent");
            __builder.AddAttribute(5, "b-3su10ndsq5");
            __builder.AddMarkupContent(6, "<div class=\"title\" b-3su10ndsq5><h1 class=\"Title\" b-3su10ndsq5>Drink Search</h1></div>\r\n\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid");
            __builder.AddAttribute(9, "b-3su10ndsq5");
            __builder.OpenElement(10, "form");
            __builder.AddAttribute(11, "b-3su10ndsq5");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row formStyle");
            __builder.AddAttribute(14, "b-3su10ndsq5");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-sm-3 textInput");
            __builder.AddAttribute(17, "style", "bottom: 9px");
            __builder.AddAttribute(18, "b-3su10ndsq5");
            __builder.AddMarkupContent(19, "\r\n                        Drink: ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "class", "text_input");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                                                         SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(25, "b-3su10ndsq5");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-sm-3 textInput");
            __builder.AddAttribute(29, "style", "bottom: 2px");
            __builder.AddAttribute(30, "b-3su10ndsq5");
            __builder.OpenComponent<BlazorWasm.Pages.Ingsearch>(31);
            __builder.SetKey(
#nullable restore
#line 28 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                                         IngFilter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-sm-3 Alcoholcheck");
            __builder.AddAttribute(35, "b-3su10ndsq5");
            __builder.AddMarkupContent(36, "\r\n                        Alcoholic?:\r\n                        ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "checkbox");
            __builder.AddAttribute(39, "class", "checkbx");
            __builder.AddAttribute(40, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                                                      AlcoholicBool

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AlcoholicBool = __value, AlcoholicBool));
            __builder.SetUpdatesAttributeName("checked");
            __builder.AddAttribute(42, "b-3su10ndsq5");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-sm-3 textInput");
            __builder.AddAttribute(46, "b-3su10ndsq5");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "value", "Filter");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                                                                      UpdateSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "b-3su10ndsq5");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "container-fluid drinkView Cpersent");
            __builder.AddAttribute(55, "b-3su10ndsq5");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row Cpersent");
            __builder.AddAttribute(58, "b-3su10ndsq5");
#nullable restore
#line 56 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                 if (Tobj == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "<p b-3su10ndsq5>Loading...</p>");
#nullable restore
#line 59 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                }


                else if (Tobj.drinks == null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "p");
            __builder.AddAttribute(61, "b-3su10ndsq5");
            __builder.OpenElement(62, "em");
            __builder.AddAttribute(63, "b-3su10ndsq5");
            __builder.AddContent(64, "What is \'");
            __builder.AddContent(65, 
#nullable restore
#line 64 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                                     SearchString

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, "\'?");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"

                }
                else

                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                     for (int drink = 0; drink < Tobj.drinks.Count; drink++)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-sm-3 drinkbox");
            __builder.AddAttribute(69, "b-3su10ndsq5");
            __builder.OpenComponent<BlazorWasm.Pages.DrinkView>(70);
            __builder.AddAttribute(71, "drink", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorWasm.Models.Drinks>(
#nullable restore
#line 73 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                                              Tobj.drinks[drink]

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 75 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
                     

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
       

    public Models.Root Tobj;

    public string SearchString;

    //[Parameter]
    //public string IngFilter { get; set; }

    public string IngFilter;

    public bool AlcoholicBool;

    private List<Models.IngredientColList.IngWcolClass> IngredientList;

    protected async Task UpdateSearch()
    {
        var logger = LoggerFactory.CreateLogger<FetchData>();

        logger.LogDebug("UpdateSearch: " + SearchString);

        Controllers.DrinksAPIController controller = new();

        IngFilter = await LocalStorage.GetItemAsync<string>("Ing");

        Tobj = await controller.SearchControllor(SearchString, IngFilter, AlcoholicBool);

        logger.LogDebug("Getting Object");
    }

    //private void filtering(ChangeEventArgs IngInput)
    //{
    //    var logger = LoggerFactory.CreateLogger<FetchData>();

    //    //Models.IngredientList GetingredientList = new();

    //    Models.IngredientColList GetingredientList = new();

    //    IngredientList = GetingredientList.GetIngredients();

    //    string StringInput = IngInput.Value.ToString().ToLower();

    //    string fixedsearch = "";

    //    if (StringInput.Length >= 2)
    //    {
    //        fixedsearch = char.ToUpper(StringInput[0]) + StringInput.Substring(1);
    //    }
    //    else
    //    {
    //        fixedsearch = StringInput;
    //    }

    //    if (IngInput.Value.ToString() == "")
    //    {
    //        IngredientList = null;
    //    }
    //    else
    //    {
    //        for (int Ingredientindex = IngredientList.Count - 1; Ingredientindex >= 0; --Ingredientindex)
    //        {
    //            if (IngredientList[Ingredientindex].Ingredients.Contains(fixedsearch))
    //            { }
    //            else
    //            {
    //                IngredientList.RemoveAt(Ingredientindex);
    //            }
    //        }
    //    }
    //}

    //protected void selectIngredient(string Ingredient)
    //{
    //    var logger = LoggerFactory.CreateLogger<FetchData>();

    //    logger.LogDebug("Ingredient: " + Ingredient);

    //    IngFilter = Ingredient;
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoggerFactory LoggerFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
