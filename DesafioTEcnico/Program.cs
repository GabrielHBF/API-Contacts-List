
using DesafioTEcnico.Application.interfaces;
using DesafioTEcnico.Application.Queryes;
using DesafioTEcnico.Infrastructure;
using System.Xml.Serialization;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//signing up for the library MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(getAllUserContactQuery).Assembly));
builder.Services.AddScoped<InterfaceUserContatctBD, MongoBD>();

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
