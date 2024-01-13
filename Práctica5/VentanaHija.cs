using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Práctica5
{
    public partial class VentanaHija : Form
    {
        public PictureBox PictureBox
        {
            get { return pb_Hija; }
        }
        public VentanaHija(string nombre)
        {
            InitializeComponent();
            this.Text = nombre;
            this.Name = nombre;

            this.Resize += VentanaHija_Resize;
        }

        public ToolStrip toolstrip1 
        {
            get { return toolStrip1; }
        }

        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
                this.PictureBox.Size = this.ClientSize;
        }

        private void ajustarAVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.AutoSize)
            {
                this.AutoScroll = false;
                this.PictureBox.Size = this.ClientSize;
                this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.Zoom)
            {
                this.AutoScroll = true;
                this.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            ajustarAVentanaToolStripMenuItem.Checked = PictureBox.SizeMode == PictureBoxSizeMode.Zoom;
        }

        private void rotarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image != null)
            {
                PictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                PictureBox.Size = ClientSize;
                PictureBox.Invalidate();
            }
        }

        private void añadirTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Graphics gfx = Graphics.FromImage(this.PictureBox.Image))
            {
                Font fuente = new Font("Arial", 20);
                Brush brocha = new SolidBrush(Color.Red); 
                gfx.DrawString("Programación Visual", fuente, brocha, 0, 0);
            }

            PictureBox.Invalidate();
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = this.PictureBox;
            Image imagen = pictureBox.Image;

            using (Graphics gfx = Graphics.FromImage(imagen))
            {
                // Matriz para realizar una transformación a escala de grises
                ColorMatrix cm = new ColorMatrix(new float[][]{
            new float[] {0.3f, 0.3f, 0.3f, 0, 0},
            new float[] {0.59f, 0.59f, 0.59f, 0, 0},
            new float[] {0.11f, 0.11f, 0.11f, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
        });

                // Información acerca de la manipulación de los colores del mapa de bits
                ImageAttributes atrImg = new ImageAttributes();
                atrImg.SetColorMatrix(cm);

                // Dibujar la imagen aplicando la transformación de escala de grises:
                gfx.DrawImage(imagen, new Rectangle(0, 0, imagen.Width, imagen.Height), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, atrImg);
            }

            // Refrescar el pictureBox para mostrar la imagen en escala de grises
            pictureBox.Invalidate();
        }

        private void mn_GuardarComo_Click(object sender, EventArgs e)
        { 
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Guardar Imagen";
            dlg.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos los archivos|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("Elemento guardado\t" + dlg.FileName);
                string rutaArchivo = dlg.FileName;
                string extension = Path.GetExtension(rutaArchivo).ToLower();

               
                // Guardar la imagen en el formato seleccionado
                if (extension == ".jpg" || extension == ".jpeg")
                {
                    pb_Hija.Image.Save(rutaArchivo, ImageFormat.Jpeg); // Guardar en formato JPEG
                }
                else if (extension == ".png")
                {
                    pb_Hija.Image.Save(rutaArchivo, ImageFormat.Png); // Guardar en formato PNG
                }
                else if (extension == ".bmp")
                {
                    pb_Hija.Image.Save(rutaArchivo, ImageFormat.Bmp); // Guardar en formato BMP
                }
                else if (extension == ".gif")
                {
                    pb_Hija.Image.Save(rutaArchivo, ImageFormat.Gif); // Guardar en formato GIF
                }
                else
                {
                    MessageBox.Show("Formato de archivo no válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Text = Path.GetFileName(rutaArchivo);
            }
        }

        private void mn_Guardar_Click(object sender, EventArgs e)
        {
            string NombrePestaña = this.Text;

            if (NombrePestaña.StartsWith("Doc"))
            {   // Mismo código que "Guardar como..."
                Console.WriteLine("Empieza por Doc");
                mn_GuardarComo.PerformClick();
            }
            else
            {// La guardamos en el mismo archivo de donde la leímos.
                string rutaArchivo = "C:\\Users\\HP\\Pictures\\Saved Pictures\\" + this.Text;
                
                string extension = Path.GetExtension(rutaArchivo).ToLower();

                //Console.WriteLine("Nuevo método" + Directory.GetCurrentDirectory());

                if (extension == ".jpg" || extension == ".jpeg")
                {
                    pb_Hija.Image.Save(rutaArchivo, ImageFormat.Jpeg); // Guardar en formato JPEG
                }
                else if (extension == ".png")
                {
                    pb_Hija.Image.Save(rutaArchivo, ImageFormat.Png); // Guardar en formato PNG
                }
                else if (extension == ".bmp")
                {
                    pb_Hija.Image.Save(rutaArchivo, ImageFormat.Bmp); // Guardar en formato BMP
                }
                else if (extension == ".gif")
                {
                    pb_Hija.Image.Save(rutaArchivo, ImageFormat.Gif); // Guardar en formato GIF
                }
                else
                {
                    MessageBox.Show("Formato de archivo no válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Console.WriteLine("Sobrescrito adecuadamente");
            }            
        }
   
    }
}
