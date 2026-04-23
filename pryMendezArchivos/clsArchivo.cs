using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
