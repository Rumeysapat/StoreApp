using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options=>options.UseSqlite(builder.Configuration.GetConnectionString("SqlConnection")));


var app = builder.Build();



app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.UseRouting();
app.UseHttpsRedirection();


app.Run();
