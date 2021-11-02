using Liga_Cordobesa.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.App.Servicios
{
    interface IService
    {
       bool RegistrarBajaEquipo(int presupuesto);
        List<Equipo> ConsultarEquipo(List<Parametro> criterios);
        List<Persona> ConsultarPersonas();
        bool GrabarEquipo(Equipo oEquipo);

        bool Insertar(Persona oPersona);
        int ObtenerProximoEquipoID();
        Equipo ObtenerEquipoPorID(int nro);

    }

}
