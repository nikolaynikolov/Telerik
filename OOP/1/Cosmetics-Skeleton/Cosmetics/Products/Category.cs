namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Contracts;
    using System.Collections.Generic;
    using System.Linq;

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
            string format = string.Empty;
            var cosmeticNames = this.cosmetics.Select(x => x.Name);
            var cosmeticBrands = this.cosmetics.Select(x => x.Brand);
            var cosmeticPrice = this.cosmetics.Select(x => x.Price);
            var cosmeticGender = this.cosmetics.Select(x => x.Gender);
           
            
            if ((this.cosmetics.Count == 1))
            {
                format = "{0} category – {1} product in total";
                Console.WriteLine(format);
            }
            else
            {
                format = "{0} category – {1} products in total";
                Console.WriteLine(format);
            }
            Console.WriteLine("- {0} – {1}:", cosmeticBrands, cosmeticNames);
            Console.WriteLine("  * Price: ${0}", cosmeticPrice);
            Console.WriteLine("  * For gender: {0}", cosmeticGender);
       //     Console.WriteLine("  * Ingredients: {0}", );


 
            string result = string.Format(format, this.Name, string.Join("\n", cosmeticNames));
            return result;
        }
    }
}
