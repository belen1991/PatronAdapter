namespace TemperaturaGrupo6.Models
{
    public class DispositivoFahrenheit
    {
      private double temperaturaFahrenheit;

      public DispositivoFahrenheit(double temperaturaFahrenheit)
      {
        this.temperaturaFahrenheit = temperaturaFahrenheit;
      }

      public double ObtenerTemperaturaEnFahrenheit()
      {
        return temperaturaFahrenheit;
      }
    }
}
