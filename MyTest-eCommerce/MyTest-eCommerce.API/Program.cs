using MyTest_eCommerce.API.Config;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigAddSwagger();
builder.Services.ConfigIoC();

var app = builder.Build();

app.ConfigUseSwagger();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
