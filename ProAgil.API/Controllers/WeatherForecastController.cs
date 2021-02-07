using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.API.Model;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[]{ 
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("ddd/MM/yyy")
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular e novidades",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("ddd/MM/yyy")
                }
            };
        }
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id){
            return new Evento[]{ 
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("ddd/MM/yyy")
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular e novidades",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("ddd/MM/yyy")
                }
            }.FirstOrDefault(x => x.EventoId == id);

        }
    }
}
