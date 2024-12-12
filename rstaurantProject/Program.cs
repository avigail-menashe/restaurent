using restaurant;
using restaurant.Core.Repositories;
using restaurant.Core.Services;
using restaurant.Data;
using restaurant.Data.Repositories;
using restaurant.Service;
using rstaurantProject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClientService, ClientSerivce>();
builder.Services.AddScoped<IClientRepository , ClientRepository>();

builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IDeliveryService , DeliverService>();
builder.Services.AddScoped<IDeliveryRepository , DeliveryRepository>();


builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
