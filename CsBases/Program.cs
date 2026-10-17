
class Program
{
    static void Main(string[] args)
    {
        WriteLine("This is a sample program.");

        var laptop = new Product(1, "Laptop", 999.99m, true);
        WriteLine(laptop.GetDescription());

        var soporte = new ServiceProduct(2, "Soporte", 300, true, 20);
        WriteLine(soporte.GetDescription());

        var product = new Product(3, "Smartphone", 499.99m, true);
        var productDto = ProductAdapter.ToDto(product);
        WriteLine($"Product Dto: {productDto.Name}, {productDto.Price:C}, {productDto.Code}");
    }
}