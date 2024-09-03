using DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;

namespace DesignPatterns_Implementations_API.Creational.FactoryMethod.Services;

public interface IShippingService
{
    Task<IEnumerable<ShippingBase>> GetAllShippingAsync();
    Task<ShippingBase?> GetShippingByIdAsync(int id);
    Task<ShippingBase> CreateShippingAsync(ShippingBase shipping);
    Task<ShippingBase> UpdateProductAsync(ShippingBase shipping);
    Task<bool> DeleteShipping(int id);
}