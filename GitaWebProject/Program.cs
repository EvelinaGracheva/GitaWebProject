using GitaWebProject.Data;
using GitaWebProject.Interfaces;
using GitaWebProject.Mapping;
using GitaWebProject.Services;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;


Log.Logger = new LoggerConfiguration()
               .WriteTo.Async(a => a.File("Logs/log-.txt", rollingInterval: RollingInterval.Day))
               .WriteTo.Console()
               .MinimumLevel.Information()
               .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
               .Enrich.FromLogContext()
               .CreateLogger();

Log.Information("Application Started");

var builder = WebApplication.CreateBuilder(args);

Host.CreateDefaultBuilder(args)
               .UseSerilog();


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "GitaWebProject", Version = "v1" });
});

builder.Services.AddResponseCaching();
builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();
builder.Services.AddTransient<IActionContextAccessor, ActionContextAccessor>();

builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IDeleteProductService, DeleteProductService>();
builder.Services.AddTransient<IUserChangesService, UserChangesService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseDeveloperExceptionPage();
app.UseMigrationsEndPoint();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gita Web Project"));

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
