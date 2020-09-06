using System;

namespace PRIMER_TALLER
{

    class Principal
    {

        static void Main(string[] args)
        {
            MenuPrincipal();
        }
        static public void MenuPrincipal()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("PRIMER TALLER.");
            Console.WriteLine("1.Primer ejercicio.");
            Console.WriteLine("2.Segundo ejercicio.");
            Console.WriteLine("3.Tecer ejercicio");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1: PrimerEjercicio(); break;
                case 2: SegundoEjercicio(); break;
                case 3: TercerEjercicio(); break;
                default: Console.WriteLine("Digite una opcion correcta."); break;
            }

        }
        static private void PrimerEjercicio()
        {
            string seguir;
            seguir = "S";
            while (seguir.ToUpper() == "S")
            {
                Estudiante estudiante = new Estudiante();
                Console.WriteLine("Digite la primera nota: \n");
                estudiante.Nota1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite la segunda nota: \n");
                estudiante.Nota2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite la tercera nota: \n");
                estudiante.Nota3 = Convert.ToDecimal(Console.ReadLine());
                estudiante.CalcularPromedio();
                Console.WriteLine("El promedio del estudiante es de: " + estudiante.Promedio);
                Console.WriteLine("El estudiante " + estudiante.ValidarEstado());
                Console.WriteLine("¿Desea continuar?S/N");
                seguir = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            MenuPrincipal();
        }
        static private void SegundoEjercicio()
        {
            string seguir;
            seguir = "S";
            Persona persona = new Persona();
            while (seguir.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Digite la edad: ");
                persona.Edad = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite el sexo (F/M): ");
                persona.Sexo = Console.ReadLine();
                if (persona.ValidarSexo())
                {
                    persona.CalcularPulsaciones();
                    Console.WriteLine("Las pulsaciones de la persona son de: " + persona.Pulsaciones);

                }
                else
                {
                    Console.WriteLine("Digite un sexo correcto(F/M).");
                    Console.ReadKey();
                    SegundoEjercicio();
                }
                Console.WriteLine("Desea continuar? S/N");
                seguir = Console.ReadLine();
            }
            MenuPrincipal();
        }

        static private void TercerEjercicio()
        {
            string Seguir;
            Seguir = "S";
            Cliente cliente = new Cliente();
            while (Seguir.ToUpper() == "S")
            {
                Console.WriteLine("Digite su nombre: ");
                cliente.Nombre = Console.ReadLine();
                Console.WriteLine("Digite su numero de cuenta");
                cliente.NumeroDeCuenta = Console.ReadLine();
                Console.WriteLine("Digite el saldo de apertura de la cuenta");
                cliente.SaldoApertura = Convert.ToDecimal(Console.ReadLine());
                cliente.SaldoTotal = cliente.SaldoApertura;
                Console.Clear();
                cliente.MenuFinanciero();
                Console.ReadKey();
            }

        }



    }
}
