﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PlataformaGruposInvestigacion.modelo
{
    public class GrupoInvestigacion
    {
     //-----------------------------------------------------------------------------------------------------------------
     //Atributos
     //-----------------------------------------------------------------------------------------------------------------
        private String nombre;
        private String codigo;
        private String clasificacion;
        private List<int> artiFrecuentados;
        private String ciudad;
        private String areaInvestigacion;
        private String region;

       //-----------------------------------------------------------------------------------------------------------------
       //Constructor
       //-----------------------------------------------------------------------------------------------------------------
        public GrupoInvestigacion(String nombre, String codigo ,String clasificacion, List<int> articulos, String ciudad, String areaInvestigacion, String region){
            this.nombre = nombre;
            this.codigo = codigo; 
            this.clasificacion = clasificacion;
            artiFrecuentados = articulos;
            this.ciudad = ciudad;
            this.areaInvestigacion = areaInvestigacion;
            this.region = region;
        }
      //-----------------------------------------------------------------------------------------------------------------
      //Metodos
      //-----------------------------------------------------------------------------------------------------------------
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public String Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public String Clasificacion
        {
            get
            {
                return clasificacion;
            }
            set
            {
                clasificacion = value;
            }
        }
        public List<int> ArtFrecuentados
        {
            get
            {
                return artiFrecuentados;
            }
            set
            {
                artiFrecuentados = value;
            }
        }
        public String Ciudad
        {
            get
            {
                return ciudad;
            }
            set
            {
                ciudad = value;
            }
        }
        public String AreaInvestigacion
        {
            get
            {
                return areaInvestigacion;
            }
            set
            {
                areaInvestigacion = value;
            }
        }
        public String Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }
    }
}
