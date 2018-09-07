﻿using System;
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
        public string ubicaciones { get; set; }
        public string[] ubica { get; set; }
        public List<GrupoInvestigacion> Grupos { get => grupos; set => grupos = value; }

        public Plataforma()
        {
            Grupos = new List<GrupoInvestigacion>();
            ubicaciones = "Aguachica;8,311986;-73,630990;8,304130;-73,598167;" +
                "Agustín Codazzi; 10,043843; -73,243543; 10,026179; -73,228521;" +
                "Apartadó; 7,885056; -76,636537; 7,877149; -76,613276;" +
                "Arauca;6,944435;-71,979233;6,213122;-70,127621;" +
                "Armenia;4,542028;-75,706743;4,523204;-75,666056;" +
                "Barrancabermeja;7.0597246;-73.8865147,13;7,036041;-73,839823;" +
                "Barranquilla;11,008407;-74,839648;10,944706;-74,777496;" +
                "Bello;6,348076;-75,567704;6,323518;-75,539549;" +
                "BogotaD.C.;4,724250;-74,159307;4,512761;-74,013668;" +
                "Boyacá;5,913834;-73,608925;5,323303;-72,500547;" +
                "Bucaramanga;7,136238;-73,155466;7,091780;-73,110140;" +
                "Buenaventura;3.8756596;-77.0932427;3,867772;-76,973752;" +
                "Cajicá;4,926508;-74,028874;4,917614;-74,016857;" +
                "Calarcá;4,541240;-75,620881;4,518480;-75,637147;" +
                "Caldas;5,524827;-75,795981;5,070807;-75,130587;" +
                "Cali;3,462054;-76,560686;3,374999;-76,490630;" +
                "Campoalegre;2,690712;-75,331707;2,677337;-75,322866;" +
                "Carepa;7,762838;-76,660410;7,747232;-76,650054;" +
                "CartagenadeIndias;10,425806;-75,523806;10,387271;-75,465949;" +
                "Cereté;8,895804;-75,801400;8,871551;-75,778482;" +
                "Chía;4,875191;-74,061218;4,842850;-76,060617;" +"Chinchiná;4,996623;-75,719982;4,957290;-75,642042;" +"Chiquinquirá;5,623060;-73,822575;5,611443;-73,810387;" +"Ciénega;11,015191;-74,257231;11,000886;-74,234775;" +               "Ciénegadeoro;8,879046;-75,628113;8,870947;-75,616740;" +               "Copacabana;6,359838;-75,516065;6,348235;-75,490315;" +               "Cota;4,812184;-74,106615;4,804230;-74,098590;" +               "Cúcuta;7,922356;-72,536352;7,874739;-72,482109;" +               "Distracción;10,899559;-72,889754;10,896840;-72,885355;" +               "Dosquebradas;4,835557;-75,693342;4,821358;-75,671884;" +               "Duitama;5,838798;-73,042657;5,815742;-73,205120;" +               "Envigado;6,176466;-75,594118;6,152742;-75,570085;" +               "Espinal;4,191900;-74,943057;4,104895;-74,820807;" +               "Facatativá;4,821026;-74,362837;4,806571;-74,344726;" +               "Florencia;1,623544;-75,625901;1,607071;-75,600151;Floridablanca;7,085681;-73,109306;7,059019;-73,083643;Fonseca;10,857806;-72,834514;10,734298;-72,715065;Fusagasugá;4,350087;-74,376249;4,327063;-74,358824;Garzón;2,199091;-75,644205;2,191543;-75,620773;Girardot;4,319012;-74,806385;4,308569;-74,771793;Girón;7,082328;-73,177357;7,065463;-73,162937;GuadalajaradeBuga;3,912286;-76,311922;3,879402;-76,297846;Guarne;6,281396;-75,447659;6,276191;-75,437445;Itagüí;6,175250;-75,634530;6,162193;-75,609295;Jamundí;3,264100;-76,547732;3,250903;-76,532883;LaEstrella;6,163923;-75,649037;6,152657;-75,635304;LaPintada;5,748157;-75,607523;5,746641;-75,606192;LaPlata;2,395333;-75,894833;2,387486;-75,886593;Leticia;-4,208732;-69,948539;-4,219475;-69,935922;Lorica;9,245343;-75,823824;9,232085;-75,809533;Madrid;4,739400;-74,288163;4,727701;-74,246233;Maicao;11,385599;-72,255327;11,369526;-72,226660;Manizales;5,072116;-75,525529;5,053990;-75,476090;Manta;4,995089;-73,592424;4,930099;-73,547451;Medellín;6,283105;-75,615200;6,225755;-75,539664;Mitú;1,264116;-70,237315;1,251845;-70,229419;Montería;8,761055;-75,897764;8,730004;-75,870299;Mosquera;4,714995;-74,235194;4,705542;-74,217684;Neiva;2,949959;-75,297966;2,910355;-75,257110;Nilo;4,307895;-74,621480;4,305071;-74,617854;Nobsa;5,774765;-72,942386;5,770453;-72,936636;Ocaña;8,248438;-73,362405;8,233147;-73,350217;Paipa;5,784339;-73,128715;5,778746;-73,110948;Palmira;3,544006;-76,317055;3,514020;-76,281349;Pamplona;7,381938;-72,653641;7,369936;-72,641882;Pasto;1,230859;-77,295248;1,202197;-77,2641;Pereira;48,146070;-75,743719;4,796817;-75,684324;Piedecuesta;6,999805;-73,057732;6,987261;-73,049621;Pitalito;1,864432;-76,058610;1,841399;-76,040929;Popayán;2,461756;-76,632552;24,414330;-76,597877;PuertoColombia;10,989524;-74,959132;10,984405;-74,949412;Quibdó;5,698067;-76,661472;5,679064;-76,648984;Riohacha;11,542008;-72,930536;11,531201;-72,899422;Rionegro;6,152261;-75,391522;6,146287;-75,357447;Sabaneta;6,153246;-75,626519;6,148574;-75,609589;SanAndrés;12,557380;-81,728116;12,510963;-81,714039;SanGil;6,560274;-73,149340;6,555243;-73,126809;SanJosédelGuaviare;2,573422;-72,645524;2,561354;-72,632435;SanJuandelCesar;10,774858;-73,011534;10,766110;-72,999024;SanLuis;12,529221;-81,712026;12,526792;-81,709011;SantaMarta;11,253832;-74,214413;11,223357;-74,177505;SantaRosadeCabal;4,882301;-75,632324;4,867677;-75,624599;SantaRosadeOsos;6,650963;-75,468808;6,636214;-75,456234;SantaRosadeViterbo;5,879460;-72,983732;5,872822;-72,978947;Sincelejo;9,313280;-75,411481;9,291597;-75,381698;Socorro;6,486331;-73,289984;6,428677;-73,212736;Sogamoso;5,729594;-72,940524;5,707475;-72,925074;Soledad;10,920126;-74,798280;10,886076;-74,774763;Sopó;4,913222;-73,945749;4,904628;-73,940084;Tuluá;4,096073;-76,206753;4,085457;-76,188514;Tunja;5,547494;-73,369803;5,524086;-73,353152;Turbaco;10,335384;-75,422154;10,328080;-75,408936;Turbo;80,964170;-76,738964;8,092933;-76,728407;Valledupar0,474644;-73,272537;10,453036;-73,240780;Vélez;6,010462;-73,675984;6,006707;-73,669225;VilladeSanDiegodeUbaté;5,312024;-73,819145;5,304973;-73,808459;VilladelRosario;7,846040;-72,476368;7,832477;-72,466197;Villavicencio;4,145557;-73,654467;4;-73,582026;Villeta;5,013805;-74,477588;5,005896;-74,469219;Yopal;5,347921;-72,407652;5,322796;-72,386452;Zipaquirá;5,030880;74,005629;5;-73,984171;ZonaBananera;10,852811;-74,246241;10,748941;-74,126078;Ibague;4,448140;-75,244630;4,423663;-75,162227;";
            ubica = ubicaciones.Split(';');
            cargarGruposInvestigacion();
            cargarArticulos();
        }

        public void AgregarGrupo(String nombre, String codigo, String clasificacion, String articulos, String ciudad, String area, String region,
            double y1, double x1, double y2, double x2)
        {
           String [] listado = { nombre, codigo, clasificacion, ciudad, area, region };
           
            var lista = articulos.Split(' ').Select(i => Int32.Parse(i));
            List<int> art = new List<int>();
            List<int> listaNueva = art.Concat(lista).ToList<int>();
            GrupoInvestigacion nuevo = new GrupoInvestigacion(nombre, codigo, clasificacion, listaNueva , ciudad, area, region,y1,x1,y2,x2);
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
                    int index = ubica.ToList().FindIndex(a => a.Equals(ciudad));
                    double y1 = 0;
                    double x1 = 0;
                    double y2 = 0;
                    double x2 = 0;
                   if ( index < ubica.Count()&& index != -1)
                    {
                        
                        try
                        {
                            if (ubica[index + 1] != null) {
                            y1 = double.Parse(ubica[index + 1]);
                            }
                            if (ubica[index + 2] != null) {
                            x1 = double.Parse(ubica[index + 2]);
                            }
                            if (ubica[index + 3] != null) {
                            y2 = double.Parse(ubica[index + 3]);
                            }
                            if (ubica[index + 4] != null)
                            {
                            x2 = double.Parse(ubica[index + 4]);
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                    AgregarGrupo(nombre, codigo, clasi, "-1 -1", ciudad, area, region,y1,x1,y2,x2);
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
