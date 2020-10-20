namespace Kiwk_E_Mart
{
    partial class frmAgregar_producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar_producto));
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Cantidad = new System.Windows.Forms.Label();
            this.lb_Precio = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lb_Mensaje = new System.Windows.Forms.Label();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.lb_Tipo = new System.Windows.Forms.Label();
            this.chb_Perecedero = new System.Windows.Forms.CheckBox();
            this.chb_No_perecedero = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(61, 43);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_Nombre.TabIndex = 4;
            this.lb_Nombre.Text = "Nombre";
            // 
            // lb_Cantidad
            // 
            this.lb_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Cantidad.AutoSize = true;
            this.lb_Cantidad.Location = new System.Drawing.Point(61, 87);
            this.lb_Cantidad.Name = "lb_Cantidad";
            this.lb_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lb_Cantidad.TabIndex = 5;
            this.lb_Cantidad.Text = "Cantidad";
            // 
            // lb_Precio
            // 
            this.lb_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Precio.AutoSize = true;
            this.lb_Precio.Location = new System.Drawing.Point(61, 127);
            this.lb_Precio.Name = "lb_Precio";
            this.lb_Precio.Size = new System.Drawing.Size(37, 13);
            this.lb_Precio.TabIndex = 6;
            this.lb_Precio.Text = "Precio";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Aceptar.AutoSize = true;
            this.btn_Aceptar.BackColor = System.Drawing.Color.Beige;
            this.btn_Aceptar.Location = new System.Drawing.Point(132, 232);
            this.btn_Aceptar.MaximumSize = new System.Drawing.Size(79, 29);
            this.btn_Aceptar.MinimumSize = new System.Drawing.Size(79, 29);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(79, 29);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Beige;
            this.button2.Location = new System.Drawing.Point(245, 260);
            this.button2.MaximumSize = new System.Drawing.Size(75, 23);
            this.button2.MinimumSize = new System.Drawing.Size(75, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nombre.BackColor = System.Drawing.Color.Beige;
            this.txt_Nombre.Location = new System.Drawing.Point(118, 43);
            this.txt_Nombre.MaximumSize = new System.Drawing.Size(130, 20);
            this.txt_Nombre.MinimumSize = new System.Drawing.Size(130, 20);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(130, 20);
            this.txt_Nombre.TabIndex = 9;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cantidad.BackColor = System.Drawing.Color.Beige;
            this.txt_Cantidad.Location = new System.Drawing.Point(118, 87);
            this.txt_Cantidad.MaximumSize = new System.Drawing.Size(130, 20);
            this.txt_Cantidad.MinimumSize = new System.Drawing.Size(130, 20);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(130, 20);
            this.txt_Cantidad.TabIndex = 10;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Precio.BackColor = System.Drawing.Color.Beige;
            this.txt_Precio.Location = new System.Drawing.Point(118, 127);
            this.txt_Precio.MaximumSize = new System.Drawing.Size(130, 20);
            this.txt_Precio.MinimumSize = new System.Drawing.Size(130, 20);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(130, 20);
            this.txt_Precio.TabIndex = 11;
            // 
            // lb_Mensaje
            // 
            this.lb_Mensaje.AutoSize = true;
            this.lb_Mensaje.Location = new System.Drawing.Point(115, 166);
            this.lb_Mensaje.Name = "lb_Mensaje";
            this.lb_Mensaje.Size = new System.Drawing.Size(0, 13);
            this.lb_Mensaje.TabIndex = 12;
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.BackColor = System.Drawing.Color.Beige;
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Location = new System.Drawing.Point(118, 166);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(130, 21);
            this.cb_Tipo.TabIndex = 13;
            // 
            // lb_Tipo
            // 
            this.lb_Tipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Tipo.AutoSize = true;
            this.lb_Tipo.Location = new System.Drawing.Point(61, 166);
            this.lb_Tipo.Name = "lb_Tipo";
            this.lb_Tipo.Size = new System.Drawing.Size(28, 13);
            this.lb_Tipo.TabIndex = 14;
            this.lb_Tipo.Text = "Tipo";
            // 
            // chb_Perecedero
            // 
            this.chb_Perecedero.AutoSize = true;
            this.chb_Perecedero.Location = new System.Drawing.Point(64, 209);
            this.chb_Perecedero.Name = "chb_Perecedero";
            this.chb_Perecedero.Size = new System.Drawing.Size(81, 17);
            this.chb_Perecedero.TabIndex = 15;
            this.chb_Perecedero.Text = "Perecedero";
            this.chb_Perecedero.UseVisualStyleBackColor = true;
            // 
            // chb_No_perecedero
            // 
            this.chb_No_perecedero.AutoSize = true;
            this.chb_No_perecedero.Location = new System.Drawing.Point(167, 209);
            this.chb_No_perecedero.Name = "chb_No_perecedero";
            this.chb_No_perecedero.Size = new System.Drawing.Size(97, 17);
            this.chb_No_perecedero.TabIndex = 16;
            this.chb_No_perecedero.Text = "No perecedero";
            this.chb_No_perecedero.UseVisualStyleBackColor = true;
            // 
            // frmAgregar_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(332, 295);
            this.Controls.Add(this.chb_No_perecedero);
            this.Controls.Add(this.chb_Perecedero);
            this.Controls.Add(this.lb_Tipo);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.lb_Mensaje);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lb_Precio);
            this.Controls.Add(this.lb_Cantidad);
            this.Controls.Add(this.lb_Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 334);
            this.MinimumSize = new System.Drawing.Size(348, 334);
            this.Name = "frmAgregar_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Agregar Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregar_producto_FormClosing);
            this.Load += new System.EventHandler(this.frmAgregar_producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_Cantidad;
        private System.Windows.Forms.Label lb_Precio;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lb_Mensaje;
        private System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.Label lb_Tipo;
        private System.Windows.Forms.CheckBox chb_Perecedero;
        private System.Windows.Forms.CheckBox chb_No_perecedero;
    }
}