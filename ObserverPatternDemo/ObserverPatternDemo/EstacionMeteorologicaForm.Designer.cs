namespace ObserverPatternDemo
{
    partial class EstacionMeteorologicaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            layoutPrincipal = new TableLayoutPanel();
            encabezado = new TableLayoutPanel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            seccionPublicacion = new TableLayoutPanel();
            lblEntrada = new Label();
            filaPublicacion = new FlowLayoutPanel();
            nudTemperatura = new NumericUpDown();
            btnPublicar = new Button();
            tarjetas = new TableLayoutPanel();
            tarjetaCelsius = new TableLayoutPanel();
            panelCelsius = new Controles.PanelCelsius();
            chkCelsius = new CheckBox();
            tarjetaFahrenheit = new TableLayoutPanel();
            panelFahrenheit = new Controles.PanelFahrenheit();
            chkFahrenheit = new CheckBox();
            tarjetaAlerta = new TableLayoutPanel();
            panelAlerta = new Controles.PanelAlerta();
            chkAlerta = new CheckBox();
            tarjetaHistorial = new TableLayoutPanel();
            panelHistorial = new Controles.PanelHistorial();
            chkHistorial = new CheckBox();
            layoutPrincipal.SuspendLayout();
            encabezado.SuspendLayout();
            seccionPublicacion.SuspendLayout();
            filaPublicacion.SuspendLayout();
            tarjetas.SuspendLayout();
            tarjetaCelsius.SuspendLayout();
            tarjetaFahrenheit.SuspendLayout();
            tarjetaAlerta.SuspendLayout();
            tarjetaHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTemperatura).BeginInit();
            SuspendLayout();
            //
            // layoutPrincipal
            //
            layoutPrincipal.ColumnCount = 1;
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutPrincipal.RowCount = 4;
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutPrincipal.Controls.Add(encabezado, 0, 0);
            layoutPrincipal.Controls.Add(seccionPublicacion, 0, 1);
            layoutPrincipal.Controls.Add(tarjetas, 0, 2);
            layoutPrincipal.Controls.Add(tarjetaHistorial, 0, 3);
            layoutPrincipal.Dock = DockStyle.Fill;
            layoutPrincipal.Margin = new Padding(0);
            layoutPrincipal.Name = "layoutPrincipal";
            layoutPrincipal.TabIndex = 0;
            //
            // encabezado
            //
            encabezado.AutoSize = true;
            encabezado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            encabezado.ColumnCount = 1;
            encabezado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            encabezado.RowCount = 2;
            encabezado.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            encabezado.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            encabezado.Controls.Add(lblTitulo, 0, 0);
            encabezado.Controls.Add(lblSubtitulo, 0, 1);
            encabezado.Dock = DockStyle.Fill;
            encabezado.Margin = new Padding(0, 0, 0, 20);
            encabezado.Name = "encabezado";
            encabezado.TabIndex = 0;
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 48, 67);
            lblTitulo.Margin = new Padding(0, 0, 0, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Estación meteorológica";
            lblTitulo.TabIndex = 0;
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.ForeColor = Color.FromArgb(96, 110, 126);
            lblSubtitulo.Margin = new Padding(0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Text = "Demostración del patrón Observer";
            lblSubtitulo.TabIndex = 1;
            //
            // seccionPublicacion
            //
            seccionPublicacion.AutoSize = true;
            seccionPublicacion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            seccionPublicacion.BackColor = Color.White;
            seccionPublicacion.Padding = new Padding(20, 16, 20, 16);
            seccionPublicacion.ColumnCount = 1;
            seccionPublicacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            seccionPublicacion.RowCount = 2;
            seccionPublicacion.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            seccionPublicacion.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            seccionPublicacion.Controls.Add(lblEntrada, 0, 0);
            seccionPublicacion.Controls.Add(filaPublicacion, 0, 1);
            seccionPublicacion.Dock = DockStyle.Fill;
            seccionPublicacion.Margin = new Padding(0, 0, 0, 20);
            seccionPublicacion.Name = "seccionPublicacion";
            seccionPublicacion.TabIndex = 1;
            //
            // lblEntrada
            //
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEntrada.Margin = new Padding(0, 0, 0, 10);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Text = "Temperatura a publicar (°C)";
            lblEntrada.TabIndex = 0;
            //
            // filaPublicacion
            //
            filaPublicacion.AutoSize = true;
            filaPublicacion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filaPublicacion.Controls.Add(nudTemperatura);
            filaPublicacion.Controls.Add(btnPublicar);
            filaPublicacion.Dock = DockStyle.Fill;
            filaPublicacion.Margin = new Padding(0);
            filaPublicacion.WrapContents = false;
            filaPublicacion.Name = "filaPublicacion";
            filaPublicacion.TabIndex = 1;
            //
            // nudTemperatura
            //
            nudTemperatura.DecimalPlaces = 1;
            nudTemperatura.Font = new Font("Segoe UI", 14F);
            nudTemperatura.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudTemperatura.Margin = new Padding(0, 4, 16, 4);
            nudTemperatura.Name = "nudTemperatura";
            nudTemperatura.Size = new Size(160, 32);
            nudTemperatura.TabIndex = 0;
            //
            // btnPublicar
            //
            btnPublicar.AutoSize = true;
            btnPublicar.BackColor = Color.FromArgb(40, 93, 135);
            btnPublicar.FlatStyle = FlatStyle.Flat;
            btnPublicar.FlatAppearance.BorderSize = 0;
            btnPublicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPublicar.ForeColor = Color.White;
            btnPublicar.Margin = new Padding(0);
            btnPublicar.Padding = new Padding(16, 6, 16, 6);
            btnPublicar.Name = "btnPublicar";
            btnPublicar.Size = new Size(220, 42);
            btnPublicar.TabIndex = 1;
            btnPublicar.Text = "Publicar temperatura";
            btnPublicar.UseVisualStyleBackColor = false;
            btnPublicar.Click += btnPublicar_Click;
            //
            // tarjetas
            //
            tarjetas.ColumnCount = 3;
            tarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tarjetas.RowCount = 1;
            tarjetas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tarjetas.Controls.Add(tarjetaCelsius, 0, 0);
            tarjetas.Controls.Add(tarjetaFahrenheit, 1, 0);
            tarjetas.Controls.Add(tarjetaAlerta, 2, 0);
            tarjetas.Dock = DockStyle.Fill;
            tarjetas.Margin = new Padding(0, 0, 0, 20);
            tarjetas.Name = "tarjetas";
            tarjetas.TabIndex = 2;
            //
            // tarjetaCelsius
            //
            tarjetaCelsius.BackColor = Color.White;
            tarjetaCelsius.Padding = new Padding(16);
            tarjetaCelsius.ColumnCount = 1;
            tarjetaCelsius.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tarjetaCelsius.RowCount = 2;
            tarjetaCelsius.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tarjetaCelsius.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tarjetaCelsius.Controls.Add(panelCelsius, 0, 0);
            tarjetaCelsius.Controls.Add(chkCelsius, 0, 1);
            tarjetaCelsius.Dock = DockStyle.Fill;
            tarjetaCelsius.Margin = new Padding(0, 0, 12, 0);
            tarjetaCelsius.Name = "tarjetaCelsius";
            tarjetaCelsius.TabIndex = 0;
            //
            // panelCelsius
            //
            panelCelsius.Dock = DockStyle.Fill;
            panelCelsius.Margin = new Padding(0);
            panelCelsius.Name = "panelCelsius";
            panelCelsius.TabIndex = 0;
            //
            // chkCelsius
            //
            chkCelsius.AutoSize = true;
            chkCelsius.Checked = true;
            chkCelsius.CheckState = CheckState.Checked;
            chkCelsius.Margin = new Padding(0, 12, 0, 0);
            chkCelsius.Name = "chkCelsius";
            chkCelsius.TabIndex = 1;
            chkCelsius.Text = "Suscribir Celsius";
            chkCelsius.UseVisualStyleBackColor = true;
            chkCelsius.CheckedChanged += chkCelsius_CheckedChanged;
            //
            // tarjetaFahrenheit
            //
            tarjetaFahrenheit.BackColor = Color.White;
            tarjetaFahrenheit.Padding = new Padding(16);
            tarjetaFahrenheit.ColumnCount = 1;
            tarjetaFahrenheit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tarjetaFahrenheit.RowCount = 2;
            tarjetaFahrenheit.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tarjetaFahrenheit.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tarjetaFahrenheit.Controls.Add(panelFahrenheit, 0, 0);
            tarjetaFahrenheit.Controls.Add(chkFahrenheit, 0, 1);
            tarjetaFahrenheit.Dock = DockStyle.Fill;
            tarjetaFahrenheit.Margin = new Padding(6, 0, 6, 0);
            tarjetaFahrenheit.Name = "tarjetaFahrenheit";
            tarjetaFahrenheit.TabIndex = 1;
            //
            // panelFahrenheit
            //
            panelFahrenheit.Dock = DockStyle.Fill;
            panelFahrenheit.Margin = new Padding(0);
            panelFahrenheit.Name = "panelFahrenheit";
            panelFahrenheit.TabIndex = 0;
            //
            // chkFahrenheit
            //
            chkFahrenheit.AutoSize = true;
            chkFahrenheit.Checked = true;
            chkFahrenheit.CheckState = CheckState.Checked;
            chkFahrenheit.Margin = new Padding(0, 12, 0, 0);
            chkFahrenheit.Name = "chkFahrenheit";
            chkFahrenheit.TabIndex = 1;
            chkFahrenheit.Text = "Suscribir Fahrenheit";
            chkFahrenheit.UseVisualStyleBackColor = true;
            chkFahrenheit.CheckedChanged += chkFahrenheit_CheckedChanged;
            //
            // tarjetaAlerta
            //
            tarjetaAlerta.BackColor = Color.White;
            tarjetaAlerta.Padding = new Padding(16);
            tarjetaAlerta.ColumnCount = 1;
            tarjetaAlerta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tarjetaAlerta.RowCount = 2;
            tarjetaAlerta.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tarjetaAlerta.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tarjetaAlerta.Controls.Add(panelAlerta, 0, 0);
            tarjetaAlerta.Controls.Add(chkAlerta, 0, 1);
            tarjetaAlerta.Dock = DockStyle.Fill;
            tarjetaAlerta.Margin = new Padding(12, 0, 0, 0);
            tarjetaAlerta.Name = "tarjetaAlerta";
            tarjetaAlerta.TabIndex = 2;
            //
            // panelAlerta
            //
            panelAlerta.Dock = DockStyle.Fill;
            panelAlerta.Margin = new Padding(0);
            panelAlerta.Name = "panelAlerta";
            panelAlerta.TabIndex = 0;
            //
            // chkAlerta
            //
            chkAlerta.AutoSize = true;
            chkAlerta.Checked = true;
            chkAlerta.CheckState = CheckState.Checked;
            chkAlerta.Margin = new Padding(0, 12, 0, 0);
            chkAlerta.Name = "chkAlerta";
            chkAlerta.TabIndex = 1;
            chkAlerta.Text = "Suscribir alertas";
            chkAlerta.UseVisualStyleBackColor = true;
            chkAlerta.CheckedChanged += chkAlerta_CheckedChanged;
            //
            // tarjetaHistorial
            //
            tarjetaHistorial.BackColor = Color.White;
            tarjetaHistorial.Padding = new Padding(16);
            tarjetaHistorial.ColumnCount = 1;
            tarjetaHistorial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tarjetaHistorial.RowCount = 2;
            tarjetaHistorial.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tarjetaHistorial.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tarjetaHistorial.Controls.Add(panelHistorial, 0, 0);
            tarjetaHistorial.Controls.Add(chkHistorial, 0, 1);
            tarjetaHistorial.Dock = DockStyle.Fill;
            tarjetaHistorial.Margin = new Padding(0);
            tarjetaHistorial.Name = "tarjetaHistorial";
            tarjetaHistorial.TabIndex = 3;
            //
            // panelHistorial
            //
            panelHistorial.Dock = DockStyle.Fill;
            panelHistorial.Margin = new Padding(0);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.TabIndex = 0;
            //
            // chkHistorial
            //
            chkHistorial.AutoSize = true;
            chkHistorial.Checked = true;
            chkHistorial.CheckState = CheckState.Checked;
            chkHistorial.Margin = new Padding(0, 12, 0, 0);
            chkHistorial.Name = "chkHistorial";
            chkHistorial.TabIndex = 1;
            chkHistorial.Text = "Suscribir historial";
            chkHistorial.UseVisualStyleBackColor = true;
            chkHistorial.CheckedChanged += chkHistorial_CheckedChanged;
            //
            // EstacionMeteorologicaForm
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 249);
            ClientSize = new Size(1040, 780);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(42, 55, 70);
            MinimumSize = new Size(940, 740);
            Padding = new Padding(24);
            Controls.Add(layoutPrincipal);
            Name = "EstacionMeteorologicaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estación meteorológica — Observer";
            layoutPrincipal.ResumeLayout(false);
            layoutPrincipal.PerformLayout();
            encabezado.ResumeLayout(false);
            encabezado.PerformLayout();
            seccionPublicacion.ResumeLayout(false);
            seccionPublicacion.PerformLayout();
            filaPublicacion.ResumeLayout(false);
            filaPublicacion.PerformLayout();
            tarjetas.ResumeLayout(false);
            tarjetas.PerformLayout();
            tarjetaCelsius.ResumeLayout(false);
            tarjetaCelsius.PerformLayout();
            tarjetaFahrenheit.ResumeLayout(false);
            tarjetaFahrenheit.PerformLayout();
            tarjetaAlerta.ResumeLayout(false);
            tarjetaAlerta.PerformLayout();
            tarjetaHistorial.ResumeLayout(false);
            tarjetaHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTemperatura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutPrincipal;
        private TableLayoutPanel encabezado;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private TableLayoutPanel seccionPublicacion;
        private Label lblEntrada;
        private FlowLayoutPanel filaPublicacion;
        private NumericUpDown nudTemperatura;
        private Button btnPublicar;
        private TableLayoutPanel tarjetas;
        private TableLayoutPanel tarjetaCelsius;
        private Controles.PanelCelsius panelCelsius;
        private CheckBox chkCelsius;
        private TableLayoutPanel tarjetaFahrenheit;
        private Controles.PanelFahrenheit panelFahrenheit;
        private CheckBox chkFahrenheit;
        private TableLayoutPanel tarjetaAlerta;
        private Controles.PanelAlerta panelAlerta;
        private CheckBox chkAlerta;
        private TableLayoutPanel tarjetaHistorial;
        private Controles.PanelHistorial panelHistorial;
        private CheckBox chkHistorial;
    }
}
