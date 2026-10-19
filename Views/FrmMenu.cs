namespace CafeteriaDev.Views
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FrmVenda venda = new FrmVenda();
            venda.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorio relatorio = new FrmRelatorio();
            relatorio.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
