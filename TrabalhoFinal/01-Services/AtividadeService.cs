using TrabalhoFinal._02_Repository;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Services;

public class AtividadeService
{
    public AtividadeRepository repository { get; set; }
    public AtividadeService(string _config)
    {
        repository = new AtividadeRepository(_config);
    }
    public void Adicionar(Atividade atividade)
    {
        repository.Adicionar(atividade);
    }

    public void Remover(int id)
    {
        repository.Remover(id);
    }

    public List<Atividade> Listar()
    {
        return repository.Listar();
    }
    public Atividade BuscarTimePorId(int id)
    {
        return repository.BuscarPorId(id);
    }
    public void Editar(Atividade editAtividade)
    {
        repository.Editar(editAtividade);
    }
}
