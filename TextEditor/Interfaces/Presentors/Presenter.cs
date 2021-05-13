using TextEditor.Interfaces;
using TextEditorModels.Interfaces;
using System;

namespace TextEditor.Presentors
{
    class Presenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly IMessageSender _messageSender;
        private string _currentFilePath;
        public Presenter(IMainForm view, IFileManager manager, IMessageSender service)
        {
            _view = view;
            _manager = manager;
            _messageSender = service;

            _view.SetSembolCount(0);
            _view.ContentChanged += _view_ContentChanged;
            _view.FileOpenCLick += _view_FileOpenCLick;
            _view.FileSaveClick += _view_FileSaveClick;
            
        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                _manager.SaveContent(_view.Content, _currentFilePath);
                _messageSender.ShowMessage("Файл успешно сохранён");
            }
            catch (Exception ex)
            {
                _messageSender.ShowError(ex.Message);
            }
            
        }

        private void _view_FileOpenCLick(object sender, System.EventArgs e)
        {
            string filePath = _view.FilePath;
            try
            {
                if (!_manager.IsExists(filePath))
                {
                    _messageSender.ShowExclamation("Выбранного файла не существует!");
                    return;
                }
                _currentFilePath = filePath;
                string content = _manager.GetContent(filePath);
                _view.Content = content;
                _view.SetSembolCount(_manager.GetSymbolCount(content));
            }
            catch(Exception ex)
            {
                _messageSender.ShowError(ex.Message);
            }
        }

        private void _view_ContentChanged(object sender, System.EventArgs e) =>
            _view.SetSembolCount(_manager.GetSymbolCount(_view.Content));
    }
}
