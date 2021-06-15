// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Pages\FetchData.razor"
           

        public Models.Root Tobj;

        public string SearchString;

        [Parameter]
        public string IngFilter { get; set; }

        public bool AlcoholicBool;

        private List<Models.IngredientColList.IngWcolClass> IngredientList;

        protected async Task UpdateSearch()
        {
            var logger = LoggerFactory.CreateLogger<FetchData>();

            logger.LogDebug("UpdateSearch: " + SearchString);

            Controllers.DrinksAPIController controller = new();

            Pages.Ingsearch ingsearch = new();

            //IngFilter = ingsearch.Inginp.ToString();

            logger.LogDebug("IngFilter raw: " + ingsearch.Inginp.ToString());

            logger.LogDebug("IngFilter: " + IngFilter);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoggerFactory LoggerFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
