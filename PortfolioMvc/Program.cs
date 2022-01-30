using PortfolioMvc.Services;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços no container DI
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IProjetosService, ProjetosService>();
builder.Services.AddTransient<IEmailService, EmailService>();


var app = builder.Build();

// Configura o pipeline do request HTTP
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
