var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    string secret = Environment.GetEnvironmentVariable("very_secret_setting");
    if (string.IsNullOrEmpty(secret)) {
        return Results.BadRequest("very_secret_setting not set");
    }
    return Results.Ok(secret);
});

app.Run();
