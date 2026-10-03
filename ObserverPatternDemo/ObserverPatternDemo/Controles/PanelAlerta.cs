using System.Drawing;
using System.Windows.Forms;
using ObserverPatternDemo.Observadores;

namespace ObserverPatternDemo.Controles;

/// <summary>
/// Observador concreto que evalúa la temperatura recibida
/// y muestra una alerta si supera el umbral configurado.
/// </summary>
public partial class PanelAlerta : UserControl, IObservadorTemperatura
{
    // Umbral elegido para la demostración.
    private const decimal UmbralAlertaCelsius = 35m;

    public PanelAlerta()
    {
        InitializeComponent();
    }

    public void ActualizarTemperatura(decimal temperaturaCelsius)
    {
        // La regla de alerta pertenece a este observador.
        // El sujeto no necesita conocerla.
        if (temperaturaCelsius > UmbralAlertaCelsius)
        {
            lblEstado.Text = "Alerta: temperatura alta";
            lblEstado.ForeColor = Color.Firebrick;
        }
        else
        {
            lblEstado.Text = "Temperatura dentro del umbral";
            lblEstado.ForeColor = Color.DarkGreen;
        }
    }
}