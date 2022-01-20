
namespace PresentationLayer
{
    partial class FrmComprasReporte
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprasReporte));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdConsulta = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodigoColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuente = new System.Windows.Forms.BindingSource(this.components);
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.datosCheckBox = new System.Windows.Forms.CheckBox();
            this.gboDatosUsuario = new System.Windows.Forms.GroupBox();
            this.colaboradorRadioButton = new System.Windows.Forms.RadioButton();
            this.clienteRadioButton = new System.Windows.Forms.RadioButton();
            this.rangoFechasCheckBox = new System.Windows.Forms.CheckBox();
            this.gboRangoFechas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaFinDtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaInicioDtp = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fuente)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.gboDatosUsuario.SuspendLayout();
            this.gboRangoFechas.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelSuperior, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grdConsulta, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(253, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 659);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuperior.Location = new System.Drawing.Point(3, 3);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(672, 63);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.TabStop = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.lblTitulo.Location = new System.Drawing.Point(187, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 38);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "REPORTE DE COMPRAS";
            // 
            // grdConsulta
            // 
            this.grdConsulta.AllowUserToAddRows = false;
            this.grdConsulta.AllowUserToDeleteRows = false;
            this.grdConsulta.AllowUserToResizeColumns = false;
            this.grdConsulta.AllowUserToResizeRows = false;
            this.grdConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdConsulta.AutoGenerateColumns = false;
            this.grdConsulta.BackgroundColor = System.Drawing.Color.White;
            this.grdConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdConsulta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdConsulta.ColumnHeadersHeight = 36;
            this.grdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cFechaCompra,
            this.cTotalProductos,
            this.cTotalCompra,
            this.cCodigoCliente,
            this.cCliente,
            this.cDniCliente,
            this.cCodigoColaborador,
            this.cCargo,
            this.cTurno});
            this.grdConsulta.DataSource = this.Fuente;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsulta.DefaultCellStyle = dataGridViewCellStyle10;
            this.grdConsulta.EnableHeadersVisualStyles = false;
            this.grdConsulta.GridColor = System.Drawing.Color.LightGray;
            this.grdConsulta.Location = new System.Drawing.Point(3, 72);
            this.grdConsulta.MultiSelect = false;
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.RowHeadersVisible = false;
            this.grdConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConsulta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdConsulta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.grdConsulta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.grdConsulta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdConsulta.RowTemplate.Height = 20;
            this.grdConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdConsulta.ShowCellToolTips = false;
            this.grdConsulta.ShowEditingIcon = false;
            this.grdConsulta.Size = new System.Drawing.Size(672, 584);
            this.grdConsulta.TabIndex = 0;
            this.grdConsulta.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdConsulta_DataBindingComplete);
            // 
            // cId
            // 
            this.cId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cId.DataPropertyName = "ID_COMPRA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cId.DefaultCellStyle = dataGridViewCellStyle2;
            this.cId.HeaderText = "ID";
            this.cId.MinimumWidth = 40;
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            this.cId.Width = 40;
            // 
            // cFechaCompra
            // 
            this.cFechaCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cFechaCompra.DataPropertyName = "FECHA_COMPRA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.cFechaCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.cFechaCompra.HeaderText = "Fecha";
            this.cFechaCompra.MinimumWidth = 50;
            this.cFechaCompra.Name = "cFechaCompra";
            this.cFechaCompra.ReadOnly = true;
            this.cFechaCompra.Width = 69;
            // 
            // cTotalProductos
            // 
            this.cTotalProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cTotalProductos.DataPropertyName = "TOTAL_PRODUCTOS";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cTotalProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.cTotalProductos.HeaderText = "Total Productos";
            this.cTotalProductos.MinimumWidth = 65;
            this.cTotalProductos.Name = "cTotalProductos";
            this.cTotalProductos.ReadOnly = true;
            this.cTotalProductos.Width = 65;
            // 
            // cTotalCompra
            // 
            this.cTotalCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cTotalCompra.DataPropertyName = "TOTAL_COMPRA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.cTotalCompra.DefaultCellStyle = dataGridViewCellStyle5;
            this.cTotalCompra.HeaderText = "Total (S/.)";
            this.cTotalCompra.MinimumWidth = 60;
            this.cTotalCompra.Name = "cTotalCompra";
            this.cTotalCompra.ReadOnly = true;
            this.cTotalCompra.Width = 60;
            // 
            // cCodigoCliente
            // 
            this.cCodigoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cCodigoCliente.DataPropertyName = "CODIGO_CLIENTE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cCodigoCliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.cCodigoCliente.HeaderText = "Código de Cliente";
            this.cCodigoCliente.MinimumWidth = 80;
            this.cCodigoCliente.Name = "cCodigoCliente";
            this.cCodigoCliente.ReadOnly = true;
            this.cCodigoCliente.Width = 80;
            // 
            // cCliente
            // 
            this.cCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cCliente.DataPropertyName = "CLIENTE";
            this.cCliente.HeaderText = "Cliente";
            this.cCliente.MinimumWidth = 80;
            this.cCliente.Name = "cCliente";
            this.cCliente.ReadOnly = true;
            this.cCliente.Width = 80;
            // 
            // cDniCliente
            // 
            this.cDniCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cDniCliente.DataPropertyName = "DNI_CLIENTE";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cDniCliente.DefaultCellStyle = dataGridViewCellStyle7;
            this.cDniCliente.HeaderText = "DNI Cliente";
            this.cDniCliente.MinimumWidth = 70;
            this.cDniCliente.Name = "cDniCliente";
            this.cDniCliente.ReadOnly = true;
            this.cDniCliente.Width = 89;
            // 
            // cCodigoColaborador
            // 
            this.cCodigoColaborador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cCodigoColaborador.DataPropertyName = "CODIGO_COLABORADOR";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cCodigoColaborador.DefaultCellStyle = dataGridViewCellStyle8;
            this.cCodigoColaborador.HeaderText = "Código de Colaborador";
            this.cCodigoColaborador.MinimumWidth = 85;
            this.cCodigoColaborador.Name = "cCodigoColaborador";
            this.cCodigoColaborador.ReadOnly = true;
            this.cCodigoColaborador.Width = 85;
            // 
            // cCargo
            // 
            this.cCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cCargo.DataPropertyName = "CARGO_COLABORADOR";
            this.cCargo.HeaderText = "Cargo";
            this.cCargo.MinimumWidth = 70;
            this.cCargo.Name = "cCargo";
            this.cCargo.ReadOnly = true;
            this.cCargo.Width = 70;
            // 
            // cTurno
            // 
            this.cTurno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cTurno.DataPropertyName = "TURNO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cTurno.DefaultCellStyle = dataGridViewCellStyle9;
            this.cTurno.HeaderText = "Turno";
            this.cTurno.MinimumWidth = 60;
            this.cTurno.Name = "cTurno";
            this.cTurno.ReadOnly = true;
            this.cTurno.Width = 64;
            // 
            // filtroComboBox
            // 
            this.filtroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.Location = new System.Drawing.Point(18, 73);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(175, 25);
            this.filtroComboBox.TabIndex = 16;
            this.filtroComboBox.TabStop = false;
            this.filtroComboBox.SelectionChangeCommitted += new System.EventHandler(this.FiltroComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtros de búsqueda:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(18, 115);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(175, 23);
            this.txtBuscar.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panelLateral, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(934, 665);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.panelLateral.Controls.Add(this.btnLimpiar);
            this.panelLateral.Controls.Add(this.btnActualizar);
            this.panelLateral.Controls.Add(this.btnFiltrar);
            this.panelLateral.Controls.Add(this.datosCheckBox);
            this.panelLateral.Controls.Add(this.gboDatosUsuario);
            this.panelLateral.Controls.Add(this.rangoFechasCheckBox);
            this.panelLateral.Controls.Add(this.gboRangoFechas);
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.statusStrip1);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLateral.Location = new System.Drawing.Point(3, 3);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(244, 659);
            this.panelLateral.TabIndex = 1;
            this.panelLateral.TabStop = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::PresentationLayer.Properties.Resources.Limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(60, 486);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 34);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = global::PresentationLayer.Properties.Resources.Actualizar;
            this.btnActualizar.Location = new System.Drawing.Point(60, 538);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 34);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Image = global::PresentationLayer.Properties.Resources.Filtrar;
            this.btnFiltrar.Location = new System.Drawing.Point(60, 446);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(125, 34);
            this.btnFiltrar.TabIndex = 25;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // datosCheckBox
            // 
            this.datosCheckBox.AutoSize = true;
            this.datosCheckBox.BackColor = System.Drawing.Color.White;
            this.datosCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosCheckBox.ForeColor = System.Drawing.Color.DimGray;
            this.datosCheckBox.Location = new System.Drawing.Point(17, 52);
            this.datosCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.datosCheckBox.Name = "datosCheckBox";
            this.datosCheckBox.Size = new System.Drawing.Size(136, 20);
            this.datosCheckBox.TabIndex = 20;
            this.datosCheckBox.Text = "Datos de usuario";
            this.datosCheckBox.UseVisualStyleBackColor = false;
            this.datosCheckBox.CheckedChanged += new System.EventHandler(this.DatosCheckBox_CheckedChanged);
            // 
            // gboDatosUsuario
            // 
            this.gboDatosUsuario.BackColor = System.Drawing.Color.White;
            this.gboDatosUsuario.Controls.Add(this.colaboradorRadioButton);
            this.gboDatosUsuario.Controls.Add(this.clienteRadioButton);
            this.gboDatosUsuario.Controls.Add(this.filtroComboBox);
            this.gboDatosUsuario.Controls.Add(this.txtBuscar);
            this.gboDatosUsuario.Enabled = false;
            this.gboDatosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboDatosUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDatosUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.gboDatosUsuario.Location = new System.Drawing.Point(17, 72);
            this.gboDatosUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.gboDatosUsuario.Name = "gboDatosUsuario";
            this.gboDatosUsuario.Padding = new System.Windows.Forms.Padding(0);
            this.gboDatosUsuario.Size = new System.Drawing.Size(210, 158);
            this.gboDatosUsuario.TabIndex = 19;
            this.gboDatosUsuario.TabStop = false;
            this.gboDatosUsuario.EnabledChanged += new System.EventHandler(this.GboDatosUsuario_EnabledChanged);
            // 
            // colaboradorRadioButton
            // 
            this.colaboradorRadioButton.AutoSize = true;
            this.colaboradorRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaboradorRadioButton.Location = new System.Drawing.Point(18, 47);
            this.colaboradorRadioButton.Name = "colaboradorRadioButton";
            this.colaboradorRadioButton.Size = new System.Drawing.Size(110, 20);
            this.colaboradorRadioButton.TabIndex = 18;
            this.colaboradorRadioButton.Text = "Colaborador";
            this.colaboradorRadioButton.UseVisualStyleBackColor = true;
            this.colaboradorRadioButton.CheckedChanged += new System.EventHandler(this.ColaboradorRadioButton_CheckedChanged);
            // 
            // clienteRadioButton
            // 
            this.clienteRadioButton.AutoSize = true;
            this.clienteRadioButton.Checked = true;
            this.clienteRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteRadioButton.Location = new System.Drawing.Point(18, 21);
            this.clienteRadioButton.Name = "clienteRadioButton";
            this.clienteRadioButton.Size = new System.Drawing.Size(72, 20);
            this.clienteRadioButton.TabIndex = 17;
            this.clienteRadioButton.TabStop = true;
            this.clienteRadioButton.Text = "Cliente";
            this.clienteRadioButton.UseVisualStyleBackColor = true;
            // 
            // rangoFechasCheckBox
            // 
            this.rangoFechasCheckBox.AutoSize = true;
            this.rangoFechasCheckBox.BackColor = System.Drawing.Color.White;
            this.rangoFechasCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangoFechasCheckBox.ForeColor = System.Drawing.Color.DimGray;
            this.rangoFechasCheckBox.Location = new System.Drawing.Point(17, 254);
            this.rangoFechasCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.rangoFechasCheckBox.Name = "rangoFechasCheckBox";
            this.rangoFechasCheckBox.Size = new System.Drawing.Size(139, 20);
            this.rangoFechasCheckBox.TabIndex = 19;
            this.rangoFechasCheckBox.Text = "Rango de Fechas";
            this.rangoFechasCheckBox.UseVisualStyleBackColor = false;
            this.rangoFechasCheckBox.CheckedChanged += new System.EventHandler(this.RangoFechasCheckBox_CheckedChanged);
            // 
            // gboRangoFechas
            // 
            this.gboRangoFechas.BackColor = System.Drawing.Color.White;
            this.gboRangoFechas.Controls.Add(this.label3);
            this.gboRangoFechas.Controls.Add(this.fechaFinDtp);
            this.gboRangoFechas.Controls.Add(this.label2);
            this.gboRangoFechas.Controls.Add(this.fechaInicioDtp);
            this.gboRangoFechas.Enabled = false;
            this.gboRangoFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboRangoFechas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboRangoFechas.ForeColor = System.Drawing.Color.DimGray;
            this.gboRangoFechas.Location = new System.Drawing.Point(17, 274);
            this.gboRangoFechas.Margin = new System.Windows.Forms.Padding(0);
            this.gboRangoFechas.Name = "gboRangoFechas";
            this.gboRangoFechas.Padding = new System.Windows.Forms.Padding(0);
            this.gboRangoFechas.Size = new System.Drawing.Size(210, 145);
            this.gboRangoFechas.TabIndex = 18;
            this.gboRangoFechas.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha fin:";
            // 
            // fechaFinDtp
            // 
            this.fechaFinDtp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFinDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinDtp.Location = new System.Drawing.Point(50, 99);
            this.fechaFinDtp.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.fechaFinDtp.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.fechaFinDtp.Name = "fechaFinDtp";
            this.fechaFinDtp.Size = new System.Drawing.Size(110, 23);
            this.fechaFinDtp.TabIndex = 2;
            this.fechaFinDtp.Value = new System.DateTime(2022, 1, 20, 12, 10, 10, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inicio:";
            // 
            // fechaInicioDtp
            // 
            this.fechaInicioDtp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicioDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicioDtp.Location = new System.Drawing.Point(50, 45);
            this.fechaInicioDtp.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.fechaInicioDtp.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.fechaInicioDtp.Name = "fechaInicioDtp";
            this.fechaInicioDtp.Size = new System.Drawing.Size(110, 23);
            this.fechaInicioDtp.TabIndex = 0;
            this.fechaInicioDtp.Value = new System.DateTime(2022, 1, 20, 12, 10, 10, 0);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(244, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmComprasReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 665);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmComprasReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmComprasReporte_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fuente)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.gboDatosUsuario.ResumeLayout(false);
            this.gboDatosUsuario.PerformLayout();
            this.gboRangoFechas.ResumeLayout(false);
            this.gboRangoFechas.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource Fuente;
        private System.Windows.Forms.ComboBox filtroComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.DataGridView grdConsulta;
        private System.Windows.Forms.CheckBox rangoFechasCheckBox;
        private System.Windows.Forms.GroupBox gboRangoFechas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaFinDtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaInicioDtp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalRegistros;
        private System.Windows.Forms.GroupBox gboDatosUsuario;
        private System.Windows.Forms.CheckBox datosCheckBox;
        private System.Windows.Forms.RadioButton colaboradorRadioButton;
        private System.Windows.Forms.RadioButton clienteRadioButton;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigoColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTurno;
    }
}

