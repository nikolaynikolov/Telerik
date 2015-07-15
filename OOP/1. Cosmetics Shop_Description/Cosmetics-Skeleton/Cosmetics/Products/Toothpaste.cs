namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Toothpaste : Category, IToothpaste
    {
        public string ingredients { get; private set; }

        string Brand { get; set; }

        public decimal Price{ get; private set; }
 

        public GenderType Gender{ get; private set; }


        public string Ingredients { get; private set; }

    }
}
