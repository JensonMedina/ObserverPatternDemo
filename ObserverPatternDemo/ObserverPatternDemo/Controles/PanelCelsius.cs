using ObserverPatternDemo.Observadores;

namespace ObserverPatternDemo.Controles;

/// <summary>
/// Observador concreto del patrón Observer.
/// Reacciona a las notificaciones mostrando la temperatura en Celsius.
/// </summary>
public partial class PanelCelsius : UserControl, IObservadorTemperatura
{
    public PanelCelsius()
    {
        InitializeComponent();
    }

    /// <summary>
    /// El sujeto invoca este método cuando publica una temperatura.
    /// Este observador decide cómo representarla visualmente.
    /// </summary>
    public void ActualizarTemperatura(decimal temperaturaCelsius)
    {
        lblTemperatura.Text = $"{temperaturaCelsius:0.0} °C";
    }
}