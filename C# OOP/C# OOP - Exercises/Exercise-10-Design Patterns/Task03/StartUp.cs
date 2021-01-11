using System;

namespace TemplatePattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();

            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            WholeWheat wholeWhat = new WholeWheat();
            wholeWhat.Make();
        }
    }
}
