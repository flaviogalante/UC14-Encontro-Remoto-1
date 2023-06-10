using Chapter16.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter16.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository) 
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult ListarC()
        {
            try
            {
                return Ok(_livroRepository.ListarR);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }   
        
    }
}
