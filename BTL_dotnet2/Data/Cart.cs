using BTL_dotnet2.Models;

namespace BTL_dotnet2.Data
{
    public class CartItem
    {

        public Product Product { get; set; }
        public int Amount { get; set; }
        public double totalPrice => Amount * Product.Price;


    }
}
