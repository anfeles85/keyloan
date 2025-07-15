namespace KeyLoan
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelEmployees = new Label();
            labelKeys = new Label();
            labelRecords = new Label();
            labelClose = new Label();
            pictureBoxI = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxI).BeginInit();
            SuspendLayout();
            // 
            // labelEmployees
            // 
            labelEmployees.AutoSize = true;
            labelEmployees.BackColor = Color.White;
            labelEmployees.Cursor = Cursors.Hand;
            labelEmployees.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelEmployees.ForeColor = SystemColors.Highlight;
            labelEmployees.Location = new Point(49, 49);
            labelEmployees.Name = "labelEmployees";
            labelEmployees.Size = new Size(138, 32);
            labelEmployees.TabIndex = 0;
            labelEmployees.Text = "Empleados";
            labelEmployees.TextAlign = ContentAlignment.MiddleCenter;
            labelEmployees.Click += labelEmployees_Click;
            // 
            // labelKeys
            // 
            labelKeys.BackColor = Color.White;
            labelKeys.Cursor = Cursors.Hand;
            labelKeys.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelKeys.ForeColor = SystemColors.Highlight;
            labelKeys.Location = new Point(49, 140);
            labelKeys.Name = "labelKeys";
            labelKeys.Size = new Size(138, 32);
            labelKeys.TabIndex = 1;
            labelKeys.Text = "Llaves";
            labelKeys.TextAlign = ContentAlignment.MiddleCenter;
            labelKeys.Click += labelKeys_Click;
            // 
            // labelRecords
            // 
            labelRecords.BackColor = Color.White;
            labelRecords.Cursor = Cursors.Hand;
            labelRecords.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelRecords.ForeColor = SystemColors.Highlight;
            labelRecords.Location = new Point(49, 242);
            labelRecords.Name = "labelRecords";
            labelRecords.Size = new Size(138, 32);
            labelRecords.TabIndex = 2;
            labelRecords.Text = "Registros";
            labelRecords.TextAlign = ContentAlignment.MiddleCenter;
            labelRecords.Click += labelRecords_Click;
            // 
            // labelClose
            // 
            labelClose.BackColor = Color.White;
            labelClose.Cursor = Cursors.Hand;
            labelClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelClose.ForeColor = SystemColors.Highlight;
            labelClose.Location = new Point(49, 348);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(138, 32);
            labelClose.TabIndex = 3;
            labelClose.Text = "Salir";
            labelClose.TextAlign = ContentAlignment.MiddleCenter;
            labelClose.Click += labelClose_Click;
            // 
            // pictureBoxI
            // 
            pictureBoxI.Image = (Image)resources.GetObject("pictureBoxI.Image");
            pictureBoxI.Location = new Point(336, 49);
            pictureBoxI.Name = "pictureBoxI";
            pictureBoxI.Size = new Size(384, 331);
            pictureBoxI.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxI.TabIndex = 4;
            pictureBoxI.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxI);
            Controls.Add(labelClose);
            Controls.Add(labelRecords);
            Controls.Add(labelKeys);
            Controls.Add(labelEmployees);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KeyLoan";
            FormClosed += FormMain_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBoxI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmployees;
        private Label labelKeys;
        private Label labelRecords;
        private Label labelClose;
        private PictureBox pictureBoxI;
    }
}
