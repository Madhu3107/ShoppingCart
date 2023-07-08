using Catelog.API.Contracts;
using Catelog.API.DataProvider;
using Catelog.API.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<CatelogDbSettings>(builder.Configuration.GetSection("CatelogDbSettings"));
builder.Services.AddSingleton<ICatelogDbSettings>(provider =>

    provider.GetRequiredService<IOptions<CatelogDbSettings>>().Value
);
builder.Services.AddScoped<ICatalogService, CatalogService>();

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
