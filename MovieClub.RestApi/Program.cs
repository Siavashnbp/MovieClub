using Microsoft.EntityFrameworkCore;
using MovieClub.Contracts.Interfaces;
using MovieClub.Persistence.EF;
using MovieClub.Persistence.EF.Genres;
using MovieClub.Services.Genres;
using MovieClub.Services.Genres.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<EFDataContext>(
    options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<UnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<GenreServices, GenreAppServices>();
builder.Services.AddScoped<GenreRepository, EFGenreRepository>();

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
