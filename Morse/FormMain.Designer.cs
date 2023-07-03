namespace Morse
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveInFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.озвучитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelRussianKeyBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.radioButtonRussian = new System.Windows.Forms.RadioButton();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.flowLayoutPanelEnglishKeyBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip2.SuspendLayout();
            this.groupBoxLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(577, 149);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(400, 200);
            this.textBoxResult.TabIndex = 5;
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputText.Location = new System.Drawing.Point(12, 149);
            this.textBoxInputText.Multiline = true;
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputText.Size = new System.Drawing.Size(400, 200);
            this.textBoxInputText.TabIndex = 6;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.SaveInFileToolStripMenuItem,
            this.озвучитьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(989, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.openFileToolStripMenuItem.Text = "Открыть файл";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // SaveInFileToolStripMenuItem
            // 
            this.SaveInFileToolStripMenuItem.Name = "SaveInFileToolStripMenuItem";
            this.SaveInFileToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.SaveInFileToolStripMenuItem.Text = "Сохранить";
            this.SaveInFileToolStripMenuItem.Click += new System.EventHandler(this.SaveInFileToolStripMenuItem_Click);
            // 
            // озвучитьToolStripMenuItem
            // 
            this.озвучитьToolStripMenuItem.Name = "озвучитьToolStripMenuItem";
            this.озвучитьToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.озвучитьToolStripMenuItem.Text = "Озвучить";
            this.озвучитьToolStripMenuItem.Click += new System.EventHandler(this.VoiceOverToolStripMenuItem_Click);
            // 
            // flowLayoutPanelRussianKeyBoard
            // 
            this.flowLayoutPanelRussianKeyBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanelRussianKeyBoard.Location = new System.Drawing.Point(0, 379);
            this.flowLayoutPanelRussianKeyBoard.Name = "flowLayoutPanelRussianKeyBoard";
            this.flowLayoutPanelRussianKeyBoard.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.flowLayoutPanelRussianKeyBoard.Size = new System.Drawing.Size(989, 251);
            this.flowLayoutPanelRussianKeyBoard.TabIndex = 8;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(446, 198);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(100, 23);
            this.buttonEncode.TabIndex = 9;
            this.buttonEncode.Text = "Закодировать";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // radioButtonRussian
            // 
            this.radioButtonRussian.AutoSize = true;
            this.radioButtonRussian.Location = new System.Drawing.Point(18, 19);
            this.radioButtonRussian.Name = "radioButtonRussian";
            this.radioButtonRussian.Size = new System.Drawing.Size(73, 17);
            this.radioButtonRussian.TabIndex = 10;
            this.radioButtonRussian.TabStop = true;
            this.radioButtonRussian.Text = "Руссский";
            this.radioButtonRussian.UseVisualStyleBackColor = true;
            this.radioButtonRussian.CheckedChanged += new System.EventHandler(this.radioButtonRussian_CheckedChanged);
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Controls.Add(this.radioButtonEnglish);
            this.groupBoxLanguage.Controls.Add(this.radioButtonRussian);
            this.groupBoxLanguage.Location = new System.Drawing.Point(12, 44);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.Size = new System.Drawing.Size(175, 75);
            this.groupBoxLanguage.TabIndex = 11;
            this.groupBoxLanguage.TabStop = false;
            this.groupBoxLanguage.Text = "Язык(Language)";
            // 
            // radioButtonEnglish
            // 
            this.radioButtonEnglish.AutoSize = true;
            this.radioButtonEnglish.Location = new System.Drawing.Point(18, 52);
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEnglish.TabIndex = 11;
            this.radioButtonEnglish.TabStop = true;
            this.radioButtonEnglish.Text = "English";
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(446, 271);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(100, 23);
            this.buttonDecode.TabIndex = 12;
            this.buttonDecode.Text = "Раскодировать";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // flowLayoutPanelEnglishKeyBoard
            // 
            this.flowLayoutPanelEnglishKeyBoard.Location = new System.Drawing.Point(0, 391);
            this.flowLayoutPanelEnglishKeyBoard.Name = "flowLayoutPanelEnglishKeyBoard";
            this.flowLayoutPanelEnglishKeyBoard.Padding = new System.Windows.Forms.Padding(110, 0, 110, 0);
            this.flowLayoutPanelEnglishKeyBoard.Size = new System.Drawing.Size(989, 213);
            this.flowLayoutPanelEnglishKeyBoard.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 661);
            this.Controls.Add(this.flowLayoutPanelEnglishKeyBoard);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.groupBoxLanguage);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.flowLayoutPanelRussianKeyBoard);
            this.Controls.Add(this.textBoxInputText);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.menuStrip2);
            this.MinimumSize = new System.Drawing.Size(1005, 700);
            this.Name = "FormMain";
            this.Text = "Морзе";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBoxLanguage.ResumeLayout(false);
            this.groupBoxLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInputText;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveInFileToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRussianKeyBoard;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.RadioButton radioButtonRussian;
        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.RadioButton radioButtonEnglish;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEnglishKeyBoard;
        private System.Windows.Forms.ToolStripMenuItem озвучитьToolStripMenuItem;
    }
}

