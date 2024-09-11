using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades.DTOs;
using TrabalhoFinal._03_Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RotinaController : ControllerBase
    {
        private readonly RotinaService _service;
        private readonly IMapper _mapper;
        public RotinaController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new RotinaService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-rotina")]
        public void AdicionarAluno(Rotina rotina)
        {
            //Pessoa pessoa = _mapper.Map<Pessoa>(pessoaDTO);
            _service.Adicionar(rotina);
        }
        [HttpGet("listar-rotina")]
        public List<Rotina> ListarAluno()
        {
            return _service.Listar();
        }
        [HttpPut("editar-rotina")]
        public void EditarPessoa(Rotina p)
        {
            _service.Editar(p);
        }
        [HttpDelete("deletar-rotina")]
        public void DeletarPessoa(int id)
        {
            _service.Remover(id);
        }

    }
}
