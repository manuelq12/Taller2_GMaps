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

        public List<GrupoInvestigacion> Grupos { get => grupos; set => grupos = value; }

        public Plataforma()
        {
            Grupos = new List<GrupoInvestigacion>();
            cargarGruposInvestigacion();
            cargarArticulos();
        }

        public void AgregarGrupo(String nombre, String codigo, String clasificacion, String articulos, String ciudad, String area, String region)
        {
           String [] listado = { nombre, codigo, clasificacion, ciudad, area, region };
           
            var lista = articulos.Split(' ').Select(i => Int32.Parse(i));
            List<int> art = new List<int>();
            List<int> listaNueva = art.Concat(lista).ToList<int>();
            GrupoInvestigacion nuevo = new GrupoInvestigacion(nombre, codigo, clasificacion, listaNueva , ciudad, area, region);
                Grupos.Add(nuevo);
            
            
        }
        public void ActualizarGrupo(GrupoInvestigacion a)
        {
                for (int i = 0; i < grupos.Count; i++)
                {
                    if (a.Codigo.Equals(grupos[i])) grupos[i] = a;
                }
        }
        public GrupoInvestigacion BuscarGrupo(String codigo)
        {
            GrupoInvestigacion nuevo = null;
            nuevo = Grupos.Find(i => i.Codigo.Equals(codigo));
            return nuevo;
        }
        public void cargarGruposInvestigacion()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(rutaGrupos);
                line = sr.ReadLine();
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
                    if (ciudad.Contains("/")) ciudad = "Colombia";
                    AgregarGrupo(nombre, codigo, clasi, "-1 -1", ciudad, area, region);
                }
                sr.Close();
            }
            catch(Exception E)
            {
                throw new Exception(E.Message);
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
                    articulos.ToList().ForEach(i => arti.Add(i.Equals("")? -1: Convert.ToInt32(i)));
                    BuscarGrupo(todo[1]).ArtFrecuentados = arti;
                }
                sr.Close();
            }
            catch(Exception E)
            {
                throw new Exception(E.Message);
            }

        }
        
    }
}
