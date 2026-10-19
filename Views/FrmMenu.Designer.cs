namespace CafeteriaDev.Views
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlTopo = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblBoasVindas = new Label();
            btnVenda = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            lblRodape = new Label();
            pnlTopo.SuspendLayout();
            SuspendLayout();
            //
            // pnlTopo
            //
            pnlTopo.BackColor = Color.FromArgb(67, 44, 34);
            pnlTopo.Controls.Add(lblTitulo);
            pnlTopo.Controls.Add(lblSubtitulo);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(860, 145);
            //
            // lblTitulo
            //
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(55, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(750, 60);
            lblTitulo.Text = "CAFETERIA DEV";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(235, 210, 192);
            lblSubtitulo.Location = new Point(70, 98);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(720, 28);
            lblSubtitulo.Text = "Sistema simples de vendas e relatórios";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblBoasVindas
            //
            lblBoasVindas.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblBoasVindas.ForeColor = Color.FromArgb(67, 44, 34);
            lblBoasVindas.Location = new Point(62, 185);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(736, 50);
            lblBoasVindas.Text = "Bem-vindo(a)! O que deseja fazer?";
            lblBoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnVenda
            //
            btnVenda.BackColor = Color.FromArgb(135, 79, 49);
            btnVenda.FlatStyle = FlatStyle.Flat;
            btnVenda.FlatAppearance.BorderSize = 0;
            btnVenda.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnVenda.ForeColor = Color.White;
            btnVenda.Location = new Point(156, 270);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(250, 90);
            btnVenda.TabIndex = 0;
            btnVenda.Text = "NOVA VENDA";
            btnVenda.UseVisualStyleBackColor = false;
            btnVenda.Click += btnVenda_Click;
            //
            // btnRelatorio
            //
            btnRelatorio.BackColor = Color.FromArgb(67, 44, 34);
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRelatorio.ForeColor = Color.White;
            btnRelatorio.Location = new Point(450, 270);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(250, 90);
            btnRelatorio.TabIndex = 1;
            btnRelatorio.Text = "RELATÓRIO DE VENDAS";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            //
            // btnSair
            //
            btnSair.BackColor = Color.FromArgb(230, 222, 214);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = Color.FromArgb(67, 44, 34);
            btnSair.Location = new Point(358, 403);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(145, 42);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            //
            // lblRodape
            //
            lblRodape.Font = new Font("Segoe UI", 9F);
            lblRodape.ForeColor = Color.FromArgb(129, 110, 98);
            lblRodape.Location = new Point(15, 481);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(830, 24);
            lblRodape.Text = "Checkpoint 2 | C# Development | FIAP";
            lblRodape.TextAlign = ContentAlignment.MiddleCenter;
            //
            // FrmMenu
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            ClientSize = new Size(860, 520);
            Controls.Add(pnlTopo);
            Controls.Add(lblBoasVindas);
            Controls.Add(btnVenda);
            Controls.Add(btnRelatorio);
            Controls.Add(btnSair);
            Controls.Add(lblRodape);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafeteria Dev - Menu Principal";
            pnlTopo.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlTopo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblBoasVindas;
        private Button btnVenda;
        private Button btnRelatorio;
        private Button btnSair;
        private Label lblRodape;
    }
}
