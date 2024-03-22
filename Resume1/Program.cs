using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Resume1.AppContext;
//using Resume1.Controllers;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ResumeContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("ResumeDb")));  

//builder.Services.AddScoped<IUnitOfWork, ResumeContext>(); 
//builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
var app = builder.Build();
//builder.Services.AddScoped<IPersonRepository, PersonRepository>(); 
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
