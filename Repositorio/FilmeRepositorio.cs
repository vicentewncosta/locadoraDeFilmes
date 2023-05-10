using locadora.Data;
using locadora.Models;

namespace locadora.Repositorio
{
    public class FilmeRepositorio : IFilmeRepositorio
    {   
        private readonly BancoContext _bancoContext;
        public FilmeRepositorio(BancoContext bancoContext)
        {   
            _bancoContext = bancoContext;
        }
        public FilmeModel Adicionar(FilmeModel filme)
        {
            //Gravar no banco de dados
            _bancoContext.Filmes.Add(filme);
            _bancoContext.SaveChanges();
            return filme;
        }
    }

}
