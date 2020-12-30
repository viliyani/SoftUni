using System;

namespace CommandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("IPhone 7", 500);

            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 200));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 300));

            Console.WriteLine($"I can buy just \n{product}");
        }

        private static void Execute(Product product, ModifyPrice modifyPrice, ICommand command)
        {
            modifyPrice.SetCommamd(command);
            modifyPrice.Invoke();
        }
    }
}
