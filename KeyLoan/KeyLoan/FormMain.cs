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
            Dispose();
        }

        private void labelRecords_Click(object sender, EventArgs e)
        {
            new FormRecord().Show();
            Dispose();
        }

        private void labelKeys_Click(object sender, EventArgs e)
        {
            new FormKeys().Show();
            Dispose();
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
