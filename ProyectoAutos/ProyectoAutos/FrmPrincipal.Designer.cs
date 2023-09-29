namespace ProyectoAutos
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsl_Usuarios = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Refacciones = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Taller = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Salir = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Regresar = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_Usuarios,
            this.tsl_Refacciones,
            this.tsl_Taller,
            this.tsl_Salir,
            this.tsl_Regresar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(148, 486);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsl_Usuarios
            // 
            this.tsl_Usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsl_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsl_Usuarios.Image")));
            this.tsl_Usuarios.Name = "tsl_Usuarios";
            this.tsl_Usuarios.Size = new System.Drawing.Size(145, 24);
            this.tsl_Usuarios.Text = "Usuarios";
            // 
            // tsl_Refacciones
            // 
            this.tsl_Refacciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsl_Refacciones.Image = ((System.Drawing.Image)(resources.GetObject("tsl_Refacciones.Image")));
            this.tsl_Refacciones.Name = "tsl_Refacciones";
            this.tsl_Refacciones.Size = new System.Drawing.Size(145, 24);
            this.tsl_Refacciones.Text = "Refacciones";
            // 
            // tsl_Taller
            // 
            this.tsl_Taller.Image = ((System.Drawing.Image)(resources.GetObject("tsl_Taller.Image")));
            this.tsl_Taller.Name = "tsl_Taller";
            this.tsl_Taller.Size = new System.Drawing.Size(145, 24);
            this.tsl_Taller.Text = "Taller";
            this.tsl_Taller.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // tsl_Salir
            // 
            this.tsl_Salir.Image = ((System.Drawing.Image)(resources.GetObject("tsl_Salir.Image")));
            this.tsl_Salir.Name = "tsl_Salir";
            this.tsl_Salir.Size = new System.Drawing.Size(145, 24);
            this.tsl_Salir.Text = "Salir";
            this.tsl_Salir.Click += new System.EventHandler(this.tsl_Salir_Click);
            // 
            // tsl_Regresar
            // 
            this.tsl_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("tsl_Regresar.Image")));
            this.tsl_Regresar.Name = "tsl_Regresar";
            this.tsl_Regresar.Size = new System.Drawing.Size(145, 24);
            this.tsl_Regresar.Text = "Regresar";
            this.tsl_Regresar.Click += new System.EventHandler(this.tsl_Regresar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 486);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsl_Usuarios;
        private System.Windows.Forms.ToolStripLabel tsl_Refacciones;
        private System.Windows.Forms.ToolStripLabel tsl_Taller;
        private System.Windows.Forms.ToolStripLabel tsl_Salir;
        private System.Windows.Forms.ToolStripLabel tsl_Regresar;
    }
}