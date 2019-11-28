namespace ProyVentas_GUI
{
    partial class Jugador03
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.chkCapitan = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtRepVentas = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cboEquipo);
            this.grpDatos.Controls.Add(this.chkCapitan);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.txtPais);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.txtEdad);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.cboRol);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtNick);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.txtRepVentas);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(9, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(400, 284);
            this.grpDatos.TabIndex = 8;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // cboEquipo
            // 
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Location = new System.Drawing.Point(101, 228);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(162, 21);
            this.cboEquipo.TabIndex = 32;
            // 
            // chkCapitan
            // 
            this.chkCapitan.AutoSize = true;
            this.chkCapitan.Location = new System.Drawing.Point(101, 170);
            this.chkCapitan.Name = "chkCapitan";
            this.chkCapitan.Size = new System.Drawing.Size(15, 14);
            this.chkCapitan.TabIndex = 31;
            this.chkCapitan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "¿Capitán?";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(101, 141);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(192, 20);
            this.txtPais.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "País:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(101, 116);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(36, 20);
            this.txtEdad.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Edad:";
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "Hard Carry",
            "Midlaner",
            "Offlaner",
            "Roaming",
            "Support"});
            this.cboRol.Location = new System.Drawing.Point(101, 195);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(162, 21);
            this.cboRol.TabIndex = 21;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(310, 109);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(72, 24);
            this.btnGrabar.TabIndex = 24;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click_1);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(15, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(101, 26);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(192, 20);
            this.txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(101, 90);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(192, 20);
            this.txtNick.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(15, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Nombre:";
            // 
            // txtRepVentas
            // 
            this.txtRepVentas.Location = new System.Drawing.Point(15, 231);
            this.txtRepVentas.Name = "txtRepVentas";
            this.txtRepVentas.Size = new System.Drawing.Size(80, 18);
            this.txtRepVentas.TabIndex = 19;
            this.txtRepVentas.Text = "Equipo:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(15, 89);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Nickname:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(15, 198);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Rol:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(310, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 24);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // Jugador03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 308);
            this.Controls.Add(this.grpDatos);
            this.Name = "Jugador03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Jugador";
            this.Load += new System.EventHandler(this.ProveedorMan03_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.CheckBox chkCapitan;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtPais;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtEdad;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRol;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtNick;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label txtRepVentas;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCancelar;
    }
}