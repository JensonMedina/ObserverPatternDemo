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
            panelCelsius = new Controles.PanelCelsius();
            nudTemperatura = new NumericUpDown();
            btnPublicar = new Button();
            panelFahrenheit = new Controles.PanelFahrenheit();
            chkCelsius = new CheckBox();
            chkFahrenheit = new CheckBox();
            chkAlerta = new CheckBox();
            panelAlerta = new Controles.PanelAlerta();
            panelHistorial = new Controles.PanelHistorial();
            chkHistorial = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudTemperatura).BeginInit();
            SuspendLayout();
            // 
            // panelCelsius
            // 
            panelCelsius.Location = new Point(12, 123);
            panelCelsius.Name = "panelCelsius";
            panelCelsius.Size = new Size(150, 150);
            panelCelsius.TabIndex = 0;
            // 
            // nudTemperatura
            // 
            nudTemperatura.DecimalPlaces = 1;
            nudTemperatura.Location = new Point(12, 32);
            nudTemperatura.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudTemperatura.Name = "nudTemperatura";
            nudTemperatura.Size = new Size(120, 23);
            nudTemperatura.TabIndex = 1;
            // 
            // btnPublicar
            // 
            btnPublicar.Location = new Point(161, 33);
            btnPublicar.Name = "btnPublicar";
            btnPublicar.Size = new Size(162, 23);
            btnPublicar.TabIndex = 2;
            btnPublicar.Text = "Publicar temperatura";
            btnPublicar.UseVisualStyleBackColor = true;
            btnPublicar.Click += btnPublicar_Click;
            // 
            // panelFahrenheit
            // 
            panelFahrenheit.Location = new Point(213, 123);
            panelFahrenheit.Name = "panelFahrenheit";
            panelFahrenheit.Size = new Size(150, 150);
            panelFahrenheit.TabIndex = 3;
            // 
            // chkCelsius
            // 
            chkCelsius.AutoSize = true;
            chkCelsius.Checked = true;
            chkCelsius.CheckState = CheckState.Checked;
            chkCelsius.Location = new Point(363, 37);
            chkCelsius.Name = "chkCelsius";
            chkCelsius.Size = new Size(111, 19);
            chkCelsius.TabIndex = 4;
            chkCelsius.Text = "Suscribir Celsius";
            chkCelsius.UseVisualStyleBackColor = true;
            chkCelsius.CheckedChanged += chkCelsius_CheckedChanged;
            // 
            // chkFahrenheit
            // 
            chkFahrenheit.AutoSize = true;
            chkFahrenheit.Checked = true;
            chkFahrenheit.CheckState = CheckState.Checked;
            chkFahrenheit.Location = new Point(480, 37);
            chkFahrenheit.Name = "chkFahrenheit";
            chkFahrenheit.Size = new Size(130, 19);
            chkFahrenheit.TabIndex = 5;
            chkFahrenheit.Text = "Suscribir Fahrenheit";
            chkFahrenheit.UseVisualStyleBackColor = true;
            chkFahrenheit.CheckedChanged += chkFahrenheit_CheckedChanged;
            // 
            // chkAlerta
            // 
            chkAlerta.AutoSize = true;
            chkAlerta.Checked = true;
            chkAlerta.CheckState = CheckState.Checked;
            chkAlerta.Location = new Point(616, 37);
            chkAlerta.Name = "chkAlerta";
            chkAlerta.Size = new Size(108, 19);
            chkAlerta.TabIndex = 6;
            chkAlerta.Text = "Suscribir alertas";
            chkAlerta.UseVisualStyleBackColor = true;
            chkAlerta.CheckedChanged += chkAlerta_CheckedChanged;
            // 
            // panelAlerta
            // 
            panelAlerta.Location = new Point(407, 123);
            panelAlerta.Name = "panelAlerta";
            panelAlerta.Size = new Size(150, 150);
            panelAlerta.TabIndex = 7;
            // 
            // panelHistorial
            // 
            panelHistorial.Location = new Point(606, 123);
            panelHistorial.Name = "panelHistorial";
            panelHistorial.Size = new Size(150, 150);
            panelHistorial.TabIndex = 8;
            // 
            // chkHistorial
            // 
            chkHistorial.AutoSize = true;
            chkHistorial.Checked = true;
            chkHistorial.CheckState = CheckState.Checked;
            chkHistorial.Location = new Point(363, 71);
            chkHistorial.Name = "chkHistorial";
            chkHistorial.Size = new Size(116, 19);
            chkHistorial.TabIndex = 9;
            chkHistorial.Text = "Suscribir historial";
            chkHistorial.UseVisualStyleBackColor = true;
            chkHistorial.CheckedChanged += chkHistorial_CheckedChanged;
            // 
            // EstacionMeteorologicaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkHistorial);
            Controls.Add(panelHistorial);
            Controls.Add(panelAlerta);
            Controls.Add(chkAlerta);
            Controls.Add(chkFahrenheit);
            Controls.Add(chkCelsius);
            Controls.Add(panelFahrenheit);
            Controls.Add(btnPublicar);
            Controls.Add(nudTemperatura);
            Controls.Add(panelCelsius);
            Name = "EstacionMeteorologicaForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudTemperatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controles.PanelCelsius panelCelsius;
        private NumericUpDown nudTemperatura;
        private Button btnPublicar;
        private Controles.PanelFahrenheit panelFahrenheit;
        private CheckBox chkCelsius;
        private CheckBox chkFahrenheit;
        private CheckBox chkAlerta;
        private Controles.PanelAlerta panelAlerta;
        private Controles.PanelHistorial panelHistorial;
        private CheckBox chkHistorial;
    }
}
