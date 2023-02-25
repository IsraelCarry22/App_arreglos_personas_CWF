namespace App_arreglos_personas_CWF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BtmAgregar = new System.Windows.Forms.Button();
            this.Btmnuevo = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.dvgDatos = new System.Windows.Forms.DataGridView();
            this.NumData = new System.Windows.Forms.NumericUpDown();
            this.dtmFechaCumpleaños = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num Campos:";
            // 
            // BtmAgregar
            // 
            this.BtmAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtmAgregar.Location = new System.Drawing.Point(552, 44);
            this.BtmAgregar.Name = "BtmAgregar";
            this.BtmAgregar.Size = new System.Drawing.Size(101, 35);
            this.BtmAgregar.TabIndex = 1;
            this.BtmAgregar.Text = "Agregar";
            this.BtmAgregar.UseVisualStyleBackColor = true;
            this.BtmAgregar.Click += new System.EventHandler(this.BtmAgregar_Click);
            // 
            // Btmnuevo
            // 
            this.Btmnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btmnuevo.Location = new System.Drawing.Point(552, 96);
            this.Btmnuevo.Name = "Btmnuevo";
            this.Btmnuevo.Size = new System.Drawing.Size(101, 35);
            this.Btmnuevo.TabIndex = 2;
            this.Btmnuevo.Text = "Guardar";
            this.Btmnuevo.UseVisualStyleBackColor = true;
            this.Btmnuevo.Click += new System.EventHandler(this.Btmnuevo_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(148, 44);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(398, 20);
            this.txtNombres.TabIndex = 3;
            // 
            // dvgDatos
            // 
            this.dvgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDatos.Location = new System.Drawing.Point(12, 201);
            this.dvgDatos.Name = "dvgDatos";
            this.dvgDatos.Size = new System.Drawing.Size(641, 237);
            this.dvgDatos.TabIndex = 4;
            // 
            // NumData
            // 
            this.NumData.Location = new System.Drawing.Point(148, 12);
            this.NumData.Name = "NumData";
            this.NumData.Size = new System.Drawing.Size(129, 20);
            this.NumData.TabIndex = 5;
            // 
            // dtmFechaCumpleaños
            // 
            this.dtmFechaCumpleaños.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaCumpleaños.Location = new System.Drawing.Point(166, 175);
            this.dtmFechaCumpleaños.Name = "dtmFechaCumpleaños";
            this.dtmFechaCumpleaños.Size = new System.Drawing.Size(96, 20);
            this.dtmFechaCumpleaños.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha cumpleaños:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(148, 148);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(398, 20);
            this.txtCorreo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(148, 122);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(398, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apellido Materno:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(148, 96);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(398, 20);
            this.txtApellidoMaterno.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Apellido paterno:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(148, 70);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(398, 20);
            this.txtApellidoPaterno.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtmFechaCumpleaños);
            this.Controls.Add(this.NumData);
            this.Controls.Add(this.dvgDatos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.Btmnuevo);
            this.Controls.Add(this.BtmAgregar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtmAgregar;
        private System.Windows.Forms.Button Btmnuevo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DataGridView dvgDatos;
        private System.Windows.Forms.NumericUpDown NumData;
        private System.Windows.Forms.DateTimePicker dtmFechaCumpleaños;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

