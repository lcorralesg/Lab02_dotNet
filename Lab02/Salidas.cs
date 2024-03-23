using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Salidas
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public double Peso { get; set; }
        public string TipoAuto { get; set; }
        public string NombreTransportista { get; set; }
        public DateTime FechaHora { get; set; }
        public double PesoIngreso { get; set; }
        public double PesoSalida { get; set; }

        public Salidas(string tipoDocumento, string numeroDocumento, double peso, string tipoAuto, string nombreTransportista, DateTime fechaHora, double pesoIngreso, double pesoSalida)
        {
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Peso = peso;
            TipoAuto = tipoAuto;
            NombreTransportista = nombreTransportista;
            FechaHora = fechaHora;
            PesoIngreso = pesoIngreso;
            PesoSalida = pesoSalida;
        }
    }
}
