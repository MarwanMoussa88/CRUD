using API.ServiceExtensions;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);
//Our own presentation layer so we can limit what dependencies can be injected in the presentation layer
//since all the depenencies have to be injected in the webapi for dependency injection 
builder.Services.AddControllers().AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureCors();
builder.Services.ConfigureRepositories();
builder.Services.ConfigureServices();
builder.Services.ConfigureHumanCapitalContext(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
else
    //to use Https 
    app.UseHsts();

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();
app.MapControllers();
app.Run();
