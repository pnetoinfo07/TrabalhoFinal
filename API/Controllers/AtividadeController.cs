using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class AtividadeController : ControllerBase
{
    private readonly AtividadeService _service;
    private readonly IMapper _mapper;
    public AtividadeController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new AtividadeService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-atividade")]
    public void AdicionarAluno(Atividade atividade)
    {
        _service.Adicionar(atividade);
    }
    [HttpGet("listar-pessoa")]
    public List<Atividade> ListarAluno()
    {
        return _service.Listar();
    }
    [HttpPut("editar-pessoa")]
    public void EditarPessoa(Atividade p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-pessoa")]
    public void DeletarPessoa(int id)
    {
        _service.Remover(id);
    }
}
