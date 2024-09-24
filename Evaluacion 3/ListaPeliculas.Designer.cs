namespace Evaluacion_3
{
    partial class ListaPeliculas
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.clbGeneros = new System.Windows.Forms.CheckedListBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.cbPuntaje = new System.Windows.Forms.ComboBox();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.lblLista_peli = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(34, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(144, 14);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de la Película:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(184, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(33, 85);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(47, 13);
            this.lblDirector.TabIndex = 2;
            this.lblDirector.Text = "Director:";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(87, 85);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(100, 20);
            this.txtDirector.TabIndex = 3;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(401, 35);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(55, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género/s:";
            // 
            // clbGeneros
            // 
            this.clbGeneros.CheckOnClick = true;
            this.clbGeneros.FormattingEnabled = true;
            this.clbGeneros.Items.AddRange(new object[] {
            "Aventura",
            "Acción",
            "Ciencia Ficción",
            "Romance",
            "Drama",
            "Terror",
            "Suspenso",
            "Histórico"});
            this.clbGeneros.Location = new System.Drawing.Point(462, 35);
            this.clbGeneros.Name = "clbGeneros";
            this.clbGeneros.Size = new System.Drawing.Size(100, 139);
            this.clbGeneros.TabIndex = 5;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(227, 85);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(76, 13);
            this.lblAnio.TabIndex = 6;
            this.lblAnio.Text = "Año de Salida:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(309, 82);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(51, 20);
            this.txtAnio.TabIndex = 7;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(36, 171);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(104, 30);
            this.btCargar.TabIndex = 8;
            this.btCargar.Text = "Cargar Película";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // cbPuntaje
            // 
            this.cbPuntaje.FormattingEnabled = true;
            this.cbPuntaje.Items.AddRange(new object[] {
            "***** (5) Estrellas",
            "****   (4) Estrellas",
            "***     (3) Estrellas",
            "**       (2) Estrellas",
            "*         (1) Estrella"});
            this.cbPuntaje.Location = new System.Drawing.Point(669, 37);
            this.cbPuntaje.Name = "cbPuntaje";
            this.cbPuntaje.Size = new System.Drawing.Size(119, 21);
            this.cbPuntaje.TabIndex = 9;
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(599, 35);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(64, 13);
            this.lblPuntuacion.TabIndex = 10;
            this.lblPuntuacion.Text = "Puntuación:";
            // 
            // lblLista_peli
            // 
            this.lblLista_peli.AutoSize = true;
            this.lblLista_peli.Location = new System.Drawing.Point(12, 221);
            this.lblLista_peli.Name = "lblLista_peli";
            this.lblLista_peli.Size = new System.Drawing.Size(92, 13);
            this.lblLista_peli.TabIndex = 11;
            this.lblLista_peli.Text = "Lista de Peliculas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Evaluacion_3.Properties.Resources.CRACK;
            this.pictureBox1.Location = new System.Drawing.Point(293, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ListaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLista_peli);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.cbPuntaje);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.clbGeneros);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "ListaPeliculas";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.CheckedListBox clbGeneros;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.ComboBox cbPuntaje;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Label lblLista_peli;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

