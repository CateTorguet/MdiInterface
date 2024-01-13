namespace Práctica5
{
    partial class VentanaHija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaHija));
            this.pb_Hija = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustarAVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_GuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_Guardar = new System.Windows.Forms.ToolStripButton();
            this.tb_AjustarVentana = new System.Windows.Forms.ToolStripButton();
            this.tb_Rotar = new System.Windows.Forms.ToolStripButton();
            this.tb_AñadirTexto = new System.Windows.Forms.ToolStripButton();
            this.tb_EscGrises = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hija)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Hija
            // 
            this.pb_Hija.Location = new System.Drawing.Point(0, 0);
            this.pb_Hija.Name = "pb_Hija";
            this.pb_Hija.Size = new System.Drawing.Size(100, 50);
            this.pb_Hija.TabIndex = 0;
            this.pb_Hija.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem,
            this.mn_Archivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustarAVentanaToolStripMenuItem,
            this.rotarToolStripMenuItem,
            this.añadirTextoToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem});
            this.imagenToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.imagenToolStripMenuItem.MergeIndex = 2;
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // ajustarAVentanaToolStripMenuItem
            // 
            this.ajustarAVentanaToolStripMenuItem.CheckOnClick = true;
            this.ajustarAVentanaToolStripMenuItem.Name = "ajustarAVentanaToolStripMenuItem";
            this.ajustarAVentanaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajustarAVentanaToolStripMenuItem.Text = "Ajustar a ventana";
            this.ajustarAVentanaToolStripMenuItem.Click += new System.EventHandler(this.ajustarAVentanaToolStripMenuItem_Click);
            // 
            // rotarToolStripMenuItem
            // 
            this.rotarToolStripMenuItem.Name = "rotarToolStripMenuItem";
            this.rotarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotarToolStripMenuItem.Text = "Rotar";
            this.rotarToolStripMenuItem.Click += new System.EventHandler(this.rotarToolStripMenuItem_Click);
            // 
            // añadirTextoToolStripMenuItem
            // 
            this.añadirTextoToolStripMenuItem.Name = "añadirTextoToolStripMenuItem";
            this.añadirTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirTextoToolStripMenuItem.Text = "Añadir Texto";
            this.añadirTextoToolStripMenuItem.Click += new System.EventHandler(this.añadirTextoToolStripMenuItem_Click);
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de Grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // mn_Archivo
            // 
            this.mn_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_Guardar,
            this.toolStripSeparator1,
            this.mn_GuardarComo});
            this.mn_Archivo.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mn_Archivo.Name = "mn_Archivo";
            this.mn_Archivo.Size = new System.Drawing.Size(60, 20);
            this.mn_Archivo.Text = "Archivo";
            // 
            // mn_Guardar
            // 
            this.mn_Guardar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mn_Guardar.MergeIndex = 3;
            this.mn_Guardar.Name = "mn_Guardar";
            this.mn_Guardar.Size = new System.Drawing.Size(180, 22);
            this.mn_Guardar.Text = "Guardar";
            this.mn_Guardar.Click += new System.EventHandler(this.mn_Guardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 4;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mn_GuardarComo
            // 
            this.mn_GuardarComo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mn_GuardarComo.MergeIndex = 5;
            this.mn_GuardarComo.Name = "mn_GuardarComo";
            this.mn_GuardarComo.Size = new System.Drawing.Size(180, 22);
            this.mn_GuardarComo.Text = "Guardar como...";
            this.mn_GuardarComo.Click += new System.EventHandler(this.mn_GuardarComo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_Guardar,
            this.tb_AjustarVentana,
            this.tb_Rotar,
            this.tb_AñadirTexto,
            this.tb_EscGrises});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // tb_Guardar
            // 
            this.tb_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("tb_Guardar.Image")));
            this.tb_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Guardar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tb_Guardar.MergeIndex = 3;
            this.tb_Guardar.Name = "tb_Guardar";
            this.tb_Guardar.Size = new System.Drawing.Size(23, 22);
            this.tb_Guardar.Text = "Guardar";
            this.tb_Guardar.Click += new System.EventHandler(this.mn_Guardar_Click);
            // 
            // tb_AjustarVentana
            // 
            this.tb_AjustarVentana.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_AjustarVentana.Image = ((System.Drawing.Image)(resources.GetObject("tb_AjustarVentana.Image")));
            this.tb_AjustarVentana.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AjustarVentana.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tb_AjustarVentana.MergeIndex = 4;
            this.tb_AjustarVentana.Name = "tb_AjustarVentana";
            this.tb_AjustarVentana.Size = new System.Drawing.Size(23, 22);
            this.tb_AjustarVentana.Text = "Ajustar Ventana";
            this.tb_AjustarVentana.Click += new System.EventHandler(this.ajustarAVentanaToolStripMenuItem_Click);
            // 
            // tb_Rotar
            // 
            this.tb_Rotar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Rotar.Image = ((System.Drawing.Image)(resources.GetObject("tb_Rotar.Image")));
            this.tb_Rotar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Rotar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tb_Rotar.MergeIndex = 5;
            this.tb_Rotar.Name = "tb_Rotar";
            this.tb_Rotar.Size = new System.Drawing.Size(23, 22);
            this.tb_Rotar.Text = "Rotar";
            this.tb_Rotar.Click += new System.EventHandler(this.rotarToolStripMenuItem_Click);
            // 
            // tb_AñadirTexto
            // 
            this.tb_AñadirTexto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_AñadirTexto.Image = ((System.Drawing.Image)(resources.GetObject("tb_AñadirTexto.Image")));
            this.tb_AñadirTexto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AñadirTexto.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tb_AñadirTexto.MergeIndex = 6;
            this.tb_AñadirTexto.Name = "tb_AñadirTexto";
            this.tb_AñadirTexto.Size = new System.Drawing.Size(23, 22);
            this.tb_AñadirTexto.Text = "Añadir Texto";
            this.tb_AñadirTexto.Click += new System.EventHandler(this.añadirTextoToolStripMenuItem_Click);
            // 
            // tb_EscGrises
            // 
            this.tb_EscGrises.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_EscGrises.Image = ((System.Drawing.Image)(resources.GetObject("tb_EscGrises.Image")));
            this.tb_EscGrises.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_EscGrises.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tb_EscGrises.MergeIndex = 7;
            this.tb_EscGrises.Name = "tb_EscGrises";
            this.tb_EscGrises.Size = new System.Drawing.Size(23, 22);
            this.tb_EscGrises.Text = "Escala de Grises";
            this.tb_EscGrises.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pb_Hija);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaHija";
            this.Text = "VentanaHija";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hija)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Hija;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustarAVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_Archivo;
        private System.Windows.Forms.ToolStripMenuItem mn_Guardar;
        private System.Windows.Forms.ToolStripMenuItem mn_GuardarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tb_Guardar;
        private System.Windows.Forms.ToolStripButton tb_AjustarVentana;
        private System.Windows.Forms.ToolStripButton tb_Rotar;
        private System.Windows.Forms.ToolStripButton tb_AñadirTexto;
        private System.Windows.Forms.ToolStripButton tb_EscGrises;
    }
}