using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using institute.Data;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Using local storage for student
builder.Services.AddDbContext<StudentDbContext>(opt =>
opt.UseInMemoryDatabase("Data"));

// Using local storage for teacher
builder.Services.AddDbContext<TeacherDbContext>(opt =>
opt.UseInMemoryDatabase("Data"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

string connectionString = $"server=127.0.0.1;Port=3306;uid = root; pwd = root; database = mydata";

MySqlConnection connObj = new MySqlConnection(connectionString);

connObj.Open();

string query = "select * from students";
Console.WriteLine(query);
MySqlCommand cmd = new MySqlCommand(query, connObj);


MySqlDataReader reader = cmd.ExecuteReader();

while (reader.Read())
{
    object[] a = new object[5];
    reader.GetValues(a);
    for(int i = 0;i< a.Length;i++)
    {
        Trace.WriteLine(a[i].ToString());
    }
}


    
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
