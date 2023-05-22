using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace axoftTareas
{
    public partial class Form1 : Form
    {
        private Repository repository;
        private int selectedTask = 0;
        private char[] specialChars = "$#%&()[]".ToCharArray();

        public Form1()
        {
            InitializeComponent();
            repository = new Repository();

            menuItemViewActiveTasks.Checked = true;
            cmbFilter.Enabled = false;

            dataGridView1.MultiSelect = false;

            cmbState.DataSource = Enum.GetValues(typeof(State));
            cmbFilter.Items.Add(State.Activo);
            cmbFilter.Items.Add(State.Completada);
            cmbFilter.Items.Add(State.Diferida);
            cmbFilter.Items.Insert(3, "Todos");

            RefreshForm();
        }

        private void RefreshForm()
        {
            // Si el repositorio tiene la connection string inicio la grilla, sino desabilito botones
            if (repository.isConnect)
            {
                RefreshGrid();
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Name"].HeaderText = "Nombre";
                dataGridView1.Columns["Name"].Width = 250;
                dataGridView1.Columns["State"].HeaderText = "Estado";
                dataGridView1.Columns["Date"].HeaderText = "Fecha de vencimiento";

                cmbFilter.SelectedIndex = 3;

                BtnEnable(true);
                Clean();
                menuView.Enabled = true;
            }
            else
            {
                BtnEnable(false);
                menuView.Enabled = false;
            }
        }

        private void RefreshGrid()
        {

            if (menuItemViewActiveTasks.Checked)
            {
                dataGridView1.DataSource = repository.GetActive();
            }
            else
            {
                if (cmbFilter.SelectedIndex == 3)
                {
                    dataGridView1.DataSource = repository.GetAll();
                }
                else
                {
                    dataGridView1.DataSource = repository.GetByState(cmbFilter.SelectedIndex);
                }
            }
        }

        private void BtnEnable(bool enable)
        {
            btnAdd.Enabled = enable;
            btnUpdate.Enabled = enable;
            btnDelete.Enabled = enable;
            btnComplete.Enabled = enable;

            menuTasks.Enabled = enable;
        }

        private void Clean()
        {
            dataGridView1.ClearSelection();
            selectedTask = 0;

            txtBoxName.Text = String.Empty;

            dateExpiry.Checked = false;

            cmbState.SelectedIndex = 0;
        }

        // Click a Configurar base de datos
        private void menuFileDataBaseConfig_Click(object sender, EventArgs e)
        {
            using (var form = new FormConnectDB())
            {
                var result = form.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    string connStr = form.ConnString;
                    repository.SetStringCon(connStr);
                }
            }

            RefreshForm();
        }

        // Click en Ver solo tareas activas
        private void menuItemViewActiveTasks_Click(object sender, EventArgs e)
        {
            menuItemViewActiveTasks.Checked = !menuItemViewActiveTasks.Checked;
            cmbFilter.Enabled = !menuItemViewActiveTasks.Checked;
            RefreshGrid();
        }

        // Menu contextual al hacer click derecho a una tarea
        private void dataGridView1_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow dataGridViewRow1 = dataGridView1.Rows[e.RowIndex];

            dataGridView1.Rows[e.RowIndex].Selected = true;

            e.ContextMenuStrip = contextMenuStrip1;
        }

        #region Botones
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelTask.Show();
            cmbState.Enabled = false;

            BtnEnable(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panelTask.Show();

            var taskToUpdate = repository.GetById(selectedTask);

            txtBoxName.Text = taskToUpdate.Name;
            cmbState.SelectedIndex = (int)taskToUpdate.State;

            if (taskToUpdate.Date.HasValue)
            {
                dateExpiry.Value = taskToUpdate.Date.Value;
                dateExpiry.Checked = true;
            }

            BtnEnable(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (selectedTask < 1)
            {
                throw new Exception("Debe seleccionar un elemento.");
            }

            if (MessageBox.Show("Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repository.Delete(selectedTask);
                Clean();
                RefreshGrid();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

            if (selectedTask < 1)
            {
                throw new Exception("Debe seleccionar un elemento.");
            }

            repository.Complete(selectedTask);
            Clean();
            RefreshGrid();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;

            Task task = new Task() { Name = name, State = (State)cmbState.SelectedIndex };

            if (dateExpiry.Checked)
            {
                task.Date = dateExpiry.Value;
            }

            if (!name.All(char.IsLetterOrDigit) 
                && !Regex.Replace(name, @"[\w\s]", "").All(c => specialChars.Contains(c)))
            {
                throw new Exception("El nombre solo puede contener letras, numeros o los simbolos $ # %& ( ) [ ] ");
            }

            if (name.Length < 3 || name.Length > 100)
            {
                throw new Exception("El nombre de la tarea no puede ser menor a 3 o mayor a 100");
            }

            if (name.All(c => char.IsUpper(c)))
            {
                throw new Exception("El nombre no puede estar todo en mayuscula");
            }

            if(task.Date.HasValue && 
                (task.Date.Value > DateTime.Today.AddDays(30) 
                || task.Date.Value.DayOfWeek == DayOfWeek.Saturday
                || task.Date.Value.DayOfWeek == DayOfWeek.Sunday))
            {
                throw new Exception("La fecha no puede ser mayor a 30 días ni sabado ni domingo");
            }

            if (selectedTask < 1)
            {
                repository.Add(task);
            }
            else
            {
                task.Id = selectedTask;
                repository.Update(task);
            }

            panelTask.Hide();

            BtnEnable(true);
            Clean();
            RefreshGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelTask.Hide();

            BtnEnable(true);
            Clean();
        }

        #endregion

        private void dateExpiry_ValueChanged(object sender, EventArgs e)
        {
            dateExpiry.Format = DateTimePickerFormat.Long;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                selectedTask = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                BtnEnable(true);
            }
            else
            {
                BtnEnable(false);
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
