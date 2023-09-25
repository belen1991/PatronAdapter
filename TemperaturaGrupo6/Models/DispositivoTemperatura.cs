using TemperaturaGrupo6.Enums;

namespace TemperaturaGrupo6.Models
{
    public class DispositivoTemperatura
    {
      public DispositivosTemperaturaEnum tipo { get; set; }
      public string NombreDispositivo { get; set; }
      public double Temperatura { get; set; }
      public double TemperaturaCelsius { get; set; }
    }
}
