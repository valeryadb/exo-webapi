using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;

        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        // GET: api/projetos -> lista todos os projetos
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.Listar());
        }

        // Código novo que completa o CRUD.

        // POST: api/projetos -> cadastra um novo projeto (201 Created)
        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            _projetoRepository.Cadastrar(projeto);
            return StatusCode(201);
        }

        // GET: api/projetos/4 -> busca um projeto pelo id (404 se não existir)
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Projeto projeto = _projetoRepository.BuscarporId(id);
            if (projeto == null)
            {
                return NotFound();
            }
            return Ok(projeto);
        }

        // PUT: api/projetos/4 -> atualiza um projeto (204 No Content, ou 404 se não existir)
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Projeto projeto)
        {
            if (_projetoRepository.BuscarporId(id) == null)
            {
                return NotFound();
            }
            _projetoRepository.Atualizar(id, projeto);
            return StatusCode(204);
        }

        // DELETE: api/projetos/4 -> remove um projeto (204 No Content, ou 404 se não existir)
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                if (_projetoRepository.BuscarporId(id) == null)
                {
                    return NotFound();
                }
                _projetoRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
