
namespace Utilización_de_Componentes
{
    partial class Frm_RVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RVideo));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Direccion = new System.Windows.Forms.Label();
            this.Lbl_Ruta = new System.Windows.Forms.Label();
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.Btn_Reproducir = new System.Windows.Forms.Button();
            this.Btn_Pausa = new System.Windows.Forms.Button();
            this.Btn_Detener = new System.Windows.Forms.Button();
            this.OFD_AbrirMp4 = new System.Windows.Forms.OpenFileDialog();
            this.Btn_LectorPdf = new System.Windows.Forms.Button();
            this.Btn_AppWeb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(56, 59);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(778, 418);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(53, 31);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(169, 16);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Reproductor de Video";
            // 
            // Lbl_Direccion
            // 
            this.Lbl_Direccion.AutoSize = true;
            this.Lbl_Direccion.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Direccion.Location = new System.Drawing.Point(53, 495);
            this.Lbl_Direccion.Name = "Lbl_Direccion";
            this.Lbl_Direccion.Size = new System.Drawing.Size(73, 16);
            this.Lbl_Direccion.TabIndex = 2;
            this.Lbl_Direccion.Text = "Direccion:";
            // 
            // Lbl_Ruta
            // 
            this.Lbl_Ruta.AutoSize = true;
            this.Lbl_Ruta.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ruta.Location = new System.Drawing.Point(132, 495);
            this.Lbl_Ruta.Name = "Lbl_Ruta";
            this.Lbl_Ruta.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Ruta.TabIndex = 3;
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargar.Location = new System.Drawing.Point(56, 535);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(75, 33);
            this.Btn_Cargar.TabIndex = 4;
            this.Btn_Cargar.Text = "Cargar";
            this.Btn_Cargar.UseVisualStyleBackColor = true;
            this.Btn_Cargar.Click += new System.EventHandler(this.Btn_Cargar_Click);
            // 
            // Btn_Reproducir
            // 
            this.Btn_Reproducir.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reproducir.Location = new System.Drawing.Point(146, 535);
            this.Btn_Reproducir.Name = "Btn_Reproducir";
            this.Btn_Reproducir.Size = new System.Drawing.Size(94, 33);
            this.Btn_Reproducir.TabIndex = 5;
            this.Btn_Reproducir.Text = "Reproducir";
            this.Btn_Reproducir.UseVisualStyleBackColor = true;
            this.Btn_Reproducir.Click += new System.EventHandler(this.Btn_Reproducir_Click);
            // 
            // Btn_Pausa
            // 
            this.Btn_Pausa.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pausa.Location = new System.Drawing.Point(349, 535);
            this.Btn_Pausa.Name = "Btn_Pausa";
            this.Btn_Pausa.Size = new System.Drawing.Size(75, 33);
            this.Btn_Pausa.TabIndex = 7;
            this.Btn_Pausa.Text = "Pausar";
            this.Btn_Pausa.UseVisualStyleBackColor = true;
            this.Btn_Pausa.Click += new System.EventHandler(this.Btn_Pausa_Click);
            // 
            // Btn_Detener
            // 
            this.Btn_Detener.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detener.Location = new System.Drawing.Point(257, 535);
            this.Btn_Detener.Name = "Btn_Detener";
            this.Btn_Detener.Size = new System.Drawing.Size(75, 33);
            this.Btn_Detener.TabIndex = 6;
            this.Btn_Detener.Text = "Detener";
            this.Btn_Detener.UseVisualStyleBackColor = true;
            this.Btn_Detener.Click += new System.EventHandler(this.Btn_Detener_Click);
            // 
            // OFD_AbrirMp4
            // 
            this.OFD_AbrirMp4.FileName = "OFD_AbrirMp4";
            // 
            // Btn_LectorPdf
            // 
            this.Btn_LectorPdf.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LectorPdf.Location = new System.Drawing.Point(497, 588);
            this.Btn_LectorPdf.Name = "Btn_LectorPdf";
            this.Btn_LectorPdf.Size = new System.Drawing.Size(159, 46);
            this.Btn_LectorPdf.TabIndex = 8;
            this.Btn_LectorPdf.Text = "Ir al Lector de PDF";
            this.Btn_LectorPdf.UseVisualStyleBackColor = true;
            this.Btn_LectorPdf.Click += new System.EventHandler(this.Btn_LectorPdf_Click);
            // 
            // Btn_AppWeb
            // 
            this.Btn_AppWeb.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AppWeb.Location = new System.Drawing.Point(673, 588);
            this.Btn_AppWeb.Name = "Btn_AppWeb";
            this.Btn_AppWeb.Size = new System.Drawing.Size(161, 46);
            this.Btn_AppWeb.TabIndex = 9;
            this.Btn_AppWeb.Text = "Ir al Navegador Web";
            this.Btn_AppWeb.UseVisualStyleBackColor = true;
            this.Btn_AppWeb.Click += new System.EventHandler(this.Btn_AppWeb_Click);
            // 
            // Frm_RVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 661);
            this.Controls.Add(this.Btn_AppWeb);
            this.Controls.Add(this.Btn_LectorPdf);
            this.Controls.Add(this.Btn_Detener);
            this.Controls.Add(this.Btn_Pausa);
            this.Controls.Add(this.Btn_Reproducir);
            this.Controls.Add(this.Btn_Cargar);
            this.Controls.Add(this.Lbl_Ruta);
            this.Controls.Add(this.Lbl_Direccion);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RVideo";
            this.Text = "Reproductor de Video";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Direccion;
        private System.Windows.Forms.Label Lbl_Ruta;
        private System.Windows.Forms.Button Btn_Cargar;
        private System.Windows.Forms.Button Btn_Reproducir;
        private System.Windows.Forms.Button Btn_Pausa;
        private System.Windows.Forms.Button Btn_Detener;
        private System.Windows.Forms.OpenFileDialog OFD_AbrirMp4;
        private System.Windows.Forms.Button Btn_LectorPdf;
        private System.Windows.Forms.Button Btn_AppWeb;
    }
}

