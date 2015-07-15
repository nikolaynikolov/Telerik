namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoo : Category, IShampoo
    {
        private string name;
        public decimal quantity { get; private set; }
        public string usage { get; private set; }

        public decimal Price { get; private set; }

        public GenderType Gender { get; private set; }

        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }
    }
}
