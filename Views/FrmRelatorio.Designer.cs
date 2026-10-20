namespace CafeteriaDev.Views
{
    partial class FrmRelatorio
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
            txtRelatorio = new RichTextBox();
            btnAtualizar = new Button();
            btnVoltar = new Button();
            lblObservacao = new Label();
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
            pnlTopo.Size = new Size(920, 116);
            //
            // lblTitulo
            //
            lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(40, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(840, 52);
            lblTitulo.Text = "RELATÓRIO DE VENDAS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(235, 210, 192);
            lblSubtitulo.Location = new Point(40, 74);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(840, 23);
            lblSubtitulo.Text = "Visualize os cafés vendidos e os valores registrados";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // txtRelatorio
            //
            txtRelatorio.BackColor = Color.White;
            txtRelatorio.BorderStyle = BorderStyle.FixedSingle;
            txtRelatorio.Font = new Font("Consolas", 11F);
            txtRelatorio.ForeColor = Color.FromArgb(67, 44, 34);
            txtRelatorio.Location = new Point(50, 155);
            txtRelatorio.Name = "txtRelatorio";
            txtRelatorio.ReadOnly = true;
            txtRelatorio.ScrollBars = RichTextBoxScrollBars.Both;
            txtRelatorio.Size = new Size(820, 324);
            txtRelatorio.TabIndex = 0;
            txtRelatorio.WordWrap = false;
            //
            // btnAtualizar
            //
            btnAtualizar.BackColor = Color.FromArgb(135, 79, 49);
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(270, 502);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(174, 48);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            //
            // btnVoltar
            //
            btnVoltar.BackColor = Color.FromArgb(230, 222, 214);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.FromArgb(67, 44, 34);
            btnVoltar.Location = new Point(475, 502);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(174, 48);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar ao menu";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            //
            // lblObservacao
            //
            lblObservacao.Font = new Font("Segoe UI", 9F);
            lblObservacao.ForeColor = Color.FromArgb(129, 110, 98);
            lblObservacao.Location = new Point(40, 565);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(840, 28);
            lblObservacao.Text = "Dados carregados do arquivo vendas.txt";
            lblObservacao.TextAlign = ContentAlignment.MiddleCenter;
            //
            // FrmRelatorio
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            ClientSize = new Size(920, 605);
            Controls.Add(pnlTopo);
            Controls.Add(txtRelatorio);
            Controls.Add(btnAtualizar);
            Controls.Add(btnVoltar);
            Controls.Add(lblObservacao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRelatorio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cafeteria Dev - Relatório de Vendas";
            pnlTopo.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlTopo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private RichTextBox txtRelatorio;
        private Button btnAtualizar;
        private Button btnVoltar;
        private Label lblObservacao;
    }
}
