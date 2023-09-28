using GestionEventosAcademicos.API.Data;
using GestionEventosAcademicos.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace GestionEventosAcademicos.API.Controllers
{


    [ApiController]
    [Route("/api/EventoAcademico")]
    public class EventoAcademicoController : Controller
    {

        private readonly DataContext _Context;
        public EventoAcademicoController(DataContext context)
        {
            _Context = context;
        }


        [HttpGet]
        public async Task<ActionResult> get()
        {
            return Ok(await _Context.evento_academico.ToListAsync());
        }

        //get por parametro----id
        [HttpGet("{IdEvento:int}")]
        public async Task<ActionResult> Get(int idEvento)
        {
            var eventoAcademico = await _Context.evento_academico.FirstOrDefaultAsync(c => c.IdEvento == idEvento);
            if (eventoAcademico == null)
            {
                return NotFound();//404
            }
            else
            {
                return Ok(eventoAcademico);//200
            }

        }
        //INSERTAR REGISTROS
        [HttpPost]
        public async Task<ActionResult> Post(EventoAcademico eventoAcademico)
        {
            _Context.Add(eventoAcademico);
            await _Context.SaveChangesAsync();
            return Ok(eventoAcademico);//200
        }
        [HttpPut]
        public async Task<ActionResult> Put(EventoAcademico eventoAcademico)
        {
            _Context.Update(eventoAcademico);
            await _Context.SaveChangesAsync();
            return Ok(eventoAcademico);
        }
        [HttpDelete("{IdEvento:int}")]
        public async Task<ActionResult> Delete(int idEvento)
        {
            var filaafectada = await _Context.evento_academico.Where(c => c.IdEvento == idEvento).ExecuteDeleteAsync();
            if (filaafectada == 0)
            {
                return NotFound();//404

            }
            return NoContent();//204

        }
    }
}
