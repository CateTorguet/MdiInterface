namespace Práctica5
{
    partial class VisorImágenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorImágenes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Ocultar = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.tb_Abrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_AcercaDe = new System.Windows.Forms.ToolStripButton();
            this.StatusText = new System.Windows.Forms.StatusStrip();
            this.etiquetaEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.mn_OcultarSB = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_OcultarTB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.StatusText.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mn_Ocultar,
            this.ventanaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_Salir,
            this.cerrarToolStripMenuItem,
            this.mn_Nuevo,
            this.mn_Abrir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mn_Salir
            // 
            this.mn_Salir.Name = "mn_Salir";
            this.mn_Salir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mn_Salir.Size = new System.Drawing.Size(180, 22);
            this.mn_Salir.Text = "Salir";
            this.mn_Salir.Click += new System.EventHandler(this.mn_Salir_Click);
            this.mn_Salir.MouseEnter += new System.EventHandler(this.mn_Salir_MouseEnter);
            this.mn_Salir.MouseLeave += new System.EventHandler(this.mn_Salir_MouseLeave);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            this.cerrarToolStripMenuItem.MouseEnter += new System.EventHandler(this.cerrarToolStripMenuItem_MouseEnter);
            this.cerrarToolStripMenuItem.MouseLeave += new System.EventHandler(this.cerrarToolStripMenuItem_MouseLeave);
            // 
            // mn_Nuevo
            // 
            this.mn_Nuevo.Name = "mn_Nuevo";
            this.mn_Nuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mn_Nuevo.Size = new System.Drawing.Size(180, 22);
            this.mn_Nuevo.Text = "Nuevo";
            this.mn_Nuevo.Click += new System.EventHandler(this.mn_Nuevo_Click);
            this.mn_Nuevo.MouseEnter += new System.EventHandler(this.mn_Nuevo_MouseEnter);
            this.mn_Nuevo.MouseLeave += new System.EventHandler(this.mn_Nuevo_MouseLeave);
            // 
            // mn_Abrir
            // 
            this.mn_Abrir.Name = "mn_Abrir";
            this.mn_Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mn_Abrir.Size = new System.Drawing.Size(180, 22);
            this.mn_Abrir.Text = "Abrir";
            this.mn_Abrir.Click += new System.EventHandler(this.mn_Abrir_Click);
            this.mn_Abrir.MouseEnter += new System.EventHandler(this.mn_Abrir_MouseEnter);
            this.mn_Abrir.MouseLeave += new System.EventHandler(this.mn_Abrir_MouseLeave);
            // 
            // mn_Ocultar
            // 
            this.mn_Ocultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_OcultarSB,
            this.mn_OcultarTB});
            this.mn_Ocultar.Name = "mn_Ocultar";
            this.mn_Ocultar.Size = new System.Drawing.Size(35, 20);
            this.mn_Ocultar.Text = "Ver";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem,
            this.mosaicoHorizontalToolStripMenuItem,
            this.mosaicoVerticalToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // mosaicoHorizontalToolStripMenuItem
            // 
            this.mosaicoHorizontalToolStripMenuItem.Name = "mosaicoHorizontalToolStripMenuItem";
            this.mosaicoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mosaicoHorizontalToolStripMenuItem.Text = "Mosaico Horizontal";
            this.mosaicoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.mosaicoHorizontalToolStripMenuItem_Click);
            // 
            // mosaicoVerticalToolStripMenuItem
            // 
            this.mosaicoVerticalToolStripMenuItem.Name = "mosaicoVerticalToolStripMenuItem";
            this.mosaicoVerticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mosaicoVerticalToolStripMenuItem.Text = "Mosaico Vertical";
            this.mosaicoVerticalToolStripMenuItem.Click += new System.EventHandler(this.mosaicoVerticalToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_AcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // mn_AcercaDe
            // 
            this.mn_AcercaDe.Name = "mn_AcercaDe";
            this.mn_AcercaDe.Size = new System.Drawing.Size(180, 22);
            this.mn_AcercaDe.Text = "Acerca De";
            this.mn_AcercaDe.Click += new System.EventHandler(this.mn_AcercaDe_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_Nuevo,
            this.tb_Abrir,
            this.toolStripSeparator2,
            this.tb_AcercaDe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tb_Nuevo
            // 
            this.tb_Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("tb_Nuevo.Image")));
            this.tb_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Nuevo.Name = "tb_Nuevo";
            this.tb_Nuevo.Size = new System.Drawing.Size(23, 22);
            this.tb_Nuevo.Text = "Nuevo";
            this.tb_Nuevo.Click += new System.EventHandler(this.mn_Nuevo_Click);
            // 
            // tb_Abrir
            // 
            this.tb_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("tb_Abrir.Image")));
            this.tb_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Abrir.Name = "tb_Abrir";
            this.tb_Abrir.Size = new System.Drawing.Size(23, 22);
            this.tb_Abrir.Text = "Abrir";
            this.tb_Abrir.Click += new System.EventHandler(this.mn_Abrir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_AcercaDe
            // 
            this.tb_AcercaDe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_AcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("tb_AcercaDe.Image")));
            this.tb_AcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AcercaDe.MergeIndex = 9;
            this.tb_AcercaDe.Name = "tb_AcercaDe";
            this.tb_AcercaDe.Size = new System.Drawing.Size(23, 22);
            this.tb_AcercaDe.Text = "AcercaDe";
            this.tb_AcercaDe.Click += new System.EventHandler(this.mn_AcercaDe_Click);
            // 
            // StatusText
            // 
            this.StatusText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetaEstado});
            this.StatusText.Location = new System.Drawing.Point(0, 428);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(800, 22);
            this.StatusText.TabIndex = 5;
            this.StatusText.Tag = "";
            this.StatusText.Text = "statusStrip1";
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(785, 17);
            this.etiquetaEstado.Spring = true;
            this.etiquetaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mn_OcultarSB
            // 
            this.mn_OcultarSB.CheckOnClick = true;
            this.mn_OcultarSB.Name = "mn_OcultarSB";
            this.mn_OcultarSB.Size = new System.Drawing.Size(180, 22);
            this.mn_OcultarSB.Text = "Ocutar StatusBar";
            this.mn_OcultarSB.Click += new System.EventHandler(this.mn_OcultarSB_Click);
            // 
            // mn_OcultarTB
            // 
            this.mn_OcultarTB.CheckOnClick = true;
            this.mn_OcultarTB.Name = "mn_OcultarTB";
            this.mn_OcultarTB.Size = new System.Drawing.Size(180, 22);
            this.mn_OcultarTB.Text = "Ocultar ToolBar";
            this.mn_OcultarTB.Click += new System.EventHandler(this.mn_OcultarTB_Click);
            // 
            // VisorImágenes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VisorImágenes";
            this.Text = "Práctica 5";
            this.MdiChildActivate += new System.EventHandler(this.VisorImágenes_MdiChildActivate);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.VisorImágenes_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VisorImágenes_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StatusText.ResumeLayout(false);
            this.StatusText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_Ocultar;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_AcercaDe;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicoVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_Salir;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem mn_Abrir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tb_Nuevo;
        private System.Windows.Forms.ToolStripButton tb_Abrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tb_AcercaDe;
        private System.Windows.Forms.StatusStrip StatusText;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaEstado;
        private System.Windows.Forms.ToolStripMenuItem mn_OcultarSB;
        private System.Windows.Forms.ToolStripMenuItem mn_OcultarTB;
    }
}

