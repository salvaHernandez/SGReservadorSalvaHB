
namespace SGReservadorSalvaHB
{
    partial class FormAdmAulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmAulas));
            System.Windows.Forms.Label cod_aulaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fotoLabel;
            this.reservadorDataSet = new SGReservadorSalvaHB.reservadorDataSet();
            this.aULASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aULASTableAdapter = new SGReservadorSalvaHB.reservadorDataSetTableAdapters.AULASTableAdapter();
            this.tableAdapterManager = new SGReservadorSalvaHB.reservadorDataSetTableAdapters.TableAdapterManager();
            this.aULASBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aULASBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_aulaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            cod_aulaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservadorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aULASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aULASBindingNavigator)).BeginInit();
            this.aULASBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // reservadorDataSet
            // 
            this.reservadorDataSet.DataSetName = "reservadorDataSet";
            this.reservadorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aULASBindingSource
            // 
            this.aULASBindingSource.DataMember = "AULAS";
            this.aULASBindingSource.DataSource = this.reservadorDataSet;
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
            // aULASBindingNavigator
            // 
            this.aULASBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aULASBindingNavigator.BindingSource = this.aULASBindingSource;
            this.aULASBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aULASBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aULASBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aULASBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aULASBindingNavigatorSaveItem});
            this.aULASBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aULASBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aULASBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aULASBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aULASBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aULASBindingNavigator.Name = "aULASBindingNavigator";
            this.aULASBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aULASBindingNavigator.Size = new System.Drawing.Size(1172, 27);
            this.aULASBindingNavigator.TabIndex = 0;
            this.aULASBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // aULASBindingNavigatorSaveItem
            // 
            this.aULASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aULASBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aULASBindingNavigatorSaveItem.Image")));
            this.aULASBindingNavigatorSaveItem.Name = "aULASBindingNavigatorSaveItem";
            this.aULASBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aULASBindingNavigatorSaveItem.Text = "Guardar datos";
            this.aULASBindingNavigatorSaveItem.Click += new System.EventHandler(this.aULASBindingNavigatorSaveItem_Click);
            // 
            // cod_aulaLabel
            // 
            cod_aulaLabel.AutoSize = true;
            cod_aulaLabel.Location = new System.Drawing.Point(299, 231);
            cod_aulaLabel.Name = "cod_aulaLabel";
            cod_aulaLabel.Size = new System.Drawing.Size(68, 17);
            cod_aulaLabel.TabIndex = 1;
            cod_aulaLabel.Text = "Cod aula:";
            // 
            // cod_aulaTextBox
            // 
            this.cod_aulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aULASBindingSource, "Cod_aula", true));
            this.cod_aulaTextBox.Location = new System.Drawing.Point(435, 226);
            this.cod_aulaTextBox.Name = "cod_aulaTextBox";
            this.cod_aulaTextBox.Size = new System.Drawing.Size(341, 22);
            this.cod_aulaTextBox.TabIndex = 2;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(299, 275);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aULASBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(435, 272);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(341, 22);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(299, 325);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(40, 17);
            fotoLabel.TabIndex = 5;
            fotoLabel.Text = "Foto:";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.aULASBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(435, 325);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(341, 180);
            this.fotoPictureBox.TabIndex = 6;
            this.fotoPictureBox.TabStop = false;
            // 
            // FormAdmAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1172, 802);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(cod_aulaLabel);
            this.Controls.Add(this.cod_aulaTextBox);
            this.Controls.Add(this.aULASBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmAulas";
            this.Text = "FormAdmAulas";
            this.Load += new System.EventHandler(this.FormAdmAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservadorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aULASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aULASBindingNavigator)).EndInit();
            this.aULASBindingNavigator.ResumeLayout(false);
            this.aULASBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private reservadorDataSet reservadorDataSet;
        private System.Windows.Forms.BindingSource aULASBindingSource;
        private reservadorDataSetTableAdapters.AULASTableAdapter aULASTableAdapter;
        private reservadorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aULASBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aULASBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_aulaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
    }
}