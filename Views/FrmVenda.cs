using CafeteriaDev.Models;

namespace CafeteriaDev.Views
{
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();
            cboCafe.SelectedIndex = 0;
            AtualizarPreco();
        }

        // Preços simples, fixos e fáceis de modificar.
        private decimal ObterPreco()
        {
            switch (cboCafe.SelectedIndex)
            {
                case 0: return 6m;  // Expresso
                case 1: return 9m;  // Cappuccino
                case 2: return 11m; // Latte
                case 3: return 10m; // Mocha
                default: return 0m;
            }
        }

        private void AtualizarPreco()
        {
            lblPreco.Text = $"Preço unitário: R$ {ObterPreco():N2}";
            lblResultado.Text = "Total: R$ 0,00";
        }

        // Cria um objeto do tipo normal ou especial, usando POO.
        private PedidoCafe? CriarPedido()
        {
            string cliente = txtCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(cliente))
            {
                MessageBox.Show("Informe o nome do cliente.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return null;
            }

            if (cboCafe.SelectedIndex < 0)
            {
                MessageBox.Show("Escolha um café.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            string cafe = cboCafe.Text;
            int quantidade = (int)nudQuantidade.Value;
            decimal valorUnitario = ObterPreco();

            // Como no OrçamentoDev: cria a classe filha quando há adicional.
            PedidoCafe pedido = chkChantilly.Checked
                ? new PedidoEspecial(cliente, cafe, quantidade, valorUnitario, true)
                : new PedidoCafe(cliente, cafe, quantidade, valorUnitario);

            return pedido;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            PedidoCafe? pedido = CriarPedido();
            if (pedido == null) return;

            lblResultado.Text = $"Total: R$ {pedido.CalcularTotal():N2}";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Calcula de novo antes de salvar, mesmo se os campos mudarem.
            PedidoCafe? pedido = CriarPedido();
            if (pedido == null) return;

            decimal total = pedido.CalcularTotal();
            string conteudo = "--------------------------------------------------\n" +
                $"Data/Hora: {DateTime.Now:dd/MM/yyyy HH:mm}\n" +
                $"Cliente: {pedido.Cliente}\n" +
                $"Café: {pedido.Cafe}\n" +
                $"Quantidade: {pedido.Quantidade}\n" +
                $"Valor unitário: R$ {pedido.ValorUnitario:N2}\n" +
                $"Adicional: {pedido.DescricaoAdicional()}\n" +
                $"Total: R$ {total:N2}\n\n";

            // Segue o padrão do OrçamentoDev: guarda as vendas em arquivo .txt.
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vendas.txt");

            try
            {
                File.AppendAllText(caminho, conteudo);

                MessageBox.Show($"Venda registrada com sucesso!\nTotal: R$ {total:N2}",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            catch (IOException)
            {
                MessageBox.Show("Não foi possível salvar a venda no arquivo.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Sem permissão para salvar o arquivo de vendas.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtCliente.Clear();
            cboCafe.SelectedIndex = 0;
            nudQuantidade.Value = 1;
            chkChantilly.Checked = false;
            AtualizarPreco();
            txtCliente.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarPreco();
        }

        private void campos_Alterados(object sender, EventArgs e)
        {
            // Ao modificar uma venda, o total antigo deixa de ser exibido.
            lblResultado.Text = "Total: R$ 0,00";
        }
    }
}
