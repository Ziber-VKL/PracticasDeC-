using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputHelperLibrary
{
    public class ReporterBuilder
    {
        public string BuildReport(string nombre, int edad, string pais)
        {
            StringBuilder reporte = new StringBuilder();

            reporte.AppendLine("==========================");
            reporte.AppendLine("Reporte de Usuario");
            reporte.AppendLine("==========================");
            reporte.AppendLine("Nombre: " + nombre);
            reporte.AppendLine("Edad: " + edad);
            reporte.AppendLine("Pais: " + pais);
            reporte.AppendLine("==========================");

            return reporte.ToString(); ;
        }
    }
}
