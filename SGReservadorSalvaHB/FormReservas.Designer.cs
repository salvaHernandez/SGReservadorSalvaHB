
namespace SGReservadorSalvaHB
{
    partial class FormReservas
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label descripcionLabel;
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.aULASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservadorDataSet = new SGReservadorSalvaHB.reservadorDataSet();
            this.dtpkFecha = new System.Windows.Forms.DateTimePicker();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.CBX = new System.Windows.Forms.ComboBox();
            this.reservasfkaulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasfkaulBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtgvHorario = new System.Windows.Forms.DataGridView();
            this.dtgcAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aULASTableAdapter = new SGReservadorSalvaHB.reservadorDataSetTableAdapters.AULASTableAdapter();
            this.tableAdapterManager = new SGReservadorSalvaHB.reservadorDataSetTableAdapters.TableAdapterManager();
            this.rESERVASTableAdapter = new SGReservadorSalvaHB.reservadorDataSetTableAdapters.RESERVASTableAdapter();
            this.rESERVASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new SGReservadorSalvaHB.reservadorDataSetTableAdapters.USUARIOSTableAdapter();
            this.btnReservar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aULASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservadorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasfkaulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasfkaulBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(691, 122);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 17);
            label1.TabIndex = 4;
            label1.Text = "Fecha: ";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(277, 122);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripcion:";
            // 
            // pboxImagen
            // 
            this.pboxImagen.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.aULASBindingSource, "Foto", true));
            this.pboxImagen.Location = new System.Drawing.Point(476, 178);
            this.pboxImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(289, 164);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 3;
            this.pboxImagen.TabStop = false;
            // 
            // aULASBindingSource
            // 
            this.aULASBindingSource.DataMember = "AULAS";
            this.aULASBindingSource.DataSource = this.reservadorDataSet;
            // 
            // reservadorDataSet
            // 
            this.reservadorDataSet.DataSetName = "reservadorDataSet";
            this.reservadorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpkFecha
            // 
            this.dtpkFecha.Location = new System.Drawing.Point(751, 122);
            this.dtpkFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkFecha.Name = "dtpkFecha";
            this.dtpkFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpkFecha.TabIndex = 5;
            this.dtpkFecha.Value = new System.DateTime(2022, 4, 26, 0, 0, 0, 0);
            this.dtpkFecha.ValueChanged += new System.EventHandler(this.dtpkFecha_ValueChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(581, 361);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // CBX
            // 
            this.CBX.FormattingEnabled = true;
            this.CBX.Location = new System.Drawing.Point(372, 118);
            this.CBX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBX.Name = "CBX";
            this.CBX.Size = new System.Drawing.Size(160, 24);
            this.CBX.TabIndex = 7;
            this.CBX.SelectedIndexChanged += new System.EventHandler(this.CBX_SelectedIndexChanged);
            // 
            // reservasfkaulBindingSource
            // 
            this.reservasfkaulBindingSource.DataMember = "reservas_fk_aul";
            this.reservasfkaulBindingSource.DataSource = this.aULASBindingSource;
            // 
            // reservasfkaulBindingSource1
            // 
            this.reservasfkaulBindingSource1.DataMember = "reservas_fk_aul";
            this.reservasfkaulBindingSource1.DataSource = this.aULASBindingSource;
            // 
            // dtgvHorario
            // 
            this.dtgvHorario.AllowUserToDeleteRows = false;
            this.dtgvHorario.AllowUserToResizeColumns = false;
            this.dtgvHorario.AllowUserToResizeRows = false;
            this.dtgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgcAula,
            this.dtgcUsuario,
            this.dtgcHora,
            this.dtgcLibre});
            this.dtgvHorario.Location = new System.Drawing.Point(256, 407);
            this.dtgvHorario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvHorario.Name = "dtgvHorario";
            this.dtgvHorario.RowHeadersWidth = 51;
            this.dtgvHorario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHorario.Size = new System.Drawing.Size(721, 191);
            this.dtgvHorario.TabIndex = 9;
            this.dtgvHorario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHorario_CellClick);
            // 
            // dtgcAula
            // 
            this.dtgcAula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgcAula.HeaderText = "Aula";
            this.dtgcAula.MinimumWidth = 6;
            this.dtgcAula.Name = "dtgcAula";
            // 
            // dtgcUsuario
            // 
            this.dtgcUsuario.HeaderText = "Usuario";
            this.dtgcUsuario.MinimumWidth = 6;
            this.dtgcUsuario.Name = "dtgcUsuario";
            // 
            // dtgcHora
            // 
            this.dtgcHora.HeaderText = "Hora";
            this.dtgcHora.MinimumWidth = 6;
            this.dtgcHora.Name = "dtgcHora";
            // 
            // dtgcLibre
            // 
            this.dtgcLibre.HeaderText = "Libre";
            this.dtgcLibre.MinimumWidth = 6;
            this.dtgcLibre.Name = "dtgcLibre";
            // 
            // aULASTableAdapter
            // 
            this.aULASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AULASTableAdapter = this.aULASTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PERFILESTableAdapter = null;
            this.tableAdapterManager.RESERVASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGReservadorSalvaHB.reservadorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // rESERVASTableAdapter
            // 
            this.rESERVASTableAdapter.ClearBeforeFill = true;
            // 
            // rESERVASBindingSource
            // 
            this.rESERVASBindingSource.DataMember = "RESERVAS";
            this.rESERVASBindingSource.DataSource = this.reservadorDataSet;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.reservadorDataSet;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(581, 624);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1172, 802);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtgvHorario);
            this.Controls.Add(this.CBX);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dtpkFecha);
            this.Controls.Add(label1);
            this.Controls.Add(this.pboxImagen);
            this.Controls.Add(descripcionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aULASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservadorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasfkaulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasfkaulBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private reservadorDataSet reservadorDataSet;
        private System.Windows.Forms.BindingSource aULASBindingSource;
        private reservadorDataSetTableAdapters.AULASTableAdapter aULASTableAdapter;
        private reservadorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pboxImagen;
        private System.Windows.Forms.DateTimePicker dtpkFecha;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox CBX;
        private System.Windows.Forms.BindingSource reservasfkaulBindingSource;
        private reservadorDataSetTableAdapters.RESERVASTableAdapter rESERVASTableAdapter;
        private System.Windows.Forms.BindingSource reservasfkaulBindingSource1;
        private System.Windows.Forms.DataGridView dtgvHorario;
        private System.Windows.Forms.BindingSource rESERVASBindingSource;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private reservadorDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgcAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgcUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgcHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgcLibre;
        private System.Windows.Forms.Button btnReservar;
    }
}