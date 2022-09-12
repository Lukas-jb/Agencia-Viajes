using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Viajes
{
    abstract internal class Viajes
    {
        private string destino;
        private short diasEstadia;
        private string fechaViaje;
        private string tipoHabitacion;
        private float totalPagar;



        public Viajes()
        {
        }

        public Viajes(string destino, short diasEstadia, string fechaViaje, string tipoHabitacion)
        {
            this.destino = destino;
            this.diasEstadia = diasEstadia;
            this.fechaViaje = fechaViaje;
            this.tipoHabitacion = tipoHabitacion;
        }


        public string Destino { get => destino; set => destino = value; }
        public short DiasEstadia { get => diasEstadia; set => diasEstadia = value; }
        public string FechaViaje { get => fechaViaje; set => fechaViaje = value; }
        public string TipoHabitacion { get => tipoHabitacion; set => tipoHabitacion = value; }
        public float TotalPagar { get => totalPagar; set => totalPagar = value; }


    }



}
