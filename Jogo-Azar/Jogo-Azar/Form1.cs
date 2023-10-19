using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Azar
{
    public partial class Form1 : Form
    {
        private int creds = 10;
        private Random rdn = new Random();

        public Form1()
        {
            InitializeComponent();
            NUCREDS.Text = creds.ToString(); // Atualize o texto do label de créditos no início
        }

    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            PicBox.Visible = false;

            
                label1.Text = rdn.Next(1, 10).ToString();
                label2.Text = rdn.Next(1, 10).ToString();
                label3.Text = rdn.Next(1, 10).ToString();

                if (label1.Text == "7" || label2.Text == "7" || label3.Text == "7")
                {
                    creds++;
                MessageBox.Show(" +1 Crédito!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                if ((label1.Text == "7" && label2.Text == "7") || (label1.Text == "7" && label3.Text == "7") || (label2.Text == "7" && label3.Text == "7"))
                {
                    creds += 2;
                    MessageBox.Show(" +2 Créditos!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (label1.Text == "7" && label2.Text == "7" && label3.Text == "7")
                {
                    MessageBox.Show("Você é um vencedor +5 Créditos !!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PicBox.Visible = true;
                    System.Media.SystemSounds.Beep.Play();
                    creds += 5;
                }

                creds--; // Atualize os créditos

                NUCREDS.Text = creds.ToString(); // Atualize o texto do label de créditos

           

            // Aqui, você pode exibir uma mensagem ou tomar outra ação quando os créditos acabarem.
            if (creds <=0)
            {
              MessageBox.Show("Seus créditos acabaram!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
            }
               







        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Tem certeza?", "Confirmar", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

             
        }

        private void lblWins_Click(object sender, EventArgs e)
        {




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {



        }

        private void contador_Click(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PicBox_Click(object sender, EventArgs e)
        {



        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
