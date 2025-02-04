using OnlineShop;

ShoppingCart cart = new ShoppingCart();
cart.Items = new List<Item>();

Item item1 = new Item();
item1.Name = "Mouse Logitech";
item1.Price = 50;
item1.Qty = 2;

Item item2 = new Item();
item2.Name = "Teclado gamer 3000";
item2.Price = 50;
item2.Qty = 1;

Item item3 = new Item();
item3.Name = "Monitor curvo MSI 144Hz";
item3.Price = 200;
item3.Qty = 3;

cart.AddItem(item1); // 0
cart.AddItem(item2); // 1
cart.AddItem(item3); // 2



var total = cart.CalculateTotal();
total = cart.AddDiscount(20);

int i = 1;
foreach(var current in cart.Items){
    Console.WriteLine($"{i}: {current.Name } | ${current.Price} " +
        $"| {current.Qty}= ${current.CalculateSubTotal()}");
    i++;
}

Console.WriteLine($"El total de tu compra: {total}");

Console.Write("Elige el elemento a eliminar: ");
var indexToDelete = Convert.ToInt32(Console.ReadLine());

cart.RemoveItem(indexToDelete-1);

int j = 1;
foreach(var current in cart.Items){
    Console.WriteLine($"{j}: {current.Name } | ${current.Price} " +
        $"| {current.Qty}= ${current.CalculateSubTotal()}");
    j++;
}
total = cart.CalculateTotal();
Console.WriteLine($"El total de tu compra: {total}");
