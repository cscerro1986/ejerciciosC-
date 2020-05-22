using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{

    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }


    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region CONSTRUCTORES

        public Llamada()
        {

        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }

        #endregion CONSTRUCTORES

        #region PROPIEDADES

        public float Duracion
        {
            get { return this.duracion; }
            set { this.duracion = value; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public abstract float CostoLlamada
        {
            get;
        }
        

        #endregion PROPIEDADES

        #region METODOS

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.Duracion);
            sb.AppendLine("Numero de Origen: " +this.NroOrigen);
            sb.AppendLine("Numero de Destino: "+ this.NroDestino);
            

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns>-1 si llamada1 >llamada2 "1" si llamada1<llamada2 "0" si son iguales </returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if(llamada1.Duracion>llamada2.Duracion)
            {
                retorno = -1;
            }
            else if(llamada1.Duracion<llamada2.Duracion)
            {
                retorno = 1;
            }
            return retorno;
        }

        #endregion METODOS

        #region OPERADORES

        public static bool operator == (Llamada llamada1, Llamada llamada2)
        {
            bool retorno = false;

            if(llamada1.Equals(llamada2))
            {
                if(llamada1.NroOrigen==llamada2.NroOrigen && llamada1.NroDestino== llamada2.NroDestino)
                {
                    retorno = true;
                }
            }

            return retorno;
        }


        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            
            return !(llamada1==llamada2);
        }


        #endregion OPERADORES
    }
}
