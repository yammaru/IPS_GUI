using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class RegimenSubsidiado : LiquidacionCuotaModeradora
    {
        public RegimenSubsidiado()
        {
        }

        public RegimenSubsidiado(string numeroLiquidacion, DateTime fecha, string identificacionPaciente, string tipo, decimal salarioPaciente, decimal valorServicio) : base(numeroLiquidacion, fecha, identificacionPaciente, tipo, salarioPaciente, valorServicio)
        {
        }

        public override void Liquidar()
        {        
            Tarifa = 0.05m;
            CuotaModeradora = ValorServicio * Tarifa;
            if (CuotaModeradora >= 200000)
            {
                CuotaModeradora = 200000;
            }            
        }
    }
}
