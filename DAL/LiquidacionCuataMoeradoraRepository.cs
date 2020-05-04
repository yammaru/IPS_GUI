using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
   public class LiquidacionCuataMoeradoraRepository
    {
        private List<LiquidacionCuotaModeradora> Liquidaciones;
        public LiquidacionCuataMoeradoraRepository()
        {
            Liquidaciones = new List<LiquidacionCuotaModeradora>();
        }
        private string ruta = @"IPS.txt";
        public void Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter stream = new StreamWriter(fileStream);
            stream.WriteLine(liquidacion.ToString());
      
            stream.Close();
            fileStream.Close();
        }
        
        public List<LiquidacionCuotaModeradora> Consultar() 
        {
            List<LiquidacionCuotaModeradora> Liquidaciones = new List<LiquidacionCuotaModeradora>();
            FileStream flujo = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lecto = new StreamReader(flujo);
            string linea = string.Empty;
            while ((linea = lecto.ReadLine()) != null)
            {
                LiquidacionCuotaModeradora cuotaModeradora = Map(linea);
                Liquidaciones.Add(cuotaModeradora);
            }
            lecto.Close();
            flujo.Close();
            return Liquidaciones;
        }


        public LiquidacionCuotaModeradora Map(string linea)
        {
            string[] datos = linea.Split(';');
            if (datos[1] == "contributiva")
            {
                LiquidacionCuotaModeradora contributivo = new RegimenContributivo();

                contributivo.NumeroLiquidacion = datos[0];
                contributivo.Fecha = DateTime.Parse(datos[1]);
                contributivo.IdentificacionPasiente = datos[2];
                contributivo.Tipo = datos[3];
                contributivo.SalarioPaciente = Decimal.Parse(datos[4]);
                contributivo.Tarifa = decimal.Parse(datos[5]);
                contributivo.ValorServicio = decimal.Parse(datos[6]);
                contributivo.CuotaModeradora = decimal.Parse(datos[7]);
                return contributivo;
            }

            else
            {
                LiquidacionCuotaModeradora subsidiado = new RegimenSubsidiado();
                subsidiado.NumeroLiquidacion = datos[0];
                subsidiado.Fecha = DateTime.Parse(datos[1]);
                subsidiado.IdentificacionPasiente = datos[2];
                subsidiado.Tipo = datos[3];
                subsidiado.SalarioPaciente = Decimal.Parse(datos[4]);
                subsidiado.Tarifa = decimal.Parse(datos[5]);
                subsidiado.ValorServicio = decimal.Parse(datos[6]);
                subsidiado.CuotaModeradora = decimal.Parse(datos[7]);
                return subsidiado;

            }

        }
        public LiquidacionCuotaModeradora Buscar(string id) 
        {
            return Liquidaciones.Find(L => L.IdentificacionPasiente.Equals(id)); 
        }
        public List<LiquidacionCuotaModeradora> Filtro(string id, int M, int Y)
        {
            List<LiquidacionCuotaModeradora> RipsS = Consultar();
            List<LiquidacionCuotaModeradora> RipsSf = RipsS.Where(p => p.Tipo.Equals(id) && p.Fecha.Year == Y && p.Fecha.Month == M).ToList();
            return RipsSf;

        }
        public decimal Totalizar() 
        {
            return Liquidaciones.Sum(L => L.ValorServicio); 
        }
    }
}




