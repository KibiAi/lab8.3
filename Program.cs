using lab8._3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть тип продукту (Smartphone, Laptop, Tablet):");
        string productType = Console.ReadLine();

        TechProductFactory factory;
        switch (productType)
        {
            case "Smartphone":
                factory = new SmartphoneFactory();
                break;
            case "Laptop":
                factory = new LaptopFactory();
                break;
            case "Tablet":
                factory = new TabletFactory();
                break;
            default:
                Console.WriteLine("Невідомий тип продукту");
                return;
        }

        TechProduct product = factory.CreateTechProduct();
        product.Assemble();
    }
}