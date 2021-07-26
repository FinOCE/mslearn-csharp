int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Console.WriteLine($"Discount: {(saleAmount > 100 ? 100 : 50)}");