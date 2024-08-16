string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

List<Product> products = new List<Product>()
{
    new Product()
    { 
        Name = "Football", 
        Price = 15, 
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
    new Product() 
    { 
        Name = "Hockey Stick", 
        Price = 12, 
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
    new Product()
    {
        Name = "Cheese",
        Price = 4,
        Sold = true,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
    new Product()
    {
        Name = "Coal",
        Price = 1,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
    new Product()
    {
        Name = "Bat",
        Price = 18,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
    new Product()
    {
        Name = "Baseball",
        Price = 10,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    }
};

Console.WriteLine(greeting);

Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

DateTime now = DateTime.Now;

Product chosenProduct = products[response - 1];
TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");