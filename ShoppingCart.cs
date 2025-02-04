namespace OnlineShop{
    public class ShoppingCart{
        public List<Item>? Items { get; set; }
        private double Discount {get; set;}

        public double CalculateTotal(){
            double total = 0;
            // Vamos a iterar la lista de Items
            foreach(Item current in Items){
                total += current.CalculateSubTotal();
            }

            if(Discount > 0)
                return total * ((100-Discount)/100);
            else
                return total;
        }

        // Recibe como parametro un objeto de tipo Item
        public void AddItem(Item newItem){ 
            Items.Add(newItem);
        }

        public double AddDiscount(int discount){
            Discount = discount;
            return CalculateTotal();
        }

        public void RemoveItem(int index){
            Items.RemoveAt(index);
        }
    }
}