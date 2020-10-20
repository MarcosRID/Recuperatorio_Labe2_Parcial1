using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Media;
using System.Threading;


namespace Kiwk_E_Mart
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }



        #region METODOS


        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            try
            {
                Inventario.Lista_empleados.Add(new Empleado("Apu", "Nahasapeemapetilon"));
                Inventario.Lista_empleados.Add(new Empleado("Sanjay", "Nahasapeemapetilon"));

                Inventario.Harcodear_lista_Empleados();
                
                            frmLogin auxFrmLogin = new frmLogin();

                            switch (auxFrmLogin.ShowDialog())
                            {

                                case DialogResult.OK:
                                    break;
                                case DialogResult.Cancel:
                                    this.Close();
                                    break;
                }

                SoundPlayer soundP = new System.Media.SoundPlayer(@"C:\Users\Usuario\Desktop\1ºParcialLavoratorio\Marcos_Ruben_Iglesias_Desmond\Kiwk_E_Mart\audios\Sonido.wav");
                soundP.Play();



                // Id minimo
                Inventario.Ultimo_id = 1000;
                Inventario.Ultimo_id_factura = 8;

                // harcodeo la lista cliente (cargo clientes)
                Inventario.Harcodear_lista_clientes();

                //Cargo el inventario.
                Inventario.Harcodear_lista();
                Inventario.Ultimo_id = Inventario.Lista_productos[Inventario.Lista_productos.Count - 1].Id;

                /* opciones para el combobox del form "Contro Stock" */
                Inventario.Titulos_filtrado.Add("Stock menos a 10");
                Inventario.Titulos_filtrado.Add("Todos");

                int aux = Inventario.Ultimo_id;
            }catch  (Exception)
            {
                MessageBox.Show("Error Load...");
            }
           
        }


        /// <summary>
        /// LLama a formulario Agregar_nuevo_producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agregarNuevoProcutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregar_producto auxFrmAgregar_Producto = new frmAgregar_producto();

                auxFrmAgregar_Producto.ShowDialog();
            }
            catch (AValueIsMissingException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error!!!");
            }
        }

        /// <summary>
        /// LLama al formulario Realiza_nueva_compra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realizarNuevasComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                frmRenovar_Stock auxFrmRenovar_Stock = new frmRenovar_Stock();

                auxFrmRenovar_Stock.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error!!!");
            }
        }


        private void controlDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmControl_Stock auxFrmControl_Stock = new frmControl_Stock();


                auxFrmControl_Stock.Cb_Selec_lista.DataSource = Inventario.Titulos_filtrado;

                auxFrmControl_Stock.ShowDialog();

                auxFrmControl_Stock.Cb_Selec_lista.DataSource = null;
                auxFrmControl_Stock.Cb_Selec_lista.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error!!!");
            }
        }


        /// <summary>
        /// Abre el FORM para realizar una compra como cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                frmRealizar_Compra auxFrmRealizar_Compra = new frmRealizar_Compra();

                auxFrmRealizar_Compra.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error!!!");
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ventasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpleados auxFrmEmpleados = new frmEmpleados();

                auxFrmEmpleados.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error!!!");
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\Usuario\Desktop\1ºParcialLavoratorio\Marcos_Ruben_Iglesias_Desmond\Kiwk_E_Mart\audios\Gracis vuelva prontoss.wav");
            sp.Play();
            Thread.Sleep(2500); // Se para el programa por 2.5 segundos
        }


        #endregion

        private void btn_Alert_Click(object sender, EventArgs e)
        {
            try
            {
                throw new MyException("HermoseishonException Se a disparado");
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                
            }
        }

        private void btn_Alert_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Alert.Text = "¡No Me Toques!";
            this.btn_Alert.AutoSize = true;
        }

        private void btn_Alert_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Alert.Text = "¡No Tocar!";
            this.btn_Alert.AutoSize = true;
        }

    }

}

