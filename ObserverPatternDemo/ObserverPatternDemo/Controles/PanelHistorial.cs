using ObserverPatternDemo.Observadores;

namespace ObserverPatternDemo.Controles;

/// <summary>
/// Observador concreto que conserva un historial visual
/// de las temperaturas que recibe mientras está suscripto.
/// </summary>
public partial class PanelHistorial : UserControl, IObservadorTemperatura
{
    public PanelHistorial()
    {
        InitializeComponent();
    }

    public void ActualizarTemperatura(decimal temperaturaCelsius)
    {
        // Registramos la hora de recepción de la notificación.
        string registro = $"{DateTime.Now:HH:mm:ss} — {temperaturaCelsius:0.0} °C";

        lstHistorial.Items.Add(registro);

        // Desplazamos la lista para mostrar el último registro.
        lstHistorial.TopIndex = lstHistorial.Items.Count - 1;
    }
}