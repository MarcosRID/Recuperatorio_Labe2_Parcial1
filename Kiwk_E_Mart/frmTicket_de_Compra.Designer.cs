namespace Kiwk_E_Mart
{
    partial class frmTicket_de_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicket_de_Compra));
            this.lsb_Ticket = new System.Windows.Forms.ListBox();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsb_Ticket
            // 
            this.lsb_Ticket.BackColor = System.Drawing.Color.Beige;
            this.lsb_Ticket.FormattingEnabled = true;
            this.lsb_Ticket.Location = new System.Drawing.Point(12, 12);
            this.lsb_Ticket.Name = "lsb_Ticket";
            this.lsb_Ticket.Size = new System.Drawing.Size(281, 186);
            this.lsb_Ticket.TabIndex = 0;
            this.lsb_Ticket.SelectedIndexChanged += new System.EventHandler(this.lsb_Ticket_SelectedIndexChanged);
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.BackColor = System.Drawing.Color.Gold;
            this.btn_Continuar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Continuar.Location = new System.Drawing.Point(121, 214);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(75, 23);
            this.btn_Continuar.TabIndex = 1;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = false;
            // 
            // frmTicket_de_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(305, 249);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.lsb_Ticket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTicket_de_Compra";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket_de_Compra";
            this.Load += new System.EventHandler(this.frmTicket_de_Compra_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_Ticket;
        private System.Windows.Forms.Button btn_Continuar;
    }
}