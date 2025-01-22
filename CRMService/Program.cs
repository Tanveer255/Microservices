using CRMService;
using CRMService.Entity.Data;
using JwtAuthentication.Interface;
using JwtAuthentication.Models;
using JwtAuthentication.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddDbContext<CRMServiceDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IJwtAuthenticationService, JwtAuthenticationService>();
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
// Add JWT Authentication using IOptions<JwtSettings>
builder.Services.AddAuthentication(auth =>
{
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    // Use IOptions<JwtSettings> to get the settings
    var jwtSettings = builder.Services.BuildServiceProvider().GetRequiredService<IOptions<JwtSettings>>().Value;

    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = jwtSettings.Audience,
        ValidIssuer = jwtSettings.Issuer,
        RequireExpirationTime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey)),
        ValidateIssuerSigningKey = true
    };
});

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

app.UseAuthentication(); // Ensure authentication middleware is before authorization
app.UseAuthorization();  // Authorization middleware

app.MapControllers();

// Map health checks
app.MapHealthChecks("/health");
app.Run();
