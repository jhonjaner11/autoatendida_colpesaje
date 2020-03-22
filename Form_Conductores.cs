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
    public partial class Form_Conductores : Form
    {
        Database miDB = new Database();
        string cedula;
        string nombre;
        string id;
        string tipo = "conductores";
        public Form_Conductores()
        {
            InitializeComponent();
            MostrarTabla();
            txt_nombre.Enabled = false;
            txt_cedula.Enabled = false;
        }


        public void MostrarTabla()
        {
            
            //btn_modificar.Enabled = false;
            string time_ini;
            string time_fin;
            string[] arrfecha = { "", "" };

            DataTable table = new DataTable();

            dt.DataSource = (miDB.LlenarTabla(table, tipo, arrfecha));
            //dt.CurrentRow.Selected = false;
        }

        private void obtener(object sender, DataGridViewCellEventArgs e)
        {
           
            cedula = dt.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
            nombre = dt.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            id = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
            //llenar_conductor(id_conductor);
            txt_cedula.Text = cedula;
            txt_nombre.Text = nombre;

            txt_nombre.Enabled = false;
            txt_cedula.Enabled = false;


        }

        private void llenar_conductor(string id)
        {
           
            txt_cedula.Text = "";
            txt_nombre.Text = "";
        }
        private bool verificar()
        {
            bool res = true;
            if (txt_cedula.Text == "") res = false;
            if (txt_nombre.Text == "") res = false;

            return res;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if(btn_modificar.Text == "Modificar")
            {
                txt_nombre.Enabled = true;
                txt_cedula.Enabled = true;
                btn_modificar.Text = "Guardar";
            }
            else
            {
                if (verificar())
                {
                    if (id == "")
                    {
                        string[] arr = { txt_cedula.Text, txt_nombre.Text };
                        miDB.InsertConductor(arr);
                    }
                    else
                    {
                        string[] arr = { id, txt_cedula.Text, txt_nombre.Text };
                        miDB.UpdateConductor(arr);
                    }

                    txt_nombre.Enabled = false;
                    txt_cedula.Enabled = false;
                    btn_modificar.Text = "Modificar";
                    txt_cedula.Text = "";
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
            txt_cedula.Text = "";
            txt_nombre.Text = "";
            txt_nombre.Enabled = true;
            txt_cedula.Enabled = true;
            btn_modificar.Text = "Guardar";
            
            id = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (id != "") 
            {
                miDB.DeleteConductor(id);
                MostrarTabla();
                txt_cedula.Text = "";
                txt_nombre.Text = "";
            }
            else
            {
                MessageBox.Show("Seleccione registro a eliminar");
            }
        }
    }
}
