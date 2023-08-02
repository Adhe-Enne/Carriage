/*
    feat: Una nueva característica para el usuario.
    fix: Arregla un bug que afecta al usuario.
    perf: Cambios que mejoran el rendimiento del sitio.
    build: Cambios en el sistema de build, tareas de despliegue o instalación.
    ci: Cambios en la integración continua.
    docs: Cambios en la documentación.
    refactor: Refactorización del código como cambios de nombre de variables o funciones.
    style: Cambios de formato, tabulaciones, espacios o puntos y coma, etc; no afectan al usuario.
    test: Añade tests o refactoriza uno existente.
 */



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthorization();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

if (app.Environment.IsDevelopment())
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
