using PS.MelonRestaurant.Web;
using PS.MelonRestaurant.Web.Services;
using PS.MelonRestaurant.Web.Services.IServices;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

SD.ProductAPIBase = builder.Configuration["ServiceUrls:ProductAPI"];

builder.Services.AddHttpClient<IProductService, ProductService>();
builder.Services.AddScoped<IProductService, ProductService>();

//Add Localization
//--------------------------------------------------------------------------------
RequestLocalizationOptions localizationOptions = new RequestLocalizationOptions();

builder.Services.AddLocalization();
var supportedCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("es-ES")
            };
localizationOptions.SupportedCultures = supportedCultures;
localizationOptions.SupportedUICultures = supportedCultures;
localizationOptions.SetDefaultCulture("en-US");
localizationOptions.ApplyCurrentCultureToResponseHeaders = true;
//--------------------------------------------------------------------------------

builder.Services.AddControllersWithViews();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseRequestLocalization(localizationOptions);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
