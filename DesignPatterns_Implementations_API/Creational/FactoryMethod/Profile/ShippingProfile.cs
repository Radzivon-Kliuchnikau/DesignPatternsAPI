using DesignPatterns_Implementations_API.Creational.FactoryMethod.DTOs;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;

namespace DesignPatterns_Implementations_API.Creational.FactoryMethod.Profile;

public class ShippingProfile : AutoMapper.Profile
{
    public ShippingProfile()
    {
        CreateMap<ShippingBase, ReadShippingDTO>();
        CreateMap<CreateShippingDTO, ShippingBase>();
        CreateMap<UpdateShippingDTO, ShippingBase>();
    }
}