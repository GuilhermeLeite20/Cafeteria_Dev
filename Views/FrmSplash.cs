namespace CafeteriaDev.Views
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            prgCarregando.Value = 0;
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (prgCarregando.Value < 100)
            {
                prgCarregando.Value = Math.Min(100, prgCarregando.Value + 4);
            }
            else
            {
                timerSplash.Stop();

                // O menu é exibido e, ao sair dele, o programa se encerra.
                this.Hide();
                FrmMenu menu = new FrmMenu();
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}
