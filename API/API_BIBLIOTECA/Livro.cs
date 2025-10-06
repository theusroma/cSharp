//NAMESPACE Agrupa e organiza o código, evitando que nomes de classes se misturem.  (Uma pasta ou sobrenome.)
namespace LIVROAPI.Models
{

//CLASSS É o molde que define os dados e as ações de um objeto (Uma planta de construção.)
    public class Livro
    {
        public string autor { get; set; }

        public string titulo { get; set; }

        public string local { get; set; }

        public int ano { get; set; }

        public int Id { get; set; }

    }


}