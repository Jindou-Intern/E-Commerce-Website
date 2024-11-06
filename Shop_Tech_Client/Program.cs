using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shop_Tech_Client;
using Shop_Tech_Client.Services;
using Shop_Tech_Shared_Library.Contracts;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF1cWWhBYVF+WmFZfVpgcF9DY1ZTRWYuP1ZhSXxXdk1hWH9adXdXR2FZUEQ=");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IProduct, ClientServices>();

builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();
