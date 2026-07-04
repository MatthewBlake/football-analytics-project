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

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
