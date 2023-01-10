using Foodmoji_Application.Repository.DomainRepository;
using Foodmoji_Application.Repository.Wrapper;
using Foodmoji_Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container - Register API

builder.Services.AddScoped<IAccountRepository, AccountRepository>();

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

//options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
