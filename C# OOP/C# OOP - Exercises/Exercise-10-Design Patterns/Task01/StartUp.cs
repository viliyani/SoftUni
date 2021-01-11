using System;

namespace Prototype
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SandwichMenu menu = new SandwichMenu();

            menu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Tomato");
            menu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion");

            Sandwich sandwich1 = menu["BLT"].Clone() as Sandwich;
            Sandwich sandwich2 = menu["Turkey"].Clone() as Sandwich;
        }
    }
}
