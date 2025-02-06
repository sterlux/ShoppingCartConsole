using OnlineShop;

List<Item> catalog = new List<Item>();

ShoppingCart cart = new ShoppingCart();
cart.Items = new List<Item>();

Item item1 = new Item();
item1.Name = "Mouse Logitech";
item1.Price = 50;

Item item2 = new Item();
item2.Name = "Teclado gamer 3000";
item2.Price = 50;

Item item3 = new Item();
item3.Name = "Monitor curvo MSI 144Hz";
item3.Price = 200;

catalog.Add(item1); // 0
catalog.Add(item2); // 1
catalog.Add(item3); // 2

while(true){
    int option = 0;
    Console.WriteLine("[1] Detener");
    Console.WriteLine("[2] Ver artículos");
    Console.WriteLine("[3] Agregar al carrito");
    Console.WriteLine("[4] Ver mi carrito");
    Console.WriteLine("Elige la opción: ");
    option = Convert.ToInt32(Console.ReadLine());

    if(option == 1)
        break;

    switch(option){
        case 2:
            PrintCatalog(catalog);
            break;
        
        case 3:
            PrintCatalog(catalog);
            Console.WriteLine("Número de artículo: ");
            int itemNo = Convert.ToInt32(Console.ReadLine());
            itemNo--; // itemNo = itemNo - 1;
            Console.WriteLine("Cantidad: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Item newItem = catalog[itemNo];
            newItem.Qty = qty;
            cart.AddItem(newItem);
            break;
        case 4:
            int i = 1;
            foreach(var current in cart.Items){
                Console.WriteLine($"{i}: {current.Name } | ${current.Price} " +
                    $" | {current.Qty} | Subtotal: ${current.CalculateSubTotal()}");
                i++;
            }
            break;
        
        default:
            break;

    }
}





var total = cart.CalculateTotal();
total = cart.AddDiscount(20);

PrintCatalog(cart.Items);

Console.WriteLine($"El total de tu compra: {total}");

Console.Write("Elige el elemento a eliminar: ");
var indexToDelete = Convert.ToInt32(Console.ReadLine());

cart.RemoveItem(indexToDelete-1);

PrintCatalog(cart.Items);

total = cart.CalculateTotal();
Console.WriteLine($"El total de tu compra: {total}");


void PrintCatalog(List<Item> items){
    int i = 1;
    foreach(var current in items){
        Console.WriteLine($"{i}: {current.Name } | ${current.Price}");
        i++;
    }
}