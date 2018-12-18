using System.Text;

namespace Fastening_Exercise.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", ");
            sb.Append(Price.ToString("c"));
            sb.Append(", ");
            sb.Append("Quantity: " + Quantity + ", ");
            sb.Append("Subtotal: " + SubTotal().ToString("c"));

            return sb.ToString();
        }
    }
}
