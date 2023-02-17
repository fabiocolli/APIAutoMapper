using AutoMapper.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper.Controllers
{
    [ApiController]
    [Route("api/Carros")]
    public class CarrosController : ControllerBase
    {
        private readonly IMapper _mapper;
        public CarrosController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult PegaTodosCarros()
        {
            return Ok();
        }

        [HttpGet("{id:int}")]
        public ActionResult PegarCarroPeloID(int id)
        {
            return Ok();
        }

        [HttpPost]
        public SaidaDeDadosCarro SalvarCarro(EntradaDadosCarro modelo)
        {
            var carro = _mapper.Map<Carro>(modelo);

            return _mapper.Map<SaidaDeDadosCarro>(carro);
        }
    }
}
