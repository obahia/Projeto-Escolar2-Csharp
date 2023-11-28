using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_DicerPoker
{
    public partial class Form1 : Form
    {
        /* definição das variáveis a usar na aplicação*/
        /*controla o tempo de duração da rolagem de dados*/
        private const int cRolarTempo = 5;

        //armazena a mensagem da barra de título
        private const string cTituloBarra = "Dicer Poker";

        //controlar a exibição de controlos checkbox
        private bool cListaDados = false;

        //total de créditos na conta do jogador
        private int creditos = 20;

        //armazena o número de jogadas de dados
        private int nrJogadas;

        private int contador; //variável contador
        private int dado1;    //dado com a face 1
        private int dado2;    //dado com a face 2
        private int dado3;    //dado com a face 3
        private int dado4;    //dado com a face 4
        private int dado5;    //dado com a face 5
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //mostrar a imagem branco nas picturebox dos dados
            pbDado1.Image = imgDados.Images[0];
            pbDado2.Image = imgDados.Images[0];
            pbDado3.Image = imgDados.Images[0];
            pbDado4.Image = imgDados.Images[0];
            pbDado5.Image = imgDados.Images[0];

            //mostrar uma saudação e total de créditos ao jogador
            txtOutput.Text = "Bem vindo!\n Está pronto para jogar?" +
            "\n Tem " + creditos.ToString() + " créditos.";

        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            RolarOsDados(nrJogadas);
            //verificar se os dados foram lançados duas vezes
            if (nrJogadas == 2)
            {
                //alterar o texto a mostrar no botão
                btnRolar.Text = "Rolar os dados";
                //colocar 0 para preparar novo jogo
                nrJogadas = 0;
            }
            //se o primeiro lançamento foi feito deve-se alternar a 
            //exibição das checkbox e acompanhar o número de rolagens
            if (btnRolar.Text == "Rolar os dados")
            {
                cListaDados = false;
                nrJogadas += 1;
            }
            else
            {
                cListaDados = true;
                nrJogadas += 1;
            }
            //iniciar o controlo Timer
            timer1.Enabled = true;

        }

        private void RolarOsDados(int x)
        {
            // Variáveis para controlar os dados que o jogador escolheu para manter na sua primeira rolagem
            bool[] saltaCases = new bool[5];
            if (cListaDados)
            {
                // Assinalar o dado a ser mantido pelo jogador
                saltaCases[0] = chkDado1.Checked;
                saltaCases[1] = chkDado2.Checked;
                saltaCases[2] = chkDado3.Checked;
                saltaCases[3] = chkDado4.Checked;
                saltaCases[4] = chkDado5.Checked;
            }

            // Criação de uma instância de Random fora do loop
            Random r = new Random();

            // Testar valor gerado para determinar face do dado
            for (int i = 0; i < 5; i++)
            {
                int rolar = r.Next(1, 7);
                if (!saltaCases[i])
                {
                    switch (rolar)
                    {
                        case 1:
                            if (x == 1) pbDado1.Image = imgDados.Images[1];
                            if (x == 2) pbDado2.Image = imgDados.Images[1];
                            if (x == 3) pbDado3.Image = imgDados.Images[1];
                            if (x == 4) pbDado4.Image = imgDados.Images[1];
                            if (x == 5) pbDado5.Image = imgDados.Images[1];
                            break;
                        case 2:
                            if (x == 1) pbDado1.Image = imgDados.Images[2];
                            if (x == 2) pbDado2.Image = imgDados.Images[2];
                            if (x == 3) pbDado3.Image = imgDados.Images[2];
                            if (x == 4) pbDado4.Image = imgDados.Images[2];
                            if (x == 5) pbDado5.Image = imgDados.Images[2];
                            break;
                        case 3:
                            if (x == 1) pbDado1.Image = imgDados.Images[3];
                            if (x == 2) pbDado2.Image = imgDados.Images[3];
                            if (x == 3) pbDado3.Image = imgDados.Images[3];
                            if (x == 4) pbDado4.Image = imgDados.Images[3];
                            if (x == 5) pbDado5.Image = imgDados.Images[3];
                            break;
                        case 4:
                            if (x == 1) pbDado1.Image = imgDados.Images[4];
                            if (x == 2) pbDado2.Image = imgDados.Images[4];
                            if (x == 3) pbDado3.Image = imgDados.Images[4];
                            if (x == 4) pbDado4.Image = imgDados.Images[4];
                            if (x == 5) pbDado5.Image = imgDados.Images[4];
                            break;
                        case 5:
                            if (x == 1) pbDado1.Image = imgDados.Images[5];
                            if (x == 2) pbDado2.Image = imgDados.Images[5];
                            if (x == 3) pbDado3.Image = imgDados.Images[5];
                            if (x == 4) pbDado4.Image = imgDados.Images[5];
                            if (x == 5) pbDado5.Image = imgDados.Images[5];
                            break;
                        case 6:
                            if (x == 1) pbDado1.Image = imgDados.Images[6];
                            if (x == 2) pbDado2.Image = imgDados.Images[6];
                            if (x == 3) pbDado3.Image = imgDados.Images[6];
                            if (x == 4) pbDado4.Image = imgDados.Images[6];
                            if (x == 5) pbDado5.Image = imgDados.Images[6];
                            break;
                    }
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //variável para controlar o loop
            int i;

            //chamar o procedimento RolarOsDados em cada interação
            for (i = 1; i < 6; i++)
            {
                RolarOsDados(i);
            }

            //incrementar o contador de jogadas
            contador += 1;

            //desativar o temporizador e exibir os checkbox no final da rolagem
            if (contador > cRolarTempo)
            {
                contador = 0;
                timer1.Enabled = false;
                if (nrJogadas == 1)
                {
                    //alterar o texto de botão
                    btnRolar.Text = "Rolar outra vez os Dados";

                    chkDado1.Visible = true;
                    chkDado2.Visible = true;
                    chkDado3.Visible = true;
                    chkDado4.Visible = true;
                    chkDado5.Visible = true;
                    chkDados.Visible = true;

                }
                if (nrJogadas == 2)
                {
                    //preparar para uma nova jogada
                    btnRolar.Text = "Rolar os dados";
                    LimparCheckBox();

                    //verificar o resultado da jogada
                    VerificarResultadosJogada();
                }
            }
        }

        private void LimparCheckBox()
        {
            //ocultar e desativar as checkboxex
            chkDado1.Visible = false;
            chkDado1.Checked = false;
            chkDado2.Visible = false;
            chkDado2.Checked = false;
            chkDado3.Visible = false;
            chkDado3.Checked = false;
            chkDado4.Visible = false;
            chkDado4.Checked = false;
            chkDado5.Visible = false;
            chkDado5.Checked = false;
            chkDados.Visible = false;
            chkDados.Checked = false;

        }

        private void VerificarResultadosJogada()
        {
            //array para manter a contagem do número em cada mão
            int[] dadosArray = new int[5];

            //variável para controlar a execução do loop
            int i = 1;

            //iterar seis vezes para manter a contagem do total
            //de 1s, 2s, 3s, 4s, 5s e 6s que foram rolados

            for (i = 1; i < 6; i++)
            {
                if (dado1 == i) dadosArray[i] += 1;
                if (dado2 == i) dadosArray[i] += 1;
                if (dado3 == i) dadosArray[i] += 1;
                if (dado4 == i) dadosArray[i] += 1;
                if (dado5 == i) dadosArray[i] += 1;
            }
            //iterar seis vezes para contar as mãos vencedores
            for (i = 1; i < 7; i++)
            {
                //ver se o jogador tem 5 do mesmo tipo
                if (dadosArray[i] == 5)
                {
                    creditos += 4;
                    txtOutput.Text = "GANHOU! 5 of a kind.\n Ganhou 4 créditos.";
                }
                //ver se o jogador tem 4 do mesmo tipo
                if (dadosArray[i] == 4)
                {
                    creditos += 3;
                    txtOutput.Text = "GANHOU! 4 of a kind.\n Ganhou 3 créditos.";

                }
                //ver se o jogador tem 3 do mesmo tipo ou Full House (3 + 2)
                if (dadosArray[i] == 3)
                {
                    //tem 3 do mesmo tipo
                    int j;
                    bool fullHouse = false;

                    //verificar se tem 2 do mesmo tipo
                    for (j = 1; j < 7; j++)
                    {
                        if (dadosArray[j] == 2)
                        {
                            fullHouse = true;
                            creditos += 2;
                            txtOutput.Text = "GANHOU! Full House.\n Ganhou 2 créditos.";
                            return;
                        }
                    }
                    if (fullHouse == false)
                    {
                        creditos += 1;
                        txtOutput.Text = "GANHOU! 3 of a kind.\n Ganhou 1 créditos.";
                        return;
                    }
                }

                //iterar os dados 2 a 6 à procura de um High Straiht
                //cada uma das posições só pode conter o valor 1
               
            } 
            for (i = 2; i < 7; i++)
                {
                    if (dadosArray[2] == 1 && dadosArray[3] == 1 && dadosArray[4] == 1 && dadosArray[5] == 1 && (dadosArray[1] == 1 || dadosArray[6] == 1))
                    {
                        creditos += 3;
                        txtOutput.Text = "GANHOU! High Straight.\n Ganhou 3 créditos.";
                        return;
                    }
            }
                //iterar os dados 1 a 5 à procura de um Low Straight
                //cada uma das posições só pode conter o valor 1
                for (i = 1; i < 5; i++)
                {
                    if ((dadosArray[1] == 1 && dadosArray[2] == 1 && dadosArray[3] == 1 && dadosArray[4] == 1 && dadosArray[5] == 1) || (dadosArray[2] == 1 && dadosArray[3] == 1 && dadosArray[4] == 1 && dadosArray[5] == 1 && dadosArray[6] == 1))
                    {
                        creditos += 3;
                        txtOutput.Text = "GANHOU! Low Straight.\n Ganhou 3 créditos.";
                        return;
                    }
                }

                //atualizar o preço da jogada
                creditos -= 2;
                txtOutput.Text = "SORRY! Perdeu esta mão e 2 créditos.";
        }

        //private void AtualizarConta()
        //{
        //    txtOutput.Text = "Tem " + creditos.ToString() + " créditos.";
        //}

        //private void FimDoJogo()
        //{
        //    //variável para resposta ao jogador
        //    DialogResult resposta = new DialogResult();

        //    //limpar as mensagens de estado do jogo
        //    txtOutput.Text = "";

        //    //prompt alerta para avisar o jogador
        //    resposta = MessageBox.Show(mensagem, "Aviso",)
        //    //se o jogador clica em Sim deve-se criar um novo jogo
        //    if (resposta == DialogResult.Yes)
        //    {
        //        //redefinir a conta do jogador
        //        creditos = 20;

        //        //mostrar a imagem branco nas pictures box
        //        pbDado1.Image = imgDados.Images[0];
        //        pbDado2.Image = imgDados.Images[0];
        //        pbDado3.Image = imgDados.Images[0];
        //        pbDado4.Image = imgDados.Images[0];
        //        pbDado5.Image = imgDados.Images[0];
        //    }
        //    else
        //    {
        //        //o jogador não quer jogar mais
        //        Application.Exit();
        //    }

        //}

        //private void chkDados_CheckedChanged(object sender, EventArgs e)
        //{
        //    //se o jogador seleciona Manter tudo
        //    if (chkDados.Checked == true)
        //    {
        //        chkDado1.Checked = true;
        //        chkDado2.Checked = true;
        //        chkDado3.Checked = true;
        //        chkDado4.Checked = true;
        //        chkDado5.Checked = true;
        //        btnRolar.Text = "Manter tudo";
        //    }
        //    else
        //    {
        //        chkDado1.Checked = false;
        //        chkDado2.Checked = false;
        //        chkDado3.Checked = false;
        //        chkDado4.Checked = false;
        //        chkDado5.Checked = false;
        //        btnRolar.Text = "Rolar os Dados";
        //    }
        //}

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


