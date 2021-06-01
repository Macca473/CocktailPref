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

                Console.WriteLine("start of task");

                Controllers.GETDrinksController controller = new();

                Models.Root BodyJSONmdl = null;



            if (SearchOption == null)

            {
                Console.WriteLine("No search option, searching via ingredients");

                BodyJSONmdl = await controller.GETDrinks(1, IngFilter);//0:drinkname 1:ingredient 2:ID

                Console.WriteLine("ingredient search length: " + BodyJSONmdl.drinks.Count);

                Models.Root TmpBody = BodyJSONmdl;

                for (int element = 0; element < BodyJSONmdl.drinks.Count; ++element)
                    {

                    Models.Root Tmp = await controller.GETDrinks(2, BodyJSONmdl.drinks[element].idDrink);

                    Console.WriteLine("Tmp search length: " + Tmp.drinks.Count);

                    BodyJSONmdl.drinks[element] = Tmp.drinks[0];

                    Console.WriteLine(BodyJSONmdl.drinks[element].strDrink + " Has " + IngFilter);

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

                        Console.WriteLine(BodyJSONmdl.drinks[element].strDrink + " is removed");
                    }

                    Console.WriteLine(BodyJSONmdl.drinks[element].strDrink + " is " + BodyJSONmdl.drinks[element].strAlcoholic);

                }
            }

            if (BodyJSONmdl.drinks == null)
            {
                Console.WriteLine("body is null");

            }

            else
            {
                Console.WriteLine("body is not null");
                Console.WriteLine("Body: " + BodyJSONmdl);
            }

            Console.WriteLine("end of task");

            return BodyJSONmdl;

            }


    }

}
