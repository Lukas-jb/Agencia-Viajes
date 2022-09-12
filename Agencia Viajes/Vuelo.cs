using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Viajes
{
    internal class Vuelo : Viajes
    {
        private string nombreAeropuerto;
        private float tasaAeropuerto;
        private float valorMinutodeVuelo;
        private float transporteAeropuerto;
        private short horasVuelo;

             
        public Vuelo()
        {
        }

        public Vuelo(string nombreAeropuerto, float tasaAeropuerto, float valorMinutodeVuelo, float transporteAeropuerto, short horasVuelo)
        {
            this.nombreAeropuerto = nombreAeropuerto;
            this.tasaAeropuerto = tasaAeropuerto;
            this.valorMinutodeVuelo = valorMinutodeVuelo;
            this.transporteAeropuerto = transporteAeropuerto;
            this.horasVuelo = horasVuelo;
        }

        public Vuelo(string destino, short diasEstadia, string fechaViaje, string tipoHabitacion, string nombreAeropuerto, float tasaAeropuerto, float valorMinutodeVuelo, float transporteAeropuerto, short horasVuelo) :
            base(destino, diasEstadia, fechaViaje, tipoHabitacion)
        {
            this.nombreAeropuerto = nombreAeropuerto;
            this.tasaAeropuerto = tasaAeropuerto;
            this.valorMinutodeVuelo = valorMinutodeVuelo;
            this.transporteAeropuerto = transporteAeropuerto;
            this.horasVuelo = horasVuelo;
        }

        public static Vuelo DatosVuelo(Vuelo VecAeropuertos, Vuelo viaje)
        {
            int diasEstadia, opcionFecha, opcionHabitacion;
            bool opcionDo = false;
            do
            {
                Console.WriteLine("Favor ingresar los dias totales de la estadia");
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
                Console.WriteLine("¿Desea realizar la compra? si/no");
                string cambios = Console.ReadLine();
                opcionDo = cambios.ToLower() == "si" ? true : false;
            } while (!opcionDo);
            
            Vuelo viajeAux = new Vuelo(viaje.Destino, viaje.DiasEstadia, viaje.FechaViaje , viaje.TipoHabitacion , VecAeropuertos.nombreAeropuerto , VecAeropuertos.TasaAeropuerto , VecAeropuertos.valorMinutodeVuelo , 
                VecAeropuertos.transporteAeropuerto , VecAeropuertos.horasVuelo);

            return viaje;
        }

        public override string ToString()//pendiente por polimorfismo
        {
            return base.ToString();
        }


        public string NombreAeropuerto { get => nombreAeropuerto; set => nombreAeropuerto = value; }
        public float TasaAeropuerto { get => tasaAeropuerto; set => tasaAeropuerto = value; }
        public float ValorMinutodeVuelo { get => valorMinutodeVuelo; set => valorMinutodeVuelo = value; }
        public float TransporteAeropuerto { get => transporteAeropuerto; set => transporteAeropuerto = value; }
        public short HorasVuelo { get => horasVuelo; set => horasVuelo = value; }
    }

}
