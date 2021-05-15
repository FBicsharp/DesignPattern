using System;

namespace FacadePattern
{
    public class Facade
    {

        private Facade1 _facade1;
        private Facade2 _facade2;
        private Facade3 _facade3;

        public Facade()
        {
            _facade1 = new Facade1();
            _facade2 = new Facade2();
            _facade3 = new Facade3();
        }



        public string GetHelloWorldFromFacade()
        {
            return _facade1.Hello() + _facade2.World()+ _facade3.FromFacade() ;
        }



    }

    internal class Facade1
    {
        internal string Hello()
        {
            return "Hello";
        }
    }


    internal class Facade2
    {
        internal string World()
        {
            return " World";
        }
    }
    internal class Facade3
    {
        internal string FromFacade()
        {
            return " from FACADE!!!!";
        }
    }




}
