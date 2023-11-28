using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Azar
{
    public partial class Form1 : Form
    {
        private int vitorias = 0;
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
            lblVi.Text = "Número de vitórias: " + vitorias;

            if (label1.Text == "7" || label2.Text == "7" || label3.Text == "7")
            {
                creds++;
                MessageBox.Show(" +1 Crédito!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vitorias++;
                PicBox.Visible = true;

            }
            if ((label1.Text == "7" && label2.Text == "7") || (label1.Text == "7" && label3.Text == "7") || (label2.Text == "7" && label3.Text == "7"))
            {
                creds += 2;
                MessageBox.Show(" +2 Créditos!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PicBox.Visible = true;
                vitorias++;
            }
            if (label1.Text == "7" && label2.Text == "7" && label3.Text == "7")
            {
                MessageBox.Show("Você é um vencedor +5 Créditos !!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PicBox.Visible = true;
                System.Media.SystemSounds.Beep.Play();
                creds += 5;
                vitorias++;
            }

            creds--; // Atualize os créditos

            NUCREDS.Text = creds.ToString(); // Atualize o texto do label de créditos

            DialogResult resposta = new DialogResult();

            // Aqui, você pode exibir uma mensagem ou tomar outra ação quando os créditos acabarem.

            if (creds <= 0)
            {

                resposta = MessageBox.Show("Seus créditos acabaram!!\n\n Deseja jogar novamente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            if (resposta == DialogResult.Yes)
            {
                creds = 10; // Reinicie os créditos para 10
                NUCREDS.Text = creds.ToString();
                vitorias = 0;
                
            }
            if (resposta == DialogResult.No)
            {
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
            btnSpin.Anchor = AnchorStyles.Top;
            label1.Anchor = AnchorStyles.Top;
            label2.Anchor = AnchorStyles.Top;
            label3.Anchor = AnchorStyles.Top;
            label4.Anchor = AnchorStyles.Top;
            lblVi.Anchor = AnchorStyles.Top;
            NUCREDS.Anchor = AnchorStyles.Top;
            bntExit.Anchor = AnchorStyles.Top;
            PicBox.Anchor = AnchorStyles.Top;

           
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

        private void lblVi_Click(object sender, EventArgs e)
        {

        }
    }
}
