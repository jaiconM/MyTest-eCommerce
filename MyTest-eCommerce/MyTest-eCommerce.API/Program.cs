using Microsoft.OpenApi.Models;
using MyTest_eCommerce.Data.Repositorios;
using MyTest_eCommerce.Domain.Interfaces;
using MyTest_eCommerce.Domain.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyTest-eCommerce", Description = "App teste do Bootcamp Way2", Version = "v1" });
});

builder.Services.AddScoped<IServicoDeCadastroDeProduto, ServicoDeCadastroDeProduto>();
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyTest-eCommerce v1");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
