﻿namespace Cosmetics.Engine
{


    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Collections.Generic;


    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            // TODO: create category
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            // TODO: create shampoo
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            // TODO: create toothpaste
        }

        public IShoppingCart ShoppingCart()
        {
            // TODO: create shopping cart
        }
    }
}
