using TaskManager.API.ServiceExtensions;
using TaskManager.Core.ExternalServices;
using TaskManager.Core.Interfaces;
using TaskManager.Core.Repositories;
using TaskManager.Core.ServiceExtensions;
using TaskManager.Core.Services;
using TaskManager.Core.Utilities.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddHttpClient<IHttpClientCommandHandler, HttpClientCommandHandler>();
builder.Services.AddTransient<IHttpClientCommandHandler, HttpClientCommandHandler>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<ITaskService, TaskService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
}
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskManager API V1");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();
