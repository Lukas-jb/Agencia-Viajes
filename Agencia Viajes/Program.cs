using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;



namespace Agencia_Viajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cedula = 0;
            int telefono = 0;
            string nombre = "0";
            bool opcion = false;
            bool opcion2 = false;
            bool opcion3 = false;
            string destino;
            short tope = 0;

            Vuelo[] vectorObjVuelo = new Vuelo[10];

            Vuelo[] vectorAeropuerto = new Vuelo[3];
            vectorAeropuerto[0] = new Vuelo("Aeropuerto internacional de Madrid", 1500000, 80000, 2500, 10);// nombreAeropuerto, tasaAeropuerto, valorMinutodeVuelo, transporteAeropuerto, short horasVuelo
            vectorAeropuerto[1] = new Vuelo("Aeropuerto internacional de USA", 1050000, 3000, 75000, 7);
            vectorAeropuerto[2] = new Vuelo("Aeropuerto internacional de Ciudad de México", 750000, 2000, 45000, 5);



            Console.WriteLine("--- Bienvenido al programa de viajes --- \n" +
                    "Por favor ingrese sus datos personales: \n");
            //Pedimos los datos del usuario

            do
            {
                Console.WriteLine("¿En qué vehículo desea realizar su viaje? \n" +
                    "1) Avión \n" +
                    "2) Crucero \n" +
                    "0) Salir");
                int opcionSwitch = Int32.Parse(Console.ReadLine());
                switch (opcionSwitch)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("¿A qué lugar desea realizar su viaje? \n" +
                            "1) España \n" +
                            "2) Estados unidos \n" +
                            "0) Salir");
                            int opcionSwitch1 = Int32.Parse(Console.ReadLine());
                            switch (opcionSwitch1)
                            {
                                case 1:
                                    Vuelo viaje = new Vuelo();
                                    viaje.Destino = "españa";
                                    viaje = Vuelo.DatosVuelo(vectorAeropuerto[0], (Vuelo)viaje);

                                    if (vectorObjVuelo.Length < 10)
                                    {
                                        Console.WriteLine("No se puede comprar el boleto, ya llenaste el número de excursiones");
                                    } else
                                    {
                                        vectorObjVuelo[tope] = viaje;
                                        tope++;

                                    }
                                    Console.WriteLine("¿Deseas comprar otro boleto? si / no");
                                    string continuar = Console.ReadLine();
                                    opcion = continuar == "si" ? false : true;

                                    break;
                                case 2:
                                    destino = vectorAeropuerto[1].Destino;

                                    break;
                                case 0:
                                    Console.WriteLine("Saliendo...");
                                    opcion2 = true;
                                    break;
                                default:
                                    Console.WriteLine("Por favor elija una opción válida \n");
                                    break;
                            }
                        } while (!opcion2);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("¿A qué lugar desea realizar su viaje? \n" +
                            "1) España \n" +
                            "2) Estados unidos \n" +
                            "0) Salir");
                            int opcionSwitch2 = Int32.Parse(Console.ReadLine());
                            switch (opcionSwitch2)
                            {
                                case 1:


                                    break;
                                case 2:

                                    break;
                                case 0:
                                    Console.WriteLine("Saliendo...");
                                    opcion2 = true;
                                    break;
                                default:
                                    Console.WriteLine("Por favor elija una opción válida \n");
                                    break;
                            }
                        } while (!opcion3);
                        break;
                    case 0:
                        Console.WriteLine("Presione cualquier tecla para salir");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Por favor seleccione una opción válida \n");
                        break;
                }

            } while (!opcion);
           // Console.WriteLine(tostring);

            Console.ReadKey();
        }


    }
}


