using DesignPatterns_Implementations_API.Creational.FactoryMethod.Services;
using DesignPatterns_Implementations_API.Data;
using DesignPatterns_Implementations_API.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite("Data Source=DbOfDesignPatternsImplementations");
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IShippingService, ShippingService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();