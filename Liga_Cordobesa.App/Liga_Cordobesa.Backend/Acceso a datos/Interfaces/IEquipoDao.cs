using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.Backend.Acceso_a_datos
{
    public interface IEquipoDao
    {
        List<Persona> TraerPersonas();
        List<Equipo> ConsultarEquipo(List<Parametro> criterios);
        bool Insertar(Persona oPersona);
        List<Posicion> TraerPosicion();
        bool Guardar(Equipo oEquipo);
        int TraerNroEquipo();
        Equipo EquipoPorId(int id);
        bool Delete(int nro);
    }
}
