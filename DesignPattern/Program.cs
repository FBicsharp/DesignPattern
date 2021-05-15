using System;
using DecoratorPattern;
using FacadePattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DECORATOR PATTERN");

            IPizza pizza = new Pizza();
            Console.WriteLine( pizza.Topping());

            IPizza pizzaDoublechease = new DoubleCheeseDecoratorPizza(pizza);
            Console.WriteLine(pizzaDoublechease.Topping());

            IPizza pizzawhite = new WhiteDecoratorPizza(pizza);
            Console.WriteLine( pizzawhite.Topping());

            Console.WriteLine("END PATTERN");


            Console.WriteLine("FACADE PATTERN\n");

            Facade facadeSample = new Facade();
            
            Console.WriteLine(facadeSample.GetHelloWorldFromFacade());

            Console.WriteLine("END PATTERN\n");


        }
    }
}
