using AutoMapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOs;

namespace TrabalhoFinal._02_Repository.Data
{
    public class RotinaRepository
    {
        private readonly string ConnectionString;
        private readonly IMapper _mapper;
        private readonly DiaRepository _repositoryDia;
        private readonly PessoaRepository _repositoryPessoa;
        private readonly AtividadeRepository _repositoryAtividade;
        public RotinaRepository(string connectioString, IMapper mapper)
        {
            ConnectionString = connectioString;
            _mapper = mapper;
            _repositoryDia = new DiaRepository(connectioString);
            _repositoryPessoa = new PessoaRepository(connectioString);
            _repositoryAtividade = new AtividadeRepository(connectioString);
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
        public List<ReadRotinaDTO> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Rotina> rotinas =  connection.GetAll<Rotina>().ToList();
            List<ReadRotinaDTO> rotinasDTO = new List<ReadRotinaDTO>();//_mapper.Map<List<ReadRotinaDTO>>(lista);
            foreach(Rotina r in rotinas)
            {
                ReadRotinaDTO rotinaDTO = new ReadRotinaDTO();
                rotinaDTO.Id= r.Id;
                rotinaDTO.DiaId= r.DiaId;
                rotinaDTO.Dia = _repositoryDia.BuscarPorID(r.DiaId);
                rotinaDTO.PessoaId = r.PessoaId;
                rotinaDTO.Pessoa = _repositoryPessoa.BuscarPorId(r.PessoaId);
                rotinaDTO.Atividade = _repositoryAtividade.BuscarPorId(r.AtividadeId);
                rotinasDTO.Add(rotinaDTO);
            }
            return rotinasDTO;
        }
        public Rotina BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Rotina>(id);
        }
    }
}
