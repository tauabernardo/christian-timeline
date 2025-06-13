using HistoryOfChristianity.Infrastructure.Data;
using HistoryOfChristianity.Infrastructure.Repositories;
using HistoryOfChristianity.Application.Services;
using HistoryOfChristianity.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using HistoryOfChristianity.Infrastructure.IoC;
using HistoryOfChristianity.Web.MappingConfig;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddMvc();
builder.Services.AddInfrastructureMVC(builder.Configuration);
builder.Services.AddAutoMapperConfiguration();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
