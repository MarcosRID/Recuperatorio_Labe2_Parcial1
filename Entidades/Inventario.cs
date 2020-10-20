﻿using Kiwk_E_Mart;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public static class Inventario
    {
        #region ATRIBUTOS

        static List<Producto> lista_productos;
        static List<string> titulos_filtrado;
        static List<Cliente> lista_clientes;
        static List<Factura> lista_facturas;
        static List<Empleado> lista_empleados;
        static int ultimo_id;
        static int ultimo_id_factura;
        static EEmpleado empleado_actual;
        static Dictionary<string, string> lista_empleados_UP;

        #endregion


        #region PROPIEDADES


        public static EEmpleado Empleado_actual
        {
            get { return empleado_actual; }
            set
            {
                if (String.IsNullOrEmpty(value.ToString()))
                {
                    empleado_actual = value;
                }
            }
        }



        public static Dictionary<string, string> Lista_empleados_UP
        {
            get { return lista_empleados_UP; }

        }



        public static int Ultimo_id
        {
            get { return ultimo_id; }
            set
            {
                if (Validaciones.only_numer(value.ToString()))
                {
                    ultimo_id = value;
                }
            }
        }

        public static int Ultimo_id_factura
        {
            get { return ultimo_id_factura; }
            set {
                if (Validaciones.only_numer(value.ToString()))
                {
                    ultimo_id_factura = value;
                }
            }
        }


        public static List<Empleado> Lista_empleados
        {
            get { return lista_empleados; }
            set
            {
                if (value != null)
                {
                    lista_empleados = value;
                }
            }
        }

        public static List<Producto> Lista_productos
        {
            get { return lista_productos; }
            set
            {
                if (value != null)
                {
                    lista_productos = value;
                    // Ultimo_id++; No realiza el incremento.
                }
            }
        }


        public static List<Cliente> Lista_clientes
        {
            get { return lista_clientes; }

            set
            {
                if (value != null)
                {
                    lista_clientes = value;
                }
            }
        }



        public static List<string> Titulos_filtrado
        {
            get { return titulos_filtrado; }
            //set { titulos_filtrado= value; }
        }


        public static List<Factura> Lista_facturas
        {
            get { return lista_facturas; }
            set
            {
                if (value != null)
                {
                    lista_facturas = value;
                }
            }
        }


        #endregion


        #region CONSTRUCTOR

        static Inventario()
        {
            lista_productos = new List<Producto>();
            titulos_filtrado = new List<string>();
            lista_clientes = new List<Cliente>();
            lista_facturas = new List<Factura>();
            lista_empleados = new List<Empleado>();
            lista_empleados_UP = new Dictionary<string, string>();

        }
        #endregion


        #region GETTERS

        public static Producto GetProducByName(string auxName)
        {

            if (auxName != null)
            {

                foreach (Producto item in lista_productos)
                {
                    if (item.Nombre.Equals(auxName))
                    {
                        return item;
                    }
                }
            }
            return null;
        }


        #endregion

        #region METODOS

        public static bool Validar_login(string auxUsuario, string auxPass)
        {
            bool okey = false;

            foreach (KeyValuePair<string, string> item in lista_empleados_UP)
            {
                if (item.Key.Equals(auxUsuario) && item.Value.Equals(auxPass))
                {
                    okey = true;
                    break;
                }
            }

            return okey;
        }

        /// <summary>
        /// Crea una lista AUXILIAR solo con los productos con un stock menor al parametro
        /// </summary>
        /// <returns></returns>
        public static List<Producto> Listar_productos_Escasos(int auxInt)
        {
            List<Producto> auxLista = new List<Producto>();


            // Con Capacity obtengo el espacio total, con Count obtengo cantidad de elementos
            foreach (Producto item in lista_productos)
            {
                if (item.U_stock <= auxInt)
                {
                    auxLista.Add(item);
                }
            }

            return auxLista;
        }


        /// <summary>
        /// Retorna una lista filtrada con los productos con stock
        /// </summary>
        /// <returns></returns>
        public static List<Producto> Lista_productos_gondola()
        {
            List<Producto> auxLista = new List<Producto>();

            foreach (Producto item in lista_productos)
            {
                if (item.U_stock > 0)
                {
                    auxLista.Add(item);
                }
            }

            return auxLista;

        }


        /// <summary>
        /// Actualiza las Unidades en stock y Unidades vendidas del inventario ,respecto a una compra realizada.
        /// </summary>
        /// <param name="auxLista_itemProducto"></param>
        public static void Descontar_stock(List<ItemProducto> auxLista_itemProducto)
        {
            foreach (ItemProducto itemProducto in auxLista_itemProducto)
            {
                foreach (Producto producto in lista_productos)
                {
                    if (producto == itemProducto)
                    {
                        producto.U_stock -= itemProducto.Cantidad;
                        producto.U_vendidas += itemProducto.Cantidad;
                        break;
                    }
                }
            }
        }


        /// <summary>
        /// Retorna el precio total de una lista de item producto
        /// </summary>
        /// <param name="auxLista_itemProducto"></param>
        /// <returns></returns>
        public static double Calcular_monto(List<ItemProducto> auxLista_itemProducto)
        {
            double total = 0;
            foreach (ItemProducto itemProducto in auxLista_itemProducto)
            {

                total += itemProducto.Cantidad * itemProducto.AuxProduto.Precio;

            }
            return total;
        }



        #endregion


        #region HERRAMIENTAS_HARCODEO

        public static void Harcodear_lista()
        {
            int length = 30;// no pasar de 30


            Perecedero auxPerecedero = new Perecedero();
            No_Perecedero auxNo_Perecedero = new No_Perecedero();
            string[] auxNombres = new string[length];
            double[] auxPrecios = new double[length];
            int[] auxCantidades = new int[length];
            int[] auxU_vendidas = new int[length];
            ETipo_alimento[] auxTipo_Alimento = new ETipo_alimento[length];
            
            #region valores_harcodeados

            auxNombres[0 ] = "Cerveza Duff";
            auxNombres[1 ] = "Donas";
            auxNombres[2 ] = "Super Barra energetica";
            auxNombres[3 ] = "Raspados";
            auxNombres[4 ] = "Goma de mascar";
            auxNombres[5 ] = "Hot dog";
            auxNombres[6 ] = "Chuletas";
            auxNombres[7 ] = "Tomaco";
            auxNombres[8 ] = "cereales Krusty";
            auxNombres[9 ] = "Buzz Cola";
            auxNombres[10] = "Radioctive Man Comics";
            auxNombres[11] = "Boletos de lotería";
            auxNombres[12] = "Patatas fritas";
            auxNombres[13] = "Pan de astronauta";
            auxNombres[14] = "Chupelupes";
            auxNombres[15] = "Teléfonos móviles llenos de caramelos";
            auxNombres[16] = "Alfajor Aguila";
            auxNombres[17] = "Alfajor Fulbito";
            auxNombres[18] = "Cigarrillos laramie";
            auxNombres[19] = "Manaos Cola";
            auxNombres[20] = "Manaos Lima";
            auxNombres[21] = "Manaos Uva";
            auxNombres[22] = "Manaos Naraja";
            auxNombres[23] = "Manaos Cereza";
            auxNombres[24] = "Pitusas Frutilla";
            auxNombres[25] = "Pitusas Chocolate";
            auxNombres[26] = "Coca cola";
            auxNombres[27] = "Caramelos media hora";
            auxNombres[28] = "Cerealitas";
            auxNombres[29] = "Cerveza Duff (Sin alcohol)";


          



            auxTipo_Alimento[0 ] = ETipo_alimento.Bebidas;
            auxTipo_Alimento[1 ] = ETipo_alimento.Comida_rapida;
            auxTipo_Alimento[2 ] = ETipo_alimento.Dulces;
            auxTipo_Alimento[3 ] = ETipo_alimento.Bebidas;
            auxTipo_Alimento[4 ] = ETipo_alimento.Dulces;
            auxTipo_Alimento[5 ] = ETipo_alimento.Comida_rapida;
            auxTipo_Alimento[6 ] = ETipo_alimento.Carnes;
            auxTipo_Alimento[7 ] = ETipo_alimento.Frutas;
            auxTipo_Alimento[8 ] = ETipo_alimento.Cereales;
            auxTipo_Alimento[9 ] = ETipo_alimento.Bebidas;
            auxTipo_Alimento[10] = ETipo_alimento.Otros;
            auxTipo_Alimento[11] = ETipo_alimento.Otros;
            auxTipo_Alimento[12] = ETipo_alimento.Comida_rapida;
            auxTipo_Alimento[13] = ETipo_alimento.Comestibles;
            auxTipo_Alimento[14] = ETipo_alimento.Dulces;
            auxTipo_Alimento[15] = ETipo_alimento.Dulces;
            auxTipo_Alimento[16] = ETipo_alimento.Dulces;
            auxTipo_Alimento[17] = ETipo_alimento.Dulces;
            auxTipo_Alimento[18] = ETipo_alimento.Otros;
            auxTipo_Alimento[19] = ETipo_alimento.Bebidas;
            auxTipo_Alimento[20] = ETipo_alimento.Bebidas;
            auxTipo_Alimento[21] = ETipo_alimento.Bebidas;
            auxTipo_Alimento[22] = ETipo_alimento.Bebidas;
            auxTipo_Alimento[23] = ETipo_alimento.Bebidas;
            auxTipo_Alimento[24] = ETipo_alimento.Comestibles;
            auxTipo_Alimento[25] = ETipo_alimento.Comestibles;
            auxTipo_Alimento[26] = ETipo_alimento.Bebidas;
            auxTipo_Alimento[27] = ETipo_alimento.Dulces;
            auxTipo_Alimento[28] = ETipo_alimento.Comestibles;
            auxTipo_Alimento[29] = ETipo_alimento.Bebidas;

            auxCantidades[0 ] = 312;
            auxCantidades[1 ] = 252;
            auxCantidades[2 ] = 150;
            auxCantidades[3 ] = 132;
            auxCantidades[4 ] = 60;
            auxCantidades[5 ] = 70;
            auxCantidades[6 ] = 100;
            auxCantidades[7 ] = 110;
            auxCantidades[8 ] = 65;
            auxCantidades[9 ] = 79;
            auxCantidades[10] = 10;
            auxCantidades[11] = 75;
            auxCantidades[12] = 66;
            auxCantidades[13] = 25;
            auxCantidades[14] = 40;
            auxCantidades[15] = 23;
            auxCantidades[16] = 25;
            auxCantidades[17] = 100;
            auxCantidades[18] = 250;
            auxCantidades[19] = 200;
            auxCantidades[20] = 200;
            auxCantidades[21] = 200;
            auxCantidades[22] = 200;
            auxCantidades[23] = 1;
            auxCantidades[24] = 50;
            auxCantidades[25] = 50;
            auxCantidades[26] = 150;
            auxCantidades[27] = 1500;
            auxCantidades[28] = 46;
            auxCantidades[29] = 500;


            /*
            auxU_vendidas[0] = 257;
            auxU_vendidas[1] = 201;
            auxU_vendidas[2] = 96;
            auxU_vendidas[3] = 76;
            auxU_vendidas[4] = 23;
            auxU_vendidas[5] = 55;
            auxU_vendidas[6] = 80;
            auxU_vendidas[7] = 110;
            auxU_vendidas[8] = 60;
            auxU_vendidas[9] = 40;
            auxU_vendidas[10] = 5;
            auxU_vendidas[11] = 11;
            auxU_vendidas[12] = 33;
            auxU_vendidas[13] = 24;
            auxU_vendidas[14] = 4;
            auxU_vendidas[15] = 2;
            auxU_vendidas[16] = 25;
            auxU_vendidas[17] = 0;
            auxU_vendidas[18] = 236;
            auxU_vendidas[19] = 10;
            auxU_vendidas[20] = 11;
            auxU_vendidas[21] = 12;
            auxU_vendidas[22] = 123;
            auxU_vendidas[23] = 1;
            auxU_vendidas[24] = 25;
            auxU_vendidas[25] = 26;
            auxU_vendidas[26] = 56;
            auxU_vendidas[27] = 1;
            auxU_vendidas[28] = 40;
            auxU_vendidas[29] = 5;
            */


            auxPrecios[0 ] = 30;
            auxPrecios[1 ] = 25;
            auxPrecios[2 ] = 20;
            auxPrecios[3 ] = 45;
            auxPrecios[4 ] = 5;
            auxPrecios[5 ] = 20;
            auxPrecios[6 ] = 75;
            auxPrecios[7 ] = 28;
            auxPrecios[8 ] = 99.99;
            auxPrecios[9 ] = 70;
            auxPrecios[10] = 75;
            auxPrecios[11] = 15;
            auxPrecios[12] = 45;
            auxPrecios[13] = 105;
            auxPrecios[14] = 7;
            auxPrecios[15] = 13;
            auxPrecios[16] = 60;
            auxPrecios[17] = 2;
            auxPrecios[18] = 75;
            auxPrecios[19] = 55;
            auxPrecios[20] = 50;
            auxPrecios[21] = 50;
            auxPrecios[22] = 50;
            auxPrecios[23] = 50;
            auxPrecios[24] = 25;
            auxPrecios[25] = 25;
            auxPrecios[26] = 200;
            auxPrecios[27] = 1;
            auxPrecios[28] = 30;
            auxPrecios[29] = 15;



                                                
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[0], auxPrecios[0], auxCantidades[0], auxU_vendidas[0], auxTipo_Alimento[0],auxPerecedero.Caducidad()));
            
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[1], auxPrecios[1], auxCantidades[1], auxU_vendidas[1], auxTipo_Alimento[1], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[2], auxPrecios[2], auxCantidades[2], auxU_vendidas[2], auxTipo_Alimento[2], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[3], auxPrecios[3], auxCantidades[3], auxU_vendidas[3], auxTipo_Alimento[3], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[4], auxPrecios[4], auxCantidades[4], auxU_vendidas[4], auxTipo_Alimento[4], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[5], auxPrecios[5], auxCantidades[5], auxU_vendidas[5], auxTipo_Alimento[5], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[6], auxPrecios[6], auxCantidades[6], auxU_vendidas[6], auxTipo_Alimento[6], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[7], auxPrecios[7], auxCantidades[7], auxU_vendidas[7], auxTipo_Alimento[7], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[8], auxPrecios[8], auxCantidades[8], auxU_vendidas[8], auxTipo_Alimento[8], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[9], auxPrecios[9], auxCantidades[9], auxU_vendidas[9], auxTipo_Alimento[9], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[10], auxPrecios[10], auxCantidades[10], auxU_vendidas[10], auxTipo_Alimento[10], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[11], auxPrecios[11], auxCantidades[11], auxU_vendidas[11], auxTipo_Alimento[11], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[12], auxPrecios[12], auxCantidades[12], auxU_vendidas[12], auxTipo_Alimento[12], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[13], auxPrecios[13], auxCantidades[13], auxU_vendidas[13], auxTipo_Alimento[13], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[14], auxPrecios[14], auxCantidades[14], auxU_vendidas[14], auxTipo_Alimento[14], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[15], auxPrecios[15], auxCantidades[15], auxU_vendidas[15], auxTipo_Alimento[15], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[16], auxPrecios[16], auxCantidades[16], auxU_vendidas[16], auxTipo_Alimento[16], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[17], auxPrecios[17], auxCantidades[17], auxU_vendidas[17], auxTipo_Alimento[17], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[18], auxPrecios[18], auxCantidades[18], auxU_vendidas[18], auxTipo_Alimento[18], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[19], auxPrecios[19], auxCantidades[19], auxU_vendidas[19], auxTipo_Alimento[19], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[20], auxPrecios[20], auxCantidades[20], auxU_vendidas[20], auxTipo_Alimento[20], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[21], auxPrecios[21], auxCantidades[21], auxU_vendidas[21], auxTipo_Alimento[21], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[22], auxPrecios[22], auxCantidades[22], auxU_vendidas[22], auxTipo_Alimento[22], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[23], auxPrecios[23], auxCantidades[23], auxU_vendidas[23], auxTipo_Alimento[23], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[24], auxPrecios[24], auxCantidades[24], auxU_vendidas[24], auxTipo_Alimento[24], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[25], auxPrecios[25], auxCantidades[25], auxU_vendidas[25], auxTipo_Alimento[25], auxPerecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[26], auxPrecios[26], auxCantidades[26], auxU_vendidas[26], auxTipo_Alimento[26], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[27], auxPrecios[27], auxCantidades[27], auxU_vendidas[27], auxTipo_Alimento[27], auxNo_Perecedero.Caducidad()));
                        
            Ultimo_id++;
            lista_productos.Add(new Perecedero   (Ultimo_id, auxNombres[28], auxPrecios[28], auxCantidades[28], auxU_vendidas[28], auxTipo_Alimento[28], auxPerecedero.Caducidad()));

            Ultimo_id++;
            lista_productos.Add(new No_Perecedero(Ultimo_id, auxNombres[29], auxPrecios[29], auxCantidades[29], auxU_vendidas[29], auxTipo_Alimento[29], auxNo_Perecedero.Caducidad()));


            #endregion

            /*for (int i = 0; i < length; i++)
            {
                Ultimo_id++;
                lista_productos.Add(new Producto(Ultimo_id, auxNombres[i], auxPrecios[i], auxCantidades[i], auxU_vendidas[i],auxTipo_Alimento[i]));
            }*/


            #region Compras

            List<Factura> auxLista = new List<Factura>();
            List<ItemProducto> auxListaProductos = new List<ItemProducto>();
            Factura auxFactura;

            auxListaProductos.Add(new ItemProducto(lista_productos[2 ], (auxCantidades[2 ]-(auxCantidades[2]/2) ), lista_productos[2].Precio * (auxCantidades[2] - (auxCantidades[2] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[13], (auxCantidades[13] - (auxCantidades[13] / 2)), lista_productos[13].Precio * (auxCantidades[13] - (auxCantidades[13] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[22], (auxCantidades[22] - (auxCantidades[22] / 2)), lista_productos[22].Precio * (auxCantidades[22] - (auxCantidades[22] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[11], (auxCantidades[11] - (auxCantidades[11] / 2)), lista_productos[11].Precio * (auxCantidades[11] - (auxCantidades[11] / 2)) ));
            auxFactura = new Factura(auxListaProductos, Inventario.Calcular_monto(auxListaProductos), "Apu");
            auxFactura.Id = 0;
            auxLista.Add(auxFactura);
            Inventario.Lista_empleados[0].Lista_ventas.Add(auxFactura);
            auxListaProductos = new List<ItemProducto>();

            auxListaProductos.Add(new ItemProducto(lista_productos[3 ], (auxCantidades[3 ] - (auxCantidades[3 ] / 2)), lista_productos[3 ].Precio * (auxCantidades[3 ] - (auxCantidades[3 ] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[14], (auxCantidades[14] - (auxCantidades[14] / 2)), lista_productos[14].Precio * (auxCantidades[14] - (auxCantidades[14] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[23], (auxCantidades[23] - (auxCantidades[23] / 2)), lista_productos[23].Precio * (auxCantidades[23] - (auxCantidades[23] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[12], (auxCantidades[12] - (auxCantidades[12] / 2)), lista_productos[12].Precio * (auxCantidades[12] - (auxCantidades[12] / 2))));
            auxFactura = new Factura(auxListaProductos, Inventario.Calcular_monto(auxListaProductos), "Apu");
            auxFactura.Id = 1;
            auxLista.Add(auxFactura);
            Inventario.Lista_empleados[0].Lista_ventas.Add(auxFactura);
            auxListaProductos = new List<ItemProducto>();

            auxListaProductos.Add(new ItemProducto(lista_productos[1 ], (auxCantidades[1 ] - (auxCantidades[1 ] / 2)),lista_productos[1 ].Precio *  (auxCantidades[1 ] - (auxCantidades[1 ] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[10], (auxCantidades[10] - (auxCantidades[10] / 2)),lista_productos[10].Precio *  (auxCantidades[1 ] - (auxCantidades[10] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[9 ], (auxCantidades[9 ] - (auxCantidades[9 ] / 2)),lista_productos[9 ].Precio *  (auxCantidades[1 ] - (auxCantidades[9 ] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[29], (auxCantidades[29] - (auxCantidades[29] / 2)),lista_productos[29].Precio *  (auxCantidades[1 ] - (auxCantidades[29] / 2))));
            auxFactura = new Factura(auxListaProductos, Inventario.Calcular_monto(auxListaProductos), "Apu");
            auxFactura.Id = 2;
            auxLista.Add(auxFactura);
            Inventario.Lista_empleados[0].Lista_ventas.Add(auxFactura);
            auxListaProductos = new List<ItemProducto>();

            auxListaProductos.Add(new ItemProducto(lista_productos[5 ], (auxCantidades[5 ] - (auxCantidades[5 ] / 2)),lista_productos[5 ].Precio * (auxCantidades[5 ] - (auxCantidades[5 ] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[15], (auxCantidades[15] - (auxCantidades[15] / 2)),lista_productos[15].Precio * (auxCantidades[15] - (auxCantidades[15] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[20], (auxCantidades[20] - (auxCantidades[20] / 2)),lista_productos[20].Precio * (auxCantidades[20] - (auxCantidades[20] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[21], (auxCantidades[21] - (auxCantidades[21] / 2)),lista_productos[21].Precio * (auxCantidades[21] - (auxCantidades[21] / 2))));
            auxFactura = new Factura(auxListaProductos, Inventario.Calcular_monto(auxListaProductos), "Sanjay");
            auxFactura.Id = 3;
            auxLista.Add(auxFactura);
            Inventario.Lista_empleados[1].Lista_ventas.Add(auxFactura);
            auxListaProductos = new List<ItemProducto>();

            auxListaProductos.Add(new ItemProducto(lista_productos[7 ], (auxCantidades[7 ] - (auxCantidades[7 ] / 2)),lista_productos[7 ].Precio *  (auxCantidades[ 7 ] - (auxCantidades[7 ] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[27], (auxCantidades[27] - (auxCantidades[27] / 2)),lista_productos[27].Precio *  (auxCantidades[27] - (auxCantidades[27] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[19], (auxCantidades[19] - (auxCantidades[19] / 2)),lista_productos[19].Precio *  (auxCantidades[19] - (auxCantidades[19] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[17], (auxCantidades[17] - (auxCantidades[17] / 2)),lista_productos[17].Precio *  (auxCantidades[17] - (auxCantidades[17] / 2))));
            auxFactura = new Factura(auxListaProductos, Inventario.Calcular_monto(auxListaProductos), "Sanjay");
            auxFactura.Id = 4;
            auxLista.Add(auxFactura);
            Inventario.Lista_empleados[1].Lista_ventas.Add(auxFactura);
            auxListaProductos = new List<ItemProducto>();

            auxListaProductos.Add(new ItemProducto(lista_productos[8 ], (auxCantidades[8 ] - (auxCantidades[8 ] / 2)),lista_productos[8 ].Precio * (auxCantidades[8 ] - (auxCantidades[8 ] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[20], (auxCantidades[20] - (auxCantidades[20] / 2)),lista_productos[20].Precio * (auxCantidades[20] - (auxCantidades[20] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[16], (auxCantidades[16] - (auxCantidades[16] / 2)),lista_productos[16].Precio * (auxCantidades[16] - (auxCantidades[16] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[26], (auxCantidades[26] - (auxCantidades[26] / 2)),lista_productos[26].Precio * (auxCantidades[26] - (auxCantidades[26] / 2))));
            auxFactura = new Factura(auxListaProductos, Inventario.Calcular_monto(auxListaProductos), "Sanjay");
            auxFactura.Id = 5;
            auxLista.Add(auxFactura);
            Inventario.Lista_empleados[1].Lista_ventas.Add(auxFactura);
            auxListaProductos = new List<ItemProducto>();

            auxListaProductos.Add(new ItemProducto(lista_productos[1 ], (auxCantidades[1 ] - (auxCantidades[1 ] / 2)),lista_productos[1 ].Precio * (auxCantidades[1 ] - (auxCantidades[1 ] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[10], (auxCantidades[10] - (auxCantidades[10] / 2)),lista_productos[10].Precio * (auxCantidades[10] - (auxCantidades[10] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[12], (auxCantidades[12] - (auxCantidades[12] / 2)),lista_productos[12].Precio * (auxCantidades[12] - (auxCantidades[12] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[14], (auxCantidades[14] - (auxCantidades[14] / 2)),lista_productos[14].Precio * (auxCantidades[14] - (auxCantidades[14] / 2))));
            auxFactura = new Factura(auxListaProductos, Inventario.Calcular_monto(auxListaProductos), "Apu");
            auxFactura.Id = 6;
            auxLista.Add(auxFactura);
            Inventario.Lista_empleados[0].Lista_ventas.Add(auxFactura);
            auxListaProductos = new List<ItemProducto>();

            auxListaProductos.Add(new ItemProducto(lista_productos[24], (auxCantidades[24] - (auxCantidades[24] / 2)),lista_productos[24].Precio * (auxCantidades[24] - (auxCantidades[24] / 2))));
            auxListaProductos.Add(new ItemProducto(lista_productos[25], (auxCantidades[25] - (auxCantidades[25] / 2)),lista_productos[25].Precio * (auxCantidades[25] - (auxCantidades[25] / 2))));
            auxFactura = new Factura(auxListaProductos, Inventario.Calcular_monto(auxListaProductos), "Sanjay");
            auxFactura.Id = 7;
            auxLista.Add(auxFactura);
            Inventario.Lista_empleados[1].Lista_ventas.Add(auxFactura);

            //auxListaProductos.RemoveRange(0, auxListaProductos.Count);

            Lista_facturas = auxLista;
            List<string> ls = new List<string>();

            Inventario.ultimo_id_factura = 8;

            for (int i = 0; i < 8; i++)
            {
                ls = (List<string>)Inventario.Lista_facturas[i];

                StreamWriter sw = new StreamWriter($@"C:\Users\Usuario\Desktop\1ºParcialLavoratorio\Marcos_Ruben_Iglesias_Desmond\Kiwk_E_Mart\Archivo_Tickes\Nº{i} {Validaciones.Dia_Hora_FormatoFile()}.txt");

                foreach (string item in ls)
                {
                    sw.WriteLine(item,true);

                }
                sw.Close();
            }

            #endregion
        }


        public static void Harcodear_lista_clientes()
        {

            lista_clientes.Add((new Cliente("homero", "simpson")));
            lista_clientes.Add((new Cliente("marge", "simpson")));
            lista_clientes.Add((new Cliente("bart", "simpson")));
            lista_clientes.Add((new Cliente("lisa", "simpson")));
            lista_clientes.Add((new Cliente("abraham", "simpson")));
            lista_clientes.Add((new Cliente("ned", "flanders")));
            lista_clientes.Add((new Cliente("todd", "flanders")));
            lista_clientes.Add((new Cliente("rod", "flanders")));
            lista_clientes.Add((new Cliente("maude", "flanders")));
            lista_clientes.Add((new Cliente("carl", "carlson")));
            lista_clientes.Add((new Cliente("lenford", "leonard")));
            lista_clientes.Add((new Cliente("barney", "gomez")));
            lista_clientes.Add((new Cliente("moe", "szyslak")));
            lista_clientes.Add((new Cliente("otto", "mann")));
            lista_clientes.Add((new Cliente("patty", "bouvier")));
            lista_clientes.Add((new Cliente("selma", "bouvier")));
            lista_clientes.Add((new Cliente("clancy", "gorgori")));
            lista_clientes.Add((new Cliente("nelson", "rufino")));
            lista_clientes.Add((new Cliente("edna", "krabapple")));
            lista_clientes.Add((new Cliente("jeff", "albertson")));
            lista_clientes.Add((new Cliente("milhouse", "van houten")));
        }


        public static void Harcodear_lista_Empleados()
        {
            lista_empleados_UP.Add("Apu", "pass123");
            lista_empleados_UP.Add("Sanjay", "pass123");

        }

     


        #endregion


    }
}
