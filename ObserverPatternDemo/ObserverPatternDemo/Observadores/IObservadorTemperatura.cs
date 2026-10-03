namespace ObserverPatternDemo.Observadores;

/// <summary>
/// Contrato del rol Observador en el patrón Observer.
/// Todos los componentes que quieran recibir temperaturas
/// deben implementar esta interfaz.
/// </summary>
public interface IObservadorTemperatura
{
    /// <summary>
    /// El sujeto invoca este método en cada observador suscripto
    /// cuando publica una temperatura.
    /// Cada observador decide cómo utilizar el valor recibido.
    /// </summary>
    /// <param name="temperaturaCelsius">
    /// Temperatura publicada, expresada en grados Celsius.
    /// </param>
    void ActualizarTemperatura(decimal temperaturaCelsius);
}
