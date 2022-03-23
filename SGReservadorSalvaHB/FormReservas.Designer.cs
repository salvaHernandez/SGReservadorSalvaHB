
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label label1;
            this.cbxAulas = new System.Windows.Forms.ComboBox();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.aULASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservadorDataSet = new SGReservadorSalvaHB.reservadorDataSet();
            this.aULASTableAdapter = new SGReservadorSalvaHB.reservadorDataSetTableAdapters.AULASTableAdapter();
            this.tableAdapterManager = new SGReservadorSalvaHB.reservadorDataSetTableAdapters.TableAdapterManager();
            descripcionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aULASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservadorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(278, 122);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripcion:";
            // 
            // cbxAulas
            // 
            this.cbxAulas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aULASBindingSource, "Descripcion", true));
            this.cbxAulas.FormattingEnabled = true;
            this.cbxAulas.Location = new System.Drawing.Point(370, 119);
            this.cbxAulas.Name = "cbxAulas";
            this.cbxAulas.Size = new System.Drawing.Size(121, 24);
            this.cbxAulas.TabIndex = 2;
            this.cbxAulas.SelectedIndexChanged += new System.EventHandler(this.cbxAulas_SelectedIndexChanged);
            // 
            // pboxImagen
            // 
            this.pboxImagen.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.aULASBindingSource, "Foto", true));
            this.pboxImagen.Location = new System.Drawing.Point(476, 179);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(289, 164);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 3;
            this.pboxImagen.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(690, 122);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 17);
            label1.TabIndex = 4;
            label1.Text = "Fecha: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(751, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(581, 361);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
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
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1172, 802);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(label1);
            this.Controls.Add(this.pboxImagen);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.cbxAulas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aULASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservadorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private reservadorDataSet reservadorDataSet;
        private System.Windows.Forms.BindingSource aULASBindingSource;
        private reservadorDataSetTableAdapters.AULASTableAdapter aULASTableAdapter;
        private reservadorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxAulas;
        private System.Windows.Forms.PictureBox pboxImagen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnMostrar;
    }
}