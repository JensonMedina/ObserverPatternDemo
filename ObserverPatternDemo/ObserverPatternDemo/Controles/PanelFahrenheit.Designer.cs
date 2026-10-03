namespace ObserverPatternDemo.Controles
{
    partial class PanelFahrenheit
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
            lblTemperatura = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(44, 93);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(55, 15);
            lblTemperatura.TabIndex = 3;
            lblTemperatura.Text = "Sin datos";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(132, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Temperatura Fahrenheit";
            // 
            // PanelFahrenheit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTemperatura);
            Controls.Add(lblTitulo);
            Name = "PanelFahrenheit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTemperatura;
        private Label lblTitulo;
    }
}
