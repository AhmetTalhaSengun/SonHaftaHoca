using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SonHaftaHoca.Data;
using SonHaftaHoca.MapperClasses;
using SonHaftaHoca.Repostories;
using SonHaftaHoca.Services.EylemService;
using SonHaftaHoca.Services.KategoriService;
using SonHaftaHoca.Services.LoginService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//For DbContext
string strConn = builder.Configuration.GetConnectionString("ConnStr");
builder.Services.AddDbContext<ToDoDbContext>(x=>x.UseSqlServer(strConn));

//For idetity
builder.Services.AddDefaultIdentity<IdentityUser>(x=>x.SignIn.RequireConfirmedAccount=false)
    .AddEntityFrameworkStores<ToDoDbContext>();

//For AuotoMapper 
builder.Services.AddAutoMapper(typeof(ToDoMapper));

//For repostories
builder.Services.AddTransient<EylemRepostory>();
builder.Services.AddTransient<KategoriRepostory>();

//For services
builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddTransient<IKategoriService, KategoriSevice>();
builder.Services.AddTransient<IEylemService, EylemService>();


var app = builder.Build();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
