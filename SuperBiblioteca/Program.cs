using API_SuperBiblioteca.Data;
using API_SuperBiblioteca.Data.Interfaces;
using API_SuperBiblioteca.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

PostgresqlConfiguration postgresqlConfiguration = new PostgresqlConfiguration(Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? "");
builder.Services.AddSingleton(postgresqlConfiguration);

builder.Services.AddScoped<ILibroService, LibroService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IEjemplarService, EjemplarService>();
builder.Services.AddScoped<IPrestamoService, PrestamoService>();
builder.Services.AddScoped<IMultaService, MultaService>();
builder.Services.AddScoped<IEjemplarService, EjemplarService>();
builder.Services.AddScoped<IAuthService, AuthService>();



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
