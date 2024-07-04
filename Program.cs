using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using WebBase.Data;
using WebBase.Interfaces;
using WebBase.Mappings;
using WebBase.Rest;
using WebBase.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebBaseContext") ?? throw new InvalidOperationException("Connection string 'WebBaseContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
//builder.Services.AddSingleton<IBancoService, BancoService>();
builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>();
//builder.Services.AddScoped<IEnderecoService, EnderecoService>();
builder.Services.AddAutoMapper(typeof(EnderecoMapping));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
