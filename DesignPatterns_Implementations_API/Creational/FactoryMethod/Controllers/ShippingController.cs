using AutoMapper;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.Constants;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.DTOs;
using DesignPatterns_Implementations_API.Creational.FactoryMethod.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_Implementations_API.Creational.FactoryMethod.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShippingController(IShippingService shippingService, IMapper mapper) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateShippingOrder([FromBody] CreateShippingDTO createShippingDto, [FromQuery] string shippingTypes)
    {
        ShippingFactory shippingFactory;

        if (shippingTypes.ToUpper() == ShippingTypes.AIR.ToString())
        {
            shippingFactory = new AirShippingFactory(shippingService, mapper);
            await shippingFactory.RegisterShippingAsync(createShippingDto);

            return Ok("Shipping success");
        }

        return BadRequest();

    }
}