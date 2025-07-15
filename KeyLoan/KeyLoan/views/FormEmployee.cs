using KeyLoan.database;
using KeyLoan.models;
using KeyLoan.utils;
using System.Data;

namespace KeyLoan.views
{
    public partial class FormEmployee : Form
    {
        private DBEmployee dBEmployee;
        private DBEmployeeType dBEmployeeType;

        public FormEmployee()
        {
            InitializeComponent();
            dBEmployee = new DBEmployee();
            dBEmployeeType = new DBEmployeeType();
            FillTableEmployees();
            FillComboTypes();
        }

        private void FillComboTypes()
        {
            DataTable dataTable = dBEmployeeType.GetAllEmployeeTypes();
            comboBoxType.DataSource = dataTable;
            comboBoxType.DisplayMember = "description"; // Lo que se muestra
            comboBoxType.ValueMember = "id";       // El valor interno
        }

        private void FillTableEmployees()
        {
            DataTable dataTable = dBEmployee.GetAllEmployees();
            dataGridViewEmployees.DataSource = dataTable;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            textBoxDocument.Clear();
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxPhone.Clear();
            comboBoxType.SelectedIndex = -1;
            dataGridViewEmployees.ClearSelection();
            FillTableEmployees();

            buttonInsert.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Document = (string.IsNullOrEmpty(textBoxDocument.Text)) ? 0 : Convert.ToInt64(textBoxDocument.Text);
            employee.Fullname = textBoxName.Text;
            employee.Address = textBoxAddress.Text;
            employee.Phone = textBoxPhone.Text;
            employee.Type = (comboBoxType.SelectedValue == null) ? 0 : Convert.ToInt32(comboBoxType.SelectedValue);

            if (ValidateEmployee(employee))
            {
                if (dBEmployee.Insert(employee))
                {
                    MessageUtils.showInfoMessage("Empleado creado exitosamente");
                }
                else
                {
                    MessageUtils.showErrorMessage("Error al crear el empleado");
                }

                Clear();
            }
        }

        private bool ValidateEmployee(Employee employee)
        {
            if (employee.Document == 0)
            {
                MessageUtils.showErrorMessage("El documento es obligatorio!");
                return false;
            }

            if (string.IsNullOrEmpty(employee.Fullname))
            {
                MessageUtils.showErrorMessage("El nombre es obligatorio!");
                return false;
            }

            if (string.IsNullOrEmpty(employee.Address))
            {
                MessageUtils.showErrorMessage("La dirección es obligatoria");
                return false;
            }

            if (employee.Type == 0)
            {
                MessageUtils.showErrorMessage("El tipo de empleado es obligatorio!");
                return false;
            }

            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                long document = Convert.ToInt64(textBoxDocument.Text);
                if (dBEmployee.Delete(document))
                {
                    MessageUtils.showInfoMessage("Empleado eliminado exitosamente");
                }
                else
                {
                    MessageUtils.showErrorMessage("Error al eliminar el empleado");
                }

                Clear();
            }
        }


        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtener la fila seleccionada
            DataGridViewRow row = dataGridViewEmployees.Rows[e.RowIndex];
            // Asignar valores a los TextBox
            Employee employee = dBEmployee.GetEmployee(Convert.ToInt64(row.Cells["Documento"].Value.ToString()));
            textBoxDocument.Text = employee.Document.ToString();
            textBoxName.Text = employee.Fullname;
            textBoxAddress.Text = employee.Address;
            textBoxPhone.Text = employee.Phone;
            comboBoxType.SelectedValue = employee.Type;

            buttonInsert.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Document = (string.IsNullOrEmpty(textBoxDocument.Text)) ? 0 : Convert.ToInt64(textBoxDocument.Text);
            employee.Fullname = textBoxName.Text;
            employee.Address = textBoxAddress.Text;
            employee.Phone = textBoxPhone.Text;
            employee.Type = (comboBoxType.SelectedValue == null) ? 0 : Convert.ToInt32(comboBoxType.SelectedValue);

            if (ValidateEmployee(employee))
            {
                if (dBEmployee.Update(employee))
                {
                    MessageUtils.showInfoMessage("Empleado actualizado exitosamente");
                }
                else
                {
                    MessageUtils.showErrorMessage("Error al actualizar el empleado");
                }

                Clear();
            }
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            Dispose();
        }

        private void FormEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();           
        }
    }
}
