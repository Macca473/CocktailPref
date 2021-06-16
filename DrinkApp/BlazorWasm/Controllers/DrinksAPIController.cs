using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    

    public class DrinksAPIController : ControllerBase
    {

        public async Task<Models.Root> SearchControllor(string SearchOption, string IngFilter, bool AlcoholicBool)
        {
                
                //Models.Root DrinksModel = new();

                Console.WriteLine("start of task:" + SearchOption + "  |  " + IngFilter + "  |  " + AlcoholicBool);

                Controllers.GETDrinksController controller = new();

                Models.Root BodyJSONmdl = null;

            if (SearchOption == "" || SearchOption == null)
            {
                Console.WriteLine("No search option, searching via ingredients");

                //BodyJSONmdl = await controller.GETDrinks(1, IngFilter);//0:drinkname 1:ingredient 2:ID

                //if (BodyJSONmdl == null)
                //{
                //    Console.WriteLine("BodyJSONmdl is null");
                //}

                //Models.Root TmpBody = BodyJSONmdl;

                //for (int element = 0; element < BodyJSONmdl.drinks.Count; ++element)
                //    {

                //    Models.Root Tmp = await controller.GETDrinks(2, BodyJSONmdl.drinks[element].idDrink);

                //    //Console.WriteLine("Tmp search length: " + Tmp.drinks.Count);

                //    BodyJSONmdl.drinks[element] = Tmp.drinks[0];

                //    Console.WriteLine(BodyJSONmdl.drinks[element].strDrink + " Has " + IngFilter + "  |  " + Tmp.drinks[0].strDrink);

                //    }

                char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

                for (int letter = 0; letter < alphabet.Length; letter++)
                {
                    Models.Root thisletter = await controller.GETDrinks(3, alphabet[letter].ToString());//0:drinkname 1:ingredient 2:ID 3:firstletter

                    Console.WriteLine("Getting drinks starting with the letter: " + alphabet[letter] + " | " + thisletter.drinks.Count);

                    for (int thisdrinkinx = thisletter.drinks.Count - 1; thisdrinkinx >= 0; thisdrinkinx--)
                    {
                        Models.Drinks thisdrink = thisletter.drinks[thisdrinkinx];

                        string[] thisdrinksIngredients = { thisdrink.strIngredient1, thisdrink.strIngredient2, thisdrink.strIngredient3, thisdrink.strIngredient4, thisdrink.strIngredient5, thisdrink.strIngredient6, thisdrink.strIngredient7,thisdrink.strIngredient8, thisdrink.strIngredient9, thisdrink.strIngredient10, thisdrink.strIngredient11, thisdrink.strIngredient12, thisdrink.strIngredient13, thisdrink.strIngredient14, thisdrink.strIngredient15};

                            for (int thisdrinkInginx = 1; thisdrinkInginx < 16; thisdrinkinx++)
                                {
                                        if (thisdrinksIngredients[thisdrinkInginx] == IngFilter)
                                        {
                                            thisletter.drinks.Add(BodyJSONmdl.drinks[thisdrinkinx]);

                                            Console.WriteLine("Added: " + BodyJSONmdl.drinks[thisdrinkinx]);
                                        }
                                }
    
                    }


                }
               

            }

            else
            {
                Console.WriteLine("Traditional search");

                BodyJSONmdl = await controller.GETDrinks(0, SearchOption);
            }

            if (AlcoholicBool == false)
            {
                for (int element = BodyJSONmdl.drinks.Count - 1; element >= 0; --element)
                {
                    if (BodyJSONmdl.drinks[element].strAlcoholic == "Alcoholic")
                    {
                        BodyJSONmdl.drinks.RemoveAt(element);
                        //BodyJSONmdl.drinks[element] = null;
                    }
                    else
                    {
                        
                    }
                }
            }

            if (BodyJSONmdl.drinks == null)
            {
                Console.WriteLine("body is null");
            }

            else
            {
                Console.WriteLine("body is not null");
            }

            Console.WriteLine("end of task");

            return BodyJSONmdl;

            }


    }

}
