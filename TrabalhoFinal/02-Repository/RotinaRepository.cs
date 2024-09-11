using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository.Data
{
    public class RotinaRepository
    {
        private readonly string ConnectionString;
        public RotinaRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar(Rotina rotina)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Rotina>(rotina);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Rotina rotina = BuscarPorId(id);
            connection.Delete<Rotina>(rotina);
        }
        public void Editar(Rotina rotina)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Rotina>(rotina);
        }
        public List<Rotina> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Rotina>().ToList();
        }
        public Rotina BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Rotina>(id);
        }
    }
}
