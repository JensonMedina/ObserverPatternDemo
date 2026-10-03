namespace ObserverPatternDemo.Controles
{
    partial class PanelHistorial
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
            lstHistorial = new ListBox();
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
            layoutContenido.Controls.Add(lstHistorial, 0, 1);
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
            lblTitulo.Text = "Historial de temperaturas";
            lblTitulo.TabIndex = 0;
            //
            // lstHistorial
            //
            lstHistorial.BackColor = Color.FromArgb(249, 251, 253);
            lstHistorial.BorderStyle = BorderStyle.FixedSingle;
            lstHistorial.Dock = DockStyle.Fill;
            lstHistorial.Font = new Font("Segoe UI", 11F);
            lstHistorial.ForeColor = Color.FromArgb(42, 55, 70);
            lstHistorial.FormattingEnabled = true;
            lstHistorial.HorizontalScrollbar = true;
            lstHistorial.IntegralHeight = false;
            lstHistorial.ItemHeight = 20;
            lstHistorial.Margin = new Padding(0);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.TabIndex = 1;
            //
            // PanelHistorial
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(layoutContenido);
            Font = new Font("Segoe UI", 10F);
            Name = "PanelHistorial";
            Size = new Size(920, 200);
            layoutContenido.ResumeLayout(false);
            layoutContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutContenido;
        private Label lblTitulo;
        private ListBox lstHistorial;
    }
}
