using System;
using System.Media;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;
namespace temporizadorPrueba
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        bool Hacer_cambio = true;
       int milisegundos_blancas = 59;
        int segundos_blancas = 0;
        int minutos_blancas = 1;
        int resetea_blancas;
        int milisegundos_negras = 59;
         int segundos_negras = 0;
        int minutos_negras = 1;
       int resetea_negras;
        
        SoundPlayer sonido_derrota = new SoundPlayer("derrota.wav");
        SoundPlayer sonido_derrota1 = new SoundPlayer("derrota1.wav");
        SoundPlayer sonido_derrota2 = new SoundPlayer("derrota2.wav");
        SoundPlayer sonido_derrota3 = new SoundPlayer("derrota3.wav");
        SoundPlayer sonido_blancas = new SoundPlayer("blancas.wav");
        SoundPlayer sonido_negras = new SoundPlayer("negras.wav");
        SoundPlayer sonido_burla = new SoundPlayer("burla.wav");
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;
            //   timer1.Enabled = true;
            timer_blancas2.Text = "1";
            timer_negras1.Text = "1";
            pausar.Enabled = false;
            resetear.Enabled = false;
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hacer_cambio == false)
            {
                label3.Text = "Negras Corriendo";
            }
            else
            {
                label3.Text = "Blancas Corriendo";
            }
            
            bola.Visible = true;
            bola2.Visible = false;
            temporizador_blancas();
           
           
        }

      
     
      public  void verificar_blancas()
        {

            string capturar = timer_blancas1.Text;
            string capturar2 = timer_blancas2.Text;

            if (Regex.IsMatch(capturar, "[.0123456789]")) 
            {
               
               
            }
         

            else
            {
                timer_blancas1.Text = "00";
               
                MessageBox.Show("SOLO SE PUEDEN COLOCAR NUMEROS", "ERROR TEMPORIZADOR AJEDREZ");
            }
          if (Regex.IsMatch(capturar2, "[.0123456789]"))
            {

              
            }
            else
            {
                timer_blancas2.Text = "1";

                MessageBox.Show("SOLO SE PUEDEN COLOCAR NUMEROS", "ERROR TEMPORIZADOR AJEDREZ");
            }
        }
        public void verificar_negras()
        {

            string capturar = timer_negras1.Text;
            string capturar2 = timer_negras2.Text;
            if (Regex.IsMatch(capturar, "[.0123456789]"))
            {
               
               
            }

            else
            {
                timer_negras1.Text = "1";
                MessageBox.Show("SOLO SE PUEDEN COLOCAR NUMEROS", "ERROR TEMPORIZADOR AJEDREZ");
            }
            if (Regex.IsMatch(capturar2, "[.0123456789]"))
            {


            }

            else
            {
                timer_negras2.Text = "00";
                MessageBox.Show("SOLO SE PUEDEN COLOCAR NUMEROS", "ERROR TEMPORIZADOR AJEDREZ");
            }
        }
       
       
        private void timer_blancas_TextChanged(object sender, EventArgs e)
        {
            verificar_blancas();
          //  sumar_blancas2();
        }

        private void timer_negras_TextChanged(object sender, EventArgs e)
        {
            verificar_negras();
           // sumar_negras2();
        }

        private void Empezar_Click(object sender, EventArgs e)
        {
            Empezar.Text = "Empezar";
            pausar.Enabled = true;
            resetear.Enabled = true;
            verificar_blancas();
           // sumar_blancas2();
            verificar_negras();
            //  sumar_negras2();
            if (Hacer_cambio == true)
            {
                milisegundos_time.Enabled = true;
                timer1.Enabled = true;

                timer3.Enabled = false;
                timer2.Enabled = false;
            }
            else
            {
                timer3.Enabled = true;
                timer2.Enabled = true;
                milisegundos_time.Enabled = false;
                timer1.Enabled = false;
            }
            if (bola.Visible == true && bola2.Visible == false)
            {
                    milisegundos_time.Enabled = true;
                    timer1.Enabled = true;

                    timer3.Enabled = false;
                    timer2.Enabled = false;
            }
            else if (bola2.Visible == true && bola.Visible == false)
            {
               
                    timer3.Enabled = true;
                    timer2.Enabled = true;
                    milisegundos_time.Enabled = false;
                    timer1.Enabled = false;
               
            }
            timer_blancas1.Enabled = false;
            timer_blancas2.Enabled = false;
            timer_negras1.Enabled = false;
            timer_negras2.Enabled = false;
            cambio.Enabled = false;
            Empezar.Enabled = false;
            pausar.Focus();
            this.KeyPreview = true;
        }
        public void temporizador_blancas()
        {

           // --segundos;
           // --milisegundos;
            if(segundos_blancas == 0)
            {
                --minutos_blancas;
                segundos_blancas = 59;
            }
          else  if (milisegundos_blancas == 0) {
                --segundos_blancas;
                milisegundos_blancas = 59;
                if (minutos_blancas == 0 && segundos_blancas == 0) { milisegundos_blancas = 0; }
            }
            //   contador = TimeSpan.Parse("50");
            //  TimeSpan.FromMinutes(60);
            //++contador1;
           
           
            timer_blancas2.Text = Convert.ToString(minutos_blancas);
            timer_blancas1.Text = Convert.ToString(segundos_blancas)+ "."+Convert.ToString(milisegundos_blancas);
            if (minutos_blancas == 0 && segundos_blancas == 0 && milisegundos_blancas == 0) 
            {

                    label3.Text = "Ingresar el tiempo\nen minutos";
                    timer_blancas2.Text = Convert.ToString(resetea_blancas);
                    timer_negras1.Text = Convert.ToString(resetea_negras);
                    segundos_blancas = 0;
                    milisegundos_blancas = 0;
                    segundos_negras = 0;
                    milisegundos_negras = 0;
                    Empezar.Enabled = false;
                    pausar.Enabled = true;
                    timer1.Enabled = false;
                    milisegundos_time.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer_blancas2.Enabled = true;
                    timer_negras1.Enabled = true;
                if (Hacer_cambio == true)
                {
                    MessageBox.Show("Negras ganan....", "Ganar o perder");
                }
                else
                {
                    MessageBox.Show("Blancas ganan....", "Ganar o perder");
                }
                    sonido_derrota.Load();
                    sonido_derrota.Play();
                
            }
        }
        public void temporizador_negras()
        {
            if (segundos_negras == 0)
            {
                --minutos_negras;
                segundos_negras = 59;
            }
            else if (milisegundos_negras == 0)
            {
                --segundos_negras;
                milisegundos_negras = 59;
                if (minutos_negras == 0 && segundos_negras == 0) { milisegundos_negras = 0; }
            }
            timer_negras1.Text = Convert.ToString(minutos_negras);

            timer_negras2.Text = Convert.ToString(segundos_negras) + "." + Convert.ToString(milisegundos_negras);

            if (minutos_negras == 0 && segundos_negras == 0 && milisegundos_negras == 0)
            {
              

                label3.Text = "Ingresar el tiempo\nen minutos";
                timer_blancas2.Text = Convert.ToString(resetea_blancas);
                timer_negras1.Text = Convert.ToString(resetea_negras);
                segundos_blancas = 0;
                milisegundos_blancas = 0;
                segundos_negras = 0;
                milisegundos_negras = 0;
                Empezar.Enabled = false;
                pausar.Enabled = true;
                timer1.Enabled = false;
                milisegundos_time.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer_blancas2.Enabled = true;
                timer_negras1.Enabled = true;
                if (Hacer_cambio == true)
                {
                    MessageBox.Show("Blancas ganan....", "Ganar o perder");
                }
                else
                {
                    MessageBox.Show("Negras ganan....", "Ganar o perder");
                }
                
                sonido_derrota.Load();
                sonido_derrota.Play();
            }
          
           

        }

        private void timer_blancas2_TextChanged(object sender, EventArgs e)
        {
            // segundos = Convert.ToInt32(timer_blancas1.Text);
           
            verificar_blancas();
            string capturar = timer_blancas2.Text;
            try {
             //   segundos = Convert.ToInt32(timer_blancas1.Text);
          
                minutos_blancas = Convert.ToInt32(timer_blancas2.Text);
                //  timer_blancas2.Text = Convert.ToString(minutos);
            }
            catch
            {
                timer_blancas2.Text = "1";
                MessageBox.Show("SOLO SE PUEDEN COLOCAR NUMEROS", "ERROR TEMPORIZADOR AJEDREZ");
            }
            resetea_blancas = minutos_blancas;
            if (timer1.Enabled == false)
            {
                if (String.Equals(timer_blancas2.Text, "0") == true)
                {
                    timer_blancas2.Text = "1";
                    MessageBox.Show("NO SE PUEDE DEJAR EN CERO", "ERROR TEMPORIZADOR AJEDREZ");

                }
            }
           
            // int comparacion = String.Compare(timer_blancas2.Text, "0");
            /*  if (comparacion == 0)
              {
                  timer_blancas2.Text = "1";
                  MessageBox.Show("NO SE PUEDE DEJAR EN CERO", "ERROR TEMPORIZADOR AJEDREZ");

              }*/
        }
      
           
        private void milisegundos_time_Tick(object sender, EventArgs e)
        {
            --milisegundos_blancas;
            if (Hacer_cambio == false)
            {
                label3.Text = "Negras Corriendo";
            }
            else
            {
                label3.Text = "Blancas Corriendo";
            }
            bola.Visible = true;
            bola2.Visible = false;
            temporizador_blancas();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* if (milisegundos_time.Enabled == false || timer1.Enabled == false)
            {
               
            }*/

            timer1.Enabled = false;
            milisegundos_time.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            Empezar.Text = "Despausar";
            pausar.Enabled = false;
            Empezar.Enabled = true;
            Empezar.Focus();
            this.KeyPreview = false;
           
        }

        private void timer_negras1_TextChanged(object sender, EventArgs e)
        {
            verificar_negras();
            try
            {
                //   segundos = Convert.ToInt32(timer_blancas1.Text);
                minutos_negras = Convert.ToInt32(timer_negras1.Text);
                //  timer_blancas2.Text = Convert.ToString(minutos);
            }
            catch
            {
                timer_negras1.Text = "1";
                MessageBox.Show("SOLO SE PUEDEN COLOCAR NUMEROS", "ERROR TEMPORIZADOR AJEDREZ");
            }
            resetea_negras = minutos_negras;
            if (timer2.Enabled == false)
            {
                if (String.Equals(timer_negras1.Text, "0") == true)
                {
                    timer_negras1.Text = "1";
                    MessageBox.Show("NO SE PUEDE DEJAR EN CERO", "ERROR TEMPORIZADOR AJEDREZ");

                }
            } 
        }

        private void resetear_Click(object sender, EventArgs e)
        {

            timer_blancas2.Text = "1";
            timer_negras1.Text = "1";
            timer_blancas1.Text = "00";
            timer_negras2.Text = "00";
            cambio.Enabled = true;
            Empezar.Text = "Empezar";
            label3.Text = "Ingresar el tiempo\nen minutos";
            timer_blancas2.Text = Convert.ToString(resetea_blancas);
            timer_negras1.Text = Convert.ToString(resetea_negras);
            segundos_blancas = 0;
            milisegundos_blancas = 59;
            minutos_blancas = 1;
            segundos_negras = 0;
            milisegundos_negras = 59;
            minutos_negras = 1;
            Empezar.Enabled = true;
            pausar.Enabled = true;
            timer1.Enabled = false;
            milisegundos_time.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer_blancas2.Enabled = true;
            timer_negras1.Enabled = true;
            this.KeyPreview = false;
              bola.Visible = false;
             bola2.Visible = false;
            // Hacer_cambio = true;
            pausar.Enabled = false;
            resetear.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.L)
            {
                sonido_blancas.Play();
                timer1.Enabled = true;
                milisegundos_time.Enabled = true;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
          else  if (e.KeyCode == Keys.A)
            {
                sonido_negras.Play();
                timer1.Enabled = false;
                milisegundos_time.Enabled = false;
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
            else if (e.KeyCode == Keys.Q)
            {
                sonido_burla.Play();
               
            }
            else if (e.KeyCode == Keys.P)
            {
                sonido_burla.Play();

            }
            else if (e.KeyCode == Keys.D1)
            {
                sonido_derrota1.Play();

            }
            else if (e.KeyCode == Keys.D2)
            {
                sonido_derrota2.Play();

            }
            else if (e.KeyCode == Keys.D3)
            {
                sonido_derrota3.Play();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Hacer_cambio == true)
            {
                label3.Text = "Blancas Corriendo";
            }
            else
            {
                label3.Text = "Negras Corriendo";
            }
            bola.Visible = false;
            bola2.Visible = true;
            temporizador_negras();
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            --milisegundos_negras;
            if (Hacer_cambio == true)
            {
                label3.Text = "Negras Corriendo";
            }
            else
            {
                label3.Text = "Blancas Corriendo";
            }
            bola.Visible = false;
            bola2.Visible = true;
            temporizador_negras();
        }

        private void cambio_Click(object sender, EventArgs e)
        {
            if(Hacer_cambio == true)
            {
                sonido_blancas.SoundLocation = "negras.wav";
                sonido_negras.SoundLocation = "blancas.wav";
                Hacer_cambio = false;
                label4.Text = "Negras";
                label5.Text = "Blancas";
            }
           else if (Hacer_cambio == false)
            {
                sonido_blancas.SoundLocation = "blancas.wav";
                sonido_negras.SoundLocation = "negras.wav";
                Hacer_cambio = true;
                label4.Text = "Blancas";
                label5.Text = "Negras";
            }

        }
    }
}
