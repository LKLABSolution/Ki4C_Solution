using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//add Service to the container



//MySQL Connection localhost:3306 db:ki4c_dx



string connectionString = "server=localhost;port=3306;database=ki4c_dx;user=root;password=password;";

builder.Services.AddDbContext<DbContext>(options =>
    options.UseMySQL(connectionString));





var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
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

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Controllers / Common / Auth / AuthController.cs
app.MapControllerRoute(
    name: "CommonAuth",
    pattern: "Common/Auth/{controller=CommonAuth}/{action=Login}/{id?}");

app.MapControllerRoute(
    name: "CommonMember",
    pattern: "Common/Member/{controller=CommonMember}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "CommonCompany",
    pattern: "Common/Company/{controller=CommonCompany}/{action=Index}/{id?}");

//Controllers / Common / Auth / AuthController.cs
app.MapControllerRoute(
    name: "Common",
    pattern: "Common/{controller=Common}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "ManagerMember",
    pattern: "Manager/Member/{controller=ManagerMember}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Manager",
    pattern: "Manager/{controller=Manager}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "MemberMypage",
    pattern: "Member/Mypage/{controller=MemberMypage}/{action=Index}/{id?}");



app.Run();
