
namespace ClienteUDP
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtIpDestino = new System.Windows.Forms.TextBox();
            this.txtPuertoDesstino = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(40, 37);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(151, 22);
            this.txtPuerto.TabIndex = 1;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(40, 161);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensaje.Size = new System.Drawing.Size(550, 208);
            this.txtMensaje.TabIndex = 2;
            // 
            // txtIpDestino
            // 
            this.txtIpDestino.Location = new System.Drawing.Point(40, 118);
            this.txtIpDestino.Name = "txtIpDestino";
            this.txtIpDestino.Size = new System.Drawing.Size(216, 22);
            this.txtIpDestino.TabIndex = 3;
            this.txtIpDestino.Text = "127.0.0.1";
            // 
            // txtPuertoDesstino
            // 
            this.txtPuertoDesstino.Location = new System.Drawing.Point(297, 118);
            this.txtPuertoDesstino.Name = "txtPuertoDesstino";
            this.txtPuertoDesstino.Size = new System.Drawing.Size(151, 22);
            this.txtPuertoDesstino.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(664, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(493, 340);
            this.listBox1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPuertoDesstino);
            this.Controls.Add(this.txtIpDestino);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TextBox txtIpDestino;
        private System.Windows.Forms.TextBox txtPuertoDesstino;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

