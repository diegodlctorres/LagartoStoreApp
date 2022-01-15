
namespace PresentationLayer
{
    partial class FrmNuevoTurno
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horaFinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            apellidoLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(64, 107);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(68, 15);
            apellidoLabel.TabIndex = 1;
            apellidoLabel.Text = "Hora Inicio:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dniLabel.Location = new System.Drawing.Point(64, 142);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(55, 15);
            dniLabel.TabIndex = 5;
            dniLabel.Text = "Hora Fin:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(64, 72);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(53, 15);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(145, 69);
            this.nombreTextBox.MaxLength = 45;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(120, 21);
            this.nombreTextBox.TabIndex = 0;
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextBox_KeyPress);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(59, 186);
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
            this.btnCancelar.Location = new System.Drawing.Point(167, 186);
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
            this.lblTitulo.Location = new System.Drawing.Point(27, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(274, 25);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "REGISTRAR NUEVO TURNO";
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataSource = typeof(BusinessLayer.Turno);
            // 
            // horaFinDateTimePicker
            // 
            this.horaFinDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.turnoBindingSource, "HoraFin", true));
            this.horaFinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaFinDateTimePicker.Location = new System.Drawing.Point(145, 139);
            this.horaFinDateTimePicker.Name = "horaFinDateTimePicker";
            this.horaFinDateTimePicker.ShowUpDown = true;
            this.horaFinDateTimePicker.Size = new System.Drawing.Size(67, 20);
            this.horaFinDateTimePicker.TabIndex = 17;
            this.horaFinDateTimePicker.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // horaInicioDateTimePicker
            // 
            this.horaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.turnoBindingSource, "HoraInicio", true));
            this.horaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaInicioDateTimePicker.Location = new System.Drawing.Point(145, 104);
            this.horaInicioDateTimePicker.Name = "horaInicioDateTimePicker";
            this.horaInicioDateTimePicker.ShowUpDown = true;
            this.horaInicioDateTimePicker.Size = new System.Drawing.Size(67, 20);
            this.horaInicioDateTimePicker.TabIndex = 19;
            this.horaInicioDateTimePicker.Value = new System.DateTime(2022, 1, 6, 0, 0, 0, 0);
            // 
            // FrmNuevoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(328, 244);
            this.Controls.Add(this.horaFinDateTimePicker);
            this.Controls.Add(this.horaInicioDateTimePicker);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(dniLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevoTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private System.Windows.Forms.DateTimePicker horaFinDateTimePicker;
        private System.Windows.Forms.DateTimePicker horaInicioDateTimePicker;
    }
}