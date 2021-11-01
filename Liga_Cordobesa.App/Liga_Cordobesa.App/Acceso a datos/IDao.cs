using Liga_Cordobesa.App.Dominio;
using Liga_Cordobesa.App.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Cordobesa.App.Acceso_a_datos
{
    interface IDao
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
