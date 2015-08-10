namespace ConversiorNumerosRomanos
{
    partial class MainWindow
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
            this.Info = new System.Windows.Forms.Label();
            this.textoEntrada = new System.Windows.Forms.TextBox();
            this.botonConvertir = new System.Windows.Forms.Button();
            this.textoSalida = new System.Windows.Forms.TextBox();
            this.Info2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(9, 9);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(137, 13);
            this.Info.TabIndex = 0;
            this.Info.Text = "Ingrese un numero decimal:";
            // 
            // textoEntrada
            // 
            this.textoEntrada.Location = new System.Drawing.Point(12, 33);
            this.textoEntrada.Name = "textoEntrada";
            this.textoEntrada.Size = new System.Drawing.Size(238, 20);
            this.textoEntrada.TabIndex = 1;
            // 
            // botonConvertir
            // 
            this.botonConvertir.Location = new System.Drawing.Point(260, 31);
            this.botonConvertir.Name = "botonConvertir";
            this.botonConvertir.Size = new System.Drawing.Size(75, 23);
            this.botonConvertir.TabIndex = 2;
            this.botonConvertir.Text = "Convertir";
            this.botonConvertir.UseVisualStyleBackColor = true;
            // 
            // textoSalida
            // 
            this.textoSalida.Location = new System.Drawing.Point(12, 110);
            this.textoSalida.Name = "textoSalida";
            this.textoSalida.ReadOnly = true;
            this.textoSalida.Size = new System.Drawing.Size(323, 20);
            this.textoSalida.TabIndex = 3;
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(11, 85);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(90, 13);
            this.Info2.TabIndex = 4;
            this.Info2.Text = "Numero Romano:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 141);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.textoSalida);
            this.Controls.Add(this.botonConvertir);
            this.Controls.Add(this.textoEntrada);
            this.Controls.Add(this.Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Conversor de Numeros Romanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.TextBox textoEntrada;
        private System.Windows.Forms.Button botonConvertir;
        private System.Windows.Forms.TextBox textoSalida;
        private System.Windows.Forms.Label Info2;
    }
}

