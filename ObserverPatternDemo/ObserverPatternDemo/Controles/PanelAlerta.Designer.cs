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
            lblEstado = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(44, 93);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(55, 15);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Sin datos";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(15, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(122, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Alerta de temperatura";
            // 
            // PanelAlerta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblEstado);
            Controls.Add(lblTitulo);
            Name = "PanelAlerta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private Label lblTitulo;
    }
}
