using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
using SS.DAL;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();

//Nlog configuration
builder.Logging.ClearProviders();
builder.Host.UseNLog();


var logPath = Path.Combine(Directory.GetCurrentDirectory(), "logs");
if (!Directory.Exists(logPath))
{
    Directory.CreateDirectory(logPath);
}

//ConnectionString
builder.Services.AddDbContext<SSDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddScoped<testt>();
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
