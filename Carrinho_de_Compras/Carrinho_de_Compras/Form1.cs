namespace Carrinho_de_Compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Escolhas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ESCOLHAS_ITENS = Escolhas.SelectedItem.ToString();
            if (ESCOLHAS_ITENS == "Hardware")
            {
                Itens.Items.Clear();
                Itens.Items.Add("Monitor");
                Itens.Items.Add("Teclado");
                Itens.Items.Add("Rato");
                Itens.Items.Add("Impressora");

            }
            if (ESCOLHAS_ITENS == "Software")
            {
                Itens.Items.Clear();
                Itens.Items.Add("Windows 10");
                Itens.Items.Add("Windows 11");
                Itens.Items.Add("Linux Ubuntu");
                Itens.Items.Add("Office 2022");
                Itens.Items.Add("Visual Studio 2022 Enterprise");
            }
            string itemselecionado = ;
            if (itemselecionado != null)
            {
                Vendidos.Items.Add(itemselecionado);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Escolhas.Items.Add("Hardware");
            Escolhas.Items.Add("Software");

        }

        private void Itens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vendidos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
    }


}