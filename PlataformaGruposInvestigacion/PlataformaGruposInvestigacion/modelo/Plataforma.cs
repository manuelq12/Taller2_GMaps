using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PlataformaGruposInvestigacion.modelo
{
    public class Plataforma
    {
        public const String rutaGrupos = "../../Resources/Grupos_de_Investigaci_n_Colombia_2017.csv";
        public const String rutaArticulos = "../../Resources/TransaccionesGruposArticulos.csv";
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
        public void cargarGruposInvestigacion()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(rutaGrupos);
                while ((line = sr.ReadLine()) != null)
                {
                    String[] todo = line.Split(',');
                    String nombre="";
                    String codigo = todo[2];
                    String clasi = "";
                    String ciudad = "";
                    String area = "";
                    String region = "";
                    int contador = 3;
                    if (todo[contador].StartsWith("\""))
                    {
                        while (!todo[contador].EndsWith("\""))
                        {
                            nombre += todo[contador];
                            contador++;
                        }
                    }
                    else
                    {
                        nombre = todo[contador];
                        contador++;
                    }
                    if (todo[contador + 1].StartsWith("\""))
                    {
                        ciudad = "Bogotá, D. C.";
                        region = "Bogotá, D. C.";
                        contador += 2;
                    }
                    else
                    {
                        ciudad = todo[contador + 1];
                        region = todo[contador + 2];
                    }
                    contador += 6;
                    if(contador>= todo.Length)
                    {
                        clasi = "No especificada";
                        area = "No especificada";
                    }
                    else
                    {
                        clasi = todo[contador];
                        if(contador + 1>= todo.Length) area = "No especificada";
                        else area = todo[contador+1];
                    }
                    AgregarGrupo(nombre, codigo, clasi, "No especificados", ciudad, area, region);
                }
                sr.Close();
            }
            catch
            {
                throw new Exception("Error al cargar los datos");
            }
        }


        public void cargarArticulos()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(rutaArticulos);
                while ((line = sr.ReadLine()) != null)
                {
                    String[] todo = line.Split(':');
                    List<int> arti = new List<int>();
                    String[] articulos = todo[2].Split(' ');
                    articulos.ToList().ForEach(i => arti.Add(Convert.ToInt32(i)));
                    BuscarGrupo(todo[1]).ArtFrecuentados = arti;
                }
                sr.Close();
            }
            catch
            {
                throw new Exception("Error al cargar los articulos");
            }

        }
        
    }
}
