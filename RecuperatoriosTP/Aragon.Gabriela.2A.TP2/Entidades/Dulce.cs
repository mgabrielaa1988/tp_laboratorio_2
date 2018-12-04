using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca">Contiene la marca del Dulce</param>
        /// <param name="patente">Contiene el codigo de barras del Dulce</param>
        /// <param name="color">Contiene el color del Dulce</param>
        public Dulce(EMarca marca, string patente, ConsoleColor color)
               : base(patente, marca, color)
        { }

        /// <summary>
        /// Convierte todos los datos de un Dulce en un string
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
    }
}
