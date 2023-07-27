using ALFASOFT.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();


var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
var connection = builder.Configuration["ConnectionString:MariaDB"];

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connection, serverVersion ?? throw new InvalidOperationException("Connection string 'MariaDB' not found.")));


builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

builder.Services.AddMvc().AddRazorPagesOptions(options =>
{
    options.RootDirectory = "/Views/ContatoViews";
}).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
