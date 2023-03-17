using Microsoft.EntityFrameworkCore;
using SudokuSolver.DataAccess;
using SudokuSolver.DataAccess.Repositories;
using SudokuSolver.UserCases;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SudokuSolverDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Injection for ef core Data Store for SQL
builder.Services.AddScoped<ISolutionResultRepository, SolutionResultRepository>();

//Dependency Injection for Use Cases and Repositories
builder.Services.AddTransient<IAddSolutionResultUseCase, AddSolutionResultUseCase>();
builder.Services.AddTransient<IViewSolutionResultUseCase, ViewSolutionResultUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(option => option.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
