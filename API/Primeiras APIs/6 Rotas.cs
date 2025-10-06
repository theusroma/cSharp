var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//primeira rota                             http://localhost:5271/
app.MapGet("/", () => "oi gente essaaaa eh minha primeira rota");

//saudacao                                  http://localhost:5271/Saudacao
app.MapGet("/Saudacao", () => "Olá, seja bem-vindo");

//data e hora                               http://localhost:5271/DataHora
app.MapGet("/DataHora", () => DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

//saudacao com nome                         http://localhost:5271/Saudacao/matheus
app.MapGet("/Saudacao/{nome}", (string nome) => $"Olá, {nome}! Seja bem-vindo(a).");

//texto motivacional                        http://localhost:5271/TextoMotivacional
app.MapGet("/TextoMotivacional", () => "Confie sempre em si mesmo");

//valor numerico                            http://localhost:5271/ValorNumerico/5
app.MapGet("/ValorNumerico/{num}", (int num) => $"O dobro de {num} é {num * 2}");

//mensagem personalizada                    http://localhost:5271/Boasvindas?nome=Matheus&cidade=Curitiba
app.MapGet("/Boasvindas", (string nome, string cidade) =>
{
    if (string.IsNullOrEmpty(cidade))
    {
        return $"Boas-vindas, {nome}!";
    }
    else
    {
        return $"Boas-vindas, {nome} de {cidade}!";
    }
});

app.Run();
