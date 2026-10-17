public class ServiceProduct : Product
{
    public int DurationInDays { get; set; } // Duration in days

    public ServiceProduct(int id, string? name, decimal price, bool isAvailable, int duration)
        : base(id, name, price, isAvailable)
    {
        DurationInDays = duration;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Duration: {DurationInDays} days";
    }
}