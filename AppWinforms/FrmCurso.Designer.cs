namespace AppWinforms
{
    partial class FrmCurso
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
            System.Windows.Forms.Label nombreCursoLabel;
            System.Windows.Forms.Label nombreProfesorLabel;
            System.Windows.Forms.Label fechaInicioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCurso));
            this.cursoDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoDtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nombreCursoTextBox = new System.Windows.Forms.TextBox();
            this.nombreProfesorTextBox = new System.Windows.Forms.TextBox();
            this.fechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cursoDtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreCursoLabel = new System.Windows.Forms.Label();
            nombreProfesorLabel = new System.Windows.Forms.Label();
            fechaInicioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDtoBindingNavigator)).BeginInit();
            this.cursoDtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreCursoLabel
            // 
            nombreCursoLabel.AutoSize = true;
            nombreCursoLabel.Location = new System.Drawing.Point(12, 49);
            nombreCursoLabel.Name = "nombreCursoLabel";
            nombreCursoLabel.Size = new System.Drawing.Size(79, 13);
            nombreCursoLabel.TabIndex = 1;
            nombreCursoLabel.Text = "Nombre Curso:";
            // 
            // nombreProfesorLabel
            // 
            nombreProfesorLabel.AutoSize = true;
            nombreProfesorLabel.Location = new System.Drawing.Point(12, 76);
            nombreProfesorLabel.Name = "nombreProfesorLabel";
            nombreProfesorLabel.Size = new System.Drawing.Size(92, 13);
            nombreProfesorLabel.TabIndex = 3;
            nombreProfesorLabel.Text = "Nombre Profesor:";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.Location = new System.Drawing.Point(12, 104);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new System.Drawing.Size(68, 13);
            fechaInicioLabel.TabIndex = 5;
            fechaInicioLabel.Text = "Fecha Inicio:";
            // 
            // cursoDtoBindingSource
            // 
            this.cursoDtoBindingSource.DataSource = typeof(DataTransferObjects.Dto.CursoDto);
            // 
            // cursoDtoBindingNavigator
            // 
            this.cursoDtoBindingNavigator.AddNewItem = null;
            this.cursoDtoBindingNavigator.BindingSource = this.listaCursosBindingSource;
            this.cursoDtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cursoDtoBindingNavigator.DeleteItem = null;
            this.cursoDtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.cursoDtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cursoDtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cursoDtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cursoDtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cursoDtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cursoDtoBindingNavigator.Name = "cursoDtoBindingNavigator";
            this.cursoDtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cursoDtoBindingNavigator.Size = new System.Drawing.Size(710, 25);
            this.cursoDtoBindingNavigator.TabIndex = 0;
            this.cursoDtoBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaCursosBindingSource
            // 
            this.listaCursosBindingSource.DataSource = typeof(DataTransferObjects.Dto.CursoDto);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nombreCursoTextBox
            // 
            this.nombreCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoDtoBindingSource, "NombreCurso", true));
            this.nombreCursoTextBox.Location = new System.Drawing.Point(109, 46);
            this.nombreCursoTextBox.Name = "nombreCursoTextBox";
            this.nombreCursoTextBox.Size = new System.Drawing.Size(200, 21);
            this.nombreCursoTextBox.TabIndex = 2;
            // 
            // nombreProfesorTextBox
            // 
            this.nombreProfesorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoDtoBindingSource, "NombreProfesor", true));
            this.nombreProfesorTextBox.Location = new System.Drawing.Point(109, 73);
            this.nombreProfesorTextBox.Name = "nombreProfesorTextBox";
            this.nombreProfesorTextBox.Size = new System.Drawing.Size(200, 21);
            this.nombreProfesorTextBox.TabIndex = 4;
            // 
            // fechaInicioDateTimePicker
            // 
            this.fechaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursoDtoBindingSource, "FechaInicio", true));
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(109, 100);
            this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
            this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.fechaInicioDateTimePicker.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(572, 126);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(126, 23);
            this.btnListar.TabIndex = 13;
            this.btnListar.Text = "Li&star";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(572, 100);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "E&liminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Location = new System.Drawing.Point(572, 74);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(126, 23);
            this.btnGrabar.TabIndex = 15;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(572, 48);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(126, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(572, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(126, 23);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cursoDtoDataGridView
            // 
            this.cursoDtoDataGridView.AllowUserToAddRows = false;
            this.cursoDtoDataGridView.AllowUserToDeleteRows = false;
            this.cursoDtoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cursoDtoDataGridView.AutoGenerateColumns = false;
            this.cursoDtoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cursoDtoDataGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.cursoDtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursoDtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cursoDtoDataGridView.DataSource = this.listaCursosBindingSource;
            this.cursoDtoDataGridView.Location = new System.Drawing.Point(15, 165);
            this.cursoDtoDataGridView.Name = "cursoDtoDataGridView";
            this.cursoDtoDataGridView.ReadOnly = true;
            this.cursoDtoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cursoDtoDataGridView.Size = new System.Drawing.Size(683, 253);
            this.cursoDtoDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCurso";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Curso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaInicio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha de Inicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreProfesor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre del Profesor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 430);
            this.Controls.Add(this.cursoDtoDataGridView);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(fechaInicioLabel);
            this.Controls.Add(this.fechaInicioDateTimePicker);
            this.Controls.Add(nombreProfesorLabel);
            this.Controls.Add(this.nombreProfesorTextBox);
            this.Controls.Add(nombreCursoLabel);
            this.Controls.Add(this.nombreCursoTextBox);
            this.Controls.Add(this.cursoDtoBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.cursoDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDtoBindingNavigator)).EndInit();
            this.cursoDtoBindingNavigator.ResumeLayout(false);
            this.cursoDtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cursoDtoBindingSource;
        private System.Windows.Forms.BindingNavigator cursoDtoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox nombreCursoTextBox;
        private System.Windows.Forms.TextBox nombreProfesorTextBox;
        private System.Windows.Forms.DateTimePicker fechaInicioDateTimePicker;
        private System.Windows.Forms.BindingSource listaCursosBindingSource;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView cursoDtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}