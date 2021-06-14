using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.Models
{
    class IngredientColList 
    {
        public class IngWcolClass
        {
            public string Ingredients { get; set; }

            public string Colors { get; set; }

            internal void Add(IngWcolClass ingWcolClass)
            {
                throw new NotImplementedException();
            }
        }

        public List<IngWcolClass> GetIngredients()
        {


            var Ing = new List<string>()
            {
            "Light rum",
            "Applejack",
            "Gin",
            "Dark rum",
            "Sweet Vermouth",
            "Strawberry schnapps",
            "Scotch",
            "Apricot brandy",
            "Triple sec",
            "Southern Comfort",
            "Orange bitters",
            "Brandy",
            "Lemon vodka",
            "Blended whiskey",
            "Dry Vermouth",
            "Amaretto",
            "Tea",
            "Champagne",
            "Coffee liqueur",
            "Bourbon",
            "Tequila",
            "Vodka",
            "Bitters",
            "Sugar",
            "Kahlua",
            "demerara Sugar",
            "Dubonnet Rouge",
            "Watermelon",
            "Lime juice",
            "Irish whiskey",
            "Apple brandy",
            "Carbonated water",
            "Cherry brandy",
            "Creme de Cacao",
            "Grenadine",
            "Port",
            "Coffee brandy",
            "Red wine",
            "Rum",
            "Grapefruit juice",
            "Ricard","Sherry",
            "Cognac","Sloe gin",
            "Apple juice",
            "Pineapple juice",
            "Lemon juice",
            "Sugar syrup",
            "Milk",
            "Strawberries",
            "Chocolate syrup",
            "Yoghurt",
            "Mango",
            "Ginger",
            "Lime",
            "Cantaloupe",
            "Berries",
            "Grapes",
            "Kiwi",
            "Tomato juice",
            "Cocoa powder",
            "Chocolate",
            "Heavy cream",
            "Galliano",
            "Peach Vodka",
            "Ouzo",
            "Coffee",
            "Spiced rum",
            "Water",
            "Espresso",
            "Angelica root",
            "Orange",
            "Cranberries",
            "Johnnie Walker",
            "Apple cider",
            "Everclear",
            "Cranberry juice",
            "Egg yolk",
            "Egg",
            "Grape juice",
            "Peach nectar",
            "Lemon","Firewater",
            "Lemonade",
            "Lager",
            "Whiskey",
            "Absolut Citron",
            "Pisco",
            "Irish cream",
            "Ale",
            "Chocolate liqueur",
            "Midori melon liqueur",
            "Sambuca",
            "Cider",
            "Sprite",
            "7-Up",
            "Blackberry brandy",
            "Peppermint schnapps",
            "Creme de Cassis"
            };

            var Colors = new List<string>()
            {
            "#f2f7f2",
            "#F58E25",
            "#F8F8F8",
            "#E84F17",
            "#7F0D1D",
            "#C6102D",
            "#F29107",
            "#F7CF3E",
            "#DBE1ED",
            "#8B2D1E",
            "#F3560F",
            "#A21E14",
            "#EED305",
            "#FFAD32",
            "#D8D8BC",
            "#D16908",
            "#C94301",
            "#EFDA9E",
            "#6F441D",
            "#FFA809",
            "#F1EFEE",
            "#F1F1F1",
            "#E37D00",
            "#D6E0EC",
            "#734D2B",
            "#A7660E",
            "#710107",
            "#96B563",
            "#D6E55C",
            "#DC9F08",
            "#806927",
            "#ECEEEF",
            "#C33919",
            "#65371E",
            "#D13C37",
            "#7D1015",
            "#171110",
            "#D60101",
            "#C3482E",
            "#ED5B0D",
            "#E07105",
            "#E3D398",
            "#E36A23",
            "#990002",
            "#F8E690",
            "E1C67D",
            "E5E37C",
            "#E0DCC7",
            "EBE5DB",
            "#F76660",
            "#4F2821",
            "#EBEEEB",
            "#C88A00",
            "#E5CF86",
            "#DEE873",
            "#B19E19",
            "#DA2833",
            "#E3DC77",
            "#8FB724",
            "#AA1400",
            "#602616",
            "#4D3835",
            "#F4E8D0",
            "#F7F048",
            "#EDC496",
            "#D7D7D7",
            "#C9A356",
            "#F6B135",
            "#E4EEF4",
            "#B86C33",
            "#E2C9B5",
            "#F29312",
            "#F790BA",
            "#D3501B",
            "#F1BB38",
            "#EDEDED",
            "#A32517",
            "#E8A005",
            "#BF8355",
            "#58021F",
            "#F08A1C",
            "#F3D91D",
            "#EFA93C",
            "#DED9D7",
            "#E6B327",
            "#E09224",
            "#E7E7F0",
            "3FEFEFC",
            "#D3C0A1",
            "#BA2E15",
            "#AC3D27",
            "#87BF66",
            "#BEB9B0",
            "#F0DD93",
            "#C6E0B8",
            "#7AAF6F",
            "#5E0400",
            "#ECECEC",
            "#A04F60"
            };


            List<IngWcolClass> IngWcol = new List<IngWcolClass>();

            for (int element = 0; element < Ing.Count; element++ )
            {
                IngWcol.Add(new IngWcolClass { Ingredients = Ing[element], Colors = Colors[element] });

                Console.WriteLine("Ingredients COunt: " + IngWcol[element] + "  |  " + Ing[element]);

            }

            return IngWcol;
        }

        
    }


}