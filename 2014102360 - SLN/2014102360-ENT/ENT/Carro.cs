using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014102360.Entities
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }
        public int EnsambladoraId { get; set; }
        public Ensambladora Ensambladora { get; set; }
        public TipoCarro TipoCarro { get; set; }
        public Volante Volante { get; set; }
        public int VolanteId { get; set; }
        public Parabrisas Parabrisas { get; set; }
        public int ParabrisasId { get; set; }
        public List<Llanta> Llantas { get; set; }
        //public Llanta Llanta { get; set; }
        public List<Asiento> Asientos { get; set; }
        //public Asiento Asiento { get; set; }
        public Propietario Propietario { get; set; }
        public int PropietarioId { get; set; }

        public Carro()
        {
            Llantas = new List<Llanta>();
            Asientos = new List<Asiento>();

        }
        public Carro(Volante volante, Parabrisas parabrisas, Propietario propietario)
        {
            Volante = volante;
            Parabrisas = parabrisas;
            Propietario = propietario;

        }
    }
}
