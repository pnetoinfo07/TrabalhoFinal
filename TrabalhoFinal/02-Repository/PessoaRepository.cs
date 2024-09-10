using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository;

public class PessoaRepository
{
    private readonly string ConnectionString;
    public PessoaRepository(string connectioString)
    {
        ConnectionString = connectioString;
    }
    public void Adicionar(Pessoa pessoa)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Insert<Pessoa>(pessoa);
    }
    public void Remover(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        Pessoa pessoa = BuscarPorId(id);
        connection.Delete<Pessoa>(pessoa);
    }
    public void Editar(Pessoa pessoa)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Update<Pessoa>(pessoa);
    }
    public List<Pessoa> Listar()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.GetAll<Pessoa>().ToList();
    }
    public Pessoa BuscarPorId(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.Get<Pessoa>(id);
    }
}

