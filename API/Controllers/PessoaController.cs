using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOs;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    private readonly PessoaService _service;
    private readonly IMapper _mapper;
    public PessoaController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new PessoaService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-pessoa")]
    public void AdicionarAluno(CreatePessoaDTO pessoaDTO)
    {
        Pessoa pessoa = _mapper.Map<Pessoa>(pessoaDTO);
        _service.Adicionar(pessoa);
    }
    [HttpGet("listar-pessoa")]
    public List<Pessoa> ListarAluno()
    {
        return _service.Listar();
    }
    [HttpPut("editar-pessoa")]
    public void EditarPessoa(int id, Pessoa p)
    {
        _service.Editar(id, p);
    }
    [HttpDelete("deletar-pessoa")]
    public void DeletarPessoa(int id)
    {
        _service.Remover(id);
    }
}
