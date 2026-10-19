namespace CafeteriaDev.Models
{
    class PedidoCafe
    {
        private string _cliente;
        private string _cafe;
        private int _quantidade;
        private decimal _valorUnitario;

        public string Cliente
        {
            get => _cliente;
            set => _cliente = value;
        }

        public string Cafe
        {
            get => _cafe;
            set => _cafe = value;
        }

        public int Quantidade
        {
            get => _quantidade;
            set => _quantidade = value > 0 ? value : 1;
        }

        public decimal ValorUnitario
        {
            get => _valorUnitario;
            set => _valorUnitario = value > 0 ? value : 0;
        }

        public PedidoCafe(string cliente, string cafe, int quantidade, decimal valorUnitario)
        {
            Cliente = cliente;
            Cafe = cafe;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public virtual decimal CalcularTotal()
        {
            return Quantidade * ValorUnitario;
        }

        public virtual string DescricaoAdicional()
        {
            return "Sem adicional";
        }
    }
}