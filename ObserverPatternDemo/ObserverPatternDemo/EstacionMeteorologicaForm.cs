using ObserverPatternDemo.Servicios;

namespace ObserverPatternDemo
{
    public partial class EstacionMeteorologicaForm : Form
    {
        private readonly TemperaturaService _temperaturaService = new TemperaturaService();

        public EstacionMeteorologicaForm()
        {
            InitializeComponent();

            // El formulario conecta al sujeto con el observador.
            // Suscribimos la instancia visual que está en la ventana.
            _temperaturaService.Suscribir(panelCelsius);
            _temperaturaService.Suscribir(panelFahrenheit);
            _temperaturaService.Suscribir(panelAlerta);
            _temperaturaService.Suscribir(panelHistorial);
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            // El formulario publica el dato.
            // El servicio se encarga de notificar a los observadores.
            _temperaturaService.PublicarTemperatura(nudTemperatura.Value);
        }

        private void chkCelsius_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCelsius.Checked)
            {
                _temperaturaService.Suscribir(panelCelsius);
            }
            else
            {
                _temperaturaService.Desuscribir(panelCelsius);
            }
        }

        private void chkFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFahrenheit.Checked)
            {
                _temperaturaService.Suscribir(panelFahrenheit);
            }
            else
            {
                _temperaturaService.Desuscribir(panelFahrenheit);
            }
        }

        private void chkAlerta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlerta.Checked)
            {
                _temperaturaService.Suscribir(panelAlerta);
            }
            else
            {
                _temperaturaService.Desuscribir(panelAlerta);
            }
        }

        private void chkHistorial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHistorial.Checked)
            {
                _temperaturaService.Suscribir(panelHistorial);
            }
            else
            {
                _temperaturaService.Desuscribir(panelHistorial);
            }
        }
    }
}