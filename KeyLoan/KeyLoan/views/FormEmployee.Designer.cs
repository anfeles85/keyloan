namespace KeyLoan.views
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            dataGridViewEmployees = new DataGridView();
            label1 = new Label();
            textBoxDocument = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxAddress = new TextBox();
            label4 = new Label();
            textBoxPhone = new TextBox();
            label5 = new Label();
            comboBoxType = new ComboBox();
            buttonInsert = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            labelTitle = new Label();
            pictureBoxHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(40, 249);
            dataGridViewEmployees.MultiSelect = false;
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(1090, 238);
            dataGridViewEmployees.TabIndex = 0;
            dataGridViewEmployees.CellClick += dataGridViewEmployees_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 82);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Documento:";
            // 
            // textBoxDocument
            // 
            textBoxDocument.Location = new Point(159, 79);
            textBoxDocument.Name = "textBoxDocument";
            textBoxDocument.Size = new Size(216, 27);
            textBoxDocument.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(424, 82);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(535, 79);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 27);
            textBoxName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(817, 82);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "Dirección:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(917, 79);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(213, 27);
            textBoxAddress.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(40, 142);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Teléfono:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(159, 138);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(216, 27);
            textBoxPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(424, 142);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 9;
            label5.Text = "Tipo:";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(535, 137);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(250, 28);
            comboBoxType.TabIndex = 10;
            // 
            // buttonInsert
            // 
            buttonInsert.BackColor = SystemColors.Highlight;
            buttonInsert.ForeColor = SystemColors.ButtonHighlight;
            buttonInsert.Location = new Point(307, 197);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 11;
            buttonInsert.Text = "Crear";
            buttonInsert.UseVisualStyleBackColor = false;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.Highlight;
            buttonUpdate.Enabled = false;
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(456, 197);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Modificar";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.Highlight;
            buttonDelete.Enabled = false;
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(606, 197);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.Highlight;
            buttonClear.ForeColor = SystemColors.ButtonHighlight;
            buttonClear.Location = new Point(761, 197);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Limpiar";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(535, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(114, 28);
            labelTitle.TabIndex = 15;
            labelTitle.Text = "Empleados";
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Cursor = Cursors.Hand;
            pictureBoxHome.Image = (Image)resources.GetObject("pictureBoxHome.Image");
            pictureBoxHome.Location = new Point(22, 12);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(37, 31);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex = 16;
            pictureBoxHome.TabStop = false;
            pictureBoxHome.Click += pictureBoxHome_Click;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 499);
            Controls.Add(pictureBoxHome);
            Controls.Add(labelTitle);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Controls.Add(comboBoxType);
            Controls.Add(label5);
            Controls.Add(textBoxPhone);
            Controls.Add(label4);
            Controls.Add(textBoxAddress);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxDocument);
            Controls.Add(label1);
            Controls.Add(dataGridViewEmployees);
            Name = "FormEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            FormClosed += FormEmployee_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private Label label1;
        private TextBox textBoxDocument;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxAddress;
        private Label label4;
        private TextBox textBoxPhone;
        private Label label5;
        private ComboBox comboBoxType;
        private Button buttonInsert;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClear;
        private Label labelTitle;
        private PictureBox pictureBoxHome;
    }
}