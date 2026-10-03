namespace ObserverPatternDemo.Controles
{
    partial class PanelCelsius
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            layoutContenido = new TableLayoutPanel();
            lblTitulo = new Label();
            lblTemperatura = new Label();
            layoutContenido.SuspendLayout();
            SuspendLayout();
            //
            // layoutContenido
            //
            layoutContenido.ColumnCount = 1;
            layoutContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutContenido.RowCount = 2;
            layoutContenido.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layoutContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutContenido.Controls.Add(lblTitulo, 0, 0);
            layoutContenido.Controls.Add(lblTemperatura, 0, 1);
            layoutContenido.Dock = DockStyle.Fill;
            layoutContenido.Margin = new Padding(0);
            layoutContenido.Name = "layoutContenido";
            layoutContenido.TabIndex = 0;
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 93, 135);
            lblTitulo.Margin = new Padding(0, 0, 0, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Celsius";
            lblTitulo.TabIndex = 0;
            //
            // lblTemperatura
            //
            lblTemperatura.Dock = DockStyle.Fill;
            lblTemperatura.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTemperatura.ForeColor = Color.FromArgb(42, 55, 70);
            lblTemperatura.Margin = new Padding(0);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.TabIndex = 1;
            lblTemperatura.Text = "Sin datos";
            lblTemperatura.TextAlign = ContentAlignment.MiddleLeft;
            //
            // PanelCelsius
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(layoutContenido);
            Font = new Font("Segoe UI", 10F);
            Name = "PanelCelsius";
            Size = new Size(280, 152);
            layoutContenido.ResumeLayout(false);
            layoutContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutContenido;
        private Label lblTitulo;
        private Label lblTemperatura;
    }
}
