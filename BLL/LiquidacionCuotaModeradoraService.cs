using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL

{
    public class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuataMoeradoraRepository RepositorioLiquidacion = new LiquidacionCuataMoeradoraRepository();
        public string Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            if (RepositorioLiquidacion.Buscar(liquidacion.NumeroLiquidacion)==null)
            {
                RepositorioLiquidacion.Guardar(liquidacion);
                return $"la liquidacion fue guarda";
            }
            return $"paciente {liquidacion.NumeroLiquidacion}, ya exite";
        }

       
        public List<LiquidacionCuotaModeradora> Consultar() { return RepositorioLiquidacion.Consultar(); }
        public List<LiquidacionCuotaModeradora> Filtro(string id,int mes,int año){return RepositorioLiquidacion.Filtro(id,mes,año);}
        public LiquidacionCuotaModeradora Buscar(string id) { return RepositorioLiquidacion.Buscar(id); }
        public decimal Totalizar() { return RepositorioLiquidacion.Totalizar(); }
    }
}
