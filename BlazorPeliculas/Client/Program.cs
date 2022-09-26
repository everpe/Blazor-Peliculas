using BlazorPeliculas.Client;
using BlazorPeliculas.Client.Repositorios;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using static BlazorPeliculas.Client.Servicios;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });



ConfigureServices(builder.Services);
await builder.Build().RunAsync();




//Inyección de Servicios
static void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<ServicioSingleton>();
    services.AddTransient<ServicioTransient>();
    services.AddSingleton<IRepositorio, Repositorio>();
}