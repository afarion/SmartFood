using SmartFood.Core.Constants;
using System.Windows.Forms;

namespace SmartFood.Forms
{
    public static class ErrorsViewWrapper
    {
        public static void ShowError(string text, string caption = ErrorTexts.ERROR)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
