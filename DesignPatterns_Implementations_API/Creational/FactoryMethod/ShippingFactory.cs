using AutoMapper;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.DTOs;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.Services;

namespace DesignPatterns_Implementations_API.Creational.FactoryMethod;

public abstract class ShippingFactory(IShippingService shippingService, IMapper mapper)
{
    public abstract ShippingBase CreateShipping(CreateShippingDTO createShippingDto);

    public async Task RegisterShippingAsync(CreateShippingDTO createShippingDto)
    {
        var shipping = CreateShipping(createShippingDto);

        var createdShipping = mapper.Map<ShippingBase>(createShippingDto);
        
        shipping.Ship();
        await shippingService.CreateShippingAsync(createdShipping);
    }
}