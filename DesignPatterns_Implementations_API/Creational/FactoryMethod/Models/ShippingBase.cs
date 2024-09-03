namespace DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;

public abstract class ShippingBase
{
    public int Id { get; set; }
    
    public string? Destination { get; set; }
    
    public decimal Weight { get; set; }
    
    public DateTime ShippingDate { get; set; }

    public abstract decimal CalculateShippingCost();

    public abstract void Ship(); // TODO: what can be here exactly
}