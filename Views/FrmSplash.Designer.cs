namespace CafeteriaDev.Views
{
    partial class FrmSplash
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblCarregando = new Label();
            prgCarregando = new ProgressBar();
            timerSplash = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = false;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(40, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(680, 64);
            lblTitulo.Text = "CAFETERIA DEV";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            lblSubtitulo.Font = new Font("Segoe UI", 13F);
            lblSubtitulo.ForeColor = Color.FromArgb(238, 215, 197);
            lblSubtitulo.Location = new Point(50, 115);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(660, 32);
            lblSubtitulo.Text = "Um café e seu código fica melhor.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblCarregando
            //
            lblCarregando.Font = new Font("Segoe UI", 10F);
            lblCarregando.ForeColor = Color.White;
            lblCarregando.Location = new Point(55, 188);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(650, 24);
            lblCarregando.Text = "Carregando sistema...";
            lblCarregando.TextAlign = ContentAlignment.MiddleCenter;
            //
            // prgCarregando
            //
            prgCarregando.Location = new Point(105, 225);
            prgCarregando.Name = "prgCarregando";
            prgCarregando.Size = new Size(550, 13);
            prgCarregando.Minimum = 0;
            prgCarregando.Maximum = 100;
            //
            // timerSplash
            //
            timerSplash.Interval = 40;
            timerSplash.Tick += timerSplash_Tick;
            //
            // FrmSplash
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 44, 34);
            ClientSize = new Size(760, 300);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblCarregando);
            Controls.Add(prgCarregando);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafeteria Dev - Carregando";
            ResumeLayout(false);
        }
        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblCarregando;
        private ProgressBar prgCarregando;
        private System.Windows.Forms.Timer timerSplash;
    }
}
