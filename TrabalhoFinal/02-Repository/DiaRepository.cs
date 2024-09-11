using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository
{
    public class DiaRepository
    {
        private readonly string ConnectionString;
        public DiaRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            for (int i = 0;i<1000;i++)
            {
                Dia d = new Dia()
                {
                    Data = DateTime.Now.AddDays(i)
                };
                connection.Insert<Dia>(d);
            }           
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Dia> dias = Listar();
            foreach (Dia d in dias)
            {
                connection.Delete<Dia>(d);
            }            
        }
        public List<Dia> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Dia>().ToList();
        }
    }
}
