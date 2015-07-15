namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Collections.Generic;

    public class Toothpaste : Product, IToothpaste, IProduct
    {

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender) 
        {
            this.Ingredients = String.Join(", ", ingredients); 
        }
        
        public string Ingredients {get; set;}

    }
}

