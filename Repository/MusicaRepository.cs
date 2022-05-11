using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudCSharp.Data;
using CrudCSharp.Properties.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudCSharp.Repository
{
    public class MusicaRepository : IMusicaRepository
    {
        private readonly MusicaContext context;

        public MusicaRepository(MusicaContext context)
        {
            this.context = context;
        }
        public void AdicionarMusica(Musica musica)
        {
            this.context.Add(musica);
        }

        public void AtualizaMusica(Musica musica)
        {
            this.context.Update(musica);
        }

        public async Task<Musica> BuscaMusica(int id)
        {
            return await context.Musicas.Where(x => x.Id == id  ).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Musica>> BuscaMusicas()
        {
            return await context.Musicas.ToListAsync();

        }

        public void DeletaMusica(Musica musica)
        {
            this.context.Remove(musica);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }
    }
}