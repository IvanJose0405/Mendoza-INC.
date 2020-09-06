using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_TALLER
{
    public class Estudiante
    {

   
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Promedio { get; set; }
        public string Estado { get; set; }

        public void CalcularPromedio() {
            Promedio = ((Nota1 + Nota2 + Nota3) / 3);
      
        }
        public string ValidarEstado() {
            decimal MINIMOBASE;
            MINIMOBASE=2.9M;
            if (Promedio <= MINIMOBASE)
            {

                return "reprobo";
            }
            else {
                return "Aprobo";
            }
            
        }
   
    }
   
}
