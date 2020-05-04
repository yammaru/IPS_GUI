using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public decimal Tarifa { get; set; }
        public string NumeroLiquidacion { get; set; }
        public DateTime Fecha { get; set; }
        public string IdentificacionPasiente { get; set; }
        public string Tipo { get; set; }
        public decimal SalarioPaciente { get; set; }
        public decimal ValorServicio { get; set; }
        public decimal CuotaModeradora { get; set; }
        public LiquidacionCuotaModeradora(string numeroLiquidacion,DateTime fecha, string identificacionPaciente, string tipo, decimal salarioPaciente,decimal valorServicio)
        {
            NumeroLiquidacion = numeroLiquidacion;
            Fecha = fecha;
            IdentificacionPasiente = identificacionPaciente;
            Tipo = tipo;
            SalarioPaciente = salarioPaciente;
            ValorServicio = valorServicio;
        }
        public LiquidacionCuotaModeradora()
        {

        }
        public abstract void Liquidar();
      
        public override string ToString()
        {
            return $"{NumeroLiquidacion};{Fecha};{IdentificacionPasiente};{Tipo};{SalarioPaciente};{Tarifa};{ValorServicio};{CuotaModeradora}";
        }
    }
}
