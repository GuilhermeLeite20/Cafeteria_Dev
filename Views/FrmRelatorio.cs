namespace CafeteriaDev.Views
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
            CarregarVendas();
        }

        private void CarregarVendas()
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vendas.txt");

            try
            {
                if (File.Exists(caminho))
                {
                    txtRelatorio.Text = File.ReadAllText(caminho);

                    if (string.IsNullOrWhiteSpace(txtRelatorio.Text))
                    {
                        txtRelatorio.Text = "Nenhuma venda registrada ainda.";
                    }
                }
                else
                {
                    txtRelatorio.Text = "Nenhuma venda registrada ainda.";
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Não foi possível abrir o relatório de vendas.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Sem permissão para ler o relatório de vendas.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
