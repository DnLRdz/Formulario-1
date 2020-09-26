//nmb=nombre
//app=apellido paterno
//apm=apellido materno
//mined=edad
//ocp=ocupación
//cor=correo


using System;


namespace ConsoleSwap
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nmb, app, apm, ocp, eml;
            int mined;
            {
                Console.WriteLine("Ingresa tu nombre(s): ");
                nmb = Console.ReadLine();
                Console.WriteLine("Ingresa tu apellido paterno: ");
                app = Console.ReadLine();
                Console.WriteLine("Ingresa tu apellido materno: ");
                apm = Console.ReadLine();
                Console.WriteLine("¿Cuál es su ocupación?: ");
                ocp = Console.ReadLine();
                Console.WriteLine("Escribe tu e-mail: ");
                eml = Console.ReadLine();
                Console.WriteLine("Ingresa tu edad: ");
                mined = Convert.ToInt32(Console.ReadLine());
                if (mined < 18)
                {
                    Console.WriteLine("Acceso restringido a menores de 18 años.");
                }

                else if (mined >= 18);
                Console.WriteLine("Por favor, verifique sus datos:");
                Console.WriteLine("\nSu nombre completo es: {0}  {1}  {2} ", nmb, app, apm);
                Console.WriteLine("\nSu edad es: {0}",mined);
                Console.WriteLine("\nSu e-mail es: {0}", eml);
                Console.WriteLine("\nSu ocupación es: {0}", ocp);


            } 
           
        }
    }
}


