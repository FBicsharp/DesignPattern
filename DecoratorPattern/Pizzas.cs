using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    /// <summary>
    /// Base Interface
    /// </summary>
    public interface IPizza
    {
        string Topping();
        void AddTopping(string topping);
        void RemoveTopping(string topping);
    }

    /// <summary>
    /// Base Class
    /// </summary>
    public class Pizza : IPizza
    {
        List<string> ToppingElem;
        public Pizza()
        {
            ToppingElem = new List<string>();
            ToppingElem.Add( "Tomato");
            ToppingElem.Add( "Cheese");
        }

        public void AddTopping(string topping)
        {
            ToppingElem.Add(topping);
        }

        public void RemoveTopping(string topping)
        {
            ToppingElem.RemoveAll(e => e == topping);          

        }

        public string Topping()
        {
            return "Pizza have:\n\t *" +string.Join("\n\t *", ToppingElem);
        }

       
    }


    /// <summary>
    /// Dichiaro la decorazione della classe base 
    /// </summary>
    public class DecoratorPizza : IPizza
    {
        private IPizza _pizza { get; set; }

        public DecoratorPizza(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string Topping()
        {
            return _pizza.Topping();
        }

        public void AddTopping(string topping)
        {
            _pizza.AddTopping(topping);
        }

        public void RemoveTopping(string topping)
        {
            _pizza.RemoveTopping(topping);
        }
    }



    /// <summary>
    /// Dichiaro una classe base che implementa l'interfaccia di base 
    /// </summary>
    public class DoubleCheeseDecoratorPizza : DecoratorPizza
    {
        public DoubleCheeseDecoratorPizza(IPizza pizza) : base(pizza)
        {
        }

        public override string Topping()
        {
            base.AddTopping("Cheese");
            return base.Topping();
        }
    }

    /// <summary>
    /// Dichiaro una classe base che implementa l'interfaccia di base 
    /// </summary>
    public class WhiteDecoratorPizza : DecoratorPizza
    {
        public WhiteDecoratorPizza(IPizza pizza) : base(pizza)
        {
        }

        public override string Topping()
        {
            base.RemoveTopping("Tomato");
            return base.Topping();
        }
    }




}
