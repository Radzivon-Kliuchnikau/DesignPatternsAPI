using AutoMapper;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.DTOs;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.Services;

namespace DesignPatterns_Implementations_API.Creational.FactoryMethod;

public class SeaShippingFactory(IShippingService shippingService, IMapper mapper) : ShippingFactory(shippingService, mapper)
{
    public override ShippingBase CreateShipping(CreateShippingDTO createShippingDto)
    {
        return new SeaShipping
        {
            Destination = createShippingDto.Destination,
            Weight = createShippingDto.Weight,
            ShippingDate = createShippingDto.ShippingDate
        };
    }
}