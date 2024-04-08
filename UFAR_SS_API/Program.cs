using Microsoft.EntityFrameworkCore;
using UFAR_SS_Core.Services.Author;
using UFAR_SS_Core.Services.Item;
using UFAR_SS_Core.Services.Style;
using UFAR_SS_Data.DAO;

var builder = WebApplication.CreateBuilder(args);

/* Add services to the container.
  This line adds support for controllers. */
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//This line adds support for API endpoint exploration using Swagger/OpenAPI.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* This line adds a DbContext to the services container.
 It configures the DbContext to use SQL Server with a connection string retrieved from the configuration.*/
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MainDB")));

/*These lines add scoped services to the container.
Scoped services are created once per request within the scope.
They are disposed of when the scope is disposed.
This helps maintain state across multiple calls during the same request.*/
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<iItemService, ItemService>();
builder.Services.AddScoped<IStyleServices, StyleServices>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
