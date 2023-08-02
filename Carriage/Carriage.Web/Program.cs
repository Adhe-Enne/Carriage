/*
    feat: Una nueva caracter�stica para el usuario.
    fix: Arregla un bug que afecta al usuario.
    perf: Cambios que mejoran el rendimiento del sitio.
    build: Cambios en el sistema de build, tareas de despliegue o instalaci�n.
    ci: Cambios en la integraci�n continua.
    docs: Cambios en la documentaci�n.
    refactor: Refactorizaci�n del c�digo como cambios de nombre de variables o funciones.
    style: Cambios de formato, tabulaciones, espacios o puntos y coma, etc; no afectan al usuario.
    test: A�ade tests o refactoriza uno existente.
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
