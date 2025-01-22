using DocsServer.Entity.Data;
using Microsoft.EntityFrameworkCore;
using SWANService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SWANServiceDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//services collection extenshion
builder.Services.AddAllCustomServices();
// Register health checks and provide the MySQL connection string
builder.Services.AddHealthChecks()
    .AddCheck("sqlserver_health_check",
    new SqlServerHealthCheck(builder.Configuration.GetConnectionString("DefaultConnection")));


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
// Map health checks
app.MapHealthChecks("/health");
app.Run();
