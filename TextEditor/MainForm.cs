using System;
using System.Windows.Forms;
using TextEditor.Interfaces;

namespace TextEditor
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            OpenFileBut.Click += OpenFileBut_Click;
            SaveFileBut.Click += SaveFileBut_Click;
            contentTB.TextChanged += ContentTB_TextChanged;
            SelectFileBut.Click += SelectFileBut_Click;
            numFont.ValueChanged += NumFont_ValueChanged;
        }

        private void NumFont_ValueChanged(object sender, EventArgs e)=>
            contentTB.Font =  new("Calibri", (float)numFont.Value);
        

        private void SelectFileBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePathTB.Text = dlg.FileName;
                FileOpenCLick?.Invoke(this, EventArgs.Empty);
            }

        }


        #region Events
        private void ContentTB_TextChanged(object sender, EventArgs e)
        {
            ContentChanged?.Invoke(this, EventArgs.Empty);
         }

        private void SaveFileBut_Click(object sender, EventArgs e)
        {
            FileSaveClick?.Invoke(this, EventArgs.Empty);
        }

        private void OpenFileBut_Click(object sender, EventArgs e)
        {
            FileOpenCLick?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region IMainForm   
        public string FilePath => filePathTB.Text;
        public string Content
        {
            get => contentTB.Text;
            set { contentTB.Text = value; }
        }

        public event EventHandler FileOpenCLick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;

        public void SetSembolCount(int count) =>
            SymbolCountLbl.Text = count.ToString();
        #endregion

        
    }
}
