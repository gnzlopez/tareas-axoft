namespace axoftTareas
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileDataBaseConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTasksAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTasksUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTasksDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTasksComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewActiveTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTask = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dateExpiry = new System.Windows.Forms.DateTimePicker();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarComoCompletadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(581, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(565, 410);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dataGridView1_RowContextMenuStripNeeded);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(581, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(185, 60);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(581, 225);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(185, 60);
            this.btnComplete.TabIndex = 3;
            this.btnComplete.Text = "Marcar como completada";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(581, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 60);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuTasks,
            this.menuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileDataBaseConfig});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(60, 20);
            this.menuFile.Text = "Archivo";
            // 
            // menuFileDataBaseConfig
            // 
            this.menuFileDataBaseConfig.Name = "menuFileDataBaseConfig";
            this.menuFileDataBaseConfig.Size = new System.Drawing.Size(218, 22);
            this.menuFileDataBaseConfig.Text = "Configurar la base de datos";
            this.menuFileDataBaseConfig.Click += new System.EventHandler(this.menuFileDataBaseConfig_Click);
            // 
            // menuTasks
            // 
            this.menuTasks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTasksAdd,
            this.menuTasksUpdate,
            this.menuTasksDelete,
            this.menuTasksComplete});
            this.menuTasks.Name = "menuTasks";
            this.menuTasks.Size = new System.Drawing.Size(51, 20);
            this.menuTasks.Text = "Tareas";
            // 
            // menuTasksAdd
            // 
            this.menuTasksAdd.Name = "menuTasksAdd";
            this.menuTasksAdd.Size = new System.Drawing.Size(211, 22);
            this.menuTasksAdd.Text = "Agregar";
            this.menuTasksAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuTasksUpdate
            // 
            this.menuTasksUpdate.Name = "menuTasksUpdate";
            this.menuTasksUpdate.Size = new System.Drawing.Size(211, 22);
            this.menuTasksUpdate.Text = "Modificar";
            this.menuTasksUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuTasksDelete
            // 
            this.menuTasksDelete.Name = "menuTasksDelete";
            this.menuTasksDelete.Size = new System.Drawing.Size(211, 22);
            this.menuTasksDelete.Text = "Eliminar";
            this.menuTasksDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuTasksComplete
            // 
            this.menuTasksComplete.Name = "menuTasksComplete";
            this.menuTasksComplete.Size = new System.Drawing.Size(211, 22);
            this.menuTasksComplete.Text = "Marcar como completada";
            this.menuTasksComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // menuView
            // 
            this.menuView.Checked = true;
            this.menuView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewActiveTasks});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(35, 20);
            this.menuView.Text = "Ver";
            // 
            // menuItemViewActiveTasks
            // 
            this.menuItemViewActiveTasks.Name = "menuItemViewActiveTasks";
            this.menuItemViewActiveTasks.Size = new System.Drawing.Size(188, 22);
            this.menuItemViewActiveTasks.Text = "Ver solo tareas activas";
            this.menuItemViewActiveTasks.Click += new System.EventHandler(this.menuItemViewActiveTasks_Click);
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.btnCancel);
            this.panelTask.Controls.Add(this.cmbState);
            this.panelTask.Controls.Add(this.labelDate);
            this.panelTask.Controls.Add(this.lblState);
            this.panelTask.Controls.Add(this.lblName);
            this.panelTask.Controls.Add(this.dateExpiry);
            this.panelTask.Controls.Add(this.txtBoxName);
            this.panelTask.Controls.Add(this.btnAccept);
            this.panelTask.Location = new System.Drawing.Point(12, 27);
            this.panelTask.Name = "panelTask";
            this.panelTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelTask.Size = new System.Drawing.Size(565, 411);
            this.panelTask.TabIndex = 7;
            this.panelTask.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(426, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 39);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(135, 107);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(310, 28);
            this.cmbState.TabIndex = 8;
            this.cmbState.Text = "Seleccione un estado";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(24, 151);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(93, 40);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Fecha de \r\nvencimiento";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(52, 110);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 20);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "Estado";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(52, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre";
            // 
            // dateExpiry
            // 
            this.dateExpiry.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateExpiry.Checked = false;
            this.dateExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExpiry.Location = new System.Drawing.Point(135, 165);
            this.dateExpiry.Name = "dateExpiry";
            this.dateExpiry.ShowCheckBox = true;
            this.dateExpiry.Size = new System.Drawing.Size(310, 26);
            this.dateExpiry.TabIndex = 3;
            this.dateExpiry.ValueChanged += new System.EventHandler(this.dateExpiry_ValueChanged);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(135, 58);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(310, 26);
            this.txtBoxName.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(309, 351);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(111, 39);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.marcarComoCompletadaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 92);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // marcarComoCompletadaToolStripMenuItem
            // 
            this.marcarComoCompletadaToolStripMenuItem.Name = "marcarComoCompletadaToolStripMenuItem";
            this.marcarComoCompletadaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.marcarComoCompletadaToolStripMenuItem.Text = "Marcar como completada";
            this.marcarComoCompletadaToolStripMenuItem.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(583, 312);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(129, 20);
            this.lblFilter.TabIndex = 10;
            this.lblFilter.Text = "Filtrar por estado";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(587, 344);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(179, 28);
            this.cmbFilter.TabIndex = 10;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuTasks;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewActiveTasks;
        private System.Windows.Forms.ToolStripMenuItem menuFileDataBaseConfig;
        private System.Windows.Forms.ToolStripMenuItem menuTasksAdd;
        private System.Windows.Forms.ToolStripMenuItem menuTasksUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuTasksDelete;
        private System.Windows.Forms.ToolStripMenuItem menuTasksComplete;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dateExpiry;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarComoCompletadaToolStripMenuItem;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}

