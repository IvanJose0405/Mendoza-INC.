using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_TALLER
{
    class MenuCliente 
    {
        Cliente cliente = new Cliente();
        public void MenuFinanciero(Cliente cliente)
        {
            this.cliente = cliente;
            int opcion;
            
            Console.Clear();
            Console.WriteLine("Seleccione la acción que desea ejecutar. ");
            Console.WriteLine("1. Consignar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Saldo total");
            Console.WriteLine("4. Volver al menu principal");
     
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1: Consignar(); break;
                case 2: Retirar(); break;
                case 3: SaldoFinal(cliente); break;
                case 4: Principal.MenuPrincipal();break;
                default: Console.WriteLine("digite una opcion correcta.");MenuFinanciero(cliente);break;
                    

            }
        
             
        }
        public void Consignar()
        {
            decimal valorAConsignar;
            Console.WriteLine("Digite el valor a consignar: ");
            valorAConsignar = Convert.ToDecimal(Console.ReadLine());
            if (valorAConsignar > 0)
            {
                cliente.SaldoTotal = cliente.SaldoApertura + valorAConsignar;
                Console.WriteLine("Se ha consignado correctamente");
                Console.ReadKey();
                MenuFinanciero(cliente);
            }
            else
            {
                Console.WriteLine("Digite un valor mayor que 0");
                Console.ReadKey();
                Consignar();
            }
        }
        public void Retirar()
        {
            Console.Clear();
            decimal valorARetirar;
            Console.WriteLine("Digite el valor a retirar: ");
            valorARetirar = Convert.ToDecimal(Console.ReadLine());
            if (valorARetirar <= 0)
            {
                Console.WriteLine("Debe retirar un valor superior a 0.");
                Console.ReadKey();
                Retirar();
            }
            else if (valorARetirar > cliente.SaldoTotal)
            {
                Console.WriteLine("el valor a retirar no puede ser superior al existente");
                Console.ReadKey();
                Retirar();
            }
            else
            {
                cliente.SaldoTotal = cliente.SaldoTotal - valorARetirar;
                Console.WriteLine("Se ha retirado correctamente.");
                Console.ReadKey();
                MenuFinanciero(cliente);
            }
        }
        public void SaldoFinal(Cliente cliente)
        {
            Console.WriteLine("Cliente: " + cliente.Nombre.ToUpper());
            Console.WriteLine("El saldo total de la cuenta es de: " + cliente.SaldoTotal);
            Console.ReadKey();
            MenuFinanciero(cliente);
        }
       
    }
}
