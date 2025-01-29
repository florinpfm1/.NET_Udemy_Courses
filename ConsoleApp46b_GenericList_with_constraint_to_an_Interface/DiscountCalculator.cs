namespace ConsoleApp46b_GenericList_with_constraint_to_an_Interface
{
    public class DiscountCalculator<TProduct> where TProduct : Product  //here we applied a constraint to a class Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

}
