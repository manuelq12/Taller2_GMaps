﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace PlataformaGruposInvestigacion.interfaz
{
    class Location
    {
        public List<Municipality> MunicipalityList { get; set; }


        public Location()
        {
            MunicipalityList = generarLocaciones();
        }

        public static List<Municipality> generarLocaciones()
        {
            List<Municipality> temporalList = new List<Municipality>();

            try
            {
                StreamReader sr = new StreamReader("../../Docs/ubicacionesMunicipios.txt");

                String line;
                int c = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    String[] atributos = line.Split(';');

                    String nombre = atributos[0];
                    String cooY1 = atributos[1];
                    String cooX1 = atributos[2];
                    String cooY2 = atributos[3];
                    String cooX2 = atributos[4];

                    Municipality mun = new Municipality(nombre, cooY1, cooX1, cooY2, cooX2);
                    //Add element to the municipalityList
                    temporalList.Add(mun);

                    c++;
                }

                //MessageBox.Show(temporalList.Count()+"");

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return temporalList;
        }
    }
}
