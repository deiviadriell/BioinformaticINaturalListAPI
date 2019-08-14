namespace BioinformaticINaturalListAPI
{
    partial class frm_InaturalList
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFechaObservacion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnINaturalVer = new System.Windows.Forms.Button();
            this.btnSigueinte = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especie / Species";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(115, 14);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(157, 20);
            this.txtEspecie.TabIndex = 1;
            this.txtEspecie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEspecie_KeyUp);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(278, 11);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(112, 23);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.Text = "Search / Buscar";
            this.txt_buscar.UseVisualStyleBackColor = true;
            this.txt_buscar.Click += new System.EventHandler(this.txt_buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUltimo);
            this.groupBox1.Controls.Add(this.btnPrimero);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.btnSigueinte);
            this.groupBox1.Controls.Add(this.btnINaturalVer);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtLocalidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFechaObservacion);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtLongitud);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtLatitud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 594);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado / Response";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Latitud";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(63, 46);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(123, 20);
            this.txtLatitud.TabIndex = 4;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(243, 46);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(123, 20);
            this.txtLongitud.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(189, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Longitud";
            // 
            // txtFechaObservacion
            // 
            this.txtFechaObservacion.Location = new System.Drawing.Point(496, 50);
            this.txtFechaObservacion.Name = "txtFechaObservacion";
            this.txtFechaObservacion.Size = new System.Drawing.Size(123, 20);
            this.txtFechaObservacion.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(375, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "Fecha de Observación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(63, 77);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(427, 20);
            this.txtLocalidad.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BioinformaticINaturalListAPI.Properties.Resources.zelenyi_fon_model_zelenaia_stebel_liagushka_krasotka_fauna_1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // btnINaturalVer
            // 
            this.btnINaturalVer.Location = new System.Drawing.Point(496, 74);
            this.btnINaturalVer.Name = "btnINaturalVer";
            this.btnINaturalVer.Size = new System.Drawing.Size(123, 23);
            this.btnINaturalVer.TabIndex = 46;
            this.btnINaturalVer.Text = "Ver en INatural";
            this.btnINaturalVer.UseVisualStyleBackColor = true;
            this.btnINaturalVer.Click += new System.EventHandler(this.btnINaturalVer_Click);
            // 
            // btnSigueinte
            // 
            this.btnSigueinte.Location = new System.Drawing.Point(633, 565);
            this.btnSigueinte.Name = "btnSigueinte";
            this.btnSigueinte.Size = new System.Drawing.Size(67, 23);
            this.btnSigueinte.TabIndex = 47;
            this.btnSigueinte.Text = "Siguiente";
            this.btnSigueinte.UseVisualStyleBackColor = true;
            this.btnSigueinte.Click += new System.EventHandler(this.btnSigueinte_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(566, 565);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(61, 23);
            this.btnAnterior.TabIndex = 48;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(18, 575);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(60, 13);
            this.lblResultado.TabIndex = 49;
            this.lblResultado.Text = "Resultados";
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(496, 565);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(64, 23);
            this.btnPrimero.TabIndex = 50;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(702, 565);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(67, 23);
            this.btnUltimo.TabIndex = 51;
            this.btnUltimo.Text = "último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // frm_InaturalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frm_InaturalList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INaturalList";
            this.Load += new System.EventHandler(this.frm_InaturalList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Button txt_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaObservacion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnINaturalVer;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSigueinte;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
    }
}

