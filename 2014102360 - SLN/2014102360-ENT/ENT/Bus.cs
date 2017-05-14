using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Entities
{
    public class Bus : Carro
    {
        
        public Carro Carro { get; set; }
        public TipoBus TipoBus { get; set; }
    }
}
