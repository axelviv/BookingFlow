using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SpaceService.Application.Handlers.Spaces;
using SpaceService.Application.Interfaces;
using SpaceService.Application.Validators;
using SpaceService.Infrastructure.Persistence;
using SpaceService.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add Services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<SpaceDbContext>(Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Validators
builder.Services.AddValidatorsFromAssemblyContaining<CreateSpaceRequestValidator>();
// Repositorios
builder.Services.AddScoped<ISpaceRepository, SpaceRepository>();
// Handlers
builder.Services.AddScoped<CreateSpaceHandler>();


var app = builder.Build();

// Configure HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();