
namespace LagartoStoreApp.PL
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mantenimientosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeTurnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCategoríasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosMenu,
            this.reportesMenu,
            this.viewMenu,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.MinimumSize = new System.Drawing.Size(0, 30);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(807, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mantenimientosMenu
            // 
            this.mantenimientosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeUsuariosToolStripMenuItem,
            this.registroDeColaboradoresToolStripMenuItem,
            this.registroDeClientesToolStripMenuItem,
            this.registroDeProductosToolStripMenuItem});
            this.mantenimientosMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.mantenimientosMenu.ForeColor = System.Drawing.Color.White;
            this.mantenimientosMenu.Name = "mantenimientosMenu";
            this.mantenimientosMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mantenimientosMenu.Size = new System.Drawing.Size(114, 30);
            this.mantenimientosMenu.Text = "&Mantenimientos";
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            this.registroDeUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            this.registroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.registroDeUsuariosToolStripMenuItem.Text = "Registro de usuarios";
            this.registroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeUsuariosToolStripMenuItem_Click);
            // 
            // registroDeColaboradoresToolStripMenuItem
            // 
            this.registroDeColaboradoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.registroDeColaboradoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeCargosToolStripMenuItem,
            this.registroDeTurnosToolStripMenuItem1});
            this.registroDeColaboradoresToolStripMenuItem.Name = "registroDeColaboradoresToolStripMenuItem";
            this.registroDeColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.registroDeColaboradoresToolStripMenuItem.Text = "Registro de colaboradores";
            this.registroDeColaboradoresToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeColaboradoresToolStripMenuItem_Click);
            // 
            // registroDeCargosToolStripMenuItem
            // 
            this.registroDeCargosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.registroDeCargosToolStripMenuItem.Name = "registroDeCargosToolStripMenuItem";
            this.registroDeCargosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registroDeCargosToolStripMenuItem.Text = "Registro de cargos";
            this.registroDeCargosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeCargosToolStripMenuItem_Click);
            // 
            // registroDeTurnosToolStripMenuItem1
            // 
            this.registroDeTurnosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(95)))), ((int)(((byte)(133)))));
            this.registroDeTurnosToolStripMenuItem1.Name = "registroDeTurnosToolStripMenuItem1";
            this.registroDeTurnosToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.registroDeTurnosToolStripMenuItem1.Text = "Registro de turnos";
            this.registroDeTurnosToolStripMenuItem1.Click += new System.EventHandler(this.RegistroDeTurnosToolStripMenuItem1_Click);
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeClientesToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.registroDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeCategoríasToolStripMenuItem1});
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de productos";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeProductosToolStripMenuItem_Click);
            // 
            // registroDeCategoríasToolStripMenuItem1
            // 
            this.registroDeCategoríasToolStripMenuItem1.Name = "registroDeCategoríasToolStripMenuItem1";
            this.registroDeCategoríasToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.registroDeCategoríasToolStripMenuItem1.Text = "Registro de categorías";
            this.registroDeCategoríasToolStripMenuItem1.Click += new System.EventHandler(this.RegistroDeCategoríasToolStripMenuItem1_Click);
            // 
            // reportesMenu
            // 
            this.reportesMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.reportesMenu.ForeColor = System.Drawing.Color.White;
            this.reportesMenu.Name = "reportesMenu";
            this.reportesMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reportesMenu.Size = new System.Drawing.Size(73, 30);
            this.reportesMenu.Text = "&Reportes";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMenu.ForeColor = System.Drawing.Color.White;
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.viewMenu.Size = new System.Drawing.Size(42, 30);
            this.viewMenu.Text = "&Ver";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.statusBarToolStripMenuItem.Text = "&Barra de estado";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.windowsMenu.ForeColor = System.Drawing.Color.White;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.windowsMenu.Size = new System.Drawing.Size(76, 30);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 603);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(807, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 30);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(807, 573);
            this.panelContenedor.TabIndex = 4;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(807, 625);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosMenu;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeColaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeTurnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroDeCategoríasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesMenu;
        private System.Windows.Forms.Panel panelContenedor;
    }
}



