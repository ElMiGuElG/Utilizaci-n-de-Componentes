
namespace Utilización_de_Componentes
{
    partial class Frm_LectorPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LectorPDF));
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.Lbl_Ruta = new System.Windows.Forms.Label();
            this.Lbl_Direccion = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.OFD_Abrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(209, 130);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(126, 33);
            this.Btn_Salir.TabIndex = 17;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargar.Location = new System.Drawing.Point(58, 130);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(126, 33);
            this.Btn_Cargar.TabIndex = 13;
            this.Btn_Cargar.Text = "Cargar";
            this.Btn_Cargar.UseVisualStyleBackColor = true;
            this.Btn_Cargar.Click += new System.EventHandler(this.Btn_Cargar_Click);
            // 
            // Lbl_Ruta
            // 
            this.Lbl_Ruta.AutoSize = true;
            this.Lbl_Ruta.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ruta.Location = new System.Drawing.Point(134, 90);
            this.Lbl_Ruta.Name = "Lbl_Ruta";
            this.Lbl_Ruta.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Ruta.TabIndex = 12;
            // 
            // Lbl_Direccion
            // 
            this.Lbl_Direccion.AutoSize = true;
            this.Lbl_Direccion.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Direccion.Location = new System.Drawing.Point(55, 90);
            this.Lbl_Direccion.Name = "Lbl_Direccion";
            this.Lbl_Direccion.Size = new System.Drawing.Size(73, 16);
            this.Lbl_Direccion.TabIndex = 11;
            this.Lbl_Direccion.Text = "Direccion:";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(55, 38);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(115, 16);
            this.Lbl_Titulo.TabIndex = 18;
            this.Lbl_Titulo.Text = "Lector de PDF";
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(58, 182);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(778, 391);
            this.axAcroPDF.TabIndex = 19;
            // 
            // OFD_Abrir
            // 
            this.OFD_Abrir.FileName = "OFD_Abrir";
            // 
            // Frm_LectorPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 661);
            this.Controls.Add(this.axAcroPDF);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Cargar);
            this.Controls.Add(this.Lbl_Ruta);
            this.Controls.Add(this.Lbl_Direccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_LectorPDF";
            this.Text = "Lector de PDF";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Cargar;
        private System.Windows.Forms.Label Lbl_Ruta;
        private System.Windows.Forms.Label Lbl_Direccion;
        private System.Windows.Forms.Label Lbl_Titulo;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.OpenFileDialog OFD_Abrir;
    }
}