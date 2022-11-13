using EstacionamentoCode.Infra.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstacionamentoCode.Mvc.Controllers
{
    //[Route("[controller]/[action]/[id]")]
    public class EstacionamentoController : Controller
    {
        private readonly Context _contexto;
        private readonly ILogger<EstacionamentoController> _logger;

        public EstacionamentoController(ILogger<EstacionamentoController> logger, Context context)
        {
            _logger = logger;
            _contexto = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var estacionamentos = _contexto.Estacionamentos.Include(o => o.Vagas).ThenInclude(p => p.Veiculo).ToList();
            return View(estacionamentos);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var estacionamento = _contexto.Estacionamentos.Find(id);
            return View(estacionamento);
        }

        [HttpPut]
        public IActionResult Edit(int id)
        {
            var estacionamento = _contexto.Estacionamentos.Find(id);
            return View(estacionamento);
        }
    }
}
