using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Milibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {

            SqlConnection Con = new SqlConnection("Data Source =.; Initial Catalog = Administracion; Integrated Security = True");
            Con.Open();
            DataSet Dsetprobando = new DataSet();
            SqlDataAdapter Consultadeprueba = new SqlDataAdapter(cmd, Con);
            Consultadeprueba.Fill(Dsetprobando);
            Con.Close();
            return Dsetprobando;



        }
    }
}
