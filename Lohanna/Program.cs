var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

app.MapGet("/", () => "Lista de Filmes!");

app.MapPost("/api/Filmes/Cadastrar", ([FromBody] Filme filme,
    [FromServices] AppDataContext ctx) ==> 
{
    ctx.Filmes.Add(filme);
    ctx.SaveChanges();
    return Results.Created("", filme);
});

app.Run();
