namespace primerasolucion
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lwUNO = new System.Windows.Forms.ListView();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.cajatxtDOS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "apretame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(593, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // lwUNO
            // 
            this.lwUNO.HideSelection = false;
            this.lwUNO.Location = new System.Drawing.Point(61, 153);
            this.lwUNO.Name = "lwUNO";
            this.lwUNO.Size = new System.Drawing.Size(208, 225);
            this.lwUNO.TabIndex = 4;
            this.lwUNO.UseCompatibleStateImageBehavior = false;
            this.lwUNO.View = System.Windows.Forms.View.List;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(61, 110);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 5;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // cajatxtDOS
            // 
            this.cajatxtDOS.Location = new System.Drawing.Point(169, 110);
            this.cajatxtDOS.Name = "cajatxtDOS";
            this.cajatxtDOS.Size = new System.Drawing.Size(100, 20);
            this.cajatxtDOS.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cajatxtDOS);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.lwUNO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lwUNO;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.TextBox cajatxtDOS;
    }
}

