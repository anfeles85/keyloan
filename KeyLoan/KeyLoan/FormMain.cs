using KeyLoan.views;

namespace KeyLoan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelEmployees_Click(object sender, EventArgs e)
        {
            new FormEmployee().Show();
            Close();
        }

        private void labelRecords_Click(object sender, EventArgs e)
        {
            new FormRecord().Show();
            Close();
        }

        private void labelKeys_Click(object sender, EventArgs e)
        {
            new FormKeys().Show();
            Close();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
