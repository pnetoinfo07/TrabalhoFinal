using TrabalhoFinal._02_Repository.Data;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Services;

public class RotinaService
{
    public RotinaRepository repository { get; set; }
    public RotinaService(string _config)
    {
        repository = new RotinaRepository(_config);
    }
    public void Adicionar(Rotina rotina)
    {
        repository.Adicionar(rotina);
    }
    public void Remover(int id)
    {
        repository.Remover(id);
    }
    public List<Rotina> Listar()
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
