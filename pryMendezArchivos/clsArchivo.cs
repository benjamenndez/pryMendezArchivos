using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMendezArchivos
{
    internal class clsArchivo
    {
        public string NombreArchivo = "Clientes.csv";
        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //abrir 
            StreamWriter AD = new StreamWriter(NombreArchivo, true);

            //cargar o leer
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);

            //cerrar
            AD.Close();
            AD.Dispose();
        }
        private struct RegCLientes
        {
            public Int32 Codigo;
            public string Nombre;
            public decimal Deuda;
            public decimal Limite;
        }
        private RegCLientes[] VecClientes = new RegCLientes[1500];
        private Int32 IND = 0;

        private void CargarVector()
        {
            
            string DatosLeidos;
            string[] VecDatos = new string[4];
            IND = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
          
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                VecClientes[IND].Codigo = Convert.ToInt32(VecDatos[0]);
                VecClientes[IND].Nombre = VecDatos[1];
                VecClientes[IND].Deuda = Convert.ToDecimal(VecDatos[2]);
                VecClientes[IND].Limite = Convert.ToDecimal(VecDatos[3]);
                IND++;
                DatosLeidos = AD.ReadLine();
            }

            //cerrar
            AD.Close();
            AD.Dispose();

        }
        private void OrdenarVector()
        {
            RegCLientes aux;
            for (Int32 c = 0; c < IND - 1; c++)//contador de vueltas
            {
                for (Int32 i = 0; i < IND - 1; i++) //recorre el vector
                {
                    if (VecClientes[i].Codigo > VecClientes[i + 1].Codigo)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
            }    
        }
        
        private void ReescribirVector()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);
            for (Int32 i = 0; i < IND; i++)
            {
                AD.Write(VecClientes[i].Codigo);
                AD.Write(";");
                AD.Write(VecClientes[i].Nombre);
                AD.Write(";");
                AD.Write(VecClientes[i].Deuda);
                AD.Write(";");
                AD.WriteLine(VecClientes[i].Limite);
            }
        }

        public void OrdenarArchivo()
        {
           
            CargarVector();
            OrdenarVector();
            ReescribirVector();

        }
        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            //abrir
            StreamReader AD = new StreamReader(NombreArchivo);

            //leer
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            while(DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
               
                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }

            //cerrar
            AD.Close() ;
            AD.Dispose() ;
            
        }
        public bool ExisteCodigo(string cod)
        {
            string datoLeido;
            string[] vecDatos;
            bool encontrado = false;

            // Verificamos si el archivo existe antes de intentar leerlo
            if (File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);
                datoLeido = AD.ReadLine();

                while (datoLeido != null)
                {
                    vecDatos = datoLeido.Split(';');
                    // Comparamos el código del archivo con el que queremos ingresar
                    if (vecDatos[0] == cod)
                    {
                        encontrado = true;
                        break; // Si lo encuentra, sale del bucle
                    }
                    datoLeido = AD.ReadLine();
                }
                AD.Close();
                AD.Dispose();
            }
            return encontrado;
        }
        public Int32 CantClientes()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            int cant = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {

                cant++;
                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return cant;
        }
        public Decimal TotalDeuda()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
                datoLeido = AD.ReadLine();
            }


            AD.Close();
            AD.Dispose();

            return total;
        }
        public Decimal Promedio()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;
            int cant = 0;
            Decimal promedio = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                cant++;
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
                if (cant > 0)
                {
                    promedio = Math.Round(total / cant);//Redondea p/tener 2 decimales
                }

                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total / cant;
        }
        public Int32 CantDeudores()
        {
            String datoLeido;
            string[] vecDatos;
            int cantDeud = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');
                // Primero separas los datos, luego comparas
                if (Convert.ToDecimal(vecDatos[2]) > 0)
                {
                    cantDeud++;
                }
                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return cantDeud;
        }
        public Decimal PromDeudores()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;
            int cant = 0;
            Decimal promedio = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                cant++;
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
                if (cant > 0)
                {
                    promedio = Math.Round(total / cant);//Redondea p/tener 2 decimales
                }

                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total / cant;
        }
        public void GenerarReporte()
        {

            String datoLeido;
            string[] vecDatos = new string[4];

            //Abrir
            StreamWriter Reporte = new StreamWriter("Reporte.csv", false, Encoding.UTF8);
            Reporte.WriteLine("LISTADO DE CLIENTES");
            Reporte.WriteLine("\n");
            Reporte.WriteLine("Código; Nombre; Deuda; Límite");


            StreamReader AD = new StreamReader(NombreArchivo);

            //Leer
            datoLeido = AD.ReadLine();

            Int32 cant = 0;
            Decimal total = 0;
            Decimal promedio = 0;

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';'); //Pasamoslalinea a un vector, cada vez que vea un punto y coma va a separar la celda (lo corta)      
                Reporte.Write(vecDatos[0]); ;
                Reporte.Write(";");
                Reporte.Write(vecDatos[1]);
                Reporte.Write(";");
                Reporte.Write(vecDatos[2]);
                Reporte.Write(";");
                Reporte.WriteLine(vecDatos[3]);

                datoLeido = AD.ReadLine();
                cant++; //acumulala cantidad de clientes
                total = total + Convert.ToDecimal(vecDatos[2]);
                promedio = Math.Round(total / cant);
            }
            //Cerrar
            AD.Close();
            AD.Dispose();

            Reporte.WriteLine(";");
            Reporte.Write("Total Deudas:;;");
            Reporte.WriteLine(total);
            Reporte.Write("Cantidad de Clientes:;;");
            Reporte.WriteLine(cant);
            Reporte.Write("Promedio deudas:;;");
            Reporte.WriteLine(promedio);

            //Cerrar
            Reporte.Close();
            Reporte.Dispose();
        }


    }
}
