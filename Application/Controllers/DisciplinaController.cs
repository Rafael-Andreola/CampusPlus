using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    
    public class DisciplinaController : Controller
    {
        private readonly ILogger<DisciplinaController> logger;
        private readonly IDisciplinaService disciplinaService;

        public DisciplinaController(ILogger<DisciplinaController> _logger, IDisciplinaService _disciplinaService)
        {
            logger = _logger;
            disciplinaService = _disciplinaService;
        }
    }
}
