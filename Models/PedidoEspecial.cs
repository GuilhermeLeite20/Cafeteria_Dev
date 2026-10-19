namespace CafeteriaDev.Models
{
    class PedidoEspecial : PedidoCafe
    {
        public bool Chantilly { get; set; }

        public PedidoEspecial(string cliente, string cafe, int quantidade,
            decimal valorUnitario, bool chantilly)
            : base(cliente, cafe, quantidade, valorUnitario)
        {
            Chantilly = chantilly;
        }

        public override decimal CalcularTotal()
        {
            decimal totalBase = base.CalcularTotal();
            return Chantilly ? totalBase + (Quantidade * 3m) : totalBase;
        }

        public override string DescricaoAdicional()
        {
            return Chantilly ? "Chantilly (+ R$ 3,00 por café)" : "Sem adicional";
        }
    }
}