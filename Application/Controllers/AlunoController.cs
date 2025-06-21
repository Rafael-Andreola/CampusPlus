using Domain.Interfaces.Services;
using Domain.Repositories;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> logger;
        private readonly IAlunoService alunoService;

        public AlunoController(ILogger<AlunoController> _logger, IAlunoService _alunoService)
        {
            logger = _logger;
            alunoService = _alunoService;
        }

        [HttpGet]
        public IActionResult ContratarDisciplina(string alunoId, string disciplinaId)
        {
            alunoService.Contratar(alunoId, disciplinaId);
            return Ok(true);
        }
    }
}
