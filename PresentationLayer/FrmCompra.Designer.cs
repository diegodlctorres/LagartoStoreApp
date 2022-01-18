
namespace PresentationLayer
{
    partial class FrmCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompra));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnComprar = new System.Windows.Forms.Button();
            this.totalAPagarTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiarCarrito = new System.Windows.Forms.Button();
            this.grdCarrito = new System.Windows.Forms.DataGridView();
            this.cIdCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecioUnitarioCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSubtotalCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidadCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDisminuir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CarritoDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dniClienteTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.apellidoClienteTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductosDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoriaCheckBox = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDataSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 724F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1099, 728);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.grdCarrito, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.49606F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.50394F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(543, 722);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.btnComprar);
            this.panel3.Controls.Add(this.totalAPagarTextBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnLimpiarCarrito);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 642);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 77);
            this.panel3.TabIndex = 3;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Image = global::PresentationLayer.Properties.Resources.Comprar;
            this.btnComprar.Location = new System.Drawing.Point(287, 21);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(100, 34);
            this.btnComprar.TabIndex = 25;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // totalAPagarTextBox
            // 
            this.totalAPagarTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.totalAPagarTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAPagarTextBox.Location = new System.Drawing.Point(185, 27);
            this.totalAPagarTextBox.Name = "totalAPagarTextBox";
            this.totalAPagarTextBox.ReadOnly = true;
            this.totalAPagarTextBox.Size = new System.Drawing.Size(80, 23);
            this.totalAPagarTextBox.TabIndex = 21;
            this.totalAPagarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(43, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total  a pagar (S./):";
            // 
            // btnLimpiarCarrito
            // 
            this.btnLimpiarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.btnLimpiarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCarrito.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCarrito.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCarrito.Image = global::PresentationLayer.Properties.Resources.Cancelar;
            this.btnLimpiarCarrito.Location = new System.Drawing.Point(393, 21);
            this.btnLimpiarCarrito.Name = "btnLimpiarCarrito";
            this.btnLimpiarCarrito.Size = new System.Drawing.Size(100, 34);
            this.btnLimpiarCarrito.TabIndex = 19;
            this.btnLimpiarCarrito.TabStop = false;
            this.btnLimpiarCarrito.Text = "Limpiar";
            this.btnLimpiarCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarCarrito.UseVisualStyleBackColor = false;
            this.btnLimpiarCarrito.Click += new System.EventHandler(this.BtnLimpiarCarrito_Click);
            // 
            // grdCarrito
            // 
            this.grdCarrito.AllowUserToAddRows = false;
            this.grdCarrito.AllowUserToDeleteRows = false;
            this.grdCarrito.AllowUserToResizeColumns = false;
            this.grdCarrito.AllowUserToResizeRows = false;
            this.grdCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCarrito.AutoGenerateColumns = false;
            this.grdCarrito.BackgroundColor = System.Drawing.Color.White;
            this.grdCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCarrito.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCarrito.ColumnHeadersHeight = 36;
            this.grdCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdCarrito,
            this.cNombreCarrito,
            this.cPrecioUnitarioCarrito,
            this.cSubtotalCarrito,
            this.cCantidadCarrito,
            this.cDisminuir});
            this.grdCarrito.DataSource = this.CarritoDataSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCarrito.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdCarrito.EnableHeadersVisualStyles = false;
            this.grdCarrito.GridColor = System.Drawing.Color.LightGray;
            this.grdCarrito.Location = new System.Drawing.Point(3, 204);
            this.grdCarrito.MultiSelect = false;
            this.grdCarrito.Name = "grdCarrito";
            this.grdCarrito.RowHeadersVisible = false;
            this.grdCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdCarrito.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCarrito.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.grdCarrito.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.grdCarrito.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdCarrito.RowTemplate.Height = 20;
            this.grdCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdCarrito.ShowCellToolTips = false;
            this.grdCarrito.ShowEditingIcon = false;
            this.grdCarrito.Size = new System.Drawing.Size(537, 432);
            this.grdCarrito.TabIndex = 2;
            this.grdCarrito.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdCarrito_CellMouseClick);
            // 
            // cIdCarrito
            // 
            this.cIdCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cIdCarrito.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cIdCarrito.DefaultCellStyle = dataGridViewCellStyle2;
            this.cIdCarrito.HeaderText = "ID";
            this.cIdCarrito.MinimumWidth = 45;
            this.cIdCarrito.Name = "cIdCarrito";
            this.cIdCarrito.ReadOnly = true;
            this.cIdCarrito.Width = 45;
            // 
            // cNombreCarrito
            // 
            this.cNombreCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombreCarrito.DataPropertyName = "NOMBRE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cNombreCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.cNombreCarrito.HeaderText = "Nombre";
            this.cNombreCarrito.MinimumWidth = 160;
            this.cNombreCarrito.Name = "cNombreCarrito";
            this.cNombreCarrito.ReadOnly = true;
            // 
            // cPrecioUnitarioCarrito
            // 
            this.cPrecioUnitarioCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cPrecioUnitarioCarrito.DataPropertyName = "PRECIO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.cPrecioUnitarioCarrito.DefaultCellStyle = dataGridViewCellStyle4;
            this.cPrecioUnitarioCarrito.HeaderText = "P. Unitario (S/.)";
            this.cPrecioUnitarioCarrito.MinimumWidth = 85;
            this.cPrecioUnitarioCarrito.Name = "cPrecioUnitarioCarrito";
            this.cPrecioUnitarioCarrito.ReadOnly = true;
            this.cPrecioUnitarioCarrito.Width = 85;
            // 
            // cSubtotalCarrito
            // 
            this.cSubtotalCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cSubtotalCarrito.DataPropertyName = "SUBTOTAL";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.cSubtotalCarrito.DefaultCellStyle = dataGridViewCellStyle5;
            this.cSubtotalCarrito.HeaderText = "P. Subtotal (S./)";
            this.cSubtotalCarrito.MinimumWidth = 85;
            this.cSubtotalCarrito.Name = "cSubtotalCarrito";
            this.cSubtotalCarrito.ReadOnly = true;
            this.cSubtotalCarrito.Width = 85;
            // 
            // cCantidadCarrito
            // 
            this.cCantidadCarrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cCantidadCarrito.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cCantidadCarrito.DefaultCellStyle = dataGridViewCellStyle6;
            this.cCantidadCarrito.HeaderText = "Cantidad";
            this.cCantidadCarrito.MinimumWidth = 75;
            this.cCantidadCarrito.Name = "cCantidadCarrito";
            this.cCantidadCarrito.ReadOnly = true;
            this.cCantidadCarrito.Width = 75;
            // 
            // cDisminuir
            // 
            this.cDisminuir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.cDisminuir.DefaultCellStyle = dataGridViewCellStyle7;
            this.cDisminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cDisminuir.HeaderText = "";
            this.cDisminuir.MinimumWidth = 85;
            this.cDisminuir.Name = "cDisminuir";
            this.cDisminuir.Text = "Disminuir";
            this.cDisminuir.UseColumnTextForButtonValue = true;
            this.cDisminuir.Width = 85;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nombreClienteTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dniClienteTextBox);
            this.panel2.Controls.Add(this.idClienteTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.apellidoClienteTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 195);
            this.panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::PresentationLayer.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(393, 143);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::PresentationLayer.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(287, 143);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 34);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(220, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nombre:";
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreClienteTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClienteTextBox.Location = new System.Drawing.Point(223, 90);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.ReadOnly = true;
            this.nombreClienteTextBox.Size = new System.Drawing.Size(255, 23);
            this.nombreClienteTextBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(125, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "DNI:";
            // 
            // dniClienteTextBox
            // 
            this.dniClienteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dniClienteTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniClienteTextBox.Location = new System.Drawing.Point(128, 90);
            this.dniClienteTextBox.MaxLength = 8;
            this.dniClienteTextBox.Name = "dniClienteTextBox";
            this.dniClienteTextBox.ReadOnly = true;
            this.dniClienteTextBox.Size = new System.Drawing.Size(64, 23);
            this.dniClienteTextBox.TabIndex = 20;
            this.dniClienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClienteTextBox.Location = new System.Drawing.Point(47, 90);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.ReadOnly = true;
            this.idClienteTextBox.Size = new System.Drawing.Size(50, 23);
            this.idClienteTextBox.TabIndex = 0;
            this.idClienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(45, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.label6.Location = new System.Drawing.Point(76, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "REGISTRO DE COMPRAS";
            // 
            // apellidoClienteTextBox
            // 
            this.apellidoClienteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apellidoClienteTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoClienteTextBox.Location = new System.Drawing.Point(48, 149);
            this.apellidoClienteTextBox.Name = "apellidoClienteTextBox";
            this.apellidoClienteTextBox.ReadOnly = true;
            this.apellidoClienteTextBox.Size = new System.Drawing.Size(200, 23);
            this.apellidoClienteTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.grdProductos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(552, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(544, 722);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.AllowUserToResizeColumns = false;
            this.grdProductos.AllowUserToResizeRows = false;
            this.grdProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProductos.AutoGenerateColumns = false;
            this.grdProductos.BackgroundColor = System.Drawing.Color.White;
            this.grdProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdProductos.ColumnHeadersHeight = 36;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNombre,
            this.cCategoria,
            this.cPrecio,
            this.cStock});
            this.grdProductos.DataSource = this.ProductosDataSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductos.DefaultCellStyle = dataGridViewCellStyle14;
            this.grdProductos.EnableHeadersVisualStyles = false;
            this.grdProductos.GridColor = System.Drawing.Color.LightGray;
            this.grdProductos.Location = new System.Drawing.Point(3, 203);
            this.grdProductos.MultiSelect = false;
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.RowHeadersVisible = false;
            this.grdProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProductos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.grdProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.grdProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdProductos.RowTemplate.Height = 20;
            this.grdProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdProductos.ShowCellToolTips = false;
            this.grdProductos.ShowEditingIcon = false;
            this.grdProductos.Size = new System.Drawing.Size(538, 516);
            this.grdProductos.TabIndex = 2;
            // 
            // cId
            // 
            this.cId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cId.DataPropertyName = "ID";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cId.DefaultCellStyle = dataGridViewCellStyle10;
            this.cId.Frozen = true;
            this.cId.HeaderText = "ID";
            this.cId.MinimumWidth = 45;
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Width = 45;
            // 
            // cNombre
            // 
            this.cNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombre.DataPropertyName = "NOMBRE";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cNombre.DefaultCellStyle = dataGridViewCellStyle11;
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 160;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cCategoria
            // 
            this.cCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cCategoria.DataPropertyName = "CATEGORIA";
            this.cCategoria.HeaderText = "Categoria";
            this.cCategoria.MinimumWidth = 150;
            this.cCategoria.Name = "cCategoria";
            this.cCategoria.ReadOnly = true;
            // 
            // cPrecio
            // 
            this.cPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cPrecio.DataPropertyName = "PRECIO";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            this.cPrecio.DefaultCellStyle = dataGridViewCellStyle12;
            this.cPrecio.HeaderText = "Precio (S/.)";
            this.cPrecio.MinimumWidth = 85;
            this.cPrecio.Name = "cPrecio";
            this.cPrecio.ReadOnly = true;
            this.cPrecio.Width = 85;
            // 
            // cStock
            // 
            this.cStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cStock.DataPropertyName = "STOCK";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cStock.DefaultCellStyle = dataGridViewCellStyle13;
            this.cStock.HeaderText = "Stock";
            this.cStock.MinimumWidth = 65;
            this.cStock.Name = "cStock";
            this.cStock.ReadOnly = true;
            this.cStock.Width = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.categoriaCheckBox);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.categoriaComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 194);
            this.panel1.TabIndex = 1;
            // 
            // categoriaCheckBox
            // 
            this.categoriaCheckBox.AutoSize = true;
            this.categoriaCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.categoriaCheckBox.ForeColor = System.Drawing.Color.DimGray;
            this.categoriaCheckBox.Location = new System.Drawing.Point(54, 124);
            this.categoriaCheckBox.Name = "categoriaCheckBox";
            this.categoriaCheckBox.Size = new System.Drawing.Size(96, 20);
            this.categoriaCheckBox.TabIndex = 20;
            this.categoriaCheckBox.TabStop = false;
            this.categoriaCheckBox.Text = "Categoría:";
            this.categoriaCheckBox.UseVisualStyleBackColor = true;
            this.categoriaCheckBox.CheckedChanged += new System.EventHandler(this.CategoriaCheckBox_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::PresentationLayer.Properties.Resources.Limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(363, 143);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 34);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(54, 90);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(50, 23);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.idTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(51, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Id:";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.Enabled = false;
            this.categoriaComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(54, 150);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(275, 24);
            this.categoriaComboBox.TabIndex = 16;
            this.categoriaComboBox.TabStop = false;
            this.categoriaComboBox.SelectionChangeCommitted += new System.EventHandler(this.CategoriaComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(113, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(80, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "NUESTROS PRODUCTOS";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(119, 90);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(210, 23);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 728);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoDataSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource ProductosDataSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox categoriaCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLimpiarCarrito;
        private System.Windows.Forms.DataGridView grdCarrito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dniClienteTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox apellidoClienteTextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource CarritoDataSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalAPagarTextBox;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioUnitarioCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubtotalCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidadCarrito;
        private System.Windows.Forms.DataGridViewButtonColumn cDisminuir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStock;
    }
}

