namespace ObserverPatternDemo.Controles
{
    partial class PanelAlerta
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
            lblEstado = new Label();
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
            layoutContenido.Controls.Add(lblEstado, 0, 1);
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
            lblTitulo.ForeColor = Color.FromArgb(66, 81, 99);
            lblTitulo.Margin = new Padding(0, 0, 0, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Alertas";
            lblTitulo.TabIndex = 0;
            //
            // lblEstado
            //
            lblEstado.Dock = DockStyle.Fill;
            lblEstado.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEstado.ForeColor = Color.FromArgb(42, 55, 70);
            lblEstado.Margin = new Padding(0);
            lblEstado.Name = "lblEstado";
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Sin datos";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            //
            // PanelAlerta
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(layoutContenido);
            Font = new Font("Segoe UI", 10F);
            Name = "PanelAlerta";
            Size = new Size(280, 152);
            layoutContenido.ResumeLayout(false);
            layoutContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutContenido;
        private Label lblTitulo;
        private Label lblEstado;
    }
}
