using Forfeit15.Postgres.Extensions;
using System.Text.Json.Serialization;
using Forfeit15.Auth.Core.Profiles;
using Forfeit15.Auth.Database.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddUserMetaDataPostgres(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(UserMetaDataProfile));

builder.Services
    .AddControllers().AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

var app = builder.Build();
//LOGGING

//SWAGGER
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.MigrateDatabases();
app.MapControllers();
app.Run();