using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudCSharp.Properties.Model;
using CrudCSharp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace crudCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicaController : ControllerBase
    {
        private readonly IMusicaRepository repository;

        public MusicaController(IMusicaRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var musicas = await repository.BuscaMusicas();
            return musicas.Any()
            ? Ok(musicas)
            : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var musica = await repository.BuscaMusica(id);
            return musica != null
            ? Ok(musica)
            : NotFound("não foi possivel encontrar ");
        }

        [HttpPost]

        public async Task<IActionResult> Post(Musica musica)
        {
            this.repository.AdicionarMusica(musica);
            return await this.repository.SaveChangesAsync()
                 ? Ok("Musica Adicionada com sucesso")
                 : BadRequest("Não foi possivel salvar");
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, Musica musica)
        {
            var musicaBanco = await repository.BuscaMusica(id);
            if (musicaBanco == null) return NotFound("Musica Não econtrada");

            musicaBanco.Nome = musica.Nome ?? musicaBanco.Nome;
            musicaBanco.Lancamento = musica.Lancamento != new DateTime()
                ? musica.Lancamento : musicaBanco.Lancamento;

            repository.AtualizaMusica(musicaBanco);

            this.repository.AdicionarMusica(musica);

            return await this.repository.SaveChangesAsync()
                 ? Ok("Musica atualizada com sucesso")
                 : BadRequest("Não foi possivel atualizar");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var musicaBanco = await repository.BuscaMusica(id);
            if (musicaBanco == null) return NotFound("Musica não encontrada");

            repository.DeletaMusica(musicaBanco);

            return await this.repository.SaveChangesAsync()
                 ? Ok("Musica deletada com sucesso")
                 : BadRequest("Não foi possivel Deletar");
        }
    }
}

