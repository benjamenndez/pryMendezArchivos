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




    }
}
