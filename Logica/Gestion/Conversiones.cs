using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVirtual.Logica.Gestion
{
    using System;

    public class Conversiones
    {
        public static (int Año, DateOnly DiaInicial, DateOnly DiaFinal, int Turno) ObtenerPeriodo(int TurnoId)
        {
            string turnoIdStr = TurnoId.ToString();

            // Obtener el año (los dos primeros dígitos)
            int año = 2000 + int.Parse(turnoIdStr.Substring(0, 2));

            // Obtener el día inicial (siguientes tres dígitos)
            int diaInicial = int.Parse(turnoIdStr.Substring(2, 3));

            // Obtener el día final (siguientes tres dígitos)
            int diaFinal = int.Parse(turnoIdStr.Substring(5, 3));

            // Obtener el turno (último dígito)
            int turno = int.Parse(turnoIdStr.Substring(8, 1));

            DateOnly fechaInicial = new DateOnly(año, 1, 1).AddDays(diaInicial - 1);
            DateOnly fechaFinal = new DateOnly(año, 1, 1).AddDays(diaFinal - 1);

            return (año, fechaInicial, fechaFinal, turno);
        }

        public static int ObtenerTurnoId(int Año, DateOnly DiaInicial, DateOnly DiaFinal, int Turno)
        {
            // Obtener los dos últimos dígitos del año
            int año = Año % 100;

            // Calcular el día del año para DiaInicial y DiaFinal
            int diaInicial = DiaInicial.DayOfYear;
            int diaFinal = DiaFinal.DayOfYear;

            // Construir el TurnoId como una cadena de texto
            string turnoIdStr = año.ToString("D2") + diaInicial.ToString("D3") + diaFinal.ToString("D3") + Turno.ToString("D1");

            // Convertir la cadena de texto a un número entero y devolverlo
            return int.Parse(turnoIdStr);
        }
    }
}



