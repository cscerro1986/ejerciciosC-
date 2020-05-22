using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{

    
   public class Provincial :Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        #region CONSTRUCTORES
        public Provincial(string origen, Franja miFranaja, string destino, float duracion) :base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranaja;
        }
        


        // llamo al constructor anterior.. reutilizacin de codigo.
        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen,miFranja,llamada.NroDestino,llamada.Duracion)
        {

        }


        //public Provincial(Franja miFranja, Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        //{
        //    this.franjaHoraria = miFranja;
        //}

        #endregion CONSTRUCTORES

        #region PROPIEDADES
        public override float CostoLlamada { get { return this.CalcularCosto(); } }
        #endregion PROPIEDADES
        #region METODOS
        private float CalcularCosto()
        {
            float retorno = 0;
            if(this.franjaHoraria==Franja.Franja_1)
            {
                retorno = (float)(this.Duracion * 0.99);
            }
            else if(this.franjaHoraria==Franja.Franja_2)
            {
                retorno = (float)(this.Duracion * 1.25);
            }
            else if(this.franjaHoraria==Franja.Franja_3)
            {
                retorno = (float)(this.Duracion * 0.66);
            }
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja: " + this.franjaHoraria);
            sb.AppendLine("Costo de la llamada: " + this.CostoLlamada);

            return sb.ToString();
        }

        #endregion METODOS

        #region OPERADORES
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Provincial)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion OPERADORES
    }
}
