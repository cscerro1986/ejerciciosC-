using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        #region CONSTRUCTORES

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita( string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion CONSTRUCTORES

        #region PROPIEDADES

        public float GananciaPorLocal { get { return this.CalcularGanancia(TipoLlamada.Local); } }

        public float GananciaPorProvincia { get { return this.CalcularGanancia(TipoLlamada.Provincial); } }

        public float GananciaPorTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); } }

        public List<Llamada> Llamadas { get { return listaDeLlamadas; } }

        #endregion PROPIEDADES

        #region METODOS



        private float CalcularGanancia(TipoLlamada tipo)
        {
            float acumulador = 0;

            foreach (Llamada item in this.listaDeLlamadas)
            {
                if(tipo == TipoLlamada.Local)
                {
                    if(item is Local)
                    {
                        acumulador = acumulador + ((Local)item).CostoLlamada;
                    }

                }
                if(tipo == TipoLlamada.Provincial)
                {
                    if(item is Provincial)
                    {
                        acumulador = acumulador + ((Provincial)item).CostoLlamada;
                    }
                    
                }
                if(tipo == TipoLlamada.Todas)
                {

                    if(item is Local)
                    {
                        acumulador = acumulador + ((Local)item).CostoLlamada;
                    }
                    else if ( item is Provincial)
                    {
                        acumulador = acumulador + ((Provincial)item).CostoLlamada;

                    }
                }

            }

            return acumulador;
        }


        public string Mostrar()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**********************************************************");
            sb.AppendLine("Razon social: " + this.razonSocial);
            sb.AppendLine("La Ganancia por Total Local es: " + this.GananciaPorLocal);
            sb.AppendLine("La Ganancia por Total por Provincial es: " + this.GananciaPorProvincia);
            sb.AppendLine("La Ganancia total es: " + this.GananciaPorTotal);

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                if(llamada is Local)
                {
                    sb.AppendLine(((Local)llamada).ToString());
                }
                else if(llamada is Provincial)
                {
                    sb.AppendLine(((Provincial)llamada).ToString());
                }
                
            }

            return sb.ToString();

        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion METODOS


        #region OPERADORES

        public static bool operator ==(Centralita centralita1, Llamada llamada1)
        {
            bool retorno = false;

            foreach (Llamada item in centralita1.listaDeLlamadas)
            {
                if(item==llamada1)
                {
                    retorno =true;
                    break;
                }
            }
            return retorno;

            //return (centralita1.listaDeLlamadas.Contains(llamada1));
        }

        public static bool operator !=(Centralita centralita1, Llamada llamada1)
        {
            return !(centralita1==llamada1);
        }

        public static Centralita operator +(Centralita centralita1, Llamada llamada1)
        {
            if(!(centralita1==llamada1))
            {
                centralita1.listaDeLlamadas.Add(llamada1);
            }

            return centralita1;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


        #endregion OPERADORES
    }
}
