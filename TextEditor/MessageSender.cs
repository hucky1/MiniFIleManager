using System.Windows.Forms;
using TextEditor.Interfaces;

namespace TextEditor
{
    class MessageSender : IMessageSender
    {
        public void ShowMessage(string message) =>
            MessageBox.Show(message, "Собщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public void ShowExclamation(string exclamation) =>
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        public void ShowError(string error) =>
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
