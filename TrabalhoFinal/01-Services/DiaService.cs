using TrabalhoFinal._02_Repository;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Services
{
    public class DiaService
    {
        public DiaRepository repository { get; set; }
        public DiaService(string _config)
        {
            repository = new DiaRepository(_config);
        }
        public void Adicionar()
        {
            repository.Adicionar();
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Dia> Listar()
        {
            return repository.Listar();
        }
    }
}
