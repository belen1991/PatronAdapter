using TemperaturaGrupo6.Interfaces;
using TemperaturaGrupo6.Models;

namespace TemperaturaGrupo6.Adapter
{
  public class AdaptadorFahrenheitACelsius : ITemperatura
  {
    private DispositivoFahrenheit dispositivoFahrenheit;

    public AdaptadorFahrenheitACelsius(DispositivoFahrenheit dispositivoFahrenheit)
    {
      this.dispositivoFahrenheit = dispositivoFahrenheit;
    }

    public double ObtenerTemperaturaEnCelsius()
    {
      double temperaturaFahrenheit = dispositivoFahrenheit.ObtenerTemperaturaEnFahrenheit();
      double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
      return temperaturaCelsius;
    }
  }

}
