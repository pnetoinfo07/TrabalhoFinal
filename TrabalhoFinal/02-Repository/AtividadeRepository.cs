using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository;

public class AtividadeRepository
{
    private readonly string ConnectionString;
    public AtividadeRepository(string connectioString)
    {
        ConnectionString = connectioString;
    }
    public void Adicionar(Atividade pessoa)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Insert<Atividade>(pessoa);
    }
    public void Remover(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        Atividade pessoa = BuscarPorId(id);
        connection.Delete<Atividade>(pessoa);
    }
    public void Editar(Atividade pessoa)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Update<Atividade>(pessoa);
    }
    public List<Atividade> Listar()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.GetAll<Atividade>().ToList();
    }
    public Atividade BuscarPorId(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.Get<Atividade>(id);
    }
}
