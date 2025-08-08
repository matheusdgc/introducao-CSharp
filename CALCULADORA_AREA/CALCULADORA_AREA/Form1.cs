using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_AREA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio = Convert.ToDouble(TxtRaio.Text);
            if (RBArea.Checked == true)
            {
                double area = Math.PI * Math.Pow(raio,2);
                LbResposta.Text = $"{area:N5} cm";
                GBResultado.Text = "CALCULO DO ÁREA";
            }
            if (RBPerimetro.Checked == true)
            {
                double p = 2 * Math.PI * raio;
                LbResposta.Text = $"{p:N5} cm";
                GBResultado.Text = "CALCULO DO PERIMETRO";
            }
            if (RBVolume.Checked == true)
            {
                double v = 4f / 3f * Math.PI * Math.Pow(raio, 3);
                LbResposta.Text = $"{v:N5} cm";
                GBResultado.Text = "CALCULO DO VOLUME";
            }
        }

        private void BtnDesenhar_Click(object sender, EventArgs e)
        {
            Graphics g = PnDesenho.CreateGraphics();
            Pen caneta = new Pen(Color.Red, 2);

            if (CHBApagarDesenho.Checked == true)
            {
                g.Clear(Color.White);
                return;
            }

            float cy = PnDesenho.Height / 2;
            float cx = PnDesenho.Width / 2;


            g.DrawLine(caneta, 0, cy, PnDesenho.Width, cy);
            caneta.Color = Color.Blue;
            g.DrawLine(caneta, cx, 0, cx, PnDesenho.Height);
            caneta.Color = Color.Black;
            try
            {
                float d = Convert.ToSingle(TxtRaio.Text) * 2;
                if (CHBPreencherCirculo.Checked == true)
                {
                    SolidBrush cor = new SolidBrush(Color.OrangeRed);
                    // g.FillRectangle(cor, cx - d / 2, cy - d / 2, d, d);
                    g.FillEllipse(cor, cx - d / 2, cy - d / 2, d, d);
                }
                g.DrawEllipse(caneta, cx - d / 2, cy - d / 2, d, d);
                g.DrawRectangle(caneta, cx - d / 2, cy - d / 2, d, d);
            }
            catch
            {
                MessageBox.Show("raio inválido");
                return;
            }
        }
    }
}