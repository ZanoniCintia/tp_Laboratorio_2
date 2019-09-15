namespace MiCalculadora
{
    partial class calculadora
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
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonBinario = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.textNumeroDos = new System.Windows.Forms.TextBox();
            this.textNumeroUno = new System.Windows.Forms.TextBox();
            this.comboBoxOperadores = new System.Windows.Forms.ComboBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOperar
            // 
            this.buttonOperar.Location = new System.Drawing.Point(14, 209);
            this.buttonOperar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(170, 68);
            this.buttonOperar.TabIndex = 0;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.ButtonOperar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(241, 209);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(170, 68);
            this.buttonLimpiar.TabIndex = 1;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(447, 209);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(170, 68);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // buttonBinario
            // 
            this.buttonBinario.Location = new System.Drawing.Point(14, 319);
            this.buttonBinario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBinario.Name = "buttonBinario";
            this.buttonBinario.Size = new System.Drawing.Size(271, 75);
            this.buttonBinario.TabIndex = 3;
            this.buttonBinario.Text = "Convertir a binario";
            this.buttonBinario.UseVisualStyleBackColor = true;
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Location = new System.Drawing.Point(362, 319);
            this.buttonDecimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(255, 75);
            this.buttonDecimal.TabIndex = 4;
            this.buttonDecimal.Text = "Convertir a decimal";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            // 
            // textNumeroDos
            // 
            this.textNumeroDos.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroDos.Location = new System.Drawing.Point(447, 139);
            this.textNumeroDos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNumeroDos.Name = "textNumeroDos";
            this.textNumeroDos.Size = new System.Drawing.Size(170, 39);
            this.textNumeroDos.TabIndex = 5;
            // 
            // textNumeroUno
            // 
            this.textNumeroUno.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroUno.Location = new System.Drawing.Point(14, 137);
            this.textNumeroUno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNumeroUno.Name = "textNumeroUno";
            this.textNumeroUno.Size = new System.Drawing.Size(170, 39);
            this.textNumeroUno.TabIndex = 6;
            this.textNumeroUno.TextChanged += new System.EventHandler(this.TextNumeroUno_TextChanged);
            // 
            // comboBoxOperadores
            // 
            this.comboBoxOperadores.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperadores.FormattingEnabled = true;
            this.comboBoxOperadores.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperadores.Location = new System.Drawing.Point(241, 137);
            this.comboBoxOperadores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxOperadores.Name = "comboBoxOperadores";
            this.comboBoxOperadores.Size = new System.Drawing.Size(170, 39);
            this.comboBoxOperadores.TabIndex = 7;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(483, 77);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(134, 31);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "Resultado";
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 423);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.comboBoxOperadores);
            this.Controls.Add(this.textNumeroUno);
            this.Controls.Add(this.textNumeroDos);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonBinario);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonOperar);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calculadora";
            this.Text = "Calculadora de Zanoni Cintia del curso 2°C";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonBinario;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.TextBox textNumeroDos;
        private System.Windows.Forms.TextBox textNumeroUno;
        private System.Windows.Forms.ComboBox comboBoxOperadores;
        private System.Windows.Forms.Label labelResultado;
    }
}

