using System;

namespace Ejercicio3._0
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool aux = true;
            char OP;
            char R;
            Cuenta cuenta = new Cuenta();
            Console.Write("Digite su nombre: ");
            cuenta.nombre = Console.ReadLine();
            Console.Write("Digite su número de cuenta: ");
            cuenta.nCuenta = Console.ReadLine();
            Console.Write("Digite su saldo de apertura: ");
            cuenta.saldo = decimal.Parse(Console.ReadLine());
            do
            {
                Console.Write("¿Desea consignar o retirar? (C/R): ");
                OP = char.Parse(Console.ReadLine().ToUpper());
                switch (OP)
                {
                    case 'C':
                        Console.Write("Digite el valor a consignar: ");
                        cuenta.Consignar(decimal.Parse(Console.ReadLine()));
                        break;
                    case 'R':
                        Console.Write("Digite el valor a retirar: ");
                        cuenta.Retirar(decimal.Parse(Console.ReadLine()));
                        break;
                }
                Console.WriteLine("Su saldo es: " + cuenta.saldo);
                Console.Write("¿Va a realizar otra transacción? (S/N): ");
                R = char.Parse(Console.ReadLine().ToUpper());
                if (R == 'S')
                {
                    aux = true;
                }
                else
                {
                    aux = false;
                }
            } while (aux == true);
        }
    }
}
