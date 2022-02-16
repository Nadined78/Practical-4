var builder = WebApplication.CreateBuilder(args);//this builds/configures our web application

// Add services to the container.
builder.Services.AddControllersWithViews(); 
var app = builder.Build(); //build an mvc application 

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
} // we can ignore this - 

//app.UseHttpsRedirection(); 
//as default, when the app runs, redicect everything to https. we dont want this, as it wont work. so we commented it out.
app.UseStaticFiles(); // want the web server to act like a normal web server and display normal html pages. like our dummy one - always leave this on

app.UseRouting(); //when a request comes in we want a router to work out what it is we want to do and direct the request to the most appropriate controller

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    //configuring the router - if a request comes in, heres how i want you to deal with it, create a controller route and heres the pattern of the route. look for a route with this pattern. default to the home controller if you dont supply. 

app.Run();
