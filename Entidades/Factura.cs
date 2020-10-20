using Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kiwk_E_Mart
{
    public class Factura
    {
        #region ATRIBUTOS
        List<ItemProducto> lista_ItemProductos_comprados;
        int id;
        string descuentos;
        string employee;
        double total_abonado;
        #endregion


        #region PROPIEDADES


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

        public string Descuentos
        {
            get
            {
                return descuentos;
            }

            set
            {
                if (!String.IsNullOrEmpty(value.ToString()) &&
                    !String.IsNullOrWhiteSpace(value.ToString()))
                {
                    descuentos = value;
                }
            }
        }


        public List<ItemProducto> Lista_ItemProductos_comprados
        {
            get { return lista_ItemProductos_comprados; }
            set
            {
                if (value != null)
                {
                    lista_ItemProductos_comprados = value;
                }
            }
        }

        public double Total_abonado
        {
            get { return total_abonado; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    total_abonado = value;
                }
            }
        }

        public string Employee
        {
            get { return employee; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {

                    employee = value;
                }
            }
        }


        #endregion


        #region CONSTRUCTORES
        public Factura()
        {
            this.lista_ItemProductos_comprados = new List<ItemProducto>();
        }


        public Factura(List<ItemProducto> auxLista, double auxTotal_abonado, string auxEmployee) : this()
        {
            this.lista_ItemProductos_comprados = auxLista;
            this.total_abonado = auxTotal_abonado;
            this.employee = auxEmployee;
        }

        public Factura(List<ItemProducto> auxLista, double auxTotal_abonado, string auxEmployee, string auxMSJDescuento) : this(auxLista, auxTotal_abonado, auxEmployee)
        {
            this.Descuentos = auxMSJDescuento;
        } 
        
        public Factura(List<ItemProducto> auxLista, double auxTotal_abonado, string auxEmployee,int auxId) : this(auxLista, auxTotal_abonado, auxEmployee)
        {
            this.Id = auxId;
        }
        #endregion


        #region ATRIBUTOS

        /// <summary>
        /// Crea un archivo txt con los datos de la factura.
        /// </summary>
        /// <param name="auxFactura"></param>
        public void Generar_FileFactura(Factura auxFactura)
        {
            List<string> ls = new List<string>();

            ls = (List<string>)auxFactura;

            StreamWriter sw = new StreamWriter($@"C:\Users\Usuario\Desktop\1ºParcialLavoratorio\Marcos_Ruben_Iglesias_Desmond\Kiwk_E_Mart\Archivo_Tickes\Nº{Inventario.Ultimo_id_factura} {Validaciones.Dia_Hora_FormatoFile()}.txt");

            foreach (string item in ls)
            {
                sw.WriteLine(item, true);
            }
            sw.Close();

            Inventario.Ultimo_id_factura++;
        }

        #endregion


        #region String_Builder

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append()

        //    return base.ToString();
        //}

        #endregion



        #region IMPLICIT EXPLICIT


        public static explicit operator List<string>(Factura auxFactura)
        {
            List<string> auxLista = new List<string>();

            foreach (ItemProducto item in auxFactura.Lista_ItemProductos_comprados)
            {
                auxLista.Add(item.ToString());
            }
            auxLista.Add($"\nPrecio total:  ${auxFactura.total_abonado}");

            if (auxFactura.Descuentos != null)
            {
                auxLista.Add(auxFactura.Descuentos);
            }

            return auxLista;
        }


        #endregion


    }
}
