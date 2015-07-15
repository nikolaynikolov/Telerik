namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Collections.Generic;

    public class Category : ICategory
    {
        private ICollection<IProduct> cosmetics;

        public Category(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            this.Name = name;
            this.Brand = brand;
            this.cosmetics = new List<IProduct>();
        }

        public string Name { get; set; }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.cosmetics.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public string Print()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public string Brand { get; set; }
    }
}
