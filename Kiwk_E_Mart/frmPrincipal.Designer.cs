namespace Kiwk_E_Mart
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoProcutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarNuevasComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Alert = new System.Windows.Forms.Button();
            this.pb_Alerta = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Alerta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ToolStripMenuItem.Text = "Realizar compra";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorEmpleadoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // ventasPorEmpleadoToolStripMenuItem
            // 
            this.ventasPorEmpleadoToolStripMenuItem.Name = "ventasPorEmpleadoToolStripMenuItem";
            this.ventasPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ventasPorEmpleadoToolStripMenuItem.Text = "Ventas Por Empleado";
            this.ventasPorEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.ventasPorEmpleadoToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoProcutoToolStripMenuItem,
            this.realizarNuevasComprasToolStripMenuItem,
            this.controlDeStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // agregarNuevoProcutoToolStripMenuItem
            // 
            this.agregarNuevoProcutoToolStripMenuItem.Name = "agregarNuevoProcutoToolStripMenuItem";
            this.agregarNuevoProcutoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agregarNuevoProcutoToolStripMenuItem.Text = "Agregar nuevo procuto";
            this.agregarNuevoProcutoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoProcutoToolStripMenuItem_Click);
            // 
            // realizarNuevasComprasToolStripMenuItem
            // 
            this.realizarNuevasComprasToolStripMenuItem.Name = "realizarNuevasComprasToolStripMenuItem";
            this.realizarNuevasComprasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.realizarNuevasComprasToolStripMenuItem.Text = "Realizar nueva compra";
            this.realizarNuevasComprasToolStripMenuItem.Click += new System.EventHandler(this.realizarNuevasComprasToolStripMenuItem_Click);
            // 
            // controlDeStockToolStripMenuItem
            // 
            this.controlDeStockToolStripMenuItem.Name = "controlDeStockToolStripMenuItem";
            this.controlDeStockToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.controlDeStockToolStripMenuItem.Text = "Control de Stock";
            this.controlDeStockToolStripMenuItem.Click += new System.EventHandler(this.controlDeStockToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Alert
            // 
            this.btn_Alert.BackColor = System.Drawing.Color.Black;
            this.btn_Alert.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_Alert.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alert.ForeColor = System.Drawing.Color.Red;
            this.btn_Alert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Alert.Location = new System.Drawing.Point(446, 341);
            this.btn_Alert.Name = "btn_Alert";
            this.btn_Alert.Size = new System.Drawing.Size(93, 31);
            this.btn_Alert.TabIndex = 1;
            this.btn_Alert.Text = "!!!No Tocar!!! ";
            this.btn_Alert.UseVisualStyleBackColor = false;
            this.btn_Alert.Click += new System.EventHandler(this.btn_Alert_Click);
            this.btn_Alert.MouseLeave += new System.EventHandler(this.btn_Alert_MouseLeave);
            this.btn_Alert.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Alert_MouseMove);
            // 
            // pb_Alerta
            // 
            this.pb_Alerta.BackgroundImage = global::Kiwk_E_Mart.Properties.Resources.Alerta;
            this.pb_Alerta.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_Alerta.ErrorImage")));
            this.pb_Alerta.InitialImage = null;
            this.pb_Alerta.Location = new System.Drawing.Point(446, 247);
            this.pb_Alerta.Name = "pb_Alerta";
            this.pb_Alerta.Size = new System.Drawing.Size(93, 88);
            this.pb_Alerta.TabIndex = 2;
            this.pb_Alerta.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::Kiwk_E_Mart.Properties.Resources.hay_tabla;
            this.ClientSize = new System.Drawing.Size(553, 391);
            this.Controls.Add(this.pb_Alerta);
            this.Controls.Add(this.btn_Alert);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion del Comecio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Alerta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoProcutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarNuevasComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeStockToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.Button btn_Alert;
        private System.Windows.Forms.PictureBox pb_Alerta;
    }
}

