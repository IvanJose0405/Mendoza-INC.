using System.Security.Policy;

namespace PRIMER_TALLER
{
    class Persona
    {
        public string Nombre  { get; set; }
        public decimal Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsaciones { get; set; }
        public void CalcularPulsaciones()
        {
            if (Sexo.ToUpper() == "F")
            {
                Pulsaciones = ((220 - Edad) / 10);
            }
            else if (Sexo.ToUpper() == "M")
            {
                Pulsaciones = ((210 - Edad) / 10);
            }

        }
        public bool ValidarSexo()
        {
            if (Sexo.ToUpper() == "F" || Sexo.ToUpper() == "M")
            {
                return true;

            }
            return false;
        }
    }

}
