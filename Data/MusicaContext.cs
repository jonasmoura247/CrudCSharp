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
        public DbSet<Musica> Musicas {get; set;} 
    }
        



}
