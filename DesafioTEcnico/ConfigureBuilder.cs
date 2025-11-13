using DesafioTEcnico.Application.Queryes;
using DesafioTEcnico.Domain;
using DesafioTEcnico.Infrastructure;

namespace DesafioTEcnico
{
    public static class ConfigureBuilder
    {
        public static void MyBuilderApi(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //signing up for the library MediatR
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllUserContactQuery).Assembly));
            //When you need the interface, it should point to the MongoDB implementation.
            builder.Services.AddScoped<InterfaceRepository, Repository>();
        }
    }
}
