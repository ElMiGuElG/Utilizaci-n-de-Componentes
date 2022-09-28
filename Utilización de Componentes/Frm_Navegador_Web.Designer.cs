
namespace Utilización_de_Componentes
{
    partial class Frm_Navegador_Web
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Navegador_Web));
            this.Btn_Atras = new System.Windows.Forms.Button();
            this.Btn_Adelante = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Detener = new System.Windows.Forms.Button();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.Cbo_ListaAgregados = new System.Windows.Forms.ComboBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Atras
            // 
            this.Btn_Atras.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Atras.Location = new System.Drawing.Point(12, 22);
            this.Btn_Atras.Name = "Btn_Atras";
            this.Btn_Atras.Size = new System.Drawing.Size(36, 23);
            this.Btn_Atras.TabIndex = 0;
            this.Btn_Atras.Text = "<";
            this.Btn_Atras.UseVisualStyleBackColor = true;
            this.Btn_Atras.Click += new System.EventHandler(this.Btn_Atras_Click);
            // 
            // Btn_Adelante
            // 
            this.Btn_Adelante.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adelante.Location = new System.Drawing.Point(54, 22);
            this.Btn_Adelante.Name = "Btn_Adelante";
            this.Btn_Adelante.Size = new System.Drawing.Size(34, 23);
            this.Btn_Adelante.TabIndex = 1;
            this.Btn_Adelante.Text = ">";
            this.Btn_Adelante.UseVisualStyleBackColor = true;
            this.Btn_Adelante.Click += new System.EventHandler(this.Btn_Adelante_Click);
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Location = new System.Drawing.Point(94, 22);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(34, 23);
            this.Btn_Refrescar.TabIndex = 2;
            this.Btn_Refrescar.Text = "R";
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            this.Btn_Refrescar.Click += new System.EventHandler(this.Btn_Refrescar_Click);
            // 
            // Btn_Detener
            // 
            this.Btn_Detener.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detener.Location = new System.Drawing.Point(134, 22);
            this.Btn_Detener.Name = "Btn_Detener";
            this.Btn_Detener.Size = new System.Drawing.Size(34, 23);
            this.Btn_Detener.TabIndex = 3;
            this.Btn_Detener.Text = "S";
            this.Btn_Detener.UseVisualStyleBackColor = true;
            this.Btn_Detener.Click += new System.EventHandler(this.Btn_Detener_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.Location = new System.Drawing.Point(174, 22);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(34, 23);
            this.Btn_Home.TabIndex = 4;
            this.Btn_Home.Text = "H";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(519, 24);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(63, 23);
            this.Btn_Buscar.TabIndex = 5;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(793, 54);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Buscar.Location = new System.Drawing.Point(214, 22);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(299, 25);
            this.Txt_Buscar.TabIndex = 7;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 83);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(856, 554);
            this.webBrowser.TabIndex = 8;
            // 
            // Cbo_ListaAgregados
            // 
            this.Cbo_ListaAgregados.FormattingEnabled = true;
            this.Cbo_ListaAgregados.Location = new System.Drawing.Point(588, 25);
            this.Cbo_ListaAgregados.Name = "Cbo_ListaAgregados";
            this.Cbo_ListaAgregados.Size = new System.Drawing.Size(121, 21);
            this.Cbo_ListaAgregados.TabIndex = 9;
            this.Cbo_ListaAgregados.SelectedIndexChanged += new System.EventHandler(this.Cbo_ListaAgregados_SelectedIndexChanged);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(715, 23);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(153, 25);
            this.Btn_Agregar.TabIndex = 10;
            this.Btn_Agregar.Text = "Agregar a Favoritos";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Frm_Navegador_Web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 661);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Cbo_ListaAgregados);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Btn_Detener);
            this.Controls.Add(this.Btn_Refrescar);
            this.Controls.Add(this.Btn_Adelante);
            this.Controls.Add(this.Btn_Atras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Navegador_Web";
            this.Text = "Navegador Web";
            this.Load += new System.EventHandler(this.Frm_Navegador_Web_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Atras;
        private System.Windows.Forms.Button Btn_Adelante;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.Button Btn_Detener;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ComboBox Cbo_ListaAgregados;
        private System.Windows.Forms.Button Btn_Agregar;
    }
}