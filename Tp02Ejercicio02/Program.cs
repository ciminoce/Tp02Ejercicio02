using System;

namespace Tp02Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Signos del Zodíaco y Horóscopo Chino";
            Console.Write("Ingrese su fecha de nacimiento:");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                if (fechaNacimiento <= DateTime.Today)
                {
                    var signoZodiaco = InformarSignoZodiaco(fechaNacimiento.Day, fechaNacimiento.Month);
                }
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento mal ingresada");
            }
            Console.ReadLine();
        }

        private static string InformarSignoZodiaco(int dia, int mes)
        {
            string signo;
            switch (mes)
            {
                case 1:
                    signo = dia >= 21 ? "Acuario":"Capricornio";
                    break;
                case 2:
                    signo = dia >= 20 ? "Piscis" : "Acuario";

                    break;
                case 3:
                    signo = dia >= 21 ? "Aries" : "Piscis";

                    break;
                case 4:
                    signo = dia >= 21 ? "Tauro" : "Aries";

                    break;
                case 5:
                    signo = dia >= 22 ? "Géminis" : "Tauro";

                    break;
                case 6:
                    signo = dia >= 22 ? "Cáncer" : "Géminis";

                    break;
                case 7:
                    signo = dia >= 23 ? "Leo" : "Cáncer";

                    break;
                case 8:
                    signo = dia >= 24 ? "Virgo" : "Leo";

                    break;

                case 9:
                    signo = dia >= 23 ? "Libra" : "Virgo";

                    break;
                case 10:
                    signo = dia >= 23 ? "Escorpio" : "Libra";

                    break;
                case 11:
                    signo = dia >= 23 ? "Sagitario" : "Escorpio";

                    break;
                default:
                    signo = dia >= 22 ? "Capricornio" : "Sagitario";

                    break;
            }

            return signo;
        }
    }
}
