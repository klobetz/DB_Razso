using BlazorApp_DB_Entity.Components;
using BlazorApp_DB_Entity.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//QuickGrid service regisztr�l�sa
builder.Services.AddQuickGridEntityFrameworkAdapter();

//a kapcsolat regisztr�l�sa a kot�nerbe �s a connectionstrin haszn�lata kieg�sz�tve egy ellen�rz�ssel
// ?? throw new InvalidOperationException
builder.Services.AddDbContext<MySql_DB_Context>(options =>
options.UseMySQL(builder.Configuration.GetConnectionString("BlazorAppDBContext")
    ?? throw new InvalidOperationException("Hiba a bet�lt�s folyam�n nincs: BlazorAppDBContext")));

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
