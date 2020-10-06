using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SoftwareMVC5.Models
{
    public enum ResultadoOperacion
    {
        Aprobado =1,
        Rechazado=2,
        Pendiente=7,
        [Description("Pendiente Aprobacion")]
        PendienteAprobacion=9
    }
}