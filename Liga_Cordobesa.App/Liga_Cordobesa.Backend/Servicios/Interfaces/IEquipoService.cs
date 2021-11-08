using Liga_Cordobesa.Backend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Servicios
{
    public interface IEquipoService
    {
        bool RegistrarBajaEquipo(int presupuesto);
        List<Equipo> ConsultarEquipo(List<Parametro> criterios);
        bool GrabarEquipo(Equipo oEquipo);
        int ObtenerProximoEquipoID();
        Equipo ObtenerEquipoPorID(int nro);
        List<Posicion> ObtenerPosiciones();
        List<Equipo> ObtenerEquipos();
    }

}
