namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;

    class ShoppingCart : IShoppingCart
    {
        public void AddProduct(IProduct product)
        {
            this.AddProduct(product);
        }

        public void RemoveProduct(IProduct product)
        {
           this.RemoveProduct(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public decimal TotalPrice()
        {
            decimal result = 0;





            return result;
        }
    }
}
