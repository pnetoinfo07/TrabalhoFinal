using AutoMapper;
using TrabalhoFinal._02_Repository.Data;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOs;

namespace TrabalhoFinal._01_Services;

public class RotinaService
{
    public RotinaRepository repository { get; set; }
    public RotinaService(string _config, IMapper mapper)
    {
        repository = new RotinaRepository(_config, mapper);
    }
    public void Adicionar(Rotina rotina)
    {
        repository.Adicionar(rotina);
    }
    public void Remover(int id)
    {
        repository.Remover(id);
    }
    public List<ReadRotinaDTO> Listar()
    {
        return repository.Listar();
    }
    public Rotina BuscarTimePorId(int id)
    {
        return repository.BuscarPorId(id);
    }
    public void Editar(Rotina editRotina)
    {
        repository.Editar(editRotina);
    }
}
