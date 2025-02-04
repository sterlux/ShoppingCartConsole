namespace OnlineShop{
    public class Item{
        // Propiedades
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        // Metodos
        public double CalculateSubTotal(){
            var subTotal = Price * Qty;
            return subTotal;
        }
    }
}