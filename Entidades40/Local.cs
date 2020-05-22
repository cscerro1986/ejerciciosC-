using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        #region CONSTRUCTOR
       
        public Local(string nroDestino, string nroOrigen, float duracion, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada1, float costo):base(llamada1.Duracion,llamada1.NroDestino,llamada1.NroOrigen)
        {
            this.costo = costo;
            
        }

        #endregion CONSTRUCTOR

        #region PROPIEDADES
        public override float CostoLlamada { get { return this.costo; } }
        #endregion PROPIEDADES

        #region METODOS
        private float CalcularCosto()
        {
            float retorno = 0;

            retorno = this.Duracion * CostoLlamada;

            return retorno;
        }

        

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo de la llamada local: " + CostoLlamada);

            return sb.ToString();
        }

        #endregion METODOS

        #region OPERADORES

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Local)
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
