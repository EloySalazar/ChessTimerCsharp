namespace temporizadorPrueba
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_blancas1 = new System.Windows.Forms.TextBox();
            this.Empezar = new System.Windows.Forms.Button();
            this.timer_blancas2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_negras2 = new System.Windows.Forms.TextBox();
            this.timer_negras1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.milisegundos_time = new System.Windows.Forms.Timer(this.components);
            this.pausar = new System.Windows.Forms.Button();
            this.resetear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.bola = new System.Windows.Forms.PictureBox();
            this.bola2 = new System.Windows.Forms.PictureBox();
            this.cambio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_blancas1
            // 
            this.timer_blancas1.BackColor = System.Drawing.Color.LightGray;
            this.timer_blancas1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timer_blancas1.Enabled = false;
            this.timer_blancas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_blancas1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timer_blancas1.HideSelection = false;
            this.timer_blancas1.Location = new System.Drawing.Point(113, 68);
            this.timer_blancas1.MaxLength = 5;
            this.timer_blancas1.Name = "timer_blancas1";
            this.timer_blancas1.Size = new System.Drawing.Size(102, 46);
            this.timer_blancas1.TabIndex = 0;
            this.timer_blancas1.Text = "00";
            this.timer_blancas1.TextChanged += new System.EventHandler(this.timer_blancas_TextChanged);
            // 
            // Empezar
            // 
            this.Empezar.BackColor = System.Drawing.Color.Gray;
            this.Empezar.FlatAppearance.BorderSize = 0;
            this.Empezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empezar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Empezar.Location = new System.Drawing.Point(147, 140);
            this.Empezar.Name = "Empezar";
            this.Empezar.Size = new System.Drawing.Size(165, 42);
            this.Empezar.TabIndex = 2;
            this.Empezar.Text = "Empezar";
            this.Empezar.UseVisualStyleBackColor = false;
            this.Empezar.Click += new System.EventHandler(this.Empezar_Click);
            // 
            // timer_blancas2
            // 
            this.timer_blancas2.BackColor = System.Drawing.Color.LightGray;
            this.timer_blancas2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timer_blancas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_blancas2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timer_blancas2.HideSelection = false;
            this.timer_blancas2.Location = new System.Drawing.Point(12, 68);
            this.timer_blancas2.MaxLength = 5;
            this.timer_blancas2.Name = "timer_blancas2";
            this.timer_blancas2.Size = new System.Drawing.Size(59, 46);
            this.timer_blancas2.TabIndex = 3;
            this.timer_blancas2.Text = "00";
            this.timer_blancas2.TextChanged += new System.EventHandler(this.timer_blancas2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(76, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // timer_negras2
            // 
            this.timer_negras2.BackColor = System.Drawing.Color.LightGray;
            this.timer_negras2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timer_negras2.Enabled = false;
            this.timer_negras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_negras2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timer_negras2.HideSelection = false;
            this.timer_negras2.Location = new System.Drawing.Point(347, 68);
            this.timer_negras2.MaxLength = 5;
            this.timer_negras2.Name = "timer_negras2";
            this.timer_negras2.Size = new System.Drawing.Size(101, 46);
            this.timer_negras2.TabIndex = 6;
            this.timer_negras2.Text = "00";
            // 
            // timer_negras1
            // 
            this.timer_negras1.BackColor = System.Drawing.Color.LightGray;
            this.timer_negras1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timer_negras1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_negras1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timer_negras1.HideSelection = false;
            this.timer_negras1.Location = new System.Drawing.Point(248, 68);
            this.timer_negras1.MaxLength = 5;
            this.timer_negras1.Name = "timer_negras1";
            this.timer_negras1.Size = new System.Drawing.Size(56, 46);
            this.timer_negras1.TabIndex = 5;
            this.timer_negras1.Text = "00";
            this.timer_negras1.TextChanged += new System.EventHandler(this.timer_negras1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(310, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(313, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingresar el tiempo\r\nen minutos\r\n";
            // 
            // milisegundos_time
            // 
            this.milisegundos_time.Interval = 10;
            this.milisegundos_time.Tick += new System.EventHandler(this.milisegundos_time_Tick);
            // 
            // pausar
            // 
            this.pausar.BackColor = System.Drawing.Color.Gray;
            this.pausar.FlatAppearance.BorderSize = 0;
            this.pausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pausar.Location = new System.Drawing.Point(159, 198);
            this.pausar.Name = "pausar";
            this.pausar.Size = new System.Drawing.Size(144, 41);
            this.pausar.TabIndex = 9;
            this.pausar.Text = "Pausar";
            this.pausar.UseVisualStyleBackColor = false;
            this.pausar.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetear
            // 
            this.resetear.BackColor = System.Drawing.Color.Gray;
            this.resetear.FlatAppearance.BorderSize = 0;
            this.resetear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetear.Location = new System.Drawing.Point(179, 258);
            this.resetear.Name = "resetear";
            this.resetear.Size = new System.Drawing.Size(107, 34);
            this.resetear.TabIndex = 10;
            this.resetear.Text = "Resetear";
            this.resetear.UseVisualStyleBackColor = false;
            this.resetear.Click += new System.EventHandler(this.resetear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(43, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Blancas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(285, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Negras";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // bola
            // 
            this.bola.BackColor = System.Drawing.Color.Transparent;
            this.bola.Image = global::temporizadorPrueba.Properties.Resources.muestra4;
            this.bola.Location = new System.Drawing.Point(33, 149);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(74, 64);
            this.bola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bola.TabIndex = 13;
            this.bola.TabStop = false;
            this.bola.Visible = false;
            // 
            // bola2
            // 
            this.bola2.BackColor = System.Drawing.Color.Transparent;
            this.bola2.Image = global::temporizadorPrueba.Properties.Resources.muestra4;
            this.bola2.Location = new System.Drawing.Point(365, 149);
            this.bola2.Name = "bola2";
            this.bola2.Size = new System.Drawing.Size(74, 64);
            this.bola2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bola2.TabIndex = 14;
            this.bola2.TabStop = false;
            this.bola2.Visible = false;
            // 
            // cambio
            // 
            this.cambio.BackColor = System.Drawing.Color.Gray;
            this.cambio.FlatAppearance.BorderSize = 0;
            this.cambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cambio.Location = new System.Drawing.Point(186, 20);
            this.cambio.Name = "cambio";
            this.cambio.Size = new System.Drawing.Size(100, 36);
            this.cambio.TabIndex = 15;
            this.cambio.Text = "cambio";
            this.cambio.UseVisualStyleBackColor = false;
            this.cambio.Click += new System.EventHandler(this.cambio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(477, 318);
            this.Controls.Add(this.cambio);
            this.Controls.Add(this.bola2);
            this.Controls.Add(this.bola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resetear);
            this.Controls.Add(this.pausar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timer_negras2);
            this.Controls.Add(this.timer_negras1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timer_blancas2);
            this.Controls.Add(this.Empezar);
            this.Controls.Add(this.timer_blancas1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 356);
            this.MinimumSize = new System.Drawing.Size(493, 356);
            this.Name = "Form1";
            this.Text = "TEMPORIZADOR--AJEDREZ V2.00";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bola2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox timer_blancas1;
        private System.Windows.Forms.Button Empezar;
        private System.Windows.Forms.TextBox timer_blancas2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timer_negras2;
        private System.Windows.Forms.TextBox timer_negras1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer milisegundos_time;
        private System.Windows.Forms.Button pausar;
        private System.Windows.Forms.Button resetear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox bola;
        private System.Windows.Forms.PictureBox bola2;
        private System.Windows.Forms.Button cambio;
    }
}

