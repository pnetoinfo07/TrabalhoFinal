using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades
{
    public class Dia
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<Rotina> Rotinas { get; set; }
    }
}
