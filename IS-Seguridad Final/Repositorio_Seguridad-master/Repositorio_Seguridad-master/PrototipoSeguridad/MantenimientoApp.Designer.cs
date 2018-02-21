namespace PrototipoSeguridad
{
    partial class Frm_MantenimientoApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantenimientoApp));
            this.Pnl_botones = new System.Windows.Forms.Panel();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_edit = new System.Windows.Forms.Button();
            this.Lbl_borrar = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Lbl_ingresar = new System.Windows.Forms.Label();
            this.Btn_ultimoElemento = new System.Windows.Forms.Button();
            this.Btn_primerElemento = new System.Windows.Forms.Button();
            this.Btn_siguiente = new System.Windows.Forms.Button();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Lbl_cancelar = new System.Windows.Forms.Label();
            this.Lbl_salir = new System.Windows.Forms.Label();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Lbl_aplicacion = new System.Windows.Forms.Label();
            this.Txt_user = new System.Windows.Forms.TextBox();
            this.Txt_aplicacion = new System.Windows.Forms.TextBox();
            this.Pnl_derechos = new System.Windows.Forms.Panel();
            this.Chb_consultar = new System.Windows.Forms.CheckBox();
            this.Chb_imprimir = new System.Windows.Forms.CheckBox();
            this.Chb_eliminar = new System.Windows.Forms.CheckBox();
            this.Chb_editar = new System.Windows.Forms.CheckBox();
            this.Chb_insertar = new System.Windows.Forms.CheckBox();
            this.Lbl_tituloDerechos = new System.Windows.Forms.Label();
            this.Cmb_aplicacion = new System.Windows.Forms.ComboBox();
            this.Picb_aceptar = new System.Windows.Forms.PictureBox();
            this.Cmb_user = new System.Windows.Forms.ComboBox();
            this.Pnl_botones.SuspendLayout();
            this.Pnl_derechos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picb_aceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_botones
            // 
            this.Pnl_botones.BackColor = System.Drawing.Color.LightBlue;
            this.Pnl_botones.Controls.Add(this.Btn_borrar);
            this.Pnl_botones.Controls.Add(this.Btn_edit);
            this.Pnl_botones.Controls.Add(this.Lbl_borrar);
            this.Pnl_botones.Controls.Add(this.Lbl_editar);
            this.Pnl_botones.Controls.Add(this.Lbl_guardar);
            this.Pnl_botones.Controls.Add(this.Btn_Guardar);
            this.Pnl_botones.Controls.Add(this.Btn_ingresar);
            this.Pnl_botones.Controls.Add(this.Lbl_ingresar);
            this.Pnl_botones.Location = new System.Drawing.Point(228, 31);
            this.Pnl_botones.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_botones.Name = "Pnl_botones";
            this.Pnl_botones.Size = new System.Drawing.Size(385, 118);
            this.Pnl_botones.TabIndex = 0;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.FlatAppearance.BorderSize = 0;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.Location = new System.Drawing.Point(191, 4);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(87, 80);
            this.Btn_borrar.TabIndex = 16;
            this.Btn_borrar.UseVisualStyleBackColor = true;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_edit
            // 
            this.Btn_edit.FlatAppearance.BorderSize = 0;
            this.Btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_edit.Image")));
            this.Btn_edit.Location = new System.Drawing.Point(103, 4);
            this.Btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(87, 80);
            this.Btn_edit.TabIndex = 13;
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Lbl_borrar
            // 
            this.Lbl_borrar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_borrar.Location = new System.Drawing.Point(191, 87);
            this.Lbl_borrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_borrar.Name = "Lbl_borrar";
            this.Lbl_borrar.Size = new System.Drawing.Size(87, 27);
            this.Lbl_borrar.TabIndex = 10;
            this.Lbl_borrar.Text = "Borrar";
            this.Lbl_borrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_editar
            // 
            this.Lbl_editar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_editar.Location = new System.Drawing.Point(99, 87);
            this.Lbl_editar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_editar.Name = "Lbl_editar";
            this.Lbl_editar.Size = new System.Drawing.Size(87, 27);
            this.Lbl_editar.TabIndex = 7;
            this.Lbl_editar.Text = "Editar";
            this.Lbl_editar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_guardar
            // 
            this.Lbl_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_guardar.Location = new System.Drawing.Point(4, 87);
            this.Lbl_guardar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_guardar.Name = "Lbl_guardar";
            this.Lbl_guardar.Size = new System.Drawing.Size(87, 27);
            this.Lbl_guardar.TabIndex = 1;
            this.Lbl_guardar.Text = "Guardar";
            this.Lbl_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(4, 4);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(87, 80);
            this.Btn_Guardar.TabIndex = 0;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.FlatAppearance.BorderSize = 0;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.Location = new System.Drawing.Point(280, 4);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(87, 80);
            this.Btn_ingresar.TabIndex = 14;
            this.Btn_ingresar.UseVisualStyleBackColor = true;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Lbl_ingresar
            // 
            this.Lbl_ingresar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ingresar.Location = new System.Drawing.Point(281, 86);
            this.Lbl_ingresar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ingresar.Name = "Lbl_ingresar";
            this.Lbl_ingresar.Size = new System.Drawing.Size(87, 27);
            this.Lbl_ingresar.TabIndex = 8;
            this.Lbl_ingresar.Text = "Ingresar";
            this.Lbl_ingresar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_ultimoElemento
            // 
            this.Btn_ultimoElemento.FlatAppearance.BorderSize = 0;
            this.Btn_ultimoElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ultimoElemento.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ultimoElemento.Image")));
            this.Btn_ultimoElemento.Location = new System.Drawing.Point(101, 452);
            this.Btn_ultimoElemento.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ultimoElemento.Name = "Btn_ultimoElemento";
            this.Btn_ultimoElemento.Size = new System.Drawing.Size(73, 39);
            this.Btn_ultimoElemento.TabIndex = 22;
            this.Btn_ultimoElemento.UseVisualStyleBackColor = true;
            this.Btn_ultimoElemento.Visible = false;
            this.Btn_ultimoElemento.Click += new System.EventHandler(this.Btn_ultimoElemento_Click);
            // 
            // Btn_primerElemento
            // 
            this.Btn_primerElemento.FlatAppearance.BorderSize = 0;
            this.Btn_primerElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_primerElemento.Image = ((System.Drawing.Image)(resources.GetObject("Btn_primerElemento.Image")));
            this.Btn_primerElemento.Location = new System.Drawing.Point(20, 452);
            this.Btn_primerElemento.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_primerElemento.Name = "Btn_primerElemento";
            this.Btn_primerElemento.Size = new System.Drawing.Size(73, 39);
            this.Btn_primerElemento.TabIndex = 21;
            this.Btn_primerElemento.UseVisualStyleBackColor = true;
            this.Btn_primerElemento.Visible = false;
            this.Btn_primerElemento.Click += new System.EventHandler(this.Btn_primerElemento_Click);
            // 
            // Btn_siguiente
            // 
            this.Btn_siguiente.FlatAppearance.BorderSize = 0;
            this.Btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_siguiente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_siguiente.Image")));
            this.Btn_siguiente.Location = new System.Drawing.Point(101, 484);
            this.Btn_siguiente.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_siguiente.Name = "Btn_siguiente";
            this.Btn_siguiente.Size = new System.Drawing.Size(73, 39);
            this.Btn_siguiente.TabIndex = 20;
            this.Btn_siguiente.UseVisualStyleBackColor = true;
            this.Btn_siguiente.Visible = false;
            this.Btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.FlatAppearance.BorderSize = 0;
            this.Btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(20, 484);
            this.Btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(73, 39);
            this.Btn_anterior.TabIndex = 19;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            this.Btn_anterior.Visible = false;
            this.Btn_anterior.Click += new System.EventHandler(this.Btn_anterior_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(724, 432);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(87, 80);
            this.Btn_salir.TabIndex = 18;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Visible = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(629, 432);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(87, 80);
            this.Btn_cancelar.TabIndex = 15;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Lbl_cancelar
            // 
            this.Lbl_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cancelar.Location = new System.Drawing.Point(629, 516);
            this.Lbl_cancelar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_cancelar.Name = "Lbl_cancelar";
            this.Lbl_cancelar.Size = new System.Drawing.Size(87, 27);
            this.Lbl_cancelar.TabIndex = 9;
            this.Lbl_cancelar.Text = "Cancelar";
            this.Lbl_cancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_cancelar.Visible = false;
            // 
            // Lbl_salir
            // 
            this.Lbl_salir.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_salir.Location = new System.Drawing.Point(724, 516);
            this.Lbl_salir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_salir.Name = "Lbl_salir";
            this.Lbl_salir.Size = new System.Drawing.Size(87, 27);
            this.Lbl_salir.TabIndex = 12;
            this.Lbl_salir.Text = "Salir";
            this.Lbl_salir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_salir.Visible = false;
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_usuario.Location = new System.Drawing.Point(88, 226);
            this.Lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(100, 25);
            this.Lbl_usuario.TabIndex = 2;
            this.Lbl_usuario.Text = "Usuario";
            this.Lbl_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_aplicacion
            // 
            this.Lbl_aplicacion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Lbl_aplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_aplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_aplicacion.Location = new System.Drawing.Point(496, 225);
            this.Lbl_aplicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_aplicacion.Name = "Lbl_aplicacion";
            this.Lbl_aplicacion.Size = new System.Drawing.Size(117, 25);
            this.Lbl_aplicacion.TabIndex = 3;
            this.Lbl_aplicacion.Text = "Aplicacion";
            this.Lbl_aplicacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_user
            // 
            this.Txt_user.Enabled = false;
            this.Txt_user.Location = new System.Drawing.Point(11, 530);
            this.Txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_user.Name = "Txt_user";
            this.Txt_user.Size = new System.Drawing.Size(173, 22);
            this.Txt_user.TabIndex = 4;
            this.Txt_user.Visible = false;
            // 
            // Txt_aplicacion
            // 
            this.Txt_aplicacion.Enabled = false;
            this.Txt_aplicacion.Location = new System.Drawing.Point(613, 225);
            this.Txt_aplicacion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_aplicacion.Name = "Txt_aplicacion";
            this.Txt_aplicacion.Size = new System.Drawing.Size(173, 22);
            this.Txt_aplicacion.TabIndex = 5;
            // 
            // Pnl_derechos
            // 
            this.Pnl_derechos.BackColor = System.Drawing.Color.PowderBlue;
            this.Pnl_derechos.Controls.Add(this.Chb_consultar);
            this.Pnl_derechos.Controls.Add(this.Chb_imprimir);
            this.Pnl_derechos.Controls.Add(this.Chb_eliminar);
            this.Pnl_derechos.Controls.Add(this.Chb_editar);
            this.Pnl_derechos.Controls.Add(this.Chb_insertar);
            this.Pnl_derechos.Controls.Add(this.Lbl_tituloDerechos);
            this.Pnl_derechos.Location = new System.Drawing.Point(220, 304);
            this.Pnl_derechos.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_derechos.Name = "Pnl_derechos";
            this.Pnl_derechos.Size = new System.Drawing.Size(369, 218);
            this.Pnl_derechos.TabIndex = 8;
            // 
            // Chb_consultar
            // 
            this.Chb_consultar.Enabled = false;
            this.Chb_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_consultar.Location = new System.Drawing.Point(24, 171);
            this.Chb_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.Chb_consultar.Name = "Chb_consultar";
            this.Chb_consultar.Size = new System.Drawing.Size(152, 36);
            this.Chb_consultar.TabIndex = 15;
            this.Chb_consultar.Text = "Consultar";
            this.Chb_consultar.UseVisualStyleBackColor = true;
            // 
            // Chb_imprimir
            // 
            this.Chb_imprimir.Enabled = false;
            this.Chb_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_imprimir.Location = new System.Drawing.Point(192, 114);
            this.Chb_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.Chb_imprimir.Name = "Chb_imprimir";
            this.Chb_imprimir.Size = new System.Drawing.Size(152, 36);
            this.Chb_imprimir.TabIndex = 14;
            this.Chb_imprimir.Text = "Imprimir";
            this.Chb_imprimir.UseVisualStyleBackColor = true;
            this.Chb_imprimir.CheckedChanged += new System.EventHandler(this.Chb_imprimir_CheckedChanged);
            // 
            // Chb_eliminar
            // 
            this.Chb_eliminar.Enabled = false;
            this.Chb_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_eliminar.Location = new System.Drawing.Point(24, 112);
            this.Chb_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Chb_eliminar.Name = "Chb_eliminar";
            this.Chb_eliminar.Size = new System.Drawing.Size(152, 39);
            this.Chb_eliminar.TabIndex = 13;
            this.Chb_eliminar.Text = "Eliminar";
            this.Chb_eliminar.UseVisualStyleBackColor = true;
            this.Chb_eliminar.CheckedChanged += new System.EventHandler(this.Chb_eliminar_CheckedChanged);
            // 
            // Chb_editar
            // 
            this.Chb_editar.Enabled = false;
            this.Chb_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_editar.Location = new System.Drawing.Point(192, 46);
            this.Chb_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Chb_editar.Name = "Chb_editar";
            this.Chb_editar.Size = new System.Drawing.Size(152, 39);
            this.Chb_editar.TabIndex = 12;
            this.Chb_editar.Text = "Editar";
            this.Chb_editar.UseVisualStyleBackColor = true;
            this.Chb_editar.CheckedChanged += new System.EventHandler(this.Chb_editar_CheckedChanged);
            // 
            // Chb_insertar
            // 
            this.Chb_insertar.Enabled = false;
            this.Chb_insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_insertar.Location = new System.Drawing.Point(24, 46);
            this.Chb_insertar.Margin = new System.Windows.Forms.Padding(4);
            this.Chb_insertar.Name = "Chb_insertar";
            this.Chb_insertar.Size = new System.Drawing.Size(152, 39);
            this.Chb_insertar.TabIndex = 11;
            this.Chb_insertar.Text = "Insertar";
            this.Chb_insertar.UseVisualStyleBackColor = true;
            this.Chb_insertar.CheckedChanged += new System.EventHandler(this.Chb_insertar_CheckedChanged);
            // 
            // Lbl_tituloDerechos
            // 
            this.Lbl_tituloDerechos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Lbl_tituloDerechos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tituloDerechos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_tituloDerechos.Location = new System.Drawing.Point(0, 0);
            this.Lbl_tituloDerechos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tituloDerechos.Name = "Lbl_tituloDerechos";
            this.Lbl_tituloDerechos.Size = new System.Drawing.Size(369, 25);
            this.Lbl_tituloDerechos.TabIndex = 10;
            this.Lbl_tituloDerechos.Text = "Derechos";
            this.Lbl_tituloDerechos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cmb_aplicacion
            // 
            this.Cmb_aplicacion.FormattingEnabled = true;
            this.Cmb_aplicacion.Location = new System.Drawing.Point(613, 224);
            this.Cmb_aplicacion.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_aplicacion.Name = "Cmb_aplicacion";
            this.Cmb_aplicacion.Size = new System.Drawing.Size(173, 24);
            this.Cmb_aplicacion.TabIndex = 10;
            this.Cmb_aplicacion.SelectedIndexChanged += new System.EventHandler(this.Cmb_aplicacion_SelectedIndexChanged);
            // 
            // Picb_aceptar
            // 
            this.Picb_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Picb_aceptar.Image")));
            this.Picb_aceptar.Location = new System.Drawing.Point(47, 220);
            this.Picb_aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Picb_aceptar.Name = "Picb_aceptar";
            this.Picb_aceptar.Size = new System.Drawing.Size(33, 31);
            this.Picb_aceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picb_aceptar.TabIndex = 11;
            this.Picb_aceptar.TabStop = false;
            this.Picb_aceptar.Visible = false;
            // 
            // Cmb_user
            // 
            this.Cmb_user.FormattingEnabled = true;
            this.Cmb_user.Location = new System.Drawing.Point(184, 226);
            this.Cmb_user.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_user.Name = "Cmb_user";
            this.Cmb_user.Size = new System.Drawing.Size(173, 24);
            this.Cmb_user.TabIndex = 23;
            this.Cmb_user.SelectedIndexChanged += new System.EventHandler(this.Cmb_user_SelectedIndexChanged);
            // 
            // Frm_MantenimientoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(827, 574);
            this.Controls.Add(this.Cmb_user);
            this.Controls.Add(this.Btn_ultimoElemento);
            this.Controls.Add(this.Btn_primerElemento);
            this.Controls.Add(this.Picb_aceptar);
            this.Controls.Add(this.Btn_siguiente);
            this.Controls.Add(this.Cmb_aplicacion);
            this.Controls.Add(this.Btn_anterior);
            this.Controls.Add(this.Pnl_derechos);
            this.Controls.Add(this.Txt_aplicacion);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Txt_user);
            this.Controls.Add(this.Lbl_cancelar);
            this.Controls.Add(this.Lbl_aplicacion);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Pnl_botones);
            this.Controls.Add(this.Lbl_salir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MantenimientoApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Derechos Aplicaciones de Usuarios";
            this.Load += new System.EventHandler(this.Frm_MantenimientoApp_Load);
            this.Pnl_botones.ResumeLayout(false);
            this.Pnl_derechos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picb_aceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_botones;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label Lbl_salir;
        private System.Windows.Forms.Label Lbl_borrar;
        private System.Windows.Forms.Label Lbl_cancelar;
        private System.Windows.Forms.Label Lbl_ingresar;
        private System.Windows.Forms.Label Lbl_editar;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.Label Lbl_aplicacion;
        private System.Windows.Forms.TextBox Txt_user;
        private System.Windows.Forms.TextBox Txt_aplicacion;
        private System.Windows.Forms.Panel Pnl_derechos;
        private System.Windows.Forms.Label Lbl_tituloDerechos;
        private System.Windows.Forms.CheckBox Chb_imprimir;
        private System.Windows.Forms.CheckBox Chb_eliminar;
        private System.Windows.Forms.CheckBox Chb_editar;
        private System.Windows.Forms.CheckBox Chb_insertar;
        private System.Windows.Forms.Button Btn_ultimoElemento;
        private System.Windows.Forms.Button Btn_primerElemento;
        private System.Windows.Forms.Button Btn_siguiente;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.CheckBox Chb_consultar;
        private System.Windows.Forms.PictureBox Picb_aceptar;
        public System.Windows.Forms.ComboBox Cmb_aplicacion;
        public System.Windows.Forms.ComboBox Cmb_user;
    }
}


