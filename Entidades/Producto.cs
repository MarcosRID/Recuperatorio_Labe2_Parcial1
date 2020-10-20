using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Entidades
{
    public class Producto
    {
        #region Atributos

        string nombre;
        string descricpcion;
        double precio;
        int u_stock;
        int u_vendidas;
        int id;
        ETipo_alimento tipo_Alimento;

        #endregion

        #region PROPIEDADES




        public ETipo_alimento Tipo_Alimento
        {
            get { return tipo_Alimento; }
            set { tipo_Alimento = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            //set {  nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    precio = value;
                }

            }
        }


        public int U_stock
        {
            get { return u_stock; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    u_stock = value;
                }
            }
        }

        public int U_vendidas
        {
            get { return u_vendidas; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    u_vendidas = value;
                }
            }
        }


        public string Descricpcion
        {
            get { return descricpcion; }
            set
            {
                if (!String.IsNullOrEmpty(value.ToString()))
                {
                    descricpcion = value;
                }
            }
        }


        public int Id
        {
            get { return id; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    id = value;
                }
            }
        }


        #endregion


        #region CONSTRUCTORES

        public Producto()
        {
            this.u_vendidas = 0;
        }

        public Producto(string auxNombre, double auxPrecio, int auxU_Stock, ETipo_alimento auxTipo_Alimento) : this()
        {
            this.nombre = auxNombre;
            this.precio = auxPrecio;
            this.u_stock = auxU_Stock;
            this.tipo_Alimento = auxTipo_Alimento;
        }

        public Producto(string auxNombre, double auxPrecio, int auxU_Stock, int auxU_vendidas, ETipo_alimento auxTipo_Alimento) : this(auxNombre, auxPrecio, auxU_Stock, auxTipo_Alimento)
        {
            this.u_vendidas = auxU_vendidas;
        }

        public Producto(string auxNombre, double auxPrecio, int auxU_Stock, int auxU_vendidas, int auxId, ETipo_alimento auxTipo_Alimento) : this(auxNombre, auxPrecio, auxU_Stock, auxU_vendidas, auxTipo_Alimento)
        {
            this.id = auxId;
        }

        public Producto(int auxId, string auxNombre, double auxPrecio, int auxU_Stock, ETipo_alimento auxTipo_Alimento) : this(auxNombre, auxPrecio, auxU_Stock, auxTipo_Alimento)
        {
            this.id = auxId;
        }

        public Producto(int auxId, string auxNombre, double auxPrecio, int auxU_Stock, int auxU_vendidas, ETipo_alimento auxTipo_Alimento, string auxDescripcion) : this(auxNombre, auxPrecio, auxU_Stock, auxU_vendidas, auxTipo_Alimento)
        {
            this.Descricpcion = auxDescripcion;
            this.id = auxId;
        }

        public Producto(int auxId, string auxNombre, double auxPrecio, int auxU_Stock, ETipo_alimento auxTipo_Alimento, string auxDescripcion) :this(auxId, auxNombre, auxPrecio, auxU_Stock, auxTipo_Alimento)
        {
            this.Descricpcion = auxDescripcion;
        }

        #endregion



        #region METODOS

        /// <summary>
        /// Agrega un producto a la lista estatica del inventario.
        /// </summary>
        /// <param name="auxProducto"></param>
        public void Agregar_producto(Producto auxProducto)
        {
            Inventario.Lista_productos.Add(auxProducto);
        }



        /// <summary>
        /// Solo creo una fecha de caducidad ,calculada desde el dia que se inicia el programa hasta 30 dias.
        /// </summary>
        /// <returns></returns>
        public string CalularVencimiento()
        {
            StringBuilder sb = new StringBuilder();
            DateTime dt = new DateTime();
            string auxString;
            int auxInt = 0;


            if (dt.Month + 1 < 12 )
            {
                auxInt += (dt.Month + 1);

                sb.Append(DateTime.Now.Day +"/");
                sb.Append(auxInt + "/");
                sb.Append(DateTime.Now.Year);
                
            }
            else
            {
                sb.Append(DateTime.Now.Day + "/");
                sb.Append(1 + "/");
                sb.Append((DateTime.Now.Year + 1));
            }


            return sb.ToString();
        }

        #endregion



        #region SOBRECARGA_OPERADORES


        public static bool operator ==(int auxCodgo, Producto producto_2)
        {
            return auxCodgo == producto_2.id ? true : false;
        }

        public static bool operator !=(int auxCodgo, Producto producto_2)
        {
            return !(auxCodgo == producto_2);
        }




        public static bool operator ==(Producto auxProducto, ItemProducto auxItemProducto)
        {
            try
            {
                if (auxItemProducto != null && auxProducto != null)
                {
                    return auxItemProducto.AuxProduto.id == auxProducto.id ? true : false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }

        public static bool operator !=(Producto auxProducto, ItemProducto auxItemProducto)
        {
            bool okey = true;

            try
            {
                okey = !(auxProducto == auxItemProducto); ;
            }
            catch (Exception)
            {
                return true;
            }

            return okey;
        }


        #endregion



        #region IMPLICIT_EXPLICIT

        public static implicit operator Producto(ItemProducto auxItemProducto)
        {
            return auxItemProducto.AuxProduto;
        }

        /// <summary>
        /// calcua el precio de la cantidad N de un mismo producto
        /// </summary>
        /// <returns></returns>
        public double Cacular_precio_productos(Producto auxProducto, int auxCantidad)
        {
            return auxCantidad * auxProducto.precio;
        }
        #endregion



        #region OVERRIDE

        public virtual string Caducidad()
        {
            return "Fecha/Vencimiento: " + this.CalularVencimiento();
        }

        #endregion

    }
}
