using System;
using System.Runtime.CompilerServices;

namespace PRIMER_TALLER
{

    class Principal
    {
        static Cliente cliente = new Cliente();
        static void Main(string[] args)
        {

            MenuPrincipal();
        }
        static public void MenuPrincipal()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("PRIMER TALLER.");
                Console.WriteLine("1.Primer ejercicio.");
                Console.WriteLine("2.Segundo ejercicio.");
                Console.WriteLine("3.Tecer ejercicio");
                Console.WriteLine("4.Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: PrimerEjercicio(); break;
                    case 2: SegundoEjercicio(); break;
                    case 3: cliente = TercerEjercicio(); break;
                    case 4: Environment.Exit(0);break;
                    default: Console.WriteLine("Digite una opcion correcta");Console.ReadKey();break;
                }
            } while (opcion != 4);
            Console.WriteLine("Pulse enter para salir.");
            Console.ReadKey();

        }
        static private void PrimerEjercicio()
        {
            Console.Clear();
            string seguir;
            seguir = "S";
            while (seguir.ToUpper() == "S")
            {
                try
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
                }
                catch (Exception e)
                {
                    Console.WriteLine("POR FAVOR SOLO DIGITE NUMEROS.");
                    Console.WriteLine("Presione enter para continuar.");
                    Console.ReadKey();

                }
                Console.Clear();
            }
            Console.Clear();
            MenuPrincipal();
        }
        static private void SegundoEjercicio()
        {
            Console.Clear();
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

        static private Cliente TercerEjercicio()
        {
            Console.Clear();
            string Seguir;
            Seguir = "S";


            MenuCliente menucliente = new MenuCliente();
                Console.WriteLine("Digite su nombre: ");
                cliente.Nombre = Console.ReadLine();
                Console.WriteLine("Digite su numero de cuenta");
                cliente.NumeroDeCuenta = Console.ReadLine();
                Console.WriteLine("Digite el saldo de apertura de la cuenta");
                cliente.SaldoApertura = Convert.ToDecimal(Console.ReadLine());
                cliente.SaldoTotal = cliente.SaldoApertura;
                Console.Clear();
                menucliente.MenuFinanciero(cliente);
                Console.ReadKey();
            return cliente;

        }



    }
}
