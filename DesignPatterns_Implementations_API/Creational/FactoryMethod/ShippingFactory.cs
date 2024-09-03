using DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;

namespace DesignPatterns_Implementations_API.Creational.FactoryMethod;

public abstract class ShippingFactory
{
    public abstract ShippingBase CreateShipping(CreateShippingDto createShippingDto);

    public async Task ShipAsync(CreateShippingDto createShippingDto)
    {
        var shipping = CreateShipping(createShippingDto);
        
        shipping.Ship();
        // context.Add(shipping);
        // context.SaveChangesAsync();
    }
}