using Microsoft.EntityFrameworkCore;
using Resume.Application;
using Resume.Core.Models;
using Resume.Repository.Repository;
using Resume.Service;
using Resume1.AppContext;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ResumeContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("ResumeDb")));


builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IPersonService,PersonService>();
builder.Services.AddScoped<IJobService,JobService>();
builder.Services.AddScoped<ILanguageService,LanguageService>();




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
