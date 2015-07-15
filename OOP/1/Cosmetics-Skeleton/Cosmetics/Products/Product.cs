namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public abstract class Product : IProduct
    {
        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public GenderType Gender { get; set; }

        public string Print()
        {
            return this.Name;
        }

    }
}
