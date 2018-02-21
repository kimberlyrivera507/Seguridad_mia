namespace Perfiles_usuario
{
    partial class PerfilesUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilesUsuario));
            this.Cmb_id = new System.Windows.Forms.ComboBox();
            this.Cmb_usuario = new System.Windows.Forms.ComboBox();
            this.Dgv_perfil = new System.Windows.Forms.DataGridView();
            this.Dgv_asignacion = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aplicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_soloapp = new System.Windows.Forms.DataGridView();
            this.Lbl_aplicaciones = new System.Windows.Forms.Label();
            this.Lbl_perfiles = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Btn_edit = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_removerTodo = new System.Windows.Forms.Button();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.Btn_agregarTodo = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.chb_perfiles = new System.Windows.Forms.CheckBox();
            this.chb_apli = new System.Windows.Forms.CheckBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_soloapp)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_id
            // 
            this.Cmb_id.FormattingEnabled = true;
            this.Cmb_id.Location = new System.Drawing.Point(103, 57);
            this.Cmb_id.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_id.Name = "Cmb_id";
            this.Cmb_id.Size = new System.Drawing.Size(107, 24);
            this.Cmb_id.TabIndex = 0;
            this.Cmb_id.SelectedIndexChanged += new System.EventHandler(this.Cmb_id_SelectedIndexChanged);
            this.Cmb_id.SelectedValueChanged += new System.EventHandler(this.llenarusuario);
            this.Cmb_id.MouseClick += new System.Windows.Forms.MouseEventHandler(this.llenar);
            // 
            // Cmb_usuario
            // 
            this.Cmb_usuario.FormattingEnabled = true;
            this.Cmb_usuario.Location = new System.Drawing.Point(329, 57);
            this.Cmb_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_usuario.Name = "Cmb_usuario";
            this.Cmb_usuario.Size = new System.Drawing.Size(341, 24);
            this.Cmb_usuario.TabIndex = 1;
            this.Cmb_usuario.SelectedValueChanged += new System.EventHandler(this.llenarid);
            // 
            // Dgv_perfil
            // 
            this.Dgv_perfil.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.Dgv_perfil.AllowUserToAddRows = false;
            this.Dgv_perfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_perfil.Location = new System.Drawing.Point(16, 193);
            this.Dgv_perfil.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_perfil.MultiSelect = false;
            this.Dgv_perfil.Name = "Dgv_perfil";
            this.Dgv_perfil.Size = new System.Drawing.Size(320, 185);
            this.Dgv_perfil.TabIndex = 3;
            this.Dgv_perfil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aplicacion);
            // 
            // Dgv_asignacion
            // 
            this.Dgv_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Aplicaciones});
            this.Dgv_asignacion.Location = new System.Drawing.Point(481, 132);
            this.Dgv_asignacion.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_asignacion.Name = "Dgv_asignacion";
            this.Dgv_asignacion.Size = new System.Drawing.Size(287, 290);
            this.Dgv_asignacion.TabIndex = 10;
            this.Dgv_asignacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asignacion_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Aplicaciones
            // 
            this.Aplicaciones.HeaderText = "Aplicaciones";
            this.Aplicaciones.Name = "Aplicaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario";
            // 
            // Dgv_soloapp
            // 
            this.Dgv_soloapp.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.Dgv_soloapp.AllowUserToAddRows = false;
            this.Dgv_soloapp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_soloapp.Location = new System.Drawing.Point(16, 433);
            this.Dgv_soloapp.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_soloapp.MultiSelect = false;
            this.Dgv_soloapp.Name = "Dgv_soloapp";
            this.Dgv_soloapp.Size = new System.Drawing.Size(320, 185);
            this.Dgv_soloapp.TabIndex = 15;
            this.Dgv_soloapp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_soloapp_CellContentClick);
            // 
            // Lbl_aplicaciones
            // 
            this.Lbl_aplicaciones.AutoSize = true;
            this.Lbl_aplicaciones.Location = new System.Drawing.Point(13, 405);
            this.Lbl_aplicaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_aplicaciones.Name = "Lbl_aplicaciones";
            this.Lbl_aplicaciones.Size = new System.Drawing.Size(87, 17);
            this.Lbl_aplicaciones.TabIndex = 16;
            this.Lbl_aplicaciones.Text = "Aplicaciones";
            // 
            // Lbl_perfiles
            // 
            this.Lbl_perfiles.AutoSize = true;
            this.Lbl_perfiles.Location = new System.Drawing.Point(13, 156);
            this.Lbl_perfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_perfiles.Name = "Lbl_perfiles";
            this.Lbl_perfiles.Size = new System.Drawing.Size(55, 17);
            this.Lbl_perfiles.TabIndex = 17;
            this.Lbl_perfiles.Text = "Perfiles";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(650, 534);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 27);
            this.label6.TabIndex = 25;
            this.label6.Text = "Limpiar Perfil";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Lbl_editar
            // 
            this.Lbl_editar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_editar.Location = new System.Drawing.Point(521, 534);
            this.Lbl_editar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_editar.Name = "Lbl_editar";
            this.Lbl_editar.Size = new System.Drawing.Size(87, 27);
            this.Lbl_editar.TabIndex = 23;
            this.Lbl_editar.Text = "Editar";
            this.Lbl_editar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_edit
            // 
            this.Btn_edit.FlatAppearance.BorderSize = 0;
            this.Btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_edit.Image")));
            this.Btn_edit.Location = new System.Drawing.Point(521, 450);
            this.Btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(87, 80);
            this.Btn_edit.TabIndex = 24;
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.FlatAppearance.BorderSize = 0;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.Location = new System.Drawing.Point(652, 450);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(85, 71);
            this.Btn_borrar.TabIndex = 22;
            this.Btn_borrar.UseVisualStyleBackColor = true;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_removerTodo
            // 
            this.Btn_removerTodo.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22264625_1723360751031984_1344209642_n;
            this.Btn_removerTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_removerTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_removerTodo.Location = new System.Drawing.Point(374, 290);
            this.Btn_removerTodo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_removerTodo.Name = "Btn_removerTodo";
            this.Btn_removerTodo.Size = new System.Drawing.Size(67, 53);
            this.Btn_removerTodo.TabIndex = 9;
            this.Btn_removerTodo.UseVisualStyleBackColor = true;
            this.Btn_removerTodo.Click += new System.EventHandler(this.Btn_removerTodo_Click);
            // 
            // Btn_remover
            // 
            this.Btn_remover.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22264596_1723360747698651_173196365_n;
            this.Btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_remover.Location = new System.Drawing.Point(374, 241);
            this.Btn_remover.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(67, 41);
            this.Btn_remover.TabIndex = 8;
            this.Btn_remover.UseVisualStyleBackColor = true;
            this.Btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // Btn_agregarTodo
            // 
            this.Btn_agregarTodo.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22264602_1723360754365317_1757528147_n;
            this.Btn_agregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_agregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_agregarTodo.Location = new System.Drawing.Point(374, 180);
            this.Btn_agregarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_agregarTodo.Name = "Btn_agregarTodo";
            this.Btn_agregarTodo.Size = new System.Drawing.Size(67, 53);
            this.Btn_agregarTodo.TabIndex = 7;
            this.Btn_agregarTodo.UseVisualStyleBackColor = true;
            this.Btn_agregarTodo.Click += new System.EventHandler(this.Btn_agregarTodo_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackgroundImage = global::PrototipoSeguridad.Properties.Resources._22236267_1723360744365318_2094413666_n;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_agregar.Location = new System.Drawing.Point(374, 132);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(67, 41);
            this.Btn_agregar.TabIndex = 6;
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // chb_perfiles
            // 
            this.chb_perfiles.AutoSize = true;
            this.chb_perfiles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_perfiles.Location = new System.Drawing.Point(46, 113);
            this.chb_perfiles.Name = "chb_perfiles";
            this.chb_perfiles.Size = new System.Drawing.Size(77, 21);
            this.chb_perfiles.TabIndex = 26;
            this.chb_perfiles.Text = "Perfiles";
            this.chb_perfiles.UseVisualStyleBackColor = true;
            this.chb_perfiles.CheckedChanged += new System.EventHandler(this.chb_perfiles_CheckedChanged);
            // 
            // chb_apli
            // 
            this.chb_apli.AutoSize = true;
            this.chb_apli.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_apli.Location = new System.Drawing.Point(201, 113);
            this.chb_apli.Name = "chb_apli";
            this.chb_apli.Size = new System.Drawing.Size(109, 21);
            this.chb_apli.TabIndex = 27;
            this.chb_apli.Text = "Aplicaciones";
            this.chb_apli.UseVisualStyleBackColor = true;
            this.chb_apli.CheckedChanged += new System.EventHandler(this.chb_apli_CheckedChanged);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(391, 450);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(87, 80);
            this.Btn_Guardar.TabIndex = 29;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 534);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Guardar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PerfilesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(806, 631);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chb_apli);
            this.Controls.Add(this.chb_perfiles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_edit);
            this.Controls.Add(this.Lbl_editar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Lbl_perfiles);
            this.Controls.Add(this.Lbl_aplicaciones);
            this.Controls.Add(this.Dgv_soloapp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_asignacion);
            this.Controls.Add(this.Btn_removerTodo);
            this.Controls.Add(this.Btn_remover);
            this.Controls.Add(this.Btn_agregarTodo);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Dgv_perfil);
            this.Controls.Add(this.Cmb_usuario);
            this.Controls.Add(this.Cmb_id);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerfilesUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion Perfil Usuarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_soloapp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_id;
        private System.Windows.Forms.ComboBox Cmb_usuario;
        private System.Windows.Forms.DataGridView Dgv_perfil;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_agregarTodo;
        private System.Windows.Forms.Button Btn_remover;
        private System.Windows.Forms.Button Btn_removerTodo;
        private System.Windows.Forms.DataGridView Dgv_asignacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_soloapp;
        private System.Windows.Forms.Label Lbl_aplicaciones;
        private System.Windows.Forms.Label Lbl_perfiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.Label Lbl_editar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aplicaciones;
        private System.Windows.Forms.CheckBox chb_perfiles;
        private System.Windows.Forms.CheckBox chb_apli;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label3;
    }
}

