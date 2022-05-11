using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudCSharp.Properties.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudCSharp.Data
{
    public class MusicaContext : DbContext

    {
        public MusicaContext(DbContextOptions<MusicaContext> options) : base(options)
        {
        }
        public DbSet<Musica> Musicas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           var musica = modelBuilder.Entity<Musica>();
            musica.ToTable("tb_musica");
            musica.HasKey(x => x.Id);
            musica.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            musica.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            musica.Property(x => x.Lancamento).HasColumnName("data_lancamento").IsRequired();

        }
    }

}
