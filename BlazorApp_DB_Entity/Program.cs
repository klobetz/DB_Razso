using BlazorApp_DB_Entity.Components;
using BlazorApp_DB_Entity.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//QuickGrid service regisztrálása
builder.Services.AddQuickGridEntityFrameworkAdapter();

//a kapcsolat regisztrálása a koténerbe és a connectionstrin használata kiegészítve egy ellenõrzéssel
// ?? throw new InvalidOperationException
builder.Services.AddDbContext<MySql_DB_Context>(options =>
options.UseMySQL(builder.Configuration.GetConnectionString("BlazorAppDBContext")
    ?? throw new InvalidOperationException("Hiba a betöltés folyamán nincs: BlazorAppDBContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
