using TemperaturaGrupo6.Interfaces;

namespace TemperaturaGrupo6.Models
{
    public class DispositivoCelsius : ITemperatura
    {
      private double temperaturaCelsius;

      public DispositivoCelsius(double temperaturaCelsius)
      {
        this.temperaturaCelsius = temperaturaCelsius;
      }

      public double ObtenerTemperaturaEnCelsius()
      {
        return temperaturaCelsius;
      }
    }
}
