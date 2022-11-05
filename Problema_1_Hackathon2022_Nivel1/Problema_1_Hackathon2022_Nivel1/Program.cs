using System;

namespace Problema_1_Hackathon2022_Nivel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Reinicio:
            int Operacion = 0, Resultado = 0;
            string Numero1 = "", Numero2 = "";
            Console.Clear();

            try
            {
                Console.WriteLine("Bienvenido al problema 1 del Hackathon2022 nivel 1");
                Console.WriteLine("Ingrese el numero de la base en la que se va a trabajar. Intro Para confirmar");
                Console.WriteLine("1. Binario");
                Console.WriteLine("2. Decimal");
                Console.WriteLine("3. Hexadecimal");
                Console.WriteLine("4. Salir");
                int Base = Convert.ToInt32(Console.ReadLine());
                if (Base == 3) 
                {
                    Console.WriteLine("Tenga en cuenta en ingresar las letras en mayuscula");
                }
                if (Base != 4)
                {
                    Console.WriteLine("Ingrese el numero de la operación la que se va a trabajar. Intro Para confirmar");
                    Console.WriteLine("1. Sumar");
                    Console.WriteLine("2. Restar");
                    Operacion = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el primer  numero");
                    Numero1 = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero");
                    Numero2 = Convert.ToString(Console.ReadLine());
                }

                switch (Base)
                {
                    case 1:
                        if (Operacion == 1)
                        {

                            int Num1 = BinarioaDecimal(Numero1);
                            int Num2 = BinarioaDecimal(Numero2);

                            Resultado = Num1 + Num2;
                            string Binario = DecimalaBinario(Resultado);
                            Console.WriteLine("Resultado de la Operación: "+ Binario);
                        }
                        else if (Operacion == 2)
                        {
                            int Num1 = BinarioaDecimal(Numero1);
                            int Num2 = BinarioaDecimal(Numero2);

                            Resultado = Num1 - Num2;
                            string Binario = DecimalaBinario(Resultado);
                            Console.WriteLine("Resultado de la Operación: " + Binario);
                        }
                        else
                        {
                            Console.WriteLine("No ingreso una operacion dentro de la opciones, Presione Intro para reiniciar");
                            Console.ReadLine();
                            goto Reinicio;
                        }
                        break;
                    case 2:
                        if (Operacion == 1)
                        {
                            int Num1 = Convert.ToInt32(Numero1);
                            int Num2 = Convert.ToInt32(Numero2);
                            Resultado = Num1 + Num2;
                            Console.WriteLine("Resultado de la Operación: " + Resultado);
                        }
                        else if (Operacion == 2)
                        {
                            int Num1 = Convert.ToInt32(Numero1);
                            int Num2 = Convert.ToInt32(Numero2);
                            Resultado = Num1 - Num2;
                            Console.WriteLine("Resultado de la Operación: " + Resultado);
                        }
                        else
                        {
                            Console.WriteLine("No ingreso una operacion dentro de la opciones, Presione Intro para reiniciar");
                            Console.ReadLine();
                            goto Reinicio;
                        }
                        break;
                    case 3:
                        if (Operacion == 1)
                        {
                            int Num1 = HexadecimalaDecimal(Numero1);
                            int Num2 = HexadecimalaDecimal(Numero2);
                            Resultado = Num1 + Num2;
                            string Hexa = DecimalaHexadecimal(Resultado);
                            Console.WriteLine("Resultado de la Operación: " + Resultado);
                        }
                        else if (Operacion == 2)
                        {
                            int Num1 = HexadecimalaDecimal(Numero1);
                            int Num2 = HexadecimalaDecimal(Numero2);
                            Resultado = Num1 - Num2;
                            string Hexa = DecimalaHexadecimal(Resultado);
                            Console.WriteLine("Resultado de la Operación: " + Hexa);
                        }
                        else
                        {
                            Console.WriteLine("No ingreso una operacion dentro de la opciones, Presione Intro para reiniciar");
                            Console.ReadLine();
                            goto Reinicio;
                        }
                        break;
                    case 4: break;

                    default: goto Reinicio; break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal, presione intro para reiniciar");
                Console.ReadLine();
                goto Reinicio;
            }
            Console.WriteLine("Quiere repetir el programa SI/NO. Enter para salir del programa");
            string Rei=Console.ReadLine();
            if (Rei!="")
            {
                goto Reinicio;
            }
           
        }

        public static int BinarioaDecimal(string Numero) 
        {
            int potencia = 0;
            int Resultado = 0;   
            for (int a = Numero.Length-1; a >= 0; a--)
            {
                if (Numero[a]=='0' || Numero[a]=='1')
                {
                    Resultado+=(int)(Convert.ToInt32(Numero[a].ToString())*Math.Pow(2,potencia));
                    potencia++;
                }
                else
                {
                    Resultado = -1;
                    break;
                }
            }
            return Resultado;
        }
        public static string DecimalaBinario(int Numero) 
        {
            string cadena = "";
            while (Numero > 0)
            {
                if (Numero % 2 == 0)
                {
                    cadena = "0" + cadena;
                }
                else
                {
                    cadena = "1" + cadena;
                }
                Numero = (int)(Numero / 2);
            }
            return cadena;
        }
        public static int HexadecimalaDecimal(string Numero) 
        {
            int potencia = 0;
            int Resultado = 0;
            for (int b = Numero.Length-1; b >=0 ; b--)
            {

                switch (Numero[b])
                {
                    case '0':
                        Resultado += (int)(Convert.ToInt32(Numero[b].ToString()) * Math.Pow(16, potencia));
                        potencia++; break;
                    case '1':
                        Resultado += (int)(Convert.ToInt32(Numero[b].ToString()) * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case '2':
                        Resultado += (int)(Convert.ToInt32(Numero[b].ToString()) * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case '4':
                        Resultado += (int)(Convert.ToInt32(Numero[b].ToString()) * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case '5':
                        Resultado += (int)(Convert.ToInt32(Numero[b].ToString()) * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case '6':
                        Resultado += (int)(Convert.ToInt32(Numero[b].ToString()) * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case '7':
                        Resultado += (int)(Convert.ToInt32(Numero[b].ToString()) * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case '8':
                        Resultado += (int)(Convert.ToInt32(Numero[b].ToString()) * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case '9':
                        Resultado += (int)(Convert.ToInt32(Numero[b].ToString()) * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case 'A':
                        Resultado += (int)(10 * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case 'B':
                        Resultado += (int)(11 * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case 'C':
                        Resultado += (int)(12 * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case 'D':
                        Resultado += (int)(13 * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case 'E':
                        Resultado += (int)(14 * Math.Pow(16, potencia));
                        potencia++;
                        break;
                    case 'F':
                        Resultado += (int)(15 * Math.Pow(16, potencia));
                        potencia++;
                        break;
                }
            }


            return Resultado;
        }
        public static string DecimalaHexadecimal(int Numero) 
        {
            string hex = "";
            while (true)
            {
                if ((Numero % 16) != 0)
                {
                    if ((Numero % 16) > 9)
                    {
                        switch (Numero % 16)
                        {
                            case 10: hex = "A" + hex; break;
                            case 11: hex = "B" + hex; break;
                            case 12: hex = "C" + hex; break;
                            case 13: hex = "D" + hex; break;
                            case 14: hex = "E" + hex; break;
                            case 15: hex = "F" + hex; break;
                        }
                    }
                    else
                    {
                        hex = (Numero % 16).ToString() + hex;
                    }
                }
                else
                {
                    hex = "0" + hex;
                }
                Numero /= 16;
                if (Numero <= 0)
                    break;
            }
            return hex;

        }
       


    }

}
