using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Viajes
{
    internal class Crucero : Viajes
    {
        private string nombreMuelle;
        private short diasViaje;
        private float transporteMuelle;
        private float precioCrucero;
        private string tipodeCamarote;


        public Crucero()
        {

        }


        public Crucero(string destino, short diasEstadia, string fechaViaje, string tipoHabitacion, string nombreMuelle, short diasViaje, float transporteMuelle, float precioCrucero, string tipodeCamarote) :
            base(destino, diasEstadia, fechaViaje, tipoHabitacion)
        {
            this.nombreMuelle = nombreMuelle;
            this.diasViaje = diasViaje;
            this.transporteMuelle = transporteMuelle;
            this.precioCrucero = precioCrucero;
            this.tipodeCamarote = tipodeCamarote;
        }

        public Crucero(string nombreMuelle, short diasViaje, float transporteMuelle, float precioCrucero, string tipodeCamarote)
        {
            this.nombreMuelle = nombreMuelle;
            this.diasViaje = diasViaje;
            this.transporteMuelle = transporteMuelle;
            this.precioCrucero = precioCrucero;
            this.tipodeCamarote = tipodeCamarote;
        }

        public static void DatosCrucero(Crucero viaje)
        {
            int diasEstadia, opcionFecha, opcionHabitacion, opcionCamarote;
            bool opcionDo = false;
            do
            {
                Console.WriteLine("Favor ingresar los dias totales de la estadia");
                diasEstadia = Int32.Parse(Console.ReadLine());
                diasEstadia = Convert.ToInt16(Console.ReadLine());
                viaje.DiasEstadia = (short)diasEstadia;
                Console.WriteLine("Seleccione la fecha de viaje\n" +
                       "1) 23/09/2022\n" +
                       "2) 29/09/2022\n");
                opcionFecha = Int32.Parse(Console.ReadLine());
                viaje.FechaViaje = opcionFecha == 1 ? "23/09/2022" : "29/09/2022";
                Console.WriteLine("¿Qué tipo de habitación desea reservar?\n" +
                       "1) Suite | precio: $100.000\n" +
                       "2) Normal | precio: $50.000\n");
                opcionHabitacion = Int32.Parse(Console.ReadLine());
                viaje.TipoHabitacion = opcionHabitacion == 1 ? "suite" : "normal";
                Console.WriteLine("¿Qué tipo de camarote desea comprar para su viaje en el crucero? \n" +
                       "1) Lujo | precio: $80.000\n" +
                        "2) Normal | precio: $60.000\n" +
                        "3) Económico | precio: $40.000\n");
                opcionCamarote = Int32.Parse(Console.ReadLine());
                viaje.tipodeCamarote = opcionCamarote == 1 ? "lujo" : "";
                viaje.tipodeCamarote = opcionCamarote == 2 ? "normal" : "";
                viaje.tipodeCamarote = opcionCamarote == 3 ? "economico" : "";
                Console.WriteLine("¿Desea realizar la compra? si/no");
                string cambios = Console.ReadLine();
                opcionDo = cambios.ToLower() == "si" ? true : false;
            } while (!opcionDo);
        }
        
        public string NombreMuelle { get => nombreMuelle; set => nombreMuelle = value; }
        public short DiasViaje { get => diasViaje; set => diasViaje = value; }
        public float TransporteMuelle { get => transporteMuelle; set => transporteMuelle = value; }
        public float PrecioCrucero { get => precioCrucero; set => precioCrucero = value; }
        public string TipodeCamarote { get => tipodeCamarote; set => tipodeCamarote = value; }

       
    }

}


