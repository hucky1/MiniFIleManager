namespace TextEditor.Interfaces
{
    interface IMessageSender
    {
        void ShowMessage(string message);
        void ShowExclamation(string message);
        void ShowError(string message);

    }
}
