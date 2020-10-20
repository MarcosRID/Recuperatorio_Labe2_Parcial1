using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perecedero : Producto
    {


        #region CONSTRUCTORES

        public Perecedero()
        {
             
        }

        public Perecedero(int auxId, string auxNombre, double auxPrecio, int auxU_Stock, int auxU_vendidas, ETipo_alimento auxTipo_Alimento, string auxDescripcion) : base(auxId, auxNombre, auxPrecio, auxU_Stock, auxU_vendidas, auxTipo_Alimento,auxDescripcion)
        {

        }


        public Perecedero(int auxId, string auxNombre, double auxPrecio, int auxU_Stock, ETipo_alimento auxTipo_Alimento, string auxDescripcion) : base(auxId, auxNombre, auxPrecio, auxU_Stock, auxTipo_Alimento, auxDescripcion) 
        {

        }

        #endregion


        #region OVERRIDE

        public override string Caducidad()
        {
            return base.Caducidad();  
        }

        #endregion

    }
}
