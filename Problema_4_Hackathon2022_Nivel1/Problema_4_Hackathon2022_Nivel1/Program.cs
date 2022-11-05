using System;

namespace Problema_4_Hackathon2022_Nivel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reinicio:
            Console.Clear();
            try
            {
                Console.WriteLine("Bienvenido al problema 4 del Hackathon2022 nivel 1");
                Console.WriteLine("Ingrese la cantidad de amigos a repartir los pasteles");
                int Amigos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de porcione que quiere cada amigo");
                int Porciones = Convert.ToInt32(Console.ReadLine());
                if (Amigos > 0 && Porciones > 0)
                {
                    decimal pasteles = (Amigos * Porciones) / 4;
                    Console.WriteLine("La cantidad de pasteles necesarios es de: {0}", Math.Ceiling(pasteles));
                    Console.WriteLine("Quiere repetir el programa SI/NO. Intro para salir del programa");
                    string Rei = Console.ReadLine();
                    if (Rei != "")
                    {
                        goto Reinicio;
                    }
                }
                else
                {
                    Console.WriteLine("No quiere reparti ningun pastel. Presione intro para Reinicar");
                    Console.ReadLine();
                    goto Reinicio;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal. Presione intro para Reinicar");
                Console.ReadLine();
                goto Reinicio;
            }
        }
    }
}
