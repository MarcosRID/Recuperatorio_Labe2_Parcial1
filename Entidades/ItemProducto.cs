using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemProducto
    {

        Producto auxProduto;
        int cantidad;
        double precio_item;


        #region PROPIEDADES


        public double Precio_item
        {
            get { return precio_item; }
            set
            {
                if (!String.IsNullOrEmpty(value.ToString()))
                {
                    precio_item = value;
                }
            }
        }


        public Producto AuxProduto
        {
            get { return auxProduto; }
            set
            {
                if (value != null)
                {
                    auxProduto = value;
                }
            }
        }


        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    cantidad = value;
                }
            }
        }



        #endregion


        #region CONSTRUCTORES

        public ItemProducto()
        {

        }

        public ItemProducto(Producto auxProducto, int auxCantidad)
        {
            this.auxProduto = auxProducto;
            this.cantidad = auxCantidad;
        }


        public ItemProducto(Producto auxProducto, int auxCantidad, double auxPrecio) : this(auxProducto,auxCantidad)
        {
            this.Precio_item = auxPrecio;

        }
        #endregion


        #region IMPLICIT_EXPLICIT

        public static implicit operator ItemProducto(Producto auxProducto)
        {
            ItemProducto auxItem = new ItemProducto();
            auxItem.auxProduto = auxProducto;
            auxItem.cantidad = 0;

            return auxItem;
        }
        #endregion



        #region String_Builder

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.auxProduto.Nombre + " ");
            sb.Append("Udad." + this.cantidad + " ");
            sb.AppendLine("$" + this.precio_item.ToString());

            return sb.ToString();
        }

        #endregion
    }
}
