using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;// throw new NotImplementedException();
namespace Práctica5
{
    public partial class VisorImágenes : Form
    {
        public VentanaHija HijaActiva
        {
            get { return (VentanaHija)this.ActiveMdiChild; }
        }
        public VisorImágenes()
        {
            InitializeComponent();

            cascadaToolStripMenuItem.Enabled = this.HijaActiva != null;
            mosaicoHorizontalToolStripMenuItem.Enabled = this.HijaActiva != null;
            mosaicoVerticalToolStripMenuItem.Enabled = this.HijaActiva != null;
        }


        private void mn_AcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe aboutBox = new AcercaDe();
            aboutBox.ShowDialog();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mn_Nuevo_Click(object sender, EventArgs e)
        {

            int númeroHijas = this.MdiChildren.Length;
            string título = "Doc" + (númeroHijas + 1);
            NuevaHija(título);
        }

        private void NuevaHija(string título)
        {
            VentanaHija hija = new VentanaHija(título);
            hija.MdiParent = this;
            hija.PictureBox.Image = Properties.Resources.Shark;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0) 
            {
                this.HijaActiva.Close();
                return;
            }
            else 
            {
                MessageBox.Show("No hay ninguna ventana activa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void mn_Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Escoja una imagen";
            dlg.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos los archivos|*.*";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("El usuario selecciono:\n*****\t\t" + dlg.FileName);

                LeerArchivo(dlg.FileName);
            }
        }

        private void LeerArchivo(String Ruta)
        {
            byte[] contenidoArchivo = File.ReadAllBytes(Ruta);
            MemoryStream memoryStream = new MemoryStream(contenidoArchivo);
            Image imagen = Image.FromStream(memoryStream);

            NuevaHija(Ruta);                               //Al crearse se selecciona
            VentanaHija nuevaVentana = this.HijaActiva;   //Se hace referencia en una variable
                                                          //a la que aplicarle métodos
            nuevaVentana.PictureBox.Image = imagen;       //Ponerle la imagen leida            Read
        }

        private void VisorImágenes_MdiChildActivate(object sender, EventArgs e)
        {
            cascadaToolStripMenuItem.Enabled = this.HijaActiva != null;
            mosaicoHorizontalToolStripMenuItem.Enabled = this.HijaActiva != null;
            mosaicoVerticalToolStripMenuItem.Enabled = this.HijaActiva != null;
  
            ToolStripManager.RevertMerge(this.toolStrip1);
            VentanaHija ventanaHijaActiva = this.ActiveMdiChild as VentanaHija;
            if (ventanaHijaActiva != null)
                ToolStripManager.Merge(ventanaHijaActiva.toolstrip1, this.toolStrip1);
        }

        private void VisorImágenes_DragEnter(object sender, DragEventArgs e)
        {
            // Nos aseguramos de que lo que se está arrastrando son archivos
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                Console.WriteLine("Ruta DragTrazada" + file);
                if (!file.ToLower().EndsWith(".jpg") &&
                !file.ToLower().EndsWith(".bmp") &&
                !file.ToLower().EndsWith(".gif"))
                {
                    e.Effect = DragDropEffects.None; // Alguno de los archivos
                                                     // no es una imagen
                    return;
                }
            }
            e.Effect = DragDropEffects.Copy; // Correcto, son todo imágenes
        }

        private void VisorImágenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                LeerArchivo(file);

        }

        private void mn_Nuevo_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Función:Crear una nueva ventana con una imagen Default";
        }
        private void mn_Nuevo_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Función:";
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            return;
            //throw new NotImplementedException();
            //ToolStripMenuItem Select = (ToolStripMenuItem)sender;
            // Console.WriteLine("\n" + Select.Text);
            /*if (sender is MenuStrip menuItem)
            {
              // Aquí puedes determinar qué opción del menú se está señalando
                string menuText = menuItem.Text;
                // string description = GetDescriptionForMenuItem(menuText); // Función para obtener la descripción correspondiente
                //etiquetaEstado.Text = menuText;
            }*/
        }

        private void mn_Salir_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Función: Salir de la ejecición del programa";
        }

        private void mn_Salir_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Función:";
        }

        private void cerrarToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Función: Cerrar la ventana seleccionada";
        }

        private void cerrarToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Función:";
        }

        private void mn_Abrir_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Función: Abrir una nueva ventana con la imagen seleccionada";
        }

        private void mn_Abrir_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Función:";
        }

        private void mn_OcultarSB_Click(object sender, EventArgs e)
        {
            StatusText.Visible = !StatusText.Visible;
            mn_OcultarSB.Text = StatusText.Visible ? "Ocultar StatusBar" : "Mostrar StatusBar";
        }

        private void mn_OcultarTB_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            mn_OcultarTB.Text = toolStrip1.Visible ? "Ocultar ToolBar" : "Mostrar ToolBar";
        }
    }
}
