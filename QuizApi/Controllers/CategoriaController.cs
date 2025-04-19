using LogicQuiz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly string StringConnection;
        public CategoriaController(IConfiguration config)
        {
            // Fix for CS8601: Use null-coalescing operator to provide a fallback value
            StringConnection = config.GetConnectionString("dbCon") ?? throw new ArgumentNullException(nameof(config), "Connection string 'dbCon' is not configured.");
        }
        [HttpGet]
        public async Task<IActionResult> ListCategoria()
        {
            CategoriaLogic catLogic = new CategoriaLogic(StringConnection);
            var respuesta = await catLogic.GetAllCategorias();
            return Ok(respuesta);
        }
    }
}
