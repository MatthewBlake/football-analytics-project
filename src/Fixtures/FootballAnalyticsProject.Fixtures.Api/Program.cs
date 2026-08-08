using FootballAnalyticsProject.Fixtures.Api.Contracts.Players;
using FootballAnalyticsProject.Fixtures.Api.Contracts.Teams;
using FootballAnalyticsProject.Fixtures.Api.Contracts.Fixtures;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<TeamStore>();
builder.Services.AddSingleton<PlayerStore>();
builder.Services.AddSingleton<FixtureStore>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy
                .WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseCors("AllowAngular");
app.MapControllers();

app.Run();
