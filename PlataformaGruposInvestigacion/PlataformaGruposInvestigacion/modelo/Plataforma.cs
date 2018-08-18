using System;
using System.Collections.Generic;
using System.Linq;

namespace PlataformaGruposInvestigacion.modelo
{
    public class Plataforma
    {
       private List<GrupoInvestigacion> grupos;
        private List<int> articulos;

        public Plataforma()
        {
            grupos = new List<GrupoInvestigacion>();
            
        }

        public void AgregarGrupo(String nombre, String codigo, String clasificacion, String articulos, String ciudad, String area, String region)
        {
           String [] listado = { nombre, codigo, clasificacion, ciudad, area, region };
            if (listado.Any(i => i.Equals(""))) {
                throw new Exception("Debe incluir todos los parametros");
            }
            else
            {
                var lista = articulos.Split(' ').Select(i => Int32.Parse(i));
                List<int> art = new List<int>();
                art.Union(lista);
                GrupoInvestigacion nuevo = new GrupoInvestigacion(nombre, codigo, clasificacion, art , ciudad, area, region);
                grupos.Add(nuevo);
            }
        }
        public GrupoInvestigacion BuscarGrupo(String codigo)
        {
            GrupoInvestigacion nuevo = grupos.Find(i => i.Codigo.Equals(codigo));
            return nuevo;
        }
        
    }
}
