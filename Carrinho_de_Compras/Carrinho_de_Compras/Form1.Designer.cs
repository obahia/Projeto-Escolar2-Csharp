namespace Carrinho_de_Compras
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Escolhas = new ComboBox();
            Itens = new ListBox();
            Vendidos = new ListBox();
            SuspendLayout();
            // 
            // Escolhas
            // 
            Escolhas.FormattingEnabled = true;
            Escolhas.Location = new Point(0, 0);
            Escolhas.Name = "Escolhas";
            Escolhas.Size = new Size(121, 23);
            Escolhas.TabIndex = 0;
            Escolhas.SelectedIndexChanged += Escolhas_SelectedIndexChanged;
            // 
            // Itens
            // 
            Itens.FormattingEnabled = true;
            Itens.ItemHeight = 15;
            Itens.Location = new Point(35, 162);
            Itens.Name = "Itens";
            Itens.Size = new Size(205, 214);
            Itens.TabIndex = 1;
            Itens.SelectedIndexChanged += Itens_SelectedIndexChanged;
            // 
            // Vendidos
            // 
            Vendidos.FormattingEnabled = true;
            Vendidos.ItemHeight = 15;
            Vendidos.Location = new Point(426, 162);
            Vendidos.Name = "Vendidos";
            Vendidos.Size = new Size(120, 94);
            Vendidos.TabIndex = 2;
            Vendidos.SelectedIndexChanged += Vendidos_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Vendidos);
            Controls.Add(Itens);
            Controls.Add(Escolhas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox Escolhas;
        private ListBox Itens;
        private ListBox Vendidos;
    }
}