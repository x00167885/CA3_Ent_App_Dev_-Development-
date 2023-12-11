using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

/* Chosen API Import (Pexels) */
using PexelsDotNetSDK.Api;

/*Blazorise Imports*/
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

namespace CA3_X00167885
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }) ;
            ///////////////////////////////////////////////////////////////////

            // Adding the PexelsClient to the service collection for accessing throughout application.
            builder.Services.AddSingleton<PexelsClient>(s => new PexelsClient("w2JPmihnasURl4O3WxMhOdIVKU6f6tRgBPG39Oh0prLQFOiHErW5DRrA"));

            // Adding my 'Like Photo' service as a singleton.
            builder.Services.AddSingleton<LikePhotoService>();

            // Adding my 'Store Photos' service as a singleton.
            builder.Services.AddSingleton<StoredPhotosService>();

            // Adding my 'Like Video' service as a singleton.
            builder.Services.AddSingleton<LikeVideoService>();

            // Adding my 'Store Videos' service as a singleton.
            builder.Services.AddSingleton<StoredVideosService>();

            // Getting Blazorrise Components Ready.
            builder.Services.AddBlazorise(options =>{options.Immediate = true;}).AddBootstrapProviders().AddFontAwesomeIcons();

            // Adding Http Client to the project.
            builder.Services.AddHttpClient();

            /* Finally Building the application within the browser*/
            await builder.Build().RunAsync();
        }
    }
}
