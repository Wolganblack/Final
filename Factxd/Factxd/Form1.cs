using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Milibreria;

namespace Factxd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { /*
            try
            {
                SqlConnection Con = new SqlConnection("Data Source =.; Initial Catalog = Administracion; Integrated Security = True");
                Con.Open();
                MessageBox.Show("Se ha conectado");
            }

            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error" + error.Message);

            }*/

            /*  Utilidades.Ejecutar("Select * from Cliente where Idcliente=1");*/

            try
            {

                string CMD = String.Format("Select * from Usuarios where Account = '{0}' and Password='{1}'", 
                    textboxuser.Text.Trim(),textboxclave.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);
                string cuenta = ds.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contraseña = ds.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (cuenta==textboxuser.Text.Trim() && contraseña==textboxclave.Text.Trim())
                {

                    MessageBox.Show("Se ha iniciado sesion");

                }

               /* else
                {
                    MessageBox.Show("Usuario y Contraseña Incorrectos");
                }*/

            }


            catch (Exception error)
            {

                MessageBox.Show("Usuario y Contraseña Incorrectos" + error.Message);


            }



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
