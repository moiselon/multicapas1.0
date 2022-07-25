namespace Multicapas
{
    partial class form2
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
            this.label10 = new System.Windows.Forms.Label();
            this.tbcumpleaño = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbestado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbgenero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvcontactos = new System.Windows.Forms.DataGridView();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactos)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "DATOS";
            // 
            // tbcumpleaño
            // 
            this.tbcumpleaño.Location = new System.Drawing.Point(162, 306);
            this.tbcumpleaño.Name = "tbcumpleaño";
            this.tbcumpleaño.Size = new System.Drawing.Size(160, 20);
            this.tbcumpleaño.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "FECHA DE NACIMIENTO:";
            // 
            // tbestado
            // 
            this.tbestado.Location = new System.Drawing.Point(162, 273);
            this.tbestado.Name = "tbestado";
            this.tbestado.Size = new System.Drawing.Size(160, 20);
            this.tbestado.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "ESTADO:";
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(162, 234);
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(160, 20);
            this.tbdireccion.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "DIRECCION:";
            // 
            // tbgenero
            // 
            this.tbgenero.Location = new System.Drawing.Point(162, 193);
            this.tbgenero.Name = "tbgenero";
            this.tbgenero.Size = new System.Drawing.Size(160, 20);
            this.tbgenero.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "GENERO:";
            // 
            // dgvcontactos
            // 
            this.dgvcontactos.AllowUserToAddRows = false;
            this.dgvcontactos.AllowUserToDeleteRows = false;
            this.dgvcontactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontactos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvcontactos.Location = new System.Drawing.Point(5, 375);
            this.dgvcontactos.Name = "dgvcontactos";
            this.dgvcontactos.ReadOnly = true;
            this.dgvcontactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcontactos.Size = new System.Drawing.Size(904, 223);
            this.dgvcontactos.TabIndex = 33;
            this.dgvcontactos.DoubleClick += new System.EventHandler(this.dgvcontactos_DoubleClick);
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(725, 66);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(103, 32);
            this.btngrabar.TabIndex = 32;
            this.btngrabar.Text = "Grabar Archivo";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(597, 71);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(103, 23);
            this.btnborrar.TabIndex = 31;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(456, 71);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 25);
            this.btnagregar.TabIndex = 30;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "E-MAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "TELEFONO:";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(162, 159);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(160, 20);
            this.tbemail.TabIndex = 27;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(162, 120);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(160, 20);
            this.tbtelefono.TabIndex = 26;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(162, 78);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(160, 20);
            this.tbapellido.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "APELLDO(S):";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(86, -41);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(160, 20);
            this.tbnombre.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, -38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "NOMBRE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "NOMBRE:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(162, 32);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(160, 20);
            this.tbname.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(368, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 21);
            this.label11.TabIndex = 45;
            this.label11.Text = "ingresar datos";
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(918, 620);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbcumpleaño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbestado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbdireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbgenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvcontactos);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label1);
            this.Name = "form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "agenda";
            this.Load += new System.EventHandler(this.form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbcumpleaño;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbdireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbgenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvcontactos;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label11;
    }
}