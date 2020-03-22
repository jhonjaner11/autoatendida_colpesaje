using System;
using System.Collections.Generic;

using System.Text;

using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Placas
{
    class Database
    {
        public SQLiteConnection myConnection;
        public Database()
        {
            //myConnection = new SQLiteConnection("Data Source=bd/autoatendido.sql");
            myConnection = new SQLiteConnection("Data Source=bd/autoatendido.sqlite");

        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

        // --------------- UPDATE -------------------------//
        public bool UpdateProducto(string[] arr)
        {
            Boolean respuesta;
            string id = arr[0];
            string codigo = arr[1];
            string nombre = arr[2];
           

            string query = "";

            //Console.WriteLine("prueba:" + prueba[1]);
            if (true)
            {
                query = "update  productos set ";
                query = query + "codigo='"+codigo+"',";
                query = query + "nombre='" + nombre + "' ";
                query = query + "where id=" + id;

            }
            else
            {
                //Console.WriteLine("entro al else");
                //query = "insert into eventos (placa, fecha_entrada, id_producto, peso_entrada,  id_conductor) values(";
                //query = query + "'" + placa + "','" + fecha + "'," + producto + "," + peso + ",'" + conductor + "')";
            }


            try
            {
                OpenConnection();
                if (true)
                {
                    Console.WriteLine(query);
                    SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                    comando.ExecuteNonQuery();
                    respuesta = true;
                }


                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                respuesta = false;
            }


            return respuesta;
        }

        public bool UpdateConductor(string[] arr)
        {
            Boolean respuesta;
            string id = arr[0];
            string cedula = arr[1];
            string nombre = arr[2];


            string query = "";

            //Console.WriteLine("prueba:" + prueba[1]);
            if (true)
            {
                query = "update  conductores set ";
                query = query + "cedula='" + cedula + "',";
                query = query + "nombre='" + nombre + "' ";
                query = query + "where id=" + id;

            }
            else
            {
                //Console.WriteLine("entro al else");
                //query = "insert into eventos (placa, fecha_entrada, id_producto, peso_entrada,  id_conductor) values(";
                //query = query + "'" + placa + "','" + fecha + "'," + producto + "," + peso + ",'" + conductor + "')";
            }


            try
            {
                OpenConnection();
                if (true)
                {
                    Console.WriteLine(query);
                    SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                    comando.ExecuteNonQuery();
                    respuesta = true;
                }


                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                respuesta = false;
            }


            return respuesta;
        }

        // --------------- INSERT -------------------------//
        public bool InsertEvento(string[] arr)
        {
            Boolean respuesta;
            string placa = arr[0];
            string fecha = arr[1];
            string producto = arr[2];
            string peso = arr[3];
            string conductor = arr[4];
            string query = "";

            string[] prueba = GetEvento(placa);
            
            Console.WriteLine("prueba:"+ prueba[1]);
            if (prueba[1]=="")
            {
                Console.WriteLine("entro a prueba");
                
                float peso_salida = float.Parse(peso);
                float peso_neto = peso_salida - float.Parse(prueba[0]);
                query = "update eventos set fecha_salida = '" + fecha + "',";
                query = query + "peso_neto=" + peso_neto + ",";
                query = query + "peso_salida=" + peso_salida;
                query = query +" where placa='"+placa+"'";
                
            }
            else
            {
                Console.WriteLine("entro al else");
                query = "insert into eventos (placa, fecha_entrada, id_producto, peso_entrada,  id_conductor) values(";
                query = query + "'" + placa + "','" + fecha + "'," + producto + "," + peso +",'"+conductor+"')";
            }
           

            try
            {
                OpenConnection();
                if (true)
                {
                    Console.WriteLine(query);
                    SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                    comando.ExecuteNonQuery();
                    respuesta = true;
                }
                
                
                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                respuesta = false;
            }


            return respuesta;
        }

        public bool InsertProducto(string[] arr)
        {
            Boolean respuesta;
            string codigo = arr[0];
            string nombre = arr[1];

            string query = "";

            //Console.WriteLine("prueba:" + prueba[1]);
            if (true)
            {
                query = "insert into productos (codigo, nombre) values(";
                query = query + "'" + codigo + "','" + nombre + "')";
               
            }
            else
            {
                //Console.WriteLine("entro al else");
                //query = "insert into eventos (placa, fecha_entrada, id_producto, peso_entrada,  id_conductor) values(";
                //query = query + "'" + placa + "','" + fecha + "'," + producto + "," + peso + ",'" + conductor + "')";
            }


            try
            {
                OpenConnection();
                if (true)
                {
                    Console.WriteLine(query);
                    SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                    comando.ExecuteNonQuery();
                    respuesta = true;
                }


                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                respuesta = false;
            }


            return respuesta;
        }

        public bool InsertConductor(string[] arr)
        {
            Boolean respuesta;
            string cedula = arr[0];
            string nombre = arr[1];

            string query = "";

            //Console.WriteLine("prueba:" + prueba[1]);
            if (true)
            {
                query = "insert into conductores (cedula, nombre) values(";
                query = query + "'" + cedula + "','" + nombre + "')";

            }
            else
            {
                //Console.WriteLine("entro al else");
                //query = "insert into eventos (placa, fecha_entrada, id_producto, peso_entrada,  id_conductor) values(";
                //query = query + "'" + placa + "','" + fecha + "'," + producto + "," + peso + ",'" + conductor + "')";
            }


            try
            {
                OpenConnection();
                if (true)
                {
                    Console.WriteLine(query);
                    SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                    comando.ExecuteNonQuery();
                    respuesta = true;
                }


                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                respuesta = false;
            }


            return respuesta;
        }

        // --------------- DELETE -------------------------//
        public bool DeleteProducto(string id)
        {
            Boolean respuesta;



            string query = "";

            //Console.WriteLine("prueba:" + prueba[1]);
            if (true)
            {
                query = "delete from productos where id=" + id;

            }
            else
            {
                //Console.WriteLine("entro al else");
                //query = "insert into eventos (placa, fecha_entrada, id_producto, peso_entrada,  id_conductor) values(";
                //query = query + "'" + placa + "','" + fecha + "'," + producto + "," + peso + ",'" + conductor + "')";
            }


            try
            {
                OpenConnection();
                if (true)
                {
                    Console.WriteLine(query);
                    SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                    comando.ExecuteNonQuery();
                    respuesta = true;
                }


                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                respuesta = false;
            }


            return respuesta;
        }

        public bool DeleteConductor(string id)
        {
            Boolean respuesta;



            string query = "";

            //Console.WriteLine("prueba:" + prueba[1]);
            if (true)
            {
                query = "delete from conductores where id=" + id;

            }
            else
            {
                //Console.WriteLine("entro al else");
                //query = "insert into eventos (placa, fecha_entrada, id_producto, peso_entrada,  id_conductor) values(";
                //query = query + "'" + placa + "','" + fecha + "'," + producto + "," + peso + ",'" + conductor + "')";
            }


            try
            {
                OpenConnection();
                if (true)
                {
                    Console.WriteLine(query);
                    SQLiteCommand comando = new SQLiteCommand(query, myConnection);
                    comando.ExecuteNonQuery();
                    respuesta = true;
                }


                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e);
                respuesta = false;
            }


            return respuesta;
        }

        // --------------- GET -------------------------//
        public string[] GetEvento(string placa)
        {
            string[] res = new string[5];
            string query = "select peso_neto, peso_entrada, peso_salida from eventos where placa='" + placa+"'";
            query = query + " order by fecha_entrada desc ";

            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    res[0] = reader["peso_entrada"].ToString();
                    res[1] = reader["peso_neto"].ToString();
                    res[2] = reader["peso_salida"].ToString();
                    Console.WriteLine("peso_entrada:"+res[0]);
                    Console.WriteLine("peso_neto:"+res[1]);
                    Console.WriteLine("peso_salida:" + res[2]);
                }
                else
                {
                    res[0] = "null";
                }

                reader.Close();
            }
            catch
            {
                res[0] = "null";
            }
            CloseConnection();

            return res;
        }

        public List<string> GetProductos()
        {
            string query = "SELECT *  FROM productos";

            List<string> li = new List<string>();

            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    li.Add(reader["codigo"].ToString());
                }
                reader.Close();

            }
            catch
            {

            }
            CloseConnection();


            return li;
        }


        public System.Data.DataTable LlenarTabla(System.Data.DataTable table, string tipo, string[] fecha)
        {
            string query;
            string queryTime;
            if (tipo == "productos")
            {
                query = "select * from productos ";
                
            }else if (tipo == "eventos")
            {
                query = "select e.id, e.placa, e.fecha_entrada as 'Fecha Entrada', e.fecha_salida as 'Fecha Salida',";
                query = query + "e.peso_entrada as 'Peso Entrada', e.peso_salida as 'Peso Salida', e.peso_neto as 'Peso Neto',";
                query = query + "p.nombre as 'Producto', c.nombre as 'Conductor' ";
                query = query + " from eventos e left join productos p on e.id_producto = p.id ";
                query = query + " left join conductores c on e.id_conductor = c.id ";

                
            }
            else if (tipo == "conductores")
            {
                query = "select * from conductores ";
            }
           
            else
            {
                query = "select null";
            }

            if (fecha[0] != "")
            {
                //where(fecha >= '18/02/2020' AND fecha < '20/02/2020')
                queryTime = "where(fecha >= '" + fecha[0] + "' AND fecha <= '" + fecha[1] + "'+'+1 day') ";
            }
            else
            {
                queryTime = "";
            }

            SQLiteCommand comand = new SQLiteCommand(query + queryTime, myConnection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            adapter.SelectCommand = (comand);
            adapter.Fill(table);
            return table;

        }

        public int GetTicket()
        {
            string query = "SELECT SEQ from sqlite_sequence WHERE name='eventos'";

            int sec;

            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    sec = int.Parse(reader["SEQ"].ToString());
                   
                }
                else
                {
                    sec = 0;
                }

                //Console.WriteLine(reader["login"].ToString());
                reader.Close();
            }
            catch
            {
               sec = 0;
            }
            CloseConnection();

            return sec+1;
        }

        public List<string> GetConductores()
        {
            string query = "SELECT cedula FROM conductores";
            List<string> li = new List<string>();
            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    li.Add(reader["cedula"].ToString());
                }
                reader.Close();
            }
            catch
            {

            }
            CloseConnection();

            return li;
        }



        public string[] GetConductor(string id)
        {
            string[] res = new string[5];
            string query = "Select * from conductores where cedula='" + id + "'";
            OpenConnection();
            try
            {
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {

                    res[0] = reader["cedula"].ToString();
                    res[1] = reader["nombre"].ToString();
                    res[2] = reader["id"].ToString();
                }
                else
                {
                    //usuario = "Errado";
                }
                reader.Close();
            }
            catch
            {
                //usuario = "Errado";
            }
            CloseConnection();
            return res;
        }

        public string[] GetProducto(string id)
        {
            string[] res = new string[5];
            string query = "Select * from productos where codigo='"+id+"'" ;
            Console.WriteLine(query);
            OpenConnection();
            try
            {
                Console.WriteLine("id" + id);
                SQLiteCommand sql = new SQLiteCommand(query, myConnection);
                SQLiteDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    
                    res[0] = reader["codigo"].ToString();
                    res[1] = reader["nombre"].ToString();
                    res[2] = reader["id"].ToString();

                    Console.WriteLine("cod" + res[0]);
                    Console.WriteLine("nom" + res[1]);
                    Console.WriteLine("id" + res[2]);
                }
                else
                {
                    //usuario = "Errado";
                }
                reader.Close();
            }
            catch
            {
                //usuario = "Errado";
            }
            CloseConnection();
            return res;
        }
    }
}
