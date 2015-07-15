namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Contracts;
    using System.Collections.Generic;

    public class Category : ICategory
    {
        private ICollection<IProduct> cosmetics;

        public Category(string name)
        {
            this.Name = name;
            this.cosmetics = new List<IProduct>();
        }

        public string Name { get; set; }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.cosmetics.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            this.cosmetics.Remove(cosmetics);
        }

        public string Print()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
