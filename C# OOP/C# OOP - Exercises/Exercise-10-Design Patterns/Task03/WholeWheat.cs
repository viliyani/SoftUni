using System;

namespace TemplatePattern
{
    public class WholeWheat : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for Whole Wheat Bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat. (15-minutes)");
        }

        public override void Slice()
        {
            Console.WriteLine("Custom slicing of Whole Wheat Bread.");
        }
    }
}
