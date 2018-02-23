using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

using MySql.Data.MySqlClient;
using PrototipoSeguridad;
using System.Net;

namespace Perfiles_usuario
{
    

    public partial class PerfilesUsuario : Form
    {
        string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD=; Database=bd_seguridad; ";

        public PerfilesUsuario()
        {
            InitializeComponent();
        }


        public void obtenerIP()
        {
            IPHostEntry host;

            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            //MessageBox.Show(localIP);
        }

        public static String s_error;
        private string localIP;
        private string error_nuevo;

        public static String stringpad = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ";
        bitacora_dll.bitacora_dll connection = new bitacora_dll.bitacora_dll(stringpad);


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               
                //Display query  
                string Query = "select id_usuario, usuario from usuario;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Cmb_id.DataSource = dTable;
                Cmb_id.ValueMember = "id_usuario";// here i have assign dTable object to the dataGridView1 object to display data.               
                Cmb_usuario.DataSource = dTable;
                Cmb_usuario.ValueMember = "usuario";// MyConn2.Close();  
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            try
            {
                
                string Query = "select * from perfil;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Dgv_perfil.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }
            try
            {

                string Query = "select * from aplicacion;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Dgv_soloapp.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            
        }
        

        private void Cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        


        private void aplicacion(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void llenar(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void llenarusuario(object sender, EventArgs e)
        {
            try
            {
                
                string Query = "select nombre_usuario from usuario where id_usuario = '" + Cmb_id.SelectedValue + "';";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Cmb_usuario.DataSource = dTable;
                Cmb_usuario.ValueMember = "nombre_usuario";// here i have assign dTable object to the dataGridView1 object to display data.               
                                                           // MyConn2.Close();  
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }
        }

        private void llenarid(object sender, EventArgs e)
        {
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            
            if (chb_perfiles.Checked)
            {
                Dgv_asignacion.Rows.Add(new string[]{
                Convert.ToString(Dgv_perfil[0,Dgv_perfil.CurrentRow.Index].Value),
                Convert.ToString(Dgv_perfil[1,Dgv_perfil.CurrentRow.Index].Value)

            });


            }
            else
            {
                Dgv_asignacion.Rows.Add(new string[]{
                Convert.ToString(Dgv_soloapp[0,Dgv_soloapp.CurrentRow.Index].Value),
                Convert.ToString(Dgv_soloapp[1,Dgv_soloapp.CurrentRow.Index].Value)

            });
            }
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            Dgv_asignacion.Rows.RemoveAt(Dgv_asignacion.CurrentRow.Index);
        }

        private void Btn_removerTodo_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            dTable.Clear();
            Dgv_asignacion.DataSource = dTable;
        }

        private void Btn_agregarTodo_Click(object sender, EventArgs e)
        {
            if (chb_perfiles.Checked)
            {
                for (int counter = 0; counter < (Dgv_perfil.Rows.Count) - 1;
            counter++)
                {
                    Dgv_asignacion.Rows.Add(new string[]{
                     Convert.ToString(Dgv_perfil[0,counter].Value),
                Convert.ToString(Dgv_perfil[1,counter].Value)

            });
                }
            }
            else
            {
                for (int counter = 0; counter < (Dgv_soloapp.Rows.Count) - 1;
            counter++)
                {
                    Dgv_asignacion.Rows.Add(new string[]{
                     Convert.ToString(Dgv_soloapp[0,counter].Value),
                Convert.ToString(Dgv_soloapp[1,counter].Value)

            });
                }

            }


        }

        private void Dgv_aplicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            Dgv_soloapp.Enabled = false;
        }

        private void Dgv_soloapp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dgv_aplicaciones.Enabled = false;
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {

            Globales.nom_apli = Dgv_asignacion.CurrentCell.Value.ToString();

            //MessageBox.Show(Globales.nom_apli);
            //MessageBox.Show(Globales.nom_usuario);
            this.Hide();
            Frm_MantenimientoApp mant_pp = new Frm_MantenimientoApp();

            mant_pp.Cmb_user.Text = Globales.nom_usuario.ToString();
            mant_pp.Cmb_aplicacion.Text = Globales.nom_apli.ToString();

            mant_pp.Show();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            int selectedIndex = Cmb_id.SelectedIndex+1;
            try
            {
                string Query = "delete from  bd_seguridad.detalle_usuario_perfil where id_usuario='" + selectedIndex.ToString() + "';";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
              //  MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dgv_asignacion.Rows.Add(new string[]{
                Convert.ToString(Dgv_perfil[0,Dgv_soloapp.CurrentRow.Index].Value),
                Convert.ToString(Dgv_perfil[1,Dgv_soloapp.CurrentRow.Index].Value)

            });
        }

        private void chb_perfiles_CheckedChanged(object sender, EventArgs e)
        {
            Dgv_soloapp.Enabled = false;
            Dgv_perfil.Enabled = true;
            chb_apli.Checked = false;
            

        }

        private void chb_apli_CheckedChanged(object sender, EventArgs e)
        {
            Dgv_perfil.Enabled = false;
            Dgv_soloapp.Enabled = true;
            chb_perfiles.Checked = false;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            String error_nuevo = ""; obtenerIP();
            String app = "4";
            

            for (int counter = 0; counter < (Dgv_asignacion.Rows.Count) - 1;
         counter++)
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  

                    //This is my insert query in which i am taking input from the user through windows forms  
                    string Query = "insert into bd_seguridad.Detalle_usuario_perfil(id_usuario,id_perfil) values('" + Cmb_id.Text.ToString() + "','" + Convert.ToString(Dgv_asignacion[0, counter].Value) + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                    OdbcDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Save Data");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    MessageBox.Show("Datos Ingresados");
                    connection.OpenConnection();
                    connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionG + "', '" + app + "','" + Globales.sExitoso + "', '" + Globales.sError + "','" + localIP + "')");
                    connection.CloseConnection();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                     MessageBox.Show(ex.Message);
                    MessageBox.Show("Datos NO ingresados, verifique la información. " + ex.ToString());
                    s_error = "." + ex.Message + ".";
                    String[] A = s_error.Split(new char[] { '\'' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string i in A)
                    {
                        error_nuevo += i;
                    }
                    connection.OpenConnection();
                    connection.InsertarRegistro("insert into bitacora(id_usuario,fecha_bitacora,hora_bitacora,accion_usuario,id_aplicacion,resultado_bitacora,error_bitacora,ip_pc) values((select U.id_usuario from usuario U where U.usuario ='" + Globales.nom_usuario + "'), sysdate(), now(), '" + Globales.sAccionG + "', '" + app + "','" + Globales.sExitoso_n + "', '" + error_nuevo + "','" + localIP + "')");
                    connection.CloseConnection();
                }
            }

        }

        private void Dgv_asignacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Globales.nom_apli = Dgv_asignacion.CurrentCell.Value.ToString();

            //MessageBox.Show(Globales.nom_apli);
            //MessageBox.Show(Globales.nom_usuario);
            this.Hide();
            Frm_MantenimientoApp mant_pp = new Frm_MantenimientoApp();
            
            mant_pp.Cmb_user.Text = Globales.nom_usuario.ToString();
            mant_pp.Cmb_aplicacion.Text = Globales.nom_apli.ToString();

            mant_pp.Show();

        }
    }
}