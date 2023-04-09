using System.Collections.Generic;
using System.Linq;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public List<Evento> _eventos = new List<Evento> 
        {
            new Evento {EventoId = 1},
            new Evento {EventoId = 2},
        };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Teste Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Teste Put com id: {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Teste Delete com id: {id}";
        }
    }
}
