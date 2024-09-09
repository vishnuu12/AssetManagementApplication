using BLL;
using BLL.Interface;
using BLL.InterfaceBLL;
using DAL;
using DAL.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//BLL
builder.Services.AddScoped<IAssetBLL, AssetBll>();

//DAL
builder.Services.AddScoped<IAssetDAL, AssetDal>();

builder.Services.AddScoped<IEmployeeDAL, EmployeeDAL>();

builder.Services.AddScoped<IEmployeeBLL, EmployeeBLL>();




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
