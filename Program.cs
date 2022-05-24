using BlazoriseTopHeaderSample;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services
    .SetupBlazorise()
    .AddBulmaProviders()
    .AddFontAwesomeIcons();

builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
