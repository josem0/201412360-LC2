using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Entities
{
    public class Ensambladora
    {
        public int EnsambladoraId { get; set; }
        public List<Carro> Carros { get; set; }
        public Carro Carro { get; set; }
        public TipoCarro TipoCarro { get; set; }
        public Ensambladora()
        {
            Carros = new List<Carro>();
        }
    }
}
