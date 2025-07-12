using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLoan.utils
{
    internal class MessageUtils
    {
        public static void showInfoMessage(string message)
        {
            MessageBox.Show(message, "Información", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        public static void showErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void showWarningMessage(string message)
        {
            MessageBox.Show(message, "Advertencia", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        }
    }
}
