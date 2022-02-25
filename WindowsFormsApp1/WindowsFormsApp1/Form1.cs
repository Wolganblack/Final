using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=mercado;Uid=root;Pwd=LINUX1983");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("select * from producto", conexion);
            conexion.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable Tabla = new DataTable();
            adaptador.Fill(Tabla);
            dataGridView1.DataSource = Tabla;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conectados");
                conexion.Close();
     
            }
            catch(Exception error)
            {
                MessageBox.Show("Problemas al conectarte" + error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("select * from producto", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable Tabla = new DataTable();
            adaptador.Fill(Tabla);
            dataGridView1.DataSource = Tabla;

          
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query ="insert into producto(Nombre,Precio) values ('"+Convert.ToString(TextNombre.Text.Trim())+"','"+Convert.ToDouble(TextPrecio.Text.Trim())+"');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se ha registrado un producto"+TextNombre);
        }

        private void Btnactualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "update producto set Nombre='" + TextNombre.Text.Trim()+ "', precio=" + Convert.ToDouble(TextPrecio.Text.Trim())+ " where Id=" 
                + Convert.ToInt16(Textid.Text.Trim());
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo el Producto");
                  




        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
          MySqlCommand consulta= new MySqlCommand("delete from producto where Id=" + Convert.ToInt16(Textid.Text.Trim()), conexion);

            if (consulta.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Se elimino el registro");
            
            }

            else

            {

                MessageBox.Show("No se elimino el registro");


            }
            conexion.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Textid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TextNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TextPrecio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
