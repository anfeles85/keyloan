namespace KeyLoan.views
{
    partial class FormKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeys));
            pictureBoxHome = new PictureBox();
            labelTitle = new Label();
            dataGridViewKeys = new DataGridView();
            labelId = new Label();
            labelName = new Label();
            labelRoom = new Label();
            labelCount = new Label();
            labelObservation = new Label();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            textBoxRoom = new TextBox();
            textBoxCount = new TextBox();
            textBoxObservation = new TextBox();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeys).BeginInit();
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
            labelTitle.Location = new Point(563, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(70, 28);
            labelTitle.TabIndex = 18;
            labelTitle.Text = "Llaves";
            // 
            // dataGridViewKeys
            // 
            dataGridViewKeys.AllowUserToAddRows = false;
            dataGridViewKeys.AllowUserToDeleteRows = false;
            dataGridViewKeys.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewKeys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKeys.Location = new Point(56, 279);
            dataGridViewKeys.MultiSelect = false;
            dataGridViewKeys.Name = "dataGridViewKeys";
            dataGridViewKeys.RowHeadersWidth = 51;
            dataGridViewKeys.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKeys.Size = new Size(1064, 188);
            dataGridViewKeys.TabIndex = 19;
            dataGridViewKeys.CellClick += dataGridViewKeys_CellClick;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelId.Location = new Point(56, 80);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 20);
            labelId.TabIndex = 20;
            labelId.Text = "Id:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelName.Location = new Point(354, 80);
            labelName.Name = "labelName";
            labelName.Size = new Size(71, 20);
            labelName.TabIndex = 21;
            labelName.Text = "Nombre:";
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelRoom.Location = new Point(797, 80);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(45, 20);
            labelRoom.TabIndex = 22;
            labelRoom.Text = "Aula:";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCount.Location = new Point(56, 141);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(75, 20);
            labelCount.TabIndex = 23;
            labelCount.Text = "Cantidad:";
            // 
            // labelObservation
            // 
            labelObservation.AutoSize = true;
            labelObservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelObservation.Location = new Point(354, 141);
            labelObservation.Name = "labelObservation";
            labelObservation.Size = new Size(99, 20);
            labelObservation.TabIndex = 24;
            labelObservation.Text = "Observation:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(154, 77);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 25;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(474, 77);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(277, 27);
            textBoxName.TabIndex = 26;
            // 
            // textBoxRoom
            // 
            textBoxRoom.Location = new Point(891, 77);
            textBoxRoom.Name = "textBoxRoom";
            textBoxRoom.Size = new Size(229, 27);
            textBoxRoom.TabIndex = 27;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(154, 134);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(125, 27);
            textBoxCount.TabIndex = 28;
            // 
            // textBoxObservation
            // 
            textBoxObservation.Location = new Point(474, 134);
            textBoxObservation.Name = "textBoxObservation";
            textBoxObservation.Size = new Size(646, 27);
            textBoxObservation.TabIndex = 29;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.Highlight;
            buttonClear.ForeColor = SystemColors.ButtonHighlight;
            buttonClear.Location = new Point(765, 205);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 33;
            buttonClear.Text = "Limpiar";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.Highlight;
            buttonDelete.Enabled = false;
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(610, 205);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 32;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.Highlight;
            buttonUpdate.Enabled = false;
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(460, 205);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 31;
            buttonUpdate.Text = "Modificar";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.BackColor = SystemColors.Highlight;
            buttonInsert.ForeColor = SystemColors.ButtonHighlight;
            buttonInsert.Location = new Point(311, 205);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 30;
            buttonInsert.Text = "Crear";
            buttonInsert.UseVisualStyleBackColor = false;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // FormKeys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 499);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Controls.Add(textBoxObservation);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxRoom);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(labelObservation);
            Controls.Add(labelCount);
            Controls.Add(labelRoom);
            Controls.Add(labelName);
            Controls.Add(labelId);
            Controls.Add(dataGridViewKeys);
            Controls.Add(labelTitle);
            Controls.Add(pictureBoxHome);
            Name = "FormKeys";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Llaves";
            FormClosed += FormKeys_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeys).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxHome;
        private Label labelTitle;
        private DataGridView dataGridViewKeys;
        private Label labelId;
        private Label labelName;
        private Label labelRoom;
        private Label labelCount;
        private Label labelObservation;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxRoom;
        private TextBox textBoxCount;
        private TextBox textBoxObservation;
        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonInsert;
    }
}