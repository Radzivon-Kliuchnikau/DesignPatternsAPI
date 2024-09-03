using DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;
using DesignPatterns_Implementations_API.Repository;

namespace DesignPatterns_Implementations_API.Creational.FactoryMethod.Services;

public class ShippingService(IRepository<ShippingBase> repository) : IShippingService
{
    public async Task<IEnumerable<ShippingBase>> GetAllShippingAsync()
    {
        return await repository.GetAllAsync();
    }

    public async Task<ShippingBase?> GetShippingByIdAsync(int id)
    {
        return await repository.GetByIdAsync(id);
    }

    public async Task<ShippingBase> CreateShippingAsync(ShippingBase shipping)
    {
        return await repository.AddAsync(shipping);
    }

    public async Task<ShippingBase> UpdateProductAsync(ShippingBase shipping)
    {
        return await repository.UpdateAsync(shipping);
    }

    public async Task<bool> DeleteShipping(int id)
    {
        return await repository.DeleteAsync(id);
    }
}