
namespace PresentationLayer
{
    partial class FrmColaborador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColaborador));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grdConsulta = new System.Windows.Forms.DataGridView();
            this.Fuente = new System.Windows.Forms.BindingSource(this.components);
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fuente)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grdConsulta, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 144);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(181, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::PresentationLayer.Properties.Resources.Agregar;
            this.btnNuevo.Location = new System.Drawing.Point(670, 93);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(160, 34);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo colaborador";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.lblTitulo.Location = new System.Drawing.Point(238, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(503, 38);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "REGISTRO DE COLABORADORES";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(243, 99);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(199, 23);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
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
            this.cCodigo,
            this.cNombre,
            this.cApellido,
            this.cDNI,
            this.cCorreo,
            this.cSexo,
            this.cTelefono,
            this.cCargo,
            this.cTurno,
            this.cEditar,
            this.cEliminar});
            this.grdConsulta.DataSource = this.Fuente;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsulta.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdConsulta.EnableHeadersVisualStyles = false;
            this.grdConsulta.GridColor = System.Drawing.Color.LightGray;
            this.grdConsulta.Location = new System.Drawing.Point(3, 153);
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
            this.grdConsulta.Size = new System.Drawing.Size(1005, 415);
            this.grdConsulta.TabIndex = 0;
            this.grdConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdConsulta_CellClick);
            // 
            // cId
            // 
            this.cId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cId.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cId.DefaultCellStyle = dataGridViewCellStyle2;
            this.cId.HeaderText = "ID";
            this.cId.MinimumWidth = 40;
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Width = 40;
            // 
            // cCodigo
            // 
            this.cCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cCodigo.DataPropertyName = "CODIGO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cCodigo.DefaultCellStyle = dataGridViewCellStyle3;
            this.cCodigo.HeaderText = "Código";
            this.cCodigo.MinimumWidth = 65;
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            this.cCodigo.Width = 65;
            // 
            // cNombre
            // 
            this.cNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cNombre.DataPropertyName = "NOMBRE";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 120;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 120;
            // 
            // cApellido
            // 
            this.cApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cApellido.DataPropertyName = "APELLIDO";
            this.cApellido.HeaderText = "Apellido";
            this.cApellido.MinimumWidth = 100;
            this.cApellido.Name = "cApellido";
            this.cApellido.ReadOnly = true;
            // 
            // cDNI
            // 
            this.cDNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cDNI.DataPropertyName = "DNI";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cDNI.DefaultCellStyle = dataGridViewCellStyle4;
            this.cDNI.HeaderText = "DNI";
            this.cDNI.MinimumWidth = 75;
            this.cDNI.Name = "cDNI";
            this.cDNI.ReadOnly = true;
            this.cDNI.Width = 75;
            // 
            // cCorreo
            // 
            this.cCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cCorreo.DataPropertyName = "CORREO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cCorreo.DefaultCellStyle = dataGridViewCellStyle5;
            this.cCorreo.HeaderText = "Correo";
            this.cCorreo.MinimumWidth = 130;
            this.cCorreo.Name = "cCorreo";
            this.cCorreo.ReadOnly = true;
            this.cCorreo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cCorreo.Width = 130;
            // 
            // cSexo
            // 
            this.cSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cSexo.DataPropertyName = "SEXO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSexo.DefaultCellStyle = dataGridViewCellStyle6;
            this.cSexo.HeaderText = "Sexo";
            this.cSexo.MinimumWidth = 50;
            this.cSexo.Name = "cSexo";
            this.cSexo.ReadOnly = true;
            this.cSexo.Width = 50;
            // 
            // cTelefono
            // 
            this.cTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cTelefono.DataPropertyName = "TELEFONO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cTelefono.DefaultCellStyle = dataGridViewCellStyle7;
            this.cTelefono.HeaderText = "Teléfono";
            this.cTelefono.MinimumWidth = 85;
            this.cTelefono.Name = "cTelefono";
            this.cTelefono.ReadOnly = true;
            this.cTelefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTelefono.Width = 85;
            // 
            // cCargo
            // 
            this.cCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cCargo.DataPropertyName = "CARGO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cCargo.DefaultCellStyle = dataGridViewCellStyle8;
            this.cCargo.HeaderText = "Cargo";
            this.cCargo.Name = "cCargo";
            this.cCargo.ReadOnly = true;
            this.cCargo.Width = 69;
            // 
            // cTurno
            // 
            this.cTurno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cTurno.DataPropertyName = "TURNO";
            this.cTurno.HeaderText = "Turno";
            this.cTurno.Name = "cTurno";
            this.cTurno.ReadOnly = true;
            this.cTurno.Width = 64;
            // 
            // cEditar
            // 
            this.cEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(106)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.cEditar.DefaultCellStyle = dataGridViewCellStyle9;
            this.cEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cEditar.HeaderText = "";
            this.cEditar.MinimumWidth = 100;
            this.cEditar.Name = "cEditar";
            this.cEditar.Text = "Editar";
            this.cEditar.UseColumnTextForButtonValue = true;
            // 
            // cEliminar
            // 
            this.cEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.cEliminar.DefaultCellStyle = dataGridViewCellStyle10;
            this.cEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cEliminar.HeaderText = "";
            this.cEliminar.MinimumWidth = 100;
            this.cEliminar.Name = "cEliminar";
            this.cEliminar.Text = "Borrar";
            this.cEliminar.UseColumnTextForButtonValue = true;
            // 
            // FrmColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmColaborador_Load);
            this.SizeChanged += new System.EventHandler(this.FrmColaborador_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fuente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdConsulta;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource Fuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTurno;
        private System.Windows.Forms.DataGridViewButtonColumn cEditar;
        private System.Windows.Forms.DataGridViewButtonColumn cEliminar;
    }
}

