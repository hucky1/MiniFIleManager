using System;

namespace TextEditor.Interfaces
{
    interface IMainForm
    {
        public string FilePath { get; }
        public string Content { get; set; }
        void SetSembolCount(int count);
        event EventHandler FileOpenCLick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }
}
