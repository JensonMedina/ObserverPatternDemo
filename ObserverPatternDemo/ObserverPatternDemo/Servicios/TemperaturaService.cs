using System.Diagnostics;
using ObserverPatternDemo.Observadores;

namespace ObserverPatternDemo.Servicios;

public class TemperaturaService
{
    // Guardamos referencias a los objetos suscriptos
    // utilizando el contrato común del observador.
    private readonly List<IObservadorTemperatura> _observadores = new List<IObservadorTemperatura>();

    /// <summary>
    /// Suscribe un observador para recibir futuras publicaciones.
    /// No envía una temperatura al momento de suscribirlo.
    /// </summary>
    public void Suscribir(IObservadorTemperatura observador)
    {
        if (observador == null)
        {
            throw new ArgumentNullException(nameof(observador));
        }

        // Evitamos agregar dos veces el mismo observador.
        if (!_observadores.Contains(observador))
        {
            _observadores.Add(observador);
        }
    }
    /// <summary>
    /// Quita un observador de las futuras publicaciones.
    /// Si no estaba suscripto, no produce ningún cambio.
    /// </summary>
    public void Desuscribir(IObservadorTemperatura observador)
    {
        if (observador == null)
        {
            throw new ArgumentNullException(nameof(observador));
        }

        _observadores.Remove(observador);
    }
    /// <summary>
    /// Publica una temperatura y notifica a los observadores.
    /// Cada llamada genera una notificación, incluso si
    /// el valor es igual al de la publicación anterior.
    /// </summary>
    public void PublicarTemperatura(decimal temperaturaCelsius)
    {
        Notificar(temperaturaCelsius);
    }
    private void Notificar(decimal temperaturaCelsius)
    {
        // Copiamos la lista para que una suscripción o
        // desuscripción durante una notificación no invalide
        // el recorrido. Los cambios aplican a la próxima publicación.
        IObservadorTemperatura[] observadoresActuales = _observadores.ToArray();

        foreach (IObservadorTemperatura observador in observadoresActuales)
        {
            try
            {
                //La parte central del patrón es esta llamada.
                //El servicio no pregunta si el observador es una pantalla Celsius, Fahrenheit o una alerta.
                //Todos cumplen el mismo contrato, así que puede notificarlos de la misma manera.
                observador.ActualizarTemperatura(temperaturaCelsius);
            }
            catch (Exception ex)
            {
                // Aislamos el fallo de este observador para continuar
                // notificando a los demás. No reintentamos la entrega.
                Trace.TraceError("Error notificando al observador {0}. " + "Temperatura: {1} °C. Detalle: {2}", observador.GetType().Name, temperaturaCelsius, ex);
            }
        }
    }
}
