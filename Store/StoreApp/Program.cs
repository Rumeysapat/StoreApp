using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqlConnection"), b => b.MigrationsAssembly("StoreApp")));
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();

builder.Services.AddScoped<IServiceManager,ServiceManager>();
builder.Services.AddScoped<IProductService,ProductManager>();
builder.Services.AddScoped<ICategoryService,CategorManager>();






var app = builder.Build();
app.UseStaticFiles();




app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.UseRouting();
app.UseHttpsRedirection();



app.Run();
