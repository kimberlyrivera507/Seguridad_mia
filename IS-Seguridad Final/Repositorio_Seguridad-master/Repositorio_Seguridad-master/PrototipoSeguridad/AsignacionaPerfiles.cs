using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Odbc;
using System.Net;
using System.Windows.Forms;


namespace PrototipoSeguridad
{
    public partial class AsignacionaPerfiles : Form
    { string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ";

        public AsignacionaPerfiles()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            this.dataGridView2.Columns[0].Visible = false;
            
            try
            {
               
                //Display query  
                string Query = "select * from bd_seguridad.aplicacion ;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }
            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ; Database=bd_seguridad; ");
            conector.Open();
           
           
            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT * from bd_seguridad.perfil";

                OdbcDataAdapter da1 = new OdbcDataAdapter(sentencia);
                DataTable dt = new DataTable();
                da1.Fill(dt);


                comboBox1.ValueMember = "nombre_perfil";
                comboBox1.DisplayMember = "nombre_perfil";
               
                comboBox1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
               // MessageBox.Show("no encntrado. " + ex);
            }
            finally
            {
                conector.Close();
            }
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           /* int selectedIndex = comboBox1.SelectedIndex;







            string sql = "SELECT nombre_perfil from bd_seguridad.perfil where '" + selectedIndex.ToString() + "' = perfil.id_perfil; ";
            OdbcConnection conn = new OdbcConnection();
            conn = new OdbcConnection(MyConnection2);
            conn.Open();

            OdbcCommand cmd = new OdbcCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(selectedIndex.ToString()));
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["nombre_perfil"].ToString();
                

            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Add(new string[] {
                 Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value)
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int counter = 0; counter < (dataGridView1.Rows.Count)-1;
         counter++)
            {
                dataGridView2.Rows.Add(new string[] {
                     Convert.ToString(dataGridView1[0, counter].Value),
                Convert.ToString(dataGridView1[1, counter].Value)
            });
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsignacionaPerfiles p1 = new AsignacionaPerfiles();
            p1.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            try
            {
                string Query = "delete from  bd_seguridad.detalle_perfil_aplicacion where id_perfil='" + selectedIndex.ToString() + "';";
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
              //  MessageBox.Show(ex.Message);
            }
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            Globales.nom_apli = dataGridView2.CurrentCell.Value.ToString();

            //MessageBox.Show(Globales.nom_apli);
            //MessageBox.Show(Globales.nom_usuario);
            this.Hide();
            Frm_MantenimientoApp mant_pp = new Frm_MantenimientoApp();
            
            mant_pp.Cmb_user.Text = Globales.nom_usuario.ToString();
            mant_pp.Cmb_aplicacion.Text = Globales.nom_apli.ToString();

            mant_pp.Show();

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        String DatoSeleccionado;

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            
            String error_nuevo = ""; obtenerIP();
            String app = "3";
            DatoSeleccionado = comboBox1.Text;
         //   MessageBox.Show("Es el perfil "+DatoSeleccionado);
            
            for (int fila = 0; fila < dataGridView2.Rows.Count - 1; fila++)
            {
                    string valor = dataGridView2.Rows[fila].Cells[0].Value.ToString();
                  //  MessageBox.Show("ID de la tabla "+valor);


                    try
                    {
                        string Query = "insert into bd_seguridad.detalle_perfil_aplicacion(id_perfil,id_aplicacion) values((select id_perfil from perfil where nombre_perfil ='" + DatoSeleccionado + "'),'" + Convert.ToString(dataGridView2[0, fila].Value) + "');";
                        OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                        OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                        OdbcDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                       // MessageBox.Show("Save Data");
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

        private void Lbl_editar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Globales.nom_apli = dataGridView2.CurrentCell.Value.ToString();

                //MessageBox.Show(Globales.nom_apli);
                //MessageBox.Show(Globales.nom_usuario);
                this.Hide();
                Frm_MantenimientoApp mant_pp = new Frm_MantenimientoApp();

            mant_pp.Cmb_user.ValueMember = Globales.nom_usuario;
            mant_pp.Cmb_aplicacion.ValueMember = Globales.nom_apli;



            mant_pp.Cmb_user.DisplayMember = Globales.nom_usuario;
            mant_pp.Cmb_aplicacion.DisplayMember = Globales.nom_apli;
            
            mant_pp.Cmb_user.Text = Globales.nom_usuario.ToString();
                mant_pp.Cmb_aplicacion.Text = Globales.nom_apli.ToString();

                mant_pp.Show();
            
            
        }
    }
}



