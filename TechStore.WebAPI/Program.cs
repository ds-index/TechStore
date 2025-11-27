using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using TechStore.Application;
using TechStore.Infrastructure;
using TechStore.Infrastructure.Identity;
using TechStore.WebAPI.Auth;

var builder = WebApplication.CreateBuilder(args);

var jwtSettings = builder.Configuration.GetSection("Jwt");

builder.Services.AddControllers();

builder.Services.AddDataProtection();

builder.Services.AddOpenApi();

builder.Services.AddApplicationService();

builder.Services.AddInfrastructureService(builder.Configuration);

var logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File("Logs/Logs.txt",
        rollingInterval: RollingInterval.Day,
        shared: true,
        flushToDiskInterval: TimeSpan.FromSeconds(2))
    .CreateLogger();


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                System.Text.Encoding.UTF8.GetBytes(jwtSettings["Key"] ??
                throw new KeyNotFoundException("Not found Jwt key!")))
        };
    });


builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IJwtRepository, JwtRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.UseSwagger();
    app.UseSwaggerUI();
}

using var scope = app.Services.CreateScope();
var service = scope.ServiceProvider;

RoleSeed.RoleSeedAsync(service).Wait();
UserSeed.UserSeedAsync(service).Wait();

app.UseHttpsRedirection();

app.MapSwagger();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();