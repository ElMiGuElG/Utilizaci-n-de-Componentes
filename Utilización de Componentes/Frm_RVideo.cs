/*
Nombre:Utilización de Componentes en Visual C#

Descripcion:La reutilización de código es muy utilizado en la construcción de aplicaciones,
y se ha convertido en uno de los elementos del agilismo.
Realice la aplicación que reutilice el Windows Media Player, la lectura de archivos PDF
y un navegador web.Cargue por este espacio el vinculo a Github. No se reciben archivos
por este espacio, solo vìnculos al repositorio.

Fecha:27/09/2022
Autor:Santiago Alexis Correa Restrepo; Miguel Angel Galeano Osorio; Santiago Montoya Restrepo
Version 1.0 
*/

// Bienvenido

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
    public partial class Frm_RVideo : Form
    {
        private string Ruta = "";
        public Frm_RVideo()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Cargar_Click(object sender, EventArgs e)
        {
            if (OFD_AbrirMp4.ShowDialog() == DialogResult.OK)
            {
                Ruta = OFD_AbrirMp4.FileName;
                Lbl_Ruta.Text = Ruta;
            }
        }

        private void Btn_Reproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = Ruta;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void Btn_Detener_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void Btn_Pausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void Btn_LectorPdf_Click(object sender, EventArgs e)
        {
            Program.Frm_Inicio.Hide();
            Frm_LectorPDF CambioPdf = new Frm_LectorPDF();
            CambioPdf.Show();
        }

        private void Btn_AppWeb_Click(object sender, EventArgs e)
        {
            Program.Frm_Inicio.Hide();
            Frm_Navegador_Web CambioWeb = new Frm_Navegador_Web();
            CambioWeb.Show();
        }
    }
}
