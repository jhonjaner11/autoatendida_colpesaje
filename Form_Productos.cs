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
    public partial class Form_Productos : Form
    {
        Database miDB = new Database();

        string codigo;
        string nombre;
        string id;
        string tipo="productos";

        public Form_Productos()
        {
            InitializeComponent();
            MostrarTabla();

            txt_nombre.Enabled = false;
            txt_codigo.Enabled = false;
        }

        public void MostrarTabla()
        {
            //btn_modificar.Enabled = false;
            string time_ini;
            string time_fin;
            string[] arrfecha =  { "", "" }; 

            DataTable table = new DataTable();

            dt.DataSource = (miDB.LlenarTabla(table, tipo, arrfecha));
            //dt.CurrentRow.Selected = false;
        }

      


        private void obtener(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificar.Enabled = true;
            codigo = dt.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            nombre = dt.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            //llenar_conductor(id_conductor);
            txt_codigo.Text = codigo;
            txt_nombre.Text = nombre;
            id = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }


        private bool verificar()
        {
            bool res = true;
            if (txt_codigo.Text == "") res = false;
            if (txt_nombre.Text == "") res = false;

            return res;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (btn_modificar.Text == "Modificar")
            {
                txt_nombre.Enabled = true;
                txt_codigo.Enabled = true;
                btn_modificar.Text = "Guardar";
            }
            else
            {
                if (verificar())
                {
                    if (id == "")
                    {
                        string[] arr = { txt_codigo.Text, txt_nombre.Text };
                        miDB.InsertProducto(arr);
                    }
                    else
                    {
                        string[] arr = { id, txt_codigo.Text, txt_nombre.Text };
                        miDB.UpdateProducto(arr);
                    }

                    txt_nombre.Enabled = false;
                    txt_codigo.Enabled = false;
                    btn_modificar.Text = "Modificar";
                    txt_codigo.Text = "";
                    txt_nombre.Text = "";
                    MostrarTabla();
                }
                else
                {
                    MessageBox.Show("Falta informacion");
                }




            }

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_nombre.Enabled = true;
            txt_codigo.Enabled = true;
            btn_modificar.Text = "Guardar";

            id = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                miDB.DeleteProducto(id);
                MostrarTabla();
                txt_codigo.Text = "";
                txt_nombre.Text = "";
            }
            else
            {
                MessageBox.Show("Seleccione registro a eliminar");
            }
        }
    }
}
