namespace DesignPatterns_Implementations_API.Creational.FactoryMethod.DTOs;

public class ReadShippingDTO
{
    public int Id { get; set; }
    
    public string? Destination { get; set; }
    
    public decimal Weight { get; set; }
    
    public DateTime ShippingDate { get; set; }
}