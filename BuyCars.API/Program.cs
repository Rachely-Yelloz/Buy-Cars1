using BuyCars.API.Middlewares;
using BuyCars.CORE;
using BuyCars.CORE.Models;
using BuyCars.CORE.Repositories;
using BuyCars.CORE.Services;
using BuyCars.DATA;
using BuyCars.DATA.Repositories;
using BuyCars.SERVICE;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<ICarRepository,CarRepository>();
builder.Services.AddScoped<ICastomerService, CastomerService>();
builder.Services.AddScoped<ICastomerRepository, CastomerRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<ShabbatMiddleware>();

app.MapControllers();

app.Run();
