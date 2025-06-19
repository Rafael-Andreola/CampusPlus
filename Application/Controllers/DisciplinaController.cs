using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class DisciplinaController : Controller
    {
        private readonly ILogger<DisciplinaController> _logger;

        public DisciplinaController(ILogger<DisciplinaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ContratarDisciplina(string alunoId string disciplinaId)
        {


            return;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
