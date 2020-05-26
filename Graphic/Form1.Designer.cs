namespace Graphic
{
    partial class lab_grafico
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_archivo_intermedio = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instruccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_obj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asm_code = new System.Windows.Forms.RichTextBox();
            this.dgv_tabsim = new System.Windows.Forms.DataGridView();
            this.simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errores = new System.Windows.Forms.TextBox();
            this.text_programa_objeto = new System.Windows.Forms.TextBox();
            this.label_code = new System.Windows.Forms.Label();
            this.label_archivo_intermedio = new System.Windows.Forms.Label();
            this.label_tabsim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_codigo_objeto = new System.Windows.Forms.Label();
            this.ensamblar = new System.Windows.Forms.Button();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tab_ensamblador = new System.Windows.Forms.TabPage();
            this.tab_cargador = new System.Windows.Forms.TabPage();
            this.boton_cerrar_programa = new System.Windows.Forms.Button();
            this.label_instrucciones = new System.Windows.Forms.Label();
            this.numeric_instrucciones = new System.Windows.Forms.NumericUpDown();
            this.boton_ejecutar = new System.Windows.Forms.Button();
            this.registro_SW = new System.Windows.Forms.Label();
            this.registro_L = new System.Windows.Forms.Label();
            this.registro_X = new System.Windows.Forms.Label();
            this.registro_A = new System.Windows.Forms.Label();
            this.registro_CP = new System.Windows.Forms.Label();
            this.texto_registro_sw = new System.Windows.Forms.Label();
            this.texto_registro_l = new System.Windows.Forms.Label();
            this.texto_registro_x = new System.Windows.Forms.Label();
            this.texto_registro_a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texto_valores = new System.Windows.Forms.Label();
            this.texto_registros = new System.Windows.Forms.Label();
            this.label_tam_programa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_direccion_carga = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_cargar = new System.Windows.Forms.Button();
            this.dgv_cargador = new System.Windows.Forms.DataGridView();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dig_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.print_info = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.info_CP = new System.Windows.Forms.Label();
            this.info_bytes = new System.Windows.Forms.Label();
            this.info_codop = new System.Windows.Forms.Label();
            this.info_modo = new System.Windows.Forms.Label();
            this.info_direccion = new System.Windows.Forms.Label();
            this.info_sigCP = new System.Windows.Forms.Label();
            this.info_nemonico = new System.Windows.Forms.Label();
            this.info_efecto = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_archivo_intermedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabsim)).BeginInit();
            this.tab_control.SuspendLayout();
            this.tab_ensamblador.SuspendLayout();
            this.tab_cargador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_instrucciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargador)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // dgv_archivo_intermedio
            // 
            this.dgv_archivo_intermedio.AllowUserToAddRows = false;
            this.dgv_archivo_intermedio.AllowUserToDeleteRows = false;
            this.dgv_archivo_intermedio.AllowUserToResizeColumns = false;
            this.dgv_archivo_intermedio.AllowUserToResizeRows = false;
            this.dgv_archivo_intermedio.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_archivo_intermedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_archivo_intermedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.cp,
            this.etiqueta,
            this.instruccion,
            this.operando,
            this.cod_obj});
            this.dgv_archivo_intermedio.Location = new System.Drawing.Point(302, 57);
            this.dgv_archivo_intermedio.Name = "dgv_archivo_intermedio";
            this.dgv_archivo_intermedio.ReadOnly = true;
            this.dgv_archivo_intermedio.RowHeadersVisible = false;
            this.dgv_archivo_intermedio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_archivo_intermedio.ShowEditingIcon = false;
            this.dgv_archivo_intermedio.Size = new System.Drawing.Size(483, 509);
            this.dgv_archivo_intermedio.TabIndex = 1;
            // 
            // num
            // 
            this.num.HeaderText = "";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 30;
            // 
            // cp
            // 
            this.cp.HeaderText = "CP";
            this.cp.Name = "cp";
            this.cp.ReadOnly = true;
            this.cp.Width = 70;
            // 
            // etiqueta
            // 
            this.etiqueta.HeaderText = "Etiqueta";
            this.etiqueta.Name = "etiqueta";
            this.etiqueta.ReadOnly = true;
            this.etiqueta.Width = 90;
            // 
            // instruccion
            // 
            this.instruccion.HeaderText = "Instruccion";
            this.instruccion.Name = "instruccion";
            this.instruccion.ReadOnly = true;
            this.instruccion.Width = 90;
            // 
            // operando
            // 
            this.operando.HeaderText = "Operando";
            this.operando.Name = "operando";
            this.operando.ReadOnly = true;
            this.operando.Width = 90;
            // 
            // cod_obj
            // 
            this.cod_obj.HeaderText = "Código Objeto";
            this.cod_obj.Name = "cod_obj";
            this.cod_obj.ReadOnly = true;
            this.cod_obj.Width = 110;
            // 
            // asm_code
            // 
            this.asm_code.AcceptsTab = true;
            this.asm_code.DetectUrls = false;
            this.asm_code.Location = new System.Drawing.Point(3, 57);
            this.asm_code.Name = "asm_code";
            this.asm_code.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.asm_code.Size = new System.Drawing.Size(268, 509);
            this.asm_code.TabIndex = 2;
            this.asm_code.Text = "";
            // 
            // dgv_tabsim
            // 
            this.dgv_tabsim.AllowUserToAddRows = false;
            this.dgv_tabsim.AllowUserToDeleteRows = false;
            this.dgv_tabsim.AllowUserToResizeColumns = false;
            this.dgv_tabsim.AllowUserToResizeRows = false;
            this.dgv_tabsim.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_tabsim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_tabsim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.simbolo,
            this.direccion});
            this.dgv_tabsim.Location = new System.Drawing.Point(825, 57);
            this.dgv_tabsim.Name = "dgv_tabsim";
            this.dgv_tabsim.ReadOnly = true;
            this.dgv_tabsim.RowHeadersVisible = false;
            this.dgv_tabsim.Size = new System.Drawing.Size(184, 258);
            this.dgv_tabsim.TabIndex = 3;
            // 
            // simbolo
            // 
            this.simbolo.HeaderText = "Simbolo";
            this.simbolo.Name = "simbolo";
            this.simbolo.ReadOnly = true;
            this.simbolo.Width = 90;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 90;
            // 
            // errores
            // 
            this.errores.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.errores.Location = new System.Drawing.Point(1045, 57);
            this.errores.Multiline = true;
            this.errores.Name = "errores";
            this.errores.ReadOnly = true;
            this.errores.Size = new System.Drawing.Size(139, 258);
            this.errores.TabIndex = 4;
            // 
            // text_programa_objeto
            // 
            this.text_programa_objeto.AcceptsReturn = true;
            this.text_programa_objeto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.text_programa_objeto.Location = new System.Drawing.Point(825, 358);
            this.text_programa_objeto.Multiline = true;
            this.text_programa_objeto.Name = "text_programa_objeto";
            this.text_programa_objeto.ReadOnly = true;
            this.text_programa_objeto.Size = new System.Drawing.Size(359, 208);
            this.text_programa_objeto.TabIndex = 5;
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_code.Location = new System.Drawing.Point(3, 26);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(167, 20);
            this.label_code.TabIndex = 6;
            this.label_code.Text = "Código Ensamblador";
            // 
            // label_archivo_intermedio
            // 
            this.label_archivo_intermedio.AutoSize = true;
            this.label_archivo_intermedio.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_archivo_intermedio.Location = new System.Drawing.Point(298, 26);
            this.label_archivo_intermedio.Name = "label_archivo_intermedio";
            this.label_archivo_intermedio.Size = new System.Drawing.Size(153, 20);
            this.label_archivo_intermedio.TabIndex = 7;
            this.label_archivo_intermedio.Text = "Archivo intermedio";
            // 
            // label_tabsim
            // 
            this.label_tabsim.AutoSize = true;
            this.label_tabsim.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tabsim.Location = new System.Drawing.Point(821, 26);
            this.label_tabsim.Name = "label_tabsim";
            this.label_tabsim.Size = new System.Drawing.Size(146, 20);
            this.label_tabsim.TabIndex = 8;
            this.label_tabsim.Text = "Tabla de Símbolos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1047, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Errores";
            // 
            // label_codigo_objeto
            // 
            this.label_codigo_objeto.AutoSize = true;
            this.label_codigo_objeto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codigo_objeto.Location = new System.Drawing.Point(821, 335);
            this.label_codigo_objeto.Name = "label_codigo_objeto";
            this.label_codigo_objeto.Size = new System.Drawing.Size(120, 20);
            this.label_codigo_objeto.TabIndex = 10;
            this.label_codigo_objeto.Text = "Código Objeto";
            // 
            // ensamblar
            // 
            this.ensamblar.Location = new System.Drawing.Point(48, 577);
            this.ensamblar.Name = "ensamblar";
            this.ensamblar.Size = new System.Drawing.Size(162, 23);
            this.ensamblar.TabIndex = 11;
            this.ensamblar.Text = "Ensamblar";
            this.ensamblar.UseVisualStyleBackColor = true;
            this.ensamblar.Click += new System.EventHandler(this.ensamblar_Click);
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_ensamblador);
            this.tab_control.Controls.Add(this.tab_cargador);
            this.tab_control.Location = new System.Drawing.Point(0, 27);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1222, 633);
            this.tab_control.TabIndex = 12;
            this.tab_control.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tab_control_KeyDown);
            // 
            // tab_ensamblador
            // 
            this.tab_ensamblador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_ensamblador.Controls.Add(this.label_code);
            this.tab_ensamblador.Controls.Add(this.ensamblar);
            this.tab_ensamblador.Controls.Add(this.dgv_archivo_intermedio);
            this.tab_ensamblador.Controls.Add(this.label_codigo_objeto);
            this.tab_ensamblador.Controls.Add(this.asm_code);
            this.tab_ensamblador.Controls.Add(this.label2);
            this.tab_ensamblador.Controls.Add(this.dgv_tabsim);
            this.tab_ensamblador.Controls.Add(this.label_tabsim);
            this.tab_ensamblador.Controls.Add(this.errores);
            this.tab_ensamblador.Controls.Add(this.label_archivo_intermedio);
            this.tab_ensamblador.Controls.Add(this.text_programa_objeto);
            this.tab_ensamblador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tab_ensamblador.Location = new System.Drawing.Point(4, 22);
            this.tab_ensamblador.Name = "tab_ensamblador";
            this.tab_ensamblador.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ensamblador.Size = new System.Drawing.Size(1214, 607);
            this.tab_ensamblador.TabIndex = 0;
            this.tab_ensamblador.Text = "Ensamblador";
            // 
            // tab_cargador
            // 
            this.tab_cargador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_cargador.Controls.Add(this.print_info);
            this.tab_cargador.Controls.Add(this.info_efecto);
            this.tab_cargador.Controls.Add(this.boton_cerrar_programa);
            this.tab_cargador.Controls.Add(this.info_nemonico);
            this.tab_cargador.Controls.Add(this.info_sigCP);
            this.tab_cargador.Controls.Add(this.info_direccion);
            this.tab_cargador.Controls.Add(this.info_modo);
            this.tab_cargador.Controls.Add(this.info_codop);
            this.tab_cargador.Controls.Add(this.info_bytes);
            this.tab_cargador.Controls.Add(this.info_CP);
            this.tab_cargador.Controls.Add(this.label11);
            this.tab_cargador.Controls.Add(this.label10);
            this.tab_cargador.Controls.Add(this.label9);
            this.tab_cargador.Controls.Add(this.label8);
            this.tab_cargador.Controls.Add(this.label7);
            this.tab_cargador.Controls.Add(this.label6);
            this.tab_cargador.Controls.Add(this.label5);
            this.tab_cargador.Controls.Add(this.label_instrucciones);
            this.tab_cargador.Controls.Add(this.numeric_instrucciones);
            this.tab_cargador.Controls.Add(this.boton_ejecutar);
            this.tab_cargador.Controls.Add(this.registro_SW);
            this.tab_cargador.Controls.Add(this.registro_L);
            this.tab_cargador.Controls.Add(this.registro_X);
            this.tab_cargador.Controls.Add(this.registro_A);
            this.tab_cargador.Controls.Add(this.registro_CP);
            this.tab_cargador.Controls.Add(this.texto_registro_sw);
            this.tab_cargador.Controls.Add(this.texto_registro_l);
            this.tab_cargador.Controls.Add(this.texto_registro_x);
            this.tab_cargador.Controls.Add(this.texto_registro_a);
            this.tab_cargador.Controls.Add(this.label1);
            this.tab_cargador.Controls.Add(this.texto_valores);
            this.tab_cargador.Controls.Add(this.texto_registros);
            this.tab_cargador.Controls.Add(this.label_tam_programa);
            this.tab_cargador.Controls.Add(this.label4);
            this.tab_cargador.Controls.Add(this.label_direccion_carga);
            this.tab_cargador.Controls.Add(this.label3);
            this.tab_cargador.Controls.Add(this.boton_cargar);
            this.tab_cargador.Controls.Add(this.dgv_cargador);
            this.tab_cargador.Location = new System.Drawing.Point(4, 22);
            this.tab_cargador.Name = "tab_cargador";
            this.tab_cargador.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cargador.Size = new System.Drawing.Size(1214, 607);
            this.tab_cargador.TabIndex = 1;
            this.tab_cargador.Text = "Cargador";
            // 
            // boton_cerrar_programa
            // 
            this.boton_cerrar_programa.Location = new System.Drawing.Point(937, 26);
            this.boton_cerrar_programa.Name = "boton_cerrar_programa";
            this.boton_cerrar_programa.Size = new System.Drawing.Size(216, 23);
            this.boton_cerrar_programa.TabIndex = 41;
            this.boton_cerrar_programa.Text = "Cerrar Programa Objeto";
            this.boton_cerrar_programa.UseVisualStyleBackColor = true;
            this.boton_cerrar_programa.Click += new System.EventHandler(this.boton_cerrar_programa_Click);
            // 
            // label_instrucciones
            // 
            this.label_instrucciones.AutoSize = true;
            this.label_instrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_instrucciones.Location = new System.Drawing.Point(583, 404);
            this.label_instrucciones.Name = "label_instrucciones";
            this.label_instrucciones.Size = new System.Drawing.Size(79, 15);
            this.label_instrucciones.TabIndex = 25;
            this.label_instrucciones.Text = "Instrucciones";
            // 
            // numeric_instrucciones
            // 
            this.numeric_instrucciones.Location = new System.Drawing.Point(540, 402);
            this.numeric_instrucciones.Name = "numeric_instrucciones";
            this.numeric_instrucciones.Size = new System.Drawing.Size(37, 20);
            this.numeric_instrucciones.TabIndex = 24;
            this.numeric_instrucciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_instrucciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // boton_ejecutar
            // 
            this.boton_ejecutar.Location = new System.Drawing.Point(467, 401);
            this.boton_ejecutar.Name = "boton_ejecutar";
            this.boton_ejecutar.Size = new System.Drawing.Size(67, 23);
            this.boton_ejecutar.TabIndex = 23;
            this.boton_ejecutar.Text = "Ejecutar";
            this.boton_ejecutar.UseVisualStyleBackColor = true;
            this.boton_ejecutar.Click += new System.EventHandler(this.boton_ejecutar_Click);
            // 
            // registro_SW
            // 
            this.registro_SW.AutoSize = true;
            this.registro_SW.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_SW.Location = new System.Drawing.Point(217, 563);
            this.registro_SW.Name = "registro_SW";
            this.registro_SW.Size = new System.Drawing.Size(13, 18);
            this.registro_SW.TabIndex = 22;
            this.registro_SW.Text = "-";
            this.registro_SW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registro_L
            // 
            this.registro_L.AutoSize = true;
            this.registro_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_L.Location = new System.Drawing.Point(217, 533);
            this.registro_L.Name = "registro_L";
            this.registro_L.Size = new System.Drawing.Size(13, 18);
            this.registro_L.TabIndex = 21;
            this.registro_L.Text = "-";
            this.registro_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registro_X
            // 
            this.registro_X.AutoSize = true;
            this.registro_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_X.Location = new System.Drawing.Point(217, 503);
            this.registro_X.Name = "registro_X";
            this.registro_X.Size = new System.Drawing.Size(13, 18);
            this.registro_X.TabIndex = 20;
            this.registro_X.Text = "-";
            this.registro_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registro_A
            // 
            this.registro_A.AutoSize = true;
            this.registro_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_A.Location = new System.Drawing.Point(217, 470);
            this.registro_A.Name = "registro_A";
            this.registro_A.Size = new System.Drawing.Size(13, 18);
            this.registro_A.TabIndex = 19;
            this.registro_A.Text = "-";
            this.registro_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registro_CP
            // 
            this.registro_CP.AutoSize = true;
            this.registro_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_CP.Location = new System.Drawing.Point(217, 436);
            this.registro_CP.Name = "registro_CP";
            this.registro_CP.Size = new System.Drawing.Size(13, 18);
            this.registro_CP.TabIndex = 18;
            this.registro_CP.Text = "-";
            this.registro_CP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // texto_registro_sw
            // 
            this.texto_registro_sw.AutoSize = true;
            this.texto_registro_sw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_registro_sw.Location = new System.Drawing.Point(63, 563);
            this.texto_registro_sw.Name = "texto_registro_sw";
            this.texto_registro_sw.Size = new System.Drawing.Size(43, 18);
            this.texto_registro_sw.TabIndex = 17;
            this.texto_registro_sw.Text = "(SW)";
            // 
            // texto_registro_l
            // 
            this.texto_registro_l.AutoSize = true;
            this.texto_registro_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_registro_l.Location = new System.Drawing.Point(80, 533);
            this.texto_registro_l.Name = "texto_registro_l";
            this.texto_registro_l.Size = new System.Drawing.Size(26, 18);
            this.texto_registro_l.TabIndex = 16;
            this.texto_registro_l.Text = "(L)";
            // 
            // texto_registro_x
            // 
            this.texto_registro_x.AutoSize = true;
            this.texto_registro_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_registro_x.Location = new System.Drawing.Point(78, 503);
            this.texto_registro_x.Name = "texto_registro_x";
            this.texto_registro_x.Size = new System.Drawing.Size(28, 18);
            this.texto_registro_x.TabIndex = 15;
            this.texto_registro_x.Text = "(X)";
            // 
            // texto_registro_a
            // 
            this.texto_registro_a.AutoSize = true;
            this.texto_registro_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_registro_a.Location = new System.Drawing.Point(79, 470);
            this.texto_registro_a.Name = "texto_registro_a";
            this.texto_registro_a.Size = new System.Drawing.Size(27, 18);
            this.texto_registro_a.TabIndex = 14;
            this.texto_registro_a.Text = "(A)";
            this.texto_registro_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "(CP)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // texto_valores
            // 
            this.texto_valores.AutoSize = true;
            this.texto_valores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_valores.Location = new System.Drawing.Point(203, 402);
            this.texto_valores.Name = "texto_valores";
            this.texto_valores.Size = new System.Drawing.Size(84, 18);
            this.texto_valores.TabIndex = 12;
            this.texto_valores.Text = "VALORES";
            // 
            // texto_registros
            // 
            this.texto_registros.AutoSize = true;
            this.texto_registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_registros.Location = new System.Drawing.Point(32, 402);
            this.texto_registros.Name = "texto_registros";
            this.texto_registros.Size = new System.Drawing.Size(105, 18);
            this.texto_registros.TabIndex = 11;
            this.texto_registros.Text = "REGISTROS";
            // 
            // label_tam_programa
            // 
            this.label_tam_programa.AutoSize = true;
            this.label_tam_programa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tam_programa.Location = new System.Drawing.Point(498, 26);
            this.label_tam_programa.Name = "label_tam_programa";
            this.label_tam_programa.Size = new System.Drawing.Size(16, 20);
            this.label_tam_programa.TabIndex = 10;
            this.label_tam_programa.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tamaño del Programa:";
            // 
            // label_direccion_carga
            // 
            this.label_direccion_carga.AutoSize = true;
            this.label_direccion_carga.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion_carga.Location = new System.Drawing.Point(176, 26);
            this.label_direccion_carga.Name = "label_direccion_carga";
            this.label_direccion_carga.Size = new System.Drawing.Size(16, 20);
            this.label_direccion_carga.TabIndex = 8;
            this.label_direccion_carga.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dirección de carga:";
            // 
            // boton_cargar
            // 
            this.boton_cargar.Location = new System.Drawing.Point(674, 26);
            this.boton_cargar.Name = "boton_cargar";
            this.boton_cargar.Size = new System.Drawing.Size(216, 23);
            this.boton_cargar.TabIndex = 1;
            this.boton_cargar.Text = "Cargar Programa Objeto";
            this.boton_cargar.UseVisualStyleBackColor = true;
            this.boton_cargar.Click += new System.EventHandler(this.boton_cargar_Click);
            // 
            // dgv_cargador
            // 
            this.dgv_cargador.AllowUserToDeleteRows = false;
            this.dgv_cargador.AllowUserToResizeColumns = false;
            this.dgv_cargador.AllowUserToResizeRows = false;
            this.dgv_cargador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cargador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dir,
            this.dig_0,
            this.dig_1,
            this.dig_2,
            this.dig_3,
            this.dig_4,
            this.dig_5,
            this.dig_6,
            this.dig_7,
            this.dig_8,
            this.dig_9,
            this.dig_A,
            this.dig_B,
            this.dig_C,
            this.dig_D,
            this.dig_E,
            this.dig_F});
            this.dgv_cargador.Location = new System.Drawing.Point(23, 73);
            this.dgv_cargador.Name = "dgv_cargador";
            this.dgv_cargador.Size = new System.Drawing.Size(1165, 310);
            this.dgv_cargador.TabIndex = 0;
            this.dgv_cargador.Visible = false;
            // 
            // dir
            // 
            this.dir.HeaderText = "Dirección";
            this.dir.Name = "dir";
            // 
            // dig_0
            // 
            this.dig_0.HeaderText = "0";
            this.dig_0.Name = "dig_0";
            // 
            // dig_1
            // 
            this.dig_1.HeaderText = "1";
            this.dig_1.Name = "dig_1";
            // 
            // dig_2
            // 
            this.dig_2.HeaderText = "2";
            this.dig_2.Name = "dig_2";
            // 
            // dig_3
            // 
            this.dig_3.HeaderText = "3";
            this.dig_3.Name = "dig_3";
            // 
            // dig_4
            // 
            this.dig_4.HeaderText = "4";
            this.dig_4.Name = "dig_4";
            // 
            // dig_5
            // 
            this.dig_5.HeaderText = "5";
            this.dig_5.Name = "dig_5";
            // 
            // dig_6
            // 
            this.dig_6.HeaderText = "6";
            this.dig_6.Name = "dig_6";
            // 
            // dig_7
            // 
            this.dig_7.HeaderText = "7";
            this.dig_7.Name = "dig_7";
            // 
            // dig_8
            // 
            this.dig_8.HeaderText = "8";
            this.dig_8.Name = "dig_8";
            // 
            // dig_9
            // 
            this.dig_9.HeaderText = "9";
            this.dig_9.Name = "dig_9";
            // 
            // dig_A
            // 
            this.dig_A.HeaderText = "A";
            this.dig_A.Name = "dig_A";
            // 
            // dig_B
            // 
            this.dig_B.HeaderText = "B";
            this.dig_B.Name = "dig_B";
            // 
            // dig_C
            // 
            this.dig_C.HeaderText = "C";
            this.dig_C.Name = "dig_C";
            // 
            // dig_D
            // 
            this.dig_D.HeaderText = "D";
            this.dig_D.Name = "dig_D";
            // 
            // dig_E
            // 
            this.dig_E.HeaderText = "E";
            this.dig_E.Name = "dig_E";
            // 
            // dig_F
            // 
            this.dig_F.HeaderText = "F";
            this.dig_F.Name = "dig_F";
            // 
            // print_info
            // 
            this.print_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.print_info.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.print_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_info.Location = new System.Drawing.Point(461, 430);
            this.print_info.Name = "print_info";
            this.print_info.ReadOnly = true;
            this.print_info.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.print_info.ShowSelectionMargin = true;
            this.print_info.Size = new System.Drawing.Size(727, 163);
            this.print_info.TabIndex = 43;
            this.print_info.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "CP = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Bytes = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "CodOp = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Modo de Direccionamiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "m = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(671, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Efecto:  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(671, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "CP = ";
            // 
            // info_CP
            // 
            this.info_CP.AutoSize = true;
            this.info_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_CP.Location = new System.Drawing.Point(499, 447);
            this.info_CP.Name = "info_CP";
            this.info_CP.Size = new System.Drawing.Size(14, 18);
            this.info_CP.TabIndex = 34;
            this.info_CP.Text = "-";
            // 
            // info_bytes
            // 
            this.info_bytes.AutoSize = true;
            this.info_bytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_bytes.Location = new System.Drawing.Point(520, 472);
            this.info_bytes.Name = "info_bytes";
            this.info_bytes.Size = new System.Drawing.Size(14, 18);
            this.info_bytes.TabIndex = 35;
            this.info_bytes.Text = "-";
            // 
            // info_codop
            // 
            this.info_codop.AutoSize = true;
            this.info_codop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_codop.Location = new System.Drawing.Point(537, 503);
            this.info_codop.Name = "info_codop";
            this.info_codop.Size = new System.Drawing.Size(14, 18);
            this.info_codop.TabIndex = 36;
            this.info_codop.Text = "-";
            // 
            // info_modo
            // 
            this.info_modo.AutoSize = true;
            this.info_modo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_modo.Location = new System.Drawing.Point(650, 535);
            this.info_modo.Name = "info_modo";
            this.info_modo.Size = new System.Drawing.Size(14, 18);
            this.info_modo.TabIndex = 37;
            this.info_modo.Text = "-";
            // 
            // info_direccion
            // 
            this.info_direccion.AutoSize = true;
            this.info_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_direccion.Location = new System.Drawing.Point(499, 565);
            this.info_direccion.Name = "info_direccion";
            this.info_direccion.Size = new System.Drawing.Size(14, 18);
            this.info_direccion.TabIndex = 38;
            this.info_direccion.Text = "-";
            // 
            // info_sigCP
            // 
            this.info_sigCP.AutoSize = true;
            this.info_sigCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_sigCP.Location = new System.Drawing.Point(719, 447);
            this.info_sigCP.Name = "info_sigCP";
            this.info_sigCP.Size = new System.Drawing.Size(14, 18);
            this.info_sigCP.TabIndex = 39;
            this.info_sigCP.Text = "-";
            // 
            // info_nemonico
            // 
            this.info_nemonico.AutoSize = true;
            this.info_nemonico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_nemonico.Location = new System.Drawing.Point(727, 492);
            this.info_nemonico.Name = "info_nemonico";
            this.info_nemonico.Size = new System.Drawing.Size(14, 18);
            this.info_nemonico.TabIndex = 40;
            this.info_nemonico.Text = "-";
            // 
            // info_efecto
            // 
            this.info_efecto.AutoSize = true;
            this.info_efecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_efecto.Location = new System.Drawing.Point(727, 522);
            this.info_efecto.Name = "info_efecto";
            this.info_efecto.Size = new System.Drawing.Size(14, 18);
            this.info_efecto.TabIndex = 42;
            this.info_efecto.Text = "-";
            // 
            // lab_grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.tab_control);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "lab_grafico";
            this.Text = "Laboratorio Gráfico de Programación de Sistemas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_archivo_intermedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabsim)).EndInit();
            this.tab_control.ResumeLayout(false);
            this.tab_ensamblador.ResumeLayout(false);
            this.tab_ensamblador.PerformLayout();
            this.tab_cargador.ResumeLayout(false);
            this.tab_cargador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_instrucciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_archivo_intermedio;
        private System.Windows.Forms.RichTextBox asm_code;
        private System.Windows.Forms.DataGridView dgv_tabsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.TextBox errores;
        private System.Windows.Forms.TextBox text_programa_objeto;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label_archivo_intermedio;
        private System.Windows.Forms.Label label_tabsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_codigo_objeto;
        private System.Windows.Forms.Button ensamblar;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn instruccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn operando;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_obj;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tab_ensamblador;
        private System.Windows.Forms.TabPage tab_cargador;
        private System.Windows.Forms.Button boton_cargar;
        private System.Windows.Forms.DataGridView dgv_cargador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_E;
        private System.Windows.Forms.DataGridViewTextBoxColumn dig_F;
        private System.Windows.Forms.Label label_tam_programa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_direccion_carga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label registro_SW;
        private System.Windows.Forms.Label registro_L;
        private System.Windows.Forms.Label registro_X;
        private System.Windows.Forms.Label registro_A;
        private System.Windows.Forms.Label registro_CP;
        private System.Windows.Forms.Label texto_registro_sw;
        private System.Windows.Forms.Label texto_registro_l;
        private System.Windows.Forms.Label texto_registro_x;
        private System.Windows.Forms.Label texto_registro_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label texto_valores;
        private System.Windows.Forms.Label texto_registros;
        private System.Windows.Forms.Label label_instrucciones;
        private System.Windows.Forms.NumericUpDown numeric_instrucciones;
        private System.Windows.Forms.Button boton_ejecutar;
        private System.Windows.Forms.Button boton_cerrar_programa;
        private System.Windows.Forms.RichTextBox print_info;
        private System.Windows.Forms.Label info_efecto;
        private System.Windows.Forms.Label info_nemonico;
        private System.Windows.Forms.Label info_sigCP;
        private System.Windows.Forms.Label info_direccion;
        private System.Windows.Forms.Label info_modo;
        private System.Windows.Forms.Label info_codop;
        private System.Windows.Forms.Label info_bytes;
        private System.Windows.Forms.Label info_CP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

