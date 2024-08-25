//1. Usings to work with EntityFramework
using Microsoft.EntityFrameworkCore;
using universityBackEnd.Data;

var builder = WebApplication.CreateBuilder(args);


//connectuins With SQL server

const string CONNECTIONNAME = "UniversityDB";

var connetionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3. Add context

builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connetionString));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
