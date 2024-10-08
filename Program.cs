using Microsoft.EntityFrameworkCore;
using netchallenge.Infrastructure.Context;
using netchallenge.Infrastructure.Repositories;
using netchallenge.Application.Interfaces;
using netchallenge.Application.Services;

var builder = WebApplication.CreateBuilder(args);


// Habilita MVC
builder.Services.AddControllersWithViews(); 

// Configura��o do DbContext para usar MySQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))); 
});


// Inje��o de depend�ncias para os reposit�rios
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddScoped<ITratamentoRepository, TratamentoRepository>();
builder.Services.AddScoped<ISinistroRepository, SinistroRepository>();
builder.Services.AddScoped<IRecomendacaoRepository, RecomendacaoRepository>();

// Inje��o de depend�ncias para os servi�os
builder.Services.AddScoped<PacienteService>();
builder.Services.AddScoped<TratamentoService>();
builder.Services.AddScoped<SinistroService>();
builder.Services.AddScoped<RecomendacaoService>();

// Adiciona uporte ao Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura��o do pipeline de requisi��es HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Usa o Swagger e Swagger UI para documenta��o da API
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Mapea as rotas para controllers usando MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
