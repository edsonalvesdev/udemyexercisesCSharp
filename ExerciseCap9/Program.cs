using ExerciseCap9.Entities;
using System.Globalization;
using System.Text;

DateTime moment = DateTime.Now;
Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(name, email, birthDate);
Order order = new Order(moment, status, client);

Console.Write("How many itens to this order? ");
int items = int.Parse(Console.ReadLine());

for (int i = 1; i <= items; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderItem orderItem = new OrderItem(product, product.Price, quantity);
    order.AddItem(orderItem);
}

StringBuilder sb = new StringBuilder();
sb.AppendLine("ORDER SUMMARY:");
sb.AppendLine($"Order moment: {order.Moment}");
sb.AppendLine($"Order status: {order.Status}");
sb.AppendLine($"Client: {order.Client.Name} ({order.Client.BirthDate.ToString("dd/MM/yyyy")}) - {order.Client.Email}");
sb.AppendLine("Order itens:");

foreach (OrderItem item in order.Items)
{
    sb.AppendLine(
        $"{item.Product.Name}, " +
        $"${item.Product.Price.ToString("N2", CultureInfo.InvariantCulture)}, " +
        $"Quantity: {item.Quantity}, " +
        $"Subtotal: ${item.SubTotal().ToString("N2", CultureInfo.InvariantCulture)}");
}

sb.AppendLine($"Total price: {order.Total().ToString("N2", CultureInfo.InvariantCulture)}");
Console.WriteLine(sb);