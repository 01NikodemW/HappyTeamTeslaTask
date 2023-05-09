using System.Text;
using System.Text.Json.Serialization;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TeslaRentalBackend;
using TeslaRentalBackend.Entities;
using TeslaRentalBackend.Models.Request;
using TeslaRentalBackend.Models.Request.Validators;
using TeslaRentalBackend.Services;

var builder = WebApplication.CreateBuilder(args);


var authenticationSettings = new AuthenticationSettings();
builder.Configuration.GetSection(AuthenticationSettings.SectionName).Bind(authenticationSettings);
builder.Services.Configure<AuthenticationSettings>(builder.Configuration.GetSection(AuthenticationSettings.SectionName));

builder.Services.AddControllers().AddJsonOptions(opts =>
{
    var enumConverter = new JsonStringEnumConverter();
    opts.JsonSerializerOptions.Converters.Add(enumConverter);
});


builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = "Bearer";
    option.DefaultScheme = "Bearer";
    option.DefaultChallengeScheme = "Bearer";
}).AddJwtBearer(cfg =>
{
    cfg.RequireHttpsMetadata = false;
    cfg.SaveToken = true;
    cfg.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = authenticationSettings.JwtIssuer,
        ValidAudience = authenticationSettings.JwtIssuer,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey)),
    };
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
builder.Services.AddScoped<IValidator<LoginRequestDto>, LoginRequestDtoValidator>();
builder.Services.AddScoped<IValidator<RegisterRequestDto>, RegisterRequestDtoValidator>();
builder.Services.AddScoped<IValidator<AvailableVehiclesRequestDto>, AvailableVehiclesRequestDtoValidator>();


builder.Services.AddDbContext<TeslaRentalDbContext>
    (options => {
        options.UseSqlServer(builder.Configuration.GetConnectionString("TeslaRentalDbConnection"));
    });



var app = builder.Build();

Thread.Sleep(15_000);
var provider = builder.Services.BuildServiceProvider();
using(var scope = provider.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<TeslaRentalDbContext>();
    db.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"));

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();