using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Morse
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Создает кнопку с заданнным текстом и шрифтом и добавляет на панель
        /// </summary>
        /// <param name="text">текст кнопки</param>
        /// <param name="panel">куда добавлять</param>
        /// <param name="font">шрифт</param>
        public void MakeButton(string text, FlowLayoutPanel panel, Font font = null)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Height = 50;
            btn.Width = 50;
            btn.BackColor = Color.FromArgb(255, 250, 250);
            if (font != null) btn.Font = font;
            btn.Click += new System.EventHandler(btnLetter_Click);
            panel.Controls.Add(btn);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 228, 225);
            radioButtonRussian.Checked = true;

            for (int i = 0; i < 26; i++) // Английский алфавит
            {
                MakeButton(((char)('A' + i)).ToString(), flowLayoutPanelEnglishKeyBoard);
            }
            for (int i = 0; i < 32; i++) // Русский алфавит
            {
                MakeButton(((char)('А' + i)).ToString(), flowLayoutPanelRussianKeyBoard);
            }
            for (int i = 0; i < 10; i++) // Цифры
            {
                MakeButton(i.ToString(), flowLayoutPanelEnglishKeyBoard);
                MakeButton(i.ToString(), flowLayoutPanelRussianKeyBoard);
            }
            Font font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            foreach (var item in new string[] { ".", "-" })
            {
                MakeButton(item, flowLayoutPanelEnglishKeyBoard, font);
                MakeButton(item, flowLayoutPanelRussianKeyBoard, font);
            }
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            textBoxInputText.Text += (sender as Button).Text;
        }
        /// <summary>
        /// Возвращает язык исходя из положения переключателя radioButtonEnglish
        /// </summary>
        /// <returns></returns>
        public Languages GetLanguage()
        {
            if (radioButtonEnglish.Checked) return Languages.English;
            return Languages.Russian;
        }
        // Кодируем
        private void buttonEncode_Click(object sender, EventArgs e)
        {
            string resultString = "";
            string[] words = textBoxInputText.Text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                foreach (var letter in word)
                {
                    resultString += ClassMorse.ConvertToMorse(letter, GetLanguage()) + " ";
                }
                resultString += "  ";//2 пробела
            }
            textBoxResult.Text = resultString;
        }
        //Раскодируем
        private void buttonDecode_Click(object sender, EventArgs e)
        {
            string resultString = "";
            string[] words = textBoxInputText.Text.Split(new string[] { "   ", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);// 3 пробела
            foreach (var word in words)
            {
                var temp = word.Split(' ');
                foreach (var letter in temp)
                {
                    resultString += ClassMorse.ConvertFromMorse(letter, GetLanguage());
                }
                resultString += " ";
            }
            textBoxResult.Text = resultString;
        }
        //открытие текстового файла
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\";// Environment.CurrentDirectory + @"\..\..";
                openFileDialog.Filter = "Text files (*.txt)|*.txt |Word files (*.doc;*.docx)|*.doc;*.docx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Выберите файл";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    using (StreamReader file = new StreamReader(path))
                    {
                        string text = file.ReadToEnd();
                        textBoxInputText.Text = text;
                    }
                }
            }
        }
        // сохранение в текстовый файл
        private void SaveInFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\";// Environment.CurrentDirectory + @"\..\..";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt |Word files (*.doc;*.docx)|*.doc;*.docx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Выберите местоположение";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;

                    using (StreamWriter file = new StreamWriter(path))
                    {
                        file.Write(textBoxResult.Text);
                        MessageBox.Show("Сохранено");
                    }
                }
            }

        }

        private void radioButtonRussian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRussian.Checked)
            {
                flowLayoutPanelRussianKeyBoard.Show();
                flowLayoutPanelEnglishKeyBoard.Hide();
            }
            else
            {
                flowLayoutPanelRussianKeyBoard.Hide();
                flowLayoutPanelEnglishKeyBoard.Show();
            }
        }
        /// <summary>
        /// Мелодия "В траве сидел кузнечик"
        /// </summary>
        private void Grasshoper()
        {
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(415, 300);
            Thread.Sleep(600);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 300);
            Console.Beep(440, 300);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(494, 300);
            Console.Beep(494, 100);
            Console.Beep(494, 100);
            Console.Beep(494, 300);
            Console.Beep(494, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 100);
            Console.Beep(523, 100);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(494, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 800);
        }

        private void VoiceOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var letter in textBoxResult.Text)
            {
                if (letter == '.') Console.Beep(400, 300);
                else if (letter == '-') Console.Beep(400, 600);
                else if (letter == ' ') Thread.Sleep(300);
            }
        }
    }
}
