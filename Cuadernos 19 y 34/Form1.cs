using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;

namespace Cuadernos_Alvores
{
   
    public struct DeudorPresentador
    {
        private string nif;
        private string nombre;
        private string iban;
        private string fecha;
        private string codigo;
        private string totalimporte;

        public string   TOTALIMPORTE
        {
            get
            {
                return totalimporte;
            }

            set
            {
                totalimporte = value;
            }
        }

        public string CODIGO
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

        public string NIF
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }
        public string FECHA
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }
        public string NOMBRE
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

        public string IBAN
        {
            get
            {
                return iban;
            }

            set
            {
                iban = value;
            }
        }
    }
    public struct OrdenEmpresa
    {
        private string FechaEmision;
        private string nif;
        private string nombre;
        private string calle;
        private string cpLocalidad;
        private string iban;
        private string CodBanc;
        private string CodOfic;
        private string CuentaCorriente;
        private string CodControl;
        private string CodSecuencia;
        private string ImporteTotal;

        public string IMPORTETOAL
        {
            get
            {
                return ImporteTotal;
            }

            set
            {
                ImporteTotal = value;
            }
        }

        public string CODIGOSECUENCIA
        {
            get
            {
                return CodSecuencia;
            }

            set
            {
                CodSecuencia = value;
            }
        }
        public string FECHAEMISION
        {
            get
            {
                return FechaEmision;
            }

            set
            {
                FechaEmision = value;
            }
        }
        public string NIF
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }

        public string NOMBRE
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
        public string CALLE
        {
            get
            {
                return calle;
            }

            set
            {
                calle = value;
            }
        }
        public string CPLOCALIDAD
        {
            get
            {
                return cpLocalidad;
            }

            set
            {
                cpLocalidad = value;
            }
        }
        public string CODBANC
        {
            get
            {
                return CodBanc;
            }

            set
            {
                CodBanc = value;
            }
        }
        public string CODOFICINA
        {
            get
            {
                return CodOfic;
            }

            set
            {
                CodOfic = value;
            }
        }
        public string CUENTACORRIENTE
        {
            get
            {
                return CuentaCorriente;
            }

            set
            {
                CuentaCorriente = value;
            }
        }

        public string CODIGOCONTROL
        {
            get
            {
                return CodControl;
            }

            set
            {
                CodControl = value;
            }
        }
        public string IBAN
        {
            get
            {
                return iban;
            }

            set
            {
                iban = value;
            }
        }
    
    }
    public struct OrdenClientePago
    {
        private string nif;
        private string nombre;
        private string calle;
        private string cpLocalidad;
        private string iban;
        private string CodBanc;
        private string CodOfic;
        private string CuentaCorriente;
        private string CodControl;
        private string factura;
        private string descripcion_factura;

        public string DESCRPCION_FACTURA
        {
            get
            {
                return descripcion_factura;
            }

            set
            {
                descripcion_factura = value;
            }
        }
        
        public string FACTURA
        {
            get
            {
                return factura;
            }

            set
            {
                factura = value;
            }
        }
        public string NIF
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }

        public string NOMBRE
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
        public string CALLE
        {
            get
            {
                return calle;
            }

            set
            {
                calle = value;
            }
        }
        public string CPLOCALIDAD
        {
            get
            {
                return cpLocalidad;
            }

            set
            {
                cpLocalidad = value;
            }
        }
        public string CODBANC
        {
            get
            {
                return CodBanc;
            }

            set
            {
                CodBanc = value;
            }
        }
        public string CODOFICINA
        {
            get
            {
                return CodOfic;
            }

            set
            {
                CodOfic = value;
            }
        }
        public string CUENTACORRIENTE
        {
            get
            {
                return CuentaCorriente;
            }

            set
            {
                CuentaCorriente = value;
            }
        }

        public string CODIGOCONTROL
        {
            get
            {
                return CodControl;
            }

            set
            {
                CodControl = value;
            }
        }
       
       
        public string IBAN
        {
            get
            {
                return iban;
            }

            set
            {
                iban = value;
            }
        }

    }
    public struct  Adeudo
    {

        private string nif;
        private string nombre;
        private string iban;
        private string factura;
        private string importe;
        public string NIF
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }
        public string FACTURA
        {
            get
            {
                return factura;
            }

            set
            {
                factura = value;
            }
        }
        public string NOMBRE
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

        public string IBAN
        {
            get
            {
                return iban;
            }

            set
            {
                iban = value;
            }
        }

        public string IMPORTE
        {
            get
            {
                return importe;
            }

            set
            {
                importe= value;
            }
        }
    
    }
    public partial class Form1 : Form
    {

        ArrayList AdeudoIndividual = new ArrayList();
        ArrayList OrdenIndividual = new ArrayList();

        DeudorPresentador dp;
        OrdenEmpresa oe;
        OrdenClientePago ocp;
        Adeudo add;
       string[] BIC;
       

        public Form1()
        {
            InitializeComponent();
        }
        public void obtener_C1914()
        {
            OpenFileDialog ofd19 = new OpenFileDialog();

            ofd19.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd19.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd19.FilterIndex = 2;
            ofd19.RestoreDirectory = true;
            
            if (ofd19.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    dp = new DeudorPresentador();
                    string file;
                    file = ofd19.FileName;
                    string[] readText = File.ReadAllLines(file, Encoding.ASCII);

                    char[] stchar;
                    bool yaheentrado = true;
                    foreach (string s in readText)
                    {
                        string st;
                        if (yaheentrado)
                        {
                            add = new Adeudo();
                            yaheentrado = false;
                        }
                        
                        stchar = s.ToCharArray();
                        st = Convert.ToString(stchar[0]) + Convert.ToString(stchar[1]);
                        if (st == "51")
                        {

                            dp.NIF = Convert.ToString(stchar[4]) + Convert.ToString(stchar[5]) + Convert.ToString(stchar[6]) + Convert.ToString(stchar[7]) + Convert.ToString(stchar[8]) + Convert.ToString(stchar[9]) + Convert.ToString(stchar[10]) + Convert.ToString(stchar[11]) + Convert.ToString(stchar[12]);
                            dp.FECHA = Convert.ToString(stchar[16]) + Convert.ToString(stchar[17]) + Convert.ToString(stchar[18]) + Convert.ToString(stchar[19]) + Convert.ToString(stchar[20]) + Convert.ToString(stchar[21]);
                            dp.CODIGO = Convert.ToString(stchar[13]) + Convert.ToString(stchar[14]) + Convert.ToString(stchar[15]);
                            for (int i = 28; i <= 67; i++)
                            {
                                dp.NOMBRE = dp.NOMBRE + Convert.ToString(stchar[i]);
                            }

                        }
                        if (st == "53")
                        {
                            string ccc;
                            ccc = null;
                            for (int i = 68; i <= 87; i++)
                            {
                                ccc = ccc + Convert.ToString(stchar[i]);
                            }

                            dp.IBAN = calculo_IBAN(ccc);

                        }

                        if (st == "56")
                        {
                            
                            for (int i = 16; i <= 24; i++)
                            {
                                add.NIF = add.NIF + Convert.ToString(stchar[i]);
                            }
                            for (int i = 28; i <= 67; i++)
                            {
                                add.NOMBRE = add.NOMBRE + Convert.ToString(stchar[i]);
                            }
                            string ccc;
                            ccc = null;
                            for (int i = 68; i <= 87; i++)
                            {
                                ccc = ccc + Convert.ToString(stchar[i]);
                            }
                            add.IBAN = calculo_IBAN(ccc);
                            for (int i = 88; i <= 97; i++)
                            {
                                add.IMPORTE = add.IMPORTE + Convert.ToString(stchar[i]);
                            }

                            for (int i = 114; i <= 161; i++)
                            {
                                add.FACTURA = add.FACTURA + Convert.ToString(stchar[i]);
                            }
                            AdeudoIndividual.Add(add);
                            yaheentrado = true;
                            

                        }

                        if (st == "58")
                        {

                            for (int i = 88; i <= 97; i++)
                            {
                                dp.TOTALIMPORTE = dp.TOTALIMPORTE + Convert.ToString(stchar[i]);
                            }

                        }

                    }
                    string referencia;
                    referencia = txtRef19.Text;

                    if (referencia.Count() < 14)
                    {

                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter objWriter;
                            string[] file_txt;
                            file_txt = saveFileDialog1.FileName.Split(new Char[] { '.' });
                            objWriter = new StreamWriter(file_txt[0] + ".txt");
                            string linea, ia;
                            int diferencia;

                            linea = "0119143001";
                            ia = identificador_Acreedor(dp.NIF);
                            diferencia = 45 - 10 - ia.Count();
                            linea = linea + ia;
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + " ";
                            }

                            diferencia = 115 - 45 - dp.NOMBRE.Count();
                            linea = linea + dp.NOMBRE;
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + " ";
                            }

                            string ano, mes, dia;
                            int intdia, intmes;

                            ano = DateTime.Now.Year.ToString();
                            intmes = DateTime.Now.Month;
                            intdia = DateTime.Now.Day;
                            if (intdia < 10)
                            {
                                dia = "0" + intdia.ToString();
                            }
                            else
                            {
                                dia = intdia.ToString();
                            }
                            if (intmes < 10)
                            {
                                mes = "0" + intmes.ToString();
                            }
                            else
                            {
                                mes = intmes.ToString();
                            }

                            linea = linea + ano + mes + dia;
                            linea = linea + "PRE" + ano + mes + dia;
                            string hora, minuto, segundo, milisegundo;
                            int inthora, intminuto, intsegundo, intmilisegundo;
                            inthora = DateTime.Now.Hour;
                            intminuto = DateTime.Now.Minute;
                            intsegundo = DateTime.Now.Second;
                            intmilisegundo = DateTime.Now.Millisecond;
                            if (inthora < 10)
                            {
                                hora = "0" + inthora.ToString();
                            }
                            else
                            {
                                hora = inthora.ToString();
                            }
                            if (intminuto < 10)
                            {
                                minuto = "0" + intminuto.ToString();
                            }
                            else
                            {
                                minuto = intminuto.ToString();
                            }
                            if (intsegundo < 10)
                            {
                                segundo = "0" + intsegundo.ToString();
                            }
                            else
                            {
                                segundo = intsegundo.ToString();
                            }
                            milisegundo = intmilisegundo.ToString();


                            for (int i = 0; i <= 5 - milisegundo.Count(); i++)
                            {
                                milisegundo = "0" + milisegundo;
                            }
                            linea = linea + hora + minuto + segundo + milisegundo;

                            stchar = referencia.ToCharArray();
                            for (int i = 0; i <= 12 - stchar.Count(); i++)
                            {
                                referencia = " " + referencia;
                            }

                            linea = linea + referencia;
                            stchar = dp.IBAN.ToCharArray(4, 11);
                            for (int i = 0; i <= 7; i++)
                            {
                                linea = linea + Convert.ToString(stchar[i]);
                            }

                            for (int i = 0; i <= 433; i++)
                            {
                                linea = linea + " ";
                            }

                            objWriter.WriteLine(linea);

                            linea = null;


                            linea = "0219143002";
                            ia = identificador_Acreedor(dp.NIF);
                            diferencia = 45 - 10 - ia.Count();
                            linea = linea + ia;
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + " ";
                            }
                            linea = linea + ano + mes + dia;
                            diferencia = 123 - 53 - dp.NOMBRE.Count();
                            linea = linea + dp.NOMBRE;
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + " ";
                            }

                            for (int i = 0; i <= 49; i++)
                            {
                                linea = linea + " ";
                            }
                            for (int i = 0; i <= 49; i++)
                            {
                                linea = linea + " ";
                            }
                            for (int i = 0; i <= 39; i++)
                            {
                                linea = linea + " ";
                            }

                            linea = linea + "ES" + dp.IBAN;
                            diferencia = 299 - 264 - dp.IBAN.Count() - 2;
                            for (int i = 0; i <= 300 + diferencia; i++)
                            {
                                linea = linea + " ";
                            }
                            objWriter.WriteLine(linea);

                            int N_Adeudos = 0;
                            string stN_Adeudos = null;
                            foreach (Adeudo ad in AdeudoIndividual)
                            {
                                linea = null;
                                linea = "0319143003";
                                string factura;
                                factura = ad.FACTURA.Trim();

                                diferencia = 35 - factura.Count();
                                linea = linea + factura;
                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + " ";
                                }

                                diferencia = 35 - ad.NIF.Count();
                                linea = linea + ad.NIF;
                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + " ";
                                }
                                linea = linea + "RCUR";
                                for (int i = 1; i <= 4; i++)
                                {
                                    linea = linea + " ";
                                }
                                diferencia = 11 - ad.IMPORTE.Count();

                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + "0";
                                }
                                linea = linea + ad.IMPORTE;
                                linea = linea + "20091031";
                                linea = linea + obtener_BIC(ad.IBAN);
                               
                                diferencia = 11 - obtener_BIC(ad.IBAN).Count();

                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + " ";
                                }
                                linea = linea + ad.NOMBRE;
                                diferencia = 70 - ad.NOMBRE.Count();

                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + " ";
                                }

                                for (int i = 1; i <= 142; i++)
                                {
                                    linea = linea + " ";
                                }
                                if (validateCif(ad.NIF))
                                {

                                    linea = linea + "1";
                                }
                                else
                                {
                                    linea = linea + "2";
                                }

                                for (int i = 1; i <= 36; i++)
                                {
                                    linea = linea + " ";
                                }
                                for (int i = 1; i <= 35; i++)
                                {
                                    linea = linea + " ";
                                }
                                linea = linea + "A";
                                linea = linea + ad.IBAN;
                                diferencia = 34 - ad.IBAN.Count();

                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + " ";
                                }
                                for (int i = 1; i <= 163; i++)
                                {
                                    linea = linea + " ";
                                }

                                objWriter.WriteLine(linea);
                                N_Adeudos = N_Adeudos + 1;
                            }

                            linea = null;
                            linea = "04";
                            ia = identificador_Acreedor(dp.NIF);
                            diferencia = 35 - ia.Count();
                            linea = linea + ia;
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + " ";
                            }


                            ano = DateTime.Now.Year.ToString();
                            intmes = DateTime.Now.Month;
                            intdia = DateTime.Now.Day;
                            if (intdia < 10)
                            {
                                dia = "0" + intdia.ToString();
                            }
                            else
                            {
                                dia = intdia.ToString();
                            }
                            if (intmes < 10)
                            {
                                mes = "0" + intmes.ToString();
                            }
                            else
                            {
                                mes = intmes.ToString();
                            }

                            linea = linea + ano + mes + dia;
                            diferencia = 17 - dp.TOTALIMPORTE.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }
                            linea = linea + dp.TOTALIMPORTE;

                            stN_Adeudos = N_Adeudos.ToString();
                            diferencia = 8 - stN_Adeudos.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }
                            linea = linea + stN_Adeudos;
                            N_Adeudos = N_Adeudos + 2;
                            stN_Adeudos = N_Adeudos.ToString();


                            diferencia = 10 - stN_Adeudos.Count();
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }

                            linea = linea + stN_Adeudos;

                            for (int i = 1; i <= 520; i++)
                            {
                                linea = linea + " ";
                            }

                            objWriter.WriteLine(linea);



                            linea = null;
                            linea = "05";
                            ia = identificador_Acreedor(dp.NIF);
                            diferencia = 35 - ia.Count();
                            linea = linea + ia;
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + " ";
                            }
                            diferencia = 17 - dp.TOTALIMPORTE.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }
                            linea = linea + dp.TOTALIMPORTE;
                            N_Adeudos = N_Adeudos - 2;
                            stN_Adeudos = N_Adeudos.ToString();
                            diferencia = 8 - stN_Adeudos.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }

                            linea = linea + stN_Adeudos;
                            N_Adeudos = N_Adeudos + 3;
                            stN_Adeudos = N_Adeudos.ToString();
                            diferencia = 10 - stN_Adeudos.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }

                            linea = linea + stN_Adeudos;

                            for (int i = 1; i <= 528; i++)
                            {
                                linea = linea + " ";
                            }

                            objWriter.WriteLine(linea);
                            linea = null;
                            linea = "99";
                            diferencia = 17 - dp.TOTALIMPORTE.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }
                            linea = linea + dp.TOTALIMPORTE;
                            N_Adeudos = N_Adeudos - 3;
                            string s = Convert.ToString(N_Adeudos);
                            diferencia = 8 - s.Count();
                            
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }

                            linea = linea + N_Adeudos;
                            N_Adeudos = N_Adeudos + 5;
                            stN_Adeudos = N_Adeudos.ToString();

                            diferencia = 10 - stN_Adeudos.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }

                            linea = linea + stN_Adeudos;


                            for (int i = 1; i <= 563; i++)
                            {
                                linea = linea + " ";
                            }

                            objWriter.WriteLine(linea);
                            objWriter.Close();


                        }
                    }

                    AdeudoIndividual.Clear();
                    OrdenIndividual.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se puede leer del archivo. Código error: " + ex.Message);
                }
            }
        
        }
        public void obtener_C3414()
        {
            OpenFileDialog ofd19 = new OpenFileDialog();

            ofd19.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd19.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd19.FilterIndex = 2;
            ofd19.RestoreDirectory = true;
            bool nominas = false;
            
            if (ofd19.ShowDialog() == DialogResult.OK)
            {
               try
                {
                    oe = new OrdenEmpresa();
                    string file;
                    file = ofd19.FileName;
                    string[] readText = File.ReadAllLines(file, Encoding.ASCII);
                    bool CompletoDatos = false;

                    char[] stchar;
                    bool yaheentrado = true;
                    foreach (string s in readText)
                    {
                        string st,codlinea1,codlinea;
                        
                        stchar = s.ToCharArray();
                        st = Convert.ToString(stchar[0]) + Convert.ToString(stchar[1]) + Convert.ToString(stchar[2]) + Convert.ToString(stchar[3]);
                        codlinea1 = Convert.ToString(stchar[28]) + Convert.ToString(stchar[29]) + Convert.ToString(stchar[30]);
                        codlinea = Convert.ToString(stchar[26]) + Convert.ToString(stchar[27]) + Convert.ToString(stchar[28]); 
                        if (st == "0356" && codlinea =="001")
                        {
                            oe.CODIGOSECUENCIA = st;

                           
                            for (int i = 4; i <= 12; i++)
                            {
                                oe.NIF = oe.NIF + Convert.ToString(stchar[i]);                               
                            }

                             for (int i = 35; i <= 40; i++)
                            {
                                oe.FECHAEMISION = oe.FECHAEMISION + Convert.ToString(stchar[i]);                               
                            }


                             for (int i = 41; i <= 44; i++)
                             {
                                 oe.CODBANC = oe.CODBANC + Convert.ToString(stchar[i]);
                             }
                             for (int i = 45; i <= 48; i++)
                             {
                                 oe.CODOFICINA = oe.CODOFICINA + Convert.ToString(stchar[i]);
                             }
                             for (int i = 50; i <= 59; i++)
                             {
                                 oe.CUENTACORRIENTE = oe.CUENTACORRIENTE + Convert.ToString(stchar[i]);
                             }
                             for (int i = 63; i <= 64; i++)
                             {
                                 oe.CODIGOCONTROL = oe.CODIGOCONTROL + Convert.ToString(stchar[i]);
                             }

                        }
                        else
                        {
                            if (codlinea1 == "001")
                            {

                                oe.CODIGOSECUENCIA = st;


                                for (int i = 4; i <= 12; i++)
                                {
                                    oe.NIF = oe.NIF + Convert.ToString(stchar[i]);
                                }

                                for (int i = 37; i <= 42; i++)
                                {
                                    oe.FECHAEMISION = oe.FECHAEMISION + Convert.ToString(stchar[i]);
                                }


                                for (int i = 43; i <= 46; i++)
                                {
                                    oe.CODBANC = oe.CODBANC + Convert.ToString(stchar[i]);
                                }
                                for (int i = 47; i <= 50; i++)
                                {
                                    oe.CODOFICINA = oe.CODOFICINA + Convert.ToString(stchar[i]);
                                }
                                for (int i = 53; i <= 63; i++)
                                {
                                    oe.CUENTACORRIENTE = oe.CUENTACORRIENTE + Convert.ToString(stchar[i]);
                                }
                                for (int i = 51; i <= 52; i++)
                                {
                                    oe.CODIGOCONTROL = oe.CODIGOCONTROL + Convert.ToString(stchar[i]);
                                }
                            }
                            
                        }

                        if (st == "0356" && codlinea == "002")
                        {
                            for (int i = 29; i <= 64; i++)
                            {
                                oe.NOMBRE = oe.NOMBRE + Convert.ToString(stchar[i]);
                            }
                        }
                        else
                        {
                            if (codlinea1 == "002")
                            {
                                for (int i = 31; i <= 66; i++)
                                {
                                    oe.NOMBRE = oe.NOMBRE + Convert.ToString(stchar[i]);
                                }


                            }
                        }

                        if (st == "0356" && codlinea == "003")
                        {
                            for (int i = 29; i <= 64; i++)
                            {
                                oe.CALLE = oe.CALLE + Convert.ToString(stchar[i]);
                            }
                        }
                        else
                        {
                            if (codlinea1 == "003")
                            {
                             for (int i = 31; i <= 66; i++)
                             {
                                oe.CALLE = oe.CALLE + Convert.ToString(stchar[i]);
                             }
                            }
                        }
                        if (st == "0356" && codlinea == "004")
                        {
                            for (int i = 29; i <= 64; i++)
                            {
                                oe.CPLOCALIDAD = oe.CPLOCALIDAD+ Convert.ToString(stchar[i]);
                            }
                        }
                        else
                        {
                            if (codlinea1 == "004")
                            {

                                for (int i = 31; i <= 66; i++)
                                {
                                oe.CPLOCALIDAD = oe.CPLOCALIDAD+ Convert.ToString(stchar[i]);
                                }


                            }
                        }

                        if (st == "0362" && codlinea == "001")
                        {
                            oe.CODIGOSECUENCIA = st;


                            for (int i = 4; i <= 12; i++)
                            {
                                oe.NIF = oe.NIF + Convert.ToString(stchar[i]);
                            }

                            for (int i = 35; i <= 40; i++)
                            {
                                oe.FECHAEMISION = oe.FECHAEMISION + Convert.ToString(stchar[i]);
                            }

                            for (int i = 41; i <= 45; i++)
                            {
                                oe.CODBANC = oe.CODBANC + Convert.ToString(stchar[i]);
                            }
                            for (int i = 46; i <= 50; i++)
                            {
                                oe.CODOFICINA = oe.CODOFICINA + Convert.ToString(stchar[i]);
                            }
                            for (int i = 49; i <= 58; i++)
                            {
                                oe.CUENTACORRIENTE = oe.CUENTACORRIENTE + Convert.ToString(stchar[i]);
                            }
                            for (int i = 63; i <= 65; i++)
                            {
                                oe.CODIGOCONTROL = oe.CODIGOCONTROL + Convert.ToString(stchar[i]);
                            }

                            oe.IBAN = calculo_IBAN(oe.CODBANC.Trim() + oe.CODOFICINA.Trim() + oe.CODIGOCONTROL.Trim() + oe.CUENTACORRIENTE.Trim());

                        }

                        if (st == "0362" && codlinea == "002")
                        {
                            for (int i = 29; i <= 72; i++)
                            {
                                oe.NOMBRE = oe.NOMBRE + Convert.ToString(stchar[i]);
                            }
                        }
                        if (st == "0362" && codlinea == "003")
                        {
                            for (int i = 29; i <= 64; i++)
                            {
                                oe.CALLE = oe.CALLE + Convert.ToString(stchar[i]);
                            }
                        }
                        if (st == "0362" && codlinea == "004")
                        {
                            for (int i = 29; i <= 64; i++)
                            {
                                oe.CPLOCALIDAD = oe.CPLOCALIDAD + Convert.ToString(stchar[i]);
                            }
                        }
                        
                        if (st == "0656")
                        {
                            

                            st = Convert.ToString(stchar[26]) + Convert.ToString(stchar[27]) + Convert.ToString(stchar[28]);

                            if (st == "010")
                            {
                                nominas = true;
                                ocp = new OrdenClientePago();
                            }
                            else
                            {
                                if (yaheentrado)
                                {
                                    ocp = new OrdenClientePago();
                                    yaheentrado = false;
                                }
                                
                            }
                            if (nominas)
                            {
                                if (st == "010")    
                                {

                                    for (int i = 17; i <= 25; i++)
                                    {
                                        ocp.NIF = ocp.NIF + Convert.ToString(stchar[i]);
                                    }
                                    for (int i = 29; i <= 40; i++)
                                    {
                                        ocp.FACTURA = ocp.FACTURA + Convert.ToString(stchar[i]);
                                    }

                                    for (int i = 41; i <= 44; i++)
                                    {
                                        ocp.CODBANC = ocp.CODBANC + Convert.ToString(stchar[i]);
                                    }

                                    for (int i = 45; i <= 48; i++)
                                    {
                                        ocp.CODOFICINA = ocp.CODOFICINA + Convert.ToString(stchar[i]);
                                    }

                                    for (int i = 49; i <= 58; i++)
                                    {
                                        ocp.CUENTACORRIENTE = ocp.CUENTACORRIENTE + Convert.ToString(stchar[i]);
                                    }
                                    for (int i = 63; i <= 64; i++)
                                    {
                                        ocp.CODIGOCONTROL = ocp.CODIGOCONTROL + Convert.ToString(stchar[i]);
                                    }
                                    ocp.IBAN = calculo_IBAN(ocp.CODBANC.Trim() + ocp.CODOFICINA.Trim() + ocp.CODIGOCONTROL.Trim() + ocp.CUENTACORRIENTE.Trim());
                                    st = Convert.ToString(stchar[26]) + Convert.ToString(stchar[27]) + Convert.ToString(stchar[28]);
                                    yaheentrado = false;
                                }
                                
                                if (st == "011")
                                {
                                    for (int i = 29; i <= 64; i++)
                                    {
                                        ocp.NOMBRE = ocp.NOMBRE + Convert.ToString(stchar[i]);
                                    }

                                    
                                }

                                if (st == "012")
                                {
                                    for (int i = 29; i <= 64; i++)
                                    {
                                        ocp.CALLE = ocp.CALLE + Convert.ToString(stchar[i]);
                                    }


                                }

                                if (st == "014")
                                {
                                    for (int i = 29; i <= 64; i++)
                                    {
                                        ocp.CPLOCALIDAD = ocp.CPLOCALIDAD + Convert.ToString(stchar[i]);
                                    }

                                    CompletoDatos = true;
                                }

                            }
                            else
                            {
                                
                                st = Convert.ToString(stchar[28]) + Convert.ToString(stchar[29]) + Convert.ToString(stchar[30]);

                                if (st == "010")
                                {

                                    for (int i = 19; i <= 27; i++)
                                    {
                                        ocp.NIF = ocp.NIF + Convert.ToString(stchar[i]);
                                    }
                                    for (int i = 31; i <= 42; i++)
                                    {
                                        ocp.FACTURA = ocp.FACTURA + Convert.ToString(stchar[i]);
                                    }

                                    for (int i = 43; i <= 46; i++)
                                    {
                                        ocp.CODBANC = ocp.CODBANC + Convert.ToString(stchar[i]);
                                    }

                                    for (int i = 47; i <= 50; i++)
                                    {
                                        ocp.CODOFICINA = ocp.CODOFICINA + Convert.ToString(stchar[i]);
                                    }

                                    for (int i = 53; i <= 62; i++)
                                    {
                                        ocp.CUENTACORRIENTE = ocp.CUENTACORRIENTE + Convert.ToString(stchar[i]);
                                    }
                                    for (int i = 51; i <= 52; i++)
                                    {
                                        ocp.CODIGOCONTROL = ocp.CODIGOCONTROL + Convert.ToString(stchar[i]);
                                    }
                                    ocp.IBAN = calculo_IBAN(ocp.CODBANC.Trim() + ocp.CODOFICINA.Trim() + ocp.CODIGOCONTROL.Trim() + ocp.CUENTACORRIENTE.Trim());
                                    st = Convert.ToString(stchar[26]) + Convert.ToString(stchar[27]) + Convert.ToString(stchar[28]);
                                }

                                if (st == "011")
                                {
                                    for (int i = 31; i <= 66; i++)
                                    {
                                        ocp.NOMBRE = ocp.NOMBRE + Convert.ToString(stchar[i]);
                                    }


                                }

                                if (st == "016")
                                {
                                    for (int i = 31; i <= 66; i++)
                                    {
                                        ocp.DESCRPCION_FACTURA = ocp.DESCRPCION_FACTURA + Convert.ToString(stchar[i]);
                                    }

                                    CompletoDatos = true;
                                }

                               
                            
                            }
                        
                        }
                        if (CompletoDatos)
                        {

                            OrdenIndividual.Add(ocp);
                            CompletoDatos = false;
                            yaheentrado = true;

                        }

                        if (st == "0856" )
                        {

                            if (nominas)
                            {
                                for (int i = 29; i <= 40; i++)
                                {
                                    oe.IMPORTETOAL = oe.IMPORTETOAL + Convert.ToString(stchar[i]);
                                }

                            }
                            else
                            {

                                for (int i = 31; i <= 42; i++)
                                {
                                    oe.IMPORTETOAL = oe.IMPORTETOAL + Convert.ToString(stchar[i]);
                                }


                            }
                           

                          
                        }


                    }
                    string referencia;
                    referencia = txtRef34.Text;

                    if (referencia.Count() < 14)
                    {

                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter objWriter;
                            string[] file_txt;
                            file_txt = saveFileDialog1.FileName.Split(new Char[] { '.' });
                            objWriter = new StreamWriter(file_txt[0] + ".txt");
                            string linea, ia;
                            int diferencia;

                            linea = "01ORD34145001";
                            linea = linea + oe.NIF;
                            linea =  linea + "000" ;
                            string ano, mes, dia;
                            int intdia, intmes;
                            ano = DateTime.Now.Year.ToString();
                            intmes = DateTime.Now.Month;
                            intdia = DateTime.Now.Day;
                            if (intdia < 10)
                            {
                                dia = "0" + intdia.ToString();
                            }
                            else
                            {
                                dia = intdia.ToString();
                            }
                            if (intmes < 10)
                            {
                                mes = "0" + intmes.ToString();
                            }
                            else
                            {
                                mes = intmes.ToString();
                            }

                            linea = linea + ano + mes + dia;

                            char[] stFecha;

                            stFecha = oe.FECHAEMISION.ToCharArray();
                            ano = "20" + stFecha[4].ToString() + stFecha[5].ToString();

                            mes = stFecha[2].ToString() + stFecha[3].ToString();
                            dia = stFecha[0].ToString() + stFecha[1].ToString();
                            linea = linea + ano + mes + dia;
                            ia = identificador_Acreedor(oe.NIF);
                            linea = linea + "A";
                            oe.IBAN = calculo_IBAN(oe.CODBANC + oe.CODOFICINA + oe.CODIGOCONTROL + oe.CUENTACORRIENTE);
                            linea = linea + oe.IBAN;
                           
                            diferencia = 34 - oe.IBAN.Count();
                          
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + " ";
                            }
                            linea = linea + "0";
                            linea = linea + oe.NOMBRE.Trim();
                            string aux = oe.NOMBRE.Trim();
                            diferencia = 70 - aux.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + " ";
                            }
                            for (int i = 1; i <= 453; i++)
                            {
                                linea = linea + " ";
                            }
                            objWriter.WriteLine(linea);

                            linea = null;
                            linea = "02SCT34145" + oe.NIF + "000";
                            for (int i = 1; i <= 578; i++)
                            {
                                linea = linea + " ";
                            }

                            objWriter.WriteLine(linea);

                             int n_total;
                             n_total = 1;

                            foreach (OrdenClientePago oc in OrdenIndividual)
                            {
                                linea = null;
                                linea = "03SCT34145002";
                                linea = linea + oc.NIF.Trim();
                                diferencia = 35 - oc.NIF.Count();

                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + " ";
                                }
                                
                                linea = linea + "A";
                                linea = linea + oc.IBAN;
                                diferencia = 34 - oc.IBAN.Count();
                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + " ";
                                }

                                //diferencia = 34 - oc.IBAN.Count();
                                //for (int i = 1; i <= diferencia; i++)
                                //{
                                //    linea = linea + " ";
                                //}
                                char[] stImporte;

                                stImporte = oc.FACTURA.ToCharArray();
                                for (int i = 1; i <= stImporte.Count()-1; i++)
                                {
                                    linea = linea + stImporte[i].ToString();
                                }
                                linea = linea + "3";
                                for (int i = 1; i <= 11; i++)
                                {
                                    linea = linea + " ";
                                }
                                aux = oc.NOMBRE.Trim();
                                diferencia = 70 - aux.Count();
                                linea = linea + aux;
                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + " ";
                                }
                                for (int i = 1; i <= 50; i++)
                                {
                                    linea = linea + " ";
                                }
                                for (int i = 1; i <= 50; i++)
                                {
                                    linea = linea + " ";
                                }
                                for (int i = 1; i <= 40; i++)
                                {
                                    linea = linea + " ";
                                }
                                linea = linea + "ES";
                                if (oc.DESCRPCION_FACTURA == null)
                                {
                                    diferencia = 140;
                                }

                                else
                                {
                                    aux = oc.DESCRPCION_FACTURA.Trim();
                                    diferencia = 140 - aux.Count();
                                    linea = linea + aux;
                                
                                }
                                
                                for (int i = 1; i <= diferencia; i++)
                                {
                                    linea = linea + " ";
                                }
                                for (int i = 1; i <= 35; i++)
                                {
                                    linea = linea + " ";
                                }
                                for (int i = 1; i <= 8; i++)
                                {
                                    linea = linea + " ";
                                }
                                for (int i = 1; i <= 99; i++)
                                {
                                    linea = linea + " ";
                                }
                                objWriter.WriteLine(linea);
                                n_total = n_total+1;

                            }

                            linea = null;
                            linea = "04SCT";
                            aux = oe.IMPORTETOAL.Trim();
                            diferencia = 17 - aux.Count();
                            
                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }
                            linea = linea + aux;

                            string stn_total;
                            stn_total = n_total.ToString();
                            diferencia = 8 - stn_total.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }

                            linea = linea + stn_total;
                            n_total = n_total + 1;
                            stn_total = n_total.ToString();
                            diferencia = 10 - stn_total.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }
                            linea = linea + stn_total;
                            n_total = n_total - 2;
                            for (int i = 1; i <= 560; i++)
                            {
                                linea = linea + " ";
                            }
                            objWriter.WriteLine(linea);

                            linea = null;
                            linea = "99ORD";

                            aux = oe.IMPORTETOAL.Trim();
                            diferencia = 17 - aux.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }
                            linea = linea + aux;
                            stn_total = n_total.ToString();
                            diferencia = 8 - stn_total.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }

                            linea = linea + stn_total;
                            n_total = n_total + 4;
                            stn_total = n_total.ToString();
                            diferencia = 10 - stn_total.Count();

                            for (int i = 1; i <= diferencia; i++)
                            {
                                linea = linea + "0";
                            }
                            linea = linea + n_total.ToString();
                            for (int i = 1; i <= 560; i++)
                            {
                                linea = linea + " ";
                            }
                            objWriter.WriteLine(linea);
                            

                           
                           
                            objWriter.Close();

                            OrdenIndividual.Clear();
                        }
                    }




                }
               catch (Exception ex)
                {
                   MessageBox.Show("Error: No se puede leer del archivo. Código error: " + ex.Message);
               }
            } 

        }
        private void btnNorma19_Click(object sender, EventArgs e)
        {
            
            
        }

        public bool validateCif(string cif)
        {
            if (string.IsNullOrEmpty(cif)) return false;
            cif = cif.Trim().ToUpper();

            //Debe tener una longitud igual a 9 caracteres;
            if (cif.Length != 9) return false;
            // ... y debe comenzar por una letra, la cual pasamos a mayúscula, ... 
            // 
            string firstChar = cif.Substring(0, 1);
            // ...que necesariamente deberá de estar comprendida en 
            // el siguiente intervalo: ABCDEFGHJNPQRSUVW 
            // 
            string cadena = "ABCDEFGHJNPQRSUVW";
            if (cadena.IndexOf(firstChar) == -1) return false;
            try
            {
                Int32 sumaPar = default(Int32);
                Int32 sumaImpar = default(Int32);
                // A continuación, la cadena debe tener 7 dígitos + el dígito de control. 
                // 
                string cif_sinControl = cif.Substring(0, 8);
                string digits = cif_sinControl.Substring(1, 7);
                for (Int32 n = 0; n <= digits.Length - 1; n += 2)
                {
                    if (n < 6)
                    {
                        // Sumo las cifras pares del número que se corresponderá 
                        // con los caracteres 1, 3 y 5 de la variable «digits». 
                        // 
                        sumaPar += Convert.ToInt32(digits[n + 1].ToString());
                    }
                    // Multiplico por dos cada cifra impar (caracteres 0, 2, 4 y 6). 
                    // 
                    Int32 dobleImpar = 2 * Convert.ToInt32(digits[n].ToString());
                    // Acumulo la suma del doble de números impares. 
                    // 
                    sumaImpar += (dobleImpar % 10) + (dobleImpar / 10);
                }
                // Sumo las cifras pares e impares. 
                // 
                Int32 sumaTotal = sumaPar + sumaImpar;
                // Me quedo con la cifra de las unidades y se la resto a 10, siempre 
                // y cuando la cifra de las unidades sea distinta de cero 
                // 
                sumaTotal = (10 - (sumaTotal % 10)) % 10;
                // Devuelvo el Dígito de Control dependiendo del primer carácter 
                // del NIF pasado a la función. 
                //
                string digitoControl = "";
                switch (firstChar)
                {
                    case "N":
                    case "P":
                    case "Q":
                    case "R":
                    case "S":
                    case "W":
                        // NIF de entidades cuyo dígito de control se corresponde 
                        // con una letra. 
                        // 
                        // Al estar los índices de los arrays en base cero, el primer 
                        // elemento del array se corresponderá con la unidad del número 
                        // 10, es decir, el número cero. 
                        // 
                        char[] characters = { 'J', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
                        digitoControl = characters[sumaTotal].ToString();
                        break;
                    default:
                        // NIF de las restantes entidades, cuyo dígito de control es un número. 
                        // 
                        digitoControl = sumaTotal.ToString();
                        break;
                }
                return digitoControl.Equals(cif.Substring(8, 1));
            }
            catch (Exception)
            {
                // Cualquier excepción producida, devolverá false. 
                return false;
            }
        }
        public string obtener_BIC(string IBAN)
        {

            string Cuenta;
            string BICActual;
            Cuenta = IBAN;
            char[] stchar;
            stchar = Cuenta.ToCharArray(4,4);
            string banco;
            banco =null;
            BICActual = null;
            for(int i=0;i<=3;i++)

            {

            banco = banco + stchar[i].ToString();

            }

            foreach (string st in BIC) 
            {
                string[] fila;
                fila = st.Split(new char[]{';'});
                if (fila[0] == banco)
                {
                    string[] Cod;
                    Cod = fila[1].Split(new char[] { 'X' });
                    BICActual = fila[1];
                }

            }

            return BICActual;
        }

        public string calculo_IBAN(string CCC)
        {
            string IBAN, Cuenta;

            decimal Valor, Valor1;
            Cuenta = CCC;
            Cuenta = Cuenta + "142800";
            Valor = Convert.ToDecimal(Cuenta);
            decimal ModuloValor;
           
            ModuloValor = Valor % 97;
            Valor1 = 98 - ModuloValor;
            if (Valor1 < 10)
            {
                IBAN = "ES0" + Convert.ToString(Valor1) + CCC;
            }
            else
            {
                IBAN = "ES" + Convert.ToString(Valor1) + CCC;
            }


            return IBAN;
        }

        public string identificador_Acreedor(string CIF)
        {
            string  Cuenta,CIF_SLetra,AT02;
            decimal Valor, Valor1;
            char[] stchar;
            Cuenta =CIF;
            Cuenta = Cuenta + "142800";
            stchar = Cuenta.ToCharArray();
            CIF_SLetra = null;
            for (int i = 1; i <= stchar.Count()-1; i++)
            {
                CIF_SLetra = CIF_SLetra + Convert.ToString(stchar[i]);
            }
            Cuenta = convertir_letra(Convert.ToString(stchar[0])) + CIF_SLetra;

            Valor = Convert.ToDecimal(Cuenta);
            decimal ModuloValor;

            ModuloValor = Valor % 97;
            Valor1 = 98 - ModuloValor;
            if (Valor1 < 10)
            {
                AT02 = "ES0" + Convert.ToString(Valor1) + dp.CODIGO +  CIF;
            }
            else
            {
                AT02 = "ES" + Convert.ToString(Valor1) + dp.CODIGO +  CIF;
            }


            return AT02;
        }

        public string convertir_letra(string letra)
        {
            string stletra;
            stletra = "";
            if (letra == "A") 
            {
                stletra = "10";
            
            }
            if (letra == "B")
            {
                stletra = "11";

            }
            if (letra == "C")
            {
                stletra = "12";

            }
            if (letra == "D")
            {
                stletra = "13";

            }
            if (letra == "E")
            {
                stletra = "14";

            }
            if (letra == "F")
            {
                stletra = "15";

            }
            if (letra == "G")
            {
                stletra = "16";

            }
            if (letra == "H")
            {
                stletra = "17";

            }
            if (letra == "I")
            {
                stletra = "18";

            }
            if (letra == "J")
            {
                stletra = "19";

            }
            if (letra == "K")
            {
                stletra = "20";

            }
            if (letra == "L")
            {
                stletra = "21";

            }
            if (letra == "M")
            {
                stletra = "22";

            }
            if (letra == "N")
            {
                stletra = "23";

            }
            if (letra == "O")
            {
                stletra = "24";

            }
            if (letra == "P")
            {
                stletra = "25";

            }
            if (letra == "Q")
            {
                stletra = "26";

            }
            if (letra == "R")
            {
                stletra = "27";

            }
            if (letra == "S")
            {
                stletra = "28";

            }
            if (letra == "T")
            {
                stletra = "29";

            }
            if (letra == "U")
            {
                stletra = "30";

            }
            if (letra == "V")
            {
                stletra = "31";

            }
            if (letra == "W")
            {
                stletra = "32";

            }
            if (letra == "X")
            {
                stletra = "33";

            }
            if (letra == "Y")
            {
                stletra = "34";

            }
            if (letra == "Z")
            {
                stletra = "35";

            }
            return stletra;

        }

        private void txtRef19_TextChanged(object sender, EventArgs e)
        {
            string st;
            st = txtRef19.Text;
            label3.Text = "Número de caracteres = " + st.Count();

        }

        private void Form1_Load(object sender, EventArgs e)

        {

            
            try
            {
                
               
                    string st;
                    st = Application.StartupPath + "\\bic_sepa42.csv";
                    string text = System.IO.File.ReadAllText(st);
                    BIC = text.Split(new Char[] { '\r', '\n' });
               
                
                
            }
            catch
            {
                string message = "Error fatal";
                string caption = "Error S.0.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon Icono = MessageBoxIcon.Error;
                MessageBox.Show(message, caption, buttons, Icono);
                this.Close();
                

            }


            
        }

      

       

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertirCuaderno19A1914ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obtener_C1914();
        }

        private void convertirCuaderno34A3414ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obtener_C3414();
        }

        private void txtRef34_TextChanged(object sender, EventArgs e)
        {
            string st;
            st = txtRef34.Text;
            label9.Text = "Número de caracteres = " + st.Count();
        }

       

    }

    
}
