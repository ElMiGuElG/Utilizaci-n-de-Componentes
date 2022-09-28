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
    public partial class Frm_Navegador_Web : Form
    {
        List<string> Favoritos = new List<string>();
        public Frm_Navegador_Web()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void Btn_Adelante_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void Btn_Detener_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(Txt_Buscar.Text);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias Por Usar Este Pequeño Navegador");
            this.Dispose();
            Program.Frm_Inicio.Show();
        }

        private void Frm_Navegador_Web_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("www.google.com.do");
            Txt_Buscar.Text = "www.google.com.do";
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Favoritos.Add(webBrowser.Url.ToString());
            Actualizar();
        }

        private void Actualizar(){
            Cbo_ListaAgregados.Items.Clear();
            foreach (string Direccion in Favoritos)
            {
                Cbo_ListaAgregados.Items.Add(Direccion);
            }
        }

        private void Cbo_ListaAgregados_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser.Navigate(Cbo_ListaAgregados.SelectedItem.ToString());
        }
    }
}
