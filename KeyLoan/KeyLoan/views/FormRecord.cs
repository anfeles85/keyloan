using KeyLoan.database;
using KeyLoan.models;
using KeyLoan.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace KeyLoan.views
{
    public partial class FormRecord : Form
    {
        private DBRecord dBRecord;
        private DBKeyRoom dBKeyRoom;
        private DBEmployee dBEmployee;

        public FormRecord()
        {
            InitializeComponent();
            dBEmployee = new DBEmployee();
            dBKeyRoom = new DBKeyRoom();
            dBRecord = new DBRecord();
            FillTableRecords();
            FillCombos();
        }

        private void FillTableRecords()
        {
            DataTable dataTable = dBRecord.GetAllRecords();
            dataGridViewRecords.DataSource = dataTable;
        }

        private void FillCombos()
        {
            DataTable dataTable = dBEmployee.GetAllEmployees();
            comboBoxEmployees.DataSource = dataTable;
            comboBoxEmployees.DisplayMember = "Nombre";
            comboBoxEmployees.ValueMember = "Documento";

            dataTable = dBKeyRoom.GetAllKeys();
            comboBoxKeys.DataSource = dataTable;
            comboBoxKeys.DisplayMember = "Nombre";
            comboBoxKeys.ValueMember = "Id";
        }

        private void Clear()
        {
            textBoxId.Clear();
            dateTimePickerDate.Value = DateTime.Now;
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
            comboBoxEmployees.SelectedIndex = -1;
            comboBoxKeys.SelectedIndex = -1;
            dataGridViewRecords.ClearSelection();
            buttonInsert.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            FillTableRecords();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool ValidateRecord(Record record)
        {
            if (string.IsNullOrEmpty(record.DateRecord))
            {
                MessageUtils.showErrorMessage("La fecha es obligatoria!");
                return false;
            }

            if (string.IsNullOrEmpty(record.StartTime))
            {
                MessageUtils.showErrorMessage("La hora de inicio es obligatoria");
                return false;
            }

            if (record.EmployeeId == 0)
            {
                MessageUtils.showErrorMessage("El empleado es obligatorio!");
                return false;
            }

            if (record.KeyId == 0)
            {
                MessageUtils.showErrorMessage("La llave es obligatoria!");
                return false;
            }

            if (string.IsNullOrEmpty(record.Status))
            {
                MessageUtils.showErrorMessage("El estado es obligatorio");
                return false;
            }

            return true;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.DateRecord = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            record.StartTime = dateTimePickerStart.Value.ToString("HH:mm");
            record.EndTime = dateTimePickerEnd.Value.ToString("HH:mm");
            record.EmployeeId = (long)comboBoxEmployees.SelectedValue;
            record.KeyId = (int)comboBoxKeys.SelectedValue;
            record.Status = comboBoxStatus.SelectedValue.ToString();

            if (ValidateRecord(record))
            {
                if (dBRecord.Insert(record))
                {
                    MessageUtils.showInfoMessage("Registro insertado correctamente.");
                    Clear();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.Id = int.Parse(textBoxId.Text);
            record.DateRecord = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            record.StartTime = dateTimePickerStart.Value.ToString("HH:mm");
            record.EndTime = dateTimePickerEnd.Value.ToString("HH:mm");
            record.EmployeeId = (long)comboBoxEmployees.SelectedValue;
            record.KeyId = (int)comboBoxKeys.SelectedValue;
            record.Status = comboBoxStatus.SelectedItem.ToString();

            if (ValidateRecord(record))
            {
                if (dBRecord.Update(record))
                {
                    MessageUtils.showInfoMessage("Registro actualizado correctamente.");
                    Clear();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (dBRecord.Delete(id))
                {
                    MessageUtils.showInfoMessage("Registro eliminado exitosamente");
                }
                else
                {
                    MessageUtils.showErrorMessage("Error al eliminar el registro");
                }

                Clear();
            }
        }

        

        private void dataGridViewRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtener la fila seleccionada
            DataGridViewRow row = dataGridViewRecords.Rows[e.RowIndex];
            // Asignar valores a los TextBox
            Record record = dBRecord.GetRecord(Convert.ToInt32(row.Cells["Id"].Value.ToString()));
            textBoxId.Text = record.Id.ToString();
            dateTimePickerDate.Text = record.DateRecord;
            dateTimePickerStart.Text = record.StartTime;
            dateTimePickerEnd.Text = record.EndTime;
            comboBoxEmployees.SelectedValue = record.EmployeeId;
            comboBoxKeys.SelectedValue = record.KeyId;
            comboBoxStatus.SelectedItem = record.Status;

            buttonInsert.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            Dispose();
        }

        private void FormRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
