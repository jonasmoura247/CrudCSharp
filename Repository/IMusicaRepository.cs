using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudCSharp.Properties.Model;

namespace CrudCSharp.Repository
{
    public interface IMusicaRepository
    {
        Task<IEnumerable<Musica>> BuscaMusicas();

        Task<Musica> BuscaMusica(int id);

        void AdicionarMusica(Musica musica);

        void AtualizaMusica(Musica musica);

        void DeletaMusica(Musica musica);

        Task<bool> SaveChangesAsync();
        
    }
}