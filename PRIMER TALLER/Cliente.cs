using System;

namespace PRIMER_TALLER
{
    class Cliente : Persona
    {
        
        public string NumeroDeCuenta { get; set; }
        public decimal SaldoApertura { get; set; }
        public decimal SaldoTotal { get; set; }

        public void MenuFinanciero() {
            int opcion;
            
            Console.Clear();
            Console.WriteLine("Seleccione la acción que desea ejecutar. ");
            Console.WriteLine("1. Consignar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Saldo total");
            Console.WriteLine("4. Salir");
            opcion =Convert.ToInt32(Console.ReadLine());
            switch (opcion) {
                case 1:Consignar(); break;
                case 2: Retirar(); break;
                case 3: SaldoFinal(); break;
                case 4: Salir();break;

            
            }
        
        }
        public void Consignar() {
            decimal valorAConsignar;
            Console.WriteLine("Digite el valor a consignar: ");
            valorAConsignar = Convert.ToDecimal(Console.ReadLine());
            if (valorAConsignar > 0)
            {
                SaldoTotal = SaldoApertura + valorAConsignar;
                Console.WriteLine("Se ha consignado correctamente");
                Console.ReadKey();
                MenuFinanciero();
            }
            else {
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
            else if (valorARetirar > SaldoTotal)
            {
                Console.WriteLine("el valor a retirar no puede ser superior al existente");
                Console.ReadKey();
                Retirar();
            }
            else {
                SaldoTotal = SaldoTotal - valorARetirar;
                Console.WriteLine("Se ha retirado correctamente.");
                Console.ReadKey();
                MenuFinanciero();
            }
        }
        public void SaldoFinal()
        {
            Console.WriteLine("Cliente: " +Nombre.ToUpper());
            Console.WriteLine("El saldo total de la cuenta es de: " + SaldoTotal);
            Console.ReadKey();
            MenuFinanciero();
        }
        public void Salir() {
            Principal principal = new Principal();
            Principal.MenuPrincipal();

        }


    }
}
