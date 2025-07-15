namespace KeyLoan.views
{
    partial class FormRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecord));
            pictureBoxHome = new PictureBox();
            labelTitle = new Label();
            dataGridViewRecords = new DataGridView();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonInsert = new Button();
            labelId = new Label();
            labelEmployee = new Label();
            labelDate = new Label();
            labelStartTime = new Label();
            labelKey = new Label();
            labelStatus = new Label();
            labelEndTime = new Label();
            textBoxId = new TextBox();
            dateTimePickerDate = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            comboBoxEmployees = new ComboBox();
            comboBoxKeys = new ComboBox();
            comboBoxStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Cursor = Cursors.Hand;
            pictureBoxHome.Image = (Image)resources.GetObject("pictureBoxHome.Image");
            pictureBoxHome.Location = new Point(12, 12);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(37, 31);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex = 17;
            pictureBoxHome.TabStop = false;
            pictureBoxHome.Click += pictureBoxHome_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(532, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(100, 28);
            labelTitle.TabIndex = 18;
            labelTitle.Text = "Registros";
            // 
            // dataGridViewRecords
            // 
            dataGridViewRecords.AllowUserToAddRows = false;
            dataGridViewRecords.AllowUserToDeleteRows = false;
            dataGridViewRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecords.Location = new Point(50, 255);
            dataGridViewRecords.MultiSelect = false;
            dataGridViewRecords.Name = "dataGridViewRecords";
            dataGridViewRecords.RowHeadersWidth = 51;
            dataGridViewRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecords.Size = new Size(1076, 232);
            dataGridViewRecords.TabIndex = 19;
            dataGridViewRecords.CellClick += dataGridViewRecords_CellClick;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.Highlight;
            buttonClear.ForeColor = SystemColors.ButtonHighlight;
            buttonClear.Location = new Point(764, 204);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 23;
            buttonClear.Text = "Limpiar";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.Highlight;
            buttonDelete.Enabled = false;
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(609, 204);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 22;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.Highlight;
            buttonUpdate.Enabled = false;
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(459, 204);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "Modificar";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.BackColor = SystemColors.Highlight;
            buttonInsert.ForeColor = SystemColors.ButtonHighlight;
            buttonInsert.Location = new Point(310, 204);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 20;
            buttonInsert.Text = "Crear";
            buttonInsert.UseVisualStyleBackColor = false;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelId.Location = new Point(54, 78);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 20);
            labelId.TabIndex = 24;
            labelId.Text = "Id:";
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEmployee.Location = new Point(54, 133);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(82, 20);
            labelEmployee.TabIndex = 25;
            labelEmployee.Text = "Empleado:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDate.Location = new Point(301, 78);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(53, 20);
            labelDate.TabIndex = 26;
            labelDate.Text = "Fecha:";
            // 
            // labelStartTime
            // 
            labelStartTime.AutoSize = true;
            labelStartTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelStartTime.Location = new Point(600, 78);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(88, 20);
            labelStartTime.TabIndex = 27;
            labelStartTime.Text = "Hora inicio:";
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelKey.Location = new Point(448, 137);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(49, 20);
            labelKey.TabIndex = 28;
            labelKey.Text = "Llave:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelStatus.Location = new Point(843, 139);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(60, 20);
            labelStatus.TabIndex = 29;
            labelStatus.Text = "Estado:";
            // 
            // labelEndTime
            // 
            labelEndTime.AutoSize = true;
            labelEndTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEndTime.Location = new Point(887, 78);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(70, 20);
            labelEndTime.TabIndex = 30;
            labelEndTime.Text = "Hora fin:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(143, 75);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 31;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDate.Location = new Point(382, 75);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(173, 27);
            dateTimePickerDate.TabIndex = 32;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Format = DateTimePickerFormat.Time;
            dateTimePickerStart.Location = new Point(721, 75);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.ShowUpDown = true;
            dateTimePickerStart.Size = new Size(129, 27);
            dateTimePickerStart.TabIndex = 33;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Format = DateTimePickerFormat.Time;
            dateTimePickerEnd.Location = new Point(997, 75);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.ShowUpDown = true;
            dateTimePickerEnd.Size = new Size(129, 27);
            dateTimePickerEnd.TabIndex = 34;
            // 
            // comboBoxEmployees
            // 
            comboBoxEmployees.FormattingEnabled = true;
            comboBoxEmployees.Location = new Point(143, 131);
            comboBoxEmployees.Name = "comboBoxEmployees";
            comboBoxEmployees.Size = new Size(250, 28);
            comboBoxEmployees.TabIndex = 35;
            // 
            // comboBoxKeys
            // 
            comboBoxKeys.FormattingEnabled = true;
            comboBoxKeys.Location = new Point(521, 131);
            comboBoxKeys.Name = "comboBoxKeys";
            comboBoxKeys.Size = new Size(252, 28);
            comboBoxKeys.TabIndex = 36;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "PENDIENTE", "ENTREGADO", "CANCELADO" });
            comboBoxStatus.Location = new Point(944, 130);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(182, 28);
            comboBoxStatus.TabIndex = 37;
            // 
            // FormRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 499);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxKeys);
            Controls.Add(comboBoxEmployees);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerDate);
            Controls.Add(textBoxId);
            Controls.Add(labelEndTime);
            Controls.Add(labelStatus);
            Controls.Add(labelKey);
            Controls.Add(labelStartTime);
            Controls.Add(labelDate);
            Controls.Add(labelEmployee);
            Controls.Add(labelId);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Controls.Add(dataGridViewRecords);
            Controls.Add(labelTitle);
            Controls.Add(pictureBoxHome);
            Name = "FormRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            FormClosed += FormRecord_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxHome;
        private Label labelTitle;
        private DataGridView dataGridViewRecords;
        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonInsert;
        private Label labelId;
        private Label labelEmployee;
        private Label labelDate;
        private Label labelStartTime;
        private Label labelKey;
        private Label labelStatus;
        private Label labelEndTime;
        private TextBox textBoxId;
        private DateTimePicker dateTimePickerDate;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private ComboBox comboBoxEmployees;
        private ComboBox comboBoxKeys;
        private ComboBox comboBoxStatus;
    }
}