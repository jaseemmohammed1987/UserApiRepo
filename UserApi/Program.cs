using Microsoft.EntityFrameworkCore;
using UserApi.Business;
using UserApi.Repository;
using UserApi.Repository.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<UserApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserApiContext") ?? throw new InvalidOperationException("Connection string 'UserApiContext' not found.")));

// Add services to the container.
builder.Services.AddTransient<IUserManager, UserManager>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

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
