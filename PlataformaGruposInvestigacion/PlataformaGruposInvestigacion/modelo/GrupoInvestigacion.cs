using System;
namespace PlataformaGruposInvestigacion.modelo
{
    public class GrupoInvestigacion
    {
     //-----------------------------------------------------------------------------------------------------------------
     //Atributos
     //-----------------------------------------------------------------------------------------------------------------
        private String nombre;
        private int codigo;
        private String clasificacion;
        private String ciudad;
        private String areaInvestigacion;
        private String region;

      //-----------------------------------------------------------------------------------------------------------------
      //Constructor
      //-----------------------------------------------------------------------------------------------------------------
        public GrupoInvestigacion(String nombre, int codigo,String clasificacion, String ciudad, String areaInvestigacion, String region){
            this.nombre = nombre;
            this.codigo = codigo; 
            this.clasificacion = clasificacion;
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
        public int Codigo
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
