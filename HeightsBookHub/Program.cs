using HeightsBookHub.Application.Service.Implementation;
using HeightsBookHub.Application.Service.Interface;
using HeightsBookHub.Domain.Entities;
using HeightsBookHub.Persistence.DbContext;
using HeightsBookHub.Persistence.Repository.Implementation;
using HeightsBookHub.Persistence.Repository.Interface;
using HeightsBookHub.Persistence.Seeders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<HeightsBHDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("HBHConnection")));
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<HeightsBHDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddScoped<UserManager<User>>();


builder.Services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IRabbitMQService, RabbitMQService>();
builder.Services.AddScoped<InventoryManagementService>();




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    RoleSedder.SeedRole(serviceProvider);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
