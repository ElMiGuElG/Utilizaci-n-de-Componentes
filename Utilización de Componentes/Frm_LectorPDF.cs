using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilización_de_Componentes
{
    public partial class Frm_LectorPDF : Form
    {
        public string Ruta = "";
        public Frm_LectorPDF()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Cargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFD_Abrir.ShowDialog() == DialogResult.OK)
                {
                    Ruta = OFD_Abrir.FileName;
                    Lbl_Ruta.Text = Ruta;

                    axAcroPDF.LoadFile(Ruta);
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al Cargar El Arhcivo\nCodigo de Error:"+Error);
            }

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias Por Usar Nuestra App");
            this.Dispose();
            Program.Frm_Inicio.Show();
        }
    }
}
