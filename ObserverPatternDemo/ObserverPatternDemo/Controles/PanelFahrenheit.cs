using ObserverPatternDemo.Observadores;

namespace ObserverPatternDemo.Controles;

/// <summary>
/// Observador concreto que convierte la temperatura recibida
/// en Celsius y la muestra en Fahrenheit.
/// </summary>
public partial class PanelFahrenheit : UserControl, IObservadorTemperatura
{
    public PanelFahrenheit()
    {
        InitializeComponent();
    }

    public void ActualizarTemperatura(decimal temperaturaCelsius)
    {
        // La conversión es responsabilidad de este observador.
        // El sujeto siempre publica el dato en Celsius.
        decimal temperaturaFahrenheit = temperaturaCelsius * 9m / 5m + 32m;

        lblTemperatura.Text = $"{temperaturaFahrenheit:0.0} °F";
    }
}