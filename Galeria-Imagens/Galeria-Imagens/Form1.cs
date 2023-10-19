using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeria_Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Imagens (*.jpg)|*.jpg|Imagens (*.png)|*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "imagens");
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string imagem in openFileDialog.FileNames)
                    {
                        lstImagem.Items.Add(imagem);
                        lstImagem.SelectedItem = imagem;

                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstImagem.SelectedItems.Count > 0)
            {
                lstImagem.Items.Remove(lstImagem.SelectedItem);
                picImagem.ImageLocation = "";
            }
        }

        private void lstImagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImagem.SelectedItems.Count > 0)
            {
                picImagem.ImageLocation = lstImagem.SelectedItem.ToString();
                picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
