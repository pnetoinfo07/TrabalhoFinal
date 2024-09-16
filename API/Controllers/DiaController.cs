using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiaController:ControllerBase
    {
        private readonly DiaService _service;
        private readonly IMapper _mapper;
        public DiaController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new DiaService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-dia")]
        public void AdicionarAluno()
        {
            _service.Adicionar();
        }
        [HttpGet("listar-dia")]
        public List<Dia> ListarAluno()
        {
            return _service.Listar();
        }
        [HttpDelete("deletar-dia")]
        public void DeletarPessoa()
        {
            _service.Remover();
        }

    }
}
