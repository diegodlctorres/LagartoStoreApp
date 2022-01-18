
namespace PresentationLayer
{
    partial class FrmNuevoColaborador
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
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cargoComboBox = new System.Windows.Forms.ComboBox();
            this.turnoComboBox = new System.Windows.Forms.ComboBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.cuentaAutomaticaCheckBox = new System.Windows.Forms.CheckBox();
            this.iconoContraseña = new System.Windows.Forms.PictureBox();
            correoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconoContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(37, 117);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(43, 15);
            correoLabel.TabIndex = 3;
            correoLabel.Text = "Cargo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(37, 82);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 15);
            label1.TabIndex = 17;
            label1.Text = "Turno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(37, 152);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 15);
            label2.TabIndex = 21;
            label2.Text = "Contraseña:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(99, 216);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 30);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Aceptar";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(207, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.lblTitulo.Location = new System.Drawing.Point(21, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(367, 25);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "REGISTRAR NUEVO COLABORADOR";
            // 
            // cargoComboBox
            // 
            this.cargoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoComboBox.FormattingEnabled = true;
            this.cargoComboBox.Location = new System.Drawing.Point(115, 114);
            this.cargoComboBox.Name = "cargoComboBox";
            this.cargoComboBox.Size = new System.Drawing.Size(237, 24);
            this.cargoComboBox.TabIndex = 16;
            // 
            // turnoComboBox
            // 
            this.turnoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turnoComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoComboBox.FormattingEnabled = true;
            this.turnoComboBox.Location = new System.Drawing.Point(115, 79);
            this.turnoComboBox.Name = "turnoComboBox";
            this.turnoComboBox.Size = new System.Drawing.Size(237, 24);
            this.turnoComboBox.TabIndex = 18;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Enabled = false;
            this.contraseñaTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTextBox.Location = new System.Drawing.Point(115, 149);
            this.contraseñaTextBox.MaxLength = 45;
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(207, 21);
            this.contraseñaTextBox.TabIndex = 19;
            this.contraseñaTextBox.UseSystemPasswordChar = true;
            // 
            // cuentaAutomaticaCheckBox
            // 
            this.cuentaAutomaticaCheckBox.AutoSize = true;
            this.cuentaAutomaticaCheckBox.Checked = true;
            this.cuentaAutomaticaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cuentaAutomaticaCheckBox.Location = new System.Drawing.Point(115, 176);
            this.cuentaAutomaticaCheckBox.Name = "cuentaAutomaticaCheckBox";
            this.cuentaAutomaticaCheckBox.Size = new System.Drawing.Size(115, 17);
            this.cuentaAutomaticaCheckBox.TabIndex = 20;
            this.cuentaAutomaticaCheckBox.Text = "Cuenta automática";
            this.cuentaAutomaticaCheckBox.UseVisualStyleBackColor = true;
            this.cuentaAutomaticaCheckBox.CheckedChanged += new System.EventHandler(this.CuentaAutomaticaCheckBox_CheckedChanged);
            // 
            // iconoContraseña
            // 
            this.iconoContraseña.Enabled = false;
            this.iconoContraseña.Image = global::PresentationLayer.Properties.Resources.VER;
            this.iconoContraseña.Location = new System.Drawing.Point(328, 147);
            this.iconoContraseña.Name = "iconoContraseña";
            this.iconoContraseña.Size = new System.Drawing.Size(24, 24);
            this.iconoContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoContraseña.TabIndex = 22;
            this.iconoContraseña.TabStop = false;
            this.iconoContraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconoContraseña_MouseDown);
            this.iconoContraseña.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IconoContraseña_MouseUp);
            // 
            // FrmNuevoColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(408, 269);
            this.Controls.Add(this.iconoContraseña);
            this.Controls.Add(label2);
            this.Controls.Add(this.cuentaAutomaticaCheckBox);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(this.turnoComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.cargoComboBox);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(correoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevoColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            this.Load += new System.EventHandler(this.FrmNuevoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconoContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cargoComboBox;
        private System.Windows.Forms.ComboBox turnoComboBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.CheckBox cuentaAutomaticaCheckBox;
        private System.Windows.Forms.PictureBox iconoContraseña;
    }
}