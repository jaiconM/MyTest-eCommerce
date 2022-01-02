using MyTest_eCommerce.Data.Interfaces;
using MyTest_eCommerce.Model.Interfaces;
using MyTest_eCommerce.Model.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IServicoDeCadastroDeProduto, ServicoDeCadastroDeProduto>();
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
