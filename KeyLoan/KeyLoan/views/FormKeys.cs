using KeyLoan.database;
using KeyLoan.models;
using KeyLoan.utils;
using System.Data;

namespace KeyLoan.views
{
    public partial class FormKeys : Form
    {
        private DBKeyRoom dBKey;

        public FormKeys()
        {
            InitializeComponent();
            dBKey = new DBKeyRoom();
            FillTableKeys();
        }

        private void FillTableKeys()
        {
            DataTable dataTable = dBKey.GetAllKeys();
            dataGridViewKeys.DataSource = dataTable;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            textBoxId.Text = "";
            textBoxCount.Text = "";
            textBoxName.Text = "";
            textBoxRoom.Text = "";
            textBoxObservation.Text = "";
            FillTableKeys();
            dataGridViewKeys.ClearSelection();

            buttonInsert.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private bool ValidateKey(KeyRoom key)
        {

            if (string.IsNullOrEmpty(key.Name))
            {
                MessageUtils.showErrorMessage("El nombre es obligatorio!");
                return false;
            }

            if (string.IsNullOrEmpty(key.Room))
            {
                MessageUtils.showErrorMessage("El aula es obligatoria");
                return false;
            }

            if (key.Count == 0)
            {
                MessageUtils.showErrorMessage("La cantidad es obligatoria!");
                return false;
            }

            return true;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            KeyRoom key = new KeyRoom();
            key.Name = textBoxName.Text;
            key.Room = textBoxRoom.Text;
            key.Count = Convert.ToInt32(textBoxCount.Text);
            key.Observation = textBoxObservation.Text;

            if (ValidateKey(key))
            {
                if (dBKey.Insert(key))
                {
                    MessageUtils.showInfoMessage("Llave creada exitosamente");
                }
                else
                {
                    MessageUtils.showErrorMessage("Error al crear la llave");
                }

                Clear();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            KeyRoom key = new KeyRoom();
            key.Id = Convert.ToInt32(textBoxId.Text);
            key.Name = textBoxName.Text;
            key.Room = textBoxRoom.Text;
            key.Count = Convert.ToInt32(textBoxCount.Text);
            key.Observation = textBoxObservation.Text;

            if (ValidateKey(key))
            {
                if (dBKey.Update(key))
                {
                    MessageUtils.showInfoMessage("Llave actualizada exitosamente");
                }
                else
                {
                    MessageUtils.showErrorMessage("Error al actualizar la llave");
                }

                Clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (dBKey.Delete(id))
                {
                    MessageUtils.showInfoMessage("Llave eliminada exitosamente");
                }
                else
                {
                    MessageUtils.showErrorMessage("Error al eliminar la llave");
                }

                Clear();
            }
        }

        private void dataGridViewKeys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtener la fila seleccionada
            DataGridViewRow row = dataGridViewKeys.Rows[e.RowIndex];
            // Asignar valores a los TextBox
            KeyRoom key = dBKey.GetKey(Convert.ToInt32(row.Cells["Id"].Value.ToString()));

            textBoxId.Text = key.Id.ToString();
            textBoxName.Text = key.Name;
            textBoxRoom.Text = key.Room;
            textBoxCount.Text = key.Count.ToString();
            textBoxObservation.Text = key.Observation;

            buttonInsert.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            Close();
        }

        private void FormKeys_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
