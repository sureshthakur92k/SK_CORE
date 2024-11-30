using Microsoft.EntityFrameworkCore;
using SK_CORE.Models;

//This is default give
//var builder = WebApplication.CreateBuilder(args);

//This is i created
var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
   // ApplicationName = "SureshKumarThakur",
    WebRootPath= "MyWebRoot"
});

// Add services to the container.
builder.Services.AddControllersWithViews();
//Registering Connection String Start
var provider=builder.Services.BuildServiceProvider();
var config=provider.GetService<IConfiguration>();
builder.Services.AddDbContext<EmployeeDBContext>(item => item.UseSqlServer(config.GetConnectionString("dbcs")));
//Registering Connection String End

//for SESSION
//builder.Services.AddSession();
builder.Services.AddSession( options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
//app.Map("/Home", () => "Hiii...");
app.UseStaticFiles();
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

//app.MapDefaultControllerRoute();
//app.MapControllers();


app.Run();
