using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placas
{
    public partial class Form_Principal : Form
    {
        Obtener_Placa ob = new Obtener_Placa();
        Database miDB = new Database();
        string img_carro = "img/camion.gif";
        string tipo = "eventos";
        string id_conductor = "";
        string id_producto = "";
        public Form_Principal()
        {
            InitializeComponent();
            txt_fecha_entrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txt_ticket.Text = miDB.GetTicket().ToString();
            autoLlenarCedula(txt_cedula);
            autoLlenarProductos(txt_codigo);
            MostrarTabla();
        }


        private void Cargar_Imagen()
        {
            
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "";
            BuscarImagen.FileName = "";
            BuscarImagen.InitialDirectory = "Imágenes";
            //BuscarImagen.FileName = txt_dir_placa.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                string dir = BuscarImagen.FileName;
               
                //txt_dir_placa.Text = dir;

                pb_original.ImageLocation = dir;
                pb_original.SizeMode = PictureBoxSizeMode.StretchImage;
                txt_placa.Text = ob.get_placa(dir);
               
            }

        }

        public void MostrarTabla()
        {
            //btn_modificar.Enabled = false;
            string time_ini;
            string time_fin;
            string[] arrfecha;
            //chk_Box_filtro.Checked
            if (false)
            {
                //time_ini = time_inicio.Value.Date.ToString();
                //time_fin = time_final.Value.Date.ToString();
                arrfecha = new string[2] { time_ini, time_fin };
            }
            else
            {
                arrfecha = new string[2] { "", "" };
            }
            //Console.WriteLine("hey: " + arrfecha[0] + arrfecha[1]);
            DataTable table = new DataTable();
            //string tipo = "visita";
            dt.DataSource = (miDB.LlenarTabla(table, tipo, arrfecha));
            //dt.CurrentRow.Selected = false;
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            Cargar_Imagen();
        }

        

        private void btn_productos_Click(object sender, EventArgs e)
        {


            Form frm = new Form_Productos();
            frm.ShowDialog();
            MostrarTabla();
        }


        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string placa = txt_placa.Text;
            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //string producto = txt_codigo.Text;
            string peso = txt_peso.Text;
            //string conductor = txt_cedula.Text;
            string[] arr = {placa, fecha, id_producto, peso, id_conductor};

            miDB.InsertEvento(arr);
            MostrarTabla();
            txt_ticket.Text = miDB.GetTicket().ToString();
            Limpiar();
        }

        private void Limpiar()
        {
            txt_nombre.Text = "";
            txt_cedula.Text = "";
            txt_placa.Text = "";
            txt_peso.Text = "";
            pb_original.ImageLocation = img_carro;
            pb_original.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btn_conductores_Click(object sender, EventArgs e)
        {
            Form frm = new Form_Conductores();
            frm.ShowDialog();
            MostrarTabla();
        }

        public void autoLlenarCedula(TextBox cajaTexto)
        {
            foreach (string color in miDB.GetConductores())
            {
                cajaTexto.AutoCompleteCustomSource.Add(color);
            }

        }

        public void autoLlenarProductos(TextBox cajaTexto)
        {
            foreach (string color in miDB.GetProductos())
            {
                cajaTexto.AutoCompleteCustomSource.Add(color);
            }
        }

        public void autoLlenarProducto(string id, TextBox cajaTexto)
        {
            string[] res = miDB.GetProducto(id);
            cajaTexto.Text = res[1];
            id_producto = res[2];
        }

        public void autoLlenarConductor(string id, TextBox cajaTexto)
        {
            string[] res = miDB.GetConductor(id);
            cajaTexto.Text = res[1];
            id_conductor = res[2];
        }

        private void txt_cedula_TextChanged(object sender, EventArgs e)
        {
            autoLlenarConductor(txt_cedula.Text, txt_nombre);
        }

        private void detalle(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("holi bebe");
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            autoLlenarProducto(txt_codigo.Text, txt_nombre_producto);
        }
    }
}
