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

                Models.Root BodyJSONmdl = await controller.GETDrinks(0, SearchOption);

            if (BodyJSONmdl.drinks == null)
                    {
                        Console.WriteLine("body is null");
                        
                    }

                    else
                    {
                        Console.WriteLine("body is not null");
                        Console.WriteLine("Body: " + BodyJSONmdl.drinks.Count);
            }

            if (SearchOption == "")

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

            else
            {

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

            Console.WriteLine("end of task");

            return BodyJSONmdl;

            }


    }

}
