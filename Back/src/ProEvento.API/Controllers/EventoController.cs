using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoID = 1,
                Tema = "Angular e Teste",
                Local = "Belem",
                Lote = "1",
                QntPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto.png"
                },
            new Evento() {
                EventoID = 2,
                Tema = "Teste e Node",
                Local = "Ananindeua",
                Lote = "2",
                QntPessoas = 350,
                DataEvento = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto1.png"
                },
        };
        public EventoController()
        {

        }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
            return _evento;
        }
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
            return _evento.Where( evento => evento.EventoID == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post01";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com Id: {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com Id: {id}";
        }
    }
}
