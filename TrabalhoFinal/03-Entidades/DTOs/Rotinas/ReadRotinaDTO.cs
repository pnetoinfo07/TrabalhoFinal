using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades.DTOs
{
    public class ReadRotinaDTO
    {
        public int Id { get; set; }
        public int DiaId { get; set; }
        public Dia Dia { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public Atividade Atividade { get; set; }
        public int TotalAtividadesVendidas { get; set; }
    }
}
