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
            lblTitulo = new Label();
            lblTemperatura = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(17, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(113, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Temperatura Celsius";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(42, 72);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(55, 15);
            lblTemperatura.TabIndex = 1;
            lblTemperatura.Text = "Sin datos";
            // 
            // PanelCelsius
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTemperatura);
            Controls.Add(lblTitulo);
            Name = "PanelCelsius";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTemperatura;
    }
}
