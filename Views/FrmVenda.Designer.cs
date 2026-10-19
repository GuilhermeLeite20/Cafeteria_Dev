namespace CafeteriaDev.Views
{
    partial class FrmVenda
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
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblCafe = new Label();
            cboCafe = new ComboBox();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            lblPreco = new Label();
            chkChantilly = new CheckBox();
            lblResultado = new Label();
            btnCalcular = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnVoltar = new Button();
            pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            //
            // pnlTopo
            //
            pnlTopo.BackColor = Color.FromArgb(67, 44, 34);
            pnlTopo.Controls.Add(lblTitulo);
            pnlTopo.Controls.Add(lblSubtitulo);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(870, 116);
            //
            // lblTitulo
            //
            lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(40, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(785, 52);
            lblTitulo.Text = "NOVA VENDA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(235, 210, 192);
            lblSubtitulo.Location = new Point(40, 74);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(785, 23);
            lblSubtitulo.Text = "Registre um pedido de café em poucos passos";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblCliente
            //
            lblCliente.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(67, 44, 34);
            lblCliente.Location = new Point(85, 166);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(205, 28);
            lblCliente.Text = "Nome do cliente:";
            //
            // txtCliente
            //
            txtCliente.Font = new Font("Segoe UI", 11F);
            txtCliente.Location = new Point(299, 161);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(480, 32);
            txtCliente.TabIndex = 0;
            txtCliente.TextChanged += campos_Alterados;
            //
            // lblCafe
            //
            lblCafe.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCafe.ForeColor = Color.FromArgb(67, 44, 34);
            lblCafe.Location = new Point(85, 220);
            lblCafe.Name = "lblCafe";
            lblCafe.Size = new Size(205, 28);
            lblCafe.Text = "Café:";
            //
            // cboCafe
            //
            cboCafe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCafe.Font = new Font("Segoe UI", 11F);
            cboCafe.FormattingEnabled = true;
            cboCafe.Items.AddRange(new object[] { "Café Expresso", "Cappuccino", "Café Latte", "Café Mocha" });
            cboCafe.Location = new Point(299, 216);
            cboCafe.Name = "cboCafe";
            cboCafe.Size = new Size(480, 33);
            cboCafe.TabIndex = 1;
            cboCafe.SelectedIndexChanged += cboCafe_SelectedIndexChanged;
            //
            // lblQuantidade
            //
            lblQuantidade.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblQuantidade.ForeColor = Color.FromArgb(67, 44, 34);
            lblQuantidade.Location = new Point(85, 274);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(205, 28);
            lblQuantidade.Text = "Quantidade:";
            //
            // nudQuantidade
            //
            nudQuantidade.Font = new Font("Segoe UI", 11F);
            nudQuantidade.Location = new Point(299, 271);
            nudQuantidade.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(106, 32);
            nudQuantidade.TabIndex = 2;
            nudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantidade.ValueChanged += campos_Alterados;
            //
            // lblPreco
            //
            lblPreco.Font = new Font("Segoe UI", 10F);
            lblPreco.ForeColor = Color.FromArgb(109, 92, 81);
            lblPreco.Location = new Point(430, 271);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(345, 30);
            lblPreco.Text = "Preço unitário: R$ 6,00";
            lblPreco.TextAlign = ContentAlignment.MiddleLeft;
            //
            // chkChantilly
            //
            chkChantilly.AutoSize = true;
            chkChantilly.Font = new Font("Segoe UI", 11F);
            chkChantilly.ForeColor = Color.FromArgb(67, 44, 34);
            chkChantilly.Location = new Point(299, 330);
            chkChantilly.Name = "chkChantilly";
            chkChantilly.Size = new Size(400, 31);
            chkChantilly.TabIndex = 3;
            chkChantilly.Text = "Adicionar chantilly (+ R$ 3,00 por café)";
            chkChantilly.UseVisualStyleBackColor = true;
            chkChantilly.CheckedChanged += campos_Alterados;
            //
            // lblResultado
            //
            lblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblResultado.ForeColor = Color.FromArgb(44, 125, 85);
            lblResultado.Location = new Point(89, 386);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(690, 65);
            lblResultado.Text = "Total: R$ 0,00";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnCalcular
            //
            btnCalcular.BackColor = Color.FromArgb(230, 222, 214);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.FromArgb(67, 44, 34);
            btnCalcular.Location = new Point(73, 480);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(166, 49);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            //
            // btnSalvar
            //
            btnSalvar.BackColor = Color.FromArgb(135, 79, 49);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(258, 480);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(184, 49);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Registrar venda";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            //
            // btnLimpar
            //
            btnLimpar.BackColor = Color.FromArgb(230, 222, 214);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.FromArgb(67, 44, 34);
            btnLimpar.Location = new Point(461, 480);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(144, 49);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            //
            // btnVoltar
            //
            btnVoltar.BackColor = Color.FromArgb(230, 222, 214);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.FromArgb(67, 44, 34);
            btnVoltar.Location = new Point(624, 480);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(173, 49);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar ao menu";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            //
            // FrmVenda
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            ClientSize = new Size(870, 568);
            Controls.Add(pnlTopo);
            Controls.Add(lblCliente);
            Controls.Add(txtCliente);
            Controls.Add(lblCafe);
            Controls.Add(cboCafe);
            Controls.Add(lblQuantidade);
            Controls.Add(nudQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(chkChantilly);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmVenda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cafeteria Dev - Registrar Venda";
            pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel pnlTopo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblCafe;
        private ComboBox cboCafe;
        private Label lblQuantidade;
        private NumericUpDown nudQuantidade;
        private Label lblPreco;
        private CheckBox chkChantilly;
        private Label lblResultado;
        private Button btnCalcular;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnVoltar;
    }
}
