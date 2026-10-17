public class Product: IProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid UniqueCode { get; set; }

    public Product(int id, string? name, decimal price, bool isAvailable)
    {
        Id = id;
        Name = name;
        Price = price;
        IsAvailable = isAvailable;
        CreatedAt = DateTime.Now;
        UniqueCode = Guid.NewGuid();
    }

    public void ApplyDiscount(decimal percentage)
    {
        var discountAmount = Price * (percentage / 100);
        Price -= discountAmount;
    }
    public virtual string GetDescription()
    {
        return $"Product: {Name}, Price: {Price:C}";
    }
}
