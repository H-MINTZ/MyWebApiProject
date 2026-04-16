using Microsoft.EntityFrameworkCore;
using MyWebApiProject.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//גישה מהיכן לקחת את מסד הנתונים
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddEndpointsApiExplorer();
//גישה לSWAGGER
builder.Services.AddSwaggerGen();
//יצירת קונטרולרים
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Middleware
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();


