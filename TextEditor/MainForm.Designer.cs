
namespace TextEditor
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.filePathTB = new System.Windows.Forms.TextBox();
            this.SelectFileBut = new System.Windows.Forms.Button();
            this.OpenFileBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numFont = new System.Windows.Forms.NumericUpDown();
            this.contentTB = new System.Windows.Forms.TextBox();
            this.SaveFileBut = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SymbolCountLbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл";
            // 
            // filePathTB
            // 
            this.filePathTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTB.Location = new System.Drawing.Point(111, 6);
            this.filePathTB.Name = "filePathTB";
            this.filePathTB.Size = new System.Drawing.Size(327, 23);
            this.filePathTB.TabIndex = 1;
            // 
            // SelectFileBut
            // 
            this.SelectFileBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFileBut.Location = new System.Drawing.Point(444, 7);
            this.SelectFileBut.Name = "SelectFileBut";
            this.SelectFileBut.Size = new System.Drawing.Size(75, 23);
            this.SelectFileBut.TabIndex = 2;
            this.SelectFileBut.Text = "Выбрать";
            this.SelectFileBut.UseVisualStyleBackColor = true;
            // 
            // OpenFileBut
            // 
            this.OpenFileBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileBut.Location = new System.Drawing.Point(525, 7);
            this.OpenFileBut.Name = "OpenFileBut";
            this.OpenFileBut.Size = new System.Drawing.Size(75, 23);
            this.OpenFileBut.TabIndex = 3;
            this.OpenFileBut.Text = "Открыть";
            this.OpenFileBut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шрифт";
            // 
            // numFont
            // 
            this.numFont.Location = new System.Drawing.Point(64, 54);
            this.numFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numFont.Name = "numFont";
            this.numFont.Size = new System.Drawing.Size(53, 23);
            this.numFont.TabIndex = 5;
            this.numFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // contentTB
            // 
            this.contentTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTB.Location = new System.Drawing.Point(12, 83);
            this.contentTB.Multiline = true;
            this.contentTB.Name = "contentTB";
            this.contentTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.contentTB.Size = new System.Drawing.Size(581, 316);
            this.contentTB.TabIndex = 6;
            // 
            // SaveFileBut
            // 
            this.SaveFileBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFileBut.Location = new System.Drawing.Point(525, 405);
            this.SaveFileBut.Name = "SaveFileBut";
            this.SaveFileBut.Size = new System.Drawing.Size(75, 23);
            this.SaveFileBut.TabIndex = 7;
            this.SaveFileBut.Text = "Сохранить";
            this.SaveFileBut.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SymbolCountLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(605, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "Количество символов";
            // 
            // SymbolCountLbl
            // 
            this.SymbolCountLbl.Name = "SymbolCountLbl";
            this.SymbolCountLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 454);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SaveFileBut);
            this.Controls.Add(this.contentTB);
            this.Controls.Add(this.numFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenFileBut);
            this.Controls.Add(this.SelectFileBut);
            this.Controls.Add(this.filePathTB);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePathTB;
        private System.Windows.Forms.Button SelectFileBut;
        private System.Windows.Forms.Button OpenFileBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFont;
        private System.Windows.Forms.TextBox contentTB;
        private System.Windows.Forms.Button SaveFileBut;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SymbolCountLbl;
    }
}

