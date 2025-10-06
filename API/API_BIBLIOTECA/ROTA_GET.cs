using LIVROAPI.Models;

namespace LIVROAPI.Routes;

public static class ROTA_GET
{
    public static void MapGetRoutes(this WebApplication app)
    {
        List<Livro> livros = new List<Livro>
        {
            new Livro {Id = 1, titulo = "Dom casmurro", autor = "Machado de Assis", ano = 1899},
            new Livro {Id = 2, titulo = "1984", autor = "George Owell", ano = 1949}
        };

        app.MapGet("/", () => "API de livros em funcionamento");
        app.MapGet("/api/livros", () => livros);
        app.MapGet("/api/livros/{id}", (int id) =>
        {
            var livro = livros.FirstOrDefault(l => l.Id == id);
            return livro != null ? Results.Ok(livro) : Results.NotFound("Livro não encontrado");
        });




    }


}


